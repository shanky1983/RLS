using System;
using System.Collections.Generic;
using Attune.Podium.BusinessEntities;
using Attune.Podium.BusinessEntities.CustomEntities;
using System.Data;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.Common;
using System.Data.SqlClient;
using System.Transactions;


/*-----------------------------------------------------------------------------------
* Created By  : Kamaraj  & Murali Manohar 
* Created On  : 30th March 2016

-------------------------------------------------------------------------------------*/
namespace Attune.Solution.DataAccessLayer_InvoiceLedger
{
    public class InvoiceLedger_DAL
    {
        ContextDetails globalContextDetails;

        public InvoiceLedger_DAL()
        {

        }
        public InvoiceLedger_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetClientInvoiceDetails(string PrefixText, long CleintID, long Orgid, out List<LedgerInvoiceDetails> lstLedgerClient,
            out List<LedgerInvoiceDetails> lstLedgerInvoice, out List<LedgerInvoiceDetails> lstLedgerInvoiceCredits,
            out List<LedgerInvoiceDetails> lstLedgerInvoiceDebits, out List<LedgerInvoiceDetails> lstLedgerInvoiceBills)
        {
            long returncode = -1;
            lstLedgerClient = new List<LedgerInvoiceDetails>();
            lstLedgerInvoice = new List<LedgerInvoiceDetails>();
            lstLedgerInvoiceCredits = new List<LedgerInvoiceDetails>();
            lstLedgerInvoiceDebits = new List<LedgerInvoiceDetails>();
            lstLedgerInvoiceBills = new List<LedgerInvoiceDetails>();
            SqlCommand cmd = Command.pGetLedgerInvoiceClientListCommand(PrefixText, CleintID, Orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstLedgerClient);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[1], out lstLedgerInvoice);
                }

