using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class OrderStatusDetails:PatientBaseInfo
    {
        public List<OrderDetailsInfo> OrderInfo { get; set; }
    }
}