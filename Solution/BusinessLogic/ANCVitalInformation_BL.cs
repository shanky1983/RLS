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
    public class ANCVitalInformation_BL
    {
          ContextDetails globalContextDetails;
        public ANCVitalInformation_BL()
        {

        }
        public ANCVitalInformation_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long getVitalInformationTrend(long patientVisitId, out List<PatientVitals> lstPatientVitals, out List<InvestigationValues> lstInvestigationValues, out decimal pWeightGained)
        {
            long returncode = -1;

            lstPatientVitals = new List<PatientVitals>();
            lstInvestigationValues = new List<InvestigationValues>();
            pWeightGained = -1;
            try
            {
                returncode = new ANCVitalInformation_DAL(globalContextDetails).getVitalInformationTrend(patientVisitId, out lstPatientVitals, out lstInvestigationValues, out pWeightGained);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL getVitalInformationTrend", ex); 
            }

            return returncode;
        }

        //public long getANCFollowUP(int ComplaintId, int Invid, string ComplicationName1, string ComplicationName2, out List<History> lstHistory, out List<Complication> lstComplication, out List<Complication> lstComplication1, out List<Examination> lstExamination, out List<FetalPresentations> lstFetalPresentations, out List<FetalPosition> lstFetalPosition, out List<FetalMovements> lstFetalMovements, out List<FetalFHS> lstFetalFHS)
        //{
        //    long returncode = -1;

        //    lstHistory = new List<History>();
        //    lstComplication = new List<Complication>();
        //    lstComplication1 = new List<Complication>();
        //    lstExamination = new List<Examination>();
        //    lstFetalMovements = new List<FetalMovements>();
        //    lstFetalPresentations = new List<FetalPresentations>();
        //    lstFetalPosition = new List<FetalPosition>();
        //    lstFetalFHS = new List<FetalFHS>();

        //    try
        //    {
        //        returncode = new ANCVitalInformation_DAL(globalContextDetails).getANCFollowUP(ComplaintId, Invid, ComplicationName1, ComplicationName2, out lstHistory, out lstComplication, out lstComplication1, out lstExamination, out lstFetalPresentations, out lstFetalPosition, out lstFetalMovements, out lstFetalFHS);
        //    }
        //    catch(Exception ex)
        //    {
        //        CLogger.LogError("Error in BL getANCFollowUP", ex);
        //    }

        //    return returncode;
        //}

        public long getANCFollowUP(long pvisitID, long pPatientID, int ComplaintId, string CompName, string ComplicationName, out List<History> lstHistory, out List<Complication> lstCompNamee, out List<Complication> lstComplication, out List<FetalPresentations> lstFetalPresentations, out List<FetalPosition> lstFetalPosition, out List<FetalMovements> lstFetalMovements, out List<FetalFHS> lstFetalFHS, out List<InvestigationMaster> lstInvestigationMaster, out int noofFetals, out int pCountBaseLine)
        {
            long returncode = -1;
            noofFetals = 0;
            pCountBaseLine = -1;

            lstHistory = new List<History>();
            lstCompNamee = new List<Complication>();
            lstComplication = new List<Complication>();
            //lstComplication2 = new List<Complication>();
            //lstExamination = new List<Examination>();
            lstFetalMovements = new List<FetalMovements>();
            lstFetalPresentations = new List<FetalPresentations>();
            lstFetalPosition = new List<FetalPosition>();
            lstFetalFHS = new List<FetalFHS>();
            lstInvestigationMaster = new List<InvestigationMaster>();

            try
            {
                returncode = new ANCVitalInformation_DAL(globalContextDetails).getANCFollowUP(pvisitID, pPatientID, ComplaintId, CompName, ComplicationName, out lstHistory, out lstCompNamee, out lstComplication, out lstFetalPresentations, out lstFetalPosition, out lstFetalMovements, out lstFetalFHS, out lstInvestigationMaster, out noofFetals, out pCountBaseLine);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL getANCFollowUP", ex);
            }

            return returncode;
        }


        public long pGetANCExamination(int ExaminationId, out List<Examination> lstExamination, out List<Examination> lstExamination1)
        {
            long returncode = -1;
            lstExamination = new List<Examination>();
            lstExamination1 = new List<Examination>();

            try
            {
                returncode = new ANCVitalInformation_DAL(globalContextDetails).pGetANCExamination(ExaminationId, out lstExamination, out lstExamination1);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL pGetANCExamination", ex);
            }

            return returncode;
        }
        public long pGetANCFollowUPExamination(int ComplaintID, int ParentID, out List<Examination> lstExamination, out List<Examination> lstExamination1, out List<Complication> lstComplication)
        {
            long returncode = -1;
            lstExamination = new List<Examination>();
            lstExamination1 = new List<Examination>();
            lstComplication = new List<Complication>();

            try
            {
                returncode = new ANCVitalInformation_DAL(globalContextDetails).pGetANCFollowUPExamination(ComplaintID, ParentID, out lstExamination, out lstExamination1, out lstComplication);
            }
            catch (Exception ex)
            {
                CLogger.LogError("error in BLpGetANCFollowUPExamination", ex);
            }
            return returncode;
        }
        public long pGetANCVisitSummary(long PatientID, out List<ANCPatientDetails> lstANCPatientDetails, out List<BackgroundProblem> lstBackgroundProblem, out List<PatientPastVaccinationHistory> lstPatientVaccinationHistory, out List<PatientUltraSoundData> lstUSD)
        {
            long returncode = -1;

            lstANCPatientDetails = new List<ANCPatientDetails>();
            lstBackgroundProblem = new List<BackgroundProblem>();
            lstPatientVaccinationHistory = new List<PatientPastVaccinationHistory>();
            lstUSD = new List<PatientUltraSoundData>();

            try
            {
                returncode = new ANCVitalInformation_DAL(globalContextDetails).pGetANCVisitSummary(PatientID, out lstANCPatientDetails, out lstBackgroundProblem, out lstPatientVaccinationHistory, out lstUSD);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL pGetANCVisitSummary", ex);
            }
            return returncode;
        }
        public long pGetANCComplication(out List<Complication> lstComplication)
        {
            long returncode = -1;
            lstComplication = new List<Complication>();
            try
            {
                returncode = new ANCVitalInformation_DAL(globalContextDetails).pGetANCComplication(out lstComplication);
            }
            catch (Exception ex)
            {
                CLogger.LogError("error in BL", ex);
            }
            return returncode;
        }
        public long pInsertANCFollowup(List<PatientFetalFindings> lstPatientFetalFindings, out int retStaus)
        {
            long returncode = -1;
            retStaus = -1;
            try
            {
                return new ANCVitalInformation_DAL(globalContextDetails).pInsertANCFollowup(lstPatientFetalFindings, out retStaus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL pInsertANCFollowup", ex);
            }
            return returncode;
        }
        public long saveHECFC(string flag, long patientID,
            long patientVisitID,
            List<PatientComplaint> pComplaint,
            List<PatientHistory> lstPatientHistory,
            List<PatientExamination> lstPatientExamination,
            List<PatientComplication> lstPatientComplication,
            List<PatientFetalFindings> lstPatientFetalFindings,
            List<PatientAdvice> pPatientAdvice, 
            List<DrugDetails> pDrgDetials,
            List<PatientVaccinationHistory> pVaccination,
            ANCPatientDetails pANCPatienDetails, PatientVisit entPatientVisit,
            PatienttoScanforANC entANCScan, 
            List<OrderedInvestigations> PatientInvestigationHL,
            long orgID, out int pOrderedInvCnt, string UID,
            string PatientObservation,int OrgAddId,long LID)
        {
            long returncode = -1;
            ANCVitalInformation_DAL ancDAL = new ANCVitalInformation_DAL(globalContextDetails);
            returncode = ancDAL.saveHECFC(flag, patientID, patientVisitID, pComplaint,lstPatientHistory,
                lstPatientExamination, lstPatientComplication,lstPatientFetalFindings, pPatientAdvice,pDrgDetials,pVaccination,
                pANCPatienDetails, entPatientVisit, entANCScan, PatientInvestigationHL, orgID,
                out pOrderedInvCnt, UID, PatientObservation, OrgAddId, LID);

             return returncode;
        }
        
    }
}
