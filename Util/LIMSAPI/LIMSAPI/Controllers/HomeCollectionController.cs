using Attune.KernelV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LIMSAPI.Utility;
using System.Web.Http.Description;
using Attune.Kernel.LIMSAPI.BusinessEntities;
using LIMSAPI.Models;
using Attune.Kernel.LIMSAPI.BL;
using Attune.KernelV2.Utilities;
using Attune.Kernel.LIMSAPI.BusinessEntities;


namespace LIMSAPI.Controllers
{
    public class HomeCollectionController : BaseApiController
    {



        #region Declaration 
        // HomeCollection_BL objHCBooking;
        #endregion

        #region PostStockReceivedItems
        /// <summary>
        /// This API method will be using Home Collection Details for the Client to Attune. 
        /// </summary>
        /// <param name="objHCBooking"></param> HCBookingModel to be Json type
        /// <returns>success</returns>
        [ResponseType(typeof(HCBookingModel))]
        [Route("Api/HomeCollection/PostHCBooking")]
        [HttpPost]
        public IHttpActionResult PostHCBookings(HCBookingModel objHCBooking)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;

            string pOrgCode = string.Empty;
            string GRNno = string.Empty;
            List<Bookings> lstBookings = new List<Bookings>();
            List<OrderedInvestigations> lstOrdInv = new List<OrderedInvestigations>();
            List<OrderedInvestigations> lstPreOrderInv = new List<OrderedInvestigations>();
            List<ContextDetails> lstContextDet = new List<ContextDetails>();
            Bookings oBookings = null;
            OrderedInvestigations oOrderInv = null;
            OrderedInvestigations oPreOrdInv = null;
            ContextDetails oContextDet = null;
            IHttpActionResult actionResult = null;
            long bookingID = -1;
            long returnCode = -1;



            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }
            try
            {
                if (string.IsNullOrEmpty(pOrgCode))
                {

                    return Content(HttpStatusCode.NotAcceptable, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.NotAcceptable, Message = "Request Parameters Value Missing ( OrgCode )  ", Status = "Failure" });
                }
                if (objHCBooking != null)
                {
                    oBookings = new Bookings();
                    #region BookingInfo 
                    if (objHCBooking.BookingsInfo != null)
                    {
                        oBookings.BookingID = objHCBooking.BookingsInfo.BookingID;
                        oBookings.TokenNumber = objHCBooking.BookingsInfo.TokenNumber;
                        oBookings.CreatedBy = objHCBooking.BookingsInfo.CreatedBy;
                        oBookings.OrgID = objHCBooking.BookingsInfo.OrgID;
                        oBookings.CreatedAt = objHCBooking.BookingsInfo.CreatedAt;
                        oBookings.PatientName = objHCBooking.BookingsInfo.PatientName.ToUpper();
                        oBookings.Sex = objHCBooking.BookingsInfo.Sex;

                        oBookings.Age = objHCBooking.BookingsInfo.Age;

                        if (Convert.ToDateTime(objHCBooking.BookingsInfo.DOB).ToString("yyyy") != "0001")
                            oBookings.DOB = objHCBooking.BookingsInfo.DOB;

                        oBookings.PhoneNumber = objHCBooking.BookingsInfo.PhoneNumber;
                        oBookings.LandLineNumber = objHCBooking.BookingsInfo.LandLineNumber;
                        oBookings.FeeType = objHCBooking.BookingsInfo.FeeType;
                        oBookings.SourceType = objHCBooking.BookingsInfo.SourceType;


                        oBookings.ClientID = objHCBooking.BookingsInfo.ClientID;




                        oBookings.NRICNumber = objHCBooking.BookingsInfo.NRICNumber; //General RateID for HomeCollection

                        oBookings.PatientID = objHCBooking.BookingsInfo.PatientID;
                        oBookings.OrgAddressID = objHCBooking.BookingsInfo.OrgAddressID;
                        oBookings.OtherOrgID = objHCBooking.BookingsInfo.OtherOrgID;
                        oBookings.CollectionAddress = objHCBooking.BookingsInfo.CollectionAddress;
                        oBookings.RoleID = objHCBooking.BookingsInfo.RoleID;
                        oBookings.UserID = objHCBooking.BookingsInfo.UserID;
                        oBookings.CollectionTime = objHCBooking.BookingsInfo.CollectionTime;
                        oBookings.BookingOrgID = objHCBooking.BookingsInfo.BookingOrgID;
                        oBookings.BookingStatus = objHCBooking.BookingsInfo.BookingStatus;
                        oBookings.CollectionAddress2 = objHCBooking.BookingsInfo.CollectionAddress2;
                        oBookings.City = objHCBooking.BookingsInfo.City;
                        oBookings.PatientNumber = objHCBooking.BookingsInfo.PatientNumber;
                        oBookings.Priority = objHCBooking.BookingsInfo.Priority;
                        oBookings.BillDescription = objHCBooking.BookingsInfo.BillDescription;
                        oBookings.State = objHCBooking.BookingsInfo.State;
                        oBookings.Pincode = objHCBooking.BookingsInfo.Pincode;
                        oBookings.TITLECode = objHCBooking.BookingsInfo.TITLECode;

                        oBookings.DispatchValue = objHCBooking.BookingsInfo.DispatchValue;
                        oBookings.URNTypeID = objHCBooking.BookingsInfo.URNTypeID;
                        oBookings.URNO = objHCBooking.BookingsInfo.URNO;
                        oBookings.EMail = objHCBooking.BookingsInfo.EMail;
                        oBookings.RefPhysicianName = objHCBooking.BookingsInfo.RefPhysicianName;//Added By Jagatheesh


                        oBookings.StateID = Convert.ToInt32(objHCBooking.BookingsInfo.StateID);

                        oBookings.CityID = Convert.ToInt32(objHCBooking.BookingsInfo.CityID);





                    }
                    lstBookings.Add(oBookings);
                    #endregion

                    #region OrderedInvestigation 
                    if (objHCBooking.OrderedInvestigationInfo != null)
                    {
                        foreach (OrderedInvModel item in objHCBooking.OrderedInvestigationInfo)
                        {
                            oOrderInv = new OrderedInvestigations();
                            oOrderInv.Name = item.Name;
                            oOrderInv.ID = item.ID;
                            oOrderInv.VisitID = item.VisitID;
                            oOrderInv.CreatedBy = item.CreatedBy;
                            oOrderInv.ModifiedBy = item.ModifiedBy;
                            oOrderInv.Status = item.Status;
                            oOrderInv.Type = item.Type;
                            oOrderInv.OrgID = item.OrgID;
                            oOrderInv.StudyInstanceUId = item.StudyInstanceUId;
                            oOrderInv.ComplaintId = item.ComplaintId;
                            oOrderInv.ReferedToOrgID = item.ReferedToOrgID;
                            oOrderInv.ReferedToLocation = item.ReferedToLocation;
                            oOrderInv.InvestigationsType = item.InvestigationsType;
                            oOrderInv.ReferralID = item.ReferralID;
                            oOrderInv.UID = item.UID;
                            oOrderInv.ReferenceType = item.ReferenceType;
                            oOrderInv.RefPhyName = item.RefPhyName;
                            oOrderInv.RefPhysicianID = item.RefPhysicianID;
                            oOrderInv.SequenceNo = item.SequenceNo;
                            oOrderInv.ReportDateTime = item.ReportDateTime;
                            oOrderInv.TatDateTime = item.TatDateTime;
                            oOrderInv.IsStat = item.IsStat;
                            oOrderInv.SampleID = item.SampleID;
                            oOrderInv.TestSequenceOrder = item.TestSequenceOrder;
                            lstOrdInv.Add(oOrderInv);
                        }
                    }

                    #endregion
                    #region PreOrderedInvestigation 
                    if (objHCBooking.PreOrderedInvestigationInfo != null)
                    {
                        foreach (PreOrdInvModel item in objHCBooking.PreOrderedInvestigationInfo)
                        {
                            oPreOrdInv = new OrderedInvestigations();
                            oPreOrdInv.Name = item.Name;
                            oPreOrdInv.ID = item.ID;
                            oPreOrdInv.VisitID = item.VisitID;
                            oPreOrdInv.Status = item.Status;
                            oPreOrdInv.Type = item.Type;
                            oPreOrdInv.OrgID = item.OrgID;
                            oPreOrdInv.Rate = item.Rate;
                            oPreOrdInv.ActualAmount = item.ActualAmount;
                            oPreOrdInv.DiscountAmount = item.DiscountAmount;
                            oPreOrdInv.SalesAmount = item.SalesAmount;
                            oPreOrdInv.PkgName = item.PkgName;
                            oPreOrdInv.PkgID = item.PkgID;
                            lstPreOrderInv.Add(oPreOrdInv);
                        }
                    }

                    #endregion
                    #region ContextDetail 
                    if (objHCBooking.ContextInfo != null)
                    {
                        oContextDet = new ContextDetails();
                        oContextDet.OrgID = Convert.ToInt32(objHCBooking.ContextInfo.OrgID);
                        oContextDet.OrgName = objHCBooking.ContextInfo.OrgName;
                        oContextDet.LogoPath = objHCBooking.ContextInfo.LogoPath;
                        oContextDet.OrgAddressID = objHCBooking.ContextInfo.OrgAddressID;
                        oContextDet.RoleID = Convert.ToInt32(objHCBooking.ContextInfo.RoleID);
                        oContextDet.RoleName = objHCBooking.ContextInfo.RoleName;
                        oContextDet.UserID = objHCBooking.ContextInfo.UserID;
                        oContextDet.LoginID = objHCBooking.ContextInfo.LoginID;
                        oContextDet.LoginName = objHCBooking.ContextInfo.LoginName;
                        oContextDet.Age = objHCBooking.ContextInfo.Age;
                        oContextDet.LocationID = Convert.ToInt32(objHCBooking.ContextInfo.LocationID);
                        oContextDet.PharmacyLocationID = objHCBooking.ContextInfo.PharmacyLocationID;
                        oContextDet.IsTrustedOrg = objHCBooking.ContextInfo.IsTrustedOrg;
                        oContextDet.BaseCurrency = objHCBooking.ContextInfo.BaseCurrency;
                        oContextDet.CurrencyFormat = objHCBooking.ContextInfo.CurrencyFormat;
                        oContextDet.ThemeID = Convert.ToInt32(objHCBooking.ContextInfo.ThemeID);
                        oContextDet.CountryID = objHCBooking.ContextInfo.CountryID;
                        oContextDet.StateID = objHCBooking.ContextInfo.StateID;
                        oContextDet.LanguageCode = objHCBooking.ContextInfo.LanguageCode;
                        oContextDet.PageID = objHCBooking.ContextInfo.PageID;
                        oContextDet.SessionID = objHCBooking.ContextInfo.SessionID;
                        oContextDet.DepartmentName = objHCBooking.ContextInfo.DepartmentName;
                        oContextDet.AdditionalInfo = objHCBooking.ContextInfo.AdditionalInfo;
                        oContextDet.strvar = objHCBooking.ContextInfo.strvar;
                    }
                    lstContextDet.Add(oContextDet);
                    #endregion


                    HomeCollections_BL sBL = new HomeCollections_BL(oContextDet);
                    returnCode = sBL.SaveServiceQuotationDetails(oBookings, lstOrdInv, lstPreOrderInv, oBookings.OrgID, oBookings.UserID, out bookingID);


                    if (returnCode == -1 || returnCode == 1001)
                    {
                        return Content(HttpStatusCode.InternalServerError, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.InternalServerError, Message = "Server Error Occured", Status = "Failure" });
                    }
                    else
                    {
                        //   return Content(HttpStatusCode.OK, new SucessMessage { HttpStatusCode = HttpStatusCode.OK, Message = "OK", transactionId = GRNno, Status = "Success" });
                        actionResult = Ok("Home Collection BookingID " + bookingID + " details successfully inserted.");
                    }
                }
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.InternalServerError, Message = "While Exception Error Occured", Status = "Failure" });
            }
            return actionResult;
        }
        #endregion
        #region GetHCBookingDetails
        /// <summary>
        /// This API method will be using Home Collection Details for the Client to Attune. 
        /// </summary>
        /// <param name="objHCBookingModel"></param> HCBookingModel to be Json type
        /// <returns>success</returns>
        [ResponseType(typeof(HCBookingDetails))]
        [Route("Api/HomeCollection/GetHomeCollectionDetails")]
        [HttpGet]
        public IHttpActionResult GetHCBookingDetails(HCBookingDetails objHCBookingModel)
        {
            string CollecttionFromdate = string.Empty;
            string CollecttionTodate = string.Empty;
            string Fromdate = string.Empty;
            string Todate = string.Empty;
            string CollecOrgID = string.Empty;
            string LoginOrgID = string.Empty;
            string Status = string.Empty;
            string Task = string.Empty;
            string Location = string.Empty;

            string Pincode = string.Empty;
            long UserID = 0;
            string MobileNumber = string.Empty;
            string TelePhone = string.Empty;

            string pName = string.Empty;
            string PageSize = string.Empty;
            string currentPageNo = string.Empty;
            string BookingNumber = string.Empty;
            string pOrgCode = string.Empty;
            DateTime FromdateLoc;
            DateTime TodateLoc;
            DateTime ClollectFromLoc;
            DateTime ClollectToLoc;
            int PageSizeLoc = 0;
            int CurrentPageNoLoc = 0;
            int CollecOrgIDLoc = 0;
            int LoginOrgIDLoc = 0;
            List<ContextDetails> lstContextDet = new List<ContextDetails>();
            ContextDetails oContextDet = null;
            IHttpActionResult actionResult = null;
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;

           
            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }
            if (string.IsNullOrEmpty(pOrgCode))
            {

                return Content(HttpStatusCode.NotAcceptable, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.NotAcceptable, Message = "Request Parameters Value Missing ( OrgCode )  ", Status = "Failure" });
            }
            if (objHCBookingModel != null)
            {
                #region BookingInfo 
                if (objHCBookingModel.BookingsParaInfo != null)
                {
                    CollecttionFromdate = objHCBookingModel.BookingsParaInfo.CollecttionFromdate;
                    CollecttionTodate = objHCBookingModel.BookingsParaInfo.CollecttionTodate;
                    Fromdate = objHCBookingModel.BookingsParaInfo.Fromdate;
                    Todate = objHCBookingModel.BookingsParaInfo.Todate;
                    CollecOrgID = objHCBookingModel.BookingsParaInfo.CollecOrgID;
                    LoginOrgID = objHCBookingModel.BookingsParaInfo.LoginOrgID;
                    Status = objHCBookingModel.BookingsParaInfo.Status;
                    Task = objHCBookingModel.BookingsParaInfo.Task;
                    Location = objHCBookingModel.BookingsParaInfo.Location;

                    Pincode = objHCBookingModel.BookingsParaInfo.Pincode;
                    UserID = objHCBookingModel.BookingsParaInfo.UserID;
                    MobileNumber = objHCBookingModel.BookingsParaInfo.MobileNumber;
                    TelePhone = objHCBookingModel.BookingsParaInfo.TelePhone;

                    pName = objHCBookingModel.BookingsParaInfo.pName;
                    PageSize = objHCBookingModel.BookingsParaInfo.PageSize;
                    currentPageNo = objHCBookingModel.BookingsParaInfo.currentPageNo;
                    BookingNumber = objHCBookingModel.BookingsParaInfo.BookingNumber;
                }
                #endregion
                #region ContextDetail 
                if (objHCBookingModel.ContextInfo != null)
                {
                    oContextDet = new ContextDetails();
                    oContextDet.OrgID = Convert.ToInt32(objHCBookingModel.ContextInfo.OrgID);
                    oContextDet.OrgName = objHCBookingModel.ContextInfo.OrgName;
                    oContextDet.LogoPath = objHCBookingModel.ContextInfo.LogoPath;
                    oContextDet.OrgAddressID = objHCBookingModel.ContextInfo.OrgAddressID;
                    oContextDet.RoleID = Convert.ToInt32(objHCBookingModel.ContextInfo.RoleID);
                    oContextDet.RoleName = objHCBookingModel.ContextInfo.RoleName;
                    oContextDet.UserID = objHCBookingModel.ContextInfo.UserID;
                    oContextDet.LoginID = objHCBookingModel.ContextInfo.LoginID;
                    oContextDet.LoginName = objHCBookingModel.ContextInfo.LoginName;
                    oContextDet.Age = objHCBookingModel.ContextInfo.Age;
                    oContextDet.LocationID = Convert.ToInt32(objHCBookingModel.ContextInfo.LocationID);
                    oContextDet.PharmacyLocationID = objHCBookingModel.ContextInfo.PharmacyLocationID;
                    oContextDet.IsTrustedOrg = objHCBookingModel.ContextInfo.IsTrustedOrg;
                    oContextDet.BaseCurrency = objHCBookingModel.ContextInfo.BaseCurrency;
                    oContextDet.CurrencyFormat = objHCBookingModel.ContextInfo.CurrencyFormat;
                    oContextDet.ThemeID = Convert.ToInt32(objHCBookingModel.ContextInfo.ThemeID);
                    oContextDet.CountryID = objHCBookingModel.ContextInfo.CountryID;
                    oContextDet.StateID = objHCBookingModel.ContextInfo.StateID;
                    oContextDet.LanguageCode = objHCBookingModel.ContextInfo.LanguageCode;
                    oContextDet.PageID = objHCBookingModel.ContextInfo.PageID;
                    oContextDet.SessionID = objHCBookingModel.ContextInfo.SessionID;
                    oContextDet.DepartmentName = objHCBookingModel.ContextInfo.DepartmentName;
                    oContextDet.AdditionalInfo = objHCBookingModel.ContextInfo.AdditionalInfo;
                    oContextDet.strvar = objHCBookingModel.ContextInfo.strvar;
                }
                lstContextDet.Add(oContextDet);
                #endregion

            }
            if (Fromdate != "")
            {
                DateTime.TryParse(Fromdate, out FromdateLoc);
            }
            else
            {
                FromdateLoc = Convert.ToDateTime("1/1/1753");
            }
            if (Todate != "")
            {
                DateTime.TryParse(Todate, out TodateLoc);
            }
            else
            {
                TodateLoc = Convert.ToDateTime("1/1/1753");
            }
            if (CollecttionFromdate != "")
            {

                DateTime.TryParse(CollecttionFromdate, out ClollectFromLoc);
            }
            else
            {
                ClollectFromLoc = Convert.ToDateTime("1/1/1753");
            }
            if (CollecttionTodate != "")
            {

                DateTime.TryParse(CollecttionTodate, out ClollectToLoc);
            }
            else
            {
                ClollectToLoc = Convert.ToDateTime("1/1/1753");
            }

            long BookingNumberLoc = 0;
            List<Bookings> lstHomeCollectionDetails = new List<Bookings>();
            List<OrderedInvestigations> lstOrdInvDetails = new List<OrderedInvestigations>();
            List<OrderedInvestigations> lstPreOrdInvDetails = new List<OrderedInvestigations>();

            long returnCode = -1;
            //List<PackageMaster> lsttest = new List<PackageMaster>();
            //List<PackageDetail> lstPackage = new List<PackageDetail>();
            //PackageMasterDetails objOrder = new PackageMasterDetails();
            try
            {
                Int64.TryParse(BookingNumber, out BookingNumberLoc);
                Int32.TryParse(PageSize, out PageSizeLoc);
                Int32.TryParse(currentPageNo, out CurrentPageNoLoc);
                Int32.TryParse(CollecOrgID, out CollecOrgIDLoc);
                Int32.TryParse(LoginOrgID, out LoginOrgIDLoc);
                HomeCollections_BL home_BlUI1 = new HomeCollections_BL(oContextDet);

                returnCode = home_BlUI1.GetHCBookingDetails(ClollectFromLoc, ClollectToLoc, UserID, CollecOrgIDLoc, Location, Pincode, LoginOrgIDLoc, FromdateLoc, TodateLoc,
                Status, Task, MobileNumber, TelePhone, pName, PageSizeLoc, CurrentPageNoLoc, BookingNumberLoc,
                out lstOrdInvDetails, out lstPreOrdInvDetails, out lstHomeCollectionDetails);

                if (returnCode != -1)
                {
                    //if (lstPackage != null && lstPackage.Count > 0)
                    //{
                    //    objOrder.OrgCode = OrgCode;
                    //    foreach (PackageDetail objpack in lstPackage)
                    //    {
                    //        PackageMaster objpkg = new PackageMaster();
                    //        objpkg.TestCode = objpack.TestCode;
                    //        objpkg.TestName = objpack.TestName;
                    //        objpkg.Type = objpack.Type;
                    //        objpkg.Gender = objpack.Gender;
                    //        objpkg.SampleID = objpack.SampleID;
                    //        objpkg.SampleName = objpack.SampleName;
                    //        objpkg.ContainerID = objpack.ContainerID;
                    //        objpkg.ContainerName = objpack.ContainerName;
                    //        objpkg.SampleContainerColour = objpack.SampleContainerColour;
                    //        objpkg.Price = objpack.Price;
                    //        objpkg.DepartmentName = objpack.DepartmentName;
                    //        objpkg.DepartmentID = objpack.DepartmentID;
                    //        objpkg.Status = objpack.Status;
                    //        objpkg.Price = objpack.Price;
                    //        objpkg.CreatedAt = objpack.CreatedAt;
                    //        objpkg.UpdatedAt = objpack.UpdatedAt;
                    //        lsttest.Add(objpkg);
                    //    }
                    //    objOrder.TestMasterListInfo = lsttest;
                    //}

                    actionResult = Ok(lstHomeCollectionDetails);
                }

            }

            catch (Exception ex)
            {
                CLogger.LogError("Error in GetCollectiontimeValidation: ", ex);
            }
            return actionResult;




        }
        #endregion

        #region UpdateHCBookingDetails
        /// <summary>
        /// This API method will be using Home Collection Details for the Client to Attune. 
        /// </summary>
        /// <param name="objHCBookingsInfo"></param> HCBookingModel to be Json type
        /// <returns>success</returns>
        [ResponseType(typeof(UpdateHCBookingModel))]
        [Route("Api/HomeCollection/UpdateHCBookingDetails")]
        [HttpPost]
        public IHttpActionResult UpdateHCBookingDetails(UpdateHCBookingModel objHCBookingsInfo)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;

            string pOrgCode = string.Empty;
            long returnCode = -1;



            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }
            List<Bookings> lstBookings = new List<Bookings>();
          //  int OrgID = OrgId;
            long LID = 0;

            long bookingID = -1;
            long res = -1;
            List<ContextDetails> lstContextDet = new List<ContextDetails>();
            Bookings oBookings = null;
            string value = string.Empty;
            ContextDetails oContextDet = null;
            IHttpActionResult actionResult = null;


            long ID = 0;
            long PatientID = 0;
            long RoleID = 0;


            long PatientVisitID = 0;
            long PageID = 0;
            string ButtonName = string.Empty;
            string ActionType = string.Empty;
            if (string.IsNullOrEmpty(pOrgCode))
            {

                return Content(HttpStatusCode.NotAcceptable, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.NotAcceptable, Message = "Request Parameters Value Missing ( OrgCode )  ", Status = "Failure" });
            }
            if (objHCBookingsInfo != null)
            {

                #region BookingInfo 
                if (objHCBookingsInfo.BookingsInfo != null)
                {
                    foreach (Bookings item in objHCBookingsInfo.BookingsInfo)
                    {
                        oBookings = new Bookings();
                        oBookings.BookingID = item.BookingID;
                        oBookings.TokenNumber = item.TokenNumber;
                        oBookings.CreatedBy = item.CreatedBy;
                        oBookings.OrgID = item.OrgID;
                        oBookings.CreatedAt = item.CreatedAt;
                        oBookings.PatientName = item.PatientName.ToUpper();
                        oBookings.Sex = item.Sex;

                        oBookings.Age = item.Age;

                        if (Convert.ToDateTime(item.DOB).ToString("yyyy") != "0001")
                            oBookings.DOB = item.DOB;

                        oBookings.PhoneNumber = item.PhoneNumber;
                        oBookings.LandLineNumber = item.LandLineNumber;
                        oBookings.FeeType = item.FeeType;
                        oBookings.SourceType = item.SourceType;


                        oBookings.ClientID = item.ClientID;




                        oBookings.NRICNumber = item.NRICNumber; //General RateID for HomeCollection

                        oBookings.PatientID = item.PatientID;
                        oBookings.OrgAddressID = item.OrgAddressID;
                        oBookings.OtherOrgID = item.OtherOrgID;
                        oBookings.CollectionAddress = item.CollectionAddress;
                        oBookings.RoleID = item.RoleID;
                        oBookings.UserID = item.UserID;
                        oBookings.CollectionTime = item.CollectionTime;
                        oBookings.BookingOrgID = item.BookingOrgID;
                        oBookings.BookingStatus = item.BookingStatus;
                        oBookings.CollectionAddress2 = item.CollectionAddress2;
                        oBookings.City = item.City;
                        oBookings.PatientNumber = item.PatientNumber;
                        oBookings.Priority = item.Priority;
                        oBookings.BillDescription = item.BillDescription;
                        oBookings.State = item.State;
                        oBookings.Pincode = item.Pincode;
                        oBookings.TITLECode = item.TITLECode;

                        oBookings.DispatchValue = item.DispatchValue;
                        oBookings.URNTypeID = item.URNTypeID;
                        oBookings.URNO = item.URNO;
                        oBookings.EMail = item.EMail;
                        oBookings.RefPhysicianName = item.RefPhysicianName;//Added By Jagatheesh


                        oBookings.StateID = Convert.ToInt32(item.StateID);

                        oBookings.CityID = Convert.ToInt32(item.CityID);
                        lstBookings.Add(oBookings);
                    }
                    }
               
            

                #endregion
                #region ContextDetail 
                if (objHCBookingsInfo.ContextInfo != null)
                {
                    oContextDet = new ContextDetails();
                    oContextDet.OrgID = Convert.ToInt32(objHCBookingsInfo.ContextInfo.OrgID);
                    oContextDet.OrgName = objHCBookingsInfo.ContextInfo.OrgName;
                    oContextDet.LogoPath = objHCBookingsInfo.ContextInfo.LogoPath;
                    oContextDet.OrgAddressID = objHCBookingsInfo.ContextInfo.OrgAddressID;
                    oContextDet.RoleID = Convert.ToInt32(objHCBookingsInfo.ContextInfo.RoleID);
                    oContextDet.RoleName = objHCBookingsInfo.ContextInfo.RoleName;
                    oContextDet.UserID = objHCBookingsInfo.ContextInfo.UserID;
                    oContextDet.LoginID = objHCBookingsInfo.ContextInfo.LoginID;
                    oContextDet.LoginName = objHCBookingsInfo.ContextInfo.LoginName;
                    oContextDet.Age = objHCBookingsInfo.ContextInfo.Age;
                    oContextDet.LocationID = Convert.ToInt32(objHCBookingsInfo.ContextInfo.LocationID);
                    oContextDet.PharmacyLocationID = objHCBookingsInfo.ContextInfo.PharmacyLocationID;
                    oContextDet.IsTrustedOrg = objHCBookingsInfo.ContextInfo.IsTrustedOrg;
                    oContextDet.BaseCurrency = objHCBookingsInfo.ContextInfo.BaseCurrency;
                    oContextDet.CurrencyFormat = objHCBookingsInfo.ContextInfo.CurrencyFormat;
                    oContextDet.ThemeID = Convert.ToInt32(objHCBookingsInfo.ContextInfo.ThemeID);
                    oContextDet.CountryID = objHCBookingsInfo.ContextInfo.CountryID;
                    oContextDet.StateID = objHCBookingsInfo.ContextInfo.StateID;
                    oContextDet.LanguageCode = objHCBookingsInfo.ContextInfo.LanguageCode;
                    oContextDet.PageID = objHCBookingsInfo.ContextInfo.PageID;
                    oContextDet.SessionID = objHCBookingsInfo.ContextInfo.SessionID;
                    oContextDet.DepartmentName = objHCBookingsInfo.ContextInfo.DepartmentName;
                    oContextDet.AdditionalInfo = objHCBookingsInfo.ContextInfo.AdditionalInfo;
                    oContextDet.strvar = objHCBookingsInfo.ContextInfo.strvar;
                }
                lstContextDet.Add(oContextDet);
                #endregion
            }

            List<OrderedInvestigations> lstInv = new List<OrderedInvestigations>();
            //  ActionManager AM = new ActionManager(oContextDet);
            //  PageContextkey PC = new PageContextkey();



            returnCode = new HomeCollections_BL(oContextDet).UpdateHCBookingDetails(lstBookings, lstInv, oBookings.OrgID, LID, out bookingID);


            // foreach (PageContextkey item in lstPageContext)
            //   {
            //       res = AM.PerformingNextStepNotification(item, "", "");
            //  }
            if (returnCode == -1 || returnCode == 1001)
            {
                return Content(HttpStatusCode.InternalServerError, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.InternalServerError, Message = "Server Error Occured", Status = "Failure" });
            }
            else
            {
                //   return Content(HttpStatusCode.OK, new SucessMessage { HttpStatusCode = HttpStatusCode.OK, Message = "OK", transactionId = GRNno, Status = "Success" });
                actionResult = Ok("Home Collection BookingID " + bookingID + " details successfully Updated.");
            }
            return actionResult;
        }
        #endregion

        /// <summary>
        /// This API method will be using Home Collection Details for the Client to Attune. 
        /// </summary>
        /// <param name="objHCBulkBookingModel"></param> HCBookingModel to be Json type
        /// <returns>success</returns>
        [ResponseType(typeof(UpdateHCBulkBookingModel))]
        [Route("Api/HomeCollection/UpdateHCBulkBookingDetails")]
        [HttpPost]
        public IHttpActionResult UpdateHCBulkBookingDetails(UpdateHCBulkBookingModel objHCBulkBookingModel) //save data to database
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;

            string pOrgCode = string.Empty;
            long returnCode = -1;



            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }
            List<Bookings> lstBookings = new List<Bookings>();
            int count = 0;
            List<ContextDetails> lstContextDet = new List<ContextDetails>();
          
          //  int OrgID = OrgId;
            long LID = 1;
           
            long bookingID = -1;
           // long res = -1;
            List<ContextDetails> lstContextDetInfo = new List<ContextDetails>();
            Bookings oBookingsInfo = null;
            string value = string.Empty;
            ContextDetails oContextDet = null;
            IHttpActionResult actionResult = null;


            //long ID = 0;
            //long PatientID = 0;
            //long RoleID = 0;


            //long PatientVisitID = 0;
            //long PageID = 0;
            string ButtonName = string.Empty;
            string ActionType = string.Empty;

            if (string.IsNullOrEmpty(pOrgCode))
            {

                return Content(HttpStatusCode.NotAcceptable, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.NotAcceptable, Message = "Request Parameters Value Missing ( OrgCode )  ", Status = "Failure" });
            }
            if (objHCBulkBookingModel != null)
            {

                #region BookingInfo 
                if (objHCBulkBookingModel.BookingsInfo != null)
                {
            foreach (Bookings item in objHCBulkBookingModel.BookingsInfo)
            {
                        oBookingsInfo = new Bookings();
                        oBookingsInfo.BookingID = item.BookingID;
                oBookingsInfo.TokenNumber = item.TokenNumber;
                oBookingsInfo.CreatedBy = item.CreatedBy;
                oBookingsInfo.OrgID = item.OrgID;
                oBookingsInfo.CreatedAt = item.CreatedAt;
                oBookingsInfo.PatientName = item.PatientName.ToUpper();
                oBookingsInfo.Sex = item.Sex;

                oBookingsInfo.Age = item.Age;

                if (Convert.ToDateTime(item.DOB).ToString("yyyy") != "0001")
                    oBookingsInfo.DOB = item.DOB;

                oBookingsInfo.PhoneNumber = item.PhoneNumber;
                oBookingsInfo.LandLineNumber = item.LandLineNumber;
                oBookingsInfo.FeeType = item.FeeType;
                oBookingsInfo.SourceType = item.SourceType;


                oBookingsInfo.ClientID = item.ClientID;




                oBookingsInfo.NRICNumber = item.NRICNumber; //General RateID for HomeCollection

                oBookingsInfo.PatientID = item.PatientID;
                oBookingsInfo.OrgAddressID = item.OrgAddressID;
                oBookingsInfo.OtherOrgID = item.OtherOrgID;
                oBookingsInfo.CollectionAddress = item.CollectionAddress;
                oBookingsInfo.RoleID = item.RoleID;
                oBookingsInfo.UserID = item.UserID;
                oBookingsInfo.CollectionTime = item.CollectionTime;
                oBookingsInfo.BookingOrgID = item.BookingOrgID;
                oBookingsInfo.BookingStatus = item.BookingStatus;
                oBookingsInfo.CollectionAddress2 = item.CollectionAddress2;
                oBookingsInfo.City = item.City;
                oBookingsInfo.PatientNumber = item.PatientNumber;
                oBookingsInfo.Priority = item.Priority;
                oBookingsInfo.BillDescription = item.BillDescription;
                oBookingsInfo.State = item.State;
                oBookingsInfo.Pincode = item.Pincode;
                oBookingsInfo.TITLECode = item.TITLECode;

                oBookingsInfo.DispatchValue = item.DispatchValue;
                oBookingsInfo.URNTypeID = item.URNTypeID;
                oBookingsInfo.URNO = item.URNO;
                oBookingsInfo.EMail = item.EMail;
                oBookingsInfo.RefPhysicianName = item.RefPhysicianName;//Added By Jagatheesh


                oBookingsInfo.StateID = Convert.ToInt32(item.StateID);

                oBookingsInfo.CityID = Convert.ToInt32(item.CityID);
                lstBookings.Add(oBookingsInfo);
            }
        }

            

                #endregion
                #region ContextDetail 
                if (objHCBulkBookingModel.ContextInfo != null)
                {
                    oContextDet = new ContextDetails();
                    oContextDet.OrgID = Convert.ToInt32(objHCBulkBookingModel.ContextInfo.OrgID);
                    oContextDet.OrgName = objHCBulkBookingModel.ContextInfo.OrgName;
                    oContextDet.LogoPath = objHCBulkBookingModel.ContextInfo.LogoPath;
                    oContextDet.OrgAddressID = objHCBulkBookingModel.ContextInfo.OrgAddressID;
                    oContextDet.RoleID = Convert.ToInt32(objHCBulkBookingModel.ContextInfo.RoleID);
                    oContextDet.RoleName = objHCBulkBookingModel.ContextInfo.RoleName;
                    oContextDet.UserID = objHCBulkBookingModel.ContextInfo.UserID;
                    oContextDet.LoginID = objHCBulkBookingModel.ContextInfo.LoginID;
                    oContextDet.LoginName = objHCBulkBookingModel.ContextInfo.LoginName;
                    oContextDet.Age = objHCBulkBookingModel.ContextInfo.Age;
                    oContextDet.LocationID = Convert.ToInt32(objHCBulkBookingModel.ContextInfo.LocationID);
                    oContextDet.PharmacyLocationID = objHCBulkBookingModel.ContextInfo.PharmacyLocationID;
                    oContextDet.IsTrustedOrg = objHCBulkBookingModel.ContextInfo.IsTrustedOrg;
                    oContextDet.BaseCurrency = objHCBulkBookingModel.ContextInfo.BaseCurrency;
                    oContextDet.CurrencyFormat = objHCBulkBookingModel.ContextInfo.CurrencyFormat;
                    oContextDet.ThemeID = Convert.ToInt32(objHCBulkBookingModel.ContextInfo.ThemeID);
                    oContextDet.CountryID = objHCBulkBookingModel.ContextInfo.CountryID;
                    oContextDet.StateID = objHCBulkBookingModel.ContextInfo.StateID;
                    oContextDet.LanguageCode = objHCBulkBookingModel.ContextInfo.LanguageCode;
                    oContextDet.PageID = objHCBulkBookingModel.ContextInfo.PageID;
                    oContextDet.SessionID = objHCBulkBookingModel.ContextInfo.SessionID;
                    oContextDet.DepartmentName = objHCBulkBookingModel.ContextInfo.DepartmentName;
                    oContextDet.AdditionalInfo = objHCBulkBookingModel.ContextInfo.AdditionalInfo;
                    oContextDet.strvar = objHCBulkBookingModel.ContextInfo.strvar;
                }
                lstContextDetInfo.Add(oContextDet);
        #endregion
    }

    List<OrderedInvestigations> lstInv = new List<OrderedInvestigations>();
            //ActionManager AM = new ActionManager(new BaseClass().ContextInfo);
            //PageContextkey PC = new PageContextkey();

            returnCode = new HomeCollections_BL(oContextDet).UpdateHCBulkBookingDetails(lstBookings, lstInv, oBookingsInfo.OrgID, LID, out bookingID, out count);
            //  return lstBooking[0].BookingID.ToString();
            //foreach (PageContextkey item in lstPageContext)
            //{
            //    res = AM.PerformingNextStepNotification(item, "", "");
            //}
            //return count;
            if (returnCode == -1 || returnCode == 1001)
            {
                return Content(HttpStatusCode.InternalServerError, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.InternalServerError, Message = "Server Error Occured", Status = "Failure" });
            }
            else
            {
                //   return Content(HttpStatusCode.OK, new SucessMessage { HttpStatusCode = HttpStatusCode.OK, Message = "OK", transactionId = GRNno, Status = "Success" });
                actionResult = Ok("Home Collection Booking details successfully Updated.");
            }
            return actionResult;
        }

        /// <summary>
        /// This API method will be using Home Collection Details for the Client to Attune. 
        /// </summary>
        /// <param name="BookingNumber"></param> 
        /// <param name="UserID"></param> 
        ///    <param name="objContextInfo"></param> 
        /// <returns>success</returns>
        [ResponseType(typeof(HCMapBookingsDetail))]
