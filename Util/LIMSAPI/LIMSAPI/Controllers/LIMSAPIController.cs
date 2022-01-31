using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using Attune.Kernel.LISAPI.BL;
using System.IO;
using System.Net.Http.Headers;
using System.Globalization;
using Attune.KernelV2.Utilities;
using Attune.Kernel.LISAPI.BusinessEntities;
using Attune.KernelV2;
using System.Web.Http.Description;
using System.Threading.Tasks;
using MobileAppIntegrationAPI.Models;

namespace MobileAppIntegrationAPI.Controllers
{
   
    public class LIMSAPIController : BaseApiController
    {
        [ResponseType(typeof(OrderStatusDetails))]
        [HttpGet]
        [Route("Api/LIMSAPI/GetTestStatusByVisitNumber")]
        /// <summary>
        /// Get This API will give the Current Status of the Investigation(Test) based on VisitNumber
        /// GET: api/Products
        /// </summary>
       
        public IHttpActionResult GetTestStatusByVisitNumber(int pOrgId, string pVisitNumber)
        {
            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<PatientBaseInfo>  lstPatientBaseInfo = new List<PatientBaseInfo>();
            List<OrderDetailsInfo> lstOrderDetailsInfo = new List<OrderDetailsInfo>();
            OrderStatusDetails lstData = new OrderStatusDetails();
            try
            {
                returnCode = new LISAPI_BL().GetTestStatusByVisitNumber(pOrgId, pVisitNumber, out lstPatientBaseInfo,out lstOrderDetailsInfo);

                if (returnCode != -1)
                {
                    if (lstPatientBaseInfo.Count > 0 && lstPatientBaseInfo != null)
                    {
                        lstData.PatientID = lstPatientBaseInfo[0].PatientID;
                        lstData.Name = lstPatientBaseInfo[0].Name;
                        lstData.Email = lstPatientBaseInfo[0].Email;
                        lstData.TitleName = lstPatientBaseInfo[0].TitleName;
                        lstData.Age = lstPatientBaseInfo[0].Age;
                        lstData.PatientNumber = lstPatientBaseInfo[0].PatientNumber;
                        lstData.PatientType = lstPatientBaseInfo[0].PatientType;
                        lstData.ExternalPatientNumber = lstPatientBaseInfo[0].ExternalPatientNumber;
                        lstData.OrderInfo = lstOrderDetailsInfo;

                    }
                    actionResult = Ok(lstData);
                }
                else
                {
                    actionResult = Ok("Result Not Found");
                }

            }
            catch (Exception excp)
            {
                actionResult = Ok("Error Occured");
            }

            return actionResult;
        }
        [ResponseType(typeof(PaymentTypeInfo))]
        [HttpGet]
        [Route("Api/LIMSAPI/GetPaymentType")]
        public IHttpActionResult GetPaymentType(int pOrgId, int offset = 1, int limit = 50)
        {
            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<PaymentTypeInfo> lstPaymentType = new List<PaymentTypeInfo>();
            List<PaymentTypeInfo> lstPType = new List<PaymentTypeInfo>();
           
            try
            {
                returnCode = new LISAPI_BL().GetPaymentType__LIMSAPI(pOrgId, out lstPaymentType);

                if (returnCode != -1)
                {
                    if (lstPaymentType.Count > 0 && lstPType != null)
                    {
                        lstPType= lstPaymentType;
                       
                     
                        

                    }
                    // Determine the number of records to skip
                    int skip = (offset - 1) * limit;

                    // Get total number of records
                    int total = lstPType.Count();

                    // Select the TestCode based on paging parameters
                    var lstPTypeM = lstPType
                        //  .OrderBy(c => c.Id)
                        .Skip(skip)
                        .Take(limit)
                        .ToList();
                    // Determine page count
                    int pageCount = total > 0
                        ? (int)Math.Ceiling(total / (double)limit)
                        : 0;


                    // Return the list of TestCode
                    //  actionResult = Ok(lstTestM);
                    // Return the list of TestCode
                    return Ok(new
                    {
                        TestCode = lstPTypeM,
                        Paging = new
                        {
                            Total = total,
                            Limit = limit,
                            Offset = offset,
                            Returned = lstPTypeM.Count
                        }
                    });

                 //   actionResult = Ok(lstPTypeM);
                }
                else
                {
                    actionResult = Ok("Result Not Found");
                }

            }
            catch (Exception excp)
            {
                actionResult = Ok("Error Occured");
            }

            return actionResult;
        }


