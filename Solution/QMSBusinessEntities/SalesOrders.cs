using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class SalesOrders
	{
		#region Fields

		private long salesOrderID=0;
		private DateTime salesOrderDate=DateTime.MaxValue;
		private string salesOrderNo=String.Empty;
		private int orgID=0;
		private long customerID=0;
		private string customerName=String.Empty;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long approvedBy=0;
		private DateTime approvedAt=DateTime.MaxValue;
		private string comments=String.Empty;
		private int orgAddressID=0;
		private int locationID=0;
		private DateTime deliveryDate=DateTime.MaxValue;
		private string invoiceNo=String.Empty;
		private string termsconditions=String.Empty;
		private decimal grandTotal=Decimal.Zero;
		private string approvalStatus=String.Empty;
		private int cLocationID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SalesOrderID value.
		/// </summary>
		public long SalesOrderID
		{
			get { return salesOrderID; }
			set { salesOrderID = value; }
		}

		/// <summary>
		/// Gets or sets the SalesOrderDate value.
		/// </summary>
		public DateTime SalesOrderDate
		{
			get { return salesOrderDate; }
			set { salesOrderDate = value; }
		}

		/// <summary>
		/// Gets or sets the SalesOrderNo value.
		/// </summary>
		public string SalesOrderNo
		{
			get { return salesOrderNo; }
			set { salesOrderNo = value; }
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
		/// Gets or sets the CustomerID value.
		/// </summary>
		public long CustomerID
		{
			get { return customerID; }
			set { customerID = value; }
		}

		/// <summary>
		/// Gets or sets the CustomerName value.
		/// </summary>
		public string CustomerName
		{
			get { return customerName; }
			set { customerName = value; }
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
		/// Gets or sets the ApprovedBy value.
		/// </summary>
		public long ApprovedBy
		{
			get { return approvedBy; }
			set { approvedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovedAt value.
		/// </summary>
		public DateTime ApprovedAt
		{
			get { return approvedAt; }
			set { approvedAt = value; }
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
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public int OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		public int LocationID
		{
			get { return locationID; }
			set { locationID = value; }
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
		/// Gets or sets the InvoiceNo value.
		/// </summary>
		public string InvoiceNo
		{
			get { return invoiceNo; }
			set { invoiceNo = value; }
		}

		/// <summary>
		/// Gets or sets the Termsconditions value.
		/// </summary>
		public string Termsconditions
		{
			get { return termsconditions; }
			set { termsconditions = value; }
		}

		/// <summary>
		/// Gets or sets the GrandTotal value.
		/// </summary>
		public decimal GrandTotal
		{
			get { return grandTotal; }
			set { grandTotal = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovalStatus value.
		/// </summary>
		public string ApprovalStatus
		{
			get { return approvalStatus; }
			set { approvalStatus = value; }
		}

		/// <summary>
		/// Gets or sets the CLocationID value.
		/// </summary>
		public int CLocationID
		{
			get { return cLocationID; }
			set { cLocationID = value; }
		}


		#endregion
}
}
