using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIMSAPI.Models
{
    public class BookingInfoModel
    {
        public long LoginID { get; set; }
        public string TransType { get; set; }
        public string SourceType { get; set; }
        public PatientInfoModel PatientInfo { get; set; }
        public BookingsModel BookingInfo { get; set; }
        public List<OrderModel> TestInfoList { get; set; }
        public List<PaymentModel> PaymentInfoList { get; set; }
    }

    public class PatientInfoModel
    {
        public string Salutation { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string URNType { get; set; }
        public string URNNumber { get; set; }
        public string ExternalPatientNo { get; set; }
        public string HealthHubID { get; set; }
        public string EmployeeID { get; set; }
        public string PatientNumber { get; set; }
        public List<AddressModel> AddressDetails { get; set; }
    }

    public class BookingsModel
    {
        public string ExternalRefNo { get; set; }
        public long OrgID { get; set; }
        public long LocationID { get; set; }
        public DateTime BookingDTTM { get; set; }
        public DateTime CollectionTime { get; set; }
        public string DispatchType { get; set; }
        public string TRFFile { get; set; }
        public string Status { get; set; }
        public long DiscountID { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal NetAmount { get; set; }
        public long ClientID { get; set; }
        public string ClientCode { get; set; }
        public string PaymentStatus { get; set; }        
        public string OrgCode { get; set; }
        public string LocationCode { get; set; }
        public string Remarks { get; set; }
        public string IsCreaditBill { get; set; }
    }

    public class OrderModel
    {
        public string OrderedFrom { get; set; }
        public string TestCode { get; set; }
        public long SampleID { get; set; }
        public string SampleName { get; set; }
        public long ContainerID { get; set; }
        public string ContainerName { get; set; }
        public string SampleContainerColour { get; set; }
        public decimal Price { get; set; }
        public string CollectionStatus { get; set; }
        public string Reason { get; set; }
        public DateTime SampleCollectedTime { get; set; }
        public string Type { get; set; }
        public string BarcodeNo { get; set; }
    }
}