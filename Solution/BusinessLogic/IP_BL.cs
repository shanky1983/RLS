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
    public class IP_BL
    {   
         ContextDetails globalContextDetails;
        public IP_BL()
        {

        }
        public IP_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
       public long SaveDischargeseqDetails(int pOrgID,DataTable lstdischargesummary)
        {
            long returnCode = -1;           
            IP_DAL IP = new IP_DAL(globalContextDetails);
            try
            {
                returnCode = IP.SaveDischargeseqDetails(pOrgID,lstdischargesummary);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing IPDischargesummary in IP_BL", ex);
            }
            return returnCode;
        }

        public long GetAllDischargeSummarySeq(int pOrgID, out List<DischargeSummarySeq> lstdischargesummary)
        {
            long returnCode = -1;
            lstdischargesummary = new List<DischargeSummarySeq>();
            IP_DAL IP = new IP_DAL(globalContextDetails);
            try
            {
                returnCode = IP.GetAllDischargeSummarySeq(pOrgID, out lstdischargesummary);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing IPDischargesummary in IP_BL", ex);
            }
            return returnCode;
        }

        public long GetIPTreatmentPlanMaster(int OrgID, out List<IPTreatmentPlanMaster> lstIPTreatmentPlanMaster)
        {
            long returnCode = -1;
            lstIPTreatmentPlanMaster = new List<IPTreatmentPlanMaster>();
            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {
                returnCode = ipDAL.GetIPTreatmentPlanMaster(OrgID, out lstIPTreatmentPlanMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPTreatmentPlanMaster in IP_BL", ex);
            }
            return returnCode;
        }


        public long SaveIPCaseRecord(List<PatientHistory> lstPatientHistory, List<PatientVitals> lstPatientVitals, List<PatientExamination> lstPatientExamination, 
            List<PatientComplaint> lstPatientComplaint,
                 List<IPTreatmentPlan> lstIPTreatmentPlan, List<DrugDetails> lstDrugDetails, RTAMLCDetails objRTAMLC, List<BackgroundProblem> lstBackgroundProblem, List<BackgroundProblem> lstOtherBackgroundProblem,
                 ANCPatientDetails objANCPatientDetails, int OrgID, long PatientVisitID, long patientID, long LID, string DetailsHistory,
                 List<PatientAdvice> lstPatientAdvice, string nextReviewDate, DateTime dtActualRewDt)
        {
            long returnCode = -1;
            //pOrderedInvCnt = 0;
            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {
                returnCode = ipDAL.SaveIPCaseRecord(lstPatientHistory, lstPatientVitals, lstPatientExamination, lstPatientComplaint,
                    lstIPTreatmentPlan, lstDrugDetails, objRTAMLC, lstBackgroundProblem, lstOtherBackgroundProblem, objANCPatientDetails,
                    OrgID, PatientVisitID, patientID, LID, DetailsHistory, lstPatientAdvice, nextReviewDate, dtActualRewDt);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveIPCaseRecord in IP_BL", ex);
            }
            return returnCode;
        }
        public long InsertPatDisChkList(long pID, long visitID, long createdBy, DateTime disDT, int typeofDischarge, string conOnDis, string destPostDis, List<PatientDisChkLstDtl> lstPatDisChkList, out long retCode)
        {
            long returnCode = -1;
            retCode = -1;
            try
            {
                returnCode = new IP_DAL(globalContextDetails).InsertPatDisChkList(pID, visitID, createdBy, disDT, typeofDischarge, conOnDis, destPostDis, lstPatDisChkList, out retCode);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL InsertPatDisChkList", ex);
            }
            return returnCode;
        }
        public long GetPatientVitalsAndComplaint(long patientVisitID, int OrgID, out  List<VitalsUOMJoin> lstVitalsUOMJoin, out List<PatientComplaint> lstPatientComplaint)
        {
            long returnCode = -1;
            lstVitalsUOMJoin = new List<VitalsUOMJoin>();
            lstPatientComplaint = new List<PatientComplaint>();

            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {
                returnCode = ipDAL.GetPatientVitalsAndComplaint(patientVisitID, OrgID, out lstVitalsUOMJoin, out lstPatientComplaint);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientVitalsAndComplaint in IP_BL", ex);
            }
            return returnCode;
        }
        public long GetOperationNotes(long patientVisitID, int OrgID, out List<SurgeryType> lstSurgeryType, out List<OperationType> lstOperationType, out List<AnesthesiaType> lstAnesthesiaType, out List<Physician> lstChiefOperater, out List<Physician> lstAnesthisa, out List<AHPStaff> lstTechnicianName, out List<Nurse> lstNurseName, out List<IPTreatmentPlan> lstIPTreatmentPlan, out List<Patient> lstPatient, out  List<IPTreatmentPlan> lstIPTreatmentPlanFromCaserecord,out List<IPTreatmentPlanDetails> lstIPTreatmentPlanDetails)
        {
            long returnCode = -1;

            lstSurgeryType = new List<SurgeryType>();
            lstOperationType = new List<OperationType>();
            lstAnesthesiaType = new List<AnesthesiaType>();
            lstChiefOperater = new List<Physician>();
            lstAnesthisa = new List<Physician>();
            lstTechnicianName = new List<AHPStaff>();
            lstNurseName = new List<Nurse>();
            lstIPTreatmentPlan = new List<IPTreatmentPlan>();
            lstPatient = new List<Patient>();
            lstIPTreatmentPlanFromCaserecord = new List<IPTreatmentPlan>();
            lstIPTreatmentPlanDetails = new List<IPTreatmentPlanDetails>();



            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {
                returnCode = ipDAL.GetOperationNotes(patientVisitID, OrgID, out lstSurgeryType, out lstOperationType, out lstAnesthesiaType, out lstChiefOperater, out lstAnesthisa, out lstTechnicianName, out lstNurseName, out lstIPTreatmentPlan, out lstPatient, out lstIPTreatmentPlanFromCaserecord, out lstIPTreatmentPlanDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOperationNotes in IP_BL", ex);
            }
            return returnCode;
        }


        public long GetOperationNotesForUpdate(long patientVisitID, int OrgID, long OperationID, out List<OperationNotes> lstOperationNotes, out List<OperationFinding> lstOperationFinding, out List<OperationComplication> lstOperationComplication, out List<Physician> lstChiefPhysicianOperationStaff, out List<Physician> lstAssistantPhysicianOperationStaff, out List<Physician> lstAnesthisiaOperationStaff, out List<AHPStaff> lstTechnicianOperationStaff, out List<Nurse> lstNurseOperationStaff, out List<IPTreatmentPlan> lstIPTreatmentPlanByOperationID)
        {
            long returnCode = -1;
            lstOperationNotes = new List<OperationNotes>();
            lstOperationFinding = new List<OperationFinding>();
            lstOperationComplication = new List<OperationComplication>();

            lstChiefPhysicianOperationStaff = new List<Physician>();
            lstAssistantPhysicianOperationStaff = new List<Physician>();
            lstAnesthisiaOperationStaff = new List<Physician>();
            lstTechnicianOperationStaff = new List<AHPStaff>();
            lstNurseOperationStaff = new List<Nurse>();
            lstIPTreatmentPlanByOperationID = new List<IPTreatmentPlan>();


            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {
                returnCode = ipDAL.GetOperationNotesForUpdate(patientVisitID, OrgID, OperationID, out lstOperationNotes, out lstOperationFinding, out lstOperationComplication, out lstChiefPhysicianOperationStaff, out lstAssistantPhysicianOperationStaff, out lstAnesthisiaOperationStaff, out lstTechnicianOperationStaff, out lstNurseOperationStaff, out lstIPTreatmentPlanByOperationID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOperationNotesForUpdate in IP_BL", ex);
            }
            return returnCode;
        }
        public long GetIPCaseRecord(long patientVisitID, long pLID, long pRID,string Priviousvisitdrug, out List<PatientHistory> lstPatientHistory, 
            out List<PatientExamination> lstPatientExamination, out List<DrugDetails> lstDrugDetails, out List<RTAMLCDetails> lstRTAMLCDetails, 
            out List<PatientComplaint> lstPatientComplaint, out List<IPTreatmentPlan> lstIPTreatmentPlan, out List<BackgroundProblem> lstBackgroundProblem, 
            out List<PatientVitals> lstPatientVitals, out List<ANCPatientDetails> lstANCPatientDetails, 
            out List<PatientInvestigation> lstPatientInvestigation, out List<OrderedInvestigations> lstIPPatientPerformedInvestigation, 
            out List<IPTreatmentPlan> lstPerformedIPTreatmentPlan, out List<BackgroundProblem> lstOtherBackgroundProblem,
            out List<PatientHistoryExt> lstPatientHistoryExt, out List<PatientAdvice> lstPatientAdvice, out string strNextReviewDt,
            out List<PatientVisit> lstPrevVisits)
        {
            long returnCode = -1;
            lstPatientHistory = new List<PatientHistory>();
            lstPatientExamination = new List<PatientExamination>();
            lstDrugDetails = new List<DrugDetails>();
            lstRTAMLCDetails = new List<RTAMLCDetails>();
            lstPatientComplaint = new List<PatientComplaint>();
            lstIPTreatmentPlan = new List<IPTreatmentPlan>();
            lstBackgroundProblem = new List<BackgroundProblem>();
            lstPatientVitals = new List<PatientVitals>();
            lstANCPatientDetails = new List<ANCPatientDetails>();
            lstPatientInvestigation = new List<PatientInvestigation>();
            lstIPPatientPerformedInvestigation = new List<OrderedInvestigations>();
            lstPerformedIPTreatmentPlan = new List<IPTreatmentPlan>();
            lstOtherBackgroundProblem = new List<BackgroundProblem>();
            lstPatientHistoryExt = new List<PatientHistoryExt>();
            lstPatientAdvice = new List<PatientAdvice>();
            strNextReviewDt = string.Empty;
            lstPrevVisits = new List<PatientVisit>();

            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {
                returnCode = ipDAL.GetIPCaseRecord(patientVisitID, pLID, pRID,Priviousvisitdrug, out lstPatientHistory, out lstPatientExamination, out lstDrugDetails, 
                    out lstRTAMLCDetails, out lstPatientComplaint, out lstIPTreatmentPlan, out lstBackgroundProblem, out lstPatientVitals, 
                    out lstANCPatientDetails, out lstPatientInvestigation, out lstIPPatientPerformedInvestigation, out lstPerformedIPTreatmentPlan, 
                    out lstOtherBackgroundProblem, out lstPatientHistoryExt, out lstPatientAdvice, out strNextReviewDt,
                    out lstPrevVisits);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPCaseRecord in IP_BL", ex);
            }
            return returnCode;
        }

        public long GetCorporateMaster(int OrgID, out List<CorporateMaster> lstCorporateMaster)
        {
            long returnCode = -1;
            lstCorporateMaster = new List<CorporateMaster>();
            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {
                returnCode = ipDAL.GetCorporateMaster(OrgID, out lstCorporateMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetCorporateMaster in IP_BL", ex);
            }
            return returnCode;
        }
        public long GetIPVisitDetails(long PatientVisitID, out List<PatientVisit> lstPatientVisit)
        {
            long returnCode = -1;
            lstPatientVisit = new List<PatientVisit>();
            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {
                returnCode = ipDAL.GetIPVisitDetails(PatientVisitID, out lstPatientVisit);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPVisitDetails in IP_BL", ex);
            }
            return returnCode;
        }
        public long GetIPOrganDonation(long patientID, out List<OrganRegWithMapping> lstOrgRegWithMapping)
        {
            long returnCode = -1;
            lstOrgRegWithMapping = new List<OrganRegWithMapping>();
            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {
                returnCode = ipDAL.GetIPOrganDonation(patientID, out lstOrgRegWithMapping);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPOrganDonation in IP_BL", ex);
            }
            return returnCode;
        }
        public long SaveCorporateMaster(CorporateMaster CorporateMaster)
        {
            long lresult = -1;
            try
            {
                IP_DAL ipDAL = new IP_DAL(globalContextDetails);
                lresult = ipDAL.SaveCorporateMaster(CorporateMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveCorporateMaster in IP_BL", ex);
            }
            return lresult;
        }
        public long GetIPPhysicianListByOrg(int orgID, out List<Physician> lstPhysician)
        {
            long returnCode = -1;
            lstPhysician = new List<Physician>();
            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {
                returnCode = ipDAL.GetIPPhysicianListByOrg(orgID, out lstPhysician);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetIPPhysicianListByOrg in IP_BL", excp);
            }
            return returnCode;
        }




        public long GetMaxOfVitalsSetID(long patientVisitID, out List<PatientVitals> lstMaxOfVitalsSetID)
        {
            long returnCode = -1;
            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            lstMaxOfVitalsSetID = new List<PatientVitals>();
            try
            {
                returnCode = ipDAL.GetMaxOfVitalsSetID(patientVisitID, out lstMaxOfVitalsSetID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetMaxOfVitalsSetID in IP_BL", excp);
            }
            return returnCode;
        }


        public long LoadDischargeType(int OrgID, long patientVisitID, out List<InPatientDischargeType> lstDischargeType)
        {
            long returnCode = -1;
            IP_DAL pDischargeType = new IP_DAL(globalContextDetails);
            lstDischargeType = new List<InPatientDischargeType>();
            try
            {
                returnCode = pDischargeType.LoadDischargeType(OrgID, patientVisitID, out lstDischargeType);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing LoadDischargeType in IP_BL", excp);
            }
            return returnCode;
        }


        public long GetComplicationNames(string pNames, out List<Complication> lstComplicationNames)
        {
            long returnCode = -1;
            lstComplicationNames = new List<Complication>();
            try
            {
                returnCode = new IP_DAL(globalContextDetails).GetComplicationNames(pNames, out lstComplicationNames);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetComplicationNames in IP_BL", ex);
            }
            return returnCode;
        }


        public long SaveOperationNotes(long patientID, long patientVisitID, int OrgID, int mode, long OperationID, List<OperationNotes> lstOperationNotes,
            List<OperationStaff> lstOperationStaff, 
            List<OperationFinding> lstOperationFinding,
            List<OperationComplication> lstOperationComplication, 
            List<IPTreatmentPlan> lstIPTreatmentPlan, List<IPTreatmentPlan> lstIPTreatmentPlanAndPerformed)
        {
            long returnCode = -1;
            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {
                returnCode = ipDAL.SaveOperationNotes(patientID, patientVisitID, OrgID, mode, OperationID, lstOperationNotes, lstOperationStaff, lstOperationFinding,lstOperationComplication, lstIPTreatmentPlan, lstIPTreatmentPlanAndPerformed);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveOperationNotes in IP_BL", ex);
            }
            return returnCode;
        }

        public long GetDischargeSummary(long patientVisitID, int OrgID, out List<Patient> lstPatient, out List<OperationNotes> lstOperationNotes, out List<PatientHistory> lstPatientHistory, out List<BackgroundProblem> lstBackgroundProblem, out List<VitalsUOMJoin> lstVitalsUOMJoin, out List<PatientComplaint> lstPatientComplaint, out List<DrugDetails> lstDrugDetails, out List<IPTreatmentPlan> lstIPTreatmentPlan, out List<PatientAdvice> lstPatientAdvice, out List<IPTreatmentPlan> lstCaseRecordIPTreatmentPlan, out List<PatientVitals> lstVitalsCount, out List<InPatientNumber> lstInPatientNumber)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            lstOperationNotes = new List<OperationNotes>();
            lstPatientHistory = new List<PatientHistory>();
            lstBackgroundProblem = new List<BackgroundProblem>();
            lstVitalsUOMJoin = new List<VitalsUOMJoin>();
            lstPatientComplaint = new List<PatientComplaint>();
            lstDrugDetails = new List<DrugDetails>();
            lstIPTreatmentPlan = new List<IPTreatmentPlan>();
            lstPatientAdvice = new List<PatientAdvice>();
            lstCaseRecordIPTreatmentPlan = new List<IPTreatmentPlan>();
            lstVitalsCount = new List<PatientVitals>();
            lstInPatientNumber = new List<InPatientNumber>();
            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {

                returnCode = ipDAL.GetDischargeSummary(patientVisitID, OrgID, out lstPatient, out lstOperationNotes, out lstPatientHistory, out lstBackgroundProblem, out lstVitalsUOMJoin, out lstPatientComplaint, out lstDrugDetails, out lstIPTreatmentPlan, out lstPatientAdvice, out lstCaseRecordIPTreatmentPlan, out lstVitalsCount, out lstInPatientNumber);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDischargeSummary in IP_BL", ex);
            }
            return returnCode;
        }

        public long GetAllIPTreatmentPlanChild(int OrgID, out List<IPTreatmentPlanMaster> lstAllIPTreatmentPlanChild)
        {
            long returnCode = -1;
            IP_DAL pAllIPTreatmentPlanChild = new IP_DAL(globalContextDetails);
            lstAllIPTreatmentPlanChild = new List<IPTreatmentPlanMaster>();
            try
            {
                returnCode = pAllIPTreatmentPlanChild.GetAllIPTreatmentPlanChild(OrgID, out lstAllIPTreatmentPlanChild);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAllIPTreatmentPlanChild in IP_BL", ex);
            }
            return returnCode;
        }



        public long SaveDischargeSummary(long patientVisitID, long patientID, string SummaryStatus, string Procedure, string Preparedby, List<DischargeSummary> lstDischargeSummary, List<PatientComplaint> lstPatientComplaint, List<DrugDetails> lstDrugDetails, List<PatientAdvice> lstPatientAdvice, List<IPTreatmentPlan> lstCaseRecordIPTreatmentPlan, List<DischargeInvNotes> lstDischargeInvNotes, long CreatedBy, string CustomIpNo)
        {
            long returnCode = -1;
            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {


                returnCode = ipDAL.SaveDischargeSummary(patientVisitID, patientID, SummaryStatus, Procedure, Preparedby, lstDischargeSummary[0].PrintNegativeExam, lstDischargeSummary[0].PrintNegativeHistory, lstDischargeSummary[0].PrintGeneralAdvice, lstDischargeSummary, lstPatientComplaint, lstDrugDetails, lstPatientAdvice, lstCaseRecordIPTreatmentPlan, lstDischargeInvNotes, @CreatedBy, CustomIpNo);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DischargeSummary in IP_BL", ex);
            }
            return returnCode;
        }

        public long GetDischargeSummaryDetailsForupdate(long patientVisitID, out List<DischargeSummary> lstDischargeSummary, out List<DischargeInvNotes> lstDischargeInvNotes)
        {
            long returnCode = -1;
            lstDischargeSummary = new List<DischargeSummary>();
            lstDischargeInvNotes = new List<DischargeInvNotes>();

            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {

                returnCode = ipDAL.GetDischargeSummaryDetailsForupdate(patientVisitID, out lstDischargeSummary, out lstDischargeInvNotes);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DischargeSummary in IP_BL", ex);
            }
            return returnCode;
        }

        public long GetDischargeSummaryCaseSheet(long patientVisitID, int OrgID, out List<Patient> lsPatient, out List<InPatientAdmissionDetails> lstInPatientAdmissionDetails, out List<OperationNotes> lstOperationNotes, out List<DischargeSummary> lstDischargeSummary, out List<PatientComplaint> lstPatientComplaint, out List<IPTreatmentPlan> lstCaserecordIPTreatmentPlan, out List<BackgroundProblem> lstBackgroundProblem, out List<VitalsUOMJoin> lstVitalsUOMJoin, out List<PatientExamination> lstPatientExamination, out List<DrugDetails> lstDrugDetails, out List<PatientAdvice> lstPatientAdvice, out List<IPTreatmentPlan> lstOperationIPTreatmentPlan, out List<InPatientAdmissionDetails> lstAdmissionDate, out List<PatientAddress> lstPatientAddress, out List<VitalsUOMJoin> lstDischargeVitalsUOMJoin, out List<PatientVitals> lstPatientVitalsCount, out List<IPComplaint> lstNegativeIPComplaint, out List<Examination> lstNegativeExamination, out List<PatientHistoryExt> lstPatientHistoryExt, out List<RoomMaster> lstRoomMaster, out  List<InPatientNumber> lstInPatientNumber, out List<GeneralAdvice> lstGeneralAdvice, out List<DischargeInvNotes> lstDischargeInvNotes,out int OrthoCount )
        {
            long returnCode = -1;
            OrthoCount = -1;
            lsPatient = new List<Patient>();
            lstInPatientAdmissionDetails = new List<InPatientAdmissionDetails>();
            lstOperationNotes = new List<OperationNotes>();
            lstDischargeSummary = new List<DischargeSummary>();
            lstPatientComplaint = new List<PatientComplaint>();
            lstCaserecordIPTreatmentPlan = new List<IPTreatmentPlan>();
            lstBackgroundProblem = new List<BackgroundProblem>();
            lstVitalsUOMJoin = new List<VitalsUOMJoin>();
            lstPatientExamination = new List<PatientExamination>();
            lstDrugDetails = new List<DrugDetails>();
            lstPatientAdvice = new List<PatientAdvice>();
            lstOperationIPTreatmentPlan = new List<IPTreatmentPlan>();
            lstAdmissionDate = new List<InPatientAdmissionDetails>();
            //lstPatientHistory = new List<PatientHistory>();
            lstPatientAddress = new List<PatientAddress>();
            lstDischargeVitalsUOMJoin = new List<VitalsUOMJoin>();
            lstPatientVitalsCount = new List<PatientVitals>();

            lstNegativeIPComplaint = new List<IPComplaint>();
            lstNegativeExamination = new List<Examination>();

            lstPatientHistoryExt = new List<PatientHistoryExt>();

            lstRoomMaster = new List<RoomMaster>();
            lstInPatientNumber = new List<InPatientNumber>();

            lstGeneralAdvice = new List<GeneralAdvice>();
            lstDischargeInvNotes = new List<DischargeInvNotes>();

            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {

                returnCode = ipDAL.GetDischargeSummaryCaseSheet(patientVisitID, OrgID, out lsPatient, out lstInPatientAdmissionDetails, out lstOperationNotes, out lstDischargeSummary, out lstPatientComplaint, out lstCaserecordIPTreatmentPlan, out lstBackgroundProblem, out lstVitalsUOMJoin, out lstPatientExamination, out lstDrugDetails, out lstPatientAdvice, out lstOperationIPTreatmentPlan, out lstAdmissionDate, out lstPatientAddress, out lstDischargeVitalsUOMJoin, out lstPatientVitalsCount, out lstNegativeIPComplaint, out lstNegativeExamination, out lstPatientHistoryExt, out lstRoomMaster, out lstInPatientNumber, out lstGeneralAdvice, out lstDischargeInvNotes, out OrthoCount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DischargeSummary in IP_BL", ex);
            }
            return returnCode;
        }



        //public long GetIPTreatmentPlanChild(int OrgID,string SearchText, out List<IPTreatmentPlanMaster> lstIPTreatmentPlanChild)
        //{
        //    long returnCode = -1;
        //    IP_DAL plstIPTreatmentPlanChild = new IP_DAL(globalContextDetails);
        //    returnCode = plstIPTreatmentPlanChild.GetIPTreatmentPlanChild(OrgID, out lstIPTreatmentPlanChild);
        //    return returnCode;
        //}



        public long GetIPTreatmentPlanbyPatientVistID(long patientVisitID, out List<IPTreatmentPlan> lstIPTreatmentPlanbyPatientVistID)
        {
            long returnCode = -1;
            lstIPTreatmentPlanbyPatientVistID = new List<IPTreatmentPlan>();
            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {
                returnCode = ipDAL.GetIPTreatmentPlanbyPatientVistID(patientVisitID, out lstIPTreatmentPlanbyPatientVistID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPTreatment in IP_BL", ex);
            }
            return returnCode;
        }

        //public long GetIPTreatmentPlanChildByMasterID(int OrgID, int TreatmentMasterID, string SearchText, out List<IPTreatmentPlanMaster> lstIPTreatmentPlanChildByMastrID)
        //{
        //    long returnCode = -1;
        //    lstIPTreatmentPlanChildByMastrID = new List<IPTreatmentPlanMaster>();
        //    IP_DAL ipDAL = new IP_DAL(globalContextDetails);
        //    try
        //    {
        //        returnCode = ipDAL.GetIPTreatmentPlanChildByMasterID(OrgID, TreatmentMasterID, SearchText, out lstIPTreatmentPlanChildByMastrID);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while executing GetIPTreatment in IP_BL", ex);
        //    }
        //    return returnCode;
        //}

        public long GetPatientHistory(long patientVisitID, int OrgID, out List<PatientHistory> lstPatientHistory)
        {
            long returnCode = -1;

            lstPatientHistory = new List<PatientHistory>();

            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {

                returnCode = ipDAL.GetPatientHistory(patientVisitID, OrgID, out lstPatientHistory);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DischargeSummary in IP_BL", ex);
            }
            return returnCode;
        }
        public long GetPatientDischargeDetailByPatientID(long pid, out List<DischargeSummary> lstDischargeSummaryByPatientID)
        {
            long returnCode = -1;

            lstDischargeSummaryByPatientID = new List<DischargeSummary>();

            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {

                returnCode = ipDAL.GetPatientDischargeDetailByPatientID(pid, out lstDischargeSummaryByPatientID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DischargeSummary in IP_BL", ex);
            }
            return returnCode;
        }
        public long GetInPatientVisitCount(long patientID, out List<PatientVisit> lstPatientVisitCount)
        {
            long returnCode = -1;

            lstPatientVisitCount = new List<PatientVisit>();
            try
            {
                returnCode = new IP_DAL(globalContextDetails).GetInPatientVisitCount(patientID, out lstPatientVisitCount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get visit details", ex);
            }
            return returnCode;
        }
        public long InsertIPOrderedInv(List<PatientInvestigation> pPatientInvTable, long visitID, long CreatedBy, long patientID,out string InterimBillNo)
        {
            long returnCode = -1;
            
           
            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            ipDAL.InsertIPOrderedInv(pPatientInvTable, visitID, CreatedBy, patientID, out InterimBillNo);
             
            return returnCode;
        }



        public long DeletePatientInvestigation(List<PatientInvestigation> lstPatient, long patientVisitID)
        {

            long lresult = -1;

            try
            {
                IP_DAL ipDAL = new IP_DAL(globalContextDetails);
                lresult = ipDAL.DeletePatientInvestigation(lstPatient, patientVisitID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing investigation BL", ex);
            }
            return lresult;
        }

        public long GetIPOrderedInvestigation(long patientVisitID, out List<OrderedInvestigations> lstInv, out List<OrderedInvestigations> lstGrp)
        {
            long returnCode = -1;
            lstInv = new List<OrderedInvestigations>();
            lstGrp = new List<OrderedInvestigations>();

            try
            {
                returnCode = new IP_DAL(globalContextDetails).GetIPOrderedInvestigation(patientVisitID, out lstInv, out lstGrp);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while investigation BL", ex);

            }
            return returnCode;
        }


        public long DeleteInPatientInvestigation(long patientVisitID,int OrgID)
        {

            long lresult = -1;

            try
            {
                IP_DAL ipDAL = new IP_DAL(globalContextDetails);
                lresult = ipDAL.DeleteInPatientInvestigation(patientVisitID, OrgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing investigation BL", ex);
            }
            return lresult;
        }

        public long UpdateReferedInv(long patientVisitID)
        {

            long lresult = -1;

            try
            {
                IP_DAL ipDAL = new IP_DAL(globalContextDetails);
                lresult = ipDAL.UpdateReferedInv(patientVisitID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing investigation BL", ex);
            }
            return lresult;
        }



        public long GetSurgeonNameAndSurgeryType(int OrgID, out List<IPTreatmentPlanMaster> lstIPTreatmentType, out List<Physician> lstChiefPhysician, out List<Physician> lstAnesthisa, out List<InstrumentationMaster> lstInstrumentationMaster,out List<Nurse> lstNurse)
        {
            long returnCode = -1;


            lstChiefPhysician = new List<Physician>();
            lstAnesthisa = new List<Physician>();
            lstIPTreatmentType = new List<IPTreatmentPlanMaster>();
            lstInstrumentationMaster = new List<InstrumentationMaster>();
            lstNurse = new List<Nurse>();
            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {
                returnCode = ipDAL.GetSurgeonNameAndSurgeryType(OrgID, out lstIPTreatmentType, out lstChiefPhysician, out lstAnesthisa, out lstInstrumentationMaster,out lstNurse);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOperationNotes in IP_BL", ex);
            }
            return returnCode;
        }


        public long SaveSurgeryBillingDetails(long SurgeryBillingID, string Type, long patientID, long patientVisitID, int OrgID, List<SurgeryBillingMaster> lstSurgeryBillingMaster, List<SurgeryBillingDetails> lstSurgeryBillingDetails, DateTime pBillDate, out decimal pTotalAmount)
        {
            long returnCode = -1;
            pTotalAmount = -1;
            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {
               

                returnCode = ipDAL.SaveSurgeryBillingDetails(SurgeryBillingID, Type, patientID, patientVisitID, OrgID, lstSurgeryBillingMaster, lstSurgeryBillingDetails, pBillDate, out  pTotalAmount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveSurgeryBillingDetails in IP_BL", ex);
            }
            return returnCode;
        }

          public long BindSurgeryBillingDetailByVisitID(long patientVisitID, out List<SurgeryBillingMaster> lstSurgeryBillingMasterByVisitid)
        {
            long returnCode = -1;
            lstSurgeryBillingMasterByVisitid = new List<SurgeryBillingMaster>();
            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {
                returnCode = ipDAL.BindSurgeryBillingDetailByVisitID(patientVisitID, out lstSurgeryBillingMasterByVisitid);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing BindSurgeryBillingDetailByVisitID in IP_BL", ex);
            }
            return returnCode;
        }


        public long GetSurgeryBillingBySurgeryBillingID(long SurgeryBillingID, out List<SurgeryBillingMaster> lstSurgeryBillingMaster, out List<SurgeryBillingDetails> lstSurgeryBillingDetails, out List<SurgeryBillingDetails> lstAssistantPhysicianOperationStaff, out List<SurgeryBillingDetails> lstAnesthisiaOperationStaff, out int pTreatmentMasterID)
        {
            long returnCode = -1;
            pTreatmentMasterID = -1;
            lstSurgeryBillingMaster = new List<SurgeryBillingMaster>();
            lstSurgeryBillingDetails = new List<SurgeryBillingDetails>();
            lstAssistantPhysicianOperationStaff = new List<SurgeryBillingDetails>();
            lstAnesthisiaOperationStaff = new List<SurgeryBillingDetails>();

            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {
                returnCode = ipDAL.GetSurgeryBillingBySurgeryBillingID(SurgeryBillingID, out lstSurgeryBillingMaster, out lstSurgeryBillingDetails, out lstAssistantPhysicianOperationStaff, out lstAnesthisiaOperationStaff, out pTreatmentMasterID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSurgeryBillingBySurgeryBillingID in IP_BL", ex);
            }
            return returnCode;
        }

        public long InsertSurgeryBillingToDue(List<SurgeryBillingMaster> lstSurgeryBillingMaster, long visitID, 
            long CreatedBy, long patientID, long SurgeryFeeId, decimal pTotalAmount, out string InterimBillNo)
        {
            long returnCode = -1;

            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            ipDAL.InsertSurgeryBillingToDue(lstSurgeryBillingMaster, visitID, CreatedBy, patientID,SurgeryFeeId,pTotalAmount, out InterimBillNo);
             
            return returnCode;
        }
        public long BindSurgeryDetailForAdvanceByVisitID(long patientVisitID, out List<PatientDueChart> lstSurgeryDetailForAdvance)
        {
            long returnCode = -1;
            lstSurgeryDetailForAdvance = new List<PatientDueChart>();
            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {
                returnCode = ipDAL.BindSurgeryDetailForAdvanceByVisitID(patientVisitID, out lstSurgeryDetailForAdvance);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing BindSurgeryDetailForAdvanceByVisitID in IP_BL", ex);
            }
            return returnCode;
        }



        public long GetPendingSurgeyPaymentTaskId(long pVisitID, out List<Tasks> lstPendingTasks)
        {
            long returnCode = -1;
            lstPendingTasks = new List<Tasks>();
            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {
                returnCode = ipDAL.GetPendingSurgeyPaymentTaskId(pVisitID, out lstPendingTasks);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPendingSurgeyPaymentTaskId in IP_BL", ex);
            }
            return returnCode;
        }


        public long GetIPCaseRecordSheet(long patientID, long patientVisitID, string viewType, int OrgID, out List<Patient> lsPatient, 
            out List<InPatientAdmissionDetails> lstInPatientAdmissionDetails, out List<PatientComplaint> lstPatientComplaint, 
            out List<BackgroundProblem> lstBackgroundProblem, out List<VitalsUOMJoin> lstVitalsUOMJoin, 
            out List<PatientExamination> lstPatientExamination, out List<DrugDetails> lstDrugDetails, 
            out List<IPTreatmentPlan> lstCaserecordIPTreatmentPlan, out List<InPatientAdmissionDetails> lstAdmissionDate, 
            out List<OrderedInvestigations> lstOrderedInvestigations, out List<IPComplaint> lstNegativeIPComplaint, 
            out List<Examination> lstNegativeExamination, out List<PatientHistoryExt> lstPatientHistoryExt,
            out List<Advice> lstAdvice, out List<PatientHistory> lstPatientHistory)
        {
            long returnCode = -1;

            lsPatient = new List<Patient>();
            lstInPatientAdmissionDetails = new List<InPatientAdmissionDetails>();
            lstPatientComplaint = new List<PatientComplaint>();
            lstBackgroundProblem = new List<BackgroundProblem>();
            lstVitalsUOMJoin = new List<VitalsUOMJoin>();
            lstPatientExamination = new List<PatientExamination>();
            lstDrugDetails = new List<DrugDetails>();
            lstCaserecordIPTreatmentPlan = new List<IPTreatmentPlan>();
            lstAdmissionDate = new List<InPatientAdmissionDetails>();
            lstOrderedInvestigations = new List<OrderedInvestigations>();
            lstNegativeIPComplaint = new List<IPComplaint>();
            lstNegativeExamination = new List<Examination>();
            lstPatientHistoryExt = new List<PatientHistoryExt>();
            lstAdvice = new List<Advice>();
            lstPatientHistory = new List<PatientHistory>();
            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {

                returnCode = ipDAL.GetIPCaseRecordSheet(patientID, patientVisitID, viewType, OrgID, out lsPatient, out lstInPatientAdmissionDetails, out lstPatientComplaint, 
                    out lstBackgroundProblem, out lstVitalsUOMJoin, out lstPatientExamination, out lstDrugDetails, out lstCaserecordIPTreatmentPlan, 
                    out lstAdmissionDate, out lstOrderedInvestigations, out lstNegativeIPComplaint, out lstNegativeExamination, 
                    out lstPatientHistoryExt, out lstAdvice, out lstPatientHistory);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPCaseRecordSheet in IP_BL", ex);
            }
            return returnCode;
        }

        public long GetIPComplaint(out List<IPComplaint> lstIPComplaint)
        {
            long returnCode = -1;
            lstIPComplaint = new List<IPComplaint>();
            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {
                returnCode = ipDAL.GetIPComplaint(out lstIPComplaint);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPComplaint in IP_BL", ex);
            }
            return returnCode;
        }



        public long pGetOperationNotesCaseSheet(long patientVisitID, long OperationID, int OrgID, out List<Patient> lstPatient, out List<OperationNotes> lstOperationNotes, out List<IPTreatmentPlan> lstIPTreatmentPlan, out List<PatientComplaint> lstPatientComplaint, out List<OperationStaff> lstOperationTeam, out List<AHPStaff> lstTechnicianName, out List<Nurse> lstNurse, out List<SurgeryType> lstSurgeryType, out List<OperationType> lstOperationType, out List<AnesthesiaType> lstAnesthesiaType, out List<OperationFinding> lstOperationFinding, out List<OperationComplication> lstOperationComplication)
        {
            long returnCode = -1;

            lstPatient = new List<Patient>();
            lstOperationNotes = new List<OperationNotes>();
            lstIPTreatmentPlan = new List<IPTreatmentPlan>();
            lstPatientComplaint = new List<PatientComplaint>();
            lstOperationTeam = new List<OperationStaff>();
            lstTechnicianName = new List<AHPStaff>();
            lstNurse = new List<Nurse>();
            lstSurgeryType = new List<SurgeryType>();
            lstOperationType = new List<OperationType>();
            lstAnesthesiaType = new List<AnesthesiaType>();
            lstOperationFinding = new List<OperationFinding>();
            lstOperationComplication = new List<OperationComplication>();


            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {

                returnCode = ipDAL.pGetOperationNotesCaseSheet(patientVisitID, OperationID, OrgID, out lstPatient, out lstOperationNotes, out lstIPTreatmentPlan, out lstPatientComplaint, out lstOperationTeam, out lstTechnicianName, out lstNurse, out lstSurgeryType, out lstOperationType, out lstAnesthesiaType, out lstOperationFinding, out lstOperationComplication);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DischargeSummary in IP_BL", ex);
            }
            return returnCode;
        }
        public long getSurgeryName(string SurgeryName, int pOrgID, out List<IPTreatmentPlan> lstSurgeryName)
        {
            long lresult = -1;
            lstSurgeryName = new List<IPTreatmentPlan>();
            try
            {
                IP_DAL objIP_DAL = new IP_DAL(globalContextDetails);
                lresult = objIP_DAL.getSurgeryName(SurgeryName, pOrgID, out lstSurgeryName);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getSurgeryName BL", ex);
            }
            return lresult;

        }
        public long GetInPatientRegDetail(long pid, long vid, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            try
            {
                returnCode = new IP_DAL(globalContextDetails).GetInPatientRegDetail(pid, vid, out lstPatient);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in IP BL GetInPatientRegDetail", ex);
            }

            return returnCode;
        }

        public long GetTPAName(int orgID, out List<TPAMaster> lstTPAMaster)
        {
            long returnCode = -1;
            lstTPAMaster = new List<TPAMaster>();

            try
            {
                returnCode = new IP_DAL(globalContextDetails).GetTPAName(orgID, out lstTPAMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while IP BL GetTPAName", ex);

            }
            return returnCode;
        }
        public long GetTPAPatient(long patientID, string PatientName, string paymentStatus,
                                    string TPAName, long TPAID, DateTime FromDate, DateTime ToDate,
                                    long OrgID, int ClientID, out List<TPADetails> lstTPADetails)
        {
            long returnCode = -1;
            lstTPADetails = new List<TPADetails>();
            try
            {
                new IP_DAL(globalContextDetails).GetTPAPatient(patientID, PatientName, paymentStatus, TPAName, TPAID, FromDate, ToDate, OrgID, ClientID, out lstTPADetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in IPDAL GetTPAPatient method", ex);
            }
            return returnCode;
        }
        public long GetTPAPayment(List<Patient> dtPatient, int orgID, out List<Patient> lPatient)
        {
            long returnCode = -1;
            lPatient = new List<Patient>();
            
             
            try
            {
                returnCode = new IP_DAL(globalContextDetails).GetTPAPayment(dtPatient, orgID, out lPatient);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in IPDAL GetTPAPayment method", ex);
            }
            return returnCode;
        }
        
        public long InsertTPAPayment(List<PatientDueChart> lPatient, int orgID)
        {
            long returnCode = -1;

            try
            {
                returnCode = new IP_DAL(globalContextDetails).InsertTPAPayment(lPatient, orgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in IPDAL InsertTPAPayment method", ex);
            }
            return returnCode;
        }
        public long GetDischargeChkList(long pid, long vid, out List<DischargeChkLstMaster> lstDisChkLst, out string DestPostDischarge)
        {
            long returnCode = -1;
            DestPostDischarge = string.Empty;
            lstDisChkLst = new List<DischargeChkLstMaster>();

            try
            {
                returnCode = new IP_DAL(globalContextDetails).GetDischargeChkList(pid, vid, out lstDisChkLst, out DestPostDischarge);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetDischargeChkList", ex);
            }
            return returnCode;
        }
         
        public long GetPTPAPaymentDetails(long VisitID, long PatientId, int OrgID, out List<TPAPayments> lPaymentDetails)
        {
            long returnCode = -1;
            lPaymentDetails = new List<TPAPayments>();

            try
            {
                returnCode = new IP_DAL(globalContextDetails).GetPTPAPaymentDetails(VisitID, PatientId, OrgID, out lPaymentDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetPTPAPaymentDetails", ex);
            }
            return returnCode;
        }

        public long UpdatePaymentDetails(TPAPayments objTPAPayments, int OrgID, long LID)
        {
            long returnCode = -1;
            try
            {
                returnCode = new IP_DAL(globalContextDetails).UpdatePaymentDetails(objTPAPayments, OrgID, LID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in IP dal UpdatePaymentDetails function", ex);
            }
            return returnCode;
        }

        public long GetMLCDetails(long PatientVisitID, out List<RTAMLCDetails> lstRTAMLCDetails)
        {
            long returnCode = -1;
            lstRTAMLCDetails = new List<RTAMLCDetails>();
            try
            {
                returnCode = new IP_DAL(globalContextDetails).GetMLCDetails(PatientVisitID, out lstRTAMLCDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetMLCDetails", ex);
            }
            return returnCode;
        }

        public long GetDeathRegData(int OrgID, out List<PlaceOfDeath> lstPlaceOfDeath, out List<TypeOfDeath> lstTypeOfDeath, out List<CauseOfDeathMaster> lstCauseOfDeathMaster, out List<LifeSupportMaster> lstLifeSupportMaster, out List<Organ> lstOrgan)
        {
            long returnCode = -1;

            lstPlaceOfDeath = new List<PlaceOfDeath>();
            lstTypeOfDeath = new List<TypeOfDeath>();
            lstCauseOfDeathMaster = new List<CauseOfDeathMaster>();
            lstLifeSupportMaster = new List<LifeSupportMaster>();
            lstOrgan = new List<Organ>();



            try
            {
                returnCode = new IP_DAL(globalContextDetails).GetDeathRegData(OrgID, out lstPlaceOfDeath, out lstTypeOfDeath, out lstCauseOfDeathMaster, out lstLifeSupportMaster, out lstOrgan);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetDeathRegData", ex);
            }
            return returnCode;
        }


        public long SaveDeathRegDetails(int OrgID, long patientVisitID, long patientID, long LID, string pType, List<CauseOfDeath> lstCauseOfDeath, List<PatientHistory> lstPatientHis, List<PatientHistoryAttribute> lstPatientHisAttributes, List<OrganRegWithMapping> lstOrgRegWithMapping, RTAMLCDetails lstRTAMLCDetails, DeathRegistration lstDeathRegistration)
        {
            long returnCode = -1;

            try
            {
                returnCode = new IP_DAL(globalContextDetails).SaveDeathRegDetails(OrgID, patientVisitID, patientID, LID, pType, lstCauseOfDeath, lstPatientHis, lstPatientHisAttributes, lstOrgRegWithMapping, lstRTAMLCDetails, lstDeathRegistration);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL SaveDeathRegDetails", ex);
            }
            return returnCode;
        }


        public long GetDeathRegForUpdate(long patientVisitID, out List<DeathRegistration> lstDeathRegistration, out List<CauseOfDeath> lstCauseOfDeath, out List<PatientHistoryAttribute> lstPatientHisAttributes)
        {
            long returnCode = -1;

            lstDeathRegistration = new List<DeathRegistration>();
            lstCauseOfDeath = new List<CauseOfDeath>();
            lstPatientHisAttributes = new List<PatientHistoryAttribute>();



            try
            {
                returnCode = new IP_DAL(globalContextDetails).GetDeathRegForUpdate(patientVisitID, out lstDeathRegistration, out lstCauseOfDeath, out lstPatientHisAttributes);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetDeathRegForUpdate", ex);
            }
            return returnCode;
        }

        public long UpdateTPAPaymentDetails(List<PatientDueChart> lPatient, int OrgID, string Status, decimal WriteOff, long finalBillID, DateTime SettlementDate,DateTime ClaimForwaredDate)
        {
            long returnCode = -1;
            try
            {
                returnCode = new IP_DAL(globalContextDetails).UpdateTPAPaymentDetails(lPatient, OrgID, Status, WriteOff, finalBillID, SettlementDate, ClaimForwaredDate);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in IP dal UpdatePaymentDetails function", ex);
            }
            return returnCode;
        }



        public long GetOperationNotesForDS(long patientVisitID,int OrgID ,out List<OperationNotes> lstOperationNotesForDS)
        {
            long returnCode = -1;

            lstOperationNotesForDS = new List<OperationNotes>(); 

            try
            {
                returnCode = new IP_DAL(globalContextDetails).GetOperationNotesForDS(patientVisitID, OrgID,out lstOperationNotesForDS);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetOperationNotesForDS", ex);
            }
            return returnCode;
        }

        public long GetPatientComplaintWithICD(long patientVisitID, string VisitType,string PageType, out List<PatientComplaint> lstPatientComplaint)
        {
            long returnCode = -1;
            lstPatientComplaint = new List<PatientComplaint>();
            try
            {
                returnCode = new IP_DAL(globalContextDetails).GetPatientComplaintWithICD(patientVisitID, VisitType,PageType, out lstPatientComplaint);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetPatientComplaintWithICD", ex);
            }
            return returnCode;
        }

        public long GetDischargeSummarySeq(int OrgID, out List<DischargeSummarySeq> lstDischargeSummarySeq)
        {
            long returnCode = -1;
            lstDischargeSummarySeq = new List<DischargeSummarySeq>();
            try
            {
                returnCode = new IP_DAL(globalContextDetails).GetDischargeSummarySeq(OrgID, out lstDischargeSummarySeq);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetDischargeSummarySeq", ex);
            }
            return returnCode;
        }

        public long GetTPACorporateReport(long patientID, string PatientName, string paymentStatus,
                                   string TPAName, long TPAID, DateTime FromDate, DateTime ToDate,
                                   long OrgID, int ClientID, out List<TPADetails> lstTPADetails)
        {
            long returnCode = -1;
            lstTPADetails = new List<TPADetails>();
            try
            {
                new IP_DAL(globalContextDetails).GetTPACorporateReport(patientID, PatientName, paymentStatus, TPAName, TPAID, FromDate, ToDate, OrgID, ClientID, out lstTPADetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in IPDAL GetTPACorporateReport method", ex);
            }
            return returnCode;
        }

        public long GetOrthoSpecialtyDetails(int OrgID, out List<SpecialtyUniqueParts> lstSpecialtyUniqueParts, out  List<BodyPartChildItems> lstBodyPartChildItems)
        {
            long returnCode = -1;
            lstSpecialtyUniqueParts = new List<SpecialtyUniqueParts>();
            lstBodyPartChildItems = new List<BodyPartChildItems>();
            try
            {
                returnCode = new IP_DAL(globalContextDetails).GetOrthoSpecialtyDetails(OrgID, out lstSpecialtyUniqueParts, out lstBodyPartChildItems);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL lstSpecialtyUniqueParts = new List<SpecialtyUniqueParts>();", ex);
            }
            return returnCode;
        }


        public long SaveOrthoPatientDetails(long VisitID, long PatientID, int OrgID,long LID,
                                             List<OrthoPatientDetails> lstOrthoPatientDetails, List<PatientBodyPartDetails> lstPatientBodyPartDetails,
                                             List<PatientOpenWound> lstPatientOpenWound,List<PatientVascularDetails>  lstPatientVascularDetails,
                                             List<PatientNeurologicalDetails> lstPatientNeurologicalDetails, List<PatientReflexes> lstPatientReflexes,
                                             List<PatientMuscleDetail> lstPatientMuscleDetail, List<PatientMuscleWasting> lstPatientMuscleWasting)
        {
            long returnCode = -1;
         
            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            try
            {

                returnCode = ipDAL.SaveOrthoPatientDetails(VisitID, PatientID, OrgID, LID,
                                             lstOrthoPatientDetails, lstPatientBodyPartDetails,
                                             lstPatientOpenWound, lstPatientVascularDetails,
                                             lstPatientNeurologicalDetails, lstPatientReflexes,
                                             lstPatientMuscleDetail, lstPatientMuscleWasting);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveOrthoPatientDetails in IP_BL", ex);
            }
            return returnCode;
        }


        public long GetOrthoPatientDetailsForEdit(long VisitID,int OrgID,out List<OrthoPatientDetails> lstOrthoPatientDetails, out List<PatientBodyPartDetails> lstPatientBodyPartDetails,
                                           out List<PatientOpenWound> lstPatientOpenWound, out List<PatientVascularDetails> lstPatientVascularDetails,
                                           out List<PatientNeurologicalDetails> lstPatientNeurologicalDetails, out List<PatientReflexes> lstPatientReflexes,
                                           out List<PatientMuscleDetail> lstPatientMuscleDetail, out List<PatientBodyPartDetails> lstPatientDistinctBodyPartDetails,out int Count,
            out List<PatientMuscleWasting> lstPatientMuscleWasting)
        {
            long returnCode = -1;
            Count = -1;

            IP_DAL ipDAL = new IP_DAL(globalContextDetails);
            lstOrthoPatientDetails = new List<OrthoPatientDetails>();
            lstPatientBodyPartDetails = new List<PatientBodyPartDetails>();
            lstPatientOpenWound = new List<PatientOpenWound>();
            lstPatientVascularDetails = new List<PatientVascularDetails>();
            lstPatientNeurologicalDetails = new List<PatientNeurologicalDetails>();
            lstPatientReflexes = new List<PatientReflexes>();
            lstPatientMuscleDetail = new List<PatientMuscleDetail>();
            lstPatientDistinctBodyPartDetails = new List<PatientBodyPartDetails>();
            lstPatientMuscleWasting = new List<PatientMuscleWasting>();
            
            try
            {

                returnCode = ipDAL.GetOrthoPatientDetailsForEdit(VisitID, OrgID, out lstOrthoPatientDetails, out lstPatientBodyPartDetails,
                                               out lstPatientOpenWound, out lstPatientVascularDetails,
                                               out lstPatientNeurologicalDetails, out lstPatientReflexes,
                                               out lstPatientMuscleDetail, out lstPatientDistinctBodyPartDetails, out Count, out lstPatientMuscleWasting);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOrthoPatientDetailsForEdit in IP_BL", ex);
            }
            return returnCode;
        }

        public long GetSurgeryPayments(long visitID, long pID, int OrgID, out decimal pTotSurgeryAdv, out decimal pTotSurgeryAmt)
        {
            long returnCode = -1;
            pTotSurgeryAdv = -1;
            pTotSurgeryAmt = -1;
            try
            {
                returnCode = new IP_DAL(globalContextDetails).GetSurgeryPayments(visitID,pID,OrgID, out pTotSurgeryAdv, out pTotSurgeryAmt);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetSurgeryPayments", ex);
            }
            return returnCode;
        }
        public long GetInvClientAttributes(int orgID, out List<InvClientMaster> lstClientAttributes)
        {
            long returnCode = -1;
            lstClientAttributes = new List<InvClientMaster>();
            try
            {

                returnCode = new IP_DAL(globalContextDetails).GetInvClientAttributes(orgID, out lstClientAttributes);


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while IP DAL GetInvClientAttributes", ex);

            }
            return returnCode;
        }
        public long GetIPBulkBill(long VisitID, long PatientID, long OrgID, out decimal GrandTotal,out List<PatientDueChart> lstBedBookingRoomType,  out List<IPBulkBill> lstIPBulkBill, out List<IPBulkBill> lstIPBulkBill1)
        {
            long returnCode = -1;
            GrandTotal = 0;
            lstIPBulkBill = new List<IPBulkBill>();
            lstIPBulkBill1 = new List<IPBulkBill>();
            lstBedBookingRoomType = new List<PatientDueChart>();
            try
            {

                IP_DAL IPBillBulkDAL = new IP_DAL(globalContextDetails);
                returnCode = IPBillBulkDAL.GetIPBulkBill(VisitID, PatientID, OrgID, out GrandTotal,out lstBedBookingRoomType,  out lstIPBulkBill, out lstIPBulkBill1);
            }

            catch (Exception excep)
            {

                CLogger.LogError("Error while executing GetKnowledgeOfService in IPBulkBill_BL", excep);
            }

            return returnCode;
        }
        public long GetReferringOrgType(int orgID, out List<ReferringOrgType> lsRefOrgTypeMaster)
        {
            long returnCode = -1;
            lsRefOrgTypeMaster = new List<ReferringOrgType>();

            try
            {
                returnCode = new IP_DAL(globalContextDetails).GetReferringOrgType(orgID, out lsRefOrgTypeMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while IP BL GetTPAName", ex);

            }
            return returnCode;
        }

        
   public long GetPlannedSurgeryForAnesthesia(long VisitID, int orgID, out List<Patient> lstPatient, out List<InPatientAdmissionDetails> lstinPatientDetails, out List<IPTreatmentPlan> lstTreatmentplan, out List<AnesthesiaType> lstAnesthesiaType, out List<Physician> lstPhysician, out List<RoomMaster> lstRoom, out List<OperationNotes> lstOperationNotes,out List<AnesthesiaModes> lstModes,out List<Complication> lstComplication,out List<Vitals> lstVitals,out List<Vitals> lstVitalsGas,out List<Vitals> lstVitalsVentilator)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            lstinPatientDetails = new List<InPatientAdmissionDetails>();
            lstTreatmentplan = new List<IPTreatmentPlan>();
            lstAnesthesiaType = new List<AnesthesiaType>();
            lstPhysician = new List<Physician>();
            lstRoom = new List<RoomMaster>();
            lstOperationNotes = new List<OperationNotes>();
            lstModes = new List<AnesthesiaModes>();
            lstComplication = new List<Complication>();
            lstVitals = new List<Vitals>();
            lstVitalsVentilator = new List<Vitals>();
            lstVitalsGas = new List<Vitals>();

            

            try
            {
                returnCode = new IP_DAL(globalContextDetails).GetPlannedSurgeryForAnesthesia(VisitID, orgID, out lstPatient, out lstinPatientDetails, out lstTreatmentplan, out lstAnesthesiaType, out lstPhysician, out lstRoom, out lstOperationNotes, out lstModes, out lstComplication, out lstVitals, out lstVitalsGas, out lstVitalsVentilator);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while IP BL GetTPAName", ex);

            }
            return returnCode;
        }

        public long InsertAnesthesiaNotes(long PatientVisitID, long PatientID, DateTime StartTime, DateTime EndTime, string AnesthesiaType, string NPODuration, string AnesthesiaNotes, string ModeOfAnesthesia, string ScoringSystem, string ScoringValue, string Complications,out List<PatientAdvice> lstPatientAdvice)
        {
            long returnCode = -1;
            lstPatientAdvice = new List<PatientAdvice>();
            try
            {
                IP_DAL objDAL = new IP_DAL(globalContextDetails);
                returnCode = objDAL.InsertAnesthesiaNotes(PatientVisitID, PatientID, StartTime, EndTime, AnesthesiaType, NPODuration, AnesthesiaNotes, ModeOfAnesthesia,ScoringSystem ,ScoringValue ,Complications,out lstPatientAdvice);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetTemplate ", excp);
            }
            return returnCode;
        }

        public long GetAnesthesiaNotes(long PatientVisitID, out List<AnesthesiaDetails> lstAnesthesiaDetails, out List<Patient> lstPatient, out List<IPTreatmentPlan> lstTreatementplan, out List<Physician> lstPhysician,out List<PatientVitals> lstPatientVitals,out List<RoomDetails> lstRoomDetails,out List<PatientPrescription> lstPatientPrescription,out List<PatientAdvice> lstPatientAdvice)
        {
            long returnCode = -1;
            lstAnesthesiaDetails = new List<AnesthesiaDetails>();
            lstPatient = new List<Patient>();
            lstTreatementplan = new List<IPTreatmentPlan>();
            lstPhysician = new List<Physician>();
            lstRoomDetails = new List<RoomDetails>();
            lstPatientVitals = new List<PatientVitals>();
            lstPatientPrescription = new List<PatientPrescription>();
            lstPatientAdvice = new List<PatientAdvice>();
            try
            {
                IP_DAL objDAL = new IP_DAL(globalContextDetails);
                returnCode = objDAL.GetAnesthesiaNotes(PatientVisitID, out lstAnesthesiaDetails, out lstPatient, out lstTreatementplan, out lstPhysician, out lstPatientVitals,out lstRoomDetails,out lstPatientPrescription,out lstPatientAdvice);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetTemplate ", excp);
            }
            return returnCode;
        }

        //Treatment Plan Details 

        
        public long InsertIPTreatmentPlanDetails(long PatientvisitID, long PatientID,int OrgID, List<IPTreatmentPlanDetails> lstIPTreatmentPlanDetails)
        {
            long returnCode = -1;
             
            try
            {
                IP_DAL IPDAL = new IP_DAL(globalContextDetails);
                returnCode = IPDAL.InsertIPTreatmentPlanDetails(PatientvisitID, PatientID, OrgID, lstIPTreatmentPlanDetails);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing InsertIPTreatmentPlanDetails status", excp);
            }
            return returnCode;

        }

        public long GetIPTreatmentPlanDetails(long PatientID,  out List<IPTreatmentPlanDetails> lstIPTreatmentPlanDetails ,out List<IPTreatmentPlanDetails> lstReportTreatmentPlanDetails)
        {
            long returnCode = -1;
            //lstmetadatainput = new List<MetaData>();
            lstIPTreatmentPlanDetails = new List<IPTreatmentPlanDetails>();
            lstReportTreatmentPlanDetails = new List<IPTreatmentPlanDetails>();


            try
            {
                IP_DAL IPDAL = new IP_DAL(globalContextDetails);
                returnCode = IPDAL.GetIPTreatmentPlanDetails(PatientID, out lstIPTreatmentPlanDetails, out lstReportTreatmentPlanDetails);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetIPTreatmentPlanDetails status", excp);
            }
            return returnCode;

        }

        public long GetIPTreatmentPlanDetailsReport(DateTime FromDate, DateTime ToDate, long PatientID, out List<IPTreatmentPlanDetails> lstReportTreatmentDetails)
        {
            long returnCode = -1;
            //lstmetadatainput = new List<MetaData>();

            lstReportTreatmentDetails = new List<IPTreatmentPlanDetails>();


            try
            {
                IP_DAL IPDAL = new IP_DAL(globalContextDetails);
                returnCode = IPDAL.GetIPTreatmentPlanDetailsReport(FromDate, ToDate,PatientID,out lstReportTreatmentDetails);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetIPTreatmentPlanDetails status", excp);
            }
            return returnCode;

        }
        //GetTreatmentPlanNames

        public long GetTreatmentPlanNames(string Prefix, long OrgID, out List<SurgeryPackageMaster> lstTreatmentPlanNames)
        {
            long returnCode = -1;
            //lstmetadatainput = new List<MetaData>();

            lstTreatmentPlanNames = new List<SurgeryPackageMaster>();


            try
            {
                IP_DAL IPDAL = new IP_DAL(globalContextDetails);
                returnCode = IPDAL.GetTreatmentPlanNames(Prefix, OrgID, out lstTreatmentPlanNames);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetIPTreatmentPlanNames", excp);
            }
            return returnCode;

        }
        //GetSurgeryPackageNames
        public long GetSurgeryPackageNames(int OrgID, out List<SurgeryPackageMaster> lstSurgeryPackageNames)
        {
            long returnCode = -1;
            //lstmetadatainput = new List<MetaData>();

            lstSurgeryPackageNames = new List<SurgeryPackageMaster>();


            try
            {
                IP_DAL IPDAL = new IP_DAL(globalContextDetails);
                returnCode = IPDAL.GetSurgeryPackageNames( OrgID, out lstSurgeryPackageNames);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetSurgeryPlanNames", excp);
            }
            return returnCode;

        }

        public long GetAnesthesiastNames(int OrgID, string PrefixText, out List<Physician> lstAnesthesiastNames)
        {
            long returnCode = -1;
            //lstmetadatainput = new List<MetaData>();

            lstAnesthesiastNames = new List<Physician>();


            try
            {
                IP_DAL IPDAL = new IP_DAL(globalContextDetails);
                returnCode = IPDAL.GetAnesthesiastNames(OrgID, PrefixText, out lstAnesthesiastNames);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetAnesthesiastNames", excp);
            }
            return returnCode;

        }


    }



        

    
}
