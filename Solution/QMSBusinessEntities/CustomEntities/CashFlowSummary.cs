using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class CashFlowSummary
    {

        #region Fields

        private long _BillingDetailsID = 0;
        private decimal _Amount = 0;
        private int _Quantity = 0;
        private string _VisitType = String.Empty;
        private DateTime _VisitDate = DateTime.MaxValue;
        private string _PatientName = String.Empty;
        private decimal _CommisionToOrg = 0;
        private decimal _AmountToHostingOrg = 0;
        private decimal _PhysicianAmount = 0;
        private string _PhysicianName = string.Empty;
        private long _PhysicianID = 0;
        private decimal _DiscountAmount = 0;
        private DateTime _CollectionDate = DateTime.MaxValue;
        private string _FeeType = String.Empty;
        private string _FeeDescription = String.Empty;
        private string  _IsCreditBill = String.Empty;
        private decimal _RefundAmount = 0;
        private string billNumber = string.Empty;
        private string interimBillNo = string.Empty;

        public string InterimBillNo
        {
            get { return interimBillNo; }
            set { interimBillNo = value; }
        }
        private string receiptNo = string.Empty;

        public string ReceiptNo
        {
            get { return receiptNo; }
            set { receiptNo = value; }
        }
        public string BillNumber
        {
            get { return billNumber; }
            set { billNumber = value; }
        }

        #endregion


        #region Properties
        public string IsCreditBill
        {
            get { return _IsCreditBill; }
            set { _IsCreditBill = value; }
        }

        public long BillingDetailsID
        {
            get { return _BillingDetailsID; }
            set { _BillingDetailsID = value; }
        }
        public decimal Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }
        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        public string VisitType
        {
            get { return _VisitType; }
            set { _VisitType = value; }
        }
        public DateTime VisitDate
        {
            get { return _VisitDate; }
            set { _VisitDate = value; }
        }
        public string PatientName
        {
            get { return _PatientName; }
            set { _PatientName = value; }
        }
        public decimal CommisionToOrg
        {
            get { return _CommisionToOrg; }
            set { _CommisionToOrg = value; }
        }
        public decimal AmountToHostingOrg
        {
            get { return _AmountToHostingOrg; }
            set { _AmountToHostingOrg = value; }
        }
        public decimal PhysicianAmount
        {
            get { return _PhysicianAmount; }
            set { _PhysicianAmount = value; }
        }
        public string PhysicianName
        {
            get { return _PhysicianName; }
            set { _PhysicianName = value; }
        }
        public long PhysicianID
        {
            get { return _PhysicianID; }
            set { _PhysicianID = value; }
        }
        public decimal DiscountAmount
        {
            get { return _DiscountAmount; }
            set { _DiscountAmount = value; }
        }
        public decimal RefundAmount
        {
            get { return _RefundAmount; }
            set { _RefundAmount = value; }
        }
        public DateTime CollectionDate
        {
            get { return _CollectionDate; }
            set { _CollectionDate = value; }
        }
        public string FeeType
        {
            get { return _FeeType; }
            set { _FeeType = value; }
        }
        public string FeeDescription
        {
            get { return _FeeDescription; }
            set { _FeeDescription = value; }
        }
        #endregion
    }
}

