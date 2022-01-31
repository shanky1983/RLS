using System;
using System.Threading.Tasks;
using Attune.KernelV2.Entities;
using Attune.KernelV2.Utilities;
using Microsoft.Owin.Security.Infrastructure;


namespace Attune.KernelV2.Providers
{
    public class RefreshTokenProvider : IAuthenticationTokenProvider
    {

        public async Task CreateAsync(AuthenticationTokenCreateContext context)
        {
            var clientid = context.Ticket.Properties.Dictionary["as:client_id"];
            bool isrefresh;
            bool.TryParse(context.Ticket.Properties.Dictionary["isrefresh"],out isrefresh);
            if (!isrefresh)
            {
                return;
            }

            if (string.IsNullOrEmpty(clientid))
            {
                return;
            }

            var refreshTokenId = Guid.NewGuid().ToString("n");

              
            using (AuthRepository _repo = new AuthRepository())
                
            {
                var refreshTokenLifeTime = context.OwinContext.Get<string>("as:clientRefreshTokenLifeTime");
                var subject = context.Ticket.Identity.Name.Split(new[] { "||" }, StringSplitOptions.RemoveEmptyEntries);
                if (subject.Length > 1)
                {
                    var token = new RefreshTokens
                    {
                        Id = Helper.GetHash(refreshTokenId),
                        ClientId = clientid,
                        Subject = subject[0],
                        IssuedUtc = DateTime.UtcNow,
                        ExpiresUtc = DateTime.UtcNow.AddHours(Convert.ToDouble(refreshTokenLifeTime))
                    };

                    context.Ticket.Properties.IssuedUtc = token.IssuedUtc;
                    context.Ticket.Properties.ExpiresUtc = token.ExpiresUtc;

                    token.ProtectedTicket = context.SerializeTicket();

                    var result = await _repo.AddRefreshToken(token);

                    if (result)
                    {
                        context.SetToken(refreshTokenId);
                    }
                }


            }
        }

        public async Task ReceiveAsync(AuthenticationTokenReceiveContext context)
        {

            context.OwinContext.Get<string>("as:clientAllowedOrigin");
            // context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { allowedOrigin });

            string hashedTokenId = Helper.GetHash(context.Token);

            using (AuthRepository _repo = new AuthRepository())
            {
                var refreshToken = await _repo.FindRefreshToken(hashedTokenId);

                if (refreshToken != null)
                {
                    //Get protectedTicket from refreshToken class
                    context.DeserializeTicket(refreshToken.ProtectedTicket);
                     await _repo.RemoveRefreshToken(hashedTokenId);
                }
            }
        }

        public void Create(AuthenticationTokenCreateContext context)
        {
            throw new NotImplementedException();
        }

        public void Receive(AuthenticationTokenReceiveContext context)
        {
            throw new NotImplementedException();
        }
    }
}