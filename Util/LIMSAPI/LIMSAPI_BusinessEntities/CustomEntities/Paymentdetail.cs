using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BusinessEntities
{
    public class Paymentdetail
    {
        #region Fields
        private DateTime chequeValidDate = DateTime.MaxValue;
        private DateTime createdAt = DateTime.MaxValue;
        private DateTime modifiedAt = DateTime.MaxValue;
        #endregion

        #region Property
        public long BookingID { get; set; }
        public long FinalBillID { get; set; }
        public decimal ReceivedAmount { get; set; }
        public long ReceivedBy { get; set; }
        public string ClosureStatus { get; set; }
        public long OrgID { get; set; }
        public long TypeID { get; set; }
        public string ChequeorCardNumber { get; set; }
        public long BaseCurrencyID { get; set; }
        public long PaidCurrencyID { get; set; }
        public decimal OtherCurrencyAmount { get; set; }
        public long RoleID { get; set; }
        public long ReferenceID { get; set; }
        public string ReferenceType { get; set; }
        public long Units { get; set; }
        public string PaymentMode { get; set; }
        public string CurrencyType { get; set; }
        public string TransactionID { get; set; }
        public string CardHolderName { get; set; }
        public decimal CashGiven { get; set; }
        public decimal BalanceGiven { get; set; }
        public decimal RoundOffAmount { get; set; }

		public DateTime ChequeValidDate
        {
            get { return chequeValidDate; }
            set { chequeValidDate = value; }
        }
        public string AuthorisationCode { get; set; }
        public string Remarks { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }
        public long ModifiedBy { get; set; }
        
		public DateTime ModifiedAt
        {
            get { return modifiedAt; }
            set { modifiedAt = value; }
        }
        public string ExternalRefNo { get; set; }

        #endregion
    }
}
