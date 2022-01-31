using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class HC_CollectionsRefunddetails
	{
		#region Fields

		private long refundID=0;
		private long collectionID=0;
		private long clientID=0;
		private decimal refundAmount=Decimal.Zero;
		private DateTime createdAT=DateTime.MaxValue;
		private long createdBy=0;
		private int paymentTypeID=0;
		private string chequeorCardNumber=String.Empty;
		private string bankNameorCardType=String.Empty;
		private string remarks=String.Empty;
		private decimal serviceCharge=Decimal.Zero;
		private int baseCurrencyID=0;
		private int paidCurrencyID=0;
		private int orgID=0;
		private string receiptNo=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RefundID value.
		/// </summary>
		public long RefundID
		{
			get { return refundID; }
			set { refundID = value; }
		}

		/// <summary>
		/// Gets or sets the CollectionID value.
		/// </summary>
		public long CollectionID
		{
			get { return collectionID; }
			set { collectionID = value; }
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
		/// Gets or sets the RefundAmount value.
		/// </summary>
		public decimal RefundAmount
		{
			get { return refundAmount; }
			set { refundAmount = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAT value.
		/// </summary>
		public DateTime CreatedAT
		{
			get { return createdAT; }
			set { createdAT = value; }
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
		/// Gets or sets the PaymentTypeID value.
		/// </summary>
		public int PaymentTypeID
		{
			get { return paymentTypeID; }
			set { paymentTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the ChequeorCardNumber value.
		/// </summary>
		public string ChequeorCardNumber
		{
			get { return chequeorCardNumber; }
			set { chequeorCardNumber = value; }
		}

		/// <summary>
		/// Gets or sets the BankNameorCardType value.
		/// </summary>
		public string BankNameorCardType
		{
			get { return bankNameorCardType; }
			set { bankNameorCardType = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceCharge value.
		/// </summary>
		public decimal ServiceCharge
		{
			get { return serviceCharge; }
			set { serviceCharge = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiptNo value.
		/// </summary>
		public string ReceiptNo
		{
			get { return receiptNo; }
			set { receiptNo = value; }
		}


		#endregion
}
}
