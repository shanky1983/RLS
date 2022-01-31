using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Web.Http;
using System.Web.Http.Controllers;


namespace Attune.KernelV2.Providers
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class AuthorizeAttributeExtended : AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {

            var plit = base.IsAuthorized(actionContext);
            if (plit)
            {
                var user = actionContext.ControllerContext.RequestContext.Principal;
                string[] name = user.Identity.Name.Split(new[] { "||" }, StringSplitOptions.RemoveEmptyEntries);
                var partnerType = name.Length > 1 ? name[1] : "Internal";
                if (partnerType == "Internal")
                {
                    using (AuthRepository _repo = new AuthRepository())
                    {

                        var loggedUser = _repo.FindUser(name[0]).Result;
                        if (loggedUser == null)
                        {
                            return false;
                        }

                        List<Claim> claims = new List<Claim>()
                       {new Claim(ClaimTypes.Surname, JsonConvert.SerializeObject(loggedUser)),
                       {new Claim(ClaimTypes.Name, user.Identity.Name) }};

                        ClaimsIdentity identity = new ClaimsIdentity(claims, "basic");
                        actionContext.ControllerContext.RequestContext.Principal = new ClaimsPrincipal(new[] { identity });
                        return true;

                    }
                }
                else
                {
                    using (AuthRepository _repo = new AuthRepository())
                    {
                        var loggedUser = _repo.GetClientDtls(name[0]);
                        if (loggedUser == null)
                        {
                            return false;
                        }

                    }
                }

            }
            return plit;


        }




    }

}