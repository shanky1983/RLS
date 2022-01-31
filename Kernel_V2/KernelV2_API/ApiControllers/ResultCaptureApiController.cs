using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Attune.KernelV2.BL;
using Attune.KernelV2.Entities;
using Attune.KernelV2.Providers;

namespace Attune.KernelV2.API
{
    public class ResultCaptureApiController : BaseApiController
    {
        [Route("api/v1/resultcapture")]
        [HttpGet]
        public IHttpActionResult get(long VisitID, string gUID)
        {
            List<UI_OrderedInvestigations> lstPatientInvestigation;
            try
            {
                using (Investigation_BL BL = new Investigation_BL(ContextDetails))
                {
                    lstPatientInvestigation = BL.GetpatientInvestigationForVisit(VisitID, ContextDetails.OrgID, ContextDetails.OrgAddressID, ContextDetails.LocationID, gUID);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstPatientInvestigation);
        }

        [Route("api/v1/resultcapture")]
        [HttpGet]
        public IHttpActionResult get(long VisitID, string gUID, string InvIDs, string IsTrustedDetails, string Status)
        {
            UI_ResultCapture objResultCapture;
            UI_LoginDetail LDetail = new UI_LoginDetail
            {
                LoginID = ContextDetails.LoginID,
                Orgid = ContextDetails.OrgID,
                RoleID = ContextDetails.RoleID,
                DummyString = "0"
            };
            try
            {
                using (Investigation_BL BL = new Investigation_BL(ContextDetails))
                {
                    objResultCapture = BL.GetInvestigatonResultsCapture(VisitID, ContextDetails.OrgID, ContextDetails.RoleID,
                        gUID, -1, InvIDs, ContextDetails.LocationID, LDetail, -1, IsTrustedDetails, Status);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(objResultCapture);
        }

        [Route("api/v1/referencerangetype")]
        [HttpGet]
        public IHttpActionResult ReferenceRangeType()
        {
            List<UI_ReferenceRangeType> lstReferenceRangeType = null;
            try
            {
                using (Investigation_BL BL = new Investigation_BL(ContextDetails))
                {
                    var ReferenceRangeType = BL.GetReferenceRangeType(ContextDetails.OrgID, ContextDetails.LanguageCode);

                    if (ReferenceRangeType != null && ReferenceRangeType.Count > 0)
                    {
                        lstReferenceRangeType = ((from child in ReferenceRangeType select new UI_ReferenceRangeType { Code = child.Code, Bound = child.Bound, Type = child.Type }).Distinct()).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstReferenceRangeType);
        }

        [Route("api/v1/saveinvestigationvalues")]
        [HttpPost]
        public IHttpActionResult SaveInvestigationValues([FromBody]UI_ResultCapturePost ResultCapture, string gUID, long VisitID)
        {
            long returncode = -1;
                        
            try
            {
                if (ResultCapture != null)
                {
                    using (Investigation_BL BL = new Investigation_BL(ContextDetails))
                    {
                        returncode = BL.SaveInvestigationValues(ResultCapture, gUID, VisitID);
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(returncode);
        }
    }
}
