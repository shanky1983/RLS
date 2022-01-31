using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class OrderStatusInfo
    {
      public string OrderID { get; set; }
      public string OrgCode { get; set; }

      public List<OrderInformation> OrderInfo { get; set; }

    }
}
    