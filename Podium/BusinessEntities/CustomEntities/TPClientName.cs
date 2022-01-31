using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class TPClientName
    {
        public InvClientMaster lstClientName { get; set; }
        public List<InvClientMaster> lstRateMaster { get; set; }
    }
}
