using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Web.Http.Description;
using Attune.KernelV2;
using LIMSAPI.Models;
using Attune.Kernel.LIMSAPI.BusinessEntities;
using Attune.Kernel.LIMSAPI.BL;
using Newtonsoft.Json;
using System.Globalization;
using LIMSAPI.Utility;


namespace LIMSAPI.Controllers
{
    public class StockManagementController : BaseApiController
    {
        /// <summary>
        /// This API will provide the LIS Inventory Stock Management Details
        /// </summary>


        #region Declaration 
        StockManagementBL objStockManagementBL;
        #endregion

        #region PostStockReceivedItems


        /// <summary>
        /// This API method will be using Inventory Stock received for the Client to Attune. 
        /// </summary>
        /// <param name="StockReceivedModel"></param> StockReceivedModel to be Json type

        [ResponseType(typeof(StockReceivedModel))]
        [Route("Api/StockManagement/PostStockReceivedItems")]
        [HttpPost]
        public IHttpActionResult PostStockReceivedItems(StockReceivedModel objStockReceivedItems)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;         

            string pOrgCode = string.Empty;
            string GRNno = string.Empty;
            List<InventoryItemsBasket> lstSRDitems=new List<InventoryItemsBasket>();
            InventoryItemsBasket objSRDitems = null;
            objStockManagementBL = new StockManagementBL();      
            long returnCode = -1;
           
            try{
            
                

                if (!string.IsNullOrEmpty(objStockReceivedItems.OrgCode))
                {
                    pOrgCode = objStockReceivedItems.OrgCode;
                }
                else
                {

                    return Content(HttpStatusCode.NotAcceptable, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.NotAcceptable, Message = "Request Parameters Value Missing ( OrgCode )  ", Status = "Failure" });
                }

                if (objStockReceivedItems.ReceiptId==0)
                {
                    return Content(HttpStatusCode.NotAcceptable, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.NotAcceptable, Message = "Request Parameters Value Missing ( ReceiptId )  ", Status = "Failure" });
                }

