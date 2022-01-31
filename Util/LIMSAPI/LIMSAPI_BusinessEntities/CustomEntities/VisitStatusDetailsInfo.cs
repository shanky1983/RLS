using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class VisitStatusDetailsInfo
    {
        public string OrgCode { get; set; }
        public long OrgID { get; set; }
        public long LocationID { get; set; }
        public string Type { get; set; }
        public long PatientID { get; set; }
        public string VisitNumber { get; set; }
        public string ExternalPatientID { get; set; }
        public List<VisitStatus> OrderInfo { get; set; }
    }
}
