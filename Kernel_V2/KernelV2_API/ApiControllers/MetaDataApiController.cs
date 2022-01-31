using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Attune.KernelV2.BL;
using Attune.KernelV2.Entities;
using Attune.KernelV2.Providers;

namespace Attune.KernelV2.API.ApiControllers.PlatForm
{
    public class MetaDataApiController : BaseApiController
    {
        [Route("api/v1/metadata")]
        [HttpGet]
        public IHttpActionResult GetMetaData(string Domain)
        {
            List<UI_MetaData> lstMetaData;
            try
            {
                using (MetaData_BL BL = new MetaData_BL(ContextDetails))
                {
                    lstMetaData = BL.GetMetaData(Domain, ContextDetails.OrgID, ContextDetails.LanguageCode);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstMetaData);
        }

        [Route("api/v1/metavalues")]
        [HttpGet]
        public IHttpActionResult GetMetaValues(string Type)
        {
            List<UI_MetaValues> lstMetaValues;
            try
            {
                using (MetaData_BL BL = new MetaData_BL(ContextDetails))
                {
                    lstMetaValues = BL.GetMetaValues(Type, ContextDetails.OrgID);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstMetaValues);
        }

        [Route("api/v1/country")]
        [HttpGet]
        public IHttpActionResult GetCountry(string SearchText)
        {
            List<UI_Country> lstCountry;
            try
            {
                using (MetaData_BL BL = new MetaData_BL(ContextDetails))
                {
                    lstCountry = BL.GetCountryList().Where(p => p.CountryName.ToUpper().Contains(SearchText.ToUpper())).ToList();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstCountry);
        }

        [Route("api/v1/state")]
        [HttpGet]
        public IHttpActionResult GetStateByCountry(Int16 CountryId, string SearchText)
        {
            List<UI_State> lstState;
            try
            {
                using (MetaData_BL BL = new MetaData_BL(ContextDetails))
                {
                    lstState = BL.GetStateByCountry(CountryId).Where(p => p.StateName.ToUpper().Contains(SearchText.ToUpper())).ToList();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstState);
        }

        [Route("api/v1/pincode")]
        [HttpGet]
        public IHttpActionResult GetPincodeDetails(long Pincode)
        {
            List<UI_Address> lstAddress;
            try
            {
                using (MetaData_BL BL = new MetaData_BL(ContextDetails))
                {
                    lstAddress = BL.GetPincodeDetails(Pincode, ContextDetails.OrgID).ToList();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstAddress);
        }
    }
}
