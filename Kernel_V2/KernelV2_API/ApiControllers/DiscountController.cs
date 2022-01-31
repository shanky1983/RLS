using System;
using System.Collections.Generic;
using System.Web.Http;
using Attune.KernelV2.BL;
using Attune.KernelV2.Entities;
using Attune.KernelV2.Providers;

namespace Attune.KernelV2.API.ApiControllers
{
    public class DiscountController : BaseApiController
    {         
        [Route("api/v1/discount")]
        [HttpGet]
        public IHttpActionResult GetDiscount()
        {
            List<UI_Discount> lstDiscount;
            try
            {
                using (Master_BL BL = new Master_BL(ContextDetails))
                {
                    lstDiscount = BL.GetDiscount(ContextDetails.OrgID);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstDiscount);
        }

        [Route("api/v1/discountreason")]
        [HttpGet]
        public IHttpActionResult GetDiscountReason(Int16 ReasonCategoryID, int ReasonTypeID, string ReasonCode)
        {
            List<UI_DiscountReason> lstDiscountReason;
            try
            {
                using (Master_BL BL = new Master_BL(ContextDetails))
                {
                    lstDiscountReason = BL.GetDiscountReason(ReasonCategoryID, ReasonTypeID, ReasonCode);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstDiscountReason);
        }

        [Route("api/v1/tax")]
        [HttpGet]
        public IHttpActionResult GetTax()
        {
            List<UI_Tax> lstTax ;
            try
            {
                using (Master_BL BL = new Master_BL(ContextDetails))
                {
                    lstTax = BL.GetTax(ContextDetails.OrgID);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstTax);
        }
    }
}
