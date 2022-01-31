using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class HC_AmountReceivedDetails
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
		private long amtReceivedLocation=0;
		private DateTime amtReceivedDate=DateTime.MaxValue;
		private long billCurrencyId=0;
		private decimal baseCurrencyConvValue=Decimal.Zero;
		private decimal baseCurrencyAmtReceived=Decimal.Zero;
		private decimal paidToBaseConvValue=Decimal.Zero;
		private decimal baseCurrencyPaidAmt=Decimal.Zero;
		private long corporateCurrencyID=0;
		private decimal corporateCurrencyConvValue=Decimal.Zero;
		private decimal corporateCurrencyAmtReceived=Decimal.Zero;
		private decimal paidToCorpConvValue=Decimal.Zero;
		private decimal corporateCurrencyPaidAmt=Decimal.Zero;

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
		/// Gets or sets the AmtReceivedLocation value.
		/// </summary>
		public long AmtReceivedLocation
		{
			get { return amtReceivedLocation; }
			set { amtReceivedLocation = value; }
		}

		/// <summary>
		/// Gets or sets the AmtReceivedDate value.
		/// </summary>
		public DateTime AmtReceivedDate
		{
			get { return amtReceivedDate; }
			set { amtReceivedDate = value; }
		}

		/// <summary>
		/// Gets or sets the BillCurrencyId value.
		/// </summary>
		public long BillCurrencyId
		{
			get { return billCurrencyId; }
			set { billCurrencyId = value; }
		}

		/// <summary>
		/// Gets or sets the BaseCurrencyConvValue value.
		/// </summary>
		public decimal BaseCurrencyConvValue
		{
			get { return baseCurrencyConvValue; }
			set { baseCurrencyConvValue = value; }
		}

		/// <summary>
		/// Gets or sets the BaseCurrencyAmtReceived value.
		/// </summary>
		public decimal BaseCurrencyAmtReceived
		{
			get { return baseCurrencyAmtReceived; }
			set { baseCurrencyAmtReceived = value; }
		}

		/// <summary>
		/// Gets or sets the PaidToBaseConvValue value.
		/// </summary>
		public decimal PaidToBaseConvValue
		{
			get { return paidToBaseConvValue; }
			set { paidToBaseConvValue = value; }
		}

		/// <summary>
		/// Gets or sets the BaseCurrencyPaidAmt value.
		/// </summary>
		public decimal BaseCurrencyPaidAmt
		{
			get { return baseCurrencyPaidAmt; }
			set { baseCurrencyPaidAmt = value; }
		}

		/// <summary>
		/// Gets or sets the CorporateCurrencyID value.
		/// </summary>
		public long CorporateCurrencyID
		{
			get { return corporateCurrencyID; }
			set { corporateCurrencyID = value; }
		}

		/// <summary>
		/// Gets or sets the CorporateCurrencyConvValue value.
		/// </summary>
		public decimal CorporateCurrencyConvValue
		{
			get { return corporateCurrencyConvValue; }
			set { corporateCurrencyConvValue = value; }
		}

		/// <summary>
		/// Gets or sets the CorporateCurrencyAmtReceived value.
		/// </summary>
		public decimal CorporateCurrencyAmtReceived
		{
			get { return corporateCurrencyAmtReceived; }
			set { corporateCurrencyAmtReceived = value; }
		}

		/// <summary>
		/// Gets or sets the PaidToCorpConvValue value.
		/// </summary>
		public decimal PaidToCorpConvValue
		{
			get { return paidToCorpConvValue; }
			set { paidToCorpConvValue = value; }
		}

		/// <summary>
		/// Gets or sets the CorporateCurrencyPaidAmt value.
		/// </summary>
		public decimal CorporateCurrencyPaidAmt
		{
			get { return corporateCurrencyPaidAmt; }
			set { corporateCurrencyPaidAmt = value; }
		}


		#endregion
}
}
