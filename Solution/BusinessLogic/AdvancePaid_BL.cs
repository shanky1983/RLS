using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Attune.Podium.BusinessEntities;
using Attune.Solution.DAL;
using Attune.Podium.Common;

namespace Attune.Solution.BusinessComponent
{
   public  class AdvancePaid_BL
    {
         ContextDetails globalContextDetails;
        public AdvancePaid_BL()
        {

        }
        public AdvancePaid_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
       public long GetAdvancePaidDetails(long VisitID, out List<AdvancePaidDetails> PatientList, out decimal dAmount)
       {
           PatientList = new List<AdvancePaidDetails>();
           long returnCode = -1;
           dAmount = 0;
           try
           {
               AdvancePaid_DAL objAdvancePaidDal = new AdvancePaid_DAL(globalContextDetails);
               returnCode = objAdvancePaidDal.GetAdvancePaidDetails(VisitID,out PatientList, out dAmount);
           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing GetAdvancePaidDetails", excp);
           }

           return returnCode;
       }

       /*AB Code For Rolling Advance*/
       public long pGetClientDepositDetailsSummary(List<DespatchMode> lstClientID, int OrgID, out List<CollectionsHistory> lstCDH, out List<AdvanceClientDetails> lstCollectionsHistory, out List<AdvanceClientDetails> lstRefundistory)
       {

           long returnCode = -1;

           lstCDH = new List<CollectionsHistory>();
           lstCollectionsHistory = new List<AdvanceClientDetails>();
           lstRefundistory = new List<AdvanceClientDetails>();

           try
           {
               AdvancePaid_DAL apdDAL = new AdvancePaid_DAL(globalContextDetails);
               returnCode = apdDAL.pGetClientDepositDetailsSummary(lstClientID, OrgID, out lstCDH, out lstCollectionsHistory, out lstRefundistory);
           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing GetClientDepositDetails", excp);
           }
           return returnCode;
       }

       public long pGetClientDepositDetailsSummaryWithDate(List<DespatchMode> lstClientID, int OrgID, string fromDate, string toDate, out List<CollectionsHistory> lstCDH, out List<AdvanceClientDetails> lstCollectionsHistory, out List<AdvanceClientDetails> lstRefundistory)
       {

           long returnCode = -1;

           lstCDH = new List<CollectionsHistory>();
           lstCollectionsHistory = new List<AdvanceClientDetails>();
           lstRefundistory = new List<AdvanceClientDetails>();

           try
           {
               AdvancePaid_DAL apdDAL = new AdvancePaid_DAL(globalContextDetails);
               returnCode = apdDAL.pGetClientDepositDetailsSummaryWithDate(lstClientID, OrgID, fromDate, toDate, out lstCDH, out lstCollectionsHistory, out lstRefundistory);
           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing GetClientDepositDetails", excp);
           }
           return returnCode;
       }

       public long SaveAdvancePaidDetails(long VisitID, long patientID, long createdby, 
                                                decimal dAmount, long pOrgID, 
                                                List<PatientInvestigation> invs,
                                                List<PatientDueChart> pPatientProcedure,
                                                List<DHEBAdder> pPatientIndents, DataTable dtAdvanceReceived,
                                                decimal dserviceCharge, out string sReceiptNo, 
                                                out long IpIntermediateID, out string sPaymentType)
       {
           long returnCode = -1;
           sReceiptNo = "";
           IpIntermediateID = 0;
           sPaymentType = "";
           try
           {
               AdvancePaid_DAL objDl = new AdvancePaid_DAL(globalContextDetails);
               returnCode = objDl.SaveAdvancePaidDetails(VisitID, patientID, 
                   createdby, dAmount, pOrgID,invs,pPatientProcedure,pPatientIndents,   
                   dtAdvanceReceived,dserviceCharge,
                   out sReceiptNo,out IpIntermediateID,out sPaymentType );
           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing SaveAdvancePaid BL", excp);
           }

           return returnCode;
       }

       





       public long saveSurgeryAdvanceDetail(long patientVisitID, long PatientID, 
           long CreatedBy, long pSurgeryBillingID,
           DataTable dtAdvancePaidDetails, decimal dserviceCharge, 
           out string sReceiptNo, out long IpIntermediateID,
           out string sPaymentType)
       {
           sReceiptNo = "";
           IpIntermediateID = 0;
           sPaymentType = "";
           long returnCode = -1;

           AdvancePaid_DAL objDl = new AdvancePaid_DAL(globalContextDetails);
           try
           {
               returnCode = objDl.saveSurgeryAdvanceDetail(patientVisitID, PatientID,
                   CreatedBy, pSurgeryBillingID, dtAdvancePaidDetails, dserviceCharge,
                   out sReceiptNo, out IpIntermediateID, out sPaymentType);
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while executing saveSurgeryAdvanceDetail in IP_BL", ex);
           }
           return returnCode;
       }

