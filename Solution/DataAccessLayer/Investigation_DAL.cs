using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using Attune.Podium.BusinessEntities.CustomEntities;
using System.Collections.Generic;
using Attune.Podium.Common;
using System.Data.Common;
using System.Transactions;
using System.IO;

namespace Attune.Solution.DAL
{
    public class Investigation_DAL
    {
        ContextDetails globalContextDetails;
        public Investigation_DAL()
        {

        }
        public Investigation_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        #region NotInUse



        #endregion

        public long SaveReFlexItemBilling(List<InvestigationQueue> InvQueue, long OrgID, out List<FinalBill> lstFinalBill, ContextDetails Context)
        {
            int ret = -1;
            long retCode = -1;
            DataTable invs = UDT_DAL.ConvertToInvestigationQueue(InvQueue);
            SqlCommand cmdInvQueue = new SqlCommand();
            lstFinalBill = new List<FinalBill>();
            DataSet ds = new DataSet();
            cmdInvQueue = Command.pInsertReFlexItemBillingCommand(invs, OrgID, UDT_DAL.ConvertToUDT_Context(Context));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {

                    retCode = dbEngine.ExecuteDataSet(cmdInvQueue, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    retCode = Utilities.ConvertTo(ds.Tables[0], out lstFinalBill);
                }

            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving OrderedInvestigation investigation_DAL", e);
            }
            return retCode;

        }
        public long SavePatientInvestigation(List<PatientInvestigation> PatientInvestigation, long OrgID, string gUID, out int pOrderedInvCnt)
        {
            int ret = -1;
            long retCode = -1;
            pOrderedInvCnt = 0;
            SqlCommand cmdInvestigation = new SqlCommand();
            DataTable invs = UDT_DAL.ConvertToPatientInvestigation(PatientInvestigation);
            cmdInvestigation = Command.pInsertInvestigationCommand(invs, OrgID, gUID, out pOrderedInvCnt, out ret, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInvestigation);
                    retCode = Convert.ToInt32(cmdInvestigation.Parameters["@returnstatus"].Value);
                    pOrderedInvCnt = Convert.ToInt32(cmdInvestigation.Parameters["@pOrderedInvCnt"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving PatientInvestigation investigation_DAL", e);
            }
            return retCode;

        }



        #region UnfoundDiagnosis

        public long SavePatientHistory(List<PatientHistory> lstPatientHistory,
            List<BackgroundProblem> lstBackground,
            List<PatientComplaint> lstPatientComplaint,
            List<PatientAdvice> lstAdvice,
            List<PatientExamination> lstPatientExamination,
            List<PatientPrescription> lstPrescription)
        {
            long lresult = -1;
            int returnStatus;
            try
            {
                DataTable dtPrescription = UDT_DAL.ConvertToPrescriptionType(lstPrescription);
                DataTable history = UDT_DAL.ConvertToHIDECType(lstPatientHistory);
                DataTable exam = UDT_DAL.ConvertToHIDECType(lstPatientExamination);
                DataTable Background = UDT_DAL.ConvertToHIDECType(lstBackground);
                SqlCommand cmdPrescription = new SqlCommand();
                SqlCommand cmdInsertHistory = new SqlCommand();
                SqlCommand cmdInsertBackground = new SqlCommand();
                SqlCommand cmdInsertExam = new SqlCommand();
                SqlCommand cmdInsertPatientComplaint = new SqlCommand();
                SqlCommand cmdInsertAdvice = new SqlCommand();


                cmdPrescription = Command.pInsertPatientPrescriptionBulkCommand(dtPrescription, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                cmdInsertPatientComplaint = Command.pInsertPatientComplaintCommand(lstPatientComplaint[0].PatientVisitID, lstPatientComplaint[0].ComplaintID, lstPatientComplaint[0].ComplaintName, lstPatientComplaint[0].Description, lstPatientComplaint[0].Query, lstPatientComplaint[0].Position, lstPatientComplaint[0].CreatedBy, lstPatientComplaint[0].ComplaintType, lstPatientComplaint[0].ICDCode, lstPatientComplaint[0].ICDDescription, lstPatientComplaint[0].ICDCodeStatus, lstPatientComplaint[0].OnBehalf, lstPatientComplaint[0].PhysicianComments, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                cmdInsertPatientComplaint.Parameters.Add("@Return", SqlDbType.Int);
                cmdInsertPatientComplaint.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
                cmdInsertAdvice = Command.pInsertPatientAdviceCommand(lstAdvice[0].PatientVisitID, lstAdvice[0].Description, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                cmdInsertHistory = Command.pInsertPatientHistoryCommand(history, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                cmdInsertExam = Command.pInsertPatientExaminationCommand(exam, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                cmdInsertBackground = Command.pInsertBackgroundProblemsCommand(Background, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                cmdInsertHistory.Parameters.Add("@Return", SqlDbType.Int);
                cmdInsertHistory.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
                cmdInsertExam.Parameters.Add("@Return", SqlDbType.Int);
                cmdInsertExam.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
                cmdInsertBackground.Parameters.Add("@pReturnStatus", SqlDbType.Int);
                cmdInsertBackground.Parameters["@pReturnStatus"].Direction = ParameterDirection.ReturnValue;

                using (TransactionScope tranScope = new TransactionScope())
                {
                    try
                    {
                        using (DBEngine dbEngine = new DBEngine(true))
                        {
                            dbEngine.ExecuteTransactionalNonQuery(cmdInsertPatientComplaint);
                            lresult = Convert.ToInt64(cmdInsertPatientComplaint.Parameters["@Return"].Value);
                            if (lresult == 0)
                            {
                                dbEngine.ExecuteTransactionalNonQuery(cmdInsertAdvice);
                                lresult = Convert.ToInt64(cmdInsertAdvice.Parameters["@pReturnStatus"].Value);
                                if (lresult == 1)
                                {

                                    dbEngine.ExecuteTransactionalNonQuery(cmdInsertBackground);
                                    lresult = Convert.ToInt64(cmdInsertBackground.Parameters["@pReturnStatus"].Value);
                                    if (lresult == 0)
                                    {
                                        dbEngine.ExecuteTransactionalNonQuery(cmdInsertHistory);
                                        lresult = Convert.ToInt64(cmdInsertHistory.Parameters["@Return"].Value);
                                        if (lresult == 0)
                                        {
                                            dbEngine.ExecuteTransactionalNonQuery(cmdInsertExam);
                                            lresult = Convert.ToInt64(cmdInsertExam.Parameters["@Return"].Value);

                                            if (lresult == 0)
                                            {
                                                lresult = dbEngine.ExecuteNonQuery(cmdPrescription);
                                            }
                                            else
                                            { tranScope.Dispose(); }
                                        }
                                        else
                                        { tranScope.Dispose(); }
                                    }
                                    else
                                    { tranScope.Dispose(); }

                                }
                                else
                                { tranScope.Dispose(); }

                            }
                            else
                            { tranScope.Dispose(); }
                            tranScope.Complete();
                        }

                    }
                    catch (Exception ex)
                    {
                        tranScope.Dispose();
                    }
                }
            }





            catch (Exception ex)
            {
                CLogger.LogError("Error while saving patient history.", ex);
            }

            return lresult;

        }











        #endregion
        public long GetPatientDueStatus(string PatientNumber, long PatientID, long PatientVisitID, long OrgId, long LocationID, long ClientID, out decimal DueAmount)
        {
            long returnCode = -1;
            DueAmount = -1;
            try
            {
                SqlCommand cmd = Command.pGetCheckPatientDueStatusCommand(PatientNumber, PatientID, PatientVisitID, OrgId, LocationID, ClientID, out DueAmount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    DueAmount = Convert.ToDecimal(cmd.Parameters["@DueAmount"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetPatientDueStatus in IntegrationDAL", ex);
            }

            return returnCode;
        }


        public long getCaseSheetDetails(long patientVisitId, out List<PatientHistory> lstPatientHistory,
                                                            out List<PatientExamination> lstPatientExamination,
                                                            out List<PatientComplaint> lstPatientComplaint,
                                                            out List<Patient> lstpatientDetail,
                                                            out List<Advice> lstAdvice,
                                                            out List<PatientPrescription> lstPatientPrescription,
                                                            out List<PatientInvestigation> lstPatientInvestigation,
                                                            out List<PatientComplaint> lstPhysicianComments)
        {
            long lResult = -1;
            lstPatientHistory = new List<PatientHistory>();
            lstPatientExamination = new List<PatientExamination>();
            lstPatientComplaint = new List<PatientComplaint>();
            lstpatientDetail = new List<Patient>();
            lstAdvice = new List<Advice>();
            lstPatientPrescription = new List<PatientPrescription>();
            lstPatientInvestigation = new List<PatientInvestigation>();
            lstPhysicianComments = new List<PatientComplaint>();


            try
            {
                SqlCommand cmd = Command.pGetCaseSheetDetailsCommand(patientVisitId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine(false))
                {

                    lResult = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0) // History
                {
                    lResult = Utilities.ConvertTo(ds.Tables[0], out lstPatientHistory);
                }

                if (ds.Tables[1].Rows.Count > 0) // Examination 
                {
                    lResult = Utilities.ConvertTo(ds.Tables[1], out lstPatientExamination);
                }

                if (ds.Tables[2].Rows.Count > 0) //Complaint
                {
                    lResult = Utilities.ConvertTo(ds.Tables[2], out lstPatientComplaint);
                }

                if (ds.Tables[3].Rows.Count > 0) // Patient Details
                {
                    lResult = Utilities.ConvertTo(ds.Tables[3], out lstpatientDetail);
                }

                if (ds.Tables[4].Rows.Count > 0) // Patient Advice
                {
                    lResult = Utilities.ConvertTo(ds.Tables[4], out lstAdvice);
                }
                if (ds.Tables[5].Rows.Count > 0) //patient treatment
                {
                    lResult = Utilities.ConvertTo(ds.Tables[5], out lstPatientPrescription);
                }
                if (ds.Tables[6].Rows.Count > 0) //Patient Investigation
                {
                    lResult = Utilities.ConvertTo(ds.Tables[6], out lstPatientInvestigation);
                }
                if (ds.Tables[7].Rows.Count > 0) //Physician Comments 
                {
                    lResult = Utilities.ConvertTo(ds.Tables[7], out  lstPhysicianComments);
                }
            }

            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getCasesheetdetails DAL", ex);
            }

            return lResult;
        }


        public long getPrintPrescription(long patientVisitId, string pPrescriptionNo, out List<Patient> lstpatientDetail,
                                                              out List<Physician> lstPhysician,
                                                              out List<PatientPrescription> lstPatientPrescription)
        {
            long lResult = -1;

            lstpatientDetail = new List<Patient>();
            lstPhysician = new List<Physician>();
            lstPatientPrescription = new List<PatientPrescription>();


            try
            {
                SqlCommand cmd = Command.pGetPrintPrescriptionCommand(patientVisitId, pPrescriptionNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine(false))
                {

                    lResult = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0) // History
                {
                    lResult = Utilities.ConvertTo(ds.Tables[0], out lstpatientDetail);
                }

                if (ds.Tables[1].Rows.Count > 0) // Examination 
                {
                    lResult = Utilities.ConvertTo(ds.Tables[1], out lstPhysician);
                }

                if (ds.Tables[2].Rows.Count > 0) //Complaint
                {
                    lResult = Utilities.ConvertTo(ds.Tables[2], out lstPatientPrescription);
                }


            }

            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getCasesheetdetails DAL", ex);
            }

            return lResult;
        }


        public long GetInvestigationResults(long patientVisitId, out List<InvestigationValues> lstInvestigationValues, out List<InvestigationDisplayName> lstDisplayName, out List<PatientInvSampleResults> lstPatientInvSampleResults)
        {

            lstInvestigationValues = new List<InvestigationValues>();
            lstDisplayName = new List<InvestigationDisplayName>();
            lstPatientInvSampleResults = new List<PatientInvSampleResults>();

            int pResultstatus = 0;
            long lresult = -1;
            DataSet dataSet = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetInvestigationDisplayValuesCommand(patientVisitId, out pResultstatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out dataSet);
                    lresult = Convert.ToInt64(cmd.Parameters["@pReturnStatus"].Value);
                }
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(dataSet.Tables[0], out lstInvestigationValues);
                }

                if (dataSet.Tables[1].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(dataSet.Tables[1], out lstDisplayName);
                }

                if (dataSet.Tables[2].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(dataSet.Tables[2], out lstPatientInvSampleResults);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Sql", ex);
            }

            return lresult;

        }



        #region Investigation Capture






        //public long GetInvBulkData(string guid, long InvestigationID, long patientVisitID, int orgID, int GroupID,
        //                             out List<InvestigationValues> lstBulkData
        //                             , out List<InvestigationValues> lstPendingValues
        //                             , out List<InvestigationStatus> header, out List<InvestigationOrgMapping> lstiom)
        //{
        //    long lresult = -1;
        //    int returnStatus = -1;
        //    lstBulkData = new List<InvestigationValues>();
        //    lstPendingValues = new List<InvestigationValues>();
        //    header = new List<InvestigationStatus>();
        //    lstiom = new List<InvestigationOrgMapping>();
        //    SqlCommand cmd = Command.pGetInvBulkDataCommand(guid, InvestigationID, patientVisitID, orgID, GroupID, returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        using (DBEngine dbEngine = new DBEngine())
        //        {
        //            dbEngine.ExecuteDataSet(cmd, out ds);
        //        }
        //        if (ds.Tables[0].Rows.Count > 0)
        //        {
        //            lresult = Utilities.ConvertTo(ds.Tables[0], out lstBulkData);
        //        }
        //        if (ds.Tables[1].Rows.Count > 0)
        //        {
        //            lresult = Utilities.ConvertTo(ds.Tables[1], out lstPendingValues);
        //        }
        //        if (ds.Tables[2].Rows.Count > 0)
        //        {
        //            lresult = Utilities.ConvertTo(ds.Tables[2], out header);
        //        }
        //        if (ds.Tables[3].Rows.Count > 0)
        //        {
        //            lresult = Utilities.ConvertTo(ds.Tables[3], out lstiom);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while executing GetDemoBulkData DAL", ex);
        //    }
        //    return lresult;
        //}

        #region BatchWise Enter result
        public long GetInvBulkData(string guid, long InvestigationID, long patientVisitID, int orgID, int GroupID, List<InvPackageMapping> lstInvPackageMapping,
                                  out List<InvestigationValues> lstBulkData
                                  , out List<InvestigationValues> lstPendingValues
                                  , out List<InvestigationStatus> header, out List<InvestigationOrgMapping> lstiom)
        {
            long lresult = -1;
            int returnStatus = -1;
            DataTable invPMDT = UDT_DAL.ConvertToUDTInvPackageMapping(lstInvPackageMapping);
            lstBulkData = new List<InvestigationValues>();
            lstPendingValues = new List<InvestigationValues>();
            header = new List<InvestigationStatus>();
            lstiom = new List<InvestigationOrgMapping>();
            SqlCommand cmd = Command.pGetInvBulkDataCommand(guid, InvestigationID, patientVisitID, orgID, GroupID, returnStatus, invPMDT, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstBulkData);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[1], out lstPendingValues);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[2], out header);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[3], out lstiom);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDemoBulkData DAL", ex);
            }
            return lresult;
        }



        #endregion

        public List<PatientInvestigation> GetInvestigationMethod(List<List<InvestigationValues>> lstValues)
        {
            PatientInvestigation Pat = null;
            List<PatientInvestigation> lstPatient = new List<PatientInvestigation>();

            for (int i = 0; i < lstValues.Count; i++)
            {
                foreach (InvestigationValues val in lstValues[i])
                {
                    if (val.Name == "Method")
                    {
                        Pat = new PatientInvestigation();
                        Pat.InvestigationID = Convert.ToInt32(val.InvestigationID);
                        Pat.InvestigationMethodID = Convert.ToInt32(val.Value);
                        Pat.PatientVisitID = val.PatientVisitID;
                        lstPatient.Add(Pat);
                    }
                }
            }

            return lstPatient;
        }




        #endregion

        public long GetInvestigationSample(long VID, out List<PatientInvestigation> lstInvestigation)
        {
            long lresult = -1;
            lstInvestigation = new List<PatientInvestigation>();
            IDataReader dataReader = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pGetInvestigationSampleCommand(VID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        lresult = Utilities.ConvertTo(dataReader, out lstInvestigation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationSample DAL" + cmd.CommandText, ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return lresult;
        }

        public long UpdateSampleCollected(List<PatientInvestigation> lstPatient, int filter, out int count)
        {
            long lresult = -1;
            count = 0;
            DataTable dtPatient = new DataTable();
            dtPatient = UDT_DAL.ConvertToPatientInvestigation(lstPatient);
            SqlCommand cmd = Command.pUpdatePatientInvStatusCommand(dtPatient, filter, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@pCount", SqlDbType.Int);
            cmd.Parameters["@pCount"].Direction = ParameterDirection.ReturnValue;


            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                    count = Convert.ToInt32(cmd.Parameters["@pCount"].Value);
                    lresult = 0;
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateSampleCollected DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }
        #region LabHome

        public long GetLabInvestigation(int OrgAddID, int OrgID, long RoleID, int currentPageNo, int PageSize,
            out List<PatientVisitDetails> lstPatient, out int totalRows, long lngSourceId,
           LoginDetail LDetail)
        {
            long lresult = -1;
            lstPatient = new List<PatientVisitDetails>();
            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
            SqlCommand cmd = Command.pGetLabInvestigationCommand(OrgAddID, OrgID, RoleID, currentPageNo,
                                                    PageSize, out totalRows, lngSourceId, DtLDetail, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
                        totalRows = Convert.ToInt32(cmd.Parameters["@totalRows"].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateSampleCollected DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }
        #endregion

        public long getPendingInvestigation(long patientId, out List<PendingInvestigation> lstPendingInvestigaion)
        {
            long lResult = -1;
            lstPendingInvestigaion = new List<PendingInvestigation>();

            SqlCommand cmd = Command.pGetPendingInvestigationCommand(patientId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lResult = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lResult = Utilities.ConvertTo(ds.Tables[0], out lstPendingInvestigaion);
                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getInvestigationId" + cmd.CommandText, ex);
            }

            return lResult;


        }

        public long GetReferedInvestigation(long patientVisitID, out List<Patient> lstPatient, out List<PatientHistory> lstPatientHistory,
                                              out List<PatientExamination> lstPatientExamination, out List<PatientComplaint> lstPatientComplaint,
                                              out List<Investigation> lstInvestigation, out List<Physician> lstPhysician)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            lstPatientComplaint = new List<PatientComplaint>();
            lstPatientExamination = new List<PatientExamination>();
            lstPatientHistory = new List<PatientHistory>();
            lstInvestigation = new List<Investigation>();
            lstPhysician = new List<Physician>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetReferedInvestigationCommand(patientVisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0) // Patient Detail
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
                    }

                    if (ds.Tables[1].Rows.Count > 0) // patient History Detail
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatientHistory);
                    }

                    if (ds.Tables[2].Rows.Count > 0) // patient Examination Detail
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatientExamination);
                    }

                    if (ds.Tables[3].Rows.Count > 0) // Patient complaint Detail
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[3], out lstPatientComplaint);
                    }

                    if (ds.Tables[4].Rows.Count > 0) // Patient Investigation Detail
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[4], out lstInvestigation);
                    }

                    if (ds.Tables[5].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[5], out lstPhysician);
                    }

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Refered investigation detail", ex);
            }
            return returnCode;
        }

        public long pUpdateInvSequence(DataTable dtSequence, int pOrgID, int pDptID)
        {

            long returnCode = -1;
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pUpdateInvSequenceCommand(dtSequence, pOrgID, pDptID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Refered count and Ordered count", ex);
            }

            return returnCode;
        }
        public long pUpdateGrpSequence(DataTable dtSequence, int pOrgID)
        {

            long returnCode = -1;
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pUpdateGrpDataCommand(dtSequence, pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Refered count and Ordered count", ex);
            }

            return returnCode;
        }
        public long GetReferedInvCount(long patientVisitID, out int referedCount, out int orderdCount)
        {
            referedCount = -1;
            orderdCount = -1;
            long returnCode = -1;
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetReferedInvCountCommand(patientVisitID, out referedCount, out orderdCount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    referedCount = Convert.ToInt32(cmd.Parameters["@pReferedCount"].Value);
                    orderdCount = Convert.ToInt32(cmd.Parameters["@pOderedCount"].Value);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Refered count and Ordered count", ex);
            }

            return returnCode;
        }




        public long GetInvesforApproval(int OrgID, out List<PatientVisitDetails> lstPatient)
        {
            long lresult = -1;
            lstPatient = new List<PatientVisitDetails>();
            SqlCommand cmd = Command.pGetApprovalCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateSampleCollected DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }
        public long GetInvforDept(int OrgID, out List<InvDeptMaster> lstDpt)
        {
            IDataReader dataReader = null;
            long lresult = -1;
            lstDpt = new List<InvDeptMaster>();
            SqlCommand cmd = null;
            try
            {
                cmd = Command.pGetDepartmentMasterCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        lresult = Utilities.ConvertTo(dataReader, out lstDpt);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvforDept investigationDAL" + cmd.CommandText, ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return lresult;
        }


        public long pGetInvDeptData(int OrgID, int DeptID, out List<InvestigationOrgMapping> lstDpt)
        {
            long lresult = -1;
            lstDpt = new List<InvestigationOrgMapping>();
            IDataReader dataReader = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pGetInvDeptDataCommand(OrgID, DeptID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        lresult = Utilities.ConvertTo(dataReader, out lstDpt);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Department DAL" + cmd.CommandText, ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return lresult;
        }

        public long pGetGrpData(int OrgID, int GroupID, out List<InvOrgGroup> lstGrp)
        {
            long lresult = -1;
            lstGrp = new List<InvOrgGroup>();
            IDataReader dataReader = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pGetSequenceGroupCommand(OrgID, GroupID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        lresult = Utilities.ConvertTo(dataReader, out lstGrp);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Sequence Group DAL" + cmd.CommandText, ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return lresult;
        }


        public long GetInvestigationReport(string patientName, DateTime fromDate, DateTime toDate, int orgID, out List<PatientVisitDetails> lstPatientVisitDetails)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetInvestigationReportCommand(patientName, fromDate, toDate, orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            lstPatientVisitDetails = new List<PatientVisitDetails>();

            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientVisitDetails);
            }
            return returnCode;
        }
        public long GetComplaintInvestigation(int complaintID, int orgID, out List<InvestigationMaster> lstInvesMaster, out List<PatientInvestigation> lstPatientInvestigationHL)
        {

            long returncode = -1;
            lstInvesMaster = null;
            lstPatientInvestigationHL = null;
            try
            {
                SqlCommand sqlCmd = Command.pGetComplaintInvestigationCommand(complaintID, orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteDataSet(sqlCmd, out ds);

                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstInvesMaster);
                } if (ds.Tables[1].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[1], out lstPatientInvestigationHL);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while excecuting GetComplaintInvestigation", ex);
            }
            return returncode;
        }





        #region Sample collection
        public long GetTAID(long RoleID, int OrgID, out List<TaskActions> lstTaskActions)
        {
            long returncode = -1;

            lstTaskActions = new List<TaskActions>();

            SqlCommand cmd = Command.pGetTAIDCommand(RoleID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returncode = Utilities.ConvertTo(ds.Tables[0], out lstTaskActions);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetTAID", ex);
            }

            return returncode;
        }



        public long updatePatientInvestigationStatus(long PatientVisitID, string Status, int DeptID, string SampleStatus, out int upIS)
        {
            long returncode = -1;
            upIS = -1;

            SqlCommand cmd = Command.pUpdatePatientInvestigationStatusCommand(PatientVisitID, Status, DeptID, SampleStatus, out upIS, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteNonQuery(cmd);
                    upIS = Convert.ToInt32(cmd.Parameters["@returnstatus"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL updatePatientInvestigationStatus", ex);
            }
            return returncode;
        }
        public long getSampleCollectionforDepartment(long RoleID, int OrgID, long PatientVisitID, int OrgAddressID, out List<PatientInvestigation> lstPatientInvestigation, out List<InvDeptMaster> lstDeptMaster, out List<PatientInvSample> lstPatientInvSample)
        {
            long returncode = -1;

            lstPatientInvestigation = new List<PatientInvestigation>();
            lstPatientInvSample = new List<PatientInvSample>();
            lstDeptMaster = new List<InvDeptMaster>();
            try
            {
                SqlCommand cmd = Command.pGetSamplesforDeptCommand(RoleID, OrgID, PatientVisitID, OrgAddressID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();

                using (DBEngine dbengine = new DBEngine())
                {
                    dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstPatientInvestigation);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[1], out lstPatientInvSample);
                }

                if (ds.Tables[2].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[2], out lstDeptMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL getSampleCollectionforDepartment", ex);
            }

            return returncode;
        }
        public long InsertSampleCollectfromDeptID(List<SampleTracker> lstSampleTracker)
        {
            long returncode = -1;

            DataTable dtSaveSampleTracker = new DataTable();

            dtSaveSampleTracker = UDT_DAL.ConvertToUDDinsertSampleTrack(lstSampleTracker);

            SqlCommand cmd = Command.pInsertSampleCollectionfromDeptIDCommand(dtSaveSampleTracker, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertSampleCollectfromDeptID", ex);
            }
            return returncode;
        }


        public long getDepartmentID(long RoleID, out List<InvDeptMaster> lstInvDeptMaster)
        {
            long returncode = -1;

            lstInvDeptMaster = new List<InvDeptMaster>();



            try
            {
                SqlCommand cmd = Command.pGetDepartmentIDCommand(RoleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();

                using (DBEngine dbengine = new DBEngine())
                {
                    dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstInvDeptMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL getDepartmentID", ex);
            }

            return returncode;
        }

        public long getInvOrgSampleStatus(int OrgID, string inStatus, out string outStatus)
        {
            long returncode = -1;

            SqlCommand cmd = Command.pGetInvOrgSampleStatusCommand(OrgID, inStatus, out outStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                    outStatus = cmd.Parameters["@pOutStatus"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL getInvOrgSampleStatus", ex);
            }

            return returncode;
        }

        #endregion
        public long GetInvestigationProfile(int orgID, string type, out List<PatientInvestigation> lstInvestigationProfiile)
        {
            long returnCode = -1;
            lstInvestigationProfiile = new List<PatientInvestigation>();
            SqlCommand cmd = Command.pGetInvestiagationprofileCommand(orgID, type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvestigationProfiile);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Investigation_dal in getInvestigationProfile", ex);
            }
            return returnCode;
        }


        public long GetInvestigationByOrgID(int OrgID, string Filtertext, out List<PatientInvestigation> lstInvestigation)
        {
            long returnCode = -1;
            lstInvestigation = new List<PatientInvestigation>();
            DataSet ds = new DataSet();
            try
            {

                SqlCommand cmd = Command.pGetInvestigationMasterCommand(OrgID, Filtertext, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvestigation);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("", ex);
            }
            return returnCode;
        }

        public long GetInvestigationByClientID(int OrgID, int clientID, string type, out List<PatientInvestigation> lstPatInv)
        {
            long returncode = -1;
            lstPatInv = new List<PatientInvestigation>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvestigationByClientIDCommand(clientID, OrgID, type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returncode = Utilities.ConvertTo(dataReader, out lstPatInv);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while excecuting investigation_dal in GetInvestigationByClientID", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returncode;

        }
        public long GetSurgeryByClientID(long lVisitID, int OrgID, int clientID, string type, out List<PatientInvestigation> lstPatInv)
        {
            long returncode = -1;
            lstPatInv = new List<PatientInvestigation>();

            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetSurgeryByClientIDCommand(lVisitID, clientID, OrgID, type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstPatInv);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while excecuting investigation_dal in GetInvestigationByClientID", ex);
            }
            return returncode;

        }


        public long GetInvestigation(int orgID, out List<PatientInvestigation> lstInvestigation)
        {
            long returncode = -1;
            lstInvestigation = null;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvestigationByOrgidCommand(orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returncode = Utilities.ConvertTo(dataReader, out lstInvestigation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while excecuting investigation_dal in GetInvestigationByClientID", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returncode;
        }


        public long GetInvestigationData(int orgID, int orgSpecific, out List<InvGroupMaster> lstGroup, out List<InvestigationMaster> lstInvestigations)
        {
            long returncode = -1;
            lstInvestigations = null;
            lstGroup = null;
            int rsCount = 0;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.PGetInvestigationDataCommand(orgID, orgSpecific, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returncode = Utilities.ConvertTo(dataReader, out lstGroup);
                            }
                            else if (rsCount == 1)
                            {
                                returncode = Utilities.ConvertTo(dataReader, out lstInvestigations);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while excecuting investigation_dal in GetInvestigationByClientID", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returncode;
        }


        public long GetInvestigationDatabyComplaint(int orgID, int orgSpecific, int complaintID, int clientID, out List<InvGroupMaster> lstGroup, out List<InvestigationMaster> lstInvestigations)
        {
            long returncode = -1;
            lstInvestigations = null;
            lstGroup = null;
            try
            {
                SqlCommand cmd = Command.PGetInvestigationByComplaintidCommand(orgID, orgSpecific, complaintID, clientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstGroup);
                }

                if (ds.Tables[1].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[1], out lstInvestigations);
                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while excecuting investigation_dal in GetInvestigationByClientID", ex);
            }
            return returncode;
        }
        public long GetOrderedInvestigation(int pOrgID, long patientVisitID, out List<OrderedInvestigations> lstOrderedInves, out List<OrderedInvestigations> oInvestigations)
        {
            long returnCode = -1;
            lstOrderedInves = new List<OrderedInvestigations>();
            oInvestigations = new List<OrderedInvestigations>();
            try
            {
                SqlCommand cmd = Command.pGetOrderedInvestigationsCommand(pOrgID, patientVisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrderedInves);

                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out oInvestigations);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while investigation dal", ex);

            }
            return returnCode;
        }

        public long getOrgClientID(long PatientVisitID, out long outStatus)
        {
            long returncode = -1;

            SqlCommand cmd = Command.pGetOrgClientIDCommand(PatientVisitID, out outStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                    outStatus = Convert.ToInt64(cmd.Parameters["@pOutStatus"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL getOrgClientID", ex);
            }
            return returncode;
        }

        public long getOrgClientName(int orgID, out List<InvClientMaster> lstClientname)
        {
            long returnCode = -1;
            lstClientname = new List<InvClientMaster>();
            try
            {
                SqlCommand cmd = Command.pGetOrgClientNameCommand(orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstClientname);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while investigation DAL ClientName", ex);
            }
            return returnCode;
        }
        public long getOrgTPAName(int orgID, out List<TPAMaster> lstTPAname)
        {
            long returnCode = -1;
            lstTPAname = new List<TPAMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetTPANameCommand(orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTPAname);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while investigation DAL TPAName", ex);
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

        public long getOrgDepartName(int orgID, out List<InvDeptMaster> lstDepname)
        {
            long returnCode = -1;
            lstDepname = new List<InvDeptMaster>();
            try
            {
                SqlCommand cmd = Command.pGetOrgDepartNameCommand(orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDepname);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while investigation DAL Department Name", ex);

            }
            return returnCode;
        }





        public long getOrgHeaderName(out  List<InvestigationHeader> lstHeader)
        {
            long returnCode = -1;
            lstHeader = new List<InvestigationHeader>();
            try
            {
                SqlCommand cmd = Command.pGetInvHeaderCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstHeader);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while investigation DAL HeaderName", ex);
            }
            return returnCode;
        }

        public long getInvGroupName(int orgID, out  List<InvGroupMaster> lstHeader)
        {
            long returnCode = -1;
            lstHeader = new List<InvGroupMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvGroupNameCommand(orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstHeader);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while investigation DAL GroupName", ex);

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


        public long GetInvForMDMAddInvAndGrp(int OrgID, string pType, out List<InvestigationMaster> lstInvNames)
        {
            long returnCode = -1;
            IDataReader dataReader = null;
            lstInvNames = new List<InvestigationMaster>();
            try
            {
                SqlCommand cmd = Command.pGetInvForMDMAddInvAndGrpCommand(OrgID, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvNames);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvForMDMAddInvAndGrp Investigation_DAL", e);
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

        public long GetInvForMDMAddInvAndNewGrp(int OrgID, string pType, out List<OrderedInvestigations> lstInvNames)
        {
            long returnCode = -1;
            lstInvNames = new List<OrderedInvestigations>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvForMDMAddInvAndGrpCommand(OrgID, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvNames);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvForMDMAddInvAndGrp Investigation_DAL", e);
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
        public long GetInvForMDMAddGrp(int OrgID, string pType, out List<InvGroupMaster> lstInvNames, out  List<OrderedInvestigations> grovalid)
        {
            long returnCode = -1;

            lstInvNames = new List<InvGroupMaster>();
            grovalid = new List<OrderedInvestigations>();
            IDataReader dataReader = null;
            int rsCount = 0;
            try
            {
                SqlCommand cmd = Command.pGetInvForMDMAddInvAndGrpCommand(OrgID, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvNames);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out grovalid);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvForMDMAddInvAndGrp Investigation_DAL", e);
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
        public long GetInvForMDMAddInv(int OrgID, string pType, out List<InvestigationOrgMapping> lstInvNames)
        {
            long returnCode = -1;

            IDataReader dataReader = null;
            lstInvNames = new List<InvestigationOrgMapping>();
            try
            {
                SqlCommand cmd = Command.pGetInvForMDMAddInvAndGrpCommand(OrgID, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvNames);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvForMDMAddInvAndGrp Investigation_DAL", e);
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
        public long GetInvForMDLoadInvInGrp(long OrgID, int GrpId, out List<InvestigationMaster> lstInvNames)
        {
            long returnCode = -1;
            lstInvNames = new List<InvestigationMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvForMDLoadInvInGrpCommand(OrgID, GrpId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvNames);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetInvForMDLoadInvInGrp Investigation_DAL", ex);
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
        public long GetInvForMDLoadInvGrpMAP(int OrgID, int GrpId, out List<OrderedInvestigations> lstInvNames, out string groupname)
        {
            long returnCode = -1;
            lstInvNames = new List<OrderedInvestigations>();
            IDataReader dataReader = null;
            groupname = string.Empty;
            try
            {
                SqlCommand cmd = Command.pgetGRPINVMAPCommand(OrgID, GrpId, out groupname, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvNames);
                        dataReader.Close();
                    }
                    groupname = Convert.ToString(cmd.Parameters["@groupname"].Value);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetInvForMDLoadInvInGrp Investigation_DAL", ex);
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

        public long GetInvForMDLoadInvInNewGrp(long OrgID, int GrpId, out List<OrderedInvestigations> lstInvNames)
        {
            long returnCode = -1;
            IDataReader dataReader = null;
            lstInvNames = new List<OrderedInvestigations>();
            try
            {
                SqlCommand cmd = Command.pGetInvForMDLoadInvInGrpCommand(OrgID, GrpId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvNames);
                        dataReader.Close();
                    }

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetInvestigationName DAL", ex);
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

        public long GetInvForMDMAddInvAndGrp(int OrgID, out List<InvestigationMaster> lstInvNames)
        {
            long returnCode = -1;
            IDataReader dataReader = null;
            lstInvNames = new List<InvestigationMaster>();
            try
            {
                SqlCommand cmd = Command.pGetInvForMDMdelInvCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvNames);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetInvestigationName DAL", ex);
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

        public long GetDeleteMDMInv(int OrgID, string InvID)
        {
            SqlCommand cmd = Command.pDeleteMDMInvCommand(OrgID, InvID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            return 0;
        }

        public long GetDeleteShowInv(int GroupID, string InvID)
        {
            SqlCommand cmd = Command.pDeleteShowInvNameCommand(GroupID, InvID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            return 0;
        }

        public long SearchInvForMDMAddInvAndGrp(string invName, int OrgID, string pType, string GroupCode, out List<InvestigationMaster> lstInvestigationMaster)
        {
            long returnCode = -1;
            lstInvestigationMaster = new List<InvestigationMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pSearchInvForMDMAddInvAndGrpCommand(invName, OrgID, pType, GroupCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbengine = new DBEngine())
                {
                    dataReader = dbengine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvestigationMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SearchInvForMDMAddInvAndGrp Investigation_DAL", e);
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
        public long SearchInvForMDMAddInvAndNewGrp(string invName, int OrgID, string pType, string GroupCode, out List<OrderedInvestigations> lstInvestigationMaster)
        {
            long returnCode = -1;
            lstInvestigationMaster = new List<OrderedInvestigations>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pSearchInvForMDMAddInvAndGrpCommand(invName, OrgID, pType, GroupCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbengine = new DBEngine())
                {
                    dataReader = dbengine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvestigationMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SearchInvForMDMAddInvAndGrp Investigation_DAL", e);
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
        public long SearchInvForMDMAddInvAndINGrp(string invName, int OrgID, string pGrp, out List<OrderedInvestigations> lstInvestigationMaster)
        {
            long returnCode = -1;
            lstInvestigationMaster = new List<OrderedInvestigations>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pSearchInvForMDMAddInvInGrpCommand(invName, OrgID, pGrp, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbengine = new DBEngine())
                {
                    dataReader = dbengine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvestigationMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SearchInvForMDMAddInvAndGrp Investigation_DAL", e);
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

        public long SearchInvForMDMAddGrp(string invName, int OrgID, string pType, string GroupCode, out List<InvGroupMaster> lstInvestigationMaster)
        {
            long returnCode = -1;
            lstInvestigationMaster = new List<InvGroupMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pSearchInvForMDMAddInvAndGrpCommand(invName, OrgID, pType, GroupCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbengine = new DBEngine())
                {
                    dataReader = dbengine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvestigationMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SearchInvForMDMAddInvAndGrp Investigation_DAL", e);
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

        public long SearchInvForMDMAddInvMapping(string invName, int OrgID, string pType, string GroupCode, out List<InvestigationOrgMapping> lstInvestigationMaster)
        {
            long returnCode = -1;
            lstInvestigationMaster = new List<InvestigationOrgMapping>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pSearchInvForMDMAddInvAndGrpCommand(invName, OrgID, pType, GroupCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbengine = new DBEngine())
                {
                    dataReader = dbengine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvestigationMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SearchInvForMDMAddInvAndGrp Investigation_DAL", e);
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
        public long SearchInvForMDMAddInvAndGrp(string invName, int OrgID, string pType, string GroupCode, out List<InvestigationOrgMapping> lstInv)
        {
            long returnCode = -1;
            lstInv = new List<InvestigationOrgMapping>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pSearchInvForMDMAddInvAndGrpCommand(invName, OrgID, pType, GroupCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbengine = new DBEngine())
                {
                    dataReader = dbengine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInv);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SearchInvForMDMAddInvAndGrp Investigation_DAL", e);
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


        public long SearchInvGrpName(string invName, int OrgID, string Type, out List<InvGroupMaster> lstInvestigationMaster)
        {
            long returnCode = -1;
            lstInvestigationMaster = new List<InvGroupMaster>();
            SqlCommand cmd = Command.pGetSearchGroupNameCommand(invName, OrgID, Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            using (DBEngine dbengine = new DBEngine())
            {
                dbengine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvestigationMaster);
            }

            return returnCode;
        }

        public long GetGrpInvList(string GrpName, int OrgID, int Filter, out List<InvGroupMaster> lstInvGroupMaster)
        {
            long returnCode = -1;
            lstInvGroupMaster = new List<InvGroupMaster>();
            SqlCommand cmd = Command.pGetGrpInvListCommand(GrpName, OrgID, Filter, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvGroupMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL pGetGrpInvList", ex);
            }
            return returnCode;
        }

        public long GetInvRefRangeForMDM(int OrgID, long StartIndex, long EndIndex, out List<InvestigationOrgMapping> lstIOM, out List<InvSampleMaster> lstInvSampleMaster, out List<InvestigationMethod> lstInvMethod, out List<InvPrincipleMaster> lstInvPrinciple, out List<InvKitMaster> lstInvKit, out List<InvInstrumentMaster> lstInvInstrument, out List<InvestigationSampleContainer> lstSampleContainer,
           out List<OrganizationAddress> lstOrganizationAddress, out long TotalCount, out List<OrganizationAddress> lstProcessingCentre)
        {
            long returnCode = -1;
            lstIOM = new List<InvestigationOrgMapping>();
            lstInvSampleMaster = new List<InvSampleMaster>();
            lstInvMethod = new List<InvestigationMethod>();
            lstInvPrinciple = new List<InvPrincipleMaster>();
            lstInvKit = new List<InvKitMaster>();
            lstInvInstrument = new List<InvInstrumentMaster>();
            lstSampleContainer = new List<InvestigationSampleContainer>();
            lstOrganizationAddress = new List<OrganizationAddress>();
            lstProcessingCentre = new List<OrganizationAddress>();
            SqlCommand cmd = Command.pGetInvForMDMRefRangeCommand(OrgID, StartIndex, EndIndex, out TotalCount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    dbengine.ExecuteDataSet(cmd, out ds);
                    TotalCount = Convert.ToInt64(cmd.Parameters["@pTotalCount"].Value);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstIOM);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstInvSampleMaster);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstInvMethod);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstInvPrinciple);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstInvKit);
                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstInvInstrument);
                }
                if (ds.Tables[6].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[6], out lstSampleContainer);
                }
                if (ds.Tables[7].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[7], out lstOrganizationAddress);
                }
                if (ds.Tables[8].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[8], out lstProcessingCentre);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvRefRangeForMDM Investigation_DAL", e);
            }

            return returnCode;
        }

        public long GetGrpRefRangeForMDM(int OrgID, long StartIndex, long EndIndex, out List<InvGroupMaster> lstIOM, out long TotalCount)
        {
            long returnCode = -1;
            lstIOM = new List<InvGroupMaster>();

            SqlCommand cmd = Command.pGetGrpForMDMRefRangeCommand(OrgID, StartIndex, EndIndex, out TotalCount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    dbengine.ExecuteDataSet(cmd, out ds);
                    TotalCount = Convert.ToInt64(cmd.Parameters["@pTotalCount"].Value);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstIOM);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetGrpRefRangeForMDM Investigation_DAL", e);
            }
            return returnCode;
        }



        public long GetInvGroupLt(int OrgGroupID, out List<InvestigationMaster> lstIOM)
        {
            long returnCode = -1;
            lstIOM = new List<InvestigationMaster>();
            SqlCommand cmd = Command.pGetShowInvGpNameCommand(OrgGroupID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            using (DBEngine dbengine = new DBEngine())
            {
                dbengine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstIOM);
            }

            return returnCode;
        }

        public long GetAddNewINVGroup(int OrgID, int GroupID, out List<InvestigationOrgMapping> lstIOM)
        {
            long returnCode = -1;
            lstIOM = new List<InvestigationOrgMapping>();
            SqlCommand cmd = Command.pGetAddNewInvGpNameCommand(OrgID, GroupID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            using (DBEngine dbengine = new DBEngine())
            {
                dbengine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstIOM);
            }

            return returnCode;
        }

        public long SaveInvestigationGrpName(List<InvestigationOrgMapping> pInvMap, string groupName, string billingName, int dptID, long gHeader, int DdlCase, string type, long OrgID, string ModifiedBy, string GroupCode, string Remarks, string Status, string Pkgcode, string printSeparately, DataTable dtCodingSchemeMaster, int CutOffTimeValue, string CutOffTimeType, string Gender, string IsServiceTaxable, short ScheduleType, bool ISpkgtransfer)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            DataTable InvMap = UDT_DAL.ConvertToInvestigationAdminRate(pInvMap);
            cmd = Command.pGetInsertInvGroupsCommand(InvMap, groupName, billingName, dptID, gHeader, DdlCase, OrgID, type, ModifiedBy, out returnCode, GroupCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails), Remarks, Status, Pkgcode, printSeparately, dtCodingSchemeMaster, CutOffTimeValue, CutOffTimeType, Gender, IsServiceTaxable, pInvMap[0].SubCategory, ScheduleType, ISpkgtransfer);
            using (DBEngine dBEngine = new DBEngine(false))
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt32(cmd.Parameters["@returnStatus"].Value);
            }
            return returnCode;
        }


        public long SaveInvestigationName(List<InvestigationOrgMapping> pInvMap)
        {
            long returnCode = -1;
            DataTable DtInvGp = UDT_DAL.ConvertToInvestigationOrgMapping(pInvMap);
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pGetInsertInvCommand(DtInvGp, out returnCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dBEngine = new DBEngine(false))
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt32(cmd.Parameters["@returnStatus"].Value);
            }
            return returnCode;
        }
        public long SaveNewInvestigation(int pGroupID, string PInvestigationID)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pAddNewInvNameCommand(pGroupID, PInvestigationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            using (DBEngine dBEngine = new DBEngine(false))
            {  //dBEngine.ExecuteTransactionalNonQuery(cmd);
                dBEngine.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
            }
            return returnCode;
        }
        public long GetIndInvList(string IndName, int OrgID, int Filter, out List<InvestigationMaster> lstInvestigationMaster)
        {
            long returnCode = -1;
            lstInvestigationMaster = new List<InvestigationMaster>();
            SqlCommand cmd = Command.pGetIndInvListCommand(IndName, OrgID, Filter, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvestigationMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetIndInvList", ex);
            }
            return returnCode;
        }









        public long pCheckInvValuesbyVID(long pVid, out int pCount, out string pPatientNumber, out List<OrderedInvestigations> lstOrderderd)
        {
            long returncode = -1;
            IDataReader dataReader = null;
            lstOrderderd = new List<OrderedInvestigations>();
            pCount = 0;
            pPatientNumber = string.Empty;
            try
            {
                SqlCommand cmd = Command.pCheckInvValuesbyVIDCommand(pVid, out pCount, out pPatientNumber, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returncode = Utilities.ConvertTo(dataReader, out lstOrderderd);
                        dataReader.Close();
                    }
                    pCount = Convert.ToInt32(cmd.Parameters["@pCount"].Value);
                    pPatientNumber = cmd.Parameters["@pPatientNumber"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL pCheckInvValuesbyVID", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returncode;
        }

        public long InsertIPInvestigation(IpInvSampleCollectionMaster entIPInvSCMaster,
            int pOrgID, List<PatientInvSample> lstPatientInvSample,
            List<PatientInvestigation> lstPatientInvestigation)//, out int ret)
        {
            long returnCode = -1;

            DataTable dtSaveIPInvSample = UDT_DAL.ConvertToIPInvSamples(lstPatientInvSample);
            DataTable dtSaveIPInvestigation = UDT_DAL.ConvertToIPPatInvestigation(lstPatientInvestigation);




            SqlCommand cmdSCM = Command.pInsertIPInvSCMasterCommand(entIPInvSCMaster.PatientVisitID, entIPInvSCMaster.Status, entIPInvSCMaster.CreatedBy, pOrgID, dtSaveIPInvestigation, dtSaveIPInvSample, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbengine = new DBEngine(true))
                {
                    dbengine.ExecuteNonQuery(cmdSCM);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertIPInvestigation", ex);
            }
            return returnCode;
        }


        public long GetIPPatientForInvestigation(long pVisitID, int OrgID, out List<IpInvSampleCollectionMaster> ipSampleMaster)
        {
            long returnCode = -1;
            ipSampleMaster = new List<IpInvSampleCollectionMaster>();
            try
            {
                SqlCommand cmd = Command.pGetIPPatientSampleCommand(pVisitID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out ipSampleMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("error whileexecuting investigation dal", ex);
            }
            return returnCode;
        }

        public long GetIPInvestigatonCapture(long VID, int OrgID, long RoleID, long pSCMID, out List<PatientInvestigation> lstDemoInvest, out List<InvestigationStatus> lstStatus)
        {
            long result = -1;
            lstDemoInvest = new List<PatientInvestigation>();
            lstStatus = new List<InvestigationStatus>();
            SqlCommand cmd = Command.pGetIPInvestigationCaptureCommand(VID, OrgID, RoleID, pSCMID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[0], out lstDemoInvest);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[1], out lstStatus);
                    }

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPInvestigatonCapture DAL", ex);
            }

            return result;
        }

        public long CheckIPInvCompleted(long pPatientVisitID, long pSCMID, out int pCount)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pCheckIPInvCompletedCommand(pPatientVisitID, pSCMID, out pCount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    pCount = Convert.ToInt32(cmd.Parameters["@pCount"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL CheckIPInvCompleted", ex);
            }
            return returnCode;
        }
        public long SaveClientMaster(InvClientMaster InvClientMaster, string sClientTypeName, int RateTypeID, int RateID)
        {
            long lresult = -1;
            long ClientID = 0;
            SqlCommand cmd = Command.pInsertClientMasterCommand(InvClientMaster.OrgID, InvClientMaster.ClientName, RateTypeID, RateID, out ClientID, InvClientMaster.ClientID, sClientTypeName, InvClientMaster.ClientAttributes, InvClientMaster.IsAllMedical, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing ClientMaster" + cmd.CommandText, ex);
            }
            return lresult;
        }
        public long SaveTPAMaster(TPAMaster InvTPAMaster)
        {
            long lresult = -1;
            long ClientID = 0;
            int orgid = Convert.ToInt16(InvTPAMaster.OrgID);
            SqlCommand cmd = Command.pinsertTPACommand(InvTPAMaster.TPAName, orgid, InvTPAMaster.TPAAttributes, InvTPAMaster.RateId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing TPAMaster" + cmd.CommandText, ex);
            }
            return lresult;
        }
        public long UpdateTPAMaster(TPAMaster InvTPAMaster)
        {
            long lresult = -1;
            long ClientID = 0;
            int orgid = Convert.ToInt16(InvTPAMaster.OrgID);
            SqlCommand cmd = Command.pUpdateTPAMasterCommand(InvTPAMaster.TPAID, InvTPAMaster.TPAName, orgid, InvTPAMaster.TPAAttributes, InvTPAMaster.RateId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing TPAMaster" + cmd.CommandText, ex);
            }
            return lresult;
        }

        public long GetClientInvestigationData(int orgID, int orgSpecific,
                                                out List<InvGroupMaster> lstGroup,
                                                out List<InvestigationMaster> lstInvestigations,
                                                int pVisitID)
        {
            long returncode = -1;
            lstInvestigations = null;
            lstGroup = null;
            try
            {
                SqlCommand cmd = Command.PGetInvestigationDataForVisitCommand(orgID, orgSpecific, pVisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstGroup);
                }

                if (ds.Tables[1].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[1], out lstInvestigations);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while excecuting investigation_dal in GetInvestigationByClientID", ex);
            }
            return returncode;
        }
        public long SaveInPatientInvestigation(List<PatientInvestigation> PatientInvestigation, long OrgID, out int pOrderedInvCnt)
        {
            int ret = -1;
            long retCode = -1;
            pOrderedInvCnt = 0;
            SqlCommand cmdInvestigation = new SqlCommand();
            DataTable invs = UDT_DAL.ConvertToPatientInvestigation(PatientInvestigation);
            cmdInvestigation = Command.pInsertInPatientInvestigationCommand(invs, OrgID, out pOrderedInvCnt, out ret, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInvestigation);
                    retCode = Convert.ToInt32(cmdInvestigation.Parameters["@returnstatus"].Value);
                    pOrderedInvCnt = Convert.ToInt32(cmdInvestigation.Parameters["@pOrderedInvCnt"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving PatientInvestigation(IP) investigation_DAL", e);
            }
            return retCode;

        }


        public long GetAllInvestigationWithRate(int OrgID, int clientID, string type, long visitID, out List<PatientInvestigation> lstPatInv)
        {
            long returncode = -1;
            lstPatInv = new List<PatientInvestigation>();

            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetAllInvestigationWithRateCommand(clientID, OrgID, type, visitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstPatInv);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while excecuting investigation_dal in GetInvestigationByClientID", ex);
            }
            return returncode;

        }


        public long SaveIPInvestigation(List<PatientInvestigation> PatientInvestigation, long OrgID, out int pOrderedInvCnt)
        {
            int ret = -1;
            long retCode = -1;
            pOrderedInvCnt = 0;
            SqlCommand cmdInvestigation = new SqlCommand();
            DataTable invs = UDT_DAL.ConvertToPatientInvestigation(PatientInvestigation);
            cmdInvestigation = Command.pSaveIPInvestigationCommand(invs, OrgID, out pOrderedInvCnt, out ret, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInvestigation);
                    retCode = Convert.ToInt32(cmdInvestigation.Parameters["@returnstatus"].Value);
                    pOrderedInvCnt = Convert.ToInt32(cmdInvestigation.Parameters["@pOrderedInvCnt"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving PatientInvestigation investigation_DAL", e);
            }
            return retCode;

        }
        public long GetUOMCode(out List<UOM> lstUOM)
        {
            long returnCode = -1;
            lstUOM = new List<UOM>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetUOMCodeCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstUOM);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetUOMCode", ex);
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
        public long DeleteClientCorporate(long OrgID, long ClientID, string sClientTypeName, out string Uavailable)
        {
            long lresult = -1;
            Uavailable = string.Empty;
            SqlCommand cmd = Command.pDeleteClientCorporateCommand(OrgID, ClientID, sClientTypeName, out Uavailable, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                    Uavailable = Convert.ToString(cmd.Parameters["@Uavailable"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing ClientMaster" + cmd.CommandText, ex);
            }

            return lresult;
        }

        public long SaveOrderedInvestigationHOS(List<OrderedInvestigations> OrderedInves, long OrgID, out int pOrderedInvCnt, string paymentstatus, string UID, string labno)
        {
            int ret = -1;
            long retCode = -1;
            DataTable invs = UDT_DAL.ConvertToOrderedInvestigation(OrderedInves);
            SqlCommand cmdInvestigation = new SqlCommand();
            cmdInvestigation = Command.pInsertOrderedInvestigationHosCommand(invs, OrgID, out pOrderedInvCnt, out ret, paymentstatus, UID, labno, "", DateTime.Now, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInvestigation);
                    retCode = Convert.ToInt32(cmdInvestigation.Parameters["@returnstatus"].Value);
                    pOrderedInvCnt = Convert.ToInt32(cmdInvestigation.Parameters["@pOrderedInvCnt"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving OrderedInvestigation investigation_DAL", e);
            }
            return retCode;

        }
        public long UpdateOrderedInvSampleCollected(List<OrderedInvestigations> lstOrderedInv, int filter, out int count)
        {
            long lresult = -1;
            count = 0;
            DataTable invs = UDT_DAL.ConvertToOrderedInvestigation(lstOrderedInv);
            SqlCommand cmd = Command.pUpdateOrderedInvStatusCommand(invs, filter, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@pCount", SqlDbType.Int);
            cmd.Parameters["@pCount"].Direction = ParameterDirection.ReturnValue;


            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                    count = Convert.ToInt32(cmd.Parameters["@pCount"].Value);
                    lresult = 0;
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateOrderedInvSampleCollected DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }
        public long getSampleCollectionforDepartment(long RoleID, int OrgID, long PatientVisitID, int OrgAddressID, out List<PatientInvestigation> lstPatientInvestigation, out List<InvDeptMaster> lstDeptMaster, out List<PatientInvSample> lstPatientInvSample, out List<CollectedSample> lstSamplesOrdered, out List<InvDeptMaster> deptList)
        {
            long returncode = -1;
            lstPatientInvestigation = new List<PatientInvestigation>();
            lstPatientInvSample = new List<PatientInvSample>();
            lstDeptMaster = new List<InvDeptMaster>();
            lstSamplesOrdered = new List<CollectedSample>();
            deptList = new List<InvDeptMaster>();
            IDataReader dataReader = null;
            int rsCount = 0;
            try
            {
                SqlCommand cmd = Command.pGetSamplesforDeptCommand(RoleID, OrgID, PatientVisitID, OrgAddressID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbengine = new DBEngine())
                {
                    dataReader = dbengine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returncode = Utilities.ConvertTo(dataReader, out lstPatientInvestigation);
                            }
                            else if (rsCount == 1)
                            {
                                returncode = Utilities.ConvertTo(dataReader, out lstPatientInvSample);
                            }

                            else if (rsCount == 2)
                            {
                                returncode = Utilities.ConvertTo(dataReader, out lstDeptMaster);
                            }
                            else if (rsCount == 3)
                            {
                                returncode = Utilities.ConvertTo(dataReader, out lstSamplesOrdered);
                            }
                            else if (rsCount == 4)
                            {
                                returncode = Utilities.ConvertTo(dataReader, out deptList);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL getSampleCollectionforDepartment", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returncode;
        }

        public long GetBulkInvestigationSamplesCollect(string patientno, string orgcode, string locCode, string userId,
           out List<PatientInvestigation> lstPatientInvestigation, out List<InvSampleMaster> lstInvSampleMaster
           , out List<InvDeptMaster> lstInvDeptMaster, out List<RoleDeptMap> roleDept
           , out List<CollectedSample> lstSamples, out List<InvDeptMaster> deptList
           , out List<InvestigationSampleContainer> lstSampleContainer)
        {
            long returnCode = -1;

            lstPatientInvestigation = new List<PatientInvestigation>();
            lstInvSampleMaster = new List<InvSampleMaster>();
            lstInvDeptMaster = new List<InvDeptMaster>();
            roleDept = new List<RoleDeptMap>();
            lstSamples = new List<CollectedSample>();
            deptList = new List<InvDeptMaster>();
            lstSampleContainer = new List<InvestigationSampleContainer>();
            IDataReader dataReader = null;
            int rsCount = 0;
            try
            {
                SqlCommand objCommand = Command.pGetBulkInvestigationSamplesCommand(patientno, orgcode, locCode, userId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPatientInvestigation);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvSampleMaster);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvDeptMaster);
                            }
                            else if (rsCount == 3)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out roleDept);
                            }
                            else if (rsCount == 4)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstSamples);
                            }
                            else if (rsCount == 5)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out deptList);
                            }
                            else if (rsCount == 6)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstSampleContainer);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL pSelectInvestigationSamples", ex);
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

        public long GetInvestigationSamplesCollect(long PatientVisitID, int OrgID, long roleID, string gUID, int LocationID, int taskactionID,
            out List<PatientInvestigation> lstPatientInvestigation, out List<InvSampleMaster> lstInvSampleMaster
            , out List<InvDeptMaster> lstInvDeptMaster, out List<RoleDeptMap> roleDept
            , out List<CollectedSample> lstSamples, out List<InvDeptMaster> deptList
            , out List<InvestigationSampleContainer> lstSampleContainer)
        {
            long returnCode = -1;

            lstPatientInvestigation = new List<PatientInvestigation>();
            lstInvSampleMaster = new List<InvSampleMaster>();
            lstInvDeptMaster = new List<InvDeptMaster>();
            roleDept = new List<RoleDeptMap>();
            lstSamples = new List<CollectedSample>();
            deptList = new List<InvDeptMaster>();
            lstSampleContainer = new List<InvestigationSampleContainer>();
            IDataReader dataReader = null;
            int rsCount = 0;
            try
            {
                SqlCommand objCommand = Command.pGetInvestigationSamplesCommand(PatientVisitID, OrgID, roleID, gUID, LocationID, taskactionID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPatientInvestigation);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvSampleMaster);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvDeptMaster);
                            }
                            else if (rsCount == 3)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out roleDept);
                            }
                            else if (rsCount == 4)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstSamples);
                            }
                            else if (rsCount == 5)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out deptList);
                            }
                            else if (rsCount == 6)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstSampleContainer);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL pSelectInvestigationSamples", ex);
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


        public long SavePatientInvSamples(List<PatientInvSample> PatientInvSample, List<SampleTracker> lstSampleTracker,
        List<InvDeptSamples> deptSamples, List<PatientInvSampleMapping> lstPatientInvSampleMapping, List<PatientInvestigation> lstPatientInvestigation,
       List<InvestigationValues> lInvestigation, string gUID, out int savePInvS, out string lstSampleId)
        {
            long returncode = -1;
            savePInvS = -1;
            int listCount1 = PatientInvSample.Count;
            DataTable invDeptSamples = UDT_DAL.ConvertToUDDInvDeptSamples(deptSamples);
            DataTable dtSM = UDT_DAL.ConvertToPatientInvSampleMapping(lstPatientInvSampleMapping);
            DataTable invs = UDT_DAL.ConvertToPatientInvestigation(lstPatientInvestigation);
            DataTable tblInvesigationIDs = UDT_DAL.ConvertToInvestigationResults(lInvestigation);
            DataTable tblPatientInvSample = UDT_DAL.ConvertToPatientInvSampleCollected(PatientInvSample);
            SqlCommand cmdinst = new SqlCommand();
            SqlCommand cmd = Command.pInsertSampleReceivingDeptCommand(PatientInvSample[0].PatientVisitID, PatientInvSample[0].OrgID, invDeptSamples, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            lstSampleId = string.Empty;
            if (listCount1 > 0)
            {
                cmdinst = Command.pInsertPatientInvSampleCommand(
                    tblPatientInvSample,
                   lstSampleTracker[0].DeptID,
                   out savePInvS,
                   out lstSampleId,
                   dtSM, invs, gUID, tblInvesigationIDs, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            }

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmdinst);
                        savePInvS = Convert.ToInt32(cmdinst.Parameters["@returnstatus"].Value);
                        lstSampleId = Convert.ToString(cmdinst.Parameters["@pSampleID"].Value);
                        //lstSampleId = lstSampleId + sampleId + ",";

                        if (lstSampleId.Length > 0)
                            lstSampleId = lstSampleId.Substring(0, lstSampleId.Length - 1);
                        if (savePInvS == 0)
                        {
                            dbEngine.ExecuteTransactionalNonQuery(cmd);
                            savePInvS = Convert.ToInt32(cmd.Parameters["@Return"].Value);
                        }
                    }
                    tranScope.Complete();

                    returncode = 0;
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Error while executing SavePatientInvSamples in Investigation_DAL", ex);
                }
            }
            return returncode;
        }

        public long InsertBulkPatientInvSample(List<PatientInvSample> PatientInvSample, List<SampleTracker> lstSampleTracker,
        List<InvDeptSamples> deptSamples, List<PatientInvSampleMapping> lstPatientInvSampleMapping, List<PatientInvestigation> lstPatientInvestigation,
       List<InvestigationValues> lInvestigation, out int savePInvS, out string lstSampleId)
        {
            long returncode = -1;
            savePInvS = -1;
            int listCount1 = PatientInvSample.Count;
            DataTable invDeptSamples = UDT_DAL.ConvertToUDDInvDeptSamples(deptSamples);
            DataTable dtSM = UDT_DAL.ConvertToPatientInvSampleMapping(lstPatientInvSampleMapping);
            DataTable invs = UDT_DAL.ConvertToPatientInvestigation(lstPatientInvestigation);
            DataTable tblInvesigationIDs = UDT_DAL.ConvertToInvestigationResults(lInvestigation);
            DataTable tblPatientInvSample = UDT_DAL.ConvertToPatientInvSampleCollected(PatientInvSample);
            SqlCommand cmdinst = new SqlCommand();
            SqlCommand cmd = Command.pInsertSampleReceivingDeptCommand(PatientInvSample[0].PatientVisitID, PatientInvSample[0].OrgID, invDeptSamples, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            lstSampleId = string.Empty;
            if (listCount1 > 0)
            {
                cmdinst = Command.pInsertBulkPatientInvSampleCommand(
                    tblPatientInvSample,
                   lstSampleTracker[0].DeptID,
                   out savePInvS,
                   out lstSampleId,
                   dtSM, invs, tblInvesigationIDs, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            }

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmdinst);
                        savePInvS = Convert.ToInt32(cmdinst.Parameters["@returnstatus"].Value);
                        lstSampleId = Convert.ToString(cmdinst.Parameters["@pSampleID"].Value);
                        //lstSampleId = lstSampleId + sampleId + ",";

                        if (lstSampleId.Length > 0)
                            lstSampleId = lstSampleId.Substring(0, lstSampleId.Length - 1);
                        if (savePInvS == 0)
                        {
                            dbEngine.ExecuteTransactionalNonQuery(cmd);
                            savePInvS = Convert.ToInt32(cmd.Parameters["@Return"].Value);
                        }
                    }
                    tranScope.Complete();

                    returncode = 0;
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Error while executing SavePatientInvSamples in Investigation_DAL", ex);
                }
            }
            return returncode;
        }

        public long GetDeptToTrackSamples(long PatientVisitID, int OrgID, long roleID, string gUID, out List<PatientInvestigation> lstSampleDept, out List<PatientInvSample> lstPatientInvSample)
        {
            long returnCode = -1;
            lstSampleDept = new List<PatientInvestigation>();
            lstPatientInvSample = new List<PatientInvSample>();
            IDataReader dataReader = null;
            int rsCount = 0;
            try
            {
                SqlCommand objCommand = Command.pGetDeptToTrackSamplesCommand(PatientVisitID, OrgID, roleID, gUID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstSampleDept);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPatientInvSample);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDeptToTrackSamples Investigation_DAL", ex);
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


        public long UpdateOrderedInvestigationStatusinLab(List<InvestigationValues> lInvestigation, long PatientVisitID, string Status, int DeptID, string SampleStatus, string gUID, out int upIS)
        {
            long returncode = -1;
            upIS = -1;
            DataTable tblInvesigationIDs = UDT_DAL.ConvertToInvestigationResults(lInvestigation);
            SqlCommand cmd = Command.pUpdateOrderedInvestigationStatusinLabCommand(tblInvesigationIDs, PatientVisitID, Status, DeptID, SampleStatus, out upIS, gUID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteNonQuery(cmd);
                    upIS = Convert.ToInt32(cmd.Parameters["@returnstatus"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL UpdateOrderedInvestigationStatusinLab", ex);
            }
            return returncode;
        }
        public long GetInvestigatonCapture(long VID, int OrgID, long RoleID, out List<OrderedInvestigations> lstDemoInvest, out List<InvestigationStatus> lstStatus)
        {
            long result = -1;
            lstDemoInvest = new List<OrderedInvestigations>();
            lstStatus = new List<InvestigationStatus>();
            SqlCommand cmd = Command.pGetInvestigationCaptureCommand(VID, OrgID, RoleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    result = Utilities.ConvertTo(ds.Tables[0], out lstDemoInvest);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    result = Utilities.ConvertTo(ds.Tables[1], out lstStatus);
                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DemoGetInvestigaton DAL", ex);
            }

            return result;
        }
        public long GetInvestigationForBillVisit(long visitID, long FinalBillID, int orgID, int LocationID,
            LoginDetail objLoginDetail, out List<OrderedInvestigations> lstPatientInvestigation)
        {
            long returnCode = -1;
            lstPatientInvestigation = new List<OrderedInvestigations>();
            IDataReader dataReader = null;
            try
            {
                DataTable dtLoginDetail = UDT_DAL.ConvertToLoginDetail(objLoginDetail);
                SqlCommand cmd = Command.pGetInvestigationForBillVisitCommand(visitID, FinalBillID, orgID, LocationID, dtLoginDetail, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPatientInvestigation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving getInvestigationforVisit investigation_DAL", ex);
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
        public long GetInvestigationForVisit(long visitID, int orgID, int LocationID,
            LoginDetail objLoginDetail, out List<OrderedInvestigations> lstPatientInvestigation)
        {
            long returnCode = -1;
            lstPatientInvestigation = new List<OrderedInvestigations>();
            IDataReader dataReader = null;
            try
            {
                DataTable dtLoginDetail = UDT_DAL.ConvertToLoginDetail(objLoginDetail);
                SqlCommand cmd = Command.PgetinvestigationforvisitCommand(visitID, orgID, LocationID, dtLoginDetail, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        Utilities.ConvertTo(dataReader, out lstPatientInvestigation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving getInvestigationforVisit investigation_DAL", ex);
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

        public long GetTaskPickedByDetails(long pPatientVisitID, long pLID,
            out long AssignedTo)
        {
            long returnCode = -1;
            AssignedTo = -1;
            try
            {
                SqlCommand cmd = Command.pGetTaskPickedByDetailsCommand(pPatientVisitID, pLID, out AssignedTo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    AssignedTo = Convert.ToInt64(cmd.Parameters["@pAssignedTo"].Value);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving GetTaskPickedByDetails investigation_DAL", ex);
            }
            return returnCode;
        }

        public long SaveInvestigationResults(long pSCMID,
            List<List<InvestigationValues>> lstInvestigationValues,
           List<PatientInvestigation> lstInvestigation,
            List<PatientInvSampleResults> lstPatientInvSampleResults,
            List<PatientInvSampleMapping> lstPatientInvSampleMapping,
            List<PatientInvestigationFiles> PatientInvestigationFiles,
            long vid, int OrgID, int deptID, long ApprovedBy,
            string gUID, out int returnStatus, List<PatientInvestigation> lstReflexPatientinvestigation, string isFromDevice,List<PatientInvestigationAttributes> lstPatAttr)
        {
            long lresult = -1;
            int i;
            bool success = true;
            List<PatientInvestigation> lstPatient = new List<PatientInvestigation>();
            List<InvestigationValues> lstPatientVisit = new List<InvestigationValues>();
            List<PatientInvSampleResults> lstPInvSampleResults = new List<PatientInvSampleResults>();

            DataTable dtResults = UDT_DAL.ConvertToInvestigationResults(lstInvestigationValues);

            DataTable dtSR = UDT_DAL.ConvertToUDTinvSampleResults(lstPatientInvSampleResults);

            DataTable dtSM = UDT_DAL.ConvertToPatientInvSampleMapping(lstPatientInvSampleMapping);

            DataTable dtPatientFiles = UDT_DAL.ConvertToPatientInvestigationFiles(PatientInvestigationFiles);
            DataTable dtPatientInvestigation = UDT_DAL.ConvertToPatientInvestigation(lstInvestigation);
            DataTable dtReflexPatientInvestigation = UDT_DAL.ConvertToPatientInvestigation(lstReflexPatientinvestigation);
            DataTable dtPatientinvAttr = UDT_DAL.ConvertToPatientInvAttr(lstPatAttr);
            SqlCommand cmd = Command.pInsertInvestigationResultsCommand(pSCMID, dtResults, vid, gUID, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails), isFromDevice);
            SqlCommand cmdSR = Command.pInsertinvSampleResultsCommand(dtSR, vid, OrgID, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            SqlCommand cmdSM = Command.pInsertInvSampleMappingCommand(dtSM, vid, OrgID, deptID, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            SqlCommand cmdUpdateteID = Command.pUpdatePatientInvestigationCompleteCommand(dtPatientInvestigation, pSCMID, ApprovedBy, gUID, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails), dtReflexPatientInvestigation,dtPatientinvAttr);
            SqlCommand[] cmdMethod = new SqlCommand[lstPatient.Count];
            SqlCommand cmdFiles = new SqlCommand();

            if (PatientInvestigationFiles.Count > 0)
            {
                if (!string.IsNullOrEmpty(PatientInvestigationFiles[0].ServerFilePath))
                {
                    cmdFiles = Command.pInsertPatientInvestigationFilesV2Command(dtPatientFiles, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                }
                else
                {
                    cmdFiles = Command.pInsertPatientInvestigationFilesCommand(dtPatientFiles, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                }
            }
            else
            {
                cmdFiles = Command.pInsertPatientInvestigationFilesCommand(dtPatientFiles, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            }

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        if (success)
                        {
                            dbEngine.ExecuteTransactionalNonQuery(cmdSR);
                            returnStatus = Convert.ToInt16(cmdSR.Parameters["@pReturnStatus"].Value.ToString());
                            if (returnStatus == 0)
                            {
                                dbEngine.ExecuteTransactionalNonQuery(cmdSM);
                                returnStatus = Convert.ToInt16(cmdSR.Parameters["@pReturnStatus"].Value.ToString());

                                if (returnStatus == 0)
                                {
                                    // Changed by Prasanna.S
                                    //dbEngine.ExecuteTransactionalNonQuery(cmd);
                                    //returnStatus = Convert.ToInt16(cmd.Parameters["@returnstatus"].Value.ToString());
                                    dbEngine.ExecuteTransactionalNonQuery(cmdUpdateteID);
                                    returnStatus = Convert.ToInt16(cmdUpdateteID.Parameters["@pReturnStatus"].Value.ToString());
                                    if (returnStatus == 0)
                                    {


                                        dbEngine.ExecuteTransactionalNonQuery(cmdFiles);

                                        if (success)
                                        {
                                            // Changed by Prasanna.S
                                            //dbEngine.ExecuteTransactionalNonQuery(cmdUpdateteID);
                                            //lresult = Convert.ToInt64(cmdUpdateteID.Parameters["@pReturnStatus"].Value);
                                            dbEngine.ExecuteTransactionalNonQuery(cmd);
                                            lresult = Convert.ToInt16(cmd.Parameters["@returnstatus"].Value.ToString());
                                            if (lresult != 0)
                                            {

                                                tranScope.Dispose();
                                            }



                                        }
                                    }
                                }
                            }
                            tranScope.Complete();

                        }
                    }
                }
                catch (Exception ex)
                {
                    tranScope.Dispose();
                }
            }
            // Changed by Prasanna.S
            //using (DBEngine dbEngine = new DBEngine())
            //{
            //    dbEngine.ExecuteNonQuery(cmd);
            //    lresult = Convert.ToInt16(cmd.Parameters["@returnstatus"].Value.ToString());
            //}
            return lresult;

        }


        public long GetInvestigationValues(long vid, int OrgID, string Guid, out List<InvestigationValues> lstInvestigationValues)
        {
            IDataReader dataReader = null;
            long result = -1;
            lstInvestigationValues = new List<InvestigationValues>();
            try
            {
                SqlCommand cmd = Command.pGetInvestigationValuesCommand(OrgID, vid, Guid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        result = Utilities.ConvertTo(dataReader, out lstInvestigationValues);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvestigationValues Investigation_DAL", e);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return result;
        }

        public long GetInvestigationResultTemplate(int OrgID, string TemplateType, long DeptID, out List<InvResultTemplate> lstInvResultTemplate)
        {
            long result = -1;
            lstInvResultTemplate = new List<InvResultTemplate>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvResultTemplateCommand(OrgID, TemplateType, DeptID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        result = Utilities.ConvertTo(dataReader, out lstInvResultTemplate);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvestigationResultTemplate Investigation_DAL", e);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return result;
        }

        public long GetInvestigationResultTemplateByID(int OrgID, long ResultID, string ResultName, string TemplateType, out List<InvResultTemplate> lInvResultTemplate)
        {
            long result = -1;
            lInvResultTemplate = new List<InvResultTemplate>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvResultTemplateByIDCommand(OrgID, ResultID, ResultName, TemplateType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    Utilities.ConvertTo(dataReader, out lInvResultTemplate);
                    dataReader.Close();
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvestigationResultTemplateByID Investigation_DAL", e);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return result;
        }

        public long GetInvestigatonResultsCapture(long VID, int OrgID, long RoleID, string gUID, long DeptID, string InvIDs,
                                                 int LocationID, LoginDetail LDetail, long taskid, string IsTrustedDetails, string status,
                                                 out List<PatientInvestigation> lstDemoInvest
                                                 , out List<InvestigationStatus> lstStatus
                                                 , out List<RoleDeptMap> lRoleDeptMap, out List<MedicalRemarksRuleMaster> lstmdRemarks
            //, out List<InvReportMaster> lEditValues
            //, out List<InvestigationHeader> lstHeader
                                                 )
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstDemoInvest = new List<PatientInvestigation>();
            lstStatus = new List<InvestigationStatus>();
            lRoleDeptMap = new List<RoleDeptMap>();
            lstmdRemarks=new List<MedicalRemarksRuleMaster>();
            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
            try
            {
                SqlCommand cmd = Command.pGetInvestigationResultsCaptureCommand(VID, OrgID, RoleID,
                                                       gUID, DeptID, InvIDs, LocationID, taskid, DtLDetail, UDT_DAL.ConvertToUDT_Context(globalContextDetails), IsTrustedDetails, status);
                using (DBEngine dbEngine = new DBEngine())
                {
                    int rsCount = 0;
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstDemoInvest);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstStatus);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lRoleDeptMap);
                            }
                            else if (rsCount == 3)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstmdRemarks);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigatonResultsCapture Investigation_DAL", ex);
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

        public long GetPatientInvSample(long pVisitId, int orgID, out List<PatientInvSample> lstPatientInvSample, out List<SampleAttributes> lstSampleAttributes, out List<PerformingPhysician> lPerfPhysician)
        {
            long returnCode = -1;

            lstPatientInvSample = new List<PatientInvSample>();
            lstSampleAttributes = new List<SampleAttributes>();
            lPerfPhysician = new List<PerformingPhysician>();
            SqlCommand cmd = Command.pGetPatientInvSampleCommand(pVisitId, orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientInvSample);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstSampleAttributes);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lPerfPhysician);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetPatientInvSample", ex);
            }

            return returnCode;
        }
        public long GetPatientInvestigationSampleResults(long vid, int OrgID, out List<PatientInvSampleResults> lstPatientInvSampleResults)
        {
            long result = -1;
            lstPatientInvSampleResults = new List<PatientInvSampleResults>();
            SqlCommand cmd = Command.pGetPatientInvestigationSampleResultsCommand(OrgID, vid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[0], out lstPatientInvSampleResults);
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetPatientInvestigationSampleResults Investigation_DAL", e);
            }
            return result;
        }
        public long GetOrderedInvestigations(long vid, int OrgID, out List<PatientInvestigation> lstOrderedInvestigations, out List<PatientInvSampleMapping> lstPatientInvSampleMapping, out List<PatientInvSampleResults> lstPatientInvSampleResults)
        {
            long result = -1;
            lstOrderedInvestigations = new List<PatientInvestigation>();
            lstPatientInvSampleMapping = new List<PatientInvSampleMapping>();
            lstPatientInvSampleResults = new List<PatientInvSampleResults>();
            SqlCommand cmd = Command.pGetSampleCollectedInvestigationsCommand(OrgID, vid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[0], out lstOrderedInvestigations);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[1], out lstPatientInvSampleMapping);
                    }
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[2], out lstPatientInvSampleResults);
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetOrderedInvestigations Investigation_DAL", e);
            }
            return result;
        }
        public long SaveInvestigationMethodKit(long vid, int OrgID, int deptID, List<PatientInvestigation> lstPatientInvestigation)
        {
            long retCode = -1;
            int ret = -1;
            SqlCommand cmdInvestigation = new SqlCommand();
            DataTable invs = UDT_DAL.ConvertToPatientInvestigation(lstPatientInvestigation);
            cmdInvestigation = Command.pInsertInvestigationMethodKitCommand(invs, vid, OrgID, deptID, out ret, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInvestigation);
                    retCode = Convert.ToInt32(cmdInvestigation.Parameters["@returnstatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving SaveInvestigationMethodKit Investigation_DAL", e);
            }
            return retCode;

        }
        public long GetInvMethodKit(long vid, int OrgID, int deptID, string gUID, out List<PatientInvestigation> lstPatientInvestigation)
        {
            long result = -1;
            lstPatientInvestigation = new List<PatientInvestigation>();
            SqlCommand cmd = Command.pGetInvMethodKitCommand(OrgID, vid, deptID, gUID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[0], out lstPatientInvestigation);
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvMethodKit Investigation_DAL", e);
            }
            return result;
        }
        public long GetGroupAndInvestigationByVisitID(long vid, int OrgID, int deptID, out List<InvestigationValues> lstInvestigationValues)
        {
            long result = -1;
            lstInvestigationValues = new List<InvestigationValues>();
            SqlCommand cmd = Command.pGetGroupAndInvestigationByVisitIDCommand(OrgID, vid, deptID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[0], out lstInvestigationValues);
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetGroupAndInvestigationByVisitID Investigation_DAL", e);
            }
            return result;
        }

        public long GetInvestigationResultByRoleid(long patientVisitID, int OrgID, long roleID, out List<PatientVisit> lstpatientdemographics, out List<InvestigationValues> lstInvestigationValues)
        {
            long result = -1;
            lstInvestigationValues = new List<InvestigationValues>();
            lstpatientdemographics = new List<PatientVisit>();
            SqlCommand cmd = Command.pGetInvestigationResultByRoleIDCommand(patientVisitID, OrgID, roleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);

                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    result = Utilities.ConvertTo(ds.Tables[0], out lstpatientdemographics);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    result = Utilities.ConvertTo(ds.Tables[1], out lstInvestigationValues);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvestigationValues Investigation_DAL", e);
            }
            return result;
        }
        public long UpdateInvestigationStatus(long patientVisitID, string status, int OrgID, List<InvestigationValues> lstInvValues)
        {
            long returncode = -1;
            int outParam = -1;
            DataTable dtvalues = UDT_DAL.ConvertToInvestigationResults(lstInvValues);
            SqlCommand cmd = Command.pUpdateInvestigationStatusCommand(patientVisitID, dtvalues, status, OrgID, out outParam, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEng = new DBEngine())
                {
                    returncode = dbEng.ExecuteNonQuery(cmd);
                    returncode = Convert.ToInt16(cmd.Parameters["@pReturnStatus"].Value.ToString());
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing UpdateInvestigationStatus Investigation_DAL", e);
            }
            return returncode;
        }
        public long SaveIPOrderedInvestigation(List<OrderedInvestigations> pInvestigationHL, long OrgID, out int returnstatus, string guid)
        {
            returnstatus = -1;
            long retCode = -1;
            DataTable invs = UDT_DAL.ConvertToOrderedInvestigation(pInvestigationHL);
            SqlCommand cmdInvestigation = new SqlCommand();
            cmdInvestigation = Command.pInsertIPOrderedInvestigationCommand(invs, OrgID, out returnstatus, guid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInvestigation);
                    retCode = Convert.ToInt16(cmdInvestigation.Parameters["@returnstatus"].Value.ToString());

                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while SaveIPOrderedInvestigation investigation_DAL", e);
            }
            return retCode;

        }
        public long GetModalityWorkList(string modalityName, DateTime FromDate, DateTime ToDate, int orgid, out List<ModalityWorkList> modalityWorklist, out List<ModalityWorkList> CompletionList)
        {
            long returncode = -1;
            modalityWorklist = new List<ModalityWorkList>();
            CompletionList = new List<ModalityWorkList>();
            SqlCommand cmd = Command.pGetModalityWorklistCommand(modalityName, FromDate, ToDate, orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out modalityWorklist);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[1], out CompletionList);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting modalityworklist in dal", ex);
            }
            return returncode;
        }
        public long GetLabConsumablesByOrg(int OrgID, string type, long ClientID, out List<LabConsumables> lstLabConsumables)
        {
            long returncode = -1;
            lstLabConsumables = new List<LabConsumables>();

            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetLabConsumablesByOrgCommand(OrgID, type, ClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstLabConsumables);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while excecuting investigation_dal in GetLabConsumablesByOrg", ex);
            }
            return returncode;

        }
        public long GetLabNo(int OrgID, List<OrderedInvestigations> ordInves, out string LabNo)
        {
            int ret = -1;
            long retCode = -1;
            DataTable dtinvs = UDT_DAL.ConvertToOrderedInvestigation(ordInves);
            SqlCommand cmdInvestigation = new SqlCommand();
            cmdInvestigation = Command.PGetLabNoCommand(OrgID, dtinvs, out LabNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInvestigation);
                    LabNo = Convert.ToString(cmdInvestigation.Parameters["@pLabNo"].Value);

                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving OrderedInvestigation investigation_DAL", e);
            }
            return retCode;

        }

        public long SaveOrderedInvestigation(List<OrderedInvestigations> OrderedInves, long OrgID)
        {
            int ret = -1;
            long retCode = -1;
            DataTable invs = UDT_DAL.ConvertToOrderedInvestigation(OrderedInves);
            SqlCommand cmdInvestigation = new SqlCommand();
            List<OrderedInvestigations> UnOrderedInve = new List<OrderedInvestigations>();
            DataTable invs1 = UDT_DAL.ConvertToOrderedInvestigation(UnOrderedInve);
            cmdInvestigation = Command.pInsertOrderedInvestigationCommand(invs, OrgID, out ret, invs1, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInvestigation);
                    retCode = Convert.ToInt32(cmdInvestigation.Parameters["@returnstatus"].Value);

                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving OrderedInvestigation investigation_DAL", e);
            }
            return retCode;

        }

        public long SaveIPPaidInvestigationAndPatientIndents(List<PatientDueChart> lstSurgergicalPkg, List<OrderedInvestigations> pInvestigationHL, int OrgID, out List<OrderedInvestigations> lstOrderedInv, List<PatientDueChart> pPatientConsultation,
                                     List<PatientDueChart> pPatientProcedure, List<PatientDueChart> pPatientIndents, List<DHEBAdder> pDHEBPatientIndents,
                                    long visitID, long CreatedBy, long patientID, DateTime dtInvDate, string GuID, out string InterimBillNo, out string labno)
        {
            labno = "0";
            long returnCode = -1;
            long ret = -1;
            InterimBillNo = "-1";
            DataSet ds = new DataSet();
            lstOrderedInv = new List<OrderedInvestigations>();
            DataTable invs = UDT_DAL.ConvertToOrderedInvestigation(pInvestigationHL);
            SqlCommand cmdInvestigation = new SqlCommand();
            cmdInvestigation = Command.pInsertIPPaidInvestigationCommand(invs, OrgID, GuID, out labno, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            cmdInvestigation.Parameters.Add("@Return", SqlDbType.Int);
            cmdInvestigation.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteDataSet(cmdInvestigation, out ds);
                        returnCode = Convert.ToInt64(cmdInvestigation.Parameters["@Return"].Value);
                        labno = Convert.ToString(cmdInvestigation.Parameters["@labno"].Value);
                        if (returnCode == 0)
                        {
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                ret = Utilities.ConvertTo(ds.Tables[0], out lstOrderedInv);
                            }
                            if (returnCode == 0)
                            {
                                DataTable dtPatientItems = null;
                                dtPatientItems = UDT_DAL.ConvertToUDTPatientDueChart(lstSurgergicalPkg, lstOrderedInv, pPatientConsultation,
                                                   pPatientProcedure, pPatientIndents, pDHEBPatientIndents,
                                                   dtInvDate, labno);
                                SqlCommand cmdInsertVisit = Command.pInsertPatientItemsCommand(dtPatientItems, visitID, CreatedBy, patientID, out InterimBillNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                                cmdInsertVisit.Parameters.Add("@Return", SqlDbType.Int);
                                cmdInsertVisit.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
                                dbEngine.ExecuteTransactionalNonQuery(cmdInsertVisit);
                                returnCode = Convert.ToInt64(cmdInvestigation.Parameters["@Return"].Value);
                                InterimBillNo = Convert.ToString(cmdInsertVisit.Parameters["@pInterimBillNumber"].Value);

                                if (returnCode == 0)
                                {
                                    tranScope.Complete();
                                }
                                else
                                {
                                    tranScope.Dispose();
                                }
                            }

                        }

                    }
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Exception while saving ANC data.", ex);
                    tranScope.Dispose();
                }

            }
            return returnCode;

        }

        public long SaveIPPaidInvestigationAndPatientIndents(List<OrderedInvestigations> pInvestigationHL,
            int OrgID, out List<OrderedInvestigations> lstOrderedInv,
            long visitID, long CreatedBy, long patientID, string GuID, out string InterimBillNo)
        {
            string labno = "";
            long returnCode = -1;
            long ret = -1;
            InterimBillNo = "-1";
            DataSet ds = new DataSet();
            lstOrderedInv = new List<OrderedInvestigations>();
            DataTable invs = UDT_DAL.ConvertToOrderedInvestigation(pInvestigationHL);

            SqlCommand cmdInvestigation = new SqlCommand();
            cmdInvestigation = Command.pInsertIPPaidInvestigationCommand(invs, OrgID, GuID, out labno, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            cmdInvestigation.Parameters.Add("@Return", SqlDbType.Int);
            cmdInvestigation.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {

                        dbEngine.ExecuteDataSet(cmdInvestigation, out ds);
                        returnCode = Convert.ToInt64(cmdInvestigation.Parameters["@Return"].Value);
                        labno = Convert.ToString(cmdInvestigation.Parameters["@labno"].Value); // check with prev version, for ["@plabnos"], modified during Hospital & Lab code merge
                        if (returnCode == 0)
                        {
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                ret = Utilities.ConvertTo(ds.Tables[0], out lstOrderedInv);
                            }
                            if (returnCode == 0)
                            {
                                DataTable dtPatientItems = null;
                                dtPatientItems = UDT_DAL.ConvertToUDTPatientDueChart(lstOrderedInv);
                                SqlCommand cmdInsertVisit = Command.pInsertPatientItemsCommand(dtPatientItems, visitID, CreatedBy, patientID, out InterimBillNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                                cmdInsertVisit.Parameters.Add("@Return", SqlDbType.Int);
                                cmdInsertVisit.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
                                dbEngine.ExecuteTransactionalNonQuery(cmdInsertVisit);
                                returnCode = Convert.ToInt64(cmdInsertVisit.Parameters["@Return"].Value);
                                InterimBillNo = Convert.ToString(cmdInsertVisit.Parameters["@pInterimBillNumber"].Value);
                                if (returnCode == 0)
                                {
                                    tranScope.Complete();
                                }
                                else
                                {
                                    tranScope.Dispose();
                                }
                            }

                        }

                    }
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Exception while saving ANC data.", ex);
                    tranScope.Dispose();
                }

            }
            return returnCode;

        }






        public long SaveInvestiagtionResult(long AccessionNumber, string InvestigationResult)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pInsertInvestigationValuesCommand(AccessionNumber, InvestigationResult, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEng = new DBEngine())
                {
                    returnCode = dbEng.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Insert Investigation values in SaveInvestiagtionResult(investigation_dal)", ex);
            }
            return returnCode;
        }
        public long GetOrderedInvForPhysician(int pOrgID, long patientVisitID, out List<OrderedInvestigations> lstOrderedInves)
        {
            long returnCode = -1;
            lstOrderedInves = new List<OrderedInvestigations>();
            try
            {
                SqlCommand cmd = Command.pGetOrderedInvForPhysicianCommand(pOrgID, patientVisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrderedInves);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while investigation dal", ex);

            }
            return returnCode;
        }

        public long SaveReferenceRange(List<InvestigationOrgMapping> lstIOM, int orgID)
        {
            long returnCode = -1;
            int retValue = -1;
            SqlCommand cmd = new SqlCommand();
            DataTable dtInvestigations = UDT_DAL.ConvertToInvestigationOrgMapping(lstIOM);
            cmd = Command.pUpdateReferenceRangeCommand(dtInvestigations, orgID, out retValue, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dBEngine = new DBEngine(false))
                {
                    dBEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@returnStatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveReferenceRange Investigation_DAL", e);
            }
            return returnCode;
        }
        public long InsertReferenceRangeXML(int OrgId, List<InvestigationOrgMapping> lstIOM)
        {
            long returnCode = -1;
            int retValue = -1;
            SqlCommand cmd = new SqlCommand();
            DataTable dtInvestigations = UDT_DAL.ConvertToInvestigationOrgMapping(lstIOM);
            cmd = Command.pInsertReferenceRangeXMLCommand(OrgId, dtInvestigations, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out retValue);
            try
            {
                using (DBEngine dBEngine = new DBEngine(false))
                {
                    dBEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@returnStatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing InsertReferenceRange Investigation_DAL", e);
            }
            return returnCode;

        }

        public long SaveGrpReferenceRange(List<InvOrgGroup> lstIOM, int orgID)
        {
            long returnCode = -1;
            int retValue = -1;
            SqlCommand cmd = new SqlCommand();
            DataTable dtInvestigations = UDT_DAL.ConvertToGroupOrgMapping(lstIOM);
            cmd = Command.pUpdateGrpReferenceRangeCommand(dtInvestigations, orgID, out retValue, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dBEngine = new DBEngine(false))
                {
                    dBEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@returnStatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveReferenceRange Investigation_DAL", e);
            }
            return returnCode;
        }

        public long SearchGrpRefRangeForMDM(int OrgID, long StartIndex, long EndIndex, string invName, out List<InvGroupMaster> lstInv, out long TotalSerachCount)
        {
            long returnCode = -1;
            lstInv = new List<InvGroupMaster>();

            SqlCommand cmd = Command.pSearchGrpForMDMRefRangeCommand(OrgID, StartIndex, EndIndex, invName, out TotalSerachCount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    dbengine.ExecuteDataSet(cmd, out ds);
                    TotalSerachCount = Convert.ToInt64(cmd.Parameters["@pTotalCount"].Value);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInv);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SearchGrpForMDMAddInvAndGrp Investigation_DAL", e);
            }
            return returnCode;
        }

        public long SearchInvRefRangeForMDM(string invName, int OrgID, long StartIndex, long EndIndex, out List<InvestigationOrgMapping> lstInv, out List<InvSampleMaster> lstInvSampleMaster, out List<InvestigationMethod> lstInvMethod, out List<InvPrincipleMaster> lstInvPrinciple, out List<InvKitMaster> lstInvKit, out List<InvInstrumentMaster> lstInvInstrument, out List<InvestigationSampleContainer> lstSampleContainer, out List<OrganizationAddress> lstOrganizationAddress, out long TotalSerachCount, out List<OrganizationAddress> lstProcessingCentre)
        {
            long returnCode = -1;
            lstInv = new List<InvestigationOrgMapping>();
            lstInvSampleMaster = new List<InvSampleMaster>();
            lstInvMethod = new List<InvestigationMethod>();
            lstInvPrinciple = new List<InvPrincipleMaster>();
            lstInvKit = new List<InvKitMaster>();
            lstInvInstrument = new List<InvInstrumentMaster>();
            lstSampleContainer = new List<InvestigationSampleContainer>();
            lstOrganizationAddress = new List<OrganizationAddress>();
            lstProcessingCentre = new List<OrganizationAddress>();
            SqlCommand cmd = Command.pSearchInvRefRangeForMDMCommand(invName, OrgID, StartIndex, EndIndex, out TotalSerachCount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    dbengine.ExecuteDataSet(cmd, out ds);
                    TotalSerachCount = Convert.ToInt64(cmd.Parameters["@pTotalCount"].Value);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInv);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstInvSampleMaster);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstInvMethod);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstInvPrinciple);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstInvKit);
                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstInvInstrument);
                }
                if (ds.Tables[6].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[6], out lstSampleContainer);
                }
                if (ds.Tables[7].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[7], out lstOrganizationAddress);
                }
                if (ds.Tables[8].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[8], out lstProcessingCentre);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SearchInvForMDMAddInvAndGrp Investigation_DAL", e);
            }
            return returnCode;
        }

        public long SavePatientRecommendation(PatientRecommendation precommendation,
            List<PatientRecommendationDtls> precommendationDtls)
        {
            long returnCode = -1;
            DataTable dtrecommendation = UDT_DAL.ConvertToPatientRecommendationDetails(precommendationDtls);
            SqlCommand cmd = Command.pInsertPatientRecommendationCommand(dtrecommendation, precommendation.PatientID, precommendation.PatientVisitId, precommendation.OrgID, precommendation.OrgAddressID, precommendation.CreatedBy, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEng = new DBEngine())
                {
                    returnCode = dbEng.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Insert Investigation values in SavePatientRecommendation", ex);
            }
            return returnCode;
        }



        public long GetPatientRecommendationTemplate(int OrgID, string TemplateType, string ResultName, out List<InvResultTemplate> lstInvResultTemplate)
        {
            long result = -1;
            lstInvResultTemplate = new List<InvResultTemplate>();
            SqlCommand cmd = Command.pGetPatientTemplateCommand(OrgID, TemplateType, ResultName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[0], out lstInvResultTemplate);
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvestigationResultTemplate Investigation_DAL", e);
            }
            return result;
        }

        public long GetInvResultsCaptureForApprovel(long VID, int OrgID, long RoleID, string gUID, long DeptID,
            LoginDetail LDetail, long TaskID,
                                                out List<PatientInvestigation> lstDemoInvest
                                                , out List<InvestigationStatus> lstStatus
                                                , out List<RoleDeptMap> lRoleDeptMap, out List<InvReportMaster> lEditValues, string IsTrustedDetails)
        {
            long result = -1;
            lstDemoInvest = new List<PatientInvestigation>();
            lstStatus = new List<InvestigationStatus>();
            lRoleDeptMap = new List<RoleDeptMap>();
            lEditValues = new List<InvReportMaster>();
            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
            SqlCommand cmd = Command.pGetInvResultsCaptureForApprovelCommand(VID, OrgID, RoleID, gUID, DeptID, DtLDetail, IsTrustedDetails, TaskID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();


            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[0], out lstDemoInvest);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[1], out lstStatus);
                    }
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[2], out lRoleDeptMap);
                    }
                    if (ds.Tables[3].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[3], out lEditValues);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigatonResultsCapture Investigation_DAL", ex);
            }

            return result;
        }



        public long GetInvBulkDataForApprovel(string gUID, long InvestigationID, long patientVisitID, int orgID, int GroupID,
                                    out List<InvestigationValues> lstBulkData
                                    , out List<InvestigationValues> lstPendingValues
                                    , out List<InvestigationStatus> header, out List<InvestigationOrgMapping> lstiom)
        {
            long lresult = -1;
            int returnStatus = -1;
            lstBulkData = new List<InvestigationValues>();
            lstPendingValues = new List<InvestigationValues>();
            header = new List<InvestigationStatus>();
            lstiom = new List<InvestigationOrgMapping>();
            SqlCommand cmd = Command.pGetInvBulkDataForApprovelCommand(gUID, InvestigationID, patientVisitID, orgID, GroupID, returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstBulkData);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[1], out lstPendingValues);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[2], out header);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[3], out lstiom);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDemoBulkData DAL", ex);
            }
            return lresult;
        }

        public long GetHealthPackageData(int OrgID, int pkgid, out List<InvGroupMaster> lstPackages, out List<InvPackageMapping> lstPackageMapping, out List<PatientInvestigation> lstPackageContents, out List<GeneralHealthCheckUpMaster> lstGeneralHealthCheckUpMaster)
        {
            long returncode = -1;
            int rsCount = 0;
            lstPackages = new List<InvGroupMaster>();
            lstPackageMapping = new List<InvPackageMapping>();
            lstPackageContents = new List<PatientInvestigation>();
            lstGeneralHealthCheckUpMaster = new List<GeneralHealthCheckUpMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetHealthPackageDataCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails), pkgid);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returncode = Utilities.ConvertTo(dataReader, out lstPackages);
                            }
                            else if (rsCount == 1)
                            {
                                returncode = Utilities.ConvertTo(dataReader, out lstPackageMapping);
                            }
                            else if (rsCount == 2)
                            {
                                returncode = Utilities.ConvertTo(dataReader, out lstPackageContents);
                            }
                            else if (rsCount == 3)
                            {
                                returncode = Utilities.ConvertTo(dataReader, out lstGeneralHealthCheckUpMaster);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while excecuting GetHealthPackageData in Investigation_DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returncode;
        }

        public long GetHealthPackageDataWithClientID(int OrgID, int ClientID, out List<InvGroupMaster> lstPackages, out List<InvPackageMapping> lstPackageMapping, out List<PatientInvestigation> lstPackageContents, out List<GeneralHealthCheckUpMaster> lstGeneralHealthCheckUpMaster)
        {
            long returncode = -1;
            lstPackages = new List<InvGroupMaster>();
            lstPackageMapping = new List<InvPackageMapping>();
            lstPackageContents = new List<PatientInvestigation>();
            lstGeneralHealthCheckUpMaster = new List<GeneralHealthCheckUpMaster>();
            try
            {
                SqlCommand cmd = Command.pGetHealthPackageDataWithClientIDCommand(OrgID, ClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstPackages);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[1], out lstPackageMapping);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[2], out lstPackageContents);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[3], out lstGeneralHealthCheckUpMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while excecuting GetHealthPackageData in Investigation_DAL", ex);
            }
            return returncode;
        }

        public long UpdatePackageContent(List<InvPackageMapping> lstInvPackageMapping, List<InvPackageMapping> lstDeletedPackageMapping, int OrgID, List<AdditionalTubeMapping> lstAdditionalTubeMapping)
        {
            long retCode = -1;
            DataTable invPMDT = UDT_DAL.ConvertToUDTInvPackageMapping(lstInvPackageMapping);
            DataTable dtinv = UDT_DAL.ConvertToUDTInvPackageDeleting(lstDeletedPackageMapping);
            DataTable dtAdditionalTubeMapping = UDT_DAL.ConvertToUDTAdditionalTubeMapping(lstAdditionalTubeMapping);

            SqlCommand cmdInvestigation = new SqlCommand();
            cmdInvestigation = Command.pUpdatePackageContentCommand(invPMDT, dtinv, OrgID, out retCode, dtAdditionalTubeMapping, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInvestigation);
                    retCode = Convert.ToInt32(cmdInvestigation.Parameters["@returnstatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing UpdatePackageContent in Investigation_DAL", e);
            }
            return retCode;
        }

        public long GetInvestigationByPCClientID(int orgID, long refOrgID, int refPhyID, int clientID, string type, out List<PatientInvestigation> lstPatInv)
        {
            long returncode = -1;
            lstPatInv = new List<PatientInvestigation>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetInvestigationByPCClientIDCommand(orgID, refOrgID, refPhyID, clientID, type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstPatInv);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationByPCClientID in Investigation_DAL", ex);
            }
            return returncode;

        }


        public long GetCustomPrice(int OrgID, int RefPhyID, long RefOrgID, out List<PCCustomPriceMapping> lstPCCPM, out List<InvestigationOrgMapping> lstIOM)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetCustomPriceCommand(OrgID, RefPhyID, RefOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPCCPM = new List<PCCustomPriceMapping>();
            lstIOM = new List<InvestigationOrgMapping>();
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPCCPM);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstIOM);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetCustomPrice Investigation_DAL", ex);
            }
            return returnCode;
        }
        public long SaveCustomPrice(int OrgID, int RefPhyID, long RefOrgID, List<PCCustomPriceMapping> lstPCCPM)
        {
            long retCode = -1;
            DataTable PCCPMDT = UDT_DAL.ConvertToUDTPCCustomPriceMapping(lstPCCPM);
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pUpdateCustomPriceCommand(OrgID, RefPhyID, RefOrgID, PCCPMDT, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                    retCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveCustomPrice in Investigation_DAL", e);
            }
            return retCode;

        }
        public long GetWayToMethodKit(long PatientVisitID, int OrgID, long roleID, out List<PatientInvestigation> lstSampleDept, out List<PatientInvSample> lstPatientInvSample)
        {
            long returnCode = -1;
            lstSampleDept = new List<PatientInvestigation>();
            lstPatientInvSample = new List<PatientInvSample>();
            try
            {
                SqlCommand objCommand = Command.pGetWayToMethodKitCommand(PatientVisitID, OrgID, roleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSampleDept);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatientInvSample);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDeptToTrackSamples Investigation_DAL", ex);
            }
            return returnCode;
        }

        public long GetInvList(int OrgID, out List<InvestigationMaster> lstInvestigationMaster)
        {
            long returnCode = -1;
            lstInvestigationMaster = new List<InvestigationMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvestigationOrgCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbengine = new DBEngine())
                {
                    dataReader = dbengine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvestigationMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetIndInvList", ex);
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



        public long getOrgDepartHeadName(int orgID, out List<InvDeptMaster> lstDepname, out List<InvestigationHeader>

        lstHeader)
        {
            long returnCode = -1;
            lstDepname = new List<InvDeptMaster>();
            lstHeader = new List<InvestigationHeader>();
            try
            {
                SqlCommand cmd = Command.pGetOrgDepartHeaderNameCommand(orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDepname);
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstHeader);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while investigation DAL Department Name", ex);

            }
            return returnCode;
        }

        public long DeleteInvestigationName(List<InvestigationOrgMapping> pInvMap, out string inv)
        {
            long returnCode = -1;
            DataTable DtInvGp = UDT_DAL.ConvertToInvestigationDeleteOrgMapping(pInvMap);
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pGetDeleteInvCommand(DtInvGp, out returnCode, out inv, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dBEngine = new DBEngine(false))
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt32(cmd.Parameters["@returnStatus"].Value);
                inv = (cmd.Parameters["@inv"].Value).ToString(); ;
            }
            return returnCode;
        }
        public long SaveInvResultTemplate(InvResultTemplate InvRt)
        {
            long retCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.PInsertInvResultTemplateCommand(InvRt.ResultID, InvRt.ResultName, InvRt.ResultValues, InvRt.ResultTemplateType, InvRt.OrgID, InvRt.DeptID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    retCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveResultTemplate in Investigation_DAL", e);
            }
            return retCode;

        }
        public long GetInvResultTemplateByResultName(int OrgID, int ResultID, string ResultName, int DeptID, out List<InvResultTemplate> lstInvResultTemp)
        {
            long result = -1;
            lstInvResultTemp = new List<InvResultTemplate>();
            try
            {

                SqlCommand objCommand = Command.pGetInvResultTemplateByTypeCommand(OrgID, ResultID, ResultName, DeptID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    result = Utilities.ConvertTo(ds.Tables[0], out lstInvResultTemp);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvestigationResultTemplate Investigation_BL", e);
            }
            return result;
        }
        public long DelResultTemplate(string ReSultID)
        {
            long returnCode = -1;

            try
            {
                SqlCommand cmd = Command.PDelResultTemplateCommand(ReSultID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveReferrals in Referrals_DAL", ex);
            }
            return returnCode;

        }




        public long GetInvQualitativeResultMaster(out List<InvQualitativeResultMaster> lstInvQualitativeResultMaster)
        {
            IDataReader dataReader = null;
            long result = -1;
            lstInvQualitativeResultMaster = new List<InvQualitativeResultMaster>();
            try
            {
                SqlCommand cmd = Command.pGetInvQualitativeResultMasterCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        result = Utilities.ConvertTo(dataReader, out lstInvQualitativeResultMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvQualitativeResultMaster Investigation_DAL", e);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return result;
        }




        public long SaveQRMData(List<InvestigationBulkData> lstQRMData)
        {
            long returnCode = -1;
            int retValue = -1;
            DataTable DtQRMDataList = UDT_DAL.ConvertToUDTInvQualitativeResultMaster(lstQRMData);
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pInsertInvQualitativeResultMasterCommand(DtQRMDataList, out retValue, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dBEngine = new DBEngine(false))
                {
                    dBEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@returnStatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveQRMData Investigation_DAL", e);
            }
            return returnCode;
        }


        public long InsertNewInvestigation(string InvestigationName, int DepartmentID, int HeaderID, int TemplateID, int PatternID, int OrgID)
        {
            long returnCode = -1;

            try
            {
                SqlCommand objCommand = Command.pInsertnewinvestigationCommand(OrgID, DepartmentID, HeaderID, TemplateID, PatternID, InvestigationName, out returnCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(objCommand);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDeptToTrackSamples Investigation_DAL", ex);
            }
            return returnCode;
        }


        public long UpdateTaskPickedByDetails(string Type, long PatientVisitID, long LID)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pUpdateTaskPickedByDetailsCommand(Type, PatientVisitID, LID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateTaskPickedByDetails in Investigation_DAL", ex);
            }
            return returnCode;
        }


        public long GetLabInvestigationPatientSearch(int OrgAddID, int OrgID, long RoleID, int currentPageNo, int PageSize,
           Int64 PatientId, string PatientName, out List<EnterResult> lstPatient, out int totalRows,
           int intVisitType, long lngSourceId,
            string wardno, string status, string invname, string fdate,
           string tdate, int priority, string VisitNumber, string PatNumber, string Type, long DeptID, string pTaskAction, int pRefPhyID, long pLocationID, LoginDetail LDetail, string IsTimed, long ProtocalGroupID, string BarcodeNumber, string tasks, string SampleID)
        {
            long lresult = -1;
            IDataReader dataReader = null;
            lstPatient = new List<EnterResult>();
            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
            SqlCommand cmd = Command.pGetLabInvestigationPatientSearchCommand(OrgAddID, OrgID, RoleID, PatientId, PatientName, currentPageNo, PageSize, out totalRows, intVisitType, lngSourceId, wardno, status, invname, fdate, tdate, priority, VisitNumber, PatNumber, Type, DeptID, pTaskAction, pRefPhyID, pLocationID, DtLDetail, UDT_DAL.ConvertToUDT_Context(globalContextDetails), IsTimed, ProtocalGroupID, BarcodeNumber, tasks, SampleID);

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        lresult = Utilities.ConvertTo(dataReader, out lstPatient);
                        dataReader.Close();

                    }
                    totalRows = Convert.ToInt32(cmd.Parameters["@totalRows"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Patient Search in labhome DAL" + cmd.CommandText, ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }

            return lresult;
        }


        public long GetCustomPriceWithInvName(int OrgID, int RefPhyID, long RefOrgID, string InvName, out List<PCCustomPriceMapping> lstPCCPM, out List<InvestigationOrgMapping> lstIOM)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetCustomPriceWithInvNameCommand(OrgID, RefPhyID, RefOrgID, InvName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPCCPM = new List<PCCustomPriceMapping>();
            lstIOM = new List<InvestigationOrgMapping>();
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPCCPM);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstIOM);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetCustomPriceWithInvName Investigation_DAL", ex);
            }
            return returnCode;
        }


        public long UpdateRefDoctorName(long PatientVisitId, int RefDocID, int OrgID)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pUpdatePatientVisitPhysicianCommand(PatientVisitId, RefDocID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(objCommand);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetCustomPriceWithInvName Investigation_DAL", ex);
            }
            return returnCode;
        }

        public long GetLabWorkListForVisit(long vid, int OrgID, int RoleID, string GUID, out List<InvestigationOrgMapping> lstInvestigationOrgMapping)
        {
            long result = -1;
            lstInvestigationOrgMapping = new List<InvestigationOrgMapping>();
            SqlCommand cmd = Command.pGetInvestigationResultsCaptureFormatForWorkListCommand(vid, OrgID, RoleID, GUID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[0], out lstInvestigationOrgMapping);
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetLabWorkListForVisit Investigation_DAL", e);
            }
            return result;
        }
        public long GetSampleNotGiven(int OrgID, long PatientVisitId, out List<SampleTracker> lstST)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstST = new List<SampleTracker>();
            try
            {
                SqlCommand cmd = Command.pGetSampleNotgivenCommand(OrgID, PatientVisitId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstST);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetSampleNotGiven Investigation_DAL", ex);
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


        public long SaveSampleTrackerStatus(List<SampleTracker> lstSampleTracker)
        {
            long returnCode = -1;
            int retValue = -1;
            DataTable SampleTrackerDT = UDT_DAL.ConvertToUDTSampleTracker(lstSampleTracker);
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pUpdateSampleNotGivenCommand(SampleTrackerDT, out retValue, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dBEngine = new DBEngine(false))
                {
                    dBEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@returnStatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveSampleTrackerStatus Investigation_DAL", e);
            }
            return returnCode;
        }

        public long SaveGroupComments(List<PatientInvestigation> lstPInvestigation, string GUID)
        {
            long returnCode = -1;
            int retValue = -1;
            DataTable DtGroupComment = UDT_DAL.ConvertToPatientInvestigation(lstPInvestigation);
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pUpdateGroupCommentCommand(DtGroupComment, GUID, out retValue, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dBEngine = new DBEngine(false))
                {
                    dBEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@returnStatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveGroupComments Investigation_DAL", e);
            }
            return returnCode;
        }

        public long DeleteInvestigationDetails(List<OrderedInvestigations> InvDetails, long ExternalVisitID, int OrgID, out long VisitID)
        {
            VisitID = 0;
            DataTable dtInvestigationDetails = UDT_DAL.ConvertToOrderedInvestigation(InvDetails);
            long returnCode = -1;
            try
            {
                SqlCommand CMD = Command.pDeleteOrderedInvestigationCommand(dtInvestigationDetails, OrgID, ExternalVisitID, out VisitID, out returnCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine DB = new DBEngine())
                {
                    returnCode = DB.ExecuteNonQuery(CMD);
                    returnCode = Convert.ToInt16(CMD.Parameters["@preturnCode"].Value);
                    VisitID = Convert.ToInt64(CMD.Parameters["@pVisitID"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in InvestigationDAL - DeleteInvestigationDetails", ex);
            }
            return returnCode;

        }
        public long GetWorkOrderFromVisitToVisit(string pFromVisitID, string pToVisitID, string pFromDate, string pToDate, string pLocation, string pSourceName, int pVisitType, string pWard, string pInvestigationName, int OrgID, int pHistoryMode, long pLoginId, string pPageMode, int pLoggedLocationId, out List<WorkOrder> lstWorkOrder)
        {
            long result = -1;
            lstWorkOrder = new List<WorkOrder>();
            SqlCommand cmd = Command.pGetWorkOrderFromVisitToVisitCommand(pFromVisitID, pToVisitID, pFromDate, pToDate, pLocation, pSourceName, pVisitType, pWard, pInvestigationName, OrgID, pHistoryMode, pLoginId, pPageMode, pLoggedLocationId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[0], out lstWorkOrder);
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetWorkOrderFromVisitToVisit Investigation_DAL", e);
            }
            return result;
        }

        public long GetRadiologyReport(int OrgAddID, int OrgID, string FromVisit, string ToVisit, string RefPhyName, string RefHosName, string ReportedBy, string UrnNo, string PatientName, string ReportText, int currentPageNo, int PageSize, out int totalRows, out List<RadiologyReport> lstRadiologyReport)
        {
            long result = -1;
            lstRadiologyReport = new List<RadiologyReport>();
            SqlCommand cmd = Command.pGetRadiologyReportCommand(OrgAddID, OrgID, FromVisit, ToVisit, RefPhyName, RefHosName, ReportedBy, UrnNo, PatientName, ReportText, currentPageNo, PageSize, out totalRows, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[0], out lstRadiologyReport);
                        totalRows = Convert.ToInt32(cmd.Parameters["@totalRows"].Value);
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetRadiologyReport Investigation_BL", e);
            }
            return result;
        }

        public long GetPerformingPhysician(int OrgID, out List<PerformingPhysician> lstPerformingPhysician)
        {
            long result = -1;
            lstPerformingPhysician = new List<PerformingPhysician>();
            SqlCommand cmd = Command.pGetPerformingPhysicianCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[0], out lstPerformingPhysician);
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetPerformingPhysician Investigation_DAL", e);
            }
            return result;
        }

        public long GetReferingHospitalList(string PrefixText, int OrgID, out List<LabReferenceOrg> lstLabRefOrg)
        {
            long result = -1;
            lstLabRefOrg = new List<LabReferenceOrg>();
            SqlCommand cmd = Command.pGetReferingHospitalListCommand(PrefixText, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[0], out lstLabRefOrg);
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetReferingHospitalList Investigation_DAL", e);
            }
            return result;
        }
        public long GetWorkListFromVisitToVisit(string fromVisit, string toVisit, int OrgID, int deptID,
             int orgadd, int clientid, long LocationID, string WardName, string InvestigationName
             , int Priority,
             out List<WorkOrder> lstWorkList, int intVisitType, string FromDate, string ToDate, int pHistoryMode,
            string pPageMode, long pLoginId, string IsIncludevalues, string Preference)
        {
            long result = -1;
            lstWorkList = new List<WorkOrder>();
            SqlCommand cmd = Command.pGetWorkListFromVisitToVisitCommand(fromVisit, toVisit, OrgID, deptID, intVisitType, orgadd
                                    , clientid, LocationID, WardName, InvestigationName, Priority, FromDate, ToDate, pHistoryMode,
                                                    pPageMode, pLoginId, IsIncludevalues, Preference, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[0], out lstWorkList);
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetWorkListFromVisitToVisit Investigation_DAL", e);
            }
            return result;
        }

        public long GetPatInvDetailsForVisit(List<OrderedInvestigations> ordInves, long patientVisitId, int OrgID, out List<PatientInvestigation> lstPatientInvestigation, out int RowsAffected)
        {
            long lResult = -1;
            lstPatientInvestigation = new List<PatientInvestigation>();
            DataTable DT = UDT_DAL.ConvertToOrderedInvestigation(ordInves);
            SqlCommand cmd = Command.pGetPatInvDetailsForVisitCommand(DT, patientVisitId, OrgID, out RowsAffected, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@returnCode", SqlDbType.Int);
            cmd.Parameters["@returnCode"].Direction = ParameterDirection.ReturnValue;

            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                lResult = dbEngine.ExecuteDataSet(cmd, out ds);
                lResult = Convert.ToInt64(cmd.Parameters["@returnCode"].Value);
                RowsAffected = Convert.ToInt32(cmd.Parameters["@RowsAffected"].Value);
            }


            return lResult;
        }
        public long UpdateClientMaster(InvClientMaster InvClientMaster)
        {
            long lresult = -1;
            long ClientID = 0;
            int orgid = Convert.ToInt16(InvClientMaster.OrgID);
            SqlCommand cmd = Command.pUpdateClientMasterCommand(InvClientMaster.OrgID, InvClientMaster.ClientName, InvClientMaster.RateTypeId, InvClientMaster.RateId, InvClientMaster.ClientID, InvClientMaster.ClientAttributes, InvClientMaster.IsAllMedical, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateClientMaster" + cmd.CommandText, ex);
            }
            return lresult;
        }
        /* BEGIN | NA | Sabari | 20190515 | Created | MRNNumberSearch */
        public long GetReceiveSampleList(int OrgID, int OrgAddressID, int CollectedLocationID, string visitid, string patientname, int visittype, int priority, string fromdate, string todate, string sourcename, string InvestigationName, long InvestigationID, string InvestigationType, string refPhyName, long refPhyID, long refPhyOrg, string BarcodeNo, out List<PatientVisitDetails> lPatientDetails, int pagesize, int startrowindex, out int totalRows, string patientnumber)
        {
            long returnCode = -1;
            totalRows = -1;
            lPatientDetails = new List<PatientVisitDetails>();
            IDataReader dataReader = null;
            int rsCount = 0;
            try
            {
                SqlCommand cmd = Command.PgetRecSampleListCommand(OrgID, OrgAddressID, CollectedLocationID, visitid, patientname, visittype, priority, fromdate, todate, sourcename, InvestigationName, InvestigationID, InvestigationType, refPhyName, refPhyID, refPhyOrg, UDT_DAL.ConvertToUDT_Context(globalContextDetails), BarcodeNo, pagesize, startrowindex, out totalRows, patientnumber);
                using (DBEngine dbEngine = new DBEngine())
                {

                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lPatientDetails);

                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());

                        dataReader.Close();
                    }
                    //totalRows = Convert.ToInt32(dataReader.Rows[0]["totalRows"]);
                    totalRows = Convert.ToInt32(cmd.Parameters["@totalRows"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetReceiveSampleList in Investigation_DAL", ex);
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
        /* END | NA | Sabari | 20190515 | Created | MRNNumberSearch */

        public long InsertPatientSampleMapping(List<PatientInvSampleMapping> lsampleresult, long VisitID, int OrgID, int DeptID, long CreatedBy, out int returnStatus)
        {
            long returncode = -1;

            DataTable dtSM = UDT_DAL.ConvertToPatientInvSampleMapping(lsampleresult);
            SqlCommand cmdSM = Command.pInsertInvSampleMappingCommand(dtSM, VisitID, OrgID, DeptID, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));


            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteNonQuery(cmdSM);
                    returncode = Convert.ToInt16(cmdSM.Parameters["@pReturnStatus"].Value.ToString());

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertPatientSampleMapping", ex);
            }
            return returncode;
        }
        public long GetDeviceImportData(string date, int orgID, string Status, string DeviceID, out List<DeviceImportData> objImportData)
        {
            long returncode = -1;
            objImportData = new List<DeviceImportData>();
            SqlCommand cmd = Command.pGetDeviceImportDataCommand(date, orgID, Status, DeviceID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out objImportData);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting GetDeviceImportData in dal", ex);
            }
            return returncode;
        }
        public long SaveOrderLocation(List<OrderedInvestigations> lstOrderInvestigation, int OrgID)
        {
            long returnCode = -1;
            int retValue = -1;
            DataTable InvLocDataList = UDT_DAL.ConvertToOrderedInvestigation(lstOrderInvestigation);
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pUpdateInvestigationOrgCommand(InvLocDataList, OrgID, out retValue, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dBEngine = new DBEngine(false))
                {
                    dBEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@returnStatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveQRMData Investigation_DAL", e);
            }
            return returnCode;
        }
        public long UpdateTestStatus(List<OrderedInvestigations> lstOrderInvestigation, int OrgID)
        {
            long returnCode = -1;
            int retValue = -1;
            DataTable InvLocDataList = UDT_DAL.ConvertToOrderedInvestigation(lstOrderInvestigation);
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pUpdateTestStatusCommand(InvLocDataList, OrgID, out retValue, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dBEngine = new DBEngine(false))
                {
                    dBEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@returnStatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing UpdateTestStatus Investigation_DAL", e);
            }
            return returnCode;
        }

        public long UpdateToHoldInvestigationReport(List<PatientInvestigation> lstOrderInvestigation)
        {
            long returnCode = -1;
            int retValue = -1;
            DataTable InvLocDataList = UDT_DAL.ConvertToPatientInvestigation(lstOrderInvestigation);
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pUpdateToHoldInvestigationReportCommand(InvLocDataList, out retValue, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dBEngine = new DBEngine(false))
                {
                    dBEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@returnStatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveQRMData Investigation_DAL", e);
            }
            return returnCode;
        }


        public long pGetInvANDGroup(int OrgID, int GrpId, out List<OrderedInvestigations> lstInvNames, out string groupname)
        {
            long returnCode = -1;
            groupname = string.Empty;
            lstInvNames = new List<OrderedInvestigations>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvANDGroupCommand(OrgID, GrpId, out groupname, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvNames);
                        dataReader.Close();
                    }
                    groupname = Convert.ToString(cmd.Parameters["@groupname"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetInvestigationName DAL", ex);
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


        public long GetInvestigationDetailsForExternalVisitID(string FrmPatientVisitID, string ToVisitID, int OrgID, long roleID, string gUID
            , int LocationID, string FDate, string toDate,
           out List<PatientInvestigation> lstPatientInvestigation)
        {
            long returnCode = -1;
            lstPatientInvestigation = new List<PatientInvestigation>();
            try
            {
                SqlCommand objCommand = Command.PgetInvestigationForExterVisitIDCommand(FrmPatientVisitID, ToVisitID, OrgID, gUID, LocationID, FDate, toDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientInvestigation);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetInvestigationDetailsForExternalVisitID", ex);
            }
            return returnCode;
        }

        public long pUpdateInvANDGrpSequence(DataTable dtSequence, int pOrgID, int GroupID)
        {

            long returnCode = -1;
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pUpdateINVandGroupSequenceCommand(pOrgID, GroupID, dtSequence, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Refered count and Ordered count", ex);
            }

            return returnCode;
        }

        public long GetDeptSequence(int OrgID, out List<InvDeptMaster> lstDpt)
        {
            long lresult = -1;
            lstDpt = new List<InvDeptMaster>();
            IDataReader dataReader = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pGetDeptSequenceCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        lresult = Utilities.ConvertTo(dataReader, out lstDpt);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Department DAL" + cmd.CommandText, ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return lresult;
        }


        public long pUpdateDeptSequence(DataTable dtSequence, int pOrgID, int pDeptid, string pDept, string DtCode)
        {

            long returnCode = -1;
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pUpdateDeptSequenceCommand(pOrgID, pDeptid, dtSequence, pDept, DtCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Refered count and Ordered count", ex);
            }

            return returnCode;
        }
        public long pInsertDeptName(int OrgID, string pdept, long DeptCode, string Code, out List<InvDeptMaster> lstDpt)
        {
            long lresult = -1;
            lstDpt = new List<InvDeptMaster>();
            SqlCommand cmd = Command.pInsertDeptNameCommand(pdept, DeptCode, OrgID, Code, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[0], out lstDpt);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Department DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }
        public long pUpdateDeptSequenceNo(DataTable dtSequence, int pOrgID)
        {

            long returnCode = -1;
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pUpdateDeptSequenceNOCommand(pOrgID, dtSequence, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Refered count and Ordered count", ex);
            }

            return returnCode;
        }
        public long GetProductUsage(int OrgID, int OrgAddressID, DateTime fromdate, DateTime todate, int LocationID, string DeviceName, string InvestigationName, string ProductName, long DeviceID, out List<InventoryProductMapping> lsttotalInvest, out List<ProductCategories> lstCategories, out List<Locations> lstLocations)
        {

            lsttotalInvest = new List<InventoryProductMapping>();
            lstCategories = new List<ProductCategories>();
            lstLocations = new List<Locations>();

            long lResult = -1;
            try
            {
                SqlCommand cmd = Command.pDeviceStockUsageReportCommand(OrgID, OrgAddressID, fromdate, todate, LocationID, DeviceName, InvestigationName, ProductName, DeviceID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine(false))
                {

                    lResult = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lResult = Utilities.ConvertTo(ds.Tables[0], out lsttotalInvest);
                }

                if (ds.Tables[1].Rows.Count > 0)
                {
                    lResult = Utilities.ConvertTo(ds.Tables[1], out lstCategories);
                }

                if (ds.Tables[2].Rows.Count > 0)
                {
                    lResult = Utilities.ConvertTo(ds.Tables[2], out lstLocations);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GET Investigation Details ", ex);
            }
            return lResult;
        }


        public long SaveHomeCollectionDetails(long PatientID, string CollectionAddr, DateTime Fromdate, DateTime Todate, long RoleID,
            long UserID, int CollecOrgID, long CollecOrgAddrID, int LoginOrgID, DateTime BookedFrom, DateTime BookedTo, string Status,
            string Task, out List<Bookings> lstHomeCollectionDetails, string Add2, string City,
            string MobileNumber, string pAge, string Sex, string pName, int PageSize, int currentPageNo, out int totalRows)
        {
            long returnCode = -1;
            totalRows = 0;
            lstHomeCollectionDetails = new List<Bookings>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pSaveHomeCollectionDetailsCommand(PatientID, CollectionAddr, Fromdate, Todate, RoleID, UserID,
                    CollecOrgID, CollecOrgAddrID, LoginOrgID, BookedFrom, BookedTo, Status,
                    Task, UDT_DAL.ConvertToUDT_Context(globalContextDetails), Add2, City, MobileNumber, pAge, Sex, pName, PageSize, currentPageNo, out totalRows);
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstHomeCollectionDetails);
                        totalRows = Convert.ToInt32(ds.Tables[1].Rows[0]["totalRows"]);
                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Save HomeCollection Details ", ex);
            }
            return returnCode;
        }

        //public long UpdateHomeCollectiondetails(long HCID, long pVisitID, string status,long pPatientID)
        //{
        //    long returnCode = -1;

        //    try
        //    {
        //        DataSet ds = new DataSet();
        //        SqlCommand cmd = Command.pUpdateHomeCollectiondetailsCommand(HCID, pVisitID, status, pPatientID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
        //        using (DBEngine dbEngine = new DBEngine())
        //        {
        //            returnCode = dbEngine.ExecuteNonQuery(cmd);

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while Updating HomeCollection Details ", ex);
        //    }
        //    return returnCode;
        //}

        public long UpdateHomeCollectiondetails(long BKNO, long patientVisitID, string status, long patientID)
        {
            long returnCode = -1;

            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pUpdateHomeCollectiondetailsCommand(BKNO, patientVisitID, status, patientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Updating HomeCollection Details ", ex);
            }
            return returnCode;
        }

        public long GetRoleUserLogin(long OrgId, out List<LoginRole> objLoginRole)
        {
            long returncode = -1;
            objLoginRole = new List<LoginRole>();
            SqlCommand cmd = Command.pGetRoleUserLoginCommand(OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out objLoginRole);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting GetRoleUserLogin in dal", ex);
            }
            return returncode;
        }



        public long DeleteInventoryProductMapping(List<InventoryProductMapping> lstProductMapping, int OrgId, int lid)
        {
            long returnCode = -1;

            DataTable dt = new DataTable();


            dt = UDT_DAL.ConvertToInvProductMapping(lstProductMapping);
            SqlCommand cmdSCM = Command.pDeleteInventoryProductMappingCommand(dt, OrgId, lid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbengine = new DBEngine(true))
                {
                    returnCode = dbengine.ExecuteNonQuery(cmdSCM);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DeleteInventoryProductMapping", ex);
            }
            return returnCode;


        }
        public long SaveInventoryProductMapping(List<InventoryProductMapping> lstProductMapping, int OrgId, int lid, out string valid)
        {
            long returnCode = -1;
            valid = string.Empty;

            DataTable dt = new DataTable();


            dt = UDT_DAL.ConvertToInvProductMapping(lstProductMapping);
            SqlCommand cmdSCM = Command.pSaveInventoryProductMappingCommand(dt, OrgId, lid, out valid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbengine = new DBEngine(true))
                {
                    returnCode = dbengine.ExecuteNonQuery(cmdSCM);
                    valid = Convert.ToString(cmdSCM.Parameters["@valid"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL SaveInventoryProductMapping", ex);
            }
            return returnCode;

        }
        public long SearchInventoryProductMapping(int OrgID, out List<InventoryProductMapping> lstProductMapping)
        {
            long returnCode = -1;
            lstProductMapping = new List<InventoryProductMapping>();
            try
            {
                SqlCommand cmd = Command.pSearchInventoryProductMappingCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine(false))
                {

                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0) // History
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstProductMapping);
                }


            }

            catch (Exception e)
            {
                CLogger.LogError("Error while saving SearchInvestigationProductMapping investigation_DAL", e);
            }
            return returnCode;
        }
        public long SearchInvestigationProductMapping(int InvestigationId, int OrgID, out List<InventoryProductMapping> lstProductMapping)
        {
            long returnCode = -1;
            lstProductMapping = new List<InventoryProductMapping>();
            try
            {
                SqlCommand cmd = Command.pSearchInvestigationProductMappingCommand(InvestigationId, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine(false))
                {

                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0) // History
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstProductMapping);
                }


            }

            catch (Exception e)
            {
                CLogger.LogError("Error while saving SearchInvestigationProductMapping investigation_DAL", e);
            }
            return returnCode;

        }
        public long pGetpatientInvestigationForVisit(long visitID, int orgID, int LocationID, string gUID, out List<OrderedInvestigations> lstPatientInvestigation)
        {
            long returnCode = -1;
            lstPatientInvestigation = new List<OrderedInvestigations>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetpatientInvestigationForVisitCommand(visitID, orgID, LocationID, gUID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPatientInvestigation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving getInvestigationforVisit investigation_DAL", ex);
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


        public long SavePatientInvestigationForWorkList(List<PatientInvestigation> PatientInvestigation, long OrgID, string gUID, out int pOrderedInvCnt)
        {
            int ret = -1;
            long retCode = -1;
            pOrderedInvCnt = 0;
            SqlCommand cmdInvestigation = new SqlCommand();
            DataTable invs = UDT_DAL.ConvertToWorkListInvestigations(PatientInvestigation);
            cmdInvestigation = Command.pInsertInvestigationForWorkListCommand(invs, OrgID, gUID, out pOrderedInvCnt, out ret, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInvestigation);
                    retCode = Convert.ToInt32(cmdInvestigation.Parameters["@returnstatus"].Value);
                    pOrderedInvCnt = Convert.ToInt32(cmdInvestigation.Parameters["@pOrderedInvCnt"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving PatientInvestigation SavePatientInvestigationForWorkList", e);
            }
            return retCode;

        }


        public long ADDinvestigationName(int OrgID, string InvName, DataTable dtCodingSchemeMaster, string CodeType, out List<InvestigationMaster> lstInvestigation)
        {
            long returnCode = -1;
            lstInvestigation = new List<InvestigationMaster>();

            SqlCommand cmd = Command.pGetAddInvestigationNameCommand(OrgID, InvName, dtCodingSchemeMaster, CodeType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            cmd.Parameters.Add("@ret", SqlDbType.Int);
            cmd.Parameters["@ret"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@ret"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Saving RefPhyRateMapping" + cmd.CommandText, ex);
            }

            return returnCode;

        }


        public long SearchInvestigation(int OrgID, string InvName, out List<InvestigationMaster> lstInvestigation, int pageSize, int StartRowIndex, out int totalRows)
        {
            long returnCode = -1;
            totalRows = 0;
            lstInvestigation = new List<InvestigationMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pSearchInvestigationCommand(OrgID, InvName, pageSize, StartRowIndex, out totalRows, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvestigation);
                        dataReader.Close();
                    }
                    Int32.TryParse(cmd.Parameters["@totalRows"].Value.ToString(), out totalRows);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving SearchInvestigation_DAL", e);
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


        public long pGetPatientInvestigationStatus(string PatientNo, string PatientName, string fromDate,
      string toDate, long OrgID, long OrgAddressID, string Status,
      List<InvDeptSamples> deptSamples, string ReportStatus,
      out List<InvestigationStatusReport> lstPatientInvestigationStatus,
      int intVisitType, Int64 intSourceId, string TestName,
              Int64 TestID, string TestType, string TestCategory, int InvestigationStatusId,
      int ClientTypeID, long ClientID, int PageSize, int currentPageNo, out int totalRows, int STATStatus)
        {
            long returnCode = -1;
            totalRows = -1;
            lstPatientInvestigationStatus = new List<InvestigationStatusReport>();
            IDataReader dataReader = null;
            try
            {
                DataTable invDeptSamples = UDT_DAL.ConvertToUDDInvDeptSamples(deptSamples);
                SqlCommand cmd = Command.pgetPatientVisitInvestigatonStatusCommand(PatientNo, PatientName, fromDate,
                                    toDate, OrgID, OrgAddressID, Status,
                                    invDeptSamples, ReportStatus, intVisitType, intSourceId,
                                                        TestName, TestID, TestType, TestCategory, InvestigationStatusId, ClientTypeID, ClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails), PageSize, currentPageNo, out totalRows, STATStatus);
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPatientInvestigationStatus);
                        dataReader.Close();
                    }
                    totalRows = Convert.ToInt32(cmd.Parameters["@totalRows"].Value);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading pGetPatientInvestigationStatus Investigation_DAL", ex);
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





        public long GetINVandPatternChange(string InvName, out List<InvestigationMaster> lstPatternForINV)
        {
            long returnCode = -1;
            lstPatternForINV = new List<InvestigationMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetINVandPatternChangeCommand(InvName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPatternForINV);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading pGetPatientInvestigationStatus Investigation_DAL", ex);
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


        public long pGetPattern(int InvestigationID, int PatternID, out List<InvestigationPattern> lstpattern)
        {
            long returnCode = -1;
            lstpattern = new List<InvestigationPattern>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetPatternCommand(InvestigationID, PatternID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstpattern);
                        dataReader.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading pGetPatientInvestigationStatus Investigation_DAL", ex);
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


        public long pSavePattern(List<PatternMapping> lstsavepattern, List<InvReportMapping> lstSaveInvReportMapping)
        {
            long returnCode = -1;
            int retValue = -1;

            try
            {
                DataTable DtInvList = UDT_DAL.ConvertToPatternMapping(lstsavepattern);
                DataTable DtInvRptMap = UDT_DAL.ConvertToUDTInvReportMapping(lstSaveInvReportMapping);

                SqlCommand cmd = Command.pSavePatternCommand(DtInvList, out retValue, DtInvRptMap, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@returnStatus"].Value);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading pGetPatientInvestigationStatus Investigation_DAL", ex);
            }

            return returnCode;
        }
        public long pGetPatternInvestigation(int PatternID, int Orgid, out List<InvestigationMaster> lstpattern)
        {
            long returnCode = -1;
            lstpattern = new List<InvestigationMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetPatterninvestigationCommand(PatternID, Orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstpattern);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading pGetPatientInvestigationStatus Investigation_DAL", ex);
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
        public long UpdateMMPSStatus(long AccessioNumber, string StudyInstanceUID, int Status)
        {


            long returnCode = -1;


            try
            {

                SqlCommand cmd = Command.pUpdateMMPSStatusCommand(AccessioNumber, StudyInstanceUID, Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while UpdateMMPSStatus Investigation_DAL", ex);
            }

            return returnCode;
        }
        public long GetPatientDemography(int OrgID, long PatientVisitID, out List<PatientDemography> PatientDemography)
        {
            long returnCode = -1;

            PatientDemography = new List<PatientDemography>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetPatientBiographyForReportCommand(PatientVisitID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out PatientDemography);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetPatientDemography Investigation_DAL", ex);
            }

            return returnCode;
        }

        public long GetInvestigationValuesForID(int OrgID, long PatientVisitID, int TemplateID, long InvestigationID, out List<InvestigationValues> InvestigationValues)
        {
            long returnCode = -1;

            InvestigationValues = new List<InvestigationValues>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetTextResultValuesForIDCommand(PatientVisitID, OrgID, TemplateID, InvestigationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out InvestigationValues);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetPatientDemography Investigation_DAL", ex);
            }

            return returnCode;
        }
        public long GetImageForApproval(long OrgID, long PatientVisitID, long InvestigationID, out Login lstLogin)
        {
            long returnCode = -1;

            lstLogin = new Login();
            List<Login> logins = new List<Login>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetImageForApprovalCommand(OrgID, PatientVisitID, InvestigationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out logins);
                    }
                    if (logins.Count > 0)
                        lstLogin = logins[0];
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetImageForApproval Investigation_DAL", ex);
            }

            return returnCode;
        }
        public long PGetInvQualitativeResult(long orgid, out List<InvQualitativeResultMaster> lstInvQual)
        {
            long lResult = -1;
            lstInvQual = new List<InvQualitativeResultMaster>();

            SqlCommand cmd = Command.PGetInvQualitativeResultCommand(orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lResult = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lResult = Utilities.ConvertTo(ds.Tables[0], out lstInvQual);
                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getInvestigationId" + cmd.CommandText, ex);
            }

            return lResult;


        }
        public long PInsertInvQualitactiveResultMaster(long orgid, string Name)
        {
            long lResult = -1;

            SqlCommand cmd = Command.pIDUInvQualitactiveResultMasterCommand(orgid, 0, Name, "Insert", UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lResult = dbEngine.ExecuteDataSet(cmd, out ds);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InvestigationId" + cmd.CommandText, ex);
            }

            return lResult;


        }
        public long PdeleteInvQualitativeResultMaster(long OrgID, long id, string perphyname)
        {
            long lResult = -1;

            SqlCommand cmd = Command.pIDUInvQualitactiveResultMasterCommand(OrgID, id, perphyname, "Delete", UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lResult = dbEngine.ExecuteDataSet(cmd, out ds);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InvestigationId" + cmd.CommandText, ex);
            }

            return lResult;


        }
        public long PUpdateInvQualitativeResultMaster(long OrgID, long id, string perphyname)
        {
            long lResult = -1;

            SqlCommand cmd = Command.pIDUInvQualitactiveResultMasterCommand(OrgID, id, perphyname, "Update", UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lResult = dbEngine.ExecuteDataSet(cmd, out ds);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InvestigationId" + cmd.CommandText, ex);
            }

            return lResult;


        }
        public long GetInvestigationSymbols(long orgid, out List<InvestigationMaster> INVMaster)
        {
            long lResult = -1;
            INVMaster = new List<InvestigationMaster>();

            SqlCommand cmd = Command.pGetInvestigationSymbolsCommand(orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lResult = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lResult = Utilities.ConvertTo(ds.Tables[0], out INVMaster);
                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationSymbols", ex);
            }

            return lResult;
        }
        public long SaveUOMSymbols(long OrgID, string UOMCode, string UOMDesc)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pSaveUOMSymbolsCommand(OrgID, UOMCode, UOMDesc, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEng = new DBEngine())
                {
                    returnCode = dbEng.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Insert UOMSymbols(investigation_dal)", ex);
            }
            return returnCode;
        }

        public long UploadUOMCode(int OrgID, string Symbol, string Description)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pUploadUOMSymbolsCommand(OrgID, Symbol, Description, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEng = new DBEngine())
                {
                    returnCode = dbEng.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Insert UploadUOMCode(investigation_dal)", ex);
            }
            return returnCode;
        }
        public long UpdateOrderedInvestigation(long patientVisitID, string labno, int OrgID, string BillNo, long TaskId)
        {
            long returncode = -1;
            int outParam = -1;
            SqlCommand cmd = Command.PUpdateOrderedInvestigationCommand(patientVisitID, labno, OrgID, TaskId, BillNo, out outParam, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEng = new DBEngine())
                {
                    returncode = dbEng.ExecuteNonQuery(cmd);
                    returncode = Convert.ToInt16(cmd.Parameters["@pReturnStatus"].Value.ToString());
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing UpdateInvestigationStatus Investigation_DAL", e);
            }
            return returncode;
        }

        public long GetInvestigationNameForOrg(string Name, long orgid, out List<OrderedInvestigations> lstOrd)
        {
            long lResult = -1;
            lstOrd = new List<OrderedInvestigations>();
            IDataReader dataReader = null;
            SqlCommand cmd = Command.pGetInvestigationNameForOrgCommand(Name, orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        lResult = Utilities.ConvertTo(dataReader, out lstOrd);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationSymbols", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return lResult;
        }


        public long GetBatchSheet(string pFromVisitID, string pToVisitID, string pFromDate, string pToDate, string pLocation, long ILocationID, long Orgid, out DataSet DSWorkOrder, out List<PatientInvSample> lstPatientInvSample, out List<InvestigationSampleContainer> lstInvestigationSampleContainer, string Mode, int BatchID, long ClientID, long CollectedID)
        {
            long result = -1;

            DSWorkOrder = new DataSet();
            lstPatientInvSample = new List<PatientInvSample>();
            lstInvestigationSampleContainer = new List<InvestigationSampleContainer>();
            SqlCommand cmd = Command.PgetbatchsheetCommand(pFromVisitID, pToVisitID, pFromDate, pToDate, pLocation, ILocationID, Orgid, Mode, BatchID, ClientID, CollectedID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DSWorkOrder = ds.Tables[0].DataSet;
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    result = Utilities.ConvertTo(ds.Tables[1], out lstPatientInvSample);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    result = Utilities.ConvertTo(ds.Tables[2], out lstInvestigationSampleContainer);
                }

            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetBatchSheet Investigation_DAL", e);
            }
            return result;
        }
        public long GetBatchNumbers(long RegLocId, string pFromDate, string pToDate, string BatchStatus, out List<SampleBatchTracker> lstSampleBatchTracker)
        {
            long result = -1;
            lstSampleBatchTracker = new List<SampleBatchTracker>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetBatchNumbersCommand(RegLocId, pFromDate, pToDate, BatchStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        result = Utilities.ConvertTo(dataReader, out lstSampleBatchTracker);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetBatchSheet Investigation_DAL", e);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return result;
        }



        public long GetCorpoRateHealthPackageDataWithClientID(int OrgID, int ClientID, out List<InvGroupMaster> lstPackages, out List<InvPackageMapping> lstPackageMapping, out List<PatientInvestigation> lstPackageContents, out List<GeneralHealthCheckUpMaster> lstGeneralHealthCheckUpMaster)
        {
            long returncode = -1;
            lstPackages = new List<InvGroupMaster>();
            lstPackageMapping = new List<InvPackageMapping>();
            lstPackageContents = new List<PatientInvestigation>();
            lstGeneralHealthCheckUpMaster = new List<GeneralHealthCheckUpMaster>();
            try
            {
                SqlCommand cmd = Command.pGetCorpoRateHealthPackageDataWithClientIDCommand(OrgID, ClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstPackages);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[1], out lstPackageMapping);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[2], out lstPackageContents);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[3], out lstGeneralHealthCheckUpMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while excecuting GetHealthPackageData in Investigation_DAL", ex);
            }
            return returncode;

        }
        public long GetInvestigationshowincollecttasks(long visitID, int orgID, int LocationID, string Labno,
            LoginDetail LDetail, out List<OrderedInvestigations> lstPatientInvestigation)
        {
            long returnCode = -1;
            lstPatientInvestigation = new List<OrderedInvestigations>();
            IDataReader dataReader = null;
            try
            {
                DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
                SqlCommand cmd = Command.pGetInvestigationshowincollecttaskCommand(visitID, orgID, LocationID, Labno, DtLDetail, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        Utilities.ConvertTo(dataReader, out lstPatientInvestigation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving getInvestigationforVisit investigation_DAL", ex);
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
        public long GetLabNoforApproveShowstatus(int orgID, long visitID, string UID, out List<OrderedInvestigations> lstLabNo)
        {
            long returnCode = -1;
            lstLabNo = new List<OrderedInvestigations>();
            try
            {
                SqlCommand cmd = Command.pGetLabNoforApproveShowstatusCommand(orgID, visitID, UID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstLabNo);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving getInvestigationforVisit investigation_DAL", ex);
            }
            return returnCode;
        }
        public long GetTestDetails(int OrgID, int searchtype, long PatientID, string BillNumber, long SampleCode, out List<InvestigationQueue> lstTest)
        {
            long returnCode = -1;
            lstTest = new List<InvestigationQueue>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetTestDetailsCommand(OrgID, searchtype, PatientID, BillNumber, SampleCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTest);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while  GetTestDetails in Ivestigation_DAL", e);
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

        public long pGetbarcodePrint(long visitID, int orgID, string UID, out List<OrderedInvestigations> lstbarcode)
        {
            long returnCode = -1;
            lstbarcode = new List<OrderedInvestigations>();
            try
            {
                SqlCommand cmd = Command.pgetBarcodeprintCommand(visitID, orgID, UID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstbarcode);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving getInvestigationforVisit investigation_DAL", ex);
            }
            return returnCode;
        }

        public long GetQuickInvSamplesStatus(int OrgID, string FromDate, string ToDate, int Status, int LocationID, out List<CollectedSample> lstSamples1, out List<CollectedSample> lstSamples2, out List<InvestigationQueue> lstRetestInvestigationQueue)
        {
            long returnCode = -1;
            lstSamples1 = new List<CollectedSample>();
            lstSamples2 = new List<CollectedSample>();
            lstRetestInvestigationQueue = new List<InvestigationQueue>();
            try
            {
                SqlCommand objCommand = Command.pGetQuickInvSamplesStatusCommand(FromDate, ToDate, OrgID, Status, LocationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSamples1);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstSamples2);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstRetestInvestigationQueue);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetInvSamplesForStatus", ex);
            }
            return returnCode;
        }
        public long GetInvestigationNameFromOrgMapping(string Name, long orgid, out List<InvestigationOrgMapping> lstOrd)
        {
            long lResult = -1;
            lstOrd = new List<InvestigationOrgMapping>();
            IDataReader dataReader = null;
            SqlCommand cmd = Command.pGetInvestigationNameFromOrgMappingCommand(Name, orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        lResult = Utilities.ConvertTo(dataReader, out lstOrd);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationSymbols", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return lResult;
        }

        public long GetAbnormalReport(DateTime fDate, DateTime tDate, long LocationID, long InvestigationID, int OrgID, out  List<PatientInvestigation> lstPatientInvestigation)
        {
            lstPatientInvestigation = new List<PatientInvestigation>();
            long returnCode = -1;
            SqlCommand cmd = Command.PGetAbnormalReportCommand(fDate, tDate, LocationID, InvestigationID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientInvestigation);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAbnormalReport in Investigation_Dal", ex);
            }

            return returnCode;
        }
        /* BEGIN | NA | Sabari | 20190515 | Created | MRNNumberSearch */
        public long GetInvSamplesForStatus(int OrgID, string FromDate, string ToDate, int Status, int LocationID, string LocationType, string VisitID,
                      string PatientName, int VisitType, int Priority, string SourceName, string InvestigationName, long InvestigationID, string InvestigationType,
                      string refPhyName, long refPhyID, long refPhyOrg, long SampleID, int SearchType, string preference, out List<CollectedSample> lstSamples,
                      int PageSize, int startRowIndex, out int totalRows, string BarcodeFrom, string BarcodeTo, string UserLoginID, string SubStatus, long RegLocation, long OutLocations, string pkgout, string patientnumber)
        {
            long returncode = -1;
            totalRows = -1;
            lstSamples = new List<CollectedSample>();
            IDataReader dataReader = null;

            try
            {
                SqlCommand objCommand = Command.pGetInvSamplesForStatusCommand(OrgID, FromDate, ToDate, Status, LocationID, LocationType, VisitID, PatientName,
                                                                               VisitType, Priority, SourceName, InvestigationName, InvestigationID, InvestigationType, refPhyName, refPhyID,
                            refPhyOrg, SampleID, SearchType, preference, UDT_DAL.ConvertToUDT_Context(globalContextDetails), PageSize, startRowIndex, out totalRows, BarcodeFrom, BarcodeTo, UserLoginID, SubStatus, RegLocation, OutLocations, pkgout, patientnumber);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returncode = Utilities.ConvertTo(dataReader, out lstSamples);
                        dataReader.Close();
                    }
                    totalRows = Convert.ToInt32(objCommand.Parameters["@totalRows"].Value);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing GetInvSamplesForStatus in Investigation_DAL.cs", excep);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returncode;
        }
        /* END | NA | Sabari | 20190515 | Created | MRNNumberSearch */
        public long GetInvExpectedSamplesForStatus(int OrgID, string FromDate, string ToDate, int Status, int LocationID, string LocationType, string VisitID,
                   string PatientName, int VisitType, int Priority, string SourceName, string InvestigationName, long InvestigationID, string InvestigationType,
                   string refPhyName, long refPhyID, long refPhyOrg, long SampleID, int SearchType, out List<CollectedSample> lstSamples)
        {
            long returnCode = -1;
            lstSamples = new List<CollectedSample>();
            try
            {
                SqlCommand objCommand = Command.pGetInvExpectedSamplesForStatusCommand(FromDate, ToDate, OrgID, Status, LocationID, LocationType,
                                    VisitID, PatientName, VisitType, Priority, SourceName, InvestigationName, InvestigationID, InvestigationType, refPhyName, refPhyID,
                                                        refPhyOrg, SampleID, SearchType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSamples);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetInvSamplesForStatus", ex);
            }
            return returnCode;
        }




        public long GetInvStatus(int OrgID, string PageType, out List<InvSampleStatusmaster> lstSampleStatus)
        {
            long returnCode = -1;
            lstSampleStatus = new List<InvSampleStatusmaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetInvStatusCommand(OrgID, PageType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstSampleStatus);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetInvStatus", ex);
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


        public long GetInvReasonsForStatus(int OrgID, long StatusID, out List<InvReasonMasters> lstSampleReasons)
        {
            long returnCode = -1;
            lstSampleReasons = new List<InvReasonMasters>();
            try
            {
                SqlCommand objCommand = Command.pGetInvReasonsForStatusCommand(OrgID, StatusID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSampleReasons);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetInvReasonsForStatus", ex);
            }
            return returnCode;
        }

        public long GetInvReasons(int OrgID, out List<InvReasonMasters> lstSampleReasons)
        {
            long returnCode = -1;
            lstSampleReasons = new List<InvReasonMasters>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetInvReasonsCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstSampleReasons);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetInvReasons", ex);
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

        public long GetNextBarcode(int OrgID, long pOrgAddressID, string Type, out string Barcode, long RefID, string RefType)
        {
            long returnCode = -1;
            Barcode = "";
            try
            {
                SqlCommand cmd = Command.pGetNextIDCommand(OrgID, Type, out Barcode, pOrgAddressID, RefID, RefType);
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                    Barcode = Convert.ToString(cmd.Parameters["@ID"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetNextBarCode", ex);
            }
            return returnCode;
        }
        //added for client billing on 24/1/15 by sudhakar//
        public long GetNextMLNumber(int OrgID, long pOrgAddressID, string Type, out string MLNumber, long RefID, string RefType)
        {
            long returnCode = -1;
            MLNumber = "";
            try
            {
                SqlCommand cmd = Command.pGetcasenonextidCommand(OrgID, Type, out MLNumber, pOrgAddressID, RefID, RefType);
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                    MLNumber = Convert.ToString(cmd.Parameters["@ID"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetNextMLNumber", ex);
            }
            return returnCode;
        }


        public long GetInvestigationForSampleID(long VisitID, int OrgID, int SampleID, out List<PatientInvestigation> lstPatientInvestigation)
        {
            long returnCode = -1;
            lstPatientInvestigation = new List<PatientInvestigation>();
            try
            {
                SqlCommand objCommand = Command.pGetInvestigationForSampleIDCommand(VisitID, OrgID, SampleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientInvestigation);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetInvestigationForSampleID", ex);
            }
            return returnCode;
        }

        public long GetInvSampleMaster(int OrgID, out List<InvSampleMaster> lstInvSampleMaster)
        {
            long returnCode = -1;
            lstInvSampleMaster = new List<InvSampleMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetInvSampleMasterCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvSampleMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetInvSampleMaster", ex);
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

        public long GetSamplesByID(int OrgID, long RoleID, int SearchType, string SearchNo, out List<CollectedSample> lstOrderedSamples)
        {
            long returnCode = -1;
            lstOrderedSamples = new List<CollectedSample>();
            try
            {
                SqlCommand objCommand = Command.pGetSamplesByIDCommand(OrgID, RoleID, SearchType, SearchNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrderedSamples);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetInvReasons", ex);
            }
            return returnCode;
        }
        public long UpdateSampleStatusDetails(List<SampleTracker> lstSampleTracker)
        {
            long returncode = -1;
            DataTable dtSaveSampleTracker = new DataTable();
            dtSaveSampleTracker = UDT_DAL.ConvertToUDDinsertSampleTrack(lstSampleTracker);
            SqlCommand cmd = Command.pUpdateSampleStatusDetailsCommand(dtSaveSampleTracker, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertSampleCollectfromDeptID", ex);
            }
            return returncode;
        }

        public long GetAberrantSampleInvestigations(long VisitID, int SampleID, int OrgID, out List<OrderedInvestigations> lstInvestigations)
        {
            long returnCode = -1;
            lstInvestigations = new List<OrderedInvestigations>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetAberrantSampleInvestigationsCommand(VisitID, SampleID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));


                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvestigations);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetAberrantSampleInvestigations", ex);
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


        public long GetInvRejected(long VisitID, int OrgID, out List<PatientInvestigation> lstInvestigations)
        {
            long returnCode = -1;
            lstInvestigations = new List<PatientInvestigation>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetInvRejectedCommand(VisitID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvestigations);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetInvRejected", ex);
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


        public long GetPatientInvestigationValuesHisiory(long patientVisitID, int OrgID, long PatternID, long InvID, out List<InvestigationValues> lstPendingValues)
        {
            long lresult = -1;
            int returnStatus = -1;

            lstPendingValues = new List<InvestigationValues>();

            SqlCommand cmd = Command.pGetPatientInvestigationValuesHisioryCommand(patientVisitID, OrgID, PatternID, InvID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstPendingValues);
                }
                //if (ds.Tables[1].Rows.Count > 0)
                //{
                //    lresult = Utilities.ConvertTo(ds.Tables[1], out lstPendingValues);
                //}


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDemoBulkData DAL", ex);
            }
            return lresult;
        }

        public long GetInvestigationByGroup(Int32 OrgGroupID, out List<InvestigationMaster> lstInvMaster)
        {
            long returnCode = -1;
            lstInvMaster = new List<InvestigationMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvestigationByGroupCommand(OrgGroupID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting Investigation By Group", ex);
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

        public long GetInvComputationRuleByGroup(Int32 OrgID, Int32 OrgGroupID, out List<InvOrgGroup> lstInvOrgGroup)
        {
            long returnCode = -1;
            lstInvOrgGroup = new List<InvOrgGroup>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvComputationRuleByGroupCommand(OrgID, OrgGroupID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvOrgGroup);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting Investigation Computation Rule By Group", ex);
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

        public long UpdateInvComputationRuleByGroup(Int32 OrgGroupID, String pValidationText, String pValidationRule)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pUpdateInvComputationRuleByGroupCommand(OrgGroupID, pValidationText, pValidationRule, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while updating Investigation Computation Rule for given Group", ex);
            }
            return returnCode;
        }

        public long CancelInvestigationSample(int pOrgID, long pVisitID, int pSampleID, long pUserID)
        {
            long returncode = -1;

            SqlCommand cmd = Command.pCancelInvestigationSampleCommand(pOrgID, pVisitID, pSampleID, pUserID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL CancelInvestigationSample", ex);
            }
            return returncode;
        }
        public long SaveRetestDetails(List<OrderedInvestigations> OrderedInves, long OrgID)
        {
            int ret = -1;
            long retCode = -1;
            DataTable invs = UDT_DAL.ConvertToOrderedInvestigation(OrderedInves);
            SqlCommand cmdInvestigation = new SqlCommand();
            cmdInvestigation = Command.pSaveRetestDetailsCommand(invs, OrgID, out ret, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInvestigation);
                    retCode = Convert.ToInt32(cmdInvestigation.Parameters["@returnstatus"].Value);

                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while SaveRetestDetails investigation_DAL", e);
            }
            return retCode;

        }

        public long PatientInvSamplealiquot(int pOrgID, long pVisitID, int pSampleID, string pBarcodeNumber, int layer, string samples, string slidevalues)
        {
            long returncode = -1;

            SqlCommand cmd = Command.pInsertPatientInvSampleAliquotCommand(pOrgID, pVisitID, pSampleID, pBarcodeNumber, layer, samples, slidevalues, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL PatientInvSampleAliquot", ex);
            }
            return returncode;
        }
        public long PatientInvSampleAliquot_BlockSlide(int pOrgID, long pVisitID, int pSampleID, string pBarcodeNumber, int layer, string samples, string slidevalues)
        {
            long returncode = -1;

            SqlCommand cmd = Command.pInsertPatientInvSampleAliquot_BlockSlideCommand(pOrgID, pVisitID, pSampleID, pBarcodeNumber, layer, samples, slidevalues, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL PatientInvSampleAliquot", ex);
            }
            return returncode;
        }
        public long pgetPatientInvSampleAliquot(int pOrgID, long pVisitID, int pSampleID, string pBarcodeNumber, int returnStatus)
        {
            long lresult = -1;
            int return_Status = -1;
            SqlCommand cmd = Command.pgetPatientInvSampleAliquotCommand(pOrgID, pVisitID, pSampleID, pBarcodeNumber, return_Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    lresult = 1;
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDemoBulkData DAL", ex);
            }
            return lresult;

        }
        public long pgetPatientlayerAliquot(int pOrgID, long pVisitID, int pSampleID, string pBarcodeNumber, int returnStatus)
        {
            long lresult = -1;
            int return_Status = -1;
            SqlCommand cmd = Command.pgetPatientlayerAliquotCommand(pOrgID, pVisitID, pSampleID, pBarcodeNumber, return_Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    lresult = 1;
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDemoBulkData DAL", ex);
            }
            return lresult;

        }

        public long InvSaveDefProcCentre(string ColCentreList, string ProcCentreList, long InvestigationID, string strAllInvestigations)
        {
            long returncode = -1;
            DataTable dtInvColLocMap = UDT_DAL.ConvertToUDTInvestigationLocationMapping(ColCentreList, InvestigationID);
            DataTable dtInvProcLocMap = UDT_DAL.ConvertToUDTInvestigationLocationMapping(ProcCentreList, InvestigationID);

            SqlCommand cmd = Command.pInvSaveDefProcCentreCommand(dtInvColLocMap, dtInvProcLocMap, InvestigationID, strAllInvestigations, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InvSaveDefProcCentre", ex);
            }
            return returncode;
        }

        public long GetOutSourceInvestigations(int OrgID, long LocationID, out List<InvestigationMaster> lstOutSourceInvestigations)
        {
            long returncode = -1;
            lstOutSourceInvestigations = null;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetOutSourceInvestigationsCommand(OrgID, LocationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returncode = Utilities.ConvertTo(dataReader, out lstOutSourceInvestigations);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while excecuting investigation_dal in GetOutSourceInvestigations", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returncode;
        }

        public long ReorderInvestigation(DataTable invs, long OrgID, string LabNo)
        {
            int ret = -1;
            long retCode = -1;
            SqlCommand cmdInvestigation = new SqlCommand();
            cmdInvestigation = Command.pReorderInvestigationCommand(invs, OrgID, LabNo, out ret, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInvestigation);
                    retCode = Convert.ToInt32(cmdInvestigation.Parameters["@returnstatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving OrderedInvestigation investigation_DAL", e);
            }
            return retCode;

        }
        public long GetAliquotBarcode(string guid, long InvestigationID, long patientVisitID, int orgID, int GroupID,
                                     out List<PatientInvSampleAliquot> lstPatientInvSampleAliquot)
        {
            long lresult = -1;
            int returnStatus = -1;
            lstPatientInvSampleAliquot = new List<PatientInvSampleAliquot>();
            SqlCommand cmd = Command.pGetAliquotBarcodeCommand(guid, InvestigationID, patientVisitID, orgID, GroupID, returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstPatientInvSampleAliquot);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDemoBulkData DAL", ex);
            }
            return lresult;
        }

        public long GetInvMappedLocations(long InvestigationID, out List<InvestigationLocationMapping> lstInvMappedLocation)
        {
            long returncode = -1;
            lstInvMappedLocation = null;



            try
            {
                SqlCommand cmd = Command.pGetInvMappedLocationsCommand(InvestigationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstInvMappedLocation);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while excecuting investigation_dal in GetInvMappedLocation", ex);
            }
            return returncode;
        }
        public long GetPatientDetailsForRetest(int OrgID, string FromDate, string ToDate, long PatientID, string BillNumber, long ClientID, long LocationID, string Priority, string TestType, out List<InvestigationQueue> lstRetestPatients)
        {
            long returncode = -1;
            lstRetestPatients = new List<InvestigationQueue>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetPatientDetailsForRetestCommand(OrgID, FromDate, ToDate, PatientID, BillNumber, ClientID, LocationID, Priority, TestType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        returncode = Utilities.ConvertTo(dataReader, out lstRetestPatients);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Dal GetPatientDetailsForRetest", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returncode;
        }

        public long GetAbberantQueue(int OrgID, string FromDate, string ToDate, int LocationID, long pClientID, out List<AbberantQueue> lstAbberantQueue)
        {
            long returnCode = -1;
            lstAbberantQueue = new List<AbberantQueue>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetAbberantQueueCommand(FromDate, ToDate, OrgID, LocationID, pClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstAbberantQueue);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetAbberantQueue", ex);
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

        public long GetInvReportTemplateList(out List<InvReportMaster> lstInvReportMaster, out List<InvReportMapping> lstInvReportMapping)
        {
            long returncode = -1;
            lstInvReportMaster = new List<InvReportMaster>();
            lstInvReportMapping = new List<InvReportMapping>();
            IDataReader dataReader = null;
            int rsCount = 0;
            try
            {
                SqlCommand cmd = Command.pGetReportTemplateListCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returncode = Utilities.ConvertTo(dataReader, out lstInvReportMaster);
                            }
                            else if (rsCount == 1)
                            {
                                returncode = Utilities.ConvertTo(dataReader, out lstInvReportMapping);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while excecuting investigation_dal in GetInvReportTemplateList", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returncode;
        }


        public long GetReportTemplateMaster(List<InvReportMaster> lstReportTemplateMasterIn, out List<InvReportMaster> lstReportTemplateMasterOut, string strAction, out string DuplicateDefault)
        {
            long returncode = -1;
            lstReportTemplateMasterOut = new List<InvReportMaster>();
            DataTable InvReportTemplate = UDT_DAL.ConvertToUDTInvReportTemplateMaster(lstReportTemplateMasterIn);
            DuplicateDefault = "";
            try
            {
                SqlCommand cmd = Command.pGetReportTemplateMasterCommand(InvReportTemplate, strAction, out DuplicateDefault, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstReportTemplateMasterOut);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while excecuting investigation_dal in GetReportTemplateMaster", ex);
            }
            return returncode;
        }

        public long SaveReportTemplateMaster(List<InvReportMaster> lstReportTemplateMasterIn, string strAction, out string DuplicateDefault)
        {
            long returncode = -1;
            DataTable InvReportTemplate = UDT_DAL.ConvertToUDTInvReportTemplateMaster(lstReportTemplateMasterIn);
            DuplicateDefault = "";
            try
            {
                SqlCommand cmd = Command.pGetReportTemplateMasterCommand(InvReportTemplate, strAction, out DuplicateDefault, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                    DuplicateDefault = cmd.Parameters["@pDuplicateDefault"].Value.ToString(); //Convert.ToInt32(cmdInvestigation.Parameters["@pOrderedInvCnt"].Value);



                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while excecuting investigation_dal in SaveReportTemplateMaster", ex);
            }
            return returncode;
        }
        public long GetDeptToTrackSamplesForQucikBill(long PatientVisitID, int OrgID, long roleID, string gUID, out List<PatientInvestigation> lstSampleDept)
        {
            long returnCode = -1;
            lstSampleDept = new List<PatientInvestigation>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetDeptToTrackSamplesForQucikBillCommand(PatientVisitID, OrgID, roleID, gUID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstSampleDept);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDeptToTrackSamples Investigation_DAL", ex);
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

        public long InsertRejectedSample(long PatientVisitID, int SampleID, int InvStatusID, string InvReason, long CreatedBy, long AccessionNo)
        {
            long retCode = -1;
            SqlCommand cmdRejectSample = new SqlCommand();
            cmdRejectSample = Command.pInsertRejectedSampleCommand(PatientVisitID, SampleID, InvStatusID, InvReason, CreatedBy, AccessionNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    retCode = dbEngine.ExecuteNonQuery(cmdRejectSample);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving InsertRejectedSample investigation_DAL", e);
            }
            return retCode;

        }
        public long GetInvstatusForDropdowns(int OrgID, long taskid, out List<InvestigationStatus> lstStatus)
        {
            long returncode = -1;
            lstStatus = new List<InvestigationStatus>();

            try
            {
                SqlCommand objCommand = Command.pGetInvstatusForDropdownsCommand(OrgID, taskid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstStatus);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvstatusForDropdowns Investigation_DAL", ex);
            }
            return returncode;
        }
        public long GetCollectSampleDropDownValues(Int32 OrgID, String PageType, out List<InvSampleStatusmaster> lstInvSampleStatus, out List<InvReasonMasters> lstInvReasonMaster, out List<OrganizationAddress> lstLocation, out List<LabRefOrgAddress> lstOutsource)
        {
            long returnCode = -1;
            lstInvSampleStatus = new List<InvSampleStatusmaster>();
            lstInvReasonMaster = new List<InvReasonMasters>();
            lstLocation = new List<OrganizationAddress>();
            lstOutsource = new List<LabRefOrgAddress>();
            int rsCount = 0;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetCollectSampleDropDownValuesCommand(OrgID, PageType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvSampleStatus);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvReasonMaster);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstLocation);
                            }
                            else if (rsCount == 3)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstOutsource);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting CollectSampleDropDownValues", ex);
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
        public long GetInvreportFooter(int Orgid, long InvestigationID, out List<InvReportTemplateFooter> lstInvReportFoot)
        {
            long returnCode = -1;
            lstInvReportFoot = new List<InvReportTemplateFooter>();
            SqlCommand objCommand = new SqlCommand();
            objCommand = Command.pGetInvReportfooterCommand(Orgid, InvestigationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvReportFoot);
            }
            return returnCode;

        }

        public long GetExpectantSampleQueue(int OrgID, long RoleID, int LocationID, string FromDate, string ToDate, out List<AbberantQueue> lstExpectantQueue)
        {
            long returnCode = -1;
            lstExpectantQueue = new List<AbberantQueue>();
            try
            {
                SqlCommand objCommand = Command.pGetExpectantSampleQueueCommand(OrgID, RoleID, LocationID, FromDate, ToDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstExpectantQueue);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetAbberantQueue", ex);
            }
            return returnCode;
        }
        public long GetSummaryReportConfig(Int32 OrgID, Int64 VisitID, out List<InvSummaryReport> lstInvSummaryReport, out List<InvSummaryTrend> lstInvSummaryTrend, out List<InvestigationMaster> lstTrendInvestigations)
        {
            long returnCode = -1;
            lstInvSummaryReport = new List<InvSummaryReport>();
            lstInvSummaryTrend = new List<InvSummaryTrend>();
            lstTrendInvestigations = new List<InvestigationMaster>();
            int rsCount = 0;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetSummaryReportConfigCommand(OrgID, VisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvSummaryReport);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvSummaryTrend);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstTrendInvestigations);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting SummaryReportConfig", ex);
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

        public long SaveInvSummaryReport(Int32 pOrgID, Int64 pVisitID, Int64 pLoginID, InvSummaryReport invSummaryReport, List<InvSummaryTrend> lstInvSummaryTrend)
        {
            long returnCode = -1;
            try
            {
                DataTable dtInvSummaryReport = UDT_DAL.ConvertToInvSummaryReport(invSummaryReport);
                DataTable dtInvSummaryTrend = UDT_DAL.ConvertToInvSummaryTrend(lstInvSummaryTrend);
                SqlCommand cmd1 = Command.pSaveInvSummaryReportCommand(pLoginID, dtInvSummaryReport, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                SqlCommand cmd2 = Command.pSaveInvSummaryTrendCommand(pOrgID, pVisitID, pLoginID, dtInvSummaryTrend, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (TransactionScope tranScope = new TransactionScope())
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmd1);
                        dbEngine.ExecuteTransactionalNonQuery(cmd2);
                    }
                    tranScope.Complete();
                }
                returnCode = 0;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveInvSummaryReport in Investigation_DAL", ex);
            }
            return returnCode;
        }

        public long GetInvSuggested(Int32 pOrgID, String pSearchText, out List<InvestigationMaster> lstInvMaster)
        {
            long returnCode = -1;
            lstInvMaster = new List<InvestigationMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetSuggestedInvestigationsCommand(pOrgID, pSearchText, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvMaster);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetInvSuggested", ex);
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
        public long GetComplaints(Int32 pOrgID, String pSearchText, out List<Complaint> lstComplaint)
        {
            long returnCode = -1;
            lstComplaint = new List<Complaint>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetComplaintsCommand(pOrgID, pSearchText, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstComplaint);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetComplaints", ex);
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
        public long CheckInvSummaryReport(Int32 pOrgID, Int64 pVisitID, out List<InvReportMaster> lstInvReportMaster, out Int32 pRecordCount, out bool pShowTRF)
        {
            long returnCode = -1;
            lstInvReportMaster = new List<InvReportMaster>();
            pRecordCount = 0;
            pShowTRF = false;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pCheckInvSummaryReportCommand(pOrgID, pVisitID, out @pRecordCount, out @pShowTRF, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvReportMaster);
                        dataReader.Close();
                        Int32.TryParse(cmd.Parameters["@pRecordCount"].Value.ToString(), out pRecordCount);
                        Boolean.TryParse(cmd.Parameters["@pShowTRF"].Value.ToString(), out @pShowTRF);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetInvSummaryReport", ex);
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
        public long GetPatientDeltaValues(Int64 pVisitID, Int32 pOrgID, Int64 pPatternID, Int64 pInvID, out List<InvestigationValues> lstPatientDeltaValues)
        {
            long returnCode = -1;
            lstPatientDeltaValues = new List<InvestigationValues>();
            IDataReader dataReader = null;

            try
            {
                SqlCommand cmd = Command.pGetPatientDeltaValuesCommand(pVisitID, pOrgID, pPatternID, pInvID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPatientDeltaValues);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetPatientDeltaValues", ex);
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
        public long getSuggedtedInvestigations(Int64 pVisitID, Int32 pOrgID, out List<OrderedPatientInvs> lstOrderedPatientInvs, out List<InvValueRangeMaster> lstInvValueRangeMaster, out List<SuggestedInvMapping> lstSuggestedInvMapping)
        {
            long returnCode = -1;
            lstOrderedPatientInvs = new List<OrderedPatientInvs>();
            lstInvValueRangeMaster = new List<InvValueRangeMaster>();
            lstSuggestedInvMapping = new List<SuggestedInvMapping>();
            try
            {
                SqlCommand objCommand = Command.pgetSuggedtedInvestigationsOfVisitCommand(pVisitID, pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrderedPatientInvs);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstInvValueRangeMaster);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstSuggestedInvMapping);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL getSuggedtedInvestigations", ex);
            }
            return returnCode;
        }
        public long GetSummaryReportTemplate(Int32 pOrgID, String pTemplateType, String pSearchText, out List<InvResultTemplate> lstInvResultTemplate)
        {
            long returnCode = -1;
            lstInvResultTemplate = new List<InvResultTemplate>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetSummaryReportTemplateCommand(pOrgID, pTemplateType, pSearchText, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvResultTemplate);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetSummaryReportTemplate", ex);
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
        public long SaveOutSourcingDetails(Int32 OrgID, long CreatedBy, List<OutsourcingDetail> lstOutSourcingDetails, string OutsourcedTime, string ReceivedDateTime, string CourierDetails, string Acknowledgement, string Status)
        {
            long returnCode = -1;

            DataTable dtOutSourceDetails = UDT_DAL.ConvertToUDTOutSourcingDetails(lstOutSourcingDetails);
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pSaveOutSourcingDetailsCommand(OrgID, CreatedBy, dtOutSourceDetails, OutsourcedTime, ReceivedDateTime, CourierDetails, Acknowledgement, Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving SaveOutSourcingDetails investigation_DAL", e);
            }
            return returnCode;
        }
        public long SaveCollectedDateTimeDetails(long VisitID, long SampleId, DateTime NewCollectedDateTime, string slidevalues, string BarcodeNumber)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pSaveCollectedDateTimeDetailsCommand(VisitID, SampleId, NewCollectedDateTime, slidevalues, BarcodeNumber, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving SaveOutSourcingDetails investigation_DAL", ex);

            }

            return returnCode;
        }

        public long GetOutSourcingDetails(Int32 OrgID, long SampleId, long PatientVisitId, long SampleTrackerID, string pGuid, out List<OutsourcingDetail> lstOutsourcingDetail)
        {
            long returnCode = -1;
            lstOutsourcingDetail = new List<OutsourcingDetail>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetOutSourcingDetailsCommand(OrgID, SampleId, PatientVisitId, SampleTrackerID, pGuid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstOutsourcingDetail);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetOutSourcingDetails", ex);
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

        public long GetInvRemarks(long pInvID, int pOrgID, string pType, string pSearchText, long pRoleID, string pRemarksType, out List<Remarks> lstRemarks)
        {
            long lResult = -1;
            lstRemarks = new List<Remarks>();

            SqlCommand cmd = Command.pGetInvRemarksCommand(pInvID, pOrgID, pType, pSearchText, pRoleID, pRemarksType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lResult = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lResult = Utilities.ConvertTo(ds.Tables[0], out lstRemarks);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvRemarks", ex);
            }
            return lResult;
        }

        public long GetTestMasterDetails(Int32 pOrgID, Int64 pInvID, String pType, out List<TestMaster> lstTestMasterDetails, out List<CodingScheme> lstCodingScheme, out List<Remarks> lstInvRemarks, out List<InvOrgReferenceMapping> lstInvOrgReferenceMapping, out List<InvValueRangeMaster> lstInvValueRangeMaster, out List<InvOrgNotifications> lstInvOrgNotifications, out List<InvOrgAuthorization> lstCoAuth, out List<InvestigationBulkData> lstInvBulkData, out List<InvInstrumentMaster> lstInstrumentMaster, out List<InvestigationLocationMapping> lstLocationMapping, out List<InvDeltaCheck> objInvDeltaCheck, out List<InvValueRangeMaster> lstCrossParameter,
           out List<InvAutoCertifyValidation> lstInvAutoCertify)
        {
            long returnCode = -1;
            lstTestMasterDetails = new List<TestMaster>();
            lstCodingScheme = new List<CodingScheme>();
            lstInvRemarks = new List<Remarks>();
            lstInvOrgReferenceMapping = new List<InvOrgReferenceMapping>();
            lstInvValueRangeMaster = new List<InvValueRangeMaster>();
            lstInvOrgNotifications = new List<InvOrgNotifications>();
            lstCoAuth = new List<InvOrgAuthorization>();
            lstInvBulkData = new List<InvestigationBulkData>();
            lstInstrumentMaster = new List<InvInstrumentMaster>();
            lstLocationMapping = new List<InvestigationLocationMapping>();
            objInvDeltaCheck = new List<InvDeltaCheck>();
            lstCrossParameter = new List<InvValueRangeMaster>();
            lstInvAutoCertify = new List<InvAutoCertifyValidation>();
            IDataReader dataReader = null;
            int rsCount = 0;
            try
            {
                SqlCommand cmd = Command.pGetTestMasterDetailsCommand(pOrgID, pInvID, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstTestMasterDetails);
                            }
                            if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstCodingScheme);
                            }
                            if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvRemarks);
                            }
                            if (rsCount == 3)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstLocationMapping);

                            }
                            if (rsCount == 4)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvOrgReferenceMapping);

                            }
                            if (rsCount == 5)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvValueRangeMaster);

                            }
                            if (rsCount == 6)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvOrgNotifications);

                            }
                            if (rsCount == 7)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstCoAuth);

                            }
                            if (rsCount == 8)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvBulkData);

                            }
                            if (rsCount == 9)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInstrumentMaster);

                            }
                            if (rsCount == 10)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out objInvDeltaCheck);

                            }
                            if (rsCount == 11)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstCrossParameter);

                            }
                            if (rsCount == 12)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvAutoCertify);

                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                        returnCode = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetTestMasterDetails", ex);
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
        public long GetTestProcessingLocation(Int32 pOrgID, string pType, out List<OrganizationAddress> lstProcessingLocation)
        {
            long returnCode = -1;
            lstProcessingLocation = new List<OrganizationAddress>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetTestProcessingLocationCommand(pOrgID, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstProcessingLocation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetTestProcessingLocation", ex);
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
        public long GetTestProcessingOrgName(int OrgID, string pType, out List<Organization> lstOrgName)
        {
            long returnCode = -1;
            lstOrgName = new List<Organization>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetTestProcessingOrgNameCommand(OrgID, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstOrgName);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetTestProcessingLocation", ex);
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
        //public long SaveTestMasterDetails(TestMaster oTestMaster, List<InvRemarks> lstInvRemarks,
        //     List<InvOrgReferenceMapping> lstInvOrgReferenceMapping,
        //     InvestigationLocationMapping oInvestigationLocationMapping, Int32 pOrgID, Int64 pInvID, String pType, Int64 pLoginID, List<InvValueRangeMaster> lstInvValueRangeMaster, List<InvOrgAuthorization> lstCoAuth, string Reason)
        //{
        //    long returnCode = -1;
        //    try
        //    {

        //        SqlCommand tmhCmd = Command.pSaveTestMasterHistoryDetailsCommand(pOrgID, pInvID, pLoginID, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails), Reason);
        //        DataTable dtTestMaster = UDT_DAL.ConvertToTestMaster(oTestMaster);
        //        SqlCommand tmCmd = Command.pSaveTestMasterDetailsCommand(dtTestMaster, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
        //        DataTable dtInvRemarks = UDT_DAL.ConvertToInvRemarks(lstInvRemarks);
        //        SqlCommand irCmd = Command.pSaveInvRemarksDetailsCommand(dtInvRemarks, pOrgID, pInvID, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
        //        DataTable dtInvOrgReferenceMapping = UDT_DAL.ConvertToInvOrgReferenceMapping(lstInvOrgReferenceMapping);
        //        SqlCommand irmCmd = Command.pSaveInvOrgReferenceMappingDetailsCommand(dtInvOrgReferenceMapping, pOrgID, pInvID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
        //        DataTable dtInvestigationLocationMapping = UDT_DAL.ConvertToUDTInvestigationLocationMapping(oInvestigationLocationMapping);
        //        SqlCommand ilmCmd = Command.pSaveTestProcessingLocationCommand(dtInvestigationLocationMapping, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
        //        DataTable dtInvValueRangeMaster = UDT_DAL.ConverttoInvValueRangeMaster(lstInvValueRangeMaster);
        //        SqlCommand ivrmCmd = Command.pSaveInvValueRangeMasterCommand(dtInvValueRangeMaster, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

        //        DataTable dtInvCoAuth = UDT_DAL.ConvertToInvCoAuth(lstCoAuth);
        //        SqlCommand icaCmd = Command.pSaveInvCoAuthorizationCommand(dtInvCoAuth, pOrgID, pInvID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));


        //        using (TransactionScope tranScope = new TransactionScope())
        //        {
        //            using (DBEngine dbEngine = new DBEngine(true))
        //            {
        //                dbEngine.ExecuteTransactionalNonQuery(tmhCmd);
        //                dbEngine.ExecuteTransactionalNonQuery(tmCmd);
        //                dbEngine.ExecuteTransactionalNonQuery(irCmd);
        //                dbEngine.ExecuteTransactionalNonQuery(irmCmd);
        //                dbEngine.ExecuteTransactionalNonQuery(ilmCmd);
        //                dbEngine.ExecuteTransactionalNonQuery(ivrmCmd);
        //                dbEngine.ExecuteTransactionalNonQuery(icaCmd);
        //            }
        //            tranScope.Complete();
        //        }
        //        returnCode = 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while executing SaveTestMasterDetails in Investigation_DAL", ex);
        //    }
        //    return returnCode;
        //}
        public long GetDispatchReports(int OrgID, string FromDate, string ToDate, int LocationID, long Roleid, out List<AbberantQueue> lstAbberantQueue)
        {
            long returnCode = -1;
            lstAbberantQueue = new List<AbberantQueue>();
            try
            {
                SqlCommand objCommand = Command.pgetDispatchReportsCommand(OrgID, FromDate, ToDate, LocationID, Roleid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstAbberantQueue);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetAbberantQueue", ex);
            }
            return returnCode;
        }
        public long GetDespatchPatientReport(int statusid, string FromDate, string ToDate, int orgid, out List<PatientVisit> lstpatientvisit)
        {
            long returncode = -1;
            lstpatientvisit = new List<PatientVisit>();
            try
            {
                SqlCommand objCommand = Command.pGetDespatchPatientReportCommand(statusid, FromDate, ToDate, orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstpatientvisit);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetAbberantQueue", ex);
            }
            return returncode;
        }
        public long GetDeptToTrackSamplesWithID(List<OrderedInvestigations> OrderedInves, long InvID, string Type, int OrgID, out List<PatientInvSample> lstPatientInvSample)
        {
            long returnCode = -1;

            lstPatientInvSample = new List<PatientInvSample>();
            try
            {
                DataTable invs = UDT_DAL.ConvertToOrderedInvestigation(OrderedInves);
                SqlCommand objCommand = Command.pGetDeptToTrackSamplesWithIDCommand(InvID, Type, OrgID, invs, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientInvSample);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDeptToTrackSamples Investigation_DAL", ex);
            }
            return returnCode;
        }
        public long GetBatchWiseInvestigationResultsCaptureFormat(string VIDs, int OrgID, string BarCodeNumber, long RoleID, long DeptID, long InvID, string InvType, LoginDetail LDetail,
            string IsTrustedDetails, long WorkListID, long deviceid, string pIsAbnormal, long pHeaderID, long pProtocalGroupID, string pActionName, string pIsMaster, int pRecordCount, int pClientID, out List<PatientInvestigation> lstInvestigation)
        {
            long result = -1;
            lstInvestigation = new List<PatientInvestigation>();
            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetBatchWiseInvestigationResultsCaptureFormatCommand(VIDs, OrgID, BarCodeNumber, RoleID, DeptID, InvID, InvType, DtLDetail, IsTrustedDetails, WorkListID, deviceid, pIsAbnormal, pHeaderID, pProtocalGroupID, pActionName, pIsMaster, pRecordCount,pClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        result = Utilities.ConvertTo(dataReader, out lstInvestigation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBatchWiseInvestigationResultsCaptureFormat Investigation_DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return result;
        }

        public long GetOrderedPatientInvestigations(string Name, long orgid, out List<PatientInvestigation> lstOrdPinv)
        {
            long lResult = -1;
            lstOrdPinv = new List<PatientInvestigation>();

            SqlCommand cmd = Command.pGetOrderedPatientInvestigationsCommand(Name, orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lResult = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lResult = Utilities.ConvertTo(ds.Tables[0], out lstOrdPinv);
                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationSymbols", ex);
            }

            return lResult;
        }
        public long GetBatchWiseInvBulkData(List<PatientInvestigation> lstInve, int orgID, string pActionName,
                                     out List<InvestigationValues> lstBulkData
                                     , out List<InvestigationValues> lstPendingValues
                                     , out List<InvestigationStatus> header, out List<InvestigationOrgMapping> lstiom)
        {
            long lresult = -1;
            int returnStatus = -1;
            lstBulkData = new List<InvestigationValues>();
            lstPendingValues = new List<InvestigationValues>();
            header = new List<InvestigationStatus>();
            lstiom = new List<InvestigationOrgMapping>();
            DataTable dtPatientInv = UDT_DAL.ConvertToPatientInvestigation(lstInve);
            SqlCommand cmd = Command.pGetBatchWiseInvBulkDataCommand(dtPatientInv, orgID, pActionName, returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstBulkData);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[1], out lstPendingValues);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[2], out header);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[3], out lstiom);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBatchWiseInvBulkData DAL", ex);
            }
            return lresult;
        }
        public long BatchWiseSaveInvestigationResults(long pSCMID, List<List<InvestigationValues>> lstInvestigationValues, List<PatientInvestigation> lstInvestigation, List<PatientInvSampleResults> lstPatientInvSampleResults, List<PatientInvSampleMapping> lstPatientInvSampleMapping, List<PatientInvestigationFiles> PatientInvestigationFiles, long vid, int OrgID, int deptID, long ApprovedBy, string gUID, out int returnStatus)
        {
            long lresult = -1;
            int i;
            bool success = true;
            List<PatientInvestigation> lstPatient = new List<PatientInvestigation>();
            List<InvestigationValues> lstPatientVisit = new List<InvestigationValues>();
            List<PatientInvSampleResults> lstPInvSampleResults = new List<PatientInvSampleResults>();

            DataTable dtResults = UDT_DAL.ConvertToInvestigationResults(lstInvestigationValues);

            DataTable dtSR = UDT_DAL.ConvertToUDTinvSampleResults(lstPatientInvSampleResults);

            DataTable dtSM = UDT_DAL.ConvertToPatientInvSampleMapping(lstPatientInvSampleMapping);

            DataTable dtPatientFiles = UDT_DAL.ConvertToPatientInvestigationFiles(PatientInvestigationFiles);


            SqlCommand cmd = Command.pBatchwiseInsertInvestigationResultsCommand(dtResults, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            SqlCommand cmdSR = Command.pInsertinvSampleResultsCommand(dtSR, vid, OrgID, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            SqlCommand cmdSM = Command.pInsertInvSampleMappingCommand(dtSM, vid, OrgID, deptID, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataTable dtPatientInvestigation = UDT_DAL.ConvertToPatientInvestigation(lstInvestigation);

            SqlCommand cmdUpdateteID = Command.pUpdateBAtchWisePatientInvestigationCompleteCommand(dtPatientInvestigation, ApprovedBy, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            SqlCommand[] cmdMethod = new SqlCommand[lstPatient.Count];

            SqlCommand cmdFiles = Command.pInsertPatientInvestigationFilesCommand(dtPatientFiles, UDT_DAL.ConvertToUDT_Context(globalContextDetails));




            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        if (success)
                        {
                            dbEngine.ExecuteTransactionalNonQuery(cmdSR);
                            returnStatus = Convert.ToInt16(cmdSR.Parameters["@pReturnStatus"].Value.ToString());
                            if (returnStatus == 0)
                            {
                                dbEngine.ExecuteTransactionalNonQuery(cmdSM);
                                returnStatus = Convert.ToInt16(cmdSR.Parameters["@pReturnStatus"].Value.ToString());

                                if (returnStatus == 0)
                                {
                                    //Changed by Prasanna.S
                                    //dbEngine.ExecuteTransactionalNonQuery(cmd);
                                    //returnStatus = Convert.ToInt16(cmd.Parameters["@returnstatus"].Value.ToString());
                                    dbEngine.ExecuteTransactionalNonQuery(cmdUpdateteID);
                                    returnStatus = Convert.ToInt16(cmdUpdateteID.Parameters["@pReturnStatus"].Value.ToString());
                                    if (returnStatus == 0)
                                    {


                                        dbEngine.ExecuteTransactionalNonQuery(cmdFiles);

                                        if (success)
                                        {
                                            //Changed by Prasanna.S
                                            //dbEngine.ExecuteTransactionalNonQuery(cmdUpdateteID);
                                            //lresult = Convert.ToInt64(cmdUpdateteID.Parameters["@pReturnStatus"].Value);
                                            dbEngine.ExecuteTransactionalNonQuery(cmd);
                                            lresult = Convert.ToInt16(cmd.Parameters["@returnstatus"].Value.ToString());
                                            if (lresult != 0)
                                            {

                                                tranScope.Dispose();
                                            }



                                        }
                                    }
                                }
                            }
                            tranScope.Complete();

                        }
                    }
                }
                catch (Exception ex)
                {
                    tranScope.Dispose();
                }
            }
            //using (DBEngine dbEngine = new DBEngine())
            //{
            //    dbEngine.ExecuteNonQuery(cmd);
            //    lresult = Convert.ToInt16(cmd.Parameters["@returnstatus"].Value.ToString());
            //}
            return lresult;

        }
        public long DeleteInvOrgRefMapping(long InvRefMappingID, long DeviceMappingID, long InvID, int OrgID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pDeleteInvOrgReferenceMappingCommand(InvRefMappingID, DeviceMappingID, InvID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL DeleteInvOrgRefMapping", ex);
            }
            return returnCode;
        }
        public long GetOrgInstruments(int OrgID, out List<InvInstrumentMaster> lstInstrument)
        {
            long returnCode = -1;
            lstInstrument = new List<InvInstrumentMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetOrgInstrumentsCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInstrument);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetOrgInstruments in InvestigationDal", excp);
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

        public long GetBatchWiseWorklist(int ClientID, string WorkListType, long SearchID, int OrgID, string WLMode, string fromDate, string toDate, string TestType, long MinVistId, long MaxVisitId, string PendingDays, string TestStatus, out string Delaydays, out List<PatientInvestigation> lstPatientInvestigation)
        {
            long returnCode = -1;
            lstPatientInvestigation = new List<PatientInvestigation>();
            Delaydays = "";
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetBatchWiseWorklistCommand(ClientID, WorkListType, SearchID, OrgID, WLMode, fromDate, toDate, TestType, MinVistId, MaxVisitId, PendingDays, TestStatus, out Delaydays, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPatientInvestigation);
                        dataReader.Close();
                    }
                    Delaydays = cmd.Parameters["@DelayDays"].Value.ToString();
                }
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetBatchWiseWorklist InvestigationDAL", excp);
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

        public long GetWorkListIds(string WLID, int OrgID, out List<PatientInvestigation> lstWorkListId)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstWorkListId = new List<PatientInvestigation>();
            try
            {
                SqlCommand cmd = Command.pGetWorkListIdsCommand(WLID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstWorkListId);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing pGetWorkListIds DAL", excp);
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

        public long UpdatePatientInvestigationStatusinLab(List<PatientInvestigation> lstPatientInvestigation, out int upIS)
        {
            long returncode = -1;
            upIS = -1;
            DataTable invs = UDT_DAL.ConvertToPatientInvestigation(lstPatientInvestigation);
            SqlCommand cmd = Command.pUpdatePatientInvestigationStatusinLabCommand(invs, out upIS, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteNonQuery(cmd);
                    upIS = Convert.ToInt32(cmd.Parameters["@returnstatus"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL UpdatePatientInvestigationStatusinLab", ex);
            }
            return returncode;
        }
        public long GetSampleDetails(int SampleID, long VisitID, int OrgID, string gUID, out PatientInvSample OPatientInvSample)
        {
            long returncode = -1;
            OPatientInvSample = new PatientInvSample();
            List<PatientInvSample> lstPatientInvSample = new List<PatientInvSample>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetSampleDetailsCommand(SampleID, VisitID, OrgID, gUID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {

                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returncode = Utilities.ConvertTo(ds.Tables[0], out lstPatientInvSample);
                        OPatientInvSample = lstPatientInvSample[0];
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetSampleDetails", ex);
            }
            return returncode;
        }
        public long GetOrgGroups(string Name, int orgid, out List<InvOrgGroup> lstGroups)
        {
            long lResult = -1;
            lstGroups = new List<InvOrgGroup>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetOrgGroupsCommand(Name, orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        lResult = Utilities.ConvertTo(dataReader, out lstGroups);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOrgGroups", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }

            return lResult;
        }

        public long GetDrawPatternInvBulkData(string guid, List<InvPackageMapping> lstInvPackageMapping, long patientVisitID, int orgID, string status,
               out List<InvestigationValues> lstBulkData
          , out List<InvestigationValues> lstPendingValue, out List<InvestigationStatus> header, out List<InvestigationOrgMapping> lstiom, out List<PerformingPhysician> lPerformingPhysicain)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            int returnStatus = -1;
            DataTable invPMDT = UDT_DAL.ConvertToUDTInvPackageMapping(lstInvPackageMapping);
            lstBulkData = new List<InvestigationValues>();
            lstPendingValue = new List<InvestigationValues>();
            header = new List<InvestigationStatus>();
            lstiom = new List<InvestigationOrgMapping>();
            lPerformingPhysicain = new List<PerformingPhysician>();
            try
            {
                SqlCommand cmd = Command.pGetDrawPatternInvBulkDataCommand(guid, patientVisitID, orgID, returnStatus, invPMDT, UDT_DAL.ConvertToUDT_Context(globalContextDetails), status);
                using (DBEngine dbEngine = new DBEngine())
                {
                    int rsCount = 0;
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstBulkData);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPendingValue);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out header);
                            }
                            else if (rsCount == 3)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstiom);
                            }
                            else if (rsCount == 4)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lPerformingPhysicain);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDrawPatternInvBulkData in investigationDAL", ex);
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

        public long GetHealthPackageDataName(int Orgid, string Packagename, string Pkgcode, out List<InvOrgGroup> lstPackages, out List<InvOrgGroup> lstorggroup)
        {
            long returncode = -1;
            lstPackages = new List<InvOrgGroup>();
            lstorggroup = new List<InvOrgGroup>();
            try
            {
                SqlCommand cmd = Command.pGetHealthPackageDataNameCommand(Orgid, Packagename, Pkgcode);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstorggroup);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[1], out lstPackages);
                }
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while loading GetHealthPackageDataName in Investigation_DAL", ex);
            }
            return returncode;
        }

        public long Updatepackages(InvOrgGroup objorgrouppackages, DataTable dtCodingSchemeMaster, int CutOffTimeValue, string CutOffTimeType, string SubCategory, short ScheduleType)
        {
            long returncode = 0;
            SqlCommand cmd = Command.pUpdatepackagesCommand(objorgrouppackages.OrgGroupID, objorgrouppackages.OrgID, objorgrouppackages.DisplayText, objorgrouppackages.Remarks, objorgrouppackages.Status, objorgrouppackages.Packagecode, objorgrouppackages.ModifiedBy, objorgrouppackages.PrintSeparately, dtCodingSchemeMaster, CutOffTimeValue, CutOffTimeType, objorgrouppackages.Gender, objorgrouppackages.IsServicetaxable, UDT_DAL.ConvertToUDT_Context(globalContextDetails), SubCategory, ScheduleType, objorgrouppackages.BillingName, objorgrouppackages.IsPkgTransfer);
            cmd.Parameters.Add("@ret", SqlDbType.Int);
            cmd.Parameters["@ret"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returncode = Convert.ToInt64(cmd.Parameters["@ret"].Value);
                }
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while updating Updatepackages", ex);
            }

            return returncode;
        }

        public long GetHealthPackageDataSearch(int OrgId, string GroupName, int pkgid, out List<InvGroupMaster> lstPackages, out List<InvPackageMapping> lstPackageMapping, out List<PatientInvestigation> lstPackageContents, out List<GeneralHealthCheckUpMaster> lstGeneralHealthCheckUpMaster)
        {
            long returncode = 0;
            int rsCount = 0;
            lstPackages = new List<InvGroupMaster>();
            lstPackageMapping = new List<InvPackageMapping>();
            lstPackageContents = new List<PatientInvestigation>();
            lstGeneralHealthCheckUpMaster = new List<GeneralHealthCheckUpMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetHealthPackageDataSearchCommand(OrgId, GroupName, pkgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returncode = Utilities.ConvertTo(dataReader, out lstPackages);
                            }
                            else if (rsCount == 1)
                            {
                                returncode = Utilities.ConvertTo(dataReader, out lstPackageMapping);
                            }
                            else if (rsCount == 2)
                            {
                                returncode = Utilities.ConvertTo(dataReader, out lstPackageContents);
                            }
                            else if (rsCount == 3)
                            {
                                returncode = Utilities.ConvertTo(dataReader, out lstGeneralHealthCheckUpMaster);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPackagedataModified in Investigation_DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returncode;

        }

        public long GetSearchPackage(int OrgID, int pkgid, string status, out List<InvOrgGroup> lstpackages, int pageSize, int StartRowIndex, out int totalRows, string packagename, string Remarks, string pkgcode)
        {
            long returnCode = -1;
            lstpackages = new List<InvOrgGroup>();
            totalRows = 0;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetSearchPackageCommand(OrgID, pkgid, status, pageSize, StartRowIndex, out totalRows, packagename, Remarks, pkgcode);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstpackages);
                        dataReader.Close();
                    }
                    Int32.TryParse(cmd.Parameters["@totalRows"].Value.ToString(), out totalRows);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetSearchPackage Investigation_DAL", e);
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


        public long GetDeviceValue(int PorgID, long PvisitID, long pinvID, string pguID, out List<InvestigationValues> lstDeviceValue)
        {
            long lresult = -1;
            lstDeviceValue = new List<InvestigationValues>();
            SqlCommand cmd = Command.PGetDeviceValueCommand(PorgID, PvisitID, pinvID, pguID);
            try
            {

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[0], out lstDeviceValue);
                    }
                }
            }

            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDeviceValue DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }
        public long GetInvestigationBulkData(Int64 invId, String name, String searchText, out List<InvestigationBulkData> lstInvBulkData)
        {
            long returnCode = -1;
            lstInvBulkData = new List<InvestigationBulkData>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvestigationBulkDataCommand(invId, name, searchText);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvBulkData);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting Investigation Bulk Data", ex);
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

        public long GetInvClient(string Name, int orgid, out List<ClientMaster> lstClientMaster)
        {
            long lResult = -1;
            lstClientMaster = new List<ClientMaster>();
            IDataReader dataReader = null;
            SqlCommand cmd = Command.pGetInvClientCommand(Name, orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {


                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        lResult = Utilities.ConvertTo(dataReader, out lstClientMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvClient", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return lResult;
        }


        public long GetInvSampleMasterTransfer(string Name, int orgid, out List<InvSampleMaster> lstInvSampleMaster)
        {
            long lResult = -1;
            lstInvSampleMaster = new List<InvSampleMaster>();
            IDataReader dataReader = null;
            SqlCommand cmd = Command.pGetInvSampleMasterTransferCommand(Name, orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        lResult = Utilities.ConvertTo(dataReader, out lstInvSampleMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvSampleMasterTransfer", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return lResult;
        }

        public long GetTransferInvestionStatus(int OrgID, out List<InvestigationStatus> lstInvestigationStatus, out List<LabReferenceOrg> lstLabReferenceOrg)
        {
            long returnCode = -1;
            IDataReader dataReader = null;
            lstInvestigationStatus = new List<InvestigationStatus>();
            lstLabReferenceOrg = new List<LabReferenceOrg>();
            int rsCount = 0;
            try
            {
                SqlCommand objCommand = Command.pGetTransferInvestionStatusCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));


                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);

                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvestigationStatus);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstLabReferenceOrg);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetInvStatus", ex);
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


        public long UpdateSampleTransfer(List<PatientInvSample> lstPatientInvSample)
        {
            long retCode = -1;
            DataTable Sampletransfer = UDT_DAL.ConvertToUDDPatientInvSampleTransfer(lstPatientInvSample);

            SqlCommand cmdInvestigation = new SqlCommand();
            cmdInvestigation = Command.pUpdateSampletransferCommand(Sampletransfer, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInvestigation);
                    // retCode = Convert.ToInt32(cmdInvestigation.Parameters["@returnstatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing UpdateSampleTransfer in Investigation_DAL", e);
            }
            return retCode;
        }

        public long UpdateoneSampleTransfer(List<PatientInvSample> lstPatientInvSample)
        {
            long retCode = -1;
            DataTable Sampletransfer = UDT_DAL.ConvertToUDDPatientoneInvSampleTransfer(lstPatientInvSample);

            SqlCommand cmdInvestigation = new SqlCommand();
            cmdInvestigation = Command.pUpdateoneSampletransferCommand(Sampletransfer, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInvestigation);
                    // retCode = Convert.ToInt32(cmdInvestigation.Parameters["@returnstatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing UpdateSampleTransfer in Investigation_DAL", e);
            }
            return retCode;
        }


        public long GetInvSamplesTransferStatus(int OrgID, string FromDate, string ToDate, int Status, int LocationID, string LocationType, string VisitID,
                   string PatientName, int VisitType, int Priority, string SourceName, string InvestigationName, long InvestigationID, string InvestigationType,
                   string refPhyName, long refPhyID, long refPhyOrg, long SampleID, int SearchType, out List<CollectedSample> lstSamples, int pagesize, int startrowindex, out int totalRows, int smpleID, int ProcessedLocID,
         int OutSourceID, string BarcodeNo, int ContainerID, int ProLoaction, int Locationn, long CollectedID)
        {
            long returnCode = -1;
            totalRows = -1;
            lstSamples = new List<CollectedSample>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetInvSamplesTransferStatusCommand(FromDate, ToDate, OrgID, Status, LocationID, LocationType,
                    VisitID, PatientName, VisitType, Priority, SourceName, InvestigationName, InvestigationID, InvestigationType, refPhyName, refPhyID,
                    refPhyOrg, SampleID, SearchType, pagesize, startrowindex, out totalRows, smpleID, ProcessedLocID, OutSourceID, BarcodeNo, ContainerID, ProLoaction, Locationn, CollectedID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstSamples);
                        dataReader.Close();
                    }
                    totalRows = Convert.ToInt32(objCommand.Parameters["@totalRows"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetInvSamplesForStatus", ex);
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
        public long GetInvoneSamplesTransferStatus(int OrgID, string FromDate, string ToDate, int Status, int LocationID, string LocationType, string VisitID,
                   string PatientName, int VisitType, int Priority, string SourceName, string InvestigationName, long InvestigationID, string InvestigationType,
                   string refPhyName, long refPhyID, long refPhyOrg, long SampleID, int SearchType, out List<CollectedSample> lstSamples, int pagesize, int startrowindex, out int totalRows, int smpleID, int ProcessedLocID,
         int OutSourceID, string BarcodeNo, int ContainerID, int ProLoaction)
        {
            long returnCode = -1;
            totalRows = -1;
            lstSamples = new List<CollectedSample>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetInvoneSamplesTransferStatusCommand(FromDate, ToDate, OrgID, Status, LocationID, LocationType,
                    VisitID, PatientName, VisitType, Priority, SourceName, InvestigationName, InvestigationID, InvestigationType, refPhyName, refPhyID,
                    refPhyOrg, SampleID, SearchType, pagesize, startrowindex, out totalRows, smpleID, ProcessedLocID, OutSourceID, BarcodeNo, ContainerID, ProLoaction, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstSamples);
                        dataReader.Close();
                    }
                    totalRows = Convert.ToInt32(objCommand.Parameters["@totalRows"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetInvSamplesForStatus", ex);
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


        public long GetTimingSpecimenDelails(DateTime fromDate, DateTime toDate, int pageSize, int StartRowIndex, out int totalRows, out List<PatientInvSample> lstInvsampleList)
        {
            long returnCode = -1;
            lstInvsampleList = new List<PatientInvSample>();
            SqlCommand cmd = Command.pGetTimingSpecimenDelailsCommand(fromDate, toDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails), pageSize, StartRowIndex, out totalRows);
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvsampleList);
                totalRows = Convert.ToInt32(ds.Tables[1].Rows[0]["totalRows"]);
            }
            return returnCode;
        }
        public long GetHomeCollectionPatientDetails(long HCDID, string pType, out List<Bookings> lstHomeCollectionDetails)
        {
            long returncode = -1;
            lstHomeCollectionDetails = new List<Bookings>();
            SqlCommand cmd = Command.pGetHomeCollectionPatientDetailsCommand(HCDID, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstHomeCollectionDetails);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting GetRoleUserLogin in dal", ex);
            }
            return returncode;
        }
        public long GetSampleContainerName(string Name, int orgid, out List<InvestigationSampleContainer> lstInvestigationSampleContainer)
        {
            long lResult = -1;
            lstInvestigationSampleContainer = new List<InvestigationSampleContainer>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetSampleContainerNameCommand(orgid, Name, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        lResult = Utilities.ConvertTo(dataReader, out lstInvestigationSampleContainer);
                        dataReader.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvSampleMasterTransfer", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return lResult;
        }

        public long GetInvestigationNameForResult(string Name, long orgid, out List<PatientInvestigation> lstPatientInvestigation)
        {
            long lResult = -1;
            lstPatientInvestigation = new List<PatientInvestigation>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvestigationNameForResultCommand(Name, orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        lResult = Utilities.ConvertTo(dataReader, out lstPatientInvestigation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationSymbols", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return lResult;
        }

        public long GetDepartmentNameForResult(string Name, long RoleID, long loginID, long OrgID, out List<InvDeptMaster> lstInvDeptMaster)
        {
            long lResult = -1;
            lstInvDeptMaster = new List<InvDeptMaster>();

            SqlCommand cmd = Command.pGetDepartmentNameForResultCommand(Name, RoleID, loginID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lResult = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lResult = Utilities.ConvertTo(ds.Tables[0], out lstInvDeptMaster);
                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationSymbols", ex);
            }

            return lResult;
        }

        public long GetInvStatus(out List<InvestigationStatus> lstInvestigationStatus, out List<InvestigationStatus> lstInvestigationSampleStatus)
        {
            long returnCode = -1;
            int rsCount = 0;
            lstInvestigationStatus = new List<InvestigationStatus>();
            lstInvestigationSampleStatus = new List<InvestigationStatus>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvStatusMasterCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbengine = new DBEngine())
                {
                    dataReader = dbengine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvestigationStatus);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvestigationSampleStatus);
                            }

                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }

            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvStatus Investigation_DAL", e);
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

        public long GetExtraSampleList(long patienid, long SampleCode, int OrgID, out List<PatientInvSample> lstPatientInvSample)
        {
            long returnCode = -1;
            lstPatientInvSample = new List<PatientInvSample>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetExtraSamplesListCommand(patienid, SampleCode, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPatientInvSample);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetExtraSampleList Investigation_DAL", ex);
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


        public long GetInvStatusSampleResult(long VisitId, long OrgId, int AccessionNumber, out List<InvestigationSampleResult> lstInvestigationSampleResult)
        {
            long returnCode = -1;
            lstInvestigationSampleResult = new List<InvestigationSampleResult>();
            SqlCommand cmd = Command.pgetpatientSamplestatusCommand(VisitId, OrgId, AccessionNumber, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            using (DBEngine dbengine = new DBEngine())
            {
                dbengine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvestigationSampleResult);
            }

            return returnCode;
        }


        public long SavePatientInvSampleNMapping(List<PatientInvSample> LstPinvsample, List<PatientInvSampleMapping> LstPinvsamplemapping, string GUID, int orgid)
        {
            long returnCode = -1;
            int ret = -1;
            DataTable dtSaveIPInvSample = UDT_DAL.ConvertToIPInvSamples(LstPinvsample);
            DataTable dtSM = UDT_DAL.ConvertToPatientInvSampleMapping(LstPinvsamplemapping);
            SqlCommand cmd = Command.pSavePatientInvSampleNMappingCommand(dtSaveIPInvSample, dtSM, GUID, orgid, out ret, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteTransactionalNonQuery(cmd);
                returnCode = Convert.ToInt32(cmd.Parameters["@returnstatus"].Value);
            }

            return returnCode;
        }


        public long GetHomeCollectionDetails(long PatientID, DateTime Fromdate, DateTime Todate, long RoleID,
                          long UserID, int CollecOrgID, long CollecOrgAddrID, int LoginOrgID, DateTime BookedFrom, DateTime BookedTo, string Status,
                          string Task, out List<Bookings> lstHomeCollectionDetails,
                          string MobileNumber, string TelePhone, string pName, int PageSize, int currentPageNo, long BookingNumber, out int totalRows)
        {
            long returnCode = -1;
            totalRows = 0;
            lstHomeCollectionDetails = new List<Bookings>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetHomeCollectionDetailsCommand(PatientID, Fromdate, Todate, RoleID, UserID,
                    CollecOrgID, CollecOrgAddrID, LoginOrgID, BookedFrom, BookedTo, Status,
                    Task, UDT_DAL.ConvertToUDT_Context(globalContextDetails), MobileNumber, TelePhone, pName, PageSize, currentPageNo, BookingNumber, out totalRows);
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstHomeCollectionDetails);
                        totalRows = Convert.ToInt32(ds.Tables[1].Rows[0]["totalRows"]);
                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Save HomeCollection Details ", ex);
            }
            return returnCode;
        }



        public long UpdateInvestigationName(int OrgID, int InvID, string InvName, DataTable dtCodingSchemeMaster, string CodeType, out List<InvestigationMaster> lstInvestigation)
        {
            long returnCode = -1;
            lstInvestigation = new List<InvestigationMaster>();
            List<CodeMaster> lstCodemaster = new List<CodeMaster>();

            SqlCommand cmd = Command.pGetUpdateInvestigationNameCommand(OrgID, InvID, InvName, dtCodingSchemeMaster, CodeType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            cmd.Parameters.Add("@ret", SqlDbType.Int);
            cmd.Parameters["@ret"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@ret"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while  UpdateInvestigationName" + cmd.CommandText, ex);
            }

            return returnCode;

        }

        public long SearchGroups(int OrgID, string GrpName, out List<InvOrgGroup> lstGroups, int pageSize, int StartRowIndex, out int totalRows)
        {
            long returnCode = -1;
            totalRows = 0;
            lstGroups = new List<InvOrgGroup>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pSearchGroupsCommand(OrgID, GrpName, pageSize, StartRowIndex, out totalRows, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstGroups);
                        dataReader.Close();
                    }
                    Int32.TryParse(cmd.Parameters["@totalRows"].Value.ToString(), out totalRows);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while SearchGroups investigation_DAL", e);
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



        public long UpdateInvestigationGrpName(int groupid, int OrgID, string groupName, string remarks, string status, string ModifiedBy, DataTable dtCodingSchemeMaster)
        {
            long returncode = 0;
            SqlCommand cmd = Command.pGetUpdateInvGroupsCommand(groupid, OrgID, groupName, remarks, status, ModifiedBy, dtCodingSchemeMaster, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@ret", SqlDbType.Int);
            cmd.Parameters["@ret"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returncode = Convert.ToInt64(cmd.Parameters["@ret"].Value);
                }
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while  UpdateInvestigationGrpName", ex);
            }

            return returncode;
        }


        public long GetSampleItem(int OrgId, int ID, long visitid, out List<PatientInvSample> lstInvestigationSampleItem)
        {
            long returnCode = -1;
            lstInvestigationSampleItem = new List<PatientInvSample>();
            SqlCommand cmd = Command.pGetSampleItemCommand(OrgId, ID, visitid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            using (DBEngine dbengine = new DBEngine())
            {
                dbengine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvestigationSampleItem);
            }

            return returnCode;
        }
        public long GetReflexTestDetailsbyInvID(long InvID, int OrgID, out List<InvValueRangeMaster> lstInvValueRangeMaster)
        {
            IDataReader dataReader = null;
            lstInvValueRangeMaster = new List<InvValueRangeMaster>();
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pGetReflexTestDetailsbyInvIDCommand(InvID, OrgID);
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvValueRangeMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while  GetReflexTestDetailsbyInvID in InvestigationDAL ", ex);
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

        public long GetphlebotomistName(string Name, int OrgID, String type, long ZonalID, out List<Users> lstUsers,
            out List<EmployeeRegMaster> lstEmployeeRegMaster
            , out List<InvClientMaster> lstInvClientMaster, out List<Localities> lstLocalities)
        {
            long lResult = -1;
            lstUsers = new List<Users>();
            lstEmployeeRegMaster = new List<EmployeeRegMaster>();
            lstInvClientMaster = new List<InvClientMaster>();
            lstLocalities = new List<Localities>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetUsersForBillingCommand(OrgID, Name, type, ZonalID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        if (type == "Users")
                        {
                            lResult = Utilities.ConvertTo(dataReader, out lstUsers);
                        }
                        if (type == "PHLEBOTOMIST")
                        {
                            lResult = Utilities.ConvertTo(dataReader, out lstUsers);
                        }
                        if (type == "CLIENTZONE")
                        {
                            lResult = Utilities.ConvertTo(dataReader, out lstInvClientMaster);
                        }
                        if (type == "Zone")
                        {
                            lResult = Utilities.ConvertTo(dataReader, out lstLocalities);
                        }
                        if (type == "LogisticsZone")
                        {
                            lResult = Utilities.ConvertTo(dataReader, out lstEmployeeRegMaster);
                        }
                        else if (type == "LOGI")
                        {
                            lResult = Utilities.ConvertTo(dataReader, out lstEmployeeRegMaster);
                        }
                        else if (type == "CLP")
                        {
                            lResult = Utilities.ConvertTo(dataReader, out lstLocalities);
                        }

                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetphlebotomistName", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return lResult;
        }


        public long GetGrouplevelvalidation(long vid, int TaskActionid, List<PatientInvestigation> Patinvestasks, int OrgID, int LID, out List<PatientInvestigation> pattasks)
        {
            long returncode = -1;

            pattasks = new List<PatientInvestigation>();
            try
            {
                DataSet ds = new DataSet();
                DataTable invs = UDT_DAL.ConvertToPatientInvestigation(Patinvestasks);
                SqlCommand cmd = Command.pGetGrouplevelvalidationCommand(vid, TaskActionid, invs, OrgID, LID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returncode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returncode = Utilities.ConvertTo(ds.Tables[0], out pattasks);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Save HomeCollection Details ", ex);
            }
            return returncode;
        }

        public long SaveTestMasterDetails(TestMaster oTestMaster, List<InvRemarks> lstInvRemarks,
    List<InvOrgReferenceMapping> lstInvOrgReferenceMapping,
    InvestigationLocationMapping oInvestigationLocationMapping, Int32 pOrgID, Int64 pInvID, String pType, Int64 pLoginID, List<InvValueRangeMaster> lstInvValueRangeMaster, List<InvOrgNotifications> lstInvOrgNotifications, List<InvOrgAuthorization> lstCoAuth, List<InvestigationLocationMapping> lstInvLocation, string Reason, List<BulkReferenceRange> InvReferenceRR, InvDeltaCheck oInvDeltaCheck, List<InvValueRangeMaster> lstInvCrossparameterTest,
            List<InvAutoCertifyValidation> lstInvAutoCertify)
      {
            long returnCode = -1;
            try
            {

                SqlCommand tmhCmd = Command.pSaveTestMasterHistoryDetailsCommand(pOrgID, pInvID, pLoginID, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails), Reason);
                DataTable dtTestMaster = UDT_DAL.ConvertToTestMaster(oTestMaster);
                SqlCommand tmCmd = Command.pSaveTestMasterDetailsCommand(dtTestMaster, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataTable dtInvRemarks = UDT_DAL.ConvertToInvRemarks(lstInvRemarks);
                SqlCommand irCmd = Command.pSaveInvRemarksDetailsCommand(dtInvRemarks, pOrgID, pInvID, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataTable dtInvOrgReferenceMapping = UDT_DAL.ConvertToInvOrgReferenceMapping(lstInvOrgReferenceMapping);
                DataTable dtBulkRR = UDT_DAL.ConvertToInvRR(InvReferenceRR);
                SqlCommand irmCmd = Command.pSaveInvOrgReferenceMappingDetailsCommand(dtInvOrgReferenceMapping, pOrgID, pInvID, UDT_DAL.ConvertToUDT_Context(globalContextDetails), dtBulkRR);
                DataTable dtInvestigationLocationMapping = UDT_DAL.ConvertToUDTInvestigationLocationMapping(oInvestigationLocationMapping);
                SqlCommand ilmCmd = Command.pSaveTestProcessingLocationCommand(dtInvestigationLocationMapping, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataTable dtInvValueRangeMaster = UDT_DAL.ConverttoInvValueRangeMaster(lstInvValueRangeMaster);
                SqlCommand ivrmCmd = Command.pSaveInvValueRangeMasterCommand(dtInvValueRangeMaster, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataTable dtInvOrgNotifications = UDT_DAL.ConvertToUDTInvOrgNotifications(lstInvOrgNotifications);
                SqlCommand Notecmd = Command.pSaveNotificationCommand(pInvID, pOrgID, dtInvOrgNotifications, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataTable dtInvCoAuth = UDT_DAL.ConvertToInvCoAuth(lstCoAuth);
                SqlCommand icaCmd = Command.pSaveInvCoAuthorizationCommand(dtInvCoAuth, pOrgID, pInvID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataTable dtInvLocationmapping = UDT_DAL.ConvertToUDTInvestigationLocationMappingList(lstInvLocation);
                SqlCommand InvLocMapCmd = Command.pSaveInvLocationMappingCommand(dtInvLocationmapping, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));


                DataTable dtInvDeltacheck = UDT_DAL.ConvertToUDTInvDeltacheckList(oInvDeltaCheck);
                DataTable dtInvCrossparameterTest = UDT_DAL.ConverttoInvValueRangeMaster(lstInvCrossparameterTest);
                SqlCommand InvDeltachkCmd = Command.pSaveInvDeltaCheckCommand(dtInvDeltacheck, dtInvCrossparameterTest, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataTable dtInvAtutoCertify = UDT_DAL.ConvertToUDTInvAutoCertifyValidation(lstInvAutoCertify);
                SqlCommand InvAutoCertifycmd = Command.pSaveInvAutoCertifyCommand(dtInvAtutoCertify, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                

                using (TransactionScope tranScope = new TransactionScope())
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(tmhCmd);
                        dbEngine.ExecuteTransactionalNonQuery(tmCmd);
                        dbEngine.ExecuteTransactionalNonQuery(irCmd);
                        dbEngine.ExecuteTransactionalNonQuery(irmCmd);
                        dbEngine.ExecuteTransactionalNonQuery(ilmCmd);
                        dbEngine.ExecuteTransactionalNonQuery(ivrmCmd);
                        dbEngine.ExecuteTransactionalNonQuery(Notecmd);
                        dbEngine.ExecuteTransactionalNonQuery(icaCmd);
                        dbEngine.ExecuteTransactionalNonQuery(InvLocMapCmd);
                        dbEngine.ExecuteTransactionalNonQuery(InvDeltachkCmd);
                        dbEngine.ExecuteNonQuery(InvAutoCertifycmd);
                    }
                    tranScope.Complete();
                }
                returnCode = 0;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveTestMasterDetails in Investigation_DAL", ex);
            }
            return returnCode;
        }

        public long GetTemplatesforAction(string ActionName, out List<ActionTemplate> lstActiontemplate)
        {
            long returnCode = -1;
            lstActiontemplate = new List<ActionTemplate>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetTemplatesforActionCommand(ActionName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbengine = new DBEngine())
                {
                    dataReader = dbengine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstActiontemplate);
                        dataReader.Close();
                    }

                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetTemplatesforAction Investigation_DAL", e);
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


        public long DeleteInvCoAuth(long ID, long InvID, int OrgID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pDeleteInvCoAuthCommand(ID, InvID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL DeleteInvCoAuthCommand", ex);
            }
            return returnCode;
        }

        public long getReferencerangetype(int orgid, string LangCode, out List<ReferenceRangeType> lstReferenceRangeType)
        {
            long returnCode = -1;
            IDataReader dataReader = null;
            lstReferenceRangeType = new List<ReferenceRangeType>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pgetReferencerangetypeCommand(orgid, LangCode);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstReferenceRangeType);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading getReferencerangetype in investgationDal", ex);
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



        public long UpdateReceiveSamplePickedBy(long PatientVisitID, long LID, string IsClearPickedBy, out string IsAlreadyPicked)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pUpdateReceiveSamplePickedByCommand(PatientVisitID, LID, IsClearPickedBy, out IsAlreadyPicked, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                    if (returnCode == 0)
                        IsAlreadyPicked = Convert.ToString(cmd.Parameters["@pIsAlreadyInProgress"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateReceiveSamplePickedBy in Investigation_DAL", ex);
            }
            return returnCode;
        }
        public long ProbeImagesForPatientVisits(long pPatientVisitid, long pInvestigationId, long POrgID, out List<PatientInvestigationFiles> lstpatientImages)
        {
            IDataReader dataReader = null;
            lstpatientImages = new List<PatientInvestigationFiles>();
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pProbeImagesForPatientCommand(pPatientVisitid, pInvestigationId, POrgID);
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstpatientImages);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting  ProbeImagesForPatientVisits Details ", ex);
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

        public long GetImageForProbes(long PatientVisitID, long InvestigationID, long ImageID, long POrgID, out PatientInvestigationFiles lstLogin)
        {
            long returnCode = -1;

            lstLogin = new PatientInvestigationFiles();
            List<PatientInvestigationFiles> probes = new List<PatientInvestigationFiles>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.PGetImageForProbesCommand(PatientVisitID, InvestigationID, ImageID, POrgID);
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out probes);
                    }
                    if (probes.Count > 0)
                    {
                        lstLogin = probes[0];

                        if (!string.IsNullOrEmpty(lstLogin.ServerFilePath))
                        {
                            System.Drawing.Image imageIn = System.Drawing.Image.FromFile(lstLogin.ServerFilePath);

                            using (var ms = new MemoryStream())
                            {
                                imageIn.Save(ms, imageIn.RawFormat);
                                lstLogin.ImageSource = ms.ToArray();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetImageForProbes Investigation_DAL", ex);
            }

            return returnCode;
        }
        public long DeleteProbeImageDeatils(long PVisitId, long Pinvid, int OrgID, long ImageId)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.PDeleteProbeImagesCommand(PVisitId, Pinvid, OrgID, ImageId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL DeleteProbeImageDeatils", ex);
            }
            return returnCode;
        }
        public long GetProbeNames(long Pinvid, out List<InvestigationBulkData> lstbulkdata)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstbulkdata = new List<InvestigationBulkData>();
            try
            {
                SqlCommand cmd = Command.PGetProbeNamesCommand(Pinvid);
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstbulkdata);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetProbeNames", ex);
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


        public long GetMappingStatus(int TaskActionID, string MappingType, int OrgID, out List<InvestigationStatus> lstInvestigationStatus)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstInvestigationStatus = new List<InvestigationStatus>();
            try
            {
                SqlCommand cmd = Command.pGetMappingStatusCommand(TaskActionID, MappingType, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvestigationStatus);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetMappingStatus", ex);
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

        public long GetSignalPatterns(long Pinvid, int orgid, out List<InvResultTemplate> lstInvResultTemplate)
        {
            long returnCode = -1;
            lstInvResultTemplate = new List<InvResultTemplate>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.PGetSPLegendsCommand(Pinvid, orgid);
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvResultTemplate);
                    }

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetSignalPatterns", ex);
            }
            return returnCode;
        }


        public long GetInvSamplesforOutSource(int OrgID, string SubStatus, long OutLocations, out List<OutsourcingDetail> lstOutSourcingDetail)
        {
            long returncode = -1;
            lstOutSourcingDetail = new List<OutsourcingDetail>();
            try
            {
                SqlCommand objCommand = Command.pGetInvSamplesforOutSourceCommand(OrgID, SubStatus, OutLocations, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }

                if (ds.Tables.Count >= 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstOutSourcingDetail);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetInvSamplesforOutSource", ex);
            }
            return returncode;
        }
        public long GetOutSourcedLocations(int OrgID, out List<LabReferenceOrg> lstLabRefOrg)
        {
            long returnCode = -1;
            lstLabRefOrg = new List<LabReferenceOrg>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetOutSourcedLocationsCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));


                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstLabRefOrg);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetOutSourcedLocations in Investigation_DAL.cs", ex);
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

        public long GetBarcodeNumForDoFromVisit(long OrgID, long DoFromVisitID, out string Barcode, int SampleCode, string UID, string type, int containerID)
        {
            long returnCode = -1;
            Barcode = "";
            try
            {
                SqlCommand cmd = Command.pGetBarcodeNumForDoFromVisitCommand(OrgID, DoFromVisitID, out Barcode, SampleCode, UID, type, containerID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                    Barcode = Convert.ToString(cmd.Parameters["@pBarcodenumber"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetBarcodeNumForDoFromVisit", ex);
            }
            return returnCode;
        }
        public long GetInvBulkDataAuto(long InvID, long GrpID, int OrgID, string KeyName, out  List<InvestigationBulkData> lstBulkData)
        {
            long returnCode = -1;
            lstBulkData = new List<InvestigationBulkData>();
            SqlCommand cmd = Command.pGetInvBulkDataAutoCommand(InvID, GrpID, OrgID, KeyName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBulkData);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetInvBulkDataAuto", ex);
            }
            return returnCode;
        }

        public long GetPatientOrderedInvestigation(long patientVisitID, int OrgID, long grpid, string type, long accNo, string parentType, out List<OrderedInvestigations> lstOrderedInvestigations, out List<OrderedInvestigations> lstMasterreflex)
        {
            long returnCode = -1;
            IDataReader dataReader = null;
            lstOrderedInvestigations = new List<OrderedInvestigations>();
            lstMasterreflex = new List<OrderedInvestigations>();
            try
            {
                SqlCommand cmd = Command.PgetpatientorderedinvestigationCommand(patientVisitID, OrgID, grpid, type, accNo, parentType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    int rsCount = 0;
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstOrderedInvestigations);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstMasterreflex);
                            }

                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientOrderedInvestigation in InvestigationDAL", ex);
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


        public long GetOrganismList(long pInvID, out List<OrganismMaster> lstOrganismMaster)
        {
            long returnCode = -1;
            lstOrganismMaster = new List<OrganismMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetOrganismListCommand(pInvID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstOrganismMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting organism list", ex);
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
        public long GetOrganismDrugDetails(long pInvID, long pOrganismID, string pOrganismCode, string pType, out List<InvOrganismDrugMapping> lstOrganismDrugDetails)
        {
            long returnCode = -1;
            lstOrganismDrugDetails = new List<InvOrganismDrugMapping>();
            IDataReader dataReader = null;

            try
            {
                SqlCommand cmd = Command.pGetOrganismDrugDetailsCommand(pInvID, pOrganismID, pOrganismCode, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstOrganismDrugDetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting organism drug details", ex);
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
        public long GetPatientInvestigationStatus(long pVisitID, int pOrgID, out List<PatientInvestigation> lstPatientInvestigation)
        {
            long returnCode = -1;
            lstPatientInvestigation = new List<PatientInvestigation>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetPatientInvestigationStatusCommand(pVisitID, pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPatientInvestigation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting patient investigation status details", ex);
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
        public long GetBatchWiseDropDownValues(int pOrgID, LoginDetail oLoginDetails, out List<InvInstrumentMaster> lstInstrumentMaster, out List<InvDeptMaster> lstDeptMaster, out List<InvestigationHeader> lstInvHeaderMaster, out List<MetaDataOrgMapping> lstProtocolGroupMaster)
        {
            long returnCode = -1;
            lstInstrumentMaster = new List<InvInstrumentMaster>();
            lstDeptMaster = new List<InvDeptMaster>();
            lstInvHeaderMaster = new List<InvestigationHeader>();
            lstProtocolGroupMaster = new List<MetaDataOrgMapping>();
            IDataReader dataReader = null;
            int rsCount = 0;
            try
            {
                DataTable DTLoginDetails = UDT_DAL.ConvertToLoginDetail(oLoginDetails);
                SqlCommand cmd = Command.pGetBatchWiseDropDownValuesCommand(pOrgID, DTLoginDetails, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInstrumentMaster);
                            }
                            if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstDeptMaster);
                            }
                            if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvHeaderMaster);
                            }
                            if (rsCount == 3)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstProtocolGroupMaster);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                        returnCode = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting batchwise dropdown value details", ex);
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
        /* ----------------Prasanna.S - Batch sheet-----------------------*/
        public long GetORCheckGeneratedBatch(int OrgID, DateTime FromDate, DateTime ToDate, int SourceLocationID, int ProcessingLocationID, out int isExists, string pType, out List<BatchSheet> lstBatchSheet, string Prefix)
        {
            long returnCode = -1;
            isExists = 0;
            lstBatchSheet = new List<BatchSheet>();
            try
            {
                SqlCommand cmd = Command.PgetorcheckgeneratedbatchCommand(OrgID, FromDate, ToDate, SourceLocationID, ProcessingLocationID, out isExists, pType, Prefix, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    if (pType == "GET" || pType == "REPORT")
                    {
                        dbEngine.ExecuteDataSet(cmd, out ds);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBatchSheet);
                        }
                    }
                    else
                    {
                        returnCode = dbEngine.ExecuteNonQuery(cmd);
                        isExists = Convert.ToInt32(cmd.Parameters["@IsExists"].Value.ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetORCheckGeneratedBatch", ex);
            }
            return returnCode;
        }

        public long SaveBatchSheet(int OrgID, DateTime FromDate, DateTime ToDate, int SourceLocationID, int ProcessingLocationID, long CreatedBy, DataTable BatchSheet, out string BatchNo)
        {
            long retCode = -1;
            SqlCommand cmdInvestigation = new SqlCommand();
            BatchNo = string.Empty;
            cmdInvestigation = Command.pSaveBatchSheetCommand(OrgID, FromDate, ToDate, SourceLocationID, ProcessingLocationID, CreatedBy, BatchSheet, out BatchNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInvestigation);
                    BatchNo = cmdInvestigation.Parameters["@BatchNo"].Value.ToString();
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving SaveBatchSheet investigation_DAL", e);
            }
            return retCode;
        }

        public long UpdateBatchSheet(int OrgID, DateTime FromDate, DateTime ToDate, int SourceLocationID, int ProcessingLocationID, long CreatedBy, DataTable BatchSheet, int Batchid)
        {
            long retCode = -1;
            SqlCommand cmdInvestigation = new SqlCommand();

            cmdInvestigation = Command.pUpdateBatchSheetCommand(OrgID, FromDate, ToDate, SourceLocationID, ProcessingLocationID, CreatedBy, BatchSheet, Batchid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    retCode = dbEngine.ExecuteNonQuery(cmdInvestigation);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving SaveBatchSheet investigation_DAL", e);
            }
            return retCode;
        }
        /* ----------------Prasanna.S - Batch sheet-----------------------*/

        /*/ ----------------Sathish.E------------------/*/
        public long GetSamplesForBatch(int OrgID, string BatchNumber, out List<SampleBatchTrackerDetails> lstSampleBatchTrackerDetails, out List<SampleBatchTrackerConflictDetails> lstSampleBatchTrackerConflictDetails)
        {
            long returnCode = -1;
            lstSampleBatchTrackerDetails = new List<SampleBatchTrackerDetails>();
            lstSampleBatchTrackerConflictDetails = new List<SampleBatchTrackerConflictDetails>();
            IDataReader dataReader = null;
            int rsCount = 0;
            try
            {

                SqlCommand cmd = Command.pGetSamplesForBatchCommand(OrgID, BatchNumber, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstSampleBatchTrackerDetails);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstSampleBatchTrackerConflictDetails);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Investigation_DAL- GetSamplesForBatch", ex);
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
        /*/ ----------------Sathish.E------------------/*/

        /*/ ----------------Sathish.E------------------/*/
        public long UpdateSampleBatchTrackerDetails(List<SampleBatchTrackerDetails> lstSampleBatchTracker, List<SampleBatchTrackerConflictDetails> lstSampleBatchConflictDetails)
        {

            long returnCode = -1;
            try
            {
                DataSet ds = new DataSet();
                DataTable DtSampleBatchTrackerDetails = new DataTable();
                DtSampleBatchTrackerDetails = UDT_DAL.ConvertToSampleBatchTrackerDetails(lstSampleBatchTracker);
                DataTable DtSampleBatchConflictDetails = new DataTable();
                DtSampleBatchConflictDetails = UDT_DAL.ConvertToSampleBatchConflictDetails(lstSampleBatchConflictDetails);

                SqlCommand cmd = Command.pUpdateSampleBatchTrackerDetailsCommand(DtSampleBatchTrackerDetails, DtSampleBatchConflictDetails, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while UpdateSampleBatchTrackerDetails in Investigation_DAL", ex);
            }

            return returnCode;
        }
        /*/ ----------------Sathish.E------------------/*/

        public long GetOrderedInvStatus(long VisitId, long OrgId, string AccessionNumber, out List<OrderedInvestigations> lstOrderedInvestigations)
        {
            long returnCode = -1;
            lstOrderedInvestigations = new List<OrderedInvestigations>();
            SqlCommand cmd = Command.pGetOrderedInvStatusCommand(VisitId, OrgId, AccessionNumber, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            using (DBEngine dbengine = new DBEngine())
            {
                dbengine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrderedInvestigations);
            }

            return returnCode;
        }
        public long GetInvestigationAbbCode(int GroupId, long VisitNumber, out List<DeviceImportData> LstDevice)
        {
            long returnCode = -1;
            LstDevice = new List<DeviceImportData>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvestigationAbbCodeCommand(GroupId, VisitNumber, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out LstDevice);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting patient investigation status details", ex);
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
        public long SaveQuickApprovalInvestigationResults(List<PatientInvestigation> lstInvestigation)
        {
            long lresult = -1;
            try
            {
                int returnStatus = -1;
                DataTable dtPatientInvestigation = UDT_DAL.ConvertToPatientInvestigation(lstInvestigation);

                SqlCommand cmd = Command.pSaveQuickApprovalInvestigationResultsCommand(dtPatientInvestigation, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (TransactionScope tranScope = new TransactionScope())
                {
                    try
                    {
                        using (DBEngine dbEngine = new DBEngine(true))
                        {
                            dbEngine.ExecuteTransactionalNonQuery(cmd);
                            lresult = Convert.ToInt16(cmd.Parameters["@returnstatus"].Value.ToString());
                            if (lresult != 0)
                            {
                                tranScope.Dispose();
                            }
                            tranScope.Complete();
                        }
                    }
                    catch (Exception ex)
                    {
                        tranScope.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in saving quick approval investigation results", ex);
            }
            return lresult;
        }
        public long GetInvAuthorizationList(long pVisitID, int pOrgID, out List<InvOrgAuthorization> lstInvOrgAuthorization)
        {
            long returnCode = -1;
            lstInvOrgAuthorization = new List<InvOrgAuthorization>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvAuthorizationListCommand(pVisitID, pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvOrgAuthorization);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting investigation authorization details", ex);
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


        public long SaveInvestigationQueue(List<InvestigationQueue> InvQueue, long OrgID)
        {
            int ret = -1;
            long retCode = -1;
            DataTable invs = UDT_DAL.ConvertToInvestigationQueue(InvQueue);
            SqlCommand cmdInvQueue = new SqlCommand();
            cmdInvQueue = Command.pInsertInvestigationQueueCommand(invs, OrgID, out ret, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInvQueue);
                    retCode = Convert.ToInt32(cmdInvQueue.Parameters["@returnstatus"].Value);

                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving OrderedInvestigation investigation_DAL", e);
            }
            return retCode;

        }
        public long DeleteReflexTest(List<InvValueRangeMaster> lstInvValueRangeMaster)
        {
            long returnCode = -1;
            DataTable dtInvValueRangeMaster = UDT_DAL.ConverttoInvValueRangeMaster(lstInvValueRangeMaster);
            try
            {
                SqlCommand cmd = Command.pSaveInvValueRangeMasterCommand(dtInvValueRangeMaster, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL DeleteInvOrgRefMapping", ex);
            }
            return returnCode;
        }

        public long UpdateInvStatus(List<PatientInvestigation> lstpatientIds, int OrgId)
        {
            long returnCode = -1;
            try
            {

                DataTable DtPatientIds = new DataTable();
                DtPatientIds = UDT_DAL.ConvertToUDTPatientInvestigation(lstpatientIds);
                SqlCommand cmd = Command.pUpdateInvestigationUnloadStatusCommand(DtPatientIds, OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();

                using (DBEngine dbengine = new DBEngine(false))
                {
                    dbengine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while UpdateSampleBatchTrackerDetails in Investigation_DAL", ex);
            }

            return returnCode;
        }


        public long GetInvStatusLoad(string VIDs, int OrgID, long RoleID, long DeptID, string InvName, string InvType, LoginDetail LDetail,
                    string IsTrustedDetails, long WorkListID, long deviceid, string pIsAbnormal, long pHeaderID, long pProtocalGroupID, string pActionName, string pIsMaster, out List<PatientInvestigation> lstInvestigation)
        {
            long result = -1;
            lstInvestigation = new List<PatientInvestigation>();
            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvStatusLoadCommand(VIDs, OrgID, RoleID, DeptID, InvName, InvType, DtLDetail, IsTrustedDetails, WorkListID, deviceid, pIsAbnormal, pHeaderID, pProtocalGroupID, pActionName, pIsMaster, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        result = Utilities.ConvertTo(dataReader, out lstInvestigation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvStatusLoad Investigation_DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return result;
        }
        public long GetPendingList(int OrgID, long RoleID, long InvID, string InvType, LoginDetail LDetail,
             string IsTrustedDetails, long deviceid, long pProtocalGroupID, DateTime fromdate, DateTime todate, string pStatus, string IsSTAT, long pDeptid, string pGroupLevel, out List<PatientInvestigation> lstInvestigation)
        {
            long result = -1;
            lstInvestigation = new List<PatientInvestigation>();
            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetPendingListCommand(OrgID, RoleID, InvID, InvType, DtLDetail, IsTrustedDetails, deviceid, pProtocalGroupID, fromdate, todate, pStatus, IsSTAT, pDeptid, pGroupLevel, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        result = Utilities.ConvertTo(dataReader, out lstInvestigation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPendingList Investigation_DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return result;
        }
        public long GetPatientInvestigationStatus(long pVisitID, int pOrgID, string UID, out List<InvestigationStatus> lstInvStatus, out List<PatientVisitDetails> lstVisitDetails, out int completedCount, out int notGivenCount)
        {
            long returnCode = -1;
            lstInvStatus = new List<InvestigationStatus>();
            lstVisitDetails = new List<PatientVisitDetails>();
            completedCount = 0;
            notGivenCount = 0;
            int rsCount = 0;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetBatchWisePatientInvestigationStatusCommand(pVisitID, pOrgID, UID, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out completedCount, out notGivenCount);
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvStatus);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstVisitDetails);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                        returnCode = 0;
                    }
                    Int32.TryParse(cmd.Parameters["@pCompletedCount"].Value.ToString(), out completedCount);
                    Int32.TryParse(cmd.Parameters["@pNotGivenCount"].Value.ToString(), out notGivenCount);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting patient investigation status details", ex);
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
        public long GetBatchWiseBulkData(List<PatientInvestigation> lstInve, int orgID, string pActionName,
                                     out List<InvestigationValues> lstBulkData
                                     , out List<InvestigationValues> lstPendingValues
                                     , out List<InvestigationStatus> header, out List<InvestigationOrgMapping> lstiom)
        {
            IDataReader dataReader = null;
            long lresult = -1;
            int rsCount = 0;
            int returnStatus = -1;
            lstBulkData = new List<InvestigationValues>();
            lstPendingValues = new List<InvestigationValues>();
            header = new List<InvestigationStatus>();
            lstiom = new List<InvestigationOrgMapping>();
            DataTable dtPatientInv = UDT_DAL.ConvertToBatchWisePatientInvestigation(lstInve);

            try
            {
                SqlCommand cmd = Command.pGetBatchWiseBulkDataCommand(dtPatientInv, orgID, pActionName, returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                lresult = Utilities.ConvertTo(dataReader, out lstBulkData);
                            }
                            else if (rsCount == 1)
                            {
                                lresult = Utilities.ConvertTo(dataReader, out lstPendingValues);
                            }
                            else if (rsCount == 2)
                            {
                                lresult = Utilities.ConvertTo(dataReader, out header);
                            }
                            else if (rsCount == 3)
                            {
                                lresult = Utilities.ConvertTo(dataReader, out lstiom);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBatchWiseInvBulkData DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return lresult;
        }


        public long ApprovePatientInvestigationStatus(List<PatientInvestigation> InvestigationList, string gUID, out int returnStatus)
        {
            long returnCode = -1;
            returnStatus = -1;
            try
            {
                DataTable dtPatientInvestigation = UDT_DAL.ConvertToPatientInvestigation(InvestigationList);
                SqlCommand cmdUpdateteID = Command.pApprovePatientInvestigationStatusCommand(dtPatientInvestigation, gUID, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdUpdateteID);
                    returnStatus = Convert.ToInt16(cmdUpdateteID.Parameters["@pReturnStatus"].Value.ToString());

                }

            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing saveInvestigationValues BL", excp);
            }

            return returnCode;
        }
        public long GetDiscountSlab(int DiscountId, out List<DiscountMaster> lstDiscountMaster, out List<InvReasonOrgMapping> lstDiscountReason)
        {
            long result = -1;
            int rsCount = 0;
            lstDiscountMaster = new List<DiscountMaster>();
            lstDiscountReason = new List<InvReasonOrgMapping>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetDiscountSlabCommand(DiscountId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                result = Utilities.ConvertTo(dataReader, out lstDiscountMaster);
                            }
                            else if (rsCount == 1)
                            {
                                result = Utilities.ConvertTo(dataReader, out lstDiscountReason);
                            }

                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPendingList Investigation_DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return result;
        }




        public long SaveTRFverificationDetails(long PatientVisitId, bool IsEdit)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pSaveTRFverificationDetailsCommand(PatientVisitId, IsEdit, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving SaveOutSourcingDetails investigation_DAL", ex);

            }

            return returnCode;
        }


        public long UpdatePatientdetails(long PatientID, long PatientVisitID, int Titlecode, string Name, string Gender, string PatientAddress1, string PatientAddress2, string City, string Age, string AgeDesc, string Mobileno, string Landlineno, DateTime DOB, string EmailID, long RefPhyID, string RefPhyName, int orgID, List<PatientHistoryExt> lstpatientHistory, out long FinallBillId)
        {
            long retCode = -1;
            SqlCommand cmdPatientDetails = new SqlCommand();
            DataTable lstpat = new DataTable();
            lstpat = UDT_DAL.ConvertToUDTPatientHistoryDetails(lstpatientHistory);

            cmdPatientDetails = Command.pupdatepatientdetailsCommand(PatientID, PatientVisitID, Titlecode, Name, Gender, PatientAddress1, PatientAddress2, City, Age, AgeDesc, Mobileno, Landlineno, DOB, EmailID, RefPhyID, RefPhyName, orgID, lstpat, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out FinallBillId);
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    retCode = dbEngine.ExecuteNonQuery(cmdPatientDetails);
                    FinallBillId = Convert.ToInt64(cmdPatientDetails.Parameters["@FinallBillId"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving SaveBatchSheet investigation_DAL", e);
            }
            return retCode;
        }

        public long CheckInvImageAttachmentMandatory(Int32 pOrgID, Int64 pVisitID, out bool pIsAttachmentMandatory, out bool pHasAttachment)
        {
            long returnCode = -1;
            pIsAttachmentMandatory = false;
            pHasAttachment = false;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pCheckInvImageAttachmentMandatoryCommand(pVisitID, pOrgID, out pIsAttachmentMandatory, out pHasAttachment);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        dataReader.Close();

                        Boolean.TryParse(cmd.Parameters["@pIsAttachmentMandatory"].Value.ToString(), out pIsAttachmentMandatory);
                        Boolean.TryParse(cmd.Parameters["@pHasAttachment"].Value.ToString(), out pHasAttachment);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL CheckInvImageAttachmentMandatory", ex);
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
        public long GetRecollectCount(long VisitId, long ID, int pOrgID, out List<InvestigationQueue> lstInvestigationQueue)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstInvestigationQueue = new List<InvestigationQueue>();
            SqlCommand cmd = Command.pGetRecollectCountCommand(VisitId, ID, pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvestigationQueue);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetRecollectCount in Investigation_DAL", ex);
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

        public long GetMemberDetails(string MemberCardNo, string CardType, string Type, out List<PatientMembershipCardMapping> lstPatientCardMap)
        {
            long result = -1;
            lstPatientCardMap = new List<PatientMembershipCardMapping>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetMemberDetailsCommand(MemberCardNo, CardType, Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        result = Utilities.ConvertTo(dataReader, out lstPatientCardMap);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetMemberDetails Investigation_DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }

            return result;
        }
        public long SaveMemberShipCardOTP(long MembershipCardMappingId, string OTP, out List<PatientMembershipCardMapping> lstPatientCardMap)
        {
            long result = -1;
            lstPatientCardMap = new List<PatientMembershipCardMapping>();
            SqlCommand cmd = Command.pSaveMemberShipCardOTPCommand(MembershipCardMappingId, OTP, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[0], out lstPatientCardMap);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveMemberShipCardOTP Investigation_DAL", ex);
            }

            return result;
        }

        public long InsertCommercialsForOrgtransfer(long pVisitID, int OrgID)
        {
            long retCode = -1;
            SqlCommand cmd = new SqlCommand();

            cmd = Command.pInsertCommercialsForOrgtransferCommand(pVisitID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    retCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving InsertCommercialsForOrgtransfer investigation_DAL", e);
            }
            return retCode;
        }

        public long CheckIsValidtoTransfer(List<PatientInvSample> lstpinvsample, out List<CollectedSample> lstpinvsampleVisits)
        {
            long returnCode = -1;
            lstpinvsampleVisits = new List<CollectedSample>();
            IDataReader dataReader = null;
            DataTable Sampletransfer = UDT_DAL.ConvertToUDDPatientInvSampleTransfer(lstpinvsample);
            try
            {
                SqlCommand cmd = Command.pCheckIsValidtoTransferCommand(Sampletransfer, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstpinvsampleVisits);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing CheckIsValidtoTransfer in Investigation_DAL", ex);
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

        public long DeleteInvLocationMapping(long ID, long InvID, int OrgID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pDeleteInvLocationMappingCommand(ID, InvID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL DeleteInvLocationMappingCommand", ex);
            }
            return returnCode;
        }
        #region for SampleworkFlow
        public long GetSampleWorkflowDetails(int OrgID, string BarcodeNumber, int ExtraSampleID, out List<SampleWorkFlow> lstSampleWorkFlow)
        {
            lstSampleWorkFlow = new List<SampleWorkFlow>();
            long returnCode = -1;
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetSampleWorkflowDetailsCommand(OrgID, BarcodeNumber, ExtraSampleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSampleWorkFlow);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Get GetSampleWorkflowDetails Details in Investigation_DAL ", ex);
            }
            return returnCode;
        }
        public long ShowSamplesforBarcode(string BarcodeNumber, out List<InvSampleMaster> lstInvSampleMaster)
        {
            long returnCode = -1;
            lstInvSampleMaster = new List<InvSampleMaster>();

            try
            {
                SqlCommand cmd = Command.pGetShowSamplesforBarcodeCommand(BarcodeNumber, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvSampleMaster);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Investigation_DAL- ShowSamplesforBarcode", ex);
            }

            return returnCode;
        }
        public long GetSampleArchivalDetails(Int32 pTrayID, string barcodeNo, out List<SampleArchival> lstSampleArchival)
        {
            long returnCode = -1;
            lstSampleArchival = new List<SampleArchival>();
            try
            {
                SqlCommand cmd = Command.pGetSampleArchivalDetailsCommand(pTrayID, barcodeNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    IDataReader dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstSampleArchival);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting Sample Archival Details in Investigation_DAL", ex);
            }
            return returnCode;
        }
        public long SaveSampleArchivalMasterDetails(string pType, List<SampleArchival> lstSampleArchival)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            DataTable sampleArchival = UDT_DAL.ConvertToSampleArchivalMasterDetails(lstSampleArchival);
            cmd = Command.pSaveSampleArchivalMasterDetailsCommand(pType, sampleArchival, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving Sample Archival Master Details in investigation_DAL", e);
            }
            return returnCode;

        }
        #endregion
        #region For new worklist
        public long SaveWorkList(int OrgID, List<NewWorkList> lstWorklist, long LocationID, string searchType, long pLoginId, out string WorklistId)
        {
            long result = -1;
            WorklistId = string.Empty;
            DataTable dtgenerateworklist = new DataTable();
            dtgenerateworklist = UDT_DAL.ConvertToUDTGenerateWorklist(lstWorklist);
            SqlCommand cmd = Command.PGenerateWorklistIDCommand(OrgID, dtgenerateworklist, LocationID, searchType, pLoginId, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out WorklistId);

            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    result = dbEngine.ExecuteNonQuery(cmd);
                    WorklistId = Convert.ToString(cmd.Parameters["@WorkListID"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveWorkList Investigation_DAL", e);
            }
            return result;
        }
        public long GetNewWorkListFromVisitToVisit(string fromVisit, string toVisit, int OrgID, int deptID,
           int orgadd, int clientid, long LocationID, string searchType, string InvestigationName
           , int Priority, out List<NewWorkList> lstWorkList,
           int intVisitType, string FromDate, string ToDate, int pHistoryMode,
          string pPageMode, long pLoginId, string IsIncludevalues, string Preference, long WorklistId)
        {
            long result = -1;
            lstWorkList = new List<NewWorkList>();
            SqlCommand cmd = Command.pGetNewWorkListFromVisitToVisitCommand(fromVisit, toVisit, OrgID, deptID, intVisitType, orgadd
                                    , clientid, LocationID, searchType, InvestigationName, Priority, FromDate, ToDate, pHistoryMode,
                                                    pPageMode, pLoginId, IsIncludevalues, Preference, WorklistId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[0], out lstWorkList);
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetWorkListFromVisitToVisit Investigation_DAL", e);
            }
            return result;
        }

        #endregion
        #region BatchWise enter Result
        public long GetBatchWiseInvestigationResultsCaptureFormat(string VIDs, int OrgID, long RoleID, long DeptID, string InvName, string InvType, LoginDetail LDetail,
         string IsTrustedDetails, long WorkListID, long deviceid, string pIsAbnormal, long pHeaderID, long pProtocalGroupID, string pActionName, string pIsMaster, string workListType, out List<PatientInvestigation> lstInvestigation)
        {
            long result = -1;
            lstInvestigation = new List<PatientInvestigation>();
            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
            SqlCommand cmd = Command.pGetBatchWiseInvestigationResultsCaptureFormat_LabCommand(VIDs, OrgID, RoleID, DeptID, InvName, InvType, DtLDetail, IsTrustedDetails, WorkListID, deviceid, pIsAbnormal, pHeaderID, pProtocalGroupID, pActionName, pIsMaster, workListType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[0], out lstInvestigation);
                    }
                }
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while executing GetBatchWiseInvestigationResultsCaptureFormat Investigation_DAL", ex);
            }

            return result;
        }
        #endregion
        #region Sample Archival master
        public long GetSampleArchival(int rackId, out DataTable oSampleArchival)
        {

            long returnCode = -1;
            oSampleArchival = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetSampleArchivalCommand(rackId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    oSampleArchival = ds.Tables[0];
                    returnCode = 0;
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Getting Sample Archival", ex);
            }
            return returnCode;

        }
        public long GetDeptAndAnalyser(out List<InvDeptMaster> lstInvDeptMaster, out List<InvInstrumentMaster> lstAnalyser)
        {
            long returnCode = -1;
            lstInvDeptMaster = new List<InvDeptMaster>();
            lstAnalyser = new List<InvInstrumentMaster>();
            int rsCount = 0;
            try
            {
                SqlCommand cmd = Command.pGetDeptAndAnalyserCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    IDataReader dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvDeptMaster);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstAnalyser);
                            }

                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting Dept And Analyser", ex);
            }
            return returnCode;
        }
        #endregion

        public long GetStatusForApproval(string guid, long patientVisitID, int orgID, string status, long taskid, out List<InvestigationStatus> header, out List<InvReasonMasters> reason, out List<ReferenceRangeType> lstReferenceRangeType, out List<PatientVisit> lstVisit)
        {
            long lresult = -1;
            header = new List<InvestigationStatus>();
            reason = new List<InvReasonMasters>();
            lstReferenceRangeType = new List<ReferenceRangeType>();
            lstVisit = new List<PatientVisit>();
            SqlCommand cmd = Command.pGetStatusForApprovalCommand(patientVisitID, orgID, guid, taskid, status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out header);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[1], out reason);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[2], out lstReferenceRangeType);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[3], out lstVisit);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetStatusForApproval DAL", ex);
            }
            return lresult;
        }

        public long SaveInvResults(long pSCMID,
   List<List<InvestigationValues>> lstInvestigationValues,
   List<PatientInvestigation> lstInvestigation,
   List<PatientInvestigationFiles> PatientInvestigationFiles,
   long vid, int OrgID, int deptID, long ApprovedBy,
   string gUID, out int returnStatus, string isFromDevice, List<PatientInvestigation> lstReflexPatientinvestigation)
        {
            long lresult = -1;
            int i;
            bool success = true;
            List<PatientInvestigation> lstPatient = new List<PatientInvestigation>();
            List<InvestigationValues> lstPatientVisit = new List<InvestigationValues>();
            List<PatientInvSampleResults> lstPInvSampleResults = new List<PatientInvSampleResults>();

            DataTable dtResults = UDT_DAL.ConvertToInvestigationResults(lstInvestigationValues);
            DataTable dtPatientFiles = UDT_DAL.ConvertToPatientInvestigationFiles(PatientInvestigationFiles);
            DataTable dtPatientInvestigation = UDT_DAL.ConvertToPatientInvestigation(lstInvestigation);
            DataTable dtReflexPatientInvestigation = UDT_DAL.ConvertToPatientInvestigation(lstReflexPatientinvestigation);

            //Seetha
            List<PatientInvestigationAttributes> lstPATAtt = new List<PatientInvestigationAttributes>();
            DataTable dtPAtinvatt = UDT_DAL.ConvertToPatientInvAttr(lstPATAtt);


            SqlCommand cmd = Command.pInsertInvestigationResultsCommand(pSCMID, dtResults, vid, gUID, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails), isFromDevice);

            SqlCommand cmdUpdateteID = Command.pUpdatePatientInvestigationCompleteCommand(dtPatientInvestigation, pSCMID, ApprovedBy, gUID, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails), dtReflexPatientInvestigation, dtPAtinvatt);
            SqlCommand[] cmdMethod = new SqlCommand[lstPatient.Count];

            SqlCommand cmdFiles = Command.pInsertPatientInvestigationFilesCommand(dtPatientFiles, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        if (success)
                        {
                            //dbEngine.ExecuteTransactionalNonQuery(cmdSR);
                            //returnStatus = Convert.ToInt16(cmdSR.Parameters["@pReturnStatus"].Value.ToString());
                            //if (returnStatus == 0)
                            //{
                            //    dbEngine.ExecuteTransactionalNonQuery(cmdSM);
                            //    returnStatus = Convert.ToInt16(cmdSR.Parameters["@pReturnStatus"].Value.ToString());

                            //    if (returnStatus == 0)
                            //    {
                            // Changed by Prasanna.S
                            //dbEngine.ExecuteTransactionalNonQuery(cmd);
                            //returnStatus = Convert.ToInt16(cmd.Parameters["@returnstatus"].Value.ToString());
                            dbEngine.ExecuteTransactionalNonQuery(cmdUpdateteID);
                            returnStatus = Convert.ToInt16(cmdUpdateteID.Parameters["@pReturnStatus"].Value.ToString());
                            if (returnStatus == 0)
                            {
                                dbEngine.ExecuteTransactionalNonQuery(cmdFiles);

                                if (success)
                                {
                                    // Changed by Prasanna.S
                                    //dbEngine.ExecuteTransactionalNonQuery(cmdUpdateteID);
                                    //lresult = Convert.ToInt64(cmdUpdateteID.Parameters["@pReturnStatus"].Value);
                                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                                    lresult = Convert.ToInt16(cmd.Parameters["@returnstatus"].Value.ToString());
                                    if (lresult != 0)
                                    {

                                        tranScope.Dispose();
                                    }
                                }
                            }
                            //    }
                            //}
                            tranScope.Complete();
                        }
                    }
                }
                catch (Exception ex)
                {
                    tranScope.Dispose();
                }
            }
            // Changed by Prasanna.S
            //using (DBEngine dbEngine = new DBEngine())
            //{
            //    dbEngine.ExecuteNonQuery(cmd);
            //    lresult = Convert.ToInt16(cmd.Parameters["@returnstatus"].Value.ToString());
            //}
            return lresult;

        }
        public long GetAutocompleteForGroupid(int GroupID, int OrgID, out List<InvOrgGroup> lstInvOrgGroup)
        {
            lstInvOrgGroup = new List<InvOrgGroup>();
            long returnCode = -1;
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetAutocompleteForGroupidCommand(GroupID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvOrgGroup);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Get GetAutocompleteForGroupid Details in DAL ", ex);
            }
            return returnCode;
        }
        public long DeviceErrorFlagcheck(long OrgID, string DeviceID, string DeviceErrorCode, int investigationID, out List<InvestigationValues> Investigationvalues)
        {
            long returnCode = -1;
            Investigationvalues = new List<InvestigationValues>();
            try
            {
                SqlCommand cmd = Command.PgetdeviceerrorflagcheckCommand(OrgID, DeviceID, DeviceErrorCode, investigationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    IDataReader dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out Investigationvalues);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting patient investigation status details", ex);
            }

            return returnCode;
        }
        public long GetDependentInvestigationdetails(long visitid, int OrgID, List<PatientInvestigation> lstpatinv, out List<PatientInvestigation> lstDependentinv, out List<PatientInvestigation> lstPatientinv)
        {
            lstDependentinv = new List<PatientInvestigation>();
            lstPatientinv = new List<PatientInvestigation>();
            long returnCode = -1;
            long returnCode1 = -1;
            try
            {
                DataSet ds = new DataSet();
                DataTable dtpatinv = UDT_DAL.ConvertToPatientInvestigation(lstpatinv);
                SqlCommand cmd = Command.pgetDependentInvestigationdetailsCommand(visitid, OrgID, dtpatinv, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDependentinv);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode1 = Utilities.ConvertTo(ds.Tables[1], out lstPatientinv);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Get GetDependentInvestigationdetails Details in DAL ", ex);
            }
            return returnCode;
        }
        public long BatchWiseSaveInvestigationResults_Lab(long pSCMID, List<List<InvestigationValues>> lstInvestigationValues, List<PatientInvestigation> lstInvestigation, List<PatientInvSampleResults> lstPatientInvSampleResults, List<PatientInvSampleMapping> lstPatientInvSampleMapping, List<PatientInvestigationFiles> PatientInvestigationFiles, long vid, int OrgID, int deptID, long ApprovedBy, string gUID, out int returnStatus)
        {
            long lresult = -1;
            int i;
            bool success = true;
            List<PatientInvestigation> lstPatient = new List<PatientInvestigation>();
            List<InvestigationValues> lstPatientVisit = new List<InvestigationValues>();
            List<PatientInvSampleResults> lstPInvSampleResults = new List<PatientInvSampleResults>();

            DataTable dtResults = UDT_DAL.ConvertToInvestigationResults(lstInvestigationValues);

            DataTable dtSR = UDT_DAL.ConvertToUDTinvSampleResults(lstPatientInvSampleResults);

            DataTable dtSM = UDT_DAL.ConvertToPatientInvSampleMapping(lstPatientInvSampleMapping);

            DataTable dtPatientFiles = UDT_DAL.ConvertToPatientInvestigationFiles(PatientInvestigationFiles);


            SqlCommand cmd = Command.pBatchwiseInsertInvestigationResultsCommand(dtResults, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            SqlCommand cmdSR = Command.pInsertinvSampleResultsCommand(dtSR, vid, OrgID, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            SqlCommand cmdSM = Command.pInsertInvSampleMappingCommand(dtSM, vid, OrgID, deptID, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataTable dtPatientInvestigation = UDT_DAL.ConvertToPatientInvestigation(lstInvestigation);

            SqlCommand cmdUpdateteID = Command.pUpdateBAtchWisePatientInvestigationComplete_QuantumCommand(dtPatientInvestigation, ApprovedBy, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            SqlCommand[] cmdMethod = new SqlCommand[lstPatient.Count];

            SqlCommand cmdFiles = Command.pInsertPatientInvestigationFilesCommand(dtPatientFiles, UDT_DAL.ConvertToUDT_Context(globalContextDetails));




            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        if (success)
                        {
                            dbEngine.ExecuteTransactionalNonQuery(cmdSR);
                            returnStatus = Convert.ToInt16(cmdSR.Parameters["@pReturnStatus"].Value.ToString());
                            if (returnStatus == 0)
                            {
                                dbEngine.ExecuteTransactionalNonQuery(cmdSM);
                                returnStatus = Convert.ToInt16(cmdSR.Parameters["@pReturnStatus"].Value.ToString());

                                if (returnStatus == 0)
                                {
                                    //Changed by Prasanna.S
                                    //dbEngine.ExecuteTransactionalNonQuery(cmd);
                                    //returnStatus = Convert.ToInt16(cmd.Parameters["@returnstatus"].Value.ToString());
                                    dbEngine.ExecuteTransactionalNonQuery(cmdUpdateteID);
                                    returnStatus = Convert.ToInt16(cmdUpdateteID.Parameters["@pReturnStatus"].Value.ToString());
                                    if (returnStatus == 0)
                                    {


                                        dbEngine.ExecuteTransactionalNonQuery(cmdFiles);

                                        if (success)
                                        {
                                            //Changed by Prasanna.S
                                            //dbEngine.ExecuteTransactionalNonQuery(cmdUpdateteID);
                                            //lresult = Convert.ToInt64(cmdUpdateteID.Parameters["@pReturnStatus"].Value);
                                            dbEngine.ExecuteTransactionalNonQuery(cmd);
                                            lresult = Convert.ToInt16(cmd.Parameters["@returnstatus"].Value.ToString());
                                            if (lresult != 0)
                                            {

                                                tranScope.Dispose();
                                            }



                                        }
                                    }
                                }
                            }
                            tranScope.Complete();

                        }
                    }
                }
                catch (Exception ex)
                {
                    tranScope.Dispose();
                }
            }
            //using (DBEngine dbEngine = new DBEngine())
            //{
            //    dbEngine.ExecuteNonQuery(cmd);
            //    lresult = Convert.ToInt16(cmd.Parameters["@returnstatus"].Value.ToString());
            //}
            return lresult;

        }

        public long GetBarcodeLayer(long PatientvisitID, int SampleID, out List<BarcodeLayer> lstbarcodelayer)
        {
            long lResult = -1;
            lstbarcodelayer = new List<BarcodeLayer>();
            //new
            SqlCommand cmd = Command.pGetBarcodeLayerCommand(PatientvisitID, SampleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lResult = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lResult = Utilities.ConvertTo(ds.Tables[0], out lstbarcodelayer);

                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing BarcodeLayer", ex);
            }

            return lResult;
        }


        public long UpdateOrderedInvestigationStatusinLabBulk(List<PatientInvestigation> lstpatinv)
        {
            long returncode = -1;
            //upIS = -1;
            DataTable tblInvesigationIDs = UDT_DAL.ConvertToBulkCollectSample(lstpatinv);
            SqlCommand cmd = Command.pUpdateOrderedInvestigationStatusinLabBulkCommand(tblInvesigationIDs);

            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteNonQuery(cmd);
                    //upIS = Convert.ToInt32(cmd.Parameters["@returnstatus"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL UpdateOrderedInvestigationStatusinLab", ex);
            }
            return returncode;
        }
        public long GetSortingTasks(int orgid, int deptid, DateTime FromDate, DateTime ToDate, string InvestigationName, long InvestigationID, string InvestigationType, string VisitID, int index, int pagesize, out int totalrows, LoginDetail LDetail, int Reassing, out List<OrderedInvestigations> lsttasks)
        {
            long returnCode = -1;
            totalrows = -1;
            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
            lsttasks = new List<OrderedInvestigations>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetSortingTasksCommand(orgid, deptid, FromDate, ToDate, InvestigationName, InvestigationID, InvestigationType, VisitID, index, pagesize, out totalrows, DtLDetail, Reassing, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lsttasks);
                        totalrows = Convert.ToInt32(cmd.Parameters["@totalRows"].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GeneralPattern", ex);
            }
            return returnCode;
        }

        public long Insertsortedtask(int pOrgID, int deptid, List<OrderedInvestigations> lstOrderedInves, DataTable dtrole)
        {

            long returnCode = -1;
            try
            {
                DataTable dtinv = UDT_DAL.ConvertToOrderedInvestigation(lstOrderedInves);
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pInsertsortedtaskCommand(pOrgID, deptid, dtinv, dtrole, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Refered count and Ordered count", ex);
            }

            return returnCode;
        }

        //added  for tabpopulate  :kapil
        public long GetGeneralPattern(long Pinvid, out List<TabularPatternConfigurationMaster> lstDynamicTable, int ORGID)
        {
            long returnCode = -1;
            lstDynamicTable = new List<TabularPatternConfigurationMaster>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.PGetGeneralPatternCommand(Pinvid, ORGID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDynamicTable);
                    }

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GeneralPattern", ex);
            }
            return returnCode;
        }
        //kapil

        //Vijayalakshmi.M
        public long GetBarCodeForSample(string ExternalVisitId, long OrgID, out List<PatientInvSample> lstinvsample, out List<BarcodeIntegrationResults> lstbarcode, out int TranStatus)
        {
            int ret = -1;
            long returnCode = -1;
            TranStatus = -1;
            // DataTable invs = UDT_DAL.ConvertToOrderedInvestigation(OrderedInves);
            lstinvsample = new List<PatientInvSample>();
            lstbarcode = new List<BarcodeIntegrationResults>();
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            cmd = Command.pGetBarCodeForSamplesCommand(ExternalVisitId, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out TranStatus);
            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstinvsample);

                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstbarcode);
                        TranStatus = Convert.ToInt32(cmd.Parameters["@TranStatus"].Value);
                    }

                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving GetBarCodeForSample investigation_DAL", e);
            }
            return returnCode;

        }
        //Vijayalakshmi.M
        public long GetBarcodeNo(int OrgID, int SampleCode, long VisitId, string BarcodeNumber, out string Barcode)
        {
            long returnCode = -1;
            Barcode = string.Empty;
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            List<PatientInvSample> lstBarcode = new List<PatientInvSample>();
            cmd = Command.pGetBarcodeNoCommand(OrgID, SampleCode, VisitId, BarcodeNumber);
            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //Barcode =lstBarcode [0].BarcodeNumber;
                        Barcode = Utilities.ConvertTo(ds.Tables[0], out lstBarcode).ToString();
                        Barcode = lstBarcode[0].BarcodeNumber;
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving GetBarCodeForSample investigation_DAL", e);
            }
            return returnCode;
        }

        public long pUpdatePkgSequence(DataTable dtSequence, int pOrgID, int PkgID)
        {

            long returnCode = -1;
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pUpdatepkgSequenceCommand(pOrgID, PkgID, dtSequence, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Refered count and Ordered count", ex);
            }

            return returnCode;
        }


        public long pGetSequencepkg(int OrgID, int PkgID, out List<InvOrgGroup> lstpkg)
        {
            long lresult = -1;
            lstpkg = new List<InvOrgGroup>();
            SqlCommand cmd = Command.PgetsequencepkgCommand(OrgID, PkgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[0], out lstpkg);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Sequence Group DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }


        public long pGetPKG(int OrgID, int GrpId, out List<OrderedInvestigations> lstInvNames, out string Pkgname)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetpkgCommand(OrgID, GrpId, out Pkgname, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstInvNames = new List<OrderedInvestigations>();
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    Pkgname = Convert.ToString(cmd.Parameters["@groupname"].Value);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvNames);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetInvestigationName DAL", ex);
            }
            return returnCode;
        }

        //End
        //Added by Vijayalakshmi.M for Mobile APP API
        public long GetReferenceRangeDetails(long VisitID, long InvestigationID, string Value, int OrgID, out List<VisitDetails> lstVisitdetails)
        {
            lstVisitdetails = new List<VisitDetails>();
            SqlCommand cmd = new SqlCommand();

            long returncode = 0;
            try
            {
                cmd = Command.pGetRefRangeDetailsCommand(VisitID, InvestigationID, Value, OrgID);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstVisitdetails);
                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetReferenceRangeDetails in Investigation_DAL : ", ex);
            }
            return returncode;
        }
        public long GetInvestigationReportDetails(int VisitID, long OrgID, out VisitCountDetails[] lstValues)
        {
            long returncode = -1;
            lstValues = null;
            List<VisitCountDetails> lstcount = new List<VisitCountDetails>();
            SqlCommand cmd = new SqlCommand();

            try
            {

                cmd = Command.pGetReportDetailsCommand(VisitID, OrgID);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    //dbEngine.ExecuteDataSet(cmd, out ds);
                    IDataReader dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        Utilities.ConvertTo(dataReader, out lstcount);
                    }
                }

                if (lstcount.Count > 0)
                {
                    lstValues = lstcount.ToArray();
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetInvestigationReportDetails in Investigation_DAL :", ex);
            }
            return returncode;
        }
        //End
        public long pGetQuickApprovelForCompletedStatus(long OrgID, out List<InvStatusmapping> LstInvStatusmapping)
        {

            LstInvStatusmapping = new List<InvStatusmapping>();
            SqlCommand cmd = new SqlCommand();

            long returncode = 0;
            try
            {
                cmd = Command.pGetQuickApprovelForCompletedStatusCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out LstInvStatusmapping);
                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in PGetQuickApprovelForCompletedStatus in Investigation_DAL : ", ex);
            }
            return returncode;
        }
        #region HL7Integration
        public long HL7SavePatientInvestigation(List<InvestigationValues> PatientInvestigation, long OrgID, string gUID, HLMessages objHLMessage, out int pOrderedInvCnt)
        {
            int ret = -1;
            long retCode = -1;
            pOrderedInvCnt = 0;
            SqlCommand cmdInvestigation = new SqlCommand();
            DataTable dtResults = UDT_DAL.ConvertToInvestigationResults(PatientInvestigation);
            //DataTable invs = UDT_DAL.ConvertToPatientInvestigation(PatientInvestigation);
            cmdInvestigation = Command.pInsertHL7InvestigationCommand(dtResults, OrgID, gUID, objHLMessage.ExternalVisitNumber, objHLMessage.Placer_Order_Number, objHLMessage.Transaction_Date_Time, out pOrderedInvCnt, out ret, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInvestigation);
                    retCode = Convert.ToInt32(cmdInvestigation.Parameters["@returnstatus"].Value);
                    pOrderedInvCnt = Convert.ToInt32(cmdInvestigation.Parameters["@pOrderedInvCnt"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving PatientInvestigation investigation_DAL", e);
            }
            return retCode;

        }
        public long GetInvestigationList(List<DischargeInvNotes> lstinvMaster, int OrgId, out List<OrderedInvestigations> lstOrdInv)
        {
            long returnCode = -1;
            lstOrdInv = new List<OrderedInvestigations>();
            try
            {
                DataSet ds = new DataSet();
                DataTable invs = UDT_DAL.ConvertToDischargeInvNotes(lstinvMaster);
                SqlCommand cmd = Command.pGetInvestigationListCommand(invs, OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrdInv);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL pGetInvestigationListCommand", ex);
            }
            return returnCode;
        }
        #endregion
        public long GetTestNameForMedicalDetailsMapping(string Name, long orgid, out List<OrderedInvestigations> lstOrd)
        {
            long lResult = -1;
            lstOrd = new List<OrderedInvestigations>();
            IDataReader dataReader = null;
            SqlCommand cmd = Command.pGetTestNameForMedicalDetailsMappingCommand(Name, orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        lResult = Utilities.ConvertTo(dataReader, out lstOrd);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationSymbols", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return lResult;
        }

        public long AddUOMCode(string UOMCode, string UOMDescription, out int pUOMID)
        {
            long returnCode = -1;
            pUOMID = 0;
            try
            {
                SqlCommand cmd = Command.pAddUOMCodeCommand(UOMCode, UOMDescription, out pUOMID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    pUOMID = Convert.ToInt32(cmd.Parameters["@pUOMID"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Adding UOM Code", ex);
            }
            return returnCode;
        }
        public long IsUOMCodeExists(string UOMCode, string UOMDescription, out int pCount)
        {
            long retCode = -1;
            pCount = 0;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pIsUOMCodeExistsCommand(UOMCode, UOMDescription, out pCount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    retCode = dbEngine.ExecuteNonQuery(cmd);
                    pCount = Convert.ToInt32(cmd.Parameters["@pCount"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while getting uomcode", e);
            }
            return retCode;

        }
        public long GetDepartmentHeaders(out List<InvestigationHeader> lstManageHeader)
        {

            lstManageHeader = new List<InvestigationHeader>();

            long lresult = -1;
            DataSet dataSet = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetDepartmentHeadersCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out dataSet);
                }
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(dataSet.Tables[0], out lstManageHeader);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Sql", ex);
            }

            return lresult;

        }
        public long pSaveManageHeader(string HeaderName, bool IsActive)
        {
            long returnCode = -1;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pSaveManageHeaderCommand(HeaderName, IsActive, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                cmd.Parameters.Add("@Return", SqlDbType.Int);
                cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Investigation_DAL pSaveManageHeader", ex);
            }
            return returnCode;
        }
        public long pUpdateManageHeader(long HeaderID, string HeaderName, bool IsActive)
        {
            long returnCode = -1;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pUpdateManageHeaderCommand(HeaderID, HeaderName, IsActive, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                cmd.Parameters.Add("@Return", SqlDbType.Int);
                cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Investigation_DAL pSaveManageHeader", ex);
            }
            return returnCode;
        }

        public long GetColletApproveAndReceivedDate_DAL(string strPrefix, int intOrgID, out List<PendingInvestigation> lstVisitNumber)
        {
            long returnCode = -1;
            lstVisitNumber = new List<PendingInvestigation>();
            SqlCommand cmd = Command.PgetCollectApproveAndReceivedDateCommand(strPrefix, intOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstVisitNumber);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetColletApproveAndReceivedDate_DAL", ex);
            }
            return returnCode;
        }
        public long UpdateCollectReceiveApprovedDate_DAL(long longVisitID, int intOrgID, string strVisitNumber, DateTime CollectDatetime, DateTime ReceviedDatetime, DateTime ApprovedDatetime)
        {

            long returnCode = -1;
            try
            {


                SqlCommand cmd = Command.PUptCollectReceiveApprovedDateCommand(longVisitID, intOrgID, strVisitNumber, CollectDatetime, ReceviedDatetime, ApprovedDatetime, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetColletApproveAndReceivedDate_DAL", ex);
            }

            return returnCode;
        }
        public long SaveInvestigationResultsPreview(long pSCMID,
            List<List<InvestigationValues>> lstInvestigationValues,
           List<PatientInvestigation> lstInvestigation,
            List<PatientInvSampleResults> lstPatientInvSampleResults,
            List<PatientInvSampleMapping> lstPatientInvSampleMapping,
            List<PatientInvestigationFiles> PatientInvestigationFiles,
            long vid, int OrgID, int deptID, long ApprovedBy,
            string gUID, out int returnStatus, List<PatientInvestigation> lstReflexPatientinvestigation, string isFromDevice)
        {
            long lresult = -1;
            int i;
            bool success = true;
            List<PatientInvestigation> lstPatient = new List<PatientInvestigation>();
            List<InvestigationValues> lstPatientVisit = new List<InvestigationValues>();
            List<PatientInvSampleResults> lstPInvSampleResults = new List<PatientInvSampleResults>();

            //Seetha
            List<PatientInvestigationAttributes> lstPATAtt = new List<PatientInvestigationAttributes>();
            DataTable dtPAtinvatt = UDT_DAL.ConvertToPatientInvAttr(lstPATAtt);

            DataTable dtResults = UDT_DAL.ConvertToInvestigationResults(lstInvestigationValues);

            DataTable dtSR = UDT_DAL.ConvertToUDTinvSampleResults(lstPatientInvSampleResults);

            DataTable dtSM = UDT_DAL.ConvertToPatientInvSampleMapping(lstPatientInvSampleMapping);

            DataTable dtPatientFiles = UDT_DAL.ConvertToPatientInvestigationFiles(PatientInvestigationFiles);
            DataTable dtPatientInvestigation = UDT_DAL.ConvertToPatientInvestigation(lstInvestigation);
            DataTable dtReflexPatientInvestigation = UDT_DAL.ConvertToPatientInvestigation(lstReflexPatientinvestigation);

            SqlCommand cmd = Command.pInsertInvestigationResultsCommand(pSCMID, dtResults, vid, gUID, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails), isFromDevice);
            SqlCommand cmdSR = Command.pInsertinvSampleResultsCommand(dtSR, vid, OrgID, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            SqlCommand cmdSM = Command.pInsertInvSampleMappingCommand(dtSM, vid, OrgID, deptID, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            SqlCommand cmdUpdateteID = Command.pUpdatePatientInvestigationCompleteCommand(dtPatientInvestigation, pSCMID, ApprovedBy, gUID, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails), dtReflexPatientInvestigation, dtPAtinvatt);
            SqlCommand[] cmdMethod = new SqlCommand[lstPatient.Count];

            SqlCommand cmdFiles = Command.pInsertPatientInvestigationFilesCommand(dtPatientFiles, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        if (success)
                        {

                            // Changed by Prasanna.S
                            //dbEngine.ExecuteTransactionalNonQuery(cmd);
                            //returnStatus = Convert.ToInt16(cmd.Parameters["@returnstatus"].Value.ToString());

                            dbEngine.ExecuteTransactionalNonQuery(cmdFiles);
                            if (success)
                            {
                                // Changed by Prasanna.S
                                //dbEngine.ExecuteTransactionalNonQuery(cmdUpdateteID);
                                //lresult = Convert.ToInt64(cmdUpdateteID.Parameters["@pReturnStatus"].Value);
                                dbEngine.ExecuteTransactionalNonQuery(cmd);
                                lresult = Convert.ToInt16(cmd.Parameters["@returnstatus"].Value.ToString());
                                if (lresult != 0)
                                {

                                    tranScope.Dispose();
                                }
                            }

                        }

                        tranScope.Complete();

                    }
                }
                catch (Exception ex)
                {
                    tranScope.Dispose();
                }
            }
            // Changed by Prasanna.S
            //using (DBEngine dbEngine = new DBEngine())
            //{
            //    dbEngine.ExecuteNonQuery(cmd);
            //    lresult = Convert.ToInt16(cmd.Parameters["@returnstatus"].Value.ToString());
            //}
            return lresult;

        }


        public long GetTAT_DAL(int OrgID, int FeeID, string FeeType, string Description, long ClientID, string IsCollected, string CollectedDatetime, out string TAT, out string ReportTAT)
        {
            long retCode = -1;
            TAT = string.Empty;
            ReportTAT = string.Empty;
            DateTime pCollectDatetime = Convert.ToDateTime(CollectedDatetime);
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pGetTATReportDetailsCommand(OrgID, FeeID, FeeType, Description, ClientID, IsCollected, pCollectDatetime, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out TAT, out ReportTAT);
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    retCode = dbEngine.ExecuteNonQuery(cmd);
                    TAT = Convert.ToString(cmd.Parameters["@TATDateTime"].Value);
                    ReportTAT = Convert.ToString(cmd.Parameters["@Reportdatetime"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while getting GetTAT_DAL", e);
            }
            return retCode;

        }

        //------------Trend Analysis Begin----------------------
        public long GetPatientComparisonReport(string pPatientIds, List<InvestigationMaster> lstInvID, string IsRerun, long pPageID, out List<TrendAnalysis> lstGetPatientComparisonResult)
        {
            long returnCode = -1;
            int rsCount = 0;
            IDataReader dataReader = null;
            lstGetPatientComparisonResult = new List<TrendAnalysis>();
            DataTable lstInvIDTemp = UDT_DAL.ConvertToUDTInvestigationMaster(lstInvID);
            try
            {
                SqlCommand cmd = Command.pPatientComparisonReportCommand(pPatientIds, lstInvIDTemp, IsRerun, pPageID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstGetPatientComparisonResult);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientComparisonReport in Investigation_DAL", ex);
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

        public long GetPatientTestLevelResult(string VisitNumber, string PatientNumber, long pPageID, out List<Patient> lstPatientDetails, out List<TrendAnalysis> lstGetPatientTestLevelResult)
        {
            long returnCode = -1;
            int rsCount = 0;
            lstPatientDetails = new List<Patient>();
            lstGetPatientTestLevelResult = new List<TrendAnalysis>();
            SqlCommand cmd = Command.pPatientTestLevelResultCommand(VisitNumber, PatientNumber, pPageID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            IDataReader dataReader = null;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPatientDetails);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstGetPatientTestLevelResult);
                            }

                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing PatientTestLevelResult in Investigation_DAL", ex);
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

        // --------------Trend Analysis End----------------------
        public long GetInBoundListForLIMS(int OrgID, string Status, out List<HLMessages> lstHl7InBoundMessageDetails, out List<HLMessagePatientIDDetails> lstPatient, out List<HLMessageOBRDetails> lstHLMessageOBRDetails)
        {
            lstHl7InBoundMessageDetails = new List<HLMessages>();
            lstPatient = null;
            lstHLMessageOBRDetails = null;
            long returnCode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.PgetInBoundMessagesListForLIMSCommand(OrgID, Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstHl7InBoundMessageDetails);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatient);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstHLMessageOBRDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While GetInBoundListForLIMS in Investigation_DAL", ex);
            }
            return returnCode;
        }
        public long CheckHL7InboundService(int pInterval, string pServiceType, DateTime pProcessingTime, out string pIsActive)
        {
            long result = -1;
            pIsActive = "N";
            SqlCommand cmd = Command.pCheckHL7InboundServiceCommand(pInterval, pServiceType, pProcessingTime, out pIsActive);
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    result = dbEngine.ExecuteNonQuery(cmd);
                    pIsActive = cmd.Parameters["@IsActive"].Value.ToString();
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while at CheckHL7InboundService in Investigation_DAL", e);
            }
            return result;
        }
        public long UpdateInBoundMsgDetails(int OrgID, DataTable DtApprovedXML)
        {
            int ret = -1;
            long retCode = -1;
            //DataTable invs = UDT_DAL.ConvertToUDTHl7OutBoundMessageDetails(PatientInvestigation);
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pUpdateInBoundMsgDetailsCommand(OrgID, DtApprovedXML, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while updating UpdateInBoundMsgDetils investigation_DAL", e);
            }
            return retCode;
        }
        public DataSet GetHLMessageDetail(int pOrgid, string pMessageControlId, string MessageType, string DateTimes, string PatientIdentifier)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetHLMessageDetailCommand(pOrgid, pMessageControlId, MessageType, DateTimes, PatientIdentifier);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL pGetInvestigationListCommand", ex);
            }
            return ds;
        }

        public long GetBatchWiseWorklistforspecialsamples(string WorkListType, long SearchID, long deptid, int OrgID, string WLMode, string fromDate, string toDate, out List<PatientInvestigation> lstPatientInvestigation)
        {
            long returnCode = -1;
            lstPatientInvestigation = new List<PatientInvestigation>();

            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetBatchWiseWorklistforspecialsamplesCommand(WorkListType, SearchID, deptid, OrgID, WLMode, fromDate, toDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPatientInvestigation);
                        dataReader.Close();
                    }

                }
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetBatchWiseWorklist InvestigationDAL", excp);
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

        public long GetBlockSlidePreparation(long VisitNumber, string BarCode, out List<BlockSlideBarcodePreparation> lstBarcodeDetails)
        {
            long returnCode = -1;
            lstBarcodeDetails = new List<BlockSlideBarcodePreparation>();
            SqlCommand cmd = Command.PgetBlockSlidePreparationCommand(VisitNumber, BarCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBarcodeDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBlockSlidePreparation", ex);
            }
            return returnCode;
        }

        public long pUpdateBlockSlideDetails(string PrimaryBarcode, string BarcodeNumber, string BlockType, string SlideName, string StainType, string SlideComments, long Orgid)
        {
            long returnCode = -1;
            try
            {

                SqlCommand cmd = Command.pUpdateBlockSlideDetailsCommand(PrimaryBarcode, BarcodeNumber, BlockType, SlideName, StainType, SlideComments, Orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);

                }
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while executing pUpdateBlockSlideDetails", ex);
            }
            return returnCode;
        }
        public long GetHistoDeptTestNames(int DeptID, out List<InvDeptMaster> lsttestname)
        {
            long returnCode = -1;
            lsttestname = new List<InvDeptMaster>();
            SqlCommand cmd = Command.pGetHistoDeptTestNamesCommand(DeptID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lsttestname);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetColletApproveAndReceivedDate_DAL", ex);
            }
            return returnCode;
        }


        public long GetKPIReport(DateTime fromdate, DateTime todate, int DeptID, int TestID, out List<HistopathologyReport> lsthisto)
        {
            long returnCode = -1;
            lsthisto = new List<HistopathologyReport>();
            SqlCommand cmd = Command.PGetKPIReportCommand(fromdate, todate, DeptID, TestID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lsthisto);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetColletApproveAndReceivedDate_DAL", ex);
            }
            return returnCode;
        }

        public long InsertNotGivenSample(long PatientVisitID, int SampleID, int InvStatusID, string InvReason, long CreatedBy, long AccessionNo)
        {
            long retCode = -1;
            SqlCommand cmdRejectSample = new SqlCommand();
            cmdRejectSample = Command.pInsertNotGivenSampleCommand(PatientVisitID, SampleID, InvStatusID, InvReason, CreatedBy, AccessionNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    retCode = dbEngine.ExecuteNonQuery(cmdRejectSample);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving InsertNotGivenSample investigation_DAL", e);
            }
            return retCode;

        }

        public string PGetConfidentialvisit(long pVisit)
        {
            string returnCode = string.Empty;

            SqlCommand cmd = Command.PGetConfidentialvisitCommand(pVisit);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = ds.Tables[0].Rows[0]["CONFIDENTIAL"].ToString();
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing PGetConfidentialvisit Investigation_DAL", ex);
            }
            return returnCode;
        }
        //public long InsertNotGivenSample(long PatientVisitID, int SampleID, int InvStatusID, string InvReason, long CreatedBy, long AccessionNo)
        //   {
        //       long retCode = -1;
        //       SqlCommand cmdRejectSample = new SqlCommand();
        //       cmdRejectSample = Command.pInsertNotGivenSampleCommand(PatientVisitID, SampleID, InvStatusID, InvReason, CreatedBy, AccessionNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
        //       try
        //       {
        //           using (DBEngine dbEngine = new DBEngine())
        //           {
        //               retCode = dbEngine.ExecuteNonQuery(cmdRejectSample);
        //           }
        //       }
        //       catch (Exception e)
        //       {
        //           CLogger.LogError("Error while saving InsertNotGivenSample investigation_DAL", e);
        //       }
        //       return retCode;

        //   }

        //public string PGetConfidentialvisit(long pVisit)
        //{
        //    string returnCode = string.Empty;

        //    SqlCommand cmd = Command.PGetConfidentialvisitCommand(pVisit);
        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        using (DBEngine dbEngine = new DBEngine())
        //        {
        //            dbEngine.ExecuteDataSet(cmd, out ds);
        //        }
        //        if (ds.Tables[0].Rows.Count > 0)
        //        {
        //            returnCode = ds.Tables[0].Rows[0]["CONFIDENTIAL"].ToString();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while executing PGetConfidentialvisit Investigation_DAL", ex);
        //    }
        //    return returnCode;
        //}
        public string PGetConfidential(long pVisit)
        {
            string returnCode = string.Empty;

            SqlCommand cmd = Command.PGetConfidentialCommand(pVisit);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = ds.Tables[0].Rows[0]["CONFIDENTIAL"].ToString();
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetColletApproveAndReceivedDate_DAL", ex);
            }
            return returnCode;
        }
        //Added by Jegan
        public long pGetpatientInvestigationValues(string visitNumber, string BarcodeNumber, int orgID, int LocationID, out List<InvestigationValues> lstInvestigationValues)
        {
            long returnCode = -1;
            lstInvestigationValues = new List<InvestigationValues>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetPatientTrackingInvestigationValuesCommand(visitNumber, BarcodeNumber, orgID, LocationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvestigationValues);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving pGetpatientInvestigationValues investigation_DAL", ex);
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
        //Added by Jegan
        public long GetIsAutoAuthorization(long VisitID, int OrgID, int AutoAuthorizationCount, long InvID, out int ReturnCode)
        {
            long result = -1;

            //IsExists = "N";
            SqlCommand cmd = Command.pGetAutoAuthorizationStatusCommand(VisitID, OrgID, AutoAuthorizationCount, InvID, out ReturnCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    result = dbEngine.ExecuteNonQuery(cmd);
                    ReturnCode = Convert.ToInt32(cmd.Parameters["@ReturnCode"].Value);

                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while at GetIsAutoAuthorization in Investigation_DAL", e);
            }
            return result;

        }
        // Alex
        public long InsertUpdateOrganismMaster(OrganismMaster organismMaster, out int Id)
        {
            long returnCode = -1;
            Id = -1;
            SqlCommand cmdUpdateInvDrugBrand = new SqlCommand();
            cmdUpdateInvDrugBrand = Command.pInsertUpdateOrganismMasterCommand(organismMaster.ID, organismMaster.Name, organismMaster.Code, out Id, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmdUpdateInvDrugBrand);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing InsertUpdateOrganismMaster in Investigation_DAL", excep);
            }
            return returnCode;
        }

        public long GetIsActiveOrganismList(long pInvID, out int IsActive)
        {
            long returnCode = -1;
            IsActive = 0;
            try
            {
                SqlCommand cmd = Command.pActiveInactiveOrganismListCommand(pInvID, out IsActive, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    IsActive = Convert.ToInt32(cmd.Parameters["@IsActive"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting GetIsActiveOrganismList at Investigation DAL", ex);
            }
            finally
            {
            }
            return returnCode;
        }

        public long InsertUpdateFamilyMaster(InvestigationDrugFamilyMaster familyMaster, out int Id)
        {
            long returnCode = -1;
            Id = -1;
            SqlCommand cmdUpdateInvDrugBrand = new SqlCommand();
            cmdUpdateInvDrugBrand = Command.pInsertUpdateDrugFamilyMasterCommand(familyMaster.FamilyId, familyMaster.Familyname, familyMaster.Familycode, out Id, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmdUpdateInvDrugBrand);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing InsertUpdateFamilyMaster in Investigation_DAL", excep);
            }
            return returnCode;
        }
        /* BEGIN | sabari | 20181129 | Dev | Culture Report */
        public long InsertUpdateDrugLevelMapping(List<DrugLevelMapping> lstDrugLevelMapping, out int Id)
        {
            long returnCode = -1;
            Id = -1;
            SqlCommand cmdins_updDrugLevelMapping = new SqlCommand();
            DataTable DTDrugLevelMapping = UDT_DAL.ConvertToUDTDrugLevelMapping(lstDrugLevelMapping);
            cmdins_updDrugLevelMapping = Command.pInsertUpdateDrugLevelMappingCommand(DTDrugLevelMapping, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out Id);
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmdins_updDrugLevelMapping);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing InsertUpdateDrugLevelMapping in Investigation_DAL", excep);
            }
            return returnCode;
        }
        public long GetDrugLevelMappingDetails(out List<DrugLevelMapping> lstDrugLevelMapping)
        {
            long returnCode = -1;
            lstDrugLevelMapping = new List<DrugLevelMapping>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetDrugLevelMappingDetailsCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstDrugLevelMapping);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting GetDrugLevelMappingDetails in Investigation_DAL", ex);
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
        public long GetOrganismDrugLevelMapDetails(long DrugID, out List<DrugLevelMapping> lstDrugLevelMapping)
        {
            long returnCode = -1;
            lstDrugLevelMapping = new List<DrugLevelMapping>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetOrganismDrugLevelMapDetailsCommand(DrugID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstDrugLevelMapping);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting GetOrganismDrugLevelMapDetails in Investigation_DAL", ex);
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
        public long GetIsActiveDrugLevelMapping(long pInvID, out int IsActive)
        {
            long returnCode = -1;
            IsActive = 0;
            try
            {
                SqlCommand cmd = Command.pActiveInActiveDrugLevelMappingCommand(pInvID, out IsActive, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    IsActive = Convert.ToInt32(cmd.Parameters["@IsActive"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting GetIsActiveDrugFamilyList at Investigation DAL", ex);
            }
            finally
            {
            }
            return returnCode;
        }
        /*XL Upload Start*/
        public DataSet OrganismMasterBulkUpload(int OrgID, string UploadXLMasterType, string UploadXLMasterCode, DataTable DtTbl)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            if (UploadXLMasterType == "FM")
            {
                cmd = Command.pOrganismMasterBulkUploadCommand(OrgID, UploadXLMasterType, UploadXLMasterCode, DtTbl, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            }
            else if (UploadXLMasterType == "DM")
            {
                cmd = Command.pOrganismMasterBulkUploadDrugMasterCommand(OrgID, UploadXLMasterType, UploadXLMasterCode, DtTbl, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            }
            else if (UploadXLMasterType == "OM")
            {
                cmd = Command.pOrganismMasterBulkUploadOrganismMasterCommand(OrgID, UploadXLMasterType, UploadXLMasterCode, DtTbl, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            }
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);


                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveClientRateMappingBulkLoad in Patient_DAL", ex);

            }
            return ds;
        }
        /*XL upload ENd*/

        /* END | sabari | 20181129 | Dev | Culture Report */

        public long GetInvestigationFamilymList(out List<InvestigationDrugFamilyMaster> lstFamilyMaster)
        {
            long returnCode = -1;
            lstFamilyMaster = new List<InvestigationDrugFamilyMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvestigationDrugFamilyMasterCommand(null, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstFamilyMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting GetInvestigationFamilymList list", ex);
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

        public long GetMappedDrugBrand(long OrganismId, long InvestigationId, out List<InvestigationDrugBrand> lstDrugBrand)
        {
            long returnCode = -1;
            lstDrugBrand = new List<InvestigationDrugBrand>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetMappedDrugBrandCommand(OrganismId, InvestigationId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstDrugBrand);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting GetMappedDrugBrand list", ex);
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

        public long GetInvestigationFamilymListHistory(long ID, out List<InvestigationDrugFamilyMaster> lstFamilyMaster)
        {
            long returnCode = -1;
            lstFamilyMaster = new List<InvestigationDrugFamilyMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetinvestigationdrugfamilymasterHistoryCommand(ID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstFamilyMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting GetInvestigationFamilymListHistory list", ex);
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

        public long GetOrganismListHistory(long pID, out List<OrganismMaster> lstOrganismMaster)
        {
            long returnCode = -1;
            lstOrganismMaster = new List<OrganismMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetOrganismMasterHistoryCommand(pID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstOrganismMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting GetOrganismListHistory", ex);
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

        public long GetIsActiveDrugFamilyList(long pInvID, out int IsActive)
        {
            long returnCode = -1;
            IsActive = 0;
            try
            {
                SqlCommand cmd = Command.pActiveInactiveInvestigationDrugFamilyMasterCommand(pInvID, out IsActive, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    IsActive = Convert.ToInt32(cmd.Parameters["@IsActive"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting GetIsActiveDrugFamilyList at Investigation DAL", ex);
            }
            finally
            {
            }
            return returnCode;
        }

        public long InsertUpdateOrganismMapping(long pInvID, DataTable lstInvOrganismDrugMapping)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pInsertUpdateOrganismMappingCommand(pInvID, lstInvOrganismDrugMapping, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    //IsActive = Convert.ToInt32(cmd.Parameters["@IsActive"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting InsertUpdateOrganismMapping at Investigation DAL", ex);
            }
            finally
            {
            }
            return returnCode;
        }


        public long GetFamilyIdByName(string Name, out List<InvestigationDrugFamilyMaster> lstInvestigationDrugFamilyMaster)
        {
            long returnCode = -1;
            lstInvestigationDrugFamilyMaster = new List<InvestigationDrugFamilyMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvestigationDrugFamilyMasterCommand(Name, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvestigationDrugFamilyMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting GetFamilyIdByName at Investigation DAL", ex);
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

        public long GetOrganismMappingList(long Id, out List<InvOrganismDrugMapping> lstInvOrganismDrugMapping)
        {
            long returnCode = -1;
            lstInvOrganismDrugMapping = new List<InvOrganismDrugMapping>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetOrganismMappingListCommand(Id, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvOrganismDrugMapping);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting GetOrganismMappingList at Investigation DAL", ex);
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

        public long GetDeptBatchWiseInvestigationResultsCaptureFormat(string VIDs, int OrgID, string BarcodeNumber, long RoleID, long DeptID, long InvID, string InvType, LoginDetail LDetail,
                 string IsTrustedDetails, long WorkListID, long deviceid, string pIsAbnormal, long pHeaderID, long pProtocalID, string pActionName, string pIsMaster, int pRecordCount, string visittype, string Location, string QcCheck, string PatIds,
                 string CollectionLocID, DateTime fromdate, DateTime todate, out List<PatientInvestigation> lstInvestigation, string Status)
        {
            long result = -1;
            lstInvestigation = new List<PatientInvestigation>();
            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetDeptBatchWiseInvestigationResultsCaptureFormat_APPCommand(VIDs, OrgID, BarcodeNumber, RoleID, DeptID, InvID, InvType, DtLDetail, IsTrustedDetails, WorkListID, deviceid, pIsAbnormal, pHeaderID, pProtocalID, pActionName, pIsMaster, pRecordCount, visittype, Location, QcCheck, PatIds, CollectionLocID, fromdate, todate, Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        result = Utilities.ConvertTo(dataReader, out lstInvestigation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBatchWiseInvestigationResultsCaptureFormat Investigation_DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return result;
        }
        public long GetBatchWiseInvestigationResultsCaptureFormat(string VIDs, int OrgID, string BarcodeNumber, long RoleID, long DeptID, long InvID, string InvType, LoginDetail LDetail,
                   string IsTrustedDetails, long WorkListID, long deviceid, string pIsAbnormal, long pHeaderID, long pProtocalID, string pActionName, string pIsMaster, int pRecordCount, string visittype, string Location, string QcCheck, string PatIds,
                   out List<PatientInvestigation> lstInvestigation)
        {
            long result = -1;
            lstInvestigation = new List<PatientInvestigation>();
            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetBatchWiseInvestigationResultsCaptureFormat_APPCommand(VIDs, OrgID, BarcodeNumber, RoleID, DeptID, InvID, InvType, DtLDetail, IsTrustedDetails, WorkListID, deviceid, pIsAbnormal, pHeaderID, pProtocalID, pActionName, pIsMaster, pRecordCount, visittype, Location, QcCheck, PatIds, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        result = Utilities.ConvertTo(dataReader, out lstInvestigation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBatchWiseInvestigationResultsCaptureFormat Investigation_DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return result;
        }
        public long CheckIsValidtoTransferNew(List<PatientInvSample> lstpinvsample, out List<CollectedSample> lstpinvsampleVisits)
        {
            long returnCode = -1;
            lstpinvsampleVisits = new List<CollectedSample>();
            IDataReader dataReader = null;
            DataTable Sampletransfer = UDT_DAL.ConvertToUDDPatientInvSampleTransfer(lstpinvsample);
            try
            {
                SqlCommand cmd = Command.pCheckIsValidtoTransferCommand(Sampletransfer, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstpinvsampleVisits);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing CheckIsValidtoTransferNew in Investigation_DAL", ex);
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


        public long UpdateSampleTransferNew(List<PatientInvSample> lstPatientInvSample)
        {
            long retCode = -1;
            DataTable Sampletransfer = UDT_DAL.ConvertToUDDPatientInvSampleTransfer(lstPatientInvSample);

            SqlCommand cmdInvestigation = new SqlCommand();
            cmdInvestigation = Command.pUpdateSampletransferCommand(Sampletransfer, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInvestigation);
                    // retCode = Convert.ToInt32(cmdInvestigation.Parameters["@returnstatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing UpdateSampleTransfer in Investigation_DAL", e);
            }
            return retCode;
        }

        public long GetInvSamplesTransferStatusNew(int OrgID, string FromDate, string ToDate, int Status, int LocationID, string LocationType, string VisitID,
                 string PatientName, int VisitType, int Priority, string SourceName, string InvestigationName, long InvestigationID, string InvestigationType,
                 string refPhyName, long refPhyID, long refPhyOrg, long SampleID, int SearchType, out List<CollectedSample> lstSamples, int pagesize, int startRowIndex, out int totalrows, int smpleID, int ProcessedLocID,
       int OutSourceID, string BarcodeNo, int ContainerID, int ProLoaction)
        {
            long returnCode = -1;
            totalrows = -1;
            lstSamples = new List<CollectedSample>();
            SqlCommand objCommand = new SqlCommand();
            IDataReader dataReader = null;
            try
            {
                objCommand = Command.PgetsamplestransferCommand(FromDate, ToDate, OrgID, Status, LocationID, LocationType,
                    VisitID, PatientName, VisitType, Priority, SourceName, InvestigationName, InvestigationID, InvestigationType, refPhyName, refPhyID,
                    refPhyOrg, SampleID, SearchType, pagesize, startRowIndex, out totalrows, smpleID, ProcessedLocID, OutSourceID, BarcodeNo, ContainerID, ProLoaction, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstSamples);
                        dataReader.Close();
                    }
                    totalrows = Convert.ToInt32(objCommand.Parameters["@totalRows"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetInvSamplesForStatusNew", ex);
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

        public long Updatedeltacheckstatus(long patientvisitid, long investigationid, bool IsdeltacheckPass)
        {
            long retCode = -1;
            SqlCommand cmdInvestigation = new SqlCommand();
            cmdInvestigation = Command.pUpdatedeltacheckstatusCommand(patientvisitid, investigationid, IsdeltacheckPass, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInvestigation);
                    // retCode = Convert.ToInt32(cmdInvestigation.Parameters["@returnstatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing UpdateSampleTransfer in Investigation_DAL", e);
            }
            return retCode;
        }
        /* BEGIN | NA | Sabari | 20181202 | Created | HOLD */
        public long GetInvestigatonResultsCaptureHoldOrApprovelTaskDetailsByVID(string _VisitNumber, string _LabNumber, string _PatientName, LoginDetail LDetail, out List<TaskDetails> lstTasks)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
            lstTasks = new List<TaskDetails>();
            try
            {
                SqlCommand cmd = Command.pGetInvestigatonResultsCaptureHoldOrApprovelTaskDetailsByVIDCommand(_VisitNumber, _LabNumber, _PatientName, DtLDetail, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTasks);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigatonResultsCaptureHoldOrApprovel Investigation_DAL", ex);
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
        public long GetInvestigatonResultsCaptureUnHoldTaskDetails(int startRowIndex, int pageSize, out int totalRows, LoginDetail LDetail, out List<TaskDetails> lstTasks)
        {
            long returnCode = -1;
            totalRows = -1;

            lstTasks = new List<TaskDetails>();
            IDataReader dataReader = null;
            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
            try
            {
                SqlCommand cmd = Command.pGetInvestigatonResultsCaptureUnHoldTaskDetailsCommand(startRowIndex, pageSize, out totalRows, DtLDetail, UDT_DAL.ConvertToUDT_Context(globalContextDetails));


                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTasks);
                        dataReader.Close();

                    }
                    totalRows = Convert.ToInt32(cmd.Parameters["@totalRows"].Value);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing GetInvestigatonResultsCaptureUnHoldTaskDetails in Investigation_DAL", excep);
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
        public long GetInvestigationResultsCaptureForUnHold(long VID, int OrgID, long RoleID, string gUID, long DeptID, string InvIDs,
                                                 int LocationID, LoginDetail LDetail, long taskid, string IsTrustedDetails, string status,
                                                 out List<PatientInvestigation> lstDemoInvest
                                                 , out List<InvestigationStatus> lstStatus
                                                 , out List<RoleDeptMap> lRoleDeptMap
            //, out List<InvReportMaster> lEditValues
            //, out List<InvestigationHeader> lstHeader
                                                 )
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstDemoInvest = new List<PatientInvestigation>();
            lstStatus = new List<InvestigationStatus>();
            lRoleDeptMap = new List<RoleDeptMap>();
            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
            try
            {
                SqlCommand cmd = Command.pGetInvestigationResultsCaptureForUnHoldCommand(VID, OrgID, RoleID,
                                                       gUID, DeptID, InvIDs, LocationID, taskid, DtLDetail, UDT_DAL.ConvertToUDT_Context(globalContextDetails), IsTrustedDetails, status);
                using (DBEngine dbEngine = new DBEngine())
                {
                    int rsCount = 0;
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstDemoInvest);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstStatus);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lRoleDeptMap);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationResultsCaptureForHold Investigation_DAL", ex);
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
        /* BEGIN | NA | Sabari | 20181202 | Created | HOLD */
        public long GetInvestigatonResultsCaptureToHold(long VID, int OrgID, long RoleID, string gUID, long DeptID, string InvIDs,
                                                         int LocationID, LoginDetail LDetail, long taskid, string IsTrustedDetails, string status,
                                                         out List<PatientInvestigation> lstDemoInvest
                                                         , out List<InvestigationStatus> lstStatus
                                                         , out List<RoleDeptMap> lRoleDeptMap
            //, out List<InvReportMaster> lEditValues
            //, out List<InvestigationHeader> lstHeader
                                                         )
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstDemoInvest = new List<PatientInvestigation>();
            lstStatus = new List<InvestigationStatus>();
            lRoleDeptMap = new List<RoleDeptMap>();
            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
            try
            {
                SqlCommand cmd = Command.GetInvestigatonResultsCaptureToHoldCommand(VID, OrgID, RoleID,
                                                       gUID, DeptID, InvIDs, LocationID, taskid, DtLDetail, UDT_DAL.ConvertToUDT_Context(globalContextDetails), IsTrustedDetails, status);
                using (DBEngine dbEngine = new DBEngine())
                {
                    int rsCount = 0;
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstDemoInvest);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstStatus);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lRoleDeptMap);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigatonResultsCaptureToHold Investigation_DAL", ex);
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
        /* END | NA | Sabari | 20181202 | Created | HOLD */
        public long SaveUnHoldDetails(List<PatientInvestigation> lstInvestigation)
        {
            long returnCode = -1;
            try
            {
                DataTable dtPatientInvestigation = UDT_DAL.ConvertToPatientInvestigation(lstInvestigation);
                SqlCommand cmd = Command.pSaveUnHoldDetailsCommand(dtPatientInvestigation);
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveUnHoldDetails Investigation_DAL", ex);
            }

            return returnCode;
        }
        public long UpdateNotificationForApprovedHold(long visitID, int orgID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pUpdateNotificationForApprovedHoldCommand(visitID, orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateNotificationForApprovedHold Investigation_DAL", ex);
            }


            return returnCode;
        }
        /* END | NA | Sabari | 20181202 | Created | HOLD */
        /* BEGIN | NA | Sabari | 20190508 | Created | BulkEnterResult */
        public long GetBatchWiseInvestigationResultsCaptureFormatBulkEnterResult(string VIDs, int OrgID, string BarcodeNumber, long RoleID, long DeptID, long InvID, string InvType, LoginDetail LDetail,
                   string IsTrustedDetails, long WorkListID, long deviceid, string pIsAbnormal, long pHeaderID, long pProtocalID, string pActionName, string pIsMaster, int pRecordCount, string visittype, string Location, string QcCheck, string PatIds,
                   string CollectLocID, out List<PatientInvestigation> lstInvestigation)
        {
            long result = -1;
            lstInvestigation = new List<PatientInvestigation>();
            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetBatchWiseInvestigationResultsCaptureFormatBulkEnterResultCommand(VIDs, OrgID, BarcodeNumber, RoleID, DeptID, InvID, InvType, DtLDetail, IsTrustedDetails, WorkListID, deviceid, pIsAbnormal, pHeaderID, pProtocalID, pActionName, pIsMaster, pRecordCount, visittype, Location, QcCheck, PatIds, CollectLocID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        result = Utilities.ConvertTo(dataReader, out lstInvestigation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBatchWiseInvestigationResultsCaptureFormat Investigation_DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return result;
        }

        /* END | NA | Sabari | 20190508 | Created | BulkEnterResult */


        public long getPakageDetails(int ID, out List<PackageDetails> lstpkgdetails)
        {
            long returnCode = -1;
            lstpkgdetails = new List<PackageDetails>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.PgetPakageDetailsCommand(ID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstpkgdetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("getPakageDetails", ex);
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
        public DataSet InterfacedValueWorklist(string worklistType, long SearchID, string Testtype, int orgid, string WLMode, string fromdate, string todate, long minvid, long maxvid, string visitnumber)
        {
            long num = -1L;
            DataSet dataSet = new DataSet();
            DataSet set2 = new DataSet();
            try
            {
                SqlCommand sqlCommand = Command.PgetInterfacedvalue_WorklistCommand(worklistType, SearchID, Testtype, orgid, WLMode, fromdate, todate, minvid, maxvid, visitnumber, UDT_DAL.ConvertToUDT_Context(this.globalContextDetails));
                using (DBEngine engine = new DBEngine())
                {
                    num = engine.ExecuteDataSet(sqlCommand, out dataSet);
                    set2 = dataSet;
                }
            }
            catch (Exception exception)
            {
                CLogger.LogError("Error in Investigation_DAL - InterfacedValueWorklist", exception);
            }
            return set2;
        }
        public long SaveSensitiveTestRemarks(long iVisitID, long iPatientID, long iTaskID, string patienthistory, string remarks)
        {
            long returncode = -1;
            try
            {
                SqlCommand cmd = Command.pSaveSensitiveTestPatientRemarksCommand(iVisitID, iPatientID, iTaskID, patienthistory, remarks, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (TransactionScope tranScope = new TransactionScope())
                {
                    try
                    {
                        using (DBEngine dbEngine = new DBEngine(true))
                        {
                            dbEngine.ExecuteTransactionalNonQuery(cmd);
                            tranScope.Complete();
                        }
                    }
                    catch (Exception exc)
                    {
                        tranScope.Dispose();
                    }
                    finally
                    {
                        tranScope.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL SaveSensitiveTestRemarks", ex);
            }
            return returncode;
        }
        public long GetIsSensitiveTestForVisit(long VisitID, long InvestigationID, int orgID, long AccessionNumber, string Status, string Type, out List<OrderedInvestigations> lstIO)
        {
            long returnCode = -1;
            lstIO = new List<OrderedInvestigations>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetIsSensitiveTestForVisitCommand(VisitID, InvestigationID, orgID, AccessionNumber, Status, Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstIO);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving GetIsSensitiveTestForVisit investigation_DAL", ex);
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
        public long PgetPreQuotation(int OrgId, string Searchtext, out List<InvestigationValues> PgetPreQuotation)
        {
            long returnCode = -1;
            PgetPreQuotation = new List<InvestigationValues>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.PgetPreQuotationCommand(OrgId, Searchtext, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out PgetPreQuotation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("PgetPreQuotation", ex);
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
        public long pGetBillingTestItemsSV(int OrgId, int FeeID, string FeeType, out List<BillingDetails> pGetBillingTestItemsSV)
        {
            long returnCode = -1;
            pGetBillingTestItemsSV = new List<BillingDetails>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetBillingTestItemsSVCommand(OrgId, FeeID, FeeType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out pGetBillingTestItemsSV);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("pGetBillingTestItemsSV", ex);
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

        public long PreQuotationBilling(int BookingID, int OrgID, out List<Bookings> lstPatientDetailes, out List<BillingDetails> lstPreQuotationBilling)
        {
            long returnCode = -1;
            int rsCount = 0;
            lstPatientDetailes = new List<Bookings>();
            lstPreQuotationBilling = new List<BillingDetails>();
            DataSet ds = new DataSet();
            SqlCommand cmd = Command.PreQuotationBillingCommand(BookingID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {

                using (DBEngine dbEngine = new DBEngine())
                {

                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientDetailes);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPreQuotationBilling);
                }

            }


            catch (Exception ex)
            {
                CLogger.LogError("PreQuotationBilling", ex);
            }

            return returnCode;
        }
        public long SaveOrderLocation(List<OrderedInvestigations> lstOrderInvestigation, int OrgID, string TaskAssignTo)
        {
            long returnCode = -1;
            DataTable InvLocDataList = UDT_DAL.ConvertToOrderedInvestigation(lstOrderInvestigation);
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pSaveCancelledTestDetailsCommand(InvLocDataList, OrgID, TaskAssignTo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dBEngine = new DBEngine(false))
                {
                    dBEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveQRMData Investigation_DAL", e);
            }
            return returnCode;
        }
        public long SaveOrganismRangeValues(List<InvOrganismDrugMapping> lstInvOrganismDrugMapping)
        {
            long returnCode = -1;
            try
            {
                DataTable dtOrganismRangeValues = UDT_DAL.ConvertToUDTInvOrganismDrugMapping(lstInvOrganismDrugMapping);
                SqlCommand cmd = Command.pSaveOrganismRangeValueMappingCommand(dtOrganismRangeValues, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting SaveOrganismRangeValues at Investigation DAL", ex);
            }
            finally
            {
            }
            return returnCode;
        }
        /* BEGIN | NA | Sabari | 17072019 | Created | LabTechPhysicianUsers */
        public long GetInvestigatonResultsCaptureSingleScreen(long VID, int OrgID, long RoleID, string gUID, long DeptID, string InvIDs,
                                                         int LocationID, LoginDetail LDetail, long taskid, string IsTrustedDetails, string status,
                                                         out List<PatientInvestigation> lstDemoInvest
                                                         , out List<InvestigationStatus> lstStatus
                                                         , out List<RoleDeptMap> lRoleDeptMap
            //, out List<InvReportMaster> lEditValues
            //, out List<InvestigationHeader> lstHeader
                                                         )
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstDemoInvest = new List<PatientInvestigation>();
            lstStatus = new List<InvestigationStatus>();
            lRoleDeptMap = new List<RoleDeptMap>();
            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
            try
            {
                SqlCommand cmd = Command.pGetInvestigationResultsCaptureSingleScreenCommand(VID, OrgID, RoleID,
                                                       gUID, DeptID, InvIDs, LocationID, taskid, DtLDetail, UDT_DAL.ConvertToUDT_Context(globalContextDetails), IsTrustedDetails, status);
                using (DBEngine dbEngine = new DBEngine())
                {
                    int rsCount = 0;
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstDemoInvest);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstStatus);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lRoleDeptMap);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigatonResultsCaptureSingleScreen Investigation_DAL", ex);
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
        public long GetDrawPatternInvBulkDataSingleScreen(string guid, List<InvPackageMapping> lstInvPackageMapping, long patientVisitID, int orgID, string status,
               out List<InvestigationValues> lstBulkData
          , out List<InvestigationValues> lstPendingValue, out List<InvestigationStatus> header, out List<InvestigationOrgMapping> lstiom, out List<PerformingPhysician> lPerformingPhysicain)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            int returnStatus = -1;
            DataTable invPMDT = UDT_DAL.ConvertToUDTInvPackageMapping(lstInvPackageMapping);
            lstBulkData = new List<InvestigationValues>();
            lstPendingValue = new List<InvestigationValues>();
            header = new List<InvestigationStatus>();
            lstiom = new List<InvestigationOrgMapping>();
            lPerformingPhysicain = new List<PerformingPhysician>();
            try
            {
                SqlCommand cmd = Command.pGetDrawPatternInvBulkDataSingleScreenCommand(guid, patientVisitID, orgID, returnStatus, invPMDT, UDT_DAL.ConvertToUDT_Context(globalContextDetails), status);
                using (DBEngine dbEngine = new DBEngine())
                {
                    int rsCount = 0;
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstBulkData);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPendingValue);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out header);
                            }
                            else if (rsCount == 3)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstiom);
                            }
                            else if (rsCount == 4)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lPerformingPhysicain);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDrawPatternInvBulkDataSingleScreen in investigationDAL", ex);
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
        public long SaveInvestigationResultsSingleScreen(long pSCMID,
            List<List<InvestigationValues>> lstInvestigationValues,
           List<PatientInvestigation> lstInvestigation,
            List<PatientInvSampleResults> lstPatientInvSampleResults,
            List<PatientInvSampleMapping> lstPatientInvSampleMapping,
            List<PatientInvestigationFiles> PatientInvestigationFiles,
            long vid, int OrgID, int deptID, long ApprovedBy,
            string gUID, out int returnStatus, List<PatientInvestigation> lstReflexPatientinvestigation, string isFromDevice)
        {
            long lresult = -1;
            int i;
            bool success = true;
            List<PatientInvestigation> lstPatient = new List<PatientInvestigation>();
            List<InvestigationValues> lstPatientVisit = new List<InvestigationValues>();
            List<PatientInvSampleResults> lstPInvSampleResults = new List<PatientInvSampleResults>();

            DataTable dtResults = UDT_DAL.ConvertToInvestigationResults(lstInvestigationValues);

            DataTable dtSR = UDT_DAL.ConvertToUDTinvSampleResults(lstPatientInvSampleResults);

            DataTable dtSM = UDT_DAL.ConvertToPatientInvSampleMapping(lstPatientInvSampleMapping);

            DataTable dtPatientFiles = UDT_DAL.ConvertToPatientInvestigationFiles(PatientInvestigationFiles);
            DataTable dtPatientInvestigation = UDT_DAL.ConvertToPatientInvestigation(lstInvestigation);
            DataTable dtReflexPatientInvestigation = UDT_DAL.ConvertToPatientInvestigation(lstReflexPatientinvestigation);

            SqlCommand cmd = Command.pInsertInvestigationResultsSingleScreenCommand(pSCMID, dtResults, vid, gUID, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails), isFromDevice);
            SqlCommand cmdSR = Command.pInsertinvSampleResultsSingleScreenCommand(dtSR, vid, OrgID, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            SqlCommand cmdSM = Command.pInsertInvSampleMappingSingleScreenCommand(dtSM, vid, OrgID, deptID, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            SqlCommand cmdUpdateteID = Command.pUpdatePatientInvestigationCompleteSingleScreenCommand(dtPatientInvestigation, pSCMID, ApprovedBy, gUID, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails), dtReflexPatientInvestigation);
            SqlCommand[] cmdMethod = new SqlCommand[lstPatient.Count];

            SqlCommand cmdFiles = Command.pInsertPatientInvestigationFilesSingleScreenCommand(dtPatientFiles, UDT_DAL.ConvertToUDT_Context(globalContextDetails));




            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        if (success)
                        {
                            dbEngine.ExecuteTransactionalNonQuery(cmdSR);
                            returnStatus = Convert.ToInt16(cmdSR.Parameters["@pReturnStatus"].Value.ToString());
                            if (returnStatus == 0)
                            {
                                dbEngine.ExecuteTransactionalNonQuery(cmdSM);
                                returnStatus = Convert.ToInt16(cmdSR.Parameters["@pReturnStatus"].Value.ToString());

                                if (returnStatus == 0)
                                {
                                    // Changed by Prasanna.S
                                    //dbEngine.ExecuteTransactionalNonQuery(cmd);
                                    //returnStatus = Convert.ToInt16(cmd.Parameters["@returnstatus"].Value.ToString());
                                    dbEngine.ExecuteTransactionalNonQuery(cmdUpdateteID);
                                    returnStatus = Convert.ToInt16(cmdUpdateteID.Parameters["@pReturnStatus"].Value.ToString());
                                    if (returnStatus == 0)
                                    {


                                        dbEngine.ExecuteTransactionalNonQuery(cmdFiles);

                                        if (success)
                                        {
                                            // Changed by Prasanna.S
                                            //dbEngine.ExecuteTransactionalNonQuery(cmdUpdateteID);
                                            //lresult = Convert.ToInt64(cmdUpdateteID.Parameters["@pReturnStatus"].Value);
                                            dbEngine.ExecuteTransactionalNonQuery(cmd);
                                            lresult = Convert.ToInt16(cmd.Parameters["@returnstatus"].Value.ToString());
                                            if (lresult != 0)
                                            {

                                                tranScope.Dispose();
                                            }



                                        }
                                    }
                                }
                            }
                            tranScope.Complete();

                        }
                    }
                }
                catch (Exception ex)
                {
                    tranScope.Dispose();
                }
            }
            // Changed by Prasanna.S
            //using (DBEngine dbEngine = new DBEngine())
            //{
            //    dbEngine.ExecuteNonQuery(cmd);
            //    lresult = Convert.ToInt16(cmd.Parameters["@returnstatus"].Value.ToString());
            //}
            return lresult;

        }
        public long SavePatientInvestigationSingleScreen(List<PatientInvestigation> PatientInvestigation, long OrgID, string gUID, out int pOrderedInvCnt)
        {
            int ret = -1;
            long retCode = -1;
            pOrderedInvCnt = 0;
            SqlCommand cmdInvestigation = new SqlCommand();
            DataTable invs = UDT_DAL.ConvertToPatientInvestigation(PatientInvestigation);
            cmdInvestigation = Command.pInsertInvestigationSingleScreenCommand(invs, OrgID, gUID, out pOrderedInvCnt, out ret, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInvestigation);
                    retCode = Convert.ToInt32(cmdInvestigation.Parameters["@returnstatus"].Value);
                    pOrderedInvCnt = Convert.ToInt32(cmdInvestigation.Parameters["@pOrderedInvCnt"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while SavePatientInvestigationSingleScreen investigation_DAL", e);
            }
            return retCode;

        }
        public long SavePatientInvSampleNMappingSingleScreen(List<PatientInvSample> LstPinvsample, List<PatientInvSampleMapping> LstPinvsamplemapping, string GUID, int orgid)
        {
            long returnCode = -1;
            int ret = -1;
            DataTable dtSaveIPInvSample = UDT_DAL.ConvertToIPInvSamples(LstPinvsample);
            DataTable dtSM = UDT_DAL.ConvertToPatientInvSampleMapping(LstPinvsamplemapping);
            SqlCommand cmd = Command.pSavePatientInvSampleNMappingSingleScreenCommand(dtSaveIPInvSample, dtSM, GUID, orgid, out ret, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteTransactionalNonQuery(cmd);
                returnCode = Convert.ToInt32(cmd.Parameters["@returnstatus"].Value);
            }

            return returnCode;
        }
        /* END | NA | Sabari | 17072019 | Created | LabTechPhysicianUsers */

        public long UpdatenotificationforCancel(long visitID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pUpdatenotificationforCancelCommand(visitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdatenotificationforCancel Investigation_DAL", ex);
            }


            return returnCode;
        }

        public long SaveInvestigationQCResults(string Barcode, int OrgID, int OrgAddressID, List<InvIntegrationQCResultValue> lstInvIntegrationQCResultValue, out int returnStatus)
        {
            long result = 0;
            returnStatus = -1;
            try
            {
                DataTable dtInvIntegrationQCResultValue = UDT_DAL.ConvertToInvIntegrationQCResultValue(lstInvIntegrationQCResultValue);
                SqlCommand cmdQC = Command.pInsertInvestigationQCResultsCommand(Barcode, OrgID, OrgAddressID, dtInvIntegrationQCResultValue, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdQC);
                    returnStatus = Convert.ToInt16(cmdQC.Parameters["@pReturnStatus"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                result = -1;
                CLogger.LogError("Error while saving InvestigationQCResults investigation_DAL", ex);
            }
            return result;
        }

        public long GetQCResultValidationDetails(string DeviceID, string LotNumber, string TestCode, string Level, int OrgID, out List<QCResultValidationDetails> lstQCValidateDetails, out List<QCResultDetails> lstlotResults, out List<QCResultDetails> lstotherlotResults)
        {
            IDataReader dataReader = null;
            long result = -1;
            lstQCValidateDetails = new List<QCResultValidationDetails>();
            lstlotResults = new List<QCResultDetails>();
            lstotherlotResults = new List<QCResultDetails>();

            try
            {
                SqlCommand cmd = Command.pGetQCResultValidationDetailsCommand(DeviceID, LotNumber, TestCode, Level, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();

                using (DBEngine dbengine = new DBEngine())
                {
                    dbengine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    result = Utilities.ConvertTo(ds.Tables[0], out lstQCValidateDetails);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    result = Utilities.ConvertTo(ds.Tables[1], out lstlotResults);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    result = Utilities.ConvertTo(ds.Tables[2], out lstotherlotResults);
                }
                return result;
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetQCResultValidationDetails Investigation_DAL", e);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return result;
        }
       public long GetInvestigationInstruction(long PatientvisitID,int OrgID ,int FeeID,string FeeType,out List<OrderedInvestigations> lstOrderedInstruction)
        {
            long returnCode = -1;
            lstOrderedInstruction = new List<OrderedInvestigations>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvestigationInstructionsCommand(PatientvisitID, OrgID,FeeID,FeeType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstOrderedInstruction);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetUOMCode", ex);
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
        public long GetBulkRegIntegrationNotifications(int InstanceID, out List<BulkRegIntegration> lstBulkRegIntegrations,out List<BulkRegFileDetails> lstfile)
        {
            lstBulkRegIntegrations = new List<BulkRegIntegration>();
            lstfile=new List<BulkRegFileDetails>();

            long returnCode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd = Command.PgetBulkRegIntegrationnotificationsCommand(InstanceID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBulkRegIntegrations);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    { 
                      returnCode=Utilities.ConvertTo(ds.Tables[1],out lstfile);
                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While GetBulkRegIntegrationNotifications in Investigation_DAL", ex);
            }
            return returnCode;
        }

        public long GetBulkRegIntegrationResultValue(long NotificationID, out List<BulkRegIntegrationResultValue> lstBulkRegIntegrationResultValue)
        {
            lstBulkRegIntegrationResultValue = new List<BulkRegIntegrationResultValue>();

            long returnCode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd = Command.PgetBulkRegIntegrationResultValueCommand(NotificationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBulkRegIntegrationResultValue);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While GetBulkRegIntegrationResultValue in Investigation_DAL", ex);
            }
            return returnCode;
        }

        public long UpdateBulkRegIntegrationNotifications(int InstanceID, List<BulkRegIntegration> lstBulkRegIntegration)
        {
            int ret = -1;
            long retCode = -1;


            DataTable invs = UDT_DAL.ConvertToUDTBulkRegIntegrationNotifications(lstBulkRegIntegration);
            SqlCommand cmd = new SqlCommand();

            cmd = Command.pUpdateBulkRegIntegrationNotificationsCommand(InstanceID, invs, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);

                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while updating UpdateBulkRegIntegrationNotifications investigation_DAL", e);
            }
            return retCode;

        }

        public long SaveOutSourcingPDFFilesDetails(string visitNumber, string testCode, string orgCode, string filePath,string ActionType)
        {
            long returnCode = 0;
            int returnStatus = -1;
            try
            {
                SqlCommand cmd = Command.pSaveOutSourcingPDFFilesDetailsCommand(visitNumber, testCode, orgCode, filePath,ActionType, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                    returnStatus = Convert.ToInt32(cmd.Parameters["@pReturnStatus"].Value);
                }
            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error while saving SaveOutSourcingPDFFilesDetails investigation_DAL", ex);
            }
            returnCode = returnStatus;
            return returnCode;
        }


        public long GetOutSourcePDFFileDetails(long pPatientVisitid, long pInvestigationId, long POrgID, out List<PatientInvestigationFiles> lstpatientImages)
        {
            IDataReader dataReader = null;
            lstpatientImages = new List<PatientInvestigationFiles>();
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pGetOutSourcePDFFileDetailsCommand(pPatientVisitid, pInvestigationId, POrgID);
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstpatientImages);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting  GetOutSourcePDFFileDetails Details ", ex);
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


        public long GetOrganismByStaintype(int CultureStainTypeId, int ResultID, int OrgID, string ResultTemplateType, out List<InvResultTemplate> lstOrganism)
        {
            long returnCode = -1;
            SqlCommand sqlCommand = new SqlCommand();
            IDataReader dataReader = null;
            lstOrganism = new List<InvResultTemplate>();
            try
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "pGetOrganismByStaintype";
                sqlCommand.Parameters.Add("@pCultureStainTypeId", SqlDbType.Int);
                sqlCommand.Parameters["@pCultureStainTypeId"].Value = CultureStainTypeId;
                sqlCommand.Parameters.Add("@pResultID", SqlDbType.BigInt);
                sqlCommand.Parameters["@pResultID"].Value = Convert.ToInt64(ResultID);
                sqlCommand.Parameters.Add("@pOrgID", SqlDbType.Int);
                sqlCommand.Parameters["@pOrgID"].Value = OrgID;
                sqlCommand.Parameters.Add("@pResultTemplateType", SqlDbType.NVarChar);
                sqlCommand.Parameters["@pResultTemplateType"].Size = 25;
                sqlCommand.Parameters["@pResultTemplateType"].Value = ResultTemplateType;
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(sqlCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstOrganism);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetOrganismByStaintype", ex);
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
        public long UpdatePatientVisitInvestigationStatus(List<PatientInvestigation> InvestigationList, string gUID, out int returnStatus)
        {
            long returnCode = -1;
            returnStatus = -1;
            try
            {
                DataTable dtPatientInvestigation = UDT_DAL.ConvertToPatientInvestigation(InvestigationList);
                SqlCommand cmdUpdateteID = Command.pUpdatePatientVisitInvestigationStatusCommand(dtPatientInvestigation, gUID, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdUpdateteID);
                    returnStatus = Convert.ToInt16(cmdUpdateteID.Parameters["@pReturnStatus"].Value.ToString());

                }

            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing UpdatePatientVisitInvestigationStatus BL", excp);
            }

            return returnCode;
        }
        public long GetVisitWiseInvestigationResults(string VIDs, int OrgID, string BarcodeNumber, long RoleID, long DeptID, long InvID, string InvType, LoginDetail LDetail,
                string IsTrustedDetails, long WorkListID, long deviceid, string pIsAbnormal, long pHeaderID, long pProtocalID, string pActionName, string pIsMaster, int pRecordCount, string visittype, string Location, string QcCheck, string PatIds,
                string CollectionLocID, DateTime fromdate, DateTime todate, out DataSet lstInvestigation)
        {
            long result = -1;
            lstInvestigation = new DataSet();
            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
            try
            {
                SqlCommand cmd = Command.pGetVisitBulkApprovalDetailsCommand(VIDs, OrgID, BarcodeNumber, RoleID, DeptID, InvID, InvType, DtLDetail, IsTrustedDetails, WorkListID, deviceid, pIsAbnormal, pHeaderID, pProtocalID, pActionName, pIsMaster, pRecordCount, visittype, Location, QcCheck, PatIds, CollectionLocID, fromdate, todate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out lstInvestigation);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetVisitWiseInvestigationResults Investigation_DAL", ex);
            }
            return result;
        }


        public long GetValidateAutoCertify(long investigationid, int orgid, long visitid, long groupid, out List<InvAutoCertifyValidation> lstInvAutoCertifyValidation, out  List<InvAutoCertifyValidation> lstcrossInvCertify)
        {
            long returnCode = -1;
            lstInvAutoCertifyValidation = new List<InvAutoCertifyValidation>();
            lstcrossInvCertify = new List<InvAutoCertifyValidation>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetValidateAutoCertifyCommand(investigationid, orgid, visitid, groupid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    // dataReader = dbEngine.ExecuteReader(cmd);

                   int rsCount = 0;
                   dataReader = dbEngine.ExecuteReader(cmd);
                   if (dataReader != null)
                   {
                       do
                       {
                           if (rsCount == 0)
                           {
                               returnCode = Utilities.ConvertTo(dataReader, out lstInvAutoCertifyValidation);
                           }
                           else if (rsCount == 1)
                           {
                               returnCode = Utilities.ConvertTo(dataReader, out lstcrossInvCertify);
                           }
                           rsCount = rsCount + 1;
                       } while (dataReader.NextResult());
                       dataReader.Close();
                   }
               }
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while executing GetValidateAutoCertify in Investigation_DAL", ex);
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

        public long CalculateFormulatest(long groupid, long visitid, long orgid, long investigationid, string value, string deviceID, out List<InvestigationValues> lstInvValues)
        {
            long returnCode = -1;
            lstInvValues = new List<InvestigationValues>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.CalculateFormulatest(groupid, visitid, orgid, investigationid, value,deviceID);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvValues);
                        dataReader.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing CalculateFormulatest Investigation_DAL", ex);
            }
            return returnCode;
        }
        public long SaveInvRulemaster(List<InvRuleMaster> lstInvRuleMaster, List<PatientAgeGenderRule> lstPatientAgeGenderRule, List<TestResultsRule> lstTestResultsRule, List<MachineErrorRule> lstMachineErrorRule, int orgID, int RemarksId, out List<InvRuleMaster> lstoutInvRuleMaster)
        {
            long result = 0;
            lstoutInvRuleMaster = new List<InvRuleMaster>();
            try
            {
                
                DataTable dtInvRuleMaster = UDT_DAL.ConvertToInvRuleMaster(lstInvRuleMaster);
                DataTable dtPatientAgeGenderRule = UDT_DAL.ConvertToPatientAgeGenderRule(lstPatientAgeGenderRule);
                DataTable dtTestResultsRule = UDT_DAL.ConvertToTestResultsRule(lstTestResultsRule);
                DataTable dtMachineErrorRule = UDT_DAL.ConvertToMachineErrorRule(lstMachineErrorRule);
                IDataReader dataReader = null;
                SqlCommand cmdIV = Command.pSaveInvRulemasterCommand(dtInvRuleMaster, dtPatientAgeGenderRule, dtTestResultsRule,dtMachineErrorRule,orgID,RemarksId ,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    int rsCount = 0;
                    dataReader = dbEngine.ExecuteReader(cmdIV);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                result = Utilities.ConvertTo(dataReader, out lstoutInvRuleMaster);
                            }
                            
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                result = -1;
                CLogger.LogError("Error while saving SaveInvRulemaster investigation_DAL", ex);
            }
            return result;
        }

        public long GetInvRulemaster(int RuleTypeid, long investigationid, int orgid, int RemarksId,out List<InvRuleMaster> lstInvRuleMaster, out  List<PatientAgeGenderRule> lstPatientAgeGenderRule, out List<TestResultsRule> lstTestResultsRule, out List<MachineErrorRule> lstMachineErrorRule)
        {
            long returnCode = -1;
            lstInvRuleMaster = new List<InvRuleMaster>();
            lstPatientAgeGenderRule = new List<PatientAgeGenderRule>();
            lstTestResultsRule = new List<TestResultsRule>();
            lstMachineErrorRule = new List<MachineErrorRule>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.PgetInvRulemasterCommand(RuleTypeid,investigationid, orgid, RemarksId,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    // dataReader = dbEngine.ExecuteReader(cmd);

                    int rsCount = 0;
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvRuleMaster);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPatientAgeGenderRule);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstTestResultsRule);
                            }
                            else if (rsCount == 3)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstMachineErrorRule);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing PgetInvRulemaster in Investigation_DAL", ex);
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

        public long deleteRuleMaster(int RuleMasterId,int RuleTypeid, long investigationid, int orgid, int RemarksId)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.PdeleteInvRuleMasterCommand(RuleMasterId, RuleTypeid, investigationid, orgid, RemarksId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing deleteRuleMaster in Investigation_DAL", ex);
            }
            
            return returnCode;
        }

        public long GetInvRulemasterCondition(int RuleTypeid, long investigationid, int orgid, string InvType, out List<InvRuleMaster> lstInvRuleMaster)
        {
            long returnCode = -1;
            lstInvRuleMaster = new List<InvRuleMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.PgetInvRulemasterConditionCommand(RuleTypeid, investigationid, orgid, InvType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    // dataReader = dbEngine.ExecuteReader(cmd);

                    int rsCount = 0;
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvRuleMaster);
                            }
                            
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing PgetInvRulemaster in Investigation_DAL", ex);
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


        public long GetInvRulemasterVisit(long Visitid, long investigationid, int orgid, string InvType, out List<InvRuleMaster> lstInvRuleMaster, out  List<PatientAgeGenderRule> lstPatientAgeGenderRule, out List<TestResultsRule> lstTestResultsRule, out List<MachineErrorRule> lstMachineErrorRule, out List<InvRuleMaster> lstInvremarks)
        {
            long returnCode = -1;
            lstInvRuleMaster = new List<InvRuleMaster>();
            lstInvremarks = new List<InvRuleMaster>();
            lstPatientAgeGenderRule = new List<PatientAgeGenderRule>();
            lstTestResultsRule = new List<TestResultsRule>();
            lstMachineErrorRule = new List<MachineErrorRule>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.PgetInvRulemasterVisitCommand(Visitid, investigationid, orgid,InvType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    // dataReader = dbEngine.ExecuteReader(cmd);

                    int rsCount = 0;
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvRuleMaster);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPatientAgeGenderRule);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstTestResultsRule);
                            }
                            else if (rsCount == 3)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstMachineErrorRule);
                            }
                            else if (rsCount == 4)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvremarks);
                            }
                            
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing PgetInvRulemaster in Investigation_DAL", ex);
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
 public DataSet DynamicInvValues(DateTime Fdate, DateTime Tdate, string VisitNo,long GroupID, string Param1, string Param2, string Param3, string Param4, long Param5)
        {
            long num = -1L;
            DataSet dataSet = new DataSet();
            DataSet set2 = new DataSet();
            try
            {
                SqlCommand sqlCommand = Command.pGetDynamicReportforInvValuesCommand(Fdate, Tdate, VisitNo,GroupID, Param1, Param2, Param3, Param4, Param5, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine engine = new DBEngine())
                {
                    num = engine.ExecuteDataSet(sqlCommand, out dataSet);
                    set2 = dataSet;
                }
            }
            catch (Exception exception)
            {
                CLogger.LogError("Error in Report_BL - DynamicInvValues", exception);
            }
            return set2;
        }
        public long SaveInvValuesforCovidReport(List<InvValuesforCovidReport> historyMappingLst,long GroupID, string Param1, string Param2, string Param3, string Param4, long Param5)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pSaveDynamicInvValuesCommand(UDT_DAL.ConvertToCovidReport(historyMappingLst),GroupID, Param1, Param2, Param3, Param4, Param5,
                UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                //DataSet ds = new DataSet();
                dBEngine.ExecuteTransactionalNonQuery(cmd);
                returnCode = 0;
            }
            return returnCode;
        }
    }
}
