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
    public class  SharedInventory_BL
    {
         ContextDetails globalContextDetails;
        public  SharedInventory_BL( )
        {

        }

        public SharedInventory_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long GetInvLocationDetail(int pOrgID, int pOrgAddressID, out List<Locations> lstInvLocation)
        {
            long returnCode = -1;
            lstInvLocation = new List<Locations>();
            SharedInventory_DAL inventoryDAL = new SharedInventory_DAL(globalContextDetails);
            try
            {
                returnCode = inventoryDAL.GetInvLocationDetail(pOrgID, pOrgAddressID, out lstInvLocation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvLocationDetail in SharedInventory_BL", ex);
            }
            return returnCode;
        }
        public long GetUserDetail(long loginID, out List<Users> lstUsers)
        {
            long returnCode = -1;
            lstUsers = new List<Users>();
            SharedInventory_DAL inventoryDAL = new SharedInventory_DAL(globalContextDetails);
            try
            {
                returnCode = inventoryDAL.GetUserDetails(loginID, out lstUsers);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetUserDetail BL", ex);
            }
            return returnCode;
        }

        public long GetListOfUsers(long OrgId, out List<Users> lstUsersDetails)
        {
            long returnCode = -1;
            lstUsersDetails = new List<Users>();
            SharedInventory_DAL inventoryDAL = new SharedInventory_DAL(globalContextDetails);
            try
            {
                returnCode = new SharedInventory_DAL(globalContextDetails).GetListOfUsers(OrgId, out lstUsersDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing.CS", ex);
            }
            return returnCode;
        }
        public long SetDefaultInventoryLocation(long pLoginID, int pLocationID, int pOrgID, int pOrgAddressID)
        {

            long returnCode = -1;
            try
            {
                returnCode = new SharedInventory_DAL(globalContextDetails).SetDefaultInventoryLocation(pLoginID, pLocationID, pOrgID, pOrgAddressID);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SetDefaultInventoryLocation", ex);
            }
            return returnCode;

        }
        public long GetLocationType(out List<LocationType> lstLocationType)
        {
            long returnCode = -1;
            lstLocationType = new List<LocationType>();
            SharedInventory_DAL inventoryDAL = new SharedInventory_DAL(globalContextDetails);
            try
            {
                returnCode = inventoryDAL.GetLocationType(out lstLocationType);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetProductType in SharedInventory_BL", ex);
            }
            return returnCode;
        }
        public long GetProductType(int OrgID, out List<ProductType> lstProductType)
        {
            long returnCode = -1;
            lstProductType = new List<ProductType>();
            SharedInventory_DAL inventoryDAL = new SharedInventory_DAL(globalContextDetails);
            try
            {
                returnCode = inventoryDAL.GetProductType(OrgID, out lstProductType);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetProductType in SharedInventory_BL", ex);
            }
            return returnCode;
        }
        public long SaveInvLocation(List<Locations> lstInvLocation)
        {
            long returnCode = -1;

            try
            {
                returnCode = new SharedInventory_DAL(globalContextDetails).SaveInvLocation(lstInvLocation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Load SaveInventoryLocation in Inventory BL", ex);
            }
            return returnCode;
        }

        public long getOrganizationAddress(int OrgID, int LocationID, out List<Organization> lstOrganization)
        {
            long returnCode = -1;
            lstOrganization = new List<Organization>();
            SharedInventory_DAL inventoryDAL = new SharedInventory_DAL(globalContextDetails);
            try
            {
                returnCode = inventoryDAL.GetOrgAddress(OrgID, LocationID, out lstOrganization);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getOrganizationAddress in Inventory_BL", ex);
            }
            return returnCode;
        }

        public long InvTrustedOrgDetail(int pOrgID, int pOrgAddressID, out List<Organization> lstOrg)
        {
            long returnCode = -1;
            lstOrg = new List<Organization>();
            SharedInventory_DAL inventoryDAL = new SharedInventory_DAL(globalContextDetails);
            try
            {
                returnCode = inventoryDAL.GetInvTrustedOrgDetail(pOrgID, pOrgAddressID, out lstOrg);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvLocationDetail in Inventory_BL", ex);
            }
            return returnCode;
        }

        public long GetAnalyzerProducts(int OrgID, int LocationID, string prefixText, int InventoryLocationID, out List<InvInstrumentMaster> lstInvInstrumentMaster)
        {
            long returnCode = -1;
            lstInvInstrumentMaster = new List<InvInstrumentMaster>();
            SharedInventory_DAL inventoryDAL = new SharedInventory_DAL(globalContextDetails);
            try
            {
                returnCode = inventoryDAL.GetAnalyzerProducts(OrgID, LocationID, prefixText, InventoryLocationID, out lstInvInstrumentMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAnalyzerProducts in Investigation_bl", ex);
            }
            return returnCode;
        }


        public long GetSupplierInvoiceList(int SupplierID, int pOrgID, int LocationID, string Fromdate, string ToDate, string InvoiceNo, string POno, out List<StockReceived> lstStockReceived)
        {
            long returnCode = -1;
            lstStockReceived = new List<StockReceived>();
            SharedInventory_DAL inventoryDAL = new SharedInventory_DAL(globalContextDetails);
            try
            {
                returnCode = inventoryDAL.GetSupplierInvoiceList(SupplierID, pOrgID, LocationID, Fromdate, ToDate, InvoiceNo, POno, out lstStockReceived);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSupplierInvoiceList in Investigation_bl", ex);
            }
            return returnCode;
        }

        public long GetSupplierList(int OrgID, int LocationID, out List<Suppliers> lstSuppliers)
        {
            long returnCode = -1;
            lstSuppliers = new List<Suppliers>();
            SharedInventory_DAL inventoryDAL = new SharedInventory_DAL(globalContextDetails);
            try
            {
                returnCode = inventoryDAL.GetSupplierList(OrgID, LocationID, out lstSuppliers);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSupplierList in Inventory_BL", ex);
            }
            return returnCode;
        }
 public long GetProducts(int OrgID, out List<InvInstrumentMaster> lstInvInstrumentMaster)
        {
            long returnCode = -1;
            lstInvInstrumentMaster = new List<InvInstrumentMaster>();
            SharedInventory_DAL inventoryDAL = new SharedInventory_DAL(globalContextDetails);
            try
            {
                returnCode = inventoryDAL.GetProducts(OrgID, out lstInvInstrumentMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAnalyzerProducts in Investigation_bl", ex);
            }
            return returnCode;
        }

         
    }
}
