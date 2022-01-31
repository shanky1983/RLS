using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
   public class ClientCreditDetails
    {
       public long BusinessType { get; set; }
       public string CSTNo { get; set; }
       public string ServiceTaxNo { get; set; }
       public string PANNo { get; set; }
       public string SAPCode { get; set; }
       public int CurrencyType { get; set; }
       public string PaymentCategory { get; set; }
       public string AllowServiceMapping { get; set; }
       public string InvoiceCycle { get; set; }
       public string CouponSystem { get; set; }
       public string InvoiceApprovalRequired { get; set; }
       public string AllowBillingDiscount { get; set; }
       public string ClientStatus { get; set; }
       public string Reason { get; set; }
       public string Action { get; set; }
       public DateTime FromDate { get; set; }
       public DateTime ToDate { get; set; }
       public decimal CreditLimit { get; set; }
       public long CreditDays { get; set; }
       public decimal GraceLimit { get; set; }
       public long GraceDays { get; set; }
       public string AdvanceThreshold { get; set; }
       public decimal Value { get; set; }
       public decimal MinimumDeposite { get; set; }
    }
}
