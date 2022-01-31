using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class AmountReceivedDetails121
	{
		#region Fields

		private long amtReceivedID=0;
		private long finalBillID=0;
		private decimal amtReceived=Decimal.Zero;
		private long receivedBy=0;
		private string closureStatus=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int typeID=0;
		private string chequeorCardNumber=String.Empty;
		private string bankNameorCardType=String.Empty;
		private string remarks=String.Empty;
		private decimal serviceCharge=Decimal.Zero;
		private long intermediatepaymentID=0;
		private string receiptNO=String.Empty;
		private string physician=String.Empty;
		private int baseCurrencyID=0;
		private int paidCurrencyID=0;
		private decimal otherCurrencyAmount=Decimal.Zero;
		private string versionNo=String.Empty;
		private int roleID=0;
		private int deptID=0;
		private long referenceID=0;
		private string referenceType=String.Empty;
		private int units=0;
		private string eMIOpted=String.Empty;
		private decimal eMIROI=Decimal.Zero;
		private int eMITenor=0;
		private decimal eMIValue=Decimal.Zero;
		private string cardHolderName=String.Empty;
		private decimal cashGiven=Decimal.Zero;
		private decimal balanceGiven=Decimal.Zero;
		private decimal roundOffAmount=Decimal.Zero;
		private DateTime chequeValidDate=DateTime.MaxValue;
		private string isDueReceived=String.Empty;
		private string paymentCollectedFrom=String.Empty;
		private long closureID=0;
		private string depositedClosureStatus=String.Empty;
		private long amountDebtClosureDetailsID=0;
		private string transactionID=String.Empty;
		private string branchName=String.Empty;
		private string isOutStation=String.Empty;
		private string authorisationCode=String.Empty;
		private bool isDueBill=false;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AmtReceivedID value.
		/// </summary>
		public long AmtReceivedID
		{
			get { return amtReceivedID; }
			set { amtReceivedID = value; }
		}

		/// <summary>
		/// Gets or sets the FinalBillID value.
		/// </summary>
		public long FinalBillID
		{
			get { return finalBillID; }
			set { finalBillID = value; }
		}

		/// <summary>
		/// Gets or sets the AmtReceived value.
		/// </summary>
		public decimal AmtReceived
		{
			get { return amtReceived; }
			set { amtReceived = value; }
		}

		/// <summary>
		/// Gets or sets the ReceivedBy value.
		/// </summary>
		public long ReceivedBy
		{
			get { return receivedBy; }
			set { receivedBy = value; }
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
		/// Gets or sets the TypeID value.
		/// </summary>
		public int TypeID
		{
			get { return typeID; }
			set { typeID = value; }
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
		/// Gets or sets the IntermediatepaymentID value.
		/// </summary>
		public long IntermediatepaymentID
		{
			get { return intermediatepaymentID; }
			set { intermediatepaymentID = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiptNO value.
		/// </summary>
		public string ReceiptNO
		{
			get { return receiptNO; }
			set { receiptNO = value; }
		}

		/// <summary>
		/// Gets or sets the Physician value.
		/// </summary>
		public string Physician
		{
			get { return physician; }
			set { physician = value; }
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
		/// Gets or sets the OtherCurrencyAmount value.
		/// </summary>
		public decimal OtherCurrencyAmount
		{
			get { return otherCurrencyAmount; }
			set { otherCurrencyAmount = value; }
		}

		/// <summary>
		/// Gets or sets the VersionNo value.
		/// </summary>
		public string VersionNo
		{
			get { return versionNo; }
			set { versionNo = value; }
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
		/// Gets or sets the ReferenceID value.
		/// </summary>
		public long ReferenceID
		{
			get { return referenceID; }
			set { referenceID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceType value.
		/// </summary>
		public string ReferenceType
		{
			get { return referenceType; }
			set { referenceType = value; }
		}

		/// <summary>
		/// Gets or sets the Units value.
		/// </summary>
		public int Units
		{
			get { return units; }
			set { units = value; }
		}

		/// <summary>
		/// Gets or sets the EMIOpted value.
		/// </summary>
		public string EMIOpted
		{
			get { return eMIOpted; }
			set { eMIOpted = value; }
		}

		/// <summary>
		/// Gets or sets the EMIROI value.
		/// </summary>
		public decimal EMIROI
		{
			get { return eMIROI; }
			set { eMIROI = value; }
		}

		/// <summary>
		/// Gets or sets the EMITenor value.
		/// </summary>
		public int EMITenor
		{
			get { return eMITenor; }
			set { eMITenor = value; }
		}

		/// <summary>
		/// Gets or sets the EMIValue value.
		/// </summary>
		public decimal EMIValue
		{
			get { return eMIValue; }
			set { eMIValue = value; }
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
		/// Gets or sets the RoundOffAmount value.
		/// </summary>
		public decimal RoundOffAmount
		{
			get { return roundOffAmount; }
			set { roundOffAmount = value; }
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
		/// Gets or sets the IsDueReceived value.
		/// </summary>
		public string IsDueReceived
		{
			get { return isDueReceived; }
			set { isDueReceived = value; }
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
		/// Gets or sets the AuthorisationCode value.
		/// </summary>
		public string AuthorisationCode
		{
			get { return authorisationCode; }
			set { authorisationCode = value; }
		}

		/// <summary>
		/// Gets or sets the IsDueBill value.
		/// </summary>
		public bool IsDueBill
		{
			get { return isDueBill; }
			set { isDueBill = value; }
		}


		#endregion
}
}
