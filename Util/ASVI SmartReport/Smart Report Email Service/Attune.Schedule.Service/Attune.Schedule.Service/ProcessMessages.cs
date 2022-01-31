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
using Attune.Schedule.Service.ServiceReference1;
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

//using iTextSharp.text.pdf;

namespace Attune.Schedule.Service
{
    public partial class ScheduleProcess : ServiceBase
    {
        System.Timers.Timer ServiceTimer;
        string IsPdfActive = "";
        string IsStatPdfActive = "";
        string IsROUNDBPdfActive = "";
        string IsEMailActive = "";
        string IsSmsActive = "";
        string IsConfidRoundbPdfActive = "";
        string IsConfidPdfActive = "";
        string IsClientBlindParentPdfActive="";
        string IsClientBlindParentRoundbPdfActive="";
        string IsClientBlindChildPdfActive="";
        string IsClientBlindChildRoundbPdfActive="";
        int InstantsID = 0;
        string Logtime = string.Empty;
        string FolderPath = string.Empty;
        string ReportFolderPath = string.Empty;
        string OldReportFolderPath = string.Empty;
        string InvoiceFolderPath = string.Empty;
        string BillFolderPath = string.Empty;
        string OldInvoiceFolderPath = string.Empty;
        string OldBillFolderPath = string.Empty;
        string ReportBannerImageFolderpath = string.Empty;
        string FACEBOOKLOGOFOLDERPATH = string.Empty;
        string METROLOGOFOLDERPATH = string.Empty;
        string MOBILEAPPLOGOFOLDERPATH = string.Empty;
        string fromAddress = string.Empty;
        string fromDisplay = string.Empty;
        string hostname = string.Empty;
        string port = string.Empty;
        string SmsUsername = string.Empty;
        string SmsPasswd = string.Empty;
        string URL = string.Empty;
        string URLCOMMON = string.Empty;
        string username = string.Empty;
        string passwd = string.Empty;
        string provider = string.Empty;
        string sFileName = string.Empty;
        string CCAddress = string.Empty;
        string BCCAddress = string.Empty;
        object ob = new object();
        string ServiceInterval = string.Empty;
        string tempstart = string.Empty;
        string Category = "";
        string ISBILLWOSPDFACTIVE = string.Empty;
        int timedoutcount = 0;
        string APIURL = string.Empty;
        public string IsCertificateValidation = "";
        public string CertificateType = "FILEPATH";
        public string CertificateValue = "C:\\ATTUNE\\EMAIL_CERTIFICATE\\iRedMail_CA.pem";
        Attune.Schedule.Service.ServiceReference1.WebServiceSoap obj = new Attune.Schedule.Service.ServiceReference1.WebServiceSoapClient();

        public ScheduleProcess()
        {
            this.ServiceName = "Attune-SmartReportCreation-V1.0";
            this.EventLog.Log = "Application";
            this.CanHandlePowerEvent = true;
            this.CanHandleSessionChangeEvent = true;
            this.CanPauseAndContinue = true;
            InitializeComponent();
            ProcessStart();
        }

        private void InitializeComponent()
        {
            this.ServiceName = "Attune-SmartReportCreation-V1.0";
        }

