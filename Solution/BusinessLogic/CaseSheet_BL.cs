using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using System.Collections;
using Attune.Podium.Common;
namespace Attune.Solution.BusinessComponent
{
    public class CaseSheet_BL
    {
         ContextDetails globalContextDetails;
        public CaseSheet_BL()
        {

        }
        public CaseSheet_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetPatientComplaintDetail(long patientVisitID, out List<PatientComplaint> lstPatientComplaint)
        {
            long returnCode = -1;
            lstPatientComplaint = new List<PatientComplaint>();
            try
            {
                returnCode = new CaseSheet_DAL(globalContextDetails).GetPatientComplaintDetail(patientVisitID, out lstPatientComplaint);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Loading GetPateintComplaintDetail BL", ex);
            }
            return returnCode;
        }
    }
}
