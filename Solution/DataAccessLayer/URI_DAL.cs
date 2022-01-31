using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using System.Data.SqlClient;
using Attune.Podium.Common;
using System.Data.Common;
using System.Transactions;

namespace Attune.Solution.DAL
{
    public class URI_DAL
    {
        ContextDetails globalContextDetails;
        public URI_DAL()
        {
            
        }
        public URI_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetInvestigation(int complaintID,out List<Investigation> investigations)
        {
            long returnCode = -1;
            using (DBEngine dBEngine = new DBEngine())
            {
                DataSet ds = new DataSet();
                investigations = new List<Investigation>();
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetInvestigationCommand(complaintID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                returnCode = dBEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out investigations);
            }
            return returnCode;
        }

        public long GetHistory(int complaintID,int parentID, out List<History> histories)
        {
            long returnCode = -1;

            using (DBEngine dBEngine = new DBEngine())
            {
                DataSet ds = new DataSet();
                histories = new List<History>();
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetHistoryCommand(complaintID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                returnCode = dBEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out histories);
            }
         
            return returnCode;
        }

        public long GetHistoryByComplaintName(string complaintName, out int complaintID, out List<History> histories)
        {
            long returnCode = -1;
            using (DBEngine dBEngine = new DBEngine())
            {
                DataSet ds = new DataSet();
                histories = new List<History>();
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetHistoryByComplaintNameCommand(complaintName, out complaintID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                returnCode = dBEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out histories);
            }
            return returnCode;
        }

        public long GetExamination(int complaintID,int parentID,out List<Examination> examinations)
        {
            long returnCode = -1;
            using (DBEngine dBEngine = new DBEngine())
            {
                DataSet ds = new DataSet();
                examinations = new List<Examination>();
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetExaminationCommand(complaintID, parentID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                returnCode = dBEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out examinations);
            }
            return returnCode;
        }

        public long GetExamination(string examinationName, out List<Examination> examinations)
        {
            long returnCode = -1;
            using (DBEngine dBEngine = new DBEngine())
            {
                DataSet ds = new DataSet();
                examinations = new List<Examination>();
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetExaminationByNameCommand(examinationName,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                returnCode = dBEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out examinations);
            }
            return returnCode;
        }

        public long GetComplaint(string complaintName, out List<Complaint> complaints)
        {
            long returnCode = -1;
            using (DBEngine dBEngine = new DBEngine())
            {
                DataSet ds = new DataSet();
                complaints = new List<Complaint>();
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetComplaintByNameCommand(complaintName,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                returnCode = dBEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out complaints);
            }
            return returnCode;
        }

        public long GetHistory(string historyName, out List<History> histories)
        {
            long returnCode = -1;
            using (DBEngine dBEngine = new DBEngine())
            {
                DataSet ds = new DataSet();
                histories = new List<History>();
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetHistoryByNameCommand(historyName,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                returnCode = dBEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out histories);
            }
            return returnCode;
        }

        #region DrugPrescription

        public long GetComplaintDrugs(int complaintID, out List<Drugs> drugs)
        {
            long returnCode = -2;
            using (DBEngine dBEngine = new DBEngine())
            {
                DataSet ds = new DataSet();
                drugs = new List<Drugs>();
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetComplaintDrugsCommand(complaintID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                returnCode = dBEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out drugs);
            }
            return returnCode;
        }

        public long GetDrugFrequencies(out List<DrugFrequency> dFrequencies)
        {
            long returnCode = -2;
            using (DBEngine dBEngine = new DBEngine())
            {

                DataSet ds = new DataSet();
                dFrequencies = new List<DrugFrequency>();
                SqlCommand cmd = new SqlCommand();
                returnCode = dBEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out dFrequencies);
            }
            return returnCode;
        }        

        public long GetDrugNames(string drugName, int count, out List<string> drugNames)
        {
            long returnCode = -1;
            
            DataSet ds = new DataSet();
            drugNames = new List<String>();
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pGetDrugNamesCommand(drugName, count,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dBEngine = new DBEngine(false))
            {
                returnCode = dBEngine.ExecuteReader(cmd, "DrugName", out drugNames);
            }
            
            return returnCode;

        }

        public long GetDrugID(string drugName,out long drugID)
        {
            long returnCode = -1;
            drugID = 0;
            DataSet ds = new DataSet();
            drugID = 0;
            
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pGetDrugIDCommand(drugName,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dBEngine = new DBEngine(false))
            {
                returnCode = dBEngine.ExecuteReader(cmd, "DrugID", out drugID);
            }

            return returnCode;

        }

        

       

