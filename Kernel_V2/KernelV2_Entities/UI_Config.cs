using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.KernelV2.Entities
{
    public class UI_Config
    {       
        public long ConfigID { get; set; }
        public string ConfigKey { get; set; }
        public string ConfigValue { get; set; }
        public int OrgID { get; set; }
        public long ParentID { get; set; }
    }
}
