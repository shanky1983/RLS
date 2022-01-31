using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class IPIntermediatePayments
	{
		#region Fields

		private long paymentDetailsID=0;
		private long visitID=0;
		private decimal amountReceived=Decimal.Zero;
		private string status=String.Empty;
		private DateTime paidDate=DateTime.MaxValue;
		private long startBillingDetailID=0;
		private long endBillingDetaillID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private decimal serviceCharge=Decimal.Zero;
		private string payerType=String.Empty;
		private string receiptNO=String.Empty;
		private int baseCurrencyID=0;
		private int paidCurrencyID=0;
		private decimal otherCurrencyAmount=Decimal.Zero;
		private string isSettlementPage=String.Empty;
		private string versionNo=String.Empty;
		private int roleID=0;
		private int deptID=0;
		private int orgID=0;
		private string receiptType=String.Empty;
		private decimal roundoffAmount=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PaymentDetailsID value.
		/// </summary>
		public long PaymentDetailsID
		{
			get { return paymentDetailsID; }
			set { paymentDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the PaidDate value.
		/// </summary>
		public DateTime PaidDate
		{
			get { return paidDate; }
			set { paidDate = value; }
		}

		/// <summary>
		/// Gets or sets the StartBillingDetailID value.
		/// </summary>
		public long StartBillingDetailID
		{
			get { return startBillingDetailID; }
			set { startBillingDetailID = value; }
		}

		/// <summary>
		/// Gets or sets the EndBillingDetaillID value.
		/// </summary>
		public long EndBillingDetaillID
		{
			get { return endBillingDetaillID; }
			set { endBillingDetaillID = value; }
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
		/// Gets or sets the ServiceCharge value.
		/// </summary>
		public decimal ServiceCharge
		{
			get { return serviceCharge; }
			set { serviceCharge = value; }
		}

		/// <summary>
		/// Gets or sets the PayerType value.
		/// </summary>
		public string PayerType
		{
			get { return payerType; }
			set { payerType = value; }
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
		/// Gets or sets the IsSettlementPage value.
		/// </summary>
		public string IsSettlementPage
		{
			get { return isSettlementPage; }
			set { isSettlementPage = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiptType value.
		/// </summary>
		public string ReceiptType
		{
			get { return receiptType; }
			set { receiptType = value; }
		}

		/// <summary>
		/// Gets or sets the RoundoffAmount value.
		/// </summary>
		public decimal RoundoffAmount
		{
			get { return roundoffAmount; }
			set { roundoffAmount = value; }
		}


		#endregion
}
}
