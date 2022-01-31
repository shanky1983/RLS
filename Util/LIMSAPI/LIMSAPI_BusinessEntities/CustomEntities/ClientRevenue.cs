using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{

    public class ClientRevenue
    {       

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<ClientRevenueDetails> ClientRevenueDetails { get; set; }

    }

        public class ClientRevenueDetails
    {
        public int OrgID { get; set; }
        public string OrgName { get; set; }
        public int pYear { get; set; }
        public int pMonth { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public decimal Amount { get; set; }
       
    }


    
}
