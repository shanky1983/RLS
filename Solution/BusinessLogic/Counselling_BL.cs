using System;
using System.Data;
using System.Configuration;
using System.Web;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using System.Collections.Generic;
using Attune.Podium.Common;

namespace Attune.Solution.BusinessComponent
{
    public class Counselling_BL
    {
        ContextDetails globalContextDetails;
        public Counselling_BL()
        {

        }
        public Counselling_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        
        public long GetCounselType(out List<CounsellingName> lstCounsellingName)
        {
            long returnCode = -1;
            lstCounsellingName = new List<CounsellingName>();
            Counselling_DAL CounsellingDAL =new Counselling_DAL(globalContextDetails);
            try
            {
                returnCode = CounsellingDAL.GetCounselType(out lstCounsellingName);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Loading CounselType in Counselling_BL", ex);
            }
            return returnCode;
        }

        public long GetPsychiatricReview(out List<PsychiatricReview> lstPsychiatricReview)
        {
            long returnCode = -1;
            lstPsychiatricReview = new List<PsychiatricReview>();
            Counselling_DAL CounsellingDAL = new Counselling_DAL(globalContextDetails);
            try
            {
                returnCode = CounsellingDAL.GetPsychiatricReview(out lstPsychiatricReview);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Loading Review of System in Counselling_BL", ex);
            }
            return returnCode;
        }


        public long SavePatientCounselling(PatientCounselling objPatientCounselling)
        {
            long returnCode = -1;
            Counselling_DAL ObjCounsellingDAL = new Counselling_DAL(globalContextDetails);
            try
            {
                returnCode = ObjCounsellingDAL.SavePatientCounselling(objPatientCounselling);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Saving Patient Counselling", ex);
            }
            return returnCode;
        }

        public long GetPreviousVisitdetails(long patientID, long VisitID, out List<CounsellingDetails> lstCounsellingDetails)
        {
            long returnCode = -1;
            lstCounsellingDetails = new List<CounsellingDetails>();
            Counselling_DAL CounsellingDAL = new Counselling_DAL(globalContextDetails);
            try
            {
                returnCode = CounsellingDAL.GetPreviousVisitdetails(patientID, VisitID,out lstCounsellingDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Loading CounsellingDetails in Counselling_BL", ex);
            }
            return returnCode;
        }

        public long GetCounsellingDetails(long patientID, long visitID, out List<CounsellingDetails>lstCounsellingDetails)
        {
            long returnCode = -1;
            lstCounsellingDetails = new List<CounsellingDetails>();
            Counselling_DAL CounsellingDAL = new Counselling_DAL(globalContextDetails);
            try
            {
                returnCode = CounsellingDAL.GetCounsellingDetails(patientID, visitID, out lstCounsellingDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Loading CounsellingDetails in Counselling_BL", ex);
            }
            return returnCode;
        }

        public long GetCounsellingCaseSheet(long VisitID, out List<PatientComplaint> lstPatientComplaint, out List<Patient> lstPatient, out List<CounsellingDetails> lstCounsellingDetails, out List<PatientAdvice> lstPatientAdvice, out List<PatientVisit> lstPatientVisit, out List<PatientPrescription> lstPatientPrescription)
        {
            long returnCode = -1;
            lstCounsellingDetails = new List<CounsellingDetails>();
            lstPatient = new List<Patient>();
            lstPatientComplaint = new List<PatientComplaint>();
            lstPatientAdvice = new List<PatientAdvice>();
            lstPatientVisit = new List<PatientVisit>();
            lstPatientPrescription = new List<PatientPrescription>();
            Counselling_DAL CounsellingDAL = new Counselling_DAL(globalContextDetails);
            try
            {
                returnCode = CounsellingDAL.GetCounsellingCaseSheet(VisitID, out lstPatientComplaint, out lstPatient, out lstCounsellingDetails, out lstPatientAdvice, out lstPatientVisit, out lstPatientPrescription);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Loading GetCounsellingCaseSheet in CounsellingBL GetCounsellingCaseSheet()", ex);
            }
            return returnCode;
        }

        public long GetLastVisitID(long PatientID, int OrgID, out long LastVisitID)
        {
            long returnCode = -1;
            LastVisitID = -1;
            Counselling_DAL CounsellingDAL = new Counselling_DAL(globalContextDetails);
            try
            {
                returnCode = CounsellingDAL.GetLastVisitID(PatientID, OrgID, out LastVisitID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetLastVisitID in Counselling_BL", ex);
            }
            return returnCode;
        }
    }
}
