using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Solution.QMSBusinessEntities;
using Attune.Podium.Common;
using Attune.Solution.QMSDataAccessLayer;
using Attune.Solution.QMSBusinessEntities.CustomEntities;

namespace Attune.Solution.QMSBusinessLogic
{
  public  class TrainingProgram_BL
    {
         ContextDetails globalContextDetails;

        public TrainingProgram_BL()
        {
        }
        public TrainingProgram_BL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }

        public long GetTrainingProgramDetails_BL(long ScheduledID, out List<PlanScheduleDetails_QMS> ResultPlanDetails,out List<Trainingprogramscustoms> Details)
        {
            long returncode = -1;
            ResultPlanDetails = new List<PlanScheduleDetails_QMS>();
            Details = new List<Trainingprogramscustoms>();
            TrainingPrograms_DAL ObjDAL = new TrainingPrograms_DAL(globalContextDetails);
            try
            {
                returncode = ObjDAL.GetTrainingProgramDetails_DAL(globalContextDetails.OrgID, ScheduledID,out ResultPlanDetails,out Details);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while (SaveFile_DAL) BL", ex);
            }
            return returncode;
        }



        //public long GetTrainingProgramFilters_BL(PlanScheduleDetails_QMS PlanAndSchedule, out List<PlanScheduleDetails_QMS> ResultPlanDetails)
        //{
        //    long returncode = -1;
        //    TrainingPrograms_DAL ObjDAL = new TrainingPrograms_DAL(globalContextDetails);
        //    ResultPlanDetails = new List<PlanScheduleDetails_QMS>();
        //    try
        //    {
        //        returncode = ObjDAL.GetTrainingProgramFilters_DAL(PlanAndSchedule,out ResultPlanDetails);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while (SaveFile_DAL) BL", ex);
        //    }
        //    return returncode;
        //}

        public long SaveTrainingProgramDetails(List<TrainingProgram_QMS> list, long ScheduleID,string Type ,out List<Trainingprogramscustoms> ResultPlanDetails)
        {
            long returncode = -1;
            TrainingPrograms_DAL ObjDAL = new TrainingPrograms_DAL(globalContextDetails);
            ResultPlanDetails = new List<Trainingprogramscustoms>();
            try
            {
                returncode = ObjDAL.SaveTrainingProgramDetails(list, ScheduleID, Type, out ResultPlanDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing in SaveTrainingProgramDetails", ex);
            }
            return returncode;
        }

        public long DeleteTrainingProgramDetails(long TrainingProgramID, long PlanScheduleID, int Orgid, string Type)
        {
            long returncode = -1;
            TrainingPrograms_DAL ObjDAL = new TrainingPrograms_DAL(globalContextDetails);
           
            try
            {
                returncode = ObjDAL.DeleteTrainingProgramDetails(TrainingProgramID, PlanScheduleID, Orgid, Type);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing in UpdateTrainingProgramDetails", ex);
            }
            return returncode;
        }


        public long LoadMRMDetails(List<ScheduledMOM> list,string Type ,out List<ScheduledMOMCustom> ResultPlanDetails)
        {
            long returncode = -1;
            TrainingPrograms_DAL ObjDAL = new TrainingPrograms_DAL(globalContextDetails);
            ResultPlanDetails = new List<ScheduledMOMCustom>();
            try
            {
                returncode = ObjDAL.LoadMRMDetails(list,Type, out ResultPlanDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing in LoadMRMDetails", ex);
            }
            return returncode;
        }
    }
}
