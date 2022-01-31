using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class KitPrepMasterDetails
	{
		#region Fields

		private long masterDetailsID=0;
		private long kitID=0;
		private long masterKitID=0;
		private long productID=0;
		private decimal quantity=Decimal.Zero;
		private string batchNo=String.Empty;
		private DateTime expiryDate=DateTime.MaxValue;
		private decimal sellingPrice=Decimal.Zero;
		private string sellingUnit=String.Empty;
		private int orgID=0;
		private int locationID=0;
		private long toLocationID=0;
		private decimal unitPrice=Decimal.Zero;
		private decimal taxPercent=Decimal.Zero;
		private string isReimbursable=String.Empty;
		private string productKey=String.Empty;
		private long kitPrepBy=0;
		private DateTime kitPrepAt=DateTime.MaxValue;
		private decimal actualQty=Decimal.Zero;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private decimal tax=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MasterDetailsID value.
		/// </summary>
		public long MasterDetailsID
		{
			get { return masterDetailsID; }
			set { masterDetailsID = value; }
		}

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
		/// Gets or sets the ProductID value.
		/// </summary>
		public long ProductID
		{
			get { return productID; }
			set { productID = value; }
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
		/// Gets or sets the BatchNo value.
		/// </summary>
		public string BatchNo
		{
			get { return batchNo; }
			set { batchNo = value; }
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
		/// Gets or sets the SellingUnit value.
		/// </summary>
		public string SellingUnit
		{
			get { return sellingUnit; }
			set { sellingUnit = value; }
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
		/// Gets or sets the IsReimbursable value.
		/// </summary>
		public string IsReimbursable
		{
			get { return isReimbursable; }
			set { isReimbursable = value; }
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
		/// Gets or sets the KitPrepBy value.
		/// </summary>
		public long KitPrepBy
		{
			get { return kitPrepBy; }
			set { kitPrepBy = value; }
		}

		/// <summary>
		/// Gets or sets the KitPrepAt value.
		/// </summary>
		public DateTime KitPrepAt
		{
			get { return kitPrepAt; }
			set { kitPrepAt = value; }
		}

		/// <summary>
		/// Gets or sets the ActualQty value.
		/// </summary>
		public decimal ActualQty
		{
			get { return actualQty; }
			set { actualQty = value; }
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
		/// Gets or sets the Tax value.
		/// </summary>
		public decimal Tax
		{
			get { return tax; }
			set { tax = value; }
		}


		#endregion
}
}
