using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities 
{
   public  class PatientVisits
    {
        public string OrgCode { get; set; }
        public string OrgName { get; set; }
        public string PatientNumber { get; set; }
        public string PatientName { get; set; }
        public long PatientID { get; set; }
        public List<PatientVisit> lstVisitDetailInfo { get; set; }
    }
     
    public class PatientVisit
    {
        public string VisitNumber { get; set; }
        public string VisitDate { get; set; }
        public string LocationCode { get; set; }

        public string LocationName { get; set; }
        public string ClientName { get; set; }
        public string ClientCode { get; set; }
    }
    public class PatientVisitInfo
    {
        public string OrgCode { get; set; }

        public string OrgName { get; set; }
        public string PatientNumber { get; set; }
        public string PatientName { get; set; }
        public long PatientID { get; set; }

        public string VisitNumber { get; set; }
        public string VisitDate { get; set; }
        public string LocationCode { get; set; }
        public string LocationName { get; set; }
        public string ClientName { get; set; }
        public string ClientCode { get; set; }
    }
}
