using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;
using System.Data;
using System.IO;

namespace Attune.Solution.BusinessComponent
{
    public class PatientVisit_BL
    {
        ContextDetails globalContextDetails;
        public PatientVisit_BL()
        {

        }
        public PatientVisit_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetVisitDetails(long visitID, out List<PatientVisitDetails> lstPatientVisit)
        {
            long returnCode = -1;
            PatientVisit_DAL patDAL = new PatientVisit_DAL(globalContextDetails);
            lstPatientVisit = new List<PatientVisitDetails>();
            returnCode = patDAL.GetVisitDetails(visitID, out lstPatientVisit);
            /*-----------------Handle VIP Data Start-------------------------*/
            List<PatientVisitDetails> lsttempDetails = new List<PatientVisitDetails>();
            lsttempDetails = lstPatientVisit.FindAll(p => p.PatientStatus == "VIP");
            lstPatientVisit.RemoveAll(p => p.PatientStatus == "VIP");
            for (int i = 0; i < lsttempDetails.Count; i++)
            {
                /*----Decrypting----------*/
                Utilities objUtilities = new Utilities();
                object inputobj = new object();
                object Decryptedobj = new object();
                inputobj = lsttempDetails[i];
                returnCode = objUtilities.GetDecryptedobj(inputobj, out Decryptedobj);
                lsttempDetails[i] = (PatientVisitDetails)Decryptedobj;
                /*----------------------*/
                /*-----Masking----------*/
                object inputobj1 = new object();
                object Maskedobj = new object();
                inputobj1 = lsttempDetails[i];
                returnCode = objUtilities.GetMaskedobj(inputobj1, out Maskedobj);
                lsttempDetails[i] = (PatientVisitDetails)Maskedobj;
                lstPatientVisit.Add(lsttempDetails[i]);
                /*----------------------*/
            }
            /*-----------------Handle VIP Data End------------------------------*/
            return returnCode;
        }

        public long GetVisitDetails(long visitID, out List<PatientVisit> lstPatientVisit)
        {
            long returnCode = -1;
            PatientVisit_DAL patDAL = new PatientVisit_DAL(globalContextDetails);
            lstPatientVisit = new List<PatientVisit>();
            returnCode = patDAL.GetVisitDetails(visitID, out lstPatientVisit);
            return returnCode;
        }

        public long GetVisitPurposes(int OrgID, out List<VisitPurpose> lstVisitPurpose)
        {
            long returnCode = -1;
            PatientVisit_DAL pVisit = new PatientVisit_DAL(globalContextDetails);
            returnCode = pVisit.GetVisitPurposes(OrgID, out lstVisitPurpose);
            return returnCode;
        }

        public List<PatientCondition> GetPatientCoditions(int OrgID)
        {
            List<PatientCondition> pConditions = new List<PatientCondition>();
            PatientCondition_DAL pDal = new PatientCondition_DAL(globalContextDetails);
            pDal.GetPatientConditions(out pConditions);
            return pConditions;

        }

        public long SaveVisit(PatientVisit pVisit, out long visitID, long enteredPatientID, int iTokenNo, long lScheduleID,
                                                                                long lResourcetemplateID, string sPassedTime,
                                                                                out int iReturnTokenNumber, DateTime dFromTime,
            DateTime dTotime, string needIPNumber, List<VisitClientMapping> lstVisitClientMapping)
        {
            visitID = -1;
            long retCode = -1;
            iReturnTokenNumber = 0;

            try
            {
                PatientVisit_DAL pvDAL = new PatientVisit_DAL(globalContextDetails);
                retCode = pvDAL.InsertVisit(pVisit, out visitID, enteredPatientID, iTokenNo, lScheduleID,
                                                                                lResourcetemplateID,
                                                                                sPassedTime,
                                                                                out iReturnTokenNumber, dFromTime, dTotime, needIPNumber, lstVisitClientMapping);
            }
            catch (Exception ex)
            {
                retCode = -1;
			CLogger.LogError("Error while executing SaveVisit in PatientVisit_BL", ex);
            }
            return retCode;
        }



        public long SaveContinueSameTreatment(long currentVisitID, long previousVisitID, string nextReviewDate, long pLID)
        {

            long retCode = -1;
            try
            {
                PatientVisit_DAL pvDAL = new PatientVisit_DAL(globalContextDetails);

                retCode = pvDAL.SaveContinueSameTreatment(currentVisitID, previousVisitID, nextReviewDate, pLID);
            }
            catch (Exception ex)
            {
                retCode = -1;
                CLogger.LogError("Error while executing SaveContinueSameTreatment in PatientVisit_BL", ex);
            }
            return retCode;
        }

        public long GetInsertVisitPurpose(int OrgID, List<VisitPurpose> lstVisitPurpose, string ptype)
        {
            long returnCode = -1;
            PatientVisit_DAL patientDAL = new PatientVisit_DAL(globalContextDetails);
            // DataTable DtVisitPurpose = GetDataTable1(lstVisitPurpose);
            try
            {
                returnCode = patientDAL.GetInsertVisitPurpose(OrgID, lstVisitPurpose, ptype);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInsertVisitPurpose in PatientVisit_BL", ex);
            }
            return returnCode;
        }

        public long GetProcedureName(long orgID, out List<ProcedureMaster> lstProcedureName)
        {
            long returnCode = -1;
            lstProcedureName = new List<ProcedureMaster>();
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetProcedureName(orgID, out lstProcedureName);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetProcedureName in PatientVisit_BL", ex);
            }
            return returnCode;
        }
        //public long GetAmbulance(int orgID, out List<Ambulancedetails> lstProcedureName)
        //{
        //    long returnCode = -1;
        //    lstProcedureName = new List<Ambulancedetails>();
        //    try
        //    {
        //        returnCode = new  PatientVisit_DAL(globalContextDetails).GetAmbulance(orgID, out lstProcedureName);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("error while GetProcedureName", ex);
        //    }
        //    return returnCode;
        //}

        //public long GetSpecialityName(long orgID, out List<Speciality> lstSpecialityName)
        //{
        //    lstSpecialityName = new List<Speciality>();
        //    long returnCode = -1;
        //    try
        //    {
        //        returnCode = new  PatientVisit_DAL(globalContextDetails).GetSpecialityName(orgID, out lstSpecialityName);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while loading GetSpecialityName BL", ex);
        //    }
        //    return returnCode;
        //}

