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
    public class Neonatal_BL
    {
         ContextDetails globalContextDetails;
        public Neonatal_BL()
        {

        }
        public Neonatal_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetDeliveryNotesData(int OrgID,out List<SurgeryType> lstSurgeryType, out List<AnesthesiaType> lstAnesthesiaType,out List<DeliveryTypeMaster> lstDeliveryTypeMaster, out List<Physician> lstDeliveringObstretician,out List<Physician> lstNeonatologist, out List<FetalPresentations> lstFetalPresentations)
        {

            long returnCode = -1;
            lstAnesthesiaType = new List<AnesthesiaType>();
            lstSurgeryType = new List<SurgeryType>();
            lstDeliveryTypeMaster = new List<DeliveryTypeMaster>();
            lstFetalPresentations = new List<FetalPresentations>();
            lstDeliveringObstretician = new List<Physician>();
            lstNeonatologist = new List<Physician>();
           
            try
            {

                Neonatal_DAL objNeonatal_DAL = new  Neonatal_DAL(globalContextDetails);
                returnCode = objNeonatal_DAL.GetDeliveryNotesData(OrgID, out lstSurgeryType, out lstAnesthesiaType, out lstDeliveryTypeMaster, out lstDeliveringObstretician, out lstNeonatologist, out lstFetalPresentations);
            }

            catch (Exception excep)
            {

                CLogger.LogError("Error while executing GetDeliveryNotesData in Neonatal_BL", excep);
            }

            return returnCode;
        }

        public long SaveLabourAndDeliveryNotes(int OrgID, long patientVisitID, long patientID, long LID, string pType, int ChildCount, List<LabourAndDeliveryNotes> lstLabourAndDeliveryNotes, List<PatientComplication> lstPatientComplication, List<BirthInstructions> lstBirthInstructions, List<NewBornDetails> lstNewBornDetails, string needIPNumber)
        {
            long returncode = -1;           

            try
            {
                returncode = new  Neonatal_DAL(globalContextDetails).SaveLabourAndDeliveryNotes(OrgID, patientVisitID, patientID, LID, pType, ChildCount, lstLabourAndDeliveryNotes, lstPatientComplication, lstBirthInstructions, lstNewBornDetails, needIPNumber);
            }
            catch (Exception excep)
            {

                CLogger.LogError("Error while executing SaveLabourAndDeliveryNotes in Neonatal_BL", excep);
            }

                return returncode;
        }


        public long GetDeliveryNotesDataForUpdate(long patientVisitID, out List<LabourAndDeliveryNotes> lstLabourAndDeliveryNotes, out List<PatientComplication> lstPatientComplication, out List<BirthInstructions> lstBirthInstructions, out List<NewBornDetails> lstNewBornDetails)
        {
            long returncode = -1;
            lstLabourAndDeliveryNotes = new List<LabourAndDeliveryNotes>();
            lstPatientComplication = new List<PatientComplication>();
            lstBirthInstructions = new List<BirthInstructions>();
            lstNewBornDetails = new List<NewBornDetails>();

            try
            {
                returncode = new  Neonatal_DAL(globalContextDetails).GetDeliveryNotesDataForUpdate(patientVisitID, out lstLabourAndDeliveryNotes, out lstPatientComplication, out lstBirthInstructions, out lstNewBornDetails);
            }
            catch (Exception excep)
            {

                CLogger.LogError("Error while executing GetDeliveryNotesDataForUpdate in Neonatal_BL", excep);
            }

            return returncode;
        }


        public long CheckIsNewBornBaby(int OrgID, long patientVisitID, out long pBornVisitID)
        {
            long returncode = -1;
            pBornVisitID = -1;
           

            try
            {
                returncode = new  Neonatal_DAL(globalContextDetails).CheckIsNewBornBaby(OrgID, patientVisitID, out @pBornVisitID);
            }
            catch (Exception excep)
            {

                CLogger.LogError("Error while executing CheckIsNewBornBaby in Neonatal_BL", excep);
            }

            return returncode;
        }

        public long GetSystemicExaminatiom(out List<Examination> lstExamination)
        {
            long returncode = -1;
            lstExamination = new List<Examination>();
            try
            {
                returncode = new  Neonatal_DAL(globalContextDetails).GetSystemicExaminatiom(out lstExamination);
            }
            catch (Exception excep)
            {

                CLogger.LogError("Error while executing GetSystemicExaminatiom in Neonatal_BL", excep);
            }

            return returncode;
        }

        public long SaveNeonatalNotes(int OrgID, long patientVisitID, long patientID, long LID, string BrfHistory, List<BackgroundProblem> lstRiskFactor, List<PatientVitals> lstPatientVitals, List<PatientExamination> lstPatientExamination, List<PatientAdvice> lstPatientAdvice, List<DrugDetails> lstDrugDetails, List<PatientBabyVaccination> lstPBV, NeonatalNotes objNeonatalNotes, string pType)
        {
            long returncode = -1;

            try
            {
                returncode = new  Neonatal_DAL(globalContextDetails).SaveNeonatalNotes(OrgID, patientVisitID, patientID, LID, BrfHistory, lstRiskFactor, lstPatientVitals, lstPatientExamination, lstPatientAdvice, lstDrugDetails, lstPBV, objNeonatalNotes, pType);
            }
            catch (Exception excep)
            {

                CLogger.LogError("Error while executing GetNeonatalNotes in Neonatal_BL", excep);
            }

            return returncode;
        }


        public long GetNeonatalNotesForUpdate(long patientVisitID,out List<PatientHistoryExt> lstPatientHistoryExt,out List<BackgroundProblem> lstRiskFactor,out List<PatientVitals> lstPatientVitals,out List<PatientExamination> lstPatientExamination,out List<PatientAdvice> lstPatientAdvice,out List<DrugDetails> lstDrugDetails,out List<PatientBabyVaccination> lstPBV,out List<NeonatalNotes> lstNeonatalNotes)
        {
            long returncode = -1;
            lstPatientHistoryExt = new List<PatientHistoryExt>();
            lstRiskFactor = new List<BackgroundProblem>();
            lstPatientVitals = new List<PatientVitals>();
            lstPatientExamination = new List<PatientExamination>();
            lstPatientAdvice = new List<PatientAdvice>();
            lstDrugDetails = new List<DrugDetails>();           
            lstPBV = new List<PatientBabyVaccination>();
            lstNeonatalNotes = new List<NeonatalNotes>();
           



            try
            {
                returncode = new  Neonatal_DAL(globalContextDetails).GetNeonatalNotesForUpdate(patientVisitID, out lstPatientHistoryExt, out lstRiskFactor, out lstPatientVitals, out lstPatientExamination, out lstPatientAdvice, out lstDrugDetails, out lstPBV, out lstNeonatalNotes);
            }
            catch (Exception excep)
            {

                CLogger.LogError("Error while executing GetNeonatalNotesForUpdate in Neonatal_BL", excep);
            }

            return returncode;
        }




        public long GetNewBornDetails(long patientVisitID, int pOrgID, out List<LabourAndDeliveryNotes> lstLabourAndDeliveryNotes, out List<NewBornDetails> lstNewBornDetails)
        {
            long returncode = -1;
            lstLabourAndDeliveryNotes = new List<LabourAndDeliveryNotes>();
            lstNewBornDetails = new List<NewBornDetails>();
            try
            {
                returncode = new  Neonatal_DAL(globalContextDetails).GetNewBornDetails(patientVisitID, pOrgID, out lstLabourAndDeliveryNotes, out lstNewBornDetails);
            }
            catch (Exception excep)
            {

                CLogger.LogError("Error while executing GetNewBornDetails in Neonatal_BL", excep);
            }

            return returncode;
        }

        public long GetInpatientDetails(long patientVisitID, out List<Patient> lstPatient, out List<InPatientAdmissionDetails> lstIPAdmissionDetails)
        {
            long returncode = -1;
            lstPatient = new List<Patient>();
            lstIPAdmissionDetails = new List<InPatientAdmissionDetails>();
            try
            {
                returncode = new  Neonatal_DAL(globalContextDetails).GetInpatientDetails(patientVisitID, out lstPatient, out lstIPAdmissionDetails);
            }
            catch (Exception excep)
            {

                CLogger.LogError("Error while executing GetInpatientDetails in Neonatal_BL", excep);
            }

            return returncode;
        }





    }
}
