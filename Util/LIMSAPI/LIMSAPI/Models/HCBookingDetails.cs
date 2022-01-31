using Attune.Kernel.LIMSAPI.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIMSAPI.Models
{
    public class HCBookingDetails
    {
        public BookingsParaInfo BookingsParaInfo { get; set; }
        public ContextDetails ContextInfo { get; set; }
    }
    public class BookingsParaInfo
    {
        public string CollecttionFromdate { get; set; }
        public string CollecttionTodate { get; set; }
        public string Fromdate { get; set; }
        public string Todate { get; set; }
        public string CollecOrgID { get; set; }
        public string LoginOrgID { get; set; }
        public string Status { get; set; }
        public string Task { get; set; }
        public string Location { get; set; }
        public string Pincode { get; set; }
        public long UserID { get; set; }
        public string MobileNumber { get; set; }
        public string TelePhone { get; set; }
        public string pName { get; set; }
        public string PageSize { get; set; }
        public string currentPageNo { get; set; }
        public string BookingNumber { get; set; }
    }
    
}