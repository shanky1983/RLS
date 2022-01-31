using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Attune.Kernel.LIMSAPI.BusinessEntities;
using Attune.KernelV2;
using System.Web.Http.Description;
using LIMSAPI.Utility;
using Attune.Kernel.LIMSAPI.BL;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using Newtonsoft.Json;
using System.Globalization;
using System.Xml.Linq;
using System.Text;
using System.Web;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.Threading;

namespace LIMSAPI.Controllers
{
    public class OrdersController : BaseApiController
    {
        public string TimeZone = string.Empty;
        /// <summary>
        /// This API will provide the list of LIS Orders and Details
        /// </summary>
        /// <param name="pDateRange"></param>
        /// <param name="pPatientNumber"></param>
        /// <param name="pVisitNumber"></param>
        /// <param name="Page"></param>
        /// <param name="Size"></param>
        /// <returns></returns>  
        [ResponseType(typeof(LISOrderDataInfo))]
        [HttpGet]
        [Route("Api/Orders/OrderInformation")]
        public IHttpActionResult GetOrderInformation(DateTime pDateRange, string pPatientNumber, string pVisitNumber, int Page, int Size)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;
            int OrgID = 0, LocationID = 0;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<LISOrderInfo> lstOrderinfo = new List<LISOrderInfo>();
            List<PaymentIn> lstPaymentinfo = new List<PaymentIn>();
            LISOrderDataInfo objOrderData = new LISOrderDataInfo();
            List<Paging> lstPages = new List<Paging>();

            List<LISOrder> lstOrders = new List<LISOrder>();
            List<Payment> lstPayment = null;
            Payment objPayment = null;
            List<OrderDetails> lstOrder = null;
            OrderDetails objOrder = null;

            try
            {
                returnCode = new LIMSAPI_BL().GetOrderInformation(pOrgCode, pDateRange, pPatientNumber, pVisitNumber, Page, Size, out lstOrderinfo, out lstPaymentinfo, out lstPages);

                if (returnCode != -1)
                {
                    if (lstOrderinfo.Count > 0 && lstOrderinfo != null)
                    {
                        for (int i = 0; i < lstOrderinfo.Count; i++)
                        {
                            OrgID = Convert.ToInt32(lstOrderinfo[i].OrgID);
                            LocationID = Convert.ToInt32(lstOrderinfo[i].LocationID);

                            if (lstOrderinfo[i].PatientID > 0 && lstOrderinfo[i].PatientID != 0)
                            {
                                lstPayment = new List<Payment>();
                                lstOrder = new List<OrderDetails>();

                                // Ordered Patient Related
                                if (!lstOrders.Select(n => n.PatientID).Contains(lstOrderinfo[i].PatientID))
                                {
                                    // Order Payment
                                    if (lstPaymentinfo.Count > 0 && lstPaymentinfo != null)
                                    {
                                        foreach (PaymentIn item in lstPaymentinfo)
                                        {
                                            if (lstOrderinfo[i].PatientID == item.PatientID)
                                            {
                                                objPayment = new Payment();
                                                objPayment.PaymentMode = item.PaymentMode;
                                                objPayment.AmtReceived = item.AmtReceived;
                                                objPayment.ChequeorCardNumber = item.ChequeorCardNumber;
                                                objPayment.ReferenceID = item.ReferenceID;
                                                lstPayment.Add(objPayment);
                                            }
                                        }
                                    }

                                    // Order Related
                                    foreach (LISOrderInfo item in lstOrderinfo)
                                    {
                                        if (lstOrderinfo[i].PatientID == item.PatientID)
                                        {
                                            objOrder = new OrderDetails();
                                            objOrder.TestCode = item.TestCode;
                                            objOrder.TestName = item.TestName;
                                            objOrder.Amount = item.Amount;
                                            lstOrder.Add(objOrder);
                                        }
                                    }

                                    lstOrders.Add(new LISOrder()
                                    {
                                        PatientID = lstOrderinfo[i].PatientID,
                                        Salutation = lstOrderinfo[i].Salutation,
                                        Name = lstOrderinfo[i].Name,
                                        Age = lstOrderinfo[i].Age,
                                        DateOfBirth = lstOrderinfo[i].DateOfBirth,
                                        Gender = lstOrderinfo[i].Gender,
                                        PatientAddress = lstOrderinfo[i].PatientAddress,
                                        MobileNumber = lstOrderinfo[i].MobileNumber,
                                        EMailID = lstOrderinfo[i].EMailID,
                                        City = lstOrderinfo[i].City,
                                        State = lstOrderinfo[i].State,
                                        Country = lstOrderinfo[i].Country,
                                        PinCode = lstOrderinfo[i].PinCode,
                                        ClientName = lstOrderinfo[i].ClientName,
                                        ClientCode = lstOrderinfo[i].ClientCode,
                                        RefPhysicianID = lstOrderinfo[i].RefPhysicianID,
                                        RefPhysicianName = lstOrderinfo[i].RefPhysicianName,
                                        HospitalID = lstOrderinfo[i].HospitalID,
                                        HospitalName = lstOrderinfo[i].HospitalName,
                                        ExternalPatientNumber = lstOrderinfo[i].ExternalPatientNumber,
                                        PatientCategory = lstOrderinfo[i].PatientCategory,
                                        VisitType = lstOrderinfo[i].VisitType,
                                        URNType = lstOrderinfo[i].URNType,
                                        URNNumber = lstOrderinfo[i].URNNumber,
                                        Quantity = lstOrderinfo[i].Quantity,
                                        GrossAmount = lstOrderinfo[i].GrossAmount,
                                        DiscountAmount = lstOrderinfo[i].DiscountAmount,
                                        NetAmount = lstOrderinfo[i].NetAmount,
                                        AmountReceived = lstOrderinfo[i].AmountReceived,
                                        DueAmount = lstOrderinfo[i].DueAmount,
                                        PaymentStatus = lstOrderinfo[i].PaymentStatus,
                                        ExternalVisitID = lstOrderinfo[i].ExternalVisitID,
                                        lstOrderDetails = lstOrder,
                                        PaymentInfo = lstPayment
                                    });
                                }
                            }
                        }

                        objOrderData.OrgCode = pOrgCode;
                        objOrderData.OrgID = OrgID;
                        objOrderData.LocationID = LocationID;
                        objOrderData.Type = "OrderInformation";
                        objOrderData.lstOrderinfo = lstOrders;
                        objOrderData.TotalRecords = lstPages[0].TotalRecords;
                        objOrderData.TotalPages = lstPages[0].TotalPages;
                        objOrderData.AllowableRecordCount = lstPages[0].AllowableRecordCount;

                        actionResult = Ok(objOrderData);
                    }
                    else
                    {
                        actionResult = Ok("Result Not Found");
                    }
                }
                else
                {
                    actionResult = Ok("While fetching the data getting an Error.");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }

            return actionResult;
        }

        /// <summary>
        /// This API will give the Current Status of all Order Items along with Patient and VisitInformation based on VisitNumber
        /// </summary>
        /// <param name="pOrgId"></param>
        /// <param name="pVisitNumber"></param>
        /// <param name="pagingparametermodel"></param>
        /// <returns></returns>

        [ResponseType(typeof(OrderStatusDetails))]
        [HttpGet]
        [Route("Api/Orders/TestStatusByVisitNumber")]
        public IHttpActionResult GetTestStatusByVisitNumber(int pOrgId, string pVisitNumber, string pExternalVisitID, [FromUri] PagingParameters pagingparametermodel)
        {
            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<PatientBaseInfo> lstPatientBaseInfo = new List<PatientBaseInfo>();
            List<OrderDetailsInfo> lstOrderDetailsInfo = new List<OrderDetailsInfo>();
            OrderStatusDetails lstData = new OrderStatusDetails();
            try
            {
                returnCode = new LIMSAPI_BL().GetTestStatusByVisitNumber(pOrgId, pVisitNumber, pExternalVisitID, out lstPatientBaseInfo, out lstOrderDetailsInfo);

                if (returnCode != -1)
                {
                    if (lstPatientBaseInfo.Count > 0 && lstPatientBaseInfo != null)
                    {
                        lstData.PatientID = lstPatientBaseInfo[0].PatientID;
                        lstData.Name = lstPatientBaseInfo[0].Name;
                        lstData.Email = lstPatientBaseInfo[0].Email;
                        lstData.Salutation = lstPatientBaseInfo[0].Salutation;
                        lstData.Age = lstPatientBaseInfo[0].Age;
                        lstData.PatientNumber = lstPatientBaseInfo[0].PatientNumber;
                        lstData.PatientType = lstPatientBaseInfo[0].PatientType;
                        lstData.ExternalPatientNumber = lstPatientBaseInfo[0].ExternalPatientNumber;

                        // Returing List of data Collections 
                        lstData.OrderInfo = new PaginatedList<OrderDetailsInfo>().GetData(lstOrderDetailsInfo.AsQueryable(), pagingparametermodel);
                    }

                    actionResult = Ok(lstData);
                }
                else
                {
                    actionResult = Ok("Result Not Found");
                }

            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }

            return actionResult;
        }

