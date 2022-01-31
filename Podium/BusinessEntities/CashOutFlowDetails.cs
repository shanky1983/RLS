using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CashOutFlowDetails
	{
		#region Fields

		private long outFlowDetailsID=0;
		private long outFlowID=0;
		private decimal amtPaid=Decimal.Zero;
		private long paidBy=0;
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
		private string voucherNO=String.Empty;
		private int baseCurrencyID=0;
		private int paidCurrencyID=0;
		private decimal otherCurrencyAmount=Decimal.Zero;
		private string versionNo=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OutFlowDetailsID value.
		/// </summary>
		public long OutFlowDetailsID
		{
			get { return outFlowDetailsID; }
			set { outFlowDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the OutFlowID value.
		/// </summary>
		public long OutFlowID
		{
			get { return outFlowID; }
			set { outFlowID = value; }
		}

		/// <summary>
		/// Gets or sets the AmtPaid value.
		/// </summary>
		public decimal AmtPaid
		{
			get { return amtPaid; }
			set { amtPaid = value; }
		}

		/// <summary>
		/// Gets or sets the PaidBy value.
		/// </summary>
		public long PaidBy
		{
			get { return paidBy; }
			set { paidBy = value; }
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
		/// Gets or sets the VoucherNO value.
		/// </summary>
		public string VoucherNO
		{
			get { return voucherNO; }
			set { voucherNO = value; }
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
		/// Gets or sets the PaymentName value.
		/// </summary>
		private String _paymentName=String.Empty;
		public String PaymentName
		{
			get { return  _paymentName; }
			set { _paymentName = value; }
		}

		/// <summary>
		/// Gets or sets the BilledBy value.
		/// </summary>
		private String _billedBy=String.Empty;
		public String BilledBy
		{
			get { return  _billedBy; }
			set { _billedBy = value; }
		}


		#endregion
}
}
