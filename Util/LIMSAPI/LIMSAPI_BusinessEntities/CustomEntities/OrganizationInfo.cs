using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class OrganizationInfo
    {
        public long OrgID { get; set; }
        public string ClientID { get; set; }
        public long LocationCode { get; set; }
        public string LocationName { get; set; }
        public string Status { get; set; }
        public string ProcessingLocation { get; set; }
    }
}
