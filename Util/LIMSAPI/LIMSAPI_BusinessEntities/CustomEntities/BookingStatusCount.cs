using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{

    public class BookingStatusCount
    {       

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<BookingStatusCountDetails> BookingStatusCountDetails { get; set; }

    }

        public class BookingStatusCountDetails
    {
        public int OrgID { get; set; }
        public string OrgName { get; set; }
        public int pYear { get; set; }
        public int pMonth { get; set; }
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public int LocID { get; set; }
        public string LocName { get; set; }
        public int BookingCount { get; set; }
       
    }


    
}