        /// <summary>
        /// This API will give the only Current Status of all Order Items based on BookingId Or VisitNumber,
        /// If booking Id is empty it give status based on VisitNumber.
        /// </summary>
        /// <param name="pBookingID">Booking Id generated in Attune LIMS</param>
        /// <param name="pVisitNumber">VisitNumber of the Patient generated in Attune LIMS</param>
        /// <returns></returns>
        [ResponseType(typeof(VisitStatusDetailsInfo))]
        [HttpGet]
        [Route("Api/Orders/GetVisitTestStatus")]
        public IHttpActionResult GetVisitStatus(int pBookingID, string pVisitNumber)
        {
            long returnCode = -1;
            IHttpActionResult actionResult = null;

            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            if (string.IsNullOrEmpty(pVisitNumber))
            {
                pVisitNumber = string.Empty;
            }


            List<VisitstatusInfo> lstPatientInfo = new List<VisitstatusInfo>();

            List<VisitStatusDetailsInfo> lstvisitPatient = new List<VisitStatusDetailsInfo>();
            List<VisitStatus> lstOrderstatus = null;
            VisitStatus objVisitstatus = null;

            try
            {
                returnCode = new LIMSAPI_BL().GetVisitStatus(pOrgCode, pBookingID, pVisitNumber, out lstPatientInfo);

                if (returnCode != -1)
                {
                    if (lstPatientInfo.Count > 0 && lstPatientInfo != null)
                    {
                        for (int i = 0; i < lstPatientInfo.Count(); i++)
                        {
                            lstOrderstatus = new List<VisitStatus>();

                            foreach (VisitstatusInfo item in lstPatientInfo)
                            {
                                objVisitstatus = new VisitStatus();

                                if (lstPatientInfo[i].PatientID == item.PatientID
                                          && lstPatientInfo[i].VisitNumber == item.VisitNumber)
                                {
                                    objVisitstatus.Type = item.Type;
                                    objVisitstatus.TestCode = item.TestCode;
                                    objVisitstatus.TestName = item.TestName;
                                    objVisitstatus.Status = item.Status;
                                    lstOrderstatus.Add(objVisitstatus);
                                }
                            }

                            if (!lstvisitPatient.Select(n => n.VisitNumber).Contains(lstPatientInfo[i].VisitNumber))
                            {
                                lstvisitPatient.Add(new VisitStatusDetailsInfo()
                                {
                                    OrgCode = pOrgCode,
                                    LocationID = lstPatientInfo[i].LocationID,
                                    OrgID = lstPatientInfo[i].OrgID,
                                    Type = "VisitStatus Information",
                                    PatientID = lstPatientInfo[i].PatientID,
                                    VisitNumber = lstPatientInfo[i].VisitNumber,
                                    ExternalPatientID = lstPatientInfo[i].ExternalPatientID,
                                    OrderInfo = lstOrderstatus
                                });
                            }
                        }

                        actionResult = Ok(lstvisitPatient);
                    }
                    else
                    {
                        actionResult = Ok("Result not Found");
                    }
                }
                else
                {
                    actionResult = Ok("While fetching the data getting an Error.");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }

            return actionResult;
        }


        /// <summary>
        /// This API will provide the Test report as PDF stream bytes based on BookingID or VisitNumber.
        /// either BookingID or VisitNumber is mandatory. 
        /// </summary>
        /// <param name="pBookingID">Attune BookingID</param>
        /// <param name="pVisitNumber">VisitNumber of Patient</param>
        /// <returns>success</returns>
        [ResponseType(typeof(Stream))]
        [HttpGet]
        [Route("Api/Orders/GetResultPDF")]
        public HttpResponseMessage GetPatientResultPDF(int pBookingID, string pVisitNumber)
        {
            long returnCode = -1;
            var result = new HttpResponseMessage(HttpStatusCode.OK);

            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            if (string.IsNullOrEmpty(pVisitNumber))
            {
                pVisitNumber = string.Empty;
            }

            List<PatientResultPDF> lstresultPDF = new List<PatientResultPDF>();

            string PathwithfileName = string.Empty;

            try
            {
                returnCode = new LIMSAPI_BL().GetPatientPDFfile(pOrgCode, pBookingID, pVisitNumber, out lstresultPDF);

                if (returnCode != -1)
                {
                    if (lstresultPDF.Count > 0 && lstresultPDF != null)
                    {
                        var fileName = Path.GetFileName(lstresultPDF[0].FilePathName);
                        PathwithfileName = lstresultPDF[0].FilePathName.Replace("/", "\\");

                        byte[] filepathByte = null;

                        if (File.Exists(PathwithfileName))
                        {
                            filepathByte = File.ReadAllBytes(PathwithfileName);
                        }

                        if (filepathByte != null && filepathByte.Length > 0)
                        {
                            MemoryStream memoryStream = new MemoryStream(filepathByte);
                            result.Content = new StreamContent(memoryStream);
                            result.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
                            result.Content.Headers.ContentDisposition.FileName = fileName;
                            result.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
                        }
                        else
                        {
                            result = new HttpResponseMessage(HttpStatusCode.NoContent);
                        }
                    }
                    else
                    {
                        result = new HttpResponseMessage(HttpStatusCode.NotFound);
                    }
                }
                else
                {
                    result = new HttpResponseMessage(HttpStatusCode.NotFound);
                }
            }
            catch (Exception ex)
            {
                result = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }

            return result;
        }
        /// <summary>
        /// This API will provide the Order Result and the parameter values based on BookingID or VisitNumber generated in AttuneLIMS.
        /// VisitNumber is mandatory for the visit if booking is not available for the particular Orders
        /// </summary>
        /// <param name="pBookingID">BookingID of AttuneLIMS</param>
        /// <param name="pVisitNumber">VisitNumber of AttuneLIMS</param>
        /// <returns></returns>
        [ResponseType(typeof(PatientResultDataInfo))]
        [HttpGet]
        [Route("Api/Orders/GetOrderResults")]
        public IHttpActionResult GetPatientResult(int pBookingID, string pVisitNumber)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<PatientResultInfo> lstPatientResult = new List<PatientResultInfo>();
            List<PatientResultDetails> lstOrder = null;
            PatientResultDataInfo PatientResultData = new PatientResultDataInfo();
            PatientResultDetails objOrder = null;
            try
            {
                returnCode = new LIMSAPI_BL().GetPatientResult(pOrgCode, pBookingID, pVisitNumber, out lstPatientResult);

                if (returnCode != -1)
                {
                    if (lstPatientResult.Count > 0 && lstPatientResult != null)
                    {
                        for (int i = 0; i < lstPatientResult.Count; i++)
                        {
                            if (lstPatientResult[i].PatientId > 0 && lstPatientResult[i].PatientId != 0)
                            {
                                lstOrder = new List<PatientResultDetails>();
                                foreach (PatientResultInfo item in lstPatientResult)
                                {
                                    objOrder = new PatientResultDetails();
                                    if (lstPatientResult[i].PatientId == item.PatientId)
                                    {
                                        objOrder.TestCode = item.TestCode;
                                        objOrder.TestName = item.TestName;
                                        objOrder.ParameterCode = item.ParameterCode;
                                        objOrder.ParameterName = item.ParameterName;
                                        objOrder.PackageName = item.PackageName;
                                        objOrder.ResultType = item.ResultType;
                                        objOrder.ResultValue = item.ResultValue;
                                        objOrder.ReferenceRange = item.ReferenceRange;
                                        objOrder.IsAbnormal = item.IsAbnormal;
                                        objOrder.IsCritical = item.IsCritical;
                                        objOrder.Status = item.Status;
                                        objOrder.ApprovedBy = item.ApprovedBy;
                                        objOrder.ApprovedDateTime = item.ApprovedDateTime;
                                        lstOrder.Add(objOrder);
                                    }
                                }
                            }
                        }

                        PatientResultData.OrgCode = pOrgCode;
                        PatientResultData.OrgID = lstPatientResult[0].OrgID;
                        PatientResultData.LocationID = lstPatientResult[0].LocationID;
                        PatientResultData.Type = lstPatientResult[0].Type;
                        PatientResultData.PatientID = lstPatientResult[0].PatientId;
                        PatientResultData.VisitNumber = lstPatientResult[0].VisitNumber;
                        PatientResultData.ExternalPatientNumber = lstPatientResult[0].ExternalPatientNumber;
                        PatientResultData.OrderInfo = lstOrder;
                        actionResult = Ok(PatientResultData);
                    }
                }
                else
                {
                    actionResult = Ok("Result Not Found");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }

            return actionResult;
        }
        /// <summary>
        /// This API will provide the new test order details of patient and the parameter values based on message type in AttuneLIMS.
        /// </summary>
        /// <param name="messageType"></param> messageType to be 'NW' 
        /// <param name="OrgCode"></param> OrgCode is organization code of AttuneLIMS
        /// <returns></returns>
        [ResponseType(typeof(PatientOrderDetails))]
        [HttpGet]
        [Route("Api/Orders/GetPatientOrderDetails")]

        public IHttpActionResult GetPatientOrderDetails(string messageType, string OrgCode)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
           

            long returnCode = -1;
            IHttpActionResult actionResult = null;
            PatientAddressDetails lstPatAdd = new PatientAddressDetails();
            List<PaymentDetails> lstPaymentinfo = new List<PaymentDetails>();

            List<PatientDetail> lstPatDetail = new List<PatientDetail>();
            List<PatientVisitDetail> lstPatVisit = new List<PatientVisitDetail>();
            List<PatientTestDetails> lstPatOrders = new List<PatientTestDetails>();
            List<PatientBillingDetails> lstPatBilling = new List<PatientBillingDetails>();
            BillingDetail objBl = new BillingDetail();
            PatientOrderDetails ObjOrder = new PatientOrderDetails();
            PatientVisitDetails objvisit = new PatientVisitDetails();
            List<CorporatePatients> lstcorp = new List<CorporatePatients>();
            CorporatePatients objcorp = new CorporatePatients();
            PatientDetails objpat = new PatientDetails(); 
            List<PatientAddressDetails> lstAdddress = new List<PatientAddressDetails>();

            try
            {
                returnCode = new LIMSAPI_BL().GetPatientOrderDetails(messageType, OrgCode, out lstPatDetail, out lstPatVisit, out lstPatBilling, out lstPaymentinfo);

                if (returnCode != -1)
                { 
                    if (lstPatDetail.Count > 0 && lstPatDetail != null)
                    {
                        objpat.PatientID = lstPatDetail[0].PatientID;
                        objpat.PatientNumber = lstPatDetail[0].PatientNumber;
                        objpat.FirstName = lstPatDetail[0].FirstName;
                        objpat.MiddleName = lstPatDetail[0].MiddleName;
                        objpat.LastName = lstPatDetail[0].LastName;
                        objpat.MobileNumber = lstPatDetail[0].MobileNumber;
                        objpat.URNNumber = lstPatDetail[0].URNNumber;
                        objpat.URNType = lstPatDetail[0].URNType;
                        objpat.Gender = lstPatDetail[0].Gender;
                        objpat.Age = lstPatDetail[0].Age;
                        objpat.DOB = lstPatDetail[0].DOB;
                        objpat.EmailID = lstPatDetail[0].EmailID;
                        objpat.SalutationCode = lstPatDetail[0].SalutationCode;
                        objpat.MaritalStatus = lstPatDetail[0].MaritalStatus;
                        objpat.DocumentOf = lstPatDetail[0].DocumentOf;
                        objpat.TelephoneNumber = lstPatDetail[0].TelephoneNumber;
                        objpat.Salutation = lstPatDetail[0].SalutationValue;
                        objpat.WardNo = lstPatDetail[0].WardNo;
                        lstPatAdd.Address = lstPatDetail[0].Address;
                        lstPatAdd.State = lstPatDetail[0].State;
                        lstPatAdd.City = lstPatDetail[0].City;
                        lstPatAdd.Country = lstPatDetail[0].Country;
                        lstPatAdd.AddressType = lstPatDetail[0].AddressType;
                        lstPatAdd.StateID = lstPatDetail[0].StateID;
                        lstPatAdd.CountryID = lstPatDetail[0].CountryID;
                        lstPatAdd.ExternalPatientNumber = lstPatDetail[0].ExternalPatientNumber;
                        lstPatAdd.Suburb = lstPatDetail[0].Suburb;
                        lstAdddress.Add(lstPatAdd);
                        objpat.AddressDetails = lstAdddress;
                        ObjOrder.PatientInfo = objpat;
                        ObjOrder.MessageType = lstPatDetail[0].MessageType;
                        ObjOrder.OrderId = lstPatDetail[0].OrderID;
                        ObjOrder.OrgCode = OrgCode;
                        TimeZone = lstPatDetail[0].TimeZone;
                    }
                    if (lstPatVisit != null && lstPatVisit.Count > 0)
                    {
                        objvisit.PatientVisitId = lstPatVisit[0].PatientVisitId;
                        objvisit.ExternalVisitNumber = lstPatVisit[0].ExternalVisitNumber;
                        objvisit.VisitType = lstPatVisit[0].VisitType;
                        objvisit.VATRegisterationNo = lstPatVisit[0].VATRegisterationNo;
                        objvisit.ClientCode = lstPatVisit[0].ClientCode;
                        objvisit.ClientName = lstPatVisit[0].ClientName;
                        objvisit.ReferingDoctorCode = lstPatVisit[0].ReferingDoctorCode;
                        objvisit.ReferingDoctorName = lstPatVisit[0].ReferingDoctorName;
                        objvisit.ReferingDoctorMobileNumber = lstPatVisit[0].ReferingDoctorMobileNumber;
                        objvisit.IsNotification = lstPatVisit[0].IsNotification;
                        objvisit.HospitalNameCode = lstPatVisit[0].HospitalNameCode;
                        objvisit.HospitalName = lstPatVisit[0].HospitalName;
                        objvisit.VisitHistory = lstPatVisit[0].VisitHistory;
                        objvisit.VisitRemarks = lstPatVisit[0].VisitRemarks;
                        objvisit.RegisterLocation = lstPatVisit[0].RegisterLocation;
                        objvisit.VisitDate = GetTimeZoneTime(lstPatVisit[0].VisitDate);
                        objvisit.CompanyID = lstPatVisit[0].CompanyID;
                        objvisit.ClientID = lstPatVisit[0].ClientID;
                        objvisit.WardNo = lstPatVisit[0].WardNo;
                        List<VisitReportLanguage> lstreportlang = new List<VisitReportLanguage>();
                        foreach (PatientVisitDetail objlang in lstPatVisit)
                        {
                            VisitReportLanguage objreplang = new VisitReportLanguage();
                            objreplang.Language = objlang.Language;
                            lstreportlang.Add(objreplang);
                        }
                        objvisit.ReportLanguage = lstreportlang;
                        //foreach (PatientVisitDetail LstVisit in lstPatVisit)
                        //{
                        if (lstPatVisit[0].CheckinDate != null && lstPatVisit[0].CheckinDate.ToString("yyyy-MM-dd")!="0001-01-01")
                        {
                            objcorp.BookedDate =GetTimeZoneTime( lstPatVisit[0].BookedDate);
                            objcorp.CheckinDate = GetTimeZoneTime(lstPatVisit[0].CheckinDate);
                            objcorp.CheckOutDate = GetTimeZoneTime(lstPatVisit[0].CheckOutDate);
                            objcorp.Status = lstPatVisit[0].Status;
                            //}
                            objvisit.CorporatePatient = objcorp;
                        }
                        ObjOrder.PatientVisitInfo = objvisit;
                    }
                    if (lstPaymentinfo != null && lstPaymentinfo.Count > 0)
                    {
                        ObjOrder.PaymentDetailsList = lstPaymentinfo;
                    }
                    if (lstPatBilling != null && lstPatBilling.Count > 0)
                    {
                        foreach (PatientBillingDetails objbill in lstPatBilling)
                        {
                            PatientTestDetails objtest = new PatientTestDetails();
                            objtest.Status = objbill.Status;
                            objtest.TestCode = objbill.TestCode;
                            objtest.TestName = objbill.TestName;
                            objtest.TestID = objbill.TestID;
                            objtest.TestClinicalHistory = objbill.TestClinicalHistory;
                            objtest.IsStat = objbill.IsStat;
                            objtest.Price = objbill.Price;
                            objtest.RateCardcode = objbill.RateCardcode;
                            objtest.Instructions = objbill.Instructions;
                            objtest.Remarks = objbill.Remarks;
                            objtest.Price = objbill.Price;
                            objtest.CreatedAt = GetTimeZoneTime(objbill.CreatedAt);
                            objtest.UpdatedAt = GetTimeZoneTime(objbill.UpdatedAt);
                            lstPatOrders.Add(objtest);
                        }
                        objBl.GrossAmount = lstPatBilling[0].GrossAmount;
                        objBl.NetAmount = lstPatBilling[0].NetAmount;
                        objBl.Discount = lstPatBilling[0].Discount;
                        objBl.DueAmount = lstPatBilling[0].DueAmount;
                        objBl.PaymentStatus = lstPatBilling[0].PaymentStatus;
                        ObjOrder.BillingInfo = objBl;
                        ObjOrder.TestDetailsList = lstPatOrders;
                    }
                    actionResult = Ok(ObjOrder);
                } 
                else
                {
                    actionResult = Ok("While fetching the data getting an Error.");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured"+ex.ToString());
            }

            return actionResult;
        }
        /// <summary>
        /// This API will provide the patient's additional ordered test for the same visit and patient demographic changed details based on message type in AttuneLIMS.
        /// </summary>
        /// <param name="messageType"></param> messageType to be 'MO'
        /// <param name="OrgCode"></param>OrgCode is organization code of AttuneLIMS
        /// <returns></returns>
         
        [ResponseType(typeof(PatientOrderDetails))]
        [HttpGet]
        [Route("Api/Orders/GetPatientOrderMODetails")]
        
        public IHttpActionResult GetPatientOrderMODetails(string messageType, string OrgCode)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            //string pOrgCode = string.Empty;

            //if (headers.Contains("orgcode"))
            //{
            //    pOrgCode = headers.GetValues("orgcode").First();
            //}

            long returnCode = -1;
            IHttpActionResult actionResult = null;
            PatientAddressDetails lstPatAdd = new PatientAddressDetails();
            List<PaymentDetails> lstPaymentinfo = new List<PaymentDetails>();

            List<PatientDetail> lstPatDetail = new List<PatientDetail>();
            List<PatientVisitDetail> lstPatVisit = new List<PatientVisitDetail>();
            List<PatientTestDetails> lstPatOrders = new List<PatientTestDetails>();
            List<PatientBillingDetails> lstPatBilling = new List<PatientBillingDetails>();
            BillingDetail objBl = new BillingDetail();
            PatientOrderDetails ObjOrder = new PatientOrderDetails();
            PatientVisitDetails objvisit = new PatientVisitDetails();
            List<CorporatePatients> lstcorp = new List<CorporatePatients>();
            CorporatePatients objcorp = new CorporatePatients();
            PatientDetails objpat = new PatientDetails(); 
            List<PatientAddressDetails> lstAdddress = new List<PatientAddressDetails>();
            try
            {
                returnCode = new LIMSAPI_BL().GetPatientOrderDetails(messageType, OrgCode, out lstPatDetail, out lstPatVisit, out lstPatBilling, out lstPaymentinfo);

                if (returnCode != -1)
                { 
                    if (lstPatDetail.Count > 0 && lstPatDetail != null)
                    {
                        objpat.PatientID = lstPatDetail[0].PatientID;
                        objpat.PatientNumber = lstPatDetail[0].PatientNumber;
                        objpat.FirstName = lstPatDetail[0].FirstName;
                        objpat.MiddleName = lstPatDetail[0].MiddleName;
                        objpat.LastName = lstPatDetail[0].LastName;
                        objpat.MobileNumber = lstPatDetail[0].MobileNumber;
                        objpat.URNNumber = lstPatDetail[0].URNNumber;
                        objpat.URNType = lstPatDetail[0].URNType;
                        objpat.Gender = lstPatDetail[0].Gender;
                        objpat.Age = lstPatDetail[0].Age;
                        objpat.DOB = lstPatDetail[0].DOB;
                        objpat.EmailID = lstPatDetail[0].EmailID;
                        objpat.SalutationCode = lstPatDetail[0].SalutationCode;
                        objpat.MaritalStatus = lstPatDetail[0].MaritalStatus;
                        objpat.DocumentOf = lstPatDetail[0].DocumentOf;
                        objpat.TelephoneNumber = lstPatDetail[0].TelephoneNumber;
                        objpat.Salutation = lstPatDetail[0].SalutationValue;
                        objpat.WardNo = lstPatDetail[0].WardNo;
                        lstPatAdd.Address = lstPatDetail[0].Address;
                        lstPatAdd.State = lstPatDetail[0].State;
                        lstPatAdd.City = lstPatDetail[0].City;
                        lstPatAdd.Country = lstPatDetail[0].Country;
                        lstPatAdd.AddressType = lstPatDetail[0].AddressType;
                        lstPatAdd.StateID = lstPatDetail[0].StateID;
                        lstPatAdd.CountryID = lstPatDetail[0].CountryID;
                        lstPatAdd.ExternalPatientNumber = lstPatDetail[0].ExternalPatientNumber;
                        lstPatAdd.Suburb = lstPatDetail[0].Suburb;
                        lstAdddress.Add(lstPatAdd);
                        objpat.AddressDetails = lstAdddress;
                        ObjOrder.PatientInfo = objpat;
                        ObjOrder.MessageType = lstPatDetail[0].MessageType;
                        ObjOrder.OrderId = lstPatDetail[0].OrderID;
                        ObjOrder.OrgCode = OrgCode;
                        TimeZone = lstPatDetail[0].TimeZone;
                    }
                      
                    if (lstPatBilling != null && lstPatBilling.Count > 0)
                    {
                        ObjOrder.MessageType = lstPatBilling[0].MessageType;
                        ObjOrder.OrderId = lstPatBilling[0].OrderID;
                        foreach (PatientBillingDetails objbill in lstPatBilling)
                        {
                            PatientTestDetails objtest = new PatientTestDetails();
                            objtest.Status = objbill.Status;
                            objtest.TestCode = objbill.TestCode;
                            objtest.TestID = objbill.TestID;
                            objtest.TestName = objbill.TestName;
                            objtest.TestClinicalHistory = objbill.TestClinicalHistory;
                            objtest.IsStat = objbill.IsStat;
                            objtest.Price = objbill.Price;
                            objtest.RateCardcode = objbill.RateCardcode;
                            objtest.Instructions = objbill.Instructions;
                            objtest.Remarks = objbill.Remarks;
                            objtest.Price = objbill.Price;
                            objtest.CreatedAt = GetTimeZoneTime(objbill.CreatedAt);
                            objtest.UpdatedAt = GetTimeZoneTime(objbill.UpdatedAt);
                            lstPatOrders.Add(objtest);
                        } 
                        ObjOrder.TestDetailsList = lstPatOrders;
                       
                    }
                    actionResult = Ok(ObjOrder);
                }
                else
                {
                    actionResult = Ok("While fetching the data getting an Error.");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured" + ex.ToString());
            }

            return actionResult;
        }
        /// <summary>
        /// This API will provide the cancelled order test of patient based on message type in AttuneLIMS.
        /// </summary>
        /// <param name="messageType"></param> messageType to be 'CA'
        /// <param name="OrgCode"></param>OrgCode is organization code of AttuneLIMS
        /// <returns></returns>
        [ResponseType(typeof(PatientOrderDetails))]
        [HttpGet]
        [Route("Api/Orders/GetPatientOrderCancelDetails")]

        public IHttpActionResult GetPatientOrderCancelDetails(string messageType, string OrgCode)
        {
           
            long returnCode = -1;
            IHttpActionResult actionResult = null;
            PatientAddressDetails lstPatAdd = new PatientAddressDetails();
            List<PaymentDetails> lstPaymentinfo = new List<PaymentDetails>();

            List<PatientDetail> lstPatDetail = new List<PatientDetail>();
            List<PatientVisitDetail> lstPatVisit = new List<PatientVisitDetail>();
            List<PatientTestDetails> lstPatOrders = new List<PatientTestDetails>();
            List<PatientBillingDetails> lstPatBilling = new List<PatientBillingDetails>();
            BillingDetail objBl = new BillingDetail();
            PatientOrderDetails ObjOrder = new PatientOrderDetails();
            PatientVisitDetails objvisit = new PatientVisitDetails();
            List<CorporatePatients> lstcorp = new List<CorporatePatients>();
            CorporatePatients objcorp = new CorporatePatients();
            PatientDetails objpat = new PatientDetails();
            

            try
            {
                returnCode = new LIMSAPI_BL().GetPatientOrderDetails(messageType, OrgCode, out lstPatDetail, out lstPatVisit, out lstPatBilling, out lstPaymentinfo);

                if (returnCode != -1)
                { 
                    if (lstPatDetail.Count > 0 && lstPatDetail != null)
                    { 
                        ObjOrder.MessageType = lstPatDetail[0].MessageType;
                        ObjOrder.OrderId = lstPatDetail[0].OrderID;
                        ObjOrder.OrgCode = OrgCode;
                        TimeZone = lstPatDetail[0].TimeZone;
                    }
                    
                    if (lstPatBilling != null && lstPatBilling.Count > 0)
                    {
                        foreach (PatientBillingDetails objbill in lstPatBilling)
                        {
                            PatientTestDetails objtest = new PatientTestDetails();
                            objtest.Status = objbill.Status;
                            objtest.TestCode = objbill.TestCode;
                            objtest.TestID = objbill.TestID;
                            objtest.TestName = objbill.TestName;
                            objtest.TestClinicalHistory = objbill.TestClinicalHistory;
                            objtest.IsStat = objbill.IsStat;
                            objtest.Price = objbill.Price;
                            objtest.RateCardcode = objbill.RateCardcode;
                            objtest.Instructions = objbill.Instructions;
                            objtest.Remarks = objbill.Remarks;
                            objtest.Price = objbill.Price;
                            objtest.CreatedAt =GetTimeZoneTime(objbill.CreatedAt);
                            objtest.UpdatedAt = GetTimeZoneTime(objbill.UpdatedAt);
                            lstPatOrders.Add(objtest);
                        }
                         
                        ObjOrder.TestDetailsList = lstPatOrders;
                    }
                    if (lstPaymentinfo != null && lstPaymentinfo.Count > 0)
                    {
                        ObjOrder.PaymentDetailsList = lstPaymentinfo;
                    }

                    actionResult = Ok(ObjOrder);
                }
                else
                {
                    actionResult = Ok("While fetching the data getting an Error.");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured" + ex.ToString());
            }

            return actionResult;
        }

        #region //Seetha

        /// <summary>
        /// This API will be used for update the Status of Particular test.
        /// </summary>
        /// <param name="lstOrderStatusInfo">List of test, which one status need to be update in LIS</param>
        /// <returns></returns>

        [ResponseType(typeof(OrderStatusInfo))]
        [Route("Api/Orders/UpdateOrderStatus")]
        [HttpPost]
        public IHttpActionResult UpdateOrderStatus(OrderStatusInfo lstOrderStatusInfo)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;
            string OrderId = string.Empty;
            List<OrderInformation> lstInformation = new List<OrderInformation>();
            OrderInformation objInformation = new OrderInformation();
            List<OrderInformation> lstOrderInformation = new List<OrderInformation>();

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }
            long returnCode = -1;
            IHttpActionResult actionResult = null;

            try
            {
                if (lstOrderStatusInfo != null)
                {

                    OrderId = lstOrderStatusInfo.OrderID;
                    lstOrderInformation = lstOrderStatusInfo.OrderInfo;
                    foreach (OrderInformation item in lstOrderInformation)
                    {
                        objInformation = new OrderInformation();
                        objInformation.TestID = item.TestID;
                        objInformation.TestCode = item.TestCode;
                        objInformation.TestName = item.TestName;
                        objInformation.TestStatus = item.TestStatus;
                        objInformation.ResultCapturedAt = item.ResultCapturedAt;
                        lstInformation.Add(objInformation);
                    }

                    string JsonValue = JsonConvert.SerializeObject(lstOrderStatusInfo);

                    returnCode = new LIMSAPI_BL().UpdateOrderStatus(pOrgCode, OrderId, lstInformation, JsonValue);
                    if (returnCode != -1 && returnCode != 0)
                    {
                        actionResult = Ok("Following the Visit Number : " + lstOrderStatusInfo.OrderID + " Status updated Successfully.");
                    }
                    else
                    {
                        actionResult = Ok("Test Information Not Found");
                    }

                }
                else
                {
                    actionResult = Ok("Test Information Not Found");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }
            return actionResult;
        }

        #endregion
		
        /// <summary>
        /// This API will be used to patient ordered test status.
        /// </summary>
        /// <param name="OrgCode">Give the org code of organization</param>
        /// <returns></returns>
        [ResponseType(typeof(OrderResult))]
        [HttpGet]
        [Route("Api/Orders/GetPatientOrderDetails")]

        public IHttpActionResult GetPatientOrderDetails(string OrgCode)
        {

            long returnCode = -1;
            IHttpActionResult actionResult = null;
            ResPatientDetails lstPat = new ResPatientDetails();
            PatAddressDetails lstPatAdd = new PatAddressDetails();

            List<PatientDetail> lstPatDetail = new List<PatientDetail>();
            List<TestOrderVisitDetails> lstPatOrderDetails = new List<TestOrderVisitDetails>();
            List<TestOrderVisitDetails> lstPatOrders = new List<TestOrderVisitDetails>();
            OrderResult ObjOrder = new OrderResult();
            List<CorporatePatients> lstcorp = new List<CorporatePatients>();
            CorporatePatients objcorp = new CorporatePatients();
            ResPatientDetails objpat = new ResPatientDetails();
            List<PatAddressDetails> lstAdddress = new List<PatAddressDetails>();
            List<TestOrder> lstAllOrder = new List<TestOrder>();
            List<ResPatientVisitDetails> lstpatientvisitdetails = new List<ResPatientVisitDetails>();
            RePatientVisitDetails objvisit = new RePatientVisitDetails();
            string VisitNumber = string.Empty;
            try
            {
                returnCode = new LIMSAPI_BL().GetPatientOrderDetails(OrgCode, out lstPatDetail, out lstPatOrders, out lstPatOrderDetails, out lstpatientvisitdetails, out VisitNumber);

                if (returnCode != -1)
                {
                    if (lstPatDetail.Count > 0 && lstPatDetail != null)
                    {
                        objpat.PatientID = lstPatDetail[0].PatientID;
                        objpat.PatientNumber = lstPatDetail[0].PatientNumber;
                        objpat.FirstName = lstPatDetail[0].FirstName;
                        objpat.MiddleName = lstPatDetail[0].MiddleName;
                        objpat.LastName = lstPatDetail[0].LastName;
                        objpat.MobileNumber = lstPatDetail[0].MobileNumber;
                        objpat.URNNumber = lstPatDetail[0].URNNumber;
                        objpat.URNType = lstPatDetail[0].URNType;
                        objpat.Gender = lstPatDetail[0].Gender;
                        objpat.Age = lstPatDetail[0].Age;
                        objpat.DOB = lstPatDetail[0].DOB;
                        objpat.EmailID = lstPatDetail[0].EmailID;
                        objpat.SalutationCode = lstPatDetail[0].SalutationCode;
                        objpat.MaritalStatus = lstPatDetail[0].MaritalStatus;
                        objpat.DocumentOf = lstPatDetail[0].DocumentOf;
                        objpat.TelephoneNumber = lstPatDetail[0].TelephoneNumber;
                        objpat.Salutation = lstPatDetail[0].SalutationValue;
                        objpat.WardNo = lstPatDetail[0].WardNo;
                        lstPatAdd.Address = lstPatDetail[0].Address;
                        lstPatAdd.State = lstPatDetail[0].State;
                        lstPatAdd.City = lstPatDetail[0].City;
                        lstPatAdd.Country = lstPatDetail[0].Country;
                        lstPatAdd.AddressType = lstPatDetail[0].AddressType;
                        lstPatAdd.StateID = lstPatDetail[0].StateID;
                        lstPatAdd.CountryID = lstPatDetail[0].CountryID;
                        lstPatAdd.ExternalPatientNumber = lstPatDetail[0].ExternalPatientNumber;
                        lstPatAdd.Suburb = lstPatDetail[0].Suburb;
                        lstAdddress.Add(lstPatAdd);
                        objpat.AddressDetails = lstAdddress;
                        ObjOrder.PatientInfo = objpat;
                        ObjOrder.OrderId = lstPatDetail[0].OrderID;
                        ObjOrder.OrgCode = OrgCode;
                        TimeZone = lstPatDetail[0].TimeZone;
                    }
                    if (lstpatientvisitdetails != null && lstpatientvisitdetails.Count > 0)
                    {
                        objvisit.ClientID = lstpatientvisitdetails[0].ClientID;
                        objvisit.PatientVisitId = lstpatientvisitdetails[0].PatientVisitId;
                        objvisit.ExternalVisitNumber = lstpatientvisitdetails[0].ExternalVisitNumber;
                        objvisit.VisitType = lstpatientvisitdetails[0].VisitType;
                        objvisit.VisitDate =GetTimeZoneTime( lstpatientvisitdetails[0].VisitDate);
                        objvisit.VATRegisterationNo = lstpatientvisitdetails[0].VATRegisterationNo;
                        objvisit.ClientCode = lstpatientvisitdetails[0].ClientCode;
                        objvisit.ClientName = lstpatientvisitdetails[0].ClientName;
                        objvisit.VisitHistory = lstpatientvisitdetails[0].VisitHistory;
                        objvisit.VisitRemarks = lstpatientvisitdetails[0].VisitRemarks;
                        objvisit.ReferingDoctorCode = lstpatientvisitdetails[0].ReferingDoctorCode;
                        objvisit.ReferingDoctorMobileNumber = lstpatientvisitdetails[0].ReferingDoctorMobileNumber;
                        objvisit.ReferingDoctorName = lstpatientvisitdetails[0].ReferingDoctorName;
                        objvisit.HospitalName = lstpatientvisitdetails[0].HospitalName;
                        objvisit.HospitalNameCode = lstpatientvisitdetails[0].HospitalNameCode;
                        objvisit.RegisterLocation = lstpatientvisitdetails[0].RegisterLocation;
                        objvisit.IsNotification = lstpatientvisitdetails[0].IsNotification;
                        objvisit.CompanyID = lstpatientvisitdetails[0].CompanyID;
                        objvisit.WardNo = lstpatientvisitdetails[0].WardNo;
                        List<VisitReportLanguage> lstreportlang = new List<VisitReportLanguage>();
                        foreach (ResPatientVisitDetails objlang in lstpatientvisitdetails)
                        {
                            VisitReportLanguage objreplang = new VisitReportLanguage();
                            objreplang.Language = objlang.Language;
                            lstreportlang.Add(objreplang);
                        }
                        objvisit.ReportLanguage = lstreportlang;
                        ObjOrder.PatientVisitInfo = objvisit;
                        if (lstpatientvisitdetails[0].BookedDate != null && lstpatientvisitdetails[0].BookedDate.ToString("yyyy-MM-dd") != "0001-01-01")
                        {
                            objcorp.BookedDate = GetTimeZoneTime(lstpatientvisitdetails[0].BookedDate);
                            objcorp.CheckinDate = GetTimeZoneTime(lstpatientvisitdetails[0].CheckinDate);
                            objcorp.CheckOutDate = GetTimeZoneTime(lstpatientvisitdetails[0].CheckOutDate);
                            objcorp.Status = lstpatientvisitdetails[0].Status;
                            ObjOrder.CorporatePatient = objcorp;
                        }
                    }
                    if (lstPatOrders != null && lstPatOrders.Count > 0)
                    {
                        ObjOrder.OverAllStatus = lstPatOrders[0].OverAllStatus;
                         

                        foreach (TestOrderVisitDetails s in lstPatOrders)
                        {

                            if (s.TestType == "INV")
                            {
                                TestOrder objtest = new TestOrder();
                                objtest.PatientVisitID = s.PatientVisitID;
                                objtest.ExternalVisitID = s.ExternalVisitID;
                                objtest.TestID = s.TestID;
                                objtest.TestCode = s.TestCode;
                                objtest.OrderedDate = GetTimeZoneTime(s.OrderedDate);
                                objtest.TestType = s.TestType;
                                objtest.TestName = s.TestName;
                                objtest.TestValueType = s.TestValueType;
                                objtest.TestValue = s.TestValue;
                                objtest.UOMCode = s.UOMCode;
                                objtest.MethodName = s.MethodName;
                                objtest.ReferenceRange = s.ReferenceRange.Contains("<?xml")?ParseXML(s.ReferenceRange): s.ReferenceRange;
                                objtest.IsAbnormal = s.IsAbnormal;
                                objtest.ResultCapturedAt = GetTimeZoneTime(s.ResultCapturedAt);
                                objtest.TestStatus = s.TestStatus;
                                objtest.MedicalRemarks = s.MedicalRemarks;
                                objtest.InterpretationNotes = s.InterpretationNotes;
                                objtest.ProcessingType = s.ProcessingType;
                                objtest.ProcessingLocation = s.ProcessingLocation;
                                objtest.DeviceID = s.DeviceID;
                                objtest.LotNumber = s.LotNumber;
                                objtest.CreatedAt = GetTimeZoneTime(s.CreatedAt);
                                objtest.UpdatedAt = GetTimeZoneTime(s.UpdatedAt);
                                objtest.DepartmentName = s.DepartmentName;
                                objtest.SampleName = s.SampleName;
                                objtest.Nonreportable = s.Nonreportable;
                                lstAllOrder.Add(objtest);
                            }

                            if (s.TestType == "GRP")
                            {
                                foreach (TestOrderVisitDetails inv in lstPatOrderDetails)
                                {
                                    if (s.TestID == inv.GroupID)
                                    {
                                        TestOrder objgrp = new TestOrder();
                                        TestOrderContentVisit objpkgcnt = new TestOrderContentVisit();
                                        TestOrderVisit objpkgparam = new TestOrderVisit();
                                        objgrp.PatientVisitID = inv.PatientVisitID;
                                        objgrp.ExternalVisitID = inv.ExternalVisitID;
                                        objgrp.TestID = s.TestID;
                                        objgrp.TestCode = s.TestCode;
                                        objgrp.OrderedDate = GetTimeZoneTime(s.OrderedDate);
                                        objgrp.TestType = s.TestType;
                                        objgrp.TestName = s.TestName;
                                        objgrp.TestValueType = s.TestValueType;
                                        objgrp.TestValue = s.TestValue;
                                        objgrp.UOMCode = s.UOMCode;
                                        objgrp.MethodName = s.MethodName;
                                        objgrp.ReferenceRange = s.ReferenceRange.Contains("<?xml") ? ParseXML(s.ReferenceRange) : s.ReferenceRange;
                                        objgrp.IsAbnormal = s.IsAbnormal;
                                        objgrp.ResultCapturedAt = GetTimeZoneTime(s.ResultCapturedAt);
                                        objgrp.TestStatus = s.TestStatus;
                                        objgrp.MedicalRemarks = s.MedicalRemarks;
                                        objgrp.InterpretationNotes = s.InterpretationNotes;
                                        objgrp.ProcessingType = s.ProcessingType;
                                        objgrp.ProcessingLocation = s.ProcessingLocation;
                                        objgrp.DeviceID = s.DeviceID;
                                        objgrp.LotNumber = s.LotNumber;
                                        objgrp.CreatedAt = GetTimeZoneTime(s.CreatedAt);
                                        objgrp.UpdatedAt = GetTimeZoneTime(s.UpdatedAt);
                                        objgrp.DepartmentName = s.DepartmentName;
                                        objgrp.DeltaValue = s.DeltaValue;
                                        objgrp.UserID = s.UserID;
                                        objgrp.UserName = s.UserName;
                                        objgrp.SampleName = s.SampleName;
                                        objgrp.Nonreportable = s.Nonreportable;
                                        List<TestOrderContentVisit> lstpkg = new List<TestOrderContentVisit>();
                                        var Contentpkg = lstPatOrderDetails.FindAll(p => p.GroupID == inv.GroupID && p.SubGroupID == "0");
                                        //  var Contentpkgparam = lstPatOrderDetails.FindAll(p => p.GroupID == inv.GroupID);
                                        var Contentpkgparam = lstPatOrderDetails.Where(t => t.SubGroupID != "0" && t.GroupID != "0" && t.GroupID == inv.GroupID).GroupBy(test => test.SubGroupID).Select(grp => grp.First()).ToList();
                                        var Contentpkgparam1 = lstPatOrderDetails.FindAll(p => p.GroupID == inv.GroupID);
                                        List<TestOrderContentVisit> lstpkgcont = new List<TestOrderContentVisit>();
                                        foreach (TestOrderVisitDetails tall in Contentpkg)
                                        {
                                            TestOrderContentVisit objcont = new TestOrderContentVisit();
                                            objcont.TestCode = tall.TestCode;
                                            objcont.OrderedDate = GetTimeZoneTime(tall.OrderedDate);
                                            objcont.TestType = tall.TestType;
                                            objcont.TestID = tall.TestID;
                                            objcont.TestName = tall.TestName;
                                            objcont.TestValueType = tall.TestValueType;
                                            objcont.TestValue = tall.TestValue;
                                            objcont.UOMCode = tall.UOMCode;
                                            objcont.MethodName = tall.MethodName;
                                            objcont.ReferenceRange = tall.ReferenceRange.Contains("<?xml") ? ParseXML(tall.ReferenceRange) : tall.ReferenceRange;
                                            objcont.IsAbnormal = tall.IsAbnormal;
                                            objcont.ResultCapturedAt = GetTimeZoneTime(tall.ResultCapturedAt);
                                            objcont.TestStatus = tall.TestStatus;
                                            objcont.MedicalRemarks = tall.MedicalRemarks;
                                            objcont.InterpretationNotes = tall.InterpretationNotes;
                                            objcont.ProcessingType = tall.ProcessingType;
                                            objcont.ProcessingLocation = tall.ProcessingLocation;
                                            objcont.DeviceID = tall.DeviceID;
                                            objcont.LotNumber = tall.LotNumber;
                                            objcont.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                            objcont.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                            objcont.DepartmentName = tall.DepartmentName;
                                            objcont.DeltaValue = tall.DeltaValue;
                                            objcont.UserID = tall.UserID;
                                            objcont.UserName = tall.UserName;
                                            objcont.SampleName = tall.SampleName;
                                            objcont.Nonreportable = tall.Nonreportable;
                                            lstpkgcont.Add(objcont);

                                        }
                                        foreach (TestOrderVisitDetails tall in Contentpkgparam)
                                        {
                                            TestOrderContentVisit objcont1 = new TestOrderContentVisit();
                                            objcont1.TestCode = tall.SubGroupCode;
                                            objcont1.OrderedDate = GetTimeZoneTime(tall.OrderedDate);
                                            objcont1.TestType = "GRP";
                                            objcont1.TestID = tall.SubGroupID;
                                            objcont1.TestName = tall.SubGroupName;
                                            objcont1.TestValueType = tall.TestValueType;
                                            objcont1.TestValue = "";
                                            objcont1.UOMCode = tall.UOMCode;
                                            objcont1.MethodName = tall.MethodName;
                                            objcont1.ReferenceRange = tall.ReferenceRange.Contains("<?xml") ? ParseXML(tall.ReferenceRange) : tall.ReferenceRange;
                                            objcont1.IsAbnormal = tall.IsAbnormal;
                                            objcont1.ResultCapturedAt = GetTimeZoneTime(tall.ResultCapturedAt);
                                            objcont1.TestStatus = tall.TestStatus;
                                            objcont1.MedicalRemarks = tall.MedicalRemarks;
                                            objcont1.InterpretationNotes = tall.InterpretationNotes;
                                            objcont1.ProcessingType = tall.ProcessingType;
                                            objcont1.ProcessingLocation = tall.ProcessingLocation;
                                            objcont1.DeviceID = tall.DeviceID;
                                            objcont1.LotNumber = tall.LotNumber;
                                            objcont1.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                            objcont1.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                            objcont1.DepartmentName = tall.DepartmentName;
                                            objcont1.DeltaValue = "";
                                            objcont1.UserID = tall.UserID;
                                            objcont1.UserName = tall.UserName;
                                            objcont1.SampleName = tall.SampleName;
                                            objcont1.Nonreportable = tall.Nonreportable;
                                            List<TestOrderVisit> lstpkgcontpar = new List<TestOrderVisit>();
                                            foreach (TestOrderVisitDetails objp in Contentpkgparam1)
                                            {
                                                TestOrderVisit objcontpar = new TestOrderVisit();
                                                if (tall.SubGroupID == objp.SubGroupID)// && objp.SubGroupID == "0")
                                                {
                                                    objcontpar.TestCode = objp.TestCode;
                                                    objcontpar.OrderedDate = GetTimeZoneTime(objp.OrderedDate);
                                                    objcontpar.TestType = objp.TestType;
                                                    objcontpar.TestID = objp.TestID;
                                                    objcontpar.TestName = objp.TestName;
                                                    objcontpar.TestValueType = objp.TestValueType;
                                                    objcontpar.TestValue = objp.TestValue;
                                                    objcontpar.UOMCode = objp.UOMCode;
                                                    objcontpar.MethodName = objp.MethodName;
                                                    objcontpar.ReferenceRange = objp.ReferenceRange.Contains("<?xml") ? ParseXML(objp.ReferenceRange) : objp.ReferenceRange;
                                                    objcontpar.IsAbnormal = objp.IsAbnormal;
                                                    objcontpar.ResultCapturedAt = GetTimeZoneTime(objp.ResultCapturedAt);
                                                    objcontpar.TestStatus = objp.TestStatus;
                                                    objcontpar.MedicalRemarks = objp.MedicalRemarks;
                                                    objcontpar.InterpretationNotes = objp.InterpretationNotes;
                                                    objcontpar.ProcessingType = objp.ProcessingType;
                                                    objcontpar.ProcessingLocation = objp.ProcessingLocation;
                                                    objcontpar.DeviceID = objp.DeviceID;
                                                    objcontpar.LotNumber = objp.LotNumber;
                                                    objcontpar.CreatedAt = GetTimeZoneTime(objp.CreatedAt);
                                                    objcontpar.UpdatedAt = GetTimeZoneTime(objp.UpdatedAt);
                                                    objcontpar.DepartmentName = tall.DepartmentName;
                                                    objcontpar.DeltaValue = objp.DeltaValue;
                                                    objcontpar.UserID = objp.UserID;
                                                    objcontpar.UserName = objp.UserName;
                                                    objcontpar.SampleName = objp.SampleName;
                                                    objcontpar.Nonreportable = objp.Nonreportable;
                                                    lstpkgcontpar.Add(objcontpar);
                                                }
                                            }

                                            objcont1.ParameterListInfo = lstpkgcontpar;
                                            lstpkgcont.Add(objcont1);
                                        }
                                        objgrp.OrderContentListInfo = lstpkgcont;
                                        if (!lstAllOrder.Exists(p => p.TestID == objgrp.TestID && p.TestType == objgrp.TestType))
                                            lstAllOrder.Add(objgrp);
                                    }
                                   
                                }
                            }
                            if (s.TestType == "PKG")// && s.TestID == inv.PKGID)
                            {
                                foreach (TestOrderVisitDetails inv in lstPatOrderDetails)
                                {
                                    if (s.TestID == inv.PKGID)
                                    {
                                        TestOrder objpkg = new TestOrder();
                                        TestOrderContentVisit objpkgcnt = new TestOrderContentVisit();
                                        TestOrderVisit objpkgparam = new TestOrderVisit();
                                        objpkg.PatientVisitID = inv.PatientVisitID;
                                        objpkg.ExternalVisitID = inv.ExternalVisitID;
                                        objpkg.TestID = s.TestID;
                                        objpkg.TestCode = s.TestCode;
                                        objpkg.OrderedDate = GetTimeZoneTime(s.OrderedDate);
                                        objpkg.TestType = s.TestType;
                                        objpkg.TestName = s.TestName;
                                        objpkg.TestValueType = s.TestValueType;
                                        objpkg.TestValue = s.TestValue;
                                        objpkg.UOMCode = s.UOMCode;
                                        objpkg.MethodName = s.MethodName;
                                        objpkg.ReferenceRange = s.ReferenceRange.Contains("<?xml") ? ParseXML(s.ReferenceRange) : s.ReferenceRange;
                                        objpkg.IsAbnormal = s.IsAbnormal;
                                        objpkg.ResultCapturedAt = GetTimeZoneTime(s.ResultCapturedAt);
                                        objpkg.TestStatus = s.TestStatus;
                                        objpkg.MedicalRemarks = s.MedicalRemarks;
                                        objpkg.InterpretationNotes = s.InterpretationNotes;
                                        objpkg.ProcessingType = s.ProcessingType;
                                        objpkg.ProcessingLocation = s.ProcessingLocation;
                                        objpkg.DeviceID = s.DeviceID;
                                        objpkg.LotNumber = s.LotNumber;
                                        objpkg.CreatedAt = GetTimeZoneTime(s.CreatedAt);
                                        objpkg.UpdatedAt = GetTimeZoneTime(s.UpdatedAt);
                                        objpkg.DepartmentName = s.DepartmentName;
                                        objpkg.SampleName = s.SampleName;
                                        objpkg.Nonreportable = s.Nonreportable;
                                        List<TestOrderContentVisit> lstpkg = new List<TestOrderContentVisit>();
                                        var Contentpkg = lstPatOrderDetails.FindAll(p => p.PKGID == inv.PKGID && p.GroupID == "0");
                                        //  var Contentpkgparam = lstPatOrderDetails.FindAll(p => p.GroupID == inv.GroupID);
                                        var Contentpkgparam = lstPatOrderDetails.GroupBy(test => test.GroupID)
                                                     .Select(grp => grp.First())
                                                     .Where(t => t.GroupID != "0" && t.PKGID != "0" && t.PKGID == inv.PKGID)
                                                       .ToList();
                                        var Contentpkgparam1 = lstPatOrderDetails.FindAll(p => p.PKGID == inv.PKGID);
                                        List<TestOrderContentVisit> lstpkgcont = new List<TestOrderContentVisit>();

                                        foreach (TestOrderVisitDetails tall in Contentpkg)
                                        {
                                            TestOrderContentVisit objcont = new TestOrderContentVisit();
                                            objcont.TestCode = tall.TestCode;
                                            objcont.OrderedDate = GetTimeZoneTime(tall.OrderedDate);
                                            objcont.TestType = tall.TestType;
                                            objcont.TestID = tall.TestID;
                                            objcont.TestName = tall.TestName;
                                            objcont.TestValueType = tall.TestValueType;
                                            objcont.TestValue = tall.TestValue;
                                            objcont.UOMCode = tall.UOMCode;
                                            objcont.MethodName = tall.MethodName;
                                            objcont.ReferenceRange = tall.ReferenceRange.Contains("<?xml") ? ParseXML(tall.ReferenceRange) : tall.ReferenceRange;
                                            objcont.IsAbnormal = tall.IsAbnormal;
                                            objcont.ResultCapturedAt = GetTimeZoneTime(tall.ResultCapturedAt);
                                            objcont.TestStatus = tall.TestStatus;
                                            objcont.MedicalRemarks = tall.MedicalRemarks;
                                            objcont.InterpretationNotes = tall.InterpretationNotes;
                                            objcont.ProcessingType = tall.ProcessingType;
                                            objcont.ProcessingLocation = tall.ProcessingLocation;
                                            objcont.DeviceID = tall.DeviceID;
                                            objcont.LotNumber = tall.LotNumber;
                                            objcont.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                            objcont.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                            objcont.DepartmentName = tall.DepartmentName;
                                            objcont.SampleName = tall.SampleName;
                                            objcont.Nonreportable = tall.Nonreportable;
                                            lstpkgcont.Add(objcont);

                                        }

                                        foreach (TestOrderVisitDetails tall in Contentpkgparam)
                                        {
                                            TestOrderContentVisit objcont1 = new TestOrderContentVisit();
                                            objcont1.TestCode = tall.GroupCode;
                                            objcont1.OrderedDate = GetTimeZoneTime(tall.OrderedDate);
                                            objcont1.TestType = "GRP";
                                            objcont1.TestID = tall.GroupID;
                                            objcont1.TestName = tall.GroupName;
                                            objcont1.TestValueType = tall.TestValueType;
                                            objcont1.TestValue = "";
                                            objcont1.UOMCode = tall.UOMCode;
                                            objcont1.MethodName = tall.MethodName;
                                            objcont1.ReferenceRange = tall.ReferenceRange.Contains("<?xml") ? ParseXML(tall.ReferenceRange) : tall.ReferenceRange;
                                            objcont1.IsAbnormal = tall.IsAbnormal;
                                            objcont1.ResultCapturedAt = GetTimeZoneTime(tall.ResultCapturedAt);
                                            objcont1.TestStatus = tall.TestStatus;
                                            objcont1.MedicalRemarks = tall.MedicalRemarks;
                                            objcont1.InterpretationNotes = tall.InterpretationNotes;
                                            objcont1.ProcessingType = tall.ProcessingType;
                                            objcont1.ProcessingLocation = tall.ProcessingLocation;
                                            objcont1.DeviceID = tall.DeviceID;
                                            objcont1.LotNumber = tall.LotNumber;
                                            objcont1.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                            objcont1.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                            objcont1.DepartmentName = tall.DepartmentName;
                                            objcont1.SampleName = tall.SampleName;
                                            objcont1.Nonreportable = tall.Nonreportable;
                                            List<TestOrderVisit> lstpkgcontpar = new List<TestOrderVisit>();
                                            foreach (TestOrderVisitDetails objp in Contentpkgparam1)
                                            {
                                                TestOrderVisit objcontpar = new TestOrderVisit();
                                                if (tall.GroupID == objp.GroupID)// && objp.SubGroupID == "0")
                                                {
                                                    objcontpar.TestCode = objp.TestCode;
                                                    objcontpar.OrderedDate = GetTimeZoneTime(objp.OrderedDate);
                                                    objcontpar.TestType = objp.TestType;
                                                    objcontpar.TestID = objp.TestID;
                                                    objcontpar.TestName = objp.TestName;
                                                    objcontpar.TestValueType = objp.TestValueType;
                                                    objcontpar.TestValue = objp.TestValue;
                                                    objcontpar.UOMCode = objp.UOMCode;
                                                    objcontpar.MethodName = objp.MethodName;
                                                    objcontpar.ReferenceRange = objp.ReferenceRange.Contains("<?xml") ? ParseXML(objp.ReferenceRange) : objp.ReferenceRange;
                                                    objcontpar.IsAbnormal = objp.IsAbnormal;
                                                    objcontpar.ResultCapturedAt =GetTimeZoneTime(objp.ResultCapturedAt);
                                                    objcontpar.TestStatus = objp.TestStatus;
                                                    objcontpar.MedicalRemarks = objp.MedicalRemarks;
                                                    objcontpar.InterpretationNotes = objp.InterpretationNotes;
                                                    objcontpar.ProcessingType = objp.ProcessingType;
                                                    objcontpar.ProcessingLocation = objp.ProcessingLocation;
                                                    objcontpar.DeviceID = objp.DeviceID;
                                                    objcontpar.LotNumber = objp.LotNumber;
                                                    objcontpar.CreatedAt = GetTimeZoneTime(objp.CreatedAt);
                                                    objcontpar.UpdatedAt = GetTimeZoneTime(objp.UpdatedAt);
                                                    objcontpar.DepartmentName = objp.DepartmentName;
                                                    objcontpar.SampleName = objp.SampleName;
                                                    objcontpar.Nonreportable = objp.Nonreportable;
                                                    lstpkgcontpar.Add(objcontpar);
                                                } 
                                            }

                                            objcont1.ParameterListInfo = lstpkgcontpar;
                                            lstpkgcont.Add(objcont1);
                                        }
                                        objpkg.OrderContentListInfo = lstpkgcont;
                                        if (!lstAllOrder.Exists(p => p.TestID == objpkg.TestID && p.TestType == objpkg.TestType))
                                            lstAllOrder.Add(objpkg);
                                    }
                                }
                            }
                        }
                        ObjOrder.OrderInfo = lstAllOrder;
                    }
                    actionResult = Ok(ObjOrder);
                } 
                else
                {
                    actionResult = Ok("While fetching the data getting an Error.");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured" + ex.ToString());
                UpdatePatientOrderInvestigation(OrgCode, VisitNumber, "");
            }

            return actionResult;
        }
        /// <summary>
        /// This API will be used to patient's Approved test results.
        /// </summary>
        /// <param name="OrgCode">Org code of the organization</param>
        /// <returns></returns>
        [ResponseType(typeof(OrderResult))]
        [HttpGet]
        [Route("Api/Orders/GetPatientResultDetails")]

        public IHttpActionResult GetPatientResultDetails(string OrgCode)
        {
            
            long returnCode = -1;
            IHttpActionResult actionResult = null;
            ResPatientDetails lstPat = new ResPatientDetails();
            PatAddressDetails lstPatAdd = new PatAddressDetails();

            List<PatientDetail> lstPatDetail = new List<PatientDetail>();
            List<TestOrderVisitDetails> lstPatOrderDetails = new List<TestOrderVisitDetails>();
            List<TestOrderVisitDetails> lstPatOrders = new List<TestOrderVisitDetails>();
            OrderResult ObjOrder = new OrderResult(); 
            List<CorporatePatients> lstcorp = new List<CorporatePatients>();
            CorporatePatients objcorp = new CorporatePatients();
            ResPatientDetails objpat = new ResPatientDetails();
            List<PatAddressDetails> lstAdddress = new List<PatAddressDetails>();
            List<TestOrder> lstAllOrder = new List<TestOrder>();
            List<ResPatientVisitDetails> lstpatientvisitdetails = new List<ResPatientVisitDetails>();
            RePatientVisitDetails objvisit = new RePatientVisitDetails();
            string VisitNumber = string.Empty;
            try
            {
                returnCode = new LIMSAPI_BL().GetPatientResultDetails(OrgCode, out lstPatDetail, out lstPatOrders, out lstPatOrderDetails, out lstpatientvisitdetails,out VisitNumber);

                if (returnCode != -1)
                {
                    if (lstPatDetail.Count > 0 && lstPatDetail != null)
                    {
                        objpat.PatientID = lstPatDetail[0].PatientID;
                        objpat.PatientNumber = lstPatDetail[0].PatientNumber;
                        objpat.FirstName = lstPatDetail[0].FirstName;
                        objpat.MiddleName = lstPatDetail[0].MiddleName;
                        objpat.LastName = lstPatDetail[0].LastName;
                        objpat.MobileNumber = lstPatDetail[0].MobileNumber;
                        objpat.URNNumber = lstPatDetail[0].URNNumber;
                        objpat.URNType = lstPatDetail[0].URNType;
                        objpat.Gender = lstPatDetail[0].Gender;
                        objpat.Age = lstPatDetail[0].Age;
                        objpat.DOB = lstPatDetail[0].DOB;
                        objpat.EmailID = lstPatDetail[0].EmailID;
                        objpat.SalutationCode = lstPatDetail[0].SalutationCode;
                        objpat.MaritalStatus = lstPatDetail[0].MaritalStatus;
                        objpat.DocumentOf = lstPatDetail[0].DocumentOf;
                        objpat.TelephoneNumber = lstPatDetail[0].TelephoneNumber;
                        objpat.Salutation = lstPatDetail[0].SalutationValue;
                        objpat.WardNo = lstPatDetail[0].WardNo;
                        lstPatAdd.Address = lstPatDetail[0].Address;
                        lstPatAdd.State = lstPatDetail[0].State;
                        lstPatAdd.City = lstPatDetail[0].City;
                        lstPatAdd.Country = lstPatDetail[0].Country;
                        lstPatAdd.AddressType = lstPatDetail[0].AddressType;
                        lstPatAdd.StateID = lstPatDetail[0].StateID;
                        lstPatAdd.CountryID = lstPatDetail[0].CountryID;
                        lstPatAdd.ExternalPatientNumber = lstPatDetail[0].ExternalPatientNumber;
                        lstPatAdd.Suburb = lstPatDetail[0].Suburb;
                        lstAdddress.Add(lstPatAdd);
                        objpat.AddressDetails = lstAdddress;
                        ObjOrder.PatientInfo = objpat;
                        ObjOrder.OrderId = lstPatDetail[0].OrderID;
                        ObjOrder.OrgCode = OrgCode;
                        TimeZone = lstPatDetail[0].TimeZone;
                    }
                    if (lstpatientvisitdetails != null && lstpatientvisitdetails.Count > 0)
                    {
                        objvisit.ClientID = lstpatientvisitdetails[0].ClientID;
                        objvisit.PatientVisitId = lstpatientvisitdetails[0].PatientVisitId;
                        objvisit.ExternalVisitNumber = lstpatientvisitdetails[0].ExternalVisitNumber;
                        objvisit.VisitType = lstpatientvisitdetails[0].VisitType;
                        objvisit.VisitDate = GetTimeZoneTime(lstpatientvisitdetails[0].VisitDate);
                        objvisit.VATRegisterationNo = lstpatientvisitdetails[0].VATRegisterationNo;
                        objvisit.ClientCode = lstpatientvisitdetails[0].ClientCode;
                        objvisit.ClientName = lstpatientvisitdetails[0].ClientName;
                        objvisit.VisitHistory = lstpatientvisitdetails[0].VisitHistory;
                        objvisit.VisitRemarks = lstpatientvisitdetails[0].VisitRemarks;
                        objvisit.ReferingDoctorCode = lstpatientvisitdetails[0].ReferingDoctorCode;
                        objvisit.ReferingDoctorMobileNumber = lstpatientvisitdetails[0].ReferingDoctorMobileNumber;
                        objvisit.ReferingDoctorName = lstpatientvisitdetails[0].ReferingDoctorName;
                        objvisit.HospitalName = lstpatientvisitdetails[0].HospitalName;
                        objvisit.HospitalNameCode = lstpatientvisitdetails[0].HospitalNameCode;
                        objvisit.RegisterLocation = lstpatientvisitdetails[0].RegisterLocation;
                        objvisit.IsNotification = lstpatientvisitdetails[0].IsNotification;
                        objvisit.CompanyID = lstpatientvisitdetails[0].CompanyID;
                        objvisit.WardNo = lstpatientvisitdetails[0].WardNo;
                        List<VisitReportLanguage> lstreportlang = new List<VisitReportLanguage>();
                        foreach (ResPatientVisitDetails objlang in lstpatientvisitdetails)
                        {
                            VisitReportLanguage objreplang = new VisitReportLanguage();
                            objreplang.Language = objlang.Language;
                            lstreportlang.Add(objreplang);
                        }
                        objvisit.ReportLanguage = lstreportlang;
                        ObjOrder.PatientVisitInfo = objvisit;
                        if (lstpatientvisitdetails[0].BookedDate != null && lstpatientvisitdetails[0].BookedDate.ToString("yyyy-MM-dd") != "0001-01-01")
                        {
                            objcorp.BookedDate = GetTimeZoneTime(lstpatientvisitdetails[0].BookedDate);
                            objcorp.CheckinDate = GetTimeZoneTime(lstpatientvisitdetails[0].CheckinDate);
                            objcorp.CheckOutDate = GetTimeZoneTime(lstpatientvisitdetails[0].CheckOutDate);
                            objcorp.Status = lstpatientvisitdetails[0].Status;
                            ObjOrder.CorporatePatient = objcorp;
                        }
                    }
                    if (lstPatOrders != null && lstPatOrders.Count > 0)
                    {
                        ObjOrder.OverAllStatus = lstPatOrders[0].OverAllStatus;
                       

                        foreach (TestOrderVisitDetails s in lstPatOrders)
                        {

                            if (s.TestType == "INV")
                            {
                                TestOrder objtest = new TestOrder();
                                objtest.PatientVisitID = s.PatientVisitID;
                                objtest.ExternalVisitID = s.ExternalVisitID;
                                objtest.TestID = s.TestID;
                                objtest.TestCode = s.TestCode;
                                objtest.OrderedDate = GetTimeZoneTime(s.OrderedDate);
                                objtest.TestType = s.TestType;
                                objtest.TestName = s.TestName;
                                objtest.TestValueType = s.TestValueType;
                                objtest.TestValue = s.TestValue;
                                objtest.UOMCode = s.UOMCode;
                                objtest.MethodName = s.MethodName;
                                objtest.ReferenceRange = s.ReferenceRange.Contains("<?xml") ? ParseXML(s.ReferenceRange) : s.ReferenceRange;
                                objtest.IsAbnormal = s.IsAbnormal;
                                objtest.ResultCapturedAt = GetTimeZoneTime(s.ResultCapturedAt);
                                objtest.TestStatus = s.TestStatus;
                                objtest.MedicalRemarks = s.MedicalRemarks;
                                objtest.InterpretationNotes = s.InterpretationNotes;
                                objtest.ProcessingType = s.ProcessingType;
                                objtest.ProcessingLocation = s.ProcessingLocation;
                                objtest.DeviceID = s.DeviceID;
                                objtest.LotNumber = s.LotNumber;
                                objtest.CreatedAt = GetTimeZoneTime(s.CreatedAt);
                                objtest.UpdatedAt = GetTimeZoneTime(s.UpdatedAt);
                                objtest.DepartmentName = s.DepartmentName;
                                objtest.DeltaValue = s.DeltaValue;
                                objtest.UserID = s.UserID;
                                objtest.UserName = s.UserName;
                                objtest.SampleName = s.SampleName;
                                objtest.ConversionRange = s.ConversionRange.Contains("<?xml") ? ParseXML(s.ConversionRange) : s.ConversionRange;
                                objtest.ConversionValue = s.ConversionValue;
                                objtest.ConversionUnit = s.ConversionUnit;
                                objtest.Nonreportable = s.Nonreportable;
                                objtest.ReportName = s.ReportName;
                                lstAllOrder.Add(objtest);
                            }

                            if (s.TestType == "GRP")
                            {
                                foreach (TestOrderVisitDetails inv in lstPatOrderDetails)
                                {
                                    if (s.TestID == inv.GroupID)
                                    {
                                        TestOrder objgrp = new TestOrder();
                                        TestOrderContentVisit objpkgcnt = new TestOrderContentVisit();
                                        TestOrderVisit objpkgparam = new TestOrderVisit();
                                        objgrp.PatientVisitID = inv.PatientVisitID;
                                        objgrp.ExternalVisitID = inv.ExternalVisitID;
                                        objgrp.TestID = s.TestID;
                                        objgrp.TestCode = s.TestCode;
                                        objgrp.OrderedDate = GetTimeZoneTime(s.OrderedDate);
                                        objgrp.TestType = s.TestType;
                                        objgrp.TestName = s.TestName;
                                        objgrp.TestValueType = s.TestValueType;
                                        objgrp.TestValue = s.TestValue;
                                        objgrp.UOMCode = s.UOMCode;
                                        objgrp.MethodName = s.MethodName;
                                        objgrp.ReferenceRange = s.ReferenceRange.Contains("<?xml") ? ParseXML(s.ReferenceRange) : s.ReferenceRange;
                                        objgrp.IsAbnormal = s.IsAbnormal;
                                        objgrp.ResultCapturedAt = GetTimeZoneTime(s.ResultCapturedAt);
                                        objgrp.TestStatus = s.TestStatus;
                                        objgrp.MedicalRemarks = s.MedicalRemarks;
                                        objgrp.InterpretationNotes = s.InterpretationNotes;
                                        objgrp.ProcessingType = s.ProcessingType;
                                        objgrp.ProcessingLocation = s.ProcessingLocation;
                                        objgrp.DeviceID = s.DeviceID;
                                        objgrp.LotNumber = s.LotNumber;
                                        objgrp.CreatedAt = GetTimeZoneTime(s.CreatedAt);
                                        objgrp.UpdatedAt = GetTimeZoneTime(s.UpdatedAt);
                                        objgrp.DepartmentName = s.DepartmentName;
                                        objgrp.DeltaValue = s.DeltaValue;
                                        objgrp.UserID = s.UserID;
                                        objgrp.UserName = s.UserName;
                                        objgrp.SampleName = s.SampleName;
                                        objgrp.ConversionRange = s.ConversionRange.Contains("<?xml") ? ParseXML(s.ConversionRange) : s.ConversionRange;
                                        objgrp.ConversionValue = s.ConversionValue;
                                        objgrp.ConversionUnit = s.ConversionUnit;
                                        objgrp.Nonreportable = s.Nonreportable;
                                        objgrp.ReportName = s.ReportName;
                                        List<TestOrderContentVisit> lstpkg = new List<TestOrderContentVisit>();
                                        var Contentpkg = lstPatOrderDetails.FindAll(p => p.GroupID == inv.GroupID && p.SubGroupID == "0");
                                        //  var Contentpkgparam = lstPatOrderDetails.FindAll(p => p.GroupID == inv.GroupID);
                                        var Contentpkgparam = lstPatOrderDetails.Where(t => t.SubGroupID != "0" && t.GroupID != "0" && t.GroupID==inv.GroupID).GroupBy(test => test.SubGroupID).Select(grp => grp.First()).ToList();
                                        var Contentpkgparam1 = lstPatOrderDetails.FindAll(p => p.GroupID == inv.GroupID);
                                        List<TestOrderContentVisit> lstpkgcont = new List<TestOrderContentVisit>();
                                        foreach (TestOrderVisitDetails tall in Contentpkg)
                                        {
                                            TestOrderContentVisit objcont = new TestOrderContentVisit();
                                            objcont.TestCode = tall.TestCode;
                                            objcont.OrderedDate = GetTimeZoneTime(tall.OrderedDate);
                                            objcont.TestType = tall.TestType;
                                            objcont.TestID = tall.TestID;
                                            objcont.TestName = tall.TestName;
                                            objcont.TestValueType = tall.TestValueType;
                                            objcont.TestValue = tall.TestValue;
                                            objcont.UOMCode = tall.UOMCode;
                                            objcont.MethodName = tall.MethodName;
                                            objcont.ReferenceRange = tall.ReferenceRange.Contains("<?xml") ? ParseXML(tall.ReferenceRange) : tall.ReferenceRange;
                                            objcont.IsAbnormal = tall.IsAbnormal;
                                            objcont.ResultCapturedAt = GetTimeZoneTime(tall.ResultCapturedAt);
                                            objcont.TestStatus = tall.TestStatus;
                                            objcont.MedicalRemarks = tall.MedicalRemarks;
                                            objcont.InterpretationNotes = tall.InterpretationNotes;
                                            objcont.ProcessingType = tall.ProcessingType;
                                            objcont.ProcessingLocation = tall.ProcessingLocation;
                                            objcont.DeviceID = tall.DeviceID;
                                            objcont.LotNumber = tall.LotNumber;
                                            objcont.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                            objcont.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                            objcont.DepartmentName = tall.DepartmentName;
                                            objcont.DeltaValue = tall.DeltaValue;
                                            objcont.UserID = tall.UserID;
                                            objcont.UserName = tall.UserName;
                                            objcont.SampleName = tall.SampleName;
                                            objcont.ConversionRange = tall.ConversionRange.Contains("<?xml") ? ParseXML(tall.ConversionRange) : tall.ConversionRange;
                                            objcont.ConversionValue = tall.ConversionValue;
                                            objcont.ConversionUnit = tall.ConversionUnit;
                                            objcont.Nonreportable = tall.Nonreportable;
                                            objcont.ReportName = tall.ReportName;
                                            lstpkgcont.Add(objcont);

                                        }
                                        foreach (TestOrderVisitDetails tall in Contentpkgparam)
                                        {
                                            TestOrderContentVisit objcont1 = new TestOrderContentVisit();
                                            objcont1.TestCode = tall.SubGroupCode;
                                            objcont1.OrderedDate = GetTimeZoneTime(tall.OrderedDate);
                                            objcont1.TestType = "GRP";
                                            objcont1.TestID = tall.SubGroupID;
                                            objcont1.TestName = tall.SubGroupName;
                                            objcont1.TestValueType = tall.TestValueType;
                                            objcont1.TestValue = "";
                                            objcont1.UOMCode = tall.UOMCode;
                                            objcont1.MethodName = tall.MethodName;
                                            objcont1.ReferenceRange = tall.ReferenceRange.Contains("<?xml") ? ParseXML(tall.ReferenceRange) : tall.ReferenceRange;
                                            objcont1.IsAbnormal = tall.IsAbnormal;
                                            objcont1.ResultCapturedAt = GetTimeZoneTime(tall.ResultCapturedAt);
                                            objcont1.TestStatus = tall.TestStatus;
                                            objcont1.MedicalRemarks = tall.MedicalRemarks;
                                            objcont1.InterpretationNotes = tall.InterpretationNotes;
                                            objcont1.ProcessingType = tall.ProcessingType;
                                            objcont1.ProcessingLocation = tall.ProcessingLocation;
                                            objcont1.DeviceID = tall.DeviceID;
                                            objcont1.LotNumber = tall.LotNumber;
                                            objcont1.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                            objcont1.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                            objcont1.DepartmentName = tall.DepartmentName;
                                            objcont1.DeltaValue = "";
                                            objcont1.UserID = tall.UserID;
                                            objcont1.UserName = tall.UserName;
                                            objcont1.SampleName = tall.SampleName;
                                            objcont1.ConversionRange = tall.ConversionRange.Contains("<?xml") ? ParseXML(tall.ConversionRange) : tall.ConversionRange;
                                            objcont1.ConversionValue = tall.ConversionValue;
                                            objcont1.ConversionUnit = tall.ConversionUnit;
                                            objcont1.Nonreportable = "";// tall.Nonreportable;
                                            objcont1.ReportName = tall.ReportName;
                                            List<TestOrderVisit> lstpkgcontpar = new List<TestOrderVisit>();
                                            foreach (TestOrderVisitDetails objp in Contentpkgparam1)
                                            {
                                                TestOrderVisit objcontpar = new TestOrderVisit();
                                                if (tall.SubGroupID == objp.SubGroupID)// && objp.SubGroupID == "0")
                                                {
                                                    objcontpar.TestCode = objp.TestCode;
                                                    objcontpar.OrderedDate = GetTimeZoneTime(objp.OrderedDate);
                                                    objcontpar.TestType = objp.TestType;
                                                    objcontpar.TestID = objp.TestID;
                                                    objcontpar.TestName = objp.TestName;
                                                    objcontpar.TestValueType = objp.TestValueType;
                                                    objcontpar.TestValue = objp.TestValue;
                                                    objcontpar.UOMCode = objp.UOMCode;
                                                    objcontpar.MethodName = objp.MethodName;
                                                    objcontpar.ReferenceRange =  objp.ReferenceRange.Contains("<?xml") ? ParseXML(objp.ReferenceRange) : objp.ReferenceRange;
                                                    objcontpar.IsAbnormal = objp.IsAbnormal;
                                                    objcontpar.ResultCapturedAt = GetTimeZoneTime(objp.ResultCapturedAt);
                                                    objcontpar.TestStatus = objp.TestStatus;
                                                    objcontpar.MedicalRemarks = objp.MedicalRemarks;
                                                    objcontpar.InterpretationNotes = objp.InterpretationNotes;
                                                    objcontpar.ProcessingType = objp.ProcessingType;
                                                    objcontpar.ProcessingLocation = objp.ProcessingLocation;
                                                    objcontpar.DeviceID = objp.DeviceID;
                                                    objcontpar.LotNumber = objp.LotNumber;
                                                    objcontpar.CreatedAt = GetTimeZoneTime(objp.CreatedAt);
                                                    objcontpar.UpdatedAt = GetTimeZoneTime(objp.UpdatedAt);
                                                    objcontpar.DepartmentName = objp.DepartmentName;
                                                    objcontpar.DeltaValue = objp.DeltaValue;
                                                    objcontpar.UserID = objp.UserID;
                                                    objcontpar.UserName = objp.UserName;
                                                    objcontpar.SampleName = objp.SampleName;
                                                    objcontpar.ConversionRange = objp.ConversionRange.Contains("<?xml") ? ParseXML(tall.ConversionRange) : tall.ConversionRange;
                                                    objcontpar.ConversionValue = objp.ConversionValue;
                                                    objcontpar.ConversionUnit = objp.ConversionUnit;
                                                    objcontpar.Nonreportable = objp.Nonreportable;
                                                    objcontpar.ReportName = objp.ReportName;
                                                    lstpkgcontpar.Add(objcontpar);
                                                }
                                            }

                                            objcont1.ParameterListInfo = lstpkgcontpar;
                                            lstpkgcont.Add(objcont1);
                                        }
                                        objgrp.OrderContentListInfo = lstpkgcont;
                                        if (!lstAllOrder.Exists(p => p.TestID == objgrp.TestID && p.TestType == objgrp.TestType))
                                            lstAllOrder.Add(objgrp);
                                    }
                                   
                                }
                            }
                            if (s.TestType == "PKG")// && s.TestID == inv.PKGID)
                            {
                                foreach (TestOrderVisitDetails inv in lstPatOrderDetails)
                                {
                                    if (s.TestID == inv.PKGID)
                                    {
                                        TestOrder objpkg = new TestOrder();
                                        TestOrderContentVisit objpkgcnt = new TestOrderContentVisit();
                                        TestOrderVisit objpkgparam = new TestOrderVisit();
                                        objpkg.PatientVisitID = inv.PatientVisitID;
                                        objpkg.ExternalVisitID = inv.ExternalVisitID;
                                        objpkg.TestID = s.TestID;
                                        objpkg.TestCode = s.TestCode;
                                        objpkg.OrderedDate = GetTimeZoneTime(s.OrderedDate);
                                        objpkg.TestType = s.TestType;
                                        objpkg.TestName = s.TestName;
                                        objpkg.TestValueType = s.TestValueType;
                                        objpkg.TestValue = s.TestValue;
                                        objpkg.UOMCode = s.UOMCode;
                                        objpkg.MethodName = s.MethodName;
                                        objpkg.ReferenceRange = s.ReferenceRange.Contains("<?xml") ? ParseXML(s.ReferenceRange) : s.ReferenceRange;
                                        objpkg.IsAbnormal = s.IsAbnormal;
                                        objpkg.ResultCapturedAt = GetTimeZoneTime(s.ResultCapturedAt);
                                        objpkg.TestStatus = s.TestStatus;
                                        objpkg.MedicalRemarks = s.MedicalRemarks;
                                        objpkg.InterpretationNotes = s.InterpretationNotes;
                                        objpkg.ProcessingType = s.ProcessingType;
                                        objpkg.ProcessingLocation = s.ProcessingLocation;
                                        objpkg.DeviceID = s.DeviceID;
                                        objpkg.LotNumber = s.LotNumber;
                                        objpkg.CreatedAt = GetTimeZoneTime(s.CreatedAt);
                                        objpkg.UpdatedAt = GetTimeZoneTime(s.UpdatedAt);
                                        objpkg.DepartmentName = s.DepartmentName;
                                        objpkg.DeltaValue = s.DeltaValue;
                                        objpkg.UserID = s.UserID;
                                        objpkg.UserName = s.UserName;
                                        objpkg.SampleName = s.SampleName;
                                        objpkg.ConversionRange = s.ConversionRange.Contains("<?xml") ? ParseXML(s.ConversionRange) : s.ConversionRange;
                                        objpkg.ConversionValue = s.ConversionValue;
                                        objpkg.ConversionUnit = s.ConversionUnit;
                                        objpkg.Nonreportable = s.Nonreportable;
                                        objpkg.ReportName = s.ReportName;
                                        List<TestOrderContentVisit> lstpkg = new List<TestOrderContentVisit>();
                                        var Contentpkg = lstPatOrderDetails.FindAll(p => p.PKGID == inv.PKGID && p.GroupID == "0");
                                        //  var Contentpkgparam = lstPatOrderDetails.FindAll(p => p.GroupID == inv.GroupID);
                                        var Contentpkgparam = lstPatOrderDetails.GroupBy(test => test.GroupID)
                                                     .Select(grp => grp.First())
                                                     .Where(t => t.GroupID != "0" && t.PKGID != "0" && t.PKGID==inv.PKGID)
                                                       .ToList();
                                        var Contentpkgparam1 = lstPatOrderDetails.FindAll(p => p.PKGID == inv.PKGID);
                                        List<TestOrderContentVisit> lstpkgcont = new List<TestOrderContentVisit>();

                                        foreach (TestOrderVisitDetails tall in Contentpkg)
                                        {
                                            TestOrderContentVisit objcont = new TestOrderContentVisit();
                                            objcont.TestCode = tall.TestCode;
                                            objcont.OrderedDate = GetTimeZoneTime(tall.OrderedDate);
                                            objcont.TestType = tall.TestType;
                                            objcont.TestID = tall.TestID;
                                            objcont.TestName = tall.TestName;
                                            objcont.TestValueType = tall.TestValueType;
                                            objcont.TestValue = tall.TestValue;
                                            objcont.UOMCode = tall.UOMCode;
                                            objcont.MethodName = tall.MethodName;
                                            objcont.ReferenceRange = tall.ReferenceRange.Contains("<?xml") ? ParseXML(tall.ReferenceRange) : tall.ReferenceRange;
                                            objcont.IsAbnormal = tall.IsAbnormal;
                                            objcont.ResultCapturedAt = GetTimeZoneTime(tall.ResultCapturedAt);
                                            objcont.TestStatus = tall.TestStatus;
                                            objcont.MedicalRemarks = tall.MedicalRemarks;
                                            objcont.InterpretationNotes = tall.InterpretationNotes;
                                            objcont.ProcessingType = tall.ProcessingType;
                                            objcont.ProcessingLocation = tall.ProcessingLocation;
                                            objcont.DeviceID = tall.DeviceID;
                                            objcont.LotNumber = tall.LotNumber;
                                            objcont.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                            objcont.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                            objcont.DepartmentName = tall.DepartmentName;
                                            objcont.DeltaValue = tall.DeltaValue;
                                            objcont.UserID = tall.UserID;
                                            objcont.UserName = tall.UserName;
                                            objcont.SampleName = tall.SampleName;
                                            objcont.ConversionRange = tall.ConversionRange.Contains("<?xml") ? ParseXML(tall.ConversionRange) : tall.ConversionRange;
                                            objcont.ConversionValue = tall.ConversionValue;
                                            objcont.ConversionUnit = tall.ConversionUnit;
                                            objcont.Nonreportable = tall.Nonreportable;
                                            objcont.ReportName = tall.ReportName;
                                            lstpkgcont.Add(objcont);

                                        }

                                        foreach (TestOrderVisitDetails tall in Contentpkgparam)
                                        {
                                            TestOrderContentVisit objcont1 = new TestOrderContentVisit();
                                            objcont1.TestCode = tall.GroupCode;
                                            objcont1.OrderedDate = GetTimeZoneTime(tall.OrderedDate);
                                            objcont1.TestType = "GRP";
                                            objcont1.TestID = tall.GroupID;
                                            objcont1.TestName = tall.GroupName;
                                            objcont1.TestValueType = tall.TestValueType;
                                            objcont1.TestValue = "";
                                            objcont1.UOMCode = tall.UOMCode;
                                            objcont1.MethodName = tall.MethodName;
                                            objcont1.ReferenceRange = tall.ReferenceRange.Contains("<?xml") ? ParseXML(tall.ReferenceRange) : tall.ReferenceRange;
                                            objcont1.IsAbnormal = tall.IsAbnormal;
                                            objcont1.ResultCapturedAt = GetTimeZoneTime(tall.ResultCapturedAt);
                                            objcont1.TestStatus = tall.TestStatus;
                                            objcont1.MedicalRemarks = tall.MedicalRemarks;
                                            objcont1.InterpretationNotes = tall.InterpretationNotes;
                                            objcont1.ProcessingType = tall.ProcessingType;
                                            objcont1.ProcessingLocation = tall.ProcessingLocation;
                                            objcont1.DeviceID = tall.DeviceID;
                                            objcont1.LotNumber = tall.LotNumber;
                                            objcont1.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                            objcont1.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                            objcont1.DepartmentName = tall.DepartmentName;
                                            objcont1.DeltaValue = "";
                                            objcont1.UserID = tall.UserID;
                                            objcont1.UserName = tall.UserName;
                                            objcont1.SampleName = tall.SampleName;
                                            objcont1.ConversionRange = tall.ConversionRange.Contains("<?xml") ? ParseXML(tall.ConversionRange) : tall.ConversionRange;
                                            objcont1.ConversionValue = tall.ConversionValue;
                                            objcont1.ConversionUnit = tall.ConversionUnit;
                                            objcont1.Nonreportable = "";// tall.Nonreportable;
                                            objcont1.ReportName = tall.ReportName;
                                            List<TestOrderVisit> lstpkgcontpar = new List<TestOrderVisit>();
                                            foreach (TestOrderVisitDetails objp in Contentpkgparam1)
                                            {
                                                TestOrderVisit objcontpar = new TestOrderVisit();
                                                if (tall.GroupID == objp.GroupID)// && objp.SubGroupID == "0")
                                                {
                                                    objcontpar.TestCode = objp.TestCode;
                                                    objcontpar.OrderedDate = GetTimeZoneTime(objp.OrderedDate);
                                                    objcontpar.TestType = objp.TestType;
                                                    objcontpar.TestID = objp.TestID;
                                                    objcontpar.TestName = objp.TestName;
                                                    objcontpar.TestValueType = objp.TestValueType;
                                                    objcontpar.TestValue = objp.TestValue;
                                                    objcontpar.UOMCode = objp.UOMCode;
                                                    objcontpar.MethodName = objp.MethodName;
                                                    objcontpar.ReferenceRange = objp.ReferenceRange.Contains("<?xml") ? ParseXML(objp.ReferenceRange) : objp.ReferenceRange;
                                                    objcontpar.IsAbnormal = objp.IsAbnormal;
                                                    objcontpar.ResultCapturedAt = GetTimeZoneTime(objp.ResultCapturedAt);
                                                    objcontpar.TestStatus = objp.TestStatus;
                                                    objcontpar.MedicalRemarks = objp.MedicalRemarks;
                                                    objcontpar.InterpretationNotes = objp.InterpretationNotes;
                                                    objcontpar.ProcessingType = objp.ProcessingType;
                                                    objcontpar.ProcessingLocation = objp.ProcessingLocation;
                                                    objcontpar.DeviceID = objp.DeviceID;
                                                    objcontpar.LotNumber = objp.LotNumber;
                                                    objcontpar.CreatedAt = GetTimeZoneTime(objp.CreatedAt);
                                                    objcontpar.UpdatedAt = GetTimeZoneTime(objp.UpdatedAt);
                                                    objcontpar.DepartmentName = objp.DepartmentName;
                                                    objcontpar.DeltaValue = objp.DeltaValue;
                                                    objcontpar.UserID = objp.UserID;
                                                    objcontpar.UserName = objp.UserName;
                                                    objcontpar.SampleName = objp.SampleName;
                                                    objcontpar.ConversionRange = objp.ConversionRange.Contains("<?xml") ? ParseXML(objp.ConversionRange) : objp.ConversionRange; 
                                                    objcontpar.ConversionValue = objp.ConversionValue;
                                                    objcontpar.ConversionUnit = objp.ConversionUnit;
                                                    objcontpar.Nonreportable = objp.Nonreportable;
                                                    objcontpar.ReportName = objp.ReportName;
                                                    lstpkgcontpar.Add(objcontpar);
                                                } 
                                            }

                                            objcont1.ParameterListInfo = lstpkgcontpar;
                                            lstpkgcont.Add(objcont1);
                                        }
                                        objpkg.OrderContentListInfo = lstpkgcont;
                                        if (!lstAllOrder.Exists(p => p.TestID == objpkg.TestID && p.TestType == objpkg.TestType))
                                            lstAllOrder.Add(objpkg);
                                    }
                                }
                            }
                        }
                        int ordercount = 0;
                        if(lstAllOrder.Count >0)
                        {
                            ordercount = lstAllOrder.Count;
                        }

                      
                        List<PatientResultPDF> lstresultPDF = new List<PatientResultPDF>();
                        string PathwithfileName = string.Empty;
                        string pVisitNumber = lstPatDetail[0].OrderID;

                        byte[] filepathByte = null;
                        byte[] OutfilepathByte = null;

                        returnCode = new LIMSAPI_BL().GetPatientPDFfile(OrgCode, 0, pVisitNumber, out lstresultPDF);
                        if (returnCode != -1)
                        {
                            if (lstresultPDF.Count > 0 && lstresultPDF != null)
                            {
                                string folderroot = lstresultPDF[0].FileFolder + lstresultPDF[0].FilePath;
                                string Newroot = string.Empty;
                                string root = string.Empty;
                                
                                var myList = new List<string>();
                                int cnt = 0;
                                string outsource = string.Empty;
                                if (!System.IO.Directory.Exists(folderroot))
                                {
                                    System.IO.Directory.CreateDirectory(folderroot);
                                }
                                foreach (PatientResultPDF objpdf in lstresultPDF)
                                {
                                    if (objpdf.FileType.ToLower() == "outsource")
                                    {
                                        outsource = "Y";
                                    }
                                    if (objpdf.FileType.ToLower() == "pdf")
                                    {
                                        var fileName = Path.GetFileName(objpdf.FilePathName);
                                        PathwithfileName = objpdf.FilePathName;//.Replace("/", ""); 
                                        //root = objpdf.FileFolder + objpdf.FilePath.Replace('/', '\\') + objpdf.FileName;
                                        //Newroot = objpdf.FileFolder + objpdf.FilePath.Replace("REPORT", "OUTSOURCEREPORT");
                                        if (File.Exists(PathwithfileName))
                                        {
                                            filepathByte = File.ReadAllBytes(PathwithfileName);
                                        }

                                    }
                                    else
                                    {
                                        root = objpdf.FileFolder + objpdf.FilePath.Replace('/', '\\') + objpdf.FileName;
                                        Newroot = objpdf.FileFolder + objpdf.FilePath.Replace("Outsource_Docs", "OUTSOURCEREPORT");
                                        myList.Add(objpdf.FilePathName);
                                    }
                                    
                                }
                                if (outsource == "Y")
                                {


                                    var myArray = myList.ToArray();
                                    byte[] bytes = concatAndAddContent(myArray);
                                    string OrginalFileName = Newroot + Path.GetFileName(root);
                                    string TempFileName = Newroot + Path.GetFileName(root);
                                    TempFileName = TempFileName.Replace(".pdf", "temp.pdf");
                                    bool _FileUse = false;
                                    int ThreadCount = 1000;
                                    if (!System.IO.Directory.Exists(Newroot))
                                    {
                                        System.IO.Directory.CreateDirectory(Newroot);
                                    }

                                    while (!_FileUse)
                                    {
                                        try
                                        {
                                            using (FileStream fsNew = new FileStream(TempFileName, FileMode.Create, FileAccess.Write, FileShare.Read))
                                            {
                                                byte[] finalresult = new byte[byte.MaxValue];
                                                fsNew.Write(bytes, 0, bytes.Length);
                                                fsNew.Close();
                                            }
                                            AddPageNumber(TempFileName, OrginalFileName);
                                            Thread.Sleep(1000);
                                            _FileUse = true;
                                        }
                                        catch (Exception ex)
                                        {
                                            Thread.Sleep(1000);
                                            _FileUse = false;
                                            if (ThreadCount == 30000)
                                            {
                                                _FileUse = true;
                                            }

                                        }
                                    }
                                    var root1 = OrginalFileName;
                                    if (File.Exists(root1))
                                    {
                                        OutfilepathByte = File.ReadAllBytes(root1);
                                        File.Delete(root1);
                                    } 
                                }
                            }
                        }


                        //lstAllOrder[ordercount - 1].ResultAsPdf = filepathByte;
                        ObjOrder.ResultAsPdf = filepathByte;
                        ObjOrder.OutsourceAsPdf = OutfilepathByte;
                        ObjOrder.OrderInfo = lstAllOrder;
                    }
                    actionResult = Ok(ObjOrder);
                } 
                else
                {
                    actionResult = Ok("While fetching the data getting an Error.");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured" + ex.ToString());
                UpdatePatientOrderInvestigation(OrgCode, VisitNumber, "Approve");
            }

            return actionResult;
        }
        /// <summary>
        /// This API will provide the Orgwise bookingstatus 
        /// </summary>
        /// <returns>success</returns>
        [ResponseType(typeof(OrgDetails))]
        [HttpGet]
        [Route("Api/Orders/OrgBookingStatusInformation")]
        public IHttpActionResult GetOrgBookingStatus(int OrgID)
        {
            //System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            //string pOrgCode = string.Empty;

            //if (headers.Contains("orgcode"))
            //{
            //    pOrgCode = headers.GetValues("orgcode").First();
            //}

            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<OrgDetails> lstOrgDetails = new List<OrgDetails>();

            try
            {
                returnCode = new LIMSAPI_BL().GetOrgBookingStatus(OrgID, out lstOrgDetails);

                if (returnCode != -1)
                {
                    if (lstOrgDetails.Count > 0 && lstOrgDetails != null)
                    {
                        OrgDetails objOrgDetails = new OrgDetails();

                        objOrgDetails.SampleReceived = lstOrgDetails[0].SampleReceived;
                        objOrgDetails.Approve = lstOrgDetails[0].Approve;
                        objOrgDetails.SampleCollected = lstOrgDetails[0].SampleCollected;
                        objOrgDetails.Completed = lstOrgDetails[0].Completed;
                        objOrgDetails.Pending = lstOrgDetails[0].Pending;
                        objOrgDetails.Validate = lstOrgDetails[0].Validate;
                        actionResult = Ok(objOrgDetails);
                    }
                    else
                    {
                        actionResult = Ok("Invalid Request");
                    }
                }
                else
                {
                    actionResult = Ok("Result Not Found");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }
            return actionResult;
        }

        public string GetTimeZoneTime(DateTime SDate)
        {
            
            string t = string.Empty;
            if (SDate != null && SDate.ToString("yyyy")!="0001")
            {
                TimeZoneInfo tzObject1 = TimeZoneInfo.FindSystemTimeZoneById(TimeZone);
                DateTime tstTime2 = TimeZoneInfo.ConvertTime(SDate, tzObject1, tzObject1);
                DateTime ut1 = TimeZoneInfo.ConvertTimeToUtc(tstTime2, tzObject1);

                //TimeZoneInfo tzObject2 = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                //DateTime tstTime3 = TimeZoneInfo.ConvertTime(ut1, TimeZoneInfo.Utc, tzObject2); 
                t = ut1.ToString("o", CultureInfo.InvariantCulture);
            }
            return t;
        }
        public string ParseXML(string xmlData)
        {
            //referencerange~Reference Range
            string code = "referencerange";
            XElement xe = XElement.Parse(xmlData);
            string ReferenceRange = string.Empty;
            string ReferenceRangeString = string.Empty; 
            Int32 itemCount = 0;
           
            var ageRange = from age in xe.Elements(code).Elements("property")
                           where (string)age.Attribute("type") == "age"
                           select age;
            var commonRange = from common in xe.Elements(code).Elements("property")
                              where (string)common.Attribute("type") == "common"
                              select common;

            var otherRange = from otherWithNumeric in xe.Elements(code).Elements("property")
                             where (string)otherWithNumeric.Attribute("type") == "other" && (string)otherWithNumeric.Attribute("ResultType") == null && (string)otherWithNumeric.Attribute("agetype") == null
                             select otherWithNumeric;

            var otherRangeWithNumeric = from otherWithNumeric in xe.Elements(code).Elements("property")
                                        where (string)otherWithNumeric.Attribute("type") == "other" && (string)otherWithNumeric.Attribute("ResultType") == "Numeric" && (string)otherWithNumeric.Attribute("agetype") == null
                                        select otherWithNumeric;

            var otherRangeWithText = from otherWithText in xe.Elements(code).Elements("property")
                                     where (string)otherWithText.Attribute("type") == "other" && (string)otherWithText.Attribute("ResultType") == "Text" && (string)otherWithText.Attribute("agetype") == null
                                     select otherWithText;

            var otherNumericWithAge = from otherWithNumeric in xe.Elements(code).Elements("property")
                                      where (string)otherWithNumeric.Attribute("type") == "other" && (string)otherWithNumeric.Attribute("ResultType") == "Numeric" && (string)otherWithNumeric.Attribute("agetype") != null
                                      select otherWithNumeric;

            var otherTextWithAge = from otherWithText in xe.Elements(code).Elements("property")
                                   where (string)otherWithText.Attribute("type") == "other" && (string)otherWithText.Attribute("ResultType") == "Text" && (string)otherWithText.Attribute("agetype") != null
                                   select otherWithText;



            if (ageRange != null && ageRange.Count() > 0)
            {
                foreach (var lst in ageRange)
                {
                    if (lst.Element("lst") != null)
                    {
                        if (lst.Element("lst").Attribute("mode").Value != "ref")
                        {

                            ReferenceRange += lst.Element("lst").Attribute("gender").Value + ": " + ConvertStringOptr("lst") + " " + lst.Element("lst").Value + " " + lst.Element("lst").Attribute("agetype").Value + " : " + (ConvertStringOptr(lst.Element("lst").Attribute("mode").Value)) + " " + lst.Element("lst").Attribute("value").Value + (lst.Element("lst").Attribute("data") != null && lst.Element("lst").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("lst").Attribute("data").Value : string.Empty) + (lst.Element("lst").Attribute("result") != null && lst.Element("lst").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("lst").Attribute("result").Value : string.Empty) + (lst.Element("lst").Attribute("device") != null && lst.Element("lst").Attribute("device").Value != "" ? " Device: " + lst.Element("lst").Attribute("device").Value : string.Empty) + "<br/>";
                            ReferenceRangeString += lst.Element("lst").Attribute("gender").Value + "~" + ConvertStringOptr("lst") + "~" + lst.Element("lst").Value + "~" + lst.Element("lst").Attribute("agetype").Value + "~" + (ConvertStringOptr(lst.Element("lst").Attribute("mode").Value)) + "~" + lst.Element("lst").Attribute("value").Value + "~" + (lst.Element("lst").Attribute("data") != null ? lst.Element("lst").Attribute("data").Value : string.Empty) + "~" + (lst.Element("lst").Attribute("result") != null ? lst.Element("lst").Attribute("result").Value : string.Empty) + "~" + (lst.Element("lst").Attribute("device") != null ? lst.Element("lst").Attribute("device").Value : string.Empty) + "^";

                        }
                        else
                        {

                            ReferenceRange += lst.Element("lst").Attribute("value").Value + "<br/>";
                            ReferenceRangeString += lst.Element("lst").Attribute("gender").Value + "~" + ConvertStringOptr("lst") + "~" + lst.Element("lst").Value + "~" + lst.Element("lst").Attribute("agetype").Value + "~" + (ConvertStringOptr(lst.Element("lst").Attribute("mode").Value)) + "~" + lst.Element("lst").Attribute("value").Value + "~~~~" + "^";

                        }
                    }
                    if (lst.Element("lsq") != null)
                    {
                        if (lst.Element("lsq").Attribute("mode").Value != "ref")
                        {

                            ReferenceRange += lst.Element("lsq").Attribute("gender").Value + ": " + ConvertStringOptr("lsq") + " " + lst.Element("lsq").Value + " " + lst.Element("lsq").Attribute("agetype").Value + " : " + (ConvertStringOptr(lst.Element("lsq").Attribute("mode").Value)) + " " + lst.Element("lsq").Attribute("value").Value + (lst.Element("lsq").Attribute("data") != null && lst.Element("lsq").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("lsq").Attribute("data").Value : string.Empty) + (lst.Element("lsq").Attribute("result") != null && lst.Element("lsq").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("lsq").Attribute("result").Value : string.Empty) + (lst.Element("lsq").Attribute("device") != null && lst.Element("lsq").Attribute("device").Value != "" ? " Device: " + lst.Element("lsq").Attribute("device").Value : string.Empty) + "<br/>";
                            ReferenceRangeString += lst.Element("lsq").Attribute("gender").Value + "~" + ConvertStringOptr("lsq") + "~" + lst.Element("lsq").Value + "~" + lst.Element("lsq").Attribute("agetype").Value + "~" + (ConvertStringOptr(lst.Element("lsq").Attribute("mode").Value)) + "~" + lst.Element("lsq").Attribute("value").Value + "~" + (lst.Element("lsq").Attribute("data") != null ? lst.Element("lsq").Attribute("data").Value : string.Empty) + "~" + (lst.Element("lsq").Attribute("result") != null ? lst.Element("lsq").Attribute("result").Value : string.Empty) + "~" + (lst.Element("lsq").Attribute("device") != null ? lst.Element("lsq").Attribute("device").Value : string.Empty) + "^";

                        }
                        else
                        {

                            ReferenceRange += lst.Element("lsq").Attribute("value").Value + "<br/>";
                            ReferenceRangeString += lst.Element("lsq").Attribute("gender").Value + "~" + ConvertStringOptr("lsq") + "~" + lst.Element("lsq").Value + "~" + lst.Element("lsq").Attribute("agetype").Value + "~" + (ConvertStringOptr(lst.Element("lsq").Attribute("mode").Value)) + "~" + lst.Element("lsq").Attribute("value").Value + "~~~~" + "^";

                        }
                    }
                    if (lst.Element("eql") != null)
                    {
                        if (lst.Element("eql").Attribute("mode").Value != "ref")
                        {

                            ReferenceRange += lst.Element("eql").Attribute("gender").Value + ": " + ConvertStringOptr("eql") + " " + lst.Element("eql").Value + " " + lst.Element("eql").Attribute("agetype").Value + " : " + (ConvertStringOptr(lst.Element("eql").Attribute("mode").Value)) + " " + lst.Element("eql").Attribute("value").Value + (lst.Element("eql").Attribute("data") != null && lst.Element("eql").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("eql").Attribute("data").Value : string.Empty) + (lst.Element("eql").Attribute("result") != null && lst.Element("eql").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("eql").Attribute("result").Value : string.Empty) + (lst.Element("eql").Attribute("device") != null && lst.Element("eql").Attribute("device").Value != "" ? " Device: " + lst.Element("eql").Attribute("device").Value : string.Empty) + "<br/>";
                            ReferenceRangeString += lst.Element("eql").Attribute("gender").Value + "~" + ConvertStringOptr("eql") + "~" + lst.Element("eql").Value + "~" + lst.Element("eql").Attribute("agetype").Value + "~" + (ConvertStringOptr(lst.Element("eql").Attribute("mode").Value)) + "~" + lst.Element("eql").Attribute("value").Value + "~" + (lst.Element("eql").Attribute("data") != null ? lst.Element("eql").Attribute("data").Value : string.Empty) + "~" + (lst.Element("eql").Attribute("result") != null ? lst.Element("eql").Attribute("result").Value : string.Empty) + "~" + (lst.Element("eql").Attribute("device") != null ? lst.Element("eql").Attribute("device").Value : string.Empty) + "^";

                        }
                        else
                        {

                            ReferenceRange += lst.Element("eql").Attribute("value").Value + "<br/>";
                            ReferenceRangeString += lst.Element("eql").Attribute("gender").Value + "~" + ConvertStringOptr("eql") + "~" + lst.Element("eql").Value + "~" + lst.Element("eql").Attribute("agetype").Value + "~" + (ConvertStringOptr(lst.Element("eql").Attribute("mode").Value)) + "~" + lst.Element("eql").Attribute("value").Value + "~~~~" + "^";

                        }
                    }
                    if (lst.Element("grt") != null)
                    {
                        if (lst.Element("grt").Attribute("mode").Value != "ref")
                        {

                            ReferenceRange += lst.Element("grt").Attribute("gender").Value + ": " + ConvertStringOptr("grt") + " " + lst.Element("grt").Value + " " + lst.Element("grt").Attribute("agetype").Value + " : " + (ConvertStringOptr(lst.Element("grt").Attribute("mode").Value)) + " " + lst.Element("grt").Attribute("value").Value + (lst.Element("grt").Attribute("data") != null && lst.Element("grt").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("grt").Attribute("data").Value : string.Empty) + (lst.Element("grt").Attribute("result") != null && lst.Element("grt").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("grt").Attribute("result").Value : string.Empty) + (lst.Element("grt").Attribute("device") != null && lst.Element("grt").Attribute("device").Value != "" ? " Device: " + lst.Element("grt").Attribute("device").Value : string.Empty) + "<br/>";
                            ReferenceRangeString += lst.Element("grt").Attribute("gender").Value + "~" + ConvertStringOptr("grt") + "~" + lst.Element("grt").Value + "~" + lst.Element("grt").Attribute("agetype").Value + "~" + (ConvertStringOptr(lst.Element("grt").Attribute("mode").Value)) + "~" + lst.Element("grt").Attribute("value").Value + "~" + (lst.Element("grt").Attribute("data") != null ? lst.Element("grt").Attribute("data").Value : string.Empty) + "~" + (lst.Element("grt").Attribute("result") != null ? lst.Element("grt").Attribute("result").Value : string.Empty) + "~" + (lst.Element("grt").Attribute("device") != null ? lst.Element("grt").Attribute("device").Value : string.Empty) + "^";

                        }

                        else
                        {

                            ReferenceRange += lst.Element("grt").Attribute("value").Value + "<br/>";
                            ReferenceRangeString += lst.Element("grt").Attribute("gender").Value + "~" + ConvertStringOptr("grt") + "~" + lst.Element("grt").Value + "~" + lst.Element("grt").Attribute("agetype").Value + "~" + (ConvertStringOptr(lst.Element("grt").Attribute("mode").Value)) + "~" + lst.Element("grt").Attribute("value").Value + "~~~~" + "^";

                        }
                    }
                    if (lst.Element("grq") != null)
                    {
                        if (lst.Element("grq").Attribute("mode").Value != "ref")
                        {

                            ReferenceRange += lst.Element("grq").Attribute("gender").Value + ": " + ConvertStringOptr("grq") + " " + lst.Element("grq").Value + " " + lst.Element("grq").Attribute("agetype").Value + " : " + (ConvertStringOptr(lst.Element("grq").Attribute("mode").Value)) + " " + lst.Element("grq").Attribute("value").Value + (lst.Element("grq").Attribute("data") != null && lst.Element("grq").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("grq").Attribute("data").Value : string.Empty) + (lst.Element("grq").Attribute("result") != null && lst.Element("grq").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("grq").Attribute("result").Value : string.Empty) + (lst.Element("grq").Attribute("device") != null && lst.Element("grq").Attribute("device").Value != "" ? " Device: " + lst.Element("grq").Attribute("device").Value : string.Empty) + "<br/>";
                            ReferenceRangeString += lst.Element("grq").Attribute("gender").Value + "~" + ConvertStringOptr("grq") + "~" + lst.Element("grq").Value + "~" + lst.Element("grq").Attribute("agetype").Value + "~" + (ConvertStringOptr(lst.Element("grq").Attribute("mode").Value)) + "~" + lst.Element("grq").Attribute("value").Value + "~" + (lst.Element("grq").Attribute("data") != null ? lst.Element("grq").Attribute("data").Value : string.Empty) + "~" + (lst.Element("grq").Attribute("result") != null ? lst.Element("grq").Attribute("result").Value : string.Empty) + "~" + (lst.Element("grq").Attribute("device") != null ? lst.Element("grq").Attribute("device").Value : string.Empty) + "^";

                        }
                        else
                        {

                            ReferenceRange += lst.Element("grq").Attribute("value").Value + "<br/>";
                            ReferenceRangeString += lst.Element("grq").Attribute("gender").Value + "~" + ConvertStringOptr("grq") + "~" + lst.Element("grq").Value + "~" + lst.Element("grq").Attribute("agetype").Value + "~" + (ConvertStringOptr(lst.Element("grq").Attribute("mode").Value)) + "~" + lst.Element("grq").Attribute("value").Value + "~~~~" + "^";

                        }
                    }
                    if (lst.Element("btw") != null)
                    {
                        if (lst.Element("btw").Attribute("mode").Value != "ref")
                        {

                            ReferenceRange += lst.Element("btw").Attribute("gender").Value + ": " + ConvertStringOptr("btw") + " " + lst.Element("btw").Value + " " + lst.Element("btw").Attribute("agetype").Value + " : " + (ConvertStringOptr(lst.Element("btw").Attribute("mode").Value)) + " " + lst.Element("btw").Attribute("value").Value + (lst.Element("btw").Attribute("data") != null && lst.Element("btw").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("btw").Attribute("data").Value : string.Empty) + (lst.Element("btw").Attribute("result") != null && lst.Element("btw").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("btw").Attribute("result").Value : string.Empty) + (lst.Element("btw").Attribute("device") != null && lst.Element("btw").Attribute("device").Value != "" ? " Device: " + lst.Element("btw").Attribute("device").Value : string.Empty) + "<br/>";
                            ReferenceRangeString += lst.Element("btw").Attribute("gender").Value + "~" + ConvertStringOptr("btw") + "~" + lst.Element("btw").Value + "~" + lst.Element("btw").Attribute("agetype").Value + "~" + (ConvertStringOptr(lst.Element("btw").Attribute("mode").Value)) + "~" + lst.Element("btw").Attribute("value").Value + "~" + (lst.Element("btw").Attribute("data") != null ? lst.Element("btw").Attribute("data").Value : string.Empty) + "~" + (lst.Element("btw").Attribute("result") != null ? lst.Element("btw").Attribute("result").Value : string.Empty) + "~" + (lst.Element("btw").Attribute("device") != null ? lst.Element("btw").Attribute("device").Value : string.Empty) + "^";

                        }
                        else
                        {

                            ReferenceRange += lst.Element("btw").Attribute("value").Value + "<br/>";
                            ReferenceRangeString += lst.Element("btw").Attribute("gender").Value + "~" + ConvertStringOptr("btw") + "~" + lst.Element("btw").Value + "~" + lst.Element("btw").Attribute("agetype").Value + "~" + (ConvertStringOptr(lst.Element("btw").Attribute("mode").Value)) + "~" + lst.Element("btw").Attribute("value").Value + "~~~~" + "^";

                        }
                    }
                }
                ReferenceRangeString += "|Age@";
            }

            if (commonRange != null && commonRange.Count() > 0)
            {
                foreach (var lst in commonRange)
                {
                    if (lst.Element("lst") != null)
                    {

                        ReferenceRange += lst.Element("lst").Attribute("value").Value + ": < " + lst.Element("lst").Value + (lst.Element("lst").Attribute("data") != null && lst.Element("lst").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("lst").Attribute("data").Value : string.Empty) + (lst.Element("lst").Attribute("result") != null && lst.Element("lst").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("lst").Attribute("result").Value : string.Empty) + (lst.Element("lst").Attribute("device") != null && lst.Element("lst").Attribute("device").Value != "" ? " Device: " + lst.Element("lst").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("lst").Attribute("value").Value + "~" + "<" + "~" + lst.Element("lst").Value + "~" + (lst.Element("lst").Attribute("data") != null ? lst.Element("lst").Attribute("data").Value : string.Empty) + "~" + (lst.Element("lst").Attribute("result") != null ? lst.Element("lst").Attribute("result").Value : string.Empty) + "~" + (lst.Element("lst").Attribute("device") != null ? lst.Element("lst").Attribute("device").Value : string.Empty) + "^";

                    }

                    if (lst.Element("lsq") != null)
                    {

                        ReferenceRange += lst.Element("lsq").Attribute("value").Value + ": <= " + lst.Element("lsq").Value + (lst.Element("lsq").Attribute("data") != null && lst.Element("lsq").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("lsq").Attribute("data").Value : string.Empty) + (lst.Element("lsq").Attribute("result") != null && lst.Element("lsq").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("lsq").Attribute("result").Value : string.Empty) + (lst.Element("lsq").Attribute("device") != null && lst.Element("lsq").Attribute("device").Value != "" ? " Device: " + lst.Element("lsq").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("lsq").Attribute("value").Value + "~" + "<=" + "~" + lst.Element("lsq").Value + "~" + (lst.Element("lsq").Attribute("data") != null ? lst.Element("lsq").Attribute("data").Value : string.Empty) + "~" + (lst.Element("lsq").Attribute("result") != null ? lst.Element("lsq").Attribute("result").Value : string.Empty) + "~" + (lst.Element("lsq").Attribute("device") != null ? lst.Element("lsq").Attribute("device").Value : string.Empty) + "^";

                    }

                    if (lst.Element("eql") != null)
                    {

                        ReferenceRange += lst.Element("eql").Attribute("value").Value + ": = " + lst.Element("eql").Value + (lst.Element("eql").Attribute("data") != null && lst.Element("eql").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("eql").Attribute("data").Value : string.Empty) + (lst.Element("eql").Attribute("result") != null && lst.Element("eql").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("eql").Attribute("result").Value : string.Empty) + (lst.Element("eql").Attribute("device") != null && lst.Element("eql").Attribute("device").Value != "" ? " Device: " + lst.Element("eql").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("eql").Attribute("value").Value + "~" + "=" + "~" + lst.Element("eql").Value + "~" + (lst.Element("eql").Attribute("data") != null ? lst.Element("eql").Attribute("data").Value : string.Empty) + "~" + (lst.Element("eql").Attribute("result") != null ? lst.Element("eql").Attribute("result").Value : string.Empty) + "~" + (lst.Element("eql").Attribute("device") != null ? lst.Element("eql").Attribute("device").Value : string.Empty) + "^";

                    }

                    if (lst.Element("grt") != null)
                    {

                        ReferenceRange += lst.Element("grt").Attribute("value").Value + ": > " + lst.Element("grt").Value + (lst.Element("grt").Attribute("data") != null && lst.Element("grt").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("grt").Attribute("data").Value : string.Empty) + (lst.Element("grt").Attribute("result") != null && lst.Element("grt").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("grt").Attribute("result").Value : string.Empty) + (lst.Element("grt").Attribute("device") != null && lst.Element("grt").Attribute("device").Value != "" ? " Device: " + lst.Element("grt").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("grt").Attribute("value").Value + "~" + ">" + "~" + lst.Element("grt").Value + "~" + (lst.Element("grt").Attribute("data") != null ? lst.Element("grt").Attribute("data").Value : string.Empty) + "~" + (lst.Element("grt").Attribute("result") != null ? lst.Element("grt").Attribute("result").Value : string.Empty) + "~" + (lst.Element("grt").Attribute("device") != null ? lst.Element("grt").Attribute("device").Value : string.Empty) + "^";

                    }


                    if (lst.Element("grq") != null)
                    {

                        ReferenceRange += lst.Element("grq").Attribute("value").Value + ": => " + lst.Element("grq").Value + (lst.Element("grq").Attribute("data") != null && lst.Element("grq").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("grq").Attribute("data").Value : string.Empty) + (lst.Element("grq").Attribute("result") != null && lst.Element("grq").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("grq").Attribute("result").Value : string.Empty) + (lst.Element("grq").Attribute("device") != null && lst.Element("grq").Attribute("device").Value != "" ? " Device: " + lst.Element("grq").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("grq").Attribute("value").Value + "~" + "=>" + "~" + lst.Element("grq").Value + "~" + (lst.Element("grq").Attribute("data") != null ? lst.Element("grq").Attribute("data").Value : string.Empty) + "~" + (lst.Element("grq").Attribute("result") != null ? lst.Element("grq").Attribute("result").Value : string.Empty) + "~" + (lst.Element("grq").Attribute("device") != null ? lst.Element("grq").Attribute("device").Value : string.Empty) + "^";

                    }


                    if (lst.Element("btw") != null)
                    {

                        ReferenceRange += lst.Element("btw").Attribute("value").Value + ": " + lst.Element("btw").Value + (lst.Element("btw").Attribute("data") != null && lst.Element("btw").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("btw").Attribute("data").Value : string.Empty) + (lst.Element("btw").Attribute("result") != null && lst.Element("btw").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("btw").Attribute("result").Value : string.Empty) + (lst.Element("btw").Attribute("device") != null && lst.Element("btw").Attribute("device").Value != "" ? " Device: " + lst.Element("btw").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("btw").Attribute("value").Value + "~" + ConvertStringOptr("btw") + "~" + lst.Element("btw").Value + "~" + (lst.Element("btw").Attribute("data") != null ? lst.Element("btw").Attribute("data").Value : string.Empty) + "~" + (lst.Element("btw").Attribute("result") != null ? lst.Element("btw").Attribute("result").Value : string.Empty) + "~" + (lst.Element("btw").Attribute("device") != null ? lst.Element("btw").Attribute("device").Value : string.Empty) + "^";

                    }
                    if (lst.Element("ref") != null)
                    {

                        ReferenceRange += lst.Element("ref").Value + "<br/>";
                        ReferenceRangeString += lst.Element("ref").Attribute("value").Value + "~" + ConvertStringOptr("ref") + "~" + lst.Element("ref").Value + "~~~" + "^";

                    }
                }
                ReferenceRangeString += "|Common@";
            }

            if (otherNumericWithAge != null && otherNumericWithAge.Count() > 0)
            {
                foreach (var lst in otherNumericWithAge)
                {
                    string ResulType = "Numeric";

                    if (lst.Element("lst") != null)
                    {

                        ReferenceRange += lst.Element("lst").Attribute("gender").Value + ": " + ConvertStringOptr(lst.Element("lst").Attribute("ageopr").Value) + " " + lst.Element("lst").Attribute("agerange").Value + " " + lst.Element("lst").Attribute("agetype").Value + " : " + lst.Element("lst").Value + ": < " + lst.Element("lst").Attribute("value").Value + (lst.Element("lst").Attribute("data") != null && lst.Element("lst").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("lst").Attribute("data").Value : string.Empty) + (lst.Element("lst").Attribute("result") != null && lst.Element("lst").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("lst").Attribute("result").Value : string.Empty) + (lst.Element("lst").Attribute("device") != null && lst.Element("lst").Attribute("device").Value != "" ? " Device: " + lst.Element("lst").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("lst").Attribute("gender").Value + "~" + lst.Element("lst").Value + "~" + "<" + "~" + lst.Element("lst").Attribute("value").Value + "~" + (lst.Element("lst").Attribute("Normal") != null ? lst.Element("lst").Attribute("Normal").Value : string.Empty) + "~~" + lst.Element("lst").Attribute("agetype").Value + "~" + ConvertStringOptr(lst.Element("lst").Attribute("ageopr").Value) + "~" + lst.Element("lst").Attribute("agerange").Value + "~" + (lst.Element("lst").Attribute("data") != null ? lst.Element("lst").Attribute("data").Value : string.Empty) + "~" + (lst.Element("lst").Attribute("result") != null ? lst.Element("lst").Attribute("result").Value : string.Empty) + "~" + (lst.Element("lst").Attribute("device") != null ? lst.Element("lst").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";

                    }
                    if (lst.Element("lsq") != null)
                    {

                        ReferenceRange += lst.Element("lsq").Attribute("gender").Value + ": " + ConvertStringOptr(lst.Element("lsq").Attribute("ageopr").Value) + " " + lst.Element("lsq").Attribute("agerange").Value + " " + lst.Element("lsq").Attribute("agetype").Value + " : " + lst.Element("lsq").Value + ": <= " + lst.Element("lsq").Attribute("value").Value + (lst.Element("lsq").Attribute("data") != null && lst.Element("lsq").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("lsq").Attribute("data").Value : string.Empty) + (lst.Element("lsq").Attribute("result") != null && lst.Element("lsq").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("lsq").Attribute("result").Value : string.Empty) + (lst.Element("lsq").Attribute("device") != null && lst.Element("lsq").Attribute("device").Value != "" ? " Device: " + lst.Element("lsq").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("lsq").Attribute("gender").Value + "~" + lst.Element("lsq").Value + "~" + "<=" + "~" + lst.Element("lsq").Attribute("value").Value + "~" + (lst.Element("lsq").Attribute("Normal") != null ? lst.Element("lsq").Attribute("Normal").Value : string.Empty) + "~~" + lst.Element("lsq").Attribute("agetype").Value + "~" + ConvertStringOptr(lst.Element("lsq").Attribute("ageopr").Value) + "~" + lst.Element("lsq").Attribute("agerange").Value + "~" + (lst.Element("lsq").Attribute("data") != null ? lst.Element("lsq").Attribute("data").Value : string.Empty) + "~" + (lst.Element("lsq").Attribute("result") != null ? lst.Element("lsq").Attribute("result").Value : string.Empty) + "~" + (lst.Element("lsq").Attribute("device") != null ? lst.Element("lsq").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";

                    }

                    if (lst.Element("eql") != null)
                    {

                        ReferenceRange += lst.Element("eql").Attribute("gender").Value + ": " + ConvertStringOptr(lst.Element("eql").Attribute("ageopr").Value) + " " + lst.Element("eql").Attribute("agerange").Value + " " + lst.Element("eql").Attribute("agetype").Value + " : " + lst.Element("eql").Value + ": = " + lst.Element("eql").Attribute("value").Value + (lst.Element("eql").Attribute("data") != null && lst.Element("eql").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("eql").Attribute("data").Value : string.Empty) + (lst.Element("eql").Attribute("result") != null && lst.Element("eql").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("eql").Attribute("result").Value : string.Empty) + (lst.Element("eql").Attribute("device") != null && lst.Element("eql").Attribute("device").Value != "" ? " Device: " + lst.Element("eql").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("eql").Attribute("gender").Value + "~" + lst.Element("eql").Value + "~" + "=" + "~" + lst.Element("eql").Attribute("value").Value + "~" + (lst.Element("eql").Attribute("Normal") != null ? lst.Element("eql").Attribute("Normal").Value : string.Empty) + "~~" + lst.Element("eql").Attribute("agetype").Value + "~" + ConvertStringOptr(lst.Element("eql").Attribute("ageopr").Value) + "~" + lst.Element("eql").Attribute("agerange").Value + "~" + (lst.Element("eql").Attribute("data") != null ? lst.Element("eql").Attribute("data").Value : string.Empty) + "~" + (lst.Element("eql").Attribute("result") != null ? lst.Element("eql").Attribute("result").Value : string.Empty) + "~" + (lst.Element("eql").Attribute("device") != null ? lst.Element("eql").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";

                    }

                    if (lst.Element("grt") != null)
                    {

                        ReferenceRange += lst.Element("grt").Attribute("gender").Value + ": " + ConvertStringOptr(lst.Element("grt").Attribute("ageopr").Value) + " " + lst.Element("grt").Attribute("agerange").Value + " " + lst.Element("grt").Attribute("agetype").Value + " : " + lst.Element("grt").Value + ": > " + lst.Element("grt").Attribute("value").Value + (lst.Element("grt").Attribute("data") != null && lst.Element("grt").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("grt").Attribute("data").Value : string.Empty) + (lst.Element("grt").Attribute("result") != null && lst.Element("grt").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("grt").Attribute("result").Value : string.Empty) + (lst.Element("grt").Attribute("device") != null && lst.Element("grt").Attribute("device").Value != "" ? " Device: " + lst.Element("grt").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("grt").Attribute("gender").Value + "~" + lst.Element("grt").Value + "~" + ">" + "~" + lst.Element("grt").Attribute("value").Value + "~" + (lst.Element("grt").Attribute("Normal") != null ? lst.Element("grt").Attribute("Normal").Value : string.Empty) + "~~" + lst.Element("grt").Attribute("agetype").Value + "~" + ConvertStringOptr(lst.Element("grt").Attribute("ageopr").Value) + "~" + lst.Element("grt").Attribute("agerange").Value + "~" + (lst.Element("grt").Attribute("data") != null ? lst.Element("grt").Attribute("data").Value : string.Empty) + "~" + (lst.Element("grt").Attribute("result") != null ? lst.Element("grt").Attribute("result").Value : string.Empty) + "~" + (lst.Element("grt").Attribute("device") != null ? lst.Element("grt").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";

                    }

                    if (lst.Element("grq") != null)
                    {

                        ReferenceRange += lst.Element("grq").Attribute("gender").Value + ": " + ConvertStringOptr(lst.Element("grq").Attribute("ageopr").Value) + " " + lst.Element("grq").Attribute("agerange").Value + " " + lst.Element("grq").Attribute("agetype").Value + " : " + lst.Element("grq").Value + ": => " + lst.Element("grq").Attribute("value").Value + (lst.Element("grq").Attribute("data") != null && lst.Element("grq").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("grq").Attribute("data").Value : string.Empty) + (lst.Element("grq").Attribute("result") != null && lst.Element("grq").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("grq").Attribute("result").Value : string.Empty) + (lst.Element("grq").Attribute("device") != null && lst.Element("grq").Attribute("device").Value != "" ? " Device: " + lst.Element("grq").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("grq").Attribute("gender").Value + "~" + lst.Element("grq").Value + "~" + "=>" + "~" + lst.Element("grq").Attribute("value").Value + "~" + (lst.Element("grq").Attribute("Normal") != null ? lst.Element("grq").Attribute("Normal").Value : string.Empty) + "~~" + lst.Element("grq").Attribute("agetype").Value + "~" + ConvertStringOptr(lst.Element("grq").Attribute("ageopr").Value) + "~" + lst.Element("grq").Attribute("agerange").Value + "~" + (lst.Element("grq").Attribute("data") != null ? lst.Element("grq").Attribute("data").Value : string.Empty) + "~" + (lst.Element("grq").Attribute("result") != null ? lst.Element("grq").Attribute("result").Value : string.Empty) + "~" + (lst.Element("grq").Attribute("device") != null ? lst.Element("grq").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";

                    }

                    if (lst.Element("btw") != null)
                    {

                        ReferenceRange += lst.Element("btw").Attribute("gender").Value + ": " + ConvertStringOptr(lst.Element("btw").Attribute("ageopr").Value) + " " + lst.Element("btw").Attribute("agerange").Value + " " + lst.Element("btw").Attribute("agetype").Value + " : " + lst.Element("btw").Value + ": " + lst.Element("btw").Attribute("value").Value + (lst.Element("btw").Attribute("data") != null && lst.Element("btw").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("btw").Attribute("data").Value : string.Empty) + (lst.Element("btw").Attribute("result") != null && lst.Element("btw").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("btw").Attribute("result").Value : string.Empty) + (lst.Element("btw").Attribute("device") != null && lst.Element("btw").Attribute("device").Value != "" ? " Device: " + lst.Element("btw").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("btw").Attribute("gender").Value + "~" + lst.Element("btw").Value + "~" + ConvertStringOptr("btw") + "~" + lst.Element("btw").Attribute("value").Value + "~" + (lst.Element("btw").Attribute("Normal") != null ? lst.Element("btw").Attribute("Normal").Value : string.Empty) + "~~" + lst.Element("btw").Attribute("agetype").Value + "~" + ConvertStringOptr(lst.Element("btw").Attribute("ageopr").Value) + "~" + lst.Element("btw").Attribute("agerange").Value + "~" + (lst.Element("btw").Attribute("data") != null ? lst.Element("btw").Attribute("data").Value : string.Empty) + "~" + (lst.Element("btw").Attribute("result") != null ? lst.Element("btw").Attribute("result").Value : string.Empty) + "~" + (lst.Element("btw").Attribute("device") != null ? lst.Element("btw").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";

                    }
                    if (lst.Element("ref") != null)
                    {

                        ReferenceRange += ConvertStringOptr(lst.Element("ref").Attribute("ageopr").Value) + " " + lst.Element("ref").Attribute("agerange").Value + " " + lst.Element("ref").Attribute("agetype").Value + " : " + lst.Element("ref").Value + "<br/>";
                        ReferenceRangeString += lst.Element("ref").Attribute("gender").Value + "~" + lst.Element("ref").Value + "~" + ConvertStringOptr("ref") + "~" + lst.Element("ref").Attribute("value").Value + "~" + (lst.Element("ref").Attribute("Normal") != null ? lst.Element("ref").Attribute("Normal").Value : string.Empty) + "~Y~" + lst.Element("ref").Attribute("agetype").Value + "~" + ConvertStringOptr(lst.Element("ref").Attribute("ageopr").Value) + "~" + lst.Element("ref").Attribute("agerange").Value + "~~~~" + ResulType + "^";

                    }
                }

                ReferenceRangeString += "|Other@";
            }
            if (otherTextWithAge != null && otherTextWithAge.Count() > 0)
            {
                foreach (var lst in otherTextWithAge)
                {
                    string ResulType = string.Empty;
                    ResulType = "Text";

                    if (lst.Element("txt") != null)
                    {

                        ReferenceRange += lst.Element("txt").Attribute("gender").Value + ": " + ConvertStringOptr(lst.Element("txt").Attribute("ageopr").Value) + " " + lst.Element("txt").Attribute("agerange").Value + " " + lst.Element("txt").Attribute("agetype").Value + " : " + lst.Element("txt").Value + (lst.Element("txt").Attribute("data") != null && lst.Element("txt").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("txt").Attribute("data").Value : string.Empty) + (lst.Element("txt").Attribute("result") != null && lst.Element("txt").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("txt").Attribute("result").Value : string.Empty) + (lst.Element("txt").Attribute("device") != null && lst.Element("txt").Attribute("device").Value != "" ? " Device: " + lst.Element("txt").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("txt").Attribute("gender").Value + "~" + lst.Element("txt").Value + "~~~" + lst.Element("txt").Attribute("Normal").Value + "~~" + lst.Element("txt").Attribute("agetype").Value + "~" + ConvertStringOptr(lst.Element("txt").Attribute("ageopr").Value) + "~" + lst.Element("txt").Attribute("agerange").Value + "~" + (lst.Element("txt").Attribute("data") != null ? lst.Element("txt").Attribute("data").Value : string.Empty) + "~" + (lst.Element("txt").Attribute("result") != null ? lst.Element("txt").Attribute("result").Value : string.Empty) + "~" + (lst.Element("txt").Attribute("device") != null ? lst.Element("txt").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";

                    }
                    if (lst.Element("ref") != null)
                    {

                        ReferenceRange += ConvertStringOptr(lst.Element("ref").Attribute("ageopr").Value) + " " + lst.Element("ref").Attribute("agerange").Value + " " + lst.Element("ref").Attribute("agetype").Value + " : " + lst.Element("ref").Value + "<br/>";
                        ReferenceRangeString += lst.Element("ref").Attribute("gender").Value + "~" + lst.Element("ref").Value + "~" + ConvertStringOptr("ref") + "~~" + lst.Element("ref").Attribute("Normal").Value + "~Y~" + lst.Element("ref").Attribute("agetype").Value + "~" + ConvertStringOptr(lst.Element("ref").Attribute("ageopr").Value) + "~" + lst.Element("ref").Attribute("agerange").Value + "~~~~" + ResulType + "^";

                    }
                }
                ReferenceRangeString += "|Other@";
            }
            if (otherRangeWithNumeric != null && otherRangeWithNumeric.Count() > 0)
            {
                foreach (var lst in otherRangeWithNumeric)
                {
                    string ResulType = "Numeric";

                    if (lst.Element("lst") != null)
                    {

                        ReferenceRange += lst.Element("lst").Attribute("gender").Value + ": " + lst.Element("lst").Value + ": < " + lst.Element("lst").Attribute("value").Value + (lst.Element("lst").Attribute("data") != null && lst.Element("lst").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("lst").Attribute("data").Value : string.Empty) + (lst.Element("lst").Attribute("result") != null && lst.Element("lst").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("lst").Attribute("result").Value : string.Empty) + (lst.Element("lst").Attribute("device") != null && lst.Element("lst").Attribute("device").Value != "" ? " Device: " + lst.Element("lst").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("lst").Attribute("gender").Value + "~" + lst.Element("lst").Value + "~" + "<" + "~" + lst.Element("lst").Attribute("value").Value + "~" + (lst.Element("lst").Attribute("Normal") != null ? lst.Element("lst").Attribute("Normal").Value : string.Empty) + "~~~~~" + (lst.Element("lst").Attribute("data") != null ? lst.Element("lst").Attribute("data").Value : string.Empty) + "~" + (lst.Element("lst").Attribute("result") != null ? lst.Element("lst").Attribute("result").Value : string.Empty) + "~" + (lst.Element("lst").Attribute("device") != null ? lst.Element("lst").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";

                    }
                    if (lst.Element("lsq") != null)
                    {

                        ReferenceRange += lst.Element("lsq").Attribute("gender").Value + ": " + lst.Element("lsq").Value + ": <= " + lst.Element("lsq").Attribute("value").Value + (lst.Element("lsq").Attribute("data") != null && lst.Element("lsq").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("lsq").Attribute("data").Value : string.Empty) + (lst.Element("lsq").Attribute("result") != null && lst.Element("lsq").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("lsq").Attribute("result").Value : string.Empty) + (lst.Element("lsq").Attribute("device") != null && lst.Element("lsq").Attribute("device").Value != "" ? " Device: " + lst.Element("lsq").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("lsq").Attribute("gender").Value + "~" + lst.Element("lsq").Value + "~" + "<=" + "~" + lst.Element("lsq").Attribute("value").Value + "~" + (lst.Element("lsq").Attribute("Normal") != null ? lst.Element("lsq").Attribute("Normal").Value : string.Empty) + "~~~~~" + (lst.Element("lsq").Attribute("data") != null ? lst.Element("lsq").Attribute("data").Value : string.Empty) + "~" + (lst.Element("lsq").Attribute("result") != null ? lst.Element("lsq").Attribute("result").Value : string.Empty) + "~" + (lst.Element("lsq").Attribute("device") != null ? lst.Element("lsq").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";

                    }

                    if (lst.Element("eql") != null)
                    {

                        ReferenceRange += lst.Element("eql").Attribute("gender").Value + ": " + lst.Element("eql").Value + ": = " + lst.Element("eql").Attribute("value").Value + (lst.Element("eql").Attribute("data") != null && lst.Element("eql").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("eql").Attribute("data").Value : string.Empty) + (lst.Element("eql").Attribute("result") != null && lst.Element("eql").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("eql").Attribute("result").Value : string.Empty) + (lst.Element("eql").Attribute("device") != null && lst.Element("eql").Attribute("device").Value != "" ? " Device: " + lst.Element("eql").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("eql").Attribute("gender").Value + "~" + lst.Element("eql").Value + "~" + "=" + "~" + lst.Element("eql").Attribute("value").Value + "~" + (lst.Element("eql").Attribute("Normal") != null ? lst.Element("eql").Attribute("Normal").Value : string.Empty) + "~~~~~" + (lst.Element("eql").Attribute("data") != null ? lst.Element("eql").Attribute("data").Value : string.Empty) + "~" + (lst.Element("eql").Attribute("result") != null ? lst.Element("eql").Attribute("result").Value : string.Empty) + "~" + (lst.Element("eql").Attribute("device") != null ? lst.Element("eql").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";

                    }

                    if (lst.Element("grt") != null)
                    {

                        ReferenceRange += lst.Element("grt").Attribute("gender").Value + ": " + lst.Element("grt").Value + ": > " + lst.Element("grt").Attribute("value").Value + (lst.Element("grt").Attribute("data") != null && lst.Element("grt").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("grt").Attribute("data").Value : string.Empty) + (lst.Element("grt").Attribute("result") != null && lst.Element("grt").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("grt").Attribute("result").Value : string.Empty) + (lst.Element("grt").Attribute("device") != null && lst.Element("grt").Attribute("device").Value != "" ? " Device: " + lst.Element("grt").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("grt").Attribute("gender").Value + "~" + lst.Element("grt").Value + "~" + ">" + "~" + lst.Element("grt").Attribute("value").Value + "~" + (lst.Element("grt").Attribute("Normal") != null ? lst.Element("grt").Attribute("Normal").Value : string.Empty) + "~~~~~" + (lst.Element("grt").Attribute("data") != null ? lst.Element("grt").Attribute("data").Value : string.Empty) + "~" + (lst.Element("grt").Attribute("result") != null ? lst.Element("grt").Attribute("result").Value : string.Empty) + "~" + (lst.Element("grt").Attribute("device") != null ? lst.Element("grt").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";

                    }


                    if (lst.Element("grq") != null)
                    {

                        ReferenceRange += lst.Element("grq").Attribute("gender").Value + ": " + lst.Element("grq").Value + ": => " + lst.Element("grq").Attribute("value").Value + (lst.Element("grq").Attribute("data") != null && lst.Element("grq").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("grq").Attribute("data").Value : string.Empty) + (lst.Element("grq").Attribute("result") != null && lst.Element("grq").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("grq").Attribute("result").Value : string.Empty) + (lst.Element("grq").Attribute("device") != null && lst.Element("grq").Attribute("device").Value != "" ? " Device: " + lst.Element("grq").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("grq").Attribute("gender").Value + "~" + lst.Element("grq").Value + "~" + "=>" + "~" + lst.Element("grq").Attribute("value").Value + "~" + (lst.Element("grq").Attribute("Normal") != null ? lst.Element("grq").Attribute("Normal").Value : string.Empty) + "~~~~~" + (lst.Element("grq").Attribute("data") != null ? lst.Element("grq").Attribute("data").Value : string.Empty) + "~" + (lst.Element("grq").Attribute("result") != null ? lst.Element("grq").Attribute("result").Value : string.Empty) + "~" + (lst.Element("grq").Attribute("device") != null ? lst.Element("grq").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";


                    }

                    if (lst.Element("btw") != null)
                    {

                        ReferenceRange += lst.Element("btw").Attribute("gender").Value + ": " + lst.Element("btw").Value + ": " + lst.Element("btw").Attribute("value").Value + (lst.Element("btw").Attribute("data") != null && lst.Element("btw").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("btw").Attribute("data").Value : string.Empty) + (lst.Element("btw").Attribute("result") != null && lst.Element("btw").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("btw").Attribute("result").Value : string.Empty) + (lst.Element("btw").Attribute("device") != null && lst.Element("btw").Attribute("device").Value != "" ? " Device: " + lst.Element("btw").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("btw").Attribute("gender").Value + "~" + lst.Element("btw").Value + "~" + ConvertStringOptr("btw") + "~" + lst.Element("btw").Attribute("value").Value + "~" + (lst.Element("btw").Attribute("Normal") != null ? lst.Element("btw").Attribute("Normal").Value : string.Empty) + "~~~~~" + (lst.Element("btw").Attribute("data") != null ? lst.Element("btw").Attribute("data").Value : string.Empty) + "~" + (lst.Element("btw").Attribute("result") != null ? lst.Element("btw").Attribute("result").Value : string.Empty) + "~" + (lst.Element("btw").Attribute("device") != null ? lst.Element("btw").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";

                    }
                    if (lst.Element("ref") != null)
                    {

                        ReferenceRange += lst.Element("ref").Value + "<br/>";
                        ReferenceRangeString += lst.Element("ref").Attribute("gender").Value + "~" + lst.Element("ref").Value + "~" + ConvertStringOptr("ref") + "~" + lst.Element("ref").Attribute("value").Value + "~" + (lst.Element("ref").Attribute("Normal") != null ? lst.Element("ref").Attribute("Normal").Value : string.Empty) + "~Y~~~~~~~" + ResulType + "^";

                    }
                }

                ReferenceRangeString += "|Other@";
            }
            if (otherRangeWithText != null && otherRangeWithText.Count() > 0)
            {
                foreach (var lst in otherRangeWithText)
                {
                    string ResulType = "Text";

                    if (lst.Element("txt") != null)
                    {

                        ReferenceRange += lst.Element("txt").Attribute("gender").Value + ": " + lst.Element("txt").Value + (lst.Element("txt").Attribute("data") != null && lst.Element("txt").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("txt").Attribute("data").Value : string.Empty) + (lst.Element("txt").Attribute("result") != null && lst.Element("txt").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("txt").Attribute("result").Value : string.Empty) + (lst.Element("txt").Attribute("device") != null && lst.Element("txt").Attribute("device").Value != "" ? " Device: " + lst.Element("txt").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("txt").Attribute("gender").Value + "~" + lst.Element("txt").Value + "~~~" + lst.Element("txt").Attribute("Normal").Value + "~~~~~" + (lst.Element("txt").Attribute("data") != null ? lst.Element("txt").Attribute("data").Value : string.Empty) + "~" + (lst.Element("txt").Attribute("result") != null ? lst.Element("txt").Attribute("result").Value : string.Empty) + "~" + (lst.Element("txt").Attribute("device") != null ? lst.Element("txt").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";

                    }
                    if (lst.Element("ref") != null)
                    {

                        ReferenceRange += lst.Element("ref").Value + "<br/>";
                        ReferenceRangeString += lst.Element("ref").Attribute("gender").Value + "~" + lst.Element("ref").Value + "~" + ConvertStringOptr("ref") + "~~" + lst.Element("ref").Attribute("Normal").Value + "~Y~~~~~~~" + ResulType + "^";

                    }
                }
                ReferenceRangeString += "|Other@";
            }
            if (otherRange != null && otherRange.Count() > 0)
            {
                foreach (var lst in otherRange)
                {
                    string ResulType = "Numeric";

                    if (lst.Element("lst") != null)
                    {

                        ReferenceRange += lst.Element("lst").Attribute("gender").Value + ": " + lst.Element("lst").Value + ": < " + lst.Element("lst").Attribute("value").Value + (lst.Element("lst").Attribute("data") != null && lst.Element("lst").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("lst").Attribute("data").Value : string.Empty) + (lst.Element("lst").Attribute("result") != null && lst.Element("lst").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("lst").Attribute("result").Value : string.Empty) + (lst.Element("lst").Attribute("device") != null && lst.Element("lst").Attribute("device").Value != "" ? " Device: " + lst.Element("lst").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("lst").Attribute("gender").Value + "~" + lst.Element("lst").Value + "~" + "<" + "~" + lst.Element("lst").Attribute("value").Value + "~~~~~~" + (lst.Element("lst").Attribute("data") != null ? lst.Element("lst").Attribute("data").Value : string.Empty) + "~" + (lst.Element("lst").Attribute("result") != null ? lst.Element("lst").Attribute("result").Value : string.Empty) + "~" + (lst.Element("lst").Attribute("device") != null ? lst.Element("lst").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";


                    }
                    if (lst.Element("lsq") != null)
                    {

                        ReferenceRange += lst.Element("lsq").Attribute("gender").Value + ": " + lst.Element("lsq").Value + ": <= " + lst.Element("lsq").Attribute("value").Value + (lst.Element("lsq").Attribute("data") != null && lst.Element("lsq").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("lsq").Attribute("data").Value : string.Empty) + (lst.Element("lsq").Attribute("result") != null && lst.Element("lsq").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("lsq").Attribute("result").Value : string.Empty) + (lst.Element("lsq").Attribute("device") != null && lst.Element("lsq").Attribute("device").Value != "" ? " Device: " + lst.Element("lsq").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("lsq").Attribute("gender").Value + "~" + lst.Element("lsq").Value + "~" + "<=" + "~" + lst.Element("lsq").Attribute("value").Value + "~~~~~~" + (lst.Element("lsq").Attribute("data") != null ? lst.Element("lsq").Attribute("data").Value : string.Empty) + "~" + (lst.Element("lsq").Attribute("result") != null ? lst.Element("lsq").Attribute("result").Value : string.Empty) + "~" + (lst.Element("lsq").Attribute("device") != null ? lst.Element("lsq").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";

                    }

                    if (lst.Element("eql") != null)
                    {

                        ReferenceRange += lst.Element("eql").Attribute("gender").Value + ": " + lst.Element("eql").Value + ": = " + lst.Element("eql").Attribute("value").Value + (lst.Element("eql").Attribute("data") != null && lst.Element("eql").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("eql").Attribute("data").Value : string.Empty) + (lst.Element("eql").Attribute("result") != null && lst.Element("eql").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("eql").Attribute("result").Value : string.Empty) + (lst.Element("eql").Attribute("device") != null && lst.Element("eql").Attribute("device").Value != "" ? " Device: " + lst.Element("eql").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("eql").Attribute("gender").Value + "~" + lst.Element("eql").Value + "~" + "=" + "~" + lst.Element("eql").Attribute("value").Value + "~~~~~~" + (lst.Element("eql").Attribute("data") != null ? lst.Element("eql").Attribute("data").Value : string.Empty) + "~" + (lst.Element("eql").Attribute("result") != null ? lst.Element("eql").Attribute("result").Value : string.Empty) + "~" + (lst.Element("eql").Attribute("device") != null ? lst.Element("eql").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";

                    }

                    if (lst.Element("grt") != null)
                    {

                        ReferenceRange += lst.Element("grt").Attribute("gender").Value + ": " + lst.Element("grt").Value + ": > " + lst.Element("grt").Attribute("value").Value + (lst.Element("grt").Attribute("data") != null && lst.Element("grt").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("grt").Attribute("data").Value : string.Empty) + (lst.Element("grt").Attribute("result") != null && lst.Element("grt").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("grt").Attribute("result").Value : string.Empty) + (lst.Element("grt").Attribute("device") != null && lst.Element("grt").Attribute("device").Value != "" ? " Device: " + lst.Element("grt").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("grt").Attribute("gender").Value + "~" + lst.Element("grt").Value + "~" + ">" + "~" + lst.Element("grt").Attribute("value").Value + "~~~~~~" + (lst.Element("grt").Attribute("data") != null ? lst.Element("grt").Attribute("data").Value : string.Empty) + "~" + (lst.Element("grt").Attribute("result") != null ? lst.Element("grt").Attribute("result").Value : string.Empty) + "~" + (lst.Element("grt").Attribute("device") != null ? lst.Element("grt").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";

                    }


                    if (lst.Element("grq") != null)
                    {

                        ReferenceRange += lst.Element("grq").Attribute("gender").Value + ": " + lst.Element("grq").Value + ": => " + lst.Element("grq").Attribute("value").Value + (lst.Element("grq").Attribute("data") != null && lst.Element("grq").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("grq").Attribute("data").Value : string.Empty) + (lst.Element("grq").Attribute("result") != null && lst.Element("grq").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("grq").Attribute("result").Value : string.Empty) + (lst.Element("grq").Attribute("device") != null && lst.Element("grq").Attribute("device").Value != "" ? " Device: " + lst.Element("grq").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("grq").Attribute("gender").Value + "~" + lst.Element("grq").Value + "~" + "=>" + "~" + lst.Element("grq").Attribute("value").Value + "~~~~~~" + (lst.Element("grq").Attribute("data") != null ? lst.Element("grq").Attribute("data").Value : string.Empty) + "~" + (lst.Element("grq").Attribute("result") != null ? lst.Element("grq").Attribute("result").Value : string.Empty) + "~" + (lst.Element("grq").Attribute("device") != null ? lst.Element("grq").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";

                    }

                    if (lst.Element("btw") != null)
                    {

                        ReferenceRange += lst.Element("btw").Attribute("gender").Value + ": " + lst.Element("btw").Value + ": " + lst.Element("btw").Attribute("value").Value + (lst.Element("btw").Attribute("data") != null && lst.Element("btw").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("btw").Attribute("data").Value : string.Empty) + (lst.Element("btw").Attribute("result") != null && lst.Element("btw").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("btw").Attribute("result").Value : string.Empty) + (lst.Element("btw").Attribute("device") != null && lst.Element("btw").Attribute("device").Value != "" ? " Device: " + lst.Element("btw").Attribute("device").Value : string.Empty) + "<br/>";
                        ReferenceRangeString += lst.Element("btw").Attribute("gender").Value + "~" + lst.Element("btw").Value + "~" + ConvertStringOptr("btw") + "~" + lst.Element("btw").Attribute("value").Value + "~~~~~~" + (lst.Element("btw").Attribute("data") != null ? lst.Element("btw").Attribute("data").Value : string.Empty) + "~" + (lst.Element("btw").Attribute("result") != null ? lst.Element("btw").Attribute("result").Value : string.Empty) + "~" + (lst.Element("btw").Attribute("device") != null ? lst.Element("btw").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";

                    }
                    if (lst.Element("ref") != null)
                    {

                        ReferenceRange += lst.Element("ref").Value + "<br/>";
                        ReferenceRangeString += lst.Element("ref").Attribute("gender").Value + "~" + lst.Element("ref").Value + "~" + ConvertStringOptr("ref") + "~" + lst.Element("ref").Attribute("value").Value + "~~Y~~~~~~~" + ResulType + "^";

                    }
                }

                ReferenceRangeString += "|Other@";
            }

            itemCount = itemCount + 1;
            if (ReferenceRangeString.EndsWith("@"))
            {
                ReferenceRangeString = ReferenceRangeString.Substring(0, ReferenceRangeString.Length - 1);
            }

            if (ReferenceRange == "")
            {
                ReferenceRange = xmlData;
                ReferenceRangeString = xmlData;

            }
            /*  var ageRange = from age in xe.Elements(code).Elements("property")
                             where (string)age.Attribute("type") == "age"
                             select age;
              var commonRange = from common in xe.Elements(code).Elements("property")
                                where (string)common.Attribute("type") == "common"
                                select common;

              var otherRange = from otherWithNumeric in xe.Elements(code).Elements("property")
                               where (string)otherWithNumeric.Attribute("type") == "other" && (string)otherWithNumeric.Attribute("ResultType") == null && (string)otherWithNumeric.Attribute("agetype") == null
                               select otherWithNumeric;

              var otherRangeWithNumeric = from otherWithNumeric in xe.Elements(code).Elements("property")
                                          where (string)otherWithNumeric.Attribute("type") == "other" && (string)otherWithNumeric.Attribute("ResultType") == "Numeric" && (string)otherWithNumeric.Attribute("agetype") == null
                                          select otherWithNumeric;

              var otherRangeWithText = from otherWithText in xe.Elements(code).Elements("property")
                                       where (string)otherWithText.Attribute("type") == "other" && (string)otherWithText.Attribute("ResultType") == "Text" && (string)otherWithText.Attribute("agetype") == null
                                       select otherWithText;

              var otherNumericWithAge = from otherWithNumeric in xe.Elements(code).Elements("property")
                                        where (string)otherWithNumeric.Attribute("type") == "other" && (string)otherWithNumeric.Attribute("ResultType") == "Numeric" && (string)otherWithNumeric.Attribute("agetype") != null
                                        select otherWithNumeric;

              var otherTextWithAge = from otherWithText in xe.Elements(code).Elements("property")
                                     where (string)otherWithText.Attribute("type") == "other" && (string)otherWithText.Attribute("ResultType") == "Text" && (string)otherWithText.Attribute("agetype") != null
                                     select otherWithText;
              string ReferenceRange = "";
              String ReferenceRangeString = "";
              //            lstKeyvalue = new Dictionary<string, string>();

              if (commonRange != null && commonRange.Count() > 0)
              {
                  foreach (var lst in commonRange)
                  {
                      if (lst.Element("lst") != null)
                      {
                          ReferenceRange += lst.Element("lst").Attribute("value").Value + ": < " + lst.Element("lst").Value + (lst.Element("lst").Attribute("data") != null && lst.Element("lst").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("lst").Attribute("data").Value : string.Empty) + (lst.Element("lst").Attribute("result") != null && lst.Element("lst").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("lst").Attribute("result").Value : string.Empty) + (lst.Element("lst").Attribute("device") != null && lst.Element("lst").Attribute("device").Value != "" ? " Device: " + lst.Element("lst").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("lst").Attribute("value").Value + "~" + "<" + "~" + lst.Element("lst").Value + "~" + (lst.Element("lst").Attribute("data") != null ? lst.Element("lst").Attribute("data").Value : string.Empty) + "~" + (lst.Element("lst").Attribute("result") != null ? lst.Element("lst").Attribute("result").Value : string.Empty) + "~" + (lst.Element("lst").Attribute("device") != null ? lst.Element("lst").Attribute("device").Value : string.Empty) + "^";
                      }

                      if (lst.Element("lsq") != null)
                      {
                          ReferenceRange += lst.Element("lsq").Attribute("value").Value + ": <= " + lst.Element("lsq").Value + (lst.Element("lsq").Attribute("data") != null && lst.Element("lsq").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("lsq").Attribute("data").Value : string.Empty) + (lst.Element("lsq").Attribute("result") != null && lst.Element("lsq").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("lsq").Attribute("result").Value : string.Empty) + (lst.Element("lsq").Attribute("device") != null && lst.Element("lsq").Attribute("device").Value != "" ? " Device: " + lst.Element("lsq").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("lsq").Attribute("value").Value + "~" + "<=" + "~" + lst.Element("lsq").Value + "~" + (lst.Element("lsq").Attribute("data") != null ? lst.Element("lsq").Attribute("data").Value : string.Empty) + "~" + (lst.Element("lsq").Attribute("result") != null ? lst.Element("lsq").Attribute("result").Value : string.Empty) + "~" + (lst.Element("lsq").Attribute("device") != null ? lst.Element("lsq").Attribute("device").Value : string.Empty) + "^";
                      }

                      if (lst.Element("eql") != null)
                      {
                          ReferenceRange += lst.Element("eql").Attribute("value").Value + ": = " + lst.Element("eql").Value + (lst.Element("eql").Attribute("data") != null && lst.Element("eql").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("eql").Attribute("data").Value : string.Empty) + (lst.Element("eql").Attribute("result") != null && lst.Element("eql").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("eql").Attribute("result").Value : string.Empty) + (lst.Element("eql").Attribute("device") != null && lst.Element("eql").Attribute("device").Value != "" ? " Device: " + lst.Element("eql").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("eql").Attribute("value").Value + "~" + "=" + "~" + lst.Element("eql").Value + "~" + (lst.Element("eql").Attribute("data") != null ? lst.Element("eql").Attribute("data").Value : string.Empty) + "~" + (lst.Element("eql").Attribute("result") != null ? lst.Element("eql").Attribute("result").Value : string.Empty) + "~" + (lst.Element("eql").Attribute("device") != null ? lst.Element("eql").Attribute("device").Value : string.Empty) + "^";
                      }

                      if (lst.Element("grt") != null)
                      {
                          ReferenceRange += lst.Element("grt").Attribute("value").Value + ": > " + lst.Element("grt").Value + (lst.Element("grt").Attribute("data") != null && lst.Element("grt").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("grt").Attribute("data").Value : string.Empty) + (lst.Element("grt").Attribute("result") != null && lst.Element("grt").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("grt").Attribute("result").Value : string.Empty) + (lst.Element("grt").Attribute("device") != null && lst.Element("grt").Attribute("device").Value != "" ? " Device: " + lst.Element("grt").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("grt").Attribute("value").Value + "~" + ">" + "~" + lst.Element("grt").Value + "~" + (lst.Element("grt").Attribute("data") != null ? lst.Element("grt").Attribute("data").Value : string.Empty) + "~" + (lst.Element("grt").Attribute("result") != null ? lst.Element("grt").Attribute("result").Value : string.Empty) + "~" + (lst.Element("grt").Attribute("device") != null ? lst.Element("grt").Attribute("device").Value : string.Empty) + "^";
                      }


                      if (lst.Element("grq") != null)
                      {
                          ReferenceRange += lst.Element("grq").Attribute("value").Value + ": => " + lst.Element("grq").Value + (lst.Element("grq").Attribute("data") != null && lst.Element("grq").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("grq").Attribute("data").Value : string.Empty) + (lst.Element("grq").Attribute("result") != null && lst.Element("grq").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("grq").Attribute("result").Value : string.Empty) + (lst.Element("grq").Attribute("device") != null && lst.Element("grq").Attribute("device").Value != "" ? " Device: " + lst.Element("grq").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("grq").Attribute("value").Value + "~" + "=>" + "~" + lst.Element("grq").Value + "~" + (lst.Element("grq").Attribute("data") != null ? lst.Element("grq").Attribute("data").Value : string.Empty) + "~" + (lst.Element("grq").Attribute("result") != null ? lst.Element("grq").Attribute("result").Value : string.Empty) + "~" + (lst.Element("grq").Attribute("device") != null ? lst.Element("grq").Attribute("device").Value : string.Empty) + "^";
                      }

                      if (lst.Element("btw") != null)
                      {
                          ReferenceRange += lst.Element("btw").Attribute("value").Value + ": " + lst.Element("btw").Value + (lst.Element("btw").Attribute("data") != null && lst.Element("btw").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("btw").Attribute("data").Value : string.Empty) + (lst.Element("btw").Attribute("result") != null && lst.Element("btw").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("btw").Attribute("result").Value : string.Empty) + (lst.Element("btw").Attribute("device") != null && lst.Element("btw").Attribute("device").Value != "" ? " Device: " + lst.Element("btw").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("btw").Attribute("value").Value + "~" + ConvertStringOptr("btw") + "~" + lst.Element("btw").Value + "~" + (lst.Element("btw").Attribute("data") != null ? lst.Element("btw").Attribute("data").Value : string.Empty) + "~" + (lst.Element("btw").Attribute("result") != null ? lst.Element("btw").Attribute("result").Value : string.Empty) + "~" + (lst.Element("btw").Attribute("device") != null ? lst.Element("btw").Attribute("device").Value : string.Empty) + "^";
                      }
                      if (lst.Element("ref") != null)
                      {
                          ReferenceRange += lst.Element("ref").Value + "<br/>";
                          ReferenceRangeString += lst.Element("ref").Attribute("value").Value + "~" + ConvertStringOptr("ref") + "~" + lst.Element("ref").Value + "~~~" + "^";
                      }
                  }
                  ReferenceRangeString += "|Common@";
              }

              if (commonRange != null && commonRange.Count() > 0)
              {
                  foreach (var lst in commonRange)
                  {
                      if (lst.Element("lst") != null)
                      {
                          ReferenceRange += lst.Element("lst").Attribute("value").Value + ": < " + lst.Element("lst").Value + (lst.Element("lst").Attribute("data") != null && lst.Element("lst").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("lst").Attribute("data").Value : string.Empty) + (lst.Element("lst").Attribute("result") != null && lst.Element("lst").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("lst").Attribute("result").Value : string.Empty) + (lst.Element("lst").Attribute("device") != null && lst.Element("lst").Attribute("device").Value != "" ? " Device: " + lst.Element("lst").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("lst").Attribute("value").Value + "~" + "<" + "~" + lst.Element("lst").Value + "~" + (lst.Element("lst").Attribute("data") != null ? lst.Element("lst").Attribute("data").Value : string.Empty) + "~" + (lst.Element("lst").Attribute("result") != null ? lst.Element("lst").Attribute("result").Value : string.Empty) + "~" + (lst.Element("lst").Attribute("device") != null ? lst.Element("lst").Attribute("device").Value : string.Empty) + "^";
                      }

                      if (lst.Element("lsq") != null)
                      {
                          ReferenceRange += lst.Element("lsq").Attribute("value").Value + ": <= " + lst.Element("lsq").Value + (lst.Element("lsq").Attribute("data") != null && lst.Element("lsq").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("lsq").Attribute("data").Value : string.Empty) + (lst.Element("lsq").Attribute("result") != null && lst.Element("lsq").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("lsq").Attribute("result").Value : string.Empty) + (lst.Element("lsq").Attribute("device") != null && lst.Element("lsq").Attribute("device").Value != "" ? " Device: " + lst.Element("lsq").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("lsq").Attribute("value").Value + "~" + "<=" + "~" + lst.Element("lsq").Value + "~" + (lst.Element("lsq").Attribute("data") != null ? lst.Element("lsq").Attribute("data").Value : string.Empty) + "~" + (lst.Element("lsq").Attribute("result") != null ? lst.Element("lsq").Attribute("result").Value : string.Empty) + "~" + (lst.Element("lsq").Attribute("device") != null ? lst.Element("lsq").Attribute("device").Value : string.Empty) + "^";
                      }

                      if (lst.Element("eql") != null)
                      {
                          ReferenceRange += lst.Element("eql").Attribute("value").Value + ": = " + lst.Element("eql").Value + (lst.Element("eql").Attribute("data") != null && lst.Element("eql").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("eql").Attribute("data").Value : string.Empty) + (lst.Element("eql").Attribute("result") != null && lst.Element("eql").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("eql").Attribute("result").Value : string.Empty) + (lst.Element("eql").Attribute("device") != null && lst.Element("eql").Attribute("device").Value != "" ? " Device: " + lst.Element("eql").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("eql").Attribute("value").Value + "~" + "=" + "~" + lst.Element("eql").Value + "~" + (lst.Element("eql").Attribute("data") != null ? lst.Element("eql").Attribute("data").Value : string.Empty) + "~" + (lst.Element("eql").Attribute("result") != null ? lst.Element("eql").Attribute("result").Value : string.Empty) + "~" + (lst.Element("eql").Attribute("device") != null ? lst.Element("eql").Attribute("device").Value : string.Empty) + "^";
                      }

                      if (lst.Element("grt") != null)
                      {
                          ReferenceRange += lst.Element("grt").Attribute("value").Value + ": > " + lst.Element("grt").Value + (lst.Element("grt").Attribute("data") != null && lst.Element("grt").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("grt").Attribute("data").Value : string.Empty) + (lst.Element("grt").Attribute("result") != null && lst.Element("grt").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("grt").Attribute("result").Value : string.Empty) + (lst.Element("grt").Attribute("device") != null && lst.Element("grt").Attribute("device").Value != "" ? " Device: " + lst.Element("grt").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("grt").Attribute("value").Value + "~" + ">" + "~" + lst.Element("grt").Value + "~" + (lst.Element("grt").Attribute("data") != null ? lst.Element("grt").Attribute("data").Value : string.Empty) + "~" + (lst.Element("grt").Attribute("result") != null ? lst.Element("grt").Attribute("result").Value : string.Empty) + "~" + (lst.Element("grt").Attribute("device") != null ? lst.Element("grt").Attribute("device").Value : string.Empty) + "^";
                      }


                      if (lst.Element("grq") != null)
                      {
                          ReferenceRange += lst.Element("grq").Attribute("value").Value + ": => " + lst.Element("grq").Value + (lst.Element("grq").Attribute("data") != null && lst.Element("grq").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("grq").Attribute("data").Value : string.Empty) + (lst.Element("grq").Attribute("result") != null && lst.Element("grq").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("grq").Attribute("result").Value : string.Empty) + (lst.Element("grq").Attribute("device") != null && lst.Element("grq").Attribute("device").Value != "" ? " Device: " + lst.Element("grq").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("grq").Attribute("value").Value + "~" + "=>" + "~" + lst.Element("grq").Value + "~" + (lst.Element("grq").Attribute("data") != null ? lst.Element("grq").Attribute("data").Value : string.Empty) + "~" + (lst.Element("grq").Attribute("result") != null ? lst.Element("grq").Attribute("result").Value : string.Empty) + "~" + (lst.Element("grq").Attribute("device") != null ? lst.Element("grq").Attribute("device").Value : string.Empty) + "^";
                      }

                      if (lst.Element("btw") != null)
                      {
                          ReferenceRange += lst.Element("btw").Attribute("value").Value + ": " + lst.Element("btw").Value + (lst.Element("btw").Attribute("data") != null && lst.Element("btw").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("btw").Attribute("data").Value : string.Empty) + (lst.Element("btw").Attribute("result") != null && lst.Element("btw").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("btw").Attribute("result").Value : string.Empty) + (lst.Element("btw").Attribute("device") != null && lst.Element("btw").Attribute("device").Value != "" ? " Device: " + lst.Element("btw").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("btw").Attribute("value").Value + "~" + ConvertStringOptr("btw") + "~" + lst.Element("btw").Value + "~" + (lst.Element("btw").Attribute("data") != null ? lst.Element("btw").Attribute("data").Value : string.Empty) + "~" + (lst.Element("btw").Attribute("result") != null ? lst.Element("btw").Attribute("result").Value : string.Empty) + "~" + (lst.Element("btw").Attribute("device") != null ? lst.Element("btw").Attribute("device").Value : string.Empty) + "^";
                      }
                      if (lst.Element("ref") != null)
                      {
                          ReferenceRange += lst.Element("ref").Value + "<br/>";
                          ReferenceRangeString += lst.Element("ref").Attribute("value").Value + "~" + ConvertStringOptr("ref") + "~" + lst.Element("ref").Value + "~~~" + "^";
                      }
                  }
                  ReferenceRangeString += "|Common@";
              }

              if (otherNumericWithAge != null && otherNumericWithAge.Count() > 0)
              {
                  foreach (var lst in otherNumericWithAge)
                  {
                      string ResulType = "Numeric";

                      if (lst.Element("lst") != null)
                      {
                          ReferenceRange += lst.Element("lst").Attribute("gender").Value + ": " + ConvertStringOptr(lst.Element("lst").Attribute("ageopr").Value) + " " + lst.Element("lst").Attribute("agerange").Value + " " + lst.Element("lst").Attribute("agetype").Value + " : " + lst.Element("lst").Value + ": < " + lst.Element("lst").Attribute("value").Value + (lst.Element("lst").Attribute("data") != null && lst.Element("lst").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("lst").Attribute("data").Value : string.Empty) + (lst.Element("lst").Attribute("result") != null && lst.Element("lst").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("lst").Attribute("result").Value : string.Empty) + (lst.Element("lst").Attribute("device") != null && lst.Element("lst").Attribute("device").Value != "" ? " Device: " + lst.Element("lst").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("lst").Attribute("gender").Value + "~" + lst.Element("lst").Value + "~" + "<" + "~" + lst.Element("lst").Attribute("value").Value + "~" + (lst.Element("lst").Attribute("Normal") != null ? lst.Element("lst").Attribute("Normal").Value : string.Empty) + "~~" + lst.Element("lst").Attribute("agetype").Value + "~" + ConvertStringOptr(lst.Element("lst").Attribute("ageopr").Value) + "~" + lst.Element("lst").Attribute("agerange").Value + "~" + (lst.Element("lst").Attribute("data") != null ? lst.Element("lst").Attribute("data").Value : string.Empty) + "~" + (lst.Element("lst").Attribute("result") != null ? lst.Element("lst").Attribute("result").Value : string.Empty) + "~" + (lst.Element("lst").Attribute("device") != null ? lst.Element("lst").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";
                      }
                      if (lst.Element("lsq") != null)
                      {
                          ReferenceRange += lst.Element("lsq").Attribute("gender").Value + ": " + ConvertStringOptr(lst.Element("lsq").Attribute("ageopr").Value) + " " + lst.Element("lsq").Attribute("agerange").Value + " " + lst.Element("lsq").Attribute("agetype").Value + " : " + lst.Element("lsq").Value + ": <= " + lst.Element("lsq").Attribute("value").Value + (lst.Element("lsq").Attribute("data") != null && lst.Element("lsq").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("lsq").Attribute("data").Value : string.Empty) + (lst.Element("lsq").Attribute("result") != null && lst.Element("lsq").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("lsq").Attribute("result").Value : string.Empty) + (lst.Element("lsq").Attribute("device") != null && lst.Element("lsq").Attribute("device").Value != "" ? " Device: " + lst.Element("lsq").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("lsq").Attribute("gender").Value + "~" + lst.Element("lsq").Value + "~" + "<=" + "~" + lst.Element("lsq").Attribute("value").Value + "~" + (lst.Element("lsq").Attribute("Normal") != null ? lst.Element("lsq").Attribute("Normal").Value : string.Empty) + "~~" + lst.Element("lsq").Attribute("agetype").Value + "~" + ConvertStringOptr(lst.Element("lsq").Attribute("ageopr").Value) + "~" + lst.Element("lsq").Attribute("agerange").Value + "~" + (lst.Element("lsq").Attribute("data") != null ? lst.Element("lsq").Attribute("data").Value : string.Empty) + "~" + (lst.Element("lsq").Attribute("result") != null ? lst.Element("lsq").Attribute("result").Value : string.Empty) + "~" + (lst.Element("lsq").Attribute("device") != null ? lst.Element("lsq").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";
                      }

                      if (lst.Element("eql") != null)
                      {
                          ReferenceRange += lst.Element("eql").Attribute("gender").Value + ": " + ConvertStringOptr(lst.Element("eql").Attribute("ageopr").Value) + " " + lst.Element("eql").Attribute("agerange").Value + " " + lst.Element("eql").Attribute("agetype").Value + " : " + lst.Element("eql").Value + ": = " + lst.Element("eql").Attribute("value").Value + (lst.Element("eql").Attribute("data") != null && lst.Element("eql").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("eql").Attribute("data").Value : string.Empty) + (lst.Element("eql").Attribute("result") != null && lst.Element("eql").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("eql").Attribute("result").Value : string.Empty) + (lst.Element("eql").Attribute("device") != null && lst.Element("eql").Attribute("device").Value != "" ? " Device: " + lst.Element("eql").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("eql").Attribute("gender").Value + "~" + lst.Element("eql").Value + "~" + "=" + "~" + lst.Element("eql").Attribute("value").Value + "~" + (lst.Element("eql").Attribute("Normal") != null ? lst.Element("eql").Attribute("Normal").Value : string.Empty) + "~~" + lst.Element("eql").Attribute("agetype").Value + "~" + ConvertStringOptr(lst.Element("eql").Attribute("ageopr").Value) + "~" + lst.Element("eql").Attribute("agerange").Value + "~" + (lst.Element("eql").Attribute("data") != null ? lst.Element("eql").Attribute("data").Value : string.Empty) + "~" + (lst.Element("eql").Attribute("result") != null ? lst.Element("eql").Attribute("result").Value : string.Empty) + "~" + (lst.Element("eql").Attribute("device") != null ? lst.Element("eql").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";
                      }

                      if (lst.Element("grt") != null)
                      {
                          ReferenceRange += lst.Element("grt").Attribute("gender").Value + ": " + ConvertStringOptr(lst.Element("grt").Attribute("ageopr").Value) + " " + lst.Element("grt").Attribute("agerange").Value + " " + lst.Element("grt").Attribute("agetype").Value + " : " + lst.Element("grt").Value + ": > " + lst.Element("grt").Attribute("value").Value + (lst.Element("grt").Attribute("data") != null && lst.Element("grt").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("grt").Attribute("data").Value : string.Empty) + (lst.Element("grt").Attribute("result") != null && lst.Element("grt").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("grt").Attribute("result").Value : string.Empty) + (lst.Element("grt").Attribute("device") != null && lst.Element("grt").Attribute("device").Value != "" ? " Device: " + lst.Element("grt").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("grt").Attribute("gender").Value + "~" + lst.Element("grt").Value + "~" + ">" + "~" + lst.Element("grt").Attribute("value").Value + "~" + (lst.Element("grt").Attribute("Normal") != null ? lst.Element("grt").Attribute("Normal").Value : string.Empty) + "~~" + lst.Element("grt").Attribute("agetype").Value + "~" + ConvertStringOptr(lst.Element("grt").Attribute("ageopr").Value) + "~" + lst.Element("grt").Attribute("agerange").Value + "~" + (lst.Element("grt").Attribute("data") != null ? lst.Element("grt").Attribute("data").Value : string.Empty) + "~" + (lst.Element("grt").Attribute("result") != null ? lst.Element("grt").Attribute("result").Value : string.Empty) + "~" + (lst.Element("grt").Attribute("device") != null ? lst.Element("grt").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";
                      }

                      if (lst.Element("grq") != null)
                      {
                          ReferenceRange += lst.Element("grq").Attribute("gender").Value + ": " + ConvertStringOptr(lst.Element("grq").Attribute("ageopr").Value) + " " + lst.Element("grq").Attribute("agerange").Value + " " + lst.Element("grq").Attribute("agetype").Value + " : " + lst.Element("grq").Value + ": => " + lst.Element("grq").Attribute("value").Value + (lst.Element("grq").Attribute("data") != null && lst.Element("grq").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("grq").Attribute("data").Value : string.Empty) + (lst.Element("grq").Attribute("result") != null && lst.Element("grq").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("grq").Attribute("result").Value : string.Empty) + (lst.Element("grq").Attribute("device") != null && lst.Element("grq").Attribute("device").Value != "" ? " Device: " + lst.Element("grq").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("grq").Attribute("gender").Value + "~" + lst.Element("grq").Value + "~" + "=>" + "~" + lst.Element("grq").Attribute("value").Value + "~" + (lst.Element("grq").Attribute("Normal") != null ? lst.Element("grq").Attribute("Normal").Value : string.Empty) + "~~" + lst.Element("grq").Attribute("agetype").Value + "~" + ConvertStringOptr(lst.Element("grq").Attribute("ageopr").Value) + "~" + lst.Element("grq").Attribute("agerange").Value + "~" + (lst.Element("grq").Attribute("data") != null ? lst.Element("grq").Attribute("data").Value : string.Empty) + "~" + (lst.Element("grq").Attribute("result") != null ? lst.Element("grq").Attribute("result").Value : string.Empty) + "~" + (lst.Element("grq").Attribute("device") != null ? lst.Element("grq").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";
                      }

                      if (lst.Element("btw") != null)
                      {
                          ReferenceRange += lst.Element("btw").Attribute("gender").Value + ": " + ConvertStringOptr(lst.Element("btw").Attribute("ageopr").Value) + " " + lst.Element("btw").Attribute("agerange").Value + " " + lst.Element("btw").Attribute("agetype").Value + " : " + lst.Element("btw").Value + ": " + lst.Element("btw").Attribute("value").Value + (lst.Element("btw").Attribute("data") != null && lst.Element("btw").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("btw").Attribute("data").Value : string.Empty) + (lst.Element("btw").Attribute("result") != null && lst.Element("btw").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("btw").Attribute("result").Value : string.Empty) + (lst.Element("btw").Attribute("device") != null && lst.Element("btw").Attribute("device").Value != "" ? " Device: " + lst.Element("btw").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("btw").Attribute("gender").Value + "~" + lst.Element("btw").Value + "~" + ConvertStringOptr("btw") + "~" + lst.Element("btw").Attribute("value").Value + "~" + (lst.Element("btw").Attribute("Normal") != null ? lst.Element("btw").Attribute("Normal").Value : string.Empty) + "~~" + lst.Element("btw").Attribute("agetype").Value + "~" + ConvertStringOptr(lst.Element("btw").Attribute("ageopr").Value) + "~" + lst.Element("btw").Attribute("agerange").Value + "~" + (lst.Element("btw").Attribute("data") != null ? lst.Element("btw").Attribute("data").Value : string.Empty) + "~" + (lst.Element("btw").Attribute("result") != null ? lst.Element("btw").Attribute("result").Value : string.Empty) + "~" + (lst.Element("btw").Attribute("device") != null ? lst.Element("btw").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";
                      }
                      if (lst.Element("ref") != null)
                      {
                          ReferenceRange += ConvertStringOptr(lst.Element("ref").Attribute("ageopr").Value) + " " + lst.Element("ref").Attribute("agerange").Value + " " + lst.Element("ref").Attribute("agetype").Value + " : " + lst.Element("ref").Value + "<br/>";
                          ReferenceRangeString += lst.Element("ref").Attribute("gender").Value + "~" + lst.Element("ref").Value + "~" + ConvertStringOptr("ref") + "~" + lst.Element("ref").Attribute("value").Value + "~" + (lst.Element("ref").Attribute("Normal") != null ? lst.Element("ref").Attribute("Normal").Value : string.Empty) + "~Y~" + lst.Element("ref").Attribute("agetype").Value + "~" + ConvertStringOptr(lst.Element("ref").Attribute("ageopr").Value) + "~" + lst.Element("ref").Attribute("agerange").Value + "~~~~" + ResulType + "^";
                      }
                  }

                  ReferenceRangeString += "|Other@";
              }
              if (otherTextWithAge != null && otherTextWithAge.Count() > 0)
              {
                  foreach (var lst in otherTextWithAge)
                  {
                      string ResulType = string.Empty;
                      ResulType = "Text";

                      if (lst.Element("txt") != null)
                      {
                          ReferenceRange += lst.Element("txt").Attribute("gender").Value + ": " + ConvertStringOptr(lst.Element("txt").Attribute("ageopr").Value) + " " + lst.Element("txt").Attribute("agerange").Value + " " + lst.Element("txt").Attribute("agetype").Value + " : " + lst.Element("txt").Value + (lst.Element("txt").Attribute("data") != null && lst.Element("txt").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("txt").Attribute("data").Value : string.Empty) + (lst.Element("txt").Attribute("result") != null && lst.Element("txt").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("txt").Attribute("result").Value : string.Empty) + (lst.Element("txt").Attribute("device") != null && lst.Element("txt").Attribute("device").Value != "" ? " Device: " + lst.Element("txt").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("txt").Attribute("gender").Value + "~" + lst.Element("txt").Value + "~~~" + lst.Element("txt").Attribute("Normal").Value + "~~" + lst.Element("txt").Attribute("agetype").Value + "~" + ConvertStringOptr(lst.Element("txt").Attribute("ageopr").Value) + "~" + lst.Element("txt").Attribute("agerange").Value + "~" + (lst.Element("txt").Attribute("data") != null ? lst.Element("txt").Attribute("data").Value : string.Empty) + "~" + (lst.Element("txt").Attribute("result") != null ? lst.Element("txt").Attribute("result").Value : string.Empty) + "~" + (lst.Element("txt").Attribute("device") != null ? lst.Element("txt").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";
                      }
                      if (lst.Element("ref") != null)
                      {
                          ReferenceRange += ConvertStringOptr(lst.Element("ref").Attribute("ageopr").Value) + " " + lst.Element("ref").Attribute("agerange").Value + " " + lst.Element("ref").Attribute("agetype").Value + " : " + lst.Element("ref").Value + "<br/>";
                          ReferenceRangeString += lst.Element("ref").Attribute("gender").Value + "~" + lst.Element("ref").Value + "~" + ConvertStringOptr("ref") + "~~" + lst.Element("ref").Attribute("Normal").Value + "~Y~" + lst.Element("ref").Attribute("agetype").Value + "~" + ConvertStringOptr(lst.Element("ref").Attribute("ageopr").Value) + "~" + lst.Element("ref").Attribute("agerange").Value + "~~~~" + ResulType + "^";
                      }
                  }
                  ReferenceRangeString += "|Other@";
              }
              if (otherRangeWithNumeric != null && otherRangeWithNumeric.Count() > 0)
              {
                  foreach (var lst in otherRangeWithNumeric)
                  {
                      string ResulType = "Numeric";

                      if (lst.Element("lst") != null)
                      {
                          ReferenceRange += lst.Element("lst").Attribute("gender").Value + ": " + lst.Element("lst").Value + ": < " + lst.Element("lst").Attribute("value").Value + (lst.Element("lst").Attribute("data") != null && lst.Element("lst").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("lst").Attribute("data").Value : string.Empty) + (lst.Element("lst").Attribute("result") != null && lst.Element("lst").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("lst").Attribute("result").Value : string.Empty) + (lst.Element("lst").Attribute("device") != null && lst.Element("lst").Attribute("device").Value != "" ? " Device: " + lst.Element("lst").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("lst").Attribute("gender").Value + "~" + lst.Element("lst").Value + "~" + "<" + "~" + lst.Element("lst").Attribute("value").Value + "~" + (lst.Element("lst").Attribute("Normal") != null ? lst.Element("lst").Attribute("Normal").Value : string.Empty) + "~~~~~" + (lst.Element("lst").Attribute("data") != null ? lst.Element("lst").Attribute("data").Value : string.Empty) + "~" + (lst.Element("lst").Attribute("result") != null ? lst.Element("lst").Attribute("result").Value : string.Empty) + "~" + (lst.Element("lst").Attribute("device") != null ? lst.Element("lst").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";

                      }
                      if (lst.Element("lsq") != null)
                      {
                          ReferenceRange += lst.Element("lsq").Attribute("gender").Value + ": " + lst.Element("lsq").Value + ": <= " + lst.Element("lsq").Attribute("value").Value + (lst.Element("lsq").Attribute("data") != null && lst.Element("lsq").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("lsq").Attribute("data").Value : string.Empty) + (lst.Element("lsq").Attribute("result") != null && lst.Element("lsq").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("lsq").Attribute("result").Value : string.Empty) + (lst.Element("lsq").Attribute("device") != null && lst.Element("lsq").Attribute("device").Value != "" ? " Device: " + lst.Element("lsq").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("lsq").Attribute("gender").Value + "~" + lst.Element("lsq").Value + "~" + "<=" + "~" + lst.Element("lsq").Attribute("value").Value + "~" + (lst.Element("lsq").Attribute("Normal") != null ? lst.Element("lsq").Attribute("Normal").Value : string.Empty) + "~~~~~" + (lst.Element("lsq").Attribute("data") != null ? lst.Element("lsq").Attribute("data").Value : string.Empty) + "~" + (lst.Element("lsq").Attribute("result") != null ? lst.Element("lsq").Attribute("result").Value : string.Empty) + "~" + (lst.Element("lsq").Attribute("device") != null ? lst.Element("lsq").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";
                      }

                      if (lst.Element("eql") != null)
                      {
                          ReferenceRange += lst.Element("eql").Attribute("gender").Value + ": " + lst.Element("eql").Value + ": = " + lst.Element("eql").Attribute("value").Value + (lst.Element("eql").Attribute("data") != null && lst.Element("eql").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("eql").Attribute("data").Value : string.Empty) + (lst.Element("eql").Attribute("result") != null && lst.Element("eql").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("eql").Attribute("result").Value : string.Empty) + (lst.Element("eql").Attribute("device") != null && lst.Element("eql").Attribute("device").Value != "" ? " Device: " + lst.Element("eql").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("eql").Attribute("gender").Value + "~" + lst.Element("eql").Value + "~" + "=" + "~" + lst.Element("eql").Attribute("value").Value + "~" + (lst.Element("eql").Attribute("Normal") != null ? lst.Element("eql").Attribute("Normal").Value : string.Empty) + "~~~~~" + (lst.Element("eql").Attribute("data") != null ? lst.Element("eql").Attribute("data").Value : string.Empty) + "~" + (lst.Element("eql").Attribute("result") != null ? lst.Element("eql").Attribute("result").Value : string.Empty) + "~" + (lst.Element("eql").Attribute("device") != null ? lst.Element("eql").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";
                      }

                      if (lst.Element("grt") != null)
                      {
                          ReferenceRange += lst.Element("grt").Attribute("gender").Value + ": " + lst.Element("grt").Value + ": > " + lst.Element("grt").Attribute("value").Value + (lst.Element("grt").Attribute("data") != null && lst.Element("grt").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("grt").Attribute("data").Value : string.Empty) + (lst.Element("grt").Attribute("result") != null && lst.Element("grt").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("grt").Attribute("result").Value : string.Empty) + (lst.Element("grt").Attribute("device") != null && lst.Element("grt").Attribute("device").Value != "" ? " Device: " + lst.Element("grt").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("grt").Attribute("gender").Value + "~" + lst.Element("grt").Value + "~" + ">" + "~" + lst.Element("grt").Attribute("value").Value + "~" + (lst.Element("grt").Attribute("Normal") != null ? lst.Element("grt").Attribute("Normal").Value : string.Empty) + "~~~~~" + (lst.Element("grt").Attribute("data") != null ? lst.Element("grt").Attribute("data").Value : string.Empty) + "~" + (lst.Element("grt").Attribute("result") != null ? lst.Element("grt").Attribute("result").Value : string.Empty) + "~" + (lst.Element("grt").Attribute("device") != null ? lst.Element("grt").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";
                      }


                      if (lst.Element("grq") != null)
                      {
                          ReferenceRange += lst.Element("grq").Attribute("gender").Value + ": " + lst.Element("grq").Value + ": => " + lst.Element("grq").Attribute("value").Value + (lst.Element("grq").Attribute("data") != null && lst.Element("grq").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("grq").Attribute("data").Value : string.Empty) + (lst.Element("grq").Attribute("result") != null && lst.Element("grq").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("grq").Attribute("result").Value : string.Empty) + (lst.Element("grq").Attribute("device") != null && lst.Element("grq").Attribute("device").Value != "" ? " Device: " + lst.Element("grq").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("grq").Attribute("gender").Value + "~" + lst.Element("grq").Value + "~" + "=>" + "~" + lst.Element("grq").Attribute("value").Value + "~" + (lst.Element("grq").Attribute("Normal") != null ? lst.Element("grq").Attribute("Normal").Value : string.Empty) + "~~~~~" + (lst.Element("grq").Attribute("data") != null ? lst.Element("grq").Attribute("data").Value : string.Empty) + "~" + (lst.Element("grq").Attribute("result") != null ? lst.Element("grq").Attribute("result").Value : string.Empty) + "~" + (lst.Element("grq").Attribute("device") != null ? lst.Element("grq").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";
                      }

                      if (lst.Element("btw") != null)
                      {
                          ReferenceRange += lst.Element("btw").Attribute("gender").Value + ": " + lst.Element("btw").Value + ": " + lst.Element("btw").Attribute("value").Value + (lst.Element("btw").Attribute("data") != null && lst.Element("btw").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("btw").Attribute("data").Value : string.Empty) + (lst.Element("btw").Attribute("result") != null && lst.Element("btw").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("btw").Attribute("result").Value : string.Empty) + (lst.Element("btw").Attribute("device") != null && lst.Element("btw").Attribute("device").Value != "" ? " Device: " + lst.Element("btw").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("btw").Attribute("gender").Value + "~" + lst.Element("btw").Value + "~" + ConvertStringOptr("btw") + "~" + lst.Element("btw").Attribute("value").Value + "~" + (lst.Element("btw").Attribute("Normal") != null ? lst.Element("btw").Attribute("Normal").Value : string.Empty) + "~~~~~" + (lst.Element("btw").Attribute("data") != null ? lst.Element("btw").Attribute("data").Value : string.Empty) + "~" + (lst.Element("btw").Attribute("result") != null ? lst.Element("btw").Attribute("result").Value : string.Empty) + "~" + (lst.Element("btw").Attribute("device") != null ? lst.Element("btw").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";
                      }
                      if (lst.Element("ref") != null)
                      {
                          ReferenceRange += lst.Element("ref").Value + "<br/>";
                          ReferenceRangeString += lst.Element("ref").Attribute("gender").Value + "~" + lst.Element("ref").Value + "~" + ConvertStringOptr("ref") + "~" + lst.Element("ref").Attribute("value").Value + "~" + (lst.Element("ref").Attribute("Normal") != null ? lst.Element("ref").Attribute("Normal").Value : string.Empty) + "~Y~~~~~~~" + ResulType + "^";
                      }
                  }

                  ReferenceRangeString += "|Other@";
              }
              if (otherRangeWithText != null && otherRangeWithText.Count() > 0)
              {
                  foreach (var lst in otherRangeWithText)
                  {
                      string ResulType = "Text";

                      if (lst.Element("txt") != null)
                      {
                          ReferenceRange += lst.Element("txt").Attribute("gender").Value + ": " + lst.Element("txt").Value + (lst.Element("txt").Attribute("data") != null && lst.Element("txt").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("txt").Attribute("data").Value : string.Empty) + (lst.Element("txt").Attribute("result") != null && lst.Element("txt").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("txt").Attribute("result").Value : string.Empty) + (lst.Element("txt").Attribute("device") != null && lst.Element("txt").Attribute("device").Value != "" ? " Device: " + lst.Element("txt").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("txt").Attribute("gender").Value + "~" + lst.Element("txt").Value + "~~~" + lst.Element("txt").Attribute("Normal").Value + "~~~~~" + (lst.Element("txt").Attribute("data") != null ? lst.Element("txt").Attribute("data").Value : string.Empty) + "~" + (lst.Element("txt").Attribute("result") != null ? lst.Element("txt").Attribute("result").Value : string.Empty) + "~" + (lst.Element("txt").Attribute("device") != null ? lst.Element("txt").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";
                      }
                      if (lst.Element("ref") != null)
                      {
                          ReferenceRange += lst.Element("ref").Value + "<br/>";
                          ReferenceRangeString += lst.Element("ref").Attribute("gender").Value + "~" + lst.Element("ref").Value + "~" + ConvertStringOptr("ref") + "~~" + lst.Element("ref").Attribute("Normal").Value + "~Y~~~~~~~" + ResulType + "^";
                      }
                  }
                  ReferenceRangeString += "|Other@";
              }
              if (otherRange != null && otherRange.Count() > 0)
              {
                  foreach (var lst in otherRange)
                  {
                      string ResulType = "Numeric";

                      if (lst.Element("lst") != null)
                      {
                          ReferenceRange += lst.Element("lst").Attribute("gender").Value + ": " + lst.Element("lst").Value + ": < " + lst.Element("lst").Attribute("value").Value + (lst.Element("lst").Attribute("data") != null && lst.Element("lst").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("lst").Attribute("data").Value : string.Empty) + (lst.Element("lst").Attribute("result") != null && lst.Element("lst").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("lst").Attribute("result").Value : string.Empty) + (lst.Element("lst").Attribute("device") != null && lst.Element("lst").Attribute("device").Value != "" ? " Device: " + lst.Element("lst").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("lst").Attribute("gender").Value + "~" + lst.Element("lst").Value + "~" + "<" + "~" + lst.Element("lst").Attribute("value").Value + "~~~~~~" + (lst.Element("lst").Attribute("data") != null ? lst.Element("lst").Attribute("data").Value : string.Empty) + "~" + (lst.Element("lst").Attribute("result") != null ? lst.Element("lst").Attribute("result").Value : string.Empty) + "~" + (lst.Element("lst").Attribute("device") != null ? lst.Element("lst").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";

                      }
                      if (lst.Element("lsq") != null)
                      {
                          ReferenceRange += lst.Element("lsq").Attribute("gender").Value + ": " + lst.Element("lsq").Value + ": <= " + lst.Element("lsq").Attribute("value").Value + (lst.Element("lsq").Attribute("data") != null && lst.Element("lsq").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("lsq").Attribute("data").Value : string.Empty) + (lst.Element("lsq").Attribute("result") != null && lst.Element("lsq").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("lsq").Attribute("result").Value : string.Empty) + (lst.Element("lsq").Attribute("device") != null && lst.Element("lsq").Attribute("device").Value != "" ? " Device: " + lst.Element("lsq").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("lsq").Attribute("gender").Value + "~" + lst.Element("lsq").Value + "~" + "<=" + "~" + lst.Element("lsq").Attribute("value").Value + "~~~~~~" + (lst.Element("lsq").Attribute("data") != null ? lst.Element("lsq").Attribute("data").Value : string.Empty) + "~" + (lst.Element("lsq").Attribute("result") != null ? lst.Element("lsq").Attribute("result").Value : string.Empty) + "~" + (lst.Element("lsq").Attribute("device") != null ? lst.Element("lsq").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";
                      }

                      if (lst.Element("eql") != null)
                      {
                          ReferenceRange += lst.Element("eql").Attribute("gender").Value + ": " + lst.Element("eql").Value + ": = " + lst.Element("eql").Attribute("value").Value + (lst.Element("eql").Attribute("data") != null && lst.Element("eql").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("eql").Attribute("data").Value : string.Empty) + (lst.Element("eql").Attribute("result") != null && lst.Element("eql").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("eql").Attribute("result").Value : string.Empty) + (lst.Element("eql").Attribute("device") != null && lst.Element("eql").Attribute("device").Value != "" ? " Device: " + lst.Element("eql").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("eql").Attribute("gender").Value + "~" + lst.Element("eql").Value + "~" + "=" + "~" + lst.Element("eql").Attribute("value").Value + "~~~~~~" + (lst.Element("eql").Attribute("data") != null ? lst.Element("eql").Attribute("data").Value : string.Empty) + "~" + (lst.Element("eql").Attribute("result") != null ? lst.Element("eql").Attribute("result").Value : string.Empty) + "~" + (lst.Element("eql").Attribute("device") != null ? lst.Element("eql").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";
                      }

                      if (lst.Element("grt") != null)
                      {
                          ReferenceRange += lst.Element("grt").Attribute("gender").Value + ": " + lst.Element("grt").Value + ": > " + lst.Element("grt").Attribute("value").Value + (lst.Element("grt").Attribute("data") != null && lst.Element("grt").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("grt").Attribute("data").Value : string.Empty) + (lst.Element("grt").Attribute("result") != null && lst.Element("grt").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("grt").Attribute("result").Value : string.Empty) + (lst.Element("grt").Attribute("device") != null && lst.Element("grt").Attribute("device").Value != "" ? " Device: " + lst.Element("grt").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("grt").Attribute("gender").Value + "~" + lst.Element("grt").Value + "~" + ">" + "~" + lst.Element("grt").Attribute("value").Value + "~~~~~~" + (lst.Element("grt").Attribute("data") != null ? lst.Element("grt").Attribute("data").Value : string.Empty) + "~" + (lst.Element("grt").Attribute("result") != null ? lst.Element("grt").Attribute("result").Value : string.Empty) + "~" + (lst.Element("grt").Attribute("device") != null ? lst.Element("grt").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";
                      }


                      if (lst.Element("grq") != null)
                      {
                          ReferenceRange += lst.Element("grq").Attribute("gender").Value + ": " + lst.Element("grq").Value + ": => " + lst.Element("grq").Attribute("value").Value + (lst.Element("grq").Attribute("data") != null && lst.Element("grq").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("grq").Attribute("data").Value : string.Empty) + (lst.Element("grq").Attribute("result") != null && lst.Element("grq").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("grq").Attribute("result").Value : string.Empty) + (lst.Element("grq").Attribute("device") != null && lst.Element("grq").Attribute("device").Value != "" ? " Device: " + lst.Element("grq").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("grq").Attribute("gender").Value + "~" + lst.Element("grq").Value + "~" + "=>" + "~" + lst.Element("grq").Attribute("value").Value + "~~~~~~" + (lst.Element("grq").Attribute("data") != null ? lst.Element("grq").Attribute("data").Value : string.Empty) + "~" + (lst.Element("grq").Attribute("result") != null ? lst.Element("grq").Attribute("result").Value : string.Empty) + "~" + (lst.Element("grq").Attribute("device") != null ? lst.Element("grq").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";
                      }

                      if (lst.Element("btw") != null)
                      {
                          ReferenceRange += lst.Element("btw").Attribute("gender").Value + ": " + lst.Element("btw").Value + ": " + lst.Element("btw").Attribute("value").Value + (lst.Element("btw").Attribute("data") != null && lst.Element("btw").Attribute("data").Value != "" ? " Interpretation: " + lst.Element("btw").Attribute("data").Value : string.Empty) + (lst.Element("btw").Attribute("result") != null && lst.Element("btw").Attribute("result").Value != "" ? " Show Result From: " + lst.Element("btw").Attribute("result").Value : string.Empty) + (lst.Element("btw").Attribute("device") != null && lst.Element("btw").Attribute("device").Value != "" ? " Device: " + lst.Element("btw").Attribute("device").Value : string.Empty) + "<br/>";
                          ReferenceRangeString += lst.Element("btw").Attribute("gender").Value + "~" + lst.Element("btw").Value + "~" + ConvertStringOptr("btw") + "~" + lst.Element("btw").Attribute("value").Value + "~~~~~~" + (lst.Element("btw").Attribute("data") != null ? lst.Element("btw").Attribute("data").Value : string.Empty) + "~" + (lst.Element("btw").Attribute("result") != null ? lst.Element("btw").Attribute("result").Value : string.Empty) + "~" + (lst.Element("btw").Attribute("device") != null ? lst.Element("btw").Attribute("device").Value : string.Empty) + "~" + ResulType + "^";
                      }
                      if (lst.Element("ref") != null)
                      {
                          ReferenceRange += lst.Element("ref").Value + "<br/>";
                          ReferenceRangeString += lst.Element("ref").Attribute("gender").Value + "~" + lst.Element("ref").Value + "~" + ConvertStringOptr("ref") + "~" + lst.Element("ref").Attribute("value").Value + "~~Y~~~~~~~" + ResulType + "^";
                      }
                  }

                  ReferenceRangeString += "|Other@";
              }
              
            //itemCount = itemCount + 1;
            if (ReferenceRangeString.EndsWith("@"))
            {
                ReferenceRangeString = ReferenceRangeString.Substring(0, ReferenceRangeString.Length - 1);
            }*/

            return ReferenceRange;
        }
        public string ConvertStringOptr(string symbol)
        {
            string ReturnValue = "";
            try
            {
                switch (symbol)
                {
                    case "lst":
                        ReturnValue = "<";
                        break;
                    case "lsq":
                        ReturnValue = "<=";
                        break;
                    case "eql":
                        ReturnValue = "=";
                        break;
                    case "grt":
                        ReturnValue = ">";
                        break;
                    case "grq":
                        ReturnValue = "=>";
                        break;
                    case "btw":
                        ReturnValue = "Between";
                        break;
                    case "ref":
                        ReturnValue = "Source";
                        break;
                }
            }
            catch (Exception ex)
            {
                //CLogger.LogError("Error while converting string to operator", ex);
                throw ex;
            }
            return ReturnValue;

        }
        public long UpdatePatientOrderInvestigation(string OrgCode, string Visitnumber, string Status)
        {
            long returncode = -1; 
            try
            {
                returncode = new LIMSAPI_BL().UpdatePatientOrderInvestigation(OrgCode, Visitnumber, Status);
            }
            catch (Exception ex)
            { }
            return returncode;
        }
        /// <summary>
        /// This API will be used to patient's Approved test results based on visit number.
        /// </summary>
        /// <param name="OrgCode">Give org code of organization</param>
        /// <param name="VisitNumber">Give patient visit number</param>
        /// <returns></returns>
        [ResponseType(typeof(OrderResult))]
        [HttpGet]
        [Route("Api/Orders/GetPatientResultDetailsbyVisitNo")]

        public IHttpActionResult GetPatientResultDetailsbyVisitNo(string OrgCode,string VisitNumber)
        {

            long returnCode = -1;
            IHttpActionResult actionResult = null;
            VisitResPatientDetails lstPat = new VisitResPatientDetails();
            PatAddressDetails lstPatAdd = new PatAddressDetails();

            List<PatientDetail> lstPatDetail = new List<PatientDetail>();
            List<TestOrderVisitDetails> lstPatOrderDetails = new List<TestOrderVisitDetails>();
            List<TestOrderVisitDetails> lstPatOrders = new List<TestOrderVisitDetails>();
            VisitOrderResult ObjOrder = new VisitOrderResult();
            List<CorporatePatients> lstcorp = new List<CorporatePatients>();
            CorporatePatients objcorp = new CorporatePatients();
            VisitResPatientDetails objpat = new VisitResPatientDetails();
            List<PatAddressDetails> lstAdddress = new List<PatAddressDetails>();
            List<TestOrder> lstAllOrder = new List<TestOrder>();
            List<ResPatientVisitDetails> lstpatientvisitdetails = new List<ResPatientVisitDetails>();
            VisitRePatientVisitDetails objvisit = new VisitRePatientVisitDetails();
            try
            {
                returnCode = new LIMSAPI_BL().GetPatientResultDetailsbyVisitNo(OrgCode,VisitNumber, out lstPatDetail, out lstPatOrders, out lstPatOrderDetails, out lstpatientvisitdetails);

                if (returnCode != -1)
                {
                    if (lstPatDetail.Count > 0 && lstPatDetail != null)
                    {
                        objpat.PatientID = lstPatDetail[0].PatientID;
                        objpat.PatientNumber = lstPatDetail[0].PatientNumber;
                        objpat.FirstName = lstPatDetail[0].FirstName;
                        objpat.MiddleName = lstPatDetail[0].MiddleName;
                        objpat.LastName = lstPatDetail[0].LastName;
                        objpat.MobileNumber = lstPatDetail[0].MobileNumber;
                        objpat.URNNumber = lstPatDetail[0].URNNumber;
                        objpat.URNType = lstPatDetail[0].URNType;
                        objpat.Gender = lstPatDetail[0].Gender;
                        objpat.Age = lstPatDetail[0].Age;
                        objpat.DOB = lstPatDetail[0].DOB;
                        objpat.EmailID = lstPatDetail[0].EmailID;
                        objpat.SalutationCode = lstPatDetail[0].SalutationCode;
                        lstPatAdd.Address = lstPatDetail[0].Address;
                        lstPatAdd.State = lstPatDetail[0].State;
                        lstPatAdd.City = lstPatDetail[0].City;
                        lstPatAdd.Country = lstPatDetail[0].Country;
                        lstPatAdd.AddressType = lstPatDetail[0].AddressType;
                        lstPatAdd.StateID = lstPatDetail[0].StateID;
                        lstPatAdd.CountryID = lstPatDetail[0].CountryID;
                        lstPatAdd.ExternalPatientNumber = lstPatDetail[0].ExternalPatientNumber;
                        lstAdddress.Add(lstPatAdd);
                        objpat.AddressDetails = lstAdddress;
                        ObjOrder.PatientInfo = objpat;
                        ObjOrder.OrderId = lstPatDetail[0].OrderID;
                        ObjOrder.OrgCode = OrgCode;
                        TimeZone = lstPatDetail[0].TimeZone;
                    }
                    if (lstpatientvisitdetails != null && lstpatientvisitdetails.Count > 0)
                    {
                        objvisit.ClientID = lstpatientvisitdetails[0].ClientID;
                        objvisit.PatientVisitId = lstpatientvisitdetails[0].PatientVisitId;
                        objvisit.ExternalVisitNumber = lstpatientvisitdetails[0].ExternalVisitNumber;
                        objvisit.VisitType = lstpatientvisitdetails[0].VisitType;
                        objvisit.VisitDate = GetTimeZoneTime(lstpatientvisitdetails[0].VisitDate);
                        objvisit.VATRegisterationNo = lstpatientvisitdetails[0].VATRegisterationNo;
                        objvisit.ClientCode = lstpatientvisitdetails[0].ClientCode;
                        objvisit.ClientName = lstpatientvisitdetails[0].ClientName;
                        objvisit.VisitHistory = lstpatientvisitdetails[0].VisitHistory;
                        objvisit.VisitRemarks = lstpatientvisitdetails[0].VisitRemarks;
                        objvisit.ReferingDoctorCode = lstpatientvisitdetails[0].ReferingDoctorCode;
                        objvisit.ReferingDoctorMobileNumber = lstpatientvisitdetails[0].ReferingDoctorMobileNumber;
                        objvisit.ReferingDoctorName = lstpatientvisitdetails[0].ReferingDoctorName;
                        objvisit.HospitalName = lstpatientvisitdetails[0].HospitalName;
                        objvisit.HospitalNameCode = lstpatientvisitdetails[0].HospitalNameCode;
                        objvisit.RegisterLocation = lstpatientvisitdetails[0].RegisterLocation;
                        objvisit.IsNotification = lstpatientvisitdetails[0].IsNotification;
                        objvisit.CompanyID = lstpatientvisitdetails[0].CompanyID;
                        ObjOrder.PatientVisitInfo = objvisit;
                        if (lstpatientvisitdetails[0].BookedDate != null && lstpatientvisitdetails[0].BookedDate.ToString("yyyy-MM-dd") != "0001-01-01")
                        {
                            objcorp.BookedDate = GetTimeZoneTime(lstpatientvisitdetails[0].BookedDate);
                            objcorp.CheckinDate = GetTimeZoneTime(lstpatientvisitdetails[0].CheckinDate);
                            objcorp.CheckOutDate = GetTimeZoneTime(lstpatientvisitdetails[0].CheckOutDate);
                            objcorp.Status = lstpatientvisitdetails[0].Status;
                            ObjOrder.CorporatePatient = objcorp;
                        }
                    }
                    if (lstPatOrders != null && lstPatOrders.Count > 0)
                    {
                        ObjOrder.OverAllStatus = lstPatOrders[0].OverAllStatus;


                        foreach (TestOrderVisitDetails s in lstPatOrders)
                        {

                            if (s.TestType == "INV")
                            {
                                TestOrder objtest = new TestOrder();
                                objtest.PatientVisitID = s.PatientVisitID;
                                objtest.ExternalVisitID = s.ExternalVisitID;
                                objtest.TestID = s.TestID;
                                objtest.TestCode = s.TestCode;
                                objtest.OrderedDate = GetTimeZoneTime(s.OrderedDate);
                                objtest.TestType = s.TestType;
                                objtest.TestName = s.TestName;
                                objtest.TestValueType = s.TestValueType;
                                objtest.TestValue = s.TestValue;
                                objtest.UOMCode = s.UOMCode;
                                objtest.MethodName = s.MethodName;
                                objtest.ReferenceRange = s.ReferenceRange.Contains("<?xml") ? ParseXML(s.ReferenceRange) : s.ReferenceRange;
                                objtest.IsAbnormal = s.IsAbnormal;
                                objtest.ResultCapturedAt = GetTimeZoneTime(s.ResultCapturedAt);
                                objtest.TestStatus = s.TestStatus;
                                objtest.MedicalRemarks = s.MedicalRemarks;
                                objtest.InterpretationNotes = s.InterpretationNotes;
                                objtest.ProcessingType = s.ProcessingType;
                                objtest.ProcessingLocation = s.ProcessingLocation;
                                objtest.DeviceID = s.DeviceID;
                                objtest.LotNumber = s.LotNumber;
                                objtest.CreatedAt = GetTimeZoneTime(s.CreatedAt);
                                objtest.UpdatedAt = GetTimeZoneTime(s.UpdatedAt);
                                objtest.DepartmentName = s.DepartmentName;
                                objtest.DeltaValue = s.DeltaValue;
                                objtest.UserID = s.UserID;
                                objtest.UserName = s.UserName;
                                objtest.SampleName = s.SampleName;
                                objtest.ConversionRange = s.ConversionRange.Contains("<?xml") ? ParseXML(s.ConversionRange) : s.ConversionRange;
                                objtest.ConversionValue = s.ConversionValue;
                                objtest.ConversionUnit = s.ConversionUnit;
                                objtest.Nonreportable = s.Nonreportable;
                                lstAllOrder.Add(objtest);
                            }

                            if (s.TestType == "GRP")
                            {
                                foreach (TestOrderVisitDetails inv in lstPatOrderDetails)
                                {
                                    if (s.TestID == inv.GroupID)
                                    {
                                        TestOrder objgrp = new TestOrder();
                                        TestOrderContentVisit objpkgcnt = new TestOrderContentVisit();
                                        TestOrderVisit objpkgparam = new TestOrderVisit();
                                        objgrp.PatientVisitID = inv.PatientVisitID;
                                        objgrp.ExternalVisitID = inv.ExternalVisitID;
                                        objgrp.TestID = s.TestID;
                                        objgrp.TestCode = s.TestCode;
                                        objgrp.OrderedDate = GetTimeZoneTime(s.OrderedDate);
                                        objgrp.TestType = s.TestType;
                                        objgrp.TestName = s.TestName;
                                        objgrp.TestValueType = s.TestValueType;
                                        objgrp.TestValue = s.TestValue;
                                        objgrp.UOMCode = s.UOMCode;
                                        objgrp.MethodName = s.MethodName;
                                        objgrp.ReferenceRange = s.ReferenceRange.Contains("<?xml") ? ParseXML(s.ReferenceRange) : s.ReferenceRange;
                                        objgrp.IsAbnormal = s.IsAbnormal;
                                        objgrp.ResultCapturedAt = GetTimeZoneTime(s.ResultCapturedAt);
                                        objgrp.TestStatus = s.TestStatus;
                                        objgrp.MedicalRemarks = s.MedicalRemarks;
                                        objgrp.InterpretationNotes = s.InterpretationNotes;
                                        objgrp.ProcessingType = s.ProcessingType;
                                        objgrp.ProcessingLocation = s.ProcessingLocation;
                                        objgrp.DeviceID = s.DeviceID;
                                        objgrp.LotNumber = s.LotNumber;
                                        objgrp.CreatedAt = GetTimeZoneTime(s.CreatedAt);
                                        objgrp.UpdatedAt = GetTimeZoneTime(s.UpdatedAt);
                                        objgrp.DepartmentName = s.DepartmentName;
                                        objgrp.DeltaValue = s.DeltaValue;
                                        objgrp.UserID = s.UserID;
                                        objgrp.UserName = s.UserName;
                                        objgrp.SampleName = s.SampleName;
                                        objgrp.ConversionRange = s.ConversionRange.Contains("<?xml") ? ParseXML(s.ConversionRange) : s.ConversionRange;
                                        objgrp.ConversionValue = s.ConversionValue;
                                        objgrp.ConversionUnit = s.ConversionUnit;
                                        objgrp.Nonreportable = s.Nonreportable;
                                        List<TestOrderContentVisit> lstpkg = new List<TestOrderContentVisit>();
                                        var Contentpkg = lstPatOrderDetails.FindAll(p => p.GroupID == inv.GroupID && p.SubGroupID == "0");
                                        //  var Contentpkgparam = lstPatOrderDetails.FindAll(p => p.GroupID == inv.GroupID);
                                        var Contentpkgparam = lstPatOrderDetails.Where(t => t.SubGroupID != "0" && t.GroupID != "0" && t.GroupID == inv.GroupID).GroupBy(test => test.SubGroupID).Select(grp => grp.First()).ToList();
                                        var Contentpkgparam1 = lstPatOrderDetails.FindAll(p => p.GroupID == inv.GroupID);
                                        List<TestOrderContentVisit> lstpkgcont = new List<TestOrderContentVisit>();
                                        foreach (TestOrderVisitDetails tall in Contentpkg)
                                        {
                                            TestOrderContentVisit objcont = new TestOrderContentVisit();
                                            objcont.TestCode = tall.TestCode;
                                            objcont.OrderedDate = GetTimeZoneTime(tall.OrderedDate);
                                            objcont.TestType = tall.TestType;
                                            objcont.TestID = tall.TestID;
                                            objcont.TestName = tall.TestName;
                                            objcont.TestValueType = tall.TestValueType;
                                            objcont.TestValue = tall.TestValue;
                                            objcont.UOMCode = tall.UOMCode;
                                            objcont.MethodName = tall.MethodName;
                                            objcont.ReferenceRange = tall.ReferenceRange.Contains("<?xml") ? ParseXML(tall.ReferenceRange) : tall.ReferenceRange;
                                            objcont.IsAbnormal = tall.IsAbnormal;
                                            objcont.ResultCapturedAt = GetTimeZoneTime(tall.ResultCapturedAt);
                                            objcont.TestStatus = tall.TestStatus;
                                            objcont.MedicalRemarks = tall.MedicalRemarks;
                                            objcont.InterpretationNotes = tall.InterpretationNotes;
                                            objcont.ProcessingType = tall.ProcessingType;
                                            objcont.ProcessingLocation = tall.ProcessingLocation;
                                            objcont.DeviceID = tall.DeviceID;
                                            objcont.LotNumber = tall.LotNumber;
                                            objcont.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                            objcont.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                            objcont.DepartmentName = tall.DepartmentName;
                                            objcont.DeltaValue = tall.DeltaValue;
                                            objcont.UserID = tall.UserID;
                                            objcont.UserName = tall.UserName;
                                            objcont.SampleName = tall.SampleName;
                                            objcont.ConversionRange = tall.ConversionRange.Contains("<?xml") ? ParseXML(tall.ConversionRange) : tall.ConversionRange;
                                            objcont.ConversionValue = tall.ConversionValue;
                                            objcont.ConversionUnit = tall.ConversionUnit;
                                            objcont.Nonreportable = tall.Nonreportable;
                                            lstpkgcont.Add(objcont);

                                        }
                                        foreach (TestOrderVisitDetails tall in Contentpkgparam)
                                        {
                                            TestOrderContentVisit objcont1 = new TestOrderContentVisit();
                                            objcont1.TestCode = tall.SubGroupCode;
                                            objcont1.OrderedDate = GetTimeZoneTime(tall.OrderedDate);
                                            objcont1.TestType = "GRP";
                                            objcont1.TestID = tall.SubGroupID;
                                            objcont1.TestName = tall.SubGroupName;
                                            objcont1.TestValueType = tall.TestValueType;
                                            objcont1.TestValue = "";
                                            objcont1.UOMCode = tall.UOMCode;
                                            objcont1.MethodName = tall.MethodName;
                                            objcont1.ReferenceRange = tall.ReferenceRange.Contains("<?xml") ? ParseXML(tall.ReferenceRange) : tall.ReferenceRange;
                                            objcont1.IsAbnormal = tall.IsAbnormal;
                                            objcont1.ResultCapturedAt = GetTimeZoneTime(tall.ResultCapturedAt);
                                            objcont1.TestStatus = tall.TestStatus;
                                            objcont1.MedicalRemarks = tall.MedicalRemarks;
                                            objcont1.InterpretationNotes = tall.InterpretationNotes;
                                            objcont1.ProcessingType = tall.ProcessingType;
                                            objcont1.ProcessingLocation = tall.ProcessingLocation;
                                            objcont1.DeviceID = tall.DeviceID;
                                            objcont1.LotNumber = tall.LotNumber;
                                            objcont1.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                            objcont1.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                            objcont1.DepartmentName = tall.DepartmentName;
                                            objcont1.DeltaValue = "";
                                            objcont1.UserID = tall.UserID;
                                            objcont1.UserName = tall.UserName;
                                            objcont1.SampleName = tall.SampleName;
                                            objcont1.ConversionRange = tall.ConversionRange.Contains("<?xml") ? ParseXML(tall.ConversionRange) : tall.ConversionRange;
                                            objcont1.ConversionValue = tall.ConversionValue;
                                            objcont1.ConversionUnit = tall.ConversionUnit;
                                            objcont1.Nonreportable = tall.Nonreportable;
                                            List<TestOrderVisit> lstpkgcontpar = new List<TestOrderVisit>();
                                            foreach (TestOrderVisitDetails objp in Contentpkgparam1)
                                            {
                                                TestOrderVisit objcontpar = new TestOrderVisit();
                                                if (tall.SubGroupID == objp.SubGroupID)// && objp.SubGroupID == "0")
                                                {
                                                    objcontpar.TestCode = objp.TestCode;
                                                    objcontpar.OrderedDate = GetTimeZoneTime(objp.OrderedDate);
                                                    objcontpar.TestType = objp.TestType;
                                                    objcontpar.TestID = objp.TestID;
                                                    objcontpar.TestName = objp.TestName;
                                                    objcontpar.TestValueType = objp.TestValueType;
                                                    objcontpar.TestValue = objp.TestValue;
                                                    objcontpar.UOMCode = objp.UOMCode;
                                                    objcontpar.MethodName = objp.MethodName;
                                                    objcontpar.ReferenceRange = objp.ReferenceRange.Contains("<?xml") ? ParseXML(objp.ReferenceRange) : objp.ReferenceRange;
                                                    objcontpar.IsAbnormal = objp.IsAbnormal;
                                                    objcontpar.ResultCapturedAt = GetTimeZoneTime(objp.ResultCapturedAt);
                                                    objcontpar.TestStatus = objp.TestStatus;
                                                    objcontpar.MedicalRemarks = objp.MedicalRemarks;
                                                    objcontpar.InterpretationNotes = objp.InterpretationNotes;
                                                    objcontpar.ProcessingType = objp.ProcessingType;
                                                    objcontpar.ProcessingLocation = objp.ProcessingLocation;
                                                    objcontpar.DeviceID = objp.DeviceID;
                                                    objcontpar.LotNumber = objp.LotNumber;
                                                    objcontpar.CreatedAt = GetTimeZoneTime(objp.CreatedAt);
                                                    objcontpar.UpdatedAt = GetTimeZoneTime(objp.UpdatedAt);
                                                    objcontpar.DepartmentName = objp.DepartmentName;
                                                    objcontpar.DeltaValue = objp.DeltaValue;
                                                    objcontpar.UserID = objp.UserID;
                                                    objcontpar.UserName = objp.UserName;
                                                    objcontpar.SampleName = objp.SampleName;
                                                    objcontpar.ConversionRange = objp.ConversionRange.Contains("<?xml") ? ParseXML(tall.ConversionRange) : tall.ConversionRange;
                                                    objcontpar.ConversionValue = objp.ConversionValue;
                                                    objcontpar.ConversionUnit = objp.ConversionUnit;
                                                    objcontpar.Nonreportable = objp.Nonreportable;
                                                    lstpkgcontpar.Add(objcontpar);
                                                }
                                            }

                                            objcont1.ParameterListInfo = lstpkgcontpar;
                                            lstpkgcont.Add(objcont1);
                                        }
                                        objgrp.OrderContentListInfo = lstpkgcont;
                                        if (!lstAllOrder.Exists(p => p.TestID == objgrp.TestID && p.TestType == objgrp.TestType))
                                            lstAllOrder.Add(objgrp);
                                    }
                                }
                            }
                            if (s.TestType == "PKG")// && s.TestID == inv.PKGID)
                            {
                                foreach (TestOrderVisitDetails inv in lstPatOrderDetails)
                                {
                                    if (s.TestID == inv.PKGID)
                                    {
                                        TestOrder objpkg = new TestOrder();
                                        TestOrderContentVisit objpkgcnt = new TestOrderContentVisit();
                                        TestOrderVisit objpkgparam = new TestOrderVisit();
                                        objpkg.PatientVisitID = inv.PatientVisitID;
                                        objpkg.ExternalVisitID = inv.ExternalVisitID;
                                        objpkg.TestID = s.TestID;
                                        objpkg.TestCode = s.TestCode;
                                        objpkg.OrderedDate = GetTimeZoneTime(s.OrderedDate);
                                        objpkg.TestType = s.TestType;
                                        objpkg.TestName = s.TestName;
                                        objpkg.TestValueType = s.TestValueType;
                                        objpkg.TestValue = s.TestValue;
                                        objpkg.UOMCode = s.UOMCode;
                                        objpkg.MethodName = s.MethodName;
                                        objpkg.ReferenceRange = s.ReferenceRange.Contains("<?xml") ? ParseXML(s.ReferenceRange) : s.ReferenceRange;
                                        objpkg.IsAbnormal = s.IsAbnormal;
                                        objpkg.ResultCapturedAt = GetTimeZoneTime(s.ResultCapturedAt);
                                        objpkg.TestStatus = s.TestStatus;
                                        objpkg.MedicalRemarks = s.MedicalRemarks;
                                        objpkg.InterpretationNotes = s.InterpretationNotes;
                                        objpkg.ProcessingType = s.ProcessingType;
                                        objpkg.ProcessingLocation = s.ProcessingLocation;
                                        objpkg.DeviceID = s.DeviceID;
                                        objpkg.LotNumber = s.LotNumber;
                                        objpkg.CreatedAt = GetTimeZoneTime(s.CreatedAt);
                                        objpkg.UpdatedAt = GetTimeZoneTime(s.UpdatedAt);
                                        objpkg.DepartmentName = s.DepartmentName;
                                        objpkg.DeltaValue = s.DeltaValue;
                                        objpkg.UserID = s.UserID;
                                        objpkg.UserName = s.UserName;
                                        objpkg.SampleName = s.SampleName;
                                        objpkg.ConversionRange = s.ConversionRange.Contains("<?xml") ? ParseXML(s.ConversionRange) : s.ConversionRange;
                                        objpkg.ConversionValue = s.ConversionValue;
                                        objpkg.ConversionUnit = s.ConversionUnit;
                                        objpkg.Nonreportable = s.Nonreportable;
                                        List<TestOrderContentVisit> lstpkg = new List<TestOrderContentVisit>();
                                        var Contentpkg = lstPatOrderDetails.FindAll(p => p.PKGID == inv.PKGID && p.GroupID == "0");
                                        //  var Contentpkgparam = lstPatOrderDetails.FindAll(p => p.GroupID == inv.GroupID);
                                        var Contentpkgparam = lstPatOrderDetails.GroupBy(test => test.GroupID)
                                                     .Select(grp => grp.First())
                                                     .Where(t => t.GroupID != "0" && t.PKGID != "0" && t.PKGID == inv.PKGID)
                                                       .ToList();
                                        var Contentpkgparam1 = lstPatOrderDetails.FindAll(p => p.PKGID == inv.PKGID);
                                        List<TestOrderContentVisit> lstpkgcont = new List<TestOrderContentVisit>();

                                        foreach (TestOrderVisitDetails tall in Contentpkg)
                                        {
                                            TestOrderContentVisit objcont = new TestOrderContentVisit();
                                            objcont.TestCode = tall.TestCode;
                                            objcont.OrderedDate = GetTimeZoneTime(tall.OrderedDate);
                                            objcont.TestType = tall.TestType;
                                            objcont.TestID = tall.TestID;
                                            objcont.TestName = tall.TestName;
                                            objcont.TestValueType = tall.TestValueType;
                                            objcont.TestValue = tall.TestValue;
                                            objcont.UOMCode = tall.UOMCode;
                                            objcont.MethodName = tall.MethodName;
                                            objcont.ReferenceRange = tall.ReferenceRange.Contains("<?xml") ? ParseXML(tall.ReferenceRange) : tall.ReferenceRange;
                                            objcont.IsAbnormal = tall.IsAbnormal;
                                            objcont.ResultCapturedAt = GetTimeZoneTime(tall.ResultCapturedAt);
                                            objcont.TestStatus = tall.TestStatus;
                                            objcont.MedicalRemarks = tall.MedicalRemarks;
                                            objcont.InterpretationNotes = tall.InterpretationNotes;
                                            objcont.ProcessingType = tall.ProcessingType;
                                            objcont.ProcessingLocation = tall.ProcessingLocation;
                                            objcont.DeviceID = tall.DeviceID;
                                            objcont.LotNumber = tall.LotNumber;
                                            objcont.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                            objcont.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                            objcont.DepartmentName = tall.DepartmentName;
                                            objcont.DeltaValue = tall.DeltaValue;
                                            objcont.UserID = tall.UserID;
                                            objcont.UserName = tall.UserName;
                                            objcont.SampleName = tall.SampleName;
                                            objcont.ConversionRange = tall.ConversionRange.Contains("<?xml") ? ParseXML(tall.ConversionRange) : tall.ConversionRange;
                                            objcont.ConversionValue = tall.ConversionValue;
                                            objcont.ConversionUnit = tall.ConversionUnit;
                                            objcont.Nonreportable = tall.Nonreportable;
                                            lstpkgcont.Add(objcont);

                                        }

                                        foreach (TestOrderVisitDetails tall in Contentpkgparam)
                                        {
                                            TestOrderContentVisit objcont1 = new TestOrderContentVisit();
                                            objcont1.TestCode = tall.GroupCode;
                                            objcont1.OrderedDate = GetTimeZoneTime(tall.OrderedDate);
                                            objcont1.TestType = "GRP";
                                            objcont1.TestID = tall.GroupID;
                                            objcont1.TestName = tall.GroupName;
                                            objcont1.TestValueType = tall.TestValueType;
                                            objcont1.TestValue = "";
                                            objcont1.UOMCode = tall.UOMCode;
                                            objcont1.MethodName = tall.MethodName;
                                            objcont1.ReferenceRange = tall.ReferenceRange.Contains("<?xml") ? ParseXML(tall.ReferenceRange) : tall.ReferenceRange;
                                            objcont1.IsAbnormal = tall.IsAbnormal;
                                            objcont1.ResultCapturedAt = GetTimeZoneTime(tall.ResultCapturedAt);
                                            objcont1.TestStatus = tall.TestStatus;
                                            objcont1.MedicalRemarks = tall.MedicalRemarks;
                                            objcont1.InterpretationNotes = tall.InterpretationNotes;
                                            objcont1.ProcessingType = tall.ProcessingType;
                                            objcont1.ProcessingLocation = tall.ProcessingLocation;
                                            objcont1.DeviceID = tall.DeviceID;
                                            objcont1.LotNumber = tall.LotNumber;
                                            objcont1.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                            objcont1.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                            objcont1.DepartmentName = tall.DepartmentName;
                                            objcont1.DeltaValue = "";
                                            objcont1.UserID = tall.UserID;
                                            objcont1.UserName = tall.UserName;
                                            objcont1.SampleName = tall.SampleName;
                                            objcont1.ConversionRange = tall.ConversionRange.Contains("<?xml") ? ParseXML(tall.ConversionRange) : tall.ConversionRange;
                                            objcont1.ConversionValue = tall.ConversionValue;
                                            objcont1.ConversionUnit = tall.ConversionUnit;
                                            objcont1.Nonreportable = tall.Nonreportable;
                                            List<TestOrderVisit> lstpkgcontpar = new List<TestOrderVisit>();
                                            foreach (TestOrderVisitDetails objp in Contentpkgparam1)
                                            {
                                                TestOrderVisit objcontpar = new TestOrderVisit();
                                                if (tall.GroupID == objp.GroupID)// && objp.SubGroupID == "0")
                                                {
                                                    objcontpar.TestCode = objp.TestCode;
                                                    objcontpar.OrderedDate = GetTimeZoneTime(objp.OrderedDate);
                                                    objcontpar.TestType = objp.TestType;
                                                    objcontpar.TestID = objp.TestID;
                                                    objcontpar.TestName = objp.TestName;
                                                    objcontpar.TestValueType = objp.TestValueType;
                                                    objcontpar.TestValue = objp.TestValue;
                                                    objcontpar.UOMCode = objp.UOMCode;
                                                    objcontpar.MethodName = objp.MethodName;
                                                    objcontpar.ReferenceRange = objp.ReferenceRange.Contains("<?xml") ? ParseXML(objp.ReferenceRange) : objp.ReferenceRange;
                                                    objcontpar.IsAbnormal = objp.IsAbnormal;
                                                    objcontpar.ResultCapturedAt = GetTimeZoneTime(objp.ResultCapturedAt);
                                                    objcontpar.TestStatus = objp.TestStatus;
                                                    objcontpar.MedicalRemarks = objp.MedicalRemarks;
                                                    objcontpar.InterpretationNotes = objp.InterpretationNotes;
                                                    objcontpar.ProcessingType = objp.ProcessingType;
                                                    objcontpar.ProcessingLocation = objp.ProcessingLocation;
                                                    objcontpar.DeviceID = objp.DeviceID;
                                                    objcontpar.LotNumber = objp.LotNumber;
                                                    objcontpar.CreatedAt = GetTimeZoneTime(objp.CreatedAt);
                                                    objcontpar.UpdatedAt = GetTimeZoneTime(objp.UpdatedAt);
                                                    objcontpar.DepartmentName = objp.DepartmentName;
                                                    objcontpar.DeltaValue = objp.DeltaValue;
                                                    objcontpar.UserID = objp.UserID;
                                                    objcontpar.UserName = objp.UserName;
                                                    objcontpar.SampleName = objp.SampleName;
                                                    objcontpar.ConversionRange = objp.ConversionRange.Contains("<?xml") ? ParseXML(objp.ConversionRange) : objp.ConversionRange;
                                                    objcontpar.ConversionValue = objp.ConversionValue;
                                                    objcontpar.ConversionUnit = objp.ConversionUnit;
                                                    objcontpar.Nonreportable = objp.Nonreportable;
                                                    lstpkgcontpar.Add(objcontpar);
                                                }
                                            }

                                            objcont1.ParameterListInfo = lstpkgcontpar;
                                            lstpkgcont.Add(objcont1);
                                        }
                                        objpkg.OrderContentListInfo = lstpkgcont;
                                        if (!lstAllOrder.Exists(p => p.TestID == objpkg.TestID && p.TestType == objpkg.TestType))
                                            lstAllOrder.Add(objpkg);
                                    }
                                }
                            }
                        }
                        int ordercount = 0;
                        if (lstAllOrder.Count > 0)
                        {
                            ordercount = lstAllOrder.Count;
                        }


                        /*   List<PatientResultPDF> lstresultPDF = new List<PatientResultPDF>();
                        string PathwithfileName = string.Empty;
                        string pVisitNumber = lstPatDetail[0].OrderID;

                        byte[] filepathByte = null;
                        byte[] OutfilepathByte = null;

                        returnCode = new LIMSAPI_BL().GetPatientPDFfile(OrgCode, 0, pVisitNumber, out lstresultPDF);
                        if (returnCode != -1)
                        {
                            if (lstresultPDF.Count > 0 && lstresultPDF != null)
                            {
                                string folderroot = lstresultPDF[0].FileFolder + lstresultPDF[0].FilePath;
                                string Newroot = string.Empty;
                                string root = string.Empty;

                                var myList = new List<string>();
                                int cnt = 0;
                                string outsource = string.Empty;
                                if (!System.IO.Directory.Exists(folderroot))
                                {
                                    System.IO.Directory.CreateDirectory(folderroot);
                                }
                                foreach (PatientResultPDF objpdf in lstresultPDF)
                                {
                                    if (objpdf.FileType.ToLower() == "outsource")
                                    {
                                        outsource = "Y";
                                    }
                                    if (objpdf.FileType.ToLower() == "pdf")
                                    {
                                        var fileName = Path.GetFileName(objpdf.FilePathName);
                                        PathwithfileName = objpdf.FilePathName;//.Replace("/", ""); 
                                        root = objpdf.FileFolder + objpdf.FilePath.Replace('/', '\\') + objpdf.FileName;
                                        Newroot = objpdf.FileFolder + objpdf.FilePath.Replace("REPORT", "OUTSOURCEREPORT");
                                        if (File.Exists(PathwithfileName))
                                        {
                                            filepathByte = File.ReadAllBytes(PathwithfileName);
                                        }

                                    }
                                    myList.Add(objpdf.FilePathName);
                                }
                                if (outsource == "Y")
                                {


                                    var myArray = myList.ToArray();
                                    byte[] bytes = concatAndAddContent(myArray);
                                    string OrginalFileName = Newroot + Path.GetFileName(root);
                                    string TempFileName = Newroot + Path.GetFileName(root);
                                    TempFileName = TempFileName.Replace(".pdf", "temp.pdf");
                                    bool _FileUse = false;
                                    int ThreadCount = 1000;
                                    if (!System.IO.Directory.Exists(Newroot))
                                    {
                                        System.IO.Directory.CreateDirectory(Newroot);
                                    }

                                    while (!_FileUse)
                                    {
                                        try
                                        {
                                            using (FileStream fsNew = new FileStream(TempFileName, FileMode.Create, FileAccess.Write))
                                            {
                                                byte[] finalresult = new byte[byte.MaxValue];
                                                fsNew.Write(bytes, 0, bytes.Length);
                                                fsNew.Close();
                                            }
                                            AddPageNumber(TempFileName, OrginalFileName);
                                            Thread.Sleep(1000);
                                            _FileUse = true;
                                        }
                                        catch (Exception ex)
                                        {
                                            Thread.Sleep(1000);
                                            _FileUse = false;
                                            if (ThreadCount == 30000)
                                            {
                                                _FileUse = true;
                                            }

                                        }
                                    }
                                    var root1 = OrginalFileName;
                                    if (File.Exists(root1))
                                    {
                                        OutfilepathByte = File.ReadAllBytes(root1);
                                    }
                                }
                            }
                        }


                        //lstAllOrder[ordercount - 1].ResultAsPdf = filepathByte;
                        ObjOrder.ResultAsPdf = filepathByte;
                        ObjOrder.OutsourceAsPdf = OutfilepathByte;*/
                        ObjOrder.OrderInfo = lstAllOrder;
                    }
                    actionResult = Ok(ObjOrder);
                }
                else
                {
                    actionResult = Ok("While fetching the data getting an Error.");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured" + ex.ToString()); 
            }

            return actionResult;
        }
        public static byte[] concatAndAddContent(string[] filename)
        {
            byte[] mergedPdf = null;
            string strTempFileName = string.Empty;
            try
            { 
                using (MemoryStream ms = new MemoryStream())
                { 
                    using (Document document = new Document())
                    { 
                        using (PdfCopy copy = new PdfCopy(document, ms))
                        { 
                            document.Open(); 
                            for (int i = 0; i <= filename.Length - 1; ++i)
                            {
                                if (File.Exists(filename[i]))
                                {
                                    if (filename[i] != "")
                                    {
                                        iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(filename[i]);
                                        int n = reader.NumberOfPages;
                                        for (int page = 0; page < n;)
                                        {
                                            copy.AddPage(copy.GetImportedPage(reader, ++page));
                                        }

                                    }
                                }
                            }
                        }
                    }
                    mergedPdf = ms.ToArray();
                     
                }
            }
            catch (Exception ex)
            { 
            }
            finally
            {
                 
            }
            return mergedPdf;
        }
        protected void AddPageNumber(string InputFileName, string OutputFileName)
        {
            try
            {
                byte[] bytes = File.ReadAllBytes(InputFileName);
                iTextSharp.text.Font blackFont = FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                iTextSharp.text.Font whiteFont = FontFactory.GetFont("Arial", 25, iTextSharp.text.Font.NORMAL, BaseColor.RED);
                using (MemoryStream stream = new MemoryStream())
                {
                    iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(bytes);

                    //PdfReader readerimg = new PdfReader(bytesimg);
                    using (PdfStamper stamper = new PdfStamper(reader, stream))
                    {
                        int pages = reader.NumberOfPages;
                        iTextSharp.text.pdf.PdfRectangle rect1 = new iTextSharp.text.pdf.PdfRectangle(0, 100, 450, 35);
                        if (File.Exists(OutputFileName))
                        {
                            File.Delete(OutputFileName);
                        }
                        FileStream fs = new FileStream(OutputFileName, FileMode.Create);
                        PdfPTable table = new PdfPTable(1);
                        table.TotalWidth = 200f;
                        Document doc = new Document(PageSize.A4, 25, 25, 30, 30);
                        PdfWriter writer = PdfWriter.GetInstance(doc, fs);

                        doc.Open();
                        PdfContentByte cb = writer.DirectContent;
                        cb.BeginText();
                        fs.Close();
                        int ilx = 450;
                        int ily = 63;//66,53,60
                        PdfPCell cell = new PdfPCell();
                        for (int i = 1; i <= pages; i++)
                        {
                            string pagecontent = "Page " + i.ToString() + " of " + pages;
                            DataTable dt = GetDataTable();
                            if (dt != null)
                            {
                                Font font8 = FontFactory.GetFont("ARIAL", 8, BaseColor.WHITE);
                                table = new PdfPTable(dt.Columns.Count);

                                cell = new PdfPCell(new Phrase(new Chunk("ID", font8)));
                                cell.BackgroundColor = BaseColor.WHITE;
                                cell.BorderColor = BaseColor.WHITE;
                                cell.Rowspan = 6;
                                table.AddCell(cell);
                                cell = new PdfPCell(new Phrase(new Chunk("Name", font8)));
                                cell.BackgroundColor = BaseColor.WHITE;
                                cell.BorderColor = BaseColor.WHITE;
                                cell.Rowspan = 6;
                                table.AddCell(cell);
                                cell = new PdfPCell(new Phrase(new Chunk("Country", font8)));
                                cell.BackgroundColor = BaseColor.WHITE;
                                cell.BorderColor = BaseColor.WHITE;
                                cell.Rowspan = 6;
                                table.AddCell(cell);
                            }
                            ColumnText ct = new ColumnText(stamper.GetOverContent(i));
                            ct.AddElement(table);
                            //iTextSharp.text.Rectangle rect = new iTextSharp.text.Rectangle(46, 190, 530, 36);
                            iTextSharp.text.Rectangle rect = new iTextSharp.text.Rectangle(56, 160, 530, 58);
                            ct.SetSimpleColumn(ilx, ily, PageSize.A4.Width - 36, 15);
                            ct.Go();
                            //ColumnText.ShowTextAligned(stamper.GetUnderContent(i), Element.ALIGN_RIGHT, new Phrase(dummyconten, whiteFont), 535f, 45f, 0);
                            ColumnText.ShowTextAligned(stamper.GetUnderContent(i), Element.ALIGN_RIGHT, new Phrase(pagecontent, blackFont), 538f, 35f, 0);
                            //ColumnText.ShowTextAligned(stamper.GetUnderContent(i), Element.ALIGN_RIGHT, new Phrase(pagecontent, blackFont), 535f, 55f, 0);
                            doc.Add(table);
                        }

                    }
                    bytes = stream.ToArray();
                }
                File.WriteAllBytes(OutputFileName, bytes);
            }
            catch (Exception ex)
            { 
            }
            finally
            {
                if (File.Exists(InputFileName))
                {
                    File.Delete(InputFileName);
                }
            }

        }
        private DataTable GetDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Id", typeof(int)),
                        new DataColumn("Name", typeof(string)),
                        new DataColumn("Country",typeof(string)) });
            dt.Rows.Add(1, "", "");
            dt.Rows.Add(2, "", "");
            dt.Rows.Add(3, "", "");
            return dt;
        }
        /// <summary>
        /// This API will be used to patient's Approved test results based on visit number not Outsourcepdf.
        /// </summary>
        /// <param name="OrgCode">Give org code of organization</param>
        /// <param name="VisitNumber">Give patient visit number</param>
        /// <returns></returns>
        [ResponseType(typeof(OrderSampleStatus))]
        [HttpGet]
        [Route("Api/Orders/GetPatientResultDetailsVisitNo")]

        public IHttpActionResult GetPatientResultDetailsVisitNo(string OrgCode, string VisitNumber)
        {

            long returnCode = -1;
            IHttpActionResult actionResult = null;
            ResPatientDetails lstPat = new ResPatientDetails();
            PatAddressDetails lstPatAdd = new PatAddressDetails();

            List<PatientDetail> lstPatDetail = new List<PatientDetail>();
            List<TestOrderSampleVisitDetails> lstPatOrderDetails = new List<TestOrderSampleVisitDetails>();
            List<TestOrderSampleVisitDetails> lstPatOrders = new List<TestOrderSampleVisitDetails>();
            OrderSampleStatus ObjOrder = new OrderSampleStatus();
            List<CorporatePatients> lstcorp = new List<CorporatePatients>();
            CorporatePatients objcorp = new CorporatePatients();
            ResPatientDetails objpat = new ResPatientDetails();
            List<PatAddressDetails> lstAdddress = new List<PatAddressDetails>();
            List<TestOrderSample> lstAllOrder = new List<TestOrderSample>();
            List<ResPatientVisitDetails> lstpatientvisitdetails = new List<ResPatientVisitDetails>();
            RePatientVisitDetails objvisit = new RePatientVisitDetails();
            try
            {
                returnCode = new LIMSAPI_BL().GetPatientResultDetailsVisitNo(OrgCode, VisitNumber, out lstPatDetail, out lstPatOrders, out lstPatOrderDetails, out lstpatientvisitdetails);

                if (returnCode != -1)
                {
                    if (lstPatDetail.Count > 0 && lstPatDetail != null)
                    {
                        objpat.PatientID = lstPatDetail[0].PatientID;
                        objpat.PatientNumber = lstPatDetail[0].PatientNumber;
                        objpat.FirstName = lstPatDetail[0].FirstName;
                        objpat.MiddleName = lstPatDetail[0].MiddleName;
                        objpat.LastName = lstPatDetail[0].LastName;
                        objpat.MobileNumber = lstPatDetail[0].MobileNumber;
                        objpat.URNNumber = lstPatDetail[0].URNNumber;
                        objpat.URNType = lstPatDetail[0].URNType;
                        objpat.Gender = lstPatDetail[0].Gender;
                        objpat.Age = lstPatDetail[0].Age;
                        objpat.DOB = lstPatDetail[0].DOB;
                        objpat.EmailID = lstPatDetail[0].EmailID;
                        objpat.SalutationCode = lstPatDetail[0].SalutationCode;
                        lstPatAdd.Address = lstPatDetail[0].Address;
                        lstPatAdd.State = lstPatDetail[0].State;
                        lstPatAdd.City = lstPatDetail[0].City;
                        lstPatAdd.Country = lstPatDetail[0].Country;
                        lstPatAdd.AddressType = lstPatDetail[0].AddressType;
                        lstPatAdd.StateID = lstPatDetail[0].StateID;
                        lstPatAdd.CountryID = lstPatDetail[0].CountryID;
                        lstPatAdd.ExternalPatientNumber = lstPatDetail[0].ExternalPatientNumber;
                        lstAdddress.Add(lstPatAdd);
                        objpat.AddressDetails = lstAdddress;
                        ObjOrder.PatientInfo = objpat;
                        ObjOrder.OrderId = lstPatDetail[0].OrderID;
                        ObjOrder.OrgCode = OrgCode;
                        TimeZone = lstPatDetail[0].TimeZone;
                    }
                    if (lstpatientvisitdetails != null && lstpatientvisitdetails.Count > 0)
                    {
                        objvisit.ClientID = lstpatientvisitdetails[0].ClientID;
                        objvisit.PatientVisitId = lstpatientvisitdetails[0].PatientVisitId;
                        objvisit.ExternalVisitNumber = lstpatientvisitdetails[0].ExternalVisitNumber;
                        objvisit.VisitType = lstpatientvisitdetails[0].VisitType;
                        objvisit.VisitDate = GetTimeZoneTime(lstpatientvisitdetails[0].VisitDate);
                        objvisit.VATRegisterationNo = lstpatientvisitdetails[0].VATRegisterationNo;
                        objvisit.ClientCode = lstpatientvisitdetails[0].ClientCode;
                        objvisit.ClientName = lstpatientvisitdetails[0].ClientName;
                        objvisit.VisitHistory = lstpatientvisitdetails[0].VisitHistory;
                        objvisit.VisitRemarks = lstpatientvisitdetails[0].VisitRemarks;
                        objvisit.ReferingDoctorCode = lstpatientvisitdetails[0].ReferingDoctorCode;
                        objvisit.ReferingDoctorMobileNumber = lstpatientvisitdetails[0].ReferingDoctorMobileNumber;
                        objvisit.ReferingDoctorName = lstpatientvisitdetails[0].ReferingDoctorName;
                        objvisit.HospitalName = lstpatientvisitdetails[0].HospitalName;
                        objvisit.HospitalNameCode = lstpatientvisitdetails[0].HospitalNameCode;
                        objvisit.RegisterLocation = lstpatientvisitdetails[0].RegisterLocation;
                        objvisit.IsNotification = lstpatientvisitdetails[0].IsNotification;
                        objvisit.CompanyID = lstpatientvisitdetails[0].CompanyID;
                        ObjOrder.PatientVisitInfo = objvisit;
                        if (lstpatientvisitdetails[0].BookedDate != null && lstpatientvisitdetails[0].BookedDate.ToString("yyyy-MM-dd") != "0001-01-01")
                        {
                            objcorp.BookedDate = GetTimeZoneTime(lstpatientvisitdetails[0].BookedDate);
                            objcorp.CheckinDate = GetTimeZoneTime(lstpatientvisitdetails[0].CheckinDate);
                            objcorp.CheckOutDate = GetTimeZoneTime(lstpatientvisitdetails[0].CheckOutDate);
                            objcorp.Status = lstpatientvisitdetails[0].Status;
                            ObjOrder.CorporatePatient = objcorp;
                        }
                    }
                    if (lstPatOrders != null && lstPatOrders.Count > 0)
                    {
                        ObjOrder.OverAllStatus = lstPatOrders[0].OverAllStatus;


                        foreach (TestOrderSampleVisitDetails s in lstPatOrders)
                        {

                            if (s.TestType == "INV")
                            {
                                TestOrderSample objtest = new TestOrderSample();
                                objtest.PatientVisitID = s.PatientVisitID;
                                objtest.ExternalVisitID = s.ExternalVisitID;
                                objtest.TestID = s.TestID;
                                objtest.TestCode = s.TestCode;
                                objtest.OrderedDate = GetTimeZoneTime(s.OrderedDate);
                                objtest.TestType = s.TestType;
                                objtest.TestName = s.TestName;
                                objtest.TestValueType = s.TestValueType;
                                objtest.TestValue = s.TestValue;
                                objtest.UOMCode = s.UOMCode;
                                objtest.MethodName = s.MethodName;
                                objtest.ReferenceRange = s.ReferenceRange.Contains("<?xml") ? ParseXML(s.ReferenceRange) : s.ReferenceRange;
                                objtest.IsAbnormal = s.IsAbnormal;
                                objtest.ResultCapturedAt = GetTimeZoneTime(s.ResultCapturedAt);
                                objtest.TestStatus = s.TestStatus;
                                objtest.MedicalRemarks = s.MedicalRemarks;
                                objtest.InterpretationNotes = s.InterpretationNotes;
                                objtest.ProcessingType = s.ProcessingType;
                                objtest.ProcessingLocation = s.ProcessingLocation;
                                objtest.SampleCollectionDateTime = GetTimeZoneTime(s.SampleCollectionDateTime);
                                objtest.DeviceID = s.DeviceID;
                                objtest.LotNumber = s.LotNumber;
                                objtest.CreatedAt = GetTimeZoneTime(s.CreatedAt);
                                objtest.UpdatedAt = GetTimeZoneTime(s.UpdatedAt);
                                objtest.DepartmentName = s.DepartmentName;
                                objtest.DeltaValue = s.DeltaValue;
                                objtest.UserID = s.UserID;
                                objtest.UserName = s.UserName;
                                objtest.SampleName = s.SampleName;
                                objtest.ConversionRange = s.ConversionRange.Contains("<?xml") ? ParseXML(s.ConversionRange) : s.ConversionRange;
                                objtest.ConversionValue = s.ConversionValue;
                                objtest.ConversionUnit = s.ConversionUnit;
                                objtest.Nonreportable = s.Nonreportable;
                                lstAllOrder.Add(objtest);
                            }

                            if (s.TestType == "GRP")
                            {
                                foreach (TestOrderSampleVisitDetails inv in lstPatOrderDetails)
                                {
                                    if (s.TestID == inv.GroupID)
                                    {
                                        TestOrderSample objgrp = new TestOrderSample();
                                        TestOrderSampleContentVisit objpkgcnt = new TestOrderSampleContentVisit();
                                        TestOrderSampleVisit objpkgparam = new TestOrderSampleVisit();
                                        objgrp.PatientVisitID = inv.PatientVisitID;
                                        objgrp.ExternalVisitID = inv.ExternalVisitID;
                                        objgrp.TestID = s.TestID;
                                        objgrp.TestCode = s.TestCode;
                                        objgrp.OrderedDate = GetTimeZoneTime(s.OrderedDate);
                                        objgrp.TestType = s.TestType;
                                        objgrp.TestName = s.TestName;
                                        objgrp.TestValueType = s.TestValueType;
                                        objgrp.TestValue = s.TestValue;
                                        objgrp.UOMCode = s.UOMCode;
                                        objgrp.MethodName = s.MethodName;
                                        objgrp.ReferenceRange = s.ReferenceRange.Contains("<?xml") ? ParseXML(s.ReferenceRange) : s.ReferenceRange;
                                        objgrp.IsAbnormal = s.IsAbnormal;
                                        objgrp.ResultCapturedAt = GetTimeZoneTime(s.ResultCapturedAt);
                                        objgrp.TestStatus = s.TestStatus;
                                        objgrp.MedicalRemarks = s.MedicalRemarks;
                                        objgrp.InterpretationNotes = s.InterpretationNotes;
                                        objgrp.ProcessingType = s.ProcessingType;
                                        objgrp.ProcessingLocation = s.ProcessingLocation;
                                        objgrp.SampleCollectionDateTime = GetTimeZoneTime(s.SampleCollectionDateTime);
                                        objgrp.DeviceID = s.DeviceID;
                                        objgrp.LotNumber = s.LotNumber;
                                        objgrp.CreatedAt = GetTimeZoneTime(s.CreatedAt);
                                        objgrp.UpdatedAt = GetTimeZoneTime(s.UpdatedAt);
                                        objgrp.DepartmentName = s.DepartmentName;
                                        objgrp.DeltaValue = s.DeltaValue;
                                        objgrp.UserID = s.UserID;
                                        objgrp.UserName = s.UserName;
                                        objgrp.SampleName = s.SampleName;
                                        objgrp.ConversionRange = s.ConversionRange.Contains("<?xml") ? ParseXML(s.ConversionRange) : s.ConversionRange;
                                        objgrp.ConversionValue = s.ConversionValue;
                                        objgrp.ConversionUnit = s.ConversionUnit;
                                        objgrp.Nonreportable = s.Nonreportable;
                                        List<TestOrderSampleContentVisit> lstpkg = new List<TestOrderSampleContentVisit>();
                                        var Contentpkg = lstPatOrderDetails.FindAll(p => p.GroupID == inv.GroupID && p.SubGroupID == "0");
                                        //  var Contentpkgparam = lstPatOrderDetails.FindAll(p => p.GroupID == inv.GroupID);
                                        var Contentpkgparam = lstPatOrderDetails.Where(t => t.SubGroupID != "0" && t.GroupID != "0" && t.GroupID == inv.GroupID).GroupBy(test => test.SubGroupID).Select(grp => grp.First()).ToList();
                                        var Contentpkgparam1 = lstPatOrderDetails.FindAll(p => p.GroupID == inv.GroupID);
                                        List<TestOrderSampleContentVisit> lstpkgcont = new List<TestOrderSampleContentVisit>();
                                        foreach (TestOrderSampleVisitDetails tall in Contentpkg)
                                        {
                                            TestOrderSampleContentVisit objcont = new TestOrderSampleContentVisit();
                                            objcont.TestCode = tall.TestCode;
                                            objcont.OrderedDate = GetTimeZoneTime(tall.OrderedDate);
                                            objcont.TestType = tall.TestType;
                                            objcont.TestID = tall.TestID;
                                            objcont.TestName = tall.TestName;
                                            objcont.TestValueType = tall.TestValueType;
                                            objcont.TestValue = tall.TestValue;
                                            objcont.UOMCode = tall.UOMCode;
                                            objcont.MethodName = tall.MethodName;
                                            objcont.ReferenceRange = tall.ReferenceRange.Contains("<?xml") ? ParseXML(tall.ReferenceRange) : tall.ReferenceRange;
                                            objcont.IsAbnormal = tall.IsAbnormal;
                                            objcont.ResultCapturedAt = GetTimeZoneTime(tall.ResultCapturedAt);
                                            objcont.TestStatus = tall.TestStatus;
                                            objcont.MedicalRemarks = tall.MedicalRemarks;
                                            objcont.InterpretationNotes = tall.InterpretationNotes;
                                            objcont.ProcessingType = tall.ProcessingType;
                                            objcont.ProcessingLocation = tall.ProcessingLocation;
                                            objcont.SampleCollectionDateTime = GetTimeZoneTime(tall.SampleCollectionDateTime);
                                            objcont.DeviceID = tall.DeviceID;
                                            objcont.LotNumber = tall.LotNumber;
                                            objcont.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                            objcont.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                            objcont.DepartmentName = tall.DepartmentName;
                                            objcont.DeltaValue = tall.DeltaValue;
                                            objcont.UserID = tall.UserID;
                                            objcont.UserName = tall.UserName;
                                            objcont.SampleName = tall.SampleName;
                                            objcont.ConversionRange = tall.ConversionRange.Contains("<?xml") ? ParseXML(tall.ConversionRange) : tall.ConversionRange;
                                            objcont.ConversionValue = tall.ConversionValue;
                                            objcont.ConversionUnit = tall.ConversionUnit;
                                            objcont.Nonreportable = tall.Nonreportable;
                                            lstpkgcont.Add(objcont);

                                        }
                                        foreach (TestOrderSampleVisitDetails tall in Contentpkgparam)
                                        {
                                            TestOrderSampleContentVisit objcont1 = new TestOrderSampleContentVisit();
                                            objcont1.TestCode = tall.SubGroupCode;
                                            objcont1.OrderedDate = GetTimeZoneTime(tall.OrderedDate);
                                            objcont1.TestType = "GRP";
                                            objcont1.TestID = tall.SubGroupID;
                                            objcont1.TestName = tall.SubGroupName;
                                            objcont1.TestValueType = tall.TestValueType;
                                            objcont1.TestValue = "";
                                            objcont1.UOMCode = tall.UOMCode;
                                            objcont1.MethodName = tall.MethodName;
                                            objcont1.ReferenceRange = tall.ReferenceRange.Contains("<?xml") ? ParseXML(tall.ReferenceRange) : tall.ReferenceRange;
                                            objcont1.IsAbnormal = tall.IsAbnormal;
                                            objcont1.ResultCapturedAt = GetTimeZoneTime(tall.ResultCapturedAt);
                                            objcont1.TestStatus = tall.TestStatus;
                                            objcont1.MedicalRemarks = tall.MedicalRemarks;
                                            objcont1.InterpretationNotes = tall.InterpretationNotes;
                                            objcont1.ProcessingType = tall.ProcessingType;
                                            objcont1.ProcessingLocation = tall.ProcessingLocation;
                                            objcont1.SampleCollectionDateTime = GetTimeZoneTime(tall.SampleCollectionDateTime);
                                            objcont1.DeviceID = tall.DeviceID;
                                            objcont1.LotNumber = tall.LotNumber;
                                            objcont1.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                            objcont1.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                            objcont1.DepartmentName = tall.DepartmentName;
                                            objcont1.DeltaValue = "";
                                            objcont1.UserID = tall.UserID;
                                            objcont1.UserName = tall.UserName;
                                            objcont1.SampleName = tall.SampleName;
                                            objcont1.ConversionRange = tall.ConversionRange.Contains("<?xml") ? ParseXML(tall.ConversionRange) : tall.ConversionRange;
                                            objcont1.ConversionValue = tall.ConversionValue;
                                            objcont1.ConversionUnit = tall.ConversionUnit;
                                            objcont1.Nonreportable = tall.Nonreportable;
                                            List<TestOrderSampleVisit> lstpkgcontpar = new List<TestOrderSampleVisit>();
                                            foreach (TestOrderSampleVisitDetails objp in Contentpkgparam1)
                                            {
                                                TestOrderSampleVisit objcontpar = new TestOrderSampleVisit();
                                                if (tall.SubGroupID == objp.SubGroupID)// && objp.SubGroupID == "0")
                                                {
                                                    objcontpar.TestCode = objp.TestCode;
                                                    objcontpar.OrderedDate = GetTimeZoneTime(objp.OrderedDate);
                                                    objcontpar.TestType = objp.TestType;
                                                    objcontpar.TestID = objp.TestID;
                                                    objcontpar.TestName = objp.TestName;
                                                    objcontpar.TestValueType = objp.TestValueType;
                                                    objcontpar.TestValue = objp.TestValue;
                                                    objcontpar.UOMCode = objp.UOMCode;
                                                    objcontpar.MethodName = objp.MethodName;
                                                    objcontpar.ReferenceRange = objp.ReferenceRange.Contains("<?xml") ? ParseXML(objp.ReferenceRange) : objp.ReferenceRange;
                                                    objcontpar.IsAbnormal = objp.IsAbnormal;
                                                    objcontpar.ResultCapturedAt = GetTimeZoneTime(objp.ResultCapturedAt);
                                                    objcontpar.TestStatus = objp.TestStatus;
                                                    objcontpar.MedicalRemarks = objp.MedicalRemarks;
                                                    objcontpar.InterpretationNotes = objp.InterpretationNotes;
                                                    objcontpar.ProcessingType = objp.ProcessingType;
                                                    objcontpar.ProcessingLocation = objp.ProcessingLocation;
                                                    objcontpar.SampleCollectionDateTime = GetTimeZoneTime(objp.SampleCollectionDateTime);
                                                    objcontpar.DeviceID = objp.DeviceID;
                                                    objcontpar.LotNumber = objp.LotNumber;
                                                    objcontpar.CreatedAt = GetTimeZoneTime(objp.CreatedAt);
                                                    objcontpar.UpdatedAt = GetTimeZoneTime(objp.UpdatedAt);
                                                    objcontpar.DepartmentName = tall.DepartmentName;
                                                    objcontpar.DeltaValue = objp.DeltaValue;
                                                    objcontpar.UserID = tall.UserID;
                                                    objcontpar.UserName = tall.UserName;
                                                    objcontpar.SampleName = tall.SampleName;
                                                    objcontpar.ConversionRange = tall.ConversionRange.Contains("<?xml") ? ParseXML(tall.ConversionRange) : tall.ConversionRange;
                                                    objcontpar.ConversionValue = tall.ConversionValue;
                                                    objcontpar.ConversionUnit = tall.ConversionUnit;
                                                    objcontpar.Nonreportable = tall.Nonreportable;
                                                    lstpkgcontpar.Add(objcontpar);
                                                }
                                            }

                                            objcont1.ParameterListInfo = lstpkgcontpar;
                                            lstpkgcont.Add(objcont1);
                                        }
                                        objgrp.OrderContentListInfo = lstpkgcont;
                                        if (!lstAllOrder.Exists(p => p.TestID == objgrp.TestID && p.TestType == objgrp.TestType))
                                            lstAllOrder.Add(objgrp);
                                    }
                                }
                            }
                            if (s.TestType == "PKG")// && s.TestID == inv.PKGID)
                            {
                                foreach (TestOrderSampleVisitDetails inv in lstPatOrderDetails)
                                {
                                    if (s.TestID == inv.PKGID)
                                    {
                                        TestOrderSample objpkg = new TestOrderSample();
                                        TestOrderSampleContentVisit objpkgcnt = new TestOrderSampleContentVisit();
                                        TestOrderSampleVisit objpkgparam = new TestOrderSampleVisit();
                                        objpkg.PatientVisitID = inv.PatientVisitID;
                                        objpkg.ExternalVisitID = inv.ExternalVisitID;
                                        objpkg.TestID = s.TestID;
                                        objpkg.TestCode = s.TestCode;
                                        objpkg.OrderedDate = GetTimeZoneTime(s.OrderedDate);
                                        objpkg.TestType = s.TestType;
                                        objpkg.TestName = s.TestName;
                                        objpkg.TestValueType = s.TestValueType;
                                        objpkg.TestValue = s.TestValue;
                                        objpkg.UOMCode = s.UOMCode;
                                        objpkg.MethodName = s.MethodName;
                                        objpkg.ReferenceRange = s.ReferenceRange.Contains("<?xml") ? ParseXML(s.ReferenceRange) : s.ReferenceRange;
                                        objpkg.IsAbnormal = s.IsAbnormal;
                                        objpkg.ResultCapturedAt = GetTimeZoneTime(s.ResultCapturedAt);
                                        objpkg.TestStatus = s.TestStatus;
                                        objpkg.MedicalRemarks = s.MedicalRemarks;
                                        objpkg.InterpretationNotes = s.InterpretationNotes;
                                        objpkg.ProcessingType = s.ProcessingType;
                                        objpkg.ProcessingLocation = s.ProcessingLocation;
                                        objpkg.SampleCollectionDateTime = GetTimeZoneTime(s.SampleCollectionDateTime);
                                        objpkg.DeviceID = s.DeviceID;
                                        objpkg.LotNumber = s.LotNumber;
                                        objpkg.CreatedAt = GetTimeZoneTime(s.CreatedAt);
                                        objpkg.UpdatedAt = GetTimeZoneTime(s.UpdatedAt);
                                        objpkg.DepartmentName = s.DepartmentName;
                                        objpkg.DeltaValue = s.DeltaValue;
                                        objpkg.UserID = s.UserID;
                                        objpkg.UserName = s.UserName;
                                        objpkg.SampleName = s.SampleName;
                                        objpkg.ConversionRange = s.ConversionRange.Contains("<?xml") ? ParseXML(s.ConversionRange) : s.ConversionRange;
                                        objpkg.ConversionValue = s.ConversionValue;
                                        objpkg.ConversionUnit = s.ConversionUnit;
                                        objpkg.Nonreportable = s.Nonreportable;
                                        List<TestOrderSampleContentVisit> lstpkg = new List<TestOrderSampleContentVisit>();
                                        var Contentpkg = lstPatOrderDetails.FindAll(p => p.PKGID == inv.PKGID && p.GroupID == "0");
                                        //  var Contentpkgparam = lstPatOrderDetails.FindAll(p => p.GroupID == inv.GroupID);
                                        var Contentpkgparam = lstPatOrderDetails.GroupBy(test => test.GroupID)
                                                     .Select(grp => grp.First())
                                                     .Where(t => t.GroupID != "0" && t.PKGID != "0" && t.PKGID == inv.PKGID)
                                                       .ToList();
                                        var Contentpkgparam1 = lstPatOrderDetails.FindAll(p => p.PKGID == inv.PKGID);
                                        List<TestOrderSampleContentVisit> lstpkgcont = new List<TestOrderSampleContentVisit>();

                                        foreach (TestOrderSampleVisitDetails tall in Contentpkg)
                                        {
                                            TestOrderSampleContentVisit objcont = new TestOrderSampleContentVisit();
                                            objcont.TestCode = tall.TestCode;
                                            objcont.OrderedDate = GetTimeZoneTime(tall.OrderedDate);
                                            objcont.TestType = tall.TestType;
                                            objcont.TestID = tall.TestID;
                                            objcont.TestName = tall.TestName;
                                            objcont.TestValueType = tall.TestValueType;
                                            objcont.TestValue = tall.TestValue;
                                            objcont.UOMCode = tall.UOMCode;
                                            objcont.MethodName = tall.MethodName;
                                            objcont.ReferenceRange = tall.ReferenceRange.Contains("<?xml") ? ParseXML(tall.ReferenceRange) : tall.ReferenceRange;
                                            objcont.IsAbnormal = tall.IsAbnormal;
                                            objcont.ResultCapturedAt = GetTimeZoneTime(tall.ResultCapturedAt);
                                            objcont.TestStatus = tall.TestStatus;
                                            objcont.MedicalRemarks = tall.MedicalRemarks;
                                            objcont.InterpretationNotes = tall.InterpretationNotes;
                                            objcont.ProcessingType = tall.ProcessingType;
                                            objcont.ProcessingLocation = tall.ProcessingLocation;
                                            objcont.SampleCollectionDateTime = GetTimeZoneTime(tall.SampleCollectionDateTime);
                                            objcont.DeviceID = tall.DeviceID;
                                            objcont.LotNumber = tall.LotNumber;
                                            objcont.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                            objcont.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                            objcont.DepartmentName = tall.DepartmentName;
                                            objcont.DeltaValue = tall.DeltaValue;
                                            objcont.UserID = tall.UserID;
                                            objcont.UserName = tall.UserName;
                                            objcont.SampleName = tall.SampleName;
                                            objcont.ConversionRange = tall.ConversionRange.Contains("<?xml") ? ParseXML(tall.ConversionRange) : tall.ConversionRange;
                                            objcont.ConversionValue = tall.ConversionValue;
                                            objcont.ConversionUnit = tall.ConversionUnit;
                                            objcont.Nonreportable = tall.Nonreportable;
                                            lstpkgcont.Add(objcont);

                                        }

                                        foreach (TestOrderSampleVisitDetails tall in Contentpkgparam)
                                        {
                                            TestOrderSampleContentVisit objcont1 = new TestOrderSampleContentVisit();
                                            objcont1.TestCode = tall.GroupCode;
                                            objcont1.OrderedDate = GetTimeZoneTime(tall.OrderedDate);
                                            objcont1.TestType = "GRP";
                                            objcont1.TestID = tall.GroupID;
                                            objcont1.TestName = tall.GroupName;
                                            objcont1.TestValueType = tall.TestValueType;
                                            objcont1.TestValue = "";
                                            objcont1.UOMCode = tall.UOMCode;
                                            objcont1.MethodName = tall.MethodName;
                                            objcont1.ReferenceRange = tall.ReferenceRange.Contains("<?xml") ? ParseXML(tall.ReferenceRange) : tall.ReferenceRange;
                                            objcont1.IsAbnormal = tall.IsAbnormal;
                                            objcont1.ResultCapturedAt = GetTimeZoneTime(tall.ResultCapturedAt);
                                            objcont1.TestStatus = tall.TestStatus;
                                            objcont1.MedicalRemarks = tall.MedicalRemarks;
                                            objcont1.InterpretationNotes = tall.InterpretationNotes;
                                            objcont1.ProcessingType = tall.ProcessingType;
                                            objcont1.ProcessingLocation = tall.ProcessingLocation;
                                            objcont1.SampleCollectionDateTime = GetTimeZoneTime(tall.SampleCollectionDateTime);
                                            objcont1.DeviceID = tall.DeviceID;
                                            objcont1.LotNumber = tall.LotNumber;
                                            objcont1.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                            objcont1.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                            objcont1.DepartmentName = tall.DepartmentName;
                                            objcont1.DeltaValue = "";
                                            objcont1.UserID = tall.UserID;
                                            objcont1.UserName = tall.UserName;
                                            objcont1.SampleName = tall.SampleName;
                                            objcont1.ConversionRange = tall.ConversionRange.Contains("<?xml") ? ParseXML(tall.ConversionRange) : tall.ConversionRange;
                                            objcont1.ConversionValue = tall.ConversionValue;
                                            objcont1.ConversionUnit = tall.ConversionUnit;
                                            objcont1.Nonreportable = tall.Nonreportable;
                                            List<TestOrderSampleVisit> lstpkgcontpar = new List<TestOrderSampleVisit>();
                                            foreach (TestOrderSampleVisitDetails objp in Contentpkgparam1)
                                            {
                                                TestOrderSampleVisit objcontpar = new TestOrderSampleVisit();
                                                if (tall.GroupID == objp.GroupID)// && objp.SubGroupID == "0")
                                                {
                                                    objcontpar.TestCode = objp.TestCode;
                                                    objcontpar.OrderedDate = GetTimeZoneTime(objp.OrderedDate);
                                                    objcontpar.TestType = objp.TestType;
                                                    objcontpar.TestID = objp.TestID;
                                                    objcontpar.TestName = objp.TestName;
                                                    objcontpar.TestValueType = objp.TestValueType;
                                                    objcontpar.TestValue = objp.TestValue;
                                                    objcontpar.UOMCode = objp.UOMCode;
                                                    objcontpar.MethodName = objp.MethodName;
                                                    objcontpar.ReferenceRange = objp.ReferenceRange.Contains("<?xml") ? ParseXML(objp.ReferenceRange) : objp.ReferenceRange;
                                                    objcontpar.IsAbnormal = objp.IsAbnormal;
                                                    objcontpar.ResultCapturedAt = GetTimeZoneTime(objp.ResultCapturedAt);
                                                    objcontpar.TestStatus = objp.TestStatus;
                                                    objcontpar.MedicalRemarks = objp.MedicalRemarks;
                                                    objcontpar.InterpretationNotes = objp.InterpretationNotes;
                                                    objcontpar.ProcessingType = objp.ProcessingType;
                                                    objcontpar.ProcessingLocation = objp.ProcessingLocation;
                                                    objcontpar.SampleCollectionDateTime = GetTimeZoneTime(objp.SampleCollectionDateTime);
                                                    objcontpar.DeviceID = objp.DeviceID;
                                                    objcontpar.LotNumber = objp.LotNumber;
                                                    objcontpar.CreatedAt = GetTimeZoneTime(objp.CreatedAt);
                                                    objcontpar.UpdatedAt = GetTimeZoneTime(objp.UpdatedAt);
                                                    objcontpar.DepartmentName = tall.DepartmentName;
                                                    objcontpar.DeltaValue = objp.DeltaValue;
                                                    objcontpar.UserID = objp.UserID;
                                                    objcontpar.UserName = objp.UserName;
                                                    objcontpar.SampleName = objp.SampleName;
                                                    objcontpar.ConversionRange = objp.ConversionRange.Contains("<?xml") ? ParseXML(objp.ConversionRange) : objp.ConversionRange;
                                                    objcontpar.ConversionValue = objp.ConversionValue;
                                                    objcontpar.ConversionUnit = objp.ConversionUnit;
                                                    objcontpar.Nonreportable = objp.Nonreportable;
                                                    lstpkgcontpar.Add(objcontpar);
                                                }
                                            }

                                            objcont1.ParameterListInfo = lstpkgcontpar;
                                            lstpkgcont.Add(objcont1);
                                        }
                                        objpkg.OrderContentListInfo = lstpkgcont;
                                        if (!lstAllOrder.Exists(p => p.TestID == objpkg.TestID && p.TestType == objpkg.TestType))
                                            lstAllOrder.Add(objpkg);
                                    }
                                }
                            }
                        }
                        int ordercount = 0;
                        if (lstAllOrder.Count > 0)
                        {
                            ordercount = lstAllOrder.Count;
                        }


                        //List<PatientResultPDF> lstresultPDF = new List<PatientResultPDF>();
                        //string PathwithfileName = string.Empty;
                        //string pVisitNumber = lstPatDetail[0].OrderID;

                        //byte[] filepathByte = null;
                        //byte[] OutfilepathByte = null;

                        //returnCode = new LIMSAPI_BL().GetPatientPDFfile(OrgCode, 0, pVisitNumber, out lstresultPDF);
                        //if (returnCode != -1)
                        //{
                        //    if (lstresultPDF.Count > 0 && lstresultPDF != null)
                        //    {
                        //        string folderroot = lstresultPDF[0].FileFolder + lstresultPDF[0].FilePath;
                        //        string Newroot = string.Empty;
                        //        string root = string.Empty;

                        //        var myList = new List<string>();
                        //        int cnt = 0;
                        //        string outsource = string.Empty;
                        //        if (!System.IO.Directory.Exists(folderroot))
                        //        {
                        //            System.IO.Directory.CreateDirectory(folderroot);
                        //        }
                        //        foreach (PatientResultPDF objpdf in lstresultPDF)
                        //        {
                        //            if (objpdf.FileType.ToLower() == "outsource")
                        //            {
                        //                outsource = "Y";
                        //            }
                        //            if (objpdf.FileType.ToLower() == "pdf")
                        //            {
                        //                var fileName = Path.GetFileName(objpdf.FilePathName);
                        //                PathwithfileName = objpdf.FilePathName;//.Replace("/", ""); 
                        //                root = objpdf.FileFolder + objpdf.FilePath.Replace('/', '\\') + objpdf.FileName;
                        //                Newroot = objpdf.FileFolder + objpdf.FilePath.Replace("REPORT", "OUTSOURCEREPORT");
                        //                if (File.Exists(PathwithfileName))
                        //                {
                        //                    filepathByte = File.ReadAllBytes(PathwithfileName);
                        //                }

                        //            }
                        //            myList.Add(objpdf.FilePathName);
                        //        }
                        //        if (outsource == "Y")
                        //        {


                        //            var myArray = myList.ToArray();
                        //            byte[] bytes = concatAndAddContent(myArray);
                        //            string OrginalFileName = Newroot + Path.GetFileName(root);
                        //            string TempFileName = Newroot + Path.GetFileName(root);
                        //            TempFileName = TempFileName.Replace(".pdf", "temp.pdf");
                        //            bool _FileUse = false;
                        //            int ThreadCount = 1000;
                        //            if (!System.IO.Directory.Exists(Newroot))
                        //            {
                        //                System.IO.Directory.CreateDirectory(Newroot);
                        //            }

                        //            while (!_FileUse)
                        //            {
                        //                try
                        //                {
                        //                    using (FileStream fsNew = new FileStream(TempFileName, FileMode.Create, FileAccess.Write))
                        //                    {
                        //                        byte[] finalresult = new byte[byte.MaxValue];
                        //                        fsNew.Write(bytes, 0, bytes.Length);
                        //                        fsNew.Close();
                        //                    }
                        //                    AddPageNumber(TempFileName, OrginalFileName);
                        //                    Thread.Sleep(1000);
                        //                    _FileUse = true;
                        //                }
                        //                catch (Exception ex)
                        //                {
                        //                    Thread.Sleep(1000);
                        //                    _FileUse = false;
                        //                    if (ThreadCount == 30000)
                        //                    {
                        //                        _FileUse = true;
                        //                    }

                        //                }
                        //            }
                        //            var root1 = OrginalFileName;
                        //            if (File.Exists(root1))
                        //            {
                        //                OutfilepathByte = File.ReadAllBytes(root1);
                        //            }
                        //        }
                        //    }
                     //   }


                        //lstAllOrder[ordercount - 1].ResultAsPdf = filepathByte;
                     //   ObjOrder.ResultAsPdf = filepathByte;
                    //    ObjOrder.OutsourceAsPdf = OutfilepathByte;
                        ObjOrder.OrderInfo = lstAllOrder;
                    }
                    actionResult = Ok(ObjOrder);
                }
                else
                {
                    actionResult = Ok("While fetching the data getting an Error.");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured" + ex.ToString());
            }

            return actionResult;
        }
        [ResponseType(typeof(OrderResult))]
        [HttpGet]
        [Route("Api/Orders/GetPatientSampleOrderDetails")]

        public IHttpActionResult GetPatientSampleOrderDetails(string OrgCode)
        {

            long returnCode = -1;
            IHttpActionResult actionResult = null;
            ResPatientDetails lstPat = new ResPatientDetails();
            PatAddressDetails lstPatAdd = new PatAddressDetails();

            List<PatientDetail> lstPatDetail = new List<PatientDetail>();
            List<TestOrderSampleVisitDetails> lstPatOrderDetails = new List<TestOrderSampleVisitDetails>();
            List<TestOrderSampleVisitDetails> lstPatOrders = new List<TestOrderSampleVisitDetails>();
            OrderSampleStatus ObjOrder = new OrderSampleStatus();
            List<CorporatePatients> lstcorp = new List<CorporatePatients>();
            CorporatePatients objcorp = new CorporatePatients();
            ResPatientDetails objpat = new ResPatientDetails();
            List<PatAddressDetails> lstAdddress = new List<PatAddressDetails>();
            List<TestOrderSample> lstAllOrder = new List<TestOrderSample>();
            List<ResPatientVisitDetails> lstpatientvisitdetails = new List<ResPatientVisitDetails>();
            RePatientVisitDetails objvisit = new RePatientVisitDetails();
            string VisitNumber = string.Empty;
            try
            {
                returnCode = new LIMSAPI_BL().GetPatientSampleOrderDetails(OrgCode, out lstPatDetail, out lstPatOrders, out lstPatOrderDetails, out lstpatientvisitdetails, out VisitNumber);

                if (returnCode != -1)
                {
                    if (lstPatDetail.Count > 0 && lstPatDetail != null)
                    {
                        objpat.PatientID = lstPatDetail[0].PatientID;
                        objpat.PatientNumber = lstPatDetail[0].PatientNumber;
                        objpat.FirstName = lstPatDetail[0].FirstName;
                        objpat.MiddleName = lstPatDetail[0].MiddleName;
                        objpat.LastName = lstPatDetail[0].LastName;
                        objpat.MobileNumber = lstPatDetail[0].MobileNumber;
                        objpat.URNNumber = lstPatDetail[0].URNNumber;
                        objpat.URNType = lstPatDetail[0].URNType;
                        objpat.Gender = lstPatDetail[0].Gender;
                        objpat.Age = lstPatDetail[0].Age;
                        objpat.DOB = lstPatDetail[0].DOB;
                        objpat.EmailID = lstPatDetail[0].EmailID;
                        objpat.SalutationCode = lstPatDetail[0].SalutationCode;
                        lstPatAdd.Address = lstPatDetail[0].Address;
                        lstPatAdd.State = lstPatDetail[0].State;
                        lstPatAdd.City = lstPatDetail[0].City;
                        lstPatAdd.Country = lstPatDetail[0].Country;
                        lstPatAdd.AddressType = lstPatDetail[0].AddressType;
                        lstPatAdd.StateID = lstPatDetail[0].StateID;
                        lstPatAdd.CountryID = lstPatDetail[0].CountryID;
                        lstPatAdd.ExternalPatientNumber = lstPatDetail[0].ExternalPatientNumber;
                        lstAdddress.Add(lstPatAdd);
                        objpat.AddressDetails = lstAdddress;
                        ObjOrder.PatientInfo = objpat;
                        ObjOrder.OrderId = lstPatDetail[0].OrderID;
                        ObjOrder.OrgCode = OrgCode;
                        TimeZone = lstPatDetail[0].TimeZone;
                    }
                    if (lstpatientvisitdetails != null && lstpatientvisitdetails.Count > 0)
                    {
                        objvisit.ClientID = lstpatientvisitdetails[0].ClientID;
                        objvisit.PatientVisitId = lstpatientvisitdetails[0].PatientVisitId;
                        objvisit.ExternalVisitNumber = lstpatientvisitdetails[0].ExternalVisitNumber;
                        objvisit.VisitType = lstpatientvisitdetails[0].VisitType;
                        objvisit.VisitDate = GetTimeZoneTime(lstpatientvisitdetails[0].VisitDate);
                        objvisit.VATRegisterationNo = lstpatientvisitdetails[0].VATRegisterationNo;
                        objvisit.ClientCode = lstpatientvisitdetails[0].ClientCode;
                        objvisit.ClientName = lstpatientvisitdetails[0].ClientName;
                        objvisit.VisitHistory = lstpatientvisitdetails[0].VisitHistory;
                        objvisit.VisitRemarks = lstpatientvisitdetails[0].VisitRemarks;
                        objvisit.ReferingDoctorCode = lstpatientvisitdetails[0].ReferingDoctorCode;
                        objvisit.ReferingDoctorMobileNumber = lstpatientvisitdetails[0].ReferingDoctorMobileNumber;
                        objvisit.ReferingDoctorName = lstpatientvisitdetails[0].ReferingDoctorName;
                        objvisit.HospitalName = lstpatientvisitdetails[0].HospitalName;
                        objvisit.HospitalNameCode = lstpatientvisitdetails[0].HospitalNameCode;
                        objvisit.RegisterLocation = lstpatientvisitdetails[0].RegisterLocation;
                        objvisit.IsNotification = lstpatientvisitdetails[0].IsNotification;
                        objvisit.CompanyID = lstpatientvisitdetails[0].CompanyID;
                        ObjOrder.PatientVisitInfo = objvisit;
                        if (lstpatientvisitdetails[0].BookedDate != null && lstpatientvisitdetails[0].BookedDate.ToString("yyyy-MM-dd") != "0001-01-01")
                        {
                            objcorp.BookedDate = GetTimeZoneTime(lstpatientvisitdetails[0].BookedDate);
                            objcorp.CheckinDate = GetTimeZoneTime(lstpatientvisitdetails[0].CheckinDate);
                            objcorp.CheckOutDate = GetTimeZoneTime(lstpatientvisitdetails[0].CheckOutDate);
                            objcorp.Status = lstpatientvisitdetails[0].Status;
                            ObjOrder.CorporatePatient = objcorp;
                        }
                    }
                    if (lstPatOrders != null && lstPatOrders.Count > 0)
                    {
                        ObjOrder.OverAllStatus = lstPatOrders[0].OverAllStatus;


                        foreach (TestOrderSampleVisitDetails s in lstPatOrders)
                        {

                            if (s.TestType == "INV")
                            {
                                TestOrderSample objtest = new TestOrderSample();
                                objtest.PatientVisitID = s.PatientVisitID;
                                objtest.ExternalVisitID = s.ExternalVisitID;
                                objtest.TestID = s.TestID;
                                objtest.TestCode = s.TestCode;
                                objtest.OrderedDate = GetTimeZoneTime(s.OrderedDate);
                                objtest.TestType = s.TestType;
                                objtest.TestName = s.TestName;
                                objtest.TestValueType = s.TestValueType;
                                objtest.TestValue = s.TestValue;
                                objtest.UOMCode = s.UOMCode;
                                objtest.MethodName = s.MethodName;
                                objtest.ReferenceRange = s.ReferenceRange.Contains("<?xml") ? ParseXML(s.ReferenceRange) : s.ReferenceRange;
                                objtest.IsAbnormal = s.IsAbnormal;
                                objtest.ResultCapturedAt = GetTimeZoneTime(s.ResultCapturedAt);
                                objtest.TestStatus = s.TestStatus;
                                objtest.MedicalRemarks = s.MedicalRemarks;
                                objtest.InterpretationNotes = s.InterpretationNotes;
                                objtest.ProcessingType = s.ProcessingType;
                                objtest.ProcessingLocation = s.ProcessingLocation;
                                objtest.SampleCollectionDateTime = GetTimeZoneTime(s.SampleCollectionDateTime);
                                objtest.DeviceID = s.DeviceID;
                                objtest.LotNumber = s.LotNumber;
                                objtest.CreatedAt = GetTimeZoneTime(s.CreatedAt);
                                objtest.UpdatedAt = GetTimeZoneTime(s.UpdatedAt);
                                objtest.DepartmentName = s.DepartmentName;
                                objtest.SampleName = s.SampleName;
                                objtest.Nonreportable = s.Nonreportable;
                                lstAllOrder.Add(objtest);
                            }

                            if (s.TestType == "GRP")
                            {
                                foreach (TestOrderSampleVisitDetails inv in lstPatOrderDetails)
                                {
                                    if (s.TestID == inv.GroupID)
                                    {
                                        TestOrderSample objgrp = new TestOrderSample();
                                        TestOrderSampleContentVisit objpkgcnt = new TestOrderSampleContentVisit();
                                        TestOrderSampleVisit objpkgparam = new TestOrderSampleVisit();
                                        objgrp.PatientVisitID = inv.PatientVisitID;
                                        objgrp.ExternalVisitID = inv.ExternalVisitID;
                                        objgrp.TestID = s.TestID;
                                        objgrp.TestCode = s.TestCode;
                                        objgrp.OrderedDate = GetTimeZoneTime(s.OrderedDate);
                                        objgrp.TestType = s.TestType;
                                        objgrp.TestName = s.TestName;
                                        objgrp.TestValueType = s.TestValueType;
                                        objgrp.TestValue = s.TestValue;
                                        objgrp.UOMCode = s.UOMCode;
                                        objgrp.MethodName = s.MethodName;
                                        objgrp.ReferenceRange = s.ReferenceRange.Contains("<?xml") ? ParseXML(s.ReferenceRange) : s.ReferenceRange;
                                        objgrp.IsAbnormal = s.IsAbnormal;
                                        objgrp.ResultCapturedAt = GetTimeZoneTime(s.ResultCapturedAt);
                                        objgrp.TestStatus = s.TestStatus;
                                        objgrp.MedicalRemarks = s.MedicalRemarks;
                                        objgrp.InterpretationNotes = s.InterpretationNotes;
                                        objgrp.ProcessingType = s.ProcessingType;
                                        objgrp.ProcessingLocation = s.ProcessingLocation;
                                        objgrp.SampleCollectionDateTime = GetTimeZoneTime(s.SampleCollectionDateTime);
                                        objgrp.DeviceID = s.DeviceID;
                                        objgrp.LotNumber = s.LotNumber;
                                        objgrp.CreatedAt = GetTimeZoneTime(s.CreatedAt);
                                        objgrp.UpdatedAt = GetTimeZoneTime(s.UpdatedAt);
                                        objgrp.DepartmentName = s.DepartmentName;
                                        objgrp.DeltaValue = s.DeltaValue;
                                        objgrp.UserID = s.UserID;
                                        objgrp.UserName = s.UserName;
                                        objgrp.SampleName = s.SampleName;
                                        objgrp.Nonreportable = s.Nonreportable;
                                        List<TestOrderSampleContentVisit> lstpkg = new List<TestOrderSampleContentVisit>();
                                        var Contentpkg = lstPatOrderDetails.FindAll(p => p.GroupID == inv.GroupID && p.SubGroupID == "0");
                                        //  var Contentpkgparam = lstPatOrderDetails.FindAll(p => p.GroupID == inv.GroupID);
                                        var Contentpkgparam = lstPatOrderDetails.Where(t => t.SubGroupID != "0" && t.GroupID != "0" && t.GroupID == inv.GroupID).GroupBy(test => test.SubGroupID).Select(grp => grp.First()).ToList();
                                        var Contentpkgparam1 = lstPatOrderDetails.FindAll(p => p.GroupID == inv.GroupID);
                                        List<TestOrderSampleContentVisit> lstpkgcont = new List<TestOrderSampleContentVisit>();
                                        foreach (TestOrderSampleVisitDetails tall in Contentpkg)
                                        {
                                            TestOrderSampleContentVisit objcont = new TestOrderSampleContentVisit();
                                            objcont.TestCode = tall.TestCode;
                                            objcont.OrderedDate = GetTimeZoneTime(tall.OrderedDate);
                                            objcont.TestType = tall.TestType;
                                            objcont.TestID = tall.TestID;
                                            objcont.TestName = tall.TestName;
                                            objcont.TestValueType = tall.TestValueType;
                                            objcont.TestValue = tall.TestValue;
                                            objcont.UOMCode = tall.UOMCode;
                                            objcont.MethodName = tall.MethodName;
                                            objcont.ReferenceRange = tall.ReferenceRange.Contains("<?xml") ? ParseXML(tall.ReferenceRange) : tall.ReferenceRange;
                                            objcont.IsAbnormal = tall.IsAbnormal;
                                            objcont.ResultCapturedAt = GetTimeZoneTime(tall.ResultCapturedAt);
                                            objcont.TestStatus = tall.TestStatus;
                                            objcont.MedicalRemarks = tall.MedicalRemarks;
                                            objcont.InterpretationNotes = tall.InterpretationNotes;
                                            objcont.ProcessingType = tall.ProcessingType;
                                            objcont.ProcessingLocation = tall.ProcessingLocation;
                                            objcont.SampleCollectionDateTime = GetTimeZoneTime(tall.SampleCollectionDateTime);
                                            objcont.DeviceID = tall.DeviceID;
                                            objcont.LotNumber = tall.LotNumber;
                                            objcont.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                            objcont.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                            objcont.DepartmentName = tall.DepartmentName;
                                            objcont.DeltaValue = tall.DeltaValue;
                                            objcont.UserID = tall.UserID;
                                            objcont.UserName = tall.UserName;
                                            objcont.SampleName = tall.SampleName;
                                            objcont.Nonreportable = tall.Nonreportable;
                                            lstpkgcont.Add(objcont);

                                        }
                                        foreach (TestOrderSampleVisitDetails tall in Contentpkgparam)
                                        {
                                            TestOrderSampleContentVisit objcont1 = new TestOrderSampleContentVisit();
                                            objcont1.TestCode = tall.SubGroupCode;
                                            objcont1.OrderedDate = GetTimeZoneTime(tall.OrderedDate);
                                            objcont1.TestType = "GRP";
                                            objcont1.TestID = tall.SubGroupID;
                                            objcont1.TestName = tall.SubGroupName;
                                            objcont1.TestValueType = tall.TestValueType;
                                            objcont1.TestValue = "";
                                            objcont1.UOMCode = tall.UOMCode;
                                            objcont1.MethodName = tall.MethodName;
                                            objcont1.ReferenceRange = tall.ReferenceRange.Contains("<?xml") ? ParseXML(tall.ReferenceRange) : tall.ReferenceRange;
                                            objcont1.IsAbnormal = tall.IsAbnormal;
                                            objcont1.ResultCapturedAt = GetTimeZoneTime(tall.ResultCapturedAt);
                                            objcont1.TestStatus = tall.TestStatus;
                                            objcont1.MedicalRemarks = tall.MedicalRemarks;
                                            objcont1.InterpretationNotes = tall.InterpretationNotes;
                                            objcont1.ProcessingType = tall.ProcessingType;
                                            objcont1.ProcessingLocation = tall.ProcessingLocation;
                                            objcont1.SampleCollectionDateTime = GetTimeZoneTime(tall.SampleCollectionDateTime);
                                            objcont1.DeviceID = tall.DeviceID;
                                            objcont1.LotNumber = tall.LotNumber;
                                            objcont1.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                            objcont1.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                            objcont1.DepartmentName = tall.DepartmentName;
                                            objcont1.DeltaValue = "";
                                            objcont1.UserID = tall.UserID;
                                            objcont1.UserName = tall.UserName;
                                            objcont1.SampleName = tall.SampleName;
                                            objcont1.Nonreportable = tall.Nonreportable;
                                            List<TestOrderSampleVisit> lstpkgcontpar = new List<TestOrderSampleVisit>();
                                            foreach (TestOrderSampleVisitDetails objp in Contentpkgparam1)
                                            {
                                                TestOrderSampleVisit objcontpar = new TestOrderSampleVisit();
                                                if (tall.SubGroupID == objp.SubGroupID)// && objp.SubGroupID == "0")
                                                {
                                                    objcontpar.TestCode = objp.TestCode;
                                                    objcontpar.OrderedDate = GetTimeZoneTime(objp.OrderedDate);
                                                    objcontpar.TestType = objp.TestType;
                                                    objcontpar.TestID = objp.TestID;
                                                    objcontpar.TestName = objp.TestName;
                                                    objcontpar.TestValueType = objp.TestValueType;
                                                    objcontpar.TestValue = objp.TestValue;
                                                    objcontpar.UOMCode = objp.UOMCode;
                                                    objcontpar.MethodName = objp.MethodName;
                                                    objcontpar.ReferenceRange = objp.ReferenceRange.Contains("<?xml") ? ParseXML(objp.ReferenceRange) : objp.ReferenceRange;
                                                    objcontpar.IsAbnormal = objp.IsAbnormal;
                                                    objcontpar.ResultCapturedAt = GetTimeZoneTime(objp.ResultCapturedAt);
                                                    objcontpar.TestStatus = objp.TestStatus;
                                                    objcontpar.MedicalRemarks = objp.MedicalRemarks;
                                                    objcontpar.InterpretationNotes = objp.InterpretationNotes;
                                                    objcontpar.ProcessingType = objp.ProcessingType;
                                                    objcontpar.ProcessingLocation = objp.ProcessingLocation;
                                                    objcontpar.SampleCollectionDateTime = GetTimeZoneTime(objp.SampleCollectionDateTime);
                                                    objcontpar.DeviceID = objp.DeviceID;
                                                    objcontpar.LotNumber = objp.LotNumber;
                                                    objcontpar.CreatedAt = GetTimeZoneTime(objp.CreatedAt);
                                                    objcontpar.UpdatedAt = GetTimeZoneTime(objp.UpdatedAt);
                                                    objcontpar.DepartmentName = tall.DepartmentName;
                                                    objcontpar.DeltaValue = objp.DeltaValue;
                                                    objcontpar.UserID = objp.UserID;
                                                    objcontpar.UserName = objp.UserName;
                                                    objcontpar.SampleName = objp.SampleName;
                                                    objcontpar.Nonreportable = objp.Nonreportable;
                                                    lstpkgcontpar.Add(objcontpar);
                                                }
                                            }

                                            objcont1.ParameterListInfo = lstpkgcontpar;
                                            lstpkgcont.Add(objcont1);
                                        }
                                        objgrp.OrderContentListInfo = lstpkgcont;
                                        if (!lstAllOrder.Exists(p => p.TestID == objgrp.TestID && p.TestType == objgrp.TestType))
                                            lstAllOrder.Add(objgrp);
                                    }

                                }
                            }
                            if (s.TestType == "PKG")// && s.TestID == inv.PKGID)
                            {
                                foreach (TestOrderSampleVisitDetails inv in lstPatOrderDetails)
                                {
                                    if (s.TestID == inv.PKGID)
                                    {
                                        TestOrderSample objpkg = new TestOrderSample();
                                        TestOrderSampleContentVisit objpkgcnt = new TestOrderSampleContentVisit();
                                        TestOrderSampleVisit objpkgparam = new TestOrderSampleVisit();
                                        objpkg.PatientVisitID = inv.PatientVisitID;
                                        objpkg.ExternalVisitID = inv.ExternalVisitID;
                                        objpkg.TestID = s.TestID;
                                        objpkg.TestCode = s.TestCode;
                                        objpkg.OrderedDate = GetTimeZoneTime(s.OrderedDate);
                                        objpkg.TestType = s.TestType;
                                        objpkg.TestName = s.TestName;
                                        objpkg.TestValueType = s.TestValueType;
                                        objpkg.TestValue = s.TestValue;
                                        objpkg.UOMCode = s.UOMCode;
                                        objpkg.MethodName = s.MethodName;
                                        objpkg.ReferenceRange = s.ReferenceRange.Contains("<?xml") ? ParseXML(s.ReferenceRange) : s.ReferenceRange;
                                        objpkg.IsAbnormal = s.IsAbnormal;
                                        objpkg.ResultCapturedAt = GetTimeZoneTime(s.ResultCapturedAt);
                                        objpkg.TestStatus = s.TestStatus;
                                        objpkg.MedicalRemarks = s.MedicalRemarks;
                                        objpkg.InterpretationNotes = s.InterpretationNotes;
                                        objpkg.ProcessingType = s.ProcessingType;
                                        objpkg.ProcessingLocation = s.ProcessingLocation;
                                        objpkg.SampleCollectionDateTime = GetTimeZoneTime(s.SampleCollectionDateTime);
                                        objpkg.DeviceID = s.DeviceID;
                                        objpkg.LotNumber = s.LotNumber;
                                        objpkg.CreatedAt = GetTimeZoneTime(s.CreatedAt);
                                        objpkg.UpdatedAt = GetTimeZoneTime(s.UpdatedAt);
                                        objpkg.DepartmentName = s.DepartmentName;
                                        objpkg.SampleName = s.SampleName;
                                        objpkg.Nonreportable = s.Nonreportable;
                                        List<TestOrderSampleContentVisit> lstpkg = new List<TestOrderSampleContentVisit>();
                                        var Contentpkg = lstPatOrderDetails.FindAll(p => p.PKGID == inv.PKGID && p.GroupID == "0");
                                        //  var Contentpkgparam = lstPatOrderDetails.FindAll(p => p.GroupID == inv.GroupID);
                                        var Contentpkgparam = lstPatOrderDetails.GroupBy(test => test.GroupID)
                                                     .Select(grp => grp.First())
                                                     .Where(t => t.GroupID != "0" && t.PKGID != "0" && t.PKGID == inv.PKGID)
                                                       .ToList();
                                        var Contentpkgparam1 = lstPatOrderDetails.FindAll(p => p.PKGID == inv.PKGID);
                                        List<TestOrderSampleContentVisit> lstpkgcont = new List<TestOrderSampleContentVisit>();

                                        foreach (TestOrderSampleVisitDetails tall in Contentpkg)
                                        {
                                            TestOrderSampleContentVisit objcont = new TestOrderSampleContentVisit();
                                            objcont.TestCode = tall.TestCode;
                                            objcont.OrderedDate = GetTimeZoneTime(tall.OrderedDate);
                                            objcont.TestType = tall.TestType;
                                            objcont.TestID = tall.TestID;
                                            objcont.TestName = tall.TestName;
                                            objcont.TestValueType = tall.TestValueType;
                                            objcont.TestValue = tall.TestValue;
                                            objcont.UOMCode = tall.UOMCode;
                                            objcont.MethodName = tall.MethodName;
                                            objcont.ReferenceRange = tall.ReferenceRange.Contains("<?xml") ? ParseXML(tall.ReferenceRange) : tall.ReferenceRange;
                                            objcont.IsAbnormal = tall.IsAbnormal;
                                            objcont.ResultCapturedAt = GetTimeZoneTime(tall.ResultCapturedAt);
                                            objcont.TestStatus = tall.TestStatus;
                                            objcont.MedicalRemarks = tall.MedicalRemarks;
                                            objcont.InterpretationNotes = tall.InterpretationNotes;
                                            objcont.ProcessingType = tall.ProcessingType;
                                            objcont.ProcessingLocation = tall.ProcessingLocation;
                                            objcont.SampleCollectionDateTime = GetTimeZoneTime(tall.SampleCollectionDateTime);
                                            objcont.DeviceID = tall.DeviceID;
                                            objcont.LotNumber = tall.LotNumber;
                                            objcont.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                            objcont.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                            objcont.DepartmentName = tall.DepartmentName;
                                            objcont.SampleName = tall.SampleName;
                                            objcont.Nonreportable = tall.Nonreportable;
                                            lstpkgcont.Add(objcont);

                                        }

                                        foreach (TestOrderSampleVisitDetails tall in Contentpkgparam)
                                        {
                                            TestOrderSampleContentVisit objcont1 = new TestOrderSampleContentVisit();
                                            objcont1.TestCode = tall.GroupCode;
                                            objcont1.OrderedDate = GetTimeZoneTime(tall.OrderedDate);
                                            objcont1.TestType = "GRP";
                                            objcont1.TestID = tall.GroupID;
                                            objcont1.TestName = tall.GroupName;
                                            objcont1.TestValueType = tall.TestValueType;
                                            objcont1.TestValue = "";
                                            objcont1.UOMCode = tall.UOMCode;
                                            objcont1.MethodName = tall.MethodName;
                                            objcont1.ReferenceRange = tall.ReferenceRange.Contains("<?xml") ? ParseXML(tall.ReferenceRange) : tall.ReferenceRange;
                                            objcont1.IsAbnormal = tall.IsAbnormal;
                                            objcont1.ResultCapturedAt = GetTimeZoneTime(tall.ResultCapturedAt);
                                            objcont1.TestStatus = tall.TestStatus;
                                            objcont1.MedicalRemarks = tall.MedicalRemarks;
                                            objcont1.InterpretationNotes = tall.InterpretationNotes;
                                            objcont1.ProcessingType = tall.ProcessingType;
                                            objcont1.ProcessingLocation = tall.ProcessingLocation;
                                            objcont1.SampleCollectionDateTime = GetTimeZoneTime(tall.SampleCollectionDateTime);
                                            objcont1.DeviceID = tall.DeviceID;
                                            objcont1.LotNumber = tall.LotNumber;
                                            objcont1.CreatedAt = GetTimeZoneTime(tall.CreatedAt);
                                            objcont1.UpdatedAt = GetTimeZoneTime(tall.UpdatedAt);
                                            objcont1.DepartmentName = tall.DepartmentName;
                                            objcont1.SampleName = tall.SampleName;
                                            objcont1.Nonreportable = tall.Nonreportable;
                                            List<TestOrderSampleVisit> lstpkgcontpar = new List<TestOrderSampleVisit>();
                                            foreach (TestOrderSampleVisitDetails objp in Contentpkgparam1)
                                            {
                                                TestOrderSampleVisit objcontpar = new TestOrderSampleVisit();
                                                if (tall.GroupID == objp.GroupID)// && objp.SubGroupID == "0")
                                                {
                                                    objcontpar.TestCode = objp.TestCode;
                                                    objcontpar.OrderedDate = GetTimeZoneTime(objp.OrderedDate);
                                                    objcontpar.TestType = objp.TestType;
                                                    objcontpar.TestID = objp.TestID;
                                                    objcontpar.TestName = objp.TestName;
                                                    objcontpar.TestValueType = objp.TestValueType;
                                                    objcontpar.TestValue = objp.TestValue;
                                                    objcontpar.UOMCode = objp.UOMCode;
                                                    objcontpar.MethodName = objp.MethodName;
                                                    objcontpar.ReferenceRange = objp.ReferenceRange.Contains("<?xml") ? ParseXML(objp.ReferenceRange) : objp.ReferenceRange;
                                                    objcontpar.IsAbnormal = objp.IsAbnormal;
                                                    objcontpar.ResultCapturedAt = GetTimeZoneTime(objp.ResultCapturedAt);
                                                    objcontpar.TestStatus = objp.TestStatus;
                                                    objcontpar.MedicalRemarks = objp.MedicalRemarks;
                                                    objcontpar.InterpretationNotes = objp.InterpretationNotes;
                                                    objcontpar.ProcessingType = objp.ProcessingType;
                                                    objcontpar.ProcessingLocation = objp.ProcessingLocation;
                                                    objcontpar.SampleCollectionDateTime = GetTimeZoneTime(objp.SampleCollectionDateTime);
                                                    objcontpar.DeviceID = objp.DeviceID;
                                                    objcontpar.LotNumber = objp.LotNumber;
                                                    objcontpar.CreatedAt = GetTimeZoneTime(objp.CreatedAt);
                                                    objcontpar.UpdatedAt = GetTimeZoneTime(objp.UpdatedAt);
                                                    objcontpar.DepartmentName = objp.DepartmentName;
                                                    objcontpar.SampleName = objp.SampleName;
                                                    objcontpar.Nonreportable = objp.Nonreportable;
                                                    lstpkgcontpar.Add(objcontpar);
                                                }
                                            }

                                            objcont1.ParameterListInfo = lstpkgcontpar;
                                            lstpkgcont.Add(objcont1);
                                        }
                                        objpkg.OrderContentListInfo = lstpkgcont;
                                        if (!lstAllOrder.Exists(p => p.TestID == objpkg.TestID && p.TestType == objpkg.TestType))
                                            lstAllOrder.Add(objpkg);
                                    }
                                }
                            }
                        }
                        ObjOrder.OrderInfo = lstAllOrder;
                    }
                    actionResult = Ok(ObjOrder);
                }
                else
                {
                    actionResult = Ok("While fetching the data getting an Error.");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured" + ex.ToString());
                UpdatePatientOrderInvestigation(OrgCode, VisitNumber, "");
            }

            return actionResult;
        }
		
		  [ResponseType(typeof(OrderDetailsResult))]
        [HttpGet]
        [Route("Api/Orders/GetOrderResultDetailsbyVisitNo")]

        public IHttpActionResult GetOrderResultDetailsbyVisitNo(string VisitNumber)
        {

            long returnCode = -1;
            IHttpActionResult actionResult = null;
            OrderDetailsResult ObjOrder = new OrderDetailsResult();

          
            List<VNPatientDetails> lstPatDetail = new List<VNPatientDetails>();
            List<VNResPatientDetails> lstResPatDetail = new List<VNResPatientDetails>();
            
            List<VNAddressDetails> lstAdddress = new List<VNAddressDetails>();
            List<VNPatientVisitDetails> lstpatientvisitdetails = new List<VNPatientVisitDetails>();
            List<VNTestOrder> lstAllOrder = new List<VNTestOrder>();
            List<VNTestOrder> lstTestDetails = new List<VNTestOrder>();
            VNPatientDetails lstPat = new VNPatientDetails();
            VNAddressDetails lstPatAdd = new VNAddressDetails();

            VNResPatientDetails objpat = new VNResPatientDetails();
            VNTestOrder objTestDetails = new VNTestOrder();
            string OrgCode = string.Empty;
            VNPatientVisitDetails objvisit = new VNPatientVisitDetails();
            try
            {
                returnCode = new LIMSAPI_BL().GetOrderResultDetailsbyVisitNo(VisitNumber, out lstPatDetail, out lstpatientvisitdetails,  out lstAllOrder, out OrgCode);

                if (returnCode != -1)
                {
                    if (lstPatDetail.Count > 0 && lstPatDetail != null)
                    {
                        objpat.PatientID = lstPatDetail[0].PatientID;
                        objpat.PatientNumber = lstPatDetail[0].PatientNumber;
                        objpat.FirstName = lstPatDetail[0].FirstName;
                        objpat.MiddleName = lstPatDetail[0].MiddleName;
                        objpat.LastName = lstPatDetail[0].LastName;
                        objpat.MobileNumber = lstPatDetail[0].MobileNumber;
                        objpat.URNNumber = lstPatDetail[0].URNNumber;
                        objpat.URNType = lstPatDetail[0].URNType;
                        objpat.Gender = lstPatDetail[0].Gender;
                        objpat.Age = lstPatDetail[0].Age;
                        objpat.DOB = lstPatDetail[0].DOB;
                        objpat.EmailID = lstPatDetail[0].EmailID;
                        objpat.SalutationCode = lstPatDetail[0].SalutationCode;
                        lstPatAdd.Address = lstPatDetail[0].Address;
                        lstPatAdd.State = lstPatDetail[0].State;
                        lstPatAdd.City = lstPatDetail[0].City;
                        lstPatAdd.Country = lstPatDetail[0].Country;
                        lstPatAdd.AddressType = lstPatDetail[0].AddressType;
                        lstPatAdd.StateID = lstPatDetail[0].StateID;
                        lstPatAdd.CountryID = lstPatDetail[0].CountryID;
                        lstPatAdd.ExternalPatientNumber = lstPatDetail[0].ExternalPatientNumber;
                        lstAdddress.Add(lstPatAdd);
                        objpat.AddressDetails = lstAdddress;
                        ObjOrder.MessageType = "OrderInformation";
                        ObjOrder.OrgCode = OrgCode;
                        ObjOrder.PatientInfo = objpat;                      
                                            
                    }
                    if (lstpatientvisitdetails != null && lstpatientvisitdetails.Count > 0)
                    {
                        objvisit.ClientID = lstpatientvisitdetails[0].ClientID;
                        objvisit.PatientVisitId = lstpatientvisitdetails[0].PatientVisitId;
                        objvisit.ExternalVisitNumber = lstpatientvisitdetails[0].ExternalVisitNumber;
                        objvisit.VisitType = lstpatientvisitdetails[0].VisitType;
                        objvisit.VisitDate = lstpatientvisitdetails[0].VisitDate;
                       
                        objvisit.ClientCode = lstpatientvisitdetails[0].ClientCode;
                        objvisit.ClientName = lstpatientvisitdetails[0].ClientName;
                      
                        objvisit.ReferingDoctorCode = lstpatientvisitdetails[0].ReferingDoctorCode;
                        objvisit.ReferingDoctorMobileNumber = lstpatientvisitdetails[0].ReferingDoctorMobileNumber;
                        objvisit.ReferingDoctorName = lstpatientvisitdetails[0].ReferingDoctorName;
                        
                        objvisit.RegisterLocation = lstpatientvisitdetails[0].RegisterLocation;
                       
                        ObjOrder.PatientVisitInfo = objvisit;
                       
                    }
                    if (lstAllOrder != null && lstAllOrder.Count > 0)
                    {

                        foreach (VNTestOrder s in lstAllOrder)
                        {

                            VNTestOrder objtest = new VNTestOrder();

                            objtest.TestID = s.TestID;
                            objtest.TestCode = s.TestCode;
                            objtest.TestName = s.TestName;
                            objtest.Status = s.Status;
                            objtest.Remarks = s.Remarks;

                            lstTestDetails.Add(objtest);

                        }
                        

                        ObjOrder.TestDetailsList = lstTestDetails;
                    }                 

                    actionResult = Ok(ObjOrder);
                }
                else
                {
                    actionResult = Ok("While fetching the data getting an Error.");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured" + ex.ToString());
            }

            return actionResult;
        }
    }
}
