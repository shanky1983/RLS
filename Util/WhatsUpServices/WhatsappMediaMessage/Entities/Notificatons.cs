﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsappMediaMessage.Entities
{
    public partial class Notification
    {
        public int NotificationID { get; set; }
        public string ActionType { get; set; }
        public string Value { get; set; }
        public string AdditionalContext { get; set; }
        public string Category { get; set; }
        public string version { get; set; }
        public string Status { get; set; }
        public Nullable<int> OrgID { get; set; }
        public Nullable<long> OrgAddressID { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public string Template { get; set; }
        public string ContextType { get; set; }
        public string IsAttachment { get; set; }
        public string Subject { get; set; }
        public Nullable<int> Seq_Num { get; set; }
        public Nullable<int> RetryCount { get; set; }
        public int Priority { get; set; }
        public string AttachmentName { get; set; }
        public string IdentityID { get; set; }
        public Nullable<System.DateTime> CompletionTime { get; set; }
        public string IsConfidentialTest { get; set; }
        public string IsClientBlinding { get; set; }
        public Nullable<long> RoundID { get; set; }
        public string EmailCC { get; set; }
        public string Content { get; set; }
        public string ReportType { get; set; }
        public Nullable<System.DateTime> PickedAt { get; set; }
        public Nullable<bool> HasRepushed { get; set; }
        public string DelayReason { get; set; }
        public string EmailBccTo { get; set; }
        public Nullable<bool> IsReprinting { get; set; }
        public string ReportLanguage { get; set; }
        public Nullable<int> NoofCopies { get; set; }
    }
}
