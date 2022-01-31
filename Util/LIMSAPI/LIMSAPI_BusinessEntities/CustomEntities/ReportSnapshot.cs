using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class ReportSnapshot
    {
       
        public string AccessionNumber { get; set; }
        public byte[] Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public string HasChangedFolderPath { get; set; }
        public long ID { get; set; }
        public int NotificationID { get; set; }
        public long OrgAddressID { get; set; }
        public int OrgID { get; set; }
        public string ReportPath { get; set; }
        public int Seq_Num { get; set; }
        public string Status { get; set; }
        public string TemplateID { get; set; }
        public string Type { get; set; }
        public long VisitID { get; set; }
    }
}
