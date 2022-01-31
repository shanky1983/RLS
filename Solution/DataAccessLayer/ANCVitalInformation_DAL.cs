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
    public class ANCVitalInformation_DAL
    {
        ContextDetails globalContextDetails;
        public ANCVitalInformation_DAL()
        {

        }
        public ANCVitalInformation_DAL(ContextDetails localContextDetails)
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
                SqlCommand cmd = Command.pGetVitalInformationTrendCommand(patientVisitId, out pWeightGained,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();

                using (DBEngine dbengine = new DBEngine())
                {
                    dbengine.ExecuteDataSet(cmd, out ds);
                    pWeightGained = Convert.ToInt32(cmd.Parameters["@pWeightGained"].Value);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstPatientVitals);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[1], out lstInvestigationValues);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL getVitalInformationTrend", ex);
            }

            return returncode;
        }






        public long getANCFollowUP(long pvisitID, long pPatientID, int ComplaintId, string CompName, string ComplicationName, out List<History> lstHistory, out List<Complication> lstCompNamee, out List<Complication> lstComplication, out List<FetalPresentations> lstFetalPresentations, out List<FetalPosition> lstFetalPosition, out List<FetalMovements> lstFetalMovements, out List<FetalFHS> lstFetalFHS, out List<InvestigationMaster> lstInvestigationMaster, out int noofFetals, out int pCountBaseLine)
        {
            long returncode = -1;
            noofFetals = 0;
            pCountBaseLine = -1;
            lstHistory = new List<History>();
            lstCompNamee = new List<Complication>();
            lstComplication = new List<Complication>();
            lstFetalMovements = new List<FetalMovements>();
            lstFetalPresentations = new List<FetalPresentations>();
            lstFetalPosition = new List<FetalPosition>();
            lstFetalFHS = new List<FetalFHS>();
            lstInvestigationMaster = new List<InvestigationMaster>();

            try
            {
                SqlCommand cmd = Command.pGetANCFollowUpCommand(pvisitID, pPatientID, ComplaintId, CompName, ComplicationName, out noofFetals, out pCountBaseLine,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();

                using (DBEngine dbengine = new DBEngine())
                {
                    dbengine.ExecuteDataSet(cmd, out ds);
                    noofFetals = Convert.ToInt32(cmd.Parameters["@pNoofFetals"].Value.ToString());
                    pCountBaseLine = Convert.ToInt32(cmd.Parameters["@pCount"].Value.ToString());
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstHistory);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[1], out lstCompNamee);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[2], out lstComplication);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[3], out lstFetalPresentations);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[4], out lstFetalPosition);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[5], out lstFetalMovements);
                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[6], out lstFetalFHS);
                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[7], out lstInvestigationMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL getANCFollowUP", ex);
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
                SqlCommand cmd = Command.pGetANCExaminationCommand(ExaminationId,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbengine = new DBEngine())
                {
                    dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstExamination);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[1], out lstExamination1);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL pGetANCExamination", ex);
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
                SqlCommand cmd = Command.pGetANCFollowUPExaminationCommand(ComplaintID, ParentID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbengine = new DBEngine())
                {
                    dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstExamination);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[1], out lstExamination1);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[2], out lstComplication);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL pGetANCFollowUPExamination", ex);
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
                SqlCommand cmd = Command.pGetANCVisitSummaryCommand(PatientID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();

                using (DBEngine dbengine = new DBEngine())
                {
                    dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstANCPatientDetails);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[1], out lstBackgroundProblem);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[2], out lstPatientVaccinationHistory);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[3], out lstUSD);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL pGetANCVisitSummary", ex);
            }

            return returncode;
        }
        public long pGetANCComplication(out List<Complication> lstComplication)
        {
            long returncode = -1;
            lstComplication = new List<Complication>();
            try
            {
                SqlCommand cmd = Command.pGetANCComplicationCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbengine = new DBEngine())
                {
                    dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstComplication);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("error in DAL pGetANCComplication", ex);
            }
            return returncode;
        }
        public long pInsertANCFollowup(List<PatientFetalFindings> lstPatientFetalFindings, out int retStaus)
        {
            long returncode = -1;
            retStaus = -1;

            DataTable dtSavePFF = new DataTable();
            dtSavePFF = UDT_DAL.ConvertToANCPatientFetalFindings(lstPatientFetalFindings);
            SqlCommand cmd = Command.pInsertANCFollowupCommand(out retStaus, dtSavePFF,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbengine = new DBEngine(true))
                {
                    returncode = dbengine.ExecuteNonQuery(cmd);
                    retStaus = Convert.ToInt32(cmd.Parameters["@returnstatus"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL pInsertANCFollowup", ex);
            }

            return returncode;
        }

        public long saveHECFC(string flag, long patientID, long patientVisitID,
            List<PatientComplaint> pComplaint,
            List<PatientHistory> lstPatientHistory,
            List<PatientExamination> lstPatientExamination,
            List<PatientComplication> lstPatientComplication,
            List<PatientFetalFindings> lstPatientFetalFindings, 
            List<PatientAdvice> lstPatientAdvice,
            List<DrugDetails> drgList,
            List<PatientVaccinationHistory> pVaccination,
            ANCPatientDetails pANCPatientDetails,
            PatientVisit entPatientVisit,
            PatienttoScanforANC entANCScan,
            List<OrderedInvestigations> PatientInvestigationHL,
            long orgID, out int pOrderedInvCnt, string UID,
            string PatientObservation, int OrgAddId, long LID)
        {
            long returncode = -1;
            int ret = -1;
            pOrderedInvCnt = -1;
            string labno = "";
            DataTable drugDT = new DataTable();
            DataTable dtPAdv = new DataTable();
            drugDT = UDT_DAL.ConvertToPrescriptionType(drgList, pComplaint[0].ComplaintID);
            dtPAdv = UDT_DAL.ConvertTouddInsertGeneralAdvice(lstPatientAdvice);
            DataTable VACC = new DataTable();
            VACC = UDT_DAL.ConvertToANCVaccincation(pVaccination);

            SqlCommand cmdComplaint = new SqlCommand();
          
            SqlCommand cmdExam = new SqlCommand();
            SqlCommand cmdComp = new SqlCommand();
            SqlCommand cmdFet = new SqlCommand();
            SqlCommand cmdPatientAdvice = new SqlCommand();
            SqlCommand cmdPrescription = new SqlCommand();
            SqlCommand cmdVaccination = new SqlCommand();
            SqlCommand cmdPatientVisit = new SqlCommand();
            SqlCommand cmdANCPatienDetails = new SqlCommand();
            SqlCommand cmdANCScan = new SqlCommand();
            SqlCommand cmdAncObservation = new SqlCommand();

            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete = Command.pDeleteANCPatientDiagnoseCommand(patientID, patientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            cmdComplaint = Command.pInsertPatientComplaintCommand(pComplaint[0].PatientVisitID, pComplaint[0].ComplaintID, pComplaint[0].ComplaintName, pComplaint[0].Description, pComplaint[0].Query, pComplaint[0].Position, pComplaint[0].CreatedBy, pComplaint[0].ComplaintType, pComplaint[0].ICDCode, pComplaint[0].ICDDescription, pComplaint[0].ICDCodeStatus,pComplaint[0].OnBehalf,pComplaint[0].PhysicianComments,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            DataTable dtHistory = UDT_DAL.ConvertToHIDECType(lstPatientHistory);
            SqlCommand cmdHis = new SqlCommand();
            cmdHis = Command.pInsertANCPatientHistoryCommand(dtHistory,UDT_DAL.ConvertToUDT_Context(globalContextDetails));


            DataTable dtExam = UDT_DAL.ConvertToHIDECType(lstPatientExamination);
            cmdExam = Command.pInsertPatientExaminationCommand(dtExam,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            DataTable dtComp = UDT_DAL.ConvertToANCPatientComplication(lstPatientComplication);
            cmdComp = Command.pInsertANCPatientComplicationCommand(dtComp,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            DataTable dtFet = UDT_DAL.ConvertToANCPatientFetalFindings(lstPatientFetalFindings);
            cmdFet = Command.pInsertPatientFetalFindingsCommand(dtFet,UDT_DAL.ConvertToUDT_Context(globalContextDetails));


            cmdPatientAdvice = Command.pInsertGeneralAdviceCommand(dtPAdv,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPrescription = Command.pInsertPatientPrescriptionBulkCommand(drugDT,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdVaccination = Command.pInsertANCVaccincationCommand(VACC,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdANCPatienDetails = Command.pUpdateANCPatientforAdmissionCommand(pANCPatientDetails.PatientID, pANCPatientDetails.AdmissionSuggested, pANCPatientDetails.AdmissionSuggestedVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPatientVisit = Command.pInsertNextReviewDateCommand(pComplaint[0].PatientVisitID, entPatientVisit.NextReviewDate, entPatientVisit.AdmissionSuggested, entPatientVisit.PatientID,DateTime.Now,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdANCScan = Command.pInsertANCPatientforScanCommand(entANCScan.PatientVisitID, entANCScan.PatienID, entANCScan.ScanStatus,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdAncObservation = Command.pSaveANCPpatientObservationCommand(patientID, patientVisitID, orgID, OrgAddId, PatientObservation, LID, flag,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            SqlCommand cmdInvestigation = new SqlCommand();

            DataTable invs = UDT_DAL.ConvertToOrderedInvestigation(PatientInvestigationHL);
            cmdInvestigation = Command.pInsertOrderedInvestigationHosCommand(invs, orgID, out pOrderedInvCnt,
                out ret,"pending",UID,labno,"",DateTime.Now,UDT_DAL.ConvertToUDT_Context(globalContextDetails));  //cmdInvestigation = Command.pOrderedInvestigationProfileBulkHosCommand(invs, orgID, out ret,;
            cmdDelete.Parameters.Add("@Return", SqlDbType.Int);
            cmdDelete.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdHis.Parameters.Add("@Return", SqlDbType.Int);
            cmdHis.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdExam.Parameters.Add("@Return", SqlDbType.Int);
            cmdExam.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdComp.Parameters.Add("@Return", SqlDbType.Int);
            cmdComp.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdFet.Parameters.Add("@Return", SqlDbType.Int);
            cmdFet.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdPrescription.Parameters.Add("@Return", SqlDbType.Int);
            cmdPrescription.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdComplaint.Parameters.Add("@Return", SqlDbType.Int);
            cmdComplaint.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdVaccination.Parameters.Add("@Return", SqlDbType.Int);
            cmdVaccination.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdPatientAdvice.Parameters.Add("@Return", SqlDbType.Int);
            cmdPatientAdvice.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdANCPatienDetails.Parameters.Add("@Return", SqlDbType.Int);
            cmdANCPatienDetails.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdPatientVisit.Parameters.Add("@Return", SqlDbType.Int);
            cmdPatientVisit.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdANCScan.Parameters.Add("@Return", SqlDbType.Int);
            cmdANCScan.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdInvestigation.Parameters.Add("@Return", SqlDbType.Int);
            cmdInvestigation.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdAncObservation.Parameters.Add("@Return", SqlDbType.Int);
            cmdAncObservation.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;


            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbengine = new DBEngine(true))
                    {
                        if (flag == "UPD")
                        {
                            dbengine.ExecuteTransactionalNonQuery(cmdDelete);
                            returncode = Convert.ToInt64(cmdDelete.Parameters["@Return"].Value);
                        }
                        else
                        {
                            returncode = 0;
                        }
                        if (returncode == 0)
                        {
                            dbengine.ExecuteTransactionalNonQuery(cmdComplaint);
                            returncode = Convert.ToInt64(cmdComplaint.Parameters["@Return"].Value);
                            if (returncode == 0)
                            {
                                dbengine.ExecuteTransactionalNonQuery(cmdHis);
                                returncode = Convert.ToInt64(cmdHis.Parameters["@Return"].Value);
                                if (returncode == 0)
                                {
                                    dbengine.ExecuteTransactionalNonQuery(cmdExam);
                                    returncode = Convert.ToInt64(cmdExam.Parameters["@Return"].Value);
                                    if (returncode == 0)
                                    {
                                        dbengine.ExecuteTransactionalNonQuery(cmdComp);
                                        returncode = Convert.ToInt64(cmdComp.Parameters["@Return"].Value);
                                        if (returncode == 0)
                                        {
                                            dbengine.ExecuteTransactionalNonQuery(cmdFet);
                                            returncode = Convert.ToInt64(cmdFet.Parameters["@Return"].Value);
                                            if (returncode == 0)
                                            {
                                                dbengine.ExecuteTransactionalNonQuery(cmdPatientAdvice);
                                                returncode = Convert.ToInt64(cmdPatientAdvice.Parameters["@Return"].Value);
                                                if (returncode == 0)
                                                {
                                                    dbengine.ExecuteTransactionalNonQuery(cmdPrescription);
                                                    returncode = Convert.ToInt64(cmdExam.Parameters["@Return"].Value);
                                                    if (returncode == 0)
                                                    {
                                                        dbengine.ExecuteTransactionalNonQuery(cmdVaccination);
                                                        returncode = Convert.ToInt64(cmdVaccination.Parameters["@Return"].Value);
                                                        if (returncode == 0)
                                                        {
                                                            dbengine.ExecuteTransactionalNonQuery(cmdANCPatienDetails);
                                                            returncode = Convert.ToInt64(cmdANCPatienDetails.Parameters["@Return"].Value);
                                                            if (returncode == 0)
                                                            {
                                                                dbengine.ExecuteTransactionalNonQuery(cmdPatientVisit);
                                                                returncode = Convert.ToInt64(cmdPatientVisit.Parameters["@Return"].Value);
                                                                if (returncode == 0)
                                                                {
                                                                    dbengine.ExecuteTransactionalNonQuery(cmdANCScan);
                                                                    returncode = Convert.ToInt64(cmdANCScan.Parameters["@Return"].Value);
                                                                    if (returncode == 0)
                                                                    {
                                                                        dbengine.ExecuteTransactionalNonQuery(cmdAncObservation);
                                                                        returncode = Convert.ToInt64(cmdAncObservation.Parameters["@Return"].Value);
                                                                        if (returncode == 0)
                                                                        {
                                                                            dbengine.ExecuteTransactionalNonQuery(cmdInvestigation);
                                                                            returncode = Convert.ToInt64(cmdInvestigation.Parameters["@Return"].Value);
                                                                            pOrderedInvCnt = Convert.ToInt32(cmdInvestigation.Parameters["@pOrderedInvCnt"].Value);
                                                                            if (returncode == 0)
                                                                            {
                                                                                tranScope.Complete();
                                                                            }
                                                                            else
                                                                            {
                                                                                tranScope.Dispose();
                                                                            }
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        tranScope.Dispose();
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    tranScope.Dispose();
                                                                }
                                                            }
                                                            else
                                                            {
                                                                tranScope.Dispose();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            tranScope.Dispose();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        tranScope.Dispose();
                                                    }
                                                }
                                                else
                                                {
                                                    tranScope.Dispose();
                                                }
                                            }
                                            else
                                            {
                                                tranScope.Dispose();
                                            }
                                        }
                                        else
                                        {
                                            tranScope.Dispose();
                                        }
                                    }
                                    else
                                    {
                                        tranScope.Dispose();
                                    }
                                }
                                else
                                {
                                    tranScope.Dispose();
                                }
                            }
                            else
                            {
                                tranScope.Dispose();
                            }
                        }
                        else
                        {
                            tranScope.Dispose();
                        }
                    }
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Error in DAL saveHECFC", ex);
                    tranScope.Dispose();
                }
            }

            return returncode;
        }

        
    }
}
