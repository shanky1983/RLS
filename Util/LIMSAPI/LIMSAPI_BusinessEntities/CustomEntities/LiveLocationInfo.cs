using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class LiveLocationInfo
    {
        public long LoginID { get; set; }
        public DateTime TransactionDate { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public long ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string ISProcessed { get; set; }
        public string Error { get; set; }
        public string Remarks { get; set; }
    }
}
