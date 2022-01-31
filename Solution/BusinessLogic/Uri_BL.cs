using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using System.Collections;
using Attune.Podium.Common;


namespace Attune.Solution.BusinessComponent
{
    public class Uri_BL
    {
        ContextDetails globalContextDetails;
        public Uri_BL()
        {

        }
        public Uri_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
       public List<Investigation> GetInvestigation(int complaintID)
        {
            List<Investigation> investigations = new List<Investigation>();
            try
            {
                URI_DAL URIDAL = new URI_DAL(globalContextDetails);
                long returnCode = -1;
                returnCode = URIDAL.GetInvestigation(complaintID, out investigations);
                return investigations;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigation method", ex);
            }

            return investigations;
        }

       public long GetDiagnoseInfo(int complaintID, out ArrayList al)
       {
           long returnCode = -1;
           al = new ArrayList();

      
               return returnCode;
         


       }

       public List<History> GetHistory(int complaintID,int parentID)
       {
           List<History> histories = new List<History>();
           try
           {
               URI_DAL URIDAL = new URI_DAL(globalContextDetails);
               long returnCode = -1;
               returnCode = URIDAL.GetHistory(complaintID,parentID, out histories);
               return histories;
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while executing GetHistory method", ex);
           }
           return histories;
       }

       public List<History> GetHistoryByComplaintName(string complaintName, out int complaintID)
       {
           List<History> histories = new List<History>();
           complaintID = 0;
           try
           {
               URI_DAL URIDAL = new URI_DAL(globalContextDetails);
               long returnCode = -1;
               returnCode = URIDAL.GetHistoryByComplaintName(complaintName, out complaintID, out histories);
               return histories;
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while executing GetHistoryByComplaintName", ex);
           }
           return histories;
       }
       
       public List<Examination> GetExamination(int complaintID,int parentID)
        {
            List<Examination> examinations = new List<Examination>();
            try
            {
                URI_DAL URIDAL = new URI_DAL(globalContextDetails);                
                long returnCode = -1;
                returnCode = URIDAL.GetExamination(complaintID,parentID,out examinations);
                return examinations;
            }
            catch(Exception ex)
            {
                CLogger.LogError("Error while executing GetExamination", ex);
            }
            return examinations;
        }

       public long GetExamination(string examinationName, out List<Examination> lstExamination)
       {
           long returnCode = -1;
           lstExamination = new List<Examination>();
           try
           {
               URI_DAL URIDAL = new URI_DAL(globalContextDetails);
               returnCode = URIDAL.GetExamination(examinationName, out lstExamination);
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while executing GetExamination", ex);
           }
           return returnCode;
       }

       public long GetComplaint(string complaintName, out List<Complaint> lstComplaint)
       {
           long returnCode = -1;
           lstComplaint = new List<Complaint>();
           try
           {
               URI_DAL URIDAL = new URI_DAL(globalContextDetails);
               returnCode = URIDAL.GetComplaint(complaintName, out lstComplaint);
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while executing GetExamination", ex);
           }
           return returnCode;
       }

       public long GetHistory(string historyName, out List<History> lstHistory)
       {
           long returnCode = -1;
           lstHistory = new List<History>();
           try
           {
               URI_DAL URIDAL = new URI_DAL(globalContextDetails);
               returnCode = URIDAL.GetHistory(historyName, out lstHistory);
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while executing GetExamination", ex);
           }
           return returnCode;
       }

       #region UnFound Diagnosis

