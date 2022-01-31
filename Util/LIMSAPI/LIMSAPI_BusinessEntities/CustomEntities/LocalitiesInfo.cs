using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class LocalitiesInfo
    {
        public long LocalityId { get; set; }
        public string LocalityCode { get; set; }
        public string LocalityValue { get; set; }
    }

    public class LocalityInfo
    {
        public long LocationID { get; set; }
        public string LocationName { get; set; }
        public string Status { get; set; }
    }
}
