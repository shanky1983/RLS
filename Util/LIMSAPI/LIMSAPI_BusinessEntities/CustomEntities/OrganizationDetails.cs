using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class OrganizationDetails
    {
        public long OrgID { get; set; }
        public string Type { get; set; }
        public string ClientID { get; set; }
        public List<OrgLocations> LocationInfo { get; set; }

    }
}
