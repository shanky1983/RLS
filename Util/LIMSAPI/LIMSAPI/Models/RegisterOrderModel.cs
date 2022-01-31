using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIMSAPI.Models
{
    public class RegisterOrderModel
    {
        public long LoginID { get; set; }
        public string OrderID { get; set; }
        public string TransType { get; set; }
        public string SourceType { get; set; }
        public string MessageType { get; set; }
        public PatientModel PatientInfo { get; set; }
        public PatientVisitModel PatientVisitInfo { get; set; }
        public List<OrdersModel> TestDetailsList { get; set; }
        public BillingsModel BillingInfo { get; set; }
        public List<PaymentsModel> PaymentDetailsList { get; set; }
    }
    public class PatientModel
    {
        public long PatientID { get; set; }
        public string SalutationCode { get; set; }
    //    public string Name { get; set; }
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
   
        public List<AddressModel> AddressDetails { get; set; }
    }
    public class PatientVisitModel
    {
        public string PatientVisitId { get; set; }
        public string ExternalVisitNumber { get; set; }
        public string VisitType { get; set; }
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

    }
    public class BillingsModel
    {
       
     
      public string PaymentStatus { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal DueAmount { get; set; }
     
    }

    public class OrdersModel
    {
        			
		
			
        public string Status { get; set; }
        public string TestCode { get; set; }
        public string TestName { get; set; }
    
       public string IsStat { get; set; }
        public decimal Price { get; set; }
        public string TestClinicalHistory { get; set; }
        public string Instructions { get; set; }
        public string Remarks { get; set; }
  
      
    }
    public class PaymentsModel
    {
        public string PaymentType { get; set; }
      
        public string ReferenceNo { get; set; }
        public decimal AmountReceived { get; set; }
     
    
    
        public long CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public string CurrencyType { get; set; }

    }

}
