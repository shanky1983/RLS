using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class CollectionsHistory
	{
		#region Fields

		private long collectionHistoryID=0;
		private long collectionID=0;
		private long identificationid=0;
		private int orgID=0;
		private string receiptNo=String.Empty;
		private decimal amountDeposited=Decimal.Zero;
		private int paymentTypeID=0;
		private string chequeorCardNumber=String.Empty;
		private string bankNameorCardType=String.Empty;
		private string remarks=String.Empty;
		private decimal serviceCharge=Decimal.Zero;
		private int baseCurrencyID=0;
		private int paidCurrencyID=0;
		private decimal conversionRate=Decimal.Zero;
		private decimal paidCurrencyAmount=Decimal.Zero;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private string closureStatus=String.Empty;
		private int roleID=0;
		private int deptID=0;
		private string cardHolderName=String.Empty;
		private decimal cashGiven=Decimal.Zero;
		private decimal balanceGiven=Decimal.Zero;
		private string paymentCollectedFrom=String.Empty;
		private string identificationType=String.Empty;
		private decimal refundAmount=Decimal.Zero;
		private string paymentTypeMode=String.Empty;
		private string refundedBy=String.Empty;
		private string collectedBy=String.Empty;
		private string clientName=String.Empty;
		private decimal amountUsed=Decimal.Zero;
		private decimal availableBalance=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CollectionHistoryID value.
		/// </summary>
		public long CollectionHistoryID
		{
			get { return collectionHistoryID; }
			set { collectionHistoryID = value; }
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
		/// Gets or sets the Identificationid value.
		/// </summary>
		public long Identificationid
		{
			get { return identificationid; }
			set { identificationid = value; }
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

		/// <summary>
		/// Gets or sets the AmountDeposited value.
		/// </summary>
		public decimal AmountDeposited
		{
			get { return amountDeposited; }
			set { amountDeposited = value; }
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
		/// Gets or sets the ConversionRate value.
		/// </summary>
		public decimal ConversionRate
		{
			get { return conversionRate; }
			set { conversionRate = value; }
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
		/// Gets or sets the ClosureStatus value.
		/// </summary>
		public string ClosureStatus
		{
			get { return closureStatus; }
			set { closureStatus = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		public int RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}

		/// <summary>
		/// Gets or sets the DeptID value.
		/// </summary>
		public int DeptID
		{
			get { return deptID; }
			set { deptID = value; }
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
		/// Gets or sets the PaymentCollectedFrom value.
		/// </summary>
		public string PaymentCollectedFrom
		{
			get { return paymentCollectedFrom; }
			set { paymentCollectedFrom = value; }
		}

		/// <summary>
		/// Gets or sets the IdentificationType value.
		/// </summary>
		public string IdentificationType
		{
			get { return identificationType; }
			set { identificationType = value; }
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
		/// Gets or sets the PaymentTypeMode value.
		/// </summary>
		public string PaymentTypeMode
		{
			get { return paymentTypeMode; }
			set { paymentTypeMode = value; }
		}

		/// <summary>
		/// Gets or sets the RefundedBy value.
		/// </summary>
		public string RefundedBy
		{
			get { return refundedBy; }
			set { refundedBy = value; }
		}

		/// <summary>
		/// Gets or sets the CollectedBy value.
		/// </summary>
		public string CollectedBy
		{
			get { return collectedBy; }
			set { collectedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ClientName value.
		/// </summary>
		public string ClientName
		{
			get { return clientName; }
			set { clientName = value; }
		}

		/// <summary>
		/// Gets or sets the AmountUsed value.
		/// </summary>
		public decimal AmountUsed
		{
			get { return amountUsed; }
			set { amountUsed = value; }
		}

		/// <summary>
		/// Gets or sets the AvailableBalance value.
		/// </summary>
		public decimal AvailableBalance
		{
			get { return availableBalance; }
			set { availableBalance = value; }
		}


		#endregion
}
}
