using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class SalesOrderOutFlowDetails
	{
		#region Fields

		private long salesOrderOutFlowDetailsID=0;
		private long salesOrderID=0;
		private long stockOutFlowID=0;
		private string invoiceNo=String.Empty;
		private string dCNo=String.Empty;
		private int orgID=0;
		private long orgAddressID=0;
		private DateTime stockOutFlowDate=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int locationID=0;
		private int raiseOrgID=0;
		private int raiseOrgAddID=0;
		private string status=String.Empty;
		private DateTime invoiceDate=DateTime.MaxValue;
		private int cLocationID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SalesOrderOutFlowDetailsID value.
		/// </summary>
		public long SalesOrderOutFlowDetailsID
		{
			get { return salesOrderOutFlowDetailsID; }
			set { salesOrderOutFlowDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the SalesOrderID value.
		/// </summary>
		public long SalesOrderID
		{
			get { return salesOrderID; }
			set { salesOrderID = value; }
		}

		/// <summary>
		/// Gets or sets the StockOutFlowID value.
		/// </summary>
		public long StockOutFlowID
		{
			get { return stockOutFlowID; }
			set { stockOutFlowID = value; }
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
		/// Gets or sets the DCNo value.
		/// </summary>
		public string DCNo
		{
			get { return dCNo; }
			set { dCNo = value; }
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
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public long OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the StockOutFlowDate value.
		/// </summary>
		public DateTime StockOutFlowDate
		{
			get { return stockOutFlowDate; }
			set { stockOutFlowDate = value; }
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
		/// Gets or sets the LocationID value.
		/// </summary>
		public int LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the RaiseOrgID value.
		/// </summary>
		public int RaiseOrgID
		{
			get { return raiseOrgID; }
			set { raiseOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the RaiseOrgAddID value.
		/// </summary>
		public int RaiseOrgAddID
		{
			get { return raiseOrgAddID; }
			set { raiseOrgAddID = value; }
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
		/// Gets or sets the InvoiceDate value.
		/// </summary>
		public DateTime InvoiceDate
		{
			get { return invoiceDate; }
			set { invoiceDate = value; }
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
