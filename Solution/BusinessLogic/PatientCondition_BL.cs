using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using System.Data;
using System.IO;
using Attune.Podium.Common;

/// <summary>
/// Summary description for PatientCondition_BL
/// </summary>
/// 
namespace Attune.Solution.BusinessComponent
{
    public class PatientCondition_BL
    {
       ContextDetails globalContextDetails;
        public PatientCondition_BL()
        {

        }
        public PatientCondition_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long GetPatientConditions( out List<PatientCondition> lstPatientCondition)
        {
            long returnCode = -1;
            lstPatientCondition = null;

            try
            {
                PatientCondition_DAL patientConditionDAL = new PatientCondition_DAL(globalContextDetails);

                returnCode = patientConditionDAL.GetPatientConditions(out lstPatientCondition);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetPatientConditions BL", excp);
            }

            return returnCode;
        }

    }
}
