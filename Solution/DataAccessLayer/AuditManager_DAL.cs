using System;
using System.Collections.Generic;
using System.Text;
using Attune.Podium.BusinessEntities;
using System.Data.SqlClient;
using System.Data;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.Common;
using System.ComponentModel;
using System.Reflection;
using System.Transactions;
using System.Collections.Specialized;

namespace Attune.Solution.DAL
{
    public class AuditManager_DAL
    {
        ContextDetails globalContextDetails;
        public AuditManager_DAL()
        {

        }
        public AuditManager_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long InsertAuditTransaction(List<AuditTransactionDetails> lstATD, string CategoryCode, string TypeCode, long LID, int OrgID, int OrgAddressD)
        {
            long returnCode = -1;
            DataTable DataBasket =UDT_DAL.ConvertToAuditTransactionDetails(lstATD);

            try
            {
                SqlCommand cmd = Command.pInsertAuditTransactionCommand(DataBasket, CategoryCode, TypeCode, LID, OrgID, OrgAddressD,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in InsertAuditTransaction", ex);
            }

            return returnCode;
        }
        // changed dataset to datareader by Arivalagan .k
        public long GetAudit_History(long patientID, int OrgID, string Htype, out List<Patient_HIST> lstPatient_HIST)
        {
            long returnCode = -1;
            lstPatient_HIST = new List<Patient_HIST>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetAudit_HistoryCommand(patientID, 0, OrgID, Htype,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPatient_HIST);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAudit_History in Patient Search", ex);
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
        // changed dataset to datareader by Arivalagan.k
        public long GetAudit_History(long patientID, int OrgID, string Htype, out List<Login_HIST> lstLogin_HIST, out List<Users_HIST> lstUsers_HIST)
        {
            long returnCode = -1;
            lstLogin_HIST = new List<Login_HIST>();
            lstUsers_HIST = new List<Users_HIST>();
            int rsCount = 0;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetAudit_HistoryCommand(patientID, 0, OrgID, Htype, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstLogin_HIST);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstUsers_HIST);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAudit_History User Master Details", ex);
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
        // changed dataset to datareader by Arivalagan.k
        public long GetAudit_History(long ProductID,int OrgID, string Htype, out List<Products> lstProducts)
        {
            long returnCode = -1;
            lstProducts = new List<Products>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetAudit_HistoryCommand(ProductID, 0, OrgID, Htype, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstProducts);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAudit_History", ex);
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
        // changed dataset to datareader by Arivalagan .k
        public long GetAudit_History(int SupplierID, int OrgID, string Htype, out List<Suppliers_HIST> lstSuppliers_HIST)
        {
            long returnCode = -1;
            lstSuppliers_HIST = new List<Suppliers_HIST>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetAudit_HistoryCommand(0, SupplierID, OrgID, Htype, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstSuppliers_HIST);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAudit_History", ex);
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
    }
}
