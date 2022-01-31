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
    public class OnFlowDialysis_BL
    {
        ContextDetails globalContextDetails;
        public OnFlowDialysis_BL()
        {

        }
        public OnFlowDialysis_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        DataSet ds = new DataSet();
        public long GetOnFlowDialysis(long PatientVisitID, out DataSet ds)//List<Dialysis> lstDialysis)
        {
            long returnCode = -1;
            //lstDialysis = new List<Dialysis>();
            ds = new DataSet();
            try
            {
                OnFlowDialysis_DAL diaDAL = new   OnFlowDialysis_DAL(globalContextDetails);
                returnCode = diaDAL.GetOnFlowDialysis(PatientVisitID, out ds);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Dialysis_BL.GetDialysisVitals :", ex);
            }

            return returnCode;
        }

        public long GetOnFlowDialysis1(long PatientVisitID, out List<Dialysis> lstDialysis)
        {
            long returnCode = -1;
            lstDialysis = new List<Dialysis>();
            
            try
            {
                OnFlowDialysis_DAL diaDAL = new   OnFlowDialysis_DAL(globalContextDetails);
                returnCode = diaDAL.GetOnFlowDialysis1(PatientVisitID, out lstDialysis);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Dialysis_BL.GetDialysisVitals :", ex);
            }

            return returnCode;
        }
    }
}
