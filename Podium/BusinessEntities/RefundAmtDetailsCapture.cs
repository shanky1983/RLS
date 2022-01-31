using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class RefundAmtDetailsCapture
	{
		#region Fields

		private long finalBillID=0;
		private long billingDetailsID=0;
		private string refundNo=String.Empty;
		private decimal refundAmt=Decimal.Zero;
		private decimal approvedAmt=Decimal.Zero;
		private string receiptNo=String.Empty;
		private int orgId=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long taskID=0;
		private string reasonForReject=String.Empty;
		private string refundType=String.Empty;
		private int authorisedBy=0;
		private string refundStatus=String.Empty;
		private string comments=String.Empty;
		private string reasonforRefund=String.Empty;
		private int iD=0;

		#endregion

		#region Properties
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
		/// Gets or sets the RefundNo value.
		/// </summary>
		public string RefundNo
		{
			get { return refundNo; }
			set { refundNo = value; }
		}

		/// <summary>
		/// Gets or sets the RefundAmt value.
		/// </summary>
		public decimal RefundAmt
		{
			get { return refundAmt; }
			set { refundAmt = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovedAmt value.
		/// </summary>
		public decimal ApprovedAmt
		{
			get { return approvedAmt; }
			set { approvedAmt = value; }
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
		/// Gets or sets the OrgId value.
		/// </summary>
		public int OrgId
		{
			get { return orgId; }
			set { orgId = value; }
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
		/// Gets or sets the TaskID value.
		/// </summary>
		public long TaskID
		{
			get { return taskID; }
			set { taskID = value; }
		}

		/// <summary>
		/// Gets or sets the ReasonForReject value.
		/// </summary>
		public string ReasonForReject
		{
			get { return reasonForReject; }
			set { reasonForReject = value; }
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
		/// Gets or sets the AuthorisedBy value.
		/// </summary>
		public int AuthorisedBy
		{
			get { return authorisedBy; }
			set { authorisedBy = value; }
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
		/// Gets or sets the Comments value.
		/// </summary>
		public string Comments
		{
			get { return comments; }
			set { comments = value; }
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
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}


		#endregion
}
}
