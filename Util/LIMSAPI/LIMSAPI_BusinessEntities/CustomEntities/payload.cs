using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
  public  class payload
    {
          

       public long company_id { get;  set;}
        public account_information account_information { get; set; }
        public corp_sales corp_sales { get; set; }
        public medical_sales medical_sales { get; set; }
        public sales_operation sales_operation { get; set; }
        public List<contact_information> contact_information { get; set; }

        }
}
