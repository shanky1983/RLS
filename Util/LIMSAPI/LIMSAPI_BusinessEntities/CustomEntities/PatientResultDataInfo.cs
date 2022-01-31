using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class PatientResultDataInfo 
    {
        public string OrgCode { get; set; }
        public long OrgID { get; set; }
        public long LocationID { get; set; }
        public string Type { get; set; }
        public long PatientID { get; set; }
        public string VisitNumber { get; set; }
        public string ExternalPatientNumber { get; set; }
        public List<PatientResultDetails> OrderInfo { get; set; }
    }
}
