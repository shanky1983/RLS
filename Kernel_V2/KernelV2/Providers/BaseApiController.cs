using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using Attune.KernelV2.Entities;
using Attune.KernelV2.Utilities;
using System.Security.Claims;
using Newtonsoft.Json;

namespace Attune.KernelV2.Providers
{
    [AuthorizeAttributeExtended]
   
    public class BaseApiController : ApiController
    {
        private UI_ContextDetails _CurrentUser ;
            

        public UI_ContextDetails ContextDetails
        {
            get
            {
                if (User.Identity.IsAuthenticated  && _CurrentUser==null)
                {
                    string[] name = User.Identity.Name.Split(new[] { "||" }, StringSplitOptions.RemoveEmptyEntries);
                    string partnerType;
                    if (name.Length > 1)
                    {
                        partnerType = name[1];
                    }
                    else
                    {
                        partnerType = "Internal";
                    }
                    using (AuthRepository _repo = new AuthRepository())
                    {
                        if (partnerType == "Internal")
                        {
                            //_CurrentUser = _repo.FindUser(name[0]).Result;

                            var claimsIdentity = (ClaimsIdentity)this.RequestContext.Principal.Identity;

                            foreach (var claim in claimsIdentity.Claims)
                            {
                                if (claim.Type == ClaimTypes.Surname)
                                    _CurrentUser = JsonConvert.DeserializeObject< UI_ContextDetails>(claim.Value);
                                break;
                            }

                        }
                        else
                        {
                            _CurrentUser = _repo.GetClientDtls(name[0]);
                        }
                    }

                }
                
                return _CurrentUser;
            }
        }
       
        public IList<VendorLocationMpping> GetLocation()
        {
            IList < VendorLocationMpping > lst = null;
            if (User.Identity.IsAuthenticated && _CurrentUser == null)
            {
                string[] name = User.Identity.Name.Split(new[] { "||" }, StringSplitOptions.RemoveEmptyEntries);
                using (AuthRepository _repo = new AuthRepository())
                {
                    lst =_repo.GetLocation(name[0]);
                }
            }
            return lst;
        }

        public UI_ContextDetails GetLocationById(Guid AttGuId,bool?IsAuthenticated=true)
        {
            LoggedInUsers oLoggedInUsers;


            if (User.Identity.IsAuthenticated && _CurrentUser == null && IsAuthenticated==true)
            {
                using (AuthRepository _repo = new AuthRepository())
                {
                    oLoggedInUsers = _repo.GetLocationById(AttGuId);
                }
            }
            else
            {
                using (AuthRepository _repo = new AuthRepository())
                {
                    oLoggedInUsers = _repo.GetLocationById(AttGuId);
                }
            }
            if (oLoggedInUsers != null)
            {
                var ctx = new UI_ContextDetails();
                ctx.LoginID = oLoggedInUsers.LoginID;
                if (oLoggedInUsers.RoleID != null) ctx.RoleID = (int) oLoggedInUsers.RoleID;
                ctx.LanguageCode = "en-GB";
                if (oLoggedInUsers.OrgID != null) ctx.OrgID = (int) oLoggedInUsers.OrgID;
                ctx.InventoryLocationID = oLoggedInUsers.InventoryLocationID == null ? 0 : (int)oLoggedInUsers.InventoryLocationID;
                ctx.LocationID = oLoggedInUsers.OrgAddressID;
                ctx.OrgAddressID = oLoggedInUsers.OrgAddressID;
                return ctx;
            }
            return null;
        }
        public bool updateProfile(int pOrgId, long pAddressID, long pRoleID)
        {
            using (AuthRepository _repo = new AuthRepository())
            {
                return _repo.updateProfile(ContextDetails, pOrgId, pAddressID, pRoleID);
            }
        }



        protected HttpStatusCode ToHttpStatusCode(Exception ex)
        {
            CLogger.LogError("Error in Api", ex);
            if (ex is UnauthorizedAccessException)
                return HttpStatusCode.Unauthorized;

            return HttpStatusCode.InternalServerError;
        }

    }
   
}