[Route("Api/HomeCollection/GetHCMapBookingDetails")]
[HttpGet]
        public IHttpActionResult GetHCMapBookingDetails(long BookingNumber, long UserID,ContextInfoModel objContextInfo)
        {
            //  long returnCode = -1;UseHttpGet = true,
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            long returnCode = -1;

            string pOrgCode = string.Empty;
            List<BookingInfo> lstBooking = new List<BookingInfo>();
            List<BookingInfo> lstCollection = new List<BookingInfo>();
            List<BookingInfo> lstBookingHistory = new List<BookingInfo>();
            ContextDetails oContextDet = null;
            List<ContextDetails> lstContextDet = new List<ContextDetails>();
            IHttpActionResult actionResult = null;
            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }
            if (string.IsNullOrEmpty(pOrgCode))
            {

                return Content(HttpStatusCode.NotAcceptable, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.NotAcceptable, Message = "Request Parameters Value Missing ( OrgCode )  ", Status = "Failure" });
            }
            #region ContextDetail 
            if (objContextInfo.ContextInfo != null)
            {
                oContextDet = new ContextDetails();
                oContextDet.OrgID = Convert.ToInt32(objContextInfo.ContextInfo.OrgID);
                oContextDet.OrgName = objContextInfo.ContextInfo.OrgName;
                oContextDet.LogoPath = objContextInfo.ContextInfo.LogoPath;
                oContextDet.OrgAddressID = objContextInfo.ContextInfo.OrgAddressID;
                oContextDet.RoleID = Convert.ToInt32(objContextInfo.ContextInfo.RoleID);
                oContextDet.RoleName = objContextInfo.ContextInfo.RoleName;
                oContextDet.UserID = objContextInfo.ContextInfo.UserID;
                oContextDet.LoginID = objContextInfo.ContextInfo.LoginID;
                oContextDet.LoginName = objContextInfo.ContextInfo.LoginName;
                oContextDet.Age = objContextInfo.ContextInfo.Age;
                oContextDet.LocationID = Convert.ToInt32(objContextInfo.ContextInfo.LocationID);
                oContextDet.PharmacyLocationID = objContextInfo.ContextInfo.PharmacyLocationID;
                oContextDet.IsTrustedOrg = objContextInfo.ContextInfo.IsTrustedOrg;
                oContextDet.BaseCurrency = objContextInfo.ContextInfo.BaseCurrency;
                oContextDet.CurrencyFormat = objContextInfo.ContextInfo.CurrencyFormat;
                oContextDet.ThemeID = Convert.ToInt32(objContextInfo.ContextInfo.ThemeID);
                oContextDet.CountryID = objContextInfo.ContextInfo.CountryID;
                oContextDet.StateID = objContextInfo.ContextInfo.StateID;
                oContextDet.LanguageCode = objContextInfo.ContextInfo.LanguageCode;
                oContextDet.PageID = objContextInfo.ContextInfo.PageID;
                oContextDet.SessionID = objContextInfo.ContextInfo.SessionID;
                oContextDet.DepartmentName = objContextInfo.ContextInfo.DepartmentName;
                oContextDet.AdditionalInfo = objContextInfo.ContextInfo.AdditionalInfo;
                oContextDet.strvar = objContextInfo.ContextInfo.strvar;
            }
            lstContextDet.Add(oContextDet);
            #endregion
            try
            {
                //   returnCode = new HomeCollections_BL(new BaseClass().ContextInfo).GetHCMapBookingDetails(pUserID, out lstBooking, out lstCollection, out lstBookingHistory);
                HomeCollections_BL Book = new HomeCollections_BL(oContextDet);
                returnCode = Book.GetHCMapBookingDetails(BookingNumber, UserID, out lstBooking, out lstCollection, out lstBookingHistory);
          
             if (returnCode == -1 || returnCode == 1001)
            {
                return Content(HttpStatusCode.InternalServerError, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.InternalServerError, Message = "Server Error Occured", Status = "Failure" });
            }
            else
            {
                //   return Content(HttpStatusCode.OK, new SucessMessage { HttpStatusCode = HttpStatusCode.OK, Message = "OK", transactionId = GRNno, Status = "Success" });
                actionResult = Ok(lstBooking);
            }
        }
    
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.InternalServerError, Message = "While Exception Error Occured", Status = "Failure" });
            }
            return actionResult;
           




        }
        /// <summary>
        /// This API method will be using Home Collection Details for the Client to Attune. 
        /// </summary>
        ///  /// <param name="BookingNumber"></param> 
        /// <param name="UserID"></param> 
        ///    <param name="objContextInfo"></param> 
      
        /// <returns>success</returns>
        [ResponseType(typeof(HCMapBookingsDetail))]
