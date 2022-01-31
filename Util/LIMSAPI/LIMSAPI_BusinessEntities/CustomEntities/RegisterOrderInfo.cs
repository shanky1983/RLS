using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{ 
    public class RegisterOrderInfo
    {
        #region Fields
        private DateTime dateofBirth = DateTime.MaxValue;
    //    private DateTime createdAt = DateTime.MaxValue;
    //    private DateTime modifiedAt = DateTime.MaxValue;
  //      private DateTime dateOfRegistration = DateTime.MaxValue;
   //     private DateTime sampleCollectionTime = DateTime.MaxValue;

        #endregion

        #region Property
        public string PatRegOrderID { get; set; }
        public string SourceType { get; set; }
        public int BookingID { get; set; }
        public string UserID { get; set; }
        public string PatientName { get; set; }
        public string PatientID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SalutationCode { get; set; }
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
        public long PostalCode { get; set; }
        public string AddressType { get; set; }
      
        public long CityID { get; set; }
        public long StateID { get; set; }
        public long CountryID { get; set; }
        public string TRFFile { get; set; }
        public string URNType { get; set; }
        public string URNNo { get; set; }
       
        //public DateTime DateOfRegistration
        //{
        //    get { return dateOfRegistration; }
        //    set { dateOfRegistration = value; }
        //}
        public string ClientCode { get; set; }
        public string DispatchType { get; set; }
        public long SampleID { get; set; }
        public string SampleName { get; set; }
        public long ContainerID { get; set; }
        public string ContainerName { get; set; }
        public string SampleContainerColour { get; set; }
      
        //public DateTime SampleCollectionTime
        //{
        //    get { return sampleCollectionTime; }
        //    set { sampleCollectionTime = value; }
        //}
        public string SampleStatus { get; set; }
        public string ReasonSampleCollected { get; set; }
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

        public string PaymentReferenceNo { get; set; }

        public string ExternalVisitID { get; set; }


        public string CreatedBy { get; set; }
     
        //public DateTime CreatedAt
        //{
        //    get { return createdAt; }
        //    set { createdAt = value; }
        //}
        public string ModifiedBy { get; set; }
        
        //public DateTime ModifiedAt
        //{
        //    get { return modifiedAt; }
        //    set { modifiedAt = value; }
        //}
        public string IsProcessYN { get; set; }
        public long OrgID { get; set; }
        public long LocationID { get; set; }
        public string Source { get; set; }
        public string Status { get; set; }
        public string ClientID { get; set; }
        public string Error { get; set; }
        public string Remarks { get; set; }

        public string JsonValue { get; set; }
        public string JsonString { get; set; }
    public string PatientVisitId {get; set; }

public string ExternalVisitNumber       { get; set; }
	 public string VisitType      { get; set; }
	 public string ClientName        { get; set; }
	 public string ReferingDoctorCode       { get; set; }
 public string ReferingDoctorName       { get; set; }
 public string ReferingDoctorMobileNumber         { get; set; }
 public string HospitalName      { get; set; }
 public string VisitHistory       { get; set; }
 public string VisitRemarks      { get; set; }
 public string HospitalNameCode      { get; set; }
        public string IsNotification { get; set; }
        public string TestCode { get; set; }
        public string IsStat { get; set; }
        public string TestClinicalHistory { get; set; }
        public string Instructions { get; set; }
        public string MessageType { get; set; }
        #endregion
    }
}
