using System;
using System.Collections.Generic;
using System.Web.Http;
using Attune.KernelV2.BL;
using Attune.KernelV2.Entities;
using Attune.KernelV2.Providers;
using System.Threading.Tasks;
using System.Configuration;
using Newtonsoft.Json;
using System.Net.Http;
using System.Web;
using System.Runtime.Serialization;

namespace Attune.KernelV2.API.ApiControllers.Billing
{
    public class BillingApiController : BaseApiController
    {
        [Route("api/v1/patientbilling")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            UI_BillingPatientMetaData objPatientBilling;
            try
            {
                using (Billing_BL BL = new Billing_BL(ContextDetails))
                {
                    objPatientBilling = BL.GetPatientBillingDetails(ContextDetails.OrgID, ContextDetails.LanguageCode);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(objPatientBilling);
        }

        [Route("api/v1/billingmetadata")]
        [HttpGet]
        public IHttpActionResult GetBillingMetaData()
        {
            UI_BillingMetaData objBillDetails;
            try
            {
                using (Billing_BL BL = new Billing_BL(ContextDetails))
                {
                    objBillDetails = BL.GetBillingDetails(ContextDetails.OrgID, ContextDetails.LanguageCode);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(objBillDetails);
        }

        [Route("api/v1/patientbilling")]
        [HttpGet]
        public IHttpActionResult GetPatientBilling(string PrefixText)
        {
            List<UI_PatientBanner> lstPatient;
            try
            {
                using (Billing_BL BL = new Billing_BL(ContextDetails))
                {
                    lstPatient = BL.GetPatientBilling(PrefixText, ContextDetails.OrgID);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstPatient);
        }

        [Route("api/v1/patientbilling")]
        [HttpGet]
        public IHttpActionResult GetPatientDetailsBilling(long PatientID)
        {
            UI_BillingPatientDetails objPatientBilling;
            try
            {
                using (Billing_BL BL = new Billing_BL(ContextDetails))
                {
                    objPatientBilling = BL.GetPatientDetailsBilling(PatientID, ContextDetails.OrgID, ContextDetails.OrgAddressID, ContextDetails.LanguageCode);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(objPatientBilling);
        }

        [Route("api/v1/patientadvancesearch")]
        [HttpGet]
        public IHttpActionResult GetPatientAdvanceSearch(string FirstName, string MiddleName, string LastName, string PatientNo, string PhoneNo, string BookingNo, long ClientID, string ClientCode)
        {
            List<UI_Patient> lstPatient;

            FirstName = string.IsNullOrEmpty(FirstName) ? "" : FirstName;
            MiddleName = string.IsNullOrEmpty(MiddleName) ? "" : MiddleName;
            LastName = string.IsNullOrEmpty(LastName) ? "" : LastName;
            PatientNo = string.IsNullOrEmpty(PatientNo) ? "" : PatientNo;
            PhoneNo = string.IsNullOrEmpty(PhoneNo) ? "" : PhoneNo;
            BookingNo = string.IsNullOrEmpty(BookingNo) ? "" : BookingNo;
            ClientCode = string.IsNullOrEmpty(ClientCode) ? "" : ClientCode;
            try
            {
                using (Billing_BL BL = new Billing_BL(ContextDetails))
                {
                    lstPatient = BL.GetPatientAdvanceSearch(FirstName, MiddleName, LastName, PatientNo, PhoneNo, BookingNo, ClientID, ClientCode, ContextDetails.OrgID);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstPatient);
        }

        [Route("api/v1/healthpackagedatasearch")]
        [HttpGet]
        public IHttpActionResult GetHealthPackageDataSearch(string GroupName, int PackageID)
        {
            List<UI_OrderedInvestigations> lstOrderedInvestigations;
            try
            {
                using (Billing_BL BL = new Billing_BL(ContextDetails))
                {
                    lstOrderedInvestigations = BL.GetHealthPackageDataSearch(ContextDetails.OrgID, GroupName, PackageID);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstOrderedInvestigations);
        }

        [Route("api/v1/getpincodedetails")]
        [HttpGet]
        public IHttpActionResult GetPincodeDetails(long Pincode)
        {
            List<UI_OrderedInvestigations> lstOrderedInvestigations;
            try
            {
                using (Billing_BL BL = new Billing_BL(ContextDetails))
                {
                    lstOrderedInvestigations = null;
                    //lstOrderedInvestigations = BL.GetPincodeDetails(Pincode, ContextDetails.OrgID);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstOrderedInvestigations);
        }

        [Route("api/v1/billingitems")]
        [HttpGet]
        public IHttpActionResult GetBillingItems(string Description, string FeeType, string Gender, long ClientID, long RateID, string IsMapped)
        {
            List<UI_BillingItems> lstBillingItems;
            try
            {
                using (Billing_BL BL = new Billing_BL(ContextDetails))
                {
                    lstBillingItems = BL.GetBillingItems(Description, FeeType, ContextDetails.OrgID, ContextDetails.OrgAddressID, Gender, ClientID, RateID, IsMapped);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(lstBillingItems);
        }

        [Route("api/v1/billingitems")]
        [HttpGet]
        public IHttpActionResult GetBillingItemsDetails(int FeeID, string FeeType, long ClientID, long VisitID, string IsCollected, DateTime CollectedDatetime)
        {
            UI_BillingItemsDetails objBillingDetailsItems;
            try
            {
                using (Billing_BL BL = new Billing_BL(ContextDetails))
                {
                    objBillingDetailsItems = BL.GetBillingItemsDetails(ContextDetails.OrgID, FeeID, FeeType, ClientID, VisitID, IsCollected, CollectedDatetime);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(objBillingDetailsItems);
        }

        //[Route("api/v1/patientbillingitemsdetails")]
        //[HttpPost]
        //public IHttpActionResult InsertPatientBilling([FromBody]UI_BillingPatient PatientBilling)
        //{
        //    UI_BillingPart BillingPart = null;
        //    try
        //    {
        //        if (PatientBilling != null)
        //        {
        //            using (Billing_BL BL = new Billing_BL(ContextDetails))
        //            {
        //                BillingPart = BL.InsertPatientBilling(PatientBilling);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(ToHttpStatusCode(ex));
        //    }
        //    return Ok(BillingPart);
        //}

        [Route("api/v1/patientbillingitemsdetails")]
        [HttpPost]
        public async Task<IHttpActionResult> Post()
        {

            UI_BillingPatient PatientBillings = null;
            UI_BillingPart BillingPart = null;

            try
            {

                if (Request.Content.IsMimeMultipartContent("form-data"))
                {
                    string fFileName  = ConfigurationManager.AppSettings["FilePath"];

                    var streamProvider = new CustomMultipartFormDataStreamProvider(fFileName);

                    CustomMultipartFormDataStreamProvider PostedData;
                    PostedData = await Request.Content.ReadAsMultipartAsync(streamProvider);

                    
                    if (!string.IsNullOrEmpty(PostedData.FormData["FileData"]))
                    {
                        PatientBillings = JsonConvert.DeserializeObject<UI_BillingPatient>(PostedData.FormData["FileData"]);
                    }
                   
                    if (PostedData.FileData.Count > 0)
                    {
                        PatientBillings.TRFFile = new List<UI_FileProperties>();
                        foreach (MultipartFileData uploadedfile in PostedData.FileData)
                        {
                            var pname = uploadedfile.Headers.ContentDisposition.FileName.Replace("\"", string.Empty);
                            PatientBillings.TRFFile.Add(new UI_FileProperties()
                            {
                               
                                
                                Name = string.IsNullOrEmpty(pname)? uploadedfile.LocalFileName.Replace(fFileName,"").Replace("\\",""): pname,//uploadedfile.Headers.ContentDisposition.FileName,
                                  FilePath = uploadedfile.LocalFileName
                                  //FilePath= updateProfile.Headers.ContentDisposition.FileName
                            });
                             
                        }
                    }


                    if (PatientBillings != null)
                    {
                        using (Billing_BL BL = new Billing_BL(ContextDetails))
                        {
                            BillingPart = BL.InsertPatientBilling(PatientBillings);
                        }
                    }
                }
            }


            catch (Exception ex)
            {
                return StatusCode(ToHttpStatusCode(ex));
            }
            return Ok(BillingPart);

        }
    }
}
