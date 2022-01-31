using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Attune.Podium.BusinessEntities;
using Attune.Podium.BusinessEntities.CustomEntities;
using Attune.Solution.DataAccessLayer_Ledger;
using Attune.Podium.Common;

namespace Attune.Solution.BusinessLogic_Ledger
{
    public class ClientLedger_BL
    {
        ContextDetails globalContextDetails;
        public ClientLedger_BL()
        {
        }
        public ClientLedger_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;

        }
        public long SaveClientDebit(ClientDebit clientdebit, out long successcode)
        {
            long lresult = -1;
            successcode = -1;
            try
            {
                ClientLedger_DAL objClientDebit_DAL = new ClientLedger_DAL(globalContextDetails);
                lresult = objClientDebit_DAL.SaveClientDebit(clientdebit, out successcode);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveClientDebit ClientLedger_BL  :" + ex.ToString() + ", Inner Exception -", ex.InnerException);
            }
            return lresult;
        }
        public long SaveClientCredit(ClientCredit clientcredit, out long successcode)
        {
            long lresult = -1;
            successcode = -1;
            try
            {

                ClientLedger_DAL objClientCredit_DAL = new ClientLedger_DAL(globalContextDetails);
                lresult = objClientCredit_DAL.SaveClientCredit(clientcredit, out successcode);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveClientCredit ClientLedger_BL :" + ex.ToString() + ", Inner Exception -", ex.InnerException);
            }

            return lresult;
        }
        public long GetNarrationList(string Type, out List<CreditDebitNarration> lstNarrationList)
        {
            long returncode = -1;
            lstNarrationList = new List<CreditDebitNarration>();
            try
            {
                returncode = new ClientLedger_DAL(globalContextDetails).getClientNarration(Type, out lstNarrationList);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetClientNarrationBL", ex);
            }
            return returncode;
        }
        public long GetClientOutstanding(int OrgID, string ClientCode, out List<ClientOutStanding> lstOustanding)
        {
            long returncode = -1;

            lstOustanding = new List<ClientOutStanding>();
            try
            {
                returncode = new ClientLedger_DAL(globalContextDetails).getClientOutstanding(OrgID, ClientCode, out lstOustanding);


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetClientNarrationBL", ex);
            }
            return returncode;

        }
        public long GetCreditDebitRecommend(int OrgID, string Status, string Type, string ClientCode, out List<ClientCreditDebit> lstCreditDebitRecommend)
        {
            long returncode = -1;

            lstCreditDebitRecommend = new List<ClientCreditDebit>();

            try
            {
                returncode = new ClientLedger_DAL(globalContextDetails).getCredirDebitRecommend(OrgID, Status, Type, ClientCode, out lstCreditDebitRecommend);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetCreditDebitNarrationBL", ex);
            }
            return returncode;

        }
        public long GetCreditDebitStatus(int OrgID, string Type, string ClientCode, string Status, DateTime From, DateTime To, out List<ClientCreditDebit> lstCreditDebitStatus)
        {
            long returncode = -1;

            lstCreditDebitStatus = new List<ClientCreditDebit>();

            try
            {
                returncode = new ClientLedger_DAL(globalContextDetails).getCreditDebitStaus(OrgID, Type, ClientCode, Status, From, To, out lstCreditDebitStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetCreditDebitNarrationBL", ex);
            }
            return returncode;

        }
        public long UpdateRecommendationStatus(List<ClientCreditDebit> lstclientcreditdebit)
        {
            long lresult = -1;
            try
            {
                ClientLedger_DAL objClientDebit_DAL = new ClientLedger_DAL(globalContextDetails);
                lresult = objClientDebit_DAL.UpdateClientRecommendationStatus(lstclientcreditdebit);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateRecommendationStatus in ClientLedger_BL  :" + ex.ToString() + ", Inner Exception -", ex.InnerException);
            }

            return lresult;
        }
        public long GetCreditOutstandingHistory(int OrgID, string ClientCode, out List<ClientCredit> lstCreditOustandingHistory)
        {
            long returncode = -1;

            lstCreditOustandingHistory = new List<ClientCredit>();
            try
            {
                returncode = new ClientLedger_DAL(globalContextDetails).getClientCreditHistory(OrgID, ClientCode, out lstCreditOustandingHistory);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetCreditOutstandingHistory", ex);
            }
            return returncode;

        }
        public long GetDebitOutstandingHistory(int OrgID, string ClientCode, out List<ClientDebit> lstDebitOustandingHistory)
        {
            long returncode = -1;

            lstDebitOustandingHistory = new List<ClientDebit>();

            try
            {
                returncode = new ClientLedger_DAL(globalContextDetails).getClientDebitHistory(OrgID, ClientCode, out lstDebitOustandingHistory);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetDebitOutstandingHistory", ex);
            }
            return returncode;

        }
        public long GetBillOutstandingHistory(int OrgID, string ClientCode, out List<ClientBill> lstBillOustandingHistory)
        {
            long returncode = -1;

            lstBillOustandingHistory = new List<ClientBill>();

            try
            {
                returncode = new ClientLedger_DAL(globalContextDetails).getClientBillHistory(OrgID, ClientCode, out lstBillOustandingHistory);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetBillOutstandingHistory", ex);
            }
            return returncode;

        }
        public long GetReceiptOutstandingHistory(int OrgID, string ClientCode, out List<ClientReceipt> lstReceiptOustandingHistory)
        {
            long returncode = -1;

            lstReceiptOustandingHistory = new List<ClientReceipt>();

            try
            {
                returncode = new ClientLedger_DAL(globalContextDetails).getClientReceiptHistory(OrgID, ClientCode, out lstReceiptOustandingHistory);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetReceiptOutstandingHistory", ex);
            }
            return returncode;

        }
        public long GetClientClosingMonth(int OrgID, string ClientCode, DateTime From, DateTime To, out List<ClientOutStanding> lstOustanding)
        {
            long returncode = -1;

            lstOustanding = new List<ClientOutStanding>();

            try
            {
                returncode = new ClientLedger_DAL(globalContextDetails).getClientMonthClosing(OrgID, ClientCode, From, To, out lstOustanding);


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetClientClosingMonthBL", ex);
            }
            return returncode;

        }
        public long SaveClientReceipt(List<ClientReceipt> lstclientreceipt, out long SuccessCode)
        {
            long lresult = -1;
            SuccessCode = -1;
            try
            {
                ClientLedger_DAL objClientreceipt_DAL = new ClientLedger_DAL(globalContextDetails);
                lresult = objClientreceipt_DAL.SaveClientReceipt(lstclientreceipt, out SuccessCode);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveClientReceipt ClientLedger_BL  :" + ex.ToString() + ", Inner Exception -", ex.InnerException);
            }

            return lresult;
        }
        public long getReceiptRecommendation(int OrgId, string Status, string ClientCode, out List<ClientReceiptDetail> lstClientReceiptDetail)
        {
            long returncode = -1;
            lstClientReceiptDetail = new List<ClientReceiptDetail>();
            try
            {
                returncode = new ClientLedger_DAL(globalContextDetails).getReceiptRecommendation(OrgId, Status, ClientCode, out lstClientReceiptDetail);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getReceiptRecommendation ClientLedger_BL  :" + ex.ToString() + ", Inner Exception -", ex.InnerException);

            }
            return returncode;
        }
        public long UpdateClientReceiptRecommendationStatus(List<ClientReceiptDetail> lstClientReceiptDetail)
        {
            long lresult = -1;
            try
            {
                ClientLedger_DAL objClientDebit_DAL = new ClientLedger_DAL(globalContextDetails);
                lresult = objClientDebit_DAL.UpdateClientReceiptRecommendationStatus(lstClientReceiptDetail);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateClientReceiptRecommendationStatus in ClientLedger_BL  :" + ex.ToString() + ", Inner Exception -", ex.InnerException);
            }
            return lresult;
        }
        public long GetTSPClientCurrentLedgerStatus(int OrgId, string ClientCode, out List<ClientOutStanding> lstTSPClientStatus)
        {
            long lresult = -1;
            lstTSPClientStatus = new List<ClientOutStanding>();
            try
            {
                ClientLedger_DAL objClientDebit_DAL = new ClientLedger_DAL(globalContextDetails);
                lresult = objClientDebit_DAL.GetTSPClientCurrentLedgerStatus(OrgId, ClientCode, out lstTSPClientStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateClientReceiptRecommendationStatus in ClientLedger_BL  :" + ex.ToString() + ", Inner Exception -", ex.InnerException);
            }
            return lresult;
        }
        public long GetTSPClientAddress(int OrgId, long ClientID, out  List<TSPClientDetails> lstTSPClientDetails)
        {
            long lresult = -1;
            lstTSPClientDetails = new List<TSPClientDetails>();
            try
            {
                ClientLedger_DAL objClientDebit_DAL = new ClientLedger_DAL(globalContextDetails);
                lresult = objClientDebit_DAL.GetTSPClientDetails(OrgId, ClientID, out lstTSPClientDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateClientReceiptRecommendationStatus in ClientLedger_BL  :" + ex.ToString() + ", Inner Exception -", ex.InnerException);
            }
            return lresult;
        }
        public long GetSelectedTSPCreditDebit(int OrgId, string type, long id, out List<TSPClientDetails> lstTSPClientDetails, out List<ClientCreditDebit> lstCreditDebitRecommend)
        {
            long lresult = -1;
            lstTSPClientDetails = new List<TSPClientDetails>();
            lstCreditDebitRecommend = new List<ClientCreditDebit>();
            try
            {
                ClientLedger_DAL objClientDebit_DAL = new ClientLedger_DAL(globalContextDetails);
                lresult = objClientDebit_DAL.GetSelectedTSPCreditDebit(OrgId, type, id, out lstTSPClientDetails, out lstCreditDebitRecommend);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSelectedTSPCreditDebit in ClientLedger_BL  :" + ex.ToString() + ", Inner Exception -", ex.InnerException);
            }
            return lresult;
        }
        public long GetSelectedTSPReceipt(int OrgId, string type, long id, out List<TSPClientDetails> lstTSPClientDetails, out List<ClientReceiptDetail> lstClientReceipt)
        {
            long lresult = -1;
            lstTSPClientDetails = new List<TSPClientDetails>();
            lstClientReceipt = new List<ClientReceiptDetail>();
            try
            {
                ClientLedger_DAL objClientDebit_DAL = new ClientLedger_DAL(globalContextDetails);
                lresult = objClientDebit_DAL.GetSelectedTSPReceipt(OrgId, type, id, out lstTSPClientDetails, out lstClientReceipt);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSelectedTSPReceipt in in ClientLedger_BL  :" + ex.ToString() + ", Inner Exception -", ex.InnerException);
            }
            return lresult;
        }
        public long GetReceiptStatus(int OrgID, string ClientCode, string Status, DateTime From, DateTime To, out List<ClientReceiptDetail> lstClientReceiptDetail)
        {
            long returncode = -1;

            lstClientReceiptDetail = new List<ClientReceiptDetail>();
            try
            {
                returncode = new ClientLedger_DAL(globalContextDetails).getReceiptStatus(OrgID, ClientCode, Status, From, To, out lstClientReceiptDetail);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetReceiptStatus", ex);
            }
            return returncode;
        }
    }
}
