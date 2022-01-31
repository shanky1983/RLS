using System;
using System.Collections.Generic;

using System.Text;

namespace Attune.Podium.BusinessEntities.CustomEntities
{
    public class LedgerInvoiceDetails
    {

        #region fields
        private string clientCode = string.Empty;
        private string clientName = string.Empty;
        private long orgid = 0;
        private string invoiceNumber = string.Empty;
        private long invoiceId = 0;
        private long clientId = 0;
        private string billNumber = string.Empty;
        private long createdBy = 0;
        private DateTime createdAt = DateTime.MaxValue;
        private DateTime modifiedAt = DateTime.MaxValue;
        private long modifiedBy = 0;
        private DateTime invoiceDate = DateTime.MaxValue;
        private string fromDate = string.Empty;
        private string toDate = string.Empty;
        private decimal receivedAmt = 0;
        private string status = string.Empty;
        private decimal netValue = 0;
        private string contactPerson = string.Empty;
        private long creditID = 0;
        private DateTime creditDate = DateTime.MaxValue;
        private decimal creditLimit = 0;
        private string narration = string.Empty;
        private string remarks = string.Empty;
        private long debitID = 0;
        private DateTime debitDate = DateTime.MaxValue;
        private string address = string.Empty;
        private int total = 0;
        private DateTime billDate = DateTime.MaxValue;
        private decimal amount = 0;
        private long billId = 0;
        private string name = string.Empty;
        private string age = string.Empty;
        private string test = string.Empty;
        private string barcode = string.Empty;
        private long invoiceDetailsID = 0;
        private string paymentMode = string.Empty;
        private string currencyCode = string.Empty;
        private long advanceDetailID = 0;
        private string city = string.Empty;
        private string paymentType = string.Empty;
        private decimal m1Pending = 0;
        private decimal m2Pending = 0;
        private decimal m3Pending = 0;
        private decimal m4Pending = 0;
        private decimal totalPending = 0;
        private string totalAmount = string.Empty;
        private string cR = string.Empty;
        private string dR = string.Empty;
        private decimal discountPercentage = 0;
        private decimal discountAmount = 0;
        private decimal actualAmount = 0;
        private string description = string.Empty;
        private decimal totalAmt = 0;

        private decimal totalAdvanceAmount = 0;
        private decimal usedAdvanceAmount = 0;
        private decimal remainingAdvanceAmount = 0;
        private string isAdvanceUsed = string.Empty;
        private string isSucceedTransaction = string.Empty;


        # endregion

        #region properties
        public string ClientCode
        {
            get { return clientCode; }
            set { clientCode = value; }
        }
        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }
        public long OrgID
        {
            get { return orgid; }
            set { orgid = value; }
        }
        public string InvoiceNumber
        {
            get { return invoiceNumber; }
            set { invoiceNumber = value; }
        }
        public long InvoiceId
        {
            get { return invoiceId; }
            set { invoiceId = value; }
        }
        public long ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }
        public string BillNumber
        {
            get { return billNumber; }
            set { billNumber = value; }
        }
        public long CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }
        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }
        public long ModifiedBy
        {
            get { return modifiedBy; }
            set { modifiedBy = value; }
        }
        public DateTime ModifiedAt
        {
            get { return modifiedAt; }
            set { modifiedAt = value; }
        }
        public DateTime InvoiceDate
        {
            get { return invoiceDate; }
            set { invoiceDate = value; }
        }
        public string FromDate
        {
            get { return fromDate; }
            set { fromDate = value; }
        }
        public string ToDate
        {
            get { return toDate; }
            set { toDate = value; }
        }
        public decimal ReceivedAmt
        {
            get { return receivedAmt; }
            set { receivedAmt = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public decimal NetValue
        {
            get { return netValue; }
            set { netValue = value; }
        }
        public string ContactPerson
        {
            get { return contactPerson; }
            set { contactPerson = value; }
        }
        public decimal CreditLimit
        {
            get { return creditLimit; }
            set { creditLimit = value; }
        }
        public long CreditID
        {
            get { return creditID; }
            set { creditID = value; }
        }
        public DateTime CreditDate
        {
            get { return creditDate; }
            set { creditDate = value; }
        }
        public string Narration
        {
            get { return narration; }
            set { narration = value; }
        }
        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }
        public long DebitID
        {
            get { return debitID; }
            set { debitID = value; }
        }
        public DateTime DebitDate
        {
            get { return debitDate; }
            set { debitDate = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Total
        {
            get { return total; }
            set { total = value; }
        }
        public DateTime BillDate
        {
            get { return billDate; }
            set { billDate = value; }
        }
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public long BillId
        {
            get { return billId; }
            set { billId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Test
        {
            get { return test; }
            set { test = value; }
        }
        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }
        public long InvoiceDetailsID
        {
            get { return invoiceDetailsID; }
            set { invoiceDetailsID = value; }
        }
        public string PaymentMode
        {
            get { return paymentMode; }
            set { paymentMode = value; }
        }
        public string CurrencyCode
        {
            get { return currencyCode; }
            set { currencyCode = value; }
        }
        public long AdvanceDetailID
        {
            get { return advanceDetailID; }
            set { advanceDetailID = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }
        public decimal M1Pending
        {
            get { return m1Pending; }
            set { m1Pending = value; }
        }
        public decimal M2Pending
        {
            get { return m2Pending; }
            set { m2Pending = value; }
        }
        public decimal M3Pending
        {
            get { return m3Pending; }
            set { m3Pending = value; }
        }
        public decimal M4Pending
        {
            get { return m4Pending; }
            set { m4Pending = value; }
        }
        public decimal TotalPending
        {
            get { return totalPending; }
            set { totalPending = value; }
        }
        public string TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }
        public string CR
        {
            get { return cR; }
            set { cR = value; }
        }
        public string DR
        {
            get { return dR; }
            set { dR = value; }
        }
        public decimal DiscountPercentage
        {
            get { return discountPercentage; }
            set { discountPercentage = value; }
        }
        public decimal DiscountAmount
        {
            get { return discountAmount; }
            set { discountAmount = value; }
        }
        public decimal ActualAmount
        {
            get { return actualAmount; }
            set { actualAmount = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public decimal TotalAmt
        {
            get { return totalAmt; }
            set { totalAmt = value; }
        }
        public decimal TotalAdvanceAmount
        {
            get { return totalAdvanceAmount; }
            set { totalAdvanceAmount = value; }
        }
        public decimal UsedAdvanceAmount
        {
            get { return usedAdvanceAmount; }
            set { usedAdvanceAmount = value; }
        }
        public decimal RemainingAdvanceAmount
        {
            get { return remainingAdvanceAmount; }
            set { remainingAdvanceAmount = value; }
        }
        public string IsAdvanceUsed
        {
            get { return isAdvanceUsed; }
            set { isAdvanceUsed = value; }
        }
        public string IsSucceedTransaction
        {
            get { return isSucceedTransaction; }
            set { isSucceedTransaction = value; }
        }
        # endregion
    }
}
