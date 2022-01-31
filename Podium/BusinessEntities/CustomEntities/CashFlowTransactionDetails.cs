using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class CashFlowTransactions
    {
        public long CashFlowTransactionID { get; set; }
        public long CashFlowID { get; set; }
        public long ReferenceID { get; set; }
        public string ReferenceType { get; set; }
        public string InvoiceNo { get; set; }
        public decimal AmountPaid { get; set; }

    }
}
