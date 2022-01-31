using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class VisitInfo
    {
        public long BookingID { get; set; }
        public DateTime VisitDate { get; set; }
        public string VisitNumber { get; set; }
        public string OrgCode { get; set; }
        public int OrgLocationCode { get; set; }

    }

    public class VisitDetails
    {
        public string OrgCode { get; set; }
        public string Type { get; set; }
        public DateTime VisitDate { get; set; }
        public string VisitNumber { get; set; }
        public int LocationID { get; set; }

    }
}
