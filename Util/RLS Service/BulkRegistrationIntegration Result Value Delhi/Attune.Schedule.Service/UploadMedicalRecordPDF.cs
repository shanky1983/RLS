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
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Attune_RLSIntegration
{
  public  class UploadMedicalRecordPDF : ServiceBase
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
        string ReportFolderPath = string.Empty;
        string Proxyaddress = string.Empty;
        int Proxyport=0;

        public string CertificateValue = "C:\\ATTUNE\\EMAIL_CERTIFICATE\\iRedMail_CA.pem";
        //NacoIntegrationWebServiceSoapClient obj = new NacoIntegrationWebServiceSoapClient();
        WebServiceSoapClient obj = new WebServiceSoapClient();
        //Attune.Schedule.Service.ServiceReference1.WebServiceSoapClient obj = new Attune.Schedule.Service.ServiceReference1.WebServiceSoapClient();

        public UploadMedicalRecordPDF()
        {
            LogInfo("Service Started Successfully:");

            this.ServiceName = "Attune_uploadMedicalRecord_RLS_V1.0";
            this.EventLog.Log = "Application";
            this.CanHandlePowerEvent = true;
            this.CanHandleSessionChangeEvent = true;
            this.CanPauseAndContinue = true;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.ServiceName = "Attune_uploadMedicalRecord_RLS_V1.0";
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

            string root = string.Empty;
            string folderroot = string.Empty;
            string Newroot = string.Empty;
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
            if (listcomcon.Exists(p => p.Name == "PDFUploadURL"))
            {
                Url = listcomcon.Find(p => p.Name == "PDFUploadURL").Value.ToString();
            }
            if (listcomcon.Exists(p => p.Name.ToLower() == "reportpdffolderpath"))
            {
                ReportFolderPath = listcomcon.Find(p => p.Name.ToLower() == "reportpdffolderpath").Value.ToString();
                LogInfo("ReportFolderPath is:" + ReportFolderPath);
            }
            else
            {
                LogInfo("List does not have values for ReportFolderPath");
            }
            if (listcomcon.Exists(p => p.Name.ToLower() == "communicationproxy"))
            {
                Proxyaddress = listcomcon.Find(p => p.Name.ToLower() == "communicationproxy").Value.ToString();
            }
            if (listcomcon.Exists(p => p.Name.ToLower() == "communicationproxyport"))
            {
                Proxyport =Convert.ToInt32( listcomcon.Find(p => p.Name.ToLower() == "communicationproxyport").Value.ToString());
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
                    lstBulkRegIntegrations = obj.GetBulkRegIntegrationNotifications(2);

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
                                    //phoneNumber = "8000743388",
                                    external_patient_id = lstBulkRegIntegrations[i].externalPatientId,
                                    emailId = lstBulkRegIntegrations[i].emailid,
                                    //country_code = "",
                                    healthHubId = lstBulkRegIntegrations[i].healthHubId
                                    //healthHubId = "YVYW-4354"
                                };


                                medicalData objmedicalData = new medicalData()
                                {
                                    title = "",
                                    description = "",
                                    external_link_id = "",
                                    category_id = "4",
                                    uploaded_on = "",
                                    order_id = lstBulkRegIntegrations[i].BookingNo,
                                    parameter = ""
                                };
                                folderroot = ReportFolderPath + lstBulkRegIntegrations[i].Template;
                                Newroot = ReportFolderPath + lstBulkRegIntegrations[i].Template.Replace("REPORT", "FINALREPORT");
                                if (!System.IO.Directory.Exists(folderroot))
                                {
                                    System.IO.Directory.CreateDirectory(folderroot);
                                }
                                root = ReportFolderPath + lstBulkRegIntegrations[i].Template.Replace('/', '\\') + lstBulkRegIntegrations[i].AttachmentName;
                                List<BulkRegFileDetails> lstfile = new List<BulkRegFileDetails>();
                                var myList = new List<string>();
                                int cnt = 0;
                                myList.Add(root);
                                if (lstBulkRegIntegrations[i].lstFile != null && lstBulkRegIntegrations[i].lstFile.Count() > 0)
                                {
                                    foreach (BulkRegFileDetails lis in lstBulkRegIntegrations[i].lstFile)
                                    {
                                        if (lis.NotificationID == lstBulkRegIntegrations[i].NotificationID)
                                        {
                                            myList.Add(lis.FilePath.Replace('/', '\\') + lis.FileName);
                                        }
                                    }
                                }
                                var myArray = myList.ToArray();
                                byte[] bytes = concatAndAddContent(myArray);
                                CLogger.LogWarning("testmethod After concatAndAddContent");
                                string OrginalFileName = Newroot + lstBulkRegIntegrations[i].AttachmentName;
                                string TempFileName = Newroot + lstBulkRegIntegrations[i].AttachmentName;
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
                                        LogInfo(ex.ToString());
                                        Thread.Sleep(1000);
                                        _FileUse = false;
                                        if (ThreadCount == 30000)
                                        {
                                            _FileUse = true;
                                        }

                                    }
                                }
                                JavaScriptSerializer jserilizer = new JavaScriptSerializer();
                                var lstpatientDemographics = jserilizer.Serialize(objpatientDemographics);
                                var lstmedicalData = jserilizer.Serialize(objmedicalData);
                                var baseAddress = Url;
                                var root1 = OrginalFileName;//root ;
                                //FileStream fs = new FileStream("D:\\mobile.png", FileMode.Open, FileAccess.Read);
                                //FileStream fs = new FileStream("D:\\API_JioHealthHub_Report_Integration.pdf", FileMode.Open, FileAccess.Read);
                                FileStream fs = new FileStream(root1, FileMode.Open, FileAccess.Read);
                                byte[] data = new byte[fs.Length];
                                fs.Read(data, 0, data.Length);
                                fs.Close();

                                // Generate post objects
                                Dictionary<string, object> postParameters = new Dictionary<string, object>();
                                postParameters.Add("authId", authId);
                                postParameters.Add("authToken", authToken);
                                //Here you can create one class for patientDemographics with required properties and serialize the same to achieve below JSON string from an object directly
                                postParameters.Add("patientData", lstpatientDemographics);
                                //Here you can create one class for patientDemographics with required properties and serialize the same to achieve below JSON string from an object directly
                                postParameters.Add("medicalData", lstmedicalData);

                                //postParameters.Add("file", new FormUpload.FileParameter(data, Path.GetFileName("Senior_Citizen_Plan.pdf"), "application/pdf"));  
                                postParameters.Add("file", new FormUpload.FileParameter(data, Path.GetFileName(root1), "application/pdf"));

                                LogInfo(lstpatientDemographics);
                                LogInfo(lstmedicalData); 

                                // Create request and receive response
                                string userAgent = "";

                                //ServicePointManager.SecurityProtocol = (SecurityProtocolType)768 | (SecurityProtocolType)3072;
                                // Remove insecure protocols (SSL3, TLS 1.0, TLS 1.1)
                                /*  ServicePointManager.SecurityProtocol &= ~SecurityProtocolType.Ssl3;
                                  ServicePointManager.SecurityProtocol &= ~SecurityProtocolType.Tls;
                                  //ServicePointManager.SecurityProtocol &= ~SecurityProtocolType.Tls11;
                                  // Add TLS 1.2
                                 // ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
                                  ServicePointManager.SecurityProtocol |= (SecurityProtocolType)(0xc0 | 0x300 | 0xc00);*/
                                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                                HttpWebResponse webResponse = FormUpload.MultipartFormPost(baseAddress, userAgent, postParameters,Proxyaddress,Proxyport);
                                // Process response
                                StatusCode = webResponse.StatusCode.ToString();
                                StreamReader responseReader = new StreamReader(webResponse.GetResponseStream());
                                using (var rdr = new StreamReader(webResponse.GetResponseStream()))
                                {
                                    StatusDescription = rdr.ReadToEnd();
                                }





                                objBulkRegIntegrationsupdate = new BulkRegIntegration();
                                if (StatusDescription.Contains("OK") == true)
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
                    obj.UpdateBulkRegIntegrationNotifications(2, lstBulkRegIntegrationsupdate.ToArray());

                }
            }
        }
        public static byte[] concatAndAddContent(string[] filename)
        {
            byte[] mergedPdf = null;
            string strTempFileName = string.Empty;
            try
            {
                CLogger.LogWarning("concatAndAddContent fileName : " + filename);
                using (MemoryStream ms = new MemoryStream())
                {
                    CLogger.LogWarning("concatAndAddContent Get MemoryStream : ");
                    using (Document document = new Document())
                    {
                        CLogger.LogWarning("concatAndAddContent Get document : ");
                        using (PdfCopy copy = new PdfCopy(document, ms))
                        {
                            CLogger.LogWarning("concatAndAddContent Before document Open : ");
                            document.Open();
                            CLogger.LogWarning("concatAndAddContent After document Open : ");
                            for (int i = 0; i <= filename.Length - 1; ++i)
                            {
                                if (filename[i] != "")
                                {
                                    CLogger.LogWarning("concatAndAddContent File Name " + filename[i]);
                                    iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(filename[i]);
                                    int n = reader.NumberOfPages;
                                    CLogger.LogWarning("concatAndAddContent NumberOfPages " + n.ToString());
                                    for (int page = 0; page < n;)
                                    {
                                        copy.AddPage(copy.GetImportedPage(reader, ++page));
                                    }

                                }
                            }
                        }
                    }
                    mergedPdf = ms.ToArray();
                    CLogger.LogWarning("concatAndAddContent set mergedPdf ");
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while concatAndAddContent:", ex);
            }
            finally
            {
                CLogger.LogWarning("Error while concatAndAddContent Final Block:");
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
                CLogger.LogError("Error in AddPageNumber", ex);
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
            public detailmap detailmap { get; set; }
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
            public string external_patient_id { get; set; }
            public string emailId { get; set; }
            //public string country_code { get; set; }
            public string healthHubId { get; set; }
        }

        public class medicalData
        {
            public string title { get; set; }
            public string description { get; set; }
            public string external_link_id { get; set; }
            public string category_id { get; set; }
            public string uploaded_on { get; set; }
            public string order_id { get; set; }
            public string parameter { get; set; }
        }

        public class vitalDetails
        {
            public string visitId { get; set; }
            public string visitDate { get; set; }
            public doctor doctor { get; set; }
            public IList<vitalarray> vitalarray { get; set; }
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
            public static HttpWebResponse MultipartFormPost(string postUrl, string userAgent, Dictionary<string, object> postParameters,string Proxyaddress,int Proxyport)
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
            //rajkumar
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

                //Add header if needed  
                //rajkumar
                //request.Headers.Add(headerkey, headervalue);
                //rajkumar

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
            string _Statuscode = string.Empty;
            string _StatueDescription = string.Empty;
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



        public void ServicecallWithAuthorization(string APIUrl, string APIKey, List<FeedbackNotifications_NPS> lstfinfo, string Authorization, string Cache_Control, string Postman_Token, string brandid, string branduserid, string cache_control, out string StatusCode, out string StatusDescription)
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
            string sFileName = System.Configuration.ConfigurationSettings.AppSettings["LogFile"];
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
