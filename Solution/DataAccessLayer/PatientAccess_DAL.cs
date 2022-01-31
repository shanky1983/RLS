using System;
using System.Data;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using System.Configuration;
using System.Web;
using System.Collections;
using System.Collections.Generic;
using Attune.Podium.Common;
using System.Transactions;

namespace Attune.Solution.DAL
{
    public class PatientAccess_DAL
    {
        ContextDetails globalContextDetails;
        public PatientAccess_DAL()
        {

        }
        public PatientAccess_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long pGetVisitSearchDetailByLoginID(long LoginID, string fromDate, string toDate, int currentOrgID, string pSearchType, out List<PatientVisit> lstPatientVisit, int startRowIndex, int pageSize, out int totalRows)
        {
            long returnCode = -1;
            totalRows = -1;
            lstPatientVisit = new List<PatientVisit>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetVisitSearchDetailbyLoginIDCommand(LoginID, fromDate, toDate, currentOrgID, pSearchType, UDT_DAL.ConvertToUDT_Context(globalContextDetails), startRowIndex, pageSize, out totalRows);
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientVisit);
                        totalRows = Convert.ToInt32(cmd.Parameters["@totalRows"].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get patient visit search details by LoginId", ex);
            }

            return returnCode;
        }

        public long pCreatePatientLogin(int pOrgID, string pPatientName, long pPatientID, long pLoginID, out string pUName, out string pPwd)
        {
            long returnCode = -1;

            pUName = string.Empty;
            pPwd = string.Empty;

            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pCreatePatientLoginCommand(pOrgID, pPatientName, pPatientID, pLoginID, out pUName, out pPwd, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);

                    if (returnCode == 0)
                    {
                        pUName = Convert.ToString(cmd.Parameters["@pUName"].Value);
                        pPwd = Convert.ToString(cmd.Parameters["@pPwd"].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while creating patient login", ex);
            }

            return returnCode;
        }
    }


}
