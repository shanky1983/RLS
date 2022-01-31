using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class ReceivedAmount
    {
        #region Fields

        private string amtReceivedID = string.Empty;
        private string finalBillID = string.Empty;
        private decimal amtReceived = Decimal.Zero;
        private long receivedBy = 0;
        private string closureStatus = String.Empty;
        private int orgID = 0;
        private long createdBy = 0;
        private DateTime createdAt = DateTime.MaxValue;
        private long modifiedBy = 0;
        private DateTime modifiedAt = DateTime.MaxValue;


        private string descriptions = string.Empty;
        private int qty = 0;
        private decimal amount = Decimal.Zero;
        private DateTime billDate = DateTime.MaxValue;
        private string isCreditBill = "";
        private int sno = 0;
        private decimal cash = 0;
        private decimal card = 0;
        private decimal cheque = 0;
        private decimal dD = 0;
        private decimal upi = 0;
        private string billStatus = String.Empty;
        private decimal refundAmount = Decimal.Zero;

        private decimal discount = Decimal.Zero;
        private decimal billedAmount = Decimal.Zero;
        private string paidCurrency = String.Empty;
        private decimal paidCurrencyAmount = Decimal.Zero;
        private decimal depositUsed = Decimal.Zero;
        private decimal pendingSettlementAmt = Decimal.Zero;
        private DateTime amtbilldate = DateTime.MaxValue;
        private string visitnumber = string.Empty;
        private DateTime bookedDate = DateTime.MaxValue;
        private string bookedBy = String.Empty;
        private long bookingID = 0;
        private string city = String.Empty;
        private DateTime collectedDateTime = DateTime.MaxValue;
        private decimal grossBillValue = Decimal.Zero;
        private decimal discountAmt = Decimal.Zero;
        private decimal dueAmount = Decimal.Zero;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the BookedDate value.
        /// </summary>
        public DateTime BookedDate
        {
            get { return bookedDate; }
            set { bookedDate = value; }
        }
        /// <summary>
        /// Gets or sets the bookedBy value.
        /// </summary>
        public string BookedBy
        {
            get { return bookedBy; }
            set { bookedBy = value; }
        }
        /// <summary>
        /// Gets or sets the bookingID value.
        /// </summary>
        public long BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }
        /// <summary>
        /// Gets or sets the cityName value.
        /// </summary>
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        /// <summary>
        /// Gets or sets the AmtReceived value.
        /// </summary>
        public decimal GrossBillValue
        {
            get { return grossBillValue; }
            set { grossBillValue = value; }
        }
        /// <summary>
        /// Gets or sets the DiscountAmt value.
        /// </summary>
        public decimal DiscountAmt
        {
            get { return discountAmt; }
            set { discountAmt = value; }
        }
        /// <summary>
        /// Gets or sets the DueAmount value.
        /// </summary>
        public decimal DueAmount
        {
            get { return dueAmount; }
            set { dueAmount = value; }
        }

        /// <summary>
        /// Gets or sets the CollectedDateTime value.
        /// </summary>
        public DateTime CollectedDateTime
        {
            get { return collectedDateTime; }
            set { collectedDateTime = value; }
        }

        /// <summary>
        /// Gets or sets the AmtReceivedID value.
        /// </summary>
        public string AmtReceivedID
        {
            get { return amtReceivedID; }
            set { amtReceivedID = value; }
        }

        /// <summary>
        /// Gets or sets the FinalBillID value.
        /// </summary>
        public string FinalBillID
        {
            get { return finalBillID; }
            set { finalBillID = value; }
        }

        /// <summary>
        /// Gets or sets the AmtReceived value.
        /// </summary>
        public decimal AmtReceived
        {
            get { return amtReceived; }
            set { amtReceived = value; }
        }

        /// <summary>
        /// Gets or sets the ReceivedBy value.
        /// </summary>
        public long ReceivedBy
        {
            get { return receivedBy; }
            set { receivedBy = value; }
        }

        /// <summary>
        /// Gets or sets the ClosureStatus value.
        /// </summary>
        public string ClosureStatus
        {
            get { return closureStatus; }
            set { closureStatus = value; }
        }

        /// <summary>
        /// Gets or sets the OrgID value.
        /// </summary>
        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }

        /// <summary>
        /// Gets or sets the CreatedBy value.
        /// </summary>
        public long CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }

        /// <summary>
        /// Gets or sets the CreatedAt value.
        /// </summary>
        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        /// <summary>
        /// Gets or sets the ModifiedBy value.
        /// </summary>
        public long ModifiedBy
        {
            get { return modifiedBy; }
            set { modifiedBy = value; }
        }

        /// <summary>
        /// Gets or sets the ModifiedAt value.
        /// </summary>
        public DateTime ModifiedAt
        {
            get { return modifiedAt; }
            set { modifiedAt = value; }
        }

        /// <summary>
        /// Gets or sets the PatientName value.
        /// </summary>
        string _patientname;
        public string PatientName
        {
            get { return _patientname; }
            set { _patientname = value; }
        }

        /// <summary>
        /// Gets or sets the Descriptions value.
        /// </summary>
        public string Descriptions
        {
            get { return descriptions; }
            set { descriptions = value; }
        }

        /// <summary>
        /// Gets or sets the Qty value.
        /// </summary>
        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        /// <summary>
        /// Gets or sets the BillDate value.
        /// </summary>
        public DateTime BillDate
        {
            get { return billDate; }
            set { billDate = value; }
        }

        /// <summary>
        /// Gets or sets the TotalAmount value.
        /// </summary>
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string IsCreditBill
        {
            get { return isCreditBill; }
            set { isCreditBill = value; }
        }

        public int Sno
        {
            get { return sno; }
            set { sno = value; }
        }

        public decimal Cash
        {
            get { return cash; }
            set { cash = value; }
        }
        public decimal Card
        {
            get { return card; }
            set { card = value; }
        }
        public decimal Cheque
        {
            get { return cheque; }
            set { cheque = value; }
        }
        public decimal DD
        {
            get { return dD; }
            set { dD = value; }
        }
        public decimal UPI
        {
            get { return upi; }
            set { upi = value; }
        }
        /// <summary>
        /// Gets or sets the BillStatus value.
        /// </summary>
        public string BillStatus
        {
            get { return billStatus; }
            set { billStatus = value; }
        }
        public string PaidCurrency
        {
            get { return paidCurrency; }
            set { paidCurrency = value; }
        }
        public decimal PaidCurrencyAmount
        {
            get { return paidCurrencyAmount; }
            set { paidCurrencyAmount = value; }
        }
        public decimal DepositUsed
        {
            get { return depositUsed; }
            set { depositUsed = value; }
        }
        public decimal RefundAmount
        {
            get { return refundAmount; }
            set { refundAmount = value; }
        }

        public decimal Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        public decimal BilledAmount
        {
            get { return billedAmount; }
            set { billedAmount = value; }
        }
        public string BillNumber
        {
            get;
            set;
        }
        public string ReceiptNO
        {
            get;
            set;
        }
        public long DetailsID
        {
            get;
            set;
        }
        public int VisitType
        {
            get;
            set;
        }
        public long VisitID
        {
            get;
            set;
        }
        public string FeeType
        {
            get;
            set;
        }

        public decimal PendingSettlementAmt
        {
            get { return pendingSettlementAmt; }
            set { pendingSettlementAmt = value; }
        }

        public DateTime AMTBillDate
        {
            get { return amtbilldate; }
            set { amtbilldate = value; }
        }

        public string VisitNumber
        {
            get { return visitnumber; }
            set { visitnumber = value; }
        }


        #endregion
        public string Name { get; set; }
    }
}
