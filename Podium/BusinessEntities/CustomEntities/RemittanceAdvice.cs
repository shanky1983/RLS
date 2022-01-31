using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class RemittanceAdvice
	{
        #region Fields

        private long clientInvoiceID = 0;
        private int orgID = 0;
        private long clientID = 0;
        private string senderCode = String.Empty;
        private string receiverCode = String.Empty;
        private string claimID = String.Empty;
        private string iDPayer = String.Empty;
        private string billingDetailsID = String.Empty;
        private decimal paymentAmount = Decimal.Zero;
        private int baseCurrencyID = 0;
        private int paidCurrencyID = 0;
        private decimal baseCurrencyAmount = Decimal.Zero;
        private decimal paidCurrencyAmount = Decimal.Zero;
        private int paymentTypeID = 0;
        private string bankCadeName = String.Empty;
        private string caequeCardNo = String.Empty;
        private string denialCode = String.Empty;
        private string startDate = String.Empty;
        private string endDate = String.Empty;

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the ClientInvoiceID value.
        /// </summary>
        public long ClientInvoiceID
        {
            get { return clientInvoiceID; }
            set { clientInvoiceID = value; }
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
        /// Gets or sets the ClientID value.
        /// </summary>
        public long ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        /// <summary>
        /// Gets or sets the SenderCode value.
        /// </summary>
        public string SenderCode
        {
            get { return senderCode; }
            set { senderCode = value; }
        }

        /// <summary>
        /// Gets or sets the ReceiverCode value.
        /// </summary>
        public string ReceiverCode
        {
            get { return receiverCode; }
            set { receiverCode = value; }
        }

        /// <summary>
        /// Gets or sets the ClaimID value.
        /// </summary>
        public string ClaimID
        {
            get { return claimID; }
            set { claimID = value; }
        }

        /// <summary>
        /// Gets or sets the IDPayer value.
        /// </summary>
        public string IDPayer
        {
            get { return iDPayer; }
            set { iDPayer = value; }
        }

        /// <summary>
        /// Gets or sets the BillingDetailsID value.
        /// </summary>
        public string BillingDetailsID
        {
            get { return billingDetailsID; }
            set { billingDetailsID = value; }
        }

        /// <summary>
        /// Gets or sets the PaymentAmount value.
        /// </summary>
        public decimal PaymentAmount
        {
            get { return paymentAmount; }
            set { paymentAmount = value; }
        }

        /// <summary>
        /// Gets or sets the BaseCurrencyID value.
        /// </summary>
        public int BaseCurrencyID
        {
            get { return baseCurrencyID; }
            set { baseCurrencyID = value; }
        }

        /// <summary>
        /// Gets or sets the PaidCurrencyID value.
        /// </summary>
        public int PaidCurrencyID
        {
            get { return paidCurrencyID; }
            set { paidCurrencyID = value; }
        }

        /// <summary>
        /// Gets or sets the BaseCurrencyAmount value.
        /// </summary>
        public decimal BaseCurrencyAmount
        {
            get { return baseCurrencyAmount; }
            set { baseCurrencyAmount = value; }
        }

        /// <summary>
        /// Gets or sets the PaidCurrencyAmount value.
        /// </summary>
        public decimal PaidCurrencyAmount
        {
            get { return paidCurrencyAmount; }
            set { paidCurrencyAmount = value; }
        }

        /// <summary>
        /// Gets or sets the PaymentTypeID value.
        /// </summary>
        public int PaymentTypeID
        {
            get { return paymentTypeID; }
            set { paymentTypeID = value; }
        }

        /// <summary>
        /// Gets or sets the BankCadeName value.
        /// </summary>
        public string BankCadeName
        {
            get { return bankCadeName; }
            set { bankCadeName = value; }
        }

        /// <summary>
        /// Gets or sets the CaequeCardNo value.
        /// </summary>
        public string CaequeCardNo
        {
            get { return caequeCardNo; }
            set { caequeCardNo = value; }
        }

        /// <summary>
        /// Gets or sets the DenialCode value.
        /// </summary>
        public string DenialCode
        {
            get { return denialCode; }
            set { denialCode = value; }
        }

        /// <summary>
        /// Gets or sets the StartDate value.
        /// </summary>
        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        /// <summary>
        /// Gets or sets the EndDate value.
        /// </summary>
        public string EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }


        #endregion
}
}
