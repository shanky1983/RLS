using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class TestMasterInfo
    {
        public string TestCode { get; set; }
        public string Display{ get; set; }
        public string DisplayText { get; set; }
        public long InvestigationID { get; set; }
        public long DeptID { get; set; }
         public string Type { get; set; }
    }
}
