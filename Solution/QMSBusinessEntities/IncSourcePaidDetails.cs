using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class IncSourcePaidDetails
	{
		#region Fields

		private long paidDetailsID=0;
		private long sourceTypeID=0;
		private string referenceID=String.Empty;
		private decimal amountReceived=Decimal.Zero;
		private int receivedCurrencyID=0;
		private decimal receivedCurrencyvalue=Decimal.Zero;
		private int baseCurrencyID=0;
		private int receivedTypeID=0;
		private string modeOFPayment=String.Empty;
		private string chequeNo=String.Empty;
		private string bankName=String.Empty;
		private string description=String.Empty;
		private int orgID=0;
		private long createdBY=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string status=String.Empty;
		private string receiptNo=String.Empty;
		private string voucherNo=String.Empty;
		private string cardHolderName=String.Empty;
		private decimal cashGiven=Decimal.Zero;
		private decimal balanceGiven=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PaidDetailsID value.
		/// </summary>
		public long PaidDetailsID
		{
			get { return paidDetailsID; }
			set { paidDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the SourceTypeID value.
		/// </summary>
		public long SourceTypeID
		{
			get { return sourceTypeID; }
			set { sourceTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceID value.
		/// </summary>
		public string ReferenceID
		{
			get { return referenceID; }
			set { referenceID = value; }
		}

		/// <summary>
		/// Gets or sets the AmountReceived value.
		/// </summary>
		public decimal AmountReceived
		{
			get { return amountReceived; }
			set { amountReceived = value; }
		}

		/// <summary>
		/// Gets or sets the ReceivedCurrencyID value.
		/// </summary>
		public int ReceivedCurrencyID
		{
			get { return receivedCurrencyID; }
			set { receivedCurrencyID = value; }
		}

		/// <summary>
		/// Gets or sets the ReceivedCurrencyvalue value.
		/// </summary>
		public decimal ReceivedCurrencyvalue
		{
			get { return receivedCurrencyvalue; }
			set { receivedCurrencyvalue = value; }
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
		/// Gets or sets the ReceivedTypeID value.
		/// </summary>
		public int ReceivedTypeID
		{
			get { return receivedTypeID; }
			set { receivedTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the ModeOFPayment value.
		/// </summary>
		public string ModeOFPayment
		{
			get { return modeOFPayment; }
			set { modeOFPayment = value; }
		}

		/// <summary>
		/// Gets or sets the ChequeNo value.
		/// </summary>
		public string ChequeNo
		{
			get { return chequeNo; }
			set { chequeNo = value; }
		}

		/// <summary>
		/// Gets or sets the BankName value.
		/// </summary>
		public string BankName
		{
			get { return bankName; }
			set { bankName = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
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
		/// Gets or sets the CreatedBY value.
		/// </summary>
		public long CreatedBY
		{
			get { return createdBY; }
			set { createdBY = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiptNo value.
		/// </summary>
		public string ReceiptNo
		{
			get { return receiptNo; }
			set { receiptNo = value; }
		}

		/// <summary>
		/// Gets or sets the VoucherNo value.
		/// </summary>
		public string VoucherNo
		{
			get { return voucherNo; }
			set { voucherNo = value; }
		}

		/// <summary>
		/// Gets or sets the CardHolderName value.
		/// </summary>
		public string CardHolderName
		{
			get { return cardHolderName; }
			set { cardHolderName = value; }
		}

		/// <summary>
		/// Gets or sets the CashGiven value.
		/// </summary>
		public decimal CashGiven
		{
			get { return cashGiven; }
			set { cashGiven = value; }
		}

		/// <summary>
		/// Gets or sets the BalanceGiven value.
		/// </summary>
		public decimal BalanceGiven
		{
			get { return balanceGiven; }
			set { balanceGiven = value; }
		}

		/// <summary>
		/// Gets or sets the CurrencyName value.
		/// </summary>
		string _currencyname;
		public string CurrencyName
		{
			get { return _currencyname; }
			set { _currencyname = value; }
		}

		/// <summary>
		/// Gets or sets the SourceType value.
		/// </summary>
		string _sourcetype;
		public string SourceType
		{
			get { return _sourcetype; }
			set { _sourcetype = value; }
		}

		/// <summary>
		/// Gets or sets the SourceName value.
		/// </summary>
		string _sourcename;
		public string SourceName
		{
			get { return _sourcename; }
			set { _sourcename = value; }
		}


		#endregion
}
}
