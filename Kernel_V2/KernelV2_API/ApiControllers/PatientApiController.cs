using System;
using System.Collections.Generic;
using System.Web.Http;
using Attune.KernelV2.BL;
using Attune.KernelV2.Entities;
using Attune.KernelV2.Providers;

namespace Attune.KernelV2.API
{
    public class PatientApiController : BaseApiController
    {
        [Route("api/v1/patient")]
        [HttpGet]
        public IHttpActionResult GetPatientBannerDetails(long VisitID, string gUID)
        {
            List<UI_PatientVisit> lstPatientLabVisitDetails ;
            try
            {
                using (Patient_BL BL = new Patient_BL(ContextDetails))
                {
                    lstPatientLabVisitDetails = BL.GetPatientBannerDetails(VisitID, ContextDetails.OrgID, gUID);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstPatientLabVisitDetails);
        }

        [Route("api/v1/patient")]
        [HttpPost]
        public IHttpActionResult post(UI_PatientHistory PatientHistory)
        {
            long returnCode = -1;
            if (PatientHistory != null)
            {
                try
                {
                    using (Patient_BL BL = new Patient_BL(ContextDetails))
                    {
                        returnCode = BL.UpdatePatientVisitChanges(PatientHistory, ContextDetails.OrgID);
                    }
                }
                catch (Exception ex)
                {
                    return StatusCode(ToHttpStatusCode(ex));
                }
            }
            return Ok(returnCode);
        }
    }
}
