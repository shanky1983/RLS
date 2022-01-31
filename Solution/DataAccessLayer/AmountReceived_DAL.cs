using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using System.Collections.Generic;
using Attune.Podium.Common;
using System.Data.Common;
using System.Transactions;


namespace Attune.Solution.DAL
{
    public class AmountReceived_DAL
    {
        ContextDetails globalContextDetails;
        public AmountReceived_DAL()
        {

        }
        public AmountReceived_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetAmountReceived(long OrgID, DateTime FromDate,DateTime ToDate, out List<AmountReceive> ReceivedDetails)
        {
            long returnCode = -1;

            SqlCommand cmd = new SqlCommand();
            cmd = Command.pGetAmountReceivedCommand(OrgID, FromDate,ToDate,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            
            ReceivedDetails = new List<AmountReceive>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out ReceivedDetails);
            }
            return returnCode;
        }

        // changed dataset to datareader by Arivalagan.k
        public long GetRecievedUser(long OrgID, int locationid,  out List<AmountReceivedDetails> lstAmtRecDetails)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            lstAmtRecDetails = new List<AmountReceivedDetails>();
            IDataReader dataReader = null;
            try
            {
                cmd = Command.pGetRecievedUserCommand(OrgID, locationid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                     dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstAmtRecDetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetRecievedUser", ex);
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
        public long GetSumAmountColsureDetails(string GetAll, DateTime FromDate, DateTime ToDate, out List<AmountClosureDetails> AmountClosureDetails)
        {
            long returnCode = -1;
            AmountClosureDetails = new List<AmountClosureDetails>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.PGetSumAmountclosureDetailsCommand(GetAll, FromDate, ToDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out AmountClosureDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSumAmountColsureDetails_AmountReceived", ex);
            }
            return returnCode;
        }

        public long UpdateAmountClosureDetails(string GetACDId, decimal TotalAmount, decimal DebitedAmount, DateTime DebitedDate, string Desc, int orgid, int CreateBy, out int GetMaxACDID)
        {
            GetMaxACDID = -1;
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.PUpdateAmountclosureDetailsCommand(GetACDId, TotalAmount, DebitedAmount, DebitedDate, Desc, orgid, CreateBy, out GetMaxACDID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                cmd.Parameters.Add("@retCode", SqlDbType.Int);
                cmd.Parameters["@retCode"].Direction = ParameterDirection.ReturnValue;
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@retCode"].Value);
                    GetMaxACDID = Convert.ToInt32(cmd.Parameters["@GetMaxACDID"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateAmountClosureDetails_AmountReceived_DAL", ex);
            }
            return returnCode;
        }

        public long SaveInsertClosureDptAttachmentDetails(string Fileurl, string fileName, int ReferenceID, string ReferenceType, string FileType, int orgid, int CreateAt)
        {
            long returncode = -1;
            SqlCommand objCommand = Command.PInsertClosureDptAttachmentCommand(Fileurl, fileName, ReferenceID, ReferenceType, FileType, orgid, CreateAt, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            objCommand.Parameters.Add("@Return", SqlDbType.Int);
            objCommand.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(objCommand);

                    returncode = Convert.ToInt64(objCommand.Parameters["@Return"].Value);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing SaveTRFdetails_AmountReceived_DAL", excep);
            }
            return returncode;

        }
      

    }
}
