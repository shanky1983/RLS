using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Attune.Cryptography;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;


namespace Attune.KernelV2.Providers
{

    public class AuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {

            string clientId;
            string clientSecret;
            VendorOrgMapping client = null;
            IntegrationTypeMaster appType;

            if (!context.TryGetBasicCredentials(out clientId, out clientSecret))
            {
                context.TryGetFormCredentials(out clientId, out clientSecret);
            }

            //if (context.ClientId == null || clientSecret == null)
            //{
            //    //Remove the comments from the below line context.SetError, and invalidate context 
            //    //if you want to force sending clientId/secrects once obtain access tokens. 
            //    context.Validated();
            //    //context.SetError("invalid_clientId", "ClientId should be sent.");
            //    return Task.FromResult<object>(null);
            //}

            using (AuthRepository _repo = new AuthRepository())
            {
                appType = _repo.FindApp(context.ClientId);
                if (appType == null)
                {

                    throw new AuthorizationException(string.Format("Client '{0}' is not registered in the system.", context.ClientId));

                }
                string decryptedString = DecryptValue(clientSecret, appType.PrivateKey);
                string[] ClientName = decryptedString.Split(new[] { "||" }, StringSplitOptions.RemoveEmptyEntries);
                if (ClientName.Length > 0)
                {
                    client = _repo.FindClient(ClientName[0]);
                }
             

            }

            if (client == null)
            {
                context.SetError("invalid_clientId", string.Format("Client '{0}' is not registered in the system.", context.ClientId));
                return Task.FromResult<object>(null);
            }

            if (!client.Status)
            {
                context.SetError("invalid_clientId", "Client is inactive.");
                return Task.FromResult<object>(null);
            }

            context.Options.AccessTokenExpireTimeSpan = TimeSpan.FromHours(client.SessionTokenLifeTime?? 15);
            context.OwinContext.Set("as:clientAllowedOrigin", client.AllowedOrigin);
            context.OwinContext.Set("as:RoleName", client.RoleName);
            context.OwinContext.Set("as:UniqueKey", Convert.ToString(client.UniqueKey));
            context.OwinContext.Set("as:partnerType", client.PartnerType);
            context.OwinContext.Set("as:privateKey", appType.PrivateKey);
            context.OwinContext.Set("as:requiredrefreshToken", client.RequiredRefreshToken.ToString());
            context.OwinContext.Set("as:clientRefreshTokenLifeTime", TimeSpan.FromHours(client.RefreshTokenLifeTime ==0 ? 30: client.RefreshTokenLifeTime).TotalSeconds.ToString());
            context.Validated();
            return Task.FromResult<object>(null);
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {

            var allowedOrigin = context.OwinContext.Get<string>("as:clientAllowedOrigin");
            var partnerType = context.OwinContext.Get<string>("as:partnerType");
            var privateKey = context.OwinContext.Get<string>("as:privateKey");
            var rolename = context.OwinContext.Get<string>("as:RoleName");
            if (allowedOrigin == null)
            {
            }


            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            string loginName = "";
            if (partnerType == "Internal")
            {
                LoggedInUsers user;
                string decryptedString;
                if (string.IsNullOrEmpty(context.UserName.Trim()))
                {
                    decryptedString = DecryptValue(context.Password, privateKey);
                    using (AuthRepository _repo = new AuthRepository())
                    {

                        user = await _repo.FindUser(decryptedString,"");

                        if (user == null)
                        {
                            context.SetError("invalid_grant", "The user name or password is incorrect.");
                            return;
                        }
                    }
                }
                else
                {
                    using (AuthRepository _repo = new AuthRepository())
                    {
                        string ipAdd = context.Request.LocalIpAddress;
                        string userAgent = ((OwinRequest)context.Request).Headers.Get("User-Agent");
                        user = await _repo.FindUser(context.UserName.Trim(), EncryptePassword(context.Password.Trim()), ipAdd, userAgent, rolename);
                        decryptedString = (user.UniqueKey.ToString());
                         
                        if (user == null)
                        {
                            context.SetError("invalid_grant", "The user name or password is incorrect.");
                            return;
                        }
                    }
                }

                loginName = user.LoginName ?? "";
                identity.AddClaim(new Claim(ClaimTypes.Name, decryptedString + "||Internal"));
                identity.AddClaim(new Claim(ClaimTypes.Role, "user"));
                identity.AddClaim(new Claim(ClaimTypes.System, partnerType));
                identity.AddClaim(new Claim("sub", user.LoginID.ToString()));
            }
            else if (partnerType == "External")
            {
                var UniqueKey = context.OwinContext.Get<string>("as:UniqueKey");

                identity.AddClaim(new Claim(ClaimTypes.Name, UniqueKey + "||External"));
                identity.AddClaim(new Claim(ClaimTypes.Role, "Partner"));
                identity.AddClaim(new Claim(ClaimTypes.System, partnerType));
            }

            var props = new AuthenticationProperties(new Dictionary<string, string>
                {
                    {
                        "as:client_id", (context.ClientId == null) ? string.Empty : context.ClientId
                    },
                    {
                        "userName",loginName
                    },
                    {
                        "isrefresh",context.OwinContext.Get<string>("as:requiredrefreshToken")==null?"false":context.OwinContext.Get<string>("as:requiredrefreshToken")
                    }
                     //context.OwinContext.Set<string>("as:requiredrefreshToken", client.RequiredRefreshToken.ToString());
                });

            var ticket = new AuthenticationTicket(identity, props);
            context.Validated(ticket);

        }

        public override Task GrantRefreshToken(OAuthGrantRefreshTokenContext context)
        {
            var originalClient = context.Ticket.Properties.Dictionary["as:client_id"];
            var currentClient = context.ClientId;

            if (originalClient != currentClient)
            {
                context.SetError("invalid_clientId", "Refresh token is issued to a different clientId.");
                return Task.FromResult<object>(null);
            }

            // Change auth ticket for refresh token requests
            var newIdentity = new ClaimsIdentity(context.Ticket.Identity);

            var newClaim = newIdentity.Claims.Where(c => c.Type == "newClaim").FirstOrDefault();
            if (newClaim != null)
            {
                newIdentity.RemoveClaim(newClaim);
            }
            newIdentity.AddClaim(new Claim("newClaim", "newValue"));

            var newTicket = new AuthenticationTicket(newIdentity, context.Ticket.Properties);
            context.Validated(newTicket);

            return Task.FromResult<object>(null);
        }

        public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        {
            foreach (KeyValuePair<string, string> property in context.Properties.Dictionary)
            {
                context.AdditionalResponseParameters.Add(property.Key, property.Value);
            }

            return Task.FromResult<object>(null);
        }
        public string DecryptValue(string encryptstring, string key)
        {
            string decryptedString = null;
            if (!string.IsNullOrEmpty(encryptstring))
            {

                RSACryptography obj = new RSACryptFactory().GetDecryptor();
                encryptstring = Uri.UnescapeDataString(encryptstring);
                obj.Crypt(encryptstring, key, out decryptedString);

            }

            return (decryptedString);
        }

       private string EncryptePassword(string password)
        {
            CCryptography obj = new CCryptFactory().GetEncryptor();
            obj.Crypt(password, out password);
            return password;
        }


    }

}
