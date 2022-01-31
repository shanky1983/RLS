using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PurchaseOrderMappingLocation
	{
		#region Fields

		private long pOMappingID=0;
		private long pOID=0;
		private long pODetailsID=0;
		private DateTime deliveryDate=DateTime.MaxValue;
		private int locationId=0;
		private decimal quantity=Decimal.Zero;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private DateTime modifiedBy=DateTime.MaxValue;
		private int orgId=0;
		private long orgAddressId=0;
		private string units=String.Empty;
		private long productID=0;
		private long supplierId=0;
		private int toLocationID=0;
		private int trustedOrgID=0;
		private string status=String.Empty;
		private decimal compQty=Decimal.Zero;
		private decimal discount=Decimal.Zero;
		private decimal vat=Decimal.Zero;
		private decimal amount=Decimal.Zero;
		private decimal rate=Decimal.Zero;
		private decimal sellingPrice=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the POMappingID value.
		/// </summary>
		public long POMappingID
		{
			get { return pOMappingID; }
			set { pOMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the POID value.
		/// </summary>
		public long POID
		{
			get { return pOID; }
			set { pOID = value; }
		}

		/// <summary>
		/// Gets or sets the PODetailsID value.
		/// </summary>
		public long PODetailsID
		{
			get { return pODetailsID; }
			set { pODetailsID = value; }
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
		/// Gets or sets the LocationId value.
		/// </summary>
		public int LocationId
		{
			get { return locationId; }
			set { locationId = value; }
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
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
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
		public DateTime ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
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
		/// Gets or sets the OrgAddressId value.
		/// </summary>
		public long OrgAddressId
		{
			get { return orgAddressId; }
			set { orgAddressId = value; }
		}

		/// <summary>
		/// Gets or sets the Units value.
		/// </summary>
		public string Units
		{
			get { return units; }
			set { units = value; }
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
		/// Gets or sets the SupplierId value.
		/// </summary>
		public long SupplierId
		{
			get { return supplierId; }
			set { supplierId = value; }
		}

		/// <summary>
		/// Gets or sets the ToLocationID value.
		/// </summary>
		public int ToLocationID
		{
			get { return toLocationID; }
			set { toLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the TrustedOrgID value.
		/// </summary>
		public int TrustedOrgID
		{
			get { return trustedOrgID; }
			set { trustedOrgID = value; }
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
		/// Gets or sets the CompQty value.
		/// </summary>
		public decimal CompQty
		{
			get { return compQty; }
			set { compQty = value; }
		}

		/// <summary>
		/// Gets or sets the Discount value.
		/// </summary>
		public decimal Discount
		{
			get { return discount; }
			set { discount = value; }
		}

		/// <summary>
		/// Gets or sets the Vat value.
		/// </summary>
		public decimal Vat
		{
			get { return vat; }
			set { vat = value; }
		}

		/// <summary>
		/// Gets or sets the Amount value.
		/// </summary>
		public decimal Amount
		{
			get { return amount; }
			set { amount = value; }
		}

		/// <summary>
		/// Gets or sets the Rate value.
		/// </summary>
		public decimal Rate
		{
			get { return rate; }
			set { rate = value; }
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
		/// Gets or sets the SupplierName value.
		/// </summary>
		string _suppliername;
		public string SupplierName
		{
			get { return _suppliername; }
			set { _suppliername = value; }
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
		/// Gets or sets the LocationName value.
		/// </summary>
		string _locationname;
		public string LocationName
		{
			get { return _locationname; }
			set { _locationname = value; }
		}

		/// <summary>
		/// Gets or sets the PurchaseOrderNo value.
		/// </summary>
		string _purchaseorderno;
		public string PurchaseOrderNo
		{
			get { return _purchaseorderno; }
			set { _purchaseorderno = value; }
		}

		/// <summary>
		/// Gets or sets the Comments value.
		/// </summary>
		string _comments;
		public string Comments
		{
			get { return _comments; }
			set { _comments = value; }
		}

		/// <summary>
		/// Gets or sets the LSU value.
		/// </summary>
		string _lsu;
		public string LSU
		{
			get { return _lsu; }
			set { _lsu = value; }
		}


		#endregion
}
}
