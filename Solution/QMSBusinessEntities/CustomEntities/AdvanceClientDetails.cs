using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class AdvanceClientDetails
    {

        private long clientID = 0;

        public long ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        private long sno = 0;

        public long Sno
        {
            get { return sno; }
            set { sno = value; }
        }
        string clientCode = String.Empty;

        public string ClientCode
        {
            get { return clientCode; }
            set { clientCode = value; }
        }
        string clientName = String.Empty;

        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }
        string type = String.Empty;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string fromdate = string.Empty;

        public string Fromdate
        {
            get { return fromdate; }
            set { fromdate = value; }
        }
        public string toDate = string.Empty;

        public string ToDate
        {
            get { return toDate; }
            set { toDate = value; }
        }
        public DateTime depositedDate = DateTime.MaxValue;

        public DateTime DepositedDate
        {
            get { return depositedDate; }
            set { depositedDate = value; }
        }
        public string paymentType = String.Empty;

        public string PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }
        public Decimal amountDeposited = Decimal.Zero;

        public Decimal AmountDeposited
        {
            get { return amountDeposited; }
            set { amountDeposited = value; }
        }

        public Decimal refundAmount = Decimal.Zero;

        public Decimal RefundAmount
        {
            get { return refundAmount; }
            set { refundAmount = value; }
        }

        public string receiptNo = String.Empty;

        public string ReceiptNo
        {
            get { return receiptNo; }
            set { receiptNo = value; }
        }
        public DateTime visitDate = DateTime.MaxValue;

        public DateTime VisitDate
        {
            get { return visitDate; }
            set { visitDate = value; }
        }

        public string visitNumber = string.Empty;

        public string VisitNumber
        {
            get { return visitNumber; }
            set { visitNumber = value; }
        }

        public string name = string.Empty;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string billNumber = string.Empty;

        public string BillNumber
        {
            get { return billNumber; }
            set { billNumber = value; }
        }

        public Decimal amount = Decimal.Zero;

        public Decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        private string collectedBy = String.Empty;

        public string CollectedBy
        {
            get { return collectedBy; }
            set { collectedBy = value; }
        }
        private string refundedBy = String.Empty;

        public string RefundedBy
        {
            get { return refundedBy; }
            set { refundedBy = value; }
        }
        private string location = String.Empty;

        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        private int totalRows = 0;

        public int TotalRows
        {
            get { return totalRows; }
            set { totalRows = value; }
        }
    }
}
