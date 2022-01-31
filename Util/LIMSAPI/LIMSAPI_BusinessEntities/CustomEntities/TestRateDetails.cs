using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
   public class TestRateDetails
    {
        public string TestCode { get; set; }
        public string LonicCode { get; set; }

        public string TestName { get; set; }

        public string TestID { get; set;}
        public string FeeType { get; set; }
       

        public decimal Rate { get; set; }


        public string IsActive { get; set; }

        public string Comments { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
