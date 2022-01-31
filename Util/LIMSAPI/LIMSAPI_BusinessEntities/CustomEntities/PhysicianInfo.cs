using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
   public class PhysicianInfo
    {
        public int UserId { get; set; }
        public long OrgID { get; set; }
        public long LocationID { get; set; }
        public string Salutation { get; set; }
        public string PhysicianName { get; set; }
        public string PhysicianCode { get; set; }
        public string MobileNo { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string Email { get; set; }
        public string Qualification { get; set; }
        public string PortalAccess { get; set; }
        public string IsClient { get; set; }
        public string ContactPersonType { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactPersonMobileNumber { get; set; }
        public string ContactPersonEmailID { get; set; }
        public string Status { get; set; }
        public Boolean HasReportingEmail { get; set; }
        public Boolean HasReportingSms { get; set; }

    }

    public class PhysicianDetailInfo
    {
        public int UserId { get; set; }
        public string Salutation { get; set; }
        public string PhysicianName { get; set; }
        public string PhysicianCode { get; set; }
        public string MobileNo { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string Email { get; set; }
        public string Qualification { get; set; }
        public string PortalAccess { get; set; }
        public string IsClient { get; set; }
        public string ContactPersonType { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactPersonMobileNumber { get; set; }
        public string ContactPersonEmailID { get; set; }
        public string Status { get; set; }
        public string HasReportingEmail { get; set; }
        public string HasReportingSms { get; set; }
    }
}
