using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.Common;
using Attune.Podium.BusinessEntities;
using Attune.Solution.DAL;
namespace Attune.Podium.DataAccessLayer
{
    public class NewInstanceCreation_DAL
    {

         ContextDetails globalContextDetails;
        public NewInstanceCreation_DAL()
        {

        }
        public NewInstanceCreation_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long CreateOrgInstanceQueue(string pOrgName, DataTable dtOrganization, DataTable dtRoles, DataTable dtVisitPurposes,DataTable dtdepartment,out int pRetStatus, string strPassword, long CurrencyID, string AliceType, int OldInsID)
        {
            long returnCode = -1;
            pRetStatus = -1;

            try
            {
                SqlCommand cmd = Command.pCreateOrgInstanceQueueCommand(pOrgName, dtOrganization, dtRoles, dtVisitPurposes,dtdepartment,out pRetStatus, strPassword, CurrencyID, AliceType, OldInsID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    Int32.TryParse(cmd.Parameters["@pRetStatus"].Value.ToString(), out pRetStatus);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in NewInstanceCreation_DAL, CreateOrgInstanceQueue", ex);
            }

            return returnCode;
        }

        public long CreateatedOrgInstanceDetail(out List<NewInstanceCreationTracker> lstNICT, out long pReturnStatus)
        {
            long returnCode = -1;
            pReturnStatus = -1;
            lstNICT = new List<NewInstanceCreationTracker>();

            try
            {
                SqlCommand cmd = Command.pCreateatedOrgInstanceDetailCommand(out pReturnStatus,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    Int64.TryParse(cmd.Parameters["@pRetStatus"].Value.ToString(), out pReturnStatus);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstNICT);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in NewInstanceCreation_DAL, CreateatedOrgInstanceDetail", ex);
            }

            return returnCode;
        }

        public long pCheckOrganizationName(string pOrgName, out int pReturnStatus)
        {
            long returnCode = -1;
            pReturnStatus = 0;
            try
            {
                SqlCommand cmd = Command.pCheckOrganizationNameCommand(pOrgName, out pReturnStatus,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    pReturnStatus = Convert.ToInt16(cmd.Parameters["@pReturn"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL CheckANCNurseTaskStatus", ex);
            }

            return returnCode;
        }

    }
}
