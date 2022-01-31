using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Audit_ProductSupplierRateMapping
	{
		#region Fields

		private long auditProductMappingID=0;
		private long productID=0;
		private long supplierID=0;
		private string unit=String.Empty;
		private long inverseQty=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgid=0;
		private string isDefault=String.Empty;
		private decimal rate=Decimal.Zero;
		private string type=String.Empty;
		private string conUnit=String.Empty;
		private long productMappingID=0;
		private long audit_Createdby=0;
		private DateTime audit_CreatedAt=DateTime.MaxValue;
		private string status=String.Empty;
		private long quotationID=0;
		private decimal mRP=Decimal.Zero;
		private decimal sellingPrice=Decimal.Zero;
		private decimal discount=Decimal.Zero;
		private decimal tax=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AuditProductMappingID value.
		/// </summary>
		public long AuditProductMappingID
		{
			get { return auditProductMappingID; }
			set { auditProductMappingID = value; }
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
		/// Gets or sets the SupplierID value.
		/// </summary>
		public long SupplierID
		{
			get { return supplierID; }
			set { supplierID = value; }
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
		/// Gets or sets the InverseQty value.
		/// </summary>
		public long InverseQty
		{
			get { return inverseQty; }
			set { inverseQty = value; }
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
		/// Gets or sets the Orgid value.
		/// </summary>
		public int Orgid
		{
			get { return orgid; }
			set { orgid = value; }
		}

		/// <summary>
		/// Gets or sets the IsDefault value.
		/// </summary>
		public string IsDefault
		{
			get { return isDefault; }
			set { isDefault = value; }
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
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the ConUnit value.
		/// </summary>
		public string ConUnit
		{
			get { return conUnit; }
			set { conUnit = value; }
		}

		/// <summary>
		/// Gets or sets the ProductMappingID value.
		/// </summary>
		public long ProductMappingID
		{
			get { return productMappingID; }
			set { productMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the Audit_Createdby value.
		/// </summary>
		public long Audit_Createdby
		{
			get { return audit_Createdby; }
			set { audit_Createdby = value; }
		}

		/// <summary>
		/// Gets or sets the Audit_CreatedAt value.
		/// </summary>
		public DateTime Audit_CreatedAt
		{
			get { return audit_CreatedAt; }
			set { audit_CreatedAt = value; }
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
		/// Gets or sets the QuotationID value.
		/// </summary>
		public long QuotationID
		{
			get { return quotationID; }
			set { quotationID = value; }
		}

		/// <summary>
		/// Gets or sets the MRP value.
		/// </summary>
		public decimal MRP
		{
			get { return mRP; }
			set { mRP = value; }
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
		/// Gets or sets the Discount value.
		/// </summary>
		public decimal Discount
		{
			get { return discount; }
			set { discount = value; }
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
