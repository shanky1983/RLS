using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using Attune.Kernel.LISAPI.BL;
using System.IO;
using System.Net.Http.Headers;
using System.Globalization;
using Attune.KernelV2.Utilities;
using Attune.Kernel.LISAPI.BusinessEntities;
using Attune.KernelV2;
using System.Web.Http.Description;


namespace MobileAppIntegrationAPI.Controllers
{
   
    public class LIMSMastersController : BaseApiController
    {
        [ResponseType(typeof(LocalitiesDetails))]
        [HttpGet]
        [Route("Api/LIMSMasters/GetLocalityByType")]
        /// <summary>
        /// Get This API will give the Current Status of the Localites based on Type
        /// GET: api/GetLocalityByType
        /// </summary>
        public IHttpActionResult GetLocalityByType(int pOrgID, string pType, string pLocalityCategory)
        {

            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<LocalitiesInfo> lstLocalities = new List<LocalitiesInfo>();
            LocalitiesDetails result = new LocalitiesDetails();

            if (string.IsNullOrEmpty(pLocalityCategory))
            {
                pLocalityCategory = string.Empty;
            }

            try
            {
                returnCode = new LISAPI_BL().GetLocalityByType( pOrgID, pType, pLocalityCategory, out lstLocalities);

                if (returnCode !=-1)
                {
                    if (lstLocalities.Count > 0 && lstLocalities != null)
                    {
                        result.LocalityType = pType;
                        if (pType.ToUpper() == "COUNTRY")
                        {
                            result.LocalityCategory = "ALL";
                        }
                        else
                        {
                            if (pLocalityCategory != string.Empty)
                            {
                                result.LocalityCategory = pLocalityCategory;
                            }
                        }

                        result.LocalityInfo = lstLocalities;
                    }
                    actionResult = Ok(result);
                }
                else
                {
                    result.LocalityType = null;
                    result.LocalityCategory = null;
                    result.LocalityInfo = null;
                    actionResult = Ok(result);
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }

            return actionResult;
        }

        [ResponseType(typeof(LocalitiesDetails))]
        [HttpGet]
        [Route("Api/LIMSMasters/GetLocalityByText")]
        /// <summary>
        /// Get This API will give the Current Status of the Localites based on Type with SearchText
        /// GET: api/GetLocalityByText
        /// </summary>
        public IHttpActionResult GetLocalityByText(int pOrgID, string pType, string pLocalityCategory, string pSearchText)
        {

            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<LocalitiesInfo> lstLocalities = new List<LocalitiesInfo>();
            LocalitiesDetails result = new LocalitiesDetails();

            if (string.IsNullOrEmpty(pLocalityCategory))
            {
                pLocalityCategory = string.Empty;
            }


            try
            {
                returnCode = new LISAPI_BL().GetLocalityByText(pOrgID, pType, pLocalityCategory, pSearchText, out lstLocalities);

                if (returnCode != -1)
                {
                    if (lstLocalities.Count > 0 && lstLocalities != null)
                    {
                        result.LocalityType = pType;
                        if (pType.ToUpper() == "COUNTRY")
                        {
                            result.LocalityCategory = "ALL";
                        }
                        else
                        {
                            if (pLocalityCategory != string.Empty)
                            {
                                result.LocalityCategory = pLocalityCategory;
                            }
                        }

                        result.LocalityInfo = lstLocalities;
                    }
                    actionResult = Ok(result);
                }
                else
                {
                    result.LocalityType = null;
                    result.LocalityCategory = null;
                    result.LocalityInfo = null;
                    actionResult = Ok(result);
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }

            return actionResult;
        }

    }
}
