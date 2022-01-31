using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class contact_information
    {
       public string name { get; set; }
       public long id { get; set; }
       public string title { get; set; }
       public string contact_type { get; set; }
        public List<string> work_email { get; set; }
        public List<string> work_phone { get; set; }

    }
    }
