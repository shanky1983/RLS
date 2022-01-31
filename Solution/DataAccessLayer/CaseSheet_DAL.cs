using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using System.Collections.Generic;
using Attune.Podium.Common;
using System.Data.Common;
using System.Transactions;

namespace Attune.Solution.DAL
{
    public class CaseSheet_DAL
    {
         ContextDetails globalContextDetails;
        public CaseSheet_DAL()
        {

        }
        public CaseSheet_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }


        public long GetPatientComplaintDetail(long patientVisitID, out List<PatientComplaint> lstPatientComplaint)
        {
            long returnCode = -1;
            lstPatientComplaint = new List<PatientComplaint>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetPatientComplaintDetailCommand(patientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientComplaint);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading patient complaint detail", ex);

            }

            return returnCode;
            
        }
    }

}
