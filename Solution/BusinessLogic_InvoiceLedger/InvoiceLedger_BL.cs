using System;
using System.Collections.Generic;
using Attune.Podium.Common;
using Attune.Podium.BusinessEntities;
using Attune.Podium.BusinessEntities.CustomEntities;
using Attune.Solution.DataAccessLayer_InvoiceLedger;

/*-----------------------------------------------------------------------------------
* Created By  : Kamaraj  & Murali Manohar 
* Created On  : 30th March 2016 

-------------------------------------------------------------------------------------*/

namespace Attune.Solution.BusinessLogic_InvoiceLedger
{
    public class InvoiceLedger_BL
    {
        ContextDetails globalContextDetails;
        public InvoiceLedger_BL()
        {
        }
        public InvoiceLedger_BL(ContextDetails localContextDetails)
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
            try
            {
                returncode = new InvoiceLedger_DAL(globalContextDetails).GetClientInvoiceDetails(PrefixText, CleintID, Orgid,
                    out lstLedgerClient, out lstLedgerInvoice, out lstLedgerInvoiceCredits, out lstLedgerInvoiceDebits,
                    out lstLedgerInvoiceBills);


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetClientNarrationBL", ex);
            }
            return returncode;

        }
        public long SaveCrediMaxOnlinveClientReceipt(long orgid, List<ClientReceipt> lstclientreceipt, List<LedgerInvoiceDetails> lstLedgerInvoiceDetails, out long SuccessCode)
        {
            long lresult = -1;
            SuccessCode = -1;
            try
            {
                InvoiceLedger_DAL objClientreceipt_DAL = new InvoiceLedger_DAL(globalContextDetails);
                lresult = objClientreceipt_DAL.SaveCrediMaxOnlinveClientReceipt(orgid, lstclientreceipt, lstLedgerInvoiceDetails, out SuccessCode);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveClientReceipt ClientLedger_BL  :" + ex.ToString() + ", Inner Exception -", ex.InnerException);
            }

            return lresult;
        }
        public long GetInvoiceClientOutStanding(long ClientId, long Orgid, out List<LedgerInvoiceDetails> lstLedgerInvoiceDetails)
        {
            long returncode = -1;
            lstLedgerInvoiceDetails = new List<LedgerInvoiceDetails>();

            try
            {
                returncode = new InvoiceLedger_DAL(globalContextDetails).GetInvoiceClientOutStanding(ClientId, Orgid, out lstLedgerInvoiceDetails);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetClientInvoiceDetails", ex);
            }
            return returncode;

        }
        public long GetLedgerInvoiceOutstandingInvList(long ClientId, int From, int To, long Orgid, out List<LedgerInvoiceDetails> lstLedgerInvoiceDetails)
        {
            long returncode = -1;
            lstLedgerInvoiceDetails = new List<LedgerInvoiceDetails>();

            try
            {
                returncode = new InvoiceLedger_DAL(globalContextDetails).GetLedgerInvoiceOutstandingInvList(ClientId,From,To, Orgid, out lstLedgerInvoiceDetails);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetClientInvoiceDetails", ex);
            }
            return returncode;

        }

