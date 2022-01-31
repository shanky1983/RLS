using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using System.Collections.Generic;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;
using System.Transactions;

namespace Attune.Solution.DAL
{
    public class SharedInventory_DAL
    {
        ContextDetails globalContextDetails;
        public SharedInventory_DAL()
        {

        }
        public SharedInventory_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long GetInvLocationDetail(int pOrgID, int pOrgAddressID, out List<Locations> lstInvLocation)
        {
            long returnCode = -1;
            lstInvLocation = new List<Locations>();
            SqlCommand cmd = Command.pGetLocationDetailsCommand(pOrgID, pOrgAddressID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvLocation);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvLocationDetail in Inventory_DAL", ex);
            }
            return returnCode;
        }
        public long GetUserDetails(long loginID, out List<Users> lstUserDetail)
        {

            long returnCode = -1;
            lstUserDetail = new List<Users>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetUserDetailCommand(loginID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstUserDetail);
                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading user detail", ex);
            }

            return returnCode;

        }


        public long GetListOfUsers(long OrgId, out List<Users> lstUsersDetails)
        {
            long returnCode = -1;
            lstUsersDetails = new List<Users>();

            SqlCommand cmd = Command.pGetListOfUsersByOrgCommand(OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstUsersDetails);
            }
            return returnCode;
        }
        public long SetDefaultInventoryLocation(long pLoginID, int pLocationID, int pOrgID, int pOrgAddressID)
        {
            long returnCode = -1;


            SqlCommand cmd = Command.pSetDefaultInventoryLocationCommand(pLoginID, pLocationID, pOrgID, pOrgAddressID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SetDefaultInventoryLocation in Inventory_DAL", ex);
            }
            return returnCode;

        }
        public long GetLocationType(out List<LocationType> lstLocationType)
        {
            long returnCode = -1;
            lstLocationType = new List<LocationType>();
            SqlCommand cmd = Command.pGetLocationTypeCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstLocationType);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetProductCategories in Inventory_DAL", ex);
            }
            return returnCode;
        }
        public long GetProductType(int OrgID, out List<ProductType> lstProductType)
        {
            long returnCode = -1;
            lstProductType = new List<ProductType>();
            SqlCommand cmd = Command.pGetProductTypeCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstProductType);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetProductCategories in Inventory_DAL", ex);
            }
            return returnCode;
        }
        public long SaveInvLocation(List<Locations> lstInvLocation)
        {
            long returnCode = -1;
            DataTable DtLocationsDataList = UDT_DAL.ConvertToUDTInventoryLocations(lstInvLocation);
            
            SqlCommand cmd = Command.pInsertLocationCommand(DtLocationsDataList,DtLocationsDataList,  UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveInvLocation in Inventory_DAL", ex);
            }
            return returnCode;
        }
        public long GetOrgAddress(int OrgID, int LocationID, out List<Organization> lstOrganization)
        {
            long returnCode = -1;
            lstOrganization = new List<Organization>();
            SqlCommand cmd = Command.pGetOrgAddressCommand(OrgID, LocationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrganization);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetStockReceivedPODetails in Inventory_DAL", ex);
            }
            return returnCode;

        }

        public long GetInvTrustedOrgDetail(int pOrgID, int pOrgAddressID, out List<Organization> lstOrg)
        {
            long returnCode = -1;
            lstOrg = new List<Organization>();
            SqlCommand cmd = Command.pGetTrustedOrgDetailsCommand(pOrgID, pOrgAddressID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrg);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvLocationDetail in Inventory_DAL", ex);
            }
            return returnCode;
        }


        // changed dataset to datareader by Arivalagan.k
        public long GetAnalyzerProducts(int OrgID, int OrgAddressID, string prefixText, int InventoryLocationID, out List<InvInstrumentMaster> lstInvInstrumentMaster)
        {
            long returnCode = -1;
            lstInvInstrumentMaster = new List<InvInstrumentMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetAnalyserProductsCommand(OrgID, OrgAddressID, prefixText, InventoryLocationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvInstrumentMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAnalyzerProducts in Investigation_dal", ex);
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

        public long GetSupplierInvoiceList(int SupplierID, int pOrgID, int LocationID, string Fromdate, string ToDate, string InvoiceNo, string POno, out List<StockReceived> lstStockReceived)
        {
            long returnCode = -1;
            lstStockReceived = new List<StockReceived>();
            SqlCommand cmd = Command.pGetSupplierInvoiceListCommand(SupplierID, Fromdate, ToDate, InvoiceNo, POno, pOrgID, LocationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstStockReceived);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetStockBilligDetails in Investigation_dal", ex);
            }
            return returnCode;
        }

        public long GetSupplierList(int OrgID, int OrgAddressID, out List<Suppliers> lstSuppliers)
        {
            long returnCode = -1;
            lstSuppliers = new List<Suppliers>();
            DataSet ds = new DataSet();
            SqlCommand objCommand = Command.pGetSupplierListCommand(OrgID, OrgAddressID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSuppliers);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSupplierList in Inventory_DAL", ex);
            }
            return returnCode;
        }
public long GetProducts(int OrgID, out List<InvInstrumentMaster> lstInvInstrumentMaster)
        {
            long returnCode = -1;
            lstInvInstrumentMaster = new List<InvInstrumentMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.PGetProductsCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvInstrumentMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAnalyzerProducts in Investigation_dal", ex);
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
