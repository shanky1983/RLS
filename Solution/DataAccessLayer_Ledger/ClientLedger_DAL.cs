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

/*-----------------------------------------------------------------------------------
* Created By  : Kamaraj  & Murali Manohar 
* Created On  :21st April 2015

-------------------------------------------------------------------------------------*/
namespace Attune.Solution.DataAccessLayer_Ledger
{
    public class ClientLedger_DAL
    {
        ContextDetails globalContextDetails;

        public ClientLedger_DAL()
        {

        }
        public ClientLedger_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long SaveClientCredit(ClientCredit clientcredit, out long successcode)
        {
            long lresult = -1;
            DataTable DtCredit = UDT_DAL.ConvertToUDT_ClientCredit(clientcredit);
            SqlCommand cmdInsertCredit = Command.pInsertClientCreditCommand(DtCredit, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out successcode);
            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteNonQuery(cmdInsertCredit);
                        successcode = Convert.ToInt64(cmdInsertCredit.Parameters["@SucessCode"].Value);
                    }
                    tranScope.Complete();
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Error while executing SaveClientCredit ClientLegder_DAL. Query: " + cmdInsertCredit.CommandText, ex);
                    tranScope.Dispose();
                }
            }
            return lresult;

        }
        public long SaveClientDebit(ClientDebit clientdebit, out long successcode)
        {

            long lresult = -1;
            DataTable DtDebit = UDT_DAL.ConvertToUDT_ClientDebit(clientdebit);
            SqlCommand cmdInsertDebit = Command.pInsertClientDebitCommand(DtDebit, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out successcode);

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteNonQuery(cmdInsertDebit);
                        successcode = Convert.ToInt64(cmdInsertDebit.Parameters["@SucessCode"].Value);
                    }

                    tranScope.Complete();
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Error while executing SaveClientDebit ClientLegder_DAL. Query: " + cmdInsertDebit.CommandText, ex);
                    tranScope.Dispose();
                }
            }
            return lresult;
        }
        public long getClientNarration(string Type, out List<CreditDebitNarration> lstClientNarration)
        {
            long returncode = -1;
            lstClientNarration = new List<CreditDebitNarration>();
            SqlCommand cmd = Command.pGetClientNarrationCommand(Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstClientNarration);
                }

            }

            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL getInvOrgSampleStatus", ex);
            }
            return returncode;
        }
        public long getClientOutstanding(int OrgID, string ClientCode, out List<ClientOutStanding> lstOustanding)
        {
            long returncode = -1;
            lstOustanding = new List<ClientOutStanding>();

            SqlCommand cmd = Command.pGetClientOutstandingCommand(OrgID, ClientCode);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstOustanding);
                }

            }

            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL getInvOrgSampleStatus", ex);
            }
            return returncode;
        }
        public long getCredirDebitRecommend(int OrgID, string Status, string Type, string ClientCode, out List<ClientCreditDebit> lstCreditDebitRecommend)
        {
            long returncode = -1;
            lstCreditDebitRecommend = new List<ClientCreditDebit>();

            SqlCommand cmd = Command.pGetCreditDebitRecommendationCommand(OrgID, Status, Type, ClientCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstCreditDebitRecommend);
                }

            }

            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL getInvOrgSampleStatus", ex);
            }
            return returncode;
        }
        public long getCreditDebitStaus(int OrgID, string Type, string ClientCode, string Status, DateTime From, DateTime To, out List<ClientCreditDebit> lstCreditDebitStatus)
        {
            long returncode = -1;
            lstCreditDebitStatus = new List<ClientCreditDebit>();

            SqlCommand cmd = Command.pGetCreditDebitStatusCommand(OrgID, Type, ClientCode, Status, From, To);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstCreditDebitStatus);
                }

            }

            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL getCreditDebitStaus", ex);
            }
            return returncode;
        }
        public long UpdateClientRecommendationStatus(List<ClientCreditDebit> lstClientCreditDebit)
        {
            long lresult = -1;
            DataTable DtCreditDebit = UDT_DAL.ConvertToUDT_ClientCreditDebit(lstClientCreditDebit);
            SqlCommand cmdUpdateRecommendation = Command.pUpdateCreditDebitRecommendationCommand(DtCreditDebit, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteNonQuery(cmdUpdateRecommendation);
                    }
                    tranScope.Complete();
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Error while executing UpdateRecommendation ClientLegder_DAL. Query: " + cmdUpdateRecommendation.CommandText, ex);
                    tranScope.Dispose();
                }
            }
            return lresult;

        }
        public long getClientCreditHistory(int OrgID, string ClientCode, out List<ClientCredit> lstCreditOustandingHistory)
        {
            long returncode = -1;
            lstCreditOustandingHistory = new List<ClientCredit>();

            SqlCommand cmd = Command.pGetClientCreditHistoryCommand(OrgID, ClientCode);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstCreditOustandingHistory);
                }

            }

            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetClientCreditHistory", ex);
            }
            return returncode;
        }
        public long getClientDebitHistory(int OrgID, string ClientCode, out List<ClientDebit> lstDebitOustandingHistory)
        {
            long returncode = -1;
            lstDebitOustandingHistory = new List<ClientDebit>();

            SqlCommand cmd = Command.pGetClientDebitHistoryCommand(OrgID, ClientCode);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstDebitOustandingHistory);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetClientDebitHistory", ex);
            }
            return returncode;
        }
        public long getClientBillHistory(int OrgID, string ClientCode, out List<ClientBill> lstBillOustandingHistory)
        {
            long returncode = -1;
            lstBillOustandingHistory = new List<ClientBill>();

            SqlCommand cmd = Command.pGetClientBillHistoryCommand(OrgID, ClientCode);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstBillOustandingHistory);
                }

            }

            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetClientBillHistory", ex);
            }
            return returncode;
        }
        public long getClientReceiptHistory(int OrgID, string ClientCode, out List<ClientReceipt> lstReceiptOustandingHistory)
        {
            long returncode = -1;
            lstReceiptOustandingHistory = new List<ClientReceipt>();

            SqlCommand cmd = Command.pGetClientReceiptHistoryCommand(OrgID, ClientCode);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstReceiptOustandingHistory);
                }

            }

            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetClientReceiptHistory", ex);
            }
            return returncode;
        }
        public long getClientMonthClosing(int OrgID, string ClientCode, DateTime From, DateTime To, out List<ClientOutStanding> lstClosingMonth)
        {
            long returncode = -1;
            lstClosingMonth = new List<ClientOutStanding>();

            SqlCommand cmd = Command.pGetClientLedgerMonthClosingCommand(OrgID, ClientCode, From, To);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstClosingMonth);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetClientLedgerMonthClosing", ex);
            }
            return returncode;

        }
        public long SaveClientReceipt(List<ClientReceipt> lstClientreceipt, out long SuccessCode)
        {

            long lresult = -1;

            DataTable DtReceipt = UDT_DAL.ConvertToUDT_ClientReceipt(lstClientreceipt);
            SqlCommand cmdInsertReceipt = Command.pInsertClientReceiptCommand(DtReceipt, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out SuccessCode);
            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteNonQuery(cmdInsertReceipt);
                        SuccessCode = Convert.ToInt64(cmdInsertReceipt.Parameters["@SuccessCode"].Value);
                    }
                    tranScope.Complete();
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Error while executing SaveClient Receipt ClientLegder_DAL. Query: " + cmdInsertReceipt.CommandText, ex);
                    tranScope.Dispose();
                }
            }
            return lresult;

        }
        public long getReceiptRecommendation(int OrgId, string Status, string ClientCode, out List<ClientReceiptDetail> lstClientReceiptDetail)
        {
            long returncode = -1;
            lstClientReceiptDetail = new List<ClientReceiptDetail>();
            SqlCommand cmd = Command.pGetReceiptRecommendationCommand(OrgId, Status, ClientCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstClientReceiptDetail);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Executing getReceiptRecommendation in ClientLedger_DAL ", ex);
            }
            return returncode;

        }
        public long UpdateClientReceiptRecommendationStatus(List<ClientReceiptDetail> lstClientReceiptDetail)
        {
            long lresult = -1;
            DataTable DtReceiptDetail = UDT_DAL.ConvertToUDT_ClientReceiptDetail(lstClientReceiptDetail);
            SqlCommand cmdUpdateReciptRecommendation = Command.pUpdateReceiptRecommendationCommand(DtReceiptDetail, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteNonQuery(cmdUpdateReciptRecommendation);
                    }
                    tranScope.Complete();
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Error while executing cmdUpdateReciptRecommendation ClientLegder_DAL. Query: " + cmdUpdateReciptRecommendation.CommandText, ex);
                    tranScope.Dispose();
                }
            }
            return lresult;

        }
        public long GetTSPClientCurrentLedgerStatus(int OrgId, string ClientCode, out List<ClientOutStanding> lstTSPClientStatus)
        {
            long returncode = -1;
            lstTSPClientStatus = new List<ClientOutStanding>();
            SqlCommand cmd = Command.pGetTSPClientCurrentLedgerStatusCommand(OrgId, ClientCode);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstTSPClientStatus);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Executing GetTSPClientCurrentLedgerStatus in ClientLedger_DAL ", ex);
            }
            return returncode;

        }
        public long GetTSPClientDetails(int OrgId, long ClientID, out List<TSPClientDetails> lstTSPClientDetails)
        {
            long returncode = -1;
            lstTSPClientDetails = new List<TSPClientDetails>();
            SqlCommand cmd = Command.pGetTSPClientDetailsCommand(OrgId, ClientID);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstTSPClientDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Executing GetTSPClientDetails in ClientLedger_DAL ", ex);
            }
            return returncode;

        }
        public long GetSelectedTSPCreditDebit(int OrgId, string type, long id, out List<TSPClientDetails> lstTSPClientDetails, out List<ClientCreditDebit> lstCreditDebitRecommend)
        {
            long returncode = -1;
            lstTSPClientDetails = new List<TSPClientDetails>();
            lstCreditDebitRecommend = new List<ClientCreditDebit>();
            SqlCommand cmd = Command.pGetSelectedTSPCreditDebitCommand(OrgId, type, id);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0 && ds.Tables[1].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstCreditDebitRecommend);
                    returncode = Utilities.ConvertTo(ds.Tables[1], out lstTSPClientDetails);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Executing GetSelectedTSPCreditDebit in ClientLedger_DAL ", ex);
            }
            return returncode;

        }
        public long GetSelectedTSPReceipt(int OrgId, string type, long id, out List<TSPClientDetails> lstTSPClientDetails, out List<ClientReceiptDetail> lstClientReceipt)
        {
            long returncode = -1;
            lstTSPClientDetails = new List<TSPClientDetails>();
            lstClientReceipt = new List<ClientReceiptDetail>();
            SqlCommand cmd = Command.pGetSelectedTSPCreditDebitCommand(OrgId, type, id);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0 && ds.Tables[1].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstClientReceipt);
                    returncode = Utilities.ConvertTo(ds.Tables[1], out lstTSPClientDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Executing GetSelectedTSPReceipt in ClientLedger_DAL ", ex);
            }
            return returncode;
        }
        public long getReceiptStatus(int OrgID, string ClientCode, string Status, DateTime From, DateTime To, out List<ClientReceiptDetail> lstClientReceiptDetail)
        {
            long returncode = -1;
            lstClientReceiptDetail = new List<ClientReceiptDetail>();

            SqlCommand cmd = Command.pGetReceiptStatusCommand(OrgID, ClientCode, Status, From, To);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstClientReceiptDetail);
                }

            }

            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL getReceiptStaus", ex);
            }
            return returncode;
        }
    }
}

   