       public long SaveUnFoundDiagnosisData(int complaintID, string admission,
                                                 long patientID, string NextReviewDate,
                                                 long visitID, List<PatientComplaint> lstPatientComplaint,
                                                 List<PatientHistory> lstHistory, List<PatientExamination> lstExamination,
                                                 List<OrderedInvestigations> lstInv, List<DrugDetails> lstdrugs,
                                                 List<PatientAdvice> lstAdvice, List<PatientVitals> lstPatientVitals,
                                                 long OrgID, out int pOrderedInvCnt, string paymentstatus, string UID, string PhysicianComments)
       {
           long retval = -1;
           pOrderedInvCnt = 0;
           //long labno = 0;

           URI_DAL uriDal = new URI_DAL(globalContextDetails);
try
           {
               retval = uriDal.SaveUnFoundDiagnosisData(complaintID, admission, patientID, NextReviewDate, visitID, lstPatientComplaint,
                   lstHistory, lstExamination, lstInv, lstdrugs, lstAdvice, lstPatientVitals, OrgID, out pOrderedInvCnt, paymentstatus, 
                   UID, PhysicianComments);
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while saving Unfound diagnosis data :", ex);
           }
           return retval;
       }


       #endregion
       #region Drugs
       public long GetComplaintDrugs(int complaintID, out List<Drugs> drugs)
        {

           long returnCode = -1;
           drugs = null;

           try
           {

               URI_DAL uriDal = new URI_DAL(globalContextDetails);
               returnCode = uriDal.GetComplaintDrugs(complaintID, out drugs);
           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing GetComplaintDrugs BL", excp);
           }
           return returnCode;
        }

       public List<DrugFrequency> GetDrugFrequencies()
        {
           URI_DAL uridal = new URI_DAL(globalContextDetails);
           List<DrugFrequency> dFrequencies = new List<DrugFrequency>();

           try
           {
               uridal.GetDrugFrequencies(out dFrequencies);
           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing GetDrugFrequencies BL", excp);
           }
           return dFrequencies;
        }

       public long GetDrugNames(string drugName, int count, out List<string> drugNames)
        {
           long returnCode = -1;
           URI_DAL uriDal = new URI_DAL(globalContextDetails);
           drugNames = null;

           try
           {
               returnCode = uriDal.GetDrugNames(drugName, count, out drugNames);
           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing GetDrugNames BL", excp);
           }
           return returnCode;

        }

       public long GetDrugID(string drugName, out long drugID)
        {
           long returnCode = -1;
           URI_DAL uriDal = new URI_DAL(globalContextDetails);
           drugID = 0;

           try
           {
               returnCode = uriDal.GetDrugID(drugName, out drugID);
           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing GetDrugsID BL", excp);
           }
           return returnCode;
        }

       //public long GetDrugROADose(string drgName, int FMID, out List<DrugROA> dROA, out List<DrugBrand> strength)
       //{
       //    long returnCode = -1;
       //    dROA = new List<DrugROA>();
       //    strength = new List<DrugBrand>();           
       //    URI_DAL uDAL = new URI_DAL(globalContextDetails);
       //    try
       //    {
       //        returnCode = uDAL.GetDrugROADose(drgName, FMID, out dROA, out strength);
       //    }
       //    catch (Exception excp)
       //    {
       //        CLogger.LogError("Error while executing GetDrugROADose BL", excp);
       //    }
       //    return returnCode;
       //}

       #endregion

       /// <summary>
       /// Converts a given PatientComplaint List to a DataTable
       /// </summary>
       /// <param name="hists"></param>
       /// <returns></returns>
     

       /// <summary>
       /// Converts a given PatientHistory List to a DataTable
       /// </summary>
       /// <param name="hists"></param>
       /// <returns></returns>

  public long SaveExamination(List<PatientExamination> pExamination)
       {
           long returnCode = -1;
            
           URI_DAL uDal = new URI_DAL(globalContextDetails);
           returnCode = uDal.SavePatientExamination(pExamination);
           return returnCode;

       }
       public long SaveHIE(List<PatientComplaint> pComplaint, List<PatientHistory> pHistory, List<PatientExamination> pExamination, 
           List<OrderedInvestigations> pInvestigationHL, List<DrugDetails> pDrgDetials, 
           PatientVisit entPatientVisit, List<PatientAdvice> lstPatientAdvice, List<PatientVitals> lstPatientVitals, List<BackgroundProblem> pBgP, long orgID, string gUID)
       {
           long returnCode = -1;
          URI_DAL uDal = new URI_DAL(globalContextDetails);
           returnCode = uDal.SaveHIE(pComplaint, pHistory, pInvestigationHL, pExamination, pDrgDetials, entPatientVisit, lstPatientAdvice, lstPatientVitals, pBgP, orgID, gUID);
           return returnCode; 
       }


