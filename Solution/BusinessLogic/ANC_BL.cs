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
    public class ANC_BL
    {
        ContextDetails globalContextDetails;
        public ANC_BL()
        {

        }
        public ANC_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long GetPregnancyComplication(int SpecialityID, out List<Complication> lstComplication)
        {
            long lresult = -1;
            lstComplication = new List<Complication>();
            try
            {
                ANC_DAL ancDAL = new ANC_DAL(globalContextDetails);
                ancDAL.GetPregnancyComplication(SpecialityID, out lstComplication);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPregnancyComplication BL", ex);
            }
            return lresult;

        }
        public long GetPriorVaccination(out List<Vaccination> lstVaccination)
        {
            long lresult = -1;
            lstVaccination = new List<Vaccination>();
            try
            {
                ANC_DAL ancDAL = new ANC_DAL(globalContextDetails);
                ancDAL.GetPriorVaccination(out lstVaccination);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPriorVaccination BL", ex);
            }
            return lresult;

        }
        public long GetModeOfDelivery(out List<ModeOfDelivery> lstMOd)
        {
            long lresult = -1;
            lstMOd = new List<ModeOfDelivery>();
            try
            {
                ANC_DAL ancDAL = new ANC_DAL(globalContextDetails);
                ancDAL.GetModeOfDelivery(out lstMOd);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetModeOfDelivery BL", ex);
            }
            return lresult;

        }
        public long GetBirthMaturity(out List<BirthMaturity> lstBirthMaturity)
        {
            long lresult = -1;
            lstBirthMaturity = new List<BirthMaturity>();
            try
            {
                ANC_DAL ancDAL = new ANC_DAL(globalContextDetails);
                ancDAL.GetBirthMaturity(out lstBirthMaturity);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBirthMaturity BL", ex);
            }
            return lresult;

        }

        public long GetPlacentalPositions(out List<PlacentalPositions> lstPlacentalPositions)
        {
            long lresult = -1;
            lstPlacentalPositions = new List<PlacentalPositions>();
            try
            {
                ANC_DAL ancDAL = new ANC_DAL(globalContextDetails);
                ancDAL.GetPlacentalPositions(out lstPlacentalPositions);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPlacentalPositions BL", ex);
            }
            return lresult;

        }


        public long GetANCComplaint(int SpecialityID, out List<Complaint> lstComplaint)
        {
            long lresult = -1;
            lstComplaint = new List<Complaint>();
            try
            {
                ANC_DAL ancDAL = new ANC_DAL(globalContextDetails);
                ancDAL.GetANCComplaint(SpecialityID, out lstComplaint);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationSample BL", ex);
            }
            return lresult;

        }

        public long GetANCInvestigation(int pComplaintID, out List<InvestigationMaster> lstInvestigationMaster)
        {
            long returnCode = -1;

            lstInvestigationMaster = new List<InvestigationMaster>();

            try
            {
                returnCode = new ANC_DAL(globalContextDetails).GetANCInvestigation(pComplaintID, out lstInvestigationMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetANCInvestigation", ex);
            }

            return returnCode;
        }

        public long GetAllComplication(string ComplicationName, out List<Complication> lstComplication)
        {
            long lresult = -1;
            lstComplication = new List<Complication>();
            try
            {
                ANC_DAL ancDAL = new ANC_DAL(globalContextDetails);
                lresult = ancDAL.GetAllComplication(ComplicationName, out lstComplication);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPrescription BL", ex);
            }
            return lresult;

        }

        
        public long SaveANC(long patientID, long patientVisitID, ANCPatientDetails pANCPatientDetails,
            List<BackgroundProblem> pBackgroundProblem,
            List<GPALDetails> pGPALDetails, PatientUltraSoundData pUSData,
            List<PatientPastComplication> pComplication,
            List<PatientPastVaccinationHistory> pVaccination,
            List<PatientVitals> lstPatientVitals,
            List<OrderedInvestigations> PatientInvestigationHL, string flag,
            List<PatientTreatmentProcedure> lstPPRO, long orgID, string guid, out int pOrderedInvCnt,
            ANCPatientObservation objANCPatientObservation)
        {
            long returncode = -1;
            ANC_DAL ancDAL = new ANC_DAL(globalContextDetails);
            returncode = ancDAL.SaveANC(patientID,
                patientVisitID,
                pANCPatientDetails,
                pBackgroundProblem,
                pGPALDetails, pUSData, pComplication, pVaccination,
                lstPatientVitals, PatientInvestigationHL,
                flag, lstPPRO, orgID, guid,
                out pOrderedInvCnt, objANCPatientObservation);
            return returncode;
        }


        public long GetANCSpecilaityID(long VisitID, out int specilaityID, out int pFollowup)
        {
            long returnCode = -1;
            specilaityID = -1;
            pFollowup = -1;

            try
            {
                ANC_DAL ancDAL = new ANC_DAL(globalContextDetails);
                returnCode = ancDAL.GetANCSpecialityID(VisitID, out specilaityID, out pFollowup);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetPatientVitals BL", excp);
            }

            return returnCode;
        }

        public long GetANCDetailsbyPVIDCommand(long patientID, long pPatientVisitID, int pComplaintID, out List<ANCPatientDetails> lstANCPatientDetails, out List<BackgroundProblem> lstBackgroundProblem, out List<GPALDetails> lstGPALDetails, out List<PatientUltraSoundData> lstPatientUltraSoundData, out List<PatientPastComplication> lstPatientPastComplication, out List<PatientPastVaccinationHistory> lstPatientPastVaccinationHistory, out List<OrderedInvestigations> lstPatientInvestigationHL, out string proName, out List<ANCPatientObservation> lstANCPatientObservation)
        {
            long returnCode = -1;
            proName = string.Empty;

            lstANCPatientDetails = new List<ANCPatientDetails>();
            lstBackgroundProblem = new List<BackgroundProblem>();
            lstGPALDetails = new List<GPALDetails>();
            lstPatientUltraSoundData = new List<PatientUltraSoundData>();
            lstPatientPastComplication = new List<PatientPastComplication>();
            lstPatientPastVaccinationHistory = new List<PatientPastVaccinationHistory>();
            lstPatientInvestigationHL = new List<OrderedInvestigations>();
            lstANCPatientObservation = new List<ANCPatientObservation>();


            try
            {
                returnCode = new ANC_DAL(globalContextDetails).GetANCDetailsbyPVIDCommand(patientID, pPatientVisitID, pComplaintID, out lstANCPatientDetails, out lstBackgroundProblem, out lstGPALDetails, out lstPatientUltraSoundData, out lstPatientPastComplication, out lstPatientPastVaccinationHistory, out lstPatientInvestigationHL, out proName, out lstANCPatientObservation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetANCDetailsbyPVIDCommand", ex);
            }

            return returnCode;
        }

        public long GetANCDetailsbyPIDCommand(long patientID, out List<ANCPatientDetails> lstANCPatientDetails, out List<BackgroundProblem> lstBackgroundProblem, out List<GPALDetails> lstGPALDetails, out List<PatientUltraSoundData> lstPatientUltraSoundData, out List<PatientPastComplication> lstPatientPastComplication, out List<PatientPastVaccinationHistory> lstPatientPastVaccinationHistory)
        {
            long returnCode = -1;

            lstANCPatientDetails = new List<ANCPatientDetails>();
            lstBackgroundProblem = new List<BackgroundProblem>();
            lstGPALDetails = new List<GPALDetails>();
            lstPatientUltraSoundData = new List<PatientUltraSoundData>();
            lstPatientPastComplication = new List<PatientPastComplication>();
            lstPatientPastVaccinationHistory = new List<PatientPastVaccinationHistory>();

            try
            {
                returnCode = new ANC_DAL(globalContextDetails).GetANCDetailsbyPIDCommand(patientID, out lstANCPatientDetails, out lstBackgroundProblem, out lstGPALDetails, out lstPatientUltraSoundData, out lstPatientPastComplication, out lstPatientPastVaccinationHistory);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetANCDetailsbyPIDCommand", ex);
            }

            return returnCode;
        }

        public long saveANCFollowupData(List<PatientVaccinationHistory> pVaccination, PatientUltraSoundData pUSData, List<PatientVitals> lstPatientVitals, long orgID)
        {
            long returncode = -1;

            ANC_DAL ancDAL = new ANC_DAL(globalContextDetails);
            returncode = ancDAL.saveANCFollowupData(pVaccination, pUSData, lstPatientVitals, orgID);

            return returncode;
        }

        public long GetANCCaseSheetDetails(long pPatinetVisitID, long pPatientID, out List<PatientHistory> lstPatientHistory,
                                                                                  out List<PatientExamination> lstPatientExamination,
                                                                                  out List<PatientComplaint> lstPatientComplaint,
                                                                                  out List<Patient> lstPatient,
                                                                                  out List<PatientAdvice> lstPatientAdvice,
                                                                                  out List<ANCAdvice> lstANCAdvice,
                                                                                  out List<PatientPrescription> lstPatientPrescription,
                                                                                  out List<PatientInvestigation> lstPatientInvestigation,
                                                                                  out List<PatientFetalFindings> lstPatientFetalFindings,
                                                                                  out List<ANCPatientDetails> lstANCPatientDetails,
                                                                                  out List<BackgroundProblem> lstBackgroundProblem,
                                                                                  out List<ANCAlerts> lstANCAlerts,
                                                                                  out List<PatienttoScanforANC> lstANCScan,
                                                                                  out List<PatientComplication> lstPatientComplication,
                                                                                  out int pVisitCount)
        {
            long returnCode = -1;
            pVisitCount = -1;
            lstPatientHistory = new List<PatientHistory>();
            lstPatientExamination = new List<PatientExamination>();
            lstPatientComplaint = new List<PatientComplaint>();
            lstPatient = new List<Patient>();
            lstPatientAdvice = new List<PatientAdvice>();
            lstANCAdvice = new List<ANCAdvice>();
            lstPatientPrescription = new List<PatientPrescription>();
            lstPatientInvestigation = new List<PatientInvestigation>();
            lstPatientFetalFindings = new List<PatientFetalFindings>();
            lstANCPatientDetails = new List<ANCPatientDetails>();
            lstBackgroundProblem = new List<BackgroundProblem>();
            lstANCAlerts = new List<ANCAlerts>();
            lstANCScan = new List<PatienttoScanforANC>();
            lstPatientComplication = new List<PatientComplication>();

            try
            {
                returnCode = new ANC_DAL(globalContextDetails).GetANCCaseSheetDetails(pPatinetVisitID, pPatientID, out lstPatientHistory, out lstPatientExamination, out lstPatientComplaint, out lstPatient, out lstPatientAdvice, out lstANCAdvice, out lstPatientPrescription, out lstPatientInvestigation, out lstPatientFetalFindings, out lstANCPatientDetails, out lstBackgroundProblem, out lstANCAlerts, out lstANCScan, out lstPatientComplication, out pVisitCount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetANCCaseSheetDetails", ex);
            }

            return returnCode;
        }

        public long GetANCCountforNurse(long pPatientVisitID, out int pCount)
        {
            long returnCode = -1;
            pCount = -1;
            try
            {
                returnCode = new ANC_DAL(globalContextDetails).GetANCCountforNurse(pPatientVisitID, out pCount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetANCCountforNurse", ex);
            }

            return returnCode;
        }

        public long GetANCPatientVisitDetailsByVID(int pComplaintID, long patientID, long patientVisitID, out List<OrderedInvestigations> lstPatientInvestigationHL, out List<DrugDetails> lstPatientPrescription, out List<PatientAdvice> lstPatientAdvice, out List<ANCPatientObservation> lstANCPatientObservation)
        {
            long returnCode = -1;

            lstPatientInvestigationHL = new List<OrderedInvestigations>();
            lstPatientPrescription = new List<DrugDetails>();
            lstPatientAdvice = new List<PatientAdvice>();
            lstANCPatientObservation = new List<ANCPatientObservation>();

            try
            {
                returnCode = new ANC_DAL(globalContextDetails).GetANCPatientVisitDetailsByVID(pComplaintID, patientID, patientVisitID, out lstPatientInvestigationHL, out lstPatientPrescription, out lstPatientAdvice, out lstANCPatientObservation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetANCPatientVisitDetailsByVID", ex);
            }
            return returnCode;
        }

        public long GetANCPatientDiagnoseEdit(long pPatientVisitID, long pPatientID, long pCreatedBy, int pComplaintID, out string pScanStatus, out string pNextReviewDate,
                                                                                    out List<PatientComplaint> lstPatientComplaint,
                                                                                    out List<PatientHistory> lstPatientHistory,
                                                                                    out List<PatientExamination> lstPatientExamination,
                                                                                    out List<PatientComplication> lstPatientComplication,
                                                                                    out List<PatientFetalFindings> lstPatientFetalFindings,
                                                                                    out List<PatientAdvice> lstPatientAdvice,
                                                                                    out List<DrugDetails> lstPatientPrescription,
                                                                                    out List<PatientVaccinationHistory> lstPatientVaccinationHistory,
                                                                                    out List<ANCPatientDetails> lstANCPatientDetails,
                                                                                    out List<PatientInvestigation> lstPatientInvestigation,
                                                                                    out List<ANCPatientObservation> lstANCPatientObservation)
        {
            long returnCode = -1;

            lstPatientComplaint = new List<PatientComplaint>();
            lstPatientHistory = new List<PatientHistory>();
            lstPatientExamination = new List<PatientExamination>();
            lstPatientComplication = new List<PatientComplication>();
            lstPatientFetalFindings = new List<PatientFetalFindings>();
            lstPatientAdvice = new List<PatientAdvice>();
            lstPatientPrescription = new List<DrugDetails>();
            lstPatientVaccinationHistory = new List<PatientVaccinationHistory>();
            lstANCPatientDetails = new List<ANCPatientDetails>();
            lstPatientInvestigation = new List<PatientInvestigation>();
            lstANCPatientObservation = new List<ANCPatientObservation>();
            pScanStatus = string.Empty;
            pNextReviewDate = string.Empty;

            returnCode = new ANC_DAL(globalContextDetails).GetANCPatientDiagnoseEdit(pPatientVisitID, pPatientID, pCreatedBy, pComplaintID, out pScanStatus, out pNextReviewDate, out lstPatientComplaint, out lstPatientHistory, out lstPatientExamination, out lstPatientComplication, out lstPatientFetalFindings, out lstPatientAdvice, out lstPatientPrescription, out lstPatientVaccinationHistory, out lstANCPatientDetails, out lstPatientInvestigation, out lstANCPatientObservation);

            return returnCode;
        }

        public long CheckANCNurseTaskStatus(long patientVisitId, int specialityId, long roleId, out int pStatus, out int pLabStatus)
        {
            long returnCode = -1;

            pStatus = -1;
            pLabStatus = -1;

            try
            {
                returnCode = new ANC_DAL(globalContextDetails).CheckANCNurseTaskStatus(patientVisitId, specialityId, roleId, out pStatus, out pLabStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL CheckANCNurseTaskStatus", ex);
            }
            return returnCode;
        }

        public long GetPhysiotheraphyID(long pVisitID, string proDesc, long pOrgId, out List<ProcedureFee> lstProcedureFee)
        {
            long returnCode = -1;
            lstProcedureFee = new List<ProcedureFee>();

            try
            {
                returnCode = new ANC_DAL(globalContextDetails).GetPhysiotheraphyID(pVisitID, proDesc, pOrgId, out lstProcedureFee);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetPhysiotheraphyID", ex);
            }

            return returnCode;
        }

        public long GetANCSnapShotView(long patientVisitID, int pOrgID, out DataSet ds, out List<PatientFetalFindings> lstPFF, out List<ANCPatientObservation> lstANCPatientObservation)
        {
            long returnCode = -1;
            ds = new DataSet();
            lstPFF = new List<PatientFetalFindings>();
            lstANCPatientObservation = new List<ANCPatientObservation>();
            try
            {
                returnCode = new ANC_DAL(globalContextDetails).GetANCSnapShotView(patientVisitID, pOrgID, out ds, out lstPFF, out lstANCPatientObservation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetANCSnapShotView", ex);
            }
            return returnCode;
        }
        
    }
}
