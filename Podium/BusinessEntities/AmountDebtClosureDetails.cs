using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class AmountDebtClosureDetails
	{
		#region Fields

		private long amountDebtClosureDetailsID=0;
		private decimal totalAmount=Decimal.Zero;
		private decimal debitedAmount=Decimal.Zero;
		private DateTime debitedDate=DateTime.MaxValue;
		private string description=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedAt=0;
		private DateTime modifiedBy=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AmountDebtClosureDetailsID value.
		/// </summary>
		public long AmountDebtClosureDetailsID
		{
			get { return amountDebtClosureDetailsID; }
			set { amountDebtClosureDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the TotalAmount value.
		/// </summary>
		public decimal TotalAmount
		{
			get { return totalAmount; }
			set { totalAmount = value; }
		}

		/// <summary>
		/// Gets or sets the DebitedAmount value.
		/// </summary>
		public decimal DebitedAmount
		{
			get { return debitedAmount; }
			set { debitedAmount = value; }
		}

		/// <summary>
		/// Gets or sets the DebitedDate value.
		/// </summary>
		public DateTime DebitedDate
		{
			get { return debitedDate; }
			set { debitedDate = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public long ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public DateTime ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the RemainingAmount value.
		/// </summary>
		private decimal _remainingAmount=Decimal.Zero;
		public decimal RemainingAmount
		{
			get { return  _remainingAmount; }
			set { _remainingAmount = value; }
		}

		/// <summary>
		/// Gets or sets the FileURL value.
		/// </summary>
		private string _fileURL=String.Empty;
		public string FileURL
		{
			get { return  _fileURL; }
			set { _fileURL = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		private string _name=String.Empty;
		public string Name
		{
			get { return  _name; }
			set { _name = value; }
		}

		/// <summary>
		/// Gets or sets the HeaderLogo value.
		/// </summary>
		private string _headerLogo=String.Empty;
		public string HeaderLogo
		{
			get { return  _headerLogo; }
			set { _headerLogo = value; }
		}

		/// <summary>
		/// Gets or sets the DepositedBy value.
		/// </summary>
		private string _depositedBy=String.Empty;
		public string DepositedBy
		{
			get { return  _depositedBy; }
			set { _depositedBy = value; }
		}

		/// <summary>
		/// Gets or sets the AccountNo value.
		/// </summary>
		private string _accountNo=String.Empty;
		public string AccountNo
		{
			get { return  _accountNo; }
			set { _accountNo = value; }
		}

		/// <summary>
		/// Gets or sets the HeaderBankName value.
		/// </summary>
		private string _headerBankName=String.Empty;
		public string HeaderBankName
		{
			get { return  _headerBankName; }
			set { _headerBankName = value; }
		}

		/// <summary>
		/// Gets or sets the HeaderBranch value.
		/// </summary>
		private string _headerBranch=String.Empty;
		public string HeaderBranch
		{
			get { return  _headerBranch; }
			set { _headerBranch = value; }
		}

		/// <summary>
		/// Gets or sets the UserName value.
		/// </summary>
		private string _userName=String.Empty;
		public string UserName
		{
			get { return  _userName; }
			set { _userName = value; }
		}

		/// <summary>
		/// Gets or sets the AmountClosed value.
		/// </summary>
		private string _amountClosed=String.Empty;
		public string AmountClosed
		{
			get { return  _amountClosed; }
			set { _amountClosed = value; }
		}

		/// <summary>
		/// Gets or sets the ClosedFor value.
		/// </summary>
		private string _closedFor=String.Empty;
		public string ClosedFor
		{
			get { return  _closedFor; }
			set { _closedFor = value; }
		}

		/// <summary>
		/// Gets or sets the BankNameorCardType value.
		/// </summary>
		private string _bankNameorCardType=String.Empty;
		public string BankNameorCardType
		{
			get { return  _bankNameorCardType; }
			set { _bankNameorCardType = value; }
		}

		/// <summary>
		/// Gets or sets the BankBranch value.
		/// </summary>
		private string _bankBranch=String.Empty;
		public string BankBranch
		{
			get { return  _bankBranch; }
			set { _bankBranch = value; }
		}

		/// <summary>
		/// Gets or sets the ChequeorCardNumber value.
		/// </summary>
		private string _chequeorCardNumber=String.Empty;
		public string ChequeorCardNumber
		{
			get { return  _chequeorCardNumber; }
			set { _chequeorCardNumber = value; }
		}

		/// <summary>
		/// Gets or sets the ChequeValidDate value.
		/// </summary>
		private string _chequeValidDate=String.Empty;
		public string ChequeValidDate
		{
			get { return  _chequeValidDate; }
			set { _chequeValidDate = value; }
		}

		/// <summary>
		/// Gets or sets the AmtReceived value.
		/// </summary>
		private string _amtReceived=String.Empty;
		public string AmtReceived
		{
			get { return  _amtReceived; }
			set { _amtReceived = value; }
		}

		/// <summary>
		/// Gets or sets the ReceivedBy value.
		/// </summary>
		private string _receivedBy=String.Empty;
		public string ReceivedBy
		{
			get { return  _receivedBy; }
			set { _receivedBy = value; }
		}

		/// <summary>
		/// Gets or sets the TransactionID value.
		/// </summary>
		private string _transactionID=String.Empty;
		public string TransactionID
		{
			get { return  _transactionID; }
			set { _transactionID = value; }
		}

		/// <summary>
		/// Gets or sets the RefID value.
		/// </summary>
		private long _refID=0;
		public long RefID
		{
			get { return  _refID; }
			set { _refID = value; }
		}

		/// <summary>
		/// Gets or sets the RefType value.
		/// </summary>
		private string _refType=String.Empty;
		public string RefType
		{
			get { return  _refType; }
			set { _refType = value; }
		}

		/// <summary>
		/// Gets or sets the RefName value.
		/// </summary>
		private string _refName=String.Empty;
		public string RefName
		{
			get { return  _refName; }
			set { _refName = value; }
		}

		/// <summary>
		/// Gets or sets the DepositedRefNo value.
		/// </summary>
		private string _depositedRefNo=String.Empty;
		public string DepositedRefNo
		{
			get { return  _depositedRefNo; }
			set { _depositedRefNo = value; }
		}

		/// <summary>
		/// Gets or sets the PaymentType value.
		/// </summary>
		private string _paymentType=String.Empty;
		public string PaymentType
		{
			get { return  _paymentType; }
			set { _paymentType = value; }
		}


		#endregion
}
}
