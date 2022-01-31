using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.Common;
using Attune.Podium.BusinessEntities;
using System.ComponentModel;
using Attune.Solution.DAL;
using System.Transactions;
using System.Collections.Specialized;

namespace DataAccessLayer
{
    public class ActionManager_DAL
    {

         ContextDetails globalContextDetails;
        public ActionManager_DAL()
        {

        }
        public ActionManager_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetPerformingAction(PageContextkey objPageContextkey, out List<PerformingAction> lstPerformingAction)
        {


            lstPerformingAction = new List<PerformingAction>();
            DataSet ds = new DataSet();
            long returnCode = -1;
			   try
            {
            SqlCommand cmd = Command.pPerformingNextActionCommand(objPageContextkey.PageID, objPageContextkey.ButtonName, objPageContextkey.RoleID, objPageContextkey.PatientID, objPageContextkey.OrgID, objPageContextkey.PatientVisitID,objPageContextkey.SampleID,objPageContextkey.IDS,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPerformingAction);
                }

            }
			}
			  catch (Exception ex)
            {
                CLogger.LogError("Error in ActionManager_DAL GetPerformingAction", ex);
            }
            return returnCode;
        }

        public long GetMultiplePerformingAction(List<PageContextkey> objPageContextkey, out List<PerformingAction> lstPerformingAction)
        {


            lstPerformingAction = new List<PerformingAction>();
            DataTable dtcontexkeys = UDT_DAL.ConvertToMultiplePageContextkey(objPageContextkey);
            DataSet ds = new DataSet();
            long returnCode = -1;
            SqlCommand cmd = Command.pPerformingMultipleNextActionCommand(dtcontexkeys,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPerformingAction);
                }

            }
            return returnCode;
        }
        //Added by jegan
        public long GetManualReportAction(PageContextkey objPageContextkey, out List<PerformingAction> lstPerformingAction)
        {


            lstPerformingAction = new List<PerformingAction>();
            DataSet ds = new DataSet();
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pManualReportActionCommand(objPageContextkey.PageID, objPageContextkey.ButtonName, objPageContextkey.RoleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPerformingAction);
                    }
                    else
                        return -1;
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in ActionManager_DAL GetManualReportAction", ex);
            }
            return returnCode;
        }
        //end
    }
}
