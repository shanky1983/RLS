using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.IO;
using System.Linq;
using System.Xml;
using Attune.Cryptography;
using Attune.KernelV2.DAL;
using Attune.KernelV2.Entities;


namespace Attune.KernelV2.BL
{
    public class ActionManager_BL : IDisposable
    {
        UI_ContextDetails globalContextDetails;

        public ActionManager_BL(UI_ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        private static string StrFormat(string pTemplate, NameValueCollection pTemplateResult)
        {

            foreach (string key in pTemplateResult.Keys)
            {
                if (pTemplate.Contains("{" + key + "}"))
                {
                    if (key == "Password")
                    {
                        string DecryptedPassword;
                        CCryptography objDecryptor = new CCryptFactory().GetDecryptor();
                        objDecryptor.Crypt(pTemplateResult[key], out DecryptedPassword);
                        pTemplate = pTemplate.Replace("{" + key + "}", DecryptedPassword);
                    }
                    else
                    {
                        pTemplate = pTemplate.Replace("{" + key + "}", pTemplateResult[key]);
                    }
                }
            }

            return pTemplate;

        }

        public void PerformingNextStepNotification(UI_PageContext objPageContextkey, string fromdate, string Todate)
        {
            globalContextDetails.AdditionalInfo = objPageContextkey.FinalBillID.ToString();
            List<UI_PerformingAction> lstPerformingAction;
            using (ActionManager_DAL DAL = new ActionManager_DAL(globalContextDetails))
            {
                lstPerformingAction = DAL.GetPerformingAction(objPageContextkey.PageID, objPageContextkey.ButtonName,
                    objPageContextkey.RoleID, objPageContextkey.PatientID,
                    objPageContextkey.OrgID, objPageContextkey.PatientVisitID, objPageContextkey.SampleID,
                    objPageContextkey.IDS);
            }

            if (!string.IsNullOrEmpty(objPageContextkey.Description))
            {
                foreach (UI_PerformingAction item in lstPerformingAction)
                {
                    item.MailTo = objPageContextkey.Description;
                }
            }

            List<UI_PerformingAction> PerformingActionInvoice = (from PA in lstPerformingAction
                where PA.ContextType == "INV"
                select PA).ToList();
            List<UI_PerformingAction> PerformingActionforBill = (from PA in lstPerformingAction
                where PA.AdditionalContext.ToLower() == "bill"
                select PA).ToList();


            string xmlContent;
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
                        xw.WriteString(objPageContextkey.PatientID.ToString()); //ClientID asPatientID 
                        xw.WriteEndElement();
                        xw.WriteStartElement("ClientID");
                        xw.WriteString(objPageContextkey.PatientID.ToString()); //ClientID asPatientID 
                        xw.WriteEndElement();
                        xw.WriteStartElement("FromDate");
                        xw.WriteString(!string.IsNullOrEmpty(fromdate) ? fromdate : "0");
                        xw.WriteEndElement();
                        xw.WriteStartElement("ToDate");
                        xw.WriteString(!string.IsNullOrEmpty(Todate) ? Todate : "0");
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
                            xw.WriteString(!string.IsNullOrEmpty(lstPerformingAction[0].AccessionNumber)
                                ? lstPerformingAction[0].AccessionNumber
                                : "0");
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
                                        billnum = objPageContextkey.BillNumber;
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

            DataTable dt = new DataTable();
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
                lstPatientDispatchMode =
                    lstPerformingAction.Find(p => p.ContextType.ToLower() == "p").Attributes.Split(',');
            }

            if (lstPerformingAction.Exists(p => p.ContextType.ToLower() == "inv" && p.Attributes != null))
            {
                ListAttributes = lstPerformingAction.Find(p => p.ContextType.ToLower() == "inv").Attributes.Split(',');
            }

            const string Client_Notify_Email = "REMAIL";
            const string Client_Notify_SMS = "RSMS";
            const string Client_Report_Email = "REPEMAIL";
            const string Client_Report_SMS = "REPSMS";

            const string Patient_Notify_Email = "REMAIL";
            const string Patient_Notify_SMS = "RSMS";
            const string Patient_Report_Email = "REPEMAIL";
            const string Patient_Report_SMS = "REPSMS";

            const string Client_Invoice_Email = "IEMAIL";
            const string Client_Invoice_SMS = "ISMS";

            const string Client_Bill_Email = "TMPR";

            foreach (UI_PerformingAction item in lstPerformingAction)
            {
                if ((item.ContextType.ToLower() == "cp" && item.AdditionalContext.ToLower() == "notify" &&
                     item.ActionType.ToLower() == "sms" && ListAttributes.Contains(Client_Notify_SMS)) ||
                    (item.ContextType.ToLower() == "cp" && item.AdditionalContext.ToLower() == "notify" &&
                     item.ActionType.ToLower() == "email" && ListAttributes.Contains(Client_Notify_Email)) ||
                    (item.ContextType.ToLower() == "cp" && item.AdditionalContext.ToLower() == "report" &&
                     item.ActionType.ToLower() == "sms" && ListAttributes.Contains(Client_Report_SMS) &&
                     (objPageContextkey.isActionDisabled != true)) ||
                    (item.ContextType.ToLower() == "cp" && item.AdditionalContext.ToLower() == "report" &&
                     item.ActionType.ToLower() == "email" && ListAttributes.Contains(Client_Report_Email) &&
                     (objPageContextkey.isActionDisabled != true)) ||
                    (item.ContextType.ToLower() == "cp" && item.AdditionalContext.ToLower() == "bill" &&
                     item.ActionType.ToLower() == "email" && ListAttributes.Contains(Client_Bill_Email)) ||

                    (item.ContextType.ToLower() == "p" && item.AdditionalContext.ToLower() == "notify" &&
                     item.ActionType.ToLower() == "sms" && lstPatientDispatchMode.Contains(Patient_Notify_SMS)) ||
                    (item.ContextType.ToLower() == "p" && item.AdditionalContext.ToLower() == "notify" &&
                     item.ActionType.ToLower() == "email" && lstPatientDispatchMode.Contains(Patient_Notify_Email)) ||
                    (item.ContextType.ToLower() == "p" && item.AdditionalContext.ToLower() == "report" &&
                     item.ActionType.ToLower() == "sms" && lstPatientDispatchMode.Contains(Patient_Report_SMS) &&
                     (objPageContextkey.isActionDisabled != true)) ||
                    (item.ContextType.ToLower() == "p" && item.AdditionalContext.ToLower() == "report" &&
                     item.ActionType.ToLower() == "email" && lstPatientDispatchMode.Contains(Patient_Report_Email) &&
                     (objPageContextkey.isActionDisabled != true)) ||
                    (item.ContextType.ToLower() == "p" && item.AdditionalContext.ToLower() == "bill" &&
                     item.ActionType.ToLower() == "email") ||

                    (item.ContextType.ToLower() == "inv" && item.AdditionalContext.ToLower() == "invoice" &&
                     item.ActionType.ToLower() == "sms" && ListAttributes.Contains(Client_Invoice_SMS)) ||
                    (item.ContextType.ToLower() == "inv" && item.AdditionalContext.ToLower() == "invoice" &&
                     item.ActionType.ToLower() == "email" && ListAttributes.Contains(Client_Invoice_Email)) ||
                    (item.ContextType.ToLower() == "can" && item.ActionType.ToLower() == "email") ||
                    (item.ContextType.ToLower() == "rjn" && item.ActionType.ToLower() == "email") ||
                    (item.ContextType.ToLower() == "rcn" && item.ActionType.ToLower() == "email") ||
                    (item.ContextType.ToLower() == "rfn" && item.ActionType.ToLower() == "email") ||
                    (item.ContextType.ToLower() != "cp" && item.ContextType.ToLower() != "p" &&
                     item.ContextType.ToLower() != "inv") ||
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
                    (item.ActionType.ToLower() == "roundbpdf" && RoundBCount == 0) ||
                    (item.ActionType.ToLower() == "wbill") || (item.ActionType.ToLower() == "outbound") ||
                    (item.ActionType.ToLower() == "lisordered"))
                {
                    var dr = dt.NewRow();
                    dr["ActionType"] = item.ActionType;
                    if (item.ActionType == "Sms")
                    {
                        dr["Value"] = item.PhoneNo;
                    }

                    if (item.ActionType == "Email")
                    {
                        dr["Value"] = item.MailTo;
                        dr["BccTo"] = item.BccTo; //surya new chanage for critical Alert (6october2017)
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
                    if ((item.PatientDueStatus.ToLower() == "open") &&
                        (item.ContextType.ToLower() == "p" || item.ContextType.ToLower() == "cp"))
                        //if (item.PatientDueStatus.ToLower() == "open" && item.ContextType.ToLower() == "p" && PerformingActionContextType.Count < 1)
                    {
                        dr["Status"] = "Due";
                    }
                    else
                    {
                        dr["Status"] = "";
                    }

                    dr["OrgID"] = Convert.ToInt32(objPageContextkey.OrgID);
                    dr["OrgAddressID"] = Convert.ToInt32(objPageContextkey.ID);
                    dr["CreatedAt"] = DateTime.MinValue;
                    dr["CreatedBy"] = objPageContextkey.RoleID;
                    dr["Template"] = StrFormat(item.Description, item.ActionTemplateValue);
                    if (item.ActionType.ToLower() == "sms" && item.AdditionalContext.ToLower() == "report")
                    {
                        dr["Template"] = StrFormat(item.Description, item.ActionTemplateValue) + item.InvsNValues;
                    }

                    dr["ContextType"] = item.ContextType;
                    dr["IsAttachment"] = item.IsAttachment;
                    dr["Subject"] = StrFormat(item.Subject, item.ActionTemplateValue);
                    dr["AttachmentName"] = StrFormat(item.AttachmentName ?? string.Empty, item.ActionTemplateValue);
                    //dr["AttachmentName"] = StrFormat(item.AttachmentName, item.ActionTemplateValue);
                    if (item.ActionType.ToLower() == "email")
                    {
                        if (item.IsClientblinding == "")
                        {
                            int Blindcount = (from grp in lstPerformingAction
                                where grp.ActionType.ToLower() == "clientblindchildpdf" ||
                                      grp.ActionType.ToLower() == "clientblindchildroundbpdf"
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

                    if (item.ActionType.ToLower() == "pdf" || item.ActionType.ToLower() == "roundbpdf" ||
                        item.ActionType.ToLower() == "wbill" || item.ActionType.ToLower() == "outbound" ||
                        item.ActionType.ToLower() == "lisordered"
                        || item.ActionType.ToLower() == "confidpdf" || item.ActionType.ToLower() == "confidroundbpdf"
                        || item.ActionType.ToLower() == "clientblindchildpdf" ||
                        item.ActionType.ToLower() == "clientblindchildroundbpdf"
                        || item.ActionType.ToLower() == "clientblindparentpdf" ||
                        item.ActionType.ToLower() == "clientblindparentroundbpdf")
                    {
                        var a = (from m in dt.AsEnumerable()
                            where m.Field<string>("Category").ToLower() == item.AdditionalContext.ToLower() &&
                                  m.Field<string>("ActionType").ToLower() == item.ActionType.ToLower()
                            select m).ToList();
                        var cnt = a.Count;
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

            using (ActionManager_DAL DAL = new ActionManager_DAL(globalContextDetails))
            {
                DAL.SaveActionDetails(dt);
            }



        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
