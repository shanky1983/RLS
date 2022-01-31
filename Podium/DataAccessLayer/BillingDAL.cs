using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.Common;
using Attune.Podium.BusinessEntities;
using System.ComponentModel;
using Attune.Solution.DAL;
using System.Transactions;
using Attune.Podium.BusinessEntities.CustomEntities;

namespace Attune.Podium.DataAccessLayer
{
    public class BillingDAL
    {
        ContextDetails globalContextDetails;
        public BillingDAL()
        {

        }
        public BillingDAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long SaveConsultingBillingEntry(int physicianID, long orgID, long patientID, long visitID, long createdBy)
        {
            long lResult = -1;
            SqlCommand cmd = Command.pInsertConsultingBillEnrtyWithoutAmountCommand(physicianID, visitID, patientID, orgID,
                createdBy, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                lResult = dbEngine.ExecuteNonQuery(cmd);
            }
            return lResult;
        }
        public long GetBillDetailSearch(string Clientname, string visitno, DateTime pFDT, DateTime pTDT, long orgID, string RdoResult, long startRowIndex, long PageSize, out long totalRows, out List<ResultSearch> search)
        {
            long lResult = -1;
            DataSet ds = new DataSet();
            DataTable globalContDetails = new DataTable();
            search = new List<ResultSearch>();
            //globalContDetails = UDT_DAL.ConvertToUDT_Conxt(search);
            //DataTable globalCont = new DataTable();
            SqlCommand cmd = Command.pGetViewBillingDetailsCommand(orgID, visitno, Clientname, pFDT, pTDT, PageSize, startRowIndex, out totalRows, RdoResult, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                lResult = dBEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    lResult = Utilities.ConvertTo(ds.Tables[0], out search);
                    totalRows = Convert.ToInt32(ds.Tables[1].Rows[0]["totalRows"]);
                }
            }
            return lResult;
        }
        //public long SaveBillDetailSearch(long orgID, List<ResultSearch> lstResultSearch)
        //{
        //    long lResult = -1;
        //    DataTable dtResultSearch = new DataTable();
        //    dtResultSearch = UDT_DAL.ConvertToUDT_Conxt(lstResultSearch);
        //    //lResult = Utilities.ConvertFrom(lstAmountRefundDetails, out dtResultSearch);
        //    SqlCommand cmd = Command.pInsertBillDetailSearchCommand(orgID, dtResultSearch, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

        //    using (DBEngine dbEngine = new DBEngine(false))
        //    {
        //        lResult = dbEngine.ExecuteNonQuery(cmd);
        //    }
        //    return lResult;
        //}

        public long SaveConsultingBillingEntry(long orgID, out long BillID, out string BillNumber, long visitID, long createdBy, List<SaveBillingDetails> lst, int LocationID, long pBillingDetailsID)
        {
            long lResult = -1;
            BillID = 0;
            DataTable dt = new DataTable();
            lResult = Utilities.ConvertFrom(lst, out dt);
            SqlCommand cmd = Command.pInsertConsultingBillEnrtyCommand(visitID, out BillID, out BillNumber, orgID, createdBy, dt, LocationID, pBillingDetailsID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dbEngine = new DBEngine(false))
            {

                lResult = dbEngine.ExecuteNonQuery(cmd);
                Int64.TryParse(cmd.Parameters["@pFinalBillID"].Value.ToString(), out BillID);
                BillNumber = cmd.Parameters["@pBillNumber"].Value.ToString();
            }
            return lResult;
        }




        public long SaveProcedureBillingEntry(int procedureID, long orgID, long visitID, long patientID, long createdBy)
        {
            long lResult = -1;
            SqlCommand cmd = Command.pInsertProcedureBillEntryWithoutAmountCommand(procedureID, visitID, patientID, orgID, createdBy, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                lResult = dbEngine.ExecuteNonQuery(cmd);
            }
            return lResult;

        }

        public long SaveProcedureBillingEntry(long orgID, out long BillID, long visitID, long createdBy, List<SaveBillingDetails> lstSaveBillingDetail, int LocationID)
        {
            long lResult = -1;
            BillID = 0;
            DataTable dt = new DataTable();
            lResult = Utilities.ConvertFrom(lstSaveBillingDetail, out dt);
            SqlCommand cmd = Command.pInsertProcedureBillEntryCommand(visitID, out BillID, orgID, createdBy, dt, LocationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                lResult = dbEngine.ExecuteNonQuery(cmd);
                Int64.TryParse(cmd.Parameters["@pFinalBillID"].Value.ToString(), out BillID);
            }
            return lResult;

        }

        public long SaveInvestigationBillingEntry(int investigationID, long orgID, long patientID, long visitID, long createdBy)
        {
            long lResult = -1;
            SqlCommand cmd = Command.pInsertInvestigationFeeEntryWithoutAmountCommand(investigationID, visitID, patientID, orgID, createdBy, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                lResult = dbEngine.ExecuteNonQuery(cmd);
            }
            return lResult;
        }

        public long SaveInvestigationBillingEntry(long orgID, out long BillID,
                long visitID, long createdBy, long clientID, List<SaveBillingDetails> lstSaveBillingDetail,
            int LocationID, out string LabNo)
        {
            long lResult = -1;
            BillID = 0;
            LabNo = "";
            DataTable dt = new DataTable();
            lResult = Utilities.ConvertFrom(lstSaveBillingDetail, out dt);
            SqlCommand cmd = Command.pInsertInvestigationFeeEntryCommand(visitID, out BillID, orgID,
                                                    createdBy, clientID, dt, LocationID, out LabNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                lResult = dbEngine.ExecuteNonQuery(cmd);
                Int64.TryParse(cmd.Parameters["@pFinalBillID"].Value.ToString(), out BillID);
                LabNo = cmd.Parameters["@pLabNo"].Value.ToString();
            }
            return lResult;
        }

        public long GetDueDetails(long orgID, long patientID, long visitID, out long finalBillID,
            out List<FinalBill> dueDetails, out string visitType)
        {
            long lResult = -1;
            finalBillID = -1;
            visitType = "";
            dueDetails = new List<FinalBill>();
             IDataReader dataReader = null;
             try
             {
                 SqlCommand cmd = Command.pGetDuesCommand(patientID, orgID, visitID, out finalBillID, out visitType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                 using (DBEngine dbEngine = new DBEngine(false))
                 {
                     dataReader = dbEngine.ExecuteReader(cmd);
                     if (dataReader != null)
                     {
                         lResult = Utilities.ConvertTo(dataReader, out dueDetails);
                         dataReader.Close();
                     }

                     Int64.TryParse(cmd.Parameters["@pFinalBillID"].Value.ToString(), out finalBillID);
                     visitType = cmd.Parameters["@pVisitType"].Value.ToString();
                 }
             }
             catch (Exception e)
             {
                 CLogger.LogError("Error while executing GetDueDetails Billint_DAL", e);
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
        public long GetBillingDetails(long orgID, long patientID, long visitID,
                                        out List<BillingDetails> billingDetails,
                                        out List<StandardDeduction> lstStdDeduction,
                                        long FinalBillD)
        {

            long lResult = -1;
            billingDetails = new List<BillingDetails>();
            lstStdDeduction = new List<StandardDeduction>();

            SqlCommand cmd = Command.pGetBillingDetailsCommand(visitID, patientID, orgID, FinalBillD, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet dataSet = new DataSet();
            using (DBEngine dbEngine = new DBEngine(false))
            {
                lResult = dbEngine.ExecuteDataSet(cmd, out dataSet);
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    lResult = Utilities.ConvertTo(dataSet.Tables[0], out billingDetails);
                }
                if (dataSet.Tables[1].Rows.Count > 0)
                {
                    lResult = Utilities.ConvertTo(dataSet.Tables[1], out lstStdDeduction);
                }

            }

            return lResult;
        }

        public long UpdateFinalBill(FinalBill finalBill,
            AmountReceivedDetails amtRD,
            DataTable dtAmtReceived,
            List<PatientDueChart> pPatientIndTable,
            List<TaxBillDetails> lstTaxDetails, decimal dserviceCharge, List<VisitClientMapping> lstVisitClientMapping)
        {
            long lResult = -1;
            DataTable dtTax = new DataTable();
            dtTax = UDT_DAL.ConvertToUDTaxBillDetails(lstTaxDetails);
            DataTable dtBillingDetails = new DataTable();
            dtBillingDetails = UDT_DAL.ConvertToUDTPatientDueChart(pPatientIndTable);
            DataTable dtVisitClientmapping = new DataTable();
            dtVisitClientmapping = UDT_DAL.ConvertToVisitClientMapping(lstVisitClientMapping);

            SqlCommand cmd = Command.pUpdateFinallBillCommand(finalBill.VisitID,
                                    finalBill.FinalBillID, finalBill.OrgID, finalBill.AmountReceived, finalBill.DiscountAmount,
                                    finalBill.Due, finalBill.CurrentDue, finalBill.GrossBillValue, finalBill.IsCreditBill,
                                    finalBill.NetValue, finalBill.StdDedID, finalBill.ModifiedBy, dtAmtReceived, dtBillingDetails,
                                                    amtRD.AmtReceived, amtRD.ReceivedBy, amtRD.CreatedBy, dtTax, finalBill.DiscountReason, dserviceCharge, finalBill.RoundOff, UDT_DAL.ConvertToUDT_Context(globalContextDetails), dtVisitClientmapping);
            using (DBEngine dbEngine = new DBEngine(false))
            {
                lResult = dbEngine.ExecuteNonQuery(cmd);
            }
            return lResult;
        }


        public long GetPhysicianFeesDetail(long visitID, long physicianID, int orgID, out List<BillingFeeDetails> lstPhisicanFeesDetails)
        {
            long lResult = -1;
            lstPhisicanFeesDetails = new List<BillingFeeDetails>();

            SqlCommand cmd = Command.pGetPhysicianFeeDetailsCommand(physicianID, orgID, visitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine(false))
            {
                lResult = dbEngine.ExecuteDataSet(cmd, out ds);

                if (ds.Tables.Count > 0)
                {
                    lResult = Utilities.ConvertTo(ds.Tables[0], out lstPhisicanFeesDetails);
                }

            }

            return lResult;
        }

        public long GetProcedureFeeDetailsWithClientID(long pVisitID, long procedureID, long orgID, out List<BillingFeeDetails> lstProcedureFeeDetail, string sCheckAll, long pClientID)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetProcedureFeeDetailsWithClientIDCommand(pVisitID, procedureID, orgID, sCheckAll, pClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            lstProcedureFeeDetail = new List<BillingFeeDetails>();
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstProcedureFeeDetail);
                }
            }
            return returnCode;
        }

