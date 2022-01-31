using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Attune.Podium.BusinessEntities;
using Attune.Solution.DAL;
using Attune.Podium.Common;

namespace Attune.Solution.BusinessComponent
{
    public class PatientEpisode_BL
    {
          ContextDetails globalContextDetails;
        public PatientEpisode_BL()
        {

        }
        public PatientEpisode_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        // PatientEpisode_DAL objPatEpisode = new PatientEpisode_DAL(globalContextDetails);
        PatientEpisode_DAL objPatEpisode;
        public long InsertPatientEpisodeBL(PatientEpisode lstPatientEpisode, List<VisitClientMapping> lstVisitClientMapping)
        {
            long returnCode = -1;
            try
            {
                objPatEpisode = new PatientEpisode_DAL(globalContextDetails);
                returnCode = objPatEpisode.InsertPatientEpisodeDAL(lstPatientEpisode, lstVisitClientMapping);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing AutheticateUser", ex);
            }
            return returnCode;
        }
        public long GetPatientEpisodeDet(long EpisodeID, long PatientID, int OrgID, out List<PatientEpisode> lstEpisode, out List<PatientEpisode> lstEpisode1)
        {
            long returnCode = -1;
            lstEpisode = new List<PatientEpisode>();
            lstEpisode1 = new List<PatientEpisode>();

            try
            {
                objPatEpisode = new PatientEpisode_DAL(globalContextDetails);
                returnCode = objPatEpisode.GetPatientEpisodeDet(EpisodeID, PatientID, OrgID, out lstEpisode, out lstEpisode1);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing AutheticateUser", ex);
            }
            return returnCode;
        }
        public long SearchEpisodePatient(string lPatientNo, string strSmartCardNo, string strPatientName,string strRelation,  string strDOB, string strLocation, string strOccupation,string strCity,string strMobile, int orgID, int parentID,string urno,long urnTypeID,int pageSize,int startRowIndex,string Nationality,string TPAID,string ClientID,DateTime FDate,DateTime TDate, out List<PatientEpisode> lstPatientEpisode)
        {
            long returnCode = -1;
            lstPatientEpisode = new List<PatientEpisode>();
            try
            {
                //Attune.Solution.DAL.PatientEpisode_DAL patientEpisodeDAL = new PatientEpisode_DAL(globalContextDetails);
                objPatEpisode = new PatientEpisode_DAL(globalContextDetails);
                returnCode = objPatEpisode.SearchEpisodePatient(lPatientNo, strSmartCardNo, strPatientName, strRelation, strDOB, strLocation, strOccupation, strCity, strMobile, orgID, parentID, urno, urnTypeID, pageSize, startRowIndex, Nationality, TPAID, ClientID, FDate, TDate, out lstPatientEpisode);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while searchpatient BL", ex);
            }
            return returnCode;
        }
    }
}
