using System;
using System.Data;
using System.Configuration;
using System.Web;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using System.Collections.Generic;
using Attune.Podium.Common;


namespace Attune.Solution.BusinessComponent
{
   public class AmountReceived_BL
    {
         ContextDetails globalContextDetails;
        public AmountReceived_BL()
        {

        }
        public AmountReceived_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
       public long GetAmountReceived(long OrgID, DateTime FromDate,DateTime ToDate, out List<AmountReceive> ReceivedDetails)
        {
            ReceivedDetails = new List<AmountReceive>();
            long returnCode = -1;
            try
            {
                AmountReceived_DAL objAmountReceived = new AmountReceived_DAL(globalContextDetails);
                returnCode = objAmountReceived.GetAmountReceived(OrgID, FromDate ,ToDate , out ReceivedDetails);

            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing Get Amount Received Details", excp);
            }

            return returnCode;
        }

       public long GetSumAmountclosureDetails(string GetAll,DateTime FromDate, DateTime ToDate, out List<AmountClosureDetails> AmountClosureDetails)
       {
           AmountClosureDetails = new List<AmountClosureDetails>();
           long returnCode = -1;
           try
           {
               AmountReceived_DAL objAmountReceived = new AmountReceived_DAL(globalContextDetails);
               returnCode = objAmountReceived.GetSumAmountColsureDetails(GetAll, FromDate, ToDate, out AmountClosureDetails);

           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing Get AmountClosureDetails_AmountReceived_BL", excp);
           }

           return returnCode;
       }

       public long UpdateAmountClosureDetails(string GetACDId, decimal TotalAmount, decimal DebitedAmount, DateTime DebitedDate, string Desc, int orgid, int CreateBy, out int GetMaxACDID)
       {
           GetMaxACDID = -1;
           long returnCode = -1;         
           try
           {
               AmountReceived_DAL AmountReceived_DAL = new AmountReceived_DAL(globalContextDetails);
               returnCode = AmountReceived_DAL.UpdateAmountClosureDetails(GetACDId, TotalAmount, DebitedAmount, DebitedDate, Desc, orgid, CreateBy, out GetMaxACDID);
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while executing Update Amount Closure Details_AmountReceived_BL", ex);
           }
           return returnCode;
       }

       public long SaveInsertClosureDptAttachmentDetails(string Fileurl, string fileName, int ReferenceID, string ReferenceType, string FileType, int orgid, int CreateAt)
       {
           long returnCode = -1;
           try
           {
               AmountReceived_DAL AmountReceived_DAL = new AmountReceived_DAL(globalContextDetails);
               returnCode = new AmountReceived_DAL(globalContextDetails).SaveInsertClosureDptAttachmentDetails(Fileurl, fileName, ReferenceID, ReferenceType, FileType, orgid, CreateAt);
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while saving SaveAmountDepositTRFDetails_AmountReceived_BL", ex);
           }
           return returnCode;
       }
       public long GetRecievedUser(long OrgID, int locationid, out List<AmountReceivedDetails> lstAmtRecDetails)
       {
           lstAmtRecDetails = new List<AmountReceivedDetails>();
           long returnCode = -1;
           try
           {
               AmountReceived_DAL objAmountReceived = new AmountReceived_DAL(globalContextDetails);
               returnCode = objAmountReceived.GetRecievedUser(OrgID, locationid, out lstAmtRecDetails);

           }
           catch (Exception excp)
           {
               CLogger.LogError("Error while executing Get Amount Received Details", excp);
           }

           return returnCode;
       }

     

    }
}
