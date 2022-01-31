using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class OrdersData
    {
        public string TestName { get; set; }
        public long TestID { get; set; }
        public string TestType { get; set; }
        public string TestCode { get; set; }
        public decimal Price { get; set; }
        public List<TestContentData> TestContentInfoList { get; set; }
    }

    public class TestContentData
    {
        public long TestID { get; set; }
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public string Type { get; set; }
    }
}
