using System;
using System.Web.Http;
using Attune.KernelV2.BL;
using Attune.KernelV2.Entities;
using Attune.KernelV2.Providers;

namespace Attune.KernelV2.API.ApiControllers.PlatForm
{
    public class ProfileApiController : BaseApiController
    {
        [Route("api/v1/profile")]
        [HttpGet]
        public IHttpActionResult get()
        {
            UI_ProfileInfo oProfileInfo ;
            try
            {
                using (UserProfile_BL BL = new UserProfile_BL(ContextDetails))
                {
                    oProfileInfo = BL.GetPrivilegeDetails(ContextDetails.OrgID, ContextDetails.LoginID, ContextDetails.LanguageCode);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(oProfileInfo);
        }

        [HttpPut]
        [Route("api/v1/profile")]
        public IHttpActionResult put([FromBody]UI_Profile oProfile)
        {
            UI_Alacarte oAlacarte ;
            try
            {
                using (Master_BL BL = new Master_BL(ContextDetails))
                {
                    updateProfile(oProfile.OrgID, oProfile.AddressID, oProfile.RoleID);
                    oAlacarte = BL.GetLandingPage(oProfile.RoleID);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(oAlacarte);

        }
    }
}
