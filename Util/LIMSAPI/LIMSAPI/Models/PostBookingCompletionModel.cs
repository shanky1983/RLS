using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIMSAPI.Models
{
    public class PostBookingCompletionModel
    {
        public long LoginID { get; set; }
        public string TransType { get; set; }
        public PatientDetailModel PatientInfo { get; set; }
        public BookingDetailsModel BookingInfo { get; set; }
        public List<TestModel> TestInfoList { get; set; }
        public List<AddTestModel> AddTestInfoList { get; set; }
        public BillingModel BillingInfo { get; set; }
        public List<PaymentModel> PaymentInfoList { get; set; }
    }

    public class PatientDetailModel
    {
        public long PatientID { get; set; }
        public string Salutation { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public DateTime DOB { get; set; }
        public string MobileNumber { get; set; }
        public string EmailID { get; set; }
        public string URNType { get; set; }
        public string URNNumber { get; set; }
        public string ExternalPatientNumber { get; set; }
        public string EmployeeID { get; set; }
        public List<HCAddressModel> AddressDetails { get; set; }
    }

    public class BookingDetailsModel
    {
        public long BookingID { get; set; }
        public long OrgID { get; set; }
        public long LocationID { get; set; }
        public DateTime BookingDTTM { get; set; }
        public DateTime CollectionTime { get; set; }
        public string DispatchType { get; set; }
        public string TRFFile { get; set; }
        public string Status { get; set; }        
        public string OrgCode { get; set; }
        public string LocationCode { get; set; }
        public string Reason { get; set; }
        public string PaymentStatus { get; set; }

    }

    public class TestModel
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
    public class AddTestModel
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

    public class BillingModel
    {
        
    }

    public class HCAddressModel
    {
        public string AddressType { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public long PostalCode { get; set; }
    }
}