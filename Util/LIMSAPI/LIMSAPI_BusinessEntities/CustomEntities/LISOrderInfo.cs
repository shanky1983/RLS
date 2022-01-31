using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
  public  class LISOrderInfo
    {
        public long PatientID { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PatientAddress { get; set; }
        public string MobileNumber { get; set; }
        public string EMailID { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PinCode { get; set; }
        public string ClientName { get; set; }
        public long RefPhysicianID { get; set; }
        public string RefPhysicianName { get; set; }
        public long HospitalID { get; set; }
        public string HospitalName { get; set; }
        public string ExternalPatientNumber { get; set; }
        public string PatientType { get; set; }
        public string VisitType { get; set; }
        public string URNType { get; set; }
        public string URNNumber { get; set; }
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public decimal Amount { get; set; }
        public decimal Quantity { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal AmountReceived { get; set; }
        public decimal DueAmount { get; set; }
        public decimal AmtReceived { get; set; }
        public string ChequeorCardNumber { get; set; }
        public long ReferenceID { get; set; }
        public string PaymentName { get; set; }
        public long FinalBillID { get; set; }
        public long OrgID { get; set; }
        public string PaymentStatus { get; set; }
        public string ExternalVisitID { get; set; }
        public string BedWardInfo { get; set; }
        public string ClientCode { get; set; }
        public string PatientCategory { get; set; }
        public long LocationID { get; set; }
    }

    public class LISOrder
    {
        public long PatientID { get; set; }
        public string Salutation { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PatientAddress { get; set; }
        public string MobileNumber { get; set; }
        public string EMailID { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PinCode { get; set; }
        public string ClientName { get; set; }
        public string ClientCode { get; set; }
        public long RefPhysicianID { get; set; }
        public string RefPhysicianName { get; set; }
        public long HospitalID { get; set; }
        public string HospitalName { get; set; }
        public string ExternalPatientNumber { get; set; }
        public string PatientCategory { get; set; }
        public string VisitType { get; set; }
        public string URNType { get; set; }
        public string URNNumber { get; set; }
        public string BedWardInfo { get; set; }
        public decimal Quantity { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal AmountReceived { get; set; }
        public decimal DueAmount { get; set; }
        public string PaymentStatus { get; set; }
        public string ExternalVisitID { get; set; }
        public List<OrderDetails> lstOrderDetails { get; set; }
        public List<Payment> PaymentInfo { get; set; }
    }

    public class OrderDetails
    {
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public decimal Amount { get; set; }
    }

    public class PaymentIn
    {
        public long PatientID { get; set; }
        public decimal AmtReceived { get; set; }
        public string ChequeorCardNumber { get; set; }
        public long ReferenceID { get; set; }
        public string PaymentMode { get; set; }
    }

    public class Payment
    {
        public decimal AmtReceived { get; set; }
        public string ChequeorCardNumber { get; set; }
        public long ReferenceID { get; set; }
        public string PaymentMode { get; set; }
    }
}
