using Attune.Kernel.LIMSAPI.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities{
    public class InfectionTestResultData : Paged
    {
        public string OrgCode { get; set; }
        public long OrgID { get; set; }
        public long LocationID { get; set; }
        public string ClientID { get; set; }
        public string PatientID { get; set; }
        public string TitleName { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateofBrith { get; set; }
        public string EMailID { get; set; }
        public string Age { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public long ClientCode { get; set; }
        public string ClientName { get; set; }
        public string PhysicianName { get; set; }
        public string PhysicianCode { get; set; }
        public string Hospitalname { get; set; }
        public string HospitalCode { get; set; }
        public string ExternalPatientNumber { get; set; }
        public string Patientcategory { get; set; }
        public string VisitType { get; set; }
        public string BedWardInfo { get; set; }
        public string URNType { get; set; }
        public string URNNo { get; set; }
        public List<OrderInfo> OrderInfo { get; set; }

    }
}
