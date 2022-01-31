using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class KitPrepMaster
	{
		#region Fields

		private long kitID=0;
		private long masterKitID=0;
		private DateTime expiryDate=DateTime.MaxValue;
		private decimal sellingPrice=Decimal.Zero;
		private string kitBatchNo=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgID=0;
		private int locationID=0;
		private long toLocationID=0;
		private string comments=String.Empty;
		private decimal unitPrice=Decimal.Zero;
		private decimal taxPercent=Decimal.Zero;
		private long visitID=0;
		private string status=String.Empty;
		private string sellingUnit=String.Empty;
		private string productKey=String.Empty;
		private string stockOutFlowStatus=String.Empty;
		private string isBarCodePrinted=String.Empty;
		private decimal quantity=Decimal.Zero;
		private long receivedUniqueNumber=0;
		private long productReceivedDetailsID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the KitID value.
		/// </summary>
		public long KitID
		{
			get { return kitID; }
			set { kitID = value; }
		}

		/// <summary>
		/// Gets or sets the MasterKitID value.
		/// </summary>
		public long MasterKitID
		{
			get { return masterKitID; }
			set { masterKitID = value; }
		}

		/// <summary>
		/// Gets or sets the ExpiryDate value.
		/// </summary>
		public DateTime ExpiryDate
		{
			get { return expiryDate; }
			set { expiryDate = value; }
		}

		/// <summary>
		/// Gets or sets the SellingPrice value.
		/// </summary>
		public decimal SellingPrice
		{
			get { return sellingPrice; }
			set { sellingPrice = value; }
		}

		/// <summary>
		/// Gets or sets the KitBatchNo value.
		/// </summary>
		public string KitBatchNo
		{
			get { return kitBatchNo; }
			set { kitBatchNo = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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
		/// Gets or sets the ToLocationID value.
		/// </summary>
		public long ToLocationID
		{
			get { return toLocationID; }
			set { toLocationID = value; }
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
		/// Gets or sets the UnitPrice value.
		/// </summary>
		public decimal UnitPrice
		{
			get { return unitPrice; }
			set { unitPrice = value; }
		}

		/// <summary>
		/// Gets or sets the TaxPercent value.
		/// </summary>
		public decimal TaxPercent
		{
			get { return taxPercent; }
			set { taxPercent = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the SellingUnit value.
		/// </summary>
		public string SellingUnit
		{
			get { return sellingUnit; }
			set { sellingUnit = value; }
		}

		/// <summary>
		/// Gets or sets the ProductKey value.
		/// </summary>
		public string ProductKey
		{
			get { return productKey; }
			set { productKey = value; }
		}

		/// <summary>
		/// Gets or sets the StockOutFlowStatus value.
		/// </summary>
		public string StockOutFlowStatus
		{
			get { return stockOutFlowStatus; }
			set { stockOutFlowStatus = value; }
		}

		/// <summary>
		/// Gets or sets the IsBarCodePrinted value.
		/// </summary>
		public string IsBarCodePrinted
		{
			get { return isBarCodePrinted; }
			set { isBarCodePrinted = value; }
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
		/// Gets or sets the ReceivedUniqueNumber value.
		/// </summary>
		public long ReceivedUniqueNumber
		{
			get { return receivedUniqueNumber; }
			set { receivedUniqueNumber = value; }
		}

		/// <summary>
		/// Gets or sets the ProductReceivedDetailsID value.
		/// </summary>
		public long ProductReceivedDetailsID
		{
			get { return productReceivedDetailsID; }
			set { productReceivedDetailsID = value; }
		}


		#endregion
}
}
