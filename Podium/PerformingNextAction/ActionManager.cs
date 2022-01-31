using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Podium.BusinessEntities;
using System.Data;
using Attune.Podium.Common;
using DataAccessLayer;
using System.Collections;
using System.Collections.Specialized;
using System.Data.SqlClient;
using Attune.Solution.DAL;
using Attune.Cryptography;
using System.Collections.Generic;
using Attune.Podium.Common;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Linq;
using System.IO;

namespace Attune.Podium.PerformingNextAction
{
    public class ActionManager
    {
        ContextDetails globalContextDetails;
        public ActionManager()
        {

        }
        public bool Isreprint { get; set; }
        public ActionManager(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long PerformingMultipleNextStep(List<PageContextkey> objcontextkey)
        {
            long returnCode = -1;
            List<PerformingAction> lstPerformingAction = new List<PerformingAction>();
            try
            {
                returnCode = new ActionManager_DAL(globalContextDetails).GetMultiplePerformingAction(objcontextkey, out lstPerformingAction);
                List<NotificationAudit> Naudits = new List<NotificationAudit>();
                Int32 OrgID = (from pk in objcontextkey
                               select pk.OrgID).FirstOrDefault<Int32>();
                String URL = string.Empty;
                GetSMSConfig(OrgID, out URL);
                MailConfig oMailConfig = new MailConfig();
                GetEMailConfig(OrgID, out oMailConfig);
                if (lstPerformingAction[0].ContextType.Trim() == "PC")
                {
                    List<PerformingAction> lstPerformAction = (from PA in lstPerformingAction
                                                               where PA.ActionType == PerformActionType.Sms && PA.ContextType == ActionContextType.Patient
                                                               select PA).ToList();

                    //if (objcontextkey && lstPerformAction.Count > 0)
                    //{
                    //    foreach (PerformingAction objPerformingAction in lstPerformAction)
                    //    {
                    //        lstPerformingAction.Remove(objPerformingAction);
                    //    }
                    //}
                    List<NotificationAudit> Naudit = new List<NotificationAudit>();

                    NotificationAudit Notify;
                    foreach (PerformingAction item in lstPerformingAction)
                    {
                        string s = StrFormat(item.Description, item.ActionTemplateValue);
                        Notify = new NotificationAudit();
                        switch (item.ActionType)
                        {

                            case PerformActionType.Sms:
                                Communication.SendSMS(URL, s, item.PhoneNo);
                                //Notify.Id = item.InvoiceID;
                                Notify.Message = s;
                                Notify.NotificationTypes = "Sms";
                                Notify.ContactInfo = item.PhoneNo;
                                Notify.CreatedBy = 0;
                                Notify.ReceiverType = "InvoiceTracker";
                                Naudit.Add(Notify);

                                break;

                            case PerformActionType.Email:
                                Communication.SendMail(item.MailTo, item.CCTo, item.BccTo, item.Subject, s, null, oMailConfig);
                                Notify.Id = item.InvoiceID;
                                Notify.Message = s;
                                Notify.NotificationTypes = "EMail";
                                Notify.ContactInfo = item.MailTo;
                                Notify.CreatedBy = 0;
                                Notify.ReceiverType = "InvoiceTracker";
                                Naudit.Add(Notify);

                                break;

                            case PerformActionType.RedirectURL:
                                //objPerformingNext.RedirectURL = item.Description;
                                break;

                            default:
                                break;
                        }


                    }

                    //Patient_BL Patsms = new Patient_BL();
                    //Patsms.insertNotificationAudit(objcontextkey[0].OrgID, 0, objcontextkey[0].RoleID, Naudit);


                }
                if (lstPerformingAction[0].ContextType.Trim() == ActionContextType.ProjectManager)
                {
                    List<PerformingAction> lstPerformAction = (from PA in lstPerformingAction
                                                               where PA.ActionType == PerformActionType.Sms && PA.ContextType == ActionContextType.ProjectManager
                                                               select PA).ToList();
                    List<NotificationAudit> Naudit = new List<NotificationAudit>();

                    NotificationAudit Notify;
                    foreach (PerformingAction item in lstPerformingAction)
                    {
                        string s = StrFormat(item.Description, item.ActionTemplateValue);
                        Notify = new NotificationAudit();
                        switch (item.ActionType)
                        {

                            case PerformActionType.Sms:
                                Communication.SendSMS(URL, s, item.PhoneNo);
                                break;
                            default:
                                break;
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in PerformingMultipleNextStep", ex);
            }
            return returnCode;
        }

        public long PerformingNextStep(PageContextkey objPageContextkey)
        {
            long returnCode = -1;
            List<PerformingAction> lstPerformingAction = new List<PerformingAction>();

            try
            {
                returnCode = new ActionManager_DAL(globalContextDetails).GetPerformingAction(objPageContextkey, out lstPerformingAction);
                Int32 OrgID = objPageContextkey.OrgID;
                String URL = string.Empty;
                GetSMSConfig(OrgID, out URL);
                MailConfig oMailConfig = new MailConfig();
                GetEMailConfig(OrgID, out oMailConfig);
                //       foreach (PerformingAction oPerformingAction in lstPerformingAction)
                //       {
                // if (oPerformingAction.ContextType == "P")
                //  {

                List<PerformingAction> lstPerformActionClientpatient = (from PA in lstPerformingAction
                                                                        where PA.ContextType == ActionContextType.ClientPatient
                                                                        select PA).ToList();
                string[] ListAttributes = new string[100];
                if (lstPerformingAction.Exists(p => p.ContextType == "CP" && p.Attributes != null))
                {
                    ListAttributes = lstPerformingAction.Find(p => p.ContextType == "CP").Attributes.Split(',');
                }
                string EmailAttbts = "Report Email";
                string SmsAttbts = "Report SMS";
                foreach (PerformingAction item in lstPerformActionClientpatient)
                {
                    if ((item.ActionType.ToLower() == "sms" && ListAttributes.Contains(SmsAttbts) && item.ContextType.ToLower() == "cp") || (item.ActionType.ToLower() == "email" && ListAttributes.Contains(EmailAttbts) && item.ContextType.ToLower() == "cp"))
                    {
                        switch (item.ActionType)
                        {
                            case PerformActionType.Sms:
                                Communication.SendSMS(URL, StrFormat(item.Description, item.ActionTemplateValue), item.PhoneNo);
                                break;

                            case PerformActionType.Email:
                                Communication.SendMail(item.MailTo, item.CCTo, item.BccTo, item.Subject, StrFormat(item.Description, item.ActionTemplateValue), null, oMailConfig);
                                break;

                            case PerformActionType.RedirectURL:
                                //objPerformingNext.RedirectURL = item.Description;
                                break;

                            default:
                                break;
                        }
                    }
                }

                List<PerformingAction> lstNewPerformingAction = (from PA in lstPerformingAction
                                                                 where PA.ContextType == ActionContextType.Patient
                                                                 select PA).ToList();

                List<PerformingAction> lstPerformAction = (from PA in lstNewPerformingAction
                                                           where PA.ActionType == PerformActionType.Sms && PA.ContextType == ActionContextType.Patient
                                                           select PA).ToList();
                //if (objPageContextkey.isActionDisabled && lstPerformAction.Count > 0)
                //{
                //    foreach (PerformingAction objPerformingAction in lstPerformAction)
                //    {
                //        lstNewPerformingAction.Remove(objPerformingAction);
                //    }
                //}

                string[] lstPatientDispatchMode = new string[100];
                if (lstPerformingAction.Exists(p => p.ContextType == "P" && p.Attributes != null))
                {
                    lstPatientDispatchMode = lstPerformingAction.Find(p => p.ContextType == "P").Attributes.Split(',');
                }
                string PatientEmail = "Email";
                string PatientSms = "Sms";
                foreach (PerformingAction item in lstNewPerformingAction)
                {
                    if ((item.ActionType.ToLower() == "email" && lstPatientDispatchMode.Contains(PatientEmail) && item.ContextType.ToLower() == "p") || (item.ActionType.ToLower() == "sms" && lstPatientDispatchMode.Contains(PatientSms) && item.ContextType.ToLower() == "p"))
                    {
                        switch (item.ActionType)
                        {
                            case PerformActionType.Sms:
                                Communication.SendSMS(URL, StrFormat(item.Description, item.ActionTemplateValue), item.PhoneNo);
                                break;

                            case PerformActionType.Email:
                                Communication.SendMail(item.MailTo, item.CCTo, item.BccTo, item.Subject, StrFormat(item.Description, item.ActionTemplateValue), null, oMailConfig);
                                break;

                            case PerformActionType.RedirectURL:
                                //objPerformingNext.RedirectURL = item.Description;
                                break;

                            default:
                                break;
                        }
                    }
                }

                //  }
                //   if (oPerformingAction.ContextType == "C")
                //  {
                List<PerformingAction> lstPerformActionClient = (from PA in lstPerformingAction
                                                                 where PA.ActionType == PerformActionType.Sms && PA.ContextType == ActionContextType.Client
                                                                 select PA).ToList();

                if (objPageContextkey.isActionDisabled && lstPerformActionClient.Count > 0)
                {
                    foreach (PerformingAction objPerformingAction in lstPerformActionClient)
                    {
                        lstPerformingAction.Remove(objPerformingAction);
                    }
                }
                foreach (PerformingAction item in lstPerformActionClient)
                {
                    switch (item.ActionType)
                    {
                        case PerformActionType.Sms:
                            Communication.SendSMS(URL, StrFormat(item.Description, item.ActionTemplateValue), item.PhoneNo);
                            break;

                        case PerformActionType.Email:
                            Communication.SendMail(item.MailTo, item.CCTo, item.BccTo, item.Subject, StrFormat(item.Description, item.ActionTemplateValue), null, oMailConfig);
                            break;

                        case PerformActionType.RedirectURL:
                            //objPerformingNext.RedirectURL = item.Description;
                            break;

                        default:
                            break;
                    }
                }

                ////for cp
                //}
                //  if (oPerformingAction.ContextType == ActionContextType.ReferringPhysician)
                //    {
                List<PerformingAction> lstPerformActionForRefPhy = (from PA in lstPerformingAction
                                                                    where PA.ContextType == ActionContextType.ReferringPhysician
                                                                    select PA).ToList();

                foreach (PerformingAction item in lstPerformActionForRefPhy)
                {
                    switch (item.ActionType)
                    {
                        case PerformActionType.Sms:
                            Communication.SendSMS(URL, StrFormat(item.Description, item.ActionTemplateValue), item.PhoneNo);
                            break;

                        case PerformActionType.Email:
                            Communication.SendMail(item.MailTo, item.CCTo, item.BccTo, item.Subject, StrFormat(item.Description, item.ActionTemplateValue), null, oMailConfig);
                            break;

                        case PerformActionType.RedirectURL:
                            //objPerformingNext.RedirectURL = item.Description;
                            break;

                        default:
                            break;
                    }
                }

                //     }
                //   }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in PerformingNextStep", ex);
            }

            return returnCode;
        }

        public long PerformingNextStepNotification(PageContextkey objPageContextkey, string fromdate, string Todate)
        {
            long returnCode = -1;
            List<PerformingAction> lstPerformingAction = new List<PerformingAction>();
            string HCActionType = String.Empty;
            HCActionType = objPageContextkey.ActionType;
            try
            {
                globalContextDetails.AdditionalInfo = objPageContextkey.FinalBillID.ToString();

                returnCode = new ActionManager_DAL(globalContextDetails).GetPerformingAction(objPageContextkey, out lstPerformingAction);
                if (!string.IsNullOrEmpty(objPageContextkey.Description))
                {
                    foreach (PerformingAction item in lstPerformingAction)
                    {
                        item.MailTo = objPageContextkey.Description;
                    }
                }
                Int32 OrgID = objPageContextkey.OrgID;
                long VisitID = objPageContextkey.PatientVisitID;
                String URL = string.Empty;
                String ReportType = string.Empty;
                String InvID = string.Empty;
                GetReportType(VisitID, OrgID, InvID, out ReportType);
                GetSMSConfig(OrgID, out URL);
                MailConfig oMailConfig = new MailConfig();
                GetEMailConfig(OrgID, out oMailConfig);
                List<PerformingAction> PerformingAction = new List<PerformingAction>();
                List<PerformingAction> PerformingActionInvoice = new List<PerformingAction>();
                List<PerformingAction> PerformingActionContextType = new List<PerformingAction>();
                List<PerformingAction> PerformingActionforBill = new List<PerformingAction>();

                // Filter ContextType for Home Collection
                //if (!String.IsNullOrEmpty(HCActionType) && (HCActionType == "hca" || HCActionType == "hcr" || HCActionType == "hccan" || HCActionType == "p"))
                //{
					lstPerformingAction = (from PA in lstPerformingAction
                                    where PA.ContextType == HCActionType.ToUpper()
                                    select PA).ToList();


                PerformingAction = (from PA in lstPerformingAction
                                    where PA.ContextType == ActionContextType.Patient || PA.ContextType == ActionContextType.Client || PA.ContextType == ActionContextType.Invoice
                                    select PA).ToList();
                PerformingActionInvoice = (from PA in lstPerformingAction
                                           where PA.ContextType == "INV"
                                           select PA).ToList();
                PerformingActionContextType = (from PA in lstPerformingAction
                                               where PA.ContextType == ActionContextType.ClientPatient
                                               select PA).ToList();

                PerformingActionforBill = (from PA in lstPerformingAction
                                           where PA.AdditionalContext.ToLower() == "bill"
                                           select PA).ToList();

                //Xml Creation for VisitID and AccessionNumber:
                string xmlContent = string.Empty;
                string billnum = string.Empty;
                string xmlContentforBillReceipt = string.Empty;
                using (var sw = new StringWriter())
                {
                    using (var xw = XmlWriter.Create(sw))
                    {
                        xw.WriteStartDocument();
                        xw.WriteStartElement("ContextInfo");
                        if (PerformingActionInvoice.Count > 0)
                        {
                            xw.WriteStartElement("InvoiceID");
                            xw.WriteString(objPageContextkey.PatientID.ToString());//ClientID asPatientID 
                            xw.WriteEndElement();
                            xw.WriteStartElement("ClientID");
                            xw.WriteString(objPageContextkey.PatientID.ToString());//ClientID asPatientID 
                            xw.WriteEndElement();
                            xw.WriteStartElement("FromDate");
                            if (!string.IsNullOrEmpty(fromdate))
                            {
                                xw.WriteString(fromdate);
                            }
                            else
                            {
                                xw.WriteString("0");
                            }
                            xw.WriteEndElement();
                            xw.WriteStartElement("ToDate");
                            if (!string.IsNullOrEmpty(Todate))
                            {
                                xw.WriteString(Todate);
                            }
                            else
                            {
                                xw.WriteString("0");
                            }
                            xw.WriteEndElement();
                            xw.WriteEndElement();
                            xw.WriteEndDocument();
                            xw.Close();
                        }
                        else
                        {
                            if (lstPerformingAction.Count > 0)
                            {
                                xw.WriteStartElement("VisitID");
                                xw.WriteString(objPageContextkey.PatientVisitID.ToString());
                                xw.WriteEndElement();
                                xw.WriteStartElement("AccessionNumber");
                                if (!string.IsNullOrEmpty(lstPerformingAction[0].AccessionNumber))
                                {
                                    xw.WriteString(lstPerformingAction[0].AccessionNumber.ToString());
                                }
                                else
                                {
                                    xw.WriteString("0");
                                }
                                xw.WriteEndElement();
                                xw.WriteEndElement();
                                xw.WriteEndDocument();
                                xw.Close();
                            }
                            if (PerformingActionforBill.Count > 0)
                            {
                                using (var swbill = new StringWriter())
                                {
                                    using (var xwbill = XmlWriter.Create(swbill))
                                    {
                                        xwbill.WriteStartDocument();
                                        xwbill.WriteStartElement("ContextInfo");
                                        xwbill.WriteStartElement("VisitID");
                                        xwbill.WriteString(objPageContextkey.PatientVisitID.ToString());
                                        xwbill.WriteEndElement();
                                        xwbill.WriteStartElement("FinallBillID");
                                        xwbill.WriteString(objPageContextkey.FinalBillID.ToString());
                                        xwbill.WriteEndElement();
                                        xwbill.WriteStartElement("BillNumber");

                                        if (!string.IsNullOrEmpty(objPageContextkey.BillNumber))
                                        {
                                            billnum = objPageContextkey.BillNumber.ToString();
                                        }
                                        xwbill.WriteString(billnum);
                                        xwbill.WriteEndElement();
                                        xwbill.WriteEndElement();
                                        xwbill.WriteEndDocument();
                                        xwbill.Close();
                                    }
                                    xmlContentforBillReceipt = swbill.ToString();
                                }
                            }
                        }
                    }
                    xmlContent = sw.ToString();
                }
                System.Data.DataTable dt = new DataTable();
                DataColumn dbCol1 = new DataColumn("ActionType");
                DataColumn dbCol2 = new DataColumn("Value");
                DataColumn dbCol3 = new DataColumn("AdditionalContext");
                DataColumn dbCol4 = new DataColumn("Category");
                DataColumn dbCol5 = new DataColumn("version");
                DataColumn dbCol6 = new DataColumn("Status");
                DataColumn dbCol7 = new DataColumn("OrgID");
                DataColumn dbCol8 = new DataColumn("OrgAddressID");
                DataColumn dbCol9 = new DataColumn("CreatedAt");
                DataColumn dbCol10 = new DataColumn("CreatedBy");
                DataColumn dbCol11 = new DataColumn("Template");
                DataColumn dbCol12 = new DataColumn("ContextType");
                DataColumn dbCol13 = new DataColumn("IsAttachment");
                DataColumn dbCol14 = new DataColumn("Subject");
                DataColumn dbCol15 = new DataColumn("AttachmentName");
                DataColumn dbCol16 = new DataColumn("IsClientBlinding");
                DataColumn dbCol17 = new DataColumn("BccTo");
                DataColumn dbCol18 = new DataColumn("CCTo");
                //Added By QBITZ Prakash.A
                DataColumn dbCol19 = new DataColumn("ReportType");
                //Added By QBITZ Prakash.K
                DataColumn dbCol20 = new DataColumn("IsManualReport");
                DataColumn dbCol21 = new DataColumn("IsReprinting");
                DataColumn dbCol22 = new DataColumn("ReportLanguage");
                DataColumn dbCol23 = new DataColumn("NoofCopies");

                //add columns
                dt.Columns.Add(dbCol1);
                dt.Columns.Add(dbCol2);
                dt.Columns.Add(dbCol3);
                dt.Columns.Add(dbCol4);
                dt.Columns.Add(dbCol5);
                dt.Columns.Add(dbCol6);
                dt.Columns.Add(dbCol7);
                dt.Columns.Add(dbCol8);
                dt.Columns.Add(dbCol9);
                dt.Columns.Add(dbCol10);
                dt.Columns.Add(dbCol11);
                dt.Columns.Add(dbCol12);
                dt.Columns.Add(dbCol13);
                dt.Columns.Add(dbCol14);
                dt.Columns.Add(dbCol15);
                dt.Columns.Add(dbCol16);
                dt.Columns.Add(dbCol17);
                dt.Columns.Add(dbCol18);
                //Added By QBITZ Prakash.A
                dt.Columns.Add(dbCol19);
                //Added By QBITZ Prakash.K
                dt.Columns.Add(dbCol20);
                dt.Columns.Add(dbCol21);
                dt.Columns.Add(dbCol22);
                dt.Columns.Add(dbCol23);
                DataRow dr;
                int pdfcount = 0;
                int printcount = 0;
                int roundbprintcount = 0;
                int isstatprintcount = 0;
                int IsStatPdfCount = 0;
                int billprintcount = 0;
                int invoiceprintcount = 0;
                int RoundBCount = 0;
                string[] ListAttributes = new string[100];
                string[] lstPatientDispatchMode = new string[100];

                if (lstPerformingAction.Exists(p => p.ContextType.ToLower() == "cp" && p.Attributes != null))
                {
                    ListAttributes = lstPerformingAction.Find(p => p.ContextType.ToLower() == "cp").Attributes.Split(',');
                }
                if (lstPerformingAction.Exists(p => p.ContextType.ToLower() == "p" && p.Attributes != null))
                {
                    lstPatientDispatchMode = lstPerformingAction.Find(p => p.ContextType.ToLower() == "p").Attributes.Split(',');
                }
                if (lstPerformingAction.Exists(p => p.ContextType.ToLower() == "inv" && p.Attributes != null))
                {
                    ListAttributes = lstPerformingAction.Find(p => p.ContextType.ToLower() == "inv").Attributes.Split(',');
                }
                string Client_Notify_Email = "REMAIL";
                string Client_Notify_SMS = "RSMS";
                string Client_Report_Email = "REPEMAIL";
                string Client_Report_SMS = "REPSMS";

                string Patient_Notify_Email = "REMAIL";
                string Patient_Notify_SMS = "RSMS";
                string Patient_Report_Email = "REPEMAIL";
                string Patient_Report_SMS = "REPSMS";

                string Client_Invoice_Email = "IEMAIL";
                string Client_Invoice_SMS = "ISMS";

                string Client_Bill_Email = "TMPR";

                foreach (PerformingAction item in lstPerformingAction)
                {
                    if ((item.ContextType.ToLower() == "cp" && item.AdditionalContext.ToLower() == "notify" && item.ActionType.ToLower() == "sms" && ListAttributes.Contains(Client_Notify_SMS)) ||
                        (item.ContextType.ToLower() == "cp" && item.AdditionalContext.ToLower() == "notify" && item.ActionType.ToLower() == "apisms" && ListAttributes.Contains(Client_Notify_SMS)) ||
                        (item.ContextType.ToLower() == "cp" && item.AdditionalContext.ToLower() == "notify" && item.ActionType.ToLower() == "email" && ListAttributes.Contains(Client_Notify_Email)) ||
                        (item.ContextType.ToLower() == "cp" && item.AdditionalContext.ToLower() == "report" && item.ActionType.ToLower() == "sms" && ListAttributes.Contains(Client_Report_SMS) && (objPageContextkey.isActionDisabled != true)) ||
                        (item.ContextType.ToLower() == "cp" && item.AdditionalContext.ToLower() == "report" && item.ActionType.ToLower() == "apisms" && ListAttributes.Contains(Client_Report_SMS) && (objPageContextkey.isActionDisabled != true)) ||
                        (item.ContextType.ToLower() == "cp" && item.AdditionalContext.ToLower() == "report" && item.ActionType.ToLower() == "email" && ListAttributes.Contains(Client_Report_Email) && (objPageContextkey.isActionDisabled != true)) ||
                        (item.ContextType.ToLower() == "cp" && item.AdditionalContext.ToLower() == "bill" && item.ActionType.ToLower() == "email" && ListAttributes.Contains(Client_Bill_Email)) ||
                        (item.ContextType.ToLower() == "cp" && item.AdditionalContext.ToLower() == "report" && item.ActionType.ToLower() == "ftp") ||
                        (item.ContextType.ToLower() == "p" && item.AdditionalContext.ToLower() == "notify" && item.ActionType.ToLower() == "sms" && lstPatientDispatchMode.Contains(Patient_Notify_SMS)) ||
                        (item.ContextType.ToLower() == "p" && item.AdditionalContext.ToLower() == "notify" && item.ActionType.ToLower() == "apisms" && lstPatientDispatchMode.Contains(Patient_Notify_SMS)) ||
                        (item.ContextType.ToLower() == "p" && item.AdditionalContext.ToLower() == "notify" && item.ActionType.ToLower() == "email" && lstPatientDispatchMode.Contains(Patient_Notify_Email)) ||
                        (item.ContextType.ToLower() == "p" && item.AdditionalContext.ToLower() == "report" && item.ActionType.ToLower() == "sms" && lstPatientDispatchMode.Contains(Patient_Report_SMS) && (objPageContextkey.isActionDisabled != true)) ||
                        (item.ContextType.ToLower() == "p" && item.AdditionalContext.ToLower() == "report" && item.ActionType.ToLower() == "apisms" && lstPatientDispatchMode.Contains(Patient_Report_SMS) && (objPageContextkey.isActionDisabled != true)) ||
                        (item.ContextType.ToLower() == "p" && item.AdditionalContext.ToLower() == "report" && item.ActionType.ToLower() == "email" && lstPatientDispatchMode.Contains(Patient_Report_Email) && (objPageContextkey.isActionDisabled != true)) ||
					    (item.ContextType.ToLower() == "p" && item.AdditionalContext.ToLower() == "bill" && item.ActionType.ToLower() == "email" ) ||
                        (item.ContextType.ToLower() == "hcb" && item.AdditionalContext.ToLower() == "notify" && item.ActionType.ToLower() == "sms") ||
                        (item.ContextType.ToLower() == HCActionType && item.AdditionalContext.ToLower() == "notify" && item.ActionType.ToLower() == "sms") ||
                        (item.ContextType.ToLower() == HCActionType && item.AdditionalContext.ToLower() == "notify" && item.ActionType.ToLower() == "sms") ||
                        (item.ContextType.ToLower() == HCActionType && item.AdditionalContext.ToLower() == "notify" && item.ActionType.ToLower() == "sms") ||

                        (item.ContextType.ToLower() == "inv" && item.AdditionalContext.ToLower() == "invoice" && item.ActionType.ToLower() == "sms" && ListAttributes.Contains(Client_Invoice_SMS)) ||
                        (item.ContextType.ToLower() == "inv" && item.AdditionalContext.ToLower() == "invoice" && item.ActionType.ToLower() == "apisms" && ListAttributes.Contains(Client_Invoice_SMS)) ||
                        (item.ContextType.ToLower() == "inv" && item.AdditionalContext.ToLower() == "invoice" && item.ActionType.ToLower() == "email" && ListAttributes.Contains(Client_Invoice_Email)) ||
                        (item.ContextType.ToLower() == "can" && item.ActionType.ToLower() == "email") ||
                        (item.ContextType.ToLower() == "rjn" && item.ActionType.ToLower() == "email") ||
                        (item.ContextType.ToLower() == "rcn" && item.ActionType.ToLower() == "email") ||
                        (item.ContextType.ToLower() == "rfn" && item.ActionType.ToLower() == "email") ||
                        (item.ContextType.ToLower() != "cp" && item.ContextType.ToLower() != "p" && item.ContextType.ToLower() != "inv") ||
                        (item.ActionType.ToLower() == "pdf") ||
                        (item.ActionType.ToLower() == "confidpdf") ||
                        (item.ActionType.ToLower() == "confidroundbpdf") ||
                        (item.ActionType.ToLower() == "clientblindchildpdf") ||
                        (item.ActionType.ToLower() == "clientblindchildroundbpdf") ||
                         (item.ActionType.ToLower() == "clientblindparentpdf") ||
                        (item.ActionType.ToLower() == "clientblindparentroundbpdf") ||
                        (item.ActionType.ToLower() == "print" && printcount == 0) ||
                        (item.ActionType.ToLower() == "isstatprint" && isstatprintcount == 0) ||
                        (item.ActionType.ToLower() == "roundbprint" && roundbprintcount == 0) ||
                        (item.ActionType.ToLower() == "billprint" && billprintcount == 0) ||
                        (item.ActionType.ToLower() == "invoiceprint" && invoiceprintcount == 0) ||
                        (item.ActionType.ToLower() == "isstatpdf" && IsStatPdfCount == 0) ||
                        (item.ActionType.ToLower() == "roundbpdf" && RoundBCount == 0) || (item.ActionType.ToLower() == "wbill")
						 || (item.ActionType.ToLower() == "outbound") || (item.ActionType.ToLower() == "lisordered")
						  ||(item.ActionType.ToLower() == "smartreport")
						  || (item.ContextType.ToLower() == "p" && item.ActionType.ToLower() == "whatsapp")
						  || (item.ContextType.ToLower() == "p" && item.ActionType.ToLower() == "whatsapp" && item.Category.ToLower()=="bill")
                        || (item.ContextType.ToLower() == "rjn" && item.ActionType.ToLower() == "whatsapp")
                        || (item.ContextType.ToLower() == "recollect" && item.ActionType.ToLower() == "whatsapp")
                        || (item.ContextType.ToLower() == "rcn" && item.ActionType.ToLower() == "whatsapp")
                        || (item.ContextType.ToLower() == "cv" && item.ActionType.ToLower() == "whatsapp")
                       || (item.ContextType.ToLower() == HCActionType  && item.ActionType.ToLower() == "whatsapp") ||
                        (item.ContextType.ToLower() == HCActionType.ToLower()  && item.ActionType.ToLower() == "whatsapp") ||
                        (item.ContextType.ToLower() == HCActionType.ToLower() && item.ActionType.ToLower() == "whatsapp") 
                        || (item.ContextType.ToLower() == "p" &&  item.ActionType.ToLower() == "msgsms" )
                        || (item.ContextType.ToLower() == "hcb" && item.ActionType.ToLower() == "msgsms")
                        || (item.ContextType.ToLower() == "hca" && item.ActionType.ToLower() == "msgsms")
                        || (item.ContextType.ToLower() == "hcr" && item.ActionType.ToLower() == "msgsms")
                        || (item.ContextType.ToLower() == "hccan" && item.ActionType.ToLower() == "msgsms")
                        )
                    {
                        dr = dt.NewRow();
                        dr["ActionType"] = item.ActionType;
                        dr["ReportType"] = ReportType;
                        if (item.ActionType == "Sms" || item.ActionType == "APISMS" || item.ActionType.ToLower() == "whatsapp" || item.ActionType.ToLower() == "msgsms")
                        {
                            dr["Value"] = item.PhoneNo;
                        }
                        if (item.ActionType == "Email")
                        {
                            dr["Value"] = item.MailTo;
                            dr["BccTo"] = item.BccTo;//surya new chanage for critical Alert (6october2017)
                            dr["CCTo"] = item.CCTo;
                        }
                        if (item.AdditionalContext.ToLower() == "bill")
                        {
                            dr["AdditionalContext"] = xmlContentforBillReceipt;
                        }
                        else
                        {
                            dr["AdditionalContext"] = xmlContent;
                        }
                        if (item.ContextType == "INV")
                        {
                            dr["Category"] = "Invoice";
                        }
                        else
                        {
                            if (item.AdditionalContext.ToLower() == "bill")
                            {
                                dr["Category"] = "Bill";
                            }
                            else if (item.AdditionalContext.ToLower() == "report")
                            {
                                dr["Category"] = "Report";
                            }
                            else if (item.AdditionalContext.ToLower() == "notify")
                            {
                                dr["Category"] = "Notify";
                            }
                            else if (item.AdditionalContext.ToLower() == "integration")
                            {
                                dr["Category"] = "Integration";
                            }
                            else if (item.ActionType.ToLower() == "whatsapp")
                            {
                                dr["Category"] = "whatsapp"; 
                            }
                            else if (item.ActionType.ToLower() == "msgsms")
                            {
                                dr["Category"] = item.ActionType;
                                dr["version"] = item.ClientID;
                                dr["Status"] = item.PatientVisitID;
                            }
                        }
                        dr["version"] =item.ClientID;
                        if ((item.PatientDueStatus.ToLower() == "open") && (item.ContextType.ToLower() == "p" || item.ContextType.ToLower() == "cp"))
                        //if (item.PatientDueStatus.ToLower() == "open" && item.ContextType.ToLower() == "p" && PerformingActionContextType.Count < 1)
                        {
                            dr["Status"] = "Due";
                        }
                        else if (objPageContextkey.Reason == "IsSensitive")
                        {
                            dr["Status"] = "IsSensitive";
                        }
                        else
                        {
                            dr["Status"] = "";
                        }
                        //Added By QBITZ Prakash.K
                        dr["IsManualReport"] = Convert.ToBoolean(false);

                        dr["OrgID"] = Convert.ToInt32(objPageContextkey.OrgID);
                        dr["OrgAddressID"] = Convert.ToInt32(objPageContextkey.ID);
                        dr["CreatedAt"] = DateTime.MinValue;
                        dr["CreatedBy"] = objPageContextkey.RoleID;

                        if ((item.ActionType.ToLower() == "sms" || item.ActionType.ToLower() == "apisms" ) && item.AdditionalContext.ToLower() == "report")
                        {
                            dr["Template"] = StrFormat(item.Description, item.ActionTemplateValue) + item.InvsNValues;
                        }
                        else if (item.ActionType.ToLower() == "msgsms")
                        {
                            dr["Template"] = string.Empty;
                        }
                        else
                        {
                            dr["Template"] = StrFormat(item.Description, item.ActionTemplateValue);
                        }
                        dr["ContextType"] = item.ContextType;
                        dr["IsAttachment"] = item.IsAttachment;
                        //dr["Subject"] = StrFormat(item.Subject, item.ActionTemplateValue);
                        if (item.ActionType.ToLower() == "msgsms")
                        {
                            dr["Subject"] = string.Empty;
                            dr["AttachmentName"] = string.Empty;
                        }
                        else
                        {
                            dr["AttachmentName"] = StrFormat(item.AttachmentName == null ? string.Empty : item.AttachmentName, item.ActionTemplateValue);
                        dr["Subject"] = StrFormat(item.Subject == null ? string.Empty : item.Subject, item.ActionTemplateValue);
                        }
					    if (item.ActionType.ToLower() == "whatsapp")
                        {
                            dr["Subject"] = item.AdditionalContext;
                        }

                        //dr["AttachmentName"] = StrFormat(item.AttachmentName, item.ActionTemplateValue);
                        if (item.ActionType.ToLower() == "email")
                        {
                            if (item.IsClientblinding == "")
                            {
                                int Blindcount = (from grp in lstPerformingAction
                                                  where grp.ActionType.ToLower() == "clientblindchildpdf" || grp.ActionType.ToLower() == "clientblindchildroundbpdf"
                                                  select grp.ActionType).Distinct().Count();
                                if (Blindcount > 0)
                                {
                                    dr["IsClientBlinding"] = "BC";
                                }
                            }
                            else
                            {
                                dr["IsClientBlinding"] = item.IsClientblinding;
                            }
                        }
                        dr["IsReprinting"] = Isreprint;
                        dr["ReportLanguage"]=item.ReportLanguage;
                        dr["NoofCopies"] = item.NoofCopies;
                        if (item.ActionType.ToLower() == "msgsms")
                        {                         
                            dr["version"] = item.ClientID;
                            dr["Status"] = item.PatientVisitID;
                        }
                        //dr["Subject"] = item.Subject;
                        if (item.ActionType.ToLower()=="print")
                        {
                            dr["IsClientBlinding"] = item.Reason;
                        
                        }
                        if ((item.ActionType.ToLower() == "print" && printcount == 0))
                        {
                            printcount++;
                        }
                        if ((item.ActionType.ToLower() == "roundbprint" && roundbprintcount == 0))
                        {
                            roundbprintcount++;
                        }
                        if ((item.ActionType.ToLower() == "isstatprint" && isstatprintcount == 0))
                        {
                            isstatprintcount++;
                        }
                        if ((item.ActionType.ToLower() == "billprint" && billprintcount == 0))
                        {
                            billprintcount++;
                        }
                        if ((item.ActionType.ToLower() == "invoiceprint" && invoiceprintcount == 0))
                        {
                            invoiceprintcount++;
                        }
                        if ((item.ActionType.ToLower() == "isstatpdf" && IsStatPdfCount == 0))
                        {
                            IsStatPdfCount++;
                        }
                        if ((item.ActionType.ToLower() == "roundbpdf" && RoundBCount == 0))
                        {
                            RoundBCount++;
                        }
                        int cnt = 0;

                        if (item.ActionType.ToLower() == "pdf" || item.ActionType.ToLower() == "roundbpdf" || item.ActionType.ToLower() == "wbill" || item.ActionType.ToLower() == "outbound" || item.ActionType.ToLower() == "lisordered"
                            || item.ActionType.ToLower() == "confidpdf" || item.ActionType.ToLower() == "confidroundbpdf"
                            || item.ActionType.ToLower() == "clientblindchildpdf" || item.ActionType.ToLower() == "clientblindchildroundbpdf"
                            || item.ActionType.ToLower() == "clientblindparentpdf" || item.ActionType.ToLower() == "clientblindparentroundbpdf")
                        {
                            var a = (from m in dt.AsEnumerable()
                                     where m.Field<string>("Category").ToLower() == item.AdditionalContext.ToLower() &&
                                     m.Field<string>("ActionType").ToLower() == item.ActionType.ToLower() &&
                                     m.Field<string>("ReportLanguage").ToLower()==item.ReportLanguage.ToLower()
                                     select m).ToList();//m.Field<string>("IdentityId") == Convert.ToString(IdentityId) &&
                            cnt = a.Count();
                            if (cnt < 1)
                            {
                                dt.Rows.Add(dr);
                            }
                        }
                        else if (item.ActionType.ToLower() == "msgsms" && item.Password == "")
                        {
                            dt.Rows.Add(dr);
                        }
                        else if (item.ActionType.ToLower() != "msgsms")
						{
                            dt.Rows.Add(dr);
                        }
                if (objPageContextkey.ActionType == "SAVEROUNDDB")
                {
                    for (int i = dt.Rows.Count - 1; i >= 0; i--)
                    {
                        DataRow datarow = dt.Rows[i];
                        if (datarow["ActionType"] != null && datarow["ActionType"].ToString() == "ISSTATPRINT")
                            datarow.Delete();                     
                    }
                    for (int i = dt.Rows.Count - 1; i >= 0; i--)
                    {
                        DataRow datarow = dt.Rows[i];                        
                        if (datarow["ActionType"] != null && datarow["ActionType"].ToString() == "ROUNDBPRINT")
                            datarow["ActionType"] = "SAVEROUNDDB";
                            }
                    }
                }
				}
                Report_DAL objReportdal = new Report_DAL(globalContextDetails);
                returnCode = objReportdal.SaveActionDetails(dt);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in PerformingNextStep", ex);
            }
            return returnCode;
        }

        string StrFormat(string pTemplate, NameValueCollection pTemplateResult)
        {

            foreach (string key in pTemplateResult.Keys)
            {
                if (pTemplate.Contains("{" + key + "}"))
                {
                    if (key == "Password")
                    {
                        string DecryptedPassword = string.Empty;
                        CCryptography objDecryptor = new CCryptFactory().GetDecryptor();
                        objDecryptor.Crypt(pTemplateResult[key], out DecryptedPassword);
                        pTemplate = pTemplate.Replace("{" + key + "}", DecryptedPassword);
                    }
                    else
                    {
                        pTemplate = pTemplate.Replace("{" + key + "}", pTemplateResult[key].ToString());
                    }
                }
            }
            return pTemplate;

        }

        public void GetSMSConfig(Int32 OrgID, out String URL)
        {
            URL = string.Empty;
            try
            {
                Master_DAL oMasterDAL = new Master_DAL(globalContextDetails);
                List<CommunicationConfig> lstCommunicationConfig = new List<CommunicationConfig>();
                oMasterDAL.GetCommunicationConfig(OrgID, CommunicationType.SMS, out lstCommunicationConfig);
                string strURL = "URL" + OrgID.ToString();
                if (lstCommunicationConfig != null && lstCommunicationConfig.Count > 0)
                {
                    URL = (from c in lstCommunicationConfig
                           where c.Name == strURL
                           select c.Value).FirstOrDefault().ToString();
                    if (!String.IsNullOrEmpty(URL))
                    {
                        foreach (CommunicationConfig oCommunicationConfig in lstCommunicationConfig)
                        {
                            if (oCommunicationConfig.Name.ToLower() == "password")
                            {
                                string DecryptedPassword = string.Empty;
                                CCryptography objDecryptor = new CCryptFactory().GetDecryptor();
                                objDecryptor.Crypt(oCommunicationConfig.Value, out DecryptedPassword);
                                URL = URL.Replace("{" + oCommunicationConfig.Name + "}", DecryptedPassword);
                            }
                            else
                            {
                                URL = URL.Replace("{" + oCommunicationConfig.Name + "}", oCommunicationConfig.Value);
                            }
                        }
                    }
                    else
                        URL = string.Empty;
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting sms config: ", ex);
            }
        }

        public void GetEMailConfig(Int32 OrgID, out MailConfig oMailConfig)
        {
            oMailConfig = null;
            try
            {
                Master_DAL oMasterDAL = new Master_DAL(globalContextDetails);
                List<CommunicationConfig> lstCommunicationConfig = new List<CommunicationConfig>();
                oMasterDAL.GetCommunicationConfig(OrgID, CommunicationType.EMail, out lstCommunicationConfig);
                if (lstCommunicationConfig != null && lstCommunicationConfig.Count > 0)
                {
                    oMailConfig = new MailConfig();
                    foreach (CommunicationConfig oCommunicationConfig in lstCommunicationConfig)
                    {
                        if (oCommunicationConfig.Name.ToLower() == "host")
                        {
                            oMailConfig.Host = oCommunicationConfig.Value;
                        }
                        else if (oCommunicationConfig.Name.ToLower() == "username")
                        {
                            oMailConfig.UserName = oCommunicationConfig.Value;
                        }
                        else if (oCommunicationConfig.Name.ToLower() == "password")
                        {
                            string DecryptedPassword = string.Empty;
                            CCryptography objDecryptor = new CCryptFactory().GetDecryptor();
                            objDecryptor.Crypt(oCommunicationConfig.Value, out DecryptedPassword);
                            oMailConfig.Password = DecryptedPassword;
                        }
                        else if (oCommunicationConfig.Name.ToLower() == "port")
                        {
                            if (!String.IsNullOrEmpty(oCommunicationConfig.Value))
                            {
                                int port = 0;
                                Int32.TryParse(oCommunicationConfig.Value, out port);
                                oMailConfig.Port = port;
                            }
                        }
                        else if (oCommunicationConfig.Name.ToLower() == "fromaddress")
                        {
                            oMailConfig.FromAddress = oCommunicationConfig.Value;
                        }
                        else if (oCommunicationConfig.Name.ToLower() == "fromdisplaytext")
                        {
                            oMailConfig.FromDisplayText = oCommunicationConfig.Value;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting email config: ", ex);
            }
        }

        public long PerformingNextStepWithAttachment(PageContextkey objPageContextkey, List<MailAttachment> lstMailAttachment, string txtPatientMobileNo, string txtPatientMail)
        {
            long returnCode = -1;
            List<PerformingAction> lstPerformingAction = new List<PerformingAction>();

            try
            {
                returnCode = new ActionManager_DAL(globalContextDetails).GetPerformingAction(objPageContextkey, out lstPerformingAction);
                Int32 OrgID = objPageContextkey.OrgID;
                String URL = string.Empty;
                GetSMSConfig(OrgID, out URL);
                MailConfig oMailConfig = new MailConfig();
                GetEMailConfig(OrgID, out oMailConfig);

                if (lstPerformingAction.Count > 0)
                {
                    ////if (oPerformingAction.ContextType == "DISP")
                    ////{
                    List<PerformingAction> lstPerformAction = (from PA in lstPerformingAction
                                                               where PA.ContextType == ActionContextType.Despatch
                                                               select PA).ToList();

                    if (objPageContextkey.isActionDisabled && lstPerformAction.Count > 0)
                    {
                        foreach (PerformingAction objPerformingAction in lstPerformAction)
                        {
                            lstPerformingAction.Remove(objPerformingAction);
                        }
                    }

                    foreach (PerformingAction item in lstPerformingAction)
                    {
                        switch (item.ActionType)
                        {
                            case PerformActionType.Sms:
                                Communication.SendSMS(URL, StrFormat(item.Description, item.ActionTemplateValue), txtPatientMobileNo);
                                break;

                            case PerformActionType.Email:
                                Communication.SendMail(txtPatientMail, txtPatientMail, item.CCTo, item.BccTo, item.Subject, StrFormat(item.Description, item.ActionTemplateValue), item.OrgName, lstMailAttachment, oMailConfig);

                                break;

                            case PerformActionType.RedirectURL:
                                //objPerformingNext.RedirectURL = item.Description;
                                break;

                            default:
                                break;
                        }
                    }

                    //}


                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in PerformingNextStepWithAttachment", ex);
            }

            return returnCode;
        }

        //Added By QBITZ Prakash.K

        public long PerformingNextStepNotificationManual(PageContextkey objPageContextkey, string fromdate, string Todate, string strReportType, string strAccessionNumber)
        {
            long returnCode = -1;
            List<PerformingAction> lstPerformingAction = new List<PerformingAction>();
            List<PerformingAction> lstPerformingActionManual = new List<PerformingAction>();
            try
            {
                globalContextDetails.AdditionalInfo = objPageContextkey.FinalBillID.ToString();

                returnCode = new ActionManager_DAL(globalContextDetails).GetPerformingAction(objPageContextkey, out lstPerformingActionManual);
                if (strReportType == "Duplicate" || strReportType == "Final" || strReportType == "Amended" || strReportType == "Cumulative")
                {
                    lstPerformingAction = lstPerformingActionManual;

                }
                else
                {
                    lstPerformingActionManual.ForEach(x => x.AccessionNumber = strAccessionNumber);
                    lstPerformingAction = new List<PerformingAction>();
                    lstPerformingAction = lstPerformingActionManual;
                }

                //        lstPerformingAction = lstPerformingActionManual.Where(S => S.AccessionNumber != null)
                //.Select(S => { S.AccessionNumber = strAccessionNumber; return S; }).ToList();

                if (!string.IsNullOrEmpty(objPageContextkey.Description))
                {
                    foreach (PerformingAction item in lstPerformingAction)
                    {
                        item.MailTo = objPageContextkey.Description;
                    }
                }
                Int32 OrgID = objPageContextkey.OrgID;
                String URL = string.Empty;
                GetSMSConfig(OrgID, out URL);
                MailConfig oMailConfig = new MailConfig();
                GetEMailConfig(OrgID, out oMailConfig);
                List<PerformingAction> PerformingAction = new List<PerformingAction>();
                List<PerformingAction> PerformingActionInvoice = new List<PerformingAction>();
                List<PerformingAction> PerformingActionContextType = new List<PerformingAction>();
                List<PerformingAction> PerformingActionforBill = new List<PerformingAction>();

                PerformingAction = (from PA in lstPerformingAction
                                    where PA.ContextType == ActionContextType.Patient || PA.ContextType == ActionContextType.Client || PA.ContextType == ActionContextType.Invoice
                                    select PA).ToList();
                PerformingActionInvoice = (from PA in lstPerformingAction
                                           where PA.ContextType == "INV"
                                           select PA).ToList();
                PerformingActionContextType = (from PA in lstPerformingAction
                                               where PA.ContextType == ActionContextType.ClientPatient
                                               select PA).ToList();

                PerformingActionforBill = (from PA in lstPerformingAction
                                           where PA.AdditionalContext.ToLower() == "bill"
                                           select PA).ToList();

                //Xml Creation for VisitID and AccessionNumber:
                string xmlContent = string.Empty;
                string billnum = string.Empty;
                string xmlContentforBillReceipt = string.Empty;
                using (var sw = new StringWriter())
                {
                    using (var xw = XmlWriter.Create(sw))
                    {
                        xw.WriteStartDocument();
                        xw.WriteStartElement("ContextInfo");
                        if (PerformingActionInvoice.Count > 0)
                        {
                            xw.WriteStartElement("InvoiceID");
                            xw.WriteString(objPageContextkey.PatientID.ToString());//ClientID asPatientID 
                            xw.WriteEndElement();
                            xw.WriteStartElement("ClientID");
                            xw.WriteString(objPageContextkey.PatientID.ToString());//ClientID asPatientID 
                            xw.WriteEndElement();
                            xw.WriteStartElement("FromDate");
                            if (!string.IsNullOrEmpty(fromdate))
                            {
                                xw.WriteString(fromdate);
                            }
                            else
                            {
                                xw.WriteString("0");
                            }
                            xw.WriteEndElement();
                            xw.WriteStartElement("ToDate");
                            if (!string.IsNullOrEmpty(Todate))
                            {
                                xw.WriteString(Todate);
                            }
                            else
                            {
                                xw.WriteString("0");
                            }
                            xw.WriteEndElement();
                            xw.WriteEndElement();
                            xw.WriteEndDocument();
                            xw.Close();
                        }
                        else
                        {
                            if (lstPerformingAction.Count > 0)
                            {
                                xw.WriteStartElement("VisitID");
                                xw.WriteString(objPageContextkey.PatientVisitID.ToString());
                                xw.WriteEndElement();
                                xw.WriteStartElement("AccessionNumber");
                                if (!string.IsNullOrEmpty(lstPerformingAction[0].AccessionNumber))
                                {
                                    xw.WriteString(lstPerformingAction[0].AccessionNumber.ToString());
                                }
                                else
                                {
                                    xw.WriteString("0");
                                }
                                xw.WriteEndElement();
                                xw.WriteEndElement();
                                xw.WriteEndDocument();
                                xw.Close();
                            }
                            if (PerformingActionforBill.Count > 0)
                            {
                                using (var swbill = new StringWriter())
                                {
                                    using (var xwbill = XmlWriter.Create(swbill))
                                    {
                                        xwbill.WriteStartDocument();
                                        xwbill.WriteStartElement("ContextInfo");
                                        xwbill.WriteStartElement("VisitID");
                                        xwbill.WriteString(objPageContextkey.PatientVisitID.ToString());
                                        xwbill.WriteEndElement();
                                        xwbill.WriteStartElement("FinallBillID");
                                        xwbill.WriteString(objPageContextkey.FinalBillID.ToString());
                                        xwbill.WriteEndElement();
                                        xwbill.WriteStartElement("BillNumber");

                                        if (!string.IsNullOrEmpty(objPageContextkey.BillNumber))
                                        {
                                            billnum = objPageContextkey.BillNumber.ToString();
                                        }
                                        xwbill.WriteString(billnum);
                                        xwbill.WriteEndElement();
                                        xwbill.WriteEndElement();
                                        xwbill.WriteEndDocument();
                                        xwbill.Close();
                                    }
                                    xmlContentforBillReceipt = swbill.ToString();
                                }
                            }
                        }
                    }
                    xmlContent = sw.ToString();
                }
                System.Data.DataTable dt = new DataTable();
                DataColumn dbCol1 = new DataColumn("ActionType");
                DataColumn dbCol2 = new DataColumn("Value");
                DataColumn dbCol3 = new DataColumn("AdditionalContext");
                DataColumn dbCol4 = new DataColumn("Category");
                DataColumn dbCol5 = new DataColumn("version");
                DataColumn dbCol6 = new DataColumn("Status");
                DataColumn dbCol7 = new DataColumn("OrgID");
                DataColumn dbCol8 = new DataColumn("OrgAddressID");
                DataColumn dbCol9 = new DataColumn("CreatedAt");
                DataColumn dbCol10 = new DataColumn("CreatedBy");
                DataColumn dbCol11 = new DataColumn("Template");
                DataColumn dbCol12 = new DataColumn("ContextType");
                DataColumn dbCol13 = new DataColumn("IsAttachment");
                DataColumn dbCol14 = new DataColumn("Subject");
                DataColumn dbCol15 = new DataColumn("AttachmentName");
                DataColumn dbCol16 = new DataColumn("IsClientBlinding");
                DataColumn dbCol17 = new DataColumn("CCTo");
                DataColumn dbCol18 = new DataColumn("BccTo");
                DataColumn dbCol19 = new DataColumn("ReportType");
                DataColumn dbCol20 = new DataColumn("IsManualReport");
                //add columns
                dt.Columns.Add(dbCol1);
                dt.Columns.Add(dbCol2);
                dt.Columns.Add(dbCol3);
                dt.Columns.Add(dbCol4);
                dt.Columns.Add(dbCol5);
                dt.Columns.Add(dbCol6);
                dt.Columns.Add(dbCol7);
                dt.Columns.Add(dbCol8);
                dt.Columns.Add(dbCol9);
                dt.Columns.Add(dbCol10);
                dt.Columns.Add(dbCol11);
                dt.Columns.Add(dbCol12);
                dt.Columns.Add(dbCol13);
                dt.Columns.Add(dbCol14);
                dt.Columns.Add(dbCol15);
                dt.Columns.Add(dbCol16);
                dt.Columns.Add(dbCol17);
                dt.Columns.Add(dbCol18);
                dt.Columns.Add(dbCol19);
                dt.Columns.Add(dbCol20);
                DataRow dr;
                int pdfcount = 0;
                int printcount = 0;
                int roundbprintcount = 0;
                int isstatprintcount = 0;
                int IsStatPdfCount = 0;
                int billprintcount = 0;
                int invoiceprintcount = 0;
                int RoundBCount = 0;
                string[] ListAttributes = new string[100];
                string[] lstPatientDispatchMode = new string[100];

                if (lstPerformingAction.Exists(p => p.ContextType.ToLower() == "cp" && p.Attributes != null))
                {
                    ListAttributes = lstPerformingAction.Find(p => p.ContextType.ToLower() == "cp").Attributes.Split(',');
                }
                if (lstPerformingAction.Exists(p => p.ContextType.ToLower() == "p" && p.Attributes != null))
                {
                    lstPatientDispatchMode = lstPerformingAction.Find(p => p.ContextType.ToLower() == "p").Attributes.Split(',');
                }
                if (lstPerformingAction.Exists(p => p.ContextType.ToLower() == "inv" && p.Attributes != null))
                {
                    ListAttributes = lstPerformingAction.Find(p => p.ContextType.ToLower() == "inv").Attributes.Split(',');
                }
                string Client_Notify_Email = "REMAIL";
                string Client_Notify_SMS = "RSMS";
                string Client_Report_Email = "REPEMAIL";
                string Client_Report_SMS = "REPSMS";

                string Patient_Notify_Email = "REMAIL";
                string Patient_Notify_SMS = "RSMS";
                string Patient_Report_Email = "REPEMAIL";
                string Patient_Report_SMS = "REPSMS";

                string Client_Invoice_Email = "IEMAIL";
                string Client_Invoice_SMS = "ISMS";

                string Client_Bill_Email = "TMPR";

                foreach (PerformingAction item in lstPerformingAction)
                {
                    if ((item.ContextType.ToLower() == "cp" && item.AdditionalContext.ToLower() == "notify" && item.ActionType.ToLower() == "sms" && ListAttributes.Contains(Client_Notify_SMS)) ||
                        (item.ContextType.ToLower() == "cp" && item.AdditionalContext.ToLower() == "notify" && item.ActionType.ToLower() == "apisms" && ListAttributes.Contains(Client_Notify_SMS)) ||
                        (item.ContextType.ToLower() == "cp" && item.AdditionalContext.ToLower() == "notify" && item.ActionType.ToLower() == "email" && ListAttributes.Contains(Client_Notify_Email)) ||
                        (item.ContextType.ToLower() == "cp" && item.AdditionalContext.ToLower() == "report" && item.ActionType.ToLower() == "sms" && ListAttributes.Contains(Client_Report_SMS) && (objPageContextkey.isActionDisabled != true)) ||
                        (item.ContextType.ToLower() == "cp" && item.AdditionalContext.ToLower() == "report" && item.ActionType.ToLower() == "apisms" && ListAttributes.Contains(Client_Report_SMS) && (objPageContextkey.isActionDisabled != true)) ||
                        (item.ContextType.ToLower() == "cp" && item.AdditionalContext.ToLower() == "report" && item.ActionType.ToLower() == "email" && ListAttributes.Contains(Client_Report_Email) && (objPageContextkey.isActionDisabled != true)) ||
                        (item.ContextType.ToLower() == "cp" && item.AdditionalContext.ToLower() == "bill" && item.ActionType.ToLower() == "email" && ListAttributes.Contains(Client_Bill_Email)) ||

                        (item.ContextType.ToLower() == "p" && item.AdditionalContext.ToLower() == "notify" && item.ActionType.ToLower() == "sms" && lstPatientDispatchMode.Contains(Patient_Notify_SMS)) ||
                        (item.ContextType.ToLower() == "p" && item.AdditionalContext.ToLower() == "notify" && item.ActionType.ToLower() == "apisms" && lstPatientDispatchMode.Contains(Patient_Notify_SMS)) ||
                        (item.ContextType.ToLower() == "p" && item.AdditionalContext.ToLower() == "notify" && item.ActionType.ToLower() == "email" && lstPatientDispatchMode.Contains(Patient_Notify_Email)) ||
                        (item.ContextType.ToLower() == "p" && item.AdditionalContext.ToLower() == "report" && item.ActionType.ToLower() == "sms" && lstPatientDispatchMode.Contains(Patient_Report_SMS) && (objPageContextkey.isActionDisabled != true)) ||
                        (item.ContextType.ToLower() == "p" && item.AdditionalContext.ToLower() == "report" && item.ActionType.ToLower() == "apisms" && lstPatientDispatchMode.Contains(Patient_Report_SMS) && (objPageContextkey.isActionDisabled != true)) ||
                        (item.ContextType.ToLower() == "p" && item.AdditionalContext.ToLower() == "report" && item.ActionType.ToLower() == "email" && lstPatientDispatchMode.Contains(Patient_Report_Email) && (objPageContextkey.isActionDisabled != true)) ||
                        (item.ContextType.ToLower() == "p" && item.AdditionalContext.ToLower() == "bill" && item.ActionType.ToLower() == "email") ||

                        (item.ContextType.ToLower() == "inv" && item.AdditionalContext.ToLower() == "invoice" && item.ActionType.ToLower() == "sms" && ListAttributes.Contains(Client_Invoice_SMS)) ||
                        (item.ContextType.ToLower() == "inv" && item.AdditionalContext.ToLower() == "invoice" && item.ActionType.ToLower() == "apisms" && ListAttributes.Contains(Client_Invoice_SMS)) ||
                        (item.ContextType.ToLower() == "inv" && item.AdditionalContext.ToLower() == "invoice" && item.ActionType.ToLower() == "email" && ListAttributes.Contains(Client_Invoice_Email)) ||
                        (item.ContextType.ToLower() == "can" && item.ActionType.ToLower() == "email") ||
                        (item.ContextType.ToLower() == "rjn" && item.ActionType.ToLower() == "email") ||
                        (item.ContextType.ToLower() == "rcn" && item.ActionType.ToLower() == "email") ||
                        (item.ContextType.ToLower() == "rfn" && item.ActionType.ToLower() == "email") ||
                        (item.ContextType.ToLower() != "cp" && item.ContextType.ToLower() != "p" && item.ContextType.ToLower() != "inv") ||
                        (item.ActionType.ToLower() == "pdf") ||
                        (item.ActionType.ToLower() == "confidpdf") ||
                        (item.ActionType.ToLower() == "confidroundbpdf") ||
                        (item.ActionType.ToLower() == "clientblindchildpdf") ||
                        (item.ActionType.ToLower() == "clientblindchildroundbpdf") ||
                         (item.ActionType.ToLower() == "clientblindparentpdf") ||
                        (item.ActionType.ToLower() == "clientblindparentroundbpdf") ||
                        (item.ActionType.ToLower() == "print" && printcount == 0) ||
                        (item.ActionType.ToLower() == "isstatprint" && isstatprintcount == 0) ||
                        (item.ActionType.ToLower() == "roundbprint" && roundbprintcount == 0) ||
                        (item.ActionType.ToLower() == "billprint" && billprintcount == 0) ||
                        (item.ActionType.ToLower() == "invoiceprint" && invoiceprintcount == 0) ||
                        (item.ActionType.ToLower() == "isstatpdf" && IsStatPdfCount == 0) ||
						(item.ActionType.ToLower() == "roundbpdf" && RoundBCount == 0) 
						|| (item.ActionType.ToLower() == "wbill") || (item.ActionType.ToLower() == "outbound") || (item.ActionType.ToLower() == "lisordered"))
                    {
                        dr = dt.NewRow();
                        dr["ActionType"] = item.ActionType;
                        if (item.ActionType == "Sms" || item.ActionType == "APISMS")
                        {
                            dr["Value"] = item.PhoneNo;
                        }
                        if (item.ActionType == "Email")
                        {
                            dr["Value"] = item.MailTo;
                            dr["BccTo"] = item.BccTo;
                            dr["CCTo"] = item.CCTo;
                        }
                        if (item.AdditionalContext.ToLower() == "bill")
                        {
                            dr["AdditionalContext"] = xmlContentforBillReceipt;
                        }
                        else
                        {
                            dr["AdditionalContext"] = xmlContent;
                        }
                        if (item.ContextType == "INV")
                        {
                            dr["Category"] = "Invoice";
                        }
                        else
                        {
                            if (item.AdditionalContext.ToLower() == "bill")
                            {
                                dr["Category"] = "Bill";
                            }
                            else if (item.AdditionalContext.ToLower() == "report")
                            {
                                dr["Category"] = "Report";
                            }
                            else if (item.AdditionalContext.ToLower() == "notify")
                            {
                                dr["Category"] = "Notify";
                            }
                            else if (item.AdditionalContext.ToLower() == "integration")
                            {
                                dr["Category"] = "Integration";
                            }
                        }
                        dr["version"] = "";
                        if ((item.PatientDueStatus.ToLower() == "open") && (item.ContextType.ToLower() == "p" || item.ContextType.ToLower() == "cp"))
                        //if (item.PatientDueStatus.ToLower() == "open" && item.ContextType.ToLower() == "p" && PerformingActionContextType.Count < 1)
                        {
                            dr["Status"] = "Due";
                        }
                        else
                        {
                            dr["Status"] = "";
                        }

                        //Added By QBITZ Prakash.K
                        dr["IsManualReport"] = Convert.ToBoolean(true);

                        dr["OrgID"] = Convert.ToInt32(objPageContextkey.OrgID);
                        dr["OrgAddressID"] = Convert.ToInt32(objPageContextkey.ID);
                        dr["CreatedAt"] = DateTime.MinValue;
                        dr["CreatedBy"] = objPageContextkey.RoleID;
                        dr["Template"] = StrFormat(item.Description, item.ActionTemplateValue);
                        if ((item.ActionType.ToLower() == "sms" || item.ActionType.ToLower() == "apisms") && item.AdditionalContext.ToLower() == "report")
                        {
                            dr["Template"] = StrFormat(item.Description, item.ActionTemplateValue) + item.InvsNValues;
                        }
                        dr["ContextType"] = item.ContextType;
                        dr["IsAttachment"] = item.IsAttachment;
                        dr["Subject"] = StrFormat(item.Subject, item.ActionTemplateValue);
                        dr["AttachmentName"] = StrFormat(item.AttachmentName == null ? string.Empty : item.AttachmentName, item.ActionTemplateValue);
                        //dr["AttachmentName"] = StrFormat(item.AttachmentName, item.ActionTemplateValue);
                        if (item.ActionType.ToLower() == "email")
                        {
                            if (item.IsClientblinding == "")
                            {
                                int Blindcount = (from grp in lstPerformingAction
                                                  where grp.ActionType.ToLower() == "clientblindchildpdf" || grp.ActionType.ToLower() == "clientblindchildroundbpdf"
                                                  select grp.ActionType).Distinct().Count();
                                if (Blindcount > 0)
                                {
                                    dr["IsClientBlinding"] = "BC";
                                }
                            }
                            else
                            {
                                dr["IsClientBlinding"] = item.IsClientblinding;
                            }
                        }
                        //dr["Subject"] = item.Subject;

                        if ((item.ActionType.ToLower() == "print" && printcount == 0))
                        {
                            printcount++;
                        }
                        if ((item.ActionType.ToLower() == "roundbprint" && roundbprintcount == 0))
                        {
                            roundbprintcount++;
                        }
                        if ((item.ActionType.ToLower() == "isstatprint" && isstatprintcount == 0))
                        {
                            isstatprintcount++;
                        }
                        if ((item.ActionType.ToLower() == "billprint" && billprintcount == 0))
                        {
                            billprintcount++;
                        }
                        if ((item.ActionType.ToLower() == "invoiceprint" && invoiceprintcount == 0))
                        {
                            invoiceprintcount++;
                        }
                        if ((item.ActionType.ToLower() == "isstatpdf" && IsStatPdfCount == 0))
                        {
                            IsStatPdfCount++;
                        }
                        if ((item.ActionType.ToLower() == "roundbpdf" && RoundBCount == 0))
                        {
                            RoundBCount++;
                        }
                        int cnt = 0;
                        dr["ReportType"] = strReportType;
                        if (item.ActionType.ToLower() == "pdf" || item.ActionType.ToLower() == "roundbpdf" || item.ActionType.ToLower() == "wbill" || item.ActionType.ToLower() == "outbound" || item.ActionType.ToLower() == "lisordered"
                            || item.ActionType.ToLower() == "confidpdf" || item.ActionType.ToLower() == "confidroundbpdf"
                            || item.ActionType.ToLower() == "clientblindchildpdf" || item.ActionType.ToLower() == "clientblindchildroundbpdf"
                            || item.ActionType.ToLower() == "clientblindparentpdf" || item.ActionType.ToLower() == "clientblindparentroundbpdf")
                        {
                            var a = (from m in dt.AsEnumerable()
                                     where m.Field<string>("Category").ToLower() == item.AdditionalContext.ToLower() &&
                                     m.Field<string>("ActionType").ToLower() == item.ActionType.ToLower()
                                     select m).ToList();//m.Field<string>("IdentityId") == Convert.ToString(IdentityId) &&
                            cnt = a.Count();
                            if (cnt < 1)
                            {
                                dt.Rows.Add(dr);
                            }
                        }
                        else
                        {
                            dt.Rows.Add(dr);
                        }
                    }
                }
                Report_DAL objReportdal = new Report_DAL(globalContextDetails);
                if (dt.Rows.Count > 0)
                {
                    returnCode = objReportdal.SaveActionDetails(dt);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in PerformingNextStep", ex);
            }
            return returnCode;
        }

        //Added By QBITZ Prakash.A
        public void GetReportType(long VisitID, Int32 OrgID, string InvID, out String ReportType)
        {
            ReportType = string.Empty;
            try
            {
                Report_DAL objReportDal = new Report_DAL(globalContextDetails);
                objReportDal.pssrsReportDisplayMode(VisitID, OrgID, InvID, out ReportType);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting report type: ", ex);
            }
        }

        //Added by Jegan

        public long GetManualReportAction(PageContextkey objPageContextkey)
        {
            long returnCode = -1;
            List<PerformingAction> lstPerformingAction = new List<PerformingAction>();
            try
            {
                returnCode = new ActionManager_DAL(globalContextDetails).GetManualReportAction(objPageContextkey, out lstPerformingAction);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetManualReportAction", ex);
            }

            return returnCode;
        }
    }
}
