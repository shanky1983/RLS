using System;
using System.Collections.Generic;
using System.Web.Http;
using Attune.KernelV2.BL;
using Attune.KernelV2.Entities;
using Attune.KernelV2.Providers;

namespace Attune.KernelV2.API.ApiControllers.Client
{
    public class ClientApiController : BaseApiController
    {
        [Route("api/v1/client")]
        [HttpGet]
        public IHttpActionResult GetClientForBilling(string PrefixText)
        {
            List<UI_ClientMaster> lstClient;
            try
            {
                using (Client_BL BL = new Client_BL(ContextDetails))
                {
                    lstClient = BL.GetClientForBilling(0, PrefixText, ContextDetails.OrgID, ContextDetails.OrgAddressID);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstClient);
        }

        [Route("api/v1/referringhospital")]
        [HttpGet]
        public IHttpActionResult GetReferringHospital(string PrefixText, long ClientId)
        {
            List<UI_ReferringHospital> lstReferringHospital;
            try
            {
                using (Client_BL BL = new Client_BL(ContextDetails))
                {
                    lstReferringHospital = BL.GetReferringHospital(PrefixText, ClientId, ContextDetails.OrgID);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstReferringHospital);
        }

        [Route("api/v1/referringphysician")]
        [HttpGet]
        public IHttpActionResult GetReferringPhysician(string PrefixText, long ClientId)
        {
            List<UI_ReferringPhysician> lstReferringPhysician;
            try
            {
                using (Client_BL BL = new Client_BL(ContextDetails))
                {
                    lstReferringPhysician = BL.GetReferringPhysician(PrefixText, ClientId, ContextDetails.OrgID);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstReferringPhysician);
        }

        [Route("api/v1/clientmetamata")]
        [HttpGet]
        public IHttpActionResult GetClientMetaData()
        {
            UI_ClientMetaData objClientMetaData;
            try
            {
                using (Client_BL BL = new Client_BL(ContextDetails))
                {
                    objClientMetaData = BL.GetClientMetaData(ContextDetails.OrgID, ContextDetails.OrgAddressID, ContextDetails.LanguageCode);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(objClientMetaData);
        }

        [Route("api/v1/clientattributesfielddetails")]
        [HttpGet]
        public IHttpActionResult GetClientAttributesFieldDetails(long ReferenceID, string ReferenceType)
        {
            List<UI_FieldAttributeDetails> lstFieldAttributeDetails;
            try
            {
                using (Client_BL BL = new Client_BL(ContextDetails))
                {
                    lstFieldAttributeDetails = BL.ClientAttributesFieldDetails(ReferenceID, ReferenceType);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstFieldAttributeDetails);
        }
    }
}
