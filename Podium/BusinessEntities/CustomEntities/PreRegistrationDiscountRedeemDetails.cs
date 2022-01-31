using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class PreRegistrationDiscountRedeemDetails
    {
        public long FinalBillID{get;set;}
        public decimal GrossBillValue { get; set; }
        public decimal NetValue { get; set; }
        public decimal AmountReceived { get; set; }
        public decimal Due { get; set; }
        public long DiscountID { get; set; }
        public string DiscountCode { get; set; }
        public string DiscountName { get; set; }
        public string DiscountType { get; set; }
        public decimal DiscountCeilingValue { get; set; }
        public decimal UserDiscountValue { get; set; }
        public decimal SlabCeilingValue { get; set; }
        public decimal SlabPercentage { get; set; }
        public string Reason { get; set; }
        public long ReasonID { get; set; }
        public decimal ServiceCharge { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal EDCess { get; set; }
        public decimal SHEDCess { get; set; }
        public decimal RoundOff { get; set; }
        public string DiscountReason { get; set; }
        public string HealthCardNos { get; set; }

    }
}