        public long GetProcedureFeesDetails(long pVisitID, long procedureID, long orgID, out List<BillingFeeDetails> lstProcedureFeeDetail, string sCheckAll)
        {

            long returnCode = -1;
            SqlCommand cmd = Command.pGetProcedureFeeDetailsCommand(pVisitID, procedureID, orgID, sCheckAll, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            lstProcedureFeeDetail = new List<BillingFeeDetails>();
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstProcedureFeeDetail);
                }
            }

            return returnCode;
        }

        public long GetInvestigationFeesDetails(long patientVisitID, long orgID, long clientID, out List<BillingFeeDetails> lstInvestigationFeesDetails)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pGetInvestigationFeeDetailsCommand(patientVisitID, orgID, clientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            lstInvestigationFeesDetails = new List<BillingFeeDetails>();
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvestigationFeesDetails);
            }

            return returnCode;

        }


        public long GetBillPrintingDetails(long visitID, out List<BillingDetails> lstBillingDetails,
                                                         out List<FinalBill> lstFinalBill,
                                                         out List<Patient> lstPatientDetail,
                                                         out List<Organization> lstOrganization,
                                                         out string physicianName,
                                                         out List<DuePaidDetail> lstDuesPaid,
                                                         long FinalBillID, out List<Taxmaster> lstTaxes, out string splitstatus, out List<PatientQualification> lstQualification)
        {
            long returnCode = -1;
            lstBillingDetails = new List<BillingDetails>();
            lstFinalBill = new List<FinalBill>();
            lstPatientDetail = new List<Patient>();
            lstOrganization = new List<Organization>();
            lstDuesPaid = new List<DuePaidDetail>();
            lstTaxes = new List<Taxmaster>();
            lstQualification = new List<PatientQualification>();
            physicianName = string.Empty;
            splitstatus = string.Empty;
            DataSet ds = new DataSet();

            SqlCommand cmd = Command.pGetBillPrintingCommand(visitID, out physicianName, FinalBillID, out splitstatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

            }
            physicianName = Convert.ToString(cmd.Parameters["@pPhysicianName"].Value);
            splitstatus = Convert.ToString(cmd.Parameters["@SplitStatus"].Value);
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillingDetails);
            }

            if (ds.Tables[1].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstFinalBill);
            }

            if (ds.Tables[2].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatientDetail);
            }

            if (ds.Tables[3].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[3], out lstOrganization);
            }
            if (ds.Tables[4].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[4], out lstDuesPaid);
            }
            if (ds.Tables[5].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[5], out lstTaxes);
            }
            if (ds.Tables[6].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[6], out lstQualification);
            }
            return returnCode;
        }

        public long GetOrderedItemsForBillEdit(long visitID, out List<BillingDetails> lstBillingDetails,
                                                        out List<FinalBill> lstFinalBill,                                 
                                                        long FinalBillID)
        {
            long returnCode = -1;
            lstBillingDetails = new List<BillingDetails>();
            lstFinalBill = new List<FinalBill>();

            DataSet ds = new DataSet();

            SqlCommand cmd = Command.pGetOrderedItemsForBillEditCommand(visitID, FinalBillID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

            }
            //physicianName = Convert.ToString(cmd.Parameters["@pPhysicianName"].Value);
            //splitstatus = Convert.ToString(cmd.Parameters["@SplitStatus"].Value);
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillingDetails);
            }

            if (ds.Tables[1].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstFinalBill);
            }



            return returnCode;
        }




        public long InsertAdvanceAmount(long orgID, long patientID, long patientVisitID, decimal advanceAmount, string type)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pInsertAdvanceAmountCommand(orgID, patientID, patientVisitID, advanceAmount, type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
            }

            return returnCode;
        }

        public long GetPhysicianBeforeFeeDetail(long patientVisitID, int orgID, out List<BillingDetails> lstFeeDetails, out List<StandardDeduction> lstStdDeduction)
        {
            long returnCode = -1;
            lstFeeDetails = new List<BillingDetails>();
            lstStdDeduction = new List<StandardDeduction>();

            DataSet ds = new DataSet();
            SqlCommand cmd = Command.pGetPhysicianBeforeFeeDetailsCommand(patientVisitID, orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {

                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstFeeDetails);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstStdDeduction);
                }

            }
            return returnCode;
        }
        public long InsertPhysicianBeforeFeeDetail(FinalBill finalBill, List<BillingDetails> lstBillingDetail)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pInsertPhysicianBeforeFeeDetailsCommand(finalBill.VisitID, finalBill.OrgID, lstBillingDetail[0].Amount,
                                    lstBillingDetail[0].FeeId, lstBillingDetail[0].FeeType, lstBillingDetail[0].FeeDescription, finalBill.CreatedBy, finalBill.AmountReceived, finalBill.DiscountAmount,
                                    finalBill.Due, finalBill.GrossBillValue, finalBill.NetValue, finalBill.StdDedID, finalBill.ModifiedBy,
                                                   finalBill.IsCreditBill, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
            }

            return returnCode;
        }

        public long GetBeforeAfterPaymentMode(long patientvisitID, out List<VisitPurpose> lstVisitPurpose)
        {
            long returnCode = -1;
            lstVisitPurpose = new List<VisitPurpose>();

            DataSet ds = new DataSet();
            SqlCommand cmd = Command.pGetBeforeAfterPaymentModeCommand(patientvisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstVisitPurpose);
                }
            }

            return returnCode;
        }

        public long GetFinalBillDetail(long patientVisitID, out List<FinalBill> lstFinallBill, out List<StandardDeduction> lstStdDeduction)
        {
            long returnCode = -1;
            lstFinallBill = new List<FinalBill>();
            lstStdDeduction = new List<StandardDeduction>();

            DataSet ds = new DataSet();
            SqlCommand cmd = Command.pGetFinalBillDetailCommand(patientVisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstFinallBill);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstStdDeduction);
                }

            }

            return returnCode;
        }

        public long GetPreviousTaskDetail(long taskID, out List<Tasks> lstTasks)
        {
            long returnCode = -1;
            lstTasks = new List<Tasks>();

            DataSet ds = new DataSet();
            SqlCommand cmd = Command.pGetPreviousTaskDetailCommand(taskID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstTasks);
                }
            }

            return returnCode;

        }

        public long GetProcedureBeforeFeeDetails(long procedureID, int orgID, out List<BillingDetails> lstBillingDetails, out List<StandardDeduction> lstStdDeduction)
        {
            long returnCode = -1;
            lstBillingDetails = new List<BillingDetails>();
            lstStdDeduction = new List<StandardDeduction>();

            DataSet ds = new DataSet();
            SqlCommand cmd = Command.pGetProcedureBeforeFeeDetailCommand(procedureID, orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillingDetails);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstStdDeduction);
                }
            }

            return returnCode;

        }

        public long UpdateAndInsertDueDetail(List<DuePaidDetail> lstDuePaidDetail)
        {
            long returnCode = -1;

            DataTable dtDuePaidDetail = new DataTable();
            dtDuePaidDetail = UDT_DAL.ConvertToUpdateAndInsertDueTable(lstDuePaidDetail);

            SqlCommand cmd = Command.pUpdateAndInsertDueDetailCommand(dtDuePaidDetail, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
            }

            return returnCode;

        }


        public long UpdatePatientInvStatus(List<PatientInvestigation> lstPatient, out int count)
        {
            long lresult = -1;
            count = 0;
            DataTable dtPatient = new DataTable();
            dtPatient = UDT_DAL.ConvertToPatientInvestigation(lstPatient);
            SqlCommand cmd = Command.pUpdatePatientInvStatusCommand(dtPatient, 0, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@pCount", SqlDbType.Int);
            cmd.Parameters["@pCount"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine())
            {
                lresult = dbEngine.ExecuteNonQuery(cmd);
                lresult = 0;
            }

            return lresult;
        }



        public long GetFinalBillID(long PatientId, long PatientVisitId, out long outStatus)
        {
            long returncode = -1;

            SqlCommand cmd = Command.pGetFinalBillIDCommand(PatientId, PatientVisitId, out outStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                    outStatus = Convert.ToInt32(cmd.Parameters["@pOutStatus"].Value);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing GetFinalBillID", ex);
            }

            return returncode;
        }
        public long InsertMiscellaneousBills(BillingDetails bd)
        {
            long returncode = -1;

            SqlCommand cmd = new SqlCommand();
            cmd = Command.pInsertMiscellaneousBillsCommand(bd.FinalBillID, bd.FeeId, bd.FeeType, bd.FeeDescription, bd.Amount, bd.CreatedBy, bd.ModifiedBy, bd.IsReimbursable, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(true))
            {
                dbEngine.ExecuteNonQuery(cmd);
            }

            return returncode;
        }
        public long pGetRefundBillingDetails(long visitID, out List<BillingDetails> lstBillingDetails, out decimal amtReceived, out decimal amtRefunded, out decimal dChequeAmount, long FinalBillID, long billDetailsID)
        {
            long returnCode = -1;
            lstBillingDetails = new List<BillingDetails>();
            IDataReader dataReader = null;
            amtReceived = 0;
            amtRefunded = 0;
            dChequeAmount = 0;
            try
            {
                SqlCommand cmd = Command.pGetRefundBillingCommand(visitID, FinalBillID, billDetailsID, out amtReceived, out amtRefunded, out dChequeAmount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstBillingDetails);
                        dataReader.Close();
                    }
                    decimal.TryParse(cmd.Parameters["@pAmtReceived"].Value.ToString(), out amtReceived);
                    decimal.TryParse(cmd.Parameters["@pTotRfdAmt"].Value.ToString(), out amtRefunded);
                    decimal.TryParse(cmd.Parameters["@pChequeAmount"].Value.ToString(), out dChequeAmount);
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
            return returnCode;
        }

        public long GetCollectionDetails(long collectedBy, string fromDate,
                string toDate, int orgID, out decimal totalAdditions,
                out decimal totalDeduction, out List<ServiceQtyAmount> lstInflowDtls,
                out List<ServiceQtyAmount> lstOutflowDtls)
        {
            long returnCode = -1;
            totalAdditions = 0;
            totalDeduction = 0;
            lstInflowDtls = new List<ServiceQtyAmount>();
            lstOutflowDtls = new List<ServiceQtyAmount>();

            SqlCommand cmd = Command.pGetCollectionDtlByUserCommand(collectedBy, fromDate, toDate, orgID, out totalAdditions, out totalDeduction, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOutflowDtls);
            }
            if (ds.Tables[1].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstInflowDtls);
            }

            if (lstInflowDtls.Count > 0 || lstOutflowDtls.Count > 0)
            {
                totalAdditions = Convert.ToDecimal(cmd.Parameters["@TotalAddition"].Value);
                totalDeduction = Convert.ToDecimal(cmd.Parameters["@TotalDeduction"].Value);
            }

            return returnCode;
        }

        public long GetCollectionDetails(string fromDate,
                string toDate, int orgID, out decimal totalAdditions,
                out decimal totalDeduction, out List<ServiceQtyAmount> lstInflowDtls,
                out List<ServiceQtyAmount> lstOutflowDtls)
        {
            long returnCode = -1;
            totalAdditions = 0;
            totalDeduction = 0;
            lstInflowDtls = new List<ServiceQtyAmount>();
            lstOutflowDtls = new List<ServiceQtyAmount>();

            SqlCommand cmd = Command.pGetTotalCollectionDtlCommand(fromDate, toDate, orgID, out totalAdditions, out totalDeduction, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOutflowDtls);
            }
            if (ds.Tables[1].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstInflowDtls);
            }

            if (lstInflowDtls.Count > 0 || lstOutflowDtls.Count > 0)
            {
                totalAdditions = Convert.ToDecimal(cmd.Parameters["@TotalAddition"].Value);
                totalDeduction = Convert.ToDecimal(cmd.Parameters["@TotalDeduction"].Value);
            }

            return returnCode;
        }

        public long GetAmountReceivedDetails(long UserID, int OrgId, DateTime pFDT, DateTime pTDT,int locationId, out List<ReceivedAmount> lstBillingDetails,
                                              out List<ReceivedAmount> lstRefundDetails,
                                              out List<ReceivedAmount> lstPaymentDetails,
                                              out decimal dTotalAmount, out decimal dTotalRefund, out decimal dTotalCancelledAmount,
                                              out string sRcvdFromtime, out string sRcvdTotime,
                                              out string sRefundFromtime, out string sRefundTotime,
                                              out string sMinStartTime, out string sMaxEndTime,
                                              out decimal drAmount, out decimal othersAmount,
                                              out decimal TotalIncAmount,
                                              out List<ReceivedAmount> lstINDAmtReceivedDetails,
                                              out List<ReceivedAmount> lstINDIPAmtReceivedDetails,
                                              out List<AmountReceivedDetails> lstreceivedTypes,
                                             out List<ReceivedAmount> lstSplitDetails,
                                             out List<AmountReceivedDetails> lstIncSourcePaidDetails,
                                             out List<CurrencyOrgMapping> lstCurrencyInHand,
                                             out List<CashClosureDenomination> lstCCDeno,
                                             out decimal TotalPendingSettleAmt)
        {
            long returnCode = -1;
            sRcvdFromtime = string.Empty;
            sRcvdTotime = string.Empty;
            sRefundFromtime = string.Empty;
            sRefundTotime = string.Empty;
            lstRefundDetails = new List<ReceivedAmount>();
            lstBillingDetails = new List<ReceivedAmount>();
            lstPaymentDetails = new List<ReceivedAmount>();
            lstINDAmtReceivedDetails = new List<ReceivedAmount>();
            lstINDIPAmtReceivedDetails = new List<ReceivedAmount>();
            lstreceivedTypes = new List<AmountReceivedDetails>();
            lstSplitDetails = new List<ReceivedAmount>();
            lstCurrencyInHand = new List<CurrencyOrgMapping>();
            lstCCDeno = new List<CashClosureDenomination>();
            lstIncSourcePaidDetails = new List<AmountReceivedDetails>();
            int rsCount = 0;
            dTotalAmount = 0;
            dTotalRefund = 0; dTotalCancelledAmount = 0;
            drAmount = 0;
            othersAmount = 0;
            TotalIncAmount = 0;
            TotalPendingSettleAmt = 0;
            sMinStartTime = string.Empty;
            sMaxEndTime = string.Empty;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                if (UserID == 0)
                {
                    cmd = Command.pGetAmountReceivedDetailsCommand(UserID, OrgId, pFDT, pTDT,locationId, out dTotalAmount, out dTotalRefund, out dTotalCancelledAmount, out sRcvdFromtime, out sRcvdTotime, out sRefundFromtime, out sRefundTotime, out sMinStartTime, out sMaxEndTime, out drAmount, out othersAmount, out TotalIncAmount, out TotalPendingSettleAmt, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                }
                else
                {
                    cmd = Command.pGetAmountReceivedDetailsForUsersCommand(UserID, OrgId, pFDT, pTDT,locationId, out dTotalAmount, out dTotalRefund, out dTotalCancelledAmount, out sRcvdFromtime, out sRcvdTotime, out sRefundFromtime, out sRefundTotime, out sMinStartTime, out sMaxEndTime, out drAmount, out othersAmount, out TotalIncAmount, out TotalPendingSettleAmt, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                }
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstBillingDetails);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstRefundDetails);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPaymentDetails);
                            }
                            else if (rsCount == 3)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstINDAmtReceivedDetails);
                            }
                            else if (rsCount == 4)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstINDIPAmtReceivedDetails);
                            }
                            else if (rsCount == 5)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstreceivedTypes);
                            }
                            else if (rsCount == 6)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstCurrencyInHand);
                            }
                            else if (rsCount == 7)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstIncSourcePaidDetails);
                            }
                            if (UserID > 0)
                            {
                                if (rsCount == 8)
                                {
                                    returnCode = Utilities.ConvertTo(dataReader, out lstSplitDetails);
                                }
                                else if (rsCount == 9)
                                {
                                    returnCode = Utilities.ConvertTo(dataReader, out lstCCDeno);
                                }
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                    decimal.TryParse(cmd.Parameters["@TotalAmount"].Value.ToString(), out dTotalAmount);
                    decimal.TryParse(cmd.Parameters["@Totalrefund"].Value.ToString(), out dTotalRefund);
                    decimal.TryParse(cmd.Parameters["@TotalCancelledAmt"].Value.ToString(), out dTotalCancelledAmount);
                    decimal.TryParse(cmd.Parameters["@DoctorsAmount"].Value.ToString(), out drAmount);
                    decimal.TryParse(cmd.Parameters["@OthersAmount"].Value.ToString(), out othersAmount);
                    decimal.TryParse(cmd.Parameters["@TotalIncAmount"].Value.ToString(), out TotalIncAmount);
                    decimal.TryParse(cmd.Parameters["@TotalPendingSettAmt"].Value.ToString(), out TotalPendingSettleAmt);
                    sRcvdFromtime = cmd.Parameters["@Rcvdfrom"].Value.ToString();
                    sRcvdTotime = cmd.Parameters["@RcvdTo"].Value.ToString();
                    sMinStartTime = cmd.Parameters["@MinStartTime"].Value.ToString();
                    sMaxEndTime = cmd.Parameters["@MaxEndTime"].Value.ToString();
                    sRefundFromtime = cmd.Parameters["@RefundFrom"].Value.ToString();
                    sRefundTotime = cmd.Parameters["@RefundTo"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetOrgInvestigationsGroupandPKG in Schedule_DAL.cs", ex);
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


        public long GetAmountRefundDetails(long UserID, int OrgId, out List<ReceivedAmount> lstReceivedAmount, out decimal dTotalrRefundAmount)
        {
            long returnCode = -1;
            lstReceivedAmount = new List<ReceivedAmount>();
            SqlCommand cmd = Command.pGetAmountRefundDetailsCommand(UserID, OrgId, out dTotalrRefundAmount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReceivedAmount);
                dTotalrRefundAmount = Convert.ToDecimal(cmd.Parameters["@TotalRefund"].Value);
            }
            return returnCode;
        }


        public long GetListOfUsersForCollection(long OrgId, out List<Users> lstUsersDetails)
        {
            long returnCode = -1;
            lstUsersDetails = new List<Users>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetListOfUsersForCollectionCommand(OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstUsersDetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while  in GetListOfUsersForCollection BillingDAL.cs", ex);
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


        public long InsertAmountClosureDetails(decimal totalAmount, decimal amountReceived, string status,
                                                int closedBy, int closedFor, int createdBy, int createdFor,
                                                DataTable dtBillingDetails,
                                                DataTable dtAmountRefundDetails,
                                                DataTable dtAmountPaidDetails, string AllUsersSelected,
                                                decimal amountRefund, string isrefund)
        {
            int returnCode = -1;
            int returnStatus = -1;

            SqlCommand cmd = Command.pInsertAmountclosureDetailsCommand(totalAmount, amountReceived, status,
                                    closedBy, closedFor, createdBy, AllUsersSelected,
                                    amountRefund, isrefund, dtBillingDetails, dtAmountRefundDetails,
                                                                                                            dtAmountPaidDetails, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                    returnCode = Convert.ToInt32(cmd.Parameters["@returnstatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving PatientInvestigation investigation_DAL", e);
            }
            return returnCode;
        }

        public long InsertAmountClosureDetailsForAllUsers(DataTable dtClosureDetails, string status, int createdBy,
                                                          DataTable dtBillingDetails,
                                                          DataTable dtAmountRefundDetails,
                                                          DataTable dtAmountPaidDetails, string isrefund)
        {
            int returnCode = -1;
            SqlCommand cmd = Command.pInsertAmountclosureDetailsForAllUsersCommand(dtClosureDetails, status, createdBy,
                                    isrefund, dtBillingDetails,
                                    dtAmountRefundDetails, dtAmountPaidDetails,
                                                                                                                        out returnCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                    returnCode = Convert.ToInt32(cmd.Parameters["@returnstatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving PatientInvestigation investigation_DAL", e);
            }
            return returnCode;
        }
        public long insertAmtRefundDetails(
                List<AmountRefundDetails> lstAmountRefundDetails, string RefFlag, out string RefundNo, int RefundStatus, long OrgId, out List<BillingDetails> lstBillingdetails, long collectionID)
        {
            RefundNo = "";
            long returnCode = -1;
            lstBillingdetails = new List<BillingDetails>();
            DataTable dtInsertRAmt = new DataTable();
            dtInsertRAmt = UDT_DAL.ConvertToUDTAmtRefundDetails(lstAmountRefundDetails);
            SqlCommand cmd = new SqlCommand();

            cmd = Command.pInsertAmtRefundDetailsCommand(dtInsertRAmt, RefFlag, RefundStatus, OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails), collectionID);
            try
            {

                DataSet ds = new DataSet();

                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);

                }

                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillingdetails);
                        if (lstBillingdetails.Count > 0)
                            RefundNo = lstBillingdetails[0].LabNo.ToString();
                    }
                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL insertAmtRefundDetails", ex);
            }
            return returnCode;
        }



        public long GetBillSearchActions(int roleID, out List<BillSearchActions> lstBillSearchActions)
        {
            long returnCode = -1;
            lstBillSearchActions = new List<BillSearchActions>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetBillSearchActionsCommand(roleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillSearchActions);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading visit search actions", ex);
            }
            return returnCode;

        }



        public long InsertAmountReceivedDetails(DataTable dtAmtReceived, long OrgID, decimal dAmtReceived, long lReceivedBy, long lCreatedBy, long lFinallBillID, decimal dserviceCharge)
        {
            long lResult = -1;
            SqlCommand cmd = Command.pInsertAmountReceivedDetailsCommand(OrgID, dtAmtReceived, dAmtReceived, lReceivedBy, lCreatedBy, lFinallBillID, dserviceCharge, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                lResult = dbEngine.ExecuteNonQuery(cmd);
            }
            return lResult;
        }

        public long InsertCashFlow(int iReceiverID, string sReceiverName, string sReceiverType, string sPaymentType,
                                    decimal dAmountReceived, decimal dDue, decimal dSurplus,
                                    DateTime dFromDate, DateTime dToDate, string sRemarks, string status,
                                    int Lid, int iOrgID, DataTable dtAmountReceived, decimal dServiceCharge,
                                    out string VouNo, out long OutFlowID,
            List<CashFlowTransactions> lstCashFlowTransactions,
            CashOutFlow objCashOutFlow, long pOrgAddressID)
        {
            long lResult = -1;
            DataSet ds = new DataSet();
            DataTable DtCashFlowTransactions = UDT_DAL.ConvertToCashFlowDetails(lstCashFlowTransactions);
            VouNo = "";
            OutFlowID = 0;
            SqlCommand cmd = Command.pInsertCashFlowCommand(iReceiverID, sReceiverName, sReceiverType,
                                    sPaymentType, dAmountReceived, dDue,
                                    dSurplus, dFromDate, dToDate, sRemarks,
                                    status, Lid, iOrgID, dtAmountReceived,
                                    dServiceCharge, DtCashFlowTransactions, objCashOutFlow.TotalAmount, objCashOutFlow.OrgPercent,
                                    objCashOutFlow.OrgAmount, objCashOutFlow.AmtBeforeTDS, objCashOutFlow.TDSPercent, objCashOutFlow.TDSAmount,
                                    objCashOutFlow.TermPayableAmount, objCashOutFlow.PreviousDue, objCashOutFlow.TotalPayable,
                                    objCashOutFlow.TotalPaid, objCashOutFlow.TermPayment, objCashOutFlow.DueSettled, objCashOutFlow.TermDue,
                                                                                                objCashOutFlow.TotalDue, pOrgAddressID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                lResult = dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                VouNo = ds.Tables[0].Rows[0]["VoucherNO"].ToString();
                Int64.TryParse(ds.Tables[0].Rows[0]["OutFlowID"].ToString(), out OutFlowID);
            }
            return lResult;
        }



        public long GetCashFlow(long OrgID, long lPhysicianID, DateTime dFromDate, DateTime dToDate,
                                out List<CashFlowSummary> lstCashFlowSummary,
                                out decimal pTotalDue, out decimal pTotalAdvance,
                                out decimal dIPPercent, out decimal dOPPercent,
                                out decimal dIPTax, out decimal dOPTax, out List<CashOutFlow> lstOutFlow,
                                out decimal dtotGivenAmt)
        {
            long returnCode = -1;
            lstCashFlowSummary = new List<CashFlowSummary>();
            lstOutFlow = new List<CashOutFlow>();
            pTotalDue = 0;
            pTotalAdvance = 0;
            dIPPercent = 0;
            dOPPercent = 0;
            dIPTax = 0;
            dOPTax = 0;
            dtotGivenAmt = 0;

            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetCashOutFlowCommand(lPhysicianID, dFromDate, dToDate, OrgID,
                                    out pTotalDue, out pTotalAdvance, out dIPPercent,
                                                                                                    out dOPPercent, out dIPTax, out dOPTax, out dtotGivenAmt, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCashFlowSummary);
                    }
                    pTotalDue = Convert.ToDecimal(cmd.Parameters["@pTotalDue"].Value.ToString());

                    Decimal.TryParse(cmd.Parameters["@pTotalAdvance"].Value.ToString(), out pTotalAdvance);
                    Decimal.TryParse(cmd.Parameters["@pIPPercent"].Value.ToString(), out dIPPercent);
                    Decimal.TryParse(cmd.Parameters["@pOPPercent"].Value.ToString(), out dOPPercent);
                    Decimal.TryParse(cmd.Parameters["@pIPTax"].Value.ToString(), out dIPTax);
                    Decimal.TryParse(cmd.Parameters["@pOPTax"].Value.ToString(), out dOPTax);
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstOutFlow);
                    }
                    Decimal.TryParse(cmd.Parameters["@ptotalGivenAmt"].Value.ToString(), out dtotGivenAmt);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetCashFlow", ex);
            }
            return returnCode;

        }

        public long InsertPatientDueCollections(long lPatientID, long lOrgID, long lOrgAddresID, int iVisitPurposeID, long lCreatedBy,
                                                string sFeeDescription, decimal dAmount, List<DuePaidDetail> lstDueDetail,
                                                DataTable dtAmountReceived, decimal dAmtReceived, out long lVisitID, out long lFinalID, decimal dserviceCharge)
        {
            long lResult = -1;
            DataTable dtDuePaidDetail = new DataTable();
            dtDuePaidDetail = UDT_DAL.ConvertToUpdateAndInsertDueTable(lstDueDetail);
            lVisitID = 0;
            lFinalID = 0;
            SqlCommand cmd = Command.pInsertPatientDueCollectionCommand(lPatientID, lOrgID, lOrgAddresID,
                                    iVisitPurposeID, lCreatedBy, sFeeDescription,
                                    dAmount, dtDuePaidDetail, dtAmountReceived, dAmtReceived,
                                                                                                            lCreatedBy, out lVisitID, out lFinalID, dserviceCharge, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                lResult = dbEngine.ExecuteNonQuery(cmd);
                Int64.TryParse(cmd.Parameters["@pOutVisitID"].Value.ToString(), out lVisitID);
                Int64.TryParse(cmd.Parameters["@pOutFinalBillID"].Value.ToString(), out lFinalID);

            }
            return lResult;
        }




        public long GetCorporateDiscount(int OrgID, out List<CorporateMaster> lstCorporateMaster)
        {
            long returnCode = -1;
            lstCorporateMaster = new List<CorporateMaster>();
            SqlCommand cmd = Command.pGetCorporateDiscountCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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
                CLogger.LogError("Error while executing GetCorporateDiscount in BillingDAL", ex);
            }
            return returnCode;
        }

        public long InsertFinalBillForDirect(FinalBill finalBill, AmountReceivedDetails amtRD, DataTable dtAmtReceived,
             List<PatientDueChart> lstDueChart, decimal dserviceCharge)
        {
            long lResult = -1;
            DataTable dtBillingDetails = new DataTable();
            dtBillingDetails = UDT_DAL.ConvertToUDTPatientDueChart(lstDueChart);

            SqlCommand cmd = Command.pInsertFinalBillForDirectCommand(finalBill.VisitID,
                                    finalBill.PatientID, finalBill.OrgID, finalBill.AmountReceived, finalBill.DiscountAmount,
                                    finalBill.Due, finalBill.CurrentDue, finalBill.GrossBillValue, finalBill.IsCreditBill,
                                    finalBill.NetValue, finalBill.StdDedID, finalBill.ModifiedBy, dtAmtReceived, dtBillingDetails,
                                                    amtRD.AmtReceived, amtRD.ReceivedBy, amtRD.CreatedBy, finalBill.OrgAddressID, dserviceCharge, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            cmd.Parameters.Add("@return", SqlDbType.BigInt);
            cmd.Parameters["@return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine(false))
            {
                lResult = dbEngine.ExecuteNonQuery(cmd);
                Int64.TryParse(cmd.Parameters["@return"].Value.ToString(), out lResult);
            }
            return lResult;
        }

        public long GetAmountReceivedDetailsForDaily(long UserID, int OrgId,
                                         DateTime pFDT, DateTime pTDT, int CurrencyID, int LocationId,
                                         out List<ReceivedAmount> lstBillingDetails,
                                         out List<ReceivedAmount> lstRefundDetails,
                                         out List<ReceivedAmount> lstPaymentDetails,
                                         out decimal dTotalAmount,
                                         out decimal dTotalRefund, out decimal dTotalCancelledAmt,
                                         out decimal drAmount,
                                         out decimal othersAmount,
                                         out decimal TotalPendingDue,
                                         out List<ReceivedAmount> lstINDAmtReceivedDetails,
                                         out List<ReceivedAmount> lstINDIPAmtReceivedDetails,
                                         out List<DayWiseCollectionReport> lstDayWise,
                                         out List<ReceivedAmount> lstRcvdUserSplitup,
                                         DataTable dtusersIDs,
                                         out List<AmountReceivedDetails> lstIncSourcePaidDetails, out decimal TotalIncAmount)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstRefundDetails = new List<ReceivedAmount>();
            lstBillingDetails = new List<ReceivedAmount>();
            lstPaymentDetails = new List<ReceivedAmount>();
            lstINDAmtReceivedDetails = new List<ReceivedAmount>();
            lstINDIPAmtReceivedDetails = new List<ReceivedAmount>();
            lstDayWise = new List<DayWiseCollectionReport>();
            lstRcvdUserSplitup = new List<ReceivedAmount>();
            lstIncSourcePaidDetails = new List<AmountReceivedDetails>();
            int rsCount = 0;
            dTotalAmount = 0;
            dTotalRefund = 0;
            drAmount = 0;
            othersAmount = 0;
            TotalPendingDue = 0;
            TotalIncAmount = 0;
            dTotalCancelledAmt = 0;
            try
            {
                SqlCommand cmd = Command.pGetAmountReceivedDetailsForDailyCommand(UserID, OrgId, CurrencyID, pFDT, pTDT, LocationId, out dTotalAmount, out dTotalRefund, out dTotalCancelledAmt, out drAmount, out othersAmount, out TotalPendingDue, dtusersIDs, out TotalIncAmount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstBillingDetails);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstRefundDetails);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPaymentDetails);
                            }
                            else if (rsCount == 3)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstINDAmtReceivedDetails);
                            }
                            else if (rsCount == 4)
                            {

                            }
                            else if (rsCount == 5)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstIncSourcePaidDetails);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
                Decimal.TryParse(cmd.Parameters["@TotalAmount"].Value.ToString(), out dTotalAmount);
                Decimal.TryParse(cmd.Parameters["@Totalrefund"].Value.ToString(), out dTotalRefund);
                Decimal.TryParse(cmd.Parameters["@TotalCancelledAmt"].Value.ToString(), out dTotalCancelledAmt);
                Decimal.TryParse(cmd.Parameters["@DoctorsAmount"].Value.ToString(), out drAmount);
                decimal.TryParse(cmd.Parameters["@OthersAmount"].Value.ToString(), out othersAmount);
                decimal.TryParse(cmd.Parameters["@TotalPendingDueAmt"].Value.ToString(), out TotalPendingDue);
                Decimal.TryParse(cmd.Parameters["@TotalIncAmount"].Value.ToString(), out TotalIncAmount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetAmountReceivedDetailsForDaily in BillingDAl", ex);
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


        public long GetListOfUsers(long OrgId, out List<Users> lstUsersDetails)
        {
            long returnCode = -1;
            lstUsersDetails = new List<Users>();

            SqlCommand cmd = Command.pGetListOfUsersCommand(OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstUsersDetails);
            }
            return returnCode;
        }

        public long GetPatientBabyVaccFeeDetails(long pVisitID, long pID, out List<BillingFeeDetails> lstPBV)
        {
            long returnCode = -1;
            lstPBV = new List<BillingFeeDetails>();

            try
            {
                SqlCommand cmd = Command.pGetPatientBabyVaccFeeDetailsCommand(pVisitID, pID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPBV);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetPatientBabyVaccFeeDetails", ex);
            }

            return returnCode;
        }

        public long SaveImmunizationBillingEntry(long orgID, out long BillID, long visitID, long createdBy,
            List<SaveBillingDetails> lst, int LocationID)
        {
            long lResult = -1;
            BillID = 0;
            try
            {

                DataTable dt = new DataTable();
                dt = UDT_DAL.ConvertToBillingDetailTablesWFT(lst);
                SqlCommand cmd = Command.pInsertImmunizationBillEnrtyCommand(visitID, out BillID, orgID, createdBy, dt, LocationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine(false))
                {

                    lResult = dbEngine.ExecuteNonQuery(cmd);
                    Int64.TryParse(cmd.Parameters["@pFinalBillID"].Value.ToString(), out BillID);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL SaveImmunizationBillingEntry", ex);
            }
            return lResult;
        }

        public long GetAmountReceivedReport(int OrgId,
                                           DateTime pFDT, DateTime pTDT,
                                           out List<ReceivedAmount> lstINDAmtReceivedDetails,
                                           out List<ReceivedAmount> lstINDIPAmtReceivedDetails)
        {
            long returnCode = -1;
            lstINDAmtReceivedDetails = new List<ReceivedAmount>();
            lstINDIPAmtReceivedDetails = new List<ReceivedAmount>();

            SqlCommand cmd = Command.pGetIndCollectionDetailsReportCommand(pFDT, pTDT, OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstINDAmtReceivedDetails);
            }
            if (ds.Tables[1].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstINDIPAmtReceivedDetails);
            }
            return returnCode;
        }

        public long GetAmountReceivedDaywiseReport(int OrgId,
                                          string pType,
                                          out List<ReceivedAmount> lstINDAmtReceivedDetails)
        {
            long returnCode = -1;
            lstINDAmtReceivedDetails = new List<ReceivedAmount>();

            SqlCommand cmd = Command.pGetIndCollectionComparisionReportCommand(OrgId, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstINDAmtReceivedDetails);
            }

            return returnCode;
        }
        public long GetInvFeeDetails(long patientVisitID, long orgID, long clientID, string UID, out List<BillingFeeDetails> lstInvestigationFeesDetails)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pGetInvFeeDetailsCommand(patientVisitID, orgID, clientID, UID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            lstInvestigationFeesDetails = new List<BillingFeeDetails>();
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvestigationFeesDetails);
            }

            return returnCode;

        }


        public long GetOrderedInvestigationFeesDetails(long patientVisitID, long orgID, long clientID, out List<BillingFeeDetails> lstInvestigationFeesDetails)
        {
            long returnCode = -1;
            lstInvestigationFeesDetails = new List<BillingFeeDetails>();
            try
            {
                SqlCommand cmd = Command.pGetOrderedInvestigationFeeDetailsCommand(patientVisitID, orgID, clientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvestigationFeesDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL GetOrderedInvestigationFeesDetails", ex);
            }
            return returnCode;

        }

        public long GetTaxDetails(int orgID, out List<Taxmaster> lstTaxMaster)
        {
            long returnCode = -1;
            lstTaxMaster = new List<Taxmaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetTaxMasterCommand(orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                     dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTaxMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL GetTaxDetails", ex);
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


        public long CheckBilltobeCancelled(long finalBillID, out int duePaidforPreBills, out int duePaidinNextBills, out decimal amoutReceived)
        {
            long returnCode = -1;
            duePaidforPreBills = -1;
            duePaidinNextBills = -1;
            amoutReceived = -1;
            try
            {
                SqlCommand cmd = Command.pCheckBilltobeCancelledCommand(finalBillID, out duePaidforPreBills, out duePaidinNextBills, out amoutReceived, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    duePaidforPreBills = Convert.ToInt32(cmd.Parameters["@pDuePaidforPreBills"].Value.ToString());
                    duePaidinNextBills = Convert.ToInt32(cmd.Parameters["@pDuePaidinNextBills"].Value.ToString());
                    amoutReceived = Convert.ToDecimal(cmd.Parameters["@pAmtReceived"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL CheckBilltobeCancelled", ex);
            }

            return returnCode;
        }
        public long UpdateBillCancelled(decimal cancelledAmt, long PatientVisitID, List<AmountRefundDetails> lstAmountRefundDetails, out int returnStatus, out long RefundNo)
        {
            long returnCode = -1;
            returnStatus = -1;
            RefundNo = -1;
            DataTable dtInsertRAmt = new DataTable();
            dtInsertRAmt = UDT_DAL.ConvertToUDTAmtRefundDetails(lstAmountRefundDetails);
            SqlCommand cmd = new SqlCommand();

            cmd = Command.pUpdateBillCancelledCommand(cancelledAmt, PatientVisitID, dtInsertRAmt, out returnStatus, out RefundNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnStatus = Convert.ToInt32(cmd.Parameters["@returnStatus"].Value.ToString());
                    RefundNo = Convert.ToInt32(cmd.Parameters["@RefundNo"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL UpdateBillCancelled", ex);
            }
            return returnCode;
        }
        public long InsertOPBillingDetails(
                                            int orgID,
                                            List<PatientDueChart> lstConsultationDetails,
                                            List<PatientDueChart> lstPTT,
                                            List<OrderedInvestigations> lstOrderedINV,
                                            out int retstatus,
                                            long pvisitID,
                                            long pPatientID,
                                            int pOrgAddressID,
                                            int pClientID,
                                            int pCorporateID,
                                            long pCreatedBy,
                                            out long outpVisit,
                                            string sCreateTask,
                                            int pReferphysicianID,
                                            int pReferspecialityID,
                                            out List<FinalBill> lstFinal, string guid)
        {
            long returnCode = -1;
            DataTable dtPatientDueChart = UDT_DAL.ConvertToUDTPatientDueChart(lstConsultationDetails);
            lstFinal = new List<FinalBill>();
            retstatus = 0;
            outpVisit = 0;

            try
            {
                SqlCommand cmd = Command.pInsertOPBillingDetailsCommand(dtPatientDueChart,
                                    orgID, pOrgAddressID, out retstatus,
                                    pvisitID, pPatientID,
                                    pOrgAddressID, pClientID, pCorporateID, pCreatedBy, out outpVisit,
                                                                                sCreateTask, pReferphysicianID, pReferspecialityID, guid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstFinal);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL GetOrderedInvestigationFeesDetails", ex);
            }
            return returnCode;

        }


        public long GetCasualtyFees(int pOrgID, out List<BillingFeeDetails> lstCASFees)
        {
            long returnCode = -1;
            lstCASFees = new List<BillingFeeDetails>();

            try
            {
                SqlCommand cmd = Command.pGetCasualtyFeesCommand(pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCASFees);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetCasualtyFees", ex);
            }

            return returnCode;
        }

        public long SaveCasualtyBillingEntry(long orgID, out long BillID, long visitID, long createdBy, List<SaveBillingDetails> lst, int LocationID)
        {
            long lResult = -1;
            BillID = 0;
            try
            {

                DataTable dt = new DataTable();
                lResult = Utilities.ConvertFrom(lst, out dt);
                SqlCommand cmd = Command.pInsertCasualtyBillEnrtyCommand(visitID, out BillID, orgID, createdBy, dt, LocationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine(false))
                {

                    lResult = dbEngine.ExecuteNonQuery(cmd);
                    Int64.TryParse(cmd.Parameters["@pFinalBillID"].Value.ToString(), out BillID);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL SaveCasualtyBillingEntry", ex);
            }
            return lResult;
        }
        public long GetPhysicianFeeDetailsReAssigned(long visitID, long physicianID, int orgID, long bdID, out List<BillingFeeDetails> lstPhisicanFeesDetails)
        {
            long lResult = -1;
            lstPhisicanFeesDetails = new List<BillingFeeDetails>();
            try
            {
                SqlCommand cmd = Command.pGetPhysicianFeeDetailsReAssignedCommand(physicianID, orgID, visitID, bdID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lResult = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables.Count > 0)
                    {
                        lResult = Utilities.ConvertTo(ds.Tables[0], out lstPhisicanFeesDetails);
                    }

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetPhysicianFeeDetailsReAssigned", ex);
            }
            return lResult;
        }
        public long UpdateBillReAssigned(long visitID, decimal amtRefunded, long billDetailsID, long pLID, long pAssignedTo, out long retCode)
        {
            long returnCode = -1;
            retCode = -1;
            try
            {
                SqlCommand cmd = Command.pUpdateBillReAssignedCommand(visitID, amtRefunded, billDetailsID, pLID, pAssignedTo, out retCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    Int64.TryParse(cmd.Parameters["@preturnCode"].Value.ToString(), out retCode);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL UpdateBillReAssigned", ex);
            }

            return returnCode;
        }



        public long GetReceiptDetails(long visitID, long patientID, int orgID, long bdID, string receiptno, string receiptModel, out List<BillingDetails> lstBillingDetails, out List<Patient> lstPatient)
        {
            long lResult = -1;
            lstBillingDetails = new List<BillingDetails>();
            lstPatient = new List<Patient>();
            try
            {
                SqlCommand cmd = Command.pGetReceiptDetailsCommand(visitID, orgID, patientID, bdID, receiptno, receiptModel, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lResult = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables.Count > 0)
                    {
                        lResult = Utilities.ConvertTo(ds.Tables[0], out lstBillingDetails);
                        lResult = Utilities.ConvertTo(ds.Tables[1], out lstPatient);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetReceiptDetails", ex);
            }
            return lResult;
        }

        public long GetRefundReceiptDetails(long visitID, int orgid, long patientID, long interpaymentID, string receiptType, out decimal amtReceived, out decimal amtRefunded, out decimal dChequeAmount, out List<BillingDetails> lstBillingDetails)
        {
            long returnCode = -1;
            lstBillingDetails = new List<BillingDetails>();

            SqlCommand cmd = Command.pGetRefundReceiptDetailsCommand(visitID, orgid, patientID, interpaymentID, receiptType, out amtReceived, out amtRefunded, out dChequeAmount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillingDetails);
                amtReceived = Convert.ToDecimal(cmd.Parameters["@pAmtReceived"].Value);
                amtRefunded = Convert.ToDecimal(cmd.Parameters["@pTotRfdAmt"].Value);
                dChequeAmount = Convert.ToDecimal(cmd.Parameters["@pChequeAmount"].Value);
            }
            return returnCode;
        }

        public long GetVoucherDetails(long OutFlowID, out List<CashOutFlowDetails> lstOutFlowDetails
              , out List<CashOutFlow> lstOutFlow, string VoucherNo, string VoucherType, out List<IncSourcePaidDetails> lstCashInFlowDetails)
        {
            long lResult = -1;
            lstOutFlowDetails = new List<CashOutFlowDetails>();
            lstOutFlow = new List<CashOutFlow>();
            lstCashInFlowDetails = new List<IncSourcePaidDetails>();
            try
            {
                SqlCommand cmd = Command.pGetVoucherDetailsCommand(OutFlowID, VoucherNo, VoucherType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lResult = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables.Count > 0)
                    {
                        lResult = Utilities.ConvertTo(ds.Tables[0], out lstOutFlow);
                        lResult = Utilities.ConvertTo(ds.Tables[1], out lstOutFlowDetails);
                        lResult = Utilities.ConvertTo(ds.Tables[2], out lstCashInFlowDetails);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL pGetVoucherDetails", ex);
            }
            return lResult;
        }

        public long SearchVoucherDetails(string VoucherNo, string sVouFromDate, string VouToDate, string sRecName, int OrgID, out List<CashOutFlow> lstCashOutFlow)
        {
            long returnCode = -1;
            lstCashOutFlow = new List<CashOutFlow>();
            IDataReader dataReader = null;
            try
            {
                System.Data.SqlClient.SqlCommand cmd;
                cmd = Command.pSearchVoucherDetailsCommand(VoucherNo, sVouFromDate, VouToDate, sRecName, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                lstCashOutFlow = new List<CashOutFlow>();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstCashOutFlow);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading SearchVoucherDetails in BillingDAL.cs", ex);
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

        public long GetRefundReceiptSearch(string PatientName, string refundNo, DateTime refundFromDate, DateTime refundToDate, int OrgID, int LocationID, string PatientNo, out List<FinalBill> lstFinalBillDetail)
        {
            long returnCode = -1;
            lstFinalBillDetail = new List<FinalBill>();
            SqlCommand cmd = Command.pGetRefundReceiptSearchCommand(PatientName, refundNo, refundFromDate, refundToDate, OrgID, LocationID, PatientNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstFinalBillDetail);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvRefundDetails in Inventory_DAL", ex);
            }
            return returnCode;
        }
        public long CheckIsCreditBill(long visitID, out decimal PaidAmount, out decimal GrossBillAmount, out decimal DueAmount,
            out string pIsCreditBill, out List<VisitClientMapping> lstVisitClientMapping)
        {
            long returnCode = -1;

            pIsCreditBill = "";
            PaidAmount = -1;
            DueAmount = -1;
            GrossBillAmount = -1;
            lstVisitClientMapping = new List<VisitClientMapping>();
            try
            {
                SqlCommand cmd = Command.pCheckIsCreditBillCommand(visitID, out PaidAmount, out GrossBillAmount, out DueAmount, out pIsCreditBill, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    pIsCreditBill = cmd.Parameters["@IsCreditBill"].Value.ToString();
                    PaidAmount = Convert.ToDecimal(cmd.Parameters["@PaidAmount"].Value.ToString());
                    DueAmount = Convert.ToDecimal(cmd.Parameters["@DueAmount"].Value.ToString());
                    GrossBillAmount = Convert.ToDecimal(cmd.Parameters["@GrossBillAmount"].Value.ToString());

                    if (ds.Tables != null && ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstVisitClientMapping);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL method - CheckIsCreditBill", ex);
            }

            return returnCode;
        }
        public long GetQuickBillItems(int orgID, string feeType, string searchDesc, int filter,
            out List<BillingFeeDetails> lstBillingFeeDetails, long RateID, string vType, long VisitID, string IsMappedItem, string billPage)
        {
            long returnCode = -1;
            lstBillingFeeDetails = new List<BillingFeeDetails>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd;
                if (billPage == "LAB")
                {
                    cmd = Command.pGetLabQuickBillItemsCommand(orgID, feeType, searchDesc, filter, RateID, vType, VisitID, IsMappedItem, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                }
                else if (billPage == "MGRATES")
                {
                    cmd = Command.pGetAllFeeItemsCommand(orgID, feeType, searchDesc, filter, RateID, vType, VisitID, IsMappedItem, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                }
                else
                {
                    cmd = Command.pGetQuickBillItemsCommand(orgID, feeType, searchDesc, filter, RateID, vType, VisitID, IsMappedItem, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                }
              
                using (DBEngine dbEngine = new DBEngine())
                {
                     dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstBillingFeeDetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL - GetQuickBillItems", ex);
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

        public long InsertDepositUsage(List<PatientDepositUsage> lstUsage)
        {
            long lResult = -1;
            long returnStatus = -1;


            SqlCommand cmdDeposit = Command.pInsertDepositUsageCommand(lstUsage[0].DepositID,
                                                                       lstUsage[0].PatientID, lstUsage[0].OrgID,
                                                                       lstUsage[0].FinalBillID, "",
                                                                       lstUsage[0].AmountUsed, lstUsage[0].CreatedBy,
                                                                       UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdDeposit.Parameters.Add("@ret", SqlDbType.Int);
            cmdDeposit.Parameters["@ret"].Direction = ParameterDirection.ReturnValue;
            using (DBEngine dbEngine = new DBEngine(false))
            {
                lResult = dbEngine.ExecuteNonQuery(cmdDeposit);
                returnStatus = Convert.ToInt32(cmdDeposit.Parameters["@ret"].Value);
            }
            return returnStatus;
        }

        public long InsertQuickBill(FinalBill finalBill,
           AmountReceivedDetails amtRD,
           DataTable dtAmtReceived,
           List<PatientDueChart> lstDueChart,
           List<TaxBillDetails> lstTaxDetails, Patient pdetails,
           decimal dserviceCharge, out int returnStatus,
           List<PatientReferringDetails> lstPatientRefDetails,
           List<PatientDepositUsage> lstUsage, out long FinalBillID, out string labno)
        {
            long lResult = -1;
            returnStatus = -1;
            FinalBillID = -1;
            DataTable dtTax = new DataTable();
            dtTax = UDT_DAL.ConvertToUDTaxBillDetails(lstTaxDetails);
            DataTable dtBillingDetails = new DataTable();
            DataTable dtPatientRefDetails = new DataTable();
            dtPatientRefDetails = UDT_DAL.ConvertToPatientReferring(lstPatientRefDetails);
            dtBillingDetails = UDT_DAL.ConvertToUDTPatientDueChart(lstDueChart);


            SqlCommand cmd = Command.pInsertQuickBillCommand(finalBill.VisitID,
                                    out FinalBillID, finalBill.OrgID, finalBill.AmountReceived, finalBill.DiscountAmount,
                                    finalBill.Due, finalBill.CurrentDue, finalBill.GrossBillValue, finalBill.IsCreditBill,
                                    finalBill.NetValue, finalBill.StdDedID, finalBill.ModifiedBy, dtAmtReceived, dtBillingDetails,
                                    amtRD.AmtReceived, amtRD.ReceivedBy, amtRD.CreatedBy, dtTax, finalBill.DiscountReason, dserviceCharge,
                                    out returnStatus, finalBill.RoundOff, finalBill.TaxAmount,
                                    dtPatientRefDetails,
                                    finalBill.ExcessAmtRecd,
                                     finalBill.IsDiscountPercentage, out labno,
                                     UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dbEngine = new DBEngine(false))
            {
                lResult = dbEngine.ExecuteNonQuery(cmd);
                returnStatus = Convert.ToInt32(cmd.Parameters["@pReturnStatus"].Value);
                labno = Convert.ToString(cmd.Parameters["@pLabno"].Value);
                FinalBillID = Convert.ToInt64(cmd.Parameters["@pFinalBillID"].Value);
            }

            return returnStatus;
        }


        public long GetFeeType(int orgID, string visitType, out List<FeeTypeMaster> lstFeeTypeMaster)
        {
            long returnCode = -1;
            lstFeeTypeMaster = new List<FeeTypeMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetFeeTypeCommand(orgID, visitType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstFeeTypeMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL - GetFeeType", ex);
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

        public long GetBillingDetails(long FinalBillID, int OrgID, out List<AmountReceivedDetails> lAmtDetails)
        {
            long returnCode = -1;
            lAmtDetails = new List<AmountReceivedDetails>();
            try
            {
                SqlCommand cmd = Command.pGetPayemtDeatailsCommand(FinalBillID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);


                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lAmtDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL UpdateBillReAssigned", ex);
            }

            return returnCode;
        }

        public long InsUpdateClientFeeTypeRateCustomize(List<ClientFeeTypeRateCustomization> pClientFeeTypeRate, long orgID)
        {
            long returnCode = -1;
            DataTable pPatientIndTable = UDT_DAL.ConvertToUDTPatientDueChart(pClientFeeTypeRate);

            try
            {
                SqlCommand cmd = Command.pInsUpdateClientFeeTypeRateCommand(pPatientIndTable, orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsUpdateClientFeeTypeRateCustomize in PatientVisit_DAL", ex);
            }
            return returnCode;
        }

        public long UpdateAmountReceivedDetails(long finalBillID, List<AmountReceivedDetails> lAmtDetails)
        {
            long returnCode = -1;
            try
            {
                DataTable dt = UDT_DAL.ConvertToUDTAmtRecDetailsUpdate(lAmtDetails);
                SqlCommand cmd = Command.pUpdateAmtReceivedDetailsCommand(dt, finalBillID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL UpdateBillReAssigned", ex);
            }

            return returnCode;
        }
        public long InsertWriteOffPatientDue(long lPatientID, long lOrgID, long lOrgAddresID, int iVisitPurposeID, long lCreatedBy,
                                                string sFeeDescription, decimal dAmount, List<DuePaidDetail> lstDueDetail,
                                                DataTable dtAmountReceived, decimal dAmtReceived, out long lVisitID, out long lFinalID, decimal dserviceCharge)
        {
            long lResult = -1;
            DataTable dtDuePaidDetail = new DataTable();
            dtDuePaidDetail = UDT_DAL.ConvertToUpdateAndInsertDueTable(lstDueDetail);
            lVisitID = 0;
            lFinalID = 0;
            SqlCommand cmd = Command.pInsertWriteOffPatientDueCommand(lPatientID, lOrgID, lOrgAddresID,
                                    iVisitPurposeID, lCreatedBy, sFeeDescription,
                                    dAmount, dtDuePaidDetail, dtAmountReceived, dAmtReceived,
                                                                                                            lCreatedBy, out lVisitID, out lFinalID, dserviceCharge, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                lResult = dbEngine.ExecuteNonQuery(cmd);
                Int64.TryParse(cmd.Parameters["@pOutVisitID"].Value.ToString(), out lVisitID);
                Int64.TryParse(cmd.Parameters["@pOutFinalBillID"].Value.ToString(), out lFinalID);

            }
            return lResult;
        }


        public long InsertBillItemDetails1(ref long patientID, ref long VisitID, long ReceivedBY, long CreatedBY,
                                            FinalBill FB, DataTable dtAmtReceived, List<PatientDueChart> lstDueChart,
                                            List<TaxBillDetails> lstTaxDetails, int ClientID,
                                            int RateID, long ReferedBY, int ReferedSpeciality, out long FinalBillID)
        {
            FinalBillID = -1;
            int returnStatus;
            List<DuePaidDetail> lstDueDteails = new List<DuePaidDetail>();
            string AddtoDues = "";
            returnStatus = -1;
            List<Tasks> lstTasks = new List<Tasks>();
            Patient pdetails = new Patient();
            int orgID = FB.OrgID;
            long OrgaddressID = FB.OrgAddressID;
            decimal AmountReceived = FB.AmountReceived;
            decimal Discout = FB.DiscountAmount;
            decimal Due = FB.Due;
            decimal currentDue = FB.CurrentDue;
            decimal Gross = FB.GrossBillValue;
            decimal NetValue = FB.NetValue;
            decimal TaxAmount = FB.TaxAmount;
            string iscreditbill = FB.IsCreditBill;
            string Discountreason = FB.DiscountReason;
            decimal dserviceCharge = FB.ServiceCharge;

            string Name = pdetails.Name;
            string TitleCode = pdetails.TITLECode.ToString();
            string Sex = pdetails.SEX;
            string Age = pdetails.Age;
            string PatientNumber = "";
            PatientNumber = pdetails.PatientNumber;
            string Address1 = "";
            Address1 = pdetails.Add1 == null ? "" : pdetails.Add1;

            string Addresss2 = "";
            Addresss2 = pdetails.Add2 == null ? "" : pdetails.Add2;

            string Address3 = "";
            Address3 = pdetails.Add3 == null ? "" : pdetails.Add3;

            string City = "";
            City = pdetails.City == null ? "" : pdetails.City;

            string PhoneNo = "";
            PhoneNo = pdetails.LandLineNumber == null ? "" : pdetails.LandLineNumber;

            string MobileNo = "";
            MobileNo = pdetails.MobileNumber == null ? "" : pdetails.MobileNumber;

            DataTable dtTax = new DataTable();
            DataTable dtBillingDetails = UDT_DAL.ConvertToUDTPatientDueChartForIP(lstDueChart);
            DataTable dtTasks = UDT_DAL.ConvertToUDTTasks(lstTasks);
            DataTable dtDueDetails = new DataTable();
            dtDueDetails = UDT_DAL.ConvertToUpdateAndInsertDueTable(lstDueDteails);
            dtTax = UDT_DAL.ConvertToUDTaxBillDetails(lstTaxDetails);

            DataSet ds = new DataSet();
            SqlCommand cmd = Command.pInsertBillItemDetailsCommand(patientID, VisitID, orgID, OrgaddressID, AmountReceived, Discout, Due, currentDue,
                                    Gross, NetValue, TaxAmount, iscreditbill, ReceivedBY, CreatedBY, Discountreason,
                                    dserviceCharge, dtAmtReceived, dtBillingDetails, dtTax, dtTasks, dtDueDetails, Name,
                                    TitleCode, Sex, Age, PatientNumber, Address1, Addresss2, Address3, City, PhoneNo,
                                                                                                        MobileNo, ClientID, RateID, AddtoDues, ReferedBY, ReferedSpeciality, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                Int32.TryParse(ds.Tables[0].Rows[0]["ReturnStatus"].ToString(), out returnStatus);
                Int64.TryParse(ds.Tables[0].Rows[0]["FinalBillID"].ToString(), out FinalBillID);
                Int64.TryParse(ds.Tables[0].Rows[0]["VisitID"].ToString(), out VisitID);
                Int64.TryParse(ds.Tables[0].Rows[0]["PatientID"].ToString(), out patientID);
                Int64.TryParse(ds.Tables[0].Rows[0]["PatientID"].ToString(), out patientID);
            }
            return 0;
        }

        public long InsertPatientAndVisit(ref long patientID, ref long VisitID, ref string pPatientNo, long pCreatedBy,
                                             List<PatientDueChart> lstDueChart, Patient pdetails,
                                            long ReferedBY, int ReferedSpeciality, int OrgID,
                                          int OrgAddressID, int AgeValue, string AgeUnit, long pSpecialityID, string ReferralType,
           string picExtension, List<VisitClientMapping> lstVisitClientMapping)
        {

            int returnStatus = -1;
            string Name = pdetails.Name;
            string TitleCode = pdetails.TITLECode.ToString();
            string Sex = pdetails.SEX;
            string Age = pdetails.Age;
            DateTime DOB = pdetails.DOB;
            string MartialStatus = pdetails.MartialStatus;
            string PatientNumber = string.Empty;
            PatientNumber = pdetails.PatientNumber;
            string Address1 = "";
            long Nationality = 0;
            long StateID = pdetails.PatientAddress[0].StateID == null ? 0 : pdetails.PatientAddress[0].StateID;
            long CountryID = pdetails.PatientAddress[0].CountryID == null ? 0 : pdetails.PatientAddress[0].CountryID;
            string SecureCode = pdetails.SecuredCode.ToString();


            string RelationName = string.Empty;
            long RelationTypeId = -1;
            string Race = string.Empty;
            string EMail = string.Empty;
            int PriorityID = 0;
            string WardNo = string.Empty;
            int NotifyType = 0;
            string URNO = string.Empty;
            long URNofId = -1;
            long URNTypeId = -1;
            string PatientHistory = string.Empty;

            RelationName = pdetails.RelationName;
            RelationTypeId = pdetails.RelationTypeId;
            Race = pdetails.Race;
            EMail = pdetails.EMail;
            PriorityID = Convert.ToInt32(pdetails.PriorityID);
            WardNo = pdetails.WardNo;
            NotifyType = pdetails.NotifyType;
            URNO = pdetails.URNO;
            URNofId = pdetails.URNofId;
            URNTypeId = pdetails.URNTypeId;
            PatientHistory = pdetails.PatientHistory;



            Nationality = pdetails.Nationality;

            Address1 = pdetails.PatientAddress[0].Add1 == null ? "" : pdetails.PatientAddress[0].Add1;

            string Addresss2 = "";
            Addresss2 = pdetails.PatientAddress[0].Add2 == null ? "" : pdetails.PatientAddress[0].Add2;

            string Address3 = "";
            Address3 = pdetails.PatientAddress[0].Add3 == null ? "" : pdetails.PatientAddress[0].Add3;

            string City = "";
            City = pdetails.PatientAddress[0].City == null ? "" : pdetails.PatientAddress[0].City;

            string PhoneNo = "";
            PhoneNo = pdetails.PatientAddress[0].LandLineNumber == null ? "" : pdetails.PatientAddress[0].LandLineNumber;

            string MobileNo = "";
            MobileNo = pdetails.PatientAddress[0].MobileNumber == null ? "" : pdetails.PatientAddress[0].MobileNumber;

            DataTable dtBillingDetails = UDT_DAL.ConvertToUDTPatientDueChartForIP(lstDueChart);
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pInsertPatientAndVisitCommand(patientID, VisitID, OrgID, OrgAddressID, pCreatedBy,
                                    dtBillingDetails, Name, TitleCode, Sex, Age, PatientNumber, Address1, Addresss2,
                                    Address3, City, PhoneNo, MobileNo, pdetails.ClientID, pdetails.RateID, ReferedBY, ReferedSpeciality,
                                    MartialStatus, DOB, AgeValue, AgeUnit, pdetails.CompressedName,Nationality, StateID, CountryID, pdetails.RegistrationFee,
                                    pdetails.SmartCardNumber, pdetails.VisitPurposeID, pdetails.ReferingPhysicianName, pdetails.SecuredCode,
                                    pdetails.PatientVisitID, pSpecialityID, ReferralType, RelationName, RelationTypeId, Race, EMail, PriorityID,
                                                        WardNo, NotifyType, picExtension, URNO, URNofId, URNTypeId, PatientHistory, pdetails.EmpDeptCode == null ? "" : pdetails.EmpDeptCode,
                                                        UDT_DAL.ConvertToUDT_Context(globalContextDetails), UDT_DAL.ConvertToVisitClientMapping(lstVisitClientMapping));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Int32.TryParse(ds.Tables[0].Rows[0]["ReturnStatus"].ToString(), out returnStatus);
                    Int64.TryParse(ds.Tables[0].Rows[0]["VisitID"].ToString(), out VisitID);
                    Int64.TryParse(ds.Tables[0].Rows[0]["PatientID"].ToString(), out patientID);
                    pPatientNo = ds.Tables[0].Rows[0]["pPatientNo"].ToString();
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL InsertQuickBill", ex);
            }
            return returnStatus;
        }




        public long GetPatientBillingDetails(long PatientID, long VisitID, string filterTxt, out List<PatientDueChart> lPatDueChart, out List<BillingDetails> lPatientBillingDetails)
        {
            long returnCode = -1;
            lPatDueChart = new List<PatientDueChart>();
            lPatientBillingDetails = new List<BillingDetails>();
            DataSet ds = new DataSet();
            SqlCommand cmd = Command.PgetPatientRefDetailsCommand(PatientID, VisitID, filterTxt, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine db = new DBEngine())
            {
                db.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0) { returnCode = Utilities.ConvertTo(ds.Tables[0], out lPatDueChart); };
                if (ds.Tables[1].Rows.Count > 0) { returnCode = Utilities.ConvertTo(ds.Tables[1], out lPatientBillingDetails); };
            }
            return returnCode;
        }
        public long UpdateBillingDetails(long billingDetailsID, long PatientDueChartID, long ReferingPhyID, string ReferingPhyName)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pUpdateBillingDetailsCommand(billingDetailsID, PatientDueChartID, ReferingPhyID, ReferingPhyName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine db = new DBEngine())
            {
                returnCode = db.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }


        public long GetNonReimbursableItems(int orgID, string feeType, string searchDesc, out List<BillingFeeDetails> lstBillingFeeDetails)
        {
            long returnCode = -1;
            lstBillingFeeDetails = new List<BillingFeeDetails>();
            try
            {
                SqlCommand cmd = Command.pGetNonReimbursableItemsCommand(orgID, feeType, searchDesc, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillingFeeDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL - GetNonReimbursableItems", ex);
            }

            return returnCode;
        }
        public long InsertPatientDueChart(List<PatientDueChart> lstPatientDueChart, List<OrderedInvestigations> pInvestigationHL, int OrgID, string SitingTypes,
             long visitID, long patientID, long CreatedBy, string GuID,
             out List<OrderedInvestigations> lstOrderedInv, List<PatientReferringDetails> lstPatientRefDetails,
  out string InterimBillNo, out string labno, string IsAddServices, long ClientID)
        {

            long returnCode = -1;
            long ret = -1;
            InterimBillNo = "-1";
            DataSet ds = new DataSet();
            lstOrderedInv = new List<OrderedInvestigations>();
            DataTable dtPatientRefDetails = new DataTable();
            DataTable invs = new DataTable();
            dtPatientRefDetails = UDT_DAL.ConvertToPatientReferring(lstPatientRefDetails);

            invs = UDT_DAL.ConvertToOrderedInvestigation(pInvestigationHL);
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
                            if (ds.Tables.Count > 0)
                            {
                                ret = Utilities.ConvertTo(ds.Tables[0], out lstOrderedInv);
                            }

                            if (returnCode == 0)
                            {
                                DataTable dtPatientItems = null;
                                dtPatientItems = UDT_DAL.ConvertToUDTPatientDueChart(lstPatientDueChart);
                                SqlCommand cmdInsertVisit = Command.pInsertPatientDueChartCommand(dtPatientItems, visitID,
                                                                        CreatedBy, patientID, dtPatientRefDetails,
                                                                        out InterimBillNo, SitingTypes, labno, IsAddServices,
                                                                        UDT_DAL.ConvertToUDT_Context(globalContextDetails), ClientID);
                                dbEngine.ExecuteTransactionalNonQuery(cmdInsertVisit);
                                cmdInsertVisit.Parameters.Add("@Return", SqlDbType.Int);
                                cmdInsertVisit.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
                                InterimBillNo = Convert.ToString(cmdInsertVisit.Parameters["@pInterimBillNumber"].Value);
                                returnCode = Convert.ToInt64(cmdInvestigation.Parameters["@Return"].Value);


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
                    CLogger.LogError("Exception while saving InsertPatientDueChart.", ex);
                    tranScope.Dispose();
                }

            }
            return returnCode;


        }

        public long InsertPatientMakePayment(FinalBill objfinalBill, DataTable dtAmountReceived, AmountReceivedDetails amtRD, List<PatientDueChart> lstPatientDueChart,
            List<OrderedInvestigations> pInvestigationHL, int OrgID, string SitingTypes, long visitID,
            long patientID, long CreatedBy, string GuID,
            out List<OrderedInvestigations> lstOrderedInv, out string ReceiptNo,
            out long IpIntermediateID, out string sPaymentType, List<PatientReferringDetails> lstPatientRefDetails,
            out string InterimBillNo, out string labno, long ClientID)
        {

            long returnCode = -1;
            long ret = -1;
            IpIntermediateID = 0;
            sPaymentType = "";
            ReceiptNo = "";
            InterimBillNo = "-1";
            DataSet ds = new DataSet();
            lstOrderedInv = new List<OrderedInvestigations>();
            DataTable invs = UDT_DAL.ConvertToOrderedInvestigation(pInvestigationHL);
            DataTable dtPatientRefDetails = new DataTable();

            dtPatientRefDetails = UDT_DAL.ConvertToPatientReferring(lstPatientRefDetails);
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
                            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                ret = Utilities.ConvertTo(ds.Tables[0], out lstOrderedInv);
                            }

                            if (returnCode == 0)
                            {
                                DataTable dtPatientItems = null;
                                dtPatientItems = UDT_DAL.ConvertToUDTPatientDueChart(lstPatientDueChart);
                                SqlCommand cmdInsertVisit = Command.pInsertPatientBillingItemsCommand(
                                    visitID, patientID, OrgID, CreatedBy, objfinalBill.AmountReceived,
                                    objfinalBill.DiscountAmount, objfinalBill.GrossBillValue, objfinalBill.NetValue,
                dtPatientItems, dtAmountReceived, objfinalBill.ServiceCharge, dtPatientRefDetails, out InterimBillNo, SitingTypes, labno,
                UDT_DAL.ConvertToUDT_Context(globalContextDetails), ClientID, objfinalBill.RoundOff);

                                cmdInsertVisit.Parameters.Add("@Return", SqlDbType.Int);
                                cmdInsertVisit.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
                                dbEngine.ExecuteDataSet(cmdInsertVisit, out ds);
                                returnCode = Convert.ToInt64(cmdInvestigation.Parameters["@Return"].Value);
                                if (ds.Tables.Count > 0)
                                {
                                    if (ds.Tables[0].Rows.Count > 0)
                                    {
                                        ReceiptNo = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                                        Int64.TryParse(ds.Tables[0].Rows[0].ItemArray[1].ToString(), out IpIntermediateID);
                                        sPaymentType = ds.Tables[0].Rows[0].ItemArray[2].ToString();

                                    }
                                }
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
                    CLogger.LogError("Exception while saving InsertPatientDueChart.", ex);
                    tranScope.Dispose();
                }

            }
            return returnCode;


        }




        public long GetPatientPaymentDetails(long patientVisitID, long patientID, int orgID, out List<FinalBill> lstPatientDueChart)
        {
            long returnCode = -1;
            lstPatientDueChart = new List<FinalBill>();
            try
            {
                SqlCommand cmd = Command.pGetPatientPaymentDetailsCommand(patientVisitID, patientID, orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientDueChart);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL - GetPatientPaymentDetails", ex);
            }

            return returnCode;
        }
        public long GetPharmacyConsolidate(long patientVisitID, out List<BillingDetails> lstBillingDetails)
        {
            long returnCode = -1;
            lstBillingDetails = new List<BillingDetails>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetPharmacyConsolidateCommand(patientVisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillingDetails);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Payment Type", ex);
            }
            return returnCode;

        }
        public long GetRefundDetailForTask(int OrgID, string ReceiptNo, long PatientVisitID, out List<BillingDetails> lstBillingDetails, out List<FinalBill> lstAmountRefund)
        {
            long returnCode = -1;
            lstAmountRefund = new List<FinalBill>();
            lstBillingDetails = new List<BillingDetails>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetRefundDetailForTaskCommand(OrgID, ReceiptNo, PatientVisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillingDetails);
                        }
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[1], out lstAmountRefund);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Billing DAL - GetRefundDetailForTask", ex);
            }


            return returnCode;
        }


        public long UpdateRefundDetails(int OrgID, string RefFlag, string ReceiptNo, long RefundBy, string RefundStatus, long TaskModifiedBy, string TaskRejectionDetail, System.Data.DataTable dtSaveApprovedAmt)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pUpdateRefundDetailsCommand(OrgID, RefFlag, ReceiptNo, RefundBy, RefundStatus, TaskModifiedBy, TaskRejectionDetail, dtSaveApprovedAmt, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    cmd.Parameters.Add("@Ret", SqlDbType.Int);
                    cmd.Parameters["@Ret"].Direction = ParameterDirection.ReturnValue;
                    returnCode = Convert.ToInt64(cmd.Parameters["@Ret"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL UpdateRefundDetails", ex);
            }

            return returnCode;
        }

        public long GetPaymentType(long OrgID, out List<PaymentType> lstPaymentType)
        {
            long returnCode = -1;
            lstPaymentType = new List<PaymentType>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetPaymentTypeCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPaymentType);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Payment Type", ex);
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

        public long InsertCashInFlow(string SourceTypeCode, string referenceID, DataTable dtAmtReceived, string Remarks
            , long CreatedBy, int OrgID, out string ReceiptNo)
        {
            long returnCode = -1;
            ReceiptNo = string.Empty;
            SqlCommand cmd = Command.pInsertSourcePaidDetailsCommand(SourceTypeCode, referenceID, dtAmtReceived, Remarks, CreatedBy, OrgID, out ReceiptNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine db = new DBEngine())
            {
                returnCode = db.ExecuteNonQuery(cmd);
            }
            ReceiptNo = cmd.Parameters["@pReceiptNo"].Value.ToString();
            return returnCode;
        }
        public long GetSourcePaidDetails(int OrgID, int cashMasterFlowID, out List<IncSourcePaidDetails> SrcPaidDetails)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetCashsourceDetailsCommand(OrgID, cashMasterFlowID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            SrcPaidDetails = new List<IncSourcePaidDetails>();
            using (DBEngine db = new DBEngine())
            {
                returnCode = db.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out SrcPaidDetails);
                }
            }
            return returnCode;
        }
        public long GetPaymentMode(long FinalBillID, long VisitID, string ReceiptNo, int payingPage, out List<PaymentType> lstPaymentMode, out List<PaymentType> lstOtherCurrency, out List<PaymentType> lstDepositAmt)
        {
            long returnCode = -1;
            lstPaymentMode = new List<PaymentType>();
            lstOtherCurrency = new List<PaymentType>();
            lstDepositAmt = new List<PaymentType>();
            SqlCommand cmd = Command.pGetPaymentModeCommand(FinalBillID, VisitID, ReceiptNo, payingPage, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine db = new DBEngine())
            {
                returnCode = db.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPaymentMode);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstOtherCurrency);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstDepositAmt);
                }
            }
            return returnCode;
        }
        public long GetIPBalanceForVisit(long PatientID, out List<FinalBill> lstDue)
        {
            long returnCode = -1;
            lstDue = new List<FinalBill>();
            SqlCommand cmd = Command.pGetIPBalanceForVisitCommand(PatientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine db = new DBEngine())
            {
                returnCode = db.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDue);
            }
            return returnCode;
        }
        public long UpdateSourcePaidDetails(long paidDetID, long SourceTypeID, string referenceID, decimal ReceivedAmt, int RecCurID,
           decimal RecCurValue, int paymentTypeID, string PaymentType, string ChequeNo, string BankName, string Description
           , int BaseCurrencyID, long modifiedBy, int OrgID)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pUpdateSourcePaidDetailsCommand(paidDetID, SourceTypeID, referenceID, ReceivedAmt, RecCurID, RecCurValue, paymentTypeID, PaymentType
                                                                            , ChequeNo, BankName, Description, BaseCurrencyID, modifiedBy, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine db = new DBEngine())
            {
                returnCode = db.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }

        public long GetQuickBillingDetails(int OrgID, string LoanguageCode, out List<Salutation> lstTitles, out List<VisitPurpose> lstVisitPurpose, out List<Country> lstNationality, out List<Country> lstCountries)
        {
            long returnCode = -1;
            int rsCount = 0;
            lstTitles = new List<Salutation>();
            lstVisitPurpose = new List<VisitPurpose>();
            lstNationality = new List<Country>();
            lstCountries = new List<Country>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetQuickBillingDetailsCommand(OrgID, LoanguageCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine db = new DBEngine())
                {
                    dataReader = db.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstTitles);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstVisitPurpose);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstNationality);
                            }
                            else if (rsCount == 3)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstCountries);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
                CLogger.LogError("Error while Executing GetQuickBillingDetails", ex);
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


        public long GetRateSubVisitTypeDetails(int OrgID, string pType, out List<RateSubTypeMapping> lstRateSubTypeMapping)
        {
            long returnCode = -1;
            lstRateSubTypeMapping = new List<RateSubTypeMapping>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetRateSubVisitTypeDetailsCommand(OrgID, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine db = new DBEngine())
                {
                    dataReader = db.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstRateSubTypeMapping);
                        dataReader.Close();
                    }
                }
              
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing GetRateSubVisitTypeDetails", ex);
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





        public long UpdateServiceCodeForBill(List<BillingDetails> lstBillingDetails)
        {
            long returnCode = -1;

            DataTable dtServiceCode = new DataTable();

            dtServiceCode = UDT_DAL.ConvertToUDTServiceCode(lstBillingDetails);

            SqlCommand cmd = Command.pUpdateServiceCodeForBillCommand(dtServiceCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
            }

            return returnCode;

        }



        public long GetInterimBillDetails(string PatientNumber, string PatientName, string InterimBillNo,
            string FromDate, string ToDate, int orgID, string FeeType, out List<PatientDueChart> lstPatientDueChart)
        {

            long returnCode = -1;

            SqlCommand cmd = Command.pGetInterimBillIPCommand(PatientNumber, PatientName, InterimBillNo, FromDate, ToDate, orgID, FeeType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            lstPatientDueChart = new List<PatientDueChart>();



            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientDueChart);
                }
            }

            return returnCode;
        }

        public long PatientDepositSearch(string pPatientNo, string pPatientName, DateTime FromDate, DateTime ToDate, int OrgID, out  List<Patient> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.PatientDepositSearchCommand(pPatientNo, pPatientName, FromDate, ToDate, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
                }
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error in Billing DAL PatientDepositSearch", ex);

            }
            return returnCode;
        }

        public long pInsertDepositRefund(long pDepositID, long pPatientID, string pPatientName, string pPaymentType,
                                    decimal pAmountRefund,
                                    DateTime pDateFrom, string pRemarks, string pStatus,
                                    int pCreatedBy, int pOrgID, DataTable dtAmountReceived, decimal pServiceCharge,
                                    out string VouNo, out long OutFlowID, long pOrgAddressID)
        {
            long lResult = -1;
            DataSet ds = new DataSet();
            VouNo = "";
            OutFlowID = 0;
            SqlCommand cmd = Command.pUpdateRefundDepositCommand(pDepositID, pPatientID, pPatientName, pPaymentType, pAmountRefund, pDateFrom, pRemarks, pStatus,
                                                                                                     pCreatedBy, pOrgID, dtAmountReceived, pServiceCharge, pOrgAddressID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                lResult = dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                VouNo = ds.Tables[0].Rows[0]["VoucherNO"].ToString();
                Int64.TryParse(ds.Tables[0].Rows[0]["OutFlowID"].ToString(), out OutFlowID);
            }
            return lResult;
        }

        public long GetGenerateBillReceipt(long VisitID, int OrgID, out List<BillSearch> lstDetails)
        {
            long returnCode = -1;
            lstDetails = new List<BillSearch>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetGenerateBillReceiptCommand(VisitID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);
                }
                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDetails);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing GetGenerateBillReceipt  in Billing DAL", ex);

            }
            return returnCode;
        }
        public long InsertINVRefundAmt(long PatientVisitID, decimal RefundAmt, int paymentType, long ChequeNumber, string BankName, string RefundReason, long CreatedBy, int OrgID, out string RefundNo, out long FinalBillID, out string PatientName)
        {
            long returnCode = -1;

            SqlCommand cmd = new SqlCommand();
            cmd = Command.pInsertINVRefundAmtCommand(PatientVisitID, RefundAmt, paymentType, ChequeNumber, BankName, RefundReason, CreatedBy, OrgID, out RefundNo, out FinalBillID, out PatientName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    RefundNo = Convert.ToString(cmd.Parameters["@pRefundNo"].Value);
                    FinalBillID = Convert.ToInt64(cmd.Parameters["@FinalBillID"].Value);
                    PatientName = Convert.ToString(cmd.Parameters["@pName"].Value);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL insertAmtRefundDetails", ex);
            }
            return returnCode;
        }
        public long GetRefundVoucherPrint(string FinalBillID, string RefundNo, int OrgID, out List<BillingDetails> lstBillingDetails, out List<AmountRefundDetails> lstAmountRefundDetails, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            lstBillingDetails = new List<BillingDetails>();
            lstAmountRefundDetails = new List<AmountRefundDetails>();
            lstPatient = new List<Patient>();

            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetRefundVoucherPrintCommand(FinalBillID, RefundNo, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);
                }
                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillingDetails);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstAmountRefundDetails);
                    }
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatient);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing GetGenerateBillReceipt  in Billing DAL", ex);

            }
            return returnCode;
        }

        public long GetPatientDueDetails(string PatientNo, string BillNo, string PatientName, int OrgId, long PtientID, DateTime FromDate, DateTime ToDate, string pLocation, string pVisitNumber, out List<PatientDueDetails> lstPatientDue)
        {
            long returnCode = -1;
            lstPatientDue = new List<PatientDueDetails>();
            SqlCommand cmd = new SqlCommand();
            IDataReader dataReader = null;
            try
            {
                cmd = Command.pGetPatientDueDetailsCommand(BillNo, PatientNo, PatientName, OrgId, PtientID, pLocation, pVisitNumber, FromDate, ToDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                    using (DBEngine dbEngine = new DBEngine())
                    {
                         dataReader = dbEngine.ExecuteReader(cmd);
                        if (dataReader != null)
                        {
                            returnCode = Utilities.ConvertTo(dataReader, out lstPatientDue);
                            dataReader.Close();
                        }
                    }
            }
            catch (Exception Ex)
            {
                CLogger.LogError("Error in DAL GetPatientDueDetails", Ex);
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

        public long GetInpatientDueDetails(long PatientID, long visitID, int OrgID, out List<PatientDueDetails> lstPatientDue)
        {
            long returnCode = -1;
            lstPatientDue = new List<PatientDueDetails>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetInpatientDueDetailsCommand(PatientID, visitID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientDue);
                }


            }
            catch (Exception Ex)
            {
                CLogger.LogError("Error in DAL GetPatientDueDetails", Ex);
            }
            return returnCode;
        }


        public long SavePatientDueDetails(long lPatientID, long lOrgID, long lOrgAddresID, int iVisitPurposeID, long lCreatedBy,
                                                string sFeeDescription, decimal dAmount, List<DuePaidDetail> lstDueDetail,
                                                DataTable dtAmountReceived, decimal dAmtReceived, long ReceivedBy,
             long lVisitID, long lFinalID, decimal dserviceCharge, List<PatientDueDetails> lstPatientDueDetails, out string BillNumber,
             out long PatientVID, string DiscountReason, long DiscountAuthorisedBy, out List<BillingDetails> lstBillingdetails, out String ReceiptNo)
        {
            BillNumber = string.Empty;
            ReceiptNo = string.Empty;
            PatientVID = 0;
            long lResult = -1;
            lstBillingdetails = new List<BillingDetails>();
            DataTable dtDuePaidDetail = new DataTable();
            dtDuePaidDetail = UDT_DAL.ConvertToUpdateAndInsertDueTable(lstDueDetail);
            DataTable dtpatientduedetails = new DataTable();
            dtpatientduedetails = UDT_DAL.ConvertToUDTPatientDueDetails(lstPatientDueDetails);
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pSavePatientDueDetailsCommand(lPatientID, lOrgID, lOrgAddresID,
                                    iVisitPurposeID, lCreatedBy, sFeeDescription,
                                    dAmount, dtDuePaidDetail, dtAmountReceived, dAmtReceived,
                                    lCreatedBy, lVisitID, lFinalID, dserviceCharge, dtpatientduedetails,
                                    UDT_DAL.ConvertToUDT_Context(globalContextDetails),
                                    DiscountReason, DiscountAuthorisedBy);

            DataSet ds = new DataSet();
            try
            {

                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);
                    // BillNumber = cmd.Parameters["@pBillNo"].Value.ToString();
                    //   Int64.TryParse(cmd.Parameters["@patientVisitID"].Value.ToString(), out PatientVID);
                    lResult = 0;
                }

                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillingdetails);
                        if (lstBillingdetails.Count > 0)
                        {
                            BillNumber = Convert.ToString(lstBillingdetails[0].FinalBillID);
                            PatientVID = lstBillingdetails[0].VisitID;
                            ReceiptNo = lstBillingdetails[0].LabNo.ToString();
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL insertAmtRefundDetails", ex);
            }
            return lResult;
        }

        public long PatientDueResult(long PatientDueID, string BillNo, out List<PatientDueDetails> lstPatientDue)
        {
            long returnCode = -1;
            lstPatientDue = new List<PatientDueDetails>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetDueResultCommand(PatientDueID, BillNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientDue);
                }


            }
            catch (Exception Ex)
            {
                CLogger.LogError("Error in DAL GetPatientDueResult", Ex);
            }
            return returnCode;
        }
        public long InsertOpDuedetails(List<PatientDueDetails> lstOPDueDetails)
        {
            long lResult = -1;
            DataTable Opdue = new DataTable();
            Opdue = UDT_DAL.ConvertToUDTPatientDueDetails(lstOPDueDetails);
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pInsertOpDuedetailsCommand(Opdue, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    lResult = dbEngine.ExecuteNonQuery(cmd);

                }
            }
            catch (Exception Ex)
            {
                CLogger.LogError("Error in DAL InsertOpDuedetails", Ex);
            }
            return lResult;
        }

        public long GetDuePaymentMode(long FinalBillID, long OrgId, out List<PaymentType> lstPaymentMode, out List<PaymentType> lstOtherCurrency)
        {
            long returnCode = -1;
            lstPaymentMode = new List<PaymentType>();
            lstOtherCurrency = new List<PaymentType>();
            SqlCommand cmd = Command.pGetDuePaymentNameCommand(FinalBillID, OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine db = new DBEngine())
            {
                returnCode = db.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPaymentMode);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstOtherCurrency);
                }

            }
            return returnCode;
        }
        public long GetCreditDueItem(long VisitID, long OrgID, long PatientID, string ReceiptNo, out List<DueClearanceReference> lstDueClearanceReference)
        {
            long returnCode = -1;
            lstDueClearanceReference = new List<DueClearanceReference>();
            try
            {
                SqlCommand cmd = Command.pGetCreditDueItemCommand(VisitID, OrgID, PatientID, ReceiptNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDueClearanceReference);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetCreditDueItem Billing.CS", ex);
            }
            return returnCode;
        }
        public long GetCoPaymentReceipt(long VisitID, int OrgID, out List<BillSearch> lstDetails)
        {
            long returnCode = -1;
            lstDetails = new List<BillSearch>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetCoPaymentReceiptCommand(VisitID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);
                }
                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDetails);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing GetCoPaymentReceipt in Billing DAL", ex);

            }
            return returnCode;
        }

        public long GetUserIDs(long OrgID, out List<Users> lstUserIDs)
        {
            long returnCode = -1;
            lstUserIDs = new List<Users>();

            SqlCommand cmd = Command.PgetUserIDsCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstUserIDs);
            }
            return returnCode;
        }

        public long GetCashClosureDenominationMaster(int OrgID, out List<CashClosureDenominationMaster> lstCCDeno)
        {
            long returnCode = -1;
            lstCCDeno = new List<CashClosureDenominationMaster>();

            SqlCommand cmd = Command.pGetCashClosureDenominationMasterCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCCDeno);
            }
            return returnCode;
        }

        public long InsertCashClosureDenomination(int OrgID, List<CashClosureDenomination> lstCCDeno, long CreatedBy, decimal TotalCCAmt, out string ClosureID)
        {
            long lResult = -1;
            SqlCommand cmd = new SqlCommand();
            DataTable dtCCDetail = new DataTable();
            dtCCDetail = UDT_DAL.ConvertToUDTCashClosureDenomination(lstCCDeno);
            cmd = Command.pInsertCashClosureDenominationCommand(OrgID, dtCCDetail, CreatedBy, TotalCCAmt, out ClosureID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    lResult = dbEngine.ExecuteNonQuery(cmd);
                    ClosureID = Convert.ToString(cmd.Parameters["@pClosureID"].Value);

                }
            }
            catch (Exception Ex)
            {
                CLogger.LogError("Error in DAL InsertCashClosureDenomination", Ex);
            }
            return lResult;
        }
        public long GetCCDenominationDetail(string ClosureID, int OrgID, long CreatedBy, out List<CashClosureDenomination> lstCCDeno)
        {
            long returnCode = -1;
            lstCCDeno = new List<CashClosureDenomination>();

            SqlCommand cmd = Command.pGetCCDenominationDetailCommand(ClosureID, OrgID, CreatedBy, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCCDeno);
            }
            return returnCode;
        }
        public long GetBillSnapShot(long PatientID, long VisitID, int OrgID, out List<FinalBill> lstBillDetails)
        {
            long returnCode = -1;
            lstBillDetails = new List<FinalBill>();

            SqlCommand cmd = Command.pGetBillSnapShotCommand(PatientID, VisitID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillDetails);
            }
            return returnCode;
        }
        public long GetIsAllMedicalFlagofVisit(long VisitID, out string IsAllMedical)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pGetIsAllMedicalFlagofVisitCommand(VisitID, out IsAllMedical, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    IsAllMedical = Convert.ToString(cmd.Parameters["@IsAllMedical"].Value);
                }
            }
            catch (Exception Ex)
            {
                CLogger.LogError("Error in DAL GetIsAllMedicalFlagofVisit", Ex);
            }
            return returnCode;
        }
        public long InsertCorporteBill(long PatientID, long VisitID, int RateID, decimal GrossValue, decimal NetValue,
           List<PatientDueChart> lstDueChart, long CreatedBy, int OrgID, long refPhyID, long refSpecialityID,
            long SpecialityID, string refPhyName, long OrgAddressID, List<PatientReferringDetails> lstPatientRefDetails, string IsCreditBill, out string labno, out int returnStatus, string IsFreeOfCost, int visitpurposeID)
        {
            long lResult = -1;
            returnStatus = -1;
            DataTable dtTax = new DataTable();
            DataTable dtBillingDetails = new DataTable();
            DataTable dtPatientRefDetails = new DataTable();

            dtPatientRefDetails = UDT_DAL.ConvertToPatientReferring(lstPatientRefDetails);
            dtBillingDetails = UDT_DAL.ConvertToUDTPatientDueChart(lstDueChart);

            SqlCommand cmd = Command.pInsertCorporteBillCommand(PatientID,
                                    VisitID, RateID, GrossValue, NetValue, dtBillingDetails, CreatedBy, OrgID, refPhyID,
                                                    refSpecialityID, SpecialityID, refPhyName, OrgAddressID, dtPatientRefDetails, IsCreditBill, out labno, out returnStatus, IsFreeOfCost, visitpurposeID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dbEngine = new DBEngine(false))
            {
                lResult = dbEngine.ExecuteNonQuery(cmd);
                returnStatus = Convert.ToInt32(cmd.Parameters["@pReturnStatus"].Value);
                labno = Convert.ToString(cmd.Parameters["@pLabno"].Value);
            }

            return returnStatus;
        }
        public long InsertIPReferringDetails(int OrgID, long patientVisitID, long IPrefPhyID, int IPrefSpecialityID, string IPrefPhyName, string IReferralType)
        {
            long returnCode = -1;
            SqlCommand cmdIPrefPhydetails = new SqlCommand();
            cmdIPrefPhydetails = Command.pInsertIPrefPhyDetailsCommand(OrgID, patientVisitID, IPrefPhyID, IPrefSpecialityID, IPrefPhyName, IReferralType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdIPrefPhydetails.Parameters.Add("@Return", SqlDbType.Int);
            cmdIPrefPhydetails.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmdIPrefPhydetails);
                    returnCode = Convert.ToInt64(cmdIPrefPhydetails.Parameters["@Return"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  InsertIPReferringDetails BillingEngine.CS", ex);
            }
            return returnCode;

        }
        public long PgetTaskDetailsforvisit(long patientVisitID, int OrgID, out List<TaskDetails> lsttaskdtails)
        {
            long lResult = -1;
            lsttaskdtails = new List<TaskDetails>();
            try
            {
                SqlCommand cmd = Command.PgetTaskDetailsPatientVisitCommand(patientVisitID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lResult = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables.Count > 0)
                    {
                        lResult = Utilities.ConvertTo(ds.Tables[0], out lsttaskdtails);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL PgetTaskDetailsforvisit", ex);
            }
            return lResult;
        }
        public long pInsertCorporteInvBilling(string Guid, long patientID, long patientVisitID, long createdBy, int OrgID, int AOrgID, out string Labno, out int returnStatus)
        {
            long lResult = -1;
            returnStatus = -1;
            Labno = "";
            try
            {
                SqlCommand cmd = Command.pInsertCorporteInvBillingCommand(Guid, patientID, patientVisitID, createdBy, OrgID, AOrgID, out Labno, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lResult = dbEngine.ExecuteNonQuery(cmd);
                    Labno = Convert.ToString(cmd.Parameters["@pLabno"].Value);
                    returnStatus = Convert.ToInt32(cmd.Parameters["@pReturnStatus"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL PgetTaskDetailsforvisit", ex);
            }
            return returnStatus;
        }
        public long UpdatedTaskIDinBillingDetails(long PatientID, long VisitID, List<PatientDueChart> lstBillingDetails, long CreatedBy, int OrgID)
        {
            long lResult = -1;
            DataTable dtBillingDetails = new DataTable();
            dtBillingDetails = UDT_DAL.ConvertToUDTPatientDueChart(lstBillingDetails);

            SqlCommand cmd = Command.pUpdatedTaskIDinBillingCommand(PatientID, VisitID, dtBillingDetails, CreatedBy, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dbEngine = new DBEngine(false))
            {
                lResult = dbEngine.ExecuteNonQuery(cmd);
            }

            return lResult;
        }
        public long GetRefunStatus(long visitID, long OrgID, string LabNo, out List<RefundReasonMaster> RfdReasion, out List<OrderedInvestigations> OrdInvStatus)
        {
            long returnCode = -1;
            RfdReasion = new List<RefundReasonMaster>();
            OrdInvStatus = new List<OrderedInvestigations>();

            SqlCommand cmd = Command.pGetRefundStatusCommand(visitID, OrgID, LabNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out RfdReasion);
                returnCode = Utilities.ConvertTo(ds.Tables[1], out OrdInvStatus);
            }
            return returnCode;
        }

        public long BillingAuthorisedBy(string Name, int OrgID, string Types, out List<BillingAuthorisedBy> AuthorisedBy)
        {
            long returnCode = -1;
            AuthorisedBy = new List<BillingAuthorisedBy>();

            SqlCommand cmd = Command.pgetBillingAuthorisedByCommand(Name, OrgID, Types, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out AuthorisedBy);

            }
            return returnCode;
        }
        public long GetTransactionByType(DateTime FDate, DateTime TDate, int OrgID, DataTable LoginIDs, string Type, out List<ReceivedAmount> lstBillingDetails)
        {
            long returnCode = -1;
            lstBillingDetails = new List<ReceivedAmount>();
            SqlCommand cmd = Command.pGetTransactionByTypeCommand(FDate, TDate, OrgID, LoginIDs, Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillingDetails);
            }

            return returnCode;

        }

        public long GetAmountReceivedDetailsForDaily(long UserID, int OrgId, DateTime pFDT, DateTime pTDT, int CurrencyID, int LocationId, out List<ReceivedAmount> lstBillingDetails, out List<ReceivedAmount> lstRefundDetails, out List<ReceivedAmount> lstPaymentDetails, out decimal dTotalAmount, out decimal dTotalRefund, out decimal dTotalCancelledAmt, out decimal drAmount, out decimal othersAmount, out decimal TotalPendingDue, out List<ReceivedAmount> lstINDAmtReceivedDetails, out List<ReceivedAmount> lstINDIPAmtReceivedDetails, out List<DayWiseCollectionReport> lstDayWise, out List<ReceivedAmount> lstRcvdUserSplitup, DataTable dtusersIDs, out List<ReceivedAmount> lstCollections, out List<AmountReceivedDetails> lstIncSourcePaidDetails, out decimal TotalIncAmount)
        {
            long returnCode = -1;
            lstRefundDetails = new List<ReceivedAmount>();
            lstBillingDetails = new List<ReceivedAmount>();
            lstPaymentDetails = new List<ReceivedAmount>();
            lstINDAmtReceivedDetails = new List<ReceivedAmount>();
            lstINDIPAmtReceivedDetails = new List<ReceivedAmount>();
            lstDayWise = new List<DayWiseCollectionReport>();
            lstRcvdUserSplitup = new List<ReceivedAmount>();
            lstCollections = new List<ReceivedAmount>();
            lstIncSourcePaidDetails = new List<AmountReceivedDetails>();
            dTotalAmount = 0;
            dTotalRefund = 0;
            drAmount = 0;
            othersAmount = 0;
            TotalPendingDue = 0;
            TotalIncAmount = 0;
            dTotalCancelledAmt = 0;
            int rsCount = 0;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetAmountReceivedDetailsForDailyCommand(UserID, OrgId, CurrencyID, pFDT, pTDT, LocationId, out dTotalAmount, out dTotalRefund, out dTotalCancelledAmt, out drAmount, out othersAmount, out TotalPendingDue, dtusersIDs, out TotalIncAmount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstBillingDetails);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstRefundDetails);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPaymentDetails);
                            }
                            else if (rsCount == 3)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstINDAmtReceivedDetails);
                            }
                            else if (rsCount == 5)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstIncSourcePaidDetails);


                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
                Decimal.TryParse(cmd.Parameters["@TotalAmount"].Value.ToString(), out dTotalAmount);
                Decimal.TryParse(cmd.Parameters["@Totalrefund"].Value.ToString(), out dTotalRefund);
                Decimal.TryParse(cmd.Parameters["@TotalCancelledAmt"].Value.ToString(), out dTotalCancelledAmt);
                Decimal.TryParse(cmd.Parameters["@DoctorsAmount"].Value.ToString(), out drAmount);
                decimal.TryParse(cmd.Parameters["@OthersAmount"].Value.ToString(), out othersAmount);
                decimal.TryParse(cmd.Parameters["@TotalPendingDueAmt"].Value.ToString(), out TotalPendingDue);
                Decimal.TryParse(cmd.Parameters["@TotalIncAmount"].Value.ToString(), out TotalIncAmount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetAmountReceivedDetailsForDaily in BillingDAL", ex);
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

        public long GetInvoiceGeneration(long InvoiceID, long ClientID, int OrgID, int OrgAdd, DateTime FDate, DateTime TDate, int RejBills, out List<BillingDetails> lstInvoiceBill, out List<DiscountPolicy> lstVolumeDiscount, out List<CreditDebitSummary> lstCreditDebit)
        {
            long returnCode = -1;
            lstInvoiceBill = new List<BillingDetails>();
            lstVolumeDiscount = new List<DiscountPolicy>();
            lstCreditDebit = new List<CreditDebitSummary>();
            SqlCommand cmd = Command.pGetInvoiceGenerationCommand(InvoiceID, ClientID, OrgID, OrgAdd, FDate, TDate, RejBills, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvoiceBill);
            }
            if (ds.Tables[1].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstVolumeDiscount);
            }
            if (ds.Tables[2].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[2], out lstCreditDebit);
            }
            return returnCode;

        }

        //public long SaveInvoiceBill(decimal GrsAmt, string Discount, string DisReason, decimal Netamt, long CreateBy, string Tax, long ClientID, int OrgID, int OrgAdd, long FinalBillID, List<Invoice> lstInvoice, DateTime FromDate, DateTime ToDate, decimal TOD, long ScID, string Status, long ApporverID, long InvcID, string TaskStatus, decimal VolumeDiscountAmt, out long InvoiceID)
        //{
        //    long returnCode = -1;
        //    DataTable dtInvoice = new DataTable();
        //    dtInvoice = UDT_DAL.ConvertToUDTInvoice(lstInvoice);
        //    SqlCommand cmd = new SqlCommand();
        //    cmd = Command.pSaveInvoiceBillCommand(GrsAmt, Discount, DisReason, Netamt, CreateBy, Tax, ClientID, OrgID, OrgAdd, FinalBillID, dtInvoice, FromDate, ToDate, TOD, ScID, Status, ApporverID, InvcID, TaskStatus, VolumeDiscountAmt, out InvoiceID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
        //    try
        //    {
        //        using (DBEngine dbEngine = new DBEngine(true))
        //        {
        //            returnCode = dbEngine.ExecuteNonQuery(cmd);
        //            InvoiceID = Convert.ToInt64(cmd.Parameters["@pInvoiceID"].Value);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error in DAL SaveInvoiceBill", ex);
        //    }
        //    return returnCode;
        //}
        public long SaveInvoiceBill(decimal GrsAmt, string Discount, string DisReason, decimal Netamt, long CreateBy, string Tax, long ClientID, int OrgID, int OrgAdd, long FinalBillID, List<Invoice> lstInvoice, DateTime FromDate, DateTime ToDate, decimal TOD, long ScID, string Status, long ApporverID, long InvcID, string TaskStatus, decimal VolumeDiscountAmt, out long InvoiceID, string Type)
        {
            long returnCode = -1;
            DataTable dtInvoice = new DataTable();
            dtInvoice = UDT_DAL.ConvertToUDTInvoice(lstInvoice);
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pSaveInvoiceBillCommand(GrsAmt, Discount, DisReason, Netamt, CreateBy, Tax, ClientID, OrgID, OrgAdd, FinalBillID, dtInvoice, FromDate, ToDate, TOD, ScID, Status, ApporverID, InvcID, TaskStatus, VolumeDiscountAmt, out InvoiceID, Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    InvoiceID = Convert.ToInt64(cmd.Parameters["@pInvoiceID"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL SaveInvoiceBill", ex);
            }
            return returnCode;
        }

        public long SaveInvoiceBillByService(long CreateBy, long ClientID, int OrgID, int OrgAdd, DateTime FromDate, DateTime ToDate, string AddContext, out long InvoiceID, out string InvoiceNumber)
        {
            long returnCode = -1;
            InvoiceID = -1;
            InvoiceNumber = "0";
            DataSet dtset=new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pSaveInvoiceBillByServiceCommand(CreateBy, ClientID, OrgID, OrgAdd, FromDate, ToDate, AddContext, out InvoiceID, out InvoiceNumber, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    InvoiceID = Convert.ToInt64(cmd.Parameters["@pInvoiceID"].Value);
                    InvoiceNumber = Convert.ToString(cmd.Parameters["@pInvoiceNumber"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL SaveInvoiceBill", ex);
            }
            return returnCode;
        }

        public long GetInvoicePrinting(long InvoiceID, long OrgID, long OrgAdd, out List<Invoice> lstInvoice, out List<BillingDetails> lstInvoiceBill)
        {
            long returnCode = -1;
            lstInvoice = new List<Invoice>();
            lstInvoiceBill = new List<BillingDetails>();
            SqlCommand cmd = Command.pGetInvoicePrintingCommand(InvoiceID, OrgID, OrgAdd, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvoice);
            }
            if (ds.Tables[1].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstInvoiceBill);
            }

            return returnCode;

        }


        public long LoadDesignations(int OrgID, out List<DesignationMaster> lstDesignations)
        {
            long returnCode = -1;
            lstDesignations = new List<DesignationMaster>();
            SqlCommand cmd = Command.pLoadDesignationsCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDesignations);
            }


            return returnCode;


        }
        public long GetRateCardForBilling(string SearchText, long OrgID, string Type, long refhospid, out List<InvClientMaster> lstClients)
        {
            long returnCode = -1;
            lstClients = new List<InvClientMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetRateCardForBillingCommand(SearchText, OrgID, Type, refhospid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                     dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstClients);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BillingDAL GetRateCardForBilling", ex);
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

        public long pGetCorporateRefundBillingDetails(long visitID, out List<BillingDetails> lstBillingDetails, out decimal amtReceived, out decimal amtRefunded, out decimal dChequeAmount, long FinalBillID, long billDetailsID)
        {
            long returnCode = -1;
            lstBillingDetails = new List<BillingDetails>();

            SqlCommand cmd = Command.pGetCorporateRefundBillingCommand(visitID, FinalBillID, billDetailsID, out amtReceived, out amtRefunded, out dChequeAmount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillingDetails);
                amtReceived = Convert.ToDecimal(cmd.Parameters["@pAmtReceived"].Value);
                amtRefunded = Convert.ToDecimal(cmd.Parameters["@pTotRfdAmt"].Value);
                dChequeAmount = Convert.ToDecimal(cmd.Parameters["@pChequeAmount"].Value);
            }
            return returnCode;
        }

        public long inserCorporatetAmtRefundDetails(long PatientVisitID, FinalBill finalBill, List<AmountRefundDetails> lstAmountRefundDetails, out int returnstatus, out string ReceiptNo, out string RefundNo, int RefundStatus)
        {
            long returnCode = -1;
            returnstatus = -1;
            DataTable dtInsertRAmt = new DataTable();
            dtInsertRAmt = UDT_DAL.ConvertToUDTAmtRefundDetails(lstAmountRefundDetails);
            SqlCommand cmd = new SqlCommand();

            cmd = Command.pInsertCorporateAmtRefundDetailsCommand(finalBill.AmountRefund, PatientVisitID, dtInsertRAmt, out returnstatus, out ReceiptNo, out RefundNo, RefundStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnstatus = Convert.ToInt32(cmd.Parameters["@returnstatus"].Value);
                    ReceiptNo = Convert.ToString(cmd.Parameters["@ReceiptNo"].Value);
                    RefundNo = Convert.ToString(cmd.Parameters["@RefundNo"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL insertAmtRefundDetails", ex);
            }
            return returnCode;
        }

        public long GetLabQuickBillPatientList(string pName, string pVisitType, int pOrgID, int searchType, long PatientID, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetLabQuickPatientsCommand(pName, pVisitType, pOrgID, searchType, PatientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPatientDetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientListForQuickBill in Inventory_DAL", ex);
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


        public long GetLabQuickBillPatientList_Quantum(string pName, string pVisitType, int pOrgID, int searchType, long PatientID, string ExtVisitID, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            SqlCommand cmd = Command.pGetLabQuickPatients_QuantumCommand(pName, pVisitType, pOrgID, searchType, PatientID, ExtVisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientListForQuickBill in Inventory_DAL", ex);
            }
            return returnCode;
        }
        public long RegistrationRepush(int OrgId, out List<RegistrationRepush> lsRepush)
        {
            long returnCode = -1;
            lsRepush = new List<RegistrationRepush>();
            SqlCommand cmd = Command.pRegistrationRepushCommand(OrgId);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lsRepush);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing RegistrationRepush in Billing_DAL", ex);
            }
            return returnCode;
        }


        //public long SearchInvoice(string InvoiceNo, int OrgID, int OrgAdd, DateTime FDate, DateTime TDate, out List<Invoice> lstInvoice, int pageSize, int StartRowIndex, out int totalRows, int businessTypeID, int ClientID)
        //{
        //    long returnCode = -1;
        //    lstInvoice = new List<Invoice>();
        //    SqlCommand cmd = Command.pSearchInvoicesCommand(InvoiceNo, OrgID, OrgAdd, FDate, TDate, pageSize, StartRowIndex, out totalRows, businessTypeID, ClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
        //    DataSet ds = new DataSet();
        //    using (DBEngine dbEngine = new DBEngine())
        //    {
        //        dbEngine.ExecuteDataSet(cmd, out ds);
        //    }
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvoice);
        //        totalRows = Convert.ToInt32(ds.Tables[1].Rows[0]["totalRows"]);
        //    }

        //    return returnCode;

        //}
        public long SearchInvoice(string InvoiceNo, int OrgID, int OrgAdd, DateTime FDate, DateTime TDate, out List<Invoice> lstInvoice, int pageSize, int StartRowIndex, out int totalRows, int businessTypeID, int ClientID, string InvoiceType)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            totalRows = 0;
            lstInvoice = new List<Invoice>();
            try
            {
                SqlCommand cmd = Command.pSearchInvoicesCommand(InvoiceNo, OrgID, OrgAdd, FDate, TDate, pageSize, StartRowIndex, out totalRows, businessTypeID, ClientID, InvoiceType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvoice);
                        dataReader.Close();
                    }
                }
                Int32.TryParse(cmd.Parameters["@totalRows"].Value.ToString(), out totalRows);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading SearchInvoice in Billing DAL", ex);
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


        public long getClientInvoiceDetails(long ClientID, long InvoiceNo, int OrgID, out List<Invoice> lstInvoice)
        {
            long returnCode = -1;
            lstInvoice = new List<Invoice>();
            SqlCommand cmd = Command.pgetClientInvoiceDetailsCommand(ClientID, InvoiceNo, OrgID);
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvoice);
            }

            return returnCode;

        }


        public long GetInvoicePayments(List<Invoice> lstInvoiceId, int orgID,string Type, out List<Invoice> lstIVPayments, out List<InvoiceReceipts> lstInvoicepayments)
        {
            long returnCode = -1;
            lstIVPayments = new List<Invoice>();
            lstInvoicepayments = new List<InvoiceReceipts>();
            DataTable dtInvoice = UDT_DAL.ConvertToUDTInvoice(lstInvoiceId);

            SqlCommand cmd = Command.pGetInvoicePaymentsCommand(dtInvoice, orgID,Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine db = new DBEngine())
            {
                db.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstIVPayments);

            }
            if (ds.Tables[1].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstInvoicepayments);

            }
            return returnCode;
        }
        public long GetPreviousVisitBilling(long PatientID, long VisitID, string Type, out List<BillingDetails> lstBillings, out List<PatientInvSample> lstPatientInvSample)
        {
            long returnCode = -1;
            lstBillings = new List<BillingDetails>();
            lstPatientInvSample = new List<PatientInvSample>();


            SqlCommand cmd = Command.pGetPreviousVisitBillingCommand(PatientID, VisitID, Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine db = new DBEngine())
            {
                db.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillings);

            }
            if (ds.Tables[1].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatientInvSample);
            }
            return returnCode;
        }

        public long InsertInvoiceReceipts(List<InvoiceReceipts> lstInVoiceRecpts, out string ReceiptNo, out long ReceiptID)
        {
            long returnCode = -1;
            ReceiptNo = string.Empty;
            ReceiptID = -1;
            DataTable dtInvoiceRecpts = UDT_DAL.ConvertToUDTInvoiceReceipts(lstInVoiceRecpts);
            SqlCommand cmd = Command.pInsertInvoiceReceiptsCommand(dtInvoiceRecpts, out ReceiptNo, out ReceiptID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine db = new DBEngine())
            {
                returnCode = db.ExecuteNonQuery(cmd);
                ReceiptNo = Convert.ToString(cmd.Parameters["@ReceiptNo"].Value);
                ReceiptID = Convert.ToInt64(cmd.Parameters["@ReceiptID"].Value);
            }

            return returnCode;
        }

        public long GetInVoiceReceiptDetailss(int OrgID, int OrgAddID, long ClientID, string ReceiptNumber, long ReceiptID, long InvoiceID, out List<InvoiceReceipts> lstInvoiceRecpts, out List<AmountReceivedDetails> lstAmountReceivedDetails)
        {
            long returnCode = -1;
            lstInvoiceRecpts = new List<InvoiceReceipts>();
            lstAmountReceivedDetails = new List<AmountReceivedDetails>();
            try
            {
                SqlCommand cmd = Command.pGetInVoiceReceiptDetailsCommand(OrgID, OrgAddID, ClientID, ReceiptNumber, ReceiptID, InvoiceID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvoiceRecpts);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstAmountReceivedDetails);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - GetInVoiceReceiptDetailss", ex);
            }

            return returnCode;
        }

        public long GetInvoiceReportPath(int OrgID, string Type, long ClientID, long ReportTemplateID, out List<BillingDetails> lstReportPath)
        {
            long returnCode = -1;
            lstReportPath = new List<BillingDetails>();
            IDataReader dataReader = null;
            try
            {
            	SqlCommand cmd = Command.pGetInvoiceReportPathCommand(OrgID, Type, ClientID, ReportTemplateID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            	using (DBEngine db = new DBEngine())
            	{
                    dataReader = db.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstReportPath);
                        dataReader.Close();
                    }
                }
            }
             catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetInvoiceReportPath", ex);
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
        public long GetPatientEpisodeVisitDetails(int OrgID, long PatientID, long EpisodeID, string Type, out List<EpisodeVisitDetails> lstEpisodeVisitDetails)
        {
            long returnCode = -1;
            lstEpisodeVisitDetails = new List<EpisodeVisitDetails>();
            SqlCommand cmd = Command.pGetPatientEpisodeVisitDetailsCommand(OrgID, PatientID, EpisodeID, Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine db = new DBEngine())
            {
                db.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstEpisodeVisitDetails);

            }
            return returnCode;
        }
        public long GetClientEpisode(int OrgID, long ClientID, string Type, out List<EpisodeVisitDetails> lstEpisodeVisitDetails)
        {
            long returnCode = -1;
            lstEpisodeVisitDetails = new List<EpisodeVisitDetails>();
            SqlCommand cmd = Command.pGetClientEpisodeCommand(OrgID, ClientID, Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine db = new DBEngine())
            {
                db.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstEpisodeVisitDetails);

            }
            return returnCode;
        }
        public long GetClientChildDetails(int OrgID, long ClientID, string Clientname, string Type, out List<EpisodeVisitDetails> lstClientMaster)
        {
            long returnCode = -1;
            lstClientMaster = new List<EpisodeVisitDetails>();
            SqlCommand cmd = Command.pGetClientChildDetailsCommand(OrgID, ClientID, Clientname, Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine db = new DBEngine())
            {
                db.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstClientMaster);

            }
            return returnCode;
        }
        public long GetConsignmentNo(long EpisodeID, long SiteID, int OrgID, string pType, string ConsignmentNo, out List<EpiContainerTracking> lstEpiContainerTracking)
        {
            long returnCode = -1;
            lstEpiContainerTracking = new List<EpiContainerTracking>();
            SqlCommand cmd = Command.pGetConsignmentNoCommand(EpisodeID, SiteID, OrgID, pType, ConsignmentNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine db = new DBEngine())
            {
                db.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstEpiContainerTracking);

            }
            return returnCode;
        }
        public long GetInvestigationInfo(long ID, string Type, int orgid, out  List<InvestigationValues> lstinvestigation)
        {
            long returnCode = -1;
            lstinvestigation = new List<InvestigationValues>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvestigationsOrderedCommand(ID, orgid, Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine db = new DBEngine())
                {
                    dataReader = db.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstinvestigation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvestigationInfo Billing_DAL", e);
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

        public long GetBillingItems(int OrgID, string FeeType, string Description, long ClientID, string IsMappedItem, string Remarks, string Gender, out List<BillingFeeDetails> lstBillingFeeDetails)
        {
            long returnCode = -1;
            lstBillingFeeDetails = new List<BillingFeeDetails>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetBillingItemsCommand(OrgID, FeeType, Description, ClientID, IsMappedItem, Remarks, Gender, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstBillingFeeDetails);
                        dataReader.Close();
                    }
                }
               
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL - GetBillingItems", ex);
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
        public long GetBillingItemsForBillEdit(int OrgID, string FeeType, 
            string Description, long ClientID, string IsMappedItem, string
            Remarks, string Gender,  List<OrderedInvestigations> lstOrderedInvestigations, out List<BillingFeeDetails> lstBillingFeeDetails)
        {
            long returnCode = -1;
            lstBillingFeeDetails = new List<BillingFeeDetails>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetBillingItemsForBillEditCommand(OrgID, FeeType, Description, ClientID, IsMappedItem, Remarks, Gender,UDT_DAL.ConvertToOrderedInvestigation(lstOrderedInvestigations), UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstBillingFeeDetails);
                        dataReader.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL - GetBillingItems", ex);
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

        public long GetBillingItemsDetails(int OrgID, int FeeID, string FeeType, string Description, long ClientID, long VisitID, 
            string Remarks, string IsCollected, DateTime CollectedDatetime, string locationName, long BookingID, out List<BillingFeeDetails> lstBillingFeeDetails)
        {
            long returnCode = -1;
            lstBillingFeeDetails = new List<BillingFeeDetails>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetBillingItemsDetailsCommand(OrgID, FeeID, FeeType, Description, ClientID, VisitID, 
                    Remarks, IsCollected, CollectedDatetime, locationName, BookingID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstBillingFeeDetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL - GetBillingItemsDetails", ex);
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

        public long GetBillingItemsDetails_Quantum(int OrgID, int FeeID, string FeeType, string Description, long ClientID, long VisitID, string Remarks, string IsCollected, DateTime CollectedDatetime, string locationName, List<OrderedInvestigations> lstOrderedItems, string ExtVisitNumber, string BilledDate, long BillNo, out List<BillingFeeDetails> lstBillingFeeDetails)
        {
            long returnCode = -1;
            lstBillingFeeDetails = new List<BillingFeeDetails>();
            DataTable invs = UDT_DAL.ConvertToOrderedInvestigation(lstOrderedItems);
            try
            {

                SqlCommand cmd = Command.pGetBillingItemsDetails_QuantumCommand(OrgID, FeeID, FeeType, Description, ClientID, VisitID, Remarks, IsCollected, CollectedDatetime, locationName, invs, ExtVisitNumber, BilledDate, BillNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillingFeeDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL - GetBillingItemsDetails", ex);
            }

            return returnCode;
        }
        public long GetHospitalBillingItemsDetails(int OrgID, int FeeID, string FeeType, string Description, long ClientID, long VisitID, string Remarks, long RateID, string VisitType, out List<BillingFeeDetails> lstBillingFeeDetails)
        {
            long returnCode = -1;
            lstBillingFeeDetails = new List<BillingFeeDetails>();
            try
            {

                SqlCommand cmd = Command.pGetHospitalBillingItemsDetailsCommand(OrgID, FeeID, FeeType, Description, ClientID, VisitID, Remarks, RateID, VisitType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillingFeeDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL - GetBillingItemsDetails", ex);
            }

            return returnCode;
        }
        public long GetEpisodeVisitDetails(int OrgID, long ClientID, long EpiosdeID, int RateID, out List<EpisodeVisitDetails> lstEpisodeVisitDetails)
        {
            long returnCode = -1;
            lstEpisodeVisitDetails = new List<EpisodeVisitDetails>();
            SqlCommand cmd = Command.pGetEpisodeVisitDetailsCommand(OrgID, ClientID, EpiosdeID, RateID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine db = new DBEngine())
            {
                db.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstEpisodeVisitDetails);

            }
            return returnCode;
        }

        public long GetOrderedInvestigationStatus(long PatientID, long VisitID, long FinallBillID, int OrgID, out List<FinalBill> lstFinalBill)
        {
            long returnCode = -1;
            lstFinalBill = new List<FinalBill>();
            try
            {

                SqlCommand cmd = Command.pGetOrderedInvestigationStatusCommand(PatientID, VisitID, FinallBillID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstFinalBill);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL - GetOrderedInvestigationStatus", ex);
            }
            return returnCode;
        }
        public long GetMergePhysicianPatient(string FilterText, int OrgID, string Type, string FromDate, string ToDate, string FindPosition, string ContactNumber, string MergeType, out List<DayWiseCollectionReport> lstCollections)
        {
            long returnCode = -1;
            lstCollections = new List<DayWiseCollectionReport>();
            try
            {
                SqlCommand cmd = Command.pGetMergePhysicianPatientCommand(FilterText, OrgID, Type, FromDate, ToDate, FindPosition, ContactNumber, MergeType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCollections);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL - GetMergePhysicianPatient", ex);
            }
            return returnCode;
        }

        public long UpdatePatientPhysicianMerge(long ParentReferenceID, int OrgID, List<PatientReferringDetails> lstDatas, string MergeType, long ModifiedBy, string RegType)
        {
            long lResult = -1;
            DataTable dtDatas = new DataTable();
            dtDatas = UDT_DAL.ConvertToPatientReferring(lstDatas);
            try
            {
                SqlCommand cmd = Command.pUpdatePatientPhysicianMergeCommand(ParentReferenceID, OrgID, dtDatas, MergeType, ModifiedBy, RegType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lResult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while update Patient Physician Merge in Billing DAL", ex);
            }
            return lResult;
        }

        public long GetvisitBillingInvestigationandDept(long visitID, out List<BillingDetails> lstBillingDetails,
                                                        out List<FinalBill> lstFinalBill,
                                                        out List<Patient> lstPatientDetail,
                                                        out List<Organization> lstOrganization,
                                                        out List<DuePaidDetail> lstDuesPaid,
                                                        long FinalBillID, int orgid, string lstSampleIds)
        {
            long returnCode = -1;
            lstBillingDetails = new List<BillingDetails>();
            lstFinalBill = new List<FinalBill>();
            lstPatientDetail = new List<Patient>();
            lstOrganization = new List<Organization>();
            lstDuesPaid = new List<DuePaidDetail>();

            DataSet ds = new DataSet();

            SqlCommand cmd = Command.pGetvisitBillingInvestigationandDeptCommand(visitID, FinalBillID, orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails), lstSampleIds);
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillingDetails);
            }
            if (ds.Tables[1].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatientDetail);
            }
            if (ds.Tables[2].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[2], out lstFinalBill);
            }

            if (ds.Tables[3].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[3], out lstOrganization);
            }
            if (ds.Tables[4].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[4], out lstDuesPaid);
            }

            return returnCode;
        }

        public long GetSurgicalFeeSplitUps(long TreatmentPlanID, out List<SOIRateDetails> lstSOIRateDetails)
        {
            long returnCode = -1;
            lstSOIRateDetails = new List<SOIRateDetails>();
            try
            {
                SqlCommand cmd = Command.PGetSurgicalFeeSplitUpsCommand(TreatmentPlanID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSOIRateDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL - GetMergePhysicianPatient", ex);
            }
            return returnCode;
        }

        public long GetBloodBags(long ProductID, out List<BloodSeparationDetails> LstBloodBags)
        {
            long returnCode = -1;
            LstBloodBags = new List<BloodSeparationDetails>();

            try
            {
                SqlCommand cmd = Command.PgetBloodBagNumbersCommand(ProductID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out LstBloodBags);
                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL - GetBloodBags", ex);
            }
            return returnCode;
        }

        public long InsertPatientVisitFromEpisode(long lid, int location, long patientid, long episodeid, int orgid, out long patientvistid,
            List<VisitClientMapping> lstVisitClientMapping)
        {
            long returncode = -1;
            patientvistid = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pInsertPatientVisitFromEpisodeCommand(location, lid, patientid, episodeid, orgid, out patientvistid, UDT_DAL.ConvertToUDT_Context(globalContextDetails), UDT_DAL.ConvertToVisitClientMapping(lstVisitClientMapping));
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                    patientvistid = Convert.ToInt64(cmd.Parameters["@pVisitId"].Value);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing PatientEpisode in Billing DAL", ex);
            }
            return returncode;
        }


        public long GetOPBillSettlement(long visitId, int OrgID, out List<BillingDetails> lstBillingDetails, out List<FinalBill> lstFinalBill,
            out List<FinalBill> lstFinalBillNOWise)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetOPBillSettlementCommand(visitId, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstBillingDetails = new List<BillingDetails>();
            lstFinalBill = new List<FinalBill>();
            lstFinalBillNOWise = new List<FinalBill>();

            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }


            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillingDetails);
            }

            if (ds.Tables[1].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstFinalBill);
            }

            if (ds.Tables[2].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[2], out lstFinalBillNOWise);
            }
            return returnCode;
        }
        public long UpdateSettlementFinallBill(FinalBill finalBill,
             AmountReceivedDetails amtRD,
             DataTable dtAmtReceived,
             List<PatientDueChart> pPatientIndTable,
             List<TaxBillDetails> lstTaxDetails, decimal dserviceCharge,
             List<PatientDueDetails> lstPatientDueDetails, List<Edt_AccountsImpactDetails> lstAccountImpact,
             List<VisitClientMapping> lstVisitClientMapping,
             int lstPaymentType, string BankName, string ChekNO, decimal NewAmountRecvd)
        {
            long lResult = -1;
            DataTable dtTax = new DataTable();
            dtTax = UDT_DAL.ConvertToUDTaxBillDetails(lstTaxDetails);
            DataTable dtBillingDetails = new DataTable();
            dtBillingDetails = UDT_DAL.ConvertToUDTPatientDueChart(pPatientIndTable);
            DataTable dtVisitClientmapping = new DataTable();
            DataTable dtpatientduedetails = new DataTable();
            DataTable dtAccountsImpactDetails = new DataTable();
            dtVisitClientmapping = UDT_DAL.ConvertToVisitClientMapping(lstVisitClientMapping);

            dtpatientduedetails = UDT_DAL.ConvertToUDTPatientDueDetails(lstPatientDueDetails);
            dtAccountsImpactDetails = UDT_DAL.ConvertToUATAccountsImpactDetails(lstAccountImpact);

            SqlCommand cmd = Command.pUpdateSettlementFinallBillCommand(finalBill.VisitID,
                                    finalBill.OrgID, finalBill.AmountReceived, finalBill.DiscountAmount,
                                    finalBill.Due, finalBill.CurrentDue, finalBill.GrossBillValue, finalBill.IsCreditBill,
                                    finalBill.NetValue, finalBill.StdDedID, finalBill.ModifiedBy, dtAmtReceived, dtBillingDetails, NewAmountRecvd,
                                                     amtRD.ReceivedBy, amtRD.CreatedBy, dtTax, finalBill.DiscountReason, dserviceCharge, finalBill.RoundOff,
                                                     finalBill.AmountRefund, UDT_DAL.ConvertToUDT_Context(globalContextDetails),
                                                     dtpatientduedetails, dtAccountsImpactDetails, lstPaymentType, BankName, ChekNO, finalBill.RefundStatus,
                                                     dtVisitClientmapping);
            using (DBEngine dbEngine = new DBEngine(false))
            {
                lResult = dbEngine.ExecuteNonQuery(cmd);
            }
            return lResult;
        }
        public long GetBillingDetailsByRateTypeForOP(long VisitID, long BilledRateID, decimal BilledRateCardAmount, long SelectedRateID, out decimal BilledandSelectedRateCardDifference, int OrgID, string Type, out List<BillingDetails> lstDetails)
        {
            long returnCode = -1;
            lstDetails = new List<BillingDetails>();
            SqlCommand cmd = Command.pGetBillingDetailsByRateTypeForOPCommand(VisitID, BilledRateID, BilledRateCardAmount, SelectedRateID, out BilledandSelectedRateCardDifference, OrgID, Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returnCode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDetails);
                    BilledandSelectedRateCardDifference = Convert.ToDecimal(cmd.Parameters["@pBilledandSelectedRateCardDifference"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL GetBillingDetailsByRateTypeForOP", ex);
            }

            return returnCode;
        }


        public long GetMergeBillPrinting(long VisitID, out List<BillingDetails> lstBillingDetail, out List<FinalBill> lstFinalBillDetail,
            out  List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetMergeBillPrintingCommand(VisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstBillingDetail = new List<BillingDetails>();
            lstFinalBillDetail = new List<FinalBill>();
            lstPatientDetails = new List<Patient>();

            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillingDetail);
            }

            if (ds.Tables[1].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstFinalBillDetail);
            }

            if (ds.Tables[2].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatientDetails);
            }
            return returnCode;
        }

        public long GetBookingOrderDetails(long BookingId, int OrgId, int LocationId, out List<Bookings> lstBookings)
        {
            long returnCode = -1;
            lstBookings = new List<Bookings>();
            SqlCommand cmd = Command.pGetBookingOrderDetailsCommand(BookingId, OrgId, LocationId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returnCode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBookings);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL GetBookingOrderDetails", ex);
            }

            return returnCode;
        }
        public long GetFinalbillRefundDetails(long vid, long pFinalBillid, int pOrgid, out List<BillingDetails> lstBillingDetails, out List<FinalBill> lstFinalBill)
        {
            long returnCode = -1;
            lstFinalBill = new List<FinalBill>();
            lstBillingDetails = new List<BillingDetails>();


            SqlCommand cmd = Command.pGetFinalbillRefundDetailsCommand(vid, pFinalBillid, pOrgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));


            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillingDetails);
            }
            if (ds.Tables[1].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstFinalBill);
            }
            return returnCode;
        }

        public long GetBillingItemsDetailsForEdit(int OrgID, string BillNo, long VisitID, long PatientID, long ClientID, out List<BillingDetails> lstBillings1, out List<BillingDetails> lstBillings2)
        {
            long returnCode = -1;
            int rsCount = 0;
            lstBillings1 = new List<BillingDetails>();
            lstBillings2 = new List<BillingDetails>();
            IDataReader dataReader = null;
            try
            {
            SqlCommand cmd = Command.pGetBillingItemsDetailsForEditCommand(OrgID, BillNo, VisitID, PatientID, ClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine db = new DBEngine())
            {
                    dataReader = db.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstBillings1);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstBillings2);
                            }

                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetBillingItemsDetailsForEdit Billing_DAL", e);
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


        public long GetDiscountLimit(string ReferType, long ReferID, int OrgID, out List<FinalBill> lstFinalBill)
        {
            long returnCode = -1;
            lstFinalBill = new List<FinalBill>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetDiscountLimitCommand(ReferType, ReferID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstFinalBill);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL - GetBillingItemsDetails", ex);
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


        public long GetRateNameForClients(int OrgID, String FromDate, String ToDate, long ClientID, long InvoiceID, out List<RateMaster> lstRateMaster, out List<RateMaster> AllRateMaster, out List<RateMaster> lstInvoice, out List<RateMaster> lstselrateName)
        {
            long returnCode = -1;
            lstRateMaster = new List<RateMaster>();
            AllRateMaster = new List<RateMaster>();
            lstInvoice = new List<RateMaster>();
            lstselrateName = new List<RateMaster>();

            SqlCommand cmd = Command.pGetRateNameForClientsCommand(OrgID, FromDate, ToDate, ClientID, InvoiceID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine db = new DBEngine())
            {
                db.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstRateMaster);

            }
            if (ds.Tables[1].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out AllRateMaster);

            }
            if (ds.Tables[2].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[2], out lstInvoice);

            }
            if (ds.Tables[3].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[3], out lstselrateName);

            }
            return returnCode;
        }

        public long GetRateDetailForBulckRateChanges(int OrgID, int ClientId, string FDate, string ToDate, int NewRateid, List<Invoice> lstInvoice, List<RateMaster> lstRateMaster, out List<BulckRateUpdates> lstBillings)
        {
            long returnCode = -1;
            lstBillings = new List<BulckRateUpdates>();
            DataTable Invoice = UDT_DAL.ConvertToInvoiceForBulkrate(lstInvoice);
            DataTable Rate = UDT_DAL.ConvertToRateForBulkrate(lstRateMaster);

            SqlCommand cmd = Command.pGetRateForBulckRateChangesCommand(OrgID, ClientId, FDate, ToDate, Invoice, Rate, NewRateid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine db = new DBEngine())
            {
                db.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillings);

            }
            return returnCode;
        }

        public long InsertBulkRateApply(int OrgID, List<BulckRateUpdates> lstBulckRateUpdates, out long BulkID)
        {

            long retCode = -1;
            BulkID = 0;
            DataTable BulkInsertRateUpdate = UDT_DAL.ConvertToBulkRateApp1y(lstBulckRateUpdates);

            SqlCommand cmdInvestigation = new SqlCommand();
            cmdInvestigation = Command.pInsertBulckRateChangesCommand(BulkInsertRateUpdate, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out BulkID);
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInvestigation);
                    Int64.TryParse(cmdInvestigation.Parameters["@pBulkID"].Value.ToString(), out BulkID);
                    // retCode = Convert.ToInt32(cmdInvestigation.Parameters["@returnstatus"].Value);
                }

            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing UpdateSampleTransfer in Investigation_DAL", e);
            }
            return retCode;
        }
        //public long InsertBulkRateApply(int OrgID, List<BulckRateUpdates> lstBulckRateUpdates)
        //{

        //}
        public long GetRateAppliedRares(long BulckID, out List<BulckRateUpdates> lstBillings, out List<RateMaster> lstClients, out List<RateMaster> lstInvoice
            , out List<RateMaster> lstRate)
        {
            long returnCode = -1;
            lstBillings = new List<BulckRateUpdates>();
            lstClients = new List<RateMaster>();
            lstInvoice = new List<RateMaster>();
            lstRate = new List<RateMaster>();
            SqlCommand cmd = Command.pGetRateAppliedRaresCommand(BulckID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine db = new DBEngine())
            {
                db.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillings);

            }
            if (ds.Tables[1].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstClients);

            }
            if (ds.Tables[2].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[2], out lstInvoice);

            }
            if (ds.Tables[3].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[3], out lstRate);
            }
            return returnCode;
        }


        public long InsertInvoiceRatediff(int OrgID, int ClientID, string FDate, string TDate, List<Invoice> lstInvoice, List<RateMaster> lstRateMaster,
            int NewRateID, long LoginID, long BulkID)
        {
            long retCode = -1;
            BulkID = 0;
            DataTable Invoice = UDT_DAL.ConvertToInvoiceForBulkrate(lstInvoice);
            DataTable Rate = UDT_DAL.ConvertToRateForBulkrate(lstRateMaster);
            SqlCommand cmdInvestigation = new SqlCommand();
            cmdInvestigation = Command.PInsertInvoiceRatediffCommand(OrgID, ClientID, FDate, TDate, Invoice, Rate, NewRateID, LoginID, BulkID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInvestigation);
                }

            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing InsertInvoiceRatediff in Billing_DAL", e);
            }
            return retCode;
        }
        public long InsertDueWriteOffApprovals(List<PatientDueDetails> lstPDD, out long WriteOffApprovalID)
        {
            long returnCode = -1;
            WriteOffApprovalID = 0;
            SqlCommand cmd = Command.pInsertDueWriteOffApprovalsCommand(lstPDD[0].PatientID, lstPDD[0].VisitID, lstPDD[0].FinalBillID, lstPDD[0].DueAmount, lstPDD[0].OrgID,
                lstPDD[0].Status, lstPDD[0].WriteOffAmt, lstPDD[0].DiscountAmt, lstPDD[0].CreatedBy, lstPDD[0].CreatedAt, lstPDD[0].PatientDueID, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out WriteOffApprovalID);

            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
                WriteOffApprovalID = Convert.ToInt64(cmd.Parameters["@pWriteOffApprovalID"].Value);
            }
            return returnCode;
        }
        public long GetDueWriteOffApprovals(long ApprovalID, long PatientID, long FinalbillID, out List<PatientDueDetails> lstDueWriteOffs)
        {
            long returnCode = -1;
            lstDueWriteOffs = new List<PatientDueDetails>();
            SqlCommand cmd = Command.pGetDueWriteOffApprovalsCommand(ApprovalID, PatientID, FinalbillID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returnCode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDueWriteOffs);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL lstDueWriteOffs", ex);
            }

            return returnCode;
        }

        public long UpdateDueWriteOffApprovals(long ApprovalID, decimal ApprovalWriteOffAmt, int OrgID, string Status)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pUpdateDueWriteOffApprovalsCommand(ApprovalID, ApprovalWriteOffAmt, OrgID, Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }
        public long UpdateAmountReceivedDetails(long finalBillID, DataTable dt)
        {
            long returnCode = -1;
            try
            {
                //DataTable dt = UDT_DAL.ConvertToUDTAmtRecDetailsUpdate(lAmtDetails);

                SqlCommand cmd = Command.pUpdateAmtReceivedDetailsCommand(dt, finalBillID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL UpdateBillReAssigned", ex);
            }

            return returnCode;
        }
        public long GetLabQuickBillPatientListForClientBilling(string pName, string pVisitType, int pOrgID, long PatientVisitId, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
			IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetLabQuickPatientsForClientBillingCommand(pName, pVisitType, pOrgID, PatientVisitId,
                   UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPatientDetails);
                        dataReader.Close();
                    }   
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetLabQuickBillPatientListForBilling in Billing_DAL", ex);
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

        public long GetDuplicateValidationonEntry(int pOrgID, string Name, string Age, long ClientID, string registerdDate, long ID, string type,
         out List<PatientVisit> lstPatientVisit)
        {
            long returnCode = -1;
            lstPatientVisit = new List<PatientVisit>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetDuplicateValidationonEntryCommand(pOrgID, Name, Age, ClientID, registerdDate, ID, type,
                UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPatientVisit);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDuplicateValidationonEntry in Billing_DAL", ex);
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

        public long GetQuickPatientSearch(int searchType, string SearchText, int pOrgID, long pClientID, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetQuickPatientSearchCommand(searchType, SearchText, pOrgID, pClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPatientDetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetQuickPatientSearch in Billing_DAL", ex);
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

        public long GetQuickPatientSearchDetails(long PatientID, long PatientVisitID, int pOrgID, int SearchType, long HealthiAPIBookingID, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
			IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetQuickPatientSearchDetailsCommand(PatientID, PatientVisitID, pOrgID, SearchType, HealthiAPIBookingID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPatientDetails);
                        dataReader.Close();
                }
            }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetQuickPatientSearchDetailsCommand in Billing_DAL", ex);
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



        public long GetClientRefPhyHosforCode(string SearchText, int OrgID, out List<ClientCodeMapping> lstClientCodeMapping)
        {
            long returnCode = -1;
            lstClientCodeMapping = new List<ClientCodeMapping>();

            try
            {
                SqlCommand cmd = Command.pGetClientRefPhyHosforCodeCommand(SearchText, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstClientCodeMapping);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL - GetClientRefPhyHosforCode", ex);
            }
            return returnCode;

        }
        public long GetRateForSTAT(int OrgID, int FeeID, string FeeType, long ClientID, string BillNo, string BillstartTime, out List<BillingFeeDetails> lstGeneralBillingItems)
        {
            long returnCode = -1;
            lstGeneralBillingItems = new List<BillingFeeDetails>();
            try
            {

                SqlCommand cmd = Command.pGetAutoFeeForSTATCommand(OrgID, FeeID, FeeType, ClientID, BillNo, BillstartTime, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstGeneralBillingItems);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL - GetRateForSTAT", ex);
            }

            return returnCode;
        }
 //Vijayalakshmi.m
        public long GetOrganisationDetails(int OrgID,out  List<LabReferenceOrg> lstlabreforg)
        {
            long returnCode = -1;
            lstlabreforg = new List<LabReferenceOrg >();

            try
            {
                SqlCommand cmd = Command.pGetOrganisationDetailsCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstlabreforg);
                }
              
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL - GetOrganisationDetails", ex);
            }
            return returnCode;
        }
        public long GetOutSourceWorksheet(DateTime fDate, DateTime tDate, long LabRefId, int OrgID, out List<OutsourcingDetail> lstoutsourcce, out List<InvRateMaster> lstrate, out List<LabRefOrgAddress> lstadd, out List<GeneralBillingItems> lstbill)
        {
            long ReturnCode = -1;            
            lstoutsourcce = new List<OutsourcingDetail>();
            lstrate = new List<InvRateMaster>();
            lstadd = new List<LabRefOrgAddress>();
            lstbill = new List<GeneralBillingItems>();
            try
            {
                SqlCommand cmd = Command.pGetOutSourceWorksheetCommand(fDate ,tDate ,LabRefId ,OrgID , UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReturnCode = Utilities.ConvertTo(ds.Tables[0], out lstoutsourcce);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    ReturnCode = Utilities.ConvertTo(ds.Tables[1], out lstrate);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    ReturnCode = Utilities.ConvertTo(ds.Tables[2], out lstadd );
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    ReturnCode = Utilities.ConvertTo(ds.Tables[3], out lstbill );
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL - GetOrganisationDetails", ex);
            }
            return ReturnCode;

        }
        public long GetQuotationClientName(string SearchText, int pOrgID, out List<Patient> lstClientDetails)
        {
            long returnCode = -1;
            lstClientDetails = new List<Patient>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetQuotationClientNameCommand(SearchText, pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstClientDetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetQuickPatientSearch in Billing_DAL", ex);
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
        public long GetQuotationClientNameDetails(string ClientID, int pOrgID, out List<Patient> lstClientDetails)
        {
            long returnCode = -1;
            lstClientDetails = new List<Patient>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetQuotationClientNameDetailCommand(ClientID, pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstClientDetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetQuickPatientSearchDetailsCommand in Billing_DAL", ex);
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

        public long GetQuotationNumber(string SearchText, int pOrgID, string type,out List<Patient> lstQuotationNo)
        {
            long returnCode = -1;
            lstQuotationNo = new List<Patient>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetQuotationNumberCommand(SearchText, pOrgID,type,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstQuotationNo);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetQuickPatientSearch in Billing_DAL", ex);
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
        public long GetQuotationNumberDetails(string Quotationid, string ClientID, int pOrgID, string Type, string SampleType, out List<Patient> lstClientDetails, out List<PreQuotationInvestigations> lstTest, out List<QuotationBill> lstvalues, out  List<WatersQuotationMaster> lstWaters, out List<QuotationAddressDetails> TempAddrs)
        {
            long returnCode = -1;
            lstClientDetails = new List<Patient>();
            lstTest = new List<PreQuotationInvestigations>();
            lstvalues = new List<QuotationBill>();
            lstWaters = new List<WatersQuotationMaster>();
            TempAddrs = new List<QuotationAddressDetails>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetQuotationNumberDetailsCommand(Quotationid, ClientID, pOrgID, Type,SampleType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstClientDetails);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstTest);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstvalues );
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstWaters);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out TempAddrs);
                }
                
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetQuickPatientSearchDetailsCommand in Billing_DAL", ex);
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
		   /*added By jagatheesh  for Test wise Analyzer report*/
        public long GetTestCodeItems(int OrgID, string Description, out List<TestWiseAnalyzerReport> lstTestCodeDetails)
        {
            long returnCode = -1;
            lstTestCodeDetails = new List<TestWiseAnalyzerReport>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetTestCodeDetailsCommand(Description, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTestCodeDetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL - GetTestCodeItems For Test Wise Analyzer Report", ex);
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
		 /* End Added */
        public long GetPKGQuotationMasterDetails(long ID, string Type, int orgid, out  List<InvestigationValues> lstinvestigation)
        {
            long returnCode = -1;
            lstinvestigation = new List<InvestigationValues>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetPKGQuotationMasterDetailsCommand(ID, orgid, Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine db = new DBEngine())
                {
                    dataReader = db.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstinvestigation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvestigationInfo Billing_DAL", e);
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
		
		 public long GetPKGQuotationDetails(long ID, string Type, int orgid, out  List<InvestigationValues> lstinvestigation)
        {
            long returnCode = -1;
            lstinvestigation = new List<InvestigationValues>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetPKGQuotationDetailsCommand(ID, orgid, Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine db = new DBEngine())
                {
                    dataReader = db.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstinvestigation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvestigationInfo Billing_DAL", e);
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


         public long GetBillPrintingDetails_MRPBill(long visitID, out List<BillingDetails> lstBillingDetails,
                                                      out List<FinalBill> lstFinalBill,
                                                      out List<Patient> lstPatientDetail,
                                                      out List<Organization> lstOrganization,
                                                      out string physicianName,
                                                      out List<DuePaidDetail> lstDuesPaid,
                                                      long FinalBillID, out List<Taxmaster> lstTaxes, out string splitstatus, out List<PatientQualification> lstQualification)
         {
             long returnCode = -1;
             lstBillingDetails = new List<BillingDetails>();
             lstFinalBill = new List<FinalBill>();
             lstPatientDetail = new List<Patient>();
             lstOrganization = new List<Organization>();
             lstDuesPaid = new List<DuePaidDetail>();
             lstTaxes = new List<Taxmaster>();
             lstQualification = new List<PatientQualification>();
             physicianName = string.Empty;
             splitstatus = string.Empty;
             DataSet ds = new DataSet();

             SqlCommand cmd = Command.pGetBillPrinting_MRPBillCommand(visitID, out physicianName, FinalBillID, out splitstatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
             using (DBEngine dbEngine = new DBEngine(false))
             {
                 returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

             }
             physicianName = Convert.ToString(cmd.Parameters["@pPhysicianName"].Value);
             splitstatus = Convert.ToString(cmd.Parameters["@SplitStatus"].Value);
             if (ds.Tables[0].Rows.Count > 0)
             {
                 returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillingDetails);
             }

             if (ds.Tables[1].Rows.Count > 0)
             {
                 returnCode = Utilities.ConvertTo(ds.Tables[1], out lstFinalBill);
             }

             if (ds.Tables[2].Rows.Count > 0)
             {
                 returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatientDetail);
             }

             if (ds.Tables[3].Rows.Count > 0)
             {
                 returnCode = Utilities.ConvertTo(ds.Tables[3], out lstOrganization);
             }
             if (ds.Tables[4].Rows.Count > 0)
             {
                 returnCode = Utilities.ConvertTo(ds.Tables[4], out lstDuesPaid);
             }
             if (ds.Tables[5].Rows.Count > 0)
             {
                 returnCode = Utilities.ConvertTo(ds.Tables[5], out lstTaxes);
             }
             if (ds.Tables[6].Rows.Count > 0)
             {
                 returnCode = Utilities.ConvertTo(ds.Tables[6], out lstQualification);
             }
             return returnCode;
         }
		 
        public long GetpkgSampleDetails(long QuotationID, long InvestigationID, string Type, out  List<QuotationSampleScheduling> lstinvestigation)
         {
             long returnCode = -1;
            lstinvestigation = new List<QuotationSampleScheduling>();
             IDataReader dataReader = null;
             try
             {
                 SqlCommand cmd = Command.pGetpkgSampleDetailsCommand(QuotationID, InvestigationID, Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails)); 
                 
                 using (DBEngine db = new DBEngine())
                 {
                     dataReader = db.ExecuteReader(cmd);
                     if (dataReader != null)
                     {
                         returnCode = Utilities.ConvertTo(dataReader, out lstinvestigation);
                         dataReader.Close();
                     }
                 }
             }
             catch (Exception e)
             {
                 CLogger.LogError("Error while executing GetInvestigationInfo Billing_DAL", e);
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

        public long GetRegistrationSampleCollect(long QuotationID, int Orgid,long VisitID ,out  List<PreQuotationInvestigations> lstinvestigation)
        {
			
            long returnCode = -1;
            lstinvestigation = new List<PreQuotationInvestigations>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetWatersSampleCollectCommand(QuotationID, Orgid, VisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine db = new DBEngine())
                {
                    dataReader = db.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstinvestigation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvestigationInfo Billing_DAL", e);
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
		
		
		  public long GetPreRegistrationDiscountRedeemDetails(long bookingID, out List<PreRegistrationDiscountRedeemDetails> lstDiscountRedeemDetails)
         {
             IDataReader dataReader = null;
             long returnCode = -1;
             lstDiscountRedeemDetails = new List<PreRegistrationDiscountRedeemDetails>();
             try
             {
                 SqlCommand cmd = Command.pGetPreRegistrationDiscountRedeemDetailsCommand(bookingID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                 using (DBEngine dbEngine = new DBEngine())
                 {
                     dataReader = dbEngine.ExecuteReader(cmd);
                     if (dataReader != null)
                     {
                         returnCode = Utilities.ConvertTo(dataReader, out lstDiscountRedeemDetails);

                     }
                     dataReader.Close();
                 }

             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while loading GetPreRegistrationDiscountRedeemDetails in Billing DAL", ex);
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

          public long GetWatersInvoiceGeneration(long InvoiceID, long ClientID, int OrgID, int OrgAdd, DateTime FDate, DateTime TDate, int RejBills, out List<BillingDetails> lstInvoiceBill, out List<DiscountPolicy> lstVolumeDiscount, out List<CreditDebitSummary> lstCreditDebit)
          {
              long returnCode = -1;
              lstInvoiceBill = new List<BillingDetails>();
              lstVolumeDiscount = new List<DiscountPolicy>();
              lstCreditDebit = new List<CreditDebitSummary>();
              SqlCommand cmd = Command.pGetWatersInvoiceGenerationCommand(InvoiceID, ClientID, OrgID, OrgAdd, FDate, TDate, RejBills, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
              DataSet ds = new DataSet();
              using (DBEngine dbEngine = new DBEngine())
              {
                  dbEngine.ExecuteDataSet(cmd, out ds);
              }
              if (ds.Tables[0].Rows.Count > 0)
              {
                  returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvoiceBill);
              }
              if (ds.Tables[1].Rows.Count > 0)
              {
                  returnCode = Utilities.ConvertTo(ds.Tables[1], out lstVolumeDiscount);
              }
              if (ds.Tables[2].Rows.Count > 0)
              {
                  returnCode = Utilities.ConvertTo(ds.Tables[2], out lstCreditDebit);
              }
              return returnCode;

          }
          public long ClientAttributesFieldDetails(long ReferenceID, string ReferenceType, out List<FieldAttributeDetails> lstFieldDetails)
          {
              long returnCode = -1;
              lstFieldDetails = new List<FieldAttributeDetails>();
              SqlCommand cmd =Command.PgetClientAttributesFieldDetailsCommand(ReferenceID,ReferenceType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
              DataSet ds = new DataSet();
              using (DBEngine dbEngine = new DBEngine())
              {
                  dbEngine.ExecuteDataSet(cmd, out ds);
              }
              if (ds.Tables[0].Rows.Count > 0)
              {
                  returnCode = Utilities.ConvertTo(ds.Tables[0], out lstFieldDetails);
              }
              return returnCode;
          }

          public long TestHistoryFieldDetails(long ReferenceID, string ReferenceType,string TestType, out List<FieldAttributeDetails> lstFieldDetails)
          {
              long returnCode = -1;
              lstFieldDetails = new List<FieldAttributeDetails>();
              SqlCommand cmd = Command.PgetTestHistoryFieldDetailsCommand(ReferenceID, ReferenceType, TestType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
              DataSet ds = new DataSet();
              using (DBEngine dbEngine = new DBEngine())
              {
                  dbEngine.ExecuteDataSet(cmd, out ds);
              }
              if (ds.Tables[0].Rows.Count > 0)
              {
                  returnCode = Utilities.ConvertTo(ds.Tables[0], out lstFieldDetails);
              }
              return returnCode;
          }
          public long InsertClientAttributesFieldDetails(long PatientVisitID,List<ClientAttributesKeyFields> lstclt)
          {
              long returnCode = -1;
              //lstclt = new List<ClientAttributesKeyFields>();
              DataTable dtField=UDT_DAL.ConvertToPatientAttributesField(lstclt);
              SqlCommand cmd = Command.pInsertClientAttributeFieldDetailsCommand(PatientVisitID, dtField, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
              using (DBEngine dbEngine = new DBEngine())
              {
                returnCode =  dbEngine.ExecuteNonQuery(cmd);
              }
             
              return  returnCode;
          }
          public long InsertTestHistoryPatientFieldDetails(long PatientVisitID, List<ClientAttributesKeyFields> lstclt,string ActionType)
          {
              long returnCode = -1;
              //lstclt = new List<ClientAttributesKeyFields>();
              DataTable dtField = UDT_DAL.ConvertToPatientAttributesField(lstclt);
              SqlCommand cmd = Command.pInsertTestHistoryPatientDetailsCommand(PatientVisitID, dtField,ActionType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
              using (DBEngine dbEngine = new DBEngine())
              {
                  returnCode = dbEngine.ExecuteNonQuery(cmd);
              }

              return returnCode;
          }
        public long LoadSpecialSamples(string prefixText, out List<InvSampleMaster> FileList)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetSpecialSamplesCommand(prefixText, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            FileList = new List<InvSampleMaster>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out FileList);
            }
            return returnCode;
        }
		public long SaveBillEditDetails(long pOrgID, decimal pGrossBillValue, decimal pDiscountAmount, decimal pNetValue, long pVisitID, long pClientID, long pBillID, List<PatientDueChart> lstPatientDueChart)
          {

              long returnCode = -1;

              IDataReader dataReader = null;
              try
              {
                  SqlCommand cmd = Command.pSaveBillEditDetailsCommand(pOrgID,pGrossBillValue,pDiscountAmount,pNetValue, pVisitID, pClientID, pBillID, UDT_DAL.ConvertToUDTPatientDueChart(lstPatientDueChart), UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                  using (DBEngine db = new DBEngine())
                  {
                    returnCode = db.ExecuteNonQuery(cmd);

                  }
              }
              catch (Exception e)
              {
                  CLogger.LogError("Error while executing GetInvestigationInfo Billing_DAL", e);
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
        public long ClientAttributesFieldValues(long ReferenceID, string ReferenceType, long PatientVisitID, out List<ClientAttributesKeyFields> lstFieldDetails)
        {
            long returnCode = -1;
            lstFieldDetails = new List<ClientAttributesKeyFields>();
            SqlCommand cmd = Command.PgetClientAttributesFieldValuesCommand(ReferenceID, ReferenceType, PatientVisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstFieldDetails);
            }
            return returnCode;
        }

        public long GetHCPayments(int OrgID, long BookingID, out List<BillingFeeDetails> lstPayments)
        {
            long returnCode = -1;
            lstPayments = new List<BillingFeeDetails>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetHCPaymentDetailsCommand(OrgID, BookingID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPayments);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL - GetHCPayments", ex);
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

        public long GetHCTRFfile(long BookingID, out List<BillingFeeDetails> lstTRFfiles)
        {
            long returnCode = -1;
            lstTRFfiles = new List<BillingFeeDetails>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetHCTRFfileNameCommand(BookingID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTRFfiles);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL - GetHCTRFfile", ex);
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

        //HealthHubID validate
        public long ValidateHealthHubID(int pOrgID, long pBookingID, string pHealthHubID, string pName, string pDOB, string pGender, string pMob, string pEmail,
                                              out List<Patient> lstHealthHubID)
        {
            long returnCode = -1;
            lstHealthHubID = new List<Patient>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pValidateHealthHubIDCommand(pOrgID, pBookingID, pHealthHubID, pName, pDOB, pGender, pMob, pEmail,
                                                                  UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstHealthHubID);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL - ValidateHealthHubID", ex);
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

  public long UpdateBillofSupplyNumberClientWise(long ClientID, int OrgID, string BillofSupplyNumber, decimal InvoiceAmount, string DateofBill)
        {
            long returnCode = -1;
            try
            {

                SqlCommand cmd = Command.pUpdatebillofSupplyNumberClientWiseCommand(ClientID, OrgID, BillofSupplyNumber, InvoiceAmount, DateofBill, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL UpdateBillofSupplyNumberClientWise", ex);
            }

            return returnCode;
        }
		
		  public long GetRateCardForBilling_Franchisee(string SearchText, long OrgID, string Type, long refhospid, out List<InvClientMaster> lstClients)
        {
            long returnCode = -1;
            lstClients = new List<InvClientMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetRateCardForBilling_FranchiseeCommand(SearchText, OrgID, Type, refhospid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstClients);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BillingDAL GetRateCardForBilling_Franchisee", ex);
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

  #region POSsettlement
        public long InsertAmountClosureDenoDetails(decimal totalAmount, decimal amountReceived, string status,
                                             int closedBy, int closedFor, int createdBy, int createdFor,
                                             DataTable dtClosureDenoDetails,
                                             DataTable dtBillingDetails,
                                             DataTable dtAmountRefundDetails,
                                             DataTable dtAmountPaidDetails, string AllUsersSelected,
                                             decimal amountRefund, string isrefund)
        {
            int returnCode = -1;
            int returnStatus = -1;

            SqlCommand cmd = Command.pInsertAmountclosureDenoDetailsCommand(totalAmount, amountReceived, status,
                                    closedBy, closedFor, createdBy, AllUsersSelected,
                                    amountRefund, isrefund, dtClosureDenoDetails, dtBillingDetails, dtAmountRefundDetails,
                                                                                                            dtAmountPaidDetails, out returnStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                    returnCode = Convert.ToInt32(cmd.Parameters["@returnstatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving PatientInvestigation investigation_DAL", e);
            }
            return returnCode;
        }

        public long InsertAmountClosureDenoDetailsForAllUsers(DataTable dtClosureDenoDetails, DataTable dtClosureDetails, string status, int createdBy,
                                                          DataTable dtBillingDetails,
                                                          DataTable dtAmountRefundDetails,
                                                          DataTable dtAmountPaidDetails, string isrefund)
        {
            int returnCode = -1;
            SqlCommand cmd = Command.pInsertAmountclosureDenoDetailsForAllUsersCommand(dtClosureDenoDetails, dtClosureDetails, status, createdBy,
                                    isrefund, dtBillingDetails,
                                    dtAmountRefundDetails, dtAmountPaidDetails,
                                                                                                                        out returnCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                    returnCode = Convert.ToInt32(cmd.Parameters["@returnstatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while saving PatientInvestigation investigation_DAL", e);
            }
            return returnCode;
        }
        public long GetCurrencyForOrgMappingCashClosureDeno(int OrgID, out List<CurrencyMaster> lstCurrencyMaster)
        {
            long returnCode = -1;
            lstCurrencyMaster = new List<CurrencyMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetCurrencyForOrgMappingCashClosureDenoCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstCurrencyMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing GetCurrencyForOrgMapping in BillingDAL", excep);
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
        #endregion

        public long GetAmountReceivedDenoDetails(long UserID, int OrgId, DateTime pFDT, DateTime pTDT, int locationId, out List<ReceivedAmount> lstBillingDetails,
                                        out List<CashClosureDenominationDetail> lstCCDenoDetails,
                                           out List<ReceivedAmount> lstRefundDetails,
                                           out List<ReceivedAmount> lstPaymentDetails,
                                           out decimal dTotalAmount, out decimal dTotalRefund, out decimal dTotalCancelledAmount,
                                           out string sRcvdFromtime, out string sRcvdTotime,
                                           out string sRefundFromtime, out string sRefundTotime,
                                           out string sMinStartTime, out string sMaxEndTime,
                                           out decimal drAmount, out decimal othersAmount,
                                           out decimal TotalIncAmount,
                                           out List<ReceivedAmount> lstINDAmtReceivedDetails,
                                           out List<ReceivedAmount> lstINDIPAmtReceivedDetails,
                                           out List<AmountReceivedDetails> lstreceivedTypes,
                                          out List<ReceivedAmount> lstSplitDetails,
                                          out List<AmountReceivedDetails> lstIncSourcePaidDetails,
                                          out List<CurrencyOrgMapping> lstCurrencyInHand,
                                          out List<CashClosureDenomination> lstCCDeno,
                                          out decimal TotalPendingSettleAmt)
        {
            long returnCode = -1;
            sRcvdFromtime = string.Empty;
            sRcvdTotime = string.Empty;
            sRefundFromtime = string.Empty;
            sRefundTotime = string.Empty;
            lstRefundDetails = new List<ReceivedAmount>();
            lstBillingDetails = new List<ReceivedAmount>();
            lstPaymentDetails = new List<ReceivedAmount>();
            lstINDAmtReceivedDetails = new List<ReceivedAmount>();
            lstINDIPAmtReceivedDetails = new List<ReceivedAmount>();
            lstreceivedTypes = new List<AmountReceivedDetails>();
            lstSplitDetails = new List<ReceivedAmount>();
            lstCurrencyInHand = new List<CurrencyOrgMapping>();
            lstCCDeno = new List<CashClosureDenomination>();
            lstCCDenoDetails = new List<CashClosureDenominationDetail>();
            lstIncSourcePaidDetails = new List<AmountReceivedDetails>();
            int rsCount = 0;
            dTotalAmount = 0;
            dTotalRefund = 0; dTotalCancelledAmount = 0;
            drAmount = 0;
            othersAmount = 0;
            TotalIncAmount = 0;
            TotalPendingSettleAmt = 0;
            sMinStartTime = string.Empty;
            sMaxEndTime = string.Empty;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                if (UserID == 0)
                {
                    cmd = Command.pGetAmountReceivedDenoDetailsCommand(UserID, OrgId, pFDT, pTDT, locationId, out dTotalAmount, out dTotalRefund, out dTotalCancelledAmount, out sRcvdFromtime, out sRcvdTotime, out sRefundFromtime, out sRefundTotime, out sMinStartTime, out sMaxEndTime, out drAmount, out othersAmount, out TotalIncAmount, out TotalPendingSettleAmt, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                }
                else
                {
                    cmd = Command.pGetAmountReceivedDenoDetailsForUsersCommand(UserID, OrgId, pFDT, pTDT, locationId, out dTotalAmount, out dTotalRefund, out dTotalCancelledAmount, out sRcvdFromtime, out sRcvdTotime, out sRefundFromtime, out sRefundTotime, out sMinStartTime, out sMaxEndTime, out drAmount, out othersAmount, out TotalIncAmount, out TotalPendingSettleAmt, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                }
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstBillingDetails);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstCCDenoDetails);
                            }
                            else if (rsCount == 3)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstRefundDetails);
                            }
                            else if (rsCount == 4)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPaymentDetails);
                            }
                            else if (rsCount == 5)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstINDAmtReceivedDetails);
                            }
                            else if (rsCount == 6)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstINDIPAmtReceivedDetails);
                            }
                            else if (rsCount == 7)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstreceivedTypes);
                            }
                            else if (rsCount == 8)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstCurrencyInHand);
                            }
                            else if (rsCount == 9)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstIncSourcePaidDetails);
                            }
                            if (UserID > 0)
                            {
                                if (rsCount == 10)
                                {
                                    returnCode = Utilities.ConvertTo(dataReader, out lstSplitDetails);
                                }
                                else if (rsCount == 11)
                                {
                                    returnCode = Utilities.ConvertTo(dataReader, out lstCCDeno);
                                }
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                    decimal.TryParse(cmd.Parameters["@TotalAmount"].Value.ToString(), out dTotalAmount);
                    decimal.TryParse(cmd.Parameters["@Totalrefund"].Value.ToString(), out dTotalRefund);
                    decimal.TryParse(cmd.Parameters["@TotalCancelledAmt"].Value.ToString(), out dTotalCancelledAmount);
                    decimal.TryParse(cmd.Parameters["@DoctorsAmount"].Value.ToString(), out drAmount);
                    decimal.TryParse(cmd.Parameters["@OthersAmount"].Value.ToString(), out othersAmount);
                    decimal.TryParse(cmd.Parameters["@TotalIncAmount"].Value.ToString(), out TotalIncAmount);
                    decimal.TryParse(cmd.Parameters["@TotalPendingSettAmt"].Value.ToString(), out TotalPendingSettleAmt);
                    sRcvdFromtime = cmd.Parameters["@Rcvdfrom"].Value.ToString();
                    sRcvdTotime = cmd.Parameters["@RcvdTo"].Value.ToString();
                    sMinStartTime = cmd.Parameters["@MinStartTime"].Value.ToString();
                    sMaxEndTime = cmd.Parameters["@MaxEndTime"].Value.ToString();
                    sRefundFromtime = cmd.Parameters["@RefundFrom"].Value.ToString();
                    sRefundTotime = cmd.Parameters["@RefundTo"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetOrgInvestigationsGroupandPKG in Schedule_DAL.cs", ex);
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

        public long GetListOfUsersForCollectionDeno(long OrgId, out List<Users> lstUsersDetails)
        {
            long returnCode = -1;
            lstUsersDetails = new List<Users>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetListOfUsersForCollectionDenoCommand(OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstUsersDetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while  in GetListOfUsersForCollection BillingDAL.cs", ex);
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
    }
}

