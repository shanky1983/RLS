//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WhatsUpServices
{
    using System;
    using System.Collections.Generic;
    
    public partial class WhatsUpNotification
    {
        public long WhatsUpNotificationId { get; set; }
        public string MobileNo { get; set; }
        public Nullable<int> TemplateMasterNo { get; set; }
        public string TemplateParamJSON { get; set; }
        public string IsSentYN { get; set; }
        public string IsErrorYN { get; set; }
    }
}
