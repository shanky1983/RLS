using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class VisitstatusInfo
    {
        public long OrgID { get; set; }
        public string Type { get; set; }
        public long PatientID { get; set; }
        public string VisitNumber { get; set; }
        public string ExternalPatientID { get; set; }
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public string Status { get; set; }
        public long LocationID { get; set; }
    }
}
