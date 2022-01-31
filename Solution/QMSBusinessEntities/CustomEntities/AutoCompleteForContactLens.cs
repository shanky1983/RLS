using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class AutoCompleteForContactLens
    {
        public long Id { get; set; }
        public string DisplayText { get; set; }
        public long AttributeID { get; set; }
        public decimal Amount { get; set; }
        public long ServiceID { get; set; }
        public string ServiceCode { get; set; }
        public string ServiceType { get; set; }
        public decimal Discount { get; set; }
        public string DiscountType { get; set; }
        public long Quantity { get; set; }
        public decimal Cost { get; set; }
        public decimal CoPayment { get; set; }
        public string CoPaymentType { get; set; }
        public decimal Deductable { get; set; }
       
    }
}
