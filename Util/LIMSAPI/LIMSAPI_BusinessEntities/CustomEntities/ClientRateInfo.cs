using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class ClientRateInfo
    {
        public string ClientCode { get; set; }

        public string ClientName { get; set; }
        public string RateCardName { get; set; }
        public string RateCardCode { get; set; }
        public string TestName { get; set; }
        public string FeeType { get; set; }
        public long FeeID { get; set; }

        public decimal Rate { get; set; }

        public string RateCardType { get; set; }
        public string RateSubType { get; set; }
        public DateTime ValidaityFrom { get; set; }
        public DateTime ValidaityTo { get; set; }
        public string IsActive { get; set; }
        public int Priority { get; set; }

        public string RateComments { get; set; }

        public string LonicCode { get; set; }

        public string TestActive { get; set; }

        public string TestComments { get; set; }

        public string TestCode { get; set; }
        public string TestID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}