using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Attune.Podium.BusinessEntities;
using Attune.Solution.DAL;
using System.Text;
using Attune.Podium.Common;


namespace Attune.Solution.BusinessComponent
{
    [Obsolete]
    public class Payment_BL
    {
         ContextDetails globalContextDetails;
        public Payment_BL()
        {

        }
        public Payment_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        
        public long InsertAmouttobePaid(PatientPayments pPayments)
        {
            long returnCode = -1;
            Payment_DAL paymentDAL = new  Payment_DAL(globalContextDetails);
            returnCode = paymentDAL.InsertAmouttobePaid(pPayments);
            return returnCode;
        }

        public long GetPaymentDetails(long pVisitID,out List<PatientPayments> patPayments)
        {
            long returnCode = -1;
            patPayments = new List<PatientPayments>();
            Payment_DAL payDAL = new  Payment_DAL(globalContextDetails);
            returnCode = payDAL.GetPaymentBalance(pVisitID, out patPayments);
            return returnCode;

        }


        public long InsertAmoutPaid(PatientPayments pPayments)
        {
            long returnCode = -1;
            Payment_DAL paymentDAL = new  Payment_DAL(globalContextDetails);
            returnCode = paymentDAL.InsertAmoutPaid(pPayments);
            return returnCode;
        }
        public long GetBankName(int pOrgID, out List<PaymentBanks> lstBank)
        {
            long returncode = -1;
            lstBank = new List<PaymentBanks>();
            try
            {
                returncode = new  Payment_DAL(globalContextDetails).GetBankName(pOrgID, out lstBank);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Loading GetBankName", ex);
            }
            return returncode;
        }
        public long GetBanks(string pBankName, int OrgID, int pTypeID, string Type, out List<PaymentBanks> lstBanks)
        {
            long returnCode = -1;
            lstBanks = new List<PaymentBanks>();
            try
            {
                returnCode = new  Payment_DAL(globalContextDetails).GetBanks(pBankName, OrgID, pTypeID, Type, out lstBanks);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Payment_BL GetBanks", ex);
            }
            return returnCode;
        }
        public long InsertBanks(List<PaymentBanks> lstBanks, long CreatedBy)
        {
            long returnCode = -1;


            try
            {
                returnCode = new  Payment_DAL(globalContextDetails).InsertBanks(lstBanks, CreatedBy);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveBankMaster InsertBanks_BL", excp);
            }
            return returnCode;
        }
        public long pUpdateBank(long BankID, string BankName, long ModifiedBy, int OrgID)
        {
            long returnCode = -1;
            try
            {
                returnCode = new  Payment_DAL(globalContextDetails).pUpdateBank(BankID, BankName, ModifiedBy, OrgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Executing pUpdateBank in Payment_BL.cs", ex);
            }
            return returnCode;
        }

    }
}
