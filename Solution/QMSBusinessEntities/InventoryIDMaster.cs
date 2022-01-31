using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InventoryIDMaster
	{
		#region Fields

		private int orgID=0;
		private long purchaseOrderID=0;
		private long stockReceivedID=0;
		private long stockDamageID=0;
		private long stockReturnID=0;
		private long stockIssuedID=0;
		private long stockUsageID=0;
		private long adhocID=0;
		private long intendID=0;
		private long mivID=0;
		private long subStockReturnID=0;
		private long pORID=0;
		private long stockExpiryID=0;
		private long disposalID=0;
		private long salesOrderID=0;
		private long invoiceNo=0;
		private long dCNo=0;
		private long salesOutFlowID=0;
		private long salesReturnID=0;
		private long laundryRefID=0;
		private long cssdRefID=0;
		private long stockTransferID=0;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the PurchaseOrderID value.
		/// </summary>
		public long PurchaseOrderID
		{
			get { return purchaseOrderID; }
			set { purchaseOrderID = value; }
		}

		/// <summary>
		/// Gets or sets the StockReceivedID value.
		/// </summary>
		public long StockReceivedID
		{
			get { return stockReceivedID; }
			set { stockReceivedID = value; }
		}

		/// <summary>
		/// Gets or sets the StockDamageID value.
		/// </summary>
		public long StockDamageID
		{
			get { return stockDamageID; }
			set { stockDamageID = value; }
		}

		/// <summary>
		/// Gets or sets the StockReturnID value.
		/// </summary>
		public long StockReturnID
		{
			get { return stockReturnID; }
			set { stockReturnID = value; }
		}

		/// <summary>
		/// Gets or sets the StockIssuedID value.
		/// </summary>
		public long StockIssuedID
		{
			get { return stockIssuedID; }
			set { stockIssuedID = value; }
		}

		/// <summary>
		/// Gets or sets the StockUsageID value.
		/// </summary>
		public long StockUsageID
		{
			get { return stockUsageID; }
			set { stockUsageID = value; }
		}

		/// <summary>
		/// Gets or sets the AdhocID value.
		/// </summary>
		public long AdhocID
		{
			get { return adhocID; }
			set { adhocID = value; }
		}

		/// <summary>
		/// Gets or sets the IntendID value.
		/// </summary>
		public long IntendID
		{
			get { return intendID; }
			set { intendID = value; }
		}

		/// <summary>
		/// Gets or sets the MivID value.
		/// </summary>
		public long MivID
		{
			get { return mivID; }
			set { mivID = value; }
		}

		/// <summary>
		/// Gets or sets the SubStockReturnID value.
		/// </summary>
		public long SubStockReturnID
		{
			get { return subStockReturnID; }
			set { subStockReturnID = value; }
		}

		/// <summary>
		/// Gets or sets the PORID value.
		/// </summary>
		public long PORID
		{
			get { return pORID; }
			set { pORID = value; }
		}

		/// <summary>
		/// Gets or sets the StockExpiryID value.
		/// </summary>
		public long StockExpiryID
		{
			get { return stockExpiryID; }
			set { stockExpiryID = value; }
		}

		/// <summary>
		/// Gets or sets the DisposalID value.
		/// </summary>
		public long DisposalID
		{
			get { return disposalID; }
			set { disposalID = value; }
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
		/// Gets or sets the InvoiceNo value.
		/// </summary>
		public long InvoiceNo
		{
			get { return invoiceNo; }
			set { invoiceNo = value; }
		}

		/// <summary>
		/// Gets or sets the DCNo value.
		/// </summary>
		public long DCNo
		{
			get { return dCNo; }
			set { dCNo = value; }
		}

		/// <summary>
		/// Gets or sets the SalesOutFlowID value.
		/// </summary>
		public long SalesOutFlowID
		{
			get { return salesOutFlowID; }
			set { salesOutFlowID = value; }
		}

		/// <summary>
		/// Gets or sets the SalesReturnID value.
		/// </summary>
		public long SalesReturnID
		{
			get { return salesReturnID; }
			set { salesReturnID = value; }
		}

		/// <summary>
		/// Gets or sets the LaundryRefID value.
		/// </summary>
		public long LaundryRefID
		{
			get { return laundryRefID; }
			set { laundryRefID = value; }
		}

		/// <summary>
		/// Gets or sets the CssdRefID value.
		/// </summary>
		public long CssdRefID
		{
			get { return cssdRefID; }
			set { cssdRefID = value; }
		}

		/// <summary>
		/// Gets or sets the StockTransferID value.
		/// </summary>
		public long StockTransferID
		{
			get { return stockTransferID; }
			set { stockTransferID = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}


		#endregion
}
}