       public long SaveCollectedDeposit(long PatientID, int OrgID, long LID, List<PatientDepositHistory> lstPDH, out string ReceiptNo)
       {
           long returnCode = -1;
           ReceiptNo = "-1";
           try
           {
               AdvancePaid_DAL apdDAL = new AdvancePaid_DAL(globalContextDetails);
               returnCode = apdDAL.SaveCollectedDeposit(PatientID, OrgID, LID, lstPDH, out ReceiptNo);
           }
           catch (Exception e)
           {
               CLogger.LogError("Error while executing SaveCollectedDeposit AdvancePaid_BL", e);
           }
           return returnCode;
       }

       
       public long GetPatientDepositDetails(long PatientID, int OrgID, out List<PatientDepositHistory> lstPDH, out decimal TotalDepositAmount, out decimal TotalDepositUsed, out decimal TotalRefundAmount)
       {
           lstPDH = new List<PatientDepositHistory>();
           long returnCode = -1;
           TotalDepositAmount = 0;
           TotalDepositUsed = 0;
           TotalRefundAmount = 0;
           try
           {
               AdvancePaid_DAL apdDAL = new AdvancePaid_DAL(globalContextDetails);
               returnCode = apdDAL.GetPatientDepositDetails(PatientID, OrgID, out lstPDH, out TotalDepositAmount, out TotalDepositUsed, out TotalRefundAmount);
           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing GetPatientDepositDetails", excp);
           }
           return returnCode;
       }

       public long SaveSOIAdvancePaidDetails(long VisitID, long patientID, long createdby,
                                              decimal dAmount, long pOrgID,
                                             out List<AdvancePaidDetails> lstAdvancePaidDetails,
                                              DataTable dtAdvanceReceived,
                                              decimal dserviceCharge, out string sReceiptNo,
                                              out string sPaymentType)
       {
           lstAdvancePaidDetails = new List<AdvancePaidDetails>();
           long returnCode = -1;
           sReceiptNo = "";

           sPaymentType = "";
           try
           {

               AdvancePaid_DAL objDl = new AdvancePaid_DAL(globalContextDetails);

               returnCode = objDl.SaveSOIAdvancePaidDetails(VisitID, patientID,
                   createdby, dAmount, pOrgID, out lstAdvancePaidDetails,
                   dtAdvanceReceived, dserviceCharge,
                   out sReceiptNo, out sPaymentType);
           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing SaveAdvancePaid BL", excp);
           }

           return returnCode;
       }

       public long SaveCollectedClientDeposit(long ClientID, string Ddtype, string CType, string IsRefund, int OrgID, long LID,long PreCollectionID, List<CollectionsHistory> lstCDH, out string ReceiptNo)
       {
           long returnCode = -1;
           ReceiptNo = "-1";
           try
           {
               AdvancePaid_DAL apdDAL = new AdvancePaid_DAL(globalContextDetails);
               returnCode = apdDAL.SaveCollectedClientDeposit(ClientID, Ddtype, CType, IsRefund, OrgID, LID, PreCollectionID, lstCDH, out ReceiptNo);
           }
           catch (Exception e)
           {
               CLogger.LogError("Error while executing SaveCollectedDeposit AdvancePaid_BL", e);
           }
           return returnCode;
       }

       public long GetClientDepositDetails(long ClientID, int OrgID, int pPreCollectionID, out decimal pPreDepositAmount, out List<CollectionsHistory> lstCDH, out decimal TotalDepositAmount, out decimal TotalDepositUsed, out decimal TotalRefundAmount)
       {
           lstCDH = new List<CollectionsHistory>();
           long returnCode = -1;
           TotalDepositAmount = 0;
           TotalDepositUsed = 0;
           TotalRefundAmount = 0;
           pPreDepositAmount = 0;
           //MinimumAmount = 0;
           //PaymentRule = "";
           try
           {
               AdvancePaid_DAL apdDAL = new AdvancePaid_DAL(globalContextDetails);
               returnCode = apdDAL.GetClientDepositDetails(ClientID, OrgID,pPreCollectionID,out pPreDepositAmount, out lstCDH, out TotalDepositAmount, out TotalDepositUsed, out TotalRefundAmount);
           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing GetClientDepositDetails", excp);
           }
           return returnCode;
       }
       //Ab Code
       public long SaveCollectedRefundDeposit(long ClientID, string Ddtype, string CType, string IsRefund, int OrgID, long LID, List<CollectionsHistory> lstCDH, out string ReceiptNo)
       {
           long CodeReturn = -1;
           ReceiptNo = "-1";

           try
           {
               AdvancePaid_DAL apdDAL = new AdvancePaid_DAL(globalContextDetails);
               CodeReturn = apdDAL.SaveCollectedRefundDeposit(ClientID, Ddtype, CType, IsRefund, OrgID, LID, lstCDH, out ReceiptNo);
           }
           catch (Exception e)
           {
               CLogger.LogError("Error while executing SaveCollectedDeposit AdvancePaid_BL", e);
           }
           return CodeReturn;
       }
       public long GetClientRefundDetails(long ClientID, int OrgID, out List<CollectionsHistory> lstCDH, out decimal TotalDepositAmount, out decimal TotalDepositUsed, out decimal TotalRefundAmount)
       {
           lstCDH = new List<CollectionsHistory>();
           long returnCode = -1;
           TotalDepositAmount = 0;
           TotalDepositUsed = 0;
           TotalRefundAmount = 0;
           try
           {
               AdvancePaid_DAL apdDAL = new AdvancePaid_DAL(globalContextDetails);
               returnCode = apdDAL.GetClientRefundDetails(ClientID, OrgID, out lstCDH, out TotalDepositAmount, out TotalDepositUsed, out TotalRefundAmount);
           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing GetClientDepositDetails", excp);
           }
           return returnCode;
       }

    }

}
