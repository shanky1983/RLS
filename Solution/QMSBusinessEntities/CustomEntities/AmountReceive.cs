using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
    public class AmountReceive
    {
        #region Fields

        private string organizationName = String.Empty;
        private string patientName = String.Empty;
        private long  finalBillID = 0;
        private decimal grossBillValue = Decimal.Zero;
        private decimal discountAmount = Decimal.Zero;
        private decimal netValue = Decimal.Zero;
        private decimal amountReceived = Decimal.Zero;
        private decimal due = Decimal.Zero;
        private decimal amountRefund = Decimal.Zero;
        private DateTime createdAt=DateTime.MaxValue;
        #endregion

        #region Properties

        public string OrganizationName 
        {
            get { return organizationName; }
            set { organizationName = value; }
        }
        public string PatientName
        {
            get { return patientName; }
            set { patientName = value; }
        }
        public long FinalBillID
        {
            get { return finalBillID; }
            set { finalBillID = value; }
        }
        public decimal GrossBillValue
        {
            get { return grossBillValue; }
            set { grossBillValue = value; }
        }
        public decimal DiscountAmount
        {
            get { return discountAmount; }
            set { discountAmount = value; }
        }
        public decimal NetValue
        {
            get { return netValue; }
            set { netValue = value; }
        }
        public decimal AmountReceived
        {
            get { return amountReceived; }
            set { amountReceived = value; }
        }
        public decimal Due
        {
            get { return due; }
            set { due = value; }
        }
        public decimal AmountRefund
        {
            get { return amountRefund; }
            set { amountRefund = value; }
        }
        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }
        #endregion
    }
}