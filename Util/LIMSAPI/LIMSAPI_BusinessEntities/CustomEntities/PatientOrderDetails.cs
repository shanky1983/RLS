using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class PatientOrderDetails
    {
        public string MessageType { get; set; }
        public string OrderId { get; set; }
        public string OrgCode { get; set; }
        public PatientDetails PatientInfo { get; set; }
        public PatientVisitDetails PatientVisitInfo { get; set; }
        public List<PatientTestDetails> TestDetailsList { get; set; }
        public BillingDetail BillingInfo { get; set; }
        public List<PaymentDetails> PaymentDetailsList { get; set; }
    }
    public class PatientDetails
    {
        public string PatientID { get; set; }
        public string PatientNumber { get; set; }
        public string Salutation { get; set; }
        public string SalutationCode { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string DOB { get; set; }
        public string MaritalStatus { get; set; }
        public string MobileNumber { get;set;}
        public string TelephoneNumber { get; set; }
        public string EmailID { get; set; }
        public string DocumentOf { get; set; }
        public string URNType { get; set; }
        public string URNNumber { get; set; }
        public string WardNo { get; set; }
        public List<PatientAddressDetails> AddressDetails { get; set; }
    }
    public class PatientDetail
    {
        public string PatientID { get; set; }
        public string PatientNumber { get; set; }
        public string SalutationValue { get; set; }
        public string SalutationCode { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string DOB { get; set; }
        public string MaritalStatus { get; set; }
        public string MobileNumber { get; set; }
        public string TelephoneNumber { get; set; }
        public string EmailID { get; set; }
        public string DocumentOf { get; set; }
        public string URNType { get; set; }
        public string URNNumber { get; set; }
        public string Address { get; set; }
        public string AddressType { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string MessageType { get; set; }
        public string OrderID { get; set; }
        public string ExternalPatientNumber { get; set; }
        public string OverAllStatus { get; set; }
        public string StateID { get; set; }
        public string CountryID { get; set; } 
        public string TimeZone { get; set; }
        public string Suburb { get; set; }
        public string WardNo { get; set; }

    }
    public class PatientAddressDetails {
        public string Address { get; set; }
        public string AddressType { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string StateID { get; set; }
        public string CountryID { get; set; }
        public string ExternalPatientNumber { get; set; }

    }
    public class PatientVisitDetails
    {
        public string PatientVisitId { get; set; }
        public string ExternalVisitNumber { get; set; }
        public string VisitType { get; set; }
        public string VisitDate { get; set; }
        public string VATRegisterationNo { get; set; }
        public string ClientCode { get; set; }
        public string ClientName { get; set; }
        public string CompanyID { get; set; }
        public string ReferingDoctorCode { get; set; }
        public string ReferingDoctorName { get; set; }
        public string ReferingDoctorMobileNumber { get; set; }
        public string IsNotification { get; set; }
        public string HospitalNameCode { get; set; }
        public string HospitalName { get; set; }
        public string WardNo { get; set; }
        public string VisitHistory { get; set; }
        public string VisitRemarks { get; set; }
        public string RegisterLocation { get; set; }
        public string ClientID { get; set; }
        public CorporatePatients CorporatePatient { get; set; }
        public List<VisitReportLanguage> ReportLanguage { get; set; }

    }
    public class CorporatePatients
    {
        public string BookedDate { get; set; }
        public string CheckinDate { get; set; }
        public string CheckOutDate { get; set; }
        public string Status { get; set; }
    }
    public class PatientTestDetails
    {
        public string Status { get; set; }
        public string TestCode { get; set; }
        public string TestID { get; set; }
        public string TestName { get; set; }
        public string IsStat { get; set; }
        public string Price { get; set; }
        public string RateCardcode { get; set; }
        public string TestClinicalHistory { get; set; }
        public string Instructions { get; set; }
        public string Remarks { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
    public class PaymentDetails
    {
        public string PaymentType { get; set; }

        public string ReferenceNo { get; set; }
        public decimal AmountReceived { get; set; }         

    }
    public class BillingDetail
    { 
        public string PaymentStatus { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal DueAmount { get; set; }

    }
    public class PatientBillingDetails
    {
        public string Status { get; set; }
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public string TestID { get; set; }
        public string IsStat { get; set; }
        public string Price { get; set; }
        public string RateCardcode { get; set; }
        public string TestClinicalHistory { get; set; }
        public string Instructions { get; set; }
        public string Remarks { get; set; }
        public string PaymentStatus { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal DueAmount { get; set; }
        public string MessageType { get; set; }
        public string OrderID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
    public class PatientVisitDetail
    {
        public string PatientVisitId { get; set; }
        public string ExternalVisitNumber { get; set; }
        public string VisitType { get; set; }
        public DateTime VisitDate { get; set; }
        public string VATRegisterationNo { get; set; }
        public string ClientCode { get; set; }
        public string ClientName { get; set; }
        public string ReferingDoctorCode { get; set; }
        public string ReferingDoctorName { get; set; }
        public string ReferingDoctorMobileNumber { get; set; }
        public string IsNotification { get; set; }
        public string HospitalNameCode { get; set; }
        public string HospitalName { get; set; }
        public string VisitHistory { get; set; }
        public string VisitRemarks { get; set; }
        public string RegisterLocation { get; set; } 
        public DateTime BookedDate { get; set; }
        public DateTime CheckinDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string Status { get; set; }
        public string CompanyID { get; set; }
        public string ClientID { get; set; }
        public string WardNo { get; set; }
        public string  Language { get; set; }
    }
    public class VisitReportLanguage
    {
        public string Language { get; set; }
    }
}

