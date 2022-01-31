using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class ClientBasicGridDetails
    {
        public String ClientCode { get; set; }
        public String PaymentCategory { get; set; }
        public String ClientTypeName { get; set; }
        public String ParentClientName { get; set; }
        public String DiscountMapped { get; set; }
        public String ClientNotify { get; set; }
        public String PrintLocation { get; set; }
        public String AccountHolder { get; set; }
        public String Status { get; set; }
    }
}
