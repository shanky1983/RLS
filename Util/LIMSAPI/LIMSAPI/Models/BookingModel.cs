using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIMSAPI.Models
{
    public class BookingModel
    {
        public long BookingID { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Salutation { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string ClientCode { get; set; }
        public string URNType { get; set; }
        public string URNNo { get; set; }
        public string TRFFile { get; set; }
        public string DispatchType { get; set; }
        public DateTime BookingDTTM { get; set; }
        public long SampleID { get; set; }
        public string SampleName { get; set; }
        public long ContainerID { get; set; }
        public string ContainerName { get; set; }
        public string SampleContainerColour { get; set; }
        public DateTime SampleCollectionTime { get; set; }
        public string SampleStatus { get; set; }
        public string Reason { get; set; }
        public string FollowUpTest { get; set; }
        public DateTime FollowUpDTTM { get; set; }
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public decimal Price { get; set; }
        public decimal TotalGrossAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal ReceivedAmount { get; set; }
        public decimal DueAmount { get; set; }
        public string PaymentStatus { get; set; }
        public string PaymentMode { get; set; }
        public string CardDetails { get; set; }
        public string ReferencNo { get; set; }
       public long  InventoryCount { get; set; }



        public string InventoryDetails { get; set; }
        public long OrgID { get; set; }
        public long LocationID { get; set; }
        public string UserID { get; set; }
        public string Status { get; set; }
 public string Comments{ get; set; }
        public string ClientID { get; set; }
        public string CreatedBy { get; set; }
     
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string ISProcessed { get; set; }
        public string Error { get; set; }
        public string Remarks { get; set; }
    }
}