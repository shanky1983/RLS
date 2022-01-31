using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class OrderInformation
    {
      public string TestID { get; set; }
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public string TestStatus { get; set; }
        public string ResultCapturedAt { get; set; }

    }
}
