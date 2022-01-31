using System;

namespace LIMSAPI.Models
{
    public class PatientRegistrationModel
    {
        public long PatientID { get; set; }
        public string Age { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Salutation { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string MobileNumber { get; set; }
        public string URNType { get; set; }
        public string URNNo { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public int OrgID { get; set; }
        public long AddressID { get; set; }
        public string Source { get; set; }
        public string Status { get; set; }
        public string ClientID { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public long ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string ISProcessed { get; set; }
        public string Error { get; set; }
        public string Remarks { get; set; }
    }
}
