using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PurchaseOrderDetails
	{
		#region Fields

		private long purchaseOrderDetailsID=0;
		private long purchaseOrderId=0;
		private int orgID=0;
		private long productID=0;
		private decimal quantity=Decimal.Zero;
		private string unit=String.Empty;
		private string description=String.Empty;
		private int orgAddressID=0;
		private string pOStatus=String.Empty;
		private int locationID=0;
		private long totalqty=0;
		private long parentProductID=0;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private decimal inverseQty=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PurchaseOrderDetailsID value.
		/// </summary>
		public long PurchaseOrderDetailsID
		{
			get { return purchaseOrderDetailsID; }
			set { purchaseOrderDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the PurchaseOrderId value.
		/// </summary>
		public long PurchaseOrderId
		{
			get { return purchaseOrderId; }
			set { purchaseOrderId = value; }
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
		/// Gets or sets the Unit value.
		/// </summary>
		public string Unit
		{
			get { return unit; }
			set { unit = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
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
		/// Gets or sets the POStatus value.
		/// </summary>
		public string POStatus
		{
			get { return pOStatus; }
			set { pOStatus = value; }
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
		/// Gets or sets the Totalqty value.
		/// </summary>
		public long Totalqty
		{
			get { return totalqty; }
			set { totalqty = value; }
		}

		/// <summary>
		/// Gets or sets the ParentProductID value.
		/// </summary>
		public long ParentProductID
		{
			get { return parentProductID; }
			set { parentProductID = value; }
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
		/// Gets or sets the InverseQty value.
		/// </summary>
		public decimal InverseQty
		{
			get { return inverseQty; }
			set { inverseQty = value; }
		}

		/// <summary>
		/// Gets or sets the ProductName value.
		/// </summary>
		string _productname;
		public string ProductName
		{
			get { return _productname; }
			set { _productname = value; }
		}

		/// <summary>
		/// Gets or sets the PurchaseOrderDate value.
		/// </summary>
		DateTime _purchaseorderdate;
		public DateTime PurchaseOrderDate
		{
			get { return _purchaseorderdate; }
			set { _purchaseorderdate = value; }
		}


		#endregion
}
}
