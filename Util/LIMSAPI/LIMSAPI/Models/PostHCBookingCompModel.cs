using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIMSAPI.Models
{
    public class PostHCBookingCompModel
    {
        public long LoginID { get; set; }
        public string TransType { get; set; }
        public PatientDetailModel PatientInfo { get; set; }
        public BookingDetailsModel BookingInfo { get; set; }
        public List<OrderItemModel> TestInfoList { get; set; }
        public List<AddOrderItemModel> AddTestInfoList { get; set; }
        public List<SampleModel> SampleInfoList { get; set; }
        public List<PaymentModel> PaymentInfoList { get; set; }
    }

    public class OrderItemModel
    {
        public string OrderedFrom { get; set; }
        public string TestCode { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
    }
    public class AddOrderItemModel
    {
        public string OrderedFrom { get; set; }
        public string TestCode { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
    }

    public class SampleModel
    {
        private DateTime CollectedTime = DateTime.MaxValue;
        public long SampleID { get; set; }
        public string SampleName { get; set; }
        public long ContainerID { get; set; }
        public string ContainerName { get; set; }
        public string SampleContainerColour { get; set; }

        public DateTime SampleCollectedTime
        {
            get { return CollectedTime; }
            set { CollectedTime = value; }
        }
        
        public string CollectionStatus { get; set; }
        public string BarcodeNo { get; set; }
        public string IsNewSampleYN { get; set; }
        public string Reason { get; set; }
    }

}