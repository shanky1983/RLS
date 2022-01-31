using System.Collections.Generic;

namespace Attune.KernelV2.Entities
{
    public class UI_PaymentDetails
    {
        public List<UI_PaymentType> PaymentType { get; set; }
        public List<UI_OrgCurrency> Currency { get; set; }
    }

    public class UI_OrgCurrency
    {
        public int CurrencyID { get; set; }
        public decimal ConversionRate { get; set; }
        public string IsBaseCurrency { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
    }

    public class UI_PaymentType
    {
        public int PaymentTypeID { get; set; }
        public string PaymentName { get; set; }
        public long OrgID { get; set; }
        public string AllowEMI { get; set; }
        public string LanguageCode { get; set; }
        public string PaymentCode { get; set; }
        public string PayDetails { get; set; }
        public string CurrencyName { get; set; }
        public decimal OtherCurrencyAmount { get; set; }
        public decimal AmountUsed { get; set; }
        public string IsDefault { get; set; }
        public string PTypeIDIsRequired { get; set; }
        public string BaseCurrency { get; set; }
    }

    public class UI_Bank
    {
        public long BankID { get; set; }
        public string BankName { get; set; }
    }

    public class UI_Coupon
    {
        public int CouponID { get; set; }
        public string Name { get; set; }
        public string BatchNo { get; set; }
    }
}
