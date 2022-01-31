using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.Common;
using Attune.Podium.BusinessEntities;
using Attune.Solution.DAL;

namespace Attune.Podium.DataAccessLayer
{
    public class TrustedOrgDAL
    {
         ContextDetails globalContextDetails;
        public TrustedOrgDAL()
        {

        }
        public TrustedOrgDAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetTrustedOrgList(int pLoggedOrgID, long pRID, string pType, out List<TrustedOrgDetails> lstTrustedOrgDetails)
        {
            long returnCode = -1;
            lstTrustedOrgDetails = new List<TrustedOrgDetails>(); 
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetTrustedOrgListCommand(pLoggedOrgID, pRID, pType,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.Shared))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTrustedOrgDetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in TrustedOrgDAL", ex);
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

        public long CheckPageAccess(string ActionCode, int ownerOrgID, int patOrgID, out int pCount)
        {
            long returnCode = -1;
            pCount = -1;

            try
            {
                SqlCommand cmd = Command.pCheckPageAccessCommand(ActionCode, ownerOrgID, patOrgID, out pCount,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    pCount = Convert.ToInt32(cmd.Parameters["@pCount"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL CheckPageAccess", ex);
            }
            return returnCode;
        }
        public long CheckActionAccess( DataTable DtLDetail, out int pCount)
        {
            long returnCode = -1;
            pCount = -1;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pCheckActionAccessCommand(DtLDetail, out pCount,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        
                        dataReader.Close();
                    }
                    pCount = Convert.ToInt32(cmd.Parameters["@pCount"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL CheckPageAccess", ex);
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
        public long GetSharingOrgList(int orgID, out List<Organization> lstorgn, out List<Locations> lstloc)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetSharingOrgListCommand(orgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstorgn = new List<Organization>();
            lstloc = new List<Locations>();
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstorgn);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstloc);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSharingOrgList in Inventory_DAL", ex);
            }

            return returnCode;
        }

        public long GetTrustedItemsForMapping(int orgID, DataTable DtLModuleCategory, out List<TrustedItems> lstorgn)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetTrustedItemsForMappingCommand(orgID, DtLModuleCategory,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstorgn = new List<TrustedItems>(); 
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstorgn);
                }               
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSharingOrgList in TrustedOrg_DAL", ex);
            }

            return returnCode;
        }
        public long GetModuleCategory(out List<ModuleCategory> lstorgn)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetModuleCategoryCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstorgn = new List<ModuleCategory>();
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstorgn);
                } 
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSharingOrgList in TrustedOrg_DAL", ex);
            }

            return returnCode;
        }
        public long SaveMappedTrustedItems(int LoggedOrgID, int SharingOrgID, DataTable DtTrustedOrgActions)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pSaveMappedTrustedItemsCommand(DtTrustedOrgActions,LoggedOrgID, SharingOrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing SaveMapTrustedItems TrustedOrg_DAL", ex);
            }
            return returnCode;
        }
        public long GetMappedTrustedItems(int LoggedOrgID, int SharingOrgID, out List<TrustedOrgActions> lstorgn)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetMappedTrustedItemsCommand(LoggedOrgID, SharingOrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstorgn = new List<TrustedOrgActions>();
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstorgn);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSharingOrgList in TrustedOrg_DAL", ex);
            }

            return returnCode;
        }
    }
}
