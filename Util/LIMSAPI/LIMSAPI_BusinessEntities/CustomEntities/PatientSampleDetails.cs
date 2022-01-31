using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class PatientSampleDetails
    {
     

        public string CodeName { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public string EmailReportStatus { get; set; }
        public long ID { get; set; }
        public string LabNo { get; set; }
        public string MasterProcessingLocation { get; set; }
        public string OrderName { get; set; }
        public string OrderType { get; set; }
        public string PatientName { get; set; }
        public string RegisterLocation { get; set; }
        public string SampleContainerName { get; set; }
        public string SampleID { get; set; }
        public string Status { get; set; }
        public string TransactionalProcessingLocation { get; set; }
        public DateTime TransDateTime { get; set; }
        public string UserName { get; set; }
        public string VisitNumber { get; set; }
    }
}
