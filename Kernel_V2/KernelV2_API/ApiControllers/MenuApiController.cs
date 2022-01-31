using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Attune.KernelV2.BL;
using Attune.KernelV2.Entities;
using Attune.KernelV2.Providers;

namespace Attune.KernelV2.API
{

    public class MenuApiController : BaseApiController
    {
        [Route("api/v1/menu")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            List<UI_Alacarte> lstMenu ;
            try
            {
                using (Master_BL BL = new Master_BL(ContextDetails))
                {
                    lstMenu = (BL.GetAllMenuItems(ContextDetails.OrgID, ContextDetails.LanguageCode, ContextDetails.RoleID, ContextDetails.InventoryLocationID)).ToList();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstMenu);
        }         
    }
}