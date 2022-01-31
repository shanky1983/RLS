using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class LocalityData: Paging
    {
        public string OrgCode { get; set; }
        public string Type { get; set; }
        public List<LocalityInfo> Locality { get; set; }
    }
}