                if (ds.Tables[2].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[2], out lstLedgerInvoiceCredits);
                }

                if (ds.Tables[3].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[3], out lstLedgerInvoiceDebits);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[4], out lstLedgerInvoiceBills);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetClientInvoiceDetails", ex);
            }
            return returncode;
        }
        public long SaveCrediMaxOnlinveClientReceipt(long orgid, List<ClientReceipt> lstclientreceipt, List<LedgerInvoiceDetails> lstLedgerInvoiceDetails, out long SuccessCode)
        {

            long lresult = -1;
            DataTable DtReceipt = UDT_DAL.ConvertToUDT_ClientReceipt(lstclientreceipt);
            DataTable DtInvoiceDetails = UDT_DAL.ConvertToUDT_LedgerInvoiceDetails(lstLedgerInvoiceDetails);
            SqlCommand cmdInsertReceipt = Command.pInsertInvoiceLedgerPaymentCommand(orgid, DtReceipt, DtInvoiceDetails, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out SuccessCode);
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
        public long GetInvoiceClientOutStanding(long ClientId, long Orgid, out List<LedgerInvoiceDetails> lstLedgerInvoiceDetails)
        {
            long returncode = -1;
            lstLedgerInvoiceDetails = new List<LedgerInvoiceDetails>();

            SqlCommand cmd = Command.pGetLedgerInvoiceOutstandingClientCommand(ClientId, Orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstLedgerInvoiceDetails);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetInvoiceClientOutStanding", ex);
            }
            return returncode;
        }
        public long GetLedgerInvoiceOutstandingInvList(long ClientId, int From, int To, long Orgid, out List<LedgerInvoiceDetails> lstLedgerInvoiceDetails)
        {
            long returncode = -1;
            lstLedgerInvoiceDetails = new List<LedgerInvoiceDetails>();

            SqlCommand cmd = Command.pGetLedgerInvoiceOutstandingInvListCommand(ClientId, From, To, Orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstLedgerInvoiceDetails);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetInvoiceClientOutStanding", ex);
            }
            return returncode;
        }
        public long GetInvoiceClientBills(long ClientId, long InvoiceId, long Orgid, out List<LedgerInvoiceDetails> lstLedgerInvoiceDetails)
        {
            long returncode = -1;
            lstLedgerInvoiceDetails = new List<LedgerInvoiceDetails>();

            SqlCommand cmd = Command.pGetLedgerInvoiceOutstandingBillsCommand(ClientId, InvoiceId, Orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstLedgerInvoiceDetails);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetInvoiceClientOutStanding", ex);
            }
            return returncode;
        }

        public long GetInvoiceLedgerClientCurrencyType(long ClientID, long OrgID, out List<LedgerInvoiceDetails> lstLedgerClientCurrencyType)
        {
            long returncode = -1;
            lstLedgerClientCurrencyType = new List<LedgerInvoiceDetails>();
            SqlCommand cmd = Command.pGetInvoiceLedgerClientCurrencyTypeCommand(ClientID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstLedgerClientCurrencyType);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetLedgerClientCurrencyType", ex);
            }
            return returncode;
        }
        public long GetInvoiceClientLedgerClosing(long ClientId, long Orgid, out List<LedgerInvoiceDetails> lstLedgerInvoiceDetails)
        {
            long returncode = -1;
            lstLedgerInvoiceDetails = new List<LedgerInvoiceDetails>();

            SqlCommand cmd = Command.pGetInvoiceLedgerClosingDetailsCommand(ClientId, Orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstLedgerInvoiceDetails);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetInvoiceClientOutStanding", ex);
            }
            return returncode;
        }
        public long GetLedgerInvoiceOutstandingDetails(long ClientId, string MonthID, long Orgid, out List<LedgerInvoiceDetails> lstLedgerInvoiceDetails)
        {
            long returncode = -1;
            lstLedgerInvoiceDetails = new List<LedgerInvoiceDetails>();

            SqlCommand cmd = Command.pGetLedgerInvoiceOutstandingDetailsCommand(ClientId, MonthID, Orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstLedgerInvoiceDetails);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetInvoiceClientOutStanding", ex);
            }
            return returncode;
        }
        public long SaveAdvancePayment(long orgid, List<LedgerInvoiceDetails> lstLedgerInvoiceDetails, out long SuccessCode)
        {

            long lresult = -1;
            DataTable DtInvoiceDetails = UDT_DAL.ConvertToUDT_LedgerInvoiceDetails(lstLedgerInvoiceDetails);
            SqlCommand cmdInsertAdvance = Command.pInsertAdvancePaymentCommand(orgid, DtInvoiceDetails, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out SuccessCode);
            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteNonQuery(cmdInsertAdvance);
                        SuccessCode = Convert.ToInt64(cmdInsertAdvance.Parameters["@SuccessCode"].Value);
                    }
                    tranScope.Complete();
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Error while executing SaveAdvancePayment InvoiceClientLegder_DAL. Query: " + cmdInsertAdvance.CommandText, ex);
                    tranScope.Dispose();
                }
            }
            return lresult;

        }
        public long getAdvancePaymentRecommendation(int OrgId, string Status, long ClientID, out List<LedgerInvoiceDetails> lstLedgerInvoiceDetails)
        {
            long returncode = -1;
            lstLedgerInvoiceDetails = new List<LedgerInvoiceDetails>();
            SqlCommand cmd = Command.pGetAdvancePaymentRecommendationCommand(OrgId, Status, ClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstLedgerInvoiceDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Executing getAdvancePaymentRecommendation in InvoiceClientLegder_DAL ", ex);
            }
            return returncode;

        }
        public long UpdateAdvanceRecommendation(List<LedgerInvoiceDetails> lstLedgerInvoiceDetails)
        {
            long lresult = -1;
            DataTable DtLedgerInvoiceDetails = UDT_DAL.ConvertToUDT_LedgerInvoiceDetails(lstLedgerInvoiceDetails);
            SqlCommand cmdUpdateRecommendation = Command.pUpdateAdvanceRecommendationCommand(DtLedgerInvoiceDetails, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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
                    CLogger.LogError("Error while executing UpdateAdvanceRecommendation InvoiceClientLegder_DAL. Query: " + cmdUpdateRecommendation.CommandText, ex);
                    tranScope.Dispose();
                }
            }
            return lresult;

        }
        public long GetClientAdvanceAmount(long ClientID, long OrgId, out List<LedgerInvoiceDetails> lstLedgerInvoiceDetails)
        {
            long returncode = -1;
            lstLedgerInvoiceDetails = new List<LedgerInvoiceDetails>();
            SqlCommand cmd = Command.pGetInvoiceClientAdvanceAmountCommand(ClientID, OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstLedgerInvoiceDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Executing GetClientAdvanceAmount in InvoiceClientLegder_DAL ", ex);
            }
            return returncode;

        }
    }
}

