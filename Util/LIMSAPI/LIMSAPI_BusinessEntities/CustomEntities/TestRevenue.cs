using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{

    public class TestRevenue
    {       

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<TestRevenueDetails> TestRevenueDetails { get; set; }

    }

        public class TestRevenueDetails
    {
        public int OrgID { get; set; }
        public string OrgName { get; set; }
        public int pYear { get; set; }
        public int pMonth { get; set; }
        public string TestID { get; set; }
        public string TestName { get; set; }
        public decimal Amount { get; set; }
       
    }


    
}
