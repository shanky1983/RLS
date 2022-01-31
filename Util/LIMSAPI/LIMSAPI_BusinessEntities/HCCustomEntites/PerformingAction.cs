using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class PerformingAction
    {
        public long PageID { get; set; }
        public long RoleID { get; set; }
        public string Description { get; set; }
        public string ActionType { get; set; }
        public int OrgID { get; set; }
        public long ID { get; set; }
        public string ContextType { get; set; }
        public string MailFrom { get; set; }
        public string MailTo { get; set; }
        public string CCTo { get; set; }
        public string BccTo { get; set; }
        public string Subject { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public NameValueCollection ActionTemplateValue { get; set; }
        public string RedirectURL { get; set; }
        public string PatientNumber { get; set; }
        public string OrgName { get; set; }
        public string MsgedDate { get; set; }
        public long UserID { get; set; }
        public string ClientStatus { get; set; }
        public string BlockFrom { get; set; }
        public string BlockTo { get; set; }
        public decimal Netvalue { get; set; }
        public string InvoiceNumber { get; set; }
        public long InvoiceID { get; set; }
        public long ClientID { get; set; }
        public string RefDoctorName { get; set; }
        public string PublishedDate { get; set; }
        public string InvsNValues { get; set; }
        public long IndentNumber { get; set; }
        public string StudyName { get; set; }
        public string SiteName { get; set; }
        public string LocationName { get; set; }
        public long PatientVisitID { get; set; }
        public string AccessionNumber { get; set; }
        public string Attributes { get; set; }
        public string ClientName { get; set; }
        public string PatientDueStatus { get; set; }
        public string IsAttachment { get; set; }
        public string AdditionalContext { get; set; }
        public string TestName { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public string RateDesc { get; set; }
        public string Password { get; set; }
        public string AttachmentName { get; set; }
        public string ServiceName { get; set; }
        public string UserName { get; set; }
        public string BillType { get; set; }
        public string VisitNumber { get; set; }
        public string BillNumber { get; set; }
        public string Reason { get; set; }
        public string DiscountType { get; set; }
        public string OldPatientNumber { get; set; }
        public string Comments { get; set; }
        public string ClientCode { get; set; }
        public string DueAmount { get; set; }
        public string StockIssue { get; set; }
        public string IndentNo { get; set; }
        public string DeptName { get; set; }
        public string PONo { get; set; }
        public string PurchaseOrder { get; set; }
        public string StockReceive { get; set; }
        public string IsClientblinding { get; set; }
        public string IndentRise { get; set; }
        public string ReportLanguage { get; set; }
        public Int32 NoofCopies { get; set; }
    }
}
