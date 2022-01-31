using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{

    public class ApprovedReports
    {
        #region Fields
        private long visitID = 0;
        private int orgID = 0;
        private int seq_Num = 0;
        private long roleID = 0;
        private long createdBy = 0;
        private string status = string.Empty;
        private long orgAddressID = 0;
        private long patientID = 0;
        private string name = string.Empty;
        private string email = string.Empty;
        private string emailid = string.Empty;
        private string dispatchType = string.Empty;
        private string isCreditBill = string.Empty;
        private byte[] content = new byte[0];
        private string additionalContext = string.Empty;
        private string accessionNumber = string.Empty;
        private long notificationID = 0;
        private string reportPath = string.Empty;
        private string template = string.Empty;
        private string contextType = string.Empty;
        private string values = string.Empty;
        private string category = string.Empty;
        private long clientID = 0;
        private long invoiceID = 0;
        private DateTime fromDate = DateTime.MaxValue;
        private DateTime toDate = DateTime.MaxValue;
        private string isAttachment = string.Empty;
        private string subject = string.Empty;
        private long finallBillID = 0;
        private string billNumber = string.Empty;
        private string attachmentName = string.Empty;
        private string smsUrl = string.Empty;
        private string smsUserName = string.Empty;
        private string smsPassWord = string.Empty;
        private string smsProvider = string.Empty;
        private string emailHost = string.Empty;
        private string emailUserName = string.Empty;
        private string emailPassWord = string.Empty;
        private string emailPort = string.Empty;
        private string emailFromAddress = string.Empty;
        private string emailFromDisplayText = string.Empty;
        private string bannerImage = string.Empty;
        private string hasChangedFolderPath = String.Empty;
        /* BEGIN | sabari | 20181212 | Dev | NH Config*/
        private string _CCTo = string.Empty;
        private string _BccTo = string.Empty;
        /* END | sabari | 20181212| Dev | NH Config*/
        #endregion

        private bool isReprinting = false;
        #region Properties
        /// <summary>
        /// Gets or sets the GroupID value.
        /// </summary>
        public long VisitID
        {
            get { return visitID; }
            set { visitID = value; }
        }

        /// <summary>
        /// Gets or sets the GroupName value.
        /// </summary>
        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }
        public long OrgAddressID
        {
            get { return orgAddressID; }
            set { orgAddressID = value; }
        }

        /// <summary>
        /// Gets or sets the Type value.
        /// </summary>
        public long RoleID
        {
            get { return roleID; }
            set { roleID = value; }
        }

        /// <summary>
        /// Gets or sets the createdBy value.
        /// </summary>

        public long CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        /// <summary>
        /// Gets or sets the patientID value.
        /// </summary>
        public long PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }
        /// <summary>
        /// Gets or sets the patientID value.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// Gets or sets the patientID value.
        /// </summary>
        public string EMail
        {
            get { return email; }
            set { email = value; }
        }
        /// <summary>
        /// Gets or sets the EmaiID value.
        /// </summary>
        public string EmailID
        {
            get { return emailid; }
            set { emailid = value; }
        }
        /// <summary>
        /// Gets or sets the Content value.
        /// </summary>
        public byte[] Content
        {
            get { return content; }
            set { content = value; }
        }
        /// <summary>
        /// Gets or sets the IsCreditBill value.
        /// </summary>
        public string IsCreditBill
        {
            get { return isCreditBill; }
            set { isCreditBill = value; }
        }

        /// <summary>
        /// Gets or sets the IsCreditBill value.
        /// </summary>
        public string DispatchType
        {
            get { return dispatchType; }
            set { dispatchType = value; }
        }

        /// <summary>
        /// Gets or sets the AdditionalContext value.
        /// </summary>
        public string AdditionalContext
        {
            get { return additionalContext; }
            set { additionalContext = value; }
        }
        /// <summary>
        /// Gets or sets the AccessionNumber value.
        /// </summary>
        public string AccessionNumber
        {
            get { return accessionNumber; }
            set { accessionNumber = value; }
        }
        /// <summary>
        /// Gets or sets the AccessionNumber value.
        /// </summary>
        public long NotificationID
        {
            get { return notificationID; }
            set { notificationID = value; }
        }
        /// <summary>
        /// Gets or sets the reportPath value.
        /// </summary>
        public string ReportPath
        {
            get { return reportPath; }
            set { reportPath = value; }
        }

        /// <summary>
        /// Gets or sets the template value.
        /// </summary>
        public string Template
        {
            get { return template; }
            set { template = value; }
        }

        /// <summary>
        /// Gets or sets the contextType value.
        /// </summary>
        public string ContextType
        {
            get { return contextType; }
            set { contextType = value; }
        }
        /// <summary>
        /// Gets or sets the value value.
        /// </summary>
        public string Value
        {
            get { return values; }
            set { values = value; }
        }
        /// <summary>
        /// Gets or sets the category value.
        /// </summary>
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        /// <summary>
        /// Gets or sets the clientID value.
        /// </summary>
        public long ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }
        /// <summary>
        /// Gets or sets the invoiceID value.
        /// </summary>
        public long InvoiceID
        {
            get { return invoiceID; }
            set { invoiceID = value; }
        }
        /// <summary>
        /// Gets or sets the fromDate value.
        /// </summary>
        public DateTime FromDate
        {
            get { return fromDate; }
            set { fromDate = value; }
        }
        /// <summary>
        /// Gets or sets the toDate value.
        /// </summary>
        public DateTime TODate
        {
            get { return toDate; }
            set { toDate = value; }
        }
        /// <summary>
        /// Gets or sets the IsAttachment value.
        /// </summary>
        public string IsAttachment
        {
            get { return isAttachment; }
            set { isAttachment = value; }
        }
        /// <summary>
        /// Gets or sets the Subject value.
        /// </summary>
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        /// <summary>
        /// Gets or sets the Seq_Num value.
        /// </summary>
        public int Seq_Num
        {
            get { return seq_Num; }
            set { seq_Num = value; }
        }
        /// <summary>
        /// Gets or sets the FinallBillID value.
        /// </summary>
        public long FinallBillID
        {
            get { return finallBillID; }
            set { finallBillID = value; }
        }

        /// <summary>
        /// Gets or sets the PatientID value.
        /// </summary>
        public string BillNumber
        {
            get { return billNumber; }
            set { billNumber = value; }
        }

        /// <summary>
        /// Gets or sets the attachmentName value.
        /// </summary>
        public string AttachmentName
        {
            get { return attachmentName; }
            set { attachmentName = value; }
        }


        /// <summary>
        /// Gets or sets the return value.
        /// </summary>
        public string SmsURL
        {
            get { return smsUrl; }
            set { smsUrl = value; }
        }

        /// <summary>
        /// Gets or sets the return value.
        /// </summary>
        public string SmsUserName
        {
            get { return smsUserName; }
            set { smsUserName = value; }
        }
        /// <summary>
        /// Gets or sets the smsPassWord value.
        /// </summary>
        public string SmsPassWord
        {
            get { return smsPassWord; }
            set { smsPassWord = value; }
        }
        /// <summary>
        /// Gets or sets the smsProvider value.
        /// </summary>
        /// 
        public string SmsProvider
        {
            get { return smsProvider; }
            set { smsProvider = value; }
        }

        /// <summary>
        /// Gets or sets the emailHost value.
        /// </summary>
        ///
        public string EmailHost
        {
            get { return emailHost; }
            set { emailHost = value; }
        }
        /// <summary>
        /// Gets or sets the emailHost value.
        /// </summary>
        ///
        public string EmailUserName
        {
            get { return emailUserName; }
            set { emailUserName = value; }
        }
        /// <summary>
        /// Gets or sets the emailHost value.
        /// </summary>
        ///
        public string EmailPassWord
        {
            get { return emailPassWord; }
            set { emailPassWord = value; }
        }
        /// <summary>
        /// Gets or sets the emailPort value.
        /// </summary>
        ///
        public string EmailPort
        {
            get { return emailPort; }
            set { emailPort = value; }
        }

        /// <summary>
        /// Gets or sets the emailFromAddress value.
        /// </summary>
        ///
        public string EmailFromAddress
        {
            get { return emailFromAddress; }
            set { emailFromAddress = value; }
        }
        /// <summary>
        /// Gets or sets the emailFromDisplayText value.
        /// </summary>
        ///
        public string EmailFromDisplayText
        {
            get { return emailFromDisplayText; }
            set { emailFromDisplayText = value; }
        }

        /// <summary>
        /// Gets or sets the emailFromDisplayText value.
        /// </summary>
        ///
        public string BannerImage
        {
            get { return bannerImage; }
            set { bannerImage = value; }
        }
        
        public string HasChangedFolderPath
        {
            get { return hasChangedFolderPath; }
            set { hasChangedFolderPath = value; }
        }
        #endregion
        /* BEGIN | sabari | 20181212 | Dev | NH Config*/
        public string CCTo
        {
            get { return _CCTo; }
            set { _CCTo = value; }
        }
        public string BccTo
        {
            get { return _BccTo; }
            set { _BccTo = value; }
        }

        public bool IsReprinting
        {
            get { return isReprinting; }
            set { isReprinting = value; }
        }
        /* END | sabari | 20181212| Dev | NH Config*/
        private string _reportLanguage = string.Empty;
        public string ReportLanguage
        {
            get { return _reportLanguage; }
            set { _reportLanguage = value; }
        }
        private int _noofCopies = 0;
        public int NoofCopies
        {
            get { return _noofCopies; }
            set { _noofCopies = value; }
        }
    }
}
