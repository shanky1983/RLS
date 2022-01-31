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
using Newtonsoft.Json.Linq;

namespace Attune_RLSIntegration
{
    public partial class ProcessMessages : ServiceBase
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
       
        string authId = string.Empty;
        string authToken = string.Empty;
        string Url = string.Empty;
        string Proxyaddress = string.Empty;
        int Proxyport = 0;


        public string CertificateValue = "C:\\ATTUNE\\EMAIL_CERTIFICATE\\iRedMail_CA.pem";
        WebServiceSoapClient obj = new WebServiceSoapClient();
        //Attune.Schedule.Service.ServiceReference1.WebServiceSoapClient obj = new Attune.Schedule.Service.ServiceReference1.WebServiceSoapClient();

        public ProcessMessages()
        {
            LogInfo("Service Started Successfully:");

            this.ServiceName = "Attune_uploadStructureData_RLS_V1.0";
            this.EventLog.Log = "Application";
            this.CanHandlePowerEvent = true;
            this.CanHandleSessionChangeEvent = true;
            this.CanPauseAndContinue = true;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.ServiceName = "Attune_uploadStructureData_RLS_V1.0";
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
            if (listcomcon.Exists(p => p.Name == "authToken"))
            {
                authToken = listcomcon.Find(p => p.Name == "authToken").Value.ToString();
            }
            if (listcomcon.Exists(p => p.Name == "StructUrl"))
            {
                Url = listcomcon.Find(p => p.Name == "StructUrl").Value.ToString();
            }
            if (listcomcon.Exists(p => p.Name.ToLower() == "communicationproxy"))
            {
                Proxyaddress = listcomcon.Find(p => p.Name.ToLower() == "communicationproxy").Value.ToString();
            }
            if (listcomcon.Exists(p => p.Name.ToLower() == "communicationproxyport"))
            {
                Proxyport = Convert.ToInt32(listcomcon.Find(p => p.Name.ToLower() == "communicationproxyport").Value.ToString());
            }

            
            //FeedbackNotificationsNPS[] lstFeedbackNotifications=null;
            //List<FeedbackNotificationsNPS> lstFeedbackNotificationsupdate = new List<FeedbackNotificationsNPS>();
            //FeedbackNotificationsNPS objFeedbackNotificationsupdate = null;
            string StatusCode = string.Empty, StatusDescription = string.Empty;
            string APIUrl = string.Empty;
            string APIKey = string.Empty;
           
            BulkRegIntegration[] lstBulkRegIntegrations = null;
            BulkRegIntegrationResultValue[] lstBulkRegIntegrationResultValue = null;
            List<BulkRegIntegration> lstBulkRegIntegrationsupdate = new List<BulkRegIntegration>();
            BulkRegIntegration objBulkRegIntegrationsupdate = null;
            int lstcnt = 0;
            try
            {

                if (lstcnt == 0)
                {
                    lstBulkRegIntegrations = obj.GetBulkRegIntegrationNotifications(1);

                    if (lstBulkRegIntegrations != null && lstBulkRegIntegrations.Count() > 0)
                    {

                        lstcnt = lstBulkRegIntegrations.Count();
                        for (int i = 0; i < lstBulkRegIntegrations.Count(); i++)
                        {
                            try
                            {
                                //API call
                                ///rajkumar
                                //List<FeedbackNotificationsinfo> lstfinfo = new List<FeedbackNotificationsinfo>();
                                patientDemographics objpatientDemographics = new patientDemographics()
                                {
                                    firstName = lstBulkRegIntegrations[i].firstName,
                                    lastName = lstBulkRegIntegrations[i].lastName,
                                    dob = lstBulkRegIntegrations[i].dob.ToString("dd-MM-yyyy"),
                                    gender = lstBulkRegIntegrations[i].gender,
                                    phoneNumber = lstBulkRegIntegrations[i].phoneNumber,
                                    externalPatientId = lstBulkRegIntegrations[i].externalPatientId,
                                    emailid = lstBulkRegIntegrations[i].emailid,
                                    relation = lstBulkRegIntegrations[i].relation,
                                    healthHubId = lstBulkRegIntegrations[i].healthHubId
                                };

                              

                                lstBulkRegIntegrationResultValue = obj.GetBulkRegIntegrationResultValue(lstBulkRegIntegrations[i].NotificationID, 1);
                             
                                List<vitalDetails> lstvitalarray = new List<vitalDetails>();
                                vitalDetails objdetails = new vitalDetails();
                                var dict = lstBulkRegIntegrationResultValue.GroupBy(c => c.TestCode)
                                 .ToDictionary(k => k.Key, v => v.Select(f => new { f.value,f.unit,f.testmethod,f.normalrange,f.interpretation,f.specimen}).ToArray());
                                  List<vitalarray1> vital=new List<vitalarray1>();
                                  var report = lstBulkRegIntegrationResultValue.GroupBy(c => c.reportId).Select(grp => grp.First());
                                List<dynamic> alldict = new List<dynamic>();
                               
                               
                                foreach (BulkRegIntegrationResultValue listreport in report)
                                  {
                                    Dictionary<string, object> expandomain = new Dictionary<string, object>();
                                    vitalarray1 vitalarr = new vitalarray1();
                                      vitalarr.reportId = listreport.reportId;
                                      vitalarr.reportDate = String.Format("{0:dd-MM-yyyy HH:mm:ss}", listreport.reportDate); 
                                    var childdict = new Dictionary<string, object>();
                                    dynamic expando = new ExpandoObject();
                                    expando.reportId= listreport.reportId;
                                    expando.reportDate = String.Format("{0:dd-MM-yyyy HH:mm:ss}", listreport.reportDate);
                                    foreach (BulkRegIntegrationResultValue lis in lstBulkRegIntegrationResultValue)
                                      {
                                        dynamic expandochild = new ExpandoObject();
                                        if (listreport.reportId == lis.reportId)
                                        {
                                            var testcode = lis.TestCode;
                                            AddProperty(expando, lis.TestCode, new Regvalue { value = lis.value, testmethod = lis.testmethod, unit = lis.unit, normalrange = lis.normalrange, specimen = lis.specimen,interpretation=lis.interpretation });
                                        }
                                      } 
                                    foreach (var item in expando)
                                    {
                                        
                                        expandomain.Add(item.Key, item.Value); 
                                    }
                                    alldict.Add(expandomain);
                                   
                                }
                                objdetails.vitalarray = alldict.Distinct().ToList(); ;
                                doctor doctor1 = new doctor()
                                        {
                                            name = lstBulkRegIntegrationResultValue[0].doctor,
                                            specialty = ""

                                };
                                  
                                  objdetails.visitId = lstBulkRegIntegrations[i].visitId;
                                  objdetails.visitDate = lstBulkRegIntegrations[i].visitDate.ToString("dd-MM-yyyy HH:mm:ss"); 
                                  objdetails.doctor = doctor1; 
                                  JavaScriptSerializer jserilizer = new JavaScriptSerializer();
                                  var lstpatientDemographics = jserilizer.Serialize(objpatientDemographics);
                                  var lstvitalDetails = jserilizer.Serialize(objdetails); 
                                  var baseAddress = Url;
                                  Dictionary<string, object> postParameters = new Dictionary<string, object>(); 
                                  postParameters.Add("authId", authId);
                                  postParameters.Add("authToken", authToken);
                                  postParameters.Add("patientDemographics", lstpatientDemographics);
                                  postParameters.Add("vitalDetails", lstvitalDetails);
                                  LogInfo(lstpatientDemographics);
                                  LogInfo(lstvitalDetails);

                                  string userAgent = "";
                                // Remove insecure protocols (SSL3, TLS 1.0, TLS 1.1)
                                /*ServicePointManager.SecurityProtocol &= ~SecurityProtocolType.Ssl3;
                                ServicePointManager.SecurityProtocol &= ~SecurityProtocolType.Tls;
                                //ServicePointManager.SecurityProtocol &= ~SecurityProtocolType.Tls11;
                                // Add TLS 1.2
                                ServicePointManager.SecurityProtocol |= (SecurityProtocolType)(0xc0 | 0x300 | 0xc00); ;
                                ServicePointManager.SecurityProtocol = (SecurityProtocolType)768 | (SecurityProtocolType)3072;*/

                               // ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                              
                                HttpWebResponse webResponse = FormUpload.MultipartFormPost(baseAddress, userAgent, postParameters, Proxyaddress, Proxyport);
                                  StatusCode = webResponse.StatusCode.ToString();
                                  StreamReader responseReader = new StreamReader(webResponse.GetResponseStream());
                                  using (var rdr = new StreamReader(webResponse.GetResponseStream()))
                                  {
                                      StatusDescription = rdr.ReadToEnd();
                                  }
                                  objBulkRegIntegrationsupdate = new BulkRegIntegration();
                                  if (StatusDescription.Contains("Success") == true || StatusDescription.Contains("148"))
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
                                  SleepMethod();
                            }
                            catch (Exception ex)
                            {
                                LogInfo(ex.ToString());
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
            }
            catch (Exception Ex)
            {
                LogInfo("Exception in service-catchLoop :" + DateTime.Now.ToString());
                LogInfo(Ex.ToString());
                LogError(Ex);
            }
            finally
            {
                if (lstBulkRegIntegrationsupdate.Count() > 0)
                {

                    //obj.UpdateFeedbackNotifications(67, lstFeedbackNotificationsupdate.ToArray());
                    obj.UpdateBulkRegIntegrationNotifications(1, lstBulkRegIntegrationsupdate.ToArray());

                }
            }
        }
        public Dictionary<string,Object> GetPropertyKeysForDynamic(dynamic dynamicToGetPropertiesFor)
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
        public class Personalinfo
        {
            public string regid { get; set; }
            public string firstname { get; set; }
            public string lastname { get; set; }
            public string email { get; set; }
            public string mobileno { get; set; }
            public string gender { get; set; }
            public string transactionid { get; set; }

        }
        public class Qualifyinginfo
        {
            public string name { get; set; }
            public string value { get; set; }

        }
        public class FeedbackNotificationsinfo
        {
            public Personalinfo personalinfo { get; set; }
            public List<Qualifyinginfo> qualifyinginfo { get; set; }
        }




        public class FeedbackNotifications_NPS
        {
            public contactDTO contactDTO { get; set; }

            private string _surveyKey = string.Empty;

            public string surveyKey
            {
                get { return _surveyKey; }
                set { _surveyKey = value; }
            }

            private string _isThrottle = string.Empty;

            public string isThrottle
            {
                get { return _isThrottle; }
                set { _isThrottle = value; }
            }
        }

        public class FeedbackNotifications_NPS_Email
        {
            public userDTOs userDTOs { get; set; }

            private string _uniqueIdentifierApiKey = string.Empty;

            public string uniqueIdentifierApiKey
            {
                get { return _uniqueIdentifierApiKey; }
                set { _uniqueIdentifierApiKey = value; }
            }
        }

        public class contactDTO
        {
           
            public userDTOs userDTOs { get; set; }


            private string _uniqueIdentifierApiKey = string.Empty;

            public string uniqueIdentifierApiKey
            {
                get { return _uniqueIdentifierApiKey; }
                set { _uniqueIdentifierApiKey = value; }
            }
        }


        public class userDTOs
        {
            private string _mobile = string.Empty;
            private string _email = string.Empty;
            public string mobile
            {
                get { return _mobile; }
                set { _mobile = value; }
            }
            public string email
            {
                get { return _email; }
                set { _email = value; }
            }

            public string city { get; set; }
            public string state { get; set; }
            public string country { get; set; }


            //public int age { get; set; }
            public float age { get; set; }

            public string zip { get; set; }


            //One Direct Request to change the text
            //public string Gender { get; set; }
            //public string fullname { get; set; }
            public string gender { get; set; }
            public string fullName { get; set; }
            //One Direct Request to change the text
            public string storeId { get; set; }
            public string employeeId { get; set; }

            //public List<detailmap> detailmap { get; set; }
            public detailmap detailmap  { get; set; }
        }

        public class detailmap
        {
            
            //public string EmailId { get; set; }

            //public string Number { get; set; }
            public string pid { get; set; }
            public string vid { get; set; }
            public string center_name { get; set; }
            //public DateTime VisitDate { get; set; }
            public string sbu { get; set; }
            public string touch_point { get; set; }
            public string phlebotomist { get; set; }
           
        }

        /*Bulk Registration*/
        public class patientDemographics
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string dob { get; set; }
            public string gender { get; set; }
            public string phoneNumber { get; set; }
            public string externalPatientId { get; set; }
            public string emailid { get; set; }
            public string relation { get; set; }
            public string healthHubId { get; set; }
        }

        public class vitalDetails 
        {
            public string visitId { get; set; }
            public string visitDate { get; set; }
            public doctor doctor { get; set; }
            public List<dynamic> vitalarray { get; set; } 
        }

        public class doctor
        {
            public string name { get; set; }
            public string specialty { get; set; }
        }

        public class vitalarray
        {
            public long reportId { get; set; }
            public string reportDate { get; set; }
            public bp_systolic bp_systolic { get; set; }
        }
        public static dynamic GetDynamicObject(Dictionary<string, object> properties)
        {
            return new MyDynObject(properties);
        }
    public  class MyDynObject : DynamicObject
    {
        private readonly Dictionary<string, object> _properties;

        public MyDynObject(Dictionary<string, object> properties)
        {
            _properties = properties;
        }

        public override IEnumerable<string> GetDynamicMemberNames()
        {
            return _properties.Keys;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (_properties.ContainsKey(binder.Name))
            {
                result = _properties[binder.Name];
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            if (_properties.ContainsKey(binder.Name))
            {
                _properties[binder.Name] = value;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
        public class vitalarray1 : DynamicObject
        {
            public long reportId { get; set; }
            public string reportDate { get; set; }  
            // public Dictionary<string, Regvalue> data { get; set; }
        } 
        public class Regvalue {
            public string value { get; set; }
            public string unit { get; set; }
            public string testmethod { get; set; }
            public string normalrange { get; set; }
            public string interpretation { get; set; }
            public string specimen { get; set; }
        }
        public class bp_systolic
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
            public static HttpWebResponse MultipartFormPost(string postUrl, string userAgent, Dictionary<string, object> postParameters, string Proxyaddress, int Proxyport)
            //rajkumar
            {
                string formDataBoundary = String.Format("----------{0:N}", Guid.NewGuid());
                string contentType = "multipart/form-data; boundary=" + formDataBoundary;

                byte[] formData = GetMultipartFormData(postParameters, formDataBoundary);
                //rajkumar
                //return PostForm(postUrl, userAgent, contentType, formData, headerkey, headervalue);
                return PostForm(postUrl, userAgent, contentType, formData,  Proxyaddress,  Proxyport);
                //rajkumar
            }
            //rajkumar
            //private static HttpWebResponse PostForm(string postUrl, string userAgent, string contentType, byte[] formData, string headerkey, string headervalue)
            private static HttpWebResponse PostForm(string postUrl, string userAgent, string contentType, byte[] formData, string Proxyaddress, int Proxyport)

            {
                Uri myUri = new Uri(postUrl, UriKind.Absolute);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(myUri);
                if (!string.IsNullOrEmpty(Proxyaddress))
                {
                    WebProxy Proxy = new WebProxy(Proxyaddress, Proxyport);
                    Proxy.Credentials = CredentialCache.DefaultCredentials;
                    request.Proxy = Proxy;

                }
                else
                {
                    IWebProxy proxy = WebRequest.GetSystemWebProxy();
                    proxy.Credentials = CredentialCache.DefaultCredentials;
                    request.Proxy = proxy;
                    LogInfoform(proxy.GetProxy(myUri).ToString());
                    LogInfoform(proxy.GetProxy(myUri).Port.ToString());
                    NetworkCredential obj = proxy.Credentials.GetCredential(myUri, "Basic");
                    LogInfoform(obj.Domain);
                    LogInfoform(obj.UserName);
                    LogInfoform(obj.Password);
                }
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

                // Send the form data to the request.  
                LogInfoform(request.ToString());
                try
                {
                    using (Stream requestStream = request.GetRequestStream())
                    {
                        requestStream.Write(formData, 0, formData.Length);
                        requestStream.Close();
                    }
                }
                catch (Exception ex)
                {
                    LogInfoform(ex.ToString());
                }

                return request.GetResponse() as HttpWebResponse;
            }
            private static void LogInfoform(string pContent)
            {
                string sFileName = CreateLogFileform();
                File.AppendAllText(sFileName, Environment.NewLine);
                File.AppendAllText(sFileName, DateTime.Now.ToString("G") + Environment.NewLine);
                File.AppendAllText(sFileName, "------------------------" + Environment.NewLine);
                File.AppendAllText(sFileName, pContent + Environment.NewLine);
            }
            private static string CreateLogFileform()
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

        public void Servicecall(string APIUrl, string APIKey, List<FeedbackNotificationsinfo> lstfinfo, out string StatusCode, out string StatusDescription)
        {
             string _Statuscode = string .Empty ;
            string _StatueDescription = string.Empty ;
            try
            {
                JavaScriptSerializer jserilizer = new JavaScriptSerializer();
                var sendData = lstfinfo;  // jserilizer.Serialize();
                var sendData_obj = jserilizer.Serialize(lstfinfo);
                LogInfo(sendData_obj);
                string url = APIUrl + APIKey;
                WebRequest wr = WebRequest.Create(url);
                //  wr.Headers.Add("key" , APIKey);
                wr.Method = "POST";
                wr.ContentType = "application/json";
                wr.ContentLength = sendData_obj.Length;
                var requestStream = wr.GetRequestStream();
                byte[] postBytes = Encoding.UTF8.GetBytes(sendData_obj);
                requestStream.Write(postBytes, 0, postBytes.Length);
                requestStream.Close();
                // grab the response and print it out to the console along with the status code
                var response = (HttpWebResponse)wr.GetResponse();
                _Statuscode = response.StatusCode.ToString();
                using (var rdr = new StreamReader(response.GetResponseStream()))
                {
                    _StatueDescription = rdr.ReadToEnd();
                }



            }
            catch (Exception ex)
            {
                LogInfo("Exception in servic error :" + DateTime.Now.ToString());
                LogError(ex);

            }
            StatusCode = _Statuscode;
            StatusDescription = _StatueDescription;

        }



        public void ServicecallWithAuthorization(string APIUrl, string APIKey, List<FeedbackNotifications_NPS> lstfinfo, string Authorization,string Cache_Control,string Postman_Token,string brandid,string branduserid,string cache_control, out string StatusCode, out string StatusDescription)
        {
            string _Statuscode = string.Empty;
            string _StatueDescription = string.Empty;
            try
            {
                JavaScriptSerializer jserilizer = new JavaScriptSerializer();
                var sendData = lstfinfo;  // jserilizer.Serialize();
                var sendData_obj = jserilizer.Serialize(lstfinfo.First());

                //sendData_obj = sendData_obj.Replace("\"s:", "[");
                sendData_obj = sendData_obj.Replace(@"s"":{", @"s"":[{");
                sendData_obj = sendData_obj.Replace(@"},""u", @"}],""u");

                LogInfo(sendData_obj);
                string url = APIUrl;
                WebRequest wr = WebRequest.Create(url);

                wr.Headers.Add("Authorization", Authorization);
                wr.Headers.Add("Cache-Control", Cache_Control);
                wr.Headers.Add("Postman-Token", Postman_Token);
                wr.Headers.Add("brandid", brandid);
                wr.Headers.Add("branduserid", branduserid);
                wr.Headers.Add("cache-control", cache_control);
                
                wr.Method = "POST";
                wr.ContentType = "application/json";
                wr.ContentLength = sendData_obj.Length;
                var requestStream = wr.GetRequestStream();
                byte[] postBytes = Encoding.UTF8.GetBytes(sendData_obj);
                requestStream.Write(postBytes, 0, postBytes.Length);
                requestStream.Close();
                // grab the response and print it out to the console along with the status code
                var response = (HttpWebResponse)wr.GetResponse();
                _Statuscode = response.StatusCode.ToString();
                using (var rdr = new StreamReader(response.GetResponseStream()))
                {
                    _StatueDescription = rdr.ReadToEnd();
                }



            }
            catch (Exception ex)
            {
                LogInfo("Exception in servic error :" + DateTime.Now.ToString());
                LogError(ex);

            }
            StatusCode = _Statuscode;
            StatusDescription = _StatueDescription;

        }


        public void ServicecallWithAuthorization_Email(string APIUrl, string APIKey, List<FeedbackNotifications_NPS_Email> lstfinfo, string Authorization, string Cache_Control, string Postman_Token, string brandid, string branduserid, string cache_control, out string StatusCode, out string StatusDescription)
        {
            string _Statuscode = string.Empty;
            string _StatueDescription = string.Empty;
            try
            {
                JavaScriptSerializer jserilizer = new JavaScriptSerializer();
                var sendData = lstfinfo;  // jserilizer.Serialize();
                var sendData_obj = jserilizer.Serialize(lstfinfo.First());

                //sendData_obj = sendData_obj.Replace("\"s:", "[");
                sendData_obj = sendData_obj.Replace(@"s"":{", @"s"":[{");
                sendData_obj = sendData_obj.Replace(@"},""u", @"}],""u");

                LogInfo(sendData_obj);
                string url = APIUrl;
                WebRequest wr = WebRequest.Create(url);

                wr.Headers.Add("Authorization", Authorization);
                wr.Headers.Add("Cache-Control", Cache_Control);
                wr.Headers.Add("Postman-Token", Postman_Token);
                wr.Headers.Add("brandid", brandid);
                wr.Headers.Add("branduserid", branduserid);
                wr.Headers.Add("cache-control", cache_control);

                wr.Method = "POST";
                wr.ContentType = "application/json";
                wr.ContentLength = sendData_obj.Length;
                var requestStream = wr.GetRequestStream();
                byte[] postBytes = Encoding.UTF8.GetBytes(sendData_obj);
                requestStream.Write(postBytes, 0, postBytes.Length);
                requestStream.Close();
                // grab the response and print it out to the console along with the status code
                var response = (HttpWebResponse)wr.GetResponse();
                _Statuscode = response.StatusCode.ToString();
                using (var rdr = new StreamReader(response.GetResponseStream()))
                {
                    _StatueDescription = rdr.ReadToEnd();
                }



            }
            catch (Exception ex)
            {
                LogInfo("Exception in servic error :" + DateTime.Now.ToString());
                LogError(ex);

            }
            StatusCode = _Statuscode;
            StatusDescription = _StatueDescription;

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
        static void createType(string name, IDictionary<string, BulkRegIntegrationResultValue> props)
        {
            var csc = new CSharpCodeProvider(new Dictionary<string, string>() { { "CompilerVersion", "v4.0" } });
            var parameters = new CompilerParameters(new[] { "mscorlib.dll", "System.Core.dll" }, "Test.Dynamic.dll", false);
            parameters.GenerateExecutable = false;

            var compileUnit = new CodeCompileUnit();
            var ns = new CodeNamespace("Test.Dynamic");
            compileUnit.Namespaces.Add(ns);
            ns.Imports.Add(new CodeNamespaceImport("System"));

            var classType = new CodeTypeDeclaration(name);
            classType.Attributes = MemberAttributes.Public;
            ns.Types.Add(classType);

            foreach (var prop in props)
            {
                var fieldName = "_" + prop.Key;
                var field = new CodeMemberField(prop.GetType(), prop.Key);
                classType.Members.Add(field);

                var property = new CodeMemberProperty();
                property.Attributes = MemberAttributes.Public | MemberAttributes.Final;
                property.Type = new CodeTypeReference(prop.GetType());
                property.Name = prop.Key;
                property.GetStatements.Add(new CodeMethodReturnStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), fieldName)));
                property.SetStatements.Add(new CodeAssignStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), fieldName), new CodePropertySetValueReferenceExpression()));
                classType.Members.Add(property);
            }

            var results = csc.CompileAssemblyFromDom(parameters, compileUnit);
            results.Errors.Cast<CompilerError>().ToList().ForEach(error => Console.WriteLine(error.ErrorText));
        }
    }
}