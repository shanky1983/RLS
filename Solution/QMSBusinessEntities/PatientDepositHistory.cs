using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientDepositHistory
	{
		#region Fields

		private long depositHistoryID=0;
		private long depositID=0;
		private long patientID=0;
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
		private long closureID=0;
		private string deptType=String.Empty;
		private DateTime deliveryDate=DateTime.MaxValue;
		private DateTime chequeValidDate=DateTime.MaxValue;
		private string depositedClosureStatus=String.Empty;
		private long amountDebtClosureDetailsID=0;
		private string transactionID=String.Empty;
		private string branchName=String.Empty;
		private string isOutStation=String.Empty;
		private string isDepositused=String.Empty;
		private string discount=String.Empty;
		private string depositTypeID=String.Empty;
		private string refundNo=String.Empty;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime loyaltyExpiryDate=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DepositHistoryID value.
		/// </summary>
		public long DepositHistoryID
		{
			get { return depositHistoryID; }
			set { depositHistoryID = value; }
		}

		/// <summary>
		/// Gets or sets the DepositID value.
		/// </summary>
		public long DepositID
		{
			get { return depositID; }
			set { depositID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
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
		/// Gets or sets the ClosureID value.
		/// </summary>
		public long ClosureID
		{
			get { return closureID; }
			set { closureID = value; }
		}

		/// <summary>
		/// Gets or sets the DeptType value.
		/// </summary>
		public string DeptType
		{
			get { return deptType; }
			set { deptType = value; }
		}

		/// <summary>
		/// Gets or sets the DeliveryDate value.
		/// </summary>
		public DateTime DeliveryDate
		{
			get { return deliveryDate; }
			set { deliveryDate = value; }
		}

		/// <summary>
		/// Gets or sets the ChequeValidDate value.
		/// </summary>
		public DateTime ChequeValidDate
		{
			get { return chequeValidDate; }
			set { chequeValidDate = value; }
		}

		/// <summary>
		/// Gets or sets the DepositedClosureStatus value.
		/// </summary>
		public string DepositedClosureStatus
		{
			get { return depositedClosureStatus; }
			set { depositedClosureStatus = value; }
		}

		/// <summary>
		/// Gets or sets the AmountDebtClosureDetailsID value.
		/// </summary>
		public long AmountDebtClosureDetailsID
		{
			get { return amountDebtClosureDetailsID; }
			set { amountDebtClosureDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the TransactionID value.
		/// </summary>
		public string TransactionID
		{
			get { return transactionID; }
			set { transactionID = value; }
		}

		/// <summary>
		/// Gets or sets the BranchName value.
		/// </summary>
		public string BranchName
		{
			get { return branchName; }
			set { branchName = value; }
		}

		/// <summary>
		/// Gets or sets the IsOutStation value.
		/// </summary>
		public string IsOutStation
		{
			get { return isOutStation; }
			set { isOutStation = value; }
		}

		/// <summary>
		/// Gets or sets the IsDepositused value.
		/// </summary>
		public string IsDepositused
		{
			get { return isDepositused; }
			set { isDepositused = value; }
		}

		/// <summary>
		/// Gets or sets the Discount value.
		/// </summary>
		public string Discount
		{
			get { return discount; }
			set { discount = value; }
		}

		/// <summary>
		/// Gets or sets the DepositTypeID value.
		/// </summary>
		public string DepositTypeID
		{
			get { return depositTypeID; }
			set { depositTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the RefundNo value.
		/// </summary>
		public string RefundNo
		{
			get { return refundNo; }
			set { refundNo = value; }
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
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the LoyaltyExpiryDate value.
		/// </summary>
		public DateTime LoyaltyExpiryDate
		{
			get { return loyaltyExpiryDate; }
			set { loyaltyExpiryDate = value; }
		}


		#endregion
}
}
