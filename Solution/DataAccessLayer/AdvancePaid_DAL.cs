using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using System.Collections.Generic;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;

namespace Attune.Solution.DAL
{
    public class AdvancePaid_DAL
    {
        ContextDetails globalContextDetails;
        public AdvancePaid_DAL()
        {

        }
        public AdvancePaid_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetAdvancePaidDetails(long VisitID, out List<AdvancePaidDetails> PatientList, out decimal dAmount)
        {
            long returnCode = -1;
            dAmount = 0;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pGetAdvancePaidDetailsCommand(VisitID, out dAmount,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            PatientList = new List<AdvancePaidDetails>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out PatientList);
                dAmount = Convert.ToDecimal(cmd.Parameters["@Amount"].Value);
            }
            return returnCode;
        }

        

        public long SaveAdvancePaidDetails(long VisitID, long patientID, long createdby, decimal dAmount, long pOrgID, List<PatientInvestigation> invs,
                                                List<PatientDueChart> pPatientProcedure,
                                                List<DHEBAdder> pPatientIndents,
            DataTable dtAdvanceReceived, decimal dserviceCharge, out string sReceiptNo, out long IpIntermediateID, out string sPaymentType)
        {
            long lResult = -1;
            sReceiptNo = "";
            IpIntermediateID = 0;
            sPaymentType = "";
            DataTable pBillingTable = new DataTable();
            pBillingTable = UDT_DAL.ConvertToUDTPatientDueChart(invs, pPatientProcedure, pPatientIndents);
            SqlCommand cmdInsertAdvanceDetail = new SqlCommand();
            cmdInsertAdvanceDetail = Command.pInsertAdvancePaidDetailsCommand(VisitID, patientID, createdby, pOrgID,
									                pBillingTable, dtAdvanceReceived, dserviceCharge,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteDataSet(cmdInsertAdvanceDetail,out ds);
                    if (ds.Tables.Count > 0)
                    {
                        sReceiptNo = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                        Int64.TryParse(ds.Tables[0].Rows[0].ItemArray[1].ToString(), out IpIntermediateID);
                        sPaymentType = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving AdvancePaid. Query: " + cmdInsertAdvanceDetail.CommandText, ex);
            }
            return lResult;
        }
        public long saveSurgeryAdvanceDetail(long patientVisitID, long PatientID, long CreatedBy, long pSurgeryBillingID,
            DataTable dtAdvancePaidDetails, decimal dserviceCharge, out string sReceiptNo,out long IpIntermediateID, 
            out string sPaymentType)
        {
            long returnCode = -1;
              sReceiptNo = "";
            IpIntermediateID = 0;
            sPaymentType = "";
            SqlCommand cmd = Command.psaveSurgeryAdvanceDetailCommand(patientVisitID, PatientID, CreatedBy, pSurgeryBillingID, dtAdvancePaidDetails, dserviceCharge,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
          
            try
            {
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables.Count > 0)
                    {
                        sReceiptNo = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                        Int64.TryParse(ds.Tables[0].Rows[0].ItemArray[1].ToString(), out IpIntermediateID);
                        sPaymentType = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                    }
                }
               
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing saveSurgeryAdvanceDetail in IP_DAL", ex);
            }
            return returnCode;
        }

       
        public long SaveCollectedDeposit(long PatientID, int OrgID, long LID, List<PatientDepositHistory> lstPD, out string ReceiptNo)
        {
            long returnCode = -1;
            ReceiptNo = "-1";
            DataTable DTPDH = UDT_DAL.ConvertToUDTPatientDepositHistory(lstPD);
            SqlCommand cmdPDH = new SqlCommand();
            cmdPDH = Command.pInsertPatientDepositCommand(PatientID, OrgID, LID, DTPDH, out ReceiptNo,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPDH.Parameters.Add("@returnstatus", SqlDbType.Int);
            cmdPDH.Parameters["@returnstatus"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdPDH);
                    returnCode = Convert.ToInt32(cmdPDH.Parameters["@returnstatus"].Value);
                    ReceiptNo = Convert.ToString(cmdPDH.Parameters["@pReceiptNo"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveCollectedDeposit AdvancePaid_DAL", e);
            }
            return returnCode;

        }
        // changed dataset to datareader by Arivalagan.k
        public long GetPatientDepositDetails(long PatientID, int OrgID, out List<PatientDepositHistory> lstPDH, out decimal TotalDepositAmount, out decimal TotalDepositUsed, out decimal TotalRefundAmount)
        {
            lstPDH = new List<PatientDepositHistory>();
            IDataReader dataReader = null;
            long returnCode = -1;
            TotalDepositAmount = 0;
            TotalDepositUsed = 0;
            TotalRefundAmount = 0;
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pGetPatientDepositDetailsCommand(PatientID, OrgID, out TotalDepositAmount, out TotalDepositUsed, out TotalRefundAmount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPDH);
                        dataReader.Close();
                    }
                    TotalDepositAmount = Convert.ToDecimal(cmd.Parameters["@pTotalDepositAmount"].Value);
                    TotalDepositUsed = Convert.ToDecimal(cmd.Parameters["@pTotalDepositUsed"].Value);
                    TotalRefundAmount = Convert.ToDecimal(cmd.Parameters["@pTotalRefundAmount"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetPatientDepositDetails AdvancePaid_DAL", e);
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

        public long SaveSOIAdvancePaidDetails(long VisitID, long patientID, long createdby, decimal dAmount, long pOrgID, out List<AdvancePaidDetails> lstAdvancePaidDetails,
DataTable dtAdvanceReceived, decimal dserviceCharge, out string sReceiptNo, out string sPaymentType)
        {
            long lResult = -1;
            sReceiptNo = "";
            lstAdvancePaidDetails = new List<AdvancePaidDetails>();
            sPaymentType = "";
            SqlCommand cmdInsertAdvanceDetail = new SqlCommand();
            cmdInsertAdvanceDetail = Command.psaveSOIAdvanceDetailCommand(VisitID, patientID, createdby, pOrgID, dtAdvanceReceived, dserviceCharge,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteDataSet(cmdInsertAdvanceDetail, out ds);
                    if (ds.Tables.Count > 0)
                    {
                        sReceiptNo = ds.Tables[0].Rows[0].ItemArray[0].ToString();

                        sPaymentType = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving AdvancePaid. Query: " + cmdInsertAdvanceDetail.CommandText, ex);
            }
            return lResult;
        }

        public long SaveCollectedClientDeposit(long ClientID, string Ddtype, string CType, string IsRefund, int OrgID, long LID,long PreCollectionID, List<CollectionsHistory> lstCD, out string ReceiptNo)
        {
            long returnCode = -1;
            ReceiptNo = "-1";
            DataTable DTCDH = UDT_DAL.ConvertToUDTClientDepositHistory(lstCD);
            SqlCommand cmdCDH = new SqlCommand();
            cmdCDH = Command.pInsertClientDepositCommand(ClientID, Ddtype, CType, IsRefund, OrgID, LID,PreCollectionID, DTCDH, out ReceiptNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdCDH.Parameters.Add("@returnstatus", SqlDbType.Int);
            cmdCDH.Parameters["@returnstatus"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdCDH);
                    returnCode = Convert.ToInt32(cmdCDH.Parameters["@returnstatus"].Value);
                    ReceiptNo = Convert.ToString(cmdCDH.Parameters["@pReceiptNo"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveCollectedClientDeposit AdvancePaid_DAL", e);
            }
            return returnCode;

        }
        //AB Code
        public long pGetClientDepositDetailsSummary(List<DespatchMode> lstClientID, int OrgID, out List<CollectionsHistory> lstCDH, out List<AdvanceClientDetails> lstCollectionsHistory, out List<AdvanceClientDetails> lstRefundistory)
        {

            long returnCode = -1;
            lstCDH = new List<CollectionsHistory>();
            lstCollectionsHistory = new List<AdvanceClientDetails>();
            lstRefundistory = new List<AdvanceClientDetails>();


            SqlCommand cmd = new SqlCommand();
            DataTable Temp = UDT_DAL.ConvertToUDTClientDespatchmode(lstClientID);

            cmd = Command.pGetClientDepositDetailsSummaryCommand(Temp, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCDH);
            }
            if (ds.Tables.Count > 1)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstCollectionsHistory);
            }
            if (ds.Tables.Count > 2)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[2], out lstRefundistory);
            }

            return returnCode;
        }
        public long pGetClientDepositDetailsSummaryWithDate(List<DespatchMode> lstClientID, int OrgID, string fromDate, string toDate, out List<CollectionsHistory> lstCDH, out List<AdvanceClientDetails> lstCollectionsHistory, out List<AdvanceClientDetails> lstRefundistory)
        {

            long returnCode = -1;
            lstCDH = new List<CollectionsHistory>();
            lstCollectionsHistory = new List<AdvanceClientDetails>();
            lstRefundistory = new List<AdvanceClientDetails>();


            SqlCommand cmd = new SqlCommand();
            DataTable Temp = UDT_DAL.ConvertToUDTClientDespatchmode(lstClientID);

            cmd = Command.pGetClientDepositDetailsSummaryWithDateCommand(Temp, OrgID, fromDate, toDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCDH);
            }
            if (ds.Tables.Count > 1)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstCollectionsHistory);
            }
            if (ds.Tables.Count > 2)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[2], out lstRefundistory);
            }

            return returnCode;
        }
        //AB Code
        public long SaveCollectedRefundDeposit(long ClientID, string Ddtype, string CType, string IsRefund, int OrgID, long LID, List<CollectionsHistory> lstCD, out string ReceiptNo)
        {
            long returnCode = -1;
            ReceiptNo = "-1";
            DataTable DTCDH = UDT_DAL.ConvertToUDTClientRefundHistory(lstCD);
            SqlCommand cmdCDH = new SqlCommand();
            cmdCDH = Command.pInsertRefundDepositCommand(ClientID, Ddtype, CType, IsRefund, OrgID, LID, out ReceiptNo, DTCDH,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdCDH.Parameters.Add("@returnstatus", SqlDbType.Int);
            cmdCDH.Parameters["@returnstatus"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    //dbEngine.ExecuteTransactionalNonQuery(cmdCDH);

                    dbEngine.ExecuteNonQuery(cmdCDH);
                    returnCode = Convert.ToInt32(cmdCDH.Parameters["@returnstatus"].Value);
                    ReceiptNo = Convert.ToString(cmdCDH.Parameters["@pReceiptNo"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveCollectedClientDeposit AdvancePaid_DAL", e);
            }
            return returnCode;

        }
        public long GetClientDepositDetails(long ClientID, int OrgID,int pPreCollectionID,out decimal pPreDepositAmount, out List<CollectionsHistory> lstCDH, out decimal TotalDepositAmount, out decimal TotalDepositUsed, out decimal TotalRefundAmount)
        {
            lstCDH = new List<CollectionsHistory>();
            long returnCode = -1;
            TotalDepositAmount = 0;
            TotalDepositUsed = 0;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pGetClientDepositDetailsCommand(ClientID, OrgID, pPreCollectionID, out pPreDepositAmount, out TotalDepositAmount, out TotalDepositUsed, out TotalRefundAmount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCDH);
                TotalDepositAmount = Convert.ToDecimal(cmd.Parameters["@pTotalDepositAmount"].Value);
                TotalDepositUsed = Convert.ToDecimal(cmd.Parameters["@pTotalDepositUsed"].Value);
                TotalRefundAmount = Convert.ToDecimal(cmd.Parameters["@pTotalRefundAmount"].Value);
            }
            pPreDepositAmount = Convert.ToDecimal(cmd.Parameters["@pPreDepositAmount"].Value);
            return returnCode;
        }
        //Ab Code
        public long GetClientRefundDetails(long ClientID, int OrgID, out List<CollectionsHistory> lstCDH, out decimal TotalDepositAmount, out decimal TotalDepositUsed, out decimal TotalRefundAmount)
        {
            lstCDH = new List<CollectionsHistory>();
            long returnCode = -1;
            TotalDepositAmount = 0;
            TotalDepositUsed = 0;

            SqlCommand cmd = new SqlCommand();
            cmd = Command.pGetClientRefundDetailsCommand(ClientID, OrgID, out TotalDepositAmount, out TotalDepositUsed, out TotalRefundAmount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCDH);
                TotalDepositAmount = Convert.ToDecimal(cmd.Parameters["@pTotalDepositAmount"].Value);
                TotalDepositUsed = Convert.ToDecimal(cmd.Parameters["@pTotalDepositUsed"].Value);
                TotalRefundAmount = Convert.ToDecimal(cmd.Parameters["@pTotalRefundAmount"].Value);
            }
            return returnCode;
        }
    }
}
