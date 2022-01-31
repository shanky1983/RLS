using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CashOutFlow
	{
		#region Fields

		private long outFlowID=0;
		private long receiverID=0;
		private string receiverName=String.Empty;
		private string receiverType=String.Empty;
		private string paymentType=String.Empty;
		private decimal amountReceived=Decimal.Zero;
		private decimal due=Decimal.Zero;
		private decimal surplus=Decimal.Zero;
		private DateTime dateFrom=DateTime.MaxValue;
		private DateTime dateTo=DateTime.MaxValue;
		private string remarks=String.Empty;
		private string closureStatus=String.Empty;
		private int orgID=0;
		private int createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private int modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string voucherNO=String.Empty;
		private string versionNo=String.Empty;
		private int roleID=0;
		private int deptID=0;
		private decimal totalAmount=Decimal.Zero;
		private decimal orgPercent=Decimal.Zero;
		private decimal orgAmount=Decimal.Zero;
		private decimal amtBeforeTDS=Decimal.Zero;
		private decimal tDSPercent=Decimal.Zero;
		private decimal tDSAmount=Decimal.Zero;
		private decimal termPayableAmount=Decimal.Zero;
		private decimal previousDue=Decimal.Zero;
		private decimal totalPayable=Decimal.Zero;
		private decimal totalPaid=Decimal.Zero;
		private decimal termPayment=Decimal.Zero;
		private decimal dueSettled=Decimal.Zero;
		private decimal termDue=Decimal.Zero;
		private decimal totalDue=Decimal.Zero;
		private long closureID=0;
		private long depositID=0;
		private string referenceNo=String.Empty;
		private DateTime expenseDate=DateTime.MaxValue;
		private long locationID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OutFlowID value.
		/// </summary>
		public long OutFlowID
		{
			get { return outFlowID; }
			set { outFlowID = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiverID value.
		/// </summary>
		public long ReceiverID
		{
			get { return receiverID; }
			set { receiverID = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiverName value.
		/// </summary>
		public string ReceiverName
		{
			get { return receiverName; }
			set { receiverName = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiverType value.
		/// </summary>
		public string ReceiverType
		{
			get { return receiverType; }
			set { receiverType = value; }
		}

		/// <summary>
		/// Gets or sets the PaymentType value.
		/// </summary>
		public string PaymentType
		{
			get { return paymentType; }
			set { paymentType = value; }
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
		/// Gets or sets the Due value.
		/// </summary>
		public decimal Due
		{
			get { return due; }
			set { due = value; }
		}

		/// <summary>
		/// Gets or sets the Surplus value.
		/// </summary>
		public decimal Surplus
		{
			get { return surplus; }
			set { surplus = value; }
		}

		/// <summary>
		/// Gets or sets the DateFrom value.
		/// </summary>
		public DateTime DateFrom
		{
			get { return dateFrom; }
			set { dateFrom = value; }
		}

		/// <summary>
		/// Gets or sets the DateTo value.
		/// </summary>
		public DateTime DateTo
		{
			get { return dateTo; }
			set { dateTo = value; }
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
		public int CreatedBy
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
		public int ModifiedBy
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
		/// Gets or sets the VoucherNO value.
		/// </summary>
		public string VoucherNO
		{
			get { return voucherNO; }
			set { voucherNO = value; }
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
		/// Gets or sets the TotalAmount value.
		/// </summary>
		public decimal TotalAmount
		{
			get { return totalAmount; }
			set { totalAmount = value; }
		}

		/// <summary>
		/// Gets or sets the OrgPercent value.
		/// </summary>
		public decimal OrgPercent
		{
			get { return orgPercent; }
			set { orgPercent = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAmount value.
		/// </summary>
		public decimal OrgAmount
		{
			get { return orgAmount; }
			set { orgAmount = value; }
		}

		/// <summary>
		/// Gets or sets the AmtBeforeTDS value.
		/// </summary>
		public decimal AmtBeforeTDS
		{
			get { return amtBeforeTDS; }
			set { amtBeforeTDS = value; }
		}

		/// <summary>
		/// Gets or sets the TDSPercent value.
		/// </summary>
		public decimal TDSPercent
		{
			get { return tDSPercent; }
			set { tDSPercent = value; }
		}

		/// <summary>
		/// Gets or sets the TDSAmount value.
		/// </summary>
		public decimal TDSAmount
		{
			get { return tDSAmount; }
			set { tDSAmount = value; }
		}

		/// <summary>
		/// Gets or sets the TermPayableAmount value.
		/// </summary>
		public decimal TermPayableAmount
		{
			get { return termPayableAmount; }
			set { termPayableAmount = value; }
		}

		/// <summary>
		/// Gets or sets the PreviousDue value.
		/// </summary>
		public decimal PreviousDue
		{
			get { return previousDue; }
			set { previousDue = value; }
		}

		/// <summary>
		/// Gets or sets the TotalPayable value.
		/// </summary>
		public decimal TotalPayable
		{
			get { return totalPayable; }
			set { totalPayable = value; }
		}

		/// <summary>
		/// Gets or sets the TotalPaid value.
		/// </summary>
		public decimal TotalPaid
		{
			get { return totalPaid; }
			set { totalPaid = value; }
		}

		/// <summary>
		/// Gets or sets the TermPayment value.
		/// </summary>
		public decimal TermPayment
		{
			get { return termPayment; }
			set { termPayment = value; }
		}

		/// <summary>
		/// Gets or sets the DueSettled value.
		/// </summary>
		public decimal DueSettled
		{
			get { return dueSettled; }
			set { dueSettled = value; }
		}

		/// <summary>
		/// Gets or sets the TermDue value.
		/// </summary>
		public decimal TermDue
		{
			get { return termDue; }
			set { termDue = value; }
		}

		/// <summary>
		/// Gets or sets the TotalDue value.
		/// </summary>
		public decimal TotalDue
		{
			get { return totalDue; }
			set { totalDue = value; }
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
		/// Gets or sets the DepositID value.
		/// </summary>
		public long DepositID
		{
			get { return depositID; }
			set { depositID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceNo value.
		/// </summary>
		public string ReferenceNo
		{
			get { return referenceNo; }
			set { referenceNo = value; }
		}

		/// <summary>
		/// Gets or sets the ExpenseDate value.
		/// </summary>
		public DateTime ExpenseDate
		{
			get { return expenseDate; }
			set { expenseDate = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		public long LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the PaidBy value.
		/// </summary>
		private string _paidBy=String.Empty;
		public string PaidBy
		{
			get { return  _paidBy; }
			set { _paidBy = value; }
		}

		/// <summary>
		/// Gets or sets the HeadName value.
		/// </summary>
		private string _headName=String.Empty;
		public string HeadName
		{
			get { return  _headName; }
			set { _headName = value; }
		}

		/// <summary>
		/// Gets or sets the Others value.
		/// </summary>
		private string _others=String.Empty;
		public string Others
		{
			get { return  _others; }
			set { _others = value; }
		}

		/// <summary>
		/// Gets or sets the StaffWelfare value.
		/// </summary>
		private string _staffWelfare=String.Empty;
		public string StaffWelfare
		{
			get { return  _staffWelfare; }
			set { _staffWelfare = value; }
		}

		/// <summary>
		/// Gets or sets the Physician value.
		/// </summary>
		private string _physician=String.Empty;
		public string Physician
		{
			get { return  _physician; }
			set { _physician = value; }
		}

		/// <summary>
		/// Gets or sets the Postage value.
		/// </summary>
		private string _postage=String.Empty;
		public string Postage
		{
			get { return  _postage; }
			set { _postage = value; }
		}

		/// <summary>
		/// Gets or sets the Hospitality value.
		/// </summary>
		private string _hospitality=String.Empty;
		public string Hospitality
		{
			get { return  _hospitality; }
			set { _hospitality = value; }
		}

		/// <summary>
		/// Gets or sets the BilledBy value.
		/// </summary>
		private string _billedBy=String.Empty;
		public string BilledBy
		{
			get { return  _billedBy; }
			set { _billedBy = value; }
		}


		#endregion
}
}
