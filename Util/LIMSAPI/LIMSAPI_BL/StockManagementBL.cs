using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Attune.Kernel.LIMSAPI.BusinessEntities;
using Attune.Kernel.LIMSAPI.DAL;
using Attune.Kernel.PlatForm.Utility;

namespace Attune.Kernel.LIMSAPI.BL
{
    public class StockManagementBL
    {
        StockManagementDAL objStockManagementDAL;

        public long InsertStockReceivedItems(string OrgCode, long ReceiptID, DateTime ReceiptDate, string FromLocationCode, string ToLocationCode, List<InventoryItemsBasket> lstSRD,out string GRNno  )
        {
            long returnCode = -1;
            GRNno = string.Empty;
            try
            {
                objStockManagementDAL = new StockManagementDAL();

                returnCode = objStockManagementDAL.InsertStockReceivedItems(OrgCode, ReceiptID, ReceiptDate, FromLocationCode, ToLocationCode, lstSRD, out GRNno);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertStockReceivedItems in StockManagementBL", ex);
            }
            return returnCode;
        }

        public long GetProductIntegarationItems(string pOrgCode, out List<Products> lstProducts)
        {
             objStockManagementDAL = new StockManagementDAL();

             return objStockManagementDAL.GetProductIntegarationItems(pOrgCode, out lstProducts);
            
        }

        public long GetConsumptionProductMappingItems(string pOrgCode, out List<DeviceInfo> lstDeviceInfo, out List<DeviceProductInfoList> lstDeviceProductInfoList)
        {
            objStockManagementDAL = new StockManagementDAL();
            return objStockManagementDAL.GetConsumptionProductMappingItems( pOrgCode, out lstDeviceInfo, out lstDeviceProductInfoList);
        }


        public long GetStockOutProductIntegaration(string pOrgCode, out List<StockOutProductIntegarationDetails> lstSOPID)
        {
            objStockManagementDAL = new StockManagementDAL();
            return objStockManagementDAL.GetStockOutProductIntegaration(pOrgCode, out lstSOPID);
        }


        public long GetConsumptionReport(string pOrgCode, string LocationCode, out List<ConsumptionReportDetail> lstCRD)
        {
            objStockManagementDAL = new StockManagementDAL();
            return objStockManagementDAL.GetConsumptionReport(pOrgCode, LocationCode, out lstCRD);
        }

        public long GetInventoryLocations(string pOrgCode, out List<InventoryLocation> lstlocations)
        {
            objStockManagementDAL = new StockManagementDAL();
            return objStockManagementDAL.GetInventoryLocations(pOrgCode,out lstlocations);
        }
    }
}
