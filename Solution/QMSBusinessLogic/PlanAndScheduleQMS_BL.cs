using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Solution.QMSBusinessEntities.CustomEntities;
using Attune.Solution.QMSDataAccessLayer;
using Attune.Solution.QMSBusinessEntities;
using Attune.Podium.Common;
using System.Data;

namespace Attune.Solution.QMSBusinessLogic
{
    public class PlanAndScheduleQMS_BL
    {
        ContextDetails globalContextDetails;
        public PlanAndScheduleQMS_BL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }
        public DataSet GetPlanAndSchedule_BL(string ActionType, List<PlanScheduleDetails_QMS> scList)
        {
            List<PlanScheduleDetails_QMS> objList = new List<PlanScheduleDetails_QMS>();
            long returncode = -1;
            DataSet ds = new DataSet();
            try
            {
                PlanAndScheduleQMS_DAl objDal = new PlanAndScheduleQMS_DAl(globalContextDetails);

                ds = objDal.GetPlanAndSchedule_DAL(ActionType, scList);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in pgetGeneralStatistics_BL", e);
            }
            return ds;
        }
        public List<PlanScheduleDetails_QMS> SavePlanAndSchedule_BL(string ActionType, List<PlanScheduleDetails_QMS> scList)
        {
            List<PlanScheduleDetails_QMS> objList = new List<PlanScheduleDetails_QMS>();
            long returncode = -1;

            try
            {
                PlanAndScheduleQMS_DAl objDal = new PlanAndScheduleQMS_DAl(globalContextDetails);

                objList = objDal.SavePlanAndSchedule_DAL(ActionType, scList);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in pgetGeneralStatistics_BL", e);
            }
            return objList;
        }
        public long SaveInternalAuditObervation(long InternalAuditID, long PlanScheduleID, string AuditType, string Observarion, string Category, string ActionType)
        {

            long returncode = -1;

            
            try
            {
                PlanAndScheduleQMS_DAl objDal = new PlanAndScheduleQMS_DAl(globalContextDetails);
                returncode=objDal.SaveInternalAuditObervation(InternalAuditID, PlanScheduleID, AuditType, Observarion, Category, ActionType);
               
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in GetPlanAndSchedule_DAL", e);
            }
            return returncode;
        }
        public DataSet GetInternalAuditObervation(long InternalAuditID, long PlanScheduleID, string AuditType, string Observarion, string Category, string ActionType)
        {
           
            long returncode = -1;
            DataSet ds = new DataSet();
           
            try
            {
                PlanAndScheduleQMS_DAl objDal = new PlanAndScheduleQMS_DAl(globalContextDetails);
                ds = objDal.GetInternalAuditObervation(InternalAuditID, PlanScheduleID, AuditType, Observarion, Category, ActionType);
               
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in GetPlanAndSchedule_DAL", e);
            }
            return ds;
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

            long returncode = -1;
            DataSet ds = new DataSet();

            try
            {
                PlanAndScheduleQMS_DAl objDal = new PlanAndScheduleQMS_DAl(globalContextDetails);
                ds = objDal.GetInternalAuditNCs(InternalAuditNCID, OrgID, PlanScheduleID, NABLClause, ISOClause, NCNO, Description, Classification, ActivityAssesed
                     , ProposedAction, ActionTaken, CompletionDate, ActionVerified, Comments, Status, ActionType);

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


            try
            {
                PlanAndScheduleQMS_DAl objDal = new PlanAndScheduleQMS_DAl(globalContextDetails);
                returncode = objDal.SaveInternalAuditNCs(InternalAuditNCID, OrgID, PlanScheduleID, NABLClause, ISOClause, NCNO, Description, Classification, ActivityAssesed
                     , ProposedAction, ActionTaken, CompletionDate, ActionVerified, Comments, Status, ActionType);

            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in GetPlanAndSchedule_DAL", e);
            }
            return returncode;
        }
    }
}