         public long GetInvoiceClientBills(long ClientId, long InvoiceId,long Orgid, out List<LedgerInvoiceDetails> lstLedgerInvoiceDetails)
        {
            long returncode = -1;
            lstLedgerInvoiceDetails = new List<LedgerInvoiceDetails>();

            try
            {
                returncode = new InvoiceLedger_DAL(globalContextDetails).GetInvoiceClientBills(ClientId, InvoiceId, Orgid, out lstLedgerInvoiceDetails);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetClientInvoiceDetails", ex);
            }
            return returncode;

        }
         public long GetInvoiceLedgerClientCurrencyType(long ClientID, long OrgID, out List<LedgerInvoiceDetails> lstLedgerClientCurrencyType)
         {
             long returncode = -1;
             lstLedgerClientCurrencyType = new List<LedgerInvoiceDetails>();

             try
             {
                 returncode = new InvoiceLedger_DAL(globalContextDetails).GetInvoiceLedgerClientCurrencyType(ClientID, OrgID, out lstLedgerClientCurrencyType);

             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error in BL GetInvoiceLedgerClientCurrencyType", ex);
             }
             return returncode;

         }
         public long GetInvoiceClientLedgerClosing(long ClientId, long Orgid, out List<LedgerInvoiceDetails> lstLedgerInvoiceDetails)
         {
             long returncode = -1;
             lstLedgerInvoiceDetails = new List<LedgerInvoiceDetails>();

             try
             {
                 returncode = new InvoiceLedger_DAL(globalContextDetails).GetInvoiceClientLedgerClosing(ClientId, Orgid, out lstLedgerInvoiceDetails);

             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error in BL GetInvoiceClientLedgerClosing", ex);
             }
             return returncode;

         }
         public long GetLedgerInvoiceOutstandingDetails(long ClientId, string MonthID, long Orgid, out List<LedgerInvoiceDetails> lstLedgerInvoiceDetails)
         {
             long returncode = -1;
             lstLedgerInvoiceDetails = new List<LedgerInvoiceDetails>();

             try
             {
                 returncode = new InvoiceLedger_DAL(globalContextDetails).GetLedgerInvoiceOutstandingDetails(ClientId, MonthID, Orgid, out lstLedgerInvoiceDetails);

             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error in BL GetLedgerInvoiceOutstandingDetails", ex);
             }
             return returncode;

         }
         public long SaveAdvancePayment(long orgid, List<LedgerInvoiceDetails> lstLedgerInvoiceDetails, out long SuccessCode)
         {
             long lresult = -1;
             SuccessCode = -1;
             try
             {
                 InvoiceLedger_DAL objClientreceipt_DAL = new InvoiceLedger_DAL(globalContextDetails);
                 lresult = objClientreceipt_DAL.SaveAdvancePayment(orgid, lstLedgerInvoiceDetails, out SuccessCode);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while executing SaveClientReceipt ClientLedger_BL  :" + ex.ToString() + ", Inner Exception -", ex.InnerException);
             }

             return lresult;
         }
         public long getAdvancePaymentRecommendation(int OrgId, string Status, long ClientID, out List<LedgerInvoiceDetails> lstLedgerInvoiceDetails)
         {
             long returncode = -1;
             lstLedgerInvoiceDetails = new List<LedgerInvoiceDetails>();
             try
             {
                 returncode = new InvoiceLedger_DAL(globalContextDetails).getAdvancePaymentRecommendation(OrgId, Status, ClientID, out lstLedgerInvoiceDetails);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while executing getAdvancePaymentRecommendation ClientLedger_BL  :" + ex.ToString() + ", Inner Exception -", ex.InnerException);

             }
             return returncode;
         }
         public long UpdateAdvanceRecommendation(List<LedgerInvoiceDetails> lstLedgerInvoiceDetails)
         {
             long lresult = -1;
             try
             {
                 InvoiceLedger_DAL objInvoiceLedger_DAL = new InvoiceLedger_DAL(globalContextDetails);
                 lresult = objInvoiceLedger_DAL.UpdateAdvanceRecommendation(lstLedgerInvoiceDetails);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while executing UpdateAdvanceRecommendation in InvoiceLedger_DAL  :" + ex.ToString() + ", Inner Exception -", ex.InnerException);
             }

             return lresult;
         }
         public long GetClientAdvanceAmount(long ClientID, long OrgId, out List<LedgerInvoiceDetails> lstLedgerInvoiceDetails)
         {
             long returncode = -1;
             lstLedgerInvoiceDetails = new List<LedgerInvoiceDetails>();
             try
             {
                 returncode = new InvoiceLedger_DAL(globalContextDetails).GetClientAdvanceAmount(ClientID, OrgId, out lstLedgerInvoiceDetails);
             }
             catch (Exception ex)
             {
                 CLogger.LogError("Error while executing GetClientAdvanceAmount ClientLedger_BL  :" + ex.ToString() + ", Inner Exception -", ex.InnerException);

             }
             return returncode;
         }


    }
}
