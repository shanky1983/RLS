using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;

namespace Attune.Solution.BusinessComponent
{
    public class Title_BL
    {       
         ContextDetails globalContextDetails;
        public Title_BL()
        {

        }
        public Title_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetTitle(int OrgID,string LanguageCode, out List<Salutation> titles)
        {
            long returnCode = -1;
            titles = new List<Salutation>();

            try
            {
                Title_DAL titleDAL = new Title_DAL(globalContextDetails);
                returnCode = titleDAL.GetTitles(OrgID,LanguageCode,out titles);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetTitle BL", excp);
            }
            return returnCode;

        }
     
    
        public long GetMetaData(out List<DateAttributes> lstdateattributes,out List<Gender> lstGender ,out List<MaritalStatus> lstMaritalStatus)
        {
            long returnCode = -1;
            lstdateattributes = new List<DateAttributes>();
            lstGender = new List<Gender>();
            lstMaritalStatus = new List<MaritalStatus>();
            try
            {
                Title_DAL titleDAL = new Title_DAL(globalContextDetails);
                returnCode = titleDAL.GetMetaData(out lstdateattributes, out lstGender, out lstMaritalStatus);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetMarital status", excp);
            }
            return returnCode;

        }

        public long GetProgressNotesTemplate(int TemplateID, out List<ProgressiveTemplate> lstTemplate)
        {
            long returnCode = -1;
            Title_DAL objDal = new Title_DAL(globalContextDetails);
            lstTemplate = new List<ProgressiveTemplate>();
            try
            {
                returnCode = objDal.GetProgressNotesTemplate(TemplateID, out lstTemplate);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Progressnotes template", ex);
            }
            return returnCode;
        }

        public long GetTemplate(out List<ProgressiveTemplate> lstProgressTemplate)
        {
            long returnCode = -1;
            lstProgressTemplate = new List<ProgressiveTemplate>();

            try
            {
                Title_DAL titleDAL = new Title_DAL(globalContextDetails);
                returnCode = titleDAL.GetTemplate(out lstProgressTemplate);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetTemplate ", excp);
            }
            return returnCode;

        }


        public long InsertProgressTemplate(long PatientID, long PatientVisitID, string Subjective, String Objective, string Assesment, string Plan, string PhysicianName, DateTime ReviewDate)
        {
            long returnCode = -1;
          

            try
            {
                Title_DAL titleDAL = new Title_DAL(globalContextDetails);
                returnCode = titleDAL.InsertProgressTemplate(PatientID, PatientVisitID, Subjective, Objective, Assesment, Plan, PhysicianName, ReviewDate);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetTemplate ", excp);
            }
            return returnCode;

        }

        public long GetProgessiveNotes(long PatientVisitID,out List<PatientProgressive> lstPatientProgressive)
        {
            long returnCode = -1;
            lstPatientProgressive = new List<PatientProgressive>();

            try
            {
                Title_DAL titleDAL = new Title_DAL(globalContextDetails);
                returnCode = titleDAL.GetProgessiveNotes(PatientVisitID, out lstPatientProgressive);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetTemplate ", excp);
            }
            return returnCode;

        }
     
     

        //public long LoadMetaData(out List<MetaData> lstPriority, out List<MetaData> lstSampleStatus, out List<MetaData> lstVisitType, out List<MetaData> lstSamplePeriod)
        //{
        //    long returnCode = -1;
        //    lstPriority = new List<MetaData>();
        //    lstSampleStatus = new List<MetaData>();
        //    lstVisitType = new List<MetaData>();
        //    lstSamplePeriod = new List<MetaData>();
        //    try
        //    {
        //        Title_DAL titleDAL = new Title_DAL(globalContextDetails);
        //        returnCode = titleDAL.LoadMetaData(out lstPriority, out lstSampleStatus, out lstVisitType, out lstSamplePeriod);
        //    }
        //    catch (Exception excp)
        //    {
        //        CLogger.LogError("Error while executing GetMarital status", excp);
        //    }
        //    return returnCode;

        //}


    }
}
