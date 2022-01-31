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
    public class Counselling_DAL
    {
         ContextDetails globalContextDetails;
        public  Counselling_DAL()
        {

        }
        public Counselling_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetCounselType(out List<CounsellingName> lstCounsellingName)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetCounsellingNameCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstCounsellingName = new List<CounsellingName>();
            DataSet ds = new DataSet();
            try
            {                
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCounsellingName);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Loading Counselling Name in Counselling_DAL", ex);
            }
            return returnCode;
        }

        public long GetPsychiatricReview(out List<PsychiatricReview> lstPsychiatricReview)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetPsychiatricReviewCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPsychiatricReview = new List<PsychiatricReview>();
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPsychiatricReview);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Loading Counselling Name in Counselling_DAL", ex);
            }
            return returnCode;
        }

        public long SavePatientCounselling(PatientCounselling ObjPatientCounselling)
        {
            long returncode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pSavePatientCounsellingCommand(ObjPatientCounselling.PatientID,ObjPatientCounselling.VisitID,ObjPatientCounselling.CounselID,ObjPatientCounselling.Symptoms,ObjPatientCounselling.IsConfidential,ObjPatientCounselling.ReviewOfSystem,ObjPatientCounselling.Examination,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DiscountMaster", ex);
            }
            return returncode;
        }

        public long GetPreviousVisitdetails(long patientID, long VisitID,out List<CounsellingDetails> lstCounsellingDetails)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetPreviousVisitdetailsCommand(patientID,VisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstCounsellingDetails = new List<CounsellingDetails>();
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCounsellingDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Loading Counselling Details in Counselling_DAL", ex);
            }
            return returnCode;
        }

        public long GetCounsellingDetails(long patientID, long visitID, out List<CounsellingDetails> lstCounsellingDetails)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetCounsellingDetailsCommand(patientID, visitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstCounsellingDetails = new List<CounsellingDetails>();
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCounsellingDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Loading Counselling Details in Counselling_DAL", ex);
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
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetCounsellingCaseSheetCommand(VisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientComplaint);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatient);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstCounsellingDetails);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstPatientAdvice);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstPatientVisit);
                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstPatientPrescription);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Loading Counselling Details in Counselling_DAL", ex);
            }
            return returnCode;

        }

        public long GetLastVisitID(long patientID, int OrgID, out long LastVisitID)
        {
            long returnCode = -1;
            LastVisitID = -1;
            SqlCommand cmd = Command.pGetLastVisitIDCommand(patientID, OrgID, out LastVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    LastVisitID = Convert.ToInt64(cmd.Parameters["@pVisitID"].Value);
                }                
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetLastVisitID in Counselling_DAL", ex);
            }
            return returnCode;

        }
    }
}
