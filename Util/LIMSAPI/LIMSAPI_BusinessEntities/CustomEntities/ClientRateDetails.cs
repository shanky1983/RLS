using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class ClientRateDetails : Paging
    {
        public string OrgCode { get; set; }
        public List<ClientListRate> ClientRateListInfo { get; set; }




    }
    public class ClientMasterInfo
    {
        public ClientListRate ClientRateInfo { get; set; }
    }

    public class ClientListRate
    {
        public string ClientCode { get; set; }

        public string ClientName { get; set; }
        public List<RateCardDetails> RateCardDetails { get; set; }
    }


}
