using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIMSAPI.Models
{
    public class PostNewBookingwithSample
    {
        public long LoginID { get; set; }
        public string TransType { get; set; }
        public string SourceType { get; set; }
        public PatientInfoModel PatientInfo { get; set; }
        public BookingsModel BookingInfo { get; set; }
        public List<OrderItemModel> TestInfoList { get; set; }
        public List<SampleModel> SampleInfoList { get; set; }
        public List<PaymentModel> PaymentInfoList { get; set; }
    }
}