[Route("Api/HomeCollection/GetHCMapBookingHistDetails")]
[HttpGet]
public IHttpActionResult GetHCMapBookingHistDetails(long BookingNumber, long UserID, ContextInfoModel objContextInfo)
{

            // long returnCode = -1;UseHttpGet = true, 
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            long returnCode = -1;

            string pOrgCode = string.Empty;
            List<BookingInfo> lstBooking = new List<BookingInfo>();
            List<BookingInfo> lstCollection = new List<BookingInfo>();
            List<BookingInfo> lstBookingHistory = new List<BookingInfo>();
            ContextDetails oContextDet = null;
            List<ContextDetails> lstContextDet = new List<ContextDetails>();
            IHttpActionResult actionResult = null;
            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }
            if (string.IsNullOrEmpty(pOrgCode))
            {

                return Content(HttpStatusCode.NotAcceptable, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.NotAcceptable, Message = "Request Parameters Value Missing ( OrgCode )  ", Status = "Failure" });
            }
           
            #region ContextDetail 
            if (objContextInfo.ContextInfo != null)
            {
                oContextDet = new ContextDetails();
                oContextDet.OrgID = Convert.ToInt32(objContextInfo.ContextInfo.OrgID);
                oContextDet.OrgName = objContextInfo.ContextInfo.OrgName;
                oContextDet.LogoPath = objContextInfo.ContextInfo.LogoPath;
                oContextDet.OrgAddressID = objContextInfo.ContextInfo.OrgAddressID;
                oContextDet.RoleID = Convert.ToInt32(objContextInfo.ContextInfo.RoleID);
                oContextDet.RoleName = objContextInfo.ContextInfo.RoleName;
                oContextDet.UserID = objContextInfo.ContextInfo.UserID;
                oContextDet.LoginID = objContextInfo.ContextInfo.LoginID;
                oContextDet.LoginName = objContextInfo.ContextInfo.LoginName;
                oContextDet.Age = objContextInfo.ContextInfo.Age;
                oContextDet.LocationID = Convert.ToInt32(objContextInfo.ContextInfo.LocationID);
                oContextDet.PharmacyLocationID = objContextInfo.ContextInfo.PharmacyLocationID;
                oContextDet.IsTrustedOrg = objContextInfo.ContextInfo.IsTrustedOrg;
                oContextDet.BaseCurrency = objContextInfo.ContextInfo.BaseCurrency;
                oContextDet.CurrencyFormat = objContextInfo.ContextInfo.CurrencyFormat;
                oContextDet.ThemeID = Convert.ToInt32(objContextInfo.ContextInfo.ThemeID);
                oContextDet.CountryID = objContextInfo.ContextInfo.CountryID;
                oContextDet.StateID = objContextInfo.ContextInfo.StateID;
                oContextDet.LanguageCode = objContextInfo.ContextInfo.LanguageCode;
                oContextDet.PageID = objContextInfo.ContextInfo.PageID;
                oContextDet.SessionID = objContextInfo.ContextInfo.SessionID;
                oContextDet.DepartmentName = objContextInfo.ContextInfo.DepartmentName;
                oContextDet.AdditionalInfo = objContextInfo.ContextInfo.AdditionalInfo;
                oContextDet.strvar = objContextInfo.ContextInfo.strvar;
            }
            lstContextDet.Add(oContextDet);
            #endregion
            try
            {
                //  Int64.TryParse(BookingNumber, out BookingNumberLoc);
                //   Int64.TryParse(UserID, out UserIDLoc);
                HomeCollections_BL home_BlUI1 = new HomeCollections_BL(oContextDet);
                returnCode = home_BlUI1.GetHCMapBookingDetails(BookingNumber, UserID, out lstBooking, out lstCollection, out lstBookingHistory);
                //    returnCode = new HomeCollections_BL(new BaseClass().ContextInfo).GetHCMapBookingDetails(pUserID, out lstBooking, out lstCollection, out lstBookingHistory);

                if (returnCode == -1 || returnCode == 1001)
                {
                    return Content(HttpStatusCode.InternalServerError, new ErrorMessageUtility { HttpStatusCode = HttpStatusCode.InternalServerError, Message = "Server Error Occured", Status = "Failure" });
                }
                else
                {
                    //   return Content(HttpStatusCode.OK, new SucessMessage { HttpStatusCode = HttpStatusCode.OK, Message = "OK", transactionId = GRNno, Status = "Success" });
                    actionResult = Ok(lstBooking);
                }




            }

            catch (Exception ex)
            {
                CLogger.LogError("Error in GetCollectiontimeValidation: ", ex);
            }


            if (lstBookingHistory != null && lstBookingHistory.Count > 0)
            {

                actionResult = Ok(lstBookingHistory);
            }
            else
            {
                actionResult = Ok(lstBooking);
            }


            return actionResult;


        }
        /// <summary>
        /// This API method will be using home collection autocomplete text 
        /// </summary>
        ///  /// <param name="HCBillingItems"></param> 
        /// <param name = "UserID" ></ param >
        ///    < param name="objContextInfo"></param> 

        //  <returns>success</returns>
        [ResponseType(typeof(HCBillingItemModel))]
        [Route("Api/HomeCollection/HCBillingItems")]
        [HttpPost]
        public IHttpActionResult HCBillingItems(string prefixText, HCBillingItemModel objHCBillingItemModel)
        {
            string pOrgCode = string.Empty;
            long returnCode = -1;

            List<PageContextkeyModel1> lstPageContextkey = new List<PageContextkeyModel1>();
            int count = 0;
            List<ContextDetails> lstContextDet = new List<ContextDetails>();
            List<BillingFeeDatails> lstBillingFeeDetails = new List<BillingFeeDatails>();
            PageContextkeyModel1 oBookingsInfo = null;

            string value = string.Empty;
            ContextDetails oContextDet = null;
            IHttpActionResult actionResult = null;

            if (objHCBillingItemModel != null)
            {


                if (objHCBillingItemModel.PageContextkey != null)
                {
                    foreach (PageContextkeyModel1 item in objHCBillingItemModel.PageContextkey)
                    {
                        oBookingsInfo = new PageContextkeyModel1();
                      //  oBookingsInfo.OrgID = item.OrgID;
                        oBookingsInfo.FeeType = item.FeeType;
                        oBookingsInfo.Description = item.Description;
                        oBookingsInfo.ClientID = item.ClientID;
                        oBookingsInfo.IS2ped = item.IS2ped;
                        oBookingsInfo.Remarks = item.Remarks;
                        oBookingsInfo.Gender = item.Gender; 

                        lstPageContextkey.Add(oBookingsInfo);
                    }
                }

                if (objHCBillingItemModel.ContextInfo != null)
                {
                    if (objHCBillingItemModel.ContextInfo != null)
                    {
                        oContextDet = new ContextDetails();
                        oContextDet.OrgID = Convert.ToInt32(objHCBillingItemModel.ContextInfo.OrgID);
                        oContextDet.OrgName = objHCBillingItemModel.ContextInfo.OrgName;
                        oContextDet.LogoPath = objHCBillingItemModel.ContextInfo.LogoPath;
                        oContextDet.OrgAddressID = objHCBillingItemModel.ContextInfo.OrgAddressID;
                        oContextDet.RoleID = Convert.ToInt32(objHCBillingItemModel.ContextInfo.RoleID);
                        oContextDet.RoleName = objHCBillingItemModel.ContextInfo.RoleName;
                        oContextDet.UserID = objHCBillingItemModel.ContextInfo.UserID;
                        oContextDet.LoginID = objHCBillingItemModel.ContextInfo.LoginID;
                        oContextDet.LoginName = objHCBillingItemModel.ContextInfo.LoginName;
                        oContextDet.Age = objHCBillingItemModel.ContextInfo.Age;
                        oContextDet.LocationID = Convert.ToInt32(objHCBillingItemModel.ContextInfo.LocationID);
                        oContextDet.PharmacyLocationID = objHCBillingItemModel.ContextInfo.PharmacyLocationID;
                        oContextDet.IsTrustedOrg = objHCBillingItemModel.ContextInfo.IsTrustedOrg;
                        oContextDet.BaseCurrency = objHCBillingItemModel.ContextInfo.BaseCurrency;
                        oContextDet.CurrencyFormat = objHCBillingItemModel.ContextInfo.CurrencyFormat;
                        oContextDet.ThemeID = Convert.ToInt32(objHCBillingItemModel.ContextInfo.ThemeID);
                        oContextDet.CountryID = objHCBillingItemModel.ContextInfo.CountryID;
                        oContextDet.StateID = objHCBillingItemModel.ContextInfo.StateID;
                        oContextDet.LanguageCode = objHCBillingItemModel.ContextInfo.LanguageCode;
                        oContextDet.PageID = objHCBillingItemModel.ContextInfo.PageID;
                        oContextDet.SessionID = objHCBillingItemModel.ContextInfo.SessionID;
                        oContextDet.DepartmentName = objHCBillingItemModel.ContextInfo.DepartmentName;
                        oContextDet.AdditionalInfo = objHCBillingItemModel.ContextInfo.AdditionalInfo;
                        oContextDet.strvar = objHCBillingItemModel.ContextInfo.strvar;
                    }
                    lstContextDet.Add(oContextDet);

                }
            }

            try
            {
                long ClientID = 0;

                string FeeType = string.Empty, Description = prefixText, IsMappedItem = string.Empty, Remarks = string.Empty;
                string Gender = string.Empty;
                int OrgID = 0;

                //   OrgID = oBookingsInfo.OrgID;
                OrgID = objHCBillingItemModel.ContextInfo.OrgID;
                   FeeType = oBookingsInfo.FeeType;
                ClientID = oBookingsInfo.ClientID;
                IsMappedItem = oBookingsInfo.IS2ped;
                Remarks = oBookingsInfo.Remarks;
                Gender = oBookingsInfo.Gender;
                HomeCollections_BL home_BlUI1 = new HomeCollections_BL(oContextDet);
                returnCode = home_BlUI1.GetBillingItems(OrgID, FeeType, Description, ClientID, IsMappedItem, Remarks, Gender, out lstBillingFeeDetails);

                // long returnCode = -1;UseHttpGet = true, 
                if (returnCode != -1)
                {
                    if (lstBillingFeeDetails.Count > 0 && lstBillingFeeDetails != null)
                    {
                        actionResult = Ok(lstBillingFeeDetails);
                    }
                    else
                    {
                        actionResult = Ok("While fetching the data getting an Error.");
                    }
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }
            return actionResult;

        }

        /// <summary>
        /// This API method will be using get Client name for home collection 
        /// </summary>


        // <returns>success</returns>
        //[ResponseType(typeof(SaveServiceQuotationDetailsModel))]
        [Route("Api/HomeCollection/GetHCBillingClientName")]
        [HttpPost]
        public IHttpActionResult GetHCBillingClientName(string prefixText, HCBillingClientName objHCBillingClient)
        {
            string pType = string.Empty;
            int OrgID = 0;
            long refhospid = 0;
            long returnCode = -1;
            List<InvClientMaster> lstInvs = new List<InvClientMaster>();
            List<string> items = new List<string>();


            List<PageClientContextkeyModel> lstPageContextkey = new List<PageClientContextkeyModel>();

            List<ContextDetails> lstContextDet = new List<ContextDetails>();
            PageClientContextkeyModel oBookingsInfo = null;
            ContextDetails oContextDet = null;
            IHttpActionResult actionResult = null;

            #region ContextDetail 

            if (objHCBillingClient != null)
            {


                if (objHCBillingClient.PageContextkey != null)
                {
                    foreach (PageClientContextkeyModel item in objHCBillingClient.PageContextkey)
                    {
                        oBookingsInfo = new PageClientContextkeyModel();
                        //  oBookingsInfo.OrgID = item.OrgID;
                        oBookingsInfo.pType = item.pType;
                        oBookingsInfo.refhospid = item.refhospid;
                        lstPageContextkey.Add(oBookingsInfo);
                    }
                }


                if (objHCBillingClient.ContextInfo != null)
                {
                    oContextDet = new ContextDetails();
                    oContextDet.OrgID = Convert.ToInt32(objHCBillingClient.ContextInfo.OrgID);
                    oContextDet.OrgName = objHCBillingClient.ContextInfo.OrgName;
                    oContextDet.LogoPath = objHCBillingClient.ContextInfo.LogoPath;
                    oContextDet.OrgAddressID = objHCBillingClient.ContextInfo.OrgAddressID;
                    oContextDet.RoleID = Convert.ToInt32(objHCBillingClient.ContextInfo.RoleID);
                    oContextDet.RoleName = objHCBillingClient.ContextInfo.RoleName;
                    oContextDet.UserID = objHCBillingClient.ContextInfo.UserID;
                    oContextDet.LoginID = objHCBillingClient.ContextInfo.LoginID;
                    oContextDet.LoginName = objHCBillingClient.ContextInfo.LoginName;
                    oContextDet.Age = objHCBillingClient.ContextInfo.Age;
                    oContextDet.LocationID = Convert.ToInt32(objHCBillingClient.ContextInfo.LocationID);
                    oContextDet.PharmacyLocationID = objHCBillingClient.ContextInfo.PharmacyLocationID;
                    oContextDet.IsTrustedOrg = objHCBillingClient.ContextInfo.IsTrustedOrg;
                    oContextDet.BaseCurrency = objHCBillingClient.ContextInfo.BaseCurrency;
                    oContextDet.CurrencyFormat = objHCBillingClient.ContextInfo.CurrencyFormat;
                    oContextDet.ThemeID = Convert.ToInt32(objHCBillingClient.ContextInfo.ThemeID);
                    oContextDet.CountryID = objHCBillingClient.ContextInfo.CountryID;
                    oContextDet.StateID = objHCBillingClient.ContextInfo.StateID;
                    oContextDet.LanguageCode = objHCBillingClient.ContextInfo.LanguageCode;
                    oContextDet.PageID = objHCBillingClient.ContextInfo.PageID;
                    oContextDet.SessionID = objHCBillingClient.ContextInfo.SessionID;
                    oContextDet.DepartmentName = objHCBillingClient.ContextInfo.DepartmentName;
                    oContextDet.AdditionalInfo = objHCBillingClient.ContextInfo.AdditionalInfo;
                    oContextDet.strvar = objHCBillingClient.ContextInfo.strvar;
                }
                lstContextDet.Add(oContextDet);
                #endregion
            }


            try
            {


                OrgID = objHCBillingClient.ContextInfo.OrgID;
                pType = oBookingsInfo.pType;
                refhospid = oBookingsInfo.refhospid;

                HomeCollections_BL home_BlUI1 = new HomeCollections_BL(oContextDet);
                returnCode = home_BlUI1.GetHCBillingClientName(prefixText, OrgID, pType, refhospid, out lstInvs);
                if (returnCode != -1)
                {
                    if (lstInvs.Count > 0 && lstInvs != null)
                    {
                        actionResult = Ok(lstInvs);
                    }
                    else
                    {
                        actionResult = Ok("While fetching the data getting an Error.");
                    }
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }
            return actionResult;


        }

        /// <summary>
        /// This API method will be using get Technician name for home collection 
        /// </summary>

        // <returns>success</returns>
        //[ResponseType(typeof(SaveServiceQuotationDetailsModel))]
        [Route("Api/HomeCollection/GetHCBillingTechnicianName")]
        [HttpPost]
        public IHttpActionResult GetHCBillingTechnicianName(long RoleID, ContextInfoModel objContextInfo)
        {
            string pType = string.Empty;
            int OrgID = 0;
            long refhospid = 0;
            long returnCode = -1;

            List<ContextDetails> lstContextDet = new List<ContextDetails>();

            ContextDetails oContextDet = null;
            IHttpActionResult actionResult = null;

            #region ContextDetail 

            if (objContextInfo != null)
            {



                if (objContextInfo.ContextInfo != null)
                {
                    oContextDet = new ContextDetails();
                    oContextDet.OrgID = Convert.ToInt32(objContextInfo.ContextInfo.OrgID);
                    oContextDet.OrgName = objContextInfo.ContextInfo.OrgName;
                    oContextDet.LogoPath = objContextInfo.ContextInfo.LogoPath;
                    oContextDet.OrgAddressID = objContextInfo.ContextInfo.OrgAddressID;
                    oContextDet.RoleID = Convert.ToInt32(objContextInfo.ContextInfo.RoleID);
                    oContextDet.RoleName = objContextInfo.ContextInfo.RoleName;
                    oContextDet.UserID = objContextInfo.ContextInfo.UserID;
                    oContextDet.LoginID = objContextInfo.ContextInfo.LoginID;
                    oContextDet.LoginName = objContextInfo.ContextInfo.LoginName;
                    oContextDet.Age = objContextInfo.ContextInfo.Age;
                    oContextDet.LocationID = Convert.ToInt32(objContextInfo.ContextInfo.LocationID);
                    oContextDet.PharmacyLocationID = objContextInfo.ContextInfo.PharmacyLocationID;
                    oContextDet.IsTrustedOrg = objContextInfo.ContextInfo.IsTrustedOrg;
                    oContextDet.BaseCurrency = objContextInfo.ContextInfo.BaseCurrency;
                    oContextDet.CurrencyFormat = objContextInfo.ContextInfo.CurrencyFormat;
                    oContextDet.ThemeID = Convert.ToInt32(objContextInfo.ContextInfo.ThemeID);
                    oContextDet.CountryID = objContextInfo.ContextInfo.CountryID;
                    oContextDet.StateID = objContextInfo.ContextInfo.StateID;
                    oContextDet.LanguageCode = objContextInfo.ContextInfo.LanguageCode;
                    oContextDet.PageID = objContextInfo.ContextInfo.PageID;
                    oContextDet.SessionID = objContextInfo.ContextInfo.SessionID;
                    oContextDet.DepartmentName = objContextInfo.ContextInfo.DepartmentName;
                    oContextDet.AdditionalInfo = objContextInfo.ContextInfo.AdditionalInfo;
                    oContextDet.strvar = objContextInfo.ContextInfo.strvar;
                }
                lstContextDet.Add(oContextDet);
                #endregion
            }


            try
            {

                List<Users> lstResult = new List<Users>();
                OrgID = objContextInfo.ContextInfo.OrgID;


                HomeCollections_BL home_BlUI1 = new HomeCollections_BL(oContextDet);
                returnCode = home_BlUI1.GetHCBillingTechnicianName(OrgID, RoleID, out lstResult);
                if (returnCode != -1)
                {
                    if (lstResult.Count > 0 && lstResult != null)
                    {
                        actionResult = Ok(lstResult);
                    }
                    else
                    {
                        actionResult = Ok("While fetching the data getting an Error.");
                    }
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }
            return actionResult;


        }

        /// <summary>
        /// This API method will be using get Location name for home collection 
        /// </summary>

        // <returns>success</returns>
        //[ResponseType(typeof(SaveServiceQuotationDetailsModel))]
        [Route("Api/HomeCollection/GetLocationforHomeCollectionpincode")]
        [HttpPost]
        public IHttpActionResult GetLocationforHomeCollectionpincode(long pincode, ContextInfoModel objContextInfo)
        {
            string LocationName = "";
            long LocationID = 0;

            long returnCode = -1;

            List<ContextDetails> lstContextDet = new List<ContextDetails>();
            // List<Location> lstLocationforHomeCollection = new List<Location>();
            ContextDetails oContextDet = null;
            IHttpActionResult actionResult = null;

            #region ContextDetail 

            if (objContextInfo != null)
            {



                if (objContextInfo.ContextInfo != null)
                {
                    oContextDet = new ContextDetails();
                    oContextDet.OrgID = Convert.ToInt32(objContextInfo.ContextInfo.OrgID);
                    oContextDet.OrgName = objContextInfo.ContextInfo.OrgName;
                    oContextDet.LogoPath = objContextInfo.ContextInfo.LogoPath;
                    oContextDet.OrgAddressID = objContextInfo.ContextInfo.OrgAddressID;
                    oContextDet.RoleID = Convert.ToInt32(objContextInfo.ContextInfo.RoleID);
                    oContextDet.RoleName = objContextInfo.ContextInfo.RoleName;
                    oContextDet.UserID = objContextInfo.ContextInfo.UserID;
                    oContextDet.LoginID = objContextInfo.ContextInfo.LoginID;
                    oContextDet.LoginName = objContextInfo.ContextInfo.LoginName;
                    oContextDet.Age = objContextInfo.ContextInfo.Age;
                    oContextDet.LocationID = Convert.ToInt32(objContextInfo.ContextInfo.LocationID);
                    oContextDet.PharmacyLocationID = objContextInfo.ContextInfo.PharmacyLocationID;
                    oContextDet.IsTrustedOrg = objContextInfo.ContextInfo.IsTrustedOrg;
                    oContextDet.BaseCurrency = objContextInfo.ContextInfo.BaseCurrency;
                    oContextDet.CurrencyFormat = objContextInfo.ContextInfo.CurrencyFormat;
                    oContextDet.ThemeID = Convert.ToInt32(objContextInfo.ContextInfo.ThemeID);
                    oContextDet.CountryID = objContextInfo.ContextInfo.CountryID;
                    oContextDet.StateID = objContextInfo.ContextInfo.StateID;
                    oContextDet.LanguageCode = objContextInfo.ContextInfo.LanguageCode;
                    oContextDet.PageID = objContextInfo.ContextInfo.PageID;
                    oContextDet.SessionID = objContextInfo.ContextInfo.SessionID;
                    oContextDet.DepartmentName = objContextInfo.ContextInfo.DepartmentName;
                    oContextDet.AdditionalInfo = objContextInfo.ContextInfo.AdditionalInfo;
                    oContextDet.strvar = objContextInfo.ContextInfo.strvar;
                }
                lstContextDet.Add(oContextDet);
                #endregion
            }


            try
            {

                //List<Users> lstResult = new List<Users>();

                List<Location> lstLocationforHomeCollection = new List<Location>();

                HomeCollections_BL home_BlUI1 = new HomeCollections_BL(oContextDet);
                returnCode = home_BlUI1.GetLocationforHomeCollectionpincode(pincode, LocationID, LocationName, out lstLocationforHomeCollection);
                if (returnCode != -1)
                {
                    if (lstLocationforHomeCollection.Count > 0 && lstLocationforHomeCollection != null)
                    {
                        actionResult = Ok(lstLocationforHomeCollection);
                    }
                    else
                    {
                        actionResult = Ok("While fetching the data getting an Error.");
                    }
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }
            return actionResult;


        }

        /// <summary>
        /// This API method will be using get Collection Center name for home collection 
        /// </summary>

        // <returns>success</returns>
        //[ResponseType(typeof(SaveServiceQuotationDetailsModel))]
        [Route("Api/HomeCollection/GetCollectionCenter")]
        [HttpPost]
        public IHttpActionResult GetCollectionCenter(ContextInfoModel objContextInfo)
        {

            int orgId;
            long returnCode = -1;
            long loginID = -1;
            long roleID = -1;

            List<ContextDetails> lstContextDet = new List<ContextDetails>();
            ContextDetails oContextDet = null;
            IHttpActionResult actionResult = null;

            #region ContextDetail 

            if (objContextInfo != null)
            {

                if (objContextInfo.ContextInfo != null)
                {
                    oContextDet = new ContextDetails();
                    oContextDet.OrgID = Convert.ToInt32(objContextInfo.ContextInfo.OrgID);
                    oContextDet.OrgName = objContextInfo.ContextInfo.OrgName;
                    oContextDet.LogoPath = objContextInfo.ContextInfo.LogoPath;
                    oContextDet.OrgAddressID = objContextInfo.ContextInfo.OrgAddressID;
                    oContextDet.RoleID = Convert.ToInt32(objContextInfo.ContextInfo.RoleID);
                    oContextDet.RoleName = objContextInfo.ContextInfo.RoleName;
                    oContextDet.UserID = objContextInfo.ContextInfo.UserID;
                    oContextDet.LoginID = objContextInfo.ContextInfo.LoginID;
                    oContextDet.LoginName = objContextInfo.ContextInfo.LoginName;
                    oContextDet.Age = objContextInfo.ContextInfo.Age;
                    oContextDet.LocationID = Convert.ToInt32(objContextInfo.ContextInfo.LocationID);
                    oContextDet.PharmacyLocationID = objContextInfo.ContextInfo.PharmacyLocationID;
                    oContextDet.IsTrustedOrg = objContextInfo.ContextInfo.IsTrustedOrg;
                    oContextDet.BaseCurrency = objContextInfo.ContextInfo.BaseCurrency;
                    oContextDet.CurrencyFormat = objContextInfo.ContextInfo.CurrencyFormat;
                    oContextDet.ThemeID = Convert.ToInt32(objContextInfo.ContextInfo.ThemeID);
                    oContextDet.CountryID = objContextInfo.ContextInfo.CountryID;
                    oContextDet.StateID = objContextInfo.ContextInfo.StateID;
                    oContextDet.LanguageCode = objContextInfo.ContextInfo.LanguageCode;
                    oContextDet.PageID = objContextInfo.ContextInfo.PageID;
                    oContextDet.SessionID = objContextInfo.ContextInfo.SessionID;
                    oContextDet.DepartmentName = objContextInfo.ContextInfo.DepartmentName;
                    oContextDet.AdditionalInfo = objContextInfo.ContextInfo.AdditionalInfo;
                    oContextDet.strvar = objContextInfo.ContextInfo.strvar;
                }
                lstContextDet.Add(oContextDet);
                #endregion
            }


            try
            {

                //List<Users> lstResult = new List<Users>();
                orgId = Convert.ToInt32(objContextInfo.ContextInfo.OrgID);
                loginID = objContextInfo.ContextInfo.LoginID;
                roleID = Convert.ToInt32(objContextInfo.ContextInfo.RoleID);
                List<Location> lstLocationforHomeCollection = new List<Location>();

                HomeCollections_BL home_BlUI1 = new HomeCollections_BL(oContextDet);
                returnCode = home_BlUI1.GetCollectionCenter(orgId, loginID, roleID, out lstLocationforHomeCollection);
                if (returnCode != -1)
                {
                    if (lstLocationforHomeCollection.Count > 0 && lstLocationforHomeCollection != null)
                    {
                        actionResult = Ok(lstLocationforHomeCollection);
                    }
                    else
                    {
                        actionResult = Ok("While fetching the data getting an Error.");
                    }
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }
            return actionResult;


        }

        /// <summary>
        /// This API method will be using get Processing name for home collection 
        /// </summary>

        // <returns>success</returns>
        //[ResponseType(typeof(SaveServiceQuotationDetailsModel))]
        [Route("Api/HomeCollection/GetProcessingCentre")]
        [HttpPost]
        public IHttpActionResult GetProcessingCentre(ContextInfoModel objContextInfo)
        {

            long returnCode = -1;
            long loginID = -1;


            List<ContextDetails> lstContextDet = new List<ContextDetails>();
            ContextDetails oContextDet = null;
            IHttpActionResult actionResult = null;

            #region ContextDetail 

            if (objContextInfo != null)
            {

                if (objContextInfo.ContextInfo != null)
                {
                    oContextDet = new ContextDetails();
                    oContextDet.OrgID = Convert.ToInt32(objContextInfo.ContextInfo.OrgID);
                    oContextDet.OrgName = objContextInfo.ContextInfo.OrgName;
                    oContextDet.LogoPath = objContextInfo.ContextInfo.LogoPath;
                    oContextDet.OrgAddressID = objContextInfo.ContextInfo.OrgAddressID;
                    oContextDet.RoleID = Convert.ToInt32(objContextInfo.ContextInfo.RoleID);
                    oContextDet.RoleName = objContextInfo.ContextInfo.RoleName;
                    oContextDet.UserID = objContextInfo.ContextInfo.UserID;
                    oContextDet.LoginID = objContextInfo.ContextInfo.LoginID;
                    oContextDet.LoginName = objContextInfo.ContextInfo.LoginName;
                    oContextDet.Age = objContextInfo.ContextInfo.Age;
                    oContextDet.LocationID = Convert.ToInt32(objContextInfo.ContextInfo.LocationID);
                    oContextDet.PharmacyLocationID = objContextInfo.ContextInfo.PharmacyLocationID;
                    oContextDet.IsTrustedOrg = objContextInfo.ContextInfo.IsTrustedOrg;
                    oContextDet.BaseCurrency = objContextInfo.ContextInfo.BaseCurrency;
                    oContextDet.CurrencyFormat = objContextInfo.ContextInfo.CurrencyFormat;
                    oContextDet.ThemeID = Convert.ToInt32(objContextInfo.ContextInfo.ThemeID);
                    oContextDet.CountryID = objContextInfo.ContextInfo.CountryID;
                    oContextDet.StateID = objContextInfo.ContextInfo.StateID;
                    oContextDet.LanguageCode = objContextInfo.ContextInfo.LanguageCode;
                    oContextDet.PageID = objContextInfo.ContextInfo.PageID;
                    oContextDet.SessionID = objContextInfo.ContextInfo.SessionID;
                    oContextDet.DepartmentName = objContextInfo.ContextInfo.DepartmentName;
                    oContextDet.AdditionalInfo = objContextInfo.ContextInfo.AdditionalInfo;
                    oContextDet.strvar = objContextInfo.ContextInfo.strvar;
                }
                lstContextDet.Add(oContextDet);
                #endregion
            }


            try
            {

                //List<Users> lstResult = new List<Users>();

                loginID = objContextInfo.ContextInfo.LoginID;

                List<Role1> lstResult = new List<Role1>();

                HomeCollections_BL home_BlUI1 = new HomeCollections_BL(oContextDet);
                returnCode = home_BlUI1.GetOrganizations(loginID, out lstResult);
                if (returnCode != -1)
                {
                    if (lstResult.Count > 0 && lstResult != null)
                    {
                        actionResult = Ok(lstResult);
                    }
                    else
                    {
                        actionResult = Ok("While fetching the data getting an Error.");
                    }
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }
            return actionResult;


        }

        [Route("Api/HomeCollection/GetSampleCollectionPersonList")]
        [HttpGet]
        public IHttpActionResult GetSampleCollectionPersonList(string PrefixText, string OrgID, long pPinCode)
        {
            string pType = string.Empty;
            //int OrgID = 0;
            long returnCode = -1;
            ContextInfoModel objContextInfo = new ContextInfoModel();
            List<ContextDetails> lstContextDet = new List<ContextDetails>();

            ContextDetails oContextDet = null;
            IHttpActionResult actionResult = null;

            #region ContextDetail 

            if (objContextInfo != null)
            {



                if (objContextInfo.ContextInfo != null)
                {
                    oContextDet = new ContextDetails();
                    oContextDet.OrgID = Convert.ToInt32(objContextInfo.ContextInfo.OrgID);
                    oContextDet.OrgName = objContextInfo.ContextInfo.OrgName;
                    oContextDet.LogoPath = objContextInfo.ContextInfo.LogoPath;
                    oContextDet.OrgAddressID = objContextInfo.ContextInfo.OrgAddressID;
                    oContextDet.RoleID = Convert.ToInt32(objContextInfo.ContextInfo.RoleID);
                    oContextDet.RoleName = objContextInfo.ContextInfo.RoleName;
                    oContextDet.UserID = objContextInfo.ContextInfo.UserID;
                    oContextDet.LoginID = objContextInfo.ContextInfo.LoginID;
                    oContextDet.LoginName = objContextInfo.ContextInfo.LoginName;
                    oContextDet.Age = objContextInfo.ContextInfo.Age;
                    oContextDet.LocationID = Convert.ToInt32(objContextInfo.ContextInfo.LocationID);
                    oContextDet.PharmacyLocationID = objContextInfo.ContextInfo.PharmacyLocationID;
                    oContextDet.IsTrustedOrg = objContextInfo.ContextInfo.IsTrustedOrg;
                    oContextDet.BaseCurrency = objContextInfo.ContextInfo.BaseCurrency;
                    oContextDet.CurrencyFormat = objContextInfo.ContextInfo.CurrencyFormat;
                    oContextDet.ThemeID = Convert.ToInt32(objContextInfo.ContextInfo.ThemeID);
                    oContextDet.CountryID = objContextInfo.ContextInfo.CountryID;
                    oContextDet.StateID = objContextInfo.ContextInfo.StateID;
                    oContextDet.LanguageCode = objContextInfo.ContextInfo.LanguageCode;
                    oContextDet.PageID = objContextInfo.ContextInfo.PageID;
                    oContextDet.SessionID = objContextInfo.ContextInfo.SessionID;
                    oContextDet.DepartmentName = objContextInfo.ContextInfo.DepartmentName;
                    oContextDet.AdditionalInfo = objContextInfo.ContextInfo.AdditionalInfo;
                    oContextDet.strvar = objContextInfo.ContextInfo.strvar;
                }
                lstContextDet.Add(oContextDet);
                #endregion

            }


            try
            {

                List<Users> lstResult = new List<Users>();
                //OrgID = objContextInfo.ContextInfo.OrgID;

                //OrgID = 202;
                HomeCollections_BL home_BlUI1 = new HomeCollections_BL(oContextDet);
                returnCode = home_BlUI1.GetSampleCollectionPersonList( Convert.ToInt32( OrgID), PrefixText, pPinCode, out lstResult);
                if (returnCode != -1)
                {
                    if (lstResult.Count > 0 && lstResult != null)
                    {
                        actionResult = Ok(lstResult);
                    }
                    else
                    {
                        actionResult = Ok("While fetching the data getting an Error.");
                    }
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }
            return actionResult;


        }


        [Route("Api/HomeCollection/GetWorkingDays")]
        [HttpGet]
        public IHttpActionResult GetWorkingDays()
        {
            string pType = string.Empty;
            int OrgID = 0;
            long returnCode = -1;

            List<ContextDetails> lstContextDet = new List<ContextDetails>();

            ContextDetails oContextDet = null;
            IHttpActionResult actionResult = null;
            ContextInfoModel objContextInfo = new ContextInfoModel();
            #region ContextDetail 

            if (objContextInfo != null)
            {



                if (objContextInfo.ContextInfo != null)
                {
                    oContextDet = new ContextDetails();
                    oContextDet.OrgID = Convert.ToInt32(objContextInfo.ContextInfo.OrgID);
                    oContextDet.OrgName = objContextInfo.ContextInfo.OrgName;
                    oContextDet.LogoPath = objContextInfo.ContextInfo.LogoPath;
                    oContextDet.OrgAddressID = objContextInfo.ContextInfo.OrgAddressID;
                    oContextDet.RoleID = Convert.ToInt32(objContextInfo.ContextInfo.RoleID);
                    oContextDet.RoleName = objContextInfo.ContextInfo.RoleName;
                    oContextDet.UserID = objContextInfo.ContextInfo.UserID;
                    oContextDet.LoginID = objContextInfo.ContextInfo.LoginID;
                    oContextDet.LoginName = objContextInfo.ContextInfo.LoginName;
                    oContextDet.Age = objContextInfo.ContextInfo.Age;
                    oContextDet.LocationID = Convert.ToInt32(objContextInfo.ContextInfo.LocationID);
                    oContextDet.PharmacyLocationID = objContextInfo.ContextInfo.PharmacyLocationID;
                    oContextDet.IsTrustedOrg = objContextInfo.ContextInfo.IsTrustedOrg;
                    oContextDet.BaseCurrency = objContextInfo.ContextInfo.BaseCurrency;
                    oContextDet.CurrencyFormat = objContextInfo.ContextInfo.CurrencyFormat;
                    oContextDet.ThemeID = Convert.ToInt32(objContextInfo.ContextInfo.ThemeID);
                    oContextDet.CountryID = objContextInfo.ContextInfo.CountryID;
                    oContextDet.StateID = objContextInfo.ContextInfo.StateID;
                    oContextDet.LanguageCode = objContextInfo.ContextInfo.LanguageCode;
                    oContextDet.PageID = objContextInfo.ContextInfo.PageID;
                    oContextDet.SessionID = objContextInfo.ContextInfo.SessionID;
                    oContextDet.DepartmentName = objContextInfo.ContextInfo.DepartmentName;
                    oContextDet.AdditionalInfo = objContextInfo.ContextInfo.AdditionalInfo;
                    oContextDet.strvar = objContextInfo.ContextInfo.strvar;
                }
                lstContextDet.Add(oContextDet);
                #endregion

            }


            try
            {

                List<MetaDataFormat> lstResult = new List<MetaDataFormat>();


                HomeCollections_BL home_BlUI1 = new HomeCollections_BL(oContextDet);
                returnCode = home_BlUI1.GetWorkingDays(out lstResult);
                if (returnCode != -1)
                {
                    if (lstResult.Count > 0 && lstResult != null)
                    {
                        actionResult = Ok(lstResult);
                    }
                    else
                    {
                        actionResult = Ok("While fetching the data getting an Error.");
                    }
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }
            return actionResult;


        }

        [Route("Api/HomeCollection/GetPinCode")]
        [HttpGet]
        public IHttpActionResult GetPinCode(string PrefixText, string pMode)
        {
            string pType = string.Empty;
           
            long returnCode = -1;

            List<ContextDetails> lstContextDet = new List<ContextDetails>();

            ContextDetails oContextDet = null;
            IHttpActionResult actionResult = null;
            ContextInfoModel objContextInfo = new ContextInfoModel();
            #region ContextDetail 

            if (objContextInfo != null)
            {



                if (objContextInfo.ContextInfo != null)
                {
                    oContextDet = new ContextDetails();
                    oContextDet.OrgID = Convert.ToInt32(objContextInfo.ContextInfo.OrgID);
                    oContextDet.OrgName = objContextInfo.ContextInfo.OrgName;
                    oContextDet.LogoPath = objContextInfo.ContextInfo.LogoPath;
                    oContextDet.OrgAddressID = objContextInfo.ContextInfo.OrgAddressID;
                    oContextDet.RoleID = Convert.ToInt32(objContextInfo.ContextInfo.RoleID);
                    oContextDet.RoleName = objContextInfo.ContextInfo.RoleName;
                    oContextDet.UserID = objContextInfo.ContextInfo.UserID;
                    oContextDet.LoginID = objContextInfo.ContextInfo.LoginID;
                    oContextDet.LoginName = objContextInfo.ContextInfo.LoginName;
                    oContextDet.Age = objContextInfo.ContextInfo.Age;
                    oContextDet.LocationID = Convert.ToInt32(objContextInfo.ContextInfo.LocationID);
                    oContextDet.PharmacyLocationID = objContextInfo.ContextInfo.PharmacyLocationID;
                    oContextDet.IsTrustedOrg = objContextInfo.ContextInfo.IsTrustedOrg;
                    oContextDet.BaseCurrency = objContextInfo.ContextInfo.BaseCurrency;
                    oContextDet.CurrencyFormat = objContextInfo.ContextInfo.CurrencyFormat;
                    oContextDet.ThemeID = Convert.ToInt32(objContextInfo.ContextInfo.ThemeID);
                    oContextDet.CountryID = objContextInfo.ContextInfo.CountryID;
                    oContextDet.StateID = objContextInfo.ContextInfo.StateID;
                    oContextDet.LanguageCode = objContextInfo.ContextInfo.LanguageCode;
                    oContextDet.PageID = objContextInfo.ContextInfo.PageID;
                    oContextDet.SessionID = objContextInfo.ContextInfo.SessionID;
                    oContextDet.DepartmentName = objContextInfo.ContextInfo.DepartmentName;
                    oContextDet.AdditionalInfo = objContextInfo.ContextInfo.AdditionalInfo;
                    oContextDet.strvar = objContextInfo.ContextInfo.strvar;
                }
                lstContextDet.Add(oContextDet);
                #endregion

            }

            try
            {

                List<PinCodeList> lstResult = new List<PinCodeList>();

                HomeCollections_BL home_BlUI1 = new HomeCollections_BL(oContextDet);
                returnCode = home_BlUI1.GetPinCode(PrefixText, pMode, out lstResult);
                if (returnCode != -1)
                {
                    if (lstResult.Count > 0 && lstResult != null)
                    {
                        actionResult = Ok(lstResult);
                    }
                    else
                    {
                        actionResult = Ok("While fetching the data getting an Error.");
                    }
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }
            return actionResult;


        }


        [Route("Api/HomeCollection/GetHolidayList")]
        [HttpGet]
        public IHttpActionResult GetHolidayList()
        {
            string pType = string.Empty;
            int OrgID = 0;
            long returnCode = -1;

            List<ContextDetails> lstContextDet = new List<ContextDetails>();

            ContextDetails oContextDet = null;
            IHttpActionResult actionResult = null;
            ContextInfoModel objContextInfo = new ContextInfoModel();
            #region ContextDetail 

            if (objContextInfo != null)
            {



                if (objContextInfo.ContextInfo != null)
                {
                    oContextDet = new ContextDetails();
                    oContextDet.OrgID = Convert.ToInt32(objContextInfo.ContextInfo.OrgID);
                    oContextDet.OrgName = objContextInfo.ContextInfo.OrgName;
                    oContextDet.LogoPath = objContextInfo.ContextInfo.LogoPath;
                    oContextDet.OrgAddressID = objContextInfo.ContextInfo.OrgAddressID;
                    oContextDet.RoleID = Convert.ToInt32(objContextInfo.ContextInfo.RoleID);
                    oContextDet.RoleName = objContextInfo.ContextInfo.RoleName;
                    oContextDet.UserID = objContextInfo.ContextInfo.UserID;
                    oContextDet.LoginID = objContextInfo.ContextInfo.LoginID;
                    oContextDet.LoginName = objContextInfo.ContextInfo.LoginName;
                    oContextDet.Age = objContextInfo.ContextInfo.Age;
                    oContextDet.LocationID = Convert.ToInt32(objContextInfo.ContextInfo.LocationID);
                    oContextDet.PharmacyLocationID = objContextInfo.ContextInfo.PharmacyLocationID;
                    oContextDet.IsTrustedOrg = objContextInfo.ContextInfo.IsTrustedOrg;
                    oContextDet.BaseCurrency = objContextInfo.ContextInfo.BaseCurrency;
                    oContextDet.CurrencyFormat = objContextInfo.ContextInfo.CurrencyFormat;
                    oContextDet.ThemeID = Convert.ToInt32(objContextInfo.ContextInfo.ThemeID);
                    oContextDet.CountryID = objContextInfo.ContextInfo.CountryID;
                    oContextDet.StateID = objContextInfo.ContextInfo.StateID;
                    oContextDet.LanguageCode = objContextInfo.ContextInfo.LanguageCode;
                    oContextDet.PageID = objContextInfo.ContextInfo.PageID;
                    oContextDet.SessionID = objContextInfo.ContextInfo.SessionID;
                    oContextDet.DepartmentName = objContextInfo.ContextInfo.DepartmentName;
                    oContextDet.AdditionalInfo = objContextInfo.ContextInfo.AdditionalInfo;
                    oContextDet.strvar = objContextInfo.ContextInfo.strvar;
                }
                lstContextDet.Add(oContextDet);
                #endregion

            }

            try
            {

                List<HolidayList> lstResult = new List<HolidayList>();

                HomeCollections_BL home_BlUI1 = new HomeCollections_BL(oContextDet);
                returnCode = home_BlUI1.GetHoliday(out lstResult);
                if (returnCode != -1)
                {
                    if (lstResult.Count > 0 && lstResult != null)
                    {
                        actionResult = Ok(lstResult);
                    }
                    else
                    {
                        actionResult = Ok("While fetching the data getting an Error.");
                    }
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }
            return actionResult;


        }



        [Route("Api/HomeCollection/PostSampleCollectionPerson")]
        [HttpPost]
        public IHttpActionResult PostSampleCollectionPerson(string pSCPerson, string pPinCode, long pUserID, SampleCollectionPerson objSCPInfo)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            long pOutstring = 0;
            long returnCode = -1;

            //var pOutstring = string.Empty;
            IHttpActionResult actionResult = null;

            List<SCPTimeinfo> lstTime = new List<SCPTimeinfo>();
            List<SCPLeaveinfo> lstLeave = new List<SCPLeaveinfo>();

            SCPTimeinfo objTime = null;
            SCPLeaveinfo objLeave = null;
            List<ContextDetails> lstContextDet = new List<ContextDetails>();

            ContextDetails oContextDet = null;

            ContextInfoModel objContextInfo = new ContextInfoModel();
            #region ContextDetail 

            if (objContextInfo != null)
            {


                if (objContextInfo.ContextInfo != null)
                {
                    oContextDet = new ContextDetails();
                    oContextDet.OrgID = Convert.ToInt32(objContextInfo.ContextInfo.OrgID);
                    oContextDet.OrgName = objContextInfo.ContextInfo.OrgName;
                    oContextDet.LogoPath = objContextInfo.ContextInfo.LogoPath;
                    oContextDet.OrgAddressID = objContextInfo.ContextInfo.OrgAddressID;
                    oContextDet.RoleID = Convert.ToInt32(objContextInfo.ContextInfo.RoleID);
                    oContextDet.RoleName = objContextInfo.ContextInfo.RoleName;
                    oContextDet.UserID = objContextInfo.ContextInfo.UserID;
                    oContextDet.LoginID = objContextInfo.ContextInfo.LoginID;
                    oContextDet.LoginName = objContextInfo.ContextInfo.LoginName;
                    oContextDet.Age = objContextInfo.ContextInfo.Age;
                    oContextDet.LocationID = Convert.ToInt32(objContextInfo.ContextInfo.LocationID);
                    oContextDet.PharmacyLocationID = objContextInfo.ContextInfo.PharmacyLocationID;
                    oContextDet.IsTrustedOrg = objContextInfo.ContextInfo.IsTrustedOrg;
                    oContextDet.BaseCurrency = objContextInfo.ContextInfo.BaseCurrency;
                    oContextDet.CurrencyFormat = objContextInfo.ContextInfo.CurrencyFormat;
                    oContextDet.ThemeID = Convert.ToInt32(objContextInfo.ContextInfo.ThemeID);
                    oContextDet.CountryID = objContextInfo.ContextInfo.CountryID;
                    oContextDet.StateID = objContextInfo.ContextInfo.StateID;
                    oContextDet.LanguageCode = objContextInfo.ContextInfo.LanguageCode;
                    oContextDet.PageID = objContextInfo.ContextInfo.PageID;
                    oContextDet.SessionID = objContextInfo.ContextInfo.SessionID;
                    oContextDet.DepartmentName = objContextInfo.ContextInfo.DepartmentName;
                    oContextDet.AdditionalInfo = objContextInfo.ContextInfo.AdditionalInfo;
                    oContextDet.strvar = objContextInfo.ContextInfo.strvar;
                }
                lstContextDet.Add(oContextDet);
                #endregion
            }
            try
            {
                if (objSCPInfo != null)
                {

                    if (objSCPInfo.TimeInfoList != null)
                    {
                        foreach (TimeslotModel item in objSCPInfo.TimeInfoList)
                        {
                            objTime = new SCPTimeinfo();
                            objTime.WorkingDays = item.WorkingDays;
                            objTime.StartTime = item.StartTime;
                            objTime.EndTime = item.EndTime;
                            objTime.SlotDuration = item.SlotDuration;

                            lstTime.Add(objTime);
                        }
                    }


                    if (objSCPInfo.LeaveInfoList != null)
                    {
                        foreach (LeaveslotModel item in objSCPInfo.LeaveInfoList)
                        {
                            objLeave = new SCPLeaveinfo();
                            objLeave.Holidays = item.Holidays;
                            objLeave.StartDate = item.StartDate;
                            objLeave.EndDate = item.EndDate;
                            lstLeave.Add(objLeave);
                        }
                    }

                    HomeCollections_BL home_BlUI1 = new HomeCollections_BL(oContextDet);
                    returnCode = home_BlUI1.PostSCPSchedule(pOrgCode, pSCPerson, pPinCode, pUserID, lstTime, lstLeave, out pOutstring);


                    if (returnCode != -1 && returnCode != 1001)
                    {
                        if(pOutstring == 0)
                        {
                            actionResult = Ok("Already Scheduled this Login User.");

                        }
                        else if (pOutstring == -1)
                        {
                            actionResult = Ok("Not a valid login user.");

                        }
                        else
                        {
                            actionResult = Ok("Sample Collection successfully inserted.");
                        }
                        
                    }
                    else
                    {
                        actionResult = Ok("Error on while inserting the Sample Collection");
                    }

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



        [Route("Api/HomeCollection/PostUpdateSampleCollectionPerson")]
        [HttpPost]
        public IHttpActionResult PostUpdateSampleCollectionPerson(long pResourceTemplateID,  string pPinCode, long pUserID, SampleCollectionPerson objSCPInfo)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            //if (headers.Contains("orgcode"))
            //{
            //    pOrgCode = headers.GetValues("orgcode").First();
            //}

            long returnCode = -1;

            var pOutstring = string.Empty;
            IHttpActionResult actionResult = null;

            List<SCPTimeinfo> lstTime = new List<SCPTimeinfo>();
            List<SCPLeaveinfo> lstLeave = new List<SCPLeaveinfo>();

            SCPTimeinfo objTime = null;
            SCPLeaveinfo objLeave = null;
            List<ContextDetails> lstContextDet = new List<ContextDetails>();

            ContextDetails oContextDet = null;

            ContextInfoModel objContextInfo = new ContextInfoModel();
            #region ContextDetail 

            if (objContextInfo != null)
            {


                if (objContextInfo.ContextInfo != null)
                {
                    oContextDet = new ContextDetails();
                    oContextDet.OrgID = Convert.ToInt32(objContextInfo.ContextInfo.OrgID);
                    oContextDet.OrgName = objContextInfo.ContextInfo.OrgName;
                    oContextDet.LogoPath = objContextInfo.ContextInfo.LogoPath;
                    oContextDet.OrgAddressID = objContextInfo.ContextInfo.OrgAddressID;
                    oContextDet.RoleID = Convert.ToInt32(objContextInfo.ContextInfo.RoleID);
                    oContextDet.RoleName = objContextInfo.ContextInfo.RoleName;
                    oContextDet.UserID = objContextInfo.ContextInfo.UserID;
                    oContextDet.LoginID = objContextInfo.ContextInfo.LoginID;
                    oContextDet.LoginName = objContextInfo.ContextInfo.LoginName;
                    oContextDet.Age = objContextInfo.ContextInfo.Age;
                    oContextDet.LocationID = Convert.ToInt32(objContextInfo.ContextInfo.LocationID);
                    oContextDet.PharmacyLocationID = objContextInfo.ContextInfo.PharmacyLocationID;
                    oContextDet.IsTrustedOrg = objContextInfo.ContextInfo.IsTrustedOrg;
                    oContextDet.BaseCurrency = objContextInfo.ContextInfo.BaseCurrency;
                    oContextDet.CurrencyFormat = objContextInfo.ContextInfo.CurrencyFormat;
                    oContextDet.ThemeID = Convert.ToInt32(objContextInfo.ContextInfo.ThemeID);
                    oContextDet.CountryID = objContextInfo.ContextInfo.CountryID;
                    oContextDet.StateID = objContextInfo.ContextInfo.StateID;
                    oContextDet.LanguageCode = objContextInfo.ContextInfo.LanguageCode;
                    oContextDet.PageID = objContextInfo.ContextInfo.PageID;
                    oContextDet.SessionID = objContextInfo.ContextInfo.SessionID;
                    oContextDet.DepartmentName = objContextInfo.ContextInfo.DepartmentName;
                    oContextDet.AdditionalInfo = objContextInfo.ContextInfo.AdditionalInfo;
                    oContextDet.strvar = objContextInfo.ContextInfo.strvar;
                }
                lstContextDet.Add(oContextDet);
                #endregion
            }
            try
            {
                if (objSCPInfo != null)
                {

                    if (objSCPInfo.TimeInfoList != null)
                    {
                        foreach (TimeslotModel item in objSCPInfo.TimeInfoList)
                        {
                            objTime = new SCPTimeinfo();
                            objTime.WorkingDays = item.WorkingDays;
                            objTime.StartTime = item.StartTime;
                            objTime.EndTime = item.EndTime;
                            objTime.SlotDuration = item.SlotDuration;

                            lstTime.Add(objTime);
                        }
                    }


                    if (objSCPInfo.LeaveInfoList != null)
                    {
                        foreach (LeaveslotModel item in objSCPInfo.LeaveInfoList)
                        {
                            objLeave = new SCPLeaveinfo();
                            objLeave.Holidays = item.Holidays;
                            objLeave.StartDate = item.StartDate;
                            objLeave.EndDate = item.EndDate;
                            lstLeave.Add(objLeave);
                        }
                    }

                    HomeCollections_BL home_BlUI1 = new HomeCollections_BL(oContextDet);
                    returnCode = home_BlUI1.PostUpdateSCPSchedule(pResourceTemplateID, pPinCode, pUserID, lstTime, lstLeave);


                    if (returnCode != -1 && returnCode != 1001)
                    {
                        actionResult = Ok("Sample Collection successfully inserted.");
                    }
                    else
                    {
                        actionResult = Ok("Error on while inserting the Sample Collection");
                    }

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



        [Route("Api/HomeCollection/GetScheduleBySCPDetails")]
        [HttpGet]
        public IHttpActionResult GetScheduleBySCPDetails( string pSCPerson)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }


            long returnCode = -1;

            var pOutstring = string.Empty;
            IHttpActionResult actionResult = null;

            long ResourceTemplateID = 0;

            List<SCPTimeinfo> lstTime = new List<SCPTimeinfo>();
            List<SCPLeaveinfo> lstLeave = new List<SCPLeaveinfo>();
            List<SCPPinCodeinfo> lstPinCode = new List<SCPPinCodeinfo>();
            List<ContextDetails> lstContextDet = new List<ContextDetails>();

            SCPResourceTemplate objResourceTemplate = null;

            List<SCPTime> lstSCPTime = null;
            SCPTime objSCPTimeList = null;

            List<SCPTimeinfo> lstSCPTimeDet = null;
            SCPTimeinfo objSCPTimeDet = null;

            List<SCPLeave> lstLeaveinfo = null;
            SCPLeave objLeaveList = null;

            //List<SCPLeave> lstLeave1 = null;
            //SCPLeave objlstLeave1 = null;


            List<SCPPinCodeinfo> lstPinCodeInfo = new List<SCPPinCodeinfo>();
            SCPPinCodeinfo objPinCodeList = null;



            ContextDetails oContextDet = null;

            ContextInfoModel objContextInfo = new ContextInfoModel();
            #region ContextDetail 

            if (objContextInfo != null)
            {


                if (objContextInfo.ContextInfo != null)

                {
                    oContextDet = new ContextDetails();
                    oContextDet.OrgID = Convert.ToInt32(objContextInfo.ContextInfo.OrgID);
                    oContextDet.OrgName = objContextInfo.ContextInfo.OrgName;
                    oContextDet.LogoPath = objContextInfo.ContextInfo.LogoPath;
                    oContextDet.OrgAddressID = objContextInfo.ContextInfo.OrgAddressID;
                    oContextDet.RoleID = Convert.ToInt32(objContextInfo.ContextInfo.RoleID);
                    oContextDet.RoleName = objContextInfo.ContextInfo.RoleName;
                    oContextDet.UserID = objContextInfo.ContextInfo.UserID;
                    oContextDet.LoginID = objContextInfo.ContextInfo.LoginID;
                    oContextDet.LoginName = objContextInfo.ContextInfo.LoginName;
                    oContextDet.Age = objContextInfo.ContextInfo.Age;
                    oContextDet.LocationID = Convert.ToInt32(objContextInfo.ContextInfo.LocationID);
                    oContextDet.PharmacyLocationID = objContextInfo.ContextInfo.PharmacyLocationID;
                    oContextDet.IsTrustedOrg = objContextInfo.ContextInfo.IsTrustedOrg;
                    oContextDet.BaseCurrency = objContextInfo.ContextInfo.BaseCurrency;
                    oContextDet.CurrencyFormat = objContextInfo.ContextInfo.CurrencyFormat;
                    oContextDet.ThemeID = Convert.ToInt32(objContextInfo.ContextInfo.ThemeID);
                    oContextDet.CountryID = objContextInfo.ContextInfo.CountryID;
                    oContextDet.StateID = objContextInfo.ContextInfo.StateID;
                    oContextDet.LanguageCode = objContextInfo.ContextInfo.LanguageCode;
                    oContextDet.PageID = objContextInfo.ContextInfo.PageID;
                    oContextDet.SessionID = objContextInfo.ContextInfo.SessionID;
                    oContextDet.DepartmentName = objContextInfo.ContextInfo.DepartmentName;
                    oContextDet.AdditionalInfo = objContextInfo.ContextInfo.AdditionalInfo;
                    oContextDet.strvar = objContextInfo.ContextInfo.strvar;
                }

                lstContextDet.Add(oContextDet);

              

                #endregion
            }

            HomeCollections_BL home_BlUI1 = new HomeCollections_BL(oContextDet);
            returnCode = home_BlUI1.GetScheduleBySCPDetails(pOrgCode, pSCPerson, out lstTime, out lstLeave, out lstPinCode, out lstSCPTime);


            if (returnCode != -1 && returnCode != 1001)
            {

                objSCPTimeList = new SCPTime();

                lstSCPTimeDet = new List<SCPTimeinfo>();

                objSCPTimeList.ResourceTemplateID = lstSCPTime[0].ResourceTemplateID;

                //if (lstSCPTime.Count > 0 && lstSCPTime != null)
                //{

                //    foreach (SCPResourceTemplate item in lstSCPTime)
                //    {
                //        objSCPTimeList.ResourceTemplateID = item.ResourceTemplateID;

                //    }
                //}


                if (lstTime.Count > 0 && lstTime != null)
                {

                    foreach (SCPTimeinfo item in lstTime)
                    {
                        objSCPTimeDet = new SCPTimeinfo();
                        objSCPTimeDet.WorkingDays = item.WorkingDays;
                        objSCPTimeDet.StartTime = item.StartTime;
                        objSCPTimeDet.EndTime = item.EndTime;
                        objSCPTimeDet.SlotDuration = item.SlotDuration;
                        objSCPTimeDet.DeleteType = item.DeleteType;
                        lstSCPTimeDet.Add(objSCPTimeDet);
                    }

                }

                if (lstSCPTimeDet.Count > 0 && lstSCPTimeDet != null)
                {

                    objSCPTimeList.SCPTimeInfoDet = lstSCPTimeDet;
                }



                lstLeaveinfo = new List<SCPLeave>();

                if (lstLeave.Count > 0 && lstLeave != null)
                {
                    foreach (SCPLeaveinfo item in lstLeave)
                    {
                        objLeaveList = new SCPLeave();
                        objLeaveList.StartDate = item.StartDate;
                        objLeaveList.EndDate = item.EndDate;
                        objLeaveList.Holidays = item.Holidays;

                        lstLeaveinfo.Add(objLeaveList);
                    }

                }


                if (lstLeaveinfo.Count > 0 && lstLeaveinfo != null)
                {

                    objSCPTimeList.SCPLeave = lstLeaveinfo;
                }


                lstPinCodeInfo = new List<SCPPinCodeinfo>();

                if (lstPinCode.Count > 0 && lstPinCode != null)
                {
                    foreach (SCPPinCodeinfo item in lstPinCode)
                    {
                        objPinCodeList = new SCPPinCodeinfo();
                        objPinCodeList.PinCode = item.PinCode;

                        lstPinCodeInfo.Add(objPinCodeList);
                    }

                }


                if (lstPinCodeInfo.Count > 0 && lstPinCodeInfo != null)
                {

                    objSCPTimeList.SCPPinCode = lstPinCodeInfo;
                }


              //  lstSCPTime.Add(objSCPTimeList);


                actionResult = Ok(objSCPTimeList);

            }

            else
            {
                actionResult = Ok("Error on while inserting the Sample Collection");
            }



            return actionResult;

        }

        [Route("Api/HomeCollection/GetSCPBookingslot")]
        [HttpGet]
        public IHttpActionResult GetSCPBookingslot(long pPinCode, string pSCPPerson, DateTime pCheckDate, long pUserID, int PPageCount)
        {

            long returnCode = -1;

            var pOutstring = string.Empty;
            IHttpActionResult actionResult = null;

            List<SCPBookingslot> lstSlot = new List<SCPBookingslot>();

            List<SCPBookingTimeWiseSlot> lstTimeWiseSlot = new List<SCPBookingTimeWiseSlot>();
            List<SCPBookingCount> lstBookingCount = new List<SCPBookingCount>();

            List<SCPBookingFinalSlot> lstSCPBookingFinalSlot = null;
            SCPBookingFinalSlot objSCPBookingFinalList = null;


            List<SCPBookingTimeWiseSlot> lstBookingTimeSlot = null;
            SCPBookingTimeWiseSlot objTimeWiseSlotList = null;

            List<SCPBookingCount> lstBookingslotCount = null;
            SCPBookingCount objBookingslotCount = null;

            List<SCPBookingslot> lstBookingSlot = null;
            SCPBookingslot objBookingslot = null;



            List<ContextDetails> lstContextDet = new List<ContextDetails>();

            ContextDetails oContextDet = null;

            ContextInfoModel objContextInfo = new ContextInfoModel();
            #region ContextDetail 

            if (objContextInfo != null)
            {


                if (objContextInfo.ContextInfo != null)

                {
                    oContextDet = new ContextDetails();
                    oContextDet.OrgID = Convert.ToInt32(objContextInfo.ContextInfo.OrgID);
                    oContextDet.OrgName = objContextInfo.ContextInfo.OrgName;
                    oContextDet.LogoPath = objContextInfo.ContextInfo.LogoPath;
                    oContextDet.OrgAddressID = objContextInfo.ContextInfo.OrgAddressID;
                    oContextDet.RoleID = Convert.ToInt32(objContextInfo.ContextInfo.RoleID);
                    oContextDet.RoleName = objContextInfo.ContextInfo.RoleName;
                    oContextDet.UserID = objContextInfo.ContextInfo.UserID;
                    oContextDet.LoginID = objContextInfo.ContextInfo.LoginID;
                    oContextDet.LoginName = objContextInfo.ContextInfo.LoginName;
                    oContextDet.Age = objContextInfo.ContextInfo.Age;
                    oContextDet.LocationID = Convert.ToInt32(objContextInfo.ContextInfo.LocationID);
                    oContextDet.PharmacyLocationID = objContextInfo.ContextInfo.PharmacyLocationID;
                    oContextDet.IsTrustedOrg = objContextInfo.ContextInfo.IsTrustedOrg;
                    oContextDet.BaseCurrency = objContextInfo.ContextInfo.BaseCurrency;
                    oContextDet.CurrencyFormat = objContextInfo.ContextInfo.CurrencyFormat;
                    oContextDet.ThemeID = Convert.ToInt32(objContextInfo.ContextInfo.ThemeID);
                    oContextDet.CountryID = objContextInfo.ContextInfo.CountryID;
                    oContextDet.StateID = objContextInfo.ContextInfo.StateID;
                    oContextDet.LanguageCode = objContextInfo.ContextInfo.LanguageCode;
                    oContextDet.PageID = objContextInfo.ContextInfo.PageID;
                    oContextDet.SessionID = objContextInfo.ContextInfo.SessionID;
                    oContextDet.DepartmentName = objContextInfo.ContextInfo.DepartmentName;
                    oContextDet.AdditionalInfo = objContextInfo.ContextInfo.AdditionalInfo;
                    oContextDet.strvar = objContextInfo.ContextInfo.strvar;
                }

                lstContextDet.Add(oContextDet);



                #endregion
            }

            HomeCollections_BL home_BlUI1 = new HomeCollections_BL(oContextDet);
            returnCode = home_BlUI1.GetSCPBookingslot(pPinCode, pSCPPerson, pCheckDate, pUserID, PPageCount, out lstSlot, out lstTimeWiseSlot, out lstBookingCount);

            if (returnCode != -1)
            {
                
                objSCPBookingFinalList = new SCPBookingFinalSlot();
                lstBookingSlot = new List<SCPBookingslot>();
                lstBookingTimeSlot = new List<SCPBookingTimeWiseSlot>();
                lstBookingslotCount = new List<SCPBookingCount>();


               
                //Table 1 loop
                if (lstSlot.Count > 0 && lstSlot != null)
                {

                    foreach (SCPBookingslot item in lstSlot)
                    {
                        objBookingslot = new SCPBookingslot();
                        objBookingslot.CheckingDate = item.CheckingDate;
                        objBookingslot.ClickDate = item.ClickDate;
                        objBookingslot.Available = item.Available;
                        lstBookingSlot.Add(objBookingslot);
                    }

                }

                if (lstBookingSlot.Count > 0 && lstBookingSlot != null)
                {

                    objSCPBookingFinalList.SCPBookingTable1 = lstBookingSlot;
                }

                //Table 2 loop

             

                if (lstTimeWiseSlot.Count > 0 && lstTimeWiseSlot != null)
                {

                    foreach (SCPBookingTimeWiseSlot item in lstTimeWiseSlot)
                    {
                        objTimeWiseSlotList = new SCPBookingTimeWiseSlot();
                        objTimeWiseSlotList.AutoID = item.AutoID;
                        objTimeWiseSlotList.ResourceID = item.ResourceID;
                        objTimeWiseSlotList.ResourceName = item.ResourceName;
                        objTimeWiseSlotList.ResourceTemplateID = item.ResourceTemplateID;
                        objTimeWiseSlotList.ClickDate = item.ClickDate;
                        objTimeWiseSlotList.SlotDuration = item.SlotDuration;
                        objTimeWiseSlotList.BookedSlot = item.BookedSlot;
                        lstBookingTimeSlot.Add(objTimeWiseSlotList);
                    }

                }

                if (lstBookingTimeSlot.Count > 0 && lstBookingTimeSlot != null)
                {

                    objSCPBookingFinalList.SCPBookingTable2 = lstBookingTimeSlot;
                }

                //Table 3 loop


                if (lstBookingCount.Count > 0 && lstBookingCount != null)
                {

                    foreach (SCPBookingCount item in lstBookingCount)
                    {
                        objBookingslotCount = new SCPBookingCount();
                        objBookingslotCount.AutoID = item.AutoID;
                        objBookingslotCount.ResourceTemplateID = item.ResourceTemplateID;
                        objBookingslotCount.ResourceName = item.ResourceName;
                        objBookingslotCount.SCPCount = item.SCPCount;
                        lstBookingslotCount.Add(objBookingslotCount);
                    }

                }

                if (lstBookingslotCount.Count > 0 && lstBookingslotCount != null)
                {

                    objSCPBookingFinalList.SCPBookingTable3 = lstBookingslotCount;
                }


                actionResult = Ok(objSCPBookingFinalList);
              
                
            }
            else
            {
                actionResult = Ok("While fetching the data getting an Error.");
            }
            return actionResult;
        }


        [Route("Api/HomeCollection/PostUpdateBookingSchedule")]
        [HttpGet]
        public IHttpActionResult PostUpdateBookingSchedule(string pBookingID, string pTechID, string pBookingDate, string pLoginID)
        {
            string pType = string.Empty;
            long returnCode = -1;
            List<ContextDetails> lstContextDet = new List<ContextDetails>();
            ContextDetails oContextDet = null;
            IHttpActionResult actionResult = null;
            ContextInfoModel objContextInfo = new ContextInfoModel();
            #region ContextDetail 
            if (objContextInfo != null)
            {
                if (objContextInfo.ContextInfo != null)
                {
                    oContextDet = new ContextDetails();
                    oContextDet.OrgID = Convert.ToInt32(objContextInfo.ContextInfo.OrgID);
                    oContextDet.OrgName = objContextInfo.ContextInfo.OrgName;
                    oContextDet.LogoPath = objContextInfo.ContextInfo.LogoPath;
                    oContextDet.OrgAddressID = objContextInfo.ContextInfo.OrgAddressID;
                    oContextDet.RoleID = Convert.ToInt32(objContextInfo.ContextInfo.RoleID);
                    oContextDet.RoleName = objContextInfo.ContextInfo.RoleName;
                    oContextDet.UserID = objContextInfo.ContextInfo.UserID;
                    oContextDet.LoginID = objContextInfo.ContextInfo.LoginID;
                    oContextDet.LoginName = objContextInfo.ContextInfo.LoginName;
                    oContextDet.Age = objContextInfo.ContextInfo.Age;
                    oContextDet.LocationID = Convert.ToInt32(objContextInfo.ContextInfo.LocationID);
                    oContextDet.PharmacyLocationID = objContextInfo.ContextInfo.PharmacyLocationID;
                    oContextDet.IsTrustedOrg = objContextInfo.ContextInfo.IsTrustedOrg;
                    oContextDet.BaseCurrency = objContextInfo.ContextInfo.BaseCurrency;
                    oContextDet.CurrencyFormat = objContextInfo.ContextInfo.CurrencyFormat;
                    oContextDet.ThemeID = Convert.ToInt32(objContextInfo.ContextInfo.ThemeID);
                    oContextDet.CountryID = objContextInfo.ContextInfo.CountryID;
                    oContextDet.StateID = objContextInfo.ContextInfo.StateID;
                    oContextDet.LanguageCode = objContextInfo.ContextInfo.LanguageCode;
                    oContextDet.PageID = objContextInfo.ContextInfo.PageID;
                    oContextDet.SessionID = objContextInfo.ContextInfo.SessionID;
                    oContextDet.DepartmentName = objContextInfo.ContextInfo.DepartmentName;
                    oContextDet.AdditionalInfo = objContextInfo.ContextInfo.AdditionalInfo;
                    oContextDet.strvar = objContextInfo.ContextInfo.strvar;
                }
                lstContextDet.Add(oContextDet);
                #endregion
            }
            try
            {
                HomeCollections_BL home_BlUI1 = new HomeCollections_BL(oContextDet);
                returnCode = home_BlUI1.PostUpdateBookingSchedule(pBookingID, pTechID, pBookingDate, pLoginID);
                if (returnCode != -1)
                {
                        actionResult = Ok(returnCode);
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }
            return actionResult;
        }
        [Route("Api/HomeCollection/CheckDuplicateBookingSlot")]
        [HttpPost]
        public IHttpActionResult CheckDuplicateBookingSlot(string pPincode, string pUserID, string PDate, string pTime )
        {
            string pType = string.Empty;
            string one = PDate;
            string two = pTime;
            DateTime newDateTime = Convert.ToDateTime(one).Add(TimeSpan.Parse(two));
            DateTime pCollectionTime = newDateTime;
            long returnCode = -1;
            long pOutstring = 0;
            List<ContextDetails> lstContextDet = new List<ContextDetails>();
            ContextDetails oContextDet = null;
            IHttpActionResult actionResult = null;
            ContextInfoModel objContextInfo = new ContextInfoModel();
            #region ContextDetail 
            if (objContextInfo != null)
            {
                if (objContextInfo.ContextInfo != null)
                {
                    oContextDet = new ContextDetails();
                    oContextDet.OrgID = Convert.ToInt32(objContextInfo.ContextInfo.OrgID);
                    oContextDet.OrgName = objContextInfo.ContextInfo.OrgName;
                    oContextDet.LogoPath = objContextInfo.ContextInfo.LogoPath;
                    oContextDet.OrgAddressID = objContextInfo.ContextInfo.OrgAddressID;
                    oContextDet.RoleID = Convert.ToInt32(objContextInfo.ContextInfo.RoleID);
                    oContextDet.RoleName = objContextInfo.ContextInfo.RoleName;
                    oContextDet.UserID = objContextInfo.ContextInfo.UserID;
                    oContextDet.LoginID = objContextInfo.ContextInfo.LoginID;
                    oContextDet.LoginName = objContextInfo.ContextInfo.LoginName;
                    oContextDet.Age = objContextInfo.ContextInfo.Age;
                    oContextDet.LocationID = Convert.ToInt32(objContextInfo.ContextInfo.LocationID);
                    oContextDet.PharmacyLocationID = objContextInfo.ContextInfo.PharmacyLocationID;
                    oContextDet.IsTrustedOrg = objContextInfo.ContextInfo.IsTrustedOrg;
                    oContextDet.BaseCurrency = objContextInfo.ContextInfo.BaseCurrency;
                    oContextDet.CurrencyFormat = objContextInfo.ContextInfo.CurrencyFormat;
                    oContextDet.ThemeID = Convert.ToInt32(objContextInfo.ContextInfo.ThemeID);
                    oContextDet.CountryID = objContextInfo.ContextInfo.CountryID;
                    oContextDet.StateID = objContextInfo.ContextInfo.StateID;
                    oContextDet.LanguageCode = objContextInfo.ContextInfo.LanguageCode;
                    oContextDet.PageID = objContextInfo.ContextInfo.PageID;
                    oContextDet.SessionID = objContextInfo.ContextInfo.SessionID;
                    oContextDet.DepartmentName = objContextInfo.ContextInfo.DepartmentName;
                    oContextDet.AdditionalInfo = objContextInfo.ContextInfo.AdditionalInfo;
                    oContextDet.strvar = objContextInfo.ContextInfo.strvar;
    }
                lstContextDet.Add(oContextDet);
                #endregion
            }
            try
            {
                HomeCollections_BL home_BlUI1 = new HomeCollections_BL(oContextDet);
                returnCode = home_BlUI1.CheckDuplicateBookingSlot(pPincode, pUserID, pCollectionTime, out pOutstring);
                if (returnCode != -1)
                {
                    actionResult = Ok(pOutstring);
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }
            return actionResult;
        }
    }
}