       // protected override void OnStart(string[] args)
        public void OnStart(string[] args)
        {
            ProcessStart();
        }
         public void ProcessStart()
        {
            try
            {
                List<CommunicationConfig> listcomcon = new List<CommunicationConfig>();
                InstantsID = Convert.ToInt32(System.Configuration.ConfigurationSettings.AppSettings["InstantsID"].Trim());
                sFileName = System.Configuration.ConfigurationManager.AppSettings["LogFile"].Trim().ToString();
                Category = System.Configuration.ConfigurationManager.AppSettings["Category"].Trim().ToString();
                APIURL = System.Configuration.ConfigurationManager.AppSettings["URL"].Trim().ToString();
                CommunicationConfig[] comconfig = obj.GetCommunicationConfig(InstantsID, "");
                listcomcon = comconfig.ToList();
                //if (listcomcon.Exists(p => p.Name.ToLower() == "logfile"))
                //{
                //    sFileName = listcomcon.Find(p => p.Name.ToLower() == "logfile").Value.ToString();
                //}
                //else
                //{
                //    sFileName = "c:\\Attune-Auto-Email-Service.log";
                //}
                if (listcomcon.Count() > 0)
                {
                    LogInfo("List have values for CommunicationConfig");
                }
                else
                {
                    LogInfo("List does not have values for CommunicationConfig");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "ispdfactive"))
                {
                    IsPdfActive = listcomcon.Find(p => p.Name.ToLower() == "ispdfactive").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for ispdfactive");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "isstatpdfactive"))
                {
                    IsStatPdfActive = listcomcon.Find(p => p.Name.ToLower() == "isstatpdfactive").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for IsStatPdfActive");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "isroundbpdfactive"))
                {
                    IsROUNDBPdfActive = listcomcon.Find(p => p.Name.ToLower() == "isroundbpdfactive").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for IsROUNDBPdfActive");
                }
                //added by Bhupathy
                if (listcomcon.Exists(p => p.Name.ToLower() == "isconfidroundbpdfactive"))
                {
                    IsConfidRoundbPdfActive = listcomcon.Find(p => p.Name.ToLower() == "isconfidroundbpdfactive").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for IsConfidRoundbPdfActive");
                }

                if (listcomcon.Exists(p => p.Name.ToLower() == "isconfidpdfactive"))
                {
                    IsConfidPdfActive = listcomcon.Find(p => p.Name.ToLower() == "isconfidpdfactive").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for IsConfidPdfActive");
                }
                 if (listcomcon.Exists(p => p.Name.ToLower() == "isclientblindparentpdfactive"))
                {
                    IsClientBlindParentPdfActive = listcomcon.Find(p => p.Name.ToLower() == "isclientblindparentpdfactive").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for IsClientBlindParentPdfActive");
                }

                if (listcomcon.Exists(p => p.Name.ToLower() == "isclientblindparentroundbpdfactive"))
                {
                    IsClientBlindParentRoundbPdfActive = listcomcon.Find(p => p.Name.ToLower() == "isclientblindparentroundbpdfactive").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for IsClientBlindParentRoundbPdfActive");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "isclientblindchildpdfactive"))
                {
                    IsClientBlindChildPdfActive = listcomcon.Find(p => p.Name.ToLower() == "isclientblindchildpdfactive").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for IsClientBlindChildPdfActive");
                }

                if (listcomcon.Exists(p => p.Name.ToLower() == "isclientblindchildroundbpdfactive"))
                {
                    IsClientBlindChildRoundbPdfActive = listcomcon.Find(p => p.Name.ToLower() == "isclientblindchildroundbpdfactive").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for IsClientBlindChildRoundbPdfActive");
                }
                //End
                if (listcomcon.Exists(p => p.Name.ToLower() == "isbillwospdfactive"))
                {
                    ISBILLWOSPDFACTIVE = listcomcon.Find(p => p.Name.ToLower() == "isbillwospdfactive").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for ISBILLWOSPDFACTIVE");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "isemailactive"))
                {
                    IsEMailActive = listcomcon.Find(p => p.Name.ToLower() == "isemailactive").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for isemailactive");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "issmsactive"))
                {
                    IsSmsActive = listcomcon.Find(p => p.Name.ToLower() == "issmsactive").Value.ToString();
                }
                {
                    LogInfo("List does not have values for issmsactive");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "logtime" && p.Type.ToLower() == "email"))
                {
                    Logtime = listcomcon.Find(p => p.Name.ToLower() == "logtime" && p.Type.ToLower() == "email").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for logtime");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "pdffolderpath" && p.Type.ToLower() == "email"))
                {
                    FolderPath = listcomcon.Find(p => p.Name.ToLower() == "pdffolderpath" && p.Type.ToLower() == "email").Value.ToString();
                    LogInfo("FolderPath is:" + FolderPath);
                }
                else
                {
                    LogInfo("List does not have values for FolderPath");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "oldreportpdffolderpath" && p.Type.ToLower() == "email"))
                {
                    OldReportFolderPath = listcomcon.Find(p => p.Name.ToLower() == "oldreportpdffolderpath" && p.Type.ToLower() == "email").Value.ToString();
                    LogInfo("OldReportFolderPath is:" + OldReportFolderPath);
                }
                else
                {
                    LogInfo("List does not have values for OldReportFolderPath");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "reportpdffolderpath" && p.Type.ToLower() == "email"))
                {
                    ReportFolderPath = listcomcon.Find(p => p.Name.ToLower() == "reportpdffolderpath" && p.Type.ToLower() == "email").Value.ToString();
                    LogInfo("ReportFolderPath is:" + ReportFolderPath);
                }
                else
                {
                    LogInfo("List does not have values for ReportFolderPath");
                }
                
                if (listcomcon.Exists(p => p.Name.ToLower() == "oldinvoicepdffolderpath" && p.Type.ToLower() == "email"))
                {
                    OldInvoiceFolderPath = listcomcon.Find(p => p.Name.ToLower() == "oldinvoicepdffolderpath" && p.Type.ToLower() == "email").Value.ToString();
                    LogInfo("OldInvoiceFolderPath is:" + OldInvoiceFolderPath);
                }
                else
                {
                    LogInfo("List does not have values for OldInvoiceFolderPath");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "oldbillpdffolderpath" && p.Type.ToLower() == "email"))
                {
                    OldBillFolderPath = listcomcon.Find(p => p.Name.ToLower() == "oldbillpdffolderpath" && p.Type.ToLower() == "email").Value.ToString();
                    LogInfo("OldBillFolderPath is:" + OldBillFolderPath);
                }
                else
                {
                    LogInfo("List does not have values for OldBillFolderPath");
                }               
                
                if (listcomcon.Exists(p => p.Name.ToLower() == "invoicepdffolderpath" && p.Type.ToLower() == "email"))
                {
                    InvoiceFolderPath = listcomcon.Find(p => p.Name.ToLower() == "invoicepdffolderpath" && p.Type.ToLower() == "email").Value.ToString();
                    LogInfo("InvoiceFolderPath is:" + InvoiceFolderPath);
                }
                else
                {
                    LogInfo("List does not have values for InvoiceFolderPath");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "billpdffolderpath" && p.Type.ToLower() == "email"))
                {
                    BillFolderPath = listcomcon.Find(p => p.Name.ToLower() == "billpdffolderpath" && p.Type.ToLower() == "email").Value.ToString();
                    LogInfo("BillFolderPath is:" + BillFolderPath);
                }
                else
                {
                    LogInfo("List does not have values for BillFolderPath");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "reportbannerimagefolderpath" && p.Type.ToLower() == "email"))
                {
                    ReportBannerImageFolderpath = listcomcon.Find(p => p.Name.ToLower() == "reportbannerimagefolderpath" && p.Type.ToLower() == "email").Value.ToString();
                    LogInfo("ReportBannerImageFolderpath is:" + ReportBannerImageFolderpath);
                }
                else
                {
                    LogInfo("List does not have values for BillFolderPath");
                }

                if (listcomcon.Exists(p => p.Name.ToLower() == "facebooklogofolderpath" && p.Type.ToLower() == "email"))
                {
                    FACEBOOKLOGOFOLDERPATH = listcomcon.Find(p => p.Name.ToLower() == "facebooklogofolderpath" && p.Type.ToLower() == "email").Value.ToString();
                    LogInfo("FACEBOOKLOGOFOLDERPATH is:" + FACEBOOKLOGOFOLDERPATH);
                }
                else
                {
                    LogInfo("List does not have values for FACEBOOKLOGOFOLDERPATH");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "mobileapplogofolderpath" && p.Type.ToLower() == "email"))
                {
                    MOBILEAPPLOGOFOLDERPATH = listcomcon.Find(p => p.Name.ToLower() == "mobileapplogofolderpath" && p.Type.ToLower() == "email").Value.ToString();
                    LogInfo("MOBILEAPPLOGOFOLDERPATH is:" + MOBILEAPPLOGOFOLDERPATH);
                }
                else
                {
                    LogInfo("List does not have values for MOBILEAPPLOGOFOLDERPATH");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "metrologofolderpath" && p.Type.ToLower() == "email"))
                {
                    METROLOGOFOLDERPATH = listcomcon.Find(p => p.Name.ToLower() == "metrologofolderpath" && p.Type.ToLower() == "email").Value.ToString();
                    LogInfo("METROLOGOFOLDERPATH is:" + METROLOGOFOLDERPATH);
                }
                else
                {
                    LogInfo("List does not have values for METROLOGOFOLDERPATH");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "fromaddress" && p.Type.ToLower() == "email"))
                {
                    fromAddress = listcomcon.Find(p => p.Name.ToLower() == "fromaddress" && p.Type.ToLower() == "email").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for FromAddress");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "fromdisplaytext" && p.Type.ToLower() == "email"))
                {
                    fromDisplay = listcomcon.Find(p => p.Name.ToLower() == "fromdisplaytext" && p.Type.ToLower() == "email").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for FromDisplaytext");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "host" && p.Type.ToLower() == "email"))
                {
                    hostname = listcomcon.Find(p => p.Name.ToLower() == "host" && p.Type.ToLower() == "email").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for Host");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "ccaddress" && p.Type.ToLower() == "email"))
                {
                    CCAddress = listcomcon.Find(p => p.Name.ToLower() == "ccaddress" && p.Type.ToLower() == "email").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for CCAddress");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "bccaddress" && p.Type.ToLower() == "email"))
                {
                    BCCAddress = listcomcon.Find(p => p.Name.ToLower() == "bccaddress" && p.Type.ToLower() == "email").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for BCCAddress");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "port" && p.Type.ToLower() == "email"))
                {
                    port = listcomcon.Find(p => p.Name.ToLower() == "port" && p.Type.ToLower() == "email").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for Port");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "username" && p.Type.ToLower() == "email"))
                {
                    username = listcomcon.Find(p => p.Name.ToLower() == "username" && p.Type.ToLower() == "email").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for UserName");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "password" && p.Type.ToLower() == "email"))
                {
                    passwd = listcomcon.Find(p => p.Name.ToLower() == "password" && p.Type.ToLower() == "email").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for PassWord");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "iscertificatevalidation" && p.Type.ToLower() == "email"))
                {
                    IsCertificateValidation = listcomcon.Find(p => p.Name.ToLower() == "iscertificatevalidation" && p.Type.ToLower() == "email").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for iscertificatevalidation");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "certificatetype" && p.Type.ToLower() == "email"))
                {
                    CertificateType = listcomcon.Find(p => p.Name.ToLower() == "certificatetype" && p.Type.ToLower() == "email").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for certificatetype");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "certificatevalue" && p.Type.ToLower() == "email"))
                {
                    CertificateValue = listcomcon.Find(p => p.Name.ToLower() == "certificatevalue" && p.Type.ToLower() == "email").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for certificatevalue");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "url" && p.Type.ToLower() == "sms"))
                {
                    URL = listcomcon.Find(p => p.Name.ToLower() == "url" && p.Type.ToLower() == "sms").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for Sms Url");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "username" && p.Type.ToLower() == "sms"))
                {
                    SmsUsername = listcomcon.Find(p => p.Name.ToLower() == "username" && p.Type.ToLower() == "sms").Value.ToString();
                    URL = URL.Replace("{" + listcomcon.Find(p => p.Name.ToLower() == "username" && p.Type.ToLower() == "sms").Name.ToString() + "}", SmsUsername);
                }
                else
                {
                    LogInfo("List does not have values for Sms Username");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "password" && p.Type.ToLower() == "sms"))
                {
                    SmsPasswd = listcomcon.Find(p => p.Name.ToLower() == "password" && p.Type.ToLower() == "sms").Value.ToString();
                    string DecryptedPassword = string.Empty;
                    CCryptography objDecryptor = new CCryptFactory().GetDecryptor();
                    objDecryptor.Crypt(SmsPasswd, out DecryptedPassword);
                    URL = URL.Replace("{" + listcomcon.Find(p => p.Name.ToLower() == "password" && p.Type.ToLower() == "sms").Name.ToString() + "}", DecryptedPassword);
                }
                else
                {
                    LogInfo("List does not have values for Sms password");
                }
                if (listcomcon.Exists(p => p.Name.ToLower() == "provider" && p.Type.ToLower() == "sms"))
                {
                    provider = listcomcon.Find(p => p.Name.ToLower() == "provider" && p.Type.ToLower() == "sms").Value.ToString();
                    URL = URL.Replace("{" + listcomcon.Find(p => p.Name.ToLower() == "provider" && p.Type.ToLower() == "sms").Name.ToString() + "}", provider);
                }
                else
                {
                    LogInfo("List does not have values for Sms provider");
                }

                URLCOMMON = URL;
               // Process_PdfGeneratingEvent();
                ServiceTimer = new System.Timers.Timer();
                ServiceTimer.Elapsed += new System.Timers.ElapsedEventHandler(Process_PdfGeneratingEvent);
                if (listcomcon.Exists(p => p.Name.ToLower() == "serviceinterval"))
                {
                    ServiceInterval = listcomcon.Find(p => p.Name.ToLower() == "serviceinterval").Value.ToString();
                }
                else
                {
                    LogInfo("List does not have values for serviceinterval");
                }
                ServiceTimer.Interval = Convert.ToInt32(ServiceInterval);
               // ServiceTimer.Start();
                genpdf();
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
     //   public void Process_PdfGeneratingEvent()
     private void Process_PdfGeneratingEvent(object sender, System.Timers.ElapsedEventArgs e)
        {

            ServiceTimer.Stop();
            genpdf();
     }
        private void genpdf()
        {
            //Debugger.Break();
            string root = string.Empty;
            string body = string.Empty;
            string toAddress = string.Empty;
            string IsTimerStop = string.Empty;

            SmartReport lstSmartRep = new SmartReport();
            long retCode = -1;
            #region Email
            /////////////////////////-----------start Email Service------------////////////////////
            if (IsEMailActive == "Y")
            {
                List<ApprovedReports> AppRptEmailErrorList = new List<ApprovedReports>();
                List<ApprovedReports> AppRptEmailCompletedList = new List<ApprovedReports>();
                try
                {
                    LogInfo("Mail Service Started");
                    byte[] results = new byte[byte.MaxValue];
                    ApprovedReports[] AppReportEmailList = obj.GetEmailReportNotification(0, Logtime, "SmartReport", Category); //Dheena
                    int mailcount = 0;
                    string Password = string.Empty;
                    string StatusCode="";
                    string StatusDescription = "";
                    //string status = string.Empty;
                    if (AppReportEmailList.Count() > 0)
                    {
                        for (int i = 0; i < AppReportEmailList.Count(); i++)
                        {
                            try
                            {
                                try
                                {
                                    lstSmartRep = obj.GetSmartReportNotification(AppReportEmailList[i].NotificationID);
                                    GetAuthTokenkeyWithUsernamePassword(APIURL, lstSmartRep, out StatusCode, out StatusDescription);
                                   
                                }
                                catch (Exception ex)
                                {
                                    LogInfo("Smart Report pushing Failed");
                                    LogError(ex);

                                }
                                try
                                {
                                    //retCode = obj.UpdateSmartReportNotificationAPI(AppReportEmailList[i].NotificationID, lstSmartRep.pd.PatientVisitID, lstSmartRep.pd.OrgID, StatusCode);
                                    retCode = obj.UpdateSmartReportNotificationAPI(AppReportEmailList[i].NotificationID, lstSmartRep.personDetailsVO.PatientVisitId, Convert.ToInt64(lstSmartRep.externalEntityId));
                                }
                                catch (Exception ex)
                                {
                                     LogInfo("Smart Report Updation Failed");
                                     LogError(ex);

                                }
                             

                            }
                            catch (Exception ex)
                            {
                                LogInfo("Error while Mail Sending:");
                                LogError(ex);

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogInfo("Error while Mail Sending:");
                    LogError(ex);
                }
                 
                Dispose(true);

            }
            else
            {
                LogInfo("Email service is not Active");
            }
            #endregion
        }
     public void GetAuthTokenkeyWithUsernamePassword(string URL, SmartReport lstSmartRep, out string statuscode, out string StatusDescription)
     {
         WebClient client = new WebClient(); 
         
         string AuthTokenkey = string.Empty;
         JavaScriptSerializer jserilizer = new JavaScriptSerializer();
         WebRequest wr = WebRequest.Create(URL);
         var sendData_obj = jserilizer.Serialize(lstSmartRep); 
         wr.Method = "POST";
         wr.Headers["App_Token"] = "3367341SD";
         wr.ContentType = "application/json";
         //string strNewValue = "{0}={1}&{2}={3}";
         //byte[] postBytes = Encoding.UTF8.GetBytes(string.Format(strNewValue, UserKey, UserKeyValue, PasswordKey, PasswordKeyValue));
         wr.ContentLength = Encoding.UTF8.GetByteCount(sendData_obj);
         byte[] postBytes = Encoding.UTF8.GetBytes(sendData_obj);
         LogInfo(sendData_obj);
         var requestStream = wr.GetRequestStream();
         requestStream.Write(postBytes, 0, postBytes.Length);
         requestStream.Close();

         var response = (HttpWebResponse)wr.GetResponse();
         statuscode = response.StatusCode.ToString();
         using (var rdr = new StreamReader(response.GetResponseStream()))
         {
             StatusDescription = rdr.ReadToEnd();
         }
         response.Close();
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
            string LogFile = sFileName + DateTime.Now.ToString("_dd_MM_yyyy") + ".log";
            if (!File.Exists(LogFile))
            {
                FileStream obj = new FileStream(sFileName, FileMode.Create, FileAccess.ReadWrite);
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

