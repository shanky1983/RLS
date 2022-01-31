using System;
using System.Collections.Generic;
using System.Text;
using Attune.Podium.BusinessEntities;
using System.Data;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.Common;
using System.Transactions;

namespace Attune.Solution.DAL
{
    public class Payment_DAL
    {
        ContextDetails globalContextDetails;
        public Payment_DAL()
        {

        }
        public Payment_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long InsertAmouttobePaid(PatientPayments pPayments)
        {
            long lResult = -1;
            SqlCommand cmdInsertPayment = new SqlCommand();
            cmdInsertPayment = Command.pInsertPatientPaymentCommand(pPayments.PatientVisitID, pPayments.Amount,pPayments.PatientID, pPayments.CreatedBy,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdInsertPayment.Parameters.Add("@Return", SqlDbType.Int);
            cmdInsertPayment.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            using (DBEngine dbEngine = new DBEngine(true))
            {
                dbEngine.ExecuteTransactionalNonQuery(cmdInsertPayment);
                lResult = Convert.ToInt64(cmdInsertPayment.Parameters["@Return"].Value);               
            }
            return lResult;
        }

        public long GetPaymentBalance(long visitID, out List<PatientPayments> pPayments)
        {
            long lResult = -1;
            SqlCommand cmdGetPayment = new SqlCommand();
            DataSet ds = new DataSet();
            pPayments = new List<PatientPayments>();
            cmdGetPayment = Command.pGetPatientPaymentsCommand(visitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(true))
            {
                dbEngine.ExecuteDataSet(cmdGetPayment, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                Utilities.ConvertTo(ds.Tables[0], out pPayments);
            }

            return lResult;
        }

        public long InsertAmoutPaid(PatientPayments pPayments)
        {
            long lResult = -1;
            SqlCommand cmdInsertPayment = new SqlCommand();
            cmdInsertPayment = Command.pInsertPaymentCommand(pPayments.PatientVisitID, pPayments.Amount, pPayments.PatientID, pPayments.CreatedBy,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdInsertPayment.Parameters.Add("@Return", SqlDbType.Int);
            cmdInsertPayment.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            using (DBEngine dbEngine = new DBEngine(true))
            {
                dbEngine.ExecuteTransactionalNonQuery(cmdInsertPayment);
                lResult = Convert.ToInt64(cmdInsertPayment.Parameters["@Return"].Value);
            }
            return lResult;
        }
        public long GetBankName(int pOrgID, out List<PaymentBanks> lstBank)
        {

            long lresult = -1;
            lstBank = new List<PaymentBanks>();

            SqlCommand cmd = Command.pGetBankNameCommand(pOrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[0], out lstBank);
                    }

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Load Surgery Master(GetSurgeryMaster) DAL" + cmd.CommandText, ex);
            }
            return lresult;

        }
        // changed dataset to datareader by Arivalagan.k
        public long GetBanks(string pBankName,int OrgID,int pTypeID,string Type, out List<PaymentBanks> lstBanks)
        {
            long returnCode = -1;
            lstBanks = new List<PaymentBanks>();
            IDataReader dataReader = null;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    SqlCommand cmd = Command.pGetBanksCommand(pBankName, OrgID, pTypeID, Type,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstBanks);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while exectuing payment_DAL GetBanks()", ex);
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
        
        public long InsertBanks(List<PaymentBanks> lstBanks,long CreatedBy)
        {
            long returnCode = -1;
            DataTable dtBanks = UDT_DAL.ConvertToUDTBanks(lstBanks);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pInsertBanksCommand(dtBanks,CreatedBy,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while save surgeryMaster DAL", ex);
            }
            return returnCode;
        }

        public long pUpdateBank(long BankID, string BankName,long ModifiedBy,int OrgID )
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pUpdateBankCommand(BankID, BankName,ModifiedBy,OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@return", SqlDbType.Int);
            cmd.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            try
            {

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt16(cmd.Parameters["@return"].Value.ToString());
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Update Bank Payment_DAL.cs", ex);
            }
            return returnCode;
        }
    }
}
