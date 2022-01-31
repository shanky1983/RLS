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
    public class Feedback_DAL
    {
        ContextDetails globalContextDetails;
        public Feedback_DAL()
        {
        }
        public Feedback_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

       public List<SystemFeedBackType> GetFeedbackType()
        {
            long returncode = -1;
            List<SystemFeedBackType> lstFeedBackType = new List<SystemFeedBackType>();

            try
            {
                SqlCommand cmd = Command.pGetFeedbackTypeCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstFeedBackType);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetFeedbackType", ex);
            }
            return lstFeedBackType;
        }
        public List<SystemFeedBack> GetSysFBList(int TypeID,int OrgID, string Status)
        {
            long returncode = -1;
            List<SystemFeedBack> lstFeedBack = new List<SystemFeedBack>();

            try
            {
                SqlCommand cmd = Command.pGetFeedbackListCommand(TypeID, OrgID, Status);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstFeedBack);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetSysFBList", ex);
            }
            return lstFeedBack;
        }

        public long InsertFeedback(int TypeID, int Priority, string Module, string PageURL, string Description, string Remarks, string Status)
        {
            long returncode = -1;
            List<SystemFeedBackType> lstFeedBack = new List<SystemFeedBackType>();

            try
            {
                SqlCommand cmd = Command.pInsertSystemFeedBackCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails), TypeID, Priority, Module, PageURL, Description, Remarks, Status);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstFeedBack);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertFeedback", ex);
            }
            return returncode;
        }

        public long UpdateSystemFeedBack(int OrgID, long ID, string Remarks, string Status)
        {
            long returncode = -1;
            List<SystemFeedBack> lstFeedBack = new List<SystemFeedBack>();

            try
            {
                SqlCommand cmd = Command.pUpdateSystemFeedBackCommand(OrgID, ID, Remarks, Status);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstFeedBack);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL UpdateSysFBList", ex);
            }
            return returncode;
        }

    }
}