        [ResponseType(typeof(TestMasterInfo))]
        [HttpGet]
        [Route("Api/LIMSAPI/GetTestMaster")]
        public IHttpActionResult GetTestMaster(int pOrgId,string pType, int offset = 1, int limit = 50)
        {
          //  static readonly MemoryCache objCache = new MemoryCache(new MemoryCacheOptions());
            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<TestMasterInfo> lstTestMaster = new List<TestMasterInfo>();
            List<TestMasterInfo> lstTest = new List<TestMasterInfo>();
         
            try
            {
                returnCode = new LISAPI_BL().GetTestMaster__LIMSAPI(pOrgId,pType, out lstTestMaster);

                if (returnCode != -1)
                {
                    if (lstTestMaster.Count > 0 && lstTestMaster != null)
                    {
                        lstTest = lstTestMaster;
                       



                    }

                 
                    //// Determine the number of records to skip
                    //int skip = (offset - 1) * limit;

                    //// Get total number of records
                    //int total = lstTest.Count();

                    //// Select the TestCode based on paging parameters
                    //var lstTestM= lstTest
                    //  //  .OrderBy(c => c.Id)
                    //    .Skip(skip)
                    //    .Take(limit)
                    //    .ToList();
                    //// Determine page count
                    //int pageCount = total > 0
                    //    ? (int)Math.Ceiling(total / (double)limit)
                    //    : 0;


                    //// Return the list of TestCode
                    ////  actionResult = Ok(lstTestM);
                    //// Return the list of TestCode
                    //return Ok(new
                    //{
                    //    TestCode = lstTestM,
                    //    Paging = new
                    //    {
                    //        Total = total,
                    //        Limit = limit,
                    //        Offset = offset,
                    //        Returned = lstTestM.Count
                    //    }
                    //});


                }
                else
                {
                    actionResult = Ok("Result Not Found");
                }

            }
            catch (Exception excp)
            {
                actionResult = Ok("Error Occured");
            }

            return actionResult;
        }

        //static readonly MemoryCache objCache = new MemoryCache(new MemoryCacheOptions());
        //public async Task<PaginatedList<SampleViewModel>> PagingMethod(PaginatedInputModel pagingParams)
        //{
        //    List<SampleViewModel> sampleList = null;

        //    #region [Caching]  
        //    if (objCache.Get("SampleCacheId") != null)
        //    {
        //        sampleList = (List<SampleViewModel>)objCache.Get("SampleCacheId");
        //    }
        //    else
        //    {
        //        sampleList = _context.SampleViewModel.FromSql("usp_AllJobs").ToList();
        //        objCache.Set("SampleCacheId", sampleList, new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromMinutes(10)));
        //    }
        //    #endregion

        //    #region [Filter]  
        //    if (pagingParams != null && pagingParams.FilterParam.Any())
        //    {
        //        sampleList = FilterUtility.Filter<SampleViewModel>.FilteredData(pagingParams.FilterParam, sampleList).ToList() ?? sampleList;
        //    }
        //    #endregion

        //    #region [Sorting]  
        //    if (pagingParams != null && pagingParams.SortingParams.Count() > 0 && Enum.IsDefined(typeof(SortingUtility.SortOrders), pagingParams.SortingParams.Select(x => x.SortOrder)))
        //    {
        //        sampleList = SortingUtility.Sorting<SampleViewModel>.SortData(sampleList, pagingParams.SortingParams).ToList();
        //    }
        //    #endregion

        //    #region [Grouping]  
        //    if (pagingParams != null && pagingParams.GroupingColumns != null && pagingParams.GroupingColumns.Count() > 0)
        //    {
        //        sampleList = SortingUtility.Sorting<SampleViewModel>.GroupingData(sampleList, pagingParams.GroupingColumns).ToList() ?? sampleList;
        //    }
        //    #endregion

        //    #region [Paging]  
        //    return await PaginatedList<SampleViewModel>.CreateAsync(sampleList, pagingParams.PageNumber, pagingParams.PageSize);
        //    #endregion
        //}
    }


}
