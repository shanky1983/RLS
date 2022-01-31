using System;
using System.Collections.Generic;
using System.Web.Http;
using Attune.Kernel.LIMSAPI.BL;
using Attune.Kernel.LIMSAPI.BusinessEntities;
using System.Web.Http.Description;
using System.Linq;
using Attune.KernelV2;
using LIMSAPI.Models;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Drawing;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.File;

namespace LIMSAPI.Controllers
{
    public class PatientController : BaseApiController
    {


        /// <summary>
        /// This API returns the PatientRegistrationData those registered on specific date
        /// If PatientNumber is specified in parameter. It will return details of the specific Patient
        /// </summary>
        ///

        ///<param name = "pPatientNumber" >PatientNumber of AttuneLIMS</param >
        ///<param name = "pRegistereddate" >Patient RegistrationDate</param >
        ///<param name = "Page" >Parameter to hanlde paging</param >
        ///<param name = "Size" >Parameter to specify No.Of.Records in single page</param >
        ///
        /// /// <returns>success</returns>
        [ResponseType(typeof(PatientRegistrationData))]
        [HttpGet]
        [Route("Api/Patient/GetRegistration")]
        public IHttpActionResult GetPatientInfo(string pPatientNumber, DateTime pRegistereddate, int Page, int Size)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }
            if (string.IsNullOrEmpty(pPatientNumber))
            {
                pPatientNumber = string.Empty;
            }
            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<PatientRegistrationInfo> lstPatientRegistrationInfo = new List<PatientRegistrationInfo>();
            List<PatientRegistrationInfo> lstPatientRegistrationInfoDetails = new List<PatientRegistrationInfo>();
            List<Paging> lstPages = new List<Paging>();
            PatientRegistrationData objPatientRegistrationData = new PatientRegistrationData();
            try
            {
                returnCode = new LIMSAPI_BL().GetPatientInfo__LIMSAPI(pOrgCode, pPatientNumber, pRegistereddate, Page, Size, out lstPatientRegistrationInfo, out lstPages);

                if (returnCode != -1)
                {
                    if (lstPatientRegistrationInfo.Count > 0 && lstPatientRegistrationInfo != null)
                    {

                        var lstPatientRegDetailsInfo = new List<PatientRegistrationDetailsInfo>();
                        lstPatientRegDetailsInfo = lstPatientRegistrationInfo.Select(i => new PatientRegistrationDetailsInfo
                        {
                            PatientID = i.PatientID,
                            Salutation = i.Salutation,
                            Name = i.PatientName,
                            FirstName = i.FirstName,
                            MiddleName = i.MiddleName,
                            LastName = i.LastName,
                            Age = i.Age,
                            Gender = i.Gender,
                            DOB = i.DateofBirth,
                            Address = i.Address,
                            City = i.City,
                            State = i.State,
                            Country = i.Country,
                            PinCode = i.PostalCode,
                            MobileNumber = i.MobileNumber,
                            EmailID = i.Email,
                            URNType = i.URNType,
                            URNNo = i.URNNo,
                            DateOfRegistration = i.DateOfRegistration,

                            Source = i.Source,

                            Status = i.Status,

                        }).ToList();






                        objPatientRegistrationData.OrgCode = pOrgCode;
                        objPatientRegistrationData.OrgID = lstPatientRegistrationInfo[0].OrgID;
                        objPatientRegistrationData.LocationID = lstPatientRegistrationInfo[0].LocationID;
                        objPatientRegistrationData.Type = "Patient Registration Information";

                        objPatientRegistrationData.PatientRegistrationInfo = lstPatientRegDetailsInfo;
                        objPatientRegistrationData.TotalRecords = lstPages[0].TotalRecords;
                        objPatientRegistrationData.TotalPages = lstPages[0].TotalPages;
                        objPatientRegistrationData.AllowableRecordCount = lstPages[0].AllowableRecordCount;

                        actionResult = Ok(objPatientRegistrationData);

                    }
                    else
                    {
                        actionResult = Ok("Result not Found");
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
        /// This API will receive Registration and Order Information and generate VisitNumber with Orders in Attune LIMS
        /// </summary>
        /// <param name="pType">Default Value is RegisterOrder</param>
        /// <param name="patient">Patient and Orders Information </param>
        /// <returns></returns>
        [ResponseType(typeof(PatientRegOrderModel))]
        [HttpPost]
        [Route("Api/Patient/PatientRegisterOrder")]
        public IHttpActionResult PAtientRegisterOrder(string pType, PatientRegOrderModel patient)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }
            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<PatientRegOrderCreation> lstPatientInfo = new List<PatientRegOrderCreation>();

            try
            {
                if (patient != null)
                {
                    PatientRegOrderCreation patientInfo = new PatientRegOrderCreation();

                    patientInfo.BookingID = patient.BookingID;
                    patientInfo.UserID = patient.UserID;
                    patientInfo.TitleName = patient.TitleName;
                    patientInfo.PatientName = patient.PatientName;
                
                    patientInfo.FirstName = patient.FirstName;
                    patientInfo.MiddleName = patient.MiddleName;
                    patientInfo.LastName = patient.LastName;
                    patientInfo.Age = patient.Age;
                    patientInfo.Gender = patient.Gender;
                    patientInfo.Address = patient.Address;

                    patientInfo.MobileNumber = patient.MobileNumber;

                    if (Convert.ToDateTime(patient.DateofBrith).ToString("yyyy") == "0001")
                        patientInfo.DateofBrith = DateTime.MaxValue;
                    else
                        patientInfo.DateofBrith = patient.DateofBrith;

                  

                    patientInfo.EmailID = patient.EmailID;
                    
                  
                    patientInfo.City = patient.City;
                      patientInfo.Country = patient.Country;
                    patientInfo.State = patient.State;
                    patientInfo.PostalCode = patient.PostalCode;
                    patientInfo.TRFFile = patient.TRFFile;
                   
           
                   
                    patientInfo.URNType = patient.URNType;
                    patientInfo.URNNo = patient.URNNo;

                    


                    if (Convert.ToDateTime(patient.DateOfRegistration).ToString("yyyy") == "0001")
                        patientInfo.DateOfRegistration = DateTime.MaxValue;
                    else
                        patientInfo.DateOfRegistration = patient.DateOfRegistration;

                    patientInfo.ClientCode = patient.ClientCode;
                    patientInfo.DispatchType = patient.DispatchType;
                    patientInfo.SampleID = patient.SampleID;
                    patientInfo.SampleName = patient.SampleName;
                    patientInfo.ContainerID = patient.ContainerID;
                    patientInfo.ContainerName = patient.ContainerName;
                    patientInfo.SampleContainerColour = patient.SampleContainerColour;
                    if (Convert.ToDateTime(patient.SampleCollectionTime).ToString("yyyy") == "0001")
                        patientInfo.SampleCollectionTime = DateTime.MaxValue;
                    else
                        patientInfo.SampleCollectionTime = patient.SampleCollectionTime;
                    patientInfo.SampleStatus = patient.SampleStatus;
                    patientInfo.ReasonSampleCollected = patient.ReasonSampleCollected;
                    patientInfo.TestName = patient.TestName;
                    patientInfo.Price = patient.Price;
                    patientInfo.TotalGrossAmount = patient.TotalGrossAmount;
                    patientInfo.DiscountAmount = patient.DiscountAmount;
                    patientInfo.NetAmount = patient.NetAmount;
                    patientInfo.ReceivedAmount = patient.ReceivedAmount;
                    patientInfo.DueAmount = patient.DueAmount;
                    patientInfo.PaymentStatus = patient.PaymentStatus;
                    patientInfo.PaymentMode = patient.PaymentMode;
                    patientInfo.CardDetails = patient.CardDetails;
                    patientInfo.PaymentReferenceNo = patient.PaymentReferenceNo;
                    patientInfo.ExternalVisitID = patient.ExternalVisitID;
                    patientInfo.PatientID = patient.PatientID;
                    patientInfo.CreatedBy = patient.CreatedBy;

                    if (Convert.ToDateTime(patient.CreatedAt).ToString("yyyy") == "0001")
                        patientInfo.CreatedAt = DateTime.MaxValue;
                    else
                        patientInfo.CreatedAt = patient.CreatedAt;
                    patientInfo.ModifiedBy = patient.ModifiedBy;

                    if (Convert.ToDateTime(patient.ModifiedAt).ToString("yyyy") == "0001")
                        patientInfo.ModifiedAt = DateTime.MaxValue;
                    else
                        patientInfo.ModifiedAt = patient.ModifiedAt;
                    patientInfo.IsProcessYN = patient.IsProcessYN;
                   
                    patientInfo.OrgID = patient.OrgID;
                    patientInfo.LocationID = patient.LocationID;
                   
                    patientInfo.Source = patient.Source;
                    patientInfo.Status = patient.Status;
                    patientInfo.ClientID = patient.ClientID;
                    patientInfo.Error = patient.Error;
                    patientInfo.Remarks = patient.Remarks;
                    lstPatientInfo.Add(patientInfo);

                    if (lstPatientInfo != null)
                    {
                        returnCode = new LIMSAPI_BL().InsertPatientRegOrder(pOrgCode,pType, lstPatientInfo);

                        if (returnCode != -1)
                        {
                            actionResult = Ok("Record Inserted Successfully processed.");
                        }
                        else
                        {
                            actionResult = Ok("Result Not Found");
                        }
                    }
                }
                else
                {
                    actionResult = Ok("Patient Registration Information not found");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }

            return actionResult;
        }

        /// <summary>
        /// This API will receive Registration and Order Information and generate VisitNumber with Orders in Attune LIMS
        /// </summary>
        /// <param name="pType">Default Value is RegisterOrder</param>
        /// <param name="patient">Patient and Orders Information </param>
        /// <returns></returns>
        [ResponseType(typeof(RegisterOrderModel))]
        [HttpPost]
        [Route("Api/Patient/RegisterOrder")]
        public IHttpActionResult RegisterOrder(RegisterOrderModel objpatient)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }
            long returnCode = -1;
            long returncode = -1;
            IHttpActionResult actionResult = null;
            List<RegisterOrderInfo> lstRegisterOrderInfo = new List<RegisterOrderInfo>();
            //    List<BookingInfo> lstBooking = new List<BookingInfo>();
            List<Paymentdetail> lstPayment = new List<Paymentdetail>();
            List<RegisterOrderInfo> lstOrders = new List<RegisterOrderInfo>();
            RegisterOrderInfo objRegOrder = null;
            Paymentdetail objPayment = null;
            RegisterOrderInfo objorder = null;
            try
            {
                if (objpatient != null)
                {
                    string pType = objpatient.TransType;
                    objRegOrder = new RegisterOrderInfo();

                    objRegOrder.PatRegOrderID = objpatient.OrderID;
                    objRegOrder.MessageType = objpatient.MessageType;

                    #region PatientVisitInfo 
                    if (objpatient.PatientVisitInfo != null)
                    {
                        //       objRegOrder.OrgID = objpatient.PatientVisitInfo.OrgID;
                        //    objRegOrder.LocationID = objpatient.BookingInfo.LocationID;
                        objRegOrder.PatientVisitId = objpatient.PatientVisitInfo.PatientVisitId;
                        objRegOrder.ExternalVisitNumber = objpatient.PatientVisitInfo.ExternalVisitNumber;
                        objRegOrder.VisitType = objpatient.PatientVisitInfo.VisitType;
                        objRegOrder.ClientCode = objpatient.PatientVisitInfo.ClientCode;
                        objRegOrder.ClientName = objpatient.PatientVisitInfo.ClientName;
                        objRegOrder.ReferingDoctorCode = objpatient.PatientVisitInfo.ReferingDoctorCode;
                        objRegOrder.ReferingDoctorName = objpatient.PatientVisitInfo.ReferingDoctorName;
                        objRegOrder.ReferingDoctorMobileNumber = objpatient.PatientVisitInfo.ReferingDoctorMobileNumber;

                        objRegOrder.IsNotification = objpatient.PatientVisitInfo.IsNotification;

                        objRegOrder.HospitalNameCode = objpatient.PatientVisitInfo.HospitalNameCode;

                        objRegOrder.HospitalName = objpatient.PatientVisitInfo.HospitalName;

                        objRegOrder.VisitHistory = objpatient.PatientVisitInfo.VisitHistory;

                        objRegOrder.VisitRemarks = objpatient.PatientVisitInfo.VisitRemarks;
                        objRegOrder.ExternalVisitID = objpatient.PatientVisitInfo.ExternalVisitNumber;


                    }
                    #endregion

                    #region Patient
                    if (objpatient.PatientInfo != null)
                    {
                        objRegOrder.FirstName = objpatient.PatientInfo.FirstName;
                        objRegOrder.MiddleName = objpatient.PatientInfo.MiddleName;
                        objRegOrder.LastName = objpatient.PatientInfo.LastName;
                        objRegOrder.SalutationCode = objpatient.PatientInfo.SalutationCode;
                        objRegOrder.Age = objpatient.PatientInfo.Age;
                        objRegOrder.Gender = objpatient.PatientInfo.Gender;

                        if (Convert.ToDateTime(objpatient.PatientInfo.DOB).ToString("yyyy") == "0001")
                            objRegOrder.DateofBirth = DateTime.MaxValue;
                        else
                            objRegOrder.DateofBirth = objpatient.PatientInfo.DOB;
                        objRegOrder.MobileNumber = objpatient.PatientInfo.MobileNumber;
                        objRegOrder.Email = objpatient.PatientInfo.Email;
                        objRegOrder.URNType = objpatient.PatientInfo.URNType;
                        objRegOrder.URNNo = objpatient.PatientInfo.URNNumber;

                        if (objpatient.PatientInfo.AddressDetails != null)
                        {
                            foreach (AddressModel item in objpatient.PatientInfo.AddressDetails)
                            {
                                objRegOrder.AddressType = item.AddressType;
                                objRegOrder.Address = item.Address;
                                objRegOrder.City = item.City;
                                objRegOrder.State = item.State;
                                objRegOrder.Country= item.Country;
                                objRegOrder.PostalCode = item.PostalCode;
                            }
                        }
                    }
                    #endregion
                  
                    #region Orders   
                    if (objpatient.TestDetailsList != null)
                    {
                        foreach (OrdersModel item in objpatient.TestDetailsList)
                        {
                            objorder = new RegisterOrderInfo();
                            objorder.Status = item.Status;
                            objorder.TestCode = item.TestCode;
                            objorder.TestName = item.TestName;

                            objorder.IsStat = item.IsStat;
                            objorder.Price = item.Price;
                            objorder.TestClinicalHistory = item.TestClinicalHistory;
                            objorder.Instructions = item.Instructions;
                            objorder.Remarks = item.Remarks;
                        

                            lstOrders.Add(objorder);
                        }
                    }
                    #endregion


                    #region BillingInfo
                    if (objpatient.PatientInfo != null)
                    {
                        objRegOrder.PaymentStatus = objpatient.BillingInfo.PaymentStatus;
                        objRegOrder.TotalGrossAmount = objpatient.BillingInfo.GrossAmount;
                        objRegOrder.DiscountAmount = objpatient.BillingInfo.Discount;
                        objRegOrder.NetAmount = objpatient.BillingInfo.NetAmount;
                        objRegOrder.DueAmount = objpatient.BillingInfo.DueAmount;
    }
                    #endregion BillingInfo
                    #region PaymentInfo   
                    if (objpatient.PaymentDetailsList != null)
                    {
                        foreach (PaymentsModel item in objpatient.PaymentDetailsList)
                        {
                            objPayment = new Paymentdetail();
                        
                            objPayment.PaymentMode = item.PaymentType;
                            objPayment.TransactionID = item.ReferenceNo;
                            objPayment.ReceivedAmount = item.AmountReceived;


        lstPayment.Add(objPayment);
                        }
                    }
                    #endregion

                    objRegOrder.SourceType = objpatient.SourceType;
                    objRegOrder.JsonValue = JsonConvert.SerializeObject(objpatient);
                    lstRegisterOrderInfo.Add(objRegOrder);

                        if (lstRegisterOrderInfo != null)
                        {
                            returnCode = new LIMSAPI_BL().InsertRegisterOrder(pOrgCode, pType, lstRegisterOrderInfo, lstPayment, lstOrders);

                            if (returnCode != -1)
                            {
                                actionResult = Ok("Record Inserted Successfully processed.");
                                //#region TRF File
                                //var obj = new ImageConvertor();
                                //UploadBookingImageModel objimg = new UploadBookingImageModel();
                                ////   objimg.ImageData = Convert.FromBase64String(objBookingInfo.BookingInfo.TRFFile);

                                ////   Convert.ToBase64String(objBookingInfo.BookingInfo.ImageData)
                                //objimg.ImageData = objpatient..TRFFile;
                                //List<Config> lstConfig = new List<Config>();
                                ////  Stream stream = new MemoryStream(file);
                                //byte[] byteArray = Convert.FromBase64String(objimg.ImageData);


                                //var imageDataStream = new MemoryStream(byteArray);
                                //imageDataStream.Position = 0;

                                //Image returnImage = Image.FromStream(imageDataStream);
                                //returncode = new LIMSAPI_BL().GetConfigHCDetails(pOrgCode, "TRF_UploadPath", out lstConfig);
                                //string pathname = lstConfig[0].ConfigValue.ToString();

                                ////DateTime dt = new DateTime();
                                ////dt = Convert.ToDateTime(new DateTime());

                                ////int Year = dt.Year;
                                ////int Month = dt.Month;
                                ////int Day = dt.Day;
                                //DateTime dt = DateTime.Now;
                                //int Year = dt.Year;
                                //int Month = dt.Month;
                                //int Day = dt.Day;

                                ////Root Path =D:\ATTUNE_UPLOAD_FILES\TRF_Upload\67\2013\10\9\123456\14_A.pdf

                                //String Root = String.Empty;
                                //String RootPath = String.Empty;
                                ////Root = ATTUNE_UPLOAD_FILES\TRF_Upload\ + OrgID + '\' + Year + '\' + Month + '\' + Day + '/' + Visitnumber ;
                                //Root = "TRF_Upload-" + lstConfig[0].OrgID + "-" + Year + "-" + Month + "-" + Day + "-" + "Home_Collection" + "-";
                                //Root = Root.Replace("-", "\\\\");
                                //RootPath = pathname + Root;





                                //System.Drawing.Image imageIn = obj.ConvertByteArrayToImage(byteArray);
                                ////  String path = HttpContext.Current.Server.MapPath("~/images/Games"); //Path

                                ////Check if directory exist
                                //if (!System.IO.Directory.Exists(RootPath))
                                //{
                                //    System.IO.Directory.CreateDirectory(RootPath); //Create directory if it doesn't exist
                                //}
                                //string imageName = objpatient.BookingInfo.ExternalRefNo + ".png";

                                ////set the image path
                                //string imgPath = Path.Combine(RootPath, imageName);

                                //string Type = "TRF_Upload_APKNew_Outside_Home_Collection";



                                //File.WriteAllBytes(imgPath, byteArray);

                                //returnCode = new LIMSAPI_BL().SaveTRFHCDetails(pOrgCode, imageName, objpatient.BookingInfo.ExternalRefNo, objpatient.BookingInfo.ExternalRefNo, Type, objpatient.SourceType, RootPath);

                                //#endregion
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
        /// This API provides functionality of Patient Registration and generate PatientID in Attune LIMS.
        /// </summary>
        /// <param name="pType">Default Value is RegisterPatient</param>
        /// <param name="patient">Patient Registration JSON Data</param>
        /// <returns></returns>
        [ResponseType(typeof(PatientRegistrationModel))]
        [HttpPost]
        [Route("Api/Patient/RegisterPatient")]
        public IHttpActionResult PatientRegistration(string pType, PatientRegistrationModel patient)
        {
            long returnCode = -1;
            IHttpActionResult actionResult = null;

            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            List<PatientRegistrationInfo> lstPatientInfo = new List<PatientRegistrationInfo>();

            try
            {
                if (patient != null)
                {
                    PatientRegistrationInfo patientInfo = new PatientRegistrationInfo();

                    patientInfo.PatientID = patient.PatientID;
                    patientInfo.PatientName = patient.Name;
                    patientInfo.Gender = patient.Gender;
                    patientInfo.Age = patient.Age;
                    if (Convert.ToDateTime(patient.DOB).ToString("yyyy") == "0001")
                        patientInfo.DateofBirth = DateTime.MaxValue;
                    else
                    patientInfo.DateofBirth = patient.DOB;
                    patientInfo.Email = patient.Email;
                    patientInfo.Salutation = patient.Salutation;
                    patientInfo.Address = patient.Address;
                    patientInfo.City = patient.City;
                    patientInfo.State = patient.State;
                    patientInfo.Country = patient.Country;
                    patientInfo.OrgID = patient.OrgID;
                    patientInfo.LocationID = patient.AddressID;

                    if (Convert.ToDateTime(patient.DateOfRegistration).ToString("yyyy") == "0001")
                        patientInfo.DateOfRegistration = DateTime.MaxValue;
                    else
                    patientInfo.DateOfRegistration = patient.DateOfRegistration;
                    patientInfo.MobileNumber = patient.MobileNumber;
                    patientInfo.PostalCode = patient.PostalCode;
                    patientInfo.URNNo = patient.URNNo;
                    patientInfo.URNType = patient.URNType;
                    patientInfo.Source = patient.Source;
                    patientInfo.Status = patient.Status;
                    patientInfo.ClientID = patient.ClientID;
                    patientInfo.CreatedBy = patient.CreatedBy;
                    if (Convert.ToDateTime(patient.CreatedAt).ToString("yyyy") == "0001")
                        patientInfo.CreatedAt = DateTime.MaxValue;
                    else
                        patientInfo.CreatedAt = patient.CreatedAt;

                    patientInfo.ModifiedBy = patient.ModifiedBy;
                    if (Convert.ToDateTime(patient.ModifiedAt).ToString("yyyy") == "0001")
                        patientInfo.ModifiedAt = DateTime.MaxValue;
                    else
                        patientInfo.ModifiedAt = patient.ModifiedAt;
                    patientInfo.ISProcessed = patient.ISProcessed;

                    lstPatientInfo.Add(patientInfo);

                    if (lstPatientInfo != null)
                    {
                        returnCode = new LIMSAPI_BL().InsertPatientRegInformation(pOrgCode, pType, lstPatientInfo);
                        
                        if (returnCode >= 0 && returnCode !=1001)
                        {
                            actionResult = Ok("Following the PatientID : "+ patient.PatientID + " Successfully processed.");
                        }
                        else
                        {
                            actionResult = Ok("Error on while updating the Patient Register data");
                        }
                    }
                }
                else
                {
                    actionResult = Ok("Patient Registration Information not found");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }

            return actionResult;
        }
         /// <summary>
        /// This API will get patient visit details
        /// </summary>
        /// <param name="pPatientNumber"></param>        
        /// <returns></returns>
        [ResponseType(typeof(PatientVisits))]
        [HttpGet]
        [Route("Api/Patient/GetPatientVisitDetailsInfo")]
        public IHttpActionResult GetPatientVisitDetailsInfo(string pPatientNumber)
        {

            long returnCode = -1;
            IHttpActionResult actionResult = null;

            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            if (string.IsNullOrEmpty(pPatientNumber))
            {
                pPatientNumber = string.Empty;
            }
            PatientVisits objPatvisit = new PatientVisits();
            List<PatientVisitInfo> lstPatientInfo = new List<PatientVisitInfo>();

            List<PatientVisit> lstvisitPatient = new List<PatientVisit>(); 

            try
            {
                returnCode = new LIMSAPI_BL().GetPatientVisitDetailsInfo(pOrgCode, pPatientNumber, out lstPatientInfo);

                if (returnCode != -1)
                {
                    if (lstPatientInfo.Count > 0 && lstPatientInfo != null)
                    {
                        objPatvisit.PatientID = lstPatientInfo[0].PatientID;
                        objPatvisit.PatientNumber = lstPatientInfo[0].PatientNumber;
                        objPatvisit.OrgCode = lstPatientInfo[0].OrgCode;
                        objPatvisit.OrgName = lstPatientInfo[0].OrgName;
                        objPatvisit.PatientName = lstPatientInfo[0].PatientName;
                        foreach (PatientVisitInfo item in lstPatientInfo)
                        {
                            PatientVisit objvisit = new PatientVisit();
                            objvisit.VisitNumber = item.VisitNumber;
                            objvisit.VisitDate = item.VisitDate;
                            objvisit.LocationCode = item.LocationCode;
                            objvisit.LocationName = item.LocationName;
                            objvisit.ClientName = item.ClientName;
                            objvisit.ClientCode = item.ClientCode;
                            lstvisitPatient.Add(objvisit);
                        }
                        objPatvisit.lstVisitDetailInfo = lstvisitPatient;
                        actionResult = Ok(objPatvisit);
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

        /* not required may be used for future purpose
         /// <summary>
        /// This API will insert the InfectionTestResultInfo
        /// </summary>
        /// <param name="pType"></param>
        /// <param name="InfectionTestResult"></param>
        /// <returns></returns>
        [ResponseType(typeof(InfectionTestResultInfo))]
        [HttpPost]
        [Route("Api/Patient/PostInfectionTestResultInfo")]
        public IHttpActionResult PostInfectionTestResultInfo(string pType, InfectionTestResultInfo InfectionTestResult)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }
            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<InfectionTestResultInfo> lstInfectionTestResultInfo = new List<InfectionTestResultInfo>();

            try
            {
                if (InfectionTestResult != null)
                {
                    InfectionTestResultInfo InfTestResultInfo = new InfectionTestResultInfo();

                    InfTestResultInfo.OrgID = InfectionTestResult.OrgID;
                    InfTestResultInfo.LocationID = InfectionTestResult.LocationID;
                    InfTestResultInfo.ClientID = InfectionTestResult.ClientID;
                    InfTestResultInfo.PatientID = InfectionTestResult.PatientID;
                    InfTestResultInfo.TitleName = InfectionTestResult.TitleName;
                    InfTestResultInfo.Name = InfectionTestResult.Name;
                    InfTestResultInfo.FirstName = InfectionTestResult.FirstName;
                    InfTestResultInfo.MiddleName = InfectionTestResult.MiddleName;
                    InfTestResultInfo.LastName = InfectionTestResult.LastName;
                    InfTestResultInfo.Gender = InfectionTestResult.Gender;

                    if (Convert.ToDateTime(InfectionTestResult.DateofBrith).ToString("yyyy") == "0001")
                        InfTestResultInfo.DateofBrith = DateTime.MaxValue;
                    else
                        InfTestResultInfo.DateofBrith = InfectionTestResult.DateofBrith;

                 
                    InfTestResultInfo.Age = InfectionTestResult.Age;
                    InfTestResultInfo.MobileNumber = InfectionTestResult.MobileNumber;
                    InfTestResultInfo.EMailID = InfectionTestResult.EMailID;
                    InfTestResultInfo.Address = InfectionTestResult.Address;
                    InfTestResultInfo.City = InfectionTestResult.City;
                    InfTestResultInfo.State = InfectionTestResult.State;
                    InfTestResultInfo.Country = InfectionTestResult.Country;
                    InfTestResultInfo.PostalCode = InfectionTestResult.PostalCode;
                    InfTestResultInfo.ClientName = InfectionTestResult.ClientName;
                    InfTestResultInfo.ClientCode = InfectionTestResult.ClientCode;
                    InfTestResultInfo.PhysicianCode = InfectionTestResult.PhysicianCode;
                    InfTestResultInfo.PhysicianName = InfectionTestResult.PhysicianName;
                    InfTestResultInfo.Hospitalname = InfectionTestResult.Hospitalname;
                    InfTestResultInfo.HospitalCode = InfectionTestResult.HospitalCode;
                    InfTestResultInfo.ExternalPatientNumber = InfectionTestResult.ExternalPatientNumber;
                    InfTestResultInfo.Patientcategory = InfectionTestResult.Patientcategory;
                    InfTestResultInfo.VisitType = InfectionTestResult.VisitType;
                    InfTestResultInfo.BedWardInfo = InfectionTestResult.BedWardInfo;
                    InfTestResultInfo.URNType = InfectionTestResult.URNType;
                    InfTestResultInfo.URNNo = InfectionTestResult.URNNo;
                    InfTestResultInfo.TestCode = InfectionTestResult.TestCode;
                    InfTestResultInfo.TestName = InfectionTestResult.TestName;
                    InfTestResultInfo.ParameterCode = InfectionTestResult.ParameterCode;
                    InfTestResultInfo.ParameterName = InfectionTestResult.ParameterName;
                    InfTestResultInfo.ResultType = InfectionTestResult.ResultType;
                    InfTestResultInfo.ResultValue = InfectionTestResult.ResultValue;
                    InfTestResultInfo.ReferenceRange = InfectionTestResult.ReferenceRange;
                   
                    InfTestResultInfo.IsAbnormal = InfectionTestResult.IsAbnormal;
                    InfTestResultInfo.IsCritical = InfectionTestResult.IsCritical;
                    InfTestResultInfo.Status = InfectionTestResult.Status;
                    InfTestResultInfo.ApprovedBy = InfectionTestResult.ApprovedBy;
                      InfTestResultInfo.ApprovedDate = InfectionTestResult.ApprovedDate;

                    if (Convert.ToDateTime(InfectionTestResult.ApprovedDate).ToString("yyyy") == "0001")
                        InfTestResultInfo.ApprovedDate = DateTime.MaxValue;
                    else
                        InfTestResultInfo.ApprovedDate = InfectionTestResult.ApprovedDate;

                    InfTestResultInfo.CreatedBy = InfectionTestResult.CreatedBy;

                    if (Convert.ToDateTime(InfectionTestResult.CreatedAt).ToString("yyyy") == "0001")
                        InfTestResultInfo.CreatedAt = DateTime.MaxValue;
                    else
                        InfTestResultInfo.CreatedAt = InfectionTestResult.CreatedAt;

                  
                    InfTestResultInfo.ModifiedBy = InfectionTestResult.ModifiedBy;

                 
                    if (Convert.ToDateTime(InfectionTestResult.ModifiedAt).ToString("yyyy") == "0001")
                        InfTestResultInfo.ModifiedAt = DateTime.MaxValue;
                    else
                        InfTestResultInfo.ModifiedAt = InfectionTestResult.ModifiedAt;

                   
                    InfTestResultInfo.ISProcessed = InfectionTestResult.ISProcessed;
                    InfTestResultInfo.Error = InfectionTestResult.Error;
                    InfTestResultInfo.Remarks = InfectionTestResult.Remarks;
                    lstInfectionTestResultInfo.Add(InfTestResultInfo);

                    if (lstInfectionTestResultInfo != null)
                    {
                        returnCode = new LIMSAPI_BL().InsertInfectionTestResult(pOrgCode,pType, lstInfectionTestResultInfo);

                        if (returnCode != -1)
                        {
                            actionResult = Ok("Following the InfectionTestResultID : " + InfectionTestResult.InfTestResultID + " Successfully processed.");
                        }
                        else
                        {
                            actionResult = Ok("Result Not Found");
                        }
                    }
                }
                else
                {
                    actionResult = Ok("InfectionTestResult Registration Information not found");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }

            return actionResult;
        }

        /// <summary>
        ///  This API will insert the Live Location of the Phelobo
        /// </summary>
        /// <param name="pType"></param>
        /// <param name="objliveLocation"></param>
        /// <returns></returns>
        [ResponseType(typeof(LiveLocationModel))]
        [HttpPost]
        [Route("Api/Patient/PostLiveLocation")]
        public IHttpActionResult PostLiveLocation(string pType, LiveLocationModel objliveLocation)
        {
            long returnCode = -1;
            IHttpActionResult actionResult = null;

            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }

            List<LiveLocationInfo> lstlivelocationinfo = new List<LiveLocationInfo>();

            try
            {
                if (objliveLocation != null)
                {
                    LiveLocationInfo objlivelocate = new LiveLocationInfo();

                    objlivelocate.Longitude = objliveLocation.Longitude;
                    objlivelocate.Latitude = objliveLocation.Latitude;
                    objlivelocate.TransactionDate = objliveLocation.TransactionDate;
                    objlivelocate.LoginID = objliveLocation.LoginID;
                    objlivelocate.CreatedBy = objliveLocation.CreatedBy;
                    if (Convert.ToDateTime(objliveLocation.CreatedAt).ToString("yyyy") == "0001")
                        objlivelocate.CreatedAt = DateTime.MaxValue;
                    else
                        objlivelocate.CreatedAt = objliveLocation.CreatedAt;

                    objlivelocate.ModifiedBy = objliveLocation.ModifiedBy;
                    if (Convert.ToDateTime(objliveLocation.ModifiedAt).ToString("yyyy") == "0001")
                        objlivelocate.ModifiedAt = DateTime.MaxValue;
                    else
                        objlivelocate.ModifiedAt = objliveLocation.ModifiedAt;
                    objlivelocate.ISProcessed = objliveLocation.ISProcessed;

                    lstlivelocationinfo.Add(objlivelocate);

                    if (lstlivelocationinfo != null)
                    {
                        returnCode = new LIMSAPI_BL().InsertLiveLocation(pOrgCode, pType, lstlivelocationinfo);

                        if (returnCode != -1)
                        {
                            actionResult = Ok("Successfully Inserted.");
                        }
                        else
                        {
                            actionResult = Ok("Error on while updating the Live Location data");
                        }
                    }
                }
                else
                {
                    actionResult = Ok("Live Location data not found");
                }
            }
            catch (Exception ex)
            {
                actionResult = Ok("Error Occured");
            }

            return actionResult;
        }
        */
        [Route("api/v1/Patient")]
        [HttpGet]
        public IHttpActionResult Get(DateTime FromDate, DateTime ToDate, string LabNo)
        {
            List<PatientSampleDetails> lstrptpatientinfo = new List<PatientSampleDetails>();
            long returnCode = -1;
            IHttpActionResult actionResult = null;

            try
            {
                returnCode = new LIMSAPI_BL().GetPatientInfoCommunication(FromDate, ToDate, CurrentUser.OrgID, LabNo, out lstrptpatientinfo);

                if (returnCode != -1)
                {
                    if (lstrptpatientinfo.Count > 0 && lstrptpatientinfo != null)
                    {
                        actionResult = Ok(lstrptpatientinfo);
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

        [HttpGet]
        [Route("api/v1/PatientReport")]
        public HttpResponseMessage ConvertFilePathToPdf(string visitnumber)
        {
            long returnCode = -1;
            var result = new HttpResponseMessage(HttpStatusCode.OK);
            //PatientInfomation_BL objbl = new PatientInfomation_BL();
            try
            {
                List<ReportSnapshot> lstReportSnapshot = new List<ReportSnapshot>();

                returnCode = new LIMSAPI_BL().GetReportSnapshotwithvisitnumber(CurrentUser.OrgID, CurrentUser.OrgAddressID, visitnumber, true, out lstReportSnapshot);
                string path = lstReportSnapshot[0].ReportPath;
                string name = path.ToString().Split('\\').Last();
                //    string FilePathName = "\\lissistoragefordbbackup.file.core.windows.net\\liskernel-pdf\\PDF\\REPORT\\202\\2021/02/16\\Report-2100550_Patient_Two_GENERAL_16Feb2021_182156.pdf";
                //   string FilePathName = "\\lissistoragefordbbackup.file.core.windows.net\\liskernel - pdf\\PDF\\REPORT\\202\\2021 / 01 / 11\\Report - 2100518_VIRAT_11 - Jan - 2021_333 PM.pdf";
                string connstr = AzureConnection();
                CloudStorageAccount storageAccount = CloudAccount(connstr);
                string sharepath = storageAccount.FileStorageUri.PrimaryUri.Host;
                if (File.Exists(lstReportSnapshot[0].ReportPath))
                {
                    //   if (File.Exists(FilePathName))
                    //   {
                    string filename = System.IO.Path.GetFileName(lstReportSnapshot[0].ReportPath);
                    // string filename = FilePathName;
                    byte[] filepathByte = File.ReadAllBytes(lstReportSnapshot[0].ReportPath);
                    // byte[] filepathByte = File.ReadAllBytes(FilePathName);
                    MemoryStream memoryStream = new MemoryStream(filepathByte);
                    result.Content = new StreamContent(memoryStream);
                    result.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
                    result.Content.Headers.ContentDisposition.FileName = filename;
                    result.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
                    // objPrimaReport.FileBlob = Convert.ToBase64String(filebyte);
                    //    }
                }
                else if (lstReportSnapshot[0].ReportPath.Contains(sharepath))
                {
                    //   FilePathName = "\\lissistoragefordbbackup.file.core.windows.net\\liskernel-pdf\\PDF\\REPORT\\202\\2021/02/16\\Report-2100550_Patient_Two_GENERAL_16Feb2021_182156.pdf";

                    string filestring = azurefilebytes(lstReportSnapshot[0].ReportPath);
                    //  string filestring = azurefilebytes(FilePathName);
                    if (!String.IsNullOrEmpty(filestring))
                    {
                        // Restore the byte array.
                        byte[] filepathByte = Convert.FromBase64String(filestring);

                        string filename = System.IO.Path.GetFileName(lstReportSnapshot[0].ReportPath);

                        // objPrimaReport.FileBlob = filestring;
                        MemoryStream memoryStream = new MemoryStream(filepathByte);
                        result.Content = new StreamContent(memoryStream);
                        result.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
                        result.Content.Headers.ContentDisposition.FileName = filename;
                        result.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");

                    }
                    //byte[] pdfByte = new PathApp_BL().ReadFilePathtoByte(@path);
                    //if (pdfByte != null && pdfByte.Length > 0)
                    //{
                    //    MemoryStream memoryStream = new MemoryStream(pdfByte);
                    //    result.Content = new StreamContent(memoryStream);
                    //    result.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
                    //}
                    else
                    {
                        result = new HttpResponseMessage(HttpStatusCode.NoContent);
                    }
                    //byte[] pdfByte = ReadFilePathtoByte(@path);
                    //if (pdfByte != null && pdfByte.Length > 0)
                    //{
                    //    MemoryStream memoryStream = new MemoryStream(pdfByte);
                    //    result.Content = new StreamContent(memoryStream);
                    //    result.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
                    //}
                    //else
                    //{
                    //    result = new HttpResponseMessage(HttpStatusCode.NoContent);
                    //}
                }
            }
            catch (Exception)
            {
                result = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
            return result;
        }

        public byte[] ReadFilePathtoByte(string Filepath)
        {
            byte[] filepathByte = null;
            try
            {
                if (File.Exists(Filepath))
                {
                    filepathByte = File.ReadAllBytes(Filepath);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return filepathByte;
        }
        public string AzureConnection()
        {
            string connstr = Microsoft.Azure.CloudConfigurationManager.GetSetting("StorageConnectionString");

            string[] constrarr = connstr.Split(';');
            string accountName = (constrarr[constrarr.Length - 2]);
            string accounKey = constrarr[constrarr.Length - 1];
            string[] aNbyte = accountName.Split('=');
            string[] aKbyte = accounKey.Split('=');
            string aN = aNbyte[aNbyte.Length - 1];
            string aK = aKbyte[aKbyte.Length - 1];

            Attune.Cryptography.CCryptography obj = new Attune.Cryptography.CCryptFactory().GetDecryptor();
            obj.Crypt(aN, out aN);
            obj.Crypt(aK, out aK);
            constrarr[constrarr.Length - 2] = aNbyte[aNbyte.Length - 2] + "=" + aN;
            constrarr[constrarr.Length - 1] = aKbyte[aKbyte.Length - 2] + "=" + aK;
            connstr = constrarr[constrarr.Length - 3] + ";" + aNbyte[aNbyte.Length - 2] + "=" + aN + ";" + aKbyte[aKbyte.Length - 2] + "=" + aK;
            return connstr;
        }
        public CloudStorageAccount CloudAccount(string constr)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(constr);
            return storageAccount;
        }
        public string azurefilebytes(string path)
        {
            string basesixityfourstring = String.Empty;
            try
            {
                if (!String.IsNullOrEmpty(path))
                {
                    //    path = "\\lissistoragefordbbackup.file.core.windows.net\\liskernel-pdf\\PDF\\REPORT\\202\\2021/02/16\\Report-2100550_Patient_Two_GENERAL_16Feb2021_182156.pdf";
                    //string path = "\\lissistoragefordbbackup.file.core.windows.net\\liskernel-pdf\\PDF\\REPORT\\220\\2019/05/04\\Report-19PY17842_PADMA_MURALIDHARA_03May2019_193552.pdf";
                    string[] strarr = path.Split('\\');
                    string[] removeemptyarr = strarr.Where(j => !String.IsNullOrEmpty(j)).ToArray();
                    string shareReference = removeemptyarr[1].ToString();
                    string directoryReference = (removeemptyarr[2] + "\\" + removeemptyarr[3] + "\\" + removeemptyarr[4] + "\\" + removeemptyarr[5]).ToString();
                    string filename = System.IO.Path.GetFileName(path);

                    //CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Microsoft.Azure.CloudConfigurationManager.GetSetting("StorageConnectionString"));
                    // Parse the connection string and return a reference to the storage account. 
                    string connstr = AzureConnection();
                    CloudStorageAccount storageAccount = CloudAccount(connstr);
                    // Create a CloudFileClient object for credentialed access to Azure Files.
                    CloudFileClient fileClient = storageAccount.CreateCloudFileClient();

                    // Get a reference to the file share we created previously.
                    //CloudFileShare share = fileClient.GetShareReference("liskernel-pdf");
                    CloudFileShare share = fileClient.GetShareReference(shareReference);

                    // Ensure that the share exists.
                    if (share.Exists())
                    {
                        // Get a reference to the root directory for the share.
                        CloudFileDirectory rootDir = share.GetRootDirectoryReference();

                        // Get a reference to the directory we created previously.
                        //CloudFileDirectory sampleDir = rootDir.GetDirectoryReference("PDF\\REPORT\\220\\2019/05/04");
                        CloudFileDirectory sampleDir = rootDir.GetDirectoryReference(directoryReference);

                        // Ensure that the directory exists.
                        if (sampleDir.Exists())
                        {
                            // Get a reference to the file we created previously.
                            //CloudFile file = sampleDir.GetFileReference("Report-19PY17842_PADMA_MURALIDHARA_03May2019_193552.pdf");
                            CloudFile file = sampleDir.GetFileReference(filename);

                            // Ensure that the file exists.
                            using (var ms = new MemoryStream())
                            {
                                if (file.Exists())
                                {
                                    // Download the stream of the file from cloud storage.
                                    file.DownloadToStream(ms);
                                    byte[] arry = ms.ToArray();
                                    basesixityfourstring = Convert.ToBase64String(arry);

                                    // Download the contents of the file to the local dive.

                                    //string drivepath = "D:\\Attune\\" + filename;
                                    //file.DownloadToFile(drivepath, System.IO.FileMode.OpenOrCreate);
                                    //byte[] localfilebyte = File.ReadAllBytes(drivepath);
                                    //basesixityfourstring = Convert.ToBase64String(localfilebyte).ToString();
                                }
                            }
                        }
                        /////************ Start Copy to Blob storage and Download the stream of the blob *********//
                        //string containerName = "test-container";
                        //CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
                        //CloudBlobContainer container = blobClient.GetContainerReference(containerName.ToLower());
                        //container.CreateIfNotExists();
                        //string fileSas = file.GetSharedAccessSignature(new SharedAccessFilePolicy()
                        //{
                        //    // Only read permissions are required for the source file.
                        //    Permissions = SharedAccessFilePermissions.Read,
                        //    SharedAccessExpiryTime = DateTime.UtcNow.AddHours(24)
                        //});
                        //Uri fileSasUri = new Uri(file.StorageUri.PrimaryUri.ToString() + fileSas);

                        //CloudBlockBlob blockBlob = container.GetBlockBlobReference(filename);

                        //blockBlob.StartCopy(fileSasUri);
                        //using (var blobms = new MemoryStream())
                        //{
                        //    if (blockBlob.Exists())
                        //    {
                        //        blockBlob.DownloadToStream(blobms);
                        //        byte[] blobbyte = blobms.ToArray();
                        //        string bytarr = Convert.ToBase64String(blobbyte);
                        //        blockBlob.DeleteIfExistsAsync();
                        //    }
                        //}
                        /////************ END Copy to Blob storage and Download the stream of the blob *********//
                    }
                }
            }

            catch
            {

            }
            return basesixityfourstring;
        }
        /// <summary>
        /// This API returns the PatientRegistrationData those registered on specific date with MobileNumber
        /// If MobileNumber is specified in parameter. It will return details of the specific Patient
        /// </summary>
        ///

        ///<param name = "pMobileNumber" >MobileNumber of AttuneLIMS</param >
       
        ///<param name = "Page" >Parameter to hanlde paging</param >
        ///<param name = "Size" >Parameter to specify No.Of.Records in single page</param >
        ///
        /// /// <returns>success</returns>
        [ResponseType(typeof(PatientRegistrationData))]
        [HttpGet]
        [Route("Api/Patient/GetRegistrationDetails")]
        public IHttpActionResult GetPatientRegistrationInfo(string pMobileNumber, int Page, int Size)
        {
            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string pOrgCode = string.Empty;

            if (headers.Contains("orgcode"))
            {
                pOrgCode = headers.GetValues("orgcode").First();
            }
            if (string.IsNullOrEmpty(pMobileNumber))
            {
                pMobileNumber = string.Empty;
            }
            long returnCode = -1;
            IHttpActionResult actionResult = null;
            List<PatientRegistrationInfo> lstPatientRegistrationInfo = new List<PatientRegistrationInfo>();
            List<PatientRegistrationInfo> lstPatientRegistrationInfoDetails = new List<PatientRegistrationInfo>();
            List<Paging> lstPages = new List<Paging>();
            PatientRegistrationData objPatientRegistrationData = new PatientRegistrationData();
            try
            {
                returnCode = new LIMSAPI_BL().GetPatientRegistrationInfo__LIMSAPI(pOrgCode, pMobileNumber,  Page, Size, out lstPatientRegistrationInfo, out lstPages);

                if (returnCode != -1)
                {
                    if (lstPatientRegistrationInfo.Count > 0 && lstPatientRegistrationInfo != null)
                    {

                        var lstPatientRegDetailsInfo = new List<PatientRegistrationDetailsInfo>();
                        lstPatientRegDetailsInfo = lstPatientRegistrationInfo.Select(i => new PatientRegistrationDetailsInfo
                        {
                            PatientID = i.PatientID,
                            PatientNumber = i.PatientNumber,
                            Salutation = i.Salutation,
                            Name = i.PatientName,
                            FirstName = i.FirstName,
                            MiddleName = i.MiddleName,
                            LastName = i.LastName,
                            Age = i.Age,
                            Gender = i.Gender,
                            DOB = i.DateofBirth,
                            Address = i.Address,
                            City = i.City,
                            State = i.State,
                            Country = i.Country,
                            PinCode = i.PostalCode,
                            MobileNumber = i.MobileNumber,
                            EmailID = i.Email,
                            URNType = i.URNType,
                            URNNo = i.URNNo,
                            DateOfRegistration = i.DateOfRegistration,

                            Source = i.Source,

                            Status = i.Status,

                        }).ToList();






                        objPatientRegistrationData.OrgCode = pOrgCode;
                        objPatientRegistrationData.OrgID = lstPatientRegistrationInfo[0].OrgID;
                        objPatientRegistrationData.LocationID = lstPatientRegistrationInfo[0].LocationID;
                        objPatientRegistrationData.Type = "Patient Registration Information";

                        objPatientRegistrationData.PatientRegistrationInfo = lstPatientRegDetailsInfo;
                        objPatientRegistrationData.TotalRecords = lstPages[0].TotalRecords;
                        objPatientRegistrationData.TotalPages = lstPages[0].TotalPages;
                        objPatientRegistrationData.AllowableRecordCount = lstPages[0].AllowableRecordCount;

                        actionResult = Ok(objPatientRegistrationData);

                    }
                    else
                    {
                        actionResult = Ok("Result not Found");
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
    }
}
