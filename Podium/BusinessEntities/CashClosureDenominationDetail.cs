using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class CashClosureDenominationDetail
    {
        #region Fields
        private long cashClosureDenoID = 0;
        private long closureID = 0;
        private long userID = 0;
        private int orgID = 0;
        private int denoId = 0;
        private int currencyCount = 0;
        private decimal sumValueCurrencyCount = Decimal.Zero;
        private DateTime settleDate = DateTime.MaxValue;
        private string cashStatus = String.Empty;
        private decimal cashDeposited = Decimal.Zero;
        private decimal cashRegister = Decimal.Zero;
        private decimal cashDifference = Decimal.Zero;
        private decimal cashCounted = Decimal.Zero;
        private decimal cashExpected = Decimal.Zero;
        private long createdBy = 0;
        private DateTime createdAt = DateTime.MaxValue;
        private long modifiedBy = 0;
        private DateTime modifiedAt = DateTime.MaxValue;
        private long finalBillID = 0;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the CCDenoID value.
        /// </summary>
        public long CashClosureDenoID
        {
            get { return cashClosureDenoID; }
            set { cashClosureDenoID = value; }
        }


        public long ClosureID
        {
            get { return closureID; }
            set { closureID = value; }
        }
        public long UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public int OrgID
        {
            get { return orgID; }
            set { orgID = value; }
        }
        public int DenoId
        {
            get { return denoId; }
            set { denoId = value; }
        }
        public int CurrencyCount
        {
            get { return currencyCount; }
            set { currencyCount = value; }
        }
        public decimal SumValueCurrencyCount
        {
            get { return sumValueCurrencyCount; }
            set { sumValueCurrencyCount = value; }
        }
        public DateTime SettleDate
        {
            get { return settleDate; }
            set { settleDate = value; }
        }
        public string CashStatus
        {
            get { return cashStatus; }
            set { cashStatus = value; }
        }

        public decimal CashDeposited
        {
            get { return cashDeposited; }
            set { cashDeposited = value; }
        }

        public decimal CashRegister
        {
            get { return cashRegister; }
            set { cashRegister = value; }
        }

        public decimal CashDifference
        {
            get { return cashDifference; }
            set { cashDifference = value; }
        }

        public decimal CashCounted
        {
            get { return cashCounted; }
            set { cashCounted = value; }
        }

        public decimal CashExpected
        {
            get { return cashExpected; }
            set { cashExpected = value; }
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
        public long FinalBillID
        {
            get { return finalBillID; }
            set { finalBillID = value; }
        }
        #endregion
    }
    
}