        public long GetSpecialityAndSpecialityName(long orgID, out List<PhysicianSpeciality> lstPhySpecialityName, int iRateID, out List<Speciality> lstSpeciality)
        {
            lstPhySpecialityName = new List<PhysicianSpeciality>();
            lstSpeciality = new List<Speciality>();
            long returnCode = -1;
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetSpecialityAndSpecialityName(orgID, out lstPhySpecialityName, iRateID, out lstSpeciality);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetSpecialityAndSpecialityName in PatientVisit_BL", ex);
            }
            return returnCode;
        }
        public long CorporateGetSpecialityAndSpecialityName(long orgID, out List<PhysicianSpeciality> lstPhySpecialityName, int iRateID, out List<Speciality> lstSpeciality)
        {
            lstSpeciality = new List<Speciality>();
            lstPhySpecialityName = new List<PhysicianSpeciality>();
            long returnCode = -1;
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).CorporateGetSpecialityAndSpecialityName(orgID, out lstPhySpecialityName, iRateID, out lstSpeciality);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing CorporateGetSpecialityAndSpecialityName in PatientVisit_BL", ex);
            }
            return returnCode;
        }
        public long CorporateGetSpecialityName(long orgID, int iRateID, long SID, out List<PhysicianSpeciality> lstPhySpecialityName)
        {
            lstPhySpecialityName = new List<PhysicianSpeciality>();
            long returnCode = -1;
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).CorporateGetSpecialityName(orgID, iRateID, SID, out lstPhySpecialityName);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing CorporateGetSpecialityName in PatientVisit_BL", ex);
            }
            return returnCode;
        }
        public long GetConsultingName(long specialityID, int orgID, out List<Physician> lstPhysician)
        {
            lstPhysician = new List<Physician>();
            long returnCode = -1;
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetConsultingName(specialityID, orgID, out lstPhysician);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetConsultingName in PatientVisit_BL", ex);
            }
            return returnCode;
        }

        public long GetTaskActionID(long orgID, long visitPutposeID, long otherID, out List<TaskActions> lstTaskAction)
        {
            lstTaskAction = new List<TaskActions>();
            long returnCode = -1;
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetTaskActionID(orgID, visitPutposeID, otherID, out lstTaskAction);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetTaskActionID in PatientVisit_BL", ex);
            }
            return returnCode;
        }

        public long GetPhysicianByProcedure(long orgID, long procedureID, out List<Physician> lstPhysician)
        {
            lstPhysician = new List<Physician>();
            long returnCode = -1;
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetPhysicianByProcedure(orgID, procedureID, out lstPhysician);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPhysicianByProcedure in PatientVisit_BL", ex);
            }
            return returnCode;
        }

        public long GetPatientVisitDetailsByvisitID(int complaintID, long visitId, out PatientComplaint patientComplaint, out List<OrderedInvestigations> lstPatientInvestigationHL, out List<PatientHistory> lstPatientHistory, out List<PatientExamination> lstPatientExamination, out List<DrugDetails> lstPatientPrescription, out List<PatientAdvice> lstPatientAdvice, out List<PatientVisit> lstPatientVisit, out string isBgP)
        {
            long returncode = -1;
            patientComplaint = new PatientComplaint();
            lstPatientExamination = new List<PatientExamination>();
            lstPatientHistory = new List<PatientHistory>();
            lstPatientInvestigationHL = new List<OrderedInvestigations>();
            lstPatientPrescription = new List<DrugDetails>();
            lstPatientAdvice = new List<PatientAdvice>();
            lstPatientVisit = new List<PatientVisit>();
            isBgP = string.Empty;
            try
            {

                PatientVisit_DAL patientVisitDal = new PatientVisit_DAL(globalContextDetails);
                returncode = patientVisitDal.GetPatientVisitDetailsByvisitID(complaintID, visitId, out patientComplaint, out lstPatientInvestigationHL, out lstPatientHistory, out lstPatientExamination, out lstPatientPrescription, out lstPatientAdvice, out lstPatientVisit, out isBgP);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPatientVisitDetailsByvisitID in PatientVisit_BL", ex);
            }
            return returncode;
        }

        public long GetPatientVisitDetailsByvisitID(long visitId, out List<PatientComplaint> lstPatientComplaint, out List<OrderedInvestigations> lstPatientInvestigationHL, out List<PatientHistory> lstPatientHistory, out List<PatientExamination> lstPatientExamination, out List<DrugDetails> lstPatientPrescription, out List<PatientAdvice> lstPatientAdvice, out List<PatientVisit> lstPatientVisit)
        {
            long returncode = -1;
            lstPatientComplaint = new List<PatientComplaint>();
            lstPatientExamination = new List<PatientExamination>();
            lstPatientHistory = new List<PatientHistory>();
            lstPatientInvestigationHL = new List<OrderedInvestigations>();
            lstPatientPrescription = new List<DrugDetails>();
            lstPatientAdvice = new List<PatientAdvice>();
            lstPatientVisit = new List<PatientVisit>();
            try
            {
                PatientVisit_DAL patientVisitDal = new PatientVisit_DAL(globalContextDetails);
                returncode = patientVisitDal.GetPatientVisitDetailsByvisitID(visitId, out lstPatientComplaint, out lstPatientInvestigationHL, out lstPatientHistory, out lstPatientExamination, out lstPatientPrescription, out lstPatientAdvice, out lstPatientVisit);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPatientVisitDetailsByvisitID in PatientVisit_BL", ex);
            }
            return returncode;
        }

        public long GetPatientVisit(long patientID, int pVisitID, int pOrgID, int pVisitType, out List<PatientVisit> lstPatientVisit, out List<OrderedInvestigations> lOrderedInv, out string pPatientName, out string pPatientNo)
        {
            long returnCode = -1;
            lstPatientVisit = new List<PatientVisit>();
            lOrderedInv = new List<OrderedInvestigations>();
            pPatientName = string.Empty;
            pPatientNo = string.Empty;
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetPatientVisit(patientID, pVisitID, pOrgID, pVisitType, out lstPatientVisit, out lOrderedInv, out pPatientName, out pPatientNo);
                /*-----------------Handle VIP Data Start-------------------------*/
                List<PatientVisit> lsttempDetails = new List<PatientVisit>();
                lsttempDetails = lstPatientVisit.FindAll(P => P.PatientStatus == "VIP");
                lstPatientVisit.RemoveAll(p => p.PatientStatus == "VIP");
                for (int i = 0; i < lsttempDetails.Count; i++)
                {
                    /*----Decrypting----------*/
                    Utilities objUtilities = new Utilities();
                    object inputobj = new object();
                    object Decryptedobj = new object();
                    inputobj = lsttempDetails[i];
                    returnCode = objUtilities.GetDecryptedobj(inputobj, out Decryptedobj);
                    lsttempDetails[i] = (PatientVisit)Decryptedobj;
                    /*----------------------*/
                    /*-----Masking----------*/
                    object inputobj1 = new object();
                    object Maskedobj = new object();
                    inputobj1 = lsttempDetails[i];
                    returnCode = objUtilities.GetMaskedobj(inputobj1, out Maskedobj);
                    lsttempDetails[i] = (PatientVisit)Maskedobj;
                    lstPatientVisit.Add(lsttempDetails[i]);
                    /*----------------------*/
                }
                for (int j = 0; j < lstPatientVisit.Count; j++)
                {
                    lstPatientVisit[j].PatientName = lstPatientVisit[j].TitleName + " " + lstPatientVisit[j].PatientName + "  (Patient No: " + lstPatientVisit[j].PatientNumber + ")";
                }
                /*-----------------Handle VIP Data End------------------------------*/
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPatientVisit in PatientVisit_BL", ex);
            }
            return returnCode;
        }


        //public long GetVisitSearchActions(int roleID, int parentID, out List<VisitSearchActions> lstVisitSearchActions)
        //{
        //    long returnCode = -1;
        //    lstVisitSearchActions = new List<VisitSearchActions>();
        //    try
        //    {
        //        returnCode = new  PatientVisit_DAL(globalContextDetails).GetVisitSearchActions(roleID, parentID, out lstVisitSearchActions);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while loading GetVisitSearchActions BL", ex);
        //    }
        //    return returnCode;
        //}


        public long GetVisitSearchDetails(long patientID, string fromDate, string toDate, int pOrgID, int pVisitType, out List<PatientVisit> lstPatientVisit)
        {
            long returnCode = -1;
            lstPatientVisit = new List<PatientVisit>();
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetVisitSearchDetails(patientID, fromDate, toDate, pOrgID, pVisitType, out lstPatientVisit);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetVisitSearchDetails in PatientVisit_BL", ex);
            }
            return returnCode;
        }

        public long GetVisitPurposeName(int orgid, long visitid, out List<VisitPurpose> lstVisitPurpose)
        {
            long returnCode = -1;
            lstVisitPurpose = new List<VisitPurpose>();
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetVisitPurposeName(orgid, visitid, out lstVisitPurpose);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetVisitPurposeName in PatientVisit_BL", ex);
            }
            return returnCode;
        }

        public long GetVisitPurpose(int OrgID, string pType, out List<VisitPurpose> lstVisitPurpose)
        {
            long returnCode = -1;
            lstVisitPurpose = new List<VisitPurpose>();
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetVisitPurpose(OrgID, pType, out lstVisitPurpose);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetVisitPurpose in PatientVisit_BL", ex);
            }
            return returnCode;
        }

        public long GetDoctorsReferred(out List<ReferenceOrg> lstRefOrg)
        {
            long returnCode = -1;
            lstRefOrg = new List<ReferenceOrg>();
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetDoctorsReferred(out lstRefOrg);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetDoctorsReferred in PatientVisit_BL", ex);
            }
            return returnCode;
        }
        public long GetCurrentDateVisitDetails(int currentOrgID, List<TrustedOrgDetails> lstTOD, long loginID, int parentID, string description, long physicianID, string patientName, out List<PatientVisit> lstPatientVisit, out int totalCount, long LocationID)
        {
            long returnCode = -1;
            totalCount = 0;
            PatientVisit_DAL patDAL = new PatientVisit_DAL(globalContextDetails);
            lstPatientVisit = new List<PatientVisit>();
            // DataTable dtOrgIDs = GetOrgIDs(lstTOD);
            try
            {
                returnCode = patDAL.GetCurrentDateVisitDetails(currentOrgID, lstTOD, loginID, parentID, description, physicianID, patientName, out lstPatientVisit, out totalCount, LocationID);
                /*-----------------Handle VIP Data Start-------------------------*/
                List<PatientVisit> lsttempDetails = new List<PatientVisit>();
                lsttempDetails = lstPatientVisit.FindAll(p => p.PatientStatus == "VIP");
                lstPatientVisit.RemoveAll(p => p.PatientStatus == "VIP");
                for (int i = 0; i < lsttempDetails.Count; i++)
                {
                    /*----Decrypting----------*/
                    Utilities objUtilities = new Utilities();
                    object inputobj = new object();
                    object Decryptedobj = new object();
                    inputobj = lsttempDetails[i];
                    returnCode = objUtilities.GetDecryptedobj(inputobj, out Decryptedobj);
                    lsttempDetails[i] = (PatientVisit)Decryptedobj;
                    /*----------------------*/
                    /*-----Masking----------*/
                    object inputobj1 = new object();
                    object Maskedobj = new object();
                    inputobj1 = lsttempDetails[i];
                    returnCode = objUtilities.GetMaskedobj(inputobj1, out Maskedobj);
                    lsttempDetails[i] = (PatientVisit)Maskedobj;
                    lstPatientVisit.Add(lsttempDetails[i]);
                    /*----------------------*/
                }
                for (int j = 0; j < lstPatientVisit.Count; j++)
                {
                    lstPatientVisit[j].PatientName = lstPatientVisit[j].TitleName + " " + lstPatientVisit[j].PatientName;
                }
                /*-----------------Handle VIP Data End------------------------------*/
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetCurrentDateVisitDetails in PatientVisit_BL", ex);
            }
            return returnCode;

        }
        public long GetCurrentDateVisitsByName(int currentOrgID, List<TrustedOrgDetails> lstTOD, long loginID, int parentID, string strName, out List<PatientVisit> lstPatientVisit, out List<PatientVisit> lstPhysicianPV, out int totalCount)
        {
            long returnCode = -1;
            PatientVisit_DAL patDAL = new PatientVisit_DAL(globalContextDetails);
            lstPatientVisit = new List<PatientVisit>();
            // DataTable dtOrgIDs = GetOrgIDs(lstTOD);
            returnCode = patDAL.GetCurrentDateVisitsByName(currentOrgID, lstTOD, loginID, parentID, strName, out lstPatientVisit, out lstPhysicianPV, out totalCount);
            return returnCode;
        }

        public long GetRelationship(out List<Relationship> lstRelationship)
        {
            long returnCode = -1;
            PatientVisit_DAL gRelationship = new PatientVisit_DAL(globalContextDetails);
            returnCode = gRelationship.GetRelationship(out lstRelationship);
            return returnCode;
        }

        public long GetDoctorsForLab(int orgID, out List<Physician> lstPhysician)
        {
            long returnCode = -1;
            lstPhysician = new List<Physician>();
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetDoctorsForLab(orgID, out lstPhysician);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetDoctorsReferred in PatientVisit_BL", ex);
            }
            return returnCode;
        }

        public long GetVisitEntryPageData(long pOrgID, string pPatientName,
                                            out List<PatientCondition> lstPatientCondition,
                                            out List<OrganizationAddress> lstLocation,
                                            out List<PhysicianSchedule> lstPhysician,
                                            out List<VisitPurpose> lstVisitPurpose,
                                            out List<Patient> lstPatient,
                                            out List<Bookings> lstBookings,
                                            out List<Complaint> lstScheduleTimes,
                                            out List<Bookings> lstFullSchedules,
                                            out List<PriorityMaster> lstPriorityMaster,
                                            int LocationID)
        {
            long returnCode = -1;

            lstPatientCondition = new List<PatientCondition>();
            lstLocation = new List<OrganizationAddress>();
            lstPhysician = new List<PhysicianSchedule>();
            lstVisitPurpose = new List<VisitPurpose>();
            lstPatient = new List<Patient>();
            lstBookings = new List<Bookings>();
            lstScheduleTimes = new List<Complaint>();
            lstFullSchedules = new List<Bookings>(); lstPriorityMaster = new List<PriorityMaster>();
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetVisitEntryPageData(pOrgID, pPatientName, out lstPatientCondition,
                                            out lstLocation, out lstPhysician, out lstVisitPurpose,
                                            out lstPatient, out lstBookings, out lstScheduleTimes, out lstFullSchedules, out lstPriorityMaster, LocationID);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetDoctorsReferred in PatientVisit_BL", ex);
            }

            return returnCode;
        }

        public long GetDieTarySpecification(int orgID, long patientID, long visitID, out List<OrgDietTypeMapping> lstOrgDietType,
            out List<OrgDietPatternMapping> lstOrgDietPattern, out List<OrgDietPlanMapping> lstOrgDietPlan,
            out List<ModeofOxygenDelivery> lstModeofOxygenDelivery, out List<Patient> lstPatient,
            out List<PatientCondition> lstPatientCondition, out List<InPatientAdmissionDetails> lstInpatient)
        {
            long returnCode = -1;
            lstOrgDietType = new List<OrgDietTypeMapping>();
            lstOrgDietPattern = new List<OrgDietPatternMapping>();
            lstOrgDietPlan = new List<OrgDietPlanMapping>();
            lstModeofOxygenDelivery = new List<ModeofOxygenDelivery>();
            lstPatient = new List<Patient>();
            lstPatientCondition = new List<PatientCondition>();
            lstInpatient = new List<InPatientAdmissionDetails>();
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetDieTarySpecification(orgID, patientID, visitID, out lstOrgDietType, out lstOrgDietPattern, out lstOrgDietPlan, out lstModeofOxygenDelivery, out lstPatient, out lstPatientCondition, out lstInpatient);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetDieTarySpecification in PatientVisit_BL", ex);
            }
            return returnCode;

        }

        public long SaveHISAdmissionDetail(long visitID, PatientDietSpecification patientDietSpec, InPatientAdmissionDetails inPatientAdmission, List<BelongingsHandoverDetails> lstBelong)
        {
            long returnCode = -1;
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).SaveHISAdmissionDetail(visitID, patientDietSpec, inPatientAdmission, lstBelong);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveHISAdmissionDetail in PatientVisit_BL", ex);
            }
            return returnCode;
        }

        public long GetPurposeOfAdmission(int OrgID, out List<PurposeOfAdmission> lstPurposeOfAdmission)
        {
            long returnCode = -1;
            PatientVisit_DAL pPOA = new PatientVisit_DAL(globalContextDetails);
            returnCode = pPOA.GetPurposeOfAdmission(OrgID, out lstPurposeOfAdmission);
            return returnCode;
        }

        public long GetConditionOnAdmission(out List<PatientCondition> lstConditionOnAdmission)
        {
            long returnCode = -1;
            PatientVisit_DAL pCOA = new PatientVisit_DAL(globalContextDetails);
            returnCode = pCOA.GetConditionOnAdmission(out lstConditionOnAdmission);
            return returnCode;
        }
        public long GetOrgan(out List<Organ> lstOrgan)
        {
            long returnCode = -1;
            PatientVisit_DAL gOrgan = new PatientVisit_DAL(globalContextDetails);
            returnCode = gOrgan.GetOrgan(out lstOrgan);
            return returnCode;
        }
        public long GetKnowledgeOfService(out List<KnowledgeOfService> lstKnowledgeOfService)
        {
            long returnCode = -1;
            PatientVisit_DAL gKnowledgeOfService = new PatientVisit_DAL(globalContextDetails);
            returnCode = gKnowledgeOfService.GetKnowledgeOfService(out lstKnowledgeOfService);
            return returnCode;
        }
        public long InsertPatientIndents(List<PatientDueChart> lstSurgergicalPkg,
            List<OrderedInvestigations> pPatientInvTable,
            List<PatientDueChart> pPatientConsultation,
            List<PatientDueChart> pPatientProcedure,
            List<PatientDueChart> pPatientIndents,
            List<DHEBAdder> pDHEBPatientIndents,
            long visitID, long CreatedBy, long patientID, out string InterimBillNo)
        {
            long returnCode = -1;

            PatientVisit_DAL objPatientIndents = new PatientVisit_DAL(globalContextDetails);
            objPatientIndents.InsertPatientIndents(lstSurgergicalPkg, pPatientInvTable, pPatientConsultation, pPatientProcedure, pPatientIndents, pDHEBPatientIndents, visitID, CreatedBy, patientID, out InterimBillNo);
            // dtPatientItems = null;
            return returnCode;
        }



        public long GetMedicalItems(out List<MedicalIndents> lstMedicalIndents, int orgID)
        {
            long returnCode = -1;
            lstMedicalIndents = new List<MedicalIndents>();
            returnCode = new PatientVisit_DAL(globalContextDetails).GetMedicalItems(out lstMedicalIndents, orgID);
            return returnCode;
        }

        public long GetDueChart(out List<PatientDueChart> lstPatientDueChart, long orgID, long pVisitID, string selType, out decimal pTotalAdvance, out List<AdvancePaidDetails> lstAdvancePaidDetails)
        {
            long returnCode = -1;
            pTotalAdvance = 0;
            lstAdvancePaidDetails = new List<AdvancePaidDetails>();
            lstPatientDueChart = new List<PatientDueChart>();
            returnCode = new PatientVisit_DAL(globalContextDetails).GetDueChart(out lstPatientDueChart, orgID, pVisitID, selType, out pTotalAdvance, out lstAdvancePaidDetails);
            return returnCode;
        }

        public long InsertPatientBillItemsDetails(List<PatientDueChart> pPatientIndTable, long visitID,
                                                    long CreatedBy, long orgID, decimal pAmountReceived, decimal pRefundAmount,
                                                    decimal pDiscountAmount, decimal pDue, decimal pGrossBillValue, string isCreditBill,
                                                    decimal pnetValue, decimal pAdvanceReceived, DataTable dtAmtReceivedDetails, decimal pAmtReceived,
                                                    long pReceivedBy, string sType, int LocationID,
                                                    decimal dserviceCharge, string TPAPaymentType, string PayerType,
                                                    out string ReceiptNo, out long IpIntermediateID, out string sPaymentType)
        {
            long ireturnStatus = -1;
            //DataTable dtDueChart = new DataTable();
            ReceiptNo = "";
            IpIntermediateID = 0;
            sPaymentType = "";
            try
            {
                //Utilities.ConvertFrom(pPatientIndTable, out dtDueChart);
                //dtDueChart = GetDueChartDataTable(pPatientIndTable);
                ireturnStatus = new PatientVisit_DAL(globalContextDetails).InsertPatientBillItemsDetails(pPatientIndTable, visitID,
                                                    CreatedBy, orgID, pAmountReceived, pRefundAmount,
                                                    pDiscountAmount, pDue, pGrossBillValue, isCreditBill,
                                                    pnetValue, pAdvanceReceived, dtAmtReceivedDetails, pAmtReceived,
                                                    pReceivedBy, sType, LocationID,
                                                    dserviceCharge, TPAPaymentType, PayerType, out ReceiptNo, out IpIntermediateID, out sPaymentType);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertPatientBillItemsDetails in PatientVisit_BL", ex);
            }

            return ireturnStatus;
        }



        public long GetInPatientVisitDetails(long patientID, out List<PatientVisit> lstPatientVisit)
        {
            long returnCode = -1;
            lstPatientVisit = new List<PatientVisit>();
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetInPatientVisitDetails(patientID, out lstPatientVisit);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInPatientVisitDetails in PatientVisit_BL", ex);
            }
            return returnCode;
        }


        public long GetInPatientBills(long patientID, long pOrgID,
                                           long pVisitID,
                                           out List<BillingDetails> lstPatientVisit,
                                           out List<Patient> lstpatient, out decimal pAmountReceived, out decimal pGrandTotal, out decimal dServiceCharge)
        {
            long returnCode = -1;
            pAmountReceived = 0;
            pGrandTotal = 0;
            dServiceCharge = 0;
            lstPatientVisit = new List<BillingDetails>();
            lstpatient = new List<Patient>();
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetInPatientBills(patientID, pOrgID, pVisitID, out lstPatientVisit, out lstpatient, out pAmountReceived, out pGrandTotal, out dServiceCharge);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInPatientBills in PatientVisit_BL", ex);
            }
            return returnCode;
        }

        public long UpdatePatientBillingStatus(List<PatientDueChart> lstBillingDetails, out long lReceiptNO)
        {
            long ireturnStatus = -1;
            lReceiptNO = 0;
            //DataTable dtDatas = new DataTable();
            //dtDatas = GetDueChartDataTable(lstBillingDetails);
            ireturnStatus = new PatientVisit_DAL(globalContextDetails).UpdatePatientBillingStatus(lstBillingDetails, out lReceiptNO);
            return ireturnStatus;
        }

        public long GetIPPaymentTypes(long roleID, long ParentID,
                                            out List<IpPayments> lstIpPayments)
        {
            long returnCode = -1;

            lstIpPayments = new List<IpPayments>();
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetIPPaymentTypes(roleID, ParentID, out lstIpPayments);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPPaymentTypes in PatientVisit_BL", ex);
            }
            return returnCode;
        }

        public long InsertAdditionalBillItems(PatientDueChart pDueChart, string pType, out string InterimBillNo)
        {
            long ireturnStatus = -1;
            ireturnStatus = new PatientVisit_DAL(globalContextDetails).InsertAdditionalBillItems(pDueChart, pType, out InterimBillNo);
            return ireturnStatus;
        }

        public long GetIPBillSettlement(long pVisitID, long patientID, long orgID, out decimal ptotalReceived,
                                        out decimal ptotalAdvance, out decimal pTotalDue,
                                        out decimal pPreviousRefund, out List<PatientDueChart> lstIpPayments,
                                        out List<PatientDueChart> lstBedBooking, out decimal pTotSurgeryAdv,
                                        out decimal pTotSurgeryAmt, out List<Patient> lstPatientDetail,
                                        out List<Organization> lstOrganization,
                                        out List<Physician> physicianName,
                                        out List<Taxmaster> lstTaxes,
                                        out List<FinalBill> lstFinalBill,
                                        out decimal dPayerTotal,
                                        out decimal pNonMedicalAmtPaid,
                                        out decimal pCoPayment,
                                        out decimal pExcess, out string AdmissionDate, out string MaxBillDate, out string IsVisitHaveChild, int RoomTypeID)
        {
            long returnCode = -1;
            lstIpPayments = new List<PatientDueChart>();
            lstBedBooking = new List<PatientDueChart>();

            lstPatientDetail = new List<Patient>();
            lstOrganization = new List<Organization>();
            physicianName = new List<Physician>();
            lstTaxes = new List<Taxmaster>();
            lstFinalBill = new List<FinalBill>();

            ptotalReceived = 0;
            ptotalAdvance = 0;
            pTotalDue = 0;
            pPreviousRefund = 0;
            pTotSurgeryAdv = 0;
            pTotSurgeryAmt = 0;
            dPayerTotal = 0;

            pNonMedicalAmtPaid = decimal.Zero;
            pCoPayment = decimal.Zero;
            pExcess = decimal.Zero;
            AdmissionDate = "01/01/1753";
            MaxBillDate = "01/01/1753";
            IsVisitHaveChild = string.Empty;
            try
            {

                returnCode = new PatientVisit_DAL(globalContextDetails).GetIPBillSettlement(pVisitID, patientID, orgID,
                                                        out ptotalReceived, out ptotalAdvance, out pTotalDue,
                                                        out pPreviousRefund, out lstIpPayments, out lstBedBooking,
                                                        out pTotSurgeryAdv, out pTotSurgeryAmt,
                                                        out lstPatientDetail,
                                                        out lstOrganization,
                                                        out physicianName,
                                                        out lstTaxes,
                                                        out lstFinalBill,
                                                        out dPayerTotal,
                                                        out pNonMedicalAmtPaid,
                                                        out pCoPayment,
                                                        out pExcess, out  AdmissionDate, out MaxBillDate, out IsVisitHaveChild, RoomTypeID);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPBillSettlement in PatientVisit_BL", ex);
            }
            return returnCode;
        }

        public long GetIPBillSettlement_CreditBill(long pVisitID, long patientID, long orgID, out decimal ptotalReceived,
                                       out decimal ptotalAdvance, out decimal pTotalDue,
                                       out decimal pPreviousRefund, out List<PatientDueChart> lstIpPayments,
                                       out List<PatientDueChart> lstBedBooking, out decimal pTotSurgeryAdv,
                                       out decimal pTotSurgeryAmt, out List<Patient> lstPatientDetail,
                                       out List<Organization> lstOrganization,
                                       out List<Physician> physicianName,
                                       out List<Taxmaster> lstTaxes,
                                       out List<FinalBill> lstFinalBill,
                                       out decimal dPayerTotal,
                                       out decimal pNonMedicalAmtPaid,
                                       out decimal pCoPayment,
                                       out decimal pExcess, out string AdmissionDate, out string MaxBillDate)
        {
            long returnCode = -1;
            lstIpPayments = new List<PatientDueChart>();
            lstBedBooking = new List<PatientDueChart>();

            lstPatientDetail = new List<Patient>();
            lstOrganization = new List<Organization>();
            physicianName = new List<Physician>();
            lstTaxes = new List<Taxmaster>();
            lstFinalBill = new List<FinalBill>();

            ptotalReceived = 0;
            ptotalAdvance = 0;
            pTotalDue = 0;
            pPreviousRefund = 0;
            pTotSurgeryAdv = 0;
            pTotSurgeryAmt = 0;
            dPayerTotal = 0;

            pNonMedicalAmtPaid = decimal.Zero;
            pCoPayment = decimal.Zero;
            pExcess = decimal.Zero;
            AdmissionDate = "01/01/1753";
            MaxBillDate = "01/01/1753";

            try
            {

                returnCode = new PatientVisit_DAL(globalContextDetails).GetIPBillSettlement_CreditBill(pVisitID, patientID, orgID,
                                                        out ptotalReceived, out ptotalAdvance, out pTotalDue,
                                                        out pPreviousRefund, out lstIpPayments, out lstBedBooking,
                                                        out pTotSurgeryAdv, out pTotSurgeryAmt,
                                                        out lstPatientDetail,
                                                        out lstOrganization,
                                                        out physicianName,
                                                        out lstTaxes,
                                                        out lstFinalBill,
                                                        out dPayerTotal,
                                                        out pNonMedicalAmtPaid,
                                                        out pCoPayment,
                                                        out pExcess, out  AdmissionDate, out MaxBillDate);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPBillSettlement_CreditBill in PatientVisit_BL", ex);
            }
            return returnCode;
        }




        public long GetConsolidatedPharmacyBill(long pVisitID, out decimal AmtRcvd, out decimal GrossBill, out decimal Discount, out List<BillingDetails> lstBillingDetails, out List<BillingDetails> lstBillingRefundDetails, out List<Patient> lstPatientDetail, out List<FinalBill> lstFinalBill, out List<FinalBill> lstFinalbillDtls)
        {
            long returnCode = -1;
            lstBillingDetails = new List<BillingDetails>();
            lstPatientDetail = new List<Patient>();
            lstFinalBill = new List<FinalBill>();
            lstBillingRefundDetails = new List<BillingDetails>();
            lstFinalbillDtls = new List<FinalBill>();
            GrossBill = 0;
            AmtRcvd = 0;
            Discount = 0;
            try
            {

                returnCode = new PatientVisit_DAL(globalContextDetails).GetConsolidatedPharmacyBill(pVisitID, out  AmtRcvd, out  GrossBill, out  Discount, out  lstBillingDetails, out lstBillingRefundDetails, out lstPatientDetail, out lstFinalBill, out lstFinalbillDtls);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetConsolidatedPharmacyBill in PatientVisit_BL", ex);
            }
            return returnCode;
        }


















        public long pSaveIPFinalBill(List<PatientDueChart> pPatientIndList, long visitID,
                                                   long CreatedBy, long orgID, decimal pAmountReceived, decimal pRefundAmount, string sReasonForRefund, int payamenttype, string bankname, long checkno,
                                                   decimal pDiscountAmount, decimal pDue, decimal pGrossBillValue, string isCreditBill,
                                                   decimal pnetValue, decimal pAdvanceReceived, DataTable dtAmtReceivedDetails, decimal pAmtReceived,
                                                   long pReceivedBy, string dischargeStatus, DateTime dischargeDate,
                                                    List<TaxBillDetails> lstTaxDetails, string discountReason,
                                                    decimal dserviceCharge, string pVisitState,
                                                    decimal pNonMedicalAmtPaid, decimal pCoPayment, decimal pExcess,
                                                    out string ReceiptNo, out long sStartID, out long sEndID,
                                                    out long IPInterID, out string sType, decimal dRoundOff, int RoomTypeID, List<VisitClientMapping> lstVisitClientMapping)
        {
            long ireturnStatus = -1;

            ReceiptNo = "";
            sStartID = 0;
            sEndID = 0;
            IPInterID = 0;
            sType = "";
            try
            {


                ireturnStatus = new PatientVisit_DAL(globalContextDetails).SaveIPFinalBill(pPatientIndList, visitID,
                                                       CreatedBy, orgID, pAmountReceived, pRefundAmount, sReasonForRefund, payamenttype, bankname, checkno,
                                                       pDiscountAmount, pDue, pGrossBillValue, isCreditBill,
                                                       pnetValue, pAdvanceReceived, dtAmtReceivedDetails, pAmtReceived,
                                                       pReceivedBy, dischargeStatus, dischargeDate, lstTaxDetails,
                                                       discountReason, dserviceCharge, pVisitState,
                                                       pNonMedicalAmtPaid, pCoPayment, pExcess,
                                                       out ReceiptNo, out sStartID, out sEndID,
                                                       out IPInterID, out sType, dRoundOff, RoomTypeID, lstVisitClientMapping);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing pSaveIPFinalBill in PatientVisit_BL", ex);
            }

            return ireturnStatus;
        }

        public long UpdateIPFinalBill(List<PatientDueChart> pPatientIndList, long visitID,
                                                   long CreatedBy, long orgID, decimal pAmountReceived, decimal pRefundAmount, string sReasonForRefund, int payamenttype, string bankname, long checkno,
                                                   decimal pDiscountAmount, decimal pDue, decimal pGrossBillValue, string isCreditBill,
                                                   decimal pnetValue, decimal pAdvanceReceived, DataTable dtAmtReceivedDetails, decimal pAmtReceived,
                                                   long pReceivedBy, string dischargeStatus, DateTime dischargeDate,
                                                    List<TaxBillDetails> lstTaxDetails, string discountReason,
                                                    decimal dserviceCharge, string pVisitState,
                                                    decimal pNonMedicalAmtPaid, decimal pCoPayment, decimal pExcess,
                                                    out string ReceiptNo, out long sStartID, out long sEndID,
                                                    out long IPInterID, out string sType, decimal dRoundOff, string BillDate, int RoomTypeID, List<VisitClientMapping> lstVisitClientMapping)
        {
            long ireturnStatus = -1;

            ReceiptNo = "";
            sStartID = 0;
            sEndID = 0;
            IPInterID = 0;
            sType = "";
            try
            {


                ireturnStatus = new PatientVisit_DAL(globalContextDetails).UpdateIPFinalBill(pPatientIndList, visitID,
                                                       CreatedBy, orgID, pAmountReceived, pRefundAmount, sReasonForRefund, payamenttype, bankname, checkno,
                                                       pDiscountAmount, pDue, pGrossBillValue, isCreditBill,
                                                       pnetValue, pAdvanceReceived, dtAmtReceivedDetails, pAmtReceived,
                                                       pReceivedBy, dischargeStatus, dischargeDate, lstTaxDetails,
                                                       discountReason, dserviceCharge, pVisitState,
                                                       pNonMedicalAmtPaid, pCoPayment, pExcess,
                                                       out ReceiptNo, out sStartID, out sEndID,
                                                       out IPInterID, out sType, dRoundOff, BillDate, RoomTypeID, lstVisitClientMapping);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateIPFinalBill in PatientVisit_BL", ex);
            }

            return ireturnStatus;
        }
        public long EditIPFinalBillAfterDischarge(List<PatientDueChart> pPatientIndList, long visitID,
                                                 long CreatedBy, long orgID, decimal pAmountReceived, decimal pRefundAmount, string sReasonForRefund, int payamenttype, string bankname, long checkno,
                                                 decimal pDiscountAmount, decimal pDue, decimal pGrossBillValue, string isCreditBill,
                                                 decimal pnetValue, decimal pAdvanceReceived, DataTable dtAmtReceivedDetails, decimal pAmtReceived,
                                                 long pReceivedBy, string dischargeStatus, DateTime dischargeDate,
                                                  List<TaxBillDetails> lstTaxDetails, string discountReason,
                                                  decimal dserviceCharge, string pVisitState,
                                                  decimal pNonMedicalAmtPaid, decimal pExcess,
                                                  out string ReceiptNo, out long sStartID, out long sEndID,
                                                  out long IPInterID, out string sType, decimal dRoundOff)
        {
            long ireturnStatus = -1;

            ReceiptNo = "";
            sStartID = 0;
            sEndID = 0;
            IPInterID = 0;
            sType = "";
            try
            {


                ireturnStatus = new PatientVisit_DAL(globalContextDetails).EditIPFinalBillAfterDischarge(pPatientIndList, visitID,
                                                       CreatedBy, orgID, pAmountReceived, pRefundAmount, sReasonForRefund, payamenttype, bankname, checkno,
                                                       pDiscountAmount, pDue, pGrossBillValue, isCreditBill,
                                                       pnetValue, pAdvanceReceived, dtAmtReceivedDetails, pAmtReceived,
                                                       pReceivedBy, dischargeStatus, dischargeDate, lstTaxDetails,
                                                       discountReason, dserviceCharge, pVisitState,
                                                       pNonMedicalAmtPaid, pExcess,
                                                       out ReceiptNo, out sStartID, out sEndID,
                                                       out IPInterID, out sType, dRoundOff);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing EditIPFinalBillAfterDischarge in PatientVisit_BL", ex);
            }

            return ireturnStatus;
        }

        public long pGetVisitSearchDetailbyPNo(string patientNo, string pName, string phoneNo, string fromDate, string toDate, int currentOrgID,
            List<TrustedOrgDetails> lstTOD, string pSearchType, out List<PatientVisit> lstPatientVisit, string labno, long Locationid,
            long ClientID, int VisitType, string WardNo, string status, int priority, int Deptid, int ReferringPhyID, long ReferringorgID,

            TrustedOrgActions objTrustedOrgActions, string VisitNo, long TestID, string TestType, long ZoneID, long CourierBoyId, List<PatientDisPatchDetails> lstDispatchDetails, int startRowIndex, int pageSize, out int totalRows, string Prefernce)
        {
            long returnCode = -1;
            totalRows = -1;
            lstPatientVisit = new List<PatientVisit>();
            // DataTable dtOrgIDs = GetOrgIDs(lstTOD);
            //DataTable DtLDetail = GetLoginDetailDataTable(objTrustedOrgActions);
            try
            {

                returnCode = new PatientVisit_DAL(globalContextDetails).pGetVisitSearchDetailbyPNo(patientNo, pName, phoneNo, fromDate, toDate, currentOrgID, lstTOD, pSearchType, out lstPatientVisit, labno, Locationid, ClientID, VisitType, WardNo, status, priority, Deptid, ReferringPhyID, ReferringorgID, objTrustedOrgActions, VisitNo, TestID, TestType, ZoneID, CourierBoyId, lstDispatchDetails, startRowIndex, pageSize, out totalRows, Prefernce);
                /*-----------------Handle VIP Data Start-------------------------*/
                List<PatientVisit> lsttempDetails = new List<PatientVisit>();
                lsttempDetails = lstPatientVisit.FindAll(p => p.PatientStatus == "VIP");
                lstPatientVisit.RemoveAll(p => p.PatientStatus == "VIP");
                for (int i = 0; i < lsttempDetails.Count; i++)
                {
                    /*----Decrypting----------*/
                    Utilities objUtilities = new Utilities();
                    object inputobj = new object();
                    object Decryptedobj = new object();
                    inputobj = lsttempDetails[i];
                    returnCode = objUtilities.GetDecryptedobj(inputobj, out Decryptedobj);
                    lsttempDetails[i] = (PatientVisit)Decryptedobj;
                    /*----------------------*/
                    /*-----Masking----------*/
                    object inputobj1 = new object();
                    object Maskedobj = new object();
                    inputobj1 = lsttempDetails[i];
                    returnCode = objUtilities.GetMaskedobj(inputobj1, out Maskedobj);
                    lsttempDetails[i] = (PatientVisit)Maskedobj;
                    lstPatientVisit.Add(lsttempDetails[i]);
                    /*----------------------*/
                }
                /*-----------------Handle VIP Data End------------------------------*/
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetVisitSearchDetailbyPNo in PatientVisit_BL", ex);
            }
            return returnCode;
        }


        public long UpdatePatientDueChart(List<PatientDueChart> lstBillingDetails)
        {
            long ireturnStatus = -1;

            ireturnStatus = new PatientVisit_DAL(globalContextDetails).UpdatePatientDueChart(lstBillingDetails);
            return ireturnStatus;
        }

        public long GetSecuredPPage(long pVisitID, long pPID, out List<Patient> lstPatient, out List<Speciality> lstSpeciality, out List<AllPhysicianSchedules> lstPhysicianSchedule)
        {
            long returnCode = -1;

            lstPatient = new List<Patient>();
            lstSpeciality = new List<Speciality>();
            lstPhysicianSchedule = new List<AllPhysicianSchedules>();
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetSecuredPPage(pVisitID, pPID, out lstPatient, out lstSpeciality, out lstPhysicianSchedule);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetSecuredPPage in PatientVisit_BL", ex);
            }

            return returnCode;
        }
        public long pGetAmountReceivedDetailsForIPBILL(long VisitID, out List<AmountReceivedDetails> lstAmtReceived)
        {
            long returnCode = -1;
            lstAmtReceived = new List<AmountReceivedDetails>();
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).pGetAmountReceivedDetailsForIPBILL(VisitID, out lstAmtReceived);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing pGetAmountReceivedDetailsForIPBILL in PatientVisit_BL", ex);
            }

            return returnCode;
        }
        public long GetCorporateClientByVisit(long PatientVisitID, out List<PatientVisit> lstPatientVisit)
        {
            long returnCode = -1;
            lstPatientVisit = new List<PatientVisit>();
            PatientVisit_DAL patientVisitDAL = new PatientVisit_DAL(globalContextDetails);
            try
            {
                returnCode = patientVisitDAL.GetCorporateClientByVisit(PatientVisitID, out lstPatientVisit);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetCorporateClientByVisit in PatientVisit_BL", ex);
            }
            return returnCode;
        }
        public long InsertOutPatientItems(List<PatientDueChart> lstSurgergicalPkg,
            List<OrderedInvestigations> pPatientInvTable,
            List<PatientDueChart> pPatientConsultation,
            List<PatientDueChart> pPatientProcedure,
            List<PatientDueChart> pPatientIndents,
            List<DHEBAdder> pDHEBPatientIndents,
            long visitID, long CreatedBy, long patientID, long lFInalBillID, out long loutBillID, long lOrgID)
        {
            long returnCode = -1;
            //DataTable dtPatientItems = null;
            //loutBillID = 0;
            //dtPatientItems = GetDataTable(lstSurgergicalPkg, pPatientInvTable, pPatientConsultation,
            //                                        pPatientProcedure, pPatientIndents, pDHEBPatientIndents);
            PatientVisit_DAL objPatientIndents = new PatientVisit_DAL(globalContextDetails);
            objPatientIndents.InsertOutPatientItems(pPatientConsultation, visitID, CreatedBy, patientID, lFInalBillID, out loutBillID, lOrgID);
            // dtPatientItems = null;
            return returnCode;
        }

        public long GetPatientWaitTime(DateTime pFromTime, DateTime pToDate, long lOrgID, out List<PatientWaitTime> lstWaitTime)
        {
            long returnCode = -1;
            PatientVisit_DAL patDAL = new PatientVisit_DAL(globalContextDetails);
            lstWaitTime = new List<PatientWaitTime>();
            returnCode = patDAL.GetPatientWaitTime(pFromTime, pToDate, lOrgID, out lstWaitTime);
            return returnCode;
        }

        public long GetPatientLatestVisit(long pPatientID, out List<PatientVisit> lstPatientVisit, out List<OrderedInvestigations> lstOrdered)
        {
            long returnCode = -1;
            PatientVisit_DAL patDAL = new PatientVisit_DAL(globalContextDetails);
            lstPatientVisit = new List<PatientVisit>();
            lstOrdered = new List<OrderedInvestigations>();
            returnCode = patDAL.GetPatientLatestVisit(pPatientID, out lstPatientVisit, out lstOrdered);
            return returnCode;
        }
        public long GetRecommendationDetails(int orgID, out List<PatientVisit> lstPatientVisit)
        {
            long returnCode = -1;
            PatientVisit_DAL patDAL = new PatientVisit_DAL(globalContextDetails);
            lstPatientVisit = new List<PatientVisit>();
            returnCode = patDAL.GetRecommendationDetails(orgID, out lstPatientVisit);
            return returnCode;
        }
        public long GetProcedureDetailsForVisit(long patientVisitID, int OrgID, out List<PatientTreatmentProcedure> lPatProcedure)
        {
            long returncode = -1;
            lPatProcedure = new List<PatientTreatmentProcedure>();

            try
            {
                new PatientVisit_DAL(globalContextDetails).GetProcedureDetailsForVisit(patientVisitID, OrgID, out lPatProcedure);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetProcedureDetailsForVisit in PatientVisit_BL", ex);
            }
            return returncode;
        }
        public long GetGeneralBillItems(int orgID, long visitID, out List<GeneralBillingItems> lstGBI)
        {
            long returnCode = -1;
            lstGBI = new List<GeneralBillingItems>();
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetGeneralBillItems(orgID, visitID, out lstGBI);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetGeneralBillItems in PatientVisit_BL", ex);
            }

            return returnCode;

        }
        public long GetCorpoRateGeneralBillItems(int orgID, long visitID, out List<GeneralBillingItems> lstGBI)
        {
            long returnCode = -1;
            lstGBI = new List<GeneralBillingItems>();
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetCorpoRateGeneralBillItems(orgID, visitID, out lstGBI);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetGeneralBillItems BL", ex);
            }

            return returnCode;

        }
        public long UpdateoutsourceGrid(List<OutsourcingDetail> lstOutSourcingDetails, long CreatedBy, long visitID, DateTime receivedDate, int OrgID, string Status)
        {

            long returnCode = -1;
           
            try
            {

                returnCode = new PatientVisit_DAL(globalContextDetails).UpdateoutsourceGrid(lstOutSourcingDetails, CreatedBy, visitID, receivedDate, OrgID, Status);

            }

            catch (Exception ex)
            {

                CLogger.LogError("Error while loading GetVisitSearchDetailByPatient BL", ex);

            }

            return returnCode;

        }



        public long OutsourceGrid(long Patientvisitid,out List<OutsourcingDetail> lstOutsourcingDetail)
        {

            long returnCode = -1;
            lstOutsourcingDetail = new List<OutsourcingDetail>();
            try
            {

                returnCode = new PatientVisit_DAL(globalContextDetails).OutsourceGrid(Patientvisitid,out lstOutsourcingDetail);

            }

            catch (Exception ex)
            {

                CLogger.LogError("Error while loading GetVisitSearchDetailByPatient BL", ex);

            }

            return returnCode;

        }


        public long GetVisitSearchDetailByPatient(string patientNo, string pName, string pVisitType, string fromDate, string toDate, int currentOrgID, List<TrustedOrgDetails> lstTOD, string pSearchType, int PageSize, int startRowIndex, out int totalRows, out List<PatientVisit> lstPatientVisit, string DeptCode, long SpecialityID, long RefPhyId, long ZoneId, out List<PatientVisit> lsttotalPatientCount, string VisitNO, long orgaddressID, long ClientID, long LoginID, int IsTRFVerified)
        {

            long returnCode = -1;
            totalRows = 0;
            lstPatientVisit = new List<PatientVisit>();

            lsttotalPatientCount = new List<PatientVisit>();



            //DataTable dtOrgIDs = GetOrgIDs(lstTOD);

            try
            {

                returnCode = new PatientVisit_DAL(globalContextDetails).GetVisitSearchDetailByPatient(patientNo, pName, pVisitType, fromDate, toDate, currentOrgID, lstTOD, pSearchType, PageSize, startRowIndex, out totalRows, out lstPatientVisit, DeptCode, SpecialityID, RefPhyId, ZoneId, out lsttotalPatientCount, VisitNO, orgaddressID, ClientID, LoginID, IsTRFVerified);

            }

            catch (Exception ex)
            {

			CLogger.LogError("Error while executing GetVisitSearchDetailByPatient in PatientVisit_BL", ex);

            }

            return returnCode;

        }

        public long GetAllVisitSearchDetailByPatient(string patientNo, string pName, string pVisitType, string fromDate, string toDate, int currentOrgID, List<TrustedOrgDetails> lstTOD, string pSearchType, int PageSize, int startRowIndex, out int totalRows, out List<PatientVisit> lstPatientVisit, string DeptCode, long SpecialityID, long RefPhyId, long ZoneId, out List<PatientVisit> lsttotalPatientCount, string VisitNO, long orgaddressID, long ClientID, long LoginID)
        {

            long returnCode = -1;
            totalRows = 0;
            lstPatientVisit = new List<PatientVisit>();

            lsttotalPatientCount = new List<PatientVisit>();



            //DataTable dtOrgIDs = GetOrgIDs(lstTOD);

            try
            {

                returnCode = new PatientVisit_DAL(globalContextDetails).GetAllVisitSearchDetailByPatient(patientNo, pName, pVisitType, fromDate, toDate, currentOrgID, lstTOD, pSearchType, PageSize, startRowIndex, out totalRows, out lstPatientVisit, DeptCode, SpecialityID, RefPhyId, ZoneId, out lsttotalPatientCount, VisitNO, orgaddressID, ClientID, LoginID);

            }

            catch (Exception ex)
            {

                CLogger.LogError("Error while executing GetAllVisitSearchDetailByPatient in PatientVisit_BL", ex);

            }

            return returnCode;

        }



        public long GetVisitIDByBillID(long BillID, int OrgID, string Year, out long VisitID)
        {
            long returnCode = -1;
            VisitID = -1;
            try
            {
                PatientVisit_DAL patientVisitDAL = new PatientVisit_DAL(globalContextDetails);
                returnCode = patientVisitDAL.GetVisitIDByBillID(BillID, OrgID, Year, out VisitID);
            }
            catch (Exception excep)
            {
			CLogger.LogError("Error while executing GetVisitIDByBillID in PatientVisit_BL", excep);
            }
            return returnCode;
        }
        public long GetPatientVisitSummary(long pID, out int pOPCount, out int pIPCount, out string pPreVisitDate, out string pPreVisitType, out string pPatientNo)
        {
            long returnCode = -1;
            pOPCount = -1;
            pIPCount = -1;
            pPreVisitDate = string.Empty;
            pPreVisitType = string.Empty;
            pPatientNo = string.Empty;

            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetPatientVisitSummary(pID, out pOPCount, out pIPCount, out pPreVisitDate, out pPreVisitType, out pPatientNo);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPatientVisitSummary in PatientVisit_BL", ex);
            }

            return returnCode;
        }
        public long GetPatientVisitForRefPhy(long patientID, int pVisitID, int pOrgID, int pVisitType, out List<PatientVisit> lstPatientVisit, out List<OrderedInvestigations> lOrderedInv, out string pPatientName, out string pPatientNo, long LoginID)
        {
            long returnCode = -1;
            lstPatientVisit = new List<PatientVisit>();
            lOrderedInv = new List<OrderedInvestigations>();
            pPatientName = string.Empty;
            pPatientNo = string.Empty;
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetPatientVisitForRefPhy(patientID, pVisitID, pOrgID, pVisitType, out lstPatientVisit, out lOrderedInv, out pPatientName, out pPatientNo, LoginID);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPatientVisit in PatientVisit_BL", ex);
            }
            return returnCode;
        }
        public long GetRefPhyDetails(long RefPhysicianID, int orgID, out List<ReferingPhysician> lstRefPhys)
        {
            long returnCode = -1;
            lstRefPhys = new List<ReferingPhysician>();
            returnCode = new PatientVisit_DAL(globalContextDetails).GetRefPhyDetails(RefPhysicianID, orgID, out lstRefPhys);
            return returnCode;
        }
        public long SaveDynamicColumnMapping(List<DynamicColumnMapping> lstDynamicColumn)
        {
            long returnCode = -1;
            //DataTable dtDynamicColumnData = GetDynamicColumnDataTable(lstDynamicColumn);

            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).SaveDynamicColumnMapping(lstDynamicColumn);
            }
            catch (Exception excp)
            {
			CLogger.LogError("Error while executing SaveDynamicColumnMapping in PatientVisit_BL", excp);
            }
            return returnCode;
        }


        public long GetInPatientMakeBillEntryDetails(long patientID, out List<PatientVisit> lstPatientVisit, long visitID, out decimal pPreAuthAmount, out string pIsCreditBill,
                                                     out List<PatientDueChart> lstPatientDueChart, long orgID, string selType, out decimal ptotalAdvance,
                                                     out List<AdvancePaidDetails> lstAdvancePaidDetails, out List<SurgeryPackageItems> lstSurgeryPackageItems, out List<SurgeryPackageItems> lstSelectedSurgeryPKG,
                                                     long roleID, long ParentID, out List<IpPayments> lstIpPayments,
                                                     out List<OrderedInvestigations> lstInv, out List<OrderedInvestigations> lstGrp,
                                                     int clientID, string type, out List<PatientInvestigation> lstPatGRP, out List<PatientInvestigation> lstPatInv)
        {
            long returnCode = -1;
            pPreAuthAmount = -1;
            pIsCreditBill = "";
            ptotalAdvance = 0;
            lstPatientVisit = new List<PatientVisit>();
            //lstPatientVisitIP = new List<PatientVisit>();
            lstPatientDueChart = new List<PatientDueChart>();
            lstAdvancePaidDetails = new List<AdvancePaidDetails>();
            lstIpPayments = new List<IpPayments>();
            lstPatInv = new List<PatientInvestigation>();
            lstPatGRP = new List<PatientInvestigation>();
            lstInv = new List<OrderedInvestigations>();
            lstGrp = new List<OrderedInvestigations>();
            lstIpPayments = new List<IpPayments>();
            lstSurgeryPackageItems = new List<SurgeryPackageItems>();
            lstSelectedSurgeryPKG = new List<SurgeryPackageItems>();


            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetInPatientMakeBillEntryDetails(patientID, out lstPatientVisit, visitID, out pPreAuthAmount, out pIsCreditBill, out lstPatientDueChart, orgID, selType, out ptotalAdvance, out lstAdvancePaidDetails, out lstSurgeryPackageItems, out lstSelectedSurgeryPKG, roleID, ParentID, out lstIpPayments, out lstInv, out lstGrp, clientID, type, out lstPatGRP, out lstPatInv);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetInPatientMakeBillEntryDetails in PatientVisit_BL", ex);
            }

            return returnCode;
        }

        public long GetInternalExternalPhysician(long pOrgID,
                                      out List<Physician> lstPhysician,
                                      out List<ReferingPhysician> lstReferingPhysician)
        {
            long returnCode = -1;
            lstPhysician = new List<Physician>();
            lstReferingPhysician = new List<ReferingPhysician>();

            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetInternalExternalPhysician(pOrgID,
                                        out   lstPhysician,
                                        out   lstReferingPhysician);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetInternalExternalPhysician in PatientVisit_BL", ex);
            }

            return returnCode;

        }
        public long GetInterimDueChart(out List<PatientDueChart> lstPatientDueChart, out List<Patient> lstPatient, long orgID, long pPatientID, long pVisitID, string interimBillno, string IsSurgeryBill)
        {
            long returnCode = -1;

            lstPatientDueChart = new List<PatientDueChart>();
            lstPatient = new List<Patient>();
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetInterimDueChart(out lstPatientDueChart, out lstPatient, orgID, pPatientID, pVisitID, interimBillno, IsSurgeryBill);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetInterimDueChart in PatientVisit_BL", ex);
            }

            return returnCode;
        }

        public long UpdateIPBill(long visitID, long patientID, int OrgID, List<InventoryItemsBasket> lstInventoryItemsBasket, out int returnstatus)
        {
            long returnCode = -1;
            returnstatus = 0;

            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).UpdateIPBill(visitID, patientID, OrgID, lstInventoryItemsBasket, out returnstatus);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing UpdateIPBill in PatientVisit_BL", ex);
            }

            return returnCode;
        }

        public long GetIPBillSettlement_Merge(long pVisitID, long patientID, long orgID, out decimal ptotalReceived,
                                        out decimal ptotalAdvance, out decimal pTotalDue,
                                        out decimal pPreviousRefund, out List<PatientDueChart> lstIpPayments,
                                        out List<PatientDueChart> lstBedBooking, out decimal pTotSurgeryAdv,
                                        out decimal pTotSurgeryAmt, out List<Patient> lstPatientDetail,
                                        out List<Organization> lstOrganization,
                                        out List<Physician> physicianName,
                                        out List<Taxmaster> lstTaxes,
                                        out List<FinalBill> lstFinalBill,
                                        out decimal dPayerTotal,
                                        out decimal pNonMedicalAmtPaid,
                                        out decimal pCoPayment,
                                        out decimal pExcess, out string AdmissionDate, out string MaxBillDate, int RoomTypeID)
        {
            long returnCode = -1;
            lstIpPayments = new List<PatientDueChart>();
            lstBedBooking = new List<PatientDueChart>();

            lstPatientDetail = new List<Patient>();
            lstOrganization = new List<Organization>();
            physicianName = new List<Physician>();
            lstTaxes = new List<Taxmaster>();
            lstFinalBill = new List<FinalBill>();

            ptotalReceived = 0;
            ptotalAdvance = 0;
            pTotalDue = 0;
            pPreviousRefund = 0;
            pTotSurgeryAdv = 0;
            pTotSurgeryAmt = 0;
            dPayerTotal = 0;

            pNonMedicalAmtPaid = decimal.Zero;
            pCoPayment = decimal.Zero;
            pExcess = decimal.Zero;
            AdmissionDate = "01/01/1753";
            MaxBillDate = "01/01/1753";

            try
            {

                returnCode = new PatientVisit_DAL(globalContextDetails).GetIPBillSettlement_Merge(pVisitID, patientID, orgID,
                                                        out ptotalReceived, out ptotalAdvance, out pTotalDue,
                                                        out pPreviousRefund, out lstIpPayments, out lstBedBooking,
                                                        out pTotSurgeryAdv, out pTotSurgeryAmt,
                                                        out lstPatientDetail,
                                                        out lstOrganization,
                                                        out physicianName,
                                                        out lstTaxes,
                                                        out lstFinalBill,
                                                        out dPayerTotal,
                                                        out pNonMedicalAmtPaid,
                                                        out pCoPayment,
                                                        out pExcess, out  AdmissionDate, out MaxBillDate, RoomTypeID);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetInPatientVisitCount in PatientVisit_BL", ex);
            }
            return returnCode;
        }

        public long GetEligibleRoomAmount(long visitID, long patientID, int OrgID, out decimal pEligibleRoomAmount)
        {
            long returnCode = -1;
            pEligibleRoomAmount = 0;

            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetEligibleRoomAmount(visitID, patientID, OrgID, out pEligibleRoomAmount);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetEligibleRoomAmount in PatientVisit_BL", ex);
            }

            return returnCode;
        }


        public long GetLocation(long orgID, long pLID, long pRID, out List<OrganizationAddress> lstLocation)
        {
            lstLocation = new List<OrganizationAddress>();
            long returnCode = -1;
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetLocation(orgID, pLID, pRID, out lstLocation);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetLocation in PatientVisit_BL", ex);
            }
            return returnCode;
        }
        public long SaveRoleDeptLocationMap(int OrgID, List<Role> lstRoleLocation, long pLoginID)
        {
            long returnCode = -1;
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).SaveRoleDeptLocationMap(OrgID, lstRoleLocation, pLoginID);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveRoleDeptLocationMap in PatientVisit_BL", ex);
            }

            return returnCode;
        }
        public long GetDepartment(long orgID, long pLID, long pRID, out List<InvDeptMaster> lstInvDeptMaster, out List<InvDeptMaster> lstDeptMaster)
        {
            lstInvDeptMaster = new List<InvDeptMaster>();
            lstDeptMaster = new List<InvDeptMaster>();
            long returnCode = -1;
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetDepartment(orgID, pLID, pRID, out lstInvDeptMaster, out lstDeptMaster);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetDepartment in PatientVisit_BL", ex);
            }
            return returnCode;
        }
        public long GetDispatchStatusReports(string fdate, string todate, string sstatus, List<TrustedOrgDetails> lstTOD, int orgid,
             TrustedOrgActions objTrustedOrgActions, out List<PatientVisit> lstPatientVisit, List<PatientDisPatchDetails> lstDispatchDetails, int startRowIndex, int pageSize, out int totalRows)
        {
            long returnCode = -1;
            totalRows = -1;
            lstPatientVisit = new List<PatientVisit>();

            //DataTable dtOrgIDs = GetOrgIDs(lstTOD);
            // DataTable DtLDetail = GetLoginDetailDataTable(objTrustedOrgActions);
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetDispatchStatusReports(fdate, todate, sstatus, lstTOD, orgid, objTrustedOrgActions, out lstPatientVisit, lstDispatchDetails, startRowIndex, pageSize, out totalRows);
                /*-----------------Handle VIP Data Start-------------------------*/
                List<PatientVisit> lsttempDetails = new List<PatientVisit>();
                lsttempDetails = lstPatientVisit.FindAll(p => p.PatientStatus == "VIP");
                lstPatientVisit.RemoveAll(p => p.PatientStatus == "VIP");
                for (int i = 0; i < lsttempDetails.Count; i++)
                {
                    /*----Decrypting----------*/
                    Utilities objUtilities = new Utilities();
                    object inputobj = new object();
                    object Decryptedobj = new object();
                    inputobj = lsttempDetails[i];
                    returnCode = objUtilities.GetDecryptedobj(inputobj, out Decryptedobj);
                    lsttempDetails[i] = (PatientVisit)Decryptedobj;
                    /*----------------------*/
                    /*-----Masking----------*/
                    object inputobj1 = new object();
                    object Maskedobj = new object();
                    inputobj1 = lsttempDetails[i];
                    returnCode = objUtilities.GetMaskedobj(inputobj1, out Maskedobj);
                    lsttempDetails[i] = (PatientVisit)Maskedobj;
                    lstPatientVisit.Add(lsttempDetails[i]);
                    /*----------------------*/
                }
                /*-----------------Handle VIP Data End------------------------------*/
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDispatchStatusReports in PatientVisit_BL", ex);
            }
            return returnCode;
        }
        public long GetVisitClientMappingDetails(int OrgID, long visitId, out List<VisitClientMapping> lstVisitClient)
        {
            lstVisitClient = new List<VisitClientMapping>();

            long returnCode = -1;
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetVisitClientMappingDetails(OrgID, visitId, out lstVisitClient);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetVisitClientMappingDetails in PatientVisit_BL", ex);
            }
            return returnCode;
        }
        public long GetEMPLevel(int OrgID, out List<EmergencySeverityOrgMapping> lstGetLevels)
        {
            lstGetLevels = new List<EmergencySeverityOrgMapping>();

            long returnCode = -1;
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetEMPLevel(OrgID, out lstGetLevels);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetEMPLevel in PatientVisit_BL", ex);
            }
            return returnCode;
        }
        public long GetEMPGridList(int OrgID, out List<PatientVisitDetails> lstGetLevels)
        {
            lstGetLevels = new List<PatientVisitDetails>();

            long returnCode = -1;
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetEMPGridList(OrgID, out lstGetLevels);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetEMPGridList in PatientVisit_BL", ex);
            }
            return returnCode;
        }
        public long PSaveEmerencyPatientHistory(long EmergencyPatientTrackerId, long EmergencySeverityOrgMappingID, int pOrgID)
        {


            long returnCode = -1;
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).PSaveEmerencyPatientHistory(EmergencyPatientTrackerId, EmergencySeverityOrgMappingID, pOrgID);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing PSaveEmerencyPatientHistory in PatientVisit_BL", ex);
            }
            return returnCode;
        }

        public long GetPatientVisitHeaderHealthScreen(long VisitID, long PatientID, int OrgID, out List<Patient> lstPatientDetail)
        {
            lstPatientDetail = new List<Patient>();
            long returnCode = -1;
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetPatientVisitHeaderHealthScreen(VisitID, PatientID, OrgID, out lstPatientDetail);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPatientVisitHeaderHealthScreen in PatientVisit_BL", ex);
            }
            return returnCode;


        }
        public long GetDoctors(int orgID, out List<InvOrgAuthorization> lstPhysician)
        {
            long returnCode = -1;
            lstPhysician = new List<InvOrgAuthorization>();
            try
            {
                returnCode = new PatientVisit_DAL(globalContextDetails).GetDoctors(orgID, out lstPhysician);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetDoctorsReferred in PatientVisit_BL", ex);
            }
            return returnCode;
        }

        public long pGetDispatchReportInv(string fromDate, string toDate, int currentOrgID,
           List<TrustedOrgDetails> lstTOD, string pSearchType, out List<PatientVisit> lstPatientVisit, long Locationid,
           long ClientID, int VisitType, string status, int Deptid, int ReferringPhyID, long ReferringorgID,

           TrustedOrgActions objTrustedOrgActions, string VisitNo, long TestID, string TestType, long ZoneID, long CourierBoyId, List<PatientDisPatchDetails> lstDispatchDetails, int startRowIndex, int pageSize, out int totalRows, string Prefernce)
        {
            long returnCode = -1;
            totalRows = -1;
            lstPatientVisit = new List<PatientVisit>();
            // DataTable dtOrgIDs = GetOrgIDs(lstTOD);
            //DataTable DtLDetail = GetLoginDetailDataTable(objTrustedOrgActions);
            try
            {

                returnCode = new PatientVisit_DAL(globalContextDetails).pGetDispatchReportInv(fromDate, toDate, currentOrgID, lstTOD, pSearchType, out lstPatientVisit, Locationid, ClientID, VisitType, status, Deptid, ReferringPhyID, ReferringorgID, objTrustedOrgActions, VisitNo, TestID, TestType, ZoneID, CourierBoyId, lstDispatchDetails, startRowIndex, pageSize, out totalRows, Prefernce);
                /*-----------------Handle VIP Data Start-------------------------*/
                List<PatientVisit> lsttempDetails = new List<PatientVisit>();
                lsttempDetails = lstPatientVisit.FindAll(p => p.PatientStatus == "VIP");
                lstPatientVisit.RemoveAll(p => p.PatientStatus == "VIP");
                for (int i = 0; i < lsttempDetails.Count; i++)
                {
                    /*----Decrypting----------*/
                    Utilities objUtilities = new Utilities();
                    object inputobj = new object();
                    object Decryptedobj = new object();
                    inputobj = lsttempDetails[i];
                    returnCode = objUtilities.GetDecryptedobj(inputobj, out Decryptedobj);
                    lsttempDetails[i] = (PatientVisit)Decryptedobj;
                    /*----------------------*/
                    /*-----Masking----------*/
                    object inputobj1 = new object();
                    object Maskedobj = new object();
                    inputobj1 = lsttempDetails[i];
                    returnCode = objUtilities.GetMaskedobj(inputobj1, out Maskedobj);
                    lsttempDetails[i] = (PatientVisit)Maskedobj;
                    lstPatientVisit.Add(lsttempDetails[i]);
                    /*----------------------*/
                }
                /*-----------------Handle VIP Data End------------------------------*/
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetDispatchReportInv in PatientVisit_BL", ex);
            }
            return returnCode;
        }
        public long pGetVisitSearchDetailbyPNoPrint(string patientNo, string pName, string phoneNo, string fromDate, string toDate, int currentOrgID,
            List<TrustedOrgDetails> lstTOD, string pSearchType, out List<PatientVisit> lstPatientVisit, string labno, String Locationid,
            long ClientID, int VisitType, string WardNo, string status, int priority, int Deptid, int ReferringPhyID, long ReferringorgID,

            TrustedOrgActions objTrustedOrgActions, string VisitNo, long TestID, string TestType, String ZoneID, String HubID,
            long CourierBoyId, List<PatientDisPatchDetails> lstDispatchDetails, int startRowIndex, int pageSize, out int totalRows,
            string Prefernce, string IsPrintAll, long PrintLocationid, string IsColorPrint, string IPOPNumber, string PatientPayType, string PatientStatus,string IsPrint)
        {
            long returnCode = -1;
            totalRows = -1;
            lstPatientVisit = new List<PatientVisit>();
            // DataTable dtOrgIDs = GetOrgIDs(lstTOD);
            //DataTable DtLDetail = GetLoginDetailDataTable(objTrustedOrgActions);
            try
            {

                returnCode = new PatientVisit_DAL(globalContextDetails).pGetVisitSearchDetailbyPNoPrint(patientNo, pName, phoneNo,
               fromDate, toDate, currentOrgID, lstTOD, pSearchType, out lstPatientVisit, labno, Locationid, ClientID, VisitType,
               WardNo, status, priority, Deptid, ReferringPhyID, ReferringorgID, objTrustedOrgActions, VisitNo, TestID, TestType,
               ZoneID, HubID, CourierBoyId, lstDispatchDetails, startRowIndex, pageSize, out totalRows, Prefernce, IsPrintAll, PrintLocationid, IsColorPrint,
               IPOPNumber, PatientPayType, PatientStatus, IsPrint);
                /*-----------------Handle VIP Data Start-------------------------*/
                List<PatientVisit> lsttempDetails = new List<PatientVisit>();
                lsttempDetails = lstPatientVisit.FindAll(p => p.PatientStatus == "VIP");
                lstPatientVisit.RemoveAll(p => p.PatientStatus == "VIP");
                for (int i = 0; i < lsttempDetails.Count; i++)
                {
                    /*----Decrypting----------*/
                    Utilities objUtilities = new Utilities();
                    object inputobj = new object();
                    object Decryptedobj = new object();
                    inputobj = lsttempDetails[i];
                    returnCode = objUtilities.GetDecryptedobj(inputobj, out Decryptedobj);
                    lsttempDetails[i] = (PatientVisit)Decryptedobj;
                    /*----------------------*/
                    /*-----Masking----------*/
                    object inputobj1 = new object();
                    object Maskedobj = new object();
                    inputobj1 = lsttempDetails[i];
                    returnCode = objUtilities.GetMaskedobj(inputobj1, out Maskedobj);
                    lsttempDetails[i] = (PatientVisit)Maskedobj;
                    lstPatientVisit.Add(lsttempDetails[i]);
                    /*----------------------*/
                }
                /*-----------------Handle VIP Data End------------------------------*/
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetVisitSearchDetailbyPNoPrint in PatientVisit_BL", ex);
            }
            return returnCode;
        }
        public long pGetVisitSearchDetailbyPNoRePrint(string patientNo, string pName, string phoneNo, string fromDate, string toDate, int currentOrgID,
           List<TrustedOrgDetails> lstTOD, string pSearchType, out List<PatientVisit> lstPatientVisit, string labno, String Locationid,
           long ClientID, int VisitType, string WardNo, string status, int priority, int Deptid, int ReferringPhyID, long ReferringorgID,

           TrustedOrgActions objTrustedOrgActions, string VisitNo, long TestID, string TestType, String ZoneID, String HubID,
           long CourierBoyId, List<PatientDisPatchDetails> lstDispatchDetails, int startRowIndex, int pageSize, out int totalRows,
           string Prefernce, string IsPrintAll, long PrintLocationid, string IsColorPrint, string IPOPNumber, string PatientPayType, string PatientStatus, string IsPrint,string ReportType)
        {
            long returnCode = -1;
            totalRows = -1;
            lstPatientVisit = new List<PatientVisit>();
            // DataTable dtOrgIDs = GetOrgIDs(lstTOD);
            //DataTable DtLDetail = GetLoginDetailDataTable(objTrustedOrgActions);
            try
            {

                returnCode = new PatientVisit_DAL(globalContextDetails).pGetVisitSearchDetailbyPNoRePrint(patientNo, pName, phoneNo,
               fromDate, toDate, currentOrgID, lstTOD, pSearchType, out lstPatientVisit, labno, Locationid, ClientID, VisitType,
               WardNo, status, priority, Deptid, ReferringPhyID, ReferringorgID, objTrustedOrgActions, VisitNo, TestID, TestType,
               ZoneID, HubID, CourierBoyId, lstDispatchDetails, startRowIndex, pageSize, out totalRows, Prefernce, IsPrintAll, PrintLocationid, IsColorPrint,
               IPOPNumber, PatientPayType, PatientStatus, IsPrint,ReportType);
                /*-----------------Handle VIP Data Start-------------------------*/
                List<PatientVisit> lsttempDetails = new List<PatientVisit>();
                lsttempDetails = lstPatientVisit.FindAll(p => p.PatientStatus == "VIP");
                lstPatientVisit.RemoveAll(p => p.PatientStatus == "VIP");
                for (int i = 0; i < lsttempDetails.Count; i++)
                {
                    /*----Decrypting----------*/
                    Utilities objUtilities = new Utilities();
                    object inputobj = new object();
                    object Decryptedobj = new object();
                    inputobj = lsttempDetails[i];
                    returnCode = objUtilities.GetDecryptedobj(inputobj, out Decryptedobj);
                    lsttempDetails[i] = (PatientVisit)Decryptedobj;
                    /*----------------------*/
                    /*-----Masking----------*/
                    object inputobj1 = new object();
                    object Maskedobj = new object();
                    inputobj1 = lsttempDetails[i];
                    returnCode = objUtilities.GetMaskedobj(inputobj1, out Maskedobj);
                    lsttempDetails[i] = (PatientVisit)Maskedobj;
                    lstPatientVisit.Add(lsttempDetails[i]);
                    /*----------------------*/
                }
                /*-----------------Handle VIP Data End------------------------------*/
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetVisitSearchDetailbyPNoPrint in PatientVisit_BL", ex);
            }
            return returnCode;
        }
        public long GetLabReportForInvestigation(string VisitNumber, Int64 PatientID, string PatientName, string PatientNumber, string PhoneNo,
      string FromDate, string ToDate, Int64 ClientID,
      Int64 ZoneID, long LocationID, Int64 RefDocID, long refOrgID, string Status,
      Int64 DeptID, Int64 TestID, string TestType, int CurrentOrgID, int visitType, out List<PatientVisit> lstPatientVisit, int startRowIndex, int pageSize, out int totalRows)
        {
            long returnCode = -1;
            totalRows = -1;
            lstPatientVisit = new List<PatientVisit>();
            // DataTable dtOrgIDs = GetOrgIDs(lstTOD);
            //DataTable DtLDetail = GetLoginDetailDataTable(objTrustedOrgActions);
            try
            {

                returnCode = new PatientVisit_DAL(globalContextDetails).GetLabReport(
                        VisitNumber, PatientID, PatientName, PatientNumber, PhoneNo, FromDate, ToDate,
                        ClientID, ZoneID, LocationID, RefDocID, refOrgID, Status, DeptID, TestID, TestType, CurrentOrgID, visitType, out lstPatientVisit,
                          startRowIndex, pageSize, out totalRows

                    );

                /*-----------------Handle VIP Data Start-------------------------*/
                List<PatientVisit> lsttempDetails = new List<PatientVisit>();
                lsttempDetails = lstPatientVisit.FindAll(p => p.PatientStatus == "VIP");
                lstPatientVisit.RemoveAll(p => p.PatientStatus == "VIP");
                for (int i = 0; i < lsttempDetails.Count; i++)
                {
                    /*----Decrypting----------*/
                    Utilities objUtilities = new Utilities();
                    object inputobj = new object();
                    object Decryptedobj = new object();
                    inputobj = lsttempDetails[i];
                    returnCode = objUtilities.GetDecryptedobj(inputobj, out Decryptedobj);
                    lsttempDetails[i] = (PatientVisit)Decryptedobj;
                    /*----------------------*/
                    /*-----Masking----------*/
                    object inputobj1 = new object();
                    object Maskedobj = new object();
                    inputobj1 = lsttempDetails[i];
                    returnCode = objUtilities.GetMaskedobj(inputobj1, out Maskedobj);
                    lsttempDetails[i] = (PatientVisit)Maskedobj;
                    lstPatientVisit.Add(lsttempDetails[i]);
                    /*----------------------*/
                }
                /*-----------------Handle VIP Data End------------------------------*/
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetLabReportForInvestigation in PatientVisit_BL", ex);
            }
            return returnCode;
        }
    }
}