        #endregion

        #region UnFound Diagnosis

        public long SaveUnFoundDiagnosisData(int complaintID, string admission, long patientID,
                                                  string nextReviewDate, long visitID,
                                              List<PatientComplaint> lstPatientComplaint, List<PatientHistory> lstHistory,
                                              List<PatientExamination> lstExamination, List<OrderedInvestigations> lstInv,
                                              List<DrugDetails> lstdrugs, List<PatientAdvice> lstAdvice,
                                              List<PatientVitals> lstPatientVitals,

                                              long OrgID,
                                              out int pOrderedInvCnt, string paymentstatus, string UID, string PhysicianComments)
        {
            long returnCode = -1;
            int ret = -1;
            string labno = "";
            pOrderedInvCnt = 0;


            DataTable drugDT = new DataTable();
            DataTable dtPAdv = new DataTable();
         
            drugDT = UDT_DAL.ConvertToPrescriptionType(lstdrugs, 0);
            dtPAdv = UDT_DAL.ConvertTouddInsertGeneralAdvice(lstAdvice);



            DataTable dtlComplaint = UDT_DAL .ConvertToUDTPatientComplaintIP (lstPatientComplaint);
            DataTable dtlExamination = UDT_DAL .ConvertToHIDECType (lstExamination);
            DataTable dtlHistory = UDT_DAL .ConvertToHIDECType (lstHistory);
            DataTable dtlInv = UDT_DAL .ConvertToOrderedInvestigation (lstInv);
            SqlCommand cmdPatVitals = new SqlCommand();
            SqlCommand cmdDelete = new SqlCommand();
            SqlCommand cmdComplaint = new SqlCommand();
            SqlCommand cmdPrescription = new SqlCommand();
            SqlCommand cmdHistory = new SqlCommand();
            SqlCommand cmdExam = new SqlCommand();
            SqlCommand cmdInvestigation = new SqlCommand();
            SqlCommand cmdPatientVisit = new SqlCommand();
            SqlCommand cmdPatientAdvice = new SqlCommand();
            SqlCommand cmdPhyComments = new SqlCommand();
            cmdDelete = Command.pDeletePatientDiagnoseDetailCommand(complaintID, visitID, "Remove",UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            DataTable dtvitals = UDT_DAL.ConvertToPatientVitals(lstPatientVitals);
            cmdPatVitals = Command.pInsPatientVitalsByPhysicianCommand(OrgID, dtvitals,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            cmdComplaint = Command.pInsertPatientComplaintsCommand(dtlComplaint,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdHistory = Command.pInsertUnfoundHistoryCommand(dtlHistory,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdExam = Command.pInsertUnfoundExaminationCommand(dtlExamination,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdInvestigation = Command.pInsertOrderedInvestigationHosCommand(dtlInv, OrgID, out pOrderedInvCnt, out ret, paymentstatus, UID, labno, "", DateTime.Now,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPrescription = Command.pInsertPatientPrescriptionBulkCommand(drugDT,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPatientVisit = Command.pInsertNextReviewDateCommand(visitID, nextReviewDate, admission, patientID, DateTime.Now,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPatientAdvice = Command.pInsertGeneralAdviceCommand(dtPAdv,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPhyComments = Command.pinsertPhysicianCommentsCommand(visitID,PhysicianComments,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPatVitals.Parameters.Add("@Return", SqlDbType.Int);
            cmdPatVitals.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdComplaint.Parameters.Add("@Return", SqlDbType.Int);
            cmdComplaint.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdHistory.Parameters.Add("@Return", SqlDbType.Int);
            cmdHistory.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdExam.Parameters.Add("@Return", SqlDbType.Int);
            cmdExam.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdPatientVisit.Parameters.Add("@Return", SqlDbType.Int);
            cmdPatientVisit.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdPatientAdvice.Parameters.Add("@Return", SqlDbType.Int);
            cmdPatientAdvice.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;



                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        returnCode = dbEngine.ExecuteNonQuery(cmdDelete);

                        dbEngine.ExecuteNonQuery(cmdComplaint);
                        returnCode = Convert.ToInt64(cmdComplaint.Parameters["@Return"].Value);




                        if (returnCode == 0)
                        {
                            if (dtvitals.Rows.Count > 0)
                            {
                                dbEngine.ExecuteNonQuery(cmdPatVitals);
                                returnCode = Convert.ToInt64(cmdPatVitals.Parameters["@Return"].Value);
                            }
                            if (dtlHistory.Rows.Count > 0)
                            {
                                dbEngine.ExecuteNonQuery(cmdHistory);
                                returnCode = Convert.ToInt64(cmdHistory.Parameters["@Return"].Value);
                            }

                            if (dtlExamination.Rows.Count > 0)
                            {
                                dbEngine.ExecuteNonQuery(cmdExam);
                                returnCode = Convert.ToInt64(cmdExam.Parameters["@Return"].Value);
                            }
                            if (dtlInv.Rows.Count > 0)
                            {
                                dbEngine.ExecuteNonQuery(cmdInvestigation);
                                ret = Convert.ToInt32(cmdInvestigation.Parameters["@returnstatus"].Value.ToString());
                                pOrderedInvCnt = Convert.ToInt32(cmdInvestigation.Parameters["@pOrderedInvCnt"].Value.ToString());
                                returnCode = ret;
                            }
                            if (drugDT.Rows.Count > 0)
                            {
                                dbEngine.ExecuteNonQuery(cmdPrescription);
                                returnCode = Convert.ToInt64(cmdExam.Parameters["@Return"].Value);
                            }
                            if (dtPAdv.Rows.Count > 0)
                            {
                                dbEngine.ExecuteNonQuery(cmdPatientAdvice);
                                returnCode = Convert.ToInt64(cmdPatientAdvice.Parameters["@Return"].Value);
                            }
                            dbEngine.ExecuteNonQuery(cmdPatientVisit);
                            returnCode = Convert.ToInt64(cmdPatientVisit.Parameters["@Return"].Value);
                            dbEngine.ExecuteNonQuery(cmdPhyComments);
                         

                        }


                    }
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Exception while saving HIE data.", ex);
                }

            return returnCode;
        }

        #endregion





        public long SaveHIE(List<PatientComplaint> pComplaint, List<PatientHistory> pHistory, List<OrderedInvestigations> pInvestigationHL,
            List<PatientExamination> pExamination, List<DrugDetails> drgList, PatientVisit entPatientVisit, List<PatientAdvice> lstPatientAdvice,
            List<PatientVitals> lstPatientVitals, List<BackgroundProblem> pBgP, long orgID, string gUID)
        {
            long returnCode = -1;
            int ret = -1;
            int pOrderedInvCnt=-1;
            string labno = string.Empty;
            string paymentstatus="pending";
            DataTable drugDT = new DataTable();
            DataTable dtPAdv = new DataTable();
            DataTable complaintDT = new DataTable();
            DataTable dtVitals = new DataTable();

            drugDT = UDT_DAL.ConvertToPrescriptionType(drgList, pComplaint[0].ComplaintID);
            dtPAdv = UDT_DAL.ConvertTouddInsertGeneralAdvice(lstPatientAdvice);

            DataTable history = UDT_DAL .ConvertToHIDECType(pHistory);
            DataTable exam = UDT_DAL.ConvertToHIDECType(pExamination);
            DataTable dtPatientVitals =UDT_DAL .ConvertToPatientVitals (lstPatientVitals);
            DataTable dtPBgP = UDT_DAL .ConvertToHIDECType (pBgP);
            DataTable invs = UDT_DAL .ConvertToOrderedInvestigation (pInvestigationHL);
            SqlCommand cmdPatVitals = new SqlCommand();

            SqlCommand cmdComplaint = new SqlCommand();
            SqlCommand cmdPrescription = new SqlCommand();
            SqlCommand cmdHistory = new SqlCommand();
            SqlCommand cmdExam = new SqlCommand();
            SqlCommand cmdInvestigation = new SqlCommand();
            SqlCommand cmdPatientVisit = new SqlCommand();
            SqlCommand cmdPatientAdvice = new SqlCommand();
            SqlCommand cmdPatientBgP = new SqlCommand();

            cmdPatVitals = Command.pInsPatientVitalsByPhysicianCommand(orgID, dtPatientVitals,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdComplaint = Command.pInsertPatientComplaintCommand(pComplaint[0].PatientVisitID, pComplaint[0].ComplaintID, pComplaint[0].ComplaintName, pComplaint[0].Description, pComplaint[0].Query, pComplaint[0].Position, pComplaint[0].CreatedBy, pComplaint[0].ComplaintType, pComplaint[0].ICDCode, pComplaint[0].ICDDescription, pComplaint[0].ICDCodeStatus,pComplaint[0].OnBehalf,pComplaint[0].PhysicianComments ,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdHistory = Command.pInsertPatientHistoryCommand(history,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdExam = Command.pInsertPatientExaminationCommand(exam,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            cmdInvestigation = Command.pInsertOrderedInvestigationHosCommand(invs, orgID, out pOrderedInvCnt, out ret, paymentstatus, gUID,labno,"",DateTime.Now,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPrescription = Command.pInsertPatientPrescriptionBulkCommand(drugDT,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPatientVisit = Command.pInsertNextReviewDateCommand(pComplaint[0].PatientVisitID, entPatientVisit.NextReviewDate, entPatientVisit.AdmissionSuggested, entPatientVisit.PatientID,DateTime.Now,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPatientAdvice = Command.pInsertGeneralAdviceCommand(dtPAdv,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPatientBgP = Command.pInsertBackgroundProblemsCommand(dtPBgP,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            

            cmdPatVitals.Parameters.Add("@Return", SqlDbType.Int); 
            cmdPatVitals.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            cmdHistory.Parameters.Add("@Return", SqlDbType.Int);
            cmdHistory.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            cmdExam.Parameters.Add("@Return", SqlDbType.Int);
            cmdExam.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            cmdPrescription.Parameters.Add("@Return", SqlDbType.Int);
            cmdPrescription.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            cmdComplaint.Parameters.Add("@Return", SqlDbType.Int);
            cmdComplaint.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            cmdPatientVisit.Parameters.Add("@Return", SqlDbType.Int);
            cmdPatientVisit.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            cmdPatientAdvice.Parameters.Add("@Return", SqlDbType.Int);
            cmdPatientAdvice.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            cmdPatientBgP.Parameters.Add("@pReturnStatus", SqlDbType.Int);
            cmdPatientBgP.Parameters["@pReturnStatus"].Direction = ParameterDirection.ReturnValue;


            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmdComplaint);
                        returnCode = Convert.ToInt64(cmdComplaint.Parameters["@Return"].Value);
                        if (returnCode == 0)
                        {
                            if (dtPatientVitals.Rows.Count > 0)
                            {
                                dbEngine.ExecuteTransactionalNonQuery(cmdPatVitals);
                                returnCode = Convert.ToInt64(cmdPatVitals.Parameters["@Return"].Value);
                            }

                            dbEngine.ExecuteTransactionalNonQuery(cmdHistory);
                            returnCode = Convert.ToInt64(cmdHistory.Parameters["@Return"].Value);

                            if (returnCode == 0)
                            {
                                dbEngine.ExecuteTransactionalNonQuery(cmdExam);
                                returnCode = Convert.ToInt64(cmdExam.Parameters["@Return"].Value);
                                if (returnCode == 0)
                                {
                                    dbEngine.ExecuteTransactionalNonQuery(cmdInvestigation);
                                    ret = Convert.ToInt16(cmdInvestigation.Parameters["@returnstatus"].Value.ToString());
                                    returnCode = ret;
                                    if (returnCode == 0)
                                    {
                                        dbEngine.ExecuteTransactionalNonQuery(cmdPrescription);
                                        returnCode = Convert.ToInt64(cmdExam.Parameters["@Return"].Value);
                                        if (returnCode == 0)
                                        {
                                            dbEngine.ExecuteTransactionalNonQuery(cmdPatientVisit);
                                            returnCode = Convert.ToInt64(cmdPatientVisit.Parameters["@Return"].Value);
                                            if (returnCode == 0)
                                            {
                                                dbEngine.ExecuteTransactionalNonQuery(cmdPatientAdvice);
                                                returnCode = Convert.ToInt64(cmdPatientAdvice.Parameters["@Return"].Value);
                                                if (returnCode == 0)
                                                {
                                                    dbEngine.ExecuteTransactionalNonQuery(cmdPatientBgP);
                                                    returnCode = Convert.ToInt64(cmdPatientBgP.Parameters["@pReturnStatus"].Value);
                                                    if (returnCode == 0)
                                                    {
                                                        tranScope.Complete();
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
                                        else { tranScope.Dispose(); }
                                    }
                                    else { tranScope.Dispose(); }

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
                catch(Exception ex)
                {
                    CLogger.LogError("Exception while saving HIE data.", ex);
                    tranScope.Dispose();
                }

            }
            return returnCode;
        }

         

       public long SavePatientHistory(DataTable hist)
        {
            long returncode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pInsertPatientHistoryBulkCommand(hist,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine(false))
            {
                returncode = dBEngine.ExecuteNonQuery(cmd);
            }

            return returncode;
        }



       public long SavePatientExamination(List<PatientExamination> pExamination)
       {

           long lResult = -1;
           DataTable exam = UDT_DAL .ConvertToHIDECType(pExamination);
          SqlCommand cmd = Command.pInsertPatientExaminationCommand(exam,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
           cmd.Parameters.Add("@Return", SqlDbType.Int);
           cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
           using (DBEngine dbEngine = new DBEngine(false))
           {
               dbEngine.ExecuteNonQuery(cmd);
               lResult = Convert.ToInt16(cmd.Parameters["@Return"].Value.ToString());
           }

           return lResult;
       }
        

        public long SaveDiagnose(string complaintdesc,string examDesc,string historyDesc,long visitID,int invID,long createdBy)
        {
            long returnCode = -1;

            return returnCode;

        }

        public long SavePrescription(long visitID,long drugID,string frqID,string duration,long createdBy)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
          
            using (DBEngine dBEngine = new DBEngine(false))
            {
               
            }

            return returnCode;

        }

        public long SavePrescription(List<DrugDetails> Pres, List<DrugDetails> adminedPrescription)
        {
            long returnCode = -1;

            try
            {
        
                DataTable DtPresc = UDT_DAL .ConvertToPrescriptionDrugType (Pres);
                DataTable DtAdminedPresc =UDT_DAL .ConvertToPrescriptionDrugType (adminedPrescription);
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pInsertPatientPrescriptionDrugCommand(DtPresc, DtAdminedPresc,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dBEngine = new DBEngine(false))
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                }

               
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL SavePrescription", ex);
            }
            
            
            return returnCode;

        }

        public long UpdatePrescription(List<DrugDetails> UpdatePrescription)
        {
            long returnCode = -1;

            try
            {
                DataTable DtUpdatePresc = UDT_DAL.ConvertToPrescriptionDrugType(UpdatePrescription);
                SqlCommand cmdUpdate = new SqlCommand();
                cmdUpdate = Command.pUpdatePatientPrescriptionDrugCommand(DtUpdatePresc,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dBEngine = new DBEngine(false))
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmdUpdate);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL UpdatePrescription", ex);
            }


            return returnCode;

        }

        public long DeletePatientDiagnoseDetail(int complaintID, long patientVisitID, string rmvPres)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pDeletePatientDiagnoseDetailCommand(complaintID, patientVisitID, rmvPres,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while deleting patient diagnose details", ex);
            }
            return returnCode;
        }


        public long GetSearchPatientPrescription(long VisitID, long pLID, long pRID, out List<DrugDetails> lstPrescription, out List<DrugDetails> lstAdminsteredDrugs)
        {
            long returnCode = -1;
            using (DBEngine dBEngine = new DBEngine())
            {
                DataSet ds = new DataSet();
                lstPrescription = new List<DrugDetails>();
                lstAdminsteredDrugs = new List<DrugDetails>();

                SqlCommand cmd = new SqlCommand();
                cmd = Command.pSearchPatientPrescriptionCommand(VisitID, pLID, pRID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                returnCode = dBEngine.ExecuteDataSet(cmd, out ds);
                
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPrescription);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstAdminsteredDrugs);
                }
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

            DataSet ds = new DataSet();
            SqlCommand cmd = Command.pGetDiagnosePageDataCommand(complaintID, out complaintName,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                complaintName = cmd.Parameters["@pComplaintName"].Value.ToString();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstExamination);
                }

                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstHistory);
                }

                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstInvestigation);
                }
            }

            return returnCode;
        }
        public long InsertPatientPrescriptionBulk(List<DrugDetails> drgList)
        {
            long returnCode = -1;
            DataTable drugDT = new DataTable();
            drugDT = UDT_DAL.ConvertToPrescriptionType(drgList, 0);

            SqlCommand cmdPrescription = new SqlCommand();

            cmdPrescription = Command.pInsertPatientPrescriptionBulkCommand(drugDT,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPrescription.Parameters.Add("@Return", SqlDbType.Int);
            cmdPrescription.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteTransactionalNonQuery(cmdPrescription);
                returnCode = Convert.ToInt64(cmdPrescription.Parameters["@Return"].Value);
            }

            return returnCode;
        }






    }
}
