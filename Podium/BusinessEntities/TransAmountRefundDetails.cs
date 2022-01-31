using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class TransAmountRefundDetails
	{
		#region Fields

		private long transReundID=0;
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
		private decimal quantity=Decimal.Zero;
		private string refundOrderNo=String.Empty;
		private string refundType=String.Empty;
		private long approvedBy=0;
		private int transCurrencyID=0;
		private int baseCurrencyID=0;
		private int paymentTypeID=0;
		private string paymentDetail=String.Empty;
		private string orderReceiptNo=String.Empty;
		private long chequeNo=0;
		private string bankName=String.Empty;
		private string remarks=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TransReundID value.
		/// </summary>
		public long TransReundID
		{
			get { return transReundID; }
			set { transReundID = value; }
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
		/// Gets or sets the Quantity value.
		/// </summary>
		public decimal Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}

		/// <summary>
		/// Gets or sets the RefundOrderNo value.
		/// </summary>
		public string RefundOrderNo
		{
			get { return refundOrderNo; }
			set { refundOrderNo = value; }
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
		/// Gets or sets the TransCurrencyID value.
		/// </summary>
		public int TransCurrencyID
		{
			get { return transCurrencyID; }
			set { transCurrencyID = value; }
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
		/// Gets or sets the OrderReceiptNo value.
		/// </summary>
		public string OrderReceiptNo
		{
			get { return orderReceiptNo; }
			set { orderReceiptNo = value; }
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


		#endregion
}
}