        public long SaveHistory(PatientHistory patientHistory)
        {
            long returnCode = -1;
            
            return returnCode;
        }


        public long SaveDiagnose(string complaintdesc, string examDesc, string historyDesc, long visitID, int invID, long createdBy)
        {
            long returnCode = -1;
            URI_DAL uriDal = new URI_DAL(globalContextDetails);

            try
            {
                returnCode = uriDal.SaveDiagnose(complaintdesc, examDesc, historyDesc, visitID, invID, createdBy);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveDiagnose BL",excp);
            }
            
            return returnCode;
        }

        public long SavePrescription(long visitID, long drugID, string frqID, string duration, long createdBy)
        {
            long returnCode = -1;
            URI_DAL uriDal = new URI_DAL(globalContextDetails);

            try
            {

                returnCode = uriDal.SavePrescription(visitID, drugID, frqID, duration, createdBy);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SavePrescription BL", excp);
            }
            return returnCode;
        }

       
         

        public long SavePrescription(List<DrugDetails> Pres, List<DrugDetails> adminedPrescription)
        {
            long returnCode = -1;
            URI_DAL uriDal = new URI_DAL(globalContextDetails);
        
           
            try
            {
                returnCode = uriDal.SavePrescription(Pres, adminedPrescription);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SavePrescription BL", excp);
            }
            return returnCode;
        }

        public long UpdatePrescription(List<DrugDetails> UpdatePrescription)
        {
            long returnCode = -1;
            URI_DAL uriDal = new URI_DAL(globalContextDetails);
          
            try
            {
                returnCode = uriDal.UpdatePrescription(UpdatePrescription);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing UpdatePrescription BL", excp);
            }
            return returnCode;
        }


        public long DeletePatientDiagnoseDetail(int complaintID, long patientVisitID, string rmvPres)
        {
            return new URI_DAL(globalContextDetails).DeletePatientDiagnoseDetail(complaintID, patientVisitID,rmvPres);
        }


        public long GetSearchPatientPrescription(long VisitID, long pLID, long pRID, out List<DrugDetails> lstPrescription, out List<DrugDetails> lstAdminsteredDrugs)
        {
            long returnCode = -1;
            URI_DAL URIDAL = new URI_DAL(globalContextDetails);
            lstPrescription = new List<DrugDetails>();
            lstAdminsteredDrugs = new List<DrugDetails>();
            try
            {
                returnCode = URIDAL.GetSearchPatientPrescription(VisitID, pLID, pRID, out lstPrescription, out lstAdminsteredDrugs);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDrugDetails method", ex);
            }

            return returnCode;
        }

        public long GetDiagnosePageData(int complaintID, out List<Examination> lstExamination,
           out List<History> lstHistory, out List<InvestigationMaster> lstInvestigation, out string complaintName)
        {
            long returnCode = -1;
            complaintName = string.Empty;
            lstExamination = new List<Examination>();
            lstHistory = new List<History>();
            lstInvestigation = new List<InvestigationMaster>();
            try
            {
                returnCode = new URI_DAL(globalContextDetails).GetDiagnosePageData(complaintID, out lstExamination, out lstHistory, out lstInvestigation, out complaintName);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDiagnosePageData BL", ex);
            }
            return returnCode;
        }


       
     
  
       
        public long InsertPatientPrescriptionBulk(List<DrugDetails> drgList)
        {
            long returnCode = -1;
            try
            {
                URI_DAL uDal = new URI_DAL(globalContextDetails);
                returnCode = uDal.InsertPatientPrescriptionBulk(drgList);
                return returnCode;
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error Saving Drugs in InsertPatientPrescriptionBulk", excp);

            }
            return returnCode;
        }
      
        

        
    }
}
