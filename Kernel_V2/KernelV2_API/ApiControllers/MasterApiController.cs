using System;
using System.Collections.Generic;
using System.Web.Http;
using Attune.KernelV2.BL;
using Attune.KernelV2.Entities;
using Attune.KernelV2.Providers;

namespace Attune.KernelV2.API.ApiControllers.PlatForm
{
    public class MasterApiController : BaseApiController
    {
        [Route("api/v1/urn")]
        [HttpGet]
        public IHttpActionResult GetURN()
        {
            UI_URN objURN ;
            try
            {
                using (Master_BL BL = new Master_BL(ContextDetails))
                {
                    objURN = BL.GetURN();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(objURN);
        }
        [Route("api/v1/checkURN")]
        [HttpGet]
        public IHttpActionResult CheckURN(int UrnTypeId, string UrnNo)
        {
            List<UI_URNTypes> lstURN;
            try
            {
                using (Master_BL BL = new Master_BL(ContextDetails))
                {
                    lstURN = BL.CheckURN(UrnTypeId, UrnNo);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstURN);
        }
        [Route("api/v1/species")]
        [HttpGet]
        public IHttpActionResult GetSpecies()
        {
            List<UI_Species> objSpecies ;
            try
            {
                using (Master_BL BL = new Master_BL(ContextDetails))
                {
                    objSpecies = BL.GetSpecies(ContextDetails.OrgID);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(objSpecies);
        }

        [Route("api/v1/paymenttype")]
        [HttpGet]
        public IHttpActionResult GetPaymentType()
        {
            List<UI_PaymentType> lstPaymentType ;
            try
            {
                using (Master_BL BL = new Master_BL(ContextDetails))
                {
                    lstPaymentType = BL.GetPaymentType(ContextDetails.OrgID);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstPaymentType);
        }

        [Route("api/v1/orgcurrency")]
        [HttpGet]
        public IHttpActionResult GetOrgCurrency()
        {
            List<UI_OrgCurrency> lstOrgCurrency ;
            try
            {
                using (Master_BL BL = new Master_BL(ContextDetails))
                {
                    lstOrgCurrency = BL.GetOrgCurrency(ContextDetails.OrgID);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstOrgCurrency);
        }

        [Route("api/v1/paymentdetails")]
        [HttpGet]
        public IHttpActionResult GetPaymentDetails()
        {
            UI_PaymentDetails objPaymentDetails ;
            try
            {
                using (Master_BL BL = new Master_BL(ContextDetails))
                {
                    objPaymentDetails = BL.GetPaymentDetails(ContextDetails.OrgID);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(objPaymentDetails);
        }

        [Route("api/v1/bank")]
        [HttpGet]
        public IHttpActionResult GetBankName(string SearchText)
        {
            List<UI_Bank> lstBank ;
            try
            {
                using (Master_BL BL = new Master_BL(ContextDetails))
                {
                    lstBank = BL.GetBankName(SearchText, ContextDetails.OrgID);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstBank);
        }

        [Route("api/v1/discountapprover")]
        [HttpGet]
        public IHttpActionResult GetDiscountApprovedBy(string Name, string Type)
        {
            List<UI_DiscoiuntApproved> lstDiscoiuntApproved ;
            try
            {
                using (Master_BL BL = new Master_BL(ContextDetails))
                {
                    lstDiscoiuntApproved = BL.GetDiscountApprovedBy(Name, ContextDetails.OrgID, Type);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstDiscoiuntApproved);
        }

        [Route("api/v1/coupon")]
        [HttpGet]
        public IHttpActionResult GetCoupon(string SearchText)
        {
            List<UI_Coupon> lstCoupon ;
            try
            {
                using (Master_BL BL = new Master_BL(ContextDetails))
                {
                    lstCoupon = BL.GetCoupon(SearchText, ContextDetails.OrgID);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstCoupon);
        }

        [Route("api/v1/salutation")]
        [HttpGet]
        public IHttpActionResult GetSalutation()
        {
            List<UI_Salutation> lstSalutation ;
            try
            {
                using (Master_BL BL = new Master_BL(ContextDetails))
                {
                    lstSalutation = BL.GetSalutation(ContextDetails.OrgID, ContextDetails.LanguageCode);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstSalutation);
        }

        [Route("api/v1/phlebotomist")]
        [HttpGet]
        public IHttpActionResult GetPhlebotomist(string searchText)
        {
            List<UI_Department> lstDepartment ;
            try
            {
                using (Master_BL BL = new Master_BL(ContextDetails))
                {
                    lstDepartment = BL.GetPhlebotomist(searchText, "", ContextDetails.OrgID);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstDepartment);
        }

        [Route("api/v1/GetComplaint")]
        [HttpGet]
        public IHttpActionResult GetComplaint(string searchText)
        {
            List<UI_Complaint> lstComplaint;
            try
            {
                using (Master_BL BL = new Master_BL(ContextDetails))
                {
                    lstComplaint = BL.GetComplaint(searchText);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstComplaint);
        }
    }
}
