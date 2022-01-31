using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LIMSAPI.Models;
using Attune.Kernel.LIMSAPI.BL;
using Attune.Kernel.LIMSAPI.BusinessEntities;
using System.Web.Http.Description;
using Attune.KernelV2;
using Newtonsoft.Json;
using System.IO;
using System.Drawing;
using System.Text;

namespace LIMSAPI.Controllers
{
    public class BookingController : BaseApiController
    {

        /// <summary>
        /// This API returns the Bookings of HomeCollection for the given date
        ///If LoginID of particular Phelbo specified will return Bookings assigned to the particular Phelbo
        /// </summary>
        /// <param name="pUserID"></param>
        /// <param name="pDateRange"></param>
        /// <returns></returns>
        [ResponseType(typeof(BookingdetailsInfo))]
        [HttpGet]
        [Route("Api/Booking/GetBookingDetails")]
        public IHttpActionResult GetNewBookingDetails(int pUserID, DateTime pDateRange)
        {
            long returnCode = -1;
            IHttpActionResult actionResult = null;

            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;
            long pOrgID = 0;
            long pLocationID = 0;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            List<BookingInfo> lstBookingInfo = new List<BookingInfo>();
            List<BookingInfo> lstCollection = new List<BookingInfo>();

            BookingdetailsInfo objBookinginfo = new BookingdetailsInfo();
            List<BookingDetails> lstbookings = new List<BookingDetails>();
            List<SampleDetails> lstsamples = null;
            SampleDetails objSampledetails = null;

            try
            {
                returnCode = new LIMSAPI_BL().GetBookingDetails(pUserID, pDateRange, pOrgCode, out lstBookingInfo, out lstCollection);

                if (returnCode != -1)
                {
                    if (lstBookingInfo.Count > 0 && lstBookingInfo != null)
                    {
                        for (int i = 0; i < lstBookingInfo.Count; i++)
                        {
                            pOrgID = lstBookingInfo[i].OrgID;
                            pLocationID = lstBookingInfo[i].LocationID;

                            if (lstBookingInfo[i].BookingID > 0 && lstBookingInfo[i].BookingID != 0)
                            {
                                lstsamples = new List<SampleDetails>();

                                foreach (BookingInfo item in lstCollection)
                                {
                                    objSampledetails = new SampleDetails();

                                    if (lstBookingInfo[i].BookingID == item.BookingID)
                                    {
                                        objSampledetails.SampleID = item.SampleID;
                                        objSampledetails.SampleName = item.SampleName;
                                        objSampledetails.ContainerID = item.ContainerID;
                                        objSampledetails.ContainerName = item.ContainerName;
                                        objSampledetails.SampleContainerColour = item.SampleContainerColour;
                                        objSampledetails.TestCode = item.TestCode;
                                        objSampledetails.Price = item.Price;

                                        lstsamples.Add(objSampledetails);
                                    }
                                }

                                lstbookings.Add(new BookingDetails()
                                {
                                    BookingID = lstBookingInfo[i].BookingID,
                                    Salutation = lstBookingInfo[i].Salutation,
                                    Name = lstBookingInfo[i].Name,
                                    Gender = lstBookingInfo[i].Gender,
                                    Age = lstBookingInfo[i].Age,
                                    DateofBirth = lstBookingInfo[i].DateofBirth,
                                    Address = lstBookingInfo[i].Address,
                                    City = lstBookingInfo[i].City,
                                    State = lstBookingInfo[i].State,
                                    Country = lstBookingInfo[i].Country,
                                    PinCode = lstBookingInfo[i].PostalCode,
                                    MobileNumber = lstBookingInfo[i].MobileNumber,
                                    EmailID = lstBookingInfo[i].Email,
                                    ClientCode = lstBookingInfo[i].ClientCode,
                                    SampleCollectionTime = lstBookingInfo[i].SampleCollectionTime,
                                    DispatchType = lstBookingInfo[i].DispatchType,
                                    TotalAmount = lstBookingInfo[i].TotalGrossAmount,
                                    DiscountID = lstBookingInfo[i].DiscountID,
                                    DiscountAmount = lstBookingInfo[i].DiscountAmount,
                                    DueAmount = lstBookingInfo[i].DueAmount,
                                    PaymentStatus = lstBookingInfo[i].PaymentStatus,
                                    Status = lstBookingInfo[i].Status,
				                    Comments = lstBookingInfo[i].Comments,
                                    InventoryCount = lstBookingInfo[i].InventoryCount,
                                    LoginID = lstBookingInfo[i].UserID,
                                    CollectionInfo = lstsamples
                                });
                            }
                        }

                        objBookinginfo.OrgCode = pOrgCode;
                        objBookinginfo.Type = "BookingsInformation";
                        objBookinginfo.OrgID = pOrgID;
                        objBookinginfo.LocationID = pLocationID;
                        objBookinginfo.BookingInfo = lstbookings;
                        actionResult = Ok(objBookinginfo);
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
        /// This API will provide the VisitInformation for particular BookingID
        /// </summary>
        /// <returns>success</returns>
        [ResponseType(typeof(VisitDetails))]
        [HttpGet]
        [Route("Api/Booking/BookingVisitInformation")]
        public IHttpActionResult GetVisitInformation(int pBookingID)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<VisitInfo> lstVisitInfo = new List<VisitInfo>();

            try
            {
                returnCode = new LIMSAPI_BL().GetVisitInformation(pOrgCode, pBookingID, out lstVisitInfo);

                if (returnCode != -1)
                {
                    if (lstVisitInfo.Count > 0 && lstVisitInfo != null)
                    {
                        VisitDetails objVisitDetails = new VisitDetails();

                        objVisitDetails.OrgCode = lstVisitInfo[0].OrgCode;
                        objVisitDetails.Type = "Visit Information";
                        objVisitDetails.VisitDate = lstVisitInfo[0].VisitDate;
                        objVisitDetails.VisitNumber = lstVisitInfo[0].VisitNumber;
                        objVisitDetails.LocationID = lstVisitInfo[0].OrgLocationCode;
                        actionResult = Ok(objVisitDetails);
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

        /// <summary>
        /// This API will update the trip Status of the bookings(B- Booked,C- Canceled,A- Assigned,TS- Trip Started,
        /// TC- Trip Cancelled,RD - Reached Destination,IP- InProgress,CD- Completed
        /// </summary>
        /// <param name="pType">Default Value is Tripstatus</param>
        /// <param name="lstTripStatusInfo">Trip Status JSON with reason</param>
        /// <returns></returns>
        [ResponseType(typeof(TripStatusInfo))]
        [Route("Api/Booking/PostTripStatus")]
        [HttpPost]
        public IHttpActionResult PostTripStatus(string pType, TripStatusInfo lstTripStatusInfo)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }
            long returnCode = -1;
            IHttpActionResult actionResult = null;

            List<TripStatusInfo> lstTripStatus = new List<TripStatusInfo>();

            try
            {
                if (lstTripStatusInfo != null)
                {
                    TripStatusInfo objTripStatusInfo = new TripStatusInfo();

                    objTripStatusInfo.BookingID = lstTripStatusInfo.BookingID;
                    objTripStatusInfo.OrgID = lstTripStatusInfo.OrgID;
                    objTripStatusInfo.LocationID = lstTripStatusInfo.LocationID;
                    objTripStatusInfo.LoginID = lstTripStatusInfo.LoginID;
                    objTripStatusInfo.ModifiedBy = lstTripStatusInfo.ModifiedBy;
                    if (Convert.ToDateTime(lstTripStatusInfo.ModifiedAt).ToString("yyyy") == "0001")
                        objTripStatusInfo.ModifiedAt = DateTime.MaxValue;
                    else
                        objTripStatusInfo.ModifiedAt = lstTripStatusInfo.ModifiedAt;
                    objTripStatusInfo.TripStatus = lstTripStatusInfo.TripStatus;
                    objTripStatusInfo.TripReason = lstTripStatusInfo.TripReason;

                    lstTripStatus.Add(objTripStatusInfo);

                    if (lstTripStatus != null)
                    {
                        returnCode = new LIMSAPI_BL().UpdateTripStatus(pOrgCode, pType, lstTripStatus);

                        if (returnCode != -1)
                        {
                            actionResult = Ok("Following the BookingID : " + lstTripStatusInfo.BookingID + " Successfully processed.");
                        }
                        else
                        {
                            actionResult = Ok("Result Not Found");
                        }
                    }
                }
                else
                {
                    actionResult = Ok("Booking Registration Information not found");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }

            return actionResult;
        }

        
        /// <summary>
        /// This API will update the Home Collection Booking completion
        /// It will also update Amount received by the phelbo along with additional test which is ordered by phelbo
        /// </summary>
        /// <param name="objBookingstatus">Sample Collection and Payment Information JSON</param>
        /// <returns></returns>
        [ResponseType(typeof(PostBookingCompletionModel))]
        [HttpPost]
        [Route("Api/Booking/PostHCBookingCompletion")]
        public IHttpActionResult PostHCBookingsInfo(PostBookingCompletionModel objBookingstatus)
        {
            long returnCode = -1;
            IHttpActionResult actionResult = null;

            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            List<BookingInfo> lstBooking = new List<BookingInfo>();
            List<Paymentdetail> lstPayment = new List<Paymentdetail>();
            List<BookingInfo> lstTest = new List<BookingInfo>();
            BookingInfo objBooking = null;
            Paymentdetail objPayment = null;
            BookingInfo objTest = null;
            BookingInfo objAddTest = null;

            try
            {
                if (objBookingstatus != null)
                {
                    string pType = objBookingstatus.TransType;

                    objBooking = new BookingInfo();
                    objBooking.LoginID = objBookingstatus.LoginID;

                    #region BookingInfo 
                    if (objBookingstatus.BookingInfo != null)
                    {
                        objBooking.OrgID = objBookingstatus.BookingInfo.OrgID;
                        objBooking.LocationID = objBookingstatus.BookingInfo.LocationID;
                        objBooking.BookingID = objBookingstatus.BookingInfo.BookingID;

                        if (Convert.ToDateTime(objBookingstatus.BookingInfo.BookingDTTM).ToString("yyyy") != "0001")
                            objBooking.BookingDTTM = objBookingstatus.BookingInfo.BookingDTTM;

                        if (Convert.ToDateTime(objBookingstatus.BookingInfo.CollectionTime).ToString("yyyy") != "0001")
                            objBooking.CollectionTime = objBookingstatus.BookingInfo.CollectionTime;

                        objBooking.DispatchType = objBookingstatus.BookingInfo.DispatchType;
                        objBooking.TRFFile = objBookingstatus.BookingInfo.TRFFile;
                        objBooking.Status = objBookingstatus.BookingInfo.Status;
                        objBooking.OrgCode = objBookingstatus.BookingInfo.OrgCode;
                        objBooking.LocationCode = objBookingstatus.BookingInfo.LocationCode;
                    }
                    #endregion

                    #region PatientInfo   
                    if (objBookingstatus.PatientInfo != null)
                    {
                        objBooking.PatientID = objBookingstatus.PatientInfo.PatientID;
                        objBooking.Salutation = objBookingstatus.PatientInfo.Salutation;
                        objBooking.ExternalPatientNumber = objBookingstatus.PatientInfo.ExternalPatientNumber;
                        objBooking.FirstName = objBookingstatus.PatientInfo.FirstName;
                        objBooking.MiddleName = objBookingstatus.PatientInfo.MiddleName;
                        objBooking.LastName = objBookingstatus.PatientInfo.LastName;
                        objBooking.Gender = objBookingstatus.PatientInfo.Gender;
                        objBooking.Age = objBookingstatus.PatientInfo.Age;

                        if (Convert.ToDateTime(objBookingstatus.PatientInfo.DOB).ToString("yyyy") != "0001")
                            objBooking.DateofBirth = objBookingstatus.PatientInfo.DOB;

                        objBooking.MobileNumber = objBookingstatus.PatientInfo.MobileNumber;
                        objBooking.Email = objBookingstatus.PatientInfo.EmailID;
                        objBooking.URNNo = objBookingstatus.PatientInfo.URNNumber;
                        objBooking.URNType = objBookingstatus.PatientInfo.URNType;
                        objBooking.EmployeeID = objBookingstatus.PatientInfo.EmployeeID;

                        if (objBookingstatus.PatientInfo.AddressDetails != null)
                        {
                            foreach (HCAddressModel item in objBookingstatus.PatientInfo.AddressDetails)
                            {
                                objBooking.AddressType = item.AddressType;
                                objBooking.Address = item.Address;
                                objBooking.City = item.City;
                                objBooking.State = item.State;
                                objBooking.Country = item.Country;
                                objBooking.PostalCode = Convert.ToString(item.PostalCode);
                            }
                        }
                    }
                    #endregion

                    #region PaymentInfo   
                    if (objBookingstatus.PaymentInfoList != null)
                    {
                        foreach (PaymentModel item in objBookingstatus.PaymentInfoList)
                        {
                            objPayment = new Paymentdetail();
                            objPayment.BookingID = objBookingstatus.BookingInfo == null ? 0 : objBookingstatus.BookingInfo.BookingID;
                            objPayment.PaymentMode = item.PaymentMode;
                            objPayment.CurrencyType = item.CurrencyType;
                            objPayment.ChequeorCardNumber = Convert.ToString(item.CardNumber);
                            objPayment.CardHolderName = item.CardHolderName;
                            objPayment.TransactionID = item.TransactionID;
                            objPayment.ReceivedAmount = item.ReceivedAmount;
                            objPayment.OrgID = objBookingstatus.BookingInfo == null ? 0 : objBookingstatus.BookingInfo.OrgID;
                            objPayment.CreatedBy = objBookingstatus.LoginID;
                            lstPayment.Add(objPayment);
                        }
                    }
                    #endregion

                    #region TestInfo   
                    if (objBookingstatus.TestInfoList != null)
                    {
                        foreach (TestModel item in objBookingstatus.TestInfoList)
                        {
                            objTest = new BookingInfo();
                            objTest.BookingID = objBookingstatus.BookingInfo == null ? 0 : objBookingstatus.BookingInfo.BookingID;
                            objTest.OrderedFrom = item.OrderedFrom;
                            objTest.TestCode = item.TestCode;
                            objTest.SampleID = item.SampleID;
                            objTest.SampleName = item.SampleName;
                            objTest.SampleContainerColour = item.SampleContainerColour;
                            objTest.ContainerID = item.ContainerID;
                            objTest.ContainerName = item.ContainerName;
                            objTest.Price = item.Price;
                            objTest.SampleStatus = item.CollectionStatus;
                            if (Convert.ToDateTime(item.SampleCollectedTime).ToString("yyyy") != "0001")
                                objTest.SampleCollectionTime = item.SampleCollectedTime;
                            objTest.OrgID = objBookingstatus.BookingInfo == null ? 0 : objBookingstatus.BookingInfo.OrgID;
                            objTest.LoginID = objBookingstatus.LoginID;
                            objTest.Type = item.Type;
                            objTest.Remarks = ""; //Ordered Test
                            objTest.BarcodeNo = item.BarcodeNo;
                            lstTest.Add(objTest);
                        }
                    }
                    #endregion

                    #region Additional TestInfo   
                    if (objBookingstatus.AddTestInfoList != null)
                    {
                        foreach (AddTestModel item in objBookingstatus.AddTestInfoList)
                        {
                            objAddTest = new BookingInfo();
                            objAddTest.BookingID = objBookingstatus.BookingInfo == null ? 0 : objBookingstatus.BookingInfo.BookingID;
                            objAddTest.OrderedFrom = item.OrderedFrom;
                            objAddTest.TestCode = item.TestCode;
                            objAddTest.SampleID = item.SampleID;
                            objAddTest.SampleName = item.SampleName;
                            objAddTest.SampleContainerColour = item.SampleContainerColour;
                            objAddTest.ContainerID = item.ContainerID;
                            objAddTest.ContainerName = item.ContainerName;
                            objAddTest.Price = item.Price;
                            objAddTest.SampleStatus = item.CollectionStatus;
                            if (Convert.ToDateTime(item.SampleCollectedTime).ToString("yyyy") != "0001")
                                objAddTest.SampleCollectionTime = item.SampleCollectedTime;
                            objAddTest.OrgID = objBookingstatus.BookingInfo == null ? 0 : objBookingstatus.BookingInfo.OrgID;
                            objAddTest.LoginID = objBookingstatus.LoginID;
                            objAddTest.Type = item.Type;
                            objAddTest.Remarks = "Y"; //Additional Ordered Test
                            objAddTest.BarcodeNo = item.BarcodeNo;
                            lstTest.Add(objAddTest);
                        }
                    }
                    #endregion

                    objBooking.JsonValue = JsonConvert.SerializeObject(objBookingstatus);
                    lstBooking.Add(objBooking);

                    if (lstBooking != null)
                    {
                        returnCode = new LIMSAPI_BL().UpdateBookings(pOrgCode, pType, lstBooking, lstPayment, lstTest);

                        if (returnCode != -1 && returnCode != 1001)
                        {
                            actionResult = Ok("Home Collection details successfully inserted.");
                        }
                        else
                        {
                            actionResult = Ok("Error on while inserting the Home Collection details");
                        }
                    }
                }
                else
                {
                    actionResult = Ok("Home Collecion Information details not found");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }

            return actionResult;
        }

        /// <summary>
        ///  This API will provide functionality to the New Bookings done outside AttuneLIMS  
        /// </summary>
        /// <param name="objBookingInfo">Bookings JSON with Patient, Booking and Ordered Test Details </param>
        /// <returns></returns>
        [ResponseType(typeof(BookingInfoModel))]
        [Route("Api/Booking/PostNewBookingInfo")]
        [HttpPost]
        public IHttpActionResult PostBookingInfo(BookingInfoModel objBookingInfo)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            long returnCode = -1;
            long returncode = -1;
            var pOutstring = string.Empty;
            IHttpActionResult actionResult = null;

            List<BookingInfo> lstBooking = new List<BookingInfo>();
            List<Paymentdetail> lstPayment = new List<Paymentdetail>();
            List<BookingInfo> lstOrders = new List<BookingInfo>();
            BookingInfo objBooking = null;
            Paymentdetail objPayment = null;
            BookingInfo objorder = null;
            try
            {
                if (objBookingInfo != null)
                {
                    string pType = objBookingInfo.TransType;
                    objBooking = new BookingInfo();

                    #region BookingInfo 
                    if (objBookingInfo.BookingInfo != null)
                    {
                        objBooking.OrgID = objBookingInfo.BookingInfo.OrgID;
                        objBooking.LocationID = objBookingInfo.BookingInfo.LocationID;
                        objBooking.ExternalRefNo = objBookingInfo.BookingInfo.ExternalRefNo;

                        if (Convert.ToDateTime(objBookingInfo.BookingInfo.BookingDTTM).ToString("yyyy") != "0001")
                            objBooking.BookingDTTM = objBookingInfo.BookingInfo.BookingDTTM;

                        if (Convert.ToDateTime(objBookingInfo.BookingInfo.CollectionTime).ToString("yyyy") != "0001")
                            objBooking.CollectionTime = objBookingInfo.BookingInfo.CollectionTime;

                        objBooking.DispatchType = objBookingInfo.BookingInfo.DispatchType;
                        objBooking.Status = objBookingInfo.BookingInfo.Status;
                        objBooking.ClientID = Convert.ToString(objBookingInfo.BookingInfo.ClientID);
                        objBooking.ClientCode = objBookingInfo.BookingInfo.ClientCode;
                        objBooking.TotalGrossAmount = objBookingInfo.BookingInfo.GrossAmount;
                        objBooking.DiscountAmount = objBookingInfo.BookingInfo.DiscountAmount;
                        objBooking.NetAmount = objBookingInfo.BookingInfo.NetAmount;
                        objBooking.DiscountID = objBookingInfo.BookingInfo.DiscountID;
                        objBooking.PaymentStatus = objBookingInfo.BookingInfo.PaymentStatus;
                        objBooking.OrgCode = objBookingInfo.BookingInfo.OrgCode;
                        objBooking.LocationCode = objBookingInfo.BookingInfo.LocationCode;
                        objBooking.BookingRemarks = objBookingInfo.BookingInfo.Remarks;
                    }
                    #endregion

                    #region Patient
                    if (objBookingInfo.PatientInfo != null)
                    {
                        objBooking.Name = objBookingInfo.PatientInfo.Name;
                        objBooking.FirstName = objBookingInfo.PatientInfo.FirstName;
                        objBooking.MiddleName = objBookingInfo.PatientInfo.MiddleName;
                        objBooking.LastName = objBookingInfo.PatientInfo.LastName;
                        objBooking.Salutation = objBookingInfo.PatientInfo.Salutation;
                        objBooking.Age = objBookingInfo.PatientInfo.Age;
                        objBooking.Gender = objBookingInfo.PatientInfo.Gender;

                        if (Convert.ToDateTime(objBookingInfo.PatientInfo.DOB).ToString("yyyy") != "0001")
                            objBooking.DateofBirth = objBookingInfo.PatientInfo.DOB;

                        objBooking.MobileNumber = objBookingInfo.PatientInfo.MobileNumber;
                        objBooking.Email = objBookingInfo.PatientInfo.Email;
                        objBooking.URNType = objBookingInfo.PatientInfo.URNType;
                        objBooking.URNNo = objBookingInfo.PatientInfo.URNNumber;
                        objBooking.ExternalPatientNumber = objBookingInfo.PatientInfo.ExternalPatientNo;
                        objBooking.ExternalPatientRefNo = objBookingInfo.PatientInfo.HealthHubID;
                        objBooking.EmployeeID = objBookingInfo.PatientInfo.EmployeeID;
                        objBooking.ERPPatientNumber = objBookingInfo.PatientInfo.PatientNumber;

                        if (objBookingInfo.PatientInfo.AddressDetails != null)
                        {
                            foreach (AddressModel item in objBookingInfo.PatientInfo.AddressDetails)
                            {
                                objBooking.AddressType = item.AddressType;
                                objBooking.Address = item.Address;
                                objBooking.City = item.City;
                                objBooking.State = item.State;
                                objBooking.Country = item.Country;
                                objBooking.PostalCode = Convert.ToString(item.PostalCode);
                                objBooking.Location = item.Location;
                            }
                        }
                    }
                    #endregion

                    #region PaymentInfo   
                    if (objBookingInfo.PaymentInfoList != null)
                    {
                        foreach (PaymentModel item in objBookingInfo.PaymentInfoList)
                        {
                            objPayment = new Paymentdetail();
                            objPayment.ExternalRefNo = objBookingInfo.BookingInfo == null ? "" : objBookingInfo.BookingInfo.ExternalRefNo;
                            objPayment.PaymentMode = item.PaymentMode;
                            objPayment.CurrencyType = item.CurrencyType;
                            objPayment.ChequeorCardNumber = Convert.ToString(item.CardNumber);
                            objPayment.CardHolderName = item.CardHolderName;
                            objPayment.TransactionID = item.TransactionID;
                            objPayment.ReceivedAmount = item.ReceivedAmount;
                            objPayment.OrgID = objBookingInfo.BookingInfo == null ? 0 : objBookingInfo.BookingInfo.OrgID;
                            objPayment.CreatedBy = objBookingInfo.LoginID;
                            lstPayment.Add(objPayment);
                        }
                    }
                    #endregion

                    #region Orders   
                    if (objBookingInfo.TestInfoList != null)
                    {
                        foreach (OrderModel item in objBookingInfo.TestInfoList)
                        {
                            objorder = new BookingInfo();
                            objorder.ExternalRefNo = objBookingInfo.BookingInfo == null ? "" : objBookingInfo.BookingInfo.ExternalRefNo;
                            objorder.OrderedFrom = item.OrderedFrom;
                            objorder.TestCode = item.TestCode;
                            objorder.SampleID = item.SampleID;
                            objorder.SampleName = item.SampleName;
                            objorder.SampleContainerColour = item.SampleContainerColour;
                            objorder.ContainerID = item.ContainerID;
                            objorder.ContainerName = item.ContainerName;
                            objorder.Price = item.Price;
                            objorder.SampleStatus = item.CollectionStatus;
                            if (Convert.ToDateTime(item.SampleCollectedTime).ToString("yyyy") != "0001")
                                objorder.SampleCollectionTime = item.SampleCollectedTime;
                            objorder.OrgID = objBookingInfo.BookingInfo == null ? 0 : objBookingInfo.BookingInfo.OrgID;
                            objorder.LoginID = objBookingInfo.LoginID;
                            objorder.Type = item.Type;
                            objorder.BarcodeNo = item.BarcodeNo;
                            lstOrders.Add(objorder);
                        }
                    }
                    #endregion

                    objBooking.SourceType = objBookingInfo.SourceType;
                    objBooking.JsonValue = JsonConvert.SerializeObject(objBookingInfo);
                    lstBooking.Add(objBooking);

                    if (lstBooking != null)
                    {
                        returnCode = new LIMSAPI_BL().InsertBookingInfo(pOrgCode, pType, lstBooking, lstPayment, lstOrders, out pOutstring);

                        if (returnCode != -1 && returnCode != 1001)
                        {
                            string[] Result = pOutstring.Split('|');

                            if (Result[0].ToString().ToUpper() == "M")
                            {
                                actionResult = Ok(new
                                {
                                    Code = "Error",
                                    Message = Result[1].ToString()
                                });
                            }
                            else
                            {
                                if (Result[0].ToString().ToUpper() == "Y")
                                {
                                    actionResult = Ok(new
                                    {
                                        Code = "Success",
                                        Message = "Following the External RefNo - " + Result[1].ToString() + " already available."
                                    });
                                }
                                else
                                {
                                    #region TRF file process 
                                    if (objBookingInfo.BookingInfo.TRFFile != "" && objBookingInfo.BookingInfo.TRFFile != null)
                                    {
                                        var obj = new ImageConvertor();
                                        UploadBookingImageModel objimg = new UploadBookingImageModel();

                                    objimg.ImageData = objBookingInfo.BookingInfo.TRFFile;
                                    List<Config> lstConfig = new List<Config>();

                                    byte[] byteArray = Convert.FromBase64String(objimg.ImageData);

                                    var imageDataStream = new MemoryStream(byteArray);
                                    imageDataStream.Position = 0;

                                    Image returnImage = Image.FromStream(imageDataStream);
                                    returncode = new LIMSAPI_BL().GetConfigHCDetails(pOrgCode, "TRF_UploadPath", out lstConfig);
                                    string pathname = lstConfig[0].ConfigValue.ToString();

                                    DateTime dt = DateTime.Now;
                                    int Year = dt.Year;
                                    int Month = dt.Month;
                                    int Day = dt.Day;

                                    String Root = String.Empty;
                                    String RootPath = String.Empty;

                                    Root = "TRF_Upload-" + lstConfig[0].OrgID + "-" + Year + "-" + Month + "-" + Day + "-" + "Home_Collection" + "-";
                                    Root = Root.Replace("-", "\\\\");
                                    RootPath = pathname + Root;

                                    System.Drawing.Image imageIn = obj.ConvertByteArrayToImage(byteArray);

                                    //Check if directory exist
                                    if (!System.IO.Directory.Exists(RootPath))
                                    {
                                        System.IO.Directory.CreateDirectory(RootPath); //Create directory if it doesn't exist
                                    }
                                    string imageName = objBookingInfo.BookingInfo.ExternalRefNo + ".png";

                                    //set the image path
                                    string imgPath = Path.Combine(RootPath, imageName);

                                    string Type = "TRF_Upload_APKNew_Home_Collection";

                                    File.WriteAllBytes(imgPath, byteArray);

                                    returnCode = new LIMSAPI_BL().SaveTRFHCDetails(pOrgCode, imageName, Convert.ToInt64(Result[1]), objBookingInfo.BookingInfo.ExternalRefNo, Convert.ToInt64(Result[1]), Type, objBookingInfo.SourceType, RootPath);

                                        if (returnCode != -1 && returnCode != 1001)
                                        {
                                            actionResult = Ok(new
                                            {
                                                Code = "Success",
                                                Message = "Booking ID - " + Result[1].ToString() + " Successfully Generated and TRF file moved in path."
                                            });
                                        }
                                        else
                                        {
                                            actionResult = Ok(new
                                            {
                                                Code = "Success",
                                                Message = "Booking ID - " + Result[1].ToString() + " Successfully Generated and TRF file unable to processed."
                                            });
                                        }
                                    }
                                    else
                                    {
                                        actionResult = Ok(new
                                        {
                                            Code = "Success",
                                            Message = "Booking ID - " + Result[1].ToString() + " Successfully Generated."
                                        });
                                    }
                                    #endregion
                                }
                            }
                        }
                        else
                        {
                            actionResult = Ok(new
                            {
                                Code = "Error",
                                Message = "Error while executing the BookingInfo"
                            });
                        }
                    }
                }
                else
                {
                    actionResult = Ok(new
                    {
                        Code = "Error",
                        Message = "Booking Registration Information not found"
                    });
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok(new
                {
                    Code = "Error",
                    Message = "Error Occured"
                });
            }

            return actionResult;
        }



        /*
        /// <summary>
        /// This API will Update the Booking status from 
        /// </summary>
        /// <param name="pType"></param>
        /// <param name="objBookingstatus"></param>
        /// <returns></returns>
        [ResponseType(typeof(BookingModel))]
        [HttpPost]
        [Route("Api/Booking/PostBooking")]
        public IHttpActionResult PostBookings(string pType, BookingModel objBookingstatus)
        {
            long returnCode = -1;
            IHttpActionResult actionResult = null;

            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            List<BookingInfo> lstBooking = new List<BookingInfo>();
            List<Paymentdetail> lstPayment = new List<Paymentdetail>();
            List<BookingInfo> lstTest = new List<BookingInfo>();

            try
            {
                if (objBookingstatus != null)
                {
                    BookingInfo booking = new BookingInfo();
                    booking.BookingID = objBookingstatus.BookingID;
                    booking.FirstName = objBookingstatus.FirstName;
                    booking.MiddleName = objBookingstatus.MiddleName;
                    booking.LastName = objBookingstatus.LastName;
                    booking.Salutation = objBookingstatus.Salutation;
                    booking.Gender = objBookingstatus.Gender;
                    booking.Age = objBookingstatus.Age;
                    if (Convert.ToDateTime(objBookingstatus.DateofBirth).ToString("yyyy") == "0001")
                        booking.DateofBirth = DateTime.MaxValue;
                    else
                        booking.DateofBirth = objBookingstatus.DateofBirth;
                    booking.Email = objBookingstatus.Email;
                    booking.Address = objBookingstatus.Address;
                    booking.City = objBookingstatus.City;
                    booking.State = objBookingstatus.State;
                    booking.Country = objBookingstatus.Country;
                    booking.OrgID = objBookingstatus.OrgID;
                    booking.LocationID = objBookingstatus.LocationID;

                    if (Convert.ToDateTime(objBookingstatus.BookingDTTM).ToString("yyyy") == "0001")
                        booking.BookingDTTM = DateTime.MaxValue;
                    else
                        booking.BookingDTTM = objBookingstatus.BookingDTTM;
                    booking.MobileNumber = objBookingstatus.MobileNumber;
                    booking.PostalCode = objBookingstatus.PostalCode;
                    booking.ClientCode = objBookingstatus.ClientCode;
                    booking.URNNo = objBookingstatus.URNNo;
                    booking.URNType = objBookingstatus.URNType;
                    booking.TRFFile = objBookingstatus.TRFFile;
                    booking.DispatchType = objBookingstatus.DispatchType;
                    booking.SampleID = objBookingstatus.SampleID;
                    booking.SampleName = objBookingstatus.SampleName;
                    booking.Reason = objBookingstatus.Reason;
                    booking.TestName = objBookingstatus.TestName;
                    booking.CardDetails = objBookingstatus.CardDetails;
                    booking.Price = objBookingstatus.Price;
                    booking.NetAmount = objBookingstatus.NetAmount;
                    booking.DueAmount = objBookingstatus.DueAmount;
                    booking.UserID = objBookingstatus.UserID;
                    booking.PaymentMode = objBookingstatus.PaymentMode;
                    booking.ContainerID = objBookingstatus.ContainerID;
                    booking.ContainerName = objBookingstatus.ContainerName;
                    booking.SampleContainerColour = objBookingstatus.SampleContainerColour;
                    booking.ReceivedAmount = objBookingstatus.ReceivedAmount;
                    booking.FollowUpTest = objBookingstatus.FollowUpTest;

                    if (Convert.ToDateTime(objBookingstatus.FollowUpDTTM).ToString("yyyy") == "0001")
                        booking.FollowUpDTTM = DateTime.MaxValue;
                    else
                        booking.FollowUpDTTM = objBookingstatus.FollowUpDTTM;

                    if (Convert.ToDateTime(objBookingstatus.SampleCollectionTime).ToString("yyyy") == "0001")
                        booking.SampleCollectionTime = DateTime.MaxValue;
                    else
                        booking.SampleCollectionTime = objBookingstatus.SampleCollectionTime;

                    if (Convert.ToDateTime(booking.CollectionTime).ToString("yyyy") == "0001")
                        booking.CollectionTime = DateTime.MaxValue;

                    booking.SampleStatus = objBookingstatus.SampleStatus;
                    booking.TotalGrossAmount = objBookingstatus.TotalGrossAmount;
                    booking.DiscountAmount = objBookingstatus.DiscountAmount;
                    booking.ReferenceNo = objBookingstatus.ReferencNo;
                    booking.PaymentStatus = objBookingstatus.PaymentStatus;
                    booking.CreatedBy = objBookingstatus.CreatedBy;

                    if (Convert.ToDateTime(objBookingstatus.CreatedAt).ToString("yyyy") == "0001")
                        booking.CreatedAt = DateTime.MaxValue;
                    else
                        booking.CreatedAt = objBookingstatus.CreatedAt;

                    booking.ModifiedBy = objBookingstatus.ModifiedBy;
                    if (Convert.ToDateTime(objBookingstatus.ModifiedAt).ToString("yyyy") == "0001")
                        booking.ModifiedAt = DateTime.MaxValue;
                    else
                        booking.ModifiedAt = objBookingstatus.ModifiedAt;

                    lstBooking.Add(booking);

                    if (lstBooking != null)
                    {
                        returnCode = new LIMSAPI_BL().UpdateBookings(pOrgCode, pType, lstBooking, lstPayment, lstTest);

                        if (returnCode != -1 && returnCode != 1001)
                        {
                            actionResult = Ok("Following the BookingID : " + objBookingstatus.BookingID + " Successfully updated.");
                        }
                        else
                        {
                            actionResult = Ok("Error on while updating the Booking Status data");
                        }
                    }
                }
                else
                {
                    actionResult = Ok("Bookings Information data not found");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }
            return actionResult;
        }
      */


        /// <summary>
        /// This API returns the Bookings of HomeCollection for the given date
        ///If LoginID of particular Phelbo specified will return Bookings assigned to the particular Phelbo
        /// </summary>
        /// <param name="pBookingID"></param>
        /// <param name="pUserID"></param>
      
        /// <returns></returns>
        [ResponseType(typeof(PhleboBookingdetailsInfo))]
        [HttpGet]
        [Route("Api/Booking/GetPhleboBookingDetails")]
        public IHttpActionResult GetPhleboBookingDetails(int pBookingID, int pUserID)
        {
            long returnCode = -1;
            IHttpActionResult actionResult = null;

            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;
            long pOrgID = 0;
            long pLocationID = 0;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            List<BookingInfo> lstBookingInfo = new List<BookingInfo>();
            List<BookingInfo> lstCollection = new List<BookingInfo>();

            PhleboBookingdetailsInfo objBookinginfo = new PhleboBookingdetailsInfo();
            List<PhleboBookingDetails> lstbookings = new List<PhleboBookingDetails>();
            List<SampleDetails> lstsamples = null;
            SampleDetails objSampledetails = null;

            try
            {
                returnCode = new LIMSAPI_BL().GetPhleboBookingDetails(pBookingID, pUserID, pOrgCode, out lstBookingInfo, out lstCollection);

                if (returnCode != -1)
                {
                    if (lstBookingInfo.Count > 0 && lstBookingInfo != null)
                    {
                        for (int i = 0; i < lstBookingInfo.Count; i++)
                        {
                            pOrgID = lstBookingInfo[i].OrgID;
                            pLocationID = lstBookingInfo[i].LocationID;

                            if (lstBookingInfo[i].BookingID > 0 && lstBookingInfo[i].BookingID != 0)
                            {
                                lstsamples = new List<SampleDetails>();

                                //foreach (BookingInfo item in lstCollection)
                                //{
                                //    objSampledetails = new SampleDetails();

                                //    if (lstBookingInfo[i].BookingID == item.BookingID)
                                //    {
                                //        objSampledetails.SampleID = item.SampleID;
                                //        objSampledetails.SampleName = item.SampleName;
                                //        objSampledetails.ContainerID = item.ContainerID;
                                //        objSampledetails.ContainerName = item.ContainerName;
                                //        objSampledetails.SampleContainerColour = item.SampleContainerColour;
                                //        objSampledetails.TestCode = item.TestCode;
                                //        objSampledetails.Price = item.Price;

                                //        lstsamples.Add(objSampledetails);
                                //    }
                                //}

                                lstbookings.Add(new PhleboBookingDetails()
                                {
                                    BookingID = lstBookingInfo[i].BookingID,
                                    Salutation = lstBookingInfo[i].Salutation,
                                    Name = lstBookingInfo[i].Name,
                                    Gender = lstBookingInfo[i].Gender,
                                    Age = lstBookingInfo[i].Age,
                                    DateofBirth = lstBookingInfo[i].DateofBirth,
                                    Address = lstBookingInfo[i].Address,
                                    City = lstBookingInfo[i].City,
                                    State = lstBookingInfo[i].State,
                                    Country = lstBookingInfo[i].Country,
                                    PinCode = lstBookingInfo[i].PostalCode,
                                    MobileNumber = lstBookingInfo[i].MobileNumber,
                                    EmailID = lstBookingInfo[i].Email,
                                    ClientCode = lstBookingInfo[i].ClientCode,
                                    SampleCollectionTime = lstBookingInfo[i].SampleCollectionTime,
                                    DispatchType = lstBookingInfo[i].DispatchType,
                                    TotalAmount = lstBookingInfo[i].TotalGrossAmount,
                                    DiscountID = lstBookingInfo[i].DiscountID,
                                    DiscountAmount = lstBookingInfo[i].DiscountAmount,
                                    DueAmount = lstBookingInfo[i].DueAmount,
                                    PaymentStatus = lstBookingInfo[i].PaymentStatus,
                                    Status = lstBookingInfo[i].Status,
                                    InventoryCount = lstBookingInfo[i].InventoryCount,
                                    LoginID = lstBookingInfo[i].UserID
                                  //  CollectionInfo = lstsamples
                                });
                            }
                        }

                        objBookinginfo.OrgCode = pOrgCode;
                        objBookinginfo.Type = "PhleboBookingsInformation";
                        objBookinginfo.OrgID = pOrgID;
                        objBookinginfo.LocationID = pLocationID;
                        objBookinginfo.BookingInfo = lstbookings;
                        actionResult = Ok(objBookinginfo);
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
        /// This API returns the Bookings of HomeCollection for the given date
        ///If LoginID of particular Phelbo specified will return Bookings assigned to the particular Phelbo
        /// </summary>
        /// <param name="pUserID"></param>
        /// <param name="pDateRange"></param>
        /// <returns></returns>
        [ResponseType(typeof(BookingsdataInfo))]
        [HttpGet]
        [Route("Api/Booking/GetBookingswithSamples")]
        public IHttpActionResult GetBookings(int pUserID, DateTime pDateRange)
        {
            long returnCode = -1;
            IHttpActionResult actionResult = null;

            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;
            long pOrgID = 0;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            List<BookingInfo> lstBookingInfo = new List<BookingInfo>();
            List<SampleDataInfo> lstOrders = new List<SampleDataInfo>();
            List<SampleDataInfo> lstSamples = new List<SampleDataInfo>();

            BookingsdataInfo objBookinginfo = new BookingsdataInfo();
            List<BookingsData> lstbookings = new List<BookingsData>();

            try
            {
                returnCode = new LIMSAPI_BL().GetBookingsData(pUserID, pDateRange, pOrgCode, out lstBookingInfo, out lstOrders, out lstSamples);

                if (returnCode != -1)
                {
                    if (lstBookingInfo.Count > 0 && lstBookingInfo != null)
                    {
                        for (int i = 0; i < lstBookingInfo.Count; i++)
                        {
                            pOrgID = lstBookingInfo[i].OrgID;

                            if (lstBookingInfo[i].BookingID > 0 && lstBookingInfo[i].BookingID != 0)
                            {
                                List<OrdersData> lstOrder = new List<OrdersData>();
                                List<TestContentData> lstTestContent = null;
                                List <SampleData> lstSample = new List<SampleData>();
                                List<SampleContentData> lstSampleContent = null;


                                var lstTests = lstOrders.Where(l => l.BookingID == lstBookingInfo[i].BookingID)
                                              .GroupBy( x => new { x.InvestigationID })
                                              .Select(y => y.First()).ToList();
                                var lstOrdContent = lstOrders.Where(l => l.BookingID == lstBookingInfo[i].BookingID).ToList();


                                if (lstOrders.Count > 0 && lstOrders != null)
                                {
                                    foreach (var Orders in lstTests)
                                    {
                                        if (lstBookingInfo[i].BookingID == Orders.BookingID)
                                        {
                                            #region Orders Content
                                            int counts = lstOrders.Where(l => l.BookingID == lstBookingInfo[i].BookingID
                                                            && l.InvestigationCode == Orders.InvestigationCode).Count();

                                            var lstcontent = lstOrdContent.FindAll(p => p.InvestigationID == Orders.InvestigationID);

                                            lstTestContent = new List<TestContentData>();
                                            foreach (var TestCont in lstcontent)
                                            {
                                                if (Orders.InvestigationID == TestCont.InvestigationID && Orders.OrderType != "INV")
                                                {
                                                    lstTestContent.Add(new TestContentData()
                                                    {
                                                        TestID = TestCont.TestID,
                                                        TestCode = TestCont.TestCode,
                                                        TestName = TestCont.TestName,
                                                        Type = TestCont.TestType
                                                    });
                                                }
                                            }
                                            #endregion

                                            decimal Price;
                                            switch (Orders.OrderType)
                                            {
                                                case "GRP":
                                                    Price = Orders.GRPPrice;
                                                    break;
                                                case "PKG":
                                                    Price = Orders.PKGPrice;
                                                    break;
                                                default:
                                                    Price = Orders.Price;
                                                    break;
                                            }

                                            #region Orders
                                            if (lstBookingInfo[i].BookingID == Orders.BookingID)
                                            {
                                                lstOrder.Add(new OrdersData()
                                                {
                                                    TestName = Orders.InvestigationName,
                                                    TestID = Orders.InvestigationID,
                                                    TestType = Orders.OrderType,
                                                    TestCode = Orders.InvestigationCode,
                                                    Price = Price,
                                                    TestContentInfoList = lstTestContent
                                                });
                                            }
                                            #endregion
                                        }
                                    }

                                    if (lstSamples.Count > 0 && lstSamples != null)
                                    {
                                        var lstsamplegrp = lstSamples.Where(p => p.BookingID == lstBookingInfo[i].BookingID)
                                                         .GroupBy(q => new { q.SampleID, q.SampleContainerID })
                                                         .Select(grp => grp.First()).ToList();

                                        foreach (var sampleCont in lstsamplegrp)
                                        {
                                            #region Samples Content
                                            var lstsampleTest = lstSamples.Where(p => p.BookingID == lstBookingInfo[i].BookingID &&
                                                                                  p.SampleID == sampleCont.SampleID &&
                                                                                  p.SampleContainerID == sampleCont.SampleContainerID).ToList();

                                            lstSampleContent = new List<SampleContentData>();
                                            foreach (var sampleCon in lstsampleTest)
                                            {
                                                lstSampleContent.Add(new SampleContentData()
                                                {
                                                    TestCode = sampleCon.TestCode,
                                                    TestName = sampleCon.TestName,
                                                    TestType = sampleCon.Type
                                                });
                                            }
                                            #endregion

                                            #region Samples 
                                            lstSample.Add(new SampleData()
                                            {
                                                SampleID = sampleCont.SampleID,
                                                SampleName = sampleCont.SampleName,
                                                ContainerID = sampleCont.SampleContainerID,
                                                ContainerName = sampleCont.ContainerName,
                                                SampleContainerColour = sampleCont.SampleContainerColour,
                                                TestInfoList = lstSampleContent
                                            });
                                            #endregion
                                        }

                                    }
                                }

                                lstbookings.Add(new BookingsData()
                                {
                                    BookingID = lstBookingInfo[i].BookingID,
                                    LocationID = lstBookingInfo[i].LocationID,
                                    Salutation = lstBookingInfo[i].Salutation,
                                    Name = lstBookingInfo[i].Name,
                                    Gender = lstBookingInfo[i].Gender,
                                    Age = lstBookingInfo[i].Age,
                                    DateofBirth = lstBookingInfo[i].DateofBirth,
                                    Address = lstBookingInfo[i].Address,
                                    City = lstBookingInfo[i].City,
                                    State = lstBookingInfo[i].State,
                                    Country = lstBookingInfo[i].Country,
                                    PinCode = lstBookingInfo[i].PostalCode,
                                    MobileNumber = lstBookingInfo[i].MobileNumber,
                                    EmailID = lstBookingInfo[i].Email,
                                    ClientCode = lstBookingInfo[i].ClientCode,
                                    SampleCollectionTime = lstBookingInfo[i].SampleCollectionTime,
                                    DispatchType = lstBookingInfo[i].DispatchType,
                                    TotalAmount = lstBookingInfo[i].TotalGrossAmount,
                                    DiscountID = lstBookingInfo[i].DiscountID,
                                    DiscountAmount = lstBookingInfo[i].DiscountAmount,
                                    DueAmount = lstBookingInfo[i].DueAmount,
                                    PaymentStatus = lstBookingInfo[i].PaymentStatus,
                                    Status = lstBookingInfo[i].Status,
                                    Comments = lstBookingInfo[i].Comments,
                                    InventoryCount = lstBookingInfo[i].InventoryCount,
                                    LoginID = lstBookingInfo[i].UserID,
                                    IsCreaditBill = lstBookingInfo[i].ISProcessed, // IsCreaditBill flag
                                    OrderInfoList = lstOrder,
                                    SampleCollectionInfo = lstSample
                                });
                            }
                        }

                        objBookinginfo.OrgCode = pOrgCode;
                        objBookinginfo.Type = "BookingsInformation";
                        objBookinginfo.OrgID = pOrgID;
                        objBookinginfo.BookingInfo = lstbookings;
                        actionResult = Ok(objBookinginfo);
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
        /// This API will update the Home Collection Booking completion
        /// It will also update Amount received by the phelbo along with additional test which is ordered by phelbo
        /// </summary>
        /// <param name="objBookingstatus">Sample Collection and Payment Information JSON</param>
        /// <returns></returns>
        [ResponseType(typeof(PostHCBookingCompModel))]
        [HttpPost]
        [Route("Api/Booking/PostHCBookingwithSample")]
        public IHttpActionResult PostHCBookingsWithSample(PostHCBookingCompModel objBookingstatus)
        {
            long returnCode = -1;
            IHttpActionResult actionResult = null;

            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            List<BookingInfo> lstBooking = new List<BookingInfo>();
            List<Paymentdetail> lstPayment = new List<Paymentdetail>();
            List<BookingInfo> lstTest = new List<BookingInfo>();
            List<BookingInfo> lstTestSample = new List<BookingInfo>();
            BookingInfo objBooking = null;
            Paymentdetail objPayment = null;
            BookingInfo objTest = null;
            BookingInfo objAddTest = null;
            BookingInfo objTestSample = null;

            try
            {
                if (objBookingstatus != null)
                {
                    string pType = objBookingstatus.TransType;

                    objBooking = new BookingInfo();
                    objBooking.LoginID = objBookingstatus.LoginID;

                    #region BookingInfo 
                    if (objBookingstatus.BookingInfo != null)
                    {
                        objBooking.OrgID = objBookingstatus.BookingInfo.OrgID;
                        objBooking.LocationID = objBookingstatus.BookingInfo.LocationID;
                        objBooking.BookingID = objBookingstatus.BookingInfo.BookingID;

                        if (Convert.ToDateTime(objBookingstatus.BookingInfo.BookingDTTM).ToString("yyyy") != "0001")
                            objBooking.BookingDTTM = objBookingstatus.BookingInfo.BookingDTTM;

                        if (Convert.ToDateTime(objBookingstatus.BookingInfo.CollectionTime).ToString("yyyy") != "0001")
                            objBooking.CollectionTime = objBookingstatus.BookingInfo.CollectionTime;

                        objBooking.DispatchType = objBookingstatus.BookingInfo.DispatchType;
                        objBooking.TRFFile = objBookingstatus.BookingInfo.TRFFile;
                        objBooking.Status = objBookingstatus.BookingInfo.Status;
                        objBooking.OrgCode = objBookingstatus.BookingInfo.OrgCode;
                        objBooking.LocationCode = objBookingstatus.BookingInfo.LocationCode;
                        objBooking.Reason = objBookingstatus.BookingInfo.Reason;
                        objBooking.PaymentStatus = objBookingstatus.BookingInfo.PaymentStatus;
                    }
                    #endregion

                    #region PatientInfo   
                    if (objBookingstatus.PatientInfo != null)
                    {
                        objBooking.PatientID = objBookingstatus.PatientInfo.PatientID;
                        objBooking.Salutation = objBookingstatus.PatientInfo.Salutation;
                        objBooking.ExternalPatientNumber = objBookingstatus.PatientInfo.ExternalPatientNumber;
                        objBooking.FirstName = objBookingstatus.PatientInfo.FirstName;
                        objBooking.MiddleName = objBookingstatus.PatientInfo.MiddleName;
                        objBooking.LastName = objBookingstatus.PatientInfo.LastName;
                        objBooking.Gender = objBookingstatus.PatientInfo.Gender;
                        objBooking.Age = objBookingstatus.PatientInfo.Age;

                        if (Convert.ToDateTime(objBookingstatus.PatientInfo.DOB).ToString("yyyy") != "0001")
                            objBooking.DateofBirth = objBookingstatus.PatientInfo.DOB;

                        objBooking.MobileNumber = objBookingstatus.PatientInfo.MobileNumber;
                        objBooking.Email = objBookingstatus.PatientInfo.EmailID;
                        objBooking.URNNo = objBookingstatus.PatientInfo.URNNumber;
                        objBooking.URNType = objBookingstatus.PatientInfo.URNType;
                        objBooking.EmployeeID = objBookingstatus.PatientInfo.EmployeeID;

                        if (objBookingstatus.PatientInfo.AddressDetails != null)
                        {
                            foreach (HCAddressModel item in objBookingstatus.PatientInfo.AddressDetails)
                            {
                                objBooking.AddressType = item.AddressType;
                                objBooking.Address = item.Address;
                                objBooking.City = item.City;
                                objBooking.State = item.State;
                                objBooking.Country = item.Country;
                                objBooking.PostalCode = Convert.ToString(item.PostalCode);
                            }
                        }
                    }
                    #endregion

                    #region PaymentInfo   
                    if (objBookingstatus.PaymentInfoList != null)
                    {
                        foreach (PaymentModel item in objBookingstatus.PaymentInfoList)
                        {
                            objPayment = new Paymentdetail();
                            objPayment.BookingID = objBookingstatus.BookingInfo == null ? 0 : objBookingstatus.BookingInfo.BookingID;
                            objPayment.PaymentMode = item.PaymentMode;
                            objPayment.CurrencyType = item.CurrencyType;
                            objPayment.ChequeorCardNumber = Convert.ToString(item.CardNumber);
                            objPayment.CardHolderName = item.CardHolderName;
                            objPayment.TransactionID = item.TransactionID;
                            objPayment.ReceivedAmount = item.ReceivedAmount;
                            objPayment.OrgID = objBookingstatus.BookingInfo == null ? 0 : objBookingstatus.BookingInfo.OrgID;
                            objPayment.CreatedBy = objBookingstatus.LoginID;
                            lstPayment.Add(objPayment);
                        }
                    }
                    #endregion

                    #region TestInfo   
                    if (objBookingstatus.TestInfoList != null)
                    {
                        foreach (OrderItemModel item in objBookingstatus.TestInfoList)
                        {
                            objTest = new BookingInfo();
                            objTest.BookingID = objBookingstatus.BookingInfo == null ? 0 : objBookingstatus.BookingInfo.BookingID;
                            objTest.OrderedFrom = item.OrderedFrom;
                            objTest.TestCode = item.TestCode;
                            objTest.Type = item.Type;
                            objTest.Price = item.Price;
                            objTest.Status = item.Status;
                            objTest.OrgID = objBookingstatus.BookingInfo == null ? 0 : objBookingstatus.BookingInfo.OrgID;
                            objTest.LoginID = objBookingstatus.LoginID;
                            objTest.Remarks = ""; //Ordered Test
                            lstTest.Add(objTest);
                        }
                    }
                    #endregion

                    #region Additional TestInfo   
                    if (objBookingstatus.AddTestInfoList != null)
                    {
                        foreach (AddOrderItemModel item in objBookingstatus.AddTestInfoList)
                        {
                            objAddTest = new BookingInfo();
                            objAddTest.BookingID = objBookingstatus.BookingInfo == null ? 0 : objBookingstatus.BookingInfo.BookingID;
                            objAddTest.OrderedFrom = item.OrderedFrom;
                            objAddTest.TestCode = item.TestCode;
                            objAddTest.Type = item.Type;
                            objAddTest.Price = item.Price;
                            objAddTest.Status = item.Status;
                            objAddTest.OrgID = objBookingstatus.BookingInfo == null ? 0 : objBookingstatus.BookingInfo.OrgID;
                            objAddTest.LoginID = objBookingstatus.LoginID;
                            objAddTest.Remarks = "Y"; //Additional Ordered Test
                            lstTest.Add(objAddTest);
                        }
                    }
                    #endregion

                    #region SamplesInfo   
                    if (objBookingstatus.SampleInfoList != null)
                    {
                        foreach (SampleModel item in objBookingstatus.SampleInfoList)
                        {
                            objTestSample = new BookingInfo();
                            objTestSample.BookingID = objBookingstatus.BookingInfo == null ? 0 : objBookingstatus.BookingInfo.BookingID;
                            objTestSample.SampleID = item.SampleID;
                            objTestSample.SampleName = item.SampleName;
                            objTestSample.SampleContainerColour = item.SampleContainerColour;
                            objTestSample.ContainerID = item.ContainerID;
                            objTestSample.ContainerName = item.ContainerName;
                            objTestSample.SampleStatus = item.CollectionStatus;
                            if (Convert.ToDateTime(item.SampleCollectedTime).ToString("yyyy") != "0001")
                                objTestSample.SampleCollectionTime = item.SampleCollectedTime;
                            objTestSample.BarcodeNo = item.BarcodeNo;
                            objTestSample.OrgID = objBookingstatus.BookingInfo == null ? 0 : objBookingstatus.BookingInfo.OrgID;
                            objTestSample.LocationID = objBookingstatus.BookingInfo == null ? 0 : objBookingstatus.BookingInfo.LocationID;
                            objTestSample.LoginID = objBookingstatus.LoginID;
                            objTestSample.Remarks = item.IsNewSampleYN;
                            objTestSample.Reason = item.Reason;
                            lstTestSample.Add(objTestSample);
                        }
                    }
                    #endregion

                    objBooking.JsonValue = JsonConvert.SerializeObject(objBookingstatus);
                    lstBooking.Add(objBooking);

                    if (lstBooking != null)
                    {
                        returnCode = new LIMSAPI_BL().UpdateBookingwithSample(pOrgCode, pType, lstBooking, lstPayment, lstTest, lstTestSample);

                        if (returnCode != -1 && returnCode != 1001)
                        {
                            actionResult = Ok("Home Collection with Sample details successfully inserted.");
                        }
                        else
                        {
                            actionResult = Ok("Error on while inserting the Home Collection with Sample details");
                        }
                    }
                }
                else
                {
                    actionResult = Ok("Home Collecion with Sample Information details not found");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }

            return actionResult;
        }


        /// <summary>
        ///  This API will provide functionality to the New Bookings done outside AttuneLIMS  
        /// </summary>
        /// <param name="objBookingInfo">Bookings JSON with Patient, Booking, Ordered Test and Sample Details </param>
        /// <returns></returns>
        [ResponseType(typeof(PostNewBookingwithSample))]
        [Route("Api/Booking/PostNewBookingwithSample")]
        [HttpPost]
        public IHttpActionResult PostNewBookingwithSample(PostNewBookingwithSample objBookingInfo)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            long returnCode = -1;
            long returncode = -1;
            var pOutstring = string.Empty;
            IHttpActionResult actionResult = null;

            List<BookingInfo> lstBooking = new List<BookingInfo>();
            List<Paymentdetail> lstPayment = new List<Paymentdetail>();
            List<BookingInfo> lstOrders = new List<BookingInfo>();
            List<BookingInfo> lstOrderSamples = new List<BookingInfo>();
            BookingInfo objBooking = null;
            Paymentdetail objPayment = null;
            BookingInfo objOrder = null;
            BookingInfo objOrderSample = null;

            try
            {
                if (objBookingInfo != null)
                {
                    string pType = objBookingInfo.TransType;
                    objBooking = new BookingInfo();
                    objBooking.LoginID = objBookingInfo.LoginID;

                    #region BookingInfo 
                    if (objBookingInfo.BookingInfo != null)
                    {
                        objBooking.OrgID = objBookingInfo.BookingInfo.OrgID;
                        objBooking.LocationID = objBookingInfo.BookingInfo.LocationID;
                        objBooking.ExternalRefNo = objBookingInfo.BookingInfo.ExternalRefNo;

                        if (Convert.ToDateTime(objBookingInfo.BookingInfo.BookingDTTM).ToString("yyyy") != "0001")
                            objBooking.BookingDTTM = objBookingInfo.BookingInfo.BookingDTTM;

                        if (Convert.ToDateTime(objBookingInfo.BookingInfo.CollectionTime).ToString("yyyy") != "0001")
                            objBooking.CollectionTime = objBookingInfo.BookingInfo.CollectionTime;

                        objBooking.DispatchType = objBookingInfo.BookingInfo.DispatchType;
                        objBooking.Status = objBookingInfo.BookingInfo.Status;
                        objBooking.ClientID = Convert.ToString(objBookingInfo.BookingInfo.ClientID);
                        objBooking.ClientCode = objBookingInfo.BookingInfo.ClientCode;
                        objBooking.TotalGrossAmount = objBookingInfo.BookingInfo.GrossAmount;
                        objBooking.DiscountAmount = objBookingInfo.BookingInfo.DiscountAmount;
                        objBooking.NetAmount = objBookingInfo.BookingInfo.NetAmount;
                        objBooking.DiscountID = objBookingInfo.BookingInfo.DiscountID;
                        objBooking.PaymentStatus = objBookingInfo.BookingInfo.PaymentStatus;
                        objBooking.OrgCode = objBookingInfo.BookingInfo.OrgCode;
                        objBooking.LocationCode = objBookingInfo.BookingInfo.LocationCode;
                        objBooking.BookingRemarks = objBookingInfo.BookingInfo.Remarks;
                        objBooking.ISProcessed = objBookingInfo.BookingInfo.IsCreaditBill;
                    }
                    #endregion

                    #region Patient
                    if (objBookingInfo.PatientInfo != null)
                    {
                        objBooking.Name = objBookingInfo.PatientInfo.Name;
                        objBooking.FirstName = objBookingInfo.PatientInfo.FirstName;
                        objBooking.MiddleName = objBookingInfo.PatientInfo.MiddleName;
                        objBooking.LastName = objBookingInfo.PatientInfo.LastName;
                        objBooking.Salutation = objBookingInfo.PatientInfo.Salutation;
                        objBooking.Age = objBookingInfo.PatientInfo.Age;
                        objBooking.Gender = objBookingInfo.PatientInfo.Gender;

                        if (Convert.ToDateTime(objBookingInfo.PatientInfo.DOB).ToString("yyyy") != "0001")
                            objBooking.DateofBirth = objBookingInfo.PatientInfo.DOB;

                        objBooking.MobileNumber = objBookingInfo.PatientInfo.MobileNumber;
                        objBooking.Email = objBookingInfo.PatientInfo.Email;
                        objBooking.URNType = objBookingInfo.PatientInfo.URNType;
                        objBooking.URNNo = objBookingInfo.PatientInfo.URNNumber;
                        objBooking.ExternalPatientNumber = objBookingInfo.PatientInfo.ExternalPatientNo;
                        objBooking.ExternalPatientRefNo = objBookingInfo.PatientInfo.HealthHubID;
                        objBooking.EmployeeID = objBookingInfo.PatientInfo.EmployeeID;

                        if (objBookingInfo.PatientInfo.AddressDetails != null)
                        {
                            foreach (AddressModel item in objBookingInfo.PatientInfo.AddressDetails)
                            {
                                objBooking.AddressType = item.AddressType;
                                objBooking.Address = item.Address;
                                objBooking.City = item.City;
                                objBooking.State = item.State;
                                objBooking.Country = item.Country;
                                objBooking.PostalCode = Convert.ToString(item.PostalCode);
                            }
                        }
                    }
                    #endregion

                    #region PaymentInfo   
                    if (objBookingInfo.PaymentInfoList != null)
                    {
                        foreach (PaymentModel item in objBookingInfo.PaymentInfoList)
                        {
                            objPayment = new Paymentdetail();
                            objPayment.ExternalRefNo = objBookingInfo.BookingInfo == null ? "" : objBookingInfo.BookingInfo.ExternalRefNo;
                            objPayment.PaymentMode = item.PaymentMode;
                            objPayment.CurrencyType = item.CurrencyType;
                            objPayment.ChequeorCardNumber = Convert.ToString(item.CardNumber);
                            objPayment.CardHolderName = item.CardHolderName;
                            objPayment.TransactionID = item.TransactionID;
                            objPayment.ReceivedAmount = item.ReceivedAmount;
                            objPayment.OrgID = objBookingInfo.BookingInfo == null ? 0 : objBookingInfo.BookingInfo.OrgID;
                            objPayment.CreatedBy = objBookingInfo.LoginID;
                            lstPayment.Add(objPayment);
                        }
                    }
                    #endregion

                    #region Orders   
                    if (objBookingInfo.TestInfoList != null)
                    {
                        foreach (OrderItemModel item in objBookingInfo.TestInfoList)
                        {
                            objOrder = new BookingInfo();
                            objOrder.ExternalRefNo = objBookingInfo.BookingInfo == null ? "" : objBookingInfo.BookingInfo.ExternalRefNo;
                            objOrder.OrderedFrom = item.OrderedFrom;
                            objOrder.TestCode = item.TestCode;
                            objOrder.Type = item.Type;
                            objOrder.Price = item.Price;
                            objOrder.Status = item.Status;
                            objOrder.OrgID = objBookingInfo.BookingInfo == null ? 0 : objBookingInfo.BookingInfo.OrgID;
                            objOrder.LoginID = objBookingInfo.LoginID;
                            lstOrders.Add(objOrder);
                        }
                    }
                    #endregion

                    #region Samples   
                    if (objBookingInfo.SampleInfoList != null)
                    {
                        foreach (SampleModel item in objBookingInfo.SampleInfoList)
                        {
                            objOrderSample = new BookingInfo();
                            objOrderSample.ExternalRefNo = objBookingInfo.BookingInfo == null ? "" : objBookingInfo.BookingInfo.ExternalRefNo;
                            objOrderSample.SampleID = item.SampleID;
                            objOrderSample.SampleName = item.SampleName;
                            objOrderSample.ContainerID = item.ContainerID;
                            objOrderSample.ContainerName = item.ContainerName;
                            objOrderSample.SampleContainerColour = item.SampleContainerColour;
                            objOrderSample.SampleStatus = item.CollectionStatus;
                            objOrderSample.BarcodeNo = item.BarcodeNo;
                            if (Convert.ToDateTime(item.SampleCollectedTime).ToString("yyyy") != "0001")
                                objOrderSample.SampleCollectionTime = item.SampleCollectedTime;
                            objOrderSample.Remarks = item.IsNewSampleYN;
                            objOrderSample.Reason = item.Reason;
                            objOrderSample.OrgID = objBookingInfo.BookingInfo == null ? 0 : objBookingInfo.BookingInfo.OrgID;
                            objOrderSample.LocationID = objBookingInfo.BookingInfo == null ? 0 : objBookingInfo.BookingInfo.LocationID;
                            lstOrderSamples.Add(objOrderSample);
                        }
                    }
                    #endregion

                    objBooking.SourceType = objBookingInfo.SourceType;
                    objBooking.JsonValue = JsonConvert.SerializeObject(objBookingInfo);
                    lstBooking.Add(objBooking);

                    if (lstBooking != null)
                    {
                        returnCode = new LIMSAPI_BL().InsertBookingwithSample(pOrgCode, pType, lstBooking, lstPayment, lstOrders, lstOrderSamples, out pOutstring);

                        if (returnCode != -1 && returnCode != 1001)
                        {
                            string[] Result = pOutstring.Split('|');

                            if (Result[0].ToString().ToUpper() == "M")
                            {
                                actionResult = Ok(new
                                {
                                    Code = "Error",
                                    Message = Result[1].ToString()
                                });
                            }
                            else
                            {
                                if (Result[0].ToString().ToUpper() == "Y")
                                {
                                    actionResult = Ok(new
                                    {
                                        Code = "Success",
                                        Message = "Following the External RefNo - " + Result[1].ToString() + " already available."
                                    });
                                }
                                else
                                {
                                    #region TRF file process 
                                    if (objBookingInfo.BookingInfo.TRFFile != "" && objBookingInfo.BookingInfo.TRFFile != null)
                                    {
                                        var obj = new ImageConvertor();
                                        UploadBookingImageModel objimg = new UploadBookingImageModel();

                                        objimg.ImageData = objBookingInfo.BookingInfo.TRFFile;
                                        List<Config> lstConfig = new List<Config>();

                                        byte[] byteArray = Convert.FromBase64String(objimg.ImageData);

                                        var imageDataStream = new MemoryStream(byteArray);
                                        imageDataStream.Position = 0;

                                        Image returnImage = Image.FromStream(imageDataStream);
                                        returncode = new LIMSAPI_BL().GetConfigHCDetails(pOrgCode, "TRF_UploadPath", out lstConfig);
                                        string pathname = lstConfig[0].ConfigValue.ToString();

                                        DateTime dt = DateTime.Now;
                                        int Year = dt.Year;
                                        int Month = dt.Month;
                                        int Day = dt.Day;

                                        String Root = String.Empty;
                                        String RootPath = String.Empty;

                                        Root = "TRF_Upload-" + lstConfig[0].OrgID + "-" + Year + "-" + Month + "-" + Day + "-" + "Home_Collection" + "-";
                                        Root = Root.Replace("-", "\\\\");
                                        RootPath = pathname + Root;

                                        System.Drawing.Image imageIn = obj.ConvertByteArrayToImage(byteArray);

                                        //Check if directory exist
                                        if (!System.IO.Directory.Exists(RootPath))
                                        {
                                            System.IO.Directory.CreateDirectory(RootPath); //Create directory if it doesn't exist
                                        }
                                        string imageName = objBookingInfo.BookingInfo.ExternalRefNo + ".png";

                                        //set the image path
                                        string imgPath = Path.Combine(RootPath, imageName);

                                        string Type = "TRF_Upload_APKNew_Home_Collection";

                                        File.WriteAllBytes(imgPath, byteArray);

                                        returnCode = new LIMSAPI_BL().SaveTRFHCDetails(pOrgCode, imageName, Convert.ToInt64(Result[1]), objBookingInfo.BookingInfo.ExternalRefNo, Convert.ToInt64(Result[1]), Type, objBookingInfo.SourceType, RootPath);

                                        if (returnCode != -1 && returnCode != 1001)
                                        {
                                            actionResult = Ok(new
                                            {
                                                Code = "Success",
                                                Message = "Booking ID - " + Result[1].ToString() + " Successfully Generated and TRF file moved in path."
                                            });
                                        }
                                        else
                                        {
                                            actionResult = Ok(new
                                            {
                                                Code = "Success",
                                                Message = "Booking ID - " + Result[1].ToString() + " Successfully Generated and TRF file unable to processed."
                                            });
                                        }
                                    }
                                    else
                                    {
                                        actionResult = Ok(new
                                        {
                                            Code = "Success",
                                            Message = "Booking ID - " + Result[1].ToString() + " Successfully Generated."
                                        });
                                    }
                                    #endregion
                                }
                            }
                        }
                        else
                        {
                            actionResult = Ok(new
                            {
                                Code = "Error",
                                Message = "Error while executing the BookingInfo"
                            });
                        }
                    }
                }
                else
                {
                    actionResult = Ok(new
                    {
                        Code = "Error",
                        Message = "Booking Registration Information not found"
                    });
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok(new
                {
                    Code = "Error",
                    Message = "Error Occured"
                });
            }

            return actionResult;
        }



    }
}
