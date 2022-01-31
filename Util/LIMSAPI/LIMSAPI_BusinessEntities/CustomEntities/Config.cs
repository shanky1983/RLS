using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class Config
    {

        public long ConfigID { get; set; }
        public string ConfigKey { get; set; }
        public string ConfigValue { get; set; }
        public int OrgID { get; set; }
        public long ParentID { get; set; }
    }
}
