using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Solution.QMSBusinessEntities;
using Attune.Podium.Common;
using System.Data;
using Attune.Solution.QMSBusinessEntities.CustomEntities;

namespace Attune.Solution.QMSDataAccessLayer
{
  public  class TrainingPrograms_DAL
    {
        ContextDetails globalContextDetails;
         public TrainingPrograms_DAL() { 
        }
         public TrainingPrograms_DAL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }

         public long GetTrainingProgramDetails_DAL(long orgID, long ScheduledID, out List<PlanScheduleDetails_QMS> ResultPlanDetails, out List<Trainingprogramscustoms> Details)
        {
            long returnCode = -1;
            ResultPlanDetails = new List<PlanScheduleDetails_QMS>();
            Details = new List<Trainingprogramscustoms>();
            DataSet ds = new DataSet();
            try
            {


             
                SqlCommand cmd = new SqlCommand();
                cmd = Command.PgetTrainingProgramDetailsCommand(orgID, ScheduledID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out ResultPlanDetails);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out Details);
                }
                 
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  GetTrainingProgramDetails_DAL ", ex);
            }
            return returnCode;
        }



         //public long GetTrainingProgramFilters_DAL(PlanScheduleDetails_QMS PlanAndShedule, out List<PlanScheduleDetails_QMS> ResultPlanDetails)
         //{
         //    long returnCode = -1;
         //    ResultPlanDetails = new List<PlanScheduleDetails_QMS>();
         //    DataSet ds = new DataSet();
         //    try
         //    {
                 


         //        SqlCommand cmd = new SqlCommand();

         //      //  cmd = Command.PgetTrainingProgramFilterCommand(PlanAndShedule.OrgID, PlanAndShedule.Location, DateTime.Now, "", PlanAndShedule.AuditScope, PlanAndShedule.EventName,"", PlanAndShedule.Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
         //        using (DBEngine dbEngine = new DBEngine())
         //        {
         //            returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                     
         //        }

         //        if (ds.Tables[0].Rows.Count > 0)
         //        {
         //            returnCode = Utilities.ConvertTo(ds.Tables[0], out ResultPlanDetails);
         //        }
         //    }
         //    catch (Exception ex)
         //    {
         //        CLogger.LogError("Error in  GetTrainingProgramDetails_DAL ", ex);
                 
         //    }
         //    return returnCode;
         //}


         public long SaveTrainingProgramDetails(List<TrainingProgram_QMS> Analyzer,long ScheduleID,string Type,out List<Trainingprogramscustoms> ResultPlanDetails)
         {
             long returncode = -1;
              DataSet ds = new DataSet();
             System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
             ResultPlanDetails = new List<Trainingprogramscustoms>();
             try
             {
                 cmd = Command.pSaveTainingProgramDetailsCommand(UDT_DAL.TrainingPrograms_QMS(Analyzer), ScheduleID, Type);
                  using (DBEngine dbEngine = new DBEngine())
                 {
                     returncode = dbEngine.ExecuteDataSet(cmd, out ds);
                     
                 }

                 if (ds.Tables[0].Rows.Count > 0)
                 {
                     returncode = Utilities.ConvertTo(ds.Tables[0], out ResultPlanDetails);
                 }
             }
             catch (Exception e)
             {
                 CLogger.LogError("Error while executig in SaveTrainingProgramDetails", e);
             }
             return returncode;
         }

         public long DeleteTrainingProgramDetails(long TrainingProgramID, long PlanScheduleID, int Orgid, string Type)
         {
             long returncode = -1;
            
             System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
          
             try
             {
                 cmd = Command.pDeleteTrainingProgramDetailsCommand(TrainingProgramID, PlanScheduleID, Orgid, Type);
                 using (DBEngine dbEngine = new DBEngine())
                 {
                     returncode = dbEngine.ExecuteNonQuery(cmd);

                 }

               
             }
             catch (Exception e)
             {
                 CLogger.LogError("Error while executig in UpdateTrainingProgramDetails", e);
             }
             return returncode;
         }


         public long LoadMRMDetails(List<ScheduledMOM> list,string Type,out List<ScheduledMOMCustom> ResultPlanDetails)
         {
             long returncode = -1;
             DataSet ds = new DataSet();
             System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
             ResultPlanDetails = new List<ScheduledMOMCustom>();
             try
             {
                 cmd = Command.pLoadMRMDetailsCommand(list[0].PlanScheduleID, UDT_DAL.ConvertToUDTScheduledMOM(list), Type);
                 using (DBEngine dbEngine = new DBEngine())
                 {
                     returncode = dbEngine.ExecuteDataSet(cmd, out ds);

                 }

                 if (ds.Tables[0].Rows.Count > 0)
                 {
                     returncode = Utilities.ConvertTo(ds.Tables[0], out ResultPlanDetails);
                 }
             }
             catch (Exception e)
             {
                 CLogger.LogError("Error while executig in SaveTrainingProgramDetails", e);
             }
             return returncode;
         }

    }
}
