using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using LIMSAPI_CMD;
using Attune.Kernel.DataAccessEngine;
using Attune.Kernel.PlatForm.Utility;
using Attune.Kernel.LIMSAPI.Cmd;
using Attune.Kernel.LIMSAPI.BusinessEntities;
using Attune.Kernel.LIMSAPI.UDT;
using System.Data;

namespace Attune.Kernel.LIMSAPI.DAL
{
    public class StockManagementDAL
    {
        SqlCommand cmd;

        public long InsertStockReceivedItems(string OrgCode, long ReceiptID, DateTime ReceiptDate, string FromLocationCode, string ToLocationCode, List<InventoryItemsBasket> lstSRD, out string GRNno)
        {
          long returnCode=-1;
          GRNno =string.Empty;
          cmd = new SqlCommand();

          try
          {              
                cmd = LIMSAPI_CMD.pInsertStockReceived_LIMSAPICommand(OrgCode, ReceiptID, ReceiptDate,FromLocationCode, ToLocationCode,out GRNno, LIMSAPI_UDT.ConvertToInventoryItemsMapping(lstSRD));

               // cmd = LIMSAPI_CMD.pInsertStockReceived_LIMSAPICommand(OrgCode, ReceiptID, ReceiptDate, FromLocationCode, ToLocationCode, GRNno, LIMSAPI_UDT.ConvertToInventoryItemsMapping(lstSRD));
              using (DBEngine dbEngine = new DBEngine())
              {
              returnCode = dbEngine.ExecuteNonQuery(cmd);
              GRNno = (string)cmd.Parameters["@outSRDNo"].Value;  
              }


          }
          catch (Exception ex)
          {
              CLogger.LogError("Error in DAL InsertStockReceivedItems in StockManagementDAL", ex);
          }

          return returnCode;

        }

        public long GetProductIntegarationItems(string pOrgCode, out List<Products> lstProducts)
        {
            
            long returnCode = -1;
            lstProducts=null;
          
            DataSet ds = new DataSet();
             cmd = new SqlCommand();

            try {
                
                cmd = LIMSAPI_CMD.pGetProductIntegarationItems_LIMSCommand(pOrgCode);
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables.Count > 0)
                    {                       
                            returnCode = Utilities.ConvertTo(ds.Tables[0], out lstProducts);                          
                    }
                }


            }
            catch(Exception ex){
                CLogger.LogError("Error in DAL GetProductIntegarationItems in StockManagementDAL", ex);
            }
            return returnCode;
        }

        public long GetConsumptionProductMappingItems(string pOrgCode, out List<DeviceInfo> lstDeviceInfo, out List<DeviceProductInfoList> lstDeviceProductInfoList )
        {
            long returnCode = -1;
            lstDeviceInfo = null;
            lstDeviceProductInfoList = null;            
            DataSet ds = new DataSet();
            cmd = new SqlCommand();
            
            try
            {                   

                cmd = LIMSAPI_CMD.PGetConsumptionProductMappingItems_LIMSCommand(pOrgCode);
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables.Count > 0)
                    {  
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeviceInfo);
                       
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstDeviceProductInfoList);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetConsumptionProductMappingItems in StockManagementDAL", ex);
            }
            return returnCode;

        }
      
        public long GetStockOutProductIntegaration(string pOrgCode, out List<StockOutProductIntegarationDetails> lstSOPID)
        {
            long returnCode = -1;           
            lstSOPID = null;
            DataSet ds = new DataSet();
            cmd = new SqlCommand();

            try
            {
                cmd = LIMSAPI_CMD.pGetStockOutProductIntegaration_LIMSCommand(pOrgCode);
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSOPID);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetStockOutProductIntegaration in StockManagementDAL", ex);
            }
            return returnCode;

        }

        public long GetConsumptionReport(string pOrgCode, string LocationCode, out List<ConsumptionReportDetail> lstCRD)
        {
            long returnCode = -1;
            lstCRD = null;
            DataSet ds = new DataSet();
            cmd = new SqlCommand();

            try
            {
                cmd = LIMSAPI_CMD.pGetConsumptionReport_LIMSCommand(LocationCode, pOrgCode);
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCRD);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetConsumptionReport in StockManagementDAL", ex);
            }
            return returnCode;

        }

        public long GetInventoryLocations(string pOrgCode, out List<InventoryLocation> lstlocations)
        {
            long returnCode = -1;
            lstlocations = null;
            DataSet ds = new DataSet();
            cmd = new SqlCommand();

            try
            {
                cmd = LIMSAPI_CMD.pGetLocations_LIMSCommand(pOrgCode);
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstlocations);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetInventoryLocations in StockManagementDAL", ex);
            }
            return returnCode;

        }

    }
}
