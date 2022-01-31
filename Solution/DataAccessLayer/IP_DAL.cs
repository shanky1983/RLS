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
    public class IP_DAL
    {
        ContextDetails globalContextDetails;
        public IP_DAL()
        {

        }
        public IP_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetIPComplaint(out List<IPComplaint> lstIPComplaint)
        {
            long returnCode = -1;
            lstIPComplaint = new List<IPComplaint>();
            SqlCommand cmd = Command.pGetIPComplaintCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstIPComplaint);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPComplaint in IP_DAL", ex);
            }
            return returnCode;
        }

        public long InsertPatDisChkList(long pID, long visitID, long createdBy, DateTime disDT, int typeofDischarge, string conOnDis, string destPostDis, List<PatientDisChkLstDtl> lstPatDisChkList, out long retCode)
        {
            long returnCode = -1;
            DataTable dtChkList = UDT_DAL.ConvertToHIDECType(lstPatDisChkList);
            retCode = -1;
            try
            {
                SqlCommand cmd = Command.pInsertPatDisChkListCommand(pID, visitID, createdBy, disDT, typeofDischarge, conOnDis, destPostDis, dtChkList, out retCode,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    retCode = Convert.ToInt64(cmd.Parameters["@pRetCode"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertPatDisChkList", ex);
            }
            return returnCode;
        }

        public long GetIPTreatmentPlanMaster(int OrgID, out List<IPTreatmentPlanMaster> lstIPTreatmentPlanMaster)
        {
            long returnCode = -1;
            lstIPTreatmentPlanMaster = new List<IPTreatmentPlanMaster>();
            SqlCommand cmd = Command.pGetIPTreatmentPlanMasterCommand(OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstIPTreatmentPlanMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPTreatmentPlanMaster in IP_DAL", ex);
            }
            return returnCode;
        }

        public long SaveIPCaseRecord(List<PatientHistory> lstPatientHistory, List<PatientVitals> lstPatientVitals, List<PatientExamination> lstPatientExamination,
            List<PatientComplaint> lstPatientComplaint,
                   List<IPTreatmentPlan> lstIPTreatmentPlan, List<DrugDetails> lstDrugDetails, RTAMLCDetails objRTAMLC, List<BackgroundProblem> lstBackgroundProblem,
                   List<BackgroundProblem> lstOtherBackgroundProblem, ANCPatientDetails objANCPatientDetails, int OrgID, long PatientVisitID, long patientID,
                   long LID, string DetailsHistory, List<PatientAdvice> lstPatientAdvice, string nextReviewDate, DateTime dtActualRewDt)
        {
           
           
            long returnCode = -1;
            SqlCommand cmdPAdvice = new SqlCommand();
            DataTable dtPAdvice = UDT_DAL.ConvertTouddInsertGeneralAdvice(lstPatientAdvice);
            cmdPAdvice = Command.pInsertGeneralAdviceCommand(dtPAdvice,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPAdvice.Parameters.Add("@Return", SqlDbType.Int);
            cmdPAdvice.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            SqlCommand cmdPatientVisit = new SqlCommand();
            string strAdminSuggested = string.Empty;
            cmdPatientVisit = Command.pInsertNextReviewDateCommand(PatientVisitID, nextReviewDate, strAdminSuggested, patientID, dtActualRewDt,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPatientVisit.Parameters.Add("@Return", SqlDbType.Int);
            cmdPatientVisit.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            SqlCommand cmdPatientHistory = new SqlCommand();
            DataTable dtPatientHistory = UDT_DAL.ConvertToHIDECType(lstPatientHistory);
            cmdPatientHistory = Command.pInsertIPHistoryCommand(dtPatientHistory, OrgID, LID, patientID, PatientVisitID, DetailsHistory,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPatientHistory.Parameters.Add("@Return", SqlDbType.Int);
            cmdPatientHistory.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            SqlCommand cmdPatientVitals = new SqlCommand();
            DataTable dtPatientVitals = UDT_DAL.ConvertToPatientVitals(lstPatientVitals);
            cmdPatientVitals = Command.pInsertIPVitalsCommand(dtPatientVitals, OrgID, PatientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPatientVitals.Parameters.Add("@Return", SqlDbType.Int);
            cmdPatientVitals.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            
            SqlCommand cmdPatientExamination = new SqlCommand();
            DataTable dtPatientExamination = UDT_DAL.ConvertToHIDECType(lstPatientExamination);
            cmdPatientExamination = Command.pInsertIPExaminationCommand(dtPatientExamination, PatientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPatientExamination.Parameters.Add("@Return", SqlDbType.Int);
            cmdPatientExamination.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            SqlCommand cmdPatientComplaint = new SqlCommand();
            DataTable dtPatientComplaint = UDT_DAL.ConvertToUDTPatientComplaintIP(lstPatientComplaint);
            cmdPatientComplaint = Command.pInsertIPComplaintCommand(dtPatientComplaint, PatientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPatientComplaint.Parameters.Add("@Return", SqlDbType.Int);
            cmdPatientComplaint.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            
            SqlCommand cmdPatientTreatmentPlan = new SqlCommand();
            DataTable dtIPTreatmentPlan = UDT_DAL.ConvertToIPTreatmentPlan(lstIPTreatmentPlan);
            cmdPatientTreatmentPlan = Command.pInsertIPTreatmentPlanCommand(dtIPTreatmentPlan, PatientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPatientTreatmentPlan.Parameters.Add("@Return", SqlDbType.Int);
            cmdPatientTreatmentPlan.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

           
            SqlCommand cmdDeletePatientDrugDetails = new SqlCommand();
            cmdDeletePatientDrugDetails = Command.pDeleteInPatientPrescriptionCommand(PatientVisitID,OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdDeletePatientDrugDetails.Parameters.Add("@Return", SqlDbType.Int);
            cmdDeletePatientDrugDetails.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            SqlCommand cmdPatientDrugDetails = new SqlCommand();
            DataTable dtDrugDetails = UDT_DAL.ConvertToPrescriptionType(lstDrugDetails);
            cmdPatientDrugDetails = Command.pInsertPatientPrescriptionBulkCommand(dtDrugDetails,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPatientDrugDetails.Parameters.Add("@Return", SqlDbType.Int);
            cmdPatientDrugDetails.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            SqlCommand cmdPatientRTAMLCDetails = new SqlCommand();
            cmdPatientRTAMLCDetails = Command.pInsertIPRTAMLCDetailsCommand(patientID, PatientVisitID,
									objRTAMLC.AlcoholDrugInfluence, objRTAMLC.FIRNo, objRTAMLC.Location, objRTAMLC.RTAMLCDate,
									            OrgID, LID, objRTAMLC.PoliceStation, objRTAMLC.MLCNo, objRTAMLC.FIRDate,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPatientRTAMLCDetails.Parameters.Add("@Return", SqlDbType.Int);
            cmdPatientRTAMLCDetails.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            SqlCommand cmdPatientBackgroundProblem = new SqlCommand();
            DataTable dtBackgroundProblem = UDT_DAL.ConvertToBackgroundProblem(lstBackgroundProblem);
            DataTable dtOtherBackgroundProblem = UDT_DAL.ConvertToBackgroundProblem(lstOtherBackgroundProblem);
            cmdPatientBackgroundProblem = Command.pInsertIPBackgroundProblemCommand(dtBackgroundProblem, dtOtherBackgroundProblem, PatientVisitID, patientID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPatientBackgroundProblem.Parameters.Add("@Return", SqlDbType.Int);
            cmdPatientBackgroundProblem.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            SqlCommand cmdPatientObstretricHistory = new SqlCommand();
            cmdPatientObstretricHistory = Command.pInsertIPObstretricHistoryCommand(objANCPatientDetails.PatientID,
									objANCPatientDetails.PatientVisitID, objANCPatientDetails.Abortus, objANCPatientDetails.Gravida,
									objANCPatientDetails.Live, objANCPatientDetails.Para, objANCPatientDetails.EDD, objANCPatientDetails.LMPDate,
									            objANCPatientDetails.CreatedBy,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPatientObstretricHistory.Parameters.Add("@Return", SqlDbType.Int);
            cmdPatientObstretricHistory.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmdPatientHistory);
                        returnCode = Convert.ToInt64(cmdPatientHistory.Parameters["@Return"].Value);
                        if (returnCode == 0)
                        {
                            dbEngine.ExecuteTransactionalNonQuery(cmdPatientVitals);
                            returnCode = Convert.ToInt64(cmdPatientVitals.Parameters["@Return"].Value);
                            if (returnCode == 0)
                            {
                                dbEngine.ExecuteTransactionalNonQuery(cmdPatientExamination);
                                returnCode = Convert.ToInt64(cmdPatientExamination.Parameters["@Return"].Value);
                                if (returnCode == 0)
                                {
                                    dbEngine.ExecuteTransactionalNonQuery(cmdPatientComplaint);
                                    returnCode = Convert.ToInt64(cmdPatientComplaint.Parameters["@Return"].Value);
                                    if (returnCode == 0)
                                    {
                                        dbEngine.ExecuteTransactionalNonQuery(cmdPatientTreatmentPlan);
                                        returnCode = Convert.ToInt64(cmdPatientTreatmentPlan.Parameters["@Return"].Value);
                                        if (returnCode == 0)
                                        {
                                            dbEngine.ExecuteTransactionalNonQuery(cmdDeletePatientDrugDetails);
                                            returnCode = Convert.ToInt64(cmdDeletePatientDrugDetails.Parameters["@Return"].Value);
                                            if (returnCode == 0)
                                            {
                                                dbEngine.ExecuteTransactionalNonQuery(cmdPatientDrugDetails);
                                                returnCode = Convert.ToInt64(cmdPatientDrugDetails.Parameters["@Return"].Value);
                                                if (returnCode == 0)
                                                {
                                                    dbEngine.ExecuteTransactionalNonQuery(cmdPatientRTAMLCDetails);
                                                    returnCode = Convert.ToInt64(cmdPatientRTAMLCDetails.Parameters["@Return"].Value);
                                                    if (returnCode == 0)
                                                    {
                                                        dbEngine.ExecuteTransactionalNonQuery(cmdPatientBackgroundProblem);
                                                        returnCode = Convert.ToInt64(cmdPatientBackgroundProblem.Parameters["@Return"].Value);
                                                        if (returnCode == 0)
                                                        {
                                                            dbEngine.ExecuteTransactionalNonQuery(cmdPatientObstretricHistory);
                                                            returnCode = Convert.ToInt64(cmdPatientObstretricHistory.Parameters["@Return"].Value);

                                                            if (returnCode == 0)
                                                            {
                                                                dbEngine.ExecuteTransactionalNonQuery(cmdPAdvice);
                                                                returnCode = Convert.ToInt64(cmdPAdvice.Parameters["@Return"].Value);
                                                                if (returnCode == 0)
                                                                {
                                                                    dbEngine.ExecuteTransactionalNonQuery(cmdPatientVisit);
                                                                    returnCode = Convert.ToInt64(cmdPatientVisit.Parameters["@Return"].Value);
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    tranScope.Complete();
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Error while executing SaveIPCaseRecord in IP_DAL", ex);
                    tranScope.Dispose();
                }
                return returnCode;
            }
        }

        public long GetPatientVitalsAndComplaint(long patientVisitID, int OrgID, out  List<VitalsUOMJoin> lstVitalsUOMJoin, out List<PatientComplaint> lstPatientComplaint)
        {
            long returnCode = -1;
            lstVitalsUOMJoin = new List<VitalsUOMJoin>();
            lstPatientComplaint = new List<PatientComplaint>();

            SqlCommand cmd = Command.pGetPatientVitalsAndComplaintCommand(patientVisitID, OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstVitalsUOMJoin);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatientComplaint);
                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Operation Notes in IP_DAL", ex);
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
            SqlCommand cmd = Command.pGetOperationNotesCommand(patientVisitID, OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSurgeryType);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstOperationType);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstAnesthesiaType);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstChiefOperater);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstAnesthisa);
                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstTechnicianName);
                }
                if (ds.Tables[6].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[6], out lstNurseName);
                }
                if (ds.Tables[7].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[7], out lstIPTreatmentPlan);
                }
                if (ds.Tables[8].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[8], out lstPatient);
                }
                if (ds.Tables[9].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[9], out lstIPTreatmentPlanFromCaserecord);
                }
                if (ds.Tables[10].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[10], out lstIPTreatmentPlanDetails);
                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Operation Notes in IP_DAL", ex);
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


            SqlCommand cmd = Command.pGetOperationNotesForUpdateCommand(patientVisitID, OrgID, OperationID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOperationNotes);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstOperationFinding);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstOperationComplication);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstChiefPhysicianOperationStaff);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstAssistantPhysicianOperationStaff);
                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstAnesthisiaOperationStaff);
                }
                if (ds.Tables[6].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[6], out lstTechnicianOperationStaff);
                }
                if (ds.Tables[7].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[7], out lstNurseOperationStaff);
                }
                if (ds.Tables[8].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[8], out lstIPTreatmentPlanByOperationID);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Operation Notes in IP_DAL", ex);
            }

            return returnCode;
        }

        public long GetIPCaseRecord(long patientVisitID, long pLID, long pRID, string Priviousvisitdrug, out List<PatientHistory> lstPatientHistory,
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

            SqlCommand cmd = Command.pGetIPCaseRecordCommand(patientVisitID, pLID, pRID, Priviousvisitdrug,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientHistory);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatientExamination);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstDrugDetails);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstRTAMLCDetails);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstPatientComplaint);
                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstIPTreatmentPlan);
                }
                if (ds.Tables[6].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[6], out lstBackgroundProblem);
                }
                if (ds.Tables[7].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[7], out lstPatientVitals);
                }
                if (ds.Tables[8].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[8], out lstANCPatientDetails);
                }
                if (ds.Tables[9].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[9], out lstPatientInvestigation);
                }
                if (ds.Tables[10].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[10], out lstIPPatientPerformedInvestigation);
                }
                if (ds.Tables[11].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[11], out lstPerformedIPTreatmentPlan);
                }

                if (ds.Tables[12].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[12], out lstOtherBackgroundProblem);
                }

                if (ds.Tables[13].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[13], out lstPatientHistoryExt);
                }
                if (ds.Tables[14].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[14], out lstPatientAdvice);
                }
                if (ds.Tables[15].Rows.Count > 0)
                {
                    strNextReviewDt = ds.Tables[15].Rows[0]["NextReviewDate"].ToString();
                }
                if (ds.Tables[16].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[16], out lstPrevVisits);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPCaseRecord in IP_DAL", ex);
            }
            return returnCode;
        }
        public long GetCorporateMaster(int OrgID, out List<CorporateMaster> lstCorporateMaster)
        {
            long returnCode = -1;
            lstCorporateMaster = new List<CorporateMaster>();
            SqlCommand cmd = Command.pGetCorporateMasterCommand(OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCorporateMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetCorporateMaster in IP_DAL", ex);
            }
            return returnCode;
        }
        public long GetIPVisitDetails(long PatientVisitID, out List<PatientVisit> lstPatientVisit)
        {
            long returnCode = -1;
            lstPatientVisit = new List<PatientVisit>();
            SqlCommand cmd = Command.pGetIPVisitDetailsCommand(PatientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientVisit);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPVisitDetails in IP_DAL", ex);
            }
            return returnCode;
        }
        public long GetIPOrganDonation(long patientID, out List<OrganRegWithMapping> lstOrgRegWithMapping)
        {
            long returnCode = -1;
            lstOrgRegWithMapping = new List<OrganRegWithMapping>();
            SqlCommand cmd = Command.pGetIPOrganDonationCommand(patientID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrgRegWithMapping);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPOrganDonation in IP_DAL", ex);
            }
            return returnCode;
        }
        public long SaveCorporateMaster(CorporateMaster CorporateMaster)
        {
            long lresult = -1;
            int mCorporateID = 0;

            SqlCommand cmd = Command.pInsertCorporateMasterCommand(CorporateMaster.CorporateName, CorporateMaster.Discount, CorporateMaster.DiscountType, CorporateMaster.CreatedBy, CorporateMaster.OrgID, CorporateMaster.CorporateID, out mCorporateID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveCorporateMaster in IP_DAL" + cmd.CommandText, ex);
            }

            return lresult;
        }

        public long GetIPPhysicianListByOrg(int orgID, out List<Physician> lstPhysician)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetIPPhysicianListByOrgCommand(orgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPhysician = new List<Physician>();
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPhysician);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPPhysicianListByOrg in IP_DAL", ex);
            }
            return returnCode;
        }




        public long GetMaxOfVitalsSetID(long patientVisitID, out List<PatientVitals> lstMaxOfVitalsSetID)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetMaxofVitalsSetIDCommand(Convert.ToInt32(patientVisitID),UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstMaxOfVitalsSetID = new List<PatientVitals>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstMaxOfVitalsSetID);
            }
            return returnCode;
        }

        public long LoadDischargeType(int OrgID, long patientVisitID, out List<InPatientDischargeType> lstDischargeType)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetDischargeTypeCommand(OrgID, patientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstDischargeType = new List<InPatientDischargeType>();
            DataSet ds = new DataSet();


            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDischargeType);
            }


            return returnCode;
        }



        public long GetComplicationNames(string pNames, out List<Complication> lstComplicationNames)
        {
            long returnCode = -1;
            lstComplicationNames = new List<Complication>();
            try
            {
                SqlCommand cmd = Command.pGetComplicationNamesCommand(pNames,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstComplicationNames);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetUserNames", ex);
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
            SqlCommand cmd = new SqlCommand();
            DataTable dtOperationNotes = UDT_DAL.ConvertToOperationNotes(lstOperationNotes);
            DataTable dtOperationStaff = UDT_DAL.ConvertToOperationStaff(lstOperationStaff);
            DataTable dtOperationFinding = UDT_DAL.ConvertToOperationFinding(lstOperationFinding);
            DataTable dtOperationComplication = UDT_DAL.ConvertToOperationComplication(lstOperationComplication);
            DataTable dtIPTreatmentPlan = UDT_DAL.ConvertToIPTreatmentPlan(lstIPTreatmentPlan);
            DataTable dtIPTreatmentPlanAndPerformed = UDT_DAL.ConvertToIPTreatmentPlan(lstIPTreatmentPlanAndPerformed);
            cmd = Command.pSaveOpeartionNotesCommand(patientID, patientVisitID, OrgID, mode, OperationID, dtOperationNotes, dtOperationStaff, dtOperationFinding, dtOperationComplication, dtIPTreatmentPlan, dtIPTreatmentPlanAndPerformed,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteTransactionalNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);

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
            SqlCommand cmd = Command.pGetDischargeSummaryCommand(patientVisitID, OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstOperationNotes);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatientHistory);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstBackgroundProblem);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstVitalsUOMJoin);
                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstPatientComplaint);
                }
                if (ds.Tables[6].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[6], out lstDrugDetails);
                }
                if (ds.Tables[7].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[7], out lstIPTreatmentPlan);
                }
                if (ds.Tables[8].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[8], out lstPatientAdvice);
                }
                if (ds.Tables[9].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[9], out lstCaseRecordIPTreatmentPlan);
                }
                if (ds.Tables[10].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[10], out lstVitalsCount);
                }

                if (ds.Tables[11].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[11], out lstInPatientNumber);
                }






            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPCaseRecord in IP_DAL", ex);
            }
            return returnCode;
        }


        public long GetAllIPTreatmentPlanChild(int OrgID, out List<IPTreatmentPlanMaster> lstAllIPTreatmentPlanChild)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetAllIPTreatmentPlanChildCommand(OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstAllIPTreatmentPlanChild = new List<IPTreatmentPlanMaster>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstAllIPTreatmentPlanChild);
            }
            return returnCode;
        }




        public long SaveDischargeSummary(long patientVisitID, long patientID, string SummaryStatus, string Procedure, string Preparedby,
            string PrintNegativeExam, string PrintNegativeHistory, string PrintGeneralAdvice, List<DischargeSummary> lstDischargeSummary, 
            List<PatientComplaint> lstPatientComplaint, List<DrugDetails> lstDrugDetails, List<PatientAdvice> lstPatientAdvice,
            List<IPTreatmentPlan> lstCaseRecordIPTreatmentPlan, List<DischargeInvNotes> lstDischargeInvNotes, long CreatedBy, string CustomIpNo)
        {
            DataTable dtDischargeSummary = UDT_DAL.ConvertToDischargeSummary(lstDischargeSummary);
            DataTable dtPatientComplaint = UDT_DAL.ConvertToUDTPatientComplaintIP(lstPatientComplaint);
            DataTable dtDrugDetails = UDT_DAL.ConvertToPrescriptionType(lstDrugDetails);
            DataTable dtPatientAdvice = UDT_DAL.ConvertTouddInsertGeneralAdvice(lstPatientAdvice);
            DataTable dtIPTreatmentPlan = UDT_DAL.ConvertToIPTreatmentPlan(lstCaseRecordIPTreatmentPlan);
            DataTable dtDischargeInvNotes = UDT_DAL.ConvertToDischargeInvNotes(lstDischargeInvNotes);

            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pSaveDischargeSummaryCommand(patientVisitID, patientID, SummaryStatus, Procedure, Preparedby, PrintNegativeExam, 
									PrintNegativeHistory, PrintGeneralAdvice, CustomIpNo, dtDischargeSummary, dtPatientComplaint,
									                dtDrugDetails, dtPatientAdvice, dtIPTreatmentPlan, @CreatedBy, dtDischargeInvNotes, lstDischargeSummary[0].ReviewReason,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteTransactionalNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);

            }

            return returnCode;
        }

       
        
        public long GetDischargeSummaryDetailsForupdate(long patientVisitID, out List<DischargeSummary> lstDischargeSummary, out List<DischargeInvNotes> lstDischargeInvNotes)
        {
            long returnCode = -1;
            lstDischargeSummary = new List<DischargeSummary>();
            lstDischargeInvNotes = new List<DischargeInvNotes>();

            SqlCommand cmd = Command.pGetDischargeSummaryForupdateCommand(patientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDischargeSummary);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstDischargeInvNotes);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPCaseRecord in IP_DAL", ex);
            }
            return returnCode;
        }




        public long GetDischargeSummaryCaseSheet(long patientVisitID, int OrgID, out List<Patient> lsPatient, out List<InPatientAdmissionDetails> lstInPatientAdmissionDetails, out List<OperationNotes> lstOperationNotes, out List<DischargeSummary> lstDischargeSummary, out List<PatientComplaint> lstPatientComplaint, out List<IPTreatmentPlan> lstCaserecordIPTreatmentPlan, out List<BackgroundProblem> lstBackgroundProblem, out List<VitalsUOMJoin> lstVitalsUOMJoin, out List<PatientExamination> lstPatientExamination, out List<DrugDetails> lstDrugDetails, out List<PatientAdvice> lstPatientAdvice, out List<IPTreatmentPlan> lstOperationIPTreatmentPlan, out List<InPatientAdmissionDetails> lstAdmissionDate, out List<PatientAddress> lstPatientAddress, out List<VitalsUOMJoin> lstDischargeVitalsUOMJoin, out List<PatientVitals> lstPatientVitalsCount, out List<IPComplaint> lstNegativeIPComplaint, out List<Examination> lstNegativeExamination, out List<PatientHistoryExt> lstPatientHistoryExt, out List<RoomMaster> lstRoomMaster, out  List<InPatientNumber> lstInPatientNumber, out List<GeneralAdvice> lstGeneralAdvice, out List<DischargeInvNotes> lstDischargeInvNotes, out int OrthoCount)
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
            lstPatientAddress = new List<PatientAddress>();
            lstDischargeInvNotes = new List<DischargeInvNotes>();



            lstDischargeVitalsUOMJoin = new List<VitalsUOMJoin>();
            lstPatientVitalsCount = new List<PatientVitals>();

            lstNegativeIPComplaint = new List<IPComplaint>();
            lstNegativeExamination = new List<Examination>();

            lstPatientHistoryExt = new List<PatientHistoryExt>();
            lstRoomMaster = new List<RoomMaster>();
            lstInPatientNumber = new List<InPatientNumber>();
            lstGeneralAdvice = new List<GeneralAdvice>();
            lstDischargeInvNotes = new List<DischargeInvNotes>();

            SqlCommand cmd = Command.pGetDischargeSummarySheetCommand(patientVisitID, OrgID, out OrthoCount,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    OrthoCount = Convert.ToInt32(cmd.Parameters["@OrthoCount"].Value);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lsPatient);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstInPatientAdmissionDetails);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstOperationNotes);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstDischargeSummary);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstPatientComplaint);
                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstCaserecordIPTreatmentPlan);
                }
                if (ds.Tables[6].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[6], out lstBackgroundProblem);
                }
                if (ds.Tables[7].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[7], out lstVitalsUOMJoin);
                }
                if (ds.Tables[8].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[8], out lstPatientExamination);
                }
                if (ds.Tables[9].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[9], out lstDrugDetails);
                }
                if (ds.Tables[10].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[10], out lstPatientAdvice);
                }
                if (ds.Tables[11].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[11], out lstOperationIPTreatmentPlan);
                }
                if (ds.Tables[12].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[12], out lstAdmissionDate);
                }

                if (ds.Tables[13].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[13], out lstPatientAddress);
                }
                if (ds.Tables[14].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[14], out lstDischargeVitalsUOMJoin);
                }

                if (ds.Tables[15].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[15], out lstPatientVitalsCount);
                }

                if (ds.Tables[16].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[16], out lstNegativeIPComplaint);
                }

                if (ds.Tables[17].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[17], out lstNegativeExamination);
                }

                if (ds.Tables[18].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[18], out lstPatientHistoryExt);
                }

                if (ds.Tables[19].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[19], out lstRoomMaster);
                }

                if (ds.Tables[20].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[20], out lstInPatientNumber);
                }

                if (ds.Tables[21].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[21], out lstGeneralAdvice);
                }


                if (ds.Tables[22].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[22], out lstDischargeInvNotes);
                }







            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDischargeSummarySheet in IP_DAL", ex);
            }
            return returnCode;
        }



        public long GetIPTreatmentPlanbyPatientVistID(long patientVisitID, out List<IPTreatmentPlan> lstIPTreatmentPlanbyPatientVistID)
        {
            long returnCode = -1;
            lstIPTreatmentPlanbyPatientVistID = new List<IPTreatmentPlan>();
            SqlCommand cmd = Command.pGetIPTreatmentPlanbyPatientVisitIDCommand(patientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstIPTreatmentPlanbyPatientVistID);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPTreatment in IP_DAL", ex);
            }
            return returnCode;
        }




        public long GetPatientHistory(long patientVisitID, int OrgID, out List<PatientHistory> lstPatientHistory)
        {
            long returnCode = -1;

            lstPatientHistory = new List<PatientHistory>();

            SqlCommand cmd = Command.pGetPatientHistoryByVistIDCommand(patientVisitID, OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientHistory);
                }



            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientHistory in IP_DAL", ex);
            }
            return returnCode;
        }
        // changed dataset to datareader by thiyagu
        public long GetPatientDischargeDetailByPatientID(long pid, out List<DischargeSummary> lstDischargeSummaryByPatientID)
        {
            long returnCode = -1;
            lstDischargeSummaryByPatientID = new List<DischargeSummary>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetPatientDischargeDetailByPatientIDCommand(pid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstDischargeSummaryByPatientID);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientDischargeDetail in IP_DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            } 
            return returnCode;
        }

        public long GetInPatientVisitCount(long patientID, out List<PatientVisit> lstPatientVisitCount)
        {
            long returnCode = -1;
            lstPatientVisitCount = new List<PatientVisit>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetInPatientVisitCountCommand(patientID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 1)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientVisitCount);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get visit details", ex);
            }
            return returnCode;
        }



        public long InsertIPOrderedInv(List<PatientInvestigation> pPatientInvTable, long visitID, long CreatedBy, long PatientID, out string InterimBillNo)
        {
            long ireturnStatus = -1;
            InterimBillNo = "-1";
            DataTable dtPatientItems = null;
            dtPatientItems = UDT_DAL.ConvertToUDTPatientDueChart(pPatientInvTable);
            SqlCommand cmdInsertVisit = Command.pInsertIPOrderedInvCommand(dtPatientItems, visitID, CreatedBy, PatientID, out InterimBillNo,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(true))
            {
                dbEngine.ExecuteTransactionalNonQuery(cmdInsertVisit);
                InterimBillNo = Convert.ToString(cmdInsertVisit.Parameters["@pInterimBillNumber"].Value);
                ireturnStatus = 0;
            }
            return ireturnStatus;
        }


        public long DeletePatientInvestigation(List<PatientInvestigation> lstPatient, long patientVisitID)
        {
            long lresult = -1;

            DataTable dtPatient = new DataTable();
            dtPatient = UDT_DAL.ConvertToPatientInvestigation(lstPatient);
            SqlCommand cmd = Command.pDeletePatientInvestigationCommand(dtPatient, patientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                    lresult = 0;
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing investigation DAL" + cmd.CommandText, ex);
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
                SqlCommand cmd = Command.pGetIPOrderedInvestigationsCommand(patientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInv);

                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstGrp);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while investigation dal", ex);

            }
            return returnCode;
        }
        public long DeleteInPatientInvestigation(long patientVisitID, int OrgID)
        {
            long lresult = -1;


            SqlCommand cmd = Command.pDeleteInPatientInvestigationCommand(patientVisitID, OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                    lresult = 0;
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing investigation DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }
        public long UpdateReferedInv(long patientVisitID)
        {
            long lresult = -1;

            SqlCommand cmd = Command.pUpdateReferedInvCommand(patientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                    lresult = 0;
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing investigation DAL" + cmd.CommandText, ex);
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


            SqlCommand cmd = Command.pGetSurgeonNameAndSurgeryTypeCommand(OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstIPTreatmentType);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstChiefPhysician);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstAnesthisa);
                }

                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstInstrumentationMaster);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstNurse);
                }



            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSurgeonNameAndSurgeryType in IP_DAL", ex);
            }
            return returnCode;
        }


        public long SaveSurgeryBillingDetails(long SurgeryBillingID, string Type, long patientID, long patientVisitID, int OrgID, List<SurgeryBillingMaster> lstSurgeryBillingMaster, List<SurgeryBillingDetails> lstSurgeryBillingDetails, DateTime pBillDate, out decimal pTotalAmount)
        {
            long returnCode = -1;
            pTotalAmount = -1;
            SqlCommand cmd = new SqlCommand();
            DataTable dtSurgeryBillingMaster = UDT_DAL.ConvertToSurgeryBillingMaster(lstSurgeryBillingMaster);
            DataTable dtSurgeryBillingDetails = UDT_DAL.ConvertToSurgeryBillingDetails(lstSurgeryBillingDetails);

            cmd = Command.pSaveSurgeryBillingDetailsCommand(SurgeryBillingID, Type, patientID, patientVisitID, OrgID, dtSurgeryBillingMaster, dtSurgeryBillingDetails, pBillDate, out pTotalAmount,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteTransactionalNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                pTotalAmount = Convert.ToDecimal(cmd.Parameters["@pTotalAmount"].Value);

            }

            return returnCode;
        }

        public long BindSurgeryBillingDetailByVisitID(long patientVisitID, out List<SurgeryBillingMaster> lstSurgeryBillingMasterByVisitid)
        {
            long returnCode = -1;
            lstSurgeryBillingMasterByVisitid = new List<SurgeryBillingMaster>();
            SqlCommand cmd = Command.pBindSurgeryBillingDetailByVisitIDCommand(patientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSurgeryBillingMasterByVisitid);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing BindSurgeryBillingDetailByVisitID in IP_DAL", ex);
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

            SqlCommand cmd = Command.pGetSurgeryBillingBySurgeryBillingIDCommand(SurgeryBillingID, out pTreatmentMasterID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    pTreatmentMasterID = Convert.ToInt32(cmd.Parameters["@pTreatmentMasterID"].Value);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSurgeryBillingMaster);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstSurgeryBillingDetails);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstAssistantPhysicianOperationStaff);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstAnesthisiaOperationStaff);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing BindSurgeryBillingDetailByVisitID in IP_DAL", ex);
            }
            return returnCode;
        }

        public long InsertSurgeryBillingToDue(List<SurgeryBillingMaster> lstSurgeryBillingMaster, long visitID, long CreatedBy,
            long PatientID, long SurgeryFeeId, decimal pTotalAmount, out string InterimBillNo)
        {
            long ireturnStatus = -1;
            InterimBillNo = "-1";

            DataTable pPatientIndTable = UDT_DAL.ConvertToUDTPatientDueChart(lstSurgeryBillingMaster, SurgeryFeeId, pTotalAmount);

            SqlCommand cmdInsert = Command.pInsertSurgeryBillingToDuesCommand(pPatientIndTable, visitID, CreatedBy, PatientID, out InterimBillNo,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(true))
            {
                dbEngine.ExecuteTransactionalNonQuery(cmdInsert);
                InterimBillNo = Convert.ToString(cmdInsert.Parameters["@pInterimBillNumber"].Value);
                ireturnStatus = 0;
            }
            return ireturnStatus;
        }


        public long BindSurgeryDetailForAdvanceByVisitID(long patientVisitID, out List<PatientDueChart> lstSurgeryDetailForAdvance)
        {
            long returnCode = -1;
            lstSurgeryDetailForAdvance = new List<PatientDueChart>();
            SqlCommand cmd = Command.pBindSurgeryDetailForAdvanceByVisitIDCommand(patientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSurgeryDetailForAdvance);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing BindSurgeryDetailForAdvanceByVisitID in IP_DAL", ex);
            }
            return returnCode;
        }


        public long GetPendingSurgeyPaymentTaskId(long pVisitID, out List<Tasks> lstPendingTasks)
        {
            long returnCode = -1;

            lstPendingTasks = new List<Tasks>();
            SqlCommand cmd = Command.pGetPendingSurgeyPaymentTaskIdCommand(pVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPendingTasks);
                }
            }

            catch (Exception ex)
            {
                CLogger.LogError("Error while executing BindSurgeryDetailForAdvanceByVisitID in IP_DAL", ex);
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

            SqlCommand cmd = Command.pGetIPCaseRecordSheetCommand(patientID, patientVisitID, viewType, OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lsPatient);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstInPatientAdmissionDetails);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatientComplaint);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstBackgroundProblem);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstVitalsUOMJoin);
                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstPatientExamination);
                }
                if (ds.Tables[6].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[6], out lstDrugDetails);
                }
                if (ds.Tables[7].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[7], out lstCaserecordIPTreatmentPlan);
                }
                if (ds.Tables[8].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[8], out lstAdmissionDate);
                }
                if (ds.Tables[9].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[9], out lstOrderedInvestigations);
                }
                if (ds.Tables[10].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[10], out lstNegativeIPComplaint);
                }

                if (ds.Tables[11].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[11], out lstNegativeExamination);
                }
                if (ds.Tables[12].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[12], out lstPatientHistoryExt);
                }
                if (ds.Tables[13].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[13], out lstAdvice);
                }
                if (ds.Tables[14].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[14], out lstPatientHistory);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPCaseRecordSheet in IP_DAL", ex);
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

            SqlCommand cmd = Command.pGetOperationNotesCaseSheetCommand(patientVisitID, OperationID, OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstOperationNotes);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstIPTreatmentPlan);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstPatientComplaint);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstOperationTeam);
                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstTechnicianName);
                }
                if (ds.Tables[6].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[6], out lstNurse);
                }
                if (ds.Tables[7].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[7], out lstSurgeryType);
                }
                if (ds.Tables[8].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[8], out lstOperationType);
                }
                if (ds.Tables[9].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[9], out lstAnesthesiaType);
                }
                if (ds.Tables[10].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[10], out lstOperationFinding);
                }
                if (ds.Tables[11].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[11], out lstOperationComplication);
                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetOperationNotesCaseSheet in IP_DAL", ex);
            }
            return returnCode;
        }


        public long getSurgeryName(string SurgeryName, int pOrgID, out List<IPTreatmentPlan> lstSurgeryName)
        {
            long lresult = -1;
            lstSurgeryName = new List<IPTreatmentPlan>();
            SqlCommand cmd = Command.pGetAllSurgeryNameCommand(SurgeryName, pOrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstSurgeryName);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getSurgeryName in DAL" + cmd.CommandText, ex);
            }

            return lresult;

        }
        public long GetInPatientRegDetail(long pid, long vid, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            try
            {
                SqlCommand cmd = Command.pGetInPatientRegDetailCommand(pid, vid,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in IP DAL GetInPatientRegDetail", ex);
            }

            return returnCode;
        }


        public long GetTPAName(int orgID, out List<TPAMaster> lstTPAMaster)
        {
            long returnCode = -1;
            lstTPAMaster = new List<TPAMaster>();
            try
            {
                SqlCommand cmd = Command.pGetTPANameCommand(orgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstTPAMaster);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while IP DAL TPAName", ex);

            }
            return returnCode;
        }
        public long GetTPAPatient(long patientID, string PatientName, string paymentStatus
                                    , string TPAName, long TPAID, DateTime FromDate
                                    , DateTime ToDate, long OrgID, int ClientID, out List<TPADetails> lstTPADetails)
        {
            long returnCode = -1;
            lstTPADetails = new List<TPADetails>();
            try
            {
                SqlCommand cmd = Command.pGetTPAPatientCommand(patientID, PatientName, paymentStatus, TPAName, TPAID, FromDate, ToDate, ClientID, OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstTPADetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in IPDAL GetTPAPatient method", ex);
            }
            return returnCode;
        }
        public long GetTPAPayment(List<Patient> lstPatient, int orgID, out List<Patient> lPatient)
        {
            long returnCode = -1;
            lPatient = new List<Patient>();
            DataTable dtPatient = UDT_DAL.ConvertToPatientBillingDetails(lstPatient);
            try
            {
                SqlCommand cmd = Command.pGetTPAPaymentCommand(dtPatient, orgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lPatient);
                }
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
            DataTable dtPatient = UDT_DAL.ConvertToUDTTPAPayment(lPatient);
            try
            {
                SqlCommand cmd = Command.pInsertTPAPaymentCommand(dtPatient, orgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in IPDAL GetTPAPayment method", ex);
            }
            return returnCode;
        }

     
        public long GetDischargeChkList(long pid, long vid, out List<DischargeChkLstMaster> lstDisChkLst, out string DestPostDischarge)
        {
            long returnCode = -1;
            DestPostDischarge = string.Empty;
            lstDisChkLst = new List<DischargeChkLstMaster>();
            DataSet ds = new DataSet();

            try
            {
                SqlCommand objCommand = Command.pGetDischargeChkListCommand(pid, vid, out DestPostDischarge,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDisChkLst);
                    DestPostDischarge = objCommand.Parameters["@pDescPostDischarge"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetDischargeChkList", ex);
            }
            return returnCode;
        }
         
       
        public long GetPTPAPaymentDetails(long VisitID, long PatientId, int OrgID, out List<TPAPayments> lPaymentDetails)
        {
            long returnCode = -1;
            lPaymentDetails = new List<TPAPayments>();

            try
            {
                SqlCommand cmd = Command.pgetTPApaidDetailsCommand(VisitID, PatientId, OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);
                }
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lPaymentDetails);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in IP dal GetPTPAPaymentDetails function", ex);
            }
            return returnCode;
        }
        public long UpdatePaymentDetails(TPAPayments objTPAPayments, int OrgID, long LID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pUpdateInterMediatePaymentCommand(objTPAPayments.Amount, objTPAPayments.TDS, objTPAPayments.TPAPaymentID, OrgID, LID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteNonQuery(cmd);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in IP dal GetPTPAPaymentDetails function", ex);
            }
            return returnCode;
        }


        public long GetMLCDetails(long PatientVisitID, out List<RTAMLCDetails> lstRTAMLCDetails)
        {
            long returnCode = -1;
            lstRTAMLCDetails = new List<RTAMLCDetails>();
            DataSet ds = new DataSet();

            try
            {
                SqlCommand objCommand = Command.pGetMLCDetailsCommand(PatientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstRTAMLCDetails);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetMLCDetails", ex);
            }
            return returnCode;
        }

        public long GetAllDischargeSummarySeq(int pOrgID, out List<DischargeSummarySeq> lstdischargesummary)
        {
            long returnCode = -1;
            lstdischargesummary = new List<DischargeSummarySeq>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand objCommand = Command.pGetAllDischargeSummarySeqCommand(pOrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstdischargesummary);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL Discharge Summary", ex);
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
            DataSet ds = new DataSet();

            try
            {
                SqlCommand objCommand = Command.pGetDeathRegDataCommand(OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPlaceOfDeath);

                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstTypeOfDeath);

                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstCauseOfDeathMaster);

                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstLifeSupportMaster);

                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstOrgan);

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetDeathRegData", ex);
            }
            return returnCode;
        }

        public long SaveDischargeseqDetails(int OrgID, DataTable dtPatientHisAttributes)
        {
            long returnCode = -1;


            try
            {
                SqlCommand cmd = Command.pUpdateDischargeSequenceCommand(dtPatientHisAttributes, OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertPatDisChkList", ex);
            }
            return returnCode;
        }


        public long SaveDeathRegDetails(int OrgID, long patientVisitID, long patientID, long LID, string pType, List<CauseOfDeath> lstCauseOfDeath, List<PatientHistory> lstPatientHis, List<PatientHistoryAttribute> lstPatientHisAttributes, List<OrganRegWithMapping> lstOrgRegWithMapping, RTAMLCDetails objRTAMLCDetails, DeathRegistration objDeathRegistration)
        {
            long returnCode = -1;
            DataTable dtCauseOfDeath =UDT_DAL.ConvertToCauseOfDeath(lstCauseOfDeath);
            DataTable dtPatientHis = UDT_DAL.ConvertToHistoryPKGType(lstPatientHis);
            DataTable dtPatientHisAtt = UDT_DAL.ConvertToHistoryPKGAttribute(lstPatientHisAttributes);
            DataTable dtOrgReg = UDT_DAL.ConvertTopatientOrganDonation(lstOrgRegWithMapping);
            try
            {
                SqlCommand cmd = Command.pSaveDeathRegistrationCommand(OrgID, patientVisitID, patientID, LID, pType, dtCauseOfDeath, dtPatientHis, dtPatientHisAtt, dtOrgReg,
									objRTAMLCDetails.AlcoholDrugInfluence, objRTAMLCDetails.FIRNo, objRTAMLCDetails.Location, objRTAMLCDetails.RTAMLCDate, objRTAMLCDetails.PoliceStation, objRTAMLCDetails.MLCNo, objRTAMLCDetails.FIRDate,
									objDeathRegistration.DOD, objDeathRegistration.PlaceOfDeathID, objDeathRegistration.PlaceOfDeathDes, objDeathRegistration.DeathTypeID, objDeathRegistration.DeathTypeDes, objDeathRegistration.IsPregnancy, objDeathRegistration.PregnancyStatus,
									                  objDeathRegistration.PregnancyDescription, objDeathRegistration.IsResuscitation, objDeathRegistration.LifeSupportID, objDeathRegistration.IsROSC, objDeathRegistration.RoscDescription, objDeathRegistration.ProcedureDesc, objDeathRegistration.HospitalCourse,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertPatDisChkList", ex);
            }
            return returnCode;
        }

    
        public long GetDeathRegForUpdate(long patientVisitID, out List<DeathRegistration> lstDeathRegistration, out List<CauseOfDeath> lstCauseOfDeath, out List<PatientHistoryAttribute> lstPatientHisAttributes)
        {
            long returnCode = -1;

            lstDeathRegistration = new List<DeathRegistration>();
            lstCauseOfDeath = new List<CauseOfDeath>();
            lstPatientHisAttributes = new List<PatientHistoryAttribute>();

            DataSet ds = new DataSet();

            try
            {
                SqlCommand objCommand = Command.pGetDeathRegForUpdateCommand(patientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeathRegistration);

                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstCauseOfDeath);

                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatientHisAttributes);

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetDeathRegForUpdate", ex);
            }
            return returnCode;
        }


        public long UpdateTPAPaymentDetails(List<PatientDueChart> lPatient, int OrgID, string Status, decimal WriteOff, long finalBillID, DateTime SettlementDate, DateTime ClaimForwaredDate)
        {
            long returnCode = -1;
            DataTable dt = UDT_DAL.ConvertToUDTTPAPayment(lPatient);
            try
            {
                SqlCommand cmd = Command.pUpdateTPAPaymentDetailsCommand(dt, OrgID, Status, WriteOff, finalBillID, SettlementDate, ClaimForwaredDate,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in IP dal GetPTPAPaymentDetails function", ex);
            }
            return returnCode;
        }

        public long GetOperationNotesForDS(long patientVisitID, int OrgID, out List<OperationNotes> lstOperationNotesForDS)
        {
            long returnCode = -1;
            lstOperationNotesForDS = new List<OperationNotes>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand objCommand = Command.pGetOperationNotesForDSCommand(patientVisitID, OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOperationNotesForDS);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetDeathRegForUpdate", ex);
            }
            return returnCode;
        }
        public long GetPatientComplaintWithICD(long patientVisitID, string VisitType, string PageType, out List<PatientComplaint> lstPatientComplaint)
        {
            long returnCode = -1;
            lstPatientComplaint = new List<PatientComplaint>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand objCommand = Command.pGetPatientComplaintWithICDCommand(patientVisitID, VisitType, PageType,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientComplaint);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetPatientComplaintWithICD", ex);
            }
            return returnCode;
        }


        public long GetDischargeSummarySeq(int OrgID, out List<DischargeSummarySeq> lstDischargeSummarySeq)
        {
            long returnCode = -1;
            lstDischargeSummarySeq = new List<DischargeSummarySeq>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand objCommand = Command.pGetDischargeSummarySeqCommand(OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDischargeSummarySeq);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetDischargeSummarySeq", ex);
            }
            return returnCode;
        }

        public long GetTPACorporateReport(long patientID, string PatientName, string paymentStatus
                                   , string TPAName, long TPAID, DateTime FromDate
                                   , DateTime ToDate, long OrgID, int ClientID, out List<TPADetails> lstTPADetails)
        {
            long returnCode = -1;
            lstTPADetails = new List<TPADetails>();
            try
            {
                SqlCommand cmd = Command.pGetTPACorporateReportCommand(patientID, PatientName, paymentStatus, TPAName, TPAID, FromDate, ToDate, ClientID, OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstTPADetails);
                }
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
            DataSet ds = new DataSet();
            try
            {
                SqlCommand objCommand = Command.pGetOrthoSpecialtyDetailsCommand(OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSpecialtyUniqueParts);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstBodyPartChildItems);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetOrthoSpecialtyDetails", ex);
            }
            return returnCode;
        }


        public long SaveOrthoPatientDetails(long VisitID, long PatientID, int OrgID, long LID,
                                              List<OrthoPatientDetails> lstOrthoPatientDetails, List<PatientBodyPartDetails> lstPatientBodyPartDetails,
                                              List<PatientOpenWound> lstPatientOpenWound, List<PatientVascularDetails> lstPatientVascularDetails,
                                              List<PatientNeurologicalDetails> lstPatientNeurologicalDetails, List<PatientReflexes> lstPatientReflexes,
                                              List<PatientMuscleDetail> lstPatientMuscleDetail, List<PatientMuscleWasting> lstPatientMuscleWasting)
        {
            long returnCode = -1;
            try
            {
                DataTable dtOrthoPatientDetails = UDT_DAL.ConvertToUDTOrthoPatientDetails(lstOrthoPatientDetails);
                DataTable dtPatientBodyPartDetails = UDT_DAL.ConvertToUDTPatientBodyPartDetails(lstPatientBodyPartDetails);
                DataTable dtPatientOpenWound = UDT_DAL.ConvertToUDTPatientOpenWound(lstPatientOpenWound);
                DataTable dtPatientVascularDetails = UDT_DAL.ConvertToUDTPatientVascularDetails(lstPatientVascularDetails);
                DataTable dtPatientNeurologicalDetails = UDT_DAL.ConvertToUDTPatientNeurologicalDetails(lstPatientNeurologicalDetails);
                DataTable dtPatientReflexes = UDT_DAL.ConvertToUDTPatientReflexes(lstPatientReflexes);
                DataTable dtPatientMuscleDetail = UDT_DAL.ConvertToUDTPatientMuscleDetail(lstPatientMuscleDetail);
                DataTable dtPatientMuscleWasting = UDT_DAL.ConvertToUDTPatientMuscleWasting(lstPatientMuscleWasting);



                SqlCommand cmd = new SqlCommand();
                cmd = Command.pSaveOrthoPatientDetailsCommand(VisitID, PatientID, OrgID, LID,
									dtOrthoPatientDetails, dtPatientBodyPartDetails,
									dtPatientOpenWound, dtPatientVascularDetails,
									dtPatientNeurologicalDetails, dtPatientReflexes,
									                                                 dtPatientMuscleDetail, dtPatientMuscleWasting,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                cmd.Parameters.Add("@Return", SqlDbType.Int);
                cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetOrthoSpecialtyDetails", ex);
            }

            return returnCode;
        }


      

        

        public long GetOrthoPatientDetailsForEdit(long VisitID, int OrgID, out List<OrthoPatientDetails> lstOrthoPatientDetails, out List<PatientBodyPartDetails> lstPatientBodyPartDetails,
                                             out List<PatientOpenWound> lstPatientOpenWound, out List<PatientVascularDetails> lstPatientVascularDetails,
                                             out List<PatientNeurologicalDetails> lstPatientNeurologicalDetails, out List<PatientReflexes> lstPatientReflexes,
                                             out List<PatientMuscleDetail> lstPatientMuscleDetail, out List<PatientBodyPartDetails> lstPatientDistinctBodyPartDetails, out int Count,
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

            DataSet ds = new DataSet();
            try
            {
                SqlCommand objCommand = Command.pGetOrthoPatientDetailsForEditCommand(VisitID, OrgID, out Count,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Count = Convert.ToInt32(objCommand.Parameters["@Count"].Value);
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrthoPatientDetails);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatientBodyPartDetails);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatientOpenWound);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstPatientVascularDetails);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstPatientNeurologicalDetails);
                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstPatientReflexes);
                }
                if (ds.Tables[6].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[6], out lstPatientMuscleDetail);
                }
                if (ds.Tables[7].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[7], out lstPatientDistinctBodyPartDetails);
                }
                if (ds.Tables[8].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[8], out lstPatientMuscleWasting);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetOrthoPatientDetailsForEdit", ex);
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
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetSurgeryPaymentsCommand(visitID, pID, OrgID, out pTotSurgeryAdv, out pTotSurgeryAmt,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {

                    dbEngine.ExecuteDataSet(cmd, out ds);
                    pTotSurgeryAdv = Convert.ToDecimal(cmd.Parameters["@pTotSurgeryAdv"].Value);
                    pTotSurgeryAmt = Convert.ToDecimal(cmd.Parameters["@pTotSurgeryAmt"].Value);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertPatDisChkList", ex);
            }
            return returnCode;
        }
        public long GetInvClientAttributes(int orgID, out List<InvClientMaster> lstClientAttributes)
        {
            long returnCode = -1;
            lstClientAttributes = new List<InvClientMaster>();
            try
            {
                SqlCommand cmd = Command.pGetInvClientAttributesCommand(orgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstClientAttributes);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while IP DAL GetInvClientAttributes", ex);

            }
            return returnCode;
        }
        public long GetIPBulkBill(long VisitID, long PatientID, long OrgID, out decimal GrandTotal, out List<PatientDueChart> lstBedBookingRoomType, out List<IPBulkBill> lstIPBulkBill, out List<IPBulkBill> lstIPBulkBill1)
        {

            long returnCode = -1;
            lstIPBulkBill = new List<IPBulkBill>();
            lstIPBulkBill1 = new List<IPBulkBill>();
            lstBedBookingRoomType = new List<PatientDueChart>();
            SqlCommand cmd = Command.pGetIPBillBulkReportCommand(VisitID, PatientID, OrgID, out GrandTotal,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {

                using (DBEngine dbEngine = new DBEngine())
                {

                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBedBookingRoomType);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstIPBulkBill);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstIPBulkBill1);
                }


            }

            catch (Exception ex)
            {

                CLogger.LogError("Error while executing Load GetKnowledgeOfService in Patient_DAL", ex);
            }

            return returnCode;
        }
        public long GetReferringOrgType(int orgID, out List<ReferringOrgType> lsRefOrgTypeMaster)
        {
            long returnCode = -1;
            lsRefOrgTypeMaster = new List<ReferringOrgType>();
            try
            {
                SqlCommand cmd = Command.pGetReferringOrgTypeCommand(orgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lsRefOrgTypeMaster);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while IP DAL TPAName", ex);

            }
            return returnCode;
        }

        
    public long GetPlannedSurgeryForAnesthesia(long VisitID, int orgID, out List<Patient> lstPatient, out List<InPatientAdmissionDetails> lstinPatientDetails, out List<IPTreatmentPlan> lstTreatmentplan, out List<AnesthesiaType> lstAnesthesiaType, out List<Physician> lstPhysician, out List<RoomMaster> lstRoom, out List<OperationNotes> lstOperationNotes, out List<AnesthesiaModes> lstMode, out List<Complication> lstComplication,out List<Vitals> lstVitals,out List<Vitals> lstVitalsGas,out List<Vitals> lstVitalsVentilator)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            lstTreatmentplan = new List<IPTreatmentPlan>();
            lstAnesthesiaType = new List<AnesthesiaType>();
            lstPhysician = new List<Physician>();
            lstRoom = new List<RoomMaster>();
            lstOperationNotes = new List<OperationNotes>();
            lstinPatientDetails = new List<InPatientAdmissionDetails>();
            lstMode = new List<AnesthesiaModes>();
            lstComplication = new List<Complication>();
            lstVitals = new List<Vitals>();
            lstVitalsVentilator = new List<Vitals>();
            lstVitalsGas = new List<Vitals>();



            try
            {
                SqlCommand cmd = Command.PgetPlannedSurgeryCommand(VisitID, orgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);

                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstinPatientDetails);

                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstTreatmentplan);

                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstAnesthesiaType);

                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstPhysician);

                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstRoom);

                }
                if (ds.Tables[6].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[6], out lstOperationNotes);

                }
                if (ds.Tables[7].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[7], out lstMode);

                }
                if (ds.Tables[8].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[8], out lstComplication);

                }
                if (ds.Tables[9].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[9], out lstVitals);

                }

                if (ds.Tables[10].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[10], out lstVitalsGas);

                }

                if (ds.Tables[11].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[11], out lstVitalsVentilator);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while IP DAL TPAName", ex);

            }
            return returnCode;
        }

        public long InsertAnesthesiaNotes(long PatientVisitID, long PatientID, DateTime StartTime, DateTime EndTime, string AnesthesiaType, string NPODuration, string AnesthesiaNotes, string ModeOfAnesthesia, string ScoringSystem, string ScoringValue, string Complications,out List<PatientAdvice> lstPatientAdvice)
        {
            lstPatientAdvice = new List<PatientAdvice>();

            long returnCode = -1;

            try
            {
                SqlCommand cmd = Command.pInsertAnesthesiaDetailsCommand(PatientVisitID, PatientID, StartTime, EndTime, AnesthesiaType, NPODuration, AnesthesiaNotes, ModeOfAnesthesia, ScoringSystem, ScoringValue, Complications,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                }
            }


            catch (Exception ex)
            {
                CLogger.LogError("Error while getting Progress Template", ex);
            }


            return returnCode;
        }

        public long GetAnesthesiaNotes(long PatientVisitID, out List<AnesthesiaDetails> lstAnesthesiaDetails,out List<Patient>  lstPatient,out List<IPTreatmentPlan> lstTreatementplan,out List<Physician> lstPhysician,out List<PatientVitals > lstPatientVitals,out List<RoomDetails> lstRoomDetails,out List<PatientPrescription> lstPatientPrescription,out List<PatientAdvice> lstPatientAdvice)
        
        
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
                SqlCommand cmd = Command.pGetAnesthesiaNotesCommand(PatientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstAnesthesiaDetails);

                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatient);

                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPhysician);

                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstTreatementplan);

                }

                if (ds.Tables[4].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstPatientVitals);

                }

                if (ds.Tables[5].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstRoomDetails);

                }
                if (ds.Tables[6].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[6], out lstPatientPrescription);

                }

                if (ds.Tables[7].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[7], out lstPatientAdvice);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while IP DAL TPAName", ex);

            }
            return returnCode;
        }
        public long InsertIPTreatmentPlanDetails(long PatientvisitID, long PatientID, int OrgID, List<IPTreatmentPlanDetails> lstIPTreatmentPlanDetails)
        {
            long returnCode = -1;
            DataTable dttreatmentdetails = UDT_DAL.ConvertToIPTreatmentPlanDetails(lstIPTreatmentPlanDetails);
            SqlCommand cmd = Command.PInsertIPTreatmentPlanDetailsCommand(PatientvisitID, PatientID, OrgID, dttreatmentdetails,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);

                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPTreatmentPlanMaster in IP_DAL", ex);
            }
            return returnCode;
        }


        public long GetIPTreatmentPlanDetails(long PatientID, out List<IPTreatmentPlanDetails> lstIPTreatmentPlanDetails ,out List<IPTreatmentPlanDetails> lstReportTreatmentDetails)
        {
            long returnCode = -1;
            lstIPTreatmentPlanDetails = new List<IPTreatmentPlanDetails>();
            lstReportTreatmentDetails = new List<IPTreatmentPlanDetails>();
       
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetSurgeyPlanDetailsCommand(PatientID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                 ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstIPTreatmentPlanDetails);

                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstReportTreatmentDetails);

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPTreatmentPlanMaster in IP_DAL", ex);
            }
            return returnCode;
        }





        public long GetIPTreatmentPlanDetailsReport( DateTime FromDate ,DateTime ToDate,long PatientID, out List<IPTreatmentPlanDetails> lstReportTreatmentDetails)
        {
            long returnCode = -1;
          
            lstReportTreatmentDetails = new List<IPTreatmentPlanDetails>();
          
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetSurgeyPlanDetailsReportCommand(PatientID,FromDate, ToDate,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReportTreatmentDetails);

                }
            

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPTreatmentPlanMaster in IP_DAL", ex);
            }
            return returnCode;
        }


        public long GetTreatmentPlanNames(String Prefix,long OrgID, out List<SurgeryPackageMaster> lstTreatmentPlanNames)
        {
            long returnCode = -1;

            lstTreatmentPlanNames = new List<SurgeryPackageMaster>();

            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetProcedureNamesCommand(Prefix, OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstTreatmentPlanNames);

                }

             



            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPTreatmentPlanNames  in IP_DAL", ex);
            }
            return returnCode;
        }



        public long GetSurgeryPackageNames(int OrgID, out List<SurgeryPackageMaster> lstSurgeryPackageNames)
        {
            long returnCode = -1;

            lstSurgeryPackageNames = new List<SurgeryPackageMaster>();

            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetSurgeryMasterCommand(OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSurgeryPackageNames);

                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSurgery Items in IP_DAL", ex);
            }
            return returnCode;
        }

        public long GetAnesthesiastNames(int OrgID,string PrefixText, out List<Physician> lstAnesthesiastNames)
        {
            long returnCode = -1;

            lstAnesthesiastNames = new List<Physician>();

            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetAnesthesiastCommand(OrgID,PrefixText,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstAnesthesiastNames);

                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAnesthesiast Names  in IP_DAL", ex);
            }
            return returnCode;
        }



    }



    
}
