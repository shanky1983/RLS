using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class OrderDetailsResult
    {
      
        public string MessageType { get; set; }
        public string OrgCode { get; set; }      
        public VNResPatientDetails PatientInfo { get; set; }
        public VNPatientVisitDetails PatientVisitInfo { get; set; }     
        public List<VNTestOrder> TestDetailsList { get; set; }
        //public byte[] ResultAsPdf { get; set; }
        //public byte[] OutsourceAsPdf { get; set; }
    }
    public class VNPatientDetails
    {
        public string PatientID { get; set; }
        public string PatientNumber { get; set; }
        public string SalutationCode { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string DOB { get; set; }
        public string MobileNumber { get; set; }
        public string EmailID { get; set; }
        public string URNType { get; set; }
        public string URNNumber { get; set; }

        public string Address { get; set; }
        public string AddressType { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string StateID { get; set; }
        public string CountryID { get; set; }
        public string ExternalPatientNumber { get; set; }
        public List<VNAddressDetails> AddressDetails { get; set; }
    }

    public class VNResPatientDetails
    {
        public string PatientID { get; set; }
        public string PatientNumber { get; set; }
        public string SalutationCode { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string DOB { get; set; }
        public string MobileNumber { get; set; }
        public string EmailID { get; set; }
        public string URNType { get; set; }
        public string URNNumber { get; set; }
       
        public List<VNAddressDetails> AddressDetails { get; set; }
    }
    public class VNPatientVisitDetails
    {
        public string PatientVisitId { get; set; }
        public string ExternalVisitNumber { get; set; }
        public string VisitType { get; set; }
        public string VisitDate { get; set; }    
        public string ClientID { get; set; }
        public string ClientCode { get; set; }
        public string ClientName { get; set; }
        public string ReferingDoctorCode { get; set; }
        public string ReferingDoctorName { get; set; }
        public string ReferingDoctorMobileNumber { get; set; }       
        public string RegisterLocation { get; set; }
       
    }   
    public class VNAddressDetails
    {
        public string Address { get; set; }
        public string AddressType { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string StateID { get; set; }
        public string CountryID { get; set; }
        public string ExternalPatientNumber { get; set; }
    }
    public class VNTestOrder
    {       
        public string TestID { get; set; }
        public string TestCode { get; set; }      
        public string TestName { get; set; }       
        public string Status { get; set; }
        public string Remarks { get; set; }
       
    }
   
 

}
