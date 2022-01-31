using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.IO;
using System.Web.Security;
using System.Net.Mail;
using System.Xml.Linq;
using Attune.Cryptography;
using Attune.Podium.Common;
using System.Security.Cryptography;
using System.Net;
using System.Net.Mime;
using System.Configuration;
using System.Web;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Web.Script.Serialization;
using System.Collections;
using System.Threading;
using Attune_RLSIntegration.ServiceReference1;
using RestSharp;
using Newtonsoft;
using System.CodeDom;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Dynamic;
using System.Linq.Expressions;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Attune_RLSIntegration
{
    public class CovidIntegrationMessage : ServiceBase
    {
        string sFileName = string.Empty;
        System.Timers.Timer ServiceTimer;

        string Authorization = string.Empty;
        string Cache_Control = string.Empty;
        string Postman_Token_Email = string.Empty;
        string Postman_Token_Mobile = string.Empty;
        string brandid = string.Empty;
        string branduserid = string.Empty;
        string cache_control = string.Empty;
        string surveyKey_Email = string.Empty;
        string surveyKey_Mobile = string.Empty;
        string surveyKey_Mobile_HomeVisit = string.Empty;
        string Email_storeId = string.Empty;
        string Email_employeeId = string.Empty;
        string Email_URL = string.Empty;
        int InstantsID = 0;
        string ReportFolderPath = string.Empty;
        string authId = string.Empty;
        string authToken = string.Empty;
        string Url = string.Empty;
        string Proxyaddress = string.Empty;
        int Proxyport = 0;
        public string CertificateValue = "C:\\ATTUNE\\EMAIL_CERTIFICATE\\iRedMail_CA.pem";
        WebServiceSoapClient obj = new WebServiceSoapClient();

        public CovidIntegrationMessage()
        {
            LogInfo("Service Started Successfully:");

            this.ServiceName = "Attune_uploadCovidtestReport_RLS_V1.0";
            this.EventLog.Log = "Application";
            this.CanHandlePowerEvent = true;
            this.CanHandleSessionChangeEvent = true;
            this.CanPauseAndContinue = true;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.ServiceName = "Attune_uploadCovidtestReport_RLS_V1.0";
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                InstantsID = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["InstantsID"].Trim());
                string ServiceInterval = System.Configuration.ConfigurationManager.AppSettings["ServiceInterval"];
                List<CommunicationConfig> listcomcon = new List<CommunicationConfig>();
                ServiceTimer = new System.Timers.Timer();
                ServiceTimer.Elapsed += new System.Timers.ElapsedEventHandler(Process_PdfGeneratingEvent);
                ServiceTimer.Interval = Convert.ToInt32(ServiceInterval);
                ServiceTimer.Start();
                LogInfo("Service Started Successfully:");
            }
            catch (Exception ex)
            {
                LogInfo("Error while Service Started:");
                LogError(ex);
                LogError(ex.InnerException);
            }
        }

        protected override void OnStop()
        {
            ServiceTimer.Stop();
            LogInfo("Service Stopted Successfully:");
        }
        //public void Process_PdfGeneratingEvent()
        private void Process_PdfGeneratingEvent(object sender, System.Timers.ElapsedEventArgs e)
        {


            List<CommunicationConfig> listcomcon = new List<CommunicationConfig>();
            CommunicationConfig[] comconfig = obj.GetCommunicationConfig(0, "BulkRegJioIntegration");
            listcomcon = comconfig.ToList();


            if (listcomcon.Exists(p => p.Name == "authId"))
            {
                authId = listcomcon.Find(p => p.Name == "authId").Value.ToString();
            }
            if (listcomcon.Exists(p => p.Name == "CovidauthToken"))
            {
                authToken = listcomcon.Find(p => p.Name == "CovidauthToken").Value.ToString();
            }
            if (listcomcon.Exists(p => p.Name == "CovidreportUrl"))
            {
                Url = listcomcon.Find(p => p.Name == "CovidreportUrl").Value.ToString();
            }

            if (listcomcon.Exists(p => p.Name.ToLower() == "reportpdffolderpath"))
            {
                ReportFolderPath = listcomcon.Find(p => p.Name.ToLower() == "reportpdffolderpath").Value.ToString();
            }
            if (listcomcon.Exists(p => p.Name.ToLower() == "covidproxy"))
            {
                Proxyaddress = listcomcon.Find(p => p.Name.ToLower() == "covidproxy").Value.ToString();
            }
            if (listcomcon.Exists(p => p.Name.ToLower() == "covidproxyport"))
            {
                Proxyport = Convert.ToInt32(listcomcon.Find(p => p.Name.ToLower() == "covidproxyport").Value.ToString());
            }

            string StatusCode = string.Empty, StatusDescription = string.Empty;
            string APIUrl = string.Empty;
            string APIKey = string.Empty;
            string Newroot = string.Empty;

            BulkRegIntegration[] lstBulkRegIntegrations = null;
            BulkRegIntegrationResultValue[] lstBulkRegIntegrationResultValue = null;
            List<BulkRegIntegration> lstBulkRegIntegrationsupdate = new List<BulkRegIntegration>();
            BulkRegIntegration objBulkRegIntegrationsupdate = null;
            int lstcnt = 0;
            
            List<SourceDetails> lstsource = new List<SourceDetails>();
            try
            {

                if (lstcnt == 0)
                {
                    lstBulkRegIntegrations = obj.GetBulkRegIntegrationNotifications(4);

                    if (lstBulkRegIntegrations != null && lstBulkRegIntegrations.Count() > 0)
                    {
                       
                        lstcnt = lstBulkRegIntegrations.Count();
                        for (int i = 0; i < lstBulkRegIntegrations.Count(); i++)
                        {
                            try
                            { 
                                
                                lstBulkRegIntegrationResultValue = obj.GetBulkRegIntegrationResultValue(lstBulkRegIntegrations[i].NotificationID,4);
                                if (lstBulkRegIntegrationResultValue != null && lstBulkRegIntegrationResultValue.Count() > 0)
                                {
                                   
                                    foreach (BulkRegIntegrationResultValue lisname in lstBulkRegIntegrationResultValue)
                                    {
                                        SourceDetails objsmart = new SourceDetails();
                                        List<Reportvalues> lstreportformatvalue = new List<Reportvalues>();
                                        List<DoctorDetails> lstdoctors = new List<DoctorDetails>();
                                        objsmart.PatientName = lstBulkRegIntegrations[i].firstName;
                                        objsmart.dob = lstBulkRegIntegrations[i].dob.ToString("dd/MM/yyyy");
                                        objsmart.Gender = lstBulkRegIntegrations[i].gender;
                                        objsmart.ContactNo = lstBulkRegIntegrations[i].phoneNumber;
                                        // objsmart.PatientId = null;
                                        objsmart.alternateEmail = lstBulkRegIntegrations[i].emailid;
                                        objsmart.orderNumber = lstBulkRegIntegrations[i].BookingNo;
                                        objsmart.SampleDate = lstBulkRegIntegrations[i].visitDate.ToUniversalTime();
                                        objsmart.labId =String.IsNullOrEmpty(lstBulkRegIntegrations[i].OrgCode)?0: Convert.ToInt64(lstBulkRegIntegrations[i].OrgCode);
                                        objsmart.source_id = "attunehealth";


                                        ReportFormats objreport = new ReportFormats();
                                        Reportvalues objvalues = new Reportvalues();
                                       
                                        objsmart.reportDate = lisname.reportDate.ToUniversalTime();
                                        objsmart.ReportDate = lisname.reportDate.ToUniversalTime();
                                       // objsmart.dictionaryId = lisname.TestCode;
                                        objsmart.testCode = lisname.TestCode;
                                        objsmart.TestName = lisname.InvestigationName;
                                        objsmart.ReportId = lisname.reportId;
                                        objsmart.isSigned = 1;
                                        objsmart.status = "report_submit";

                                        objvalues.method = lisname.testmethod;
                                        objvalues.value = lisname.value;
                                        objvalues.observedIndexValue = lisname.interpretation;
                                         
                                        objreport.method = lisname.testmethod;
                                       //    objreport.dictionaryId = lisname.TestCode;
                                        objreport.testName = lisname.InvestigationName;

                                        objvalues.reportFormat = objreport;
                                        lstreportformatvalue.Add(objvalues);

                                        DoctorDetails doctor1 = new DoctorDetails()
                                        {
                                            SigningDoctor1 = lisname.doctor
                                        };
                                        lstdoctors.Add(doctor1);
                                        objsmart.SigningDoctor = lstdoctors;
                                        objsmart.reportFormatAndValues = lstreportformatvalue;
                                        try
                                        {
                                            JavaScriptSerializer jserilizer = new JavaScriptSerializer();
                                            var lstSmart = JsonConvert.SerializeObject(objsmart); // jserilizer.Serialize(objsmart);
                                            var baseAddress = Url;
                                            LogInfo(lstSmart);

                                            Uri myUri = new Uri(baseAddress, UriKind.Absolute);
                                            HttpWebRequest r = (HttpWebRequest)WebRequest.Create(myUri);
                                            r.Method = "POST";
                                            r.Headers["token"] = authToken;
                                            r.ContentType = "application/json";
                                            /* IWebProxy proxy = WebRequest.DefaultWebProxy;//.GetSystemWebProxy();
                                             proxy.Credentials = CredentialCache.DefaultCredentials;
                                             r.Proxy = proxy;*/
                                            if (!string.IsNullOrEmpty(Proxyaddress))
                                            {
                                                WebProxy Proxy = new WebProxy(Proxyaddress, Proxyport);
                                                Proxy.Credentials = CredentialCache.DefaultCredentials;
                                                r.Proxy = Proxy;
                                            }
                                            else
                                            {
                                                IWebProxy proxy = WebRequest.GetSystemWebProxy();
                                                proxy.Credentials = CredentialCache.DefaultCredentials;
                                                r.Proxy = proxy;
                                            }
                                            r.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.106 Safari/537.36";
                                            byte[] byteArray = Encoding.UTF8.GetBytes(lstSmart);
                                            r.ContentLength = byteArray.Length;
                                            LogInfo("Before get request stream");
                                            try
                                            {
                                                var requestStream = r.GetRequestStream();
                                                requestStream.Write(byteArray, 0, byteArray.Length);
                                                requestStream.Close();
                                            }
                                            catch (Exception ex)
                                            {
                                                LogInfo(ex.ToString());
                                            }


                                            LogInfo("Before response get");
                                            try
                                            {
                                                using (HttpWebResponse response = (HttpWebResponse)r.GetResponse())
                                                {
                                                    StatusCode = response.StatusCode.ToString();
                                                    Stream s = response.GetResponseStream();
                                                    StreamReader sr = new StreamReader(s);
                                                    if (StatusCode == "OK")
                                                    {
                                                        StatusDescription = "Success";
                                                    }
                                                    else
                                                    {
                                                        StatusDescription = sr.ReadToEnd();
                                                    }
                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                LogInfo(ex.ToString());
                                            }

                                            objBulkRegIntegrationsupdate = new BulkRegIntegration();
                                            if (StatusCode == "OK" || StatusDescription.Contains("Success"))
                                            {

                                                objBulkRegIntegrationsupdate.Status = "Completed";
                                                objBulkRegIntegrationsupdate.ErrorDescription = StatusDescription;
                                                objBulkRegIntegrationsupdate.NotificationID = lstBulkRegIntegrations[i].NotificationID;
                                                lstBulkRegIntegrationsupdate.Add(objBulkRegIntegrationsupdate);
                                            }
                                            else
                                            {
                                                objBulkRegIntegrationsupdate.Status = "Error";
                                                objBulkRegIntegrationsupdate.ErrorDescription = StatusDescription;
                                                objBulkRegIntegrationsupdate.NotificationID = lstBulkRegIntegrations[i].NotificationID;
                                                lstBulkRegIntegrationsupdate.Add(objBulkRegIntegrationsupdate);
                                            }
                                            //sleep
                                            StatusCode = "";
                                            StatusDescription = "";
                                            SleepMethod();
                                        }
                                        catch (Exception ex)
                                        {
                                            objBulkRegIntegrationsupdate.Status = "Error";
                                            objBulkRegIntegrationsupdate.ErrorDescription = "Catch-Loop";
                                            objBulkRegIntegrationsupdate.NotificationID = lstBulkRegIntegrationsupdate[i].NotificationID;
                                            lstBulkRegIntegrationsupdate.Add(objBulkRegIntegrationsupdate);
                                        }
                                        finally
                                        {
                                            lstcnt -= 1;
                                        }
                                    }

                                } 
                            }
                            catch (Exception ex)
                            {
                                LogInfo(ex.ToString());
                            }
                            finally
                            {
                                lstcnt -= 1;
                            }

                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                LogInfo("Exception in service-catchLoop :" + DateTime.Now.ToString());
                LogError(Ex);
            }
            finally
            {
                if (lstBulkRegIntegrationsupdate.Count() > 0)
                {
                    obj.UpdateBulkRegIntegrationNotifications(4, lstBulkRegIntegrationsupdate.ToArray());

                }
            }
        }
        public Dictionary<string, Object> GetPropertyKeysForDynamic(dynamic dynamicToGetPropertiesFor)
        {
            JObject attributesAsJObject = dynamicToGetPropertiesFor;
            Dictionary<string, object> values = attributesAsJObject.ToObject<Dictionary<string, object>>();
            Dictionary<string, Object> toReturn = new Dictionary<string, Object>();
            foreach (string key in values.Keys)
            {
                toReturn.Add(key, values[key]);
            }
            return toReturn;
        }
        public static void AddProperty(ExpandoObject expando, string propertyName, object propertyValue)
        {
            // ExpandoObject supports IDictionary so we can extend it like this
            var expandoDict = expando as IDictionary<string, object>;
            if (expandoDict.ContainsKey(propertyName))
                expandoDict[propertyName] = propertyValue;
            else
                expandoDict.Add(propertyName, propertyValue);
            //var expandoDict1 = expandoDict as ExpandoObject;
            //return expandoDict;
        }

        public class DoctorDetails
        {
            [JsonProperty("Signing Doctor 1")]
            public string SigningDoctor1 { get; set; }
        }
        public class SourceDetails
        {
            [JsonProperty("Signing Doctor")]
            public List<DoctorDetails > SigningDoctor { get; set; }
            public string source_id { get; set; }
            public string orderNumber { get; set; }
            [JsonProperty("Patient Name")]
            public string PatientName { get; set; }
            public long fileInputReport { get; set; }
            public string labPatientId { get; set; }
            [JsonProperty("Test Name")]
            public string TestName { get; set; }
            public long CentreReportId { get; set; }
            public string integrationCode { get; set; }
            public string billReferral { get; set; }
            public long labId { get; set; }
            [JsonProperty("Sample Date")]
            public DateTime SampleDate { get; set; }
            public long billId { get; set; }
            public long dictionaryId { get; set; }
            [JsonProperty("Report Id")]
            public long ReportId { get; set; }
            public string dob { get; set; }
            public List<Reportvalues> reportFormatAndValues { get; set; }
            [JsonProperty("Report Date")]
            public DateTime ReportDate { get; set; }
            public string status { get; set; }
            public string testCode { get; set; }
            public string Gender { get; set; }
            public string Age { get; set; }
            [JsonProperty("Accession Date")]
            public string AccessionDate { get; set; }
            public long isSigned { get; set; }
            public long webhookId { get; set; }
            [JsonProperty("Patient Id")]
            public long PatientId { get; set; }
            public long labReportId { get; set; }
            public DateTime reportDate { get; set; }
            public string alternateEmail { get; set; }
            [JsonProperty("Approval Date")]
            public string ApprovalDate { get; set; }
            [JsonProperty("Contact No")]
            public string ContactNo { get; set; }
            public long testID { get; set; }
        }
        public class Reportvalues
        {
            public string highlight { get; set; }
            public string value { get; set; }
            public string observedIndexValue { get; set; }
            public string method { get; set; } 
            public ReportFormats reportFormat { get; set; }
           
        }
        public class ReportFormats
        {
            public long isImage { get; set; }
            public string lowerBoundFemale { get; set; }
            public string criticalUpperFemale { get; set; }
            public int descriptionFlag { get; set; }
            public string lowerBoundMale { get; set; }
            public int listField { get; set; }
            public string otherFemale { get; set; }
            public string criticalLowerMale { get; set; }
            public long otherFlag { get; set; }
            public long highlightFlag { get; set; }
            public string upperBoundFemale { get; set; }
            public string testName { get; set; }
            public long dictionaryId { get; set; }
            public string otherMale { get; set; }
            public string upperBoundMale { get; set; }
            public string testUnit { get; set; }
            public long fileInput { get; set; }
            public string integrationCode { get; set; }
            public string criticalUpperMale { get; set; }
            public string method { get; set; }
            public string criticalLowerFemale { get; set; }
        }

        /*Bulk Registration*/
        public class SmartReportDetails
        {
            public patientDetails patientDemographics { get; set; }
            public VisitDetail patientVisitDetails { get; set; }
            public List<orders> ordersArray { get; set; }
        }
        public class patientDetails
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string dob { get; set; }
            public string gender { get; set; }
            public string phoneNumber { get; set; }
            public string externalPatientId { get; set; }
            public string emailId { get; set; }
            public string relation { get; set; }
            public string healthHubId { get; set; }
        }

        public class visitDetails
        {
            public string testName { get; set; }
            public List<doctor> doctors { get; set; }
            public List<dynamic> vitalarray { get; set; }
        }
        public class orders
        {
            public visitDetails vitalDetails { get; set; }
        }
        public class doctor
        {
            public string name { get; set; }
            public string speciality { get; set; }
            public string designation { get; set; }
            public byte[] signature_binary { get; set; }
        }
        public class VisitDetail
        {
            public string visitId { get; set; }
            public string visitDate { get; set; }
            public string location { get; set; }
            public string labAddress { get; set; }
        }
        public class Regvalue
        {
            public string value { get; set; }
            public string unit { get; set; }
            public string testmethod { get; set; }
            public string normalrange { get; set; }
            public string interpretation { get; set; }
            public string specimen { get; set; }
        }

        /*Bulk Registration*/

        public static class FormUpload
        {
            private static readonly Encoding encoding = Encoding.UTF8;
            //rajkumar
            //public static HttpWebResponse MultipartFormPost(string postUrl, string userAgent, Dictionary<string, object> postParameters, string headerkey, string headervalue)
            public static HttpWebResponse MultipartFormPost(string postUrl, string userAgent, Dictionary<string, object> postParameters)
            //rajkumar
            {
                string formDataBoundary = String.Format("----------{0:N}", Guid.NewGuid());
                string contentType = "multipart/form-data; boundary=" + formDataBoundary;

                byte[] formData = GetMultipartFormData(postParameters, formDataBoundary);
                //rajkumar
                //return PostForm(postUrl, userAgent, contentType, formData, headerkey, headervalue);
                return PostForm(postUrl, userAgent, contentType, formData);
                //rajkumar
            }
            //rajkumar
            //private static HttpWebResponse PostForm(string postUrl, string userAgent, string contentType, byte[] formData, string headerkey, string headervalue)
            private static HttpWebResponse PostForm(string postUrl, string userAgent, string contentType, byte[] formData)
            //rajkumar
            {
                HttpWebRequest request = WebRequest.Create(postUrl) as HttpWebRequest;

                if (request == null)
                {
                    throw new NullReferenceException("request is not a http request");
                }

                // Set up the request properties.  
                request.Method = "POST";
                request.ContentType = contentType;
                request.UserAgent = userAgent;
                request.CookieContainer = new CookieContainer();
                request.ContentLength = formData.Length;

                // You could add authentication here as well if needed:  
                // request.PreAuthenticate = true;  
                // request.AuthenticationLevel = System.Net.Security.AuthenticationLevel.MutualAuthRequested;  

                //Add header if needed  
                //rajkumar
                //request.Headers.Add(headerkey, headervalue);
                //rajkumar

                // Send the form data to the request.  
                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(formData, 0, formData.Length);
                    requestStream.Close();
                }

                return request.GetResponse() as HttpWebResponse;
            }

            private static byte[] GetMultipartFormData(Dictionary<string, object> postParameters, string boundary)
            {
                Stream formDataStream = new System.IO.MemoryStream();
                bool needsCLRF = false;

                foreach (var param in postParameters)
                {

                    if (needsCLRF)
                        formDataStream.Write(encoding.GetBytes("\r\n"), 0, encoding.GetByteCount("\r\n"));

                    needsCLRF = true;

                    if (param.Value is FileParameter) // to check if parameter if of file type   
                    {
                        FileParameter fileToUpload = (FileParameter)param.Value;

                        // Add just the first part of this param, since we will write the file data directly to the Stream  
                        string header = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"; filename=\"{2}\"\r\nContent-Type: {3}\r\n\r\n",
                            boundary,
                            param.Key,
                            fileToUpload.FileName ?? param.Key,
                            fileToUpload.ContentType ?? "application/octet-stream");

                        formDataStream.Write(encoding.GetBytes(header), 0, encoding.GetByteCount(header));

                        // Write the file data directly to the Stream, rather than serializing it to a string.  
                        formDataStream.Write(fileToUpload.File, 0, fileToUpload.File.Length);
                    }
                    else
                    {
                        string postData = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"\r\n\r\n{2}",
                            boundary,
                            param.Key,
                            param.Value);
                        formDataStream.Write(encoding.GetBytes(postData), 0, encoding.GetByteCount(postData));
                    }
                }

                // Add the end of the request.  Start with a newline  
                string footer = "\r\n--" + boundary + "--\r\n";
                formDataStream.Write(encoding.GetBytes(footer), 0, encoding.GetByteCount(footer));

                // Dump the Stream into a byte[]  
                formDataStream.Position = 0;
                byte[] formData = new byte[formDataStream.Length];
                formDataStream.Read(formData, 0, formData.Length);
                formDataStream.Close();

                return formData;
            }

            public class FileParameter
            {
                public byte[] File { get; set; }
                public string FileName { get; set; }
                public string ContentType { get; set; }
                public FileParameter(byte[] file) : this(file, null) { }
                public FileParameter(byte[] file, string filename) : this(file, filename, null) { }
                public FileParameter(byte[] file, string filename, string contenttype)
                {
                    File = file;
                    FileName = filename;
                    ContentType = contenttype;
                }
            }


            //internal static HttpWebResponse MultipartFormDataPost(string baseAddress, string userAgent, Dictionary<string, object> postParameters)
            //{
            //    throw new NotImplementedException();
            //}
        }
         
        public void SleepMethod()
        {
            var stopwatch = Stopwatch.StartNew();
            Thread.Sleep(5000);
            stopwatch.Stop();
        }
        private void LogInfo(string pContent)
        {
            string sFileName = CreateLogFile();
            File.AppendAllText(sFileName, Environment.NewLine);
            File.AppendAllText(sFileName, DateTime.Now.ToString("G") + Environment.NewLine);
            File.AppendAllText(sFileName, "------------------------" + Environment.NewLine);
            File.AppendAllText(sFileName, pContent + Environment.NewLine);
        }

        private string CreateLogFile()
        {
            string sFileName = System.Configuration.ConfigurationManager.AppSettings["LogFile"];
            string LogFile = sFileName + DateTime.Now.ToString("_dd_MM_yyyy") + ".log";
            if (!File.Exists(LogFile))
            {
                FileStream obj = new FileStream(LogFile, FileMode.Create, FileAccess.ReadWrite);
                obj.Close();
            }
            return LogFile;
        }

        private void LogError(Exception oExp)
        {
            string sFileName = CreateLogFile();
            File.AppendAllText(sFileName, Environment.NewLine);
            File.AppendAllText(sFileName, DateTime.Now.ToString("G") + Environment.NewLine);
            File.AppendAllText(sFileName, "------------------------" + Environment.NewLine);
            File.AppendAllText(sFileName, oExp.Source + Environment.NewLine);
            File.AppendAllText(sFileName, oExp.Message + Environment.NewLine);
            File.AppendAllText(sFileName, oExp.Data.ToString() + Environment.NewLine);
            File.AppendAllText(sFileName, (oExp.InnerException != null) ? oExp.InnerException.ToString() : string.Empty);
            File.AppendAllText(sFileName, Environment.NewLine);
            File.AppendAllText(sFileName, oExp.StackTrace + Environment.NewLine);
        }
        public bool CertificateKeyValidation(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            bool valid = certificate.GetCertHashString() == CertificateValue;  // SHA-1 fingerprint
            return valid;
        }

        public bool OurCertificateFileValidation(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            //var actualCertificate = X509Certificate.CreateFromCertFile(@"C:\Users\admin\Downloads\email_certificate\iRedMail_CA.pem");
            //  bool valid = certificate.Equals(CertificateValue);
            //return valid;
            return true;
        }
    }
}