                if (objStockReceivedItems.ReceivedDate.Day == 01 && objStockReceivedItems.ReceivedDate.Month == 01 && objStockReceivedItems.ReceivedDate.Year == 01)
                {
                    return Content(HttpStatusCode.NotAcceptable, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.NotAcceptable, Message = "Request Parameters Value Missing ( ReceivedDate )  ", Status = "Failure" });
                }

                if (string.IsNullOrEmpty(objStockReceivedItems.FromLocation))
                {
                    return Content(HttpStatusCode.NotAcceptable, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.NotAcceptable, Message = "Request Parameters Value Missing ( FromLocation )  ", Status = "Failure" });
                }

                if (string.IsNullOrEmpty(objStockReceivedItems.ToLocation))
                {
                    return Content(HttpStatusCode.NotAcceptable, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.NotAcceptable, Message = "Request Parameters Value Missing ( ToLocation )  ", Status = "Failure" });
                }
                    
 

                foreach (items objSRDitem in objStockReceivedItems.Items)
                {
                    objSRDitems = new InventoryItemsBasket();

                    if (!string.IsNullOrEmpty(objSRDitem.ItemCode))
                    {
                        objSRDitems.ProductCode  = objSRDitem.ItemCode;
                    }
                    else {
                        
                        return Content(HttpStatusCode.NotAcceptable, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.NotAcceptable, Message = "Request Parameters Value Missing ( ItemCode )  ", Status = "Failure" });
                    }
                                     
                    if (objSRDitem.ProductID>0)
                    {
                        objSRDitems.ProductID = objSRDitem.ProductID;
                    }
                    else
                    {
                        return Content(HttpStatusCode.NotAcceptable, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.NotAcceptable, Message = "Request Parameters Value Missing ( ProductID )  ", Status = "Failure" });
                       
                    }

                    if (!string.IsNullOrEmpty(objSRDitem.lotNumber))
                    {
                        objSRDitems.BatchNo = objSRDitem.lotNumber;
                    }
                    else
                    {
                        return Content(HttpStatusCode.NotAcceptable, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.NotAcceptable, Message = "Request Parameters Value Missing ( lotNumber )  ", Status = "Failure" });
                    }

                    if (!string.IsNullOrEmpty(objSRDitem.PurchaseUom))
                    {
                        objSRDitems.RECUnit = objSRDitem.PurchaseUom;
                    }
                    else
                    {
                        return Content(HttpStatusCode.NotAcceptable, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.NotAcceptable, Message = "Request Parameters Value Missing ( PurchaseUom )  ", Status = "Failure" });
                    }

                    if (objSRDitem.PurchaseQuantity>0)
                    {
                        objSRDitems.RECQuantity = Convert.ToDecimal(objSRDitem.PurchaseQuantity);
                    }
                    else
                    {
                        return Content(HttpStatusCode.NotAcceptable, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.NotAcceptable, Message = "Request Parameters Value Missing ( PurchaseQuantity )  ", Status = "Failure" });
                    }

                    if (objSRDitem.Converstionqty > 0)
                    {
                        objSRDitems.InvoiceQty = Convert.ToDecimal(objSRDitem.Converstionqty);
                    }
                    else
                    {
                        return Content(HttpStatusCode.NotAcceptable, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.NotAcceptable, Message = "Request Parameters Value Missing ( Converstionqty )  ", Status = "Failure" });
                    }

                    if (!string.IsNullOrEmpty(objSRDitem.LeastSellingUnit))
                    {
                        objSRDitems.LSUnit = objSRDitem.LeastSellingUnit;
                    }
                    else
                    {
                        return Content(HttpStatusCode.NotAcceptable, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.NotAcceptable, Message = "Request Parameters Value Missing ( LeastSellingUnit )  ", Status = "Failure" });
                    }
                    if (objSRDitem.BaseQuantity>0)
                    {
                        objSRDitems.RcvdLSUQty = Convert.ToDecimal(objSRDitem.BaseQuantity);
                    }
                    else
                    {
                        return Content(HttpStatusCode.NotAcceptable, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.NotAcceptable, Message = "Request Parameters Value Missing ( BaseQuantity )  ", Status = "Failure" });
                    }

                    if (objSRDitem.ExpirationDate.Day == 01 && objSRDitem.ExpirationDate.Month==01 && objSRDitem.ExpirationDate.Year==01)
                    {
                        return Content(HttpStatusCode.NotAcceptable, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.NotAcceptable, Message = "Request Parameters Value Missing ( ExpirationDate )  ", Status = "Failure" });
                    }
                    else
                    {
                        if (objSRDitem.ExpirationDate > DateTime.Now)
                        {
                            objSRDitems.ExpiryDate = objSRDitem.ExpirationDate;
                        }
                        else
                        {
                            return Content(HttpStatusCode.NotAcceptable, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.NotAcceptable, Message = "Request Product is expire. ( "+ objSRDitem.ItemCode+" )  ", Status = "Failure" });
                        }
                    }

                    if (objSRDitem.ManufactureDate.Day == 01 && objSRDitem.ManufactureDate.Month == 01 && objSRDitem.ManufactureDate.Year == 01)
                    {
                        return Content(HttpStatusCode.NotAcceptable, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.NotAcceptable, Message = "Request Parameters Value Missing ( ManufactureDate )  ", Status = "Failure" });
                    }
                    else
                    {
                        objSRDitems.Manufacture = objSRDitem.ManufactureDate;
                    }


                    
                     
                    lstSRDitems.Add(objSRDitems);
        
                }
                returnCode = objStockManagementBL.InsertStockReceivedItems(pOrgCode, objStockReceivedItems.ReceiptId, objStockReceivedItems.ReceivedDate, objStockReceivedItems.FromLocation, objStockReceivedItems.ToLocation, lstSRDitems, out GRNno);

                if (returnCode == -1 || returnCode == 1001)
                {
                    return Content(HttpStatusCode.InternalServerError, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.InternalServerError,Message= "Server Error Occured", Status = "Failure" });
                }
                else
                {
                    return Content(HttpStatusCode.OK, new SucessMessage { HttpStatusCode = HttpStatusCode.OK, Message = "OK", transactionId = GRNno, Status = "Success" });
                         
                }
                    
            }
            catch(Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.InternalServerError, Message = "While Exception Error Occured", Status = "Failure" });
            }
           
        }

        #endregion

        /// <summary>
        /// This API method will be using Inventory Product Integaration. 
        /// </summary>
        /// <remarks>OrgCode is organization code of AttuneLIMS. OrgCode is organization code of AttuneLIMS. OrgCode is the organization code of AttuneLIMS. It has passed to the header  </remarks>


        #region ProductMaster

        [ResponseType(typeof(BookingdetailsInfo))]
        [HttpGet]
        [Route("Api/StockManagement/GetProductIntegarationItems")]
        public IHttpActionResult GetProductIntegarationItems()
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            long returnCode = -1;
            IHttpActionResult actionResult = null;
            objStockManagementBL = new StockManagementBL();
            string pOrgCode = string.Empty;

            ProductsModel objProductsModel = new ProductsModel();
            List<ProductListInfo> lstProductListInfo = new List<ProductListInfo>();

            List<Products> lstProducts = new List<Products>();
            List<Products> DistinctProductsResult = new List<Products>();    

            List<ProductAttribute> lstPA = new List<ProductAttribute>();           
            ProductAttribute objProductAttribute;


            try
            {
                if (headers.Contains("orgcode"))
                {
                    pOrgCode = headers.GetValues("orgcode").First();
                }

                returnCode = objStockManagementBL.GetProductIntegarationItems(pOrgCode,out lstProducts);

                if (returnCode == -1 || returnCode == 1001)
                {
                    actionResult = Content(HttpStatusCode.InternalServerError, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.InternalServerError, Message = "While fetching the data getting an Error.", Status = "Failure" });
                    
                }
                else
                {

                    if (lstProducts.Count > 0)
                    {

                        objProductsModel.OrgCode = lstProducts[0].OrgCode;

                        DistinctProductsResult = lstProducts.GroupBy(P => new { P.ProductID }).Select(S => new Products() { ProductID = S.Key.ProductID }).ToList();


                        for (int i = 0; i < DistinctProductsResult.Count; i++)
                        {

                            var lstProductDetails = (lstProducts.Where(PA => PA.ProductID == DistinctProductsResult[i].ProductID).Select(OPA =>
                                                                    new Products()
                                                                    {
                                                                        ProductCode = OPA.ProductCode,
                                                                        ProductName = OPA.ProductName,
                                                                        ProductID = OPA.ProductID,
                                                                        LeastSellingUnit = OPA.LeastSellingUnit,
                                                                        ManufacturerName = OPA.ManufacturerName,
                                                                        ProductCategoryId = OPA.ProductCategoryId,
                                                                        ProductTypeId = OPA.ProductTypeId,

                                                                        HasExpiryDate = OPA.HasExpiryDate,
                                                                        HasBatchNo = OPA.HasBatchNo,
                                                                        TaxPercent = OPA.TaxPercent,
                                                                        IsLabAnalyser = OPA.IsLabAnalyser,
                                                                        ShelfPeriod = OPA.ShelfPeriod,
                                                                        ShelfPeriodType = OPA.ShelfPeriodType,
                                                                        IsScheduleDrug = OPA.IsScheduleDrug,
                                                                        ScheduleDrugType = OPA.ScheduleDrugType,
                                                                        IsNorcotic = OPA.IsNorcotic,
                                                                        IsConsumable = OPA.IsConsumable,
                                                                        CostPrice = OPA.CostPrice,
                                                                        SellingPrice = OPA.SellingPrice,
                                                                        TestCount = OPA.TestCount,
                                                                        ReorderLevelConsumption = OPA.ReorderLevelConsumption,
                                                                        CreatedAt=OPA.CreatedAt,
                                                                        ModifiedAt=OPA.ModifiedAt

                                                                    })
                                                        ).ToList();
                            objProductAttribute = new ProductAttribute()
                            {
                                HasExpiryDate = lstProductDetails[0].HasExpiryDate,
                                HasBatchNo = lstProductDetails[0].HasBatchNo,
                                TaxPercent = Convert.ToString(lstProductDetails[0].TaxPercent),
                                IsLabAnalyser = lstProductDetails[0].IsLabAnalyser,
                                ShelfPeriod = lstProductDetails[0].ShelfPeriod,
                                ShelfPeriodType = lstProductDetails[0].ShelfPeriodType,
                                IsScheduleDrug = lstProductDetails[0].IsScheduleDrug,
                                ScheduleDrugType = lstProductDetails[0].ScheduleDrugType,
                                IsNorcotic = lstProductDetails[0].IsNorcotic,
                                IsConsumable = lstProductDetails[0].IsConsumable,
                                CostPrice = lstProductDetails[0].CostPrice,
                                SellingPrice = lstProductDetails[0].SellingPrice,
                                TestCount = lstProductDetails[0].TestCount,
                                ReorderLevelConsumption = lstProductDetails[0].ReorderLevelConsumption

                            };




                            lstProductListInfo.Add(new ProductListInfo()
                            {
                                ProductInfo = new ProductInfo()
                                {
                                    ProductCode = lstProductDetails[0].ProductCode,
                                    ProductName = lstProductDetails[0].ProductName,
                                    ProductID = Convert.ToString(lstProductDetails[0].ProductID),
                                    LeastSellingUnit = lstProductDetails[0].LeastSellingUnit,
                                    ManufacturerName = lstProductDetails[0].ManufacturerName,
                                    ProductCategoryId = lstProductDetails[0].ProductCategoryId,
                                    ProductTypeId = lstProductDetails[0].ProductTypeId,
                                    CreatedAt = lstProductDetails[0].CreatedAt.ToUniversalTime(),
                                    UpdatedAt = lstProductDetails[0].ModifiedAt.ToUniversalTime()
                                },
                                ProductAttributeList = objProductAttribute,
                                PurchaseUomList = (lstProducts.Where(POM => POM.ProductID == DistinctProductsResult[i].ProductID).GroupBy(G => new { G.PurchaseUomCode, G.ConvesionQty }).Select(P => new ProductUom() { PurchaseUomCode = P.Key.PurchaseUomCode, ConvesionQty = Convert.ToInt32(P.Key.ConvesionQty) }).ToList())

                            });

                        }
                        objProductsModel.ProductListInfo = lstProductListInfo;
                        actionResult= Ok(objProductsModel);
                    }
                    else
                    {
                        actionResult= Content(HttpStatusCode.NotFound, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.OK, Message = "No Records found", Status = "Success" });
                       
                    }
                }
            }

            catch (Exception ex)
            {
                actionResult= Content(HttpStatusCode.InternalServerError, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.InternalServerError, Message = "While Exception Error Occured", Status = "Failure" });
                
            }
            return actionResult;
        }

        #endregion

        #region StockOut

        /// <summary>
        /// This API method will be using Inventory Stock Out Product Integaration. 
        /// </summary>
        /// <remarks>OrgCode is organization code of AttuneLIMS. OrgCode is organization code of AttuneLIMS. OrgCode is the organization code of AttuneLIMS. It has passed to the header  </remarks>

        [ResponseType(typeof(BookingdetailsInfo))]
        [HttpGet]
        [Route("Api/StockManagement/GetStockOutProductIntegaration")]
        public IHttpActionResult GetStockOutProductIntegaration()
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;
            long returnCode = -1;
            IHttpActionResult actionResult = null;
            objStockManagementBL = new StockManagementBL();
            List<StockOutProductIntegarationDetails> lstStockOut = new List<StockOutProductIntegarationDetails>();
            List<StockOutProductIntegarationDetails> lstSOFD;
            List<StockDetailsList> lstStockOutInteg = new List<StockDetailsList>();
            StockOutModel objStockOutModel = new StockOutModel();
            StockDetails objStockDetails;
            List<StockOutflowDetailList> lstStockOutflowDetailList;


            try
            {
                if (headers.Contains("orgcode"))
                {
                    pOrgCode = headers.GetValues("orgcode").First();
                }

                returnCode = objStockManagementBL.GetStockOutProductIntegaration(pOrgCode, out lstStockOut);
                if (returnCode == -1 || returnCode == 1001)
                {
                    actionResult = Content(HttpStatusCode.InternalServerError, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.InternalServerError, Message = "While fetching the data getting an Error", Status = "Failure" });
                    
                }
                else
                {
                    if (lstStockOut.Count > 0)
                    {
                        objStockOutModel.OrgCode = lstStockOut[0].OrgCode;

                        for (int i = 0; i < lstStockOut.Count; i++)
                        {
                            objStockDetails = new StockDetails()
                            {

                                OrgLocationCode = lstStockOut[i].OrgLocationCode,
                                InventoryLocationName = lstStockOut[i].InventoryLocationName,
                                InventoryLocationCode = lstStockOut[i].InventoryLocationCode,
                                ProductCode = lstStockOut[i].ProductCode,
                                ProductID = lstStockOut[i].ProductID,
                                ProductCategoryId = lstStockOut[i].CategoryID,
                                ProductName = lstStockOut[i].ProductName,
                                OpeningBalance = lstStockOut[i].OpeningBalance,
                                StockInhandQty = lstStockOut[i].StockInhandQty,
                                StockOutQty = lstStockOut[i].StockOutQty,
                                ReceivedUniqueNumber = lstStockOut[i].ReceivedUniqueNumber,

                            };

                            lstStockOutflowDetailList = new List<StockOutflowDetailList>();
                            lstStockOutflowDetailList = lstStockOut.Where(SO => SO.ReceivedUniqueNumber == objStockDetails.ReceivedUniqueNumber && SO.InventoryLocationCode == objStockDetails.InventoryLocationCode && SO.ProductID == objStockDetails.ProductID).Select(S => new StockOutflowDetailList()
                            {
                                StockOutType = S.StockOutType,
                                BatchNo = S.BatchNo,
                                LeastSellingUnit = S.LeastSellingUnit,
                                ExpiryDate = S.ExpiryDate.ToUniversalTime(),
                                Quantity = S.Quantity,
                                CreatedAt = S.CreatedAt.ToUniversalTime(),
                            }).ToList();


                            lstStockOutInteg.Add(new StockDetailsList() { StockDetails = objStockDetails, StockOutflowDetailList = lstStockOutflowDetailList });

                        }

                        objStockOutModel.StockDetailsList = lstStockOutInteg;
                        actionResult = Ok(objStockOutModel);
                    }
                    else {
                        actionResult = Content(HttpStatusCode.OK, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.OK, Message = "No Records Found", Status = "Success" });
              
                    }
                }
            }
            catch (Exception ex)
            {
                actionResult = Content(HttpStatusCode.InternalServerError, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.InternalServerError, Message = "While Exception Error", Status = "Failure" });
              
            }

            return actionResult;
        }


        #endregion

        #region Consumption

        /// <summary>
        /// This API method will be using Inventory Consumption mapping Product. 
        /// </summary>
        /// <remarks>OrgCode is organization code of AttuneLIMS. OrgCode is organization code of AttuneLIMS. OrgCode is the organization code of AttuneLIMS. It has passed to the header  </remarks>

        [ResponseType(typeof(BookingdetailsInfo))]
        [HttpGet]
        [Route("Api/StockManagement/GetConsumptionProductItems")]
        public IHttpActionResult GetConsumptionProductItems()
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            long returnCode = -1;
            IHttpActionResult actionResult = null;
            objStockManagementBL = new StockManagementBL();

            List<DeviceInfo> lstDeviceInfo = new List<DeviceInfo>();
            List<DeviceProductInfoList> lstDeviceProductInfoList = new List<DeviceProductInfoList>();

            List<DeviceInfoDetails> lstDeviceInfoDetails = new List<DeviceInfoDetails>();
            ModelDeviceInfo objDeviceInfo;

            List<ModelDeviceProductInfoList> lstPA = new List<ModelDeviceProductInfoList>();
            List<DeviceInfo> lstDif = new List<DeviceInfo>();

            DeviceInfoModel objDeviceInfoModel = new DeviceInfoModel();


            try
            {
                if (headers.Contains("orgcode"))
                {
                    pOrgCode = headers.GetValues("orgcode").First();
                }

                returnCode = objStockManagementBL.GetConsumptionProductMappingItems(pOrgCode, out lstDeviceInfo, out lstDeviceProductInfoList);

                if (returnCode == -1 || returnCode == 1001)
                {
                    actionResult = Content(HttpStatusCode.InternalServerError, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.InternalServerError, Message = "While fetching the data getting an Error", Status = "Failure" });
                }
                else
                {

                    if (lstDeviceInfo.Count > 0)
                    {
                        objDeviceInfoModel.OrgCode = lstDeviceInfo[0].OrgCode;

                        for (int i = 0; i < lstDeviceInfo.Count; i++)
                        {

                            lstPA = lstDeviceProductInfoList.Where(PA => PA.InvestigationProductMapID == lstDeviceInfo[i].InvestigationProductMapID).Select(S => new ModelDeviceProductInfoList()
                            {
                                ProductName = S.ProductName,
                                ProductCode = S.ProductCode,
                                ProductCategoryId = S.CategoryID,
                                ConsumptionQty = S.ConsumptionQty,
                                UOMCode = S.UOMCode,
                                CalibrationQty = S.CalibrationQty,
                                IsActive = S.IsActive
                               
                            }).ToList();

                            objDeviceInfo = new ModelDeviceInfo()
                            {
                                DeviceCode = lstDeviceInfo[i].DeviceCode,
                                TestCode = lstDeviceInfo[i].TestCode,
                                TestName = lstDeviceInfo[i].TestName,
                                MethodName = lstDeviceInfo[i].MethodName,
                                CreatedAt = lstDeviceInfo[i].CreatedAt.ToUniversalTime(),
                                UpdatedAt = lstDeviceInfo[i].ModifiedAt.ToUniversalTime(),
                            };

                            lstDeviceInfoDetails.Add(new DeviceInfoDetails() { DeviceInfo = objDeviceInfo, DeviceProductInfoList = lstPA });

                        }
                        objDeviceInfoModel.DeviceListInfo = lstDeviceInfoDetails;

                        actionResult = Ok(objDeviceInfoModel);
                    }
                    else
                    {
                        actionResult = Content(HttpStatusCode.OK, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.OK, Message = "No Records Found", Status = "Success" });
                    }
                }

                
            }
            catch (Exception ex)
            {
                actionResult = Content(HttpStatusCode.InternalServerError, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.InternalServerError, Message = "While Exception Error", Status = "Failure" });
            }
            return actionResult;
        }
        #endregion

        #region ConsumptionReport

        /// <summary>
        /// This API method will be using Inventory Consumption Report. 
        /// </summary>
        /// <remarks>OrgCode is organization code of AttuneLIMS. OrgCode is organization code of AttuneLIMS. OrgCode is the organization code of AttuneLIMS. It has passed to the header  </remarks>


        [ResponseType(typeof(BookingdetailsInfo))]
        [HttpGet]
        [Route("Api/StockManagement/GetConsumptionReport")]
        public IHttpActionResult GetConsumptionReport(string LocationCode)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;
            long returnCode = -1;
            IHttpActionResult actionResult = null;
            objStockManagementBL = new StockManagementBL();
            List<ConsumptionReportDetail> lstCRD = new List<ConsumptionReportDetail>();

            ConsumptionDetailListItem objConsumptionDetailList = new ConsumptionDetailListItem();

            List<ConsumptionItemlList> lstConsumptionItemlList = new List<ConsumptionItemlList>();
          
            try
            {
                if (headers.Contains("orgcode"))
                {
                    pOrgCode = headers.GetValues("orgcode").First();
                }

                returnCode = objStockManagementBL.GetConsumptionReport(pOrgCode, LocationCode, out lstCRD);
                
                if (returnCode == -1 || returnCode == 1001)
                {
                    actionResult = Content(HttpStatusCode.InternalServerError, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.InternalServerError, Message = "While fetching the data getting an Error", Status = "Failure" });
                }
                else {

                    if (lstCRD.Count > 0)
                    {
                        objConsumptionDetailList.OrgCode = lstCRD[0].OrgCode;
                        objConsumptionDetailList.OrgLocationCode = lstCRD[0].OrgLocationCode;
                        objConsumptionDetailList.InventoryLocationCode = lstCRD[0].InventoryLocationCode;

                        lstConsumptionItemlList = lstCRD.Select(S => new ConsumptionItemlList()
                        {
                            Barcode = S.Barcode,
                            Name = S.Name,
                            ProductCode = S.ProductCode,
                            DeviceName = S.DeviceName,
                            DeviceCode = S.DeviceCode,
                            TestCount = S.TestCount,
                            DateOpen = S.DateOpen.ToUniversalTime(),
                            DateClose = S.DateClose.ToUniversalTime(),
                            ActualTestsCount = S.ActualTestsCount,
                            Calibration = S.Calibration,
                            QC = S.QC,
                            Rerun = S.Rerun,
                            Others = S.Others,
                            TotalTests = S.TotalTests,
                            Variance = S.Variance,
                            PatientCount = S.PatientCount,
                            CreatedAt=S.CreatedAt.ToUniversalTime(),
                            UpdatedAt = S.ModifiedAt.ToUniversalTime(),
                        }).ToList();

                        objConsumptionDetailList.ConsumptionDetailList = lstConsumptionItemlList;
                    }
                    else {
                        actionResult = Content(HttpStatusCode.OK, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.OK, Message = "No Records Found", Status = "Success" });
                    }

                    actionResult = Ok(objConsumptionDetailList); 
                }               

                
            }
            catch (Exception ex)
            {
                actionResult = Content(HttpStatusCode.InternalServerError, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.InternalServerError, Message = "While Exception Error", Status = "Failure" });
            }

            return actionResult;
        }
        #endregion

        #region GetInventoryLocations
        [ResponseType(typeof(BookingdetailsInfo))]
        [HttpGet]
        [Route("Api/StockManagement/GetInventoryLocations")]
        public IHttpActionResult GetInventoryLocations(string orgcode)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            //string pOrgCode = string.Empty;
            long returnCode = -1;
            IHttpActionResult actionResult = null;
            objStockManagementBL = new StockManagementBL();
            List<InventoryLocation> lstLocations = new List<InventoryLocation>();
       
            try
            {
                //if (headers.Contains("orgcode"))
                //{
                //    pOrgCode = headers.GetValues("orgcode").First();
                //}

                returnCode = objStockManagementBL.GetInventoryLocations(orgcode,  out lstLocations);

                if (returnCode == -1 || returnCode == 1001)
                {
                    actionResult = Content(HttpStatusCode.InternalServerError, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.InternalServerError, Message = "While fetching the data getting an Error", Status = "Failure" });
                }
                else
                {                     
                    actionResult = Ok(lstLocations);
                }


            }
            catch (Exception ex)
            {
                actionResult = Content(HttpStatusCode.InternalServerError, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.InternalServerError, Message = "While Exception Error", Status = "Failure" });
            }

            return actionResult;
        }
        #endregion
    }




}
