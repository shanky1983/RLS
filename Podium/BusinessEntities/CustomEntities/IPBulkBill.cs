using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class IPBulkBill
    {
        public string ServiceCode { get; set; }
        public string FeeDesc { get; set; }
        public string FeeType { get; set; }
        public decimal Rate { get; set; }
        public long Qty { get; set; }
        public decimal Amount { get; set; }
        public decimal GrandTotal { get; set; }
        public string PatientName { get; set; }
        public decimal RoundOff { get; set; }
        public string IsReimbursable { get; set; }
    }
}
