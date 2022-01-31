using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Attune.Solution.QMSBusinessEntities;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.Common;
using System.Data;

namespace Attune.Solution.QMSDataAccessLayer
{
    public class PlanAndScheduleQMS_DAl
    {
         ContextDetails globalContextDetails;
         public PlanAndScheduleQMS_DAl(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }

         public new List<PlanScheduleDetails_QMS> SavePlanAndSchedule_DAL(string ActionType, List<PlanScheduleDetails_QMS> lstSchedule)
        {
            List<PlanScheduleDetails_QMS> objPs = new List<PlanScheduleDetails_QMS>();
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pSavePlanAndScheduleQMSCommand(ActionType, UDT_DAL.ConvertToUDT_PlanAndSchedule_QMS(lstSchedule), UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    //returncode = dbEngine.ExecuteNonQuery(cmd);
                    System.Data.IDataReader IdR = dbEngine.ExecuteReader(cmd);
                    returncode = Attune.Podium.Common.Utilities.ConvertTo<PlanScheduleDetails_QMS>(IdR, out objPs);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in pgetGeneralStatistics_DAL", e);
            }
            return objPs;
        }
         public DataSet GetPlanAndSchedule_DAL(string ActionType, List<PlanScheduleDetails_QMS> lstSchedule)
        {
            List<PlanScheduleDetails_QMS> objPs = new List<PlanScheduleDetails_QMS>();
            long returncode = -1;
            DataSet ds = new DataSet();
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pLoadPlanAndScheduleQMSCommand(ActionType, UDT_DAL.ConvertToUDT_PlanAndSchedule_QMS(lstSchedule), UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                 //   System.Data.IDataReader IdR = dbEngine.ExecuteReader(cmd);
                  //  returncode = Attune.Podium.Common.Utilities.ConvertTo<PlanScheduleDetails_QMS>(IdR, out objPs);
                    returncode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in GetPlanAndSchedule_DAL", e);
            }
            return ds;
        }
         public DataSet GetInternalAuditObervation(long InternalAuditID, long PlanScheduleID, string AuditType, string Observarion,string Category ,string ActionType)
         {
             List<PlanScheduleDetails_QMS> objPs = new List<PlanScheduleDetails_QMS>();
             long returncode = -1;
             DataSet ds = new DataSet();
             System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
             try
             {
                 cmd = Command.pLoadSaveInternalAuditObservationCommand(InternalAuditID, PlanScheduleID, AuditType, Observarion, Category, ActionType,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                 using (DBEngine dbEngine = new DBEngine())
                 {
                 //    System.Data.IDataReader IdR = dbEngine.ExecuteReader(cmd);       
                     returncode = dbEngine.ExecuteDataSet(cmd, out ds);
                 }
             }
             catch (Exception e)
             {
                 CLogger.LogError("Error while loading in GetPlanAndSchedule_DAL", e);
             }
             return ds;
         }
         public long SaveInternalAuditObervation(long InternalAuditID, long PlanScheduleID, string AuditType, string Observarion, string Category, string ActionType)
         {
         
             long returncode = -1;
             
             System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
             try
             {
                 cmd = Command.pLoadSaveInternalAuditObservationCommand(InternalAuditID, PlanScheduleID, AuditType, Observarion, Category, ActionType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                 using (DBEngine dbEngine = new DBEngine())
                 {
                     returncode = dbEngine.ExecuteNonQuery(cmd);
                 }
             }
             catch (Exception e)
             {
                 CLogger.LogError("Error while loading in GetPlanAndSchedule_DAL", e);
             }
             return returncode;
         }
         public DataSet GetInternalAuditNCs(long InternalAuditNCID,
                    long OrgID,
                    long PlanScheduleID,
                    string NABLClause,
                    string ISOClause,
                    long NCNO,
                    string Description,
                    string Classification,
                    string ActivityAssesed,
                    string ProposedAction,
                    string ActionTaken,
                    System.DateTime CompletionDate,
                    string ActionVerified,
                    string Comments,
                    string Status,
                    string ActionType)
         {
             List<PlanScheduleDetails_QMS> objPs = new List<PlanScheduleDetails_QMS>();
             long returncode = -1;
             DataSet ds = new DataSet();
             System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
             try
             {
                 cmd = Command.pLoadSaveInternalAuditNcsCommand(InternalAuditNCID, OrgID, PlanScheduleID, NABLClause, ISOClause, NCNO, Description, Classification, ActivityAssesed
                     , ProposedAction, ActionTaken, CompletionDate, ActionVerified, Comments, Status, ActionType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                 using (DBEngine dbEngine = new DBEngine())
                 {
                  //   System.Data.IDataReader IdR = dbEngine.ExecuteReader(cmd);
                     returncode = dbEngine.ExecuteDataSet(cmd, out ds);
                 }
             }
             catch (Exception e)
             {
                 CLogger.LogError("Error while loading in GetPlanAndSchedule_DAL", e);
             }
             return ds;
         }
         public long SaveInternalAuditNCs(long InternalAuditNCID,
                    long OrgID,
                    long PlanScheduleID,
                    string NABLClause,
                    string ISOClause,
                    long NCNO,
                    string Description,
                    string Classification,
                    string ActivityAssesed,
                    string ProposedAction,
                    string ActionTaken,
                    System.DateTime CompletionDate,
                    string ActionVerified,
                    string Comments,
                    string Status,
                    string ActionType)
         {

             long returncode = -1;

             System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
             try
             {
                 cmd = Command.pLoadSaveInternalAuditNcsCommand(InternalAuditNCID,OrgID,PlanScheduleID,NABLClause,ISOClause,NCNO,Description,Classification,ActivityAssesed
                     , ProposedAction, ActionTaken, CompletionDate, ActionVerified, Comments, Status, ActionType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                 using (DBEngine dbEngine = new DBEngine())
                 {
                     returncode = dbEngine.ExecuteNonQuery(cmd);
                 }
             }
             catch (Exception e)
             {
                 CLogger.LogError("Error while loading in GetPlanAndSchedule_DAL", e);
             }
             return returncode;
         }
    }
}
