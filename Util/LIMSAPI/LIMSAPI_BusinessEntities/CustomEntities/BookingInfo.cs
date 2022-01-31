using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class BookingInfo
    {
        #region Fields
        private DateTime dateofBirth = DateTime.MaxValue;
        private DateTime bookingDTTM = DateTime.MaxValue;
        private DateTime sampleCollectionTime = DateTime.MaxValue;
        private DateTime followUpDTTM = DateTime.MaxValue;
        private DateTime collectionTime = DateTime.MaxValue;
        private DateTime createdAt = DateTime.MaxValue;
        private DateTime modifiedAt = DateTime.MaxValue;
        #endregion

        #region Property
        public long BookingID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Salutation { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public DateTime DateofBirth
        {
            get { return dateofBirth; }
            set { dateofBirth = value; }
        }
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
        public DateTime BookingDTTM
        {
            get { return bookingDTTM; }
            set { bookingDTTM = value; }
        }
        public long SampleID { get; set; }
        public string SampleName { get; set; }
        public long ContainerID { get; set; }
        public string ContainerName { get; set; }
        public string SampleContainerColour { get; set; }
        public DateTime SampleCollectionTime {
            get { return sampleCollectionTime; }
            set { sampleCollectionTime = value; }
        }
        public string SampleStatus { get; set; }
        public string Reason { get; set; }
        public string FollowUpTest { get; set; }
        public DateTime FollowUpDTTM
        {
            get { return followUpDTTM; }
            set { followUpDTTM = value; }
        }
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
        public string ReferenceNo { get; set; }
        public long InventoryCount { get; set; }
        public string InventoryDetails { get; set; }
        public long OrgID { get; set; }
        public long LocationID { get; set; }
        public string UserID { get; set; }
        public string Status { get; set; }
public string Comments{ get; set; }
        public string ClientID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt
        {
            get { return modifiedAt; }
            set { modifiedAt = value; }
        }
        public string ISProcessed { get; set; }
        public string Error { get; set; }
        public string Remarks { get; set; }
        public string Name { get; set; }
        public long PatientID { get; set; }
        public string ExternalPatientNumber { get; set; }
        public DateTime CollectionTime {
            get { return collectionTime; }
            set { collectionTime = value; }
        }
        public string OrderedFrom { get; set; }
        public long CardNumber { get; set; }
        public string CurrencyType { get; set; }
        public string JsonValue { get; set; }
        public long CityID { get; set; }
        public long StateID { get; set; }
        public long CountryID { get; set; }
        public long LoginID { get; set; }
        public string AddressType { get; set; }
        public string Type { get; set; }
        public long DiscountID { get; set; }
        public string ExternalRefNo { get; set; }
        public string SourceType { get; set; }
        public string ExternalPatientRefNo { get; set; }
        public string BarcodeNo { get; set; }
        public string OrgCode { get; set; }
        public string LocationCode { get; set; }
        public string EmployeeID { get; set; }
        public string BookingRemarks { get; set; }
        public string Location { get; set; }
        public string ERPPatientNumber { get; set; }
        #endregion
    }
}
