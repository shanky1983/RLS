using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class AmountRefundDetails_HIST
	{
		#region Fields

		private int amtRefundID_HIST=0;
		private int amtRefundID=0;
		private long finalBillID=0;
		private long billingDetailsID=0;
		private decimal amtRefund=Decimal.Zero;
		private long refundBy=0;
		private string refundStatus=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string reasonforRefund=String.Empty;
		private string billStatus=String.Empty;
		private decimal quantity=Decimal.Zero;
		private string refundNo=String.Empty;
		private string refundType=String.Empty;
		private long approvedBy=0;
		private int tranCurrencyID=0;
		private int baseCurrencyID=0;
		private decimal tranCurrencyAmount=Decimal.Zero;
		private int paymentTypeID=0;
		private string paymentDetail=String.Empty;
		private string receiptNo=String.Empty;
		private long chequeNo=0;
		private string bankName=String.Empty;
		private string remarks=String.Empty;
		private long taskModifiedBy=0;
		private DateTime taskModifiedAt=DateTime.MaxValue;
		private string taskRejectReason=String.Empty;
		private string versionNo=String.Empty;
		private int authorisedBy=0;
		private string serviceType=String.Empty;
		private long createdRole=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AmtRefundID_HIST value.
		/// </summary>
		public int AmtRefundID_HIST
		{
			get { return amtRefundID_HIST; }
			set { amtRefundID_HIST = value; }
		}

		/// <summary>
		/// Gets or sets the AmtRefundID value.
		/// </summary>
		public int AmtRefundID
		{
			get { return amtRefundID; }
			set { amtRefundID = value; }
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
		/// Gets or sets the BillingDetailsID value.
		/// </summary>
		public long BillingDetailsID
		{
			get { return billingDetailsID; }
			set { billingDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the AmtRefund value.
		/// </summary>
		public decimal AmtRefund
		{
			get { return amtRefund; }
			set { amtRefund = value; }
		}

		/// <summary>
		/// Gets or sets the RefundBy value.
		/// </summary>
		public long RefundBy
		{
			get { return refundBy; }
			set { refundBy = value; }
		}

		/// <summary>
		/// Gets or sets the RefundStatus value.
		/// </summary>
		public string RefundStatus
		{
			get { return refundStatus; }
			set { refundStatus = value; }
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
		/// Gets or sets the ReasonforRefund value.
		/// </summary>
		public string ReasonforRefund
		{
			get { return reasonforRefund; }
			set { reasonforRefund = value; }
		}

		/// <summary>
		/// Gets or sets the BillStatus value.
		/// </summary>
		public string BillStatus
		{
			get { return billStatus; }
			set { billStatus = value; }
		}

		/// <summary>
		/// Gets or sets the Quantity value.
		/// </summary>
		public decimal Quantity
		{
			get { return quantity; }
			set { quantity = value; }
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
		/// Gets or sets the RefundType value.
		/// </summary>
		public string RefundType
		{
			get { return refundType; }
			set { refundType = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovedBy value.
		/// </summary>
		public long ApprovedBy
		{
			get { return approvedBy; }
			set { approvedBy = value; }
		}

		/// <summary>
		/// Gets or sets the TranCurrencyID value.
		/// </summary>
		public int TranCurrencyID
		{
			get { return tranCurrencyID; }
			set { tranCurrencyID = value; }
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
		/// Gets or sets the TranCurrencyAmount value.
		/// </summary>
		public decimal TranCurrencyAmount
		{
			get { return tranCurrencyAmount; }
			set { tranCurrencyAmount = value; }
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
		/// Gets or sets the PaymentDetail value.
		/// </summary>
		public string PaymentDetail
		{
			get { return paymentDetail; }
			set { paymentDetail = value; }
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
		/// Gets or sets the ChequeNo value.
		/// </summary>
		public long ChequeNo
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
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
		}

		/// <summary>
		/// Gets or sets the TaskModifiedBy value.
		/// </summary>
		public long TaskModifiedBy
		{
			get { return taskModifiedBy; }
			set { taskModifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the TaskModifiedAt value.
		/// </summary>
		public DateTime TaskModifiedAt
		{
			get { return taskModifiedAt; }
			set { taskModifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the TaskRejectReason value.
		/// </summary>
		public string TaskRejectReason
		{
			get { return taskRejectReason; }
			set { taskRejectReason = value; }
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
		/// Gets or sets the AuthorisedBy value.
		/// </summary>
		public int AuthorisedBy
		{
			get { return authorisedBy; }
			set { authorisedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceType value.
		/// </summary>
		public string ServiceType
		{
			get { return serviceType; }
			set { serviceType = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedRole value.
		/// </summary>
		public long CreatedRole
		{
			get { return createdRole; }
			set { createdRole = value; }
		}


		#endregion
}
}
