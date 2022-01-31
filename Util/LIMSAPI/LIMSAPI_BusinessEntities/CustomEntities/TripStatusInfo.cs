using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
   public class TripStatusInfo
    {
        public long BookingID { get; set; }
        public string LoginID { get; set; }
        public long OrgID { get; set; }
        public long LocationID { get; set; }
        public string TripStatus { get; set; }
        public string TripReason { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
