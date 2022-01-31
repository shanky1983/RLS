using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class MatchingStockReceiveddetails
	{
		#region Fields

		private long viewStockReceivedDetailsId=0;
		private long viewStockReceivedId=0;
		private long stockReceivedId=0;
		private int orgID=0;
		private int categoryId=0;
		private long productId=0;
		private string batchNo=String.Empty;
		private DateTime expiryDate=DateTime.MaxValue;
		private DateTime manufacture=DateTime.MaxValue;
		private decimal pOQuantity=Decimal.Zero;
		private decimal complimentQTY=Decimal.Zero;
		private decimal tax=Decimal.Zero;
		private decimal discount=Decimal.Zero;
		private string pOUnit=String.Empty;
		private decimal totalCost=Decimal.Zero;
		private decimal unitPrice=Decimal.Zero;
		private decimal sellingPrice=Decimal.Zero;
		private decimal rECQuantity=Decimal.Zero;
		private string rECUnit=String.Empty;
		private int orgAddressID=0;
		private string sellingUnit=String.Empty;
		private decimal invoiceQty=Decimal.Zero;
		private decimal rcvdLSUQty=Decimal.Zero;
		private DateTime stockReceivedDate=DateTime.MaxValue;
		private int locationID=0;
		private string attributeDetail=String.Empty;
		private decimal unitSellingPrice=Decimal.Zero;
		private decimal unitCostPrice=Decimal.Zero;
		private string rakNo=String.Empty;
		private decimal mRP=Decimal.Zero;
		private string status=String.Empty;
		private decimal exciseTax=Decimal.Zero;
		private string productKey=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ViewStockReceivedDetailsId value.
		/// </summary>
		public long ViewStockReceivedDetailsId
		{
			get { return viewStockReceivedDetailsId; }
			set { viewStockReceivedDetailsId = value; }
		}

		/// <summary>
		/// Gets or sets the ViewStockReceivedId value.
		/// </summary>
		public long ViewStockReceivedId
		{
			get { return viewStockReceivedId; }
			set { viewStockReceivedId = value; }
		}

		/// <summary>
		/// Gets or sets the StockReceivedId value.
		/// </summary>
		public long StockReceivedId
		{
			get { return stockReceivedId; }
			set { stockReceivedId = value; }
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
		/// Gets or sets the CategoryId value.
		/// </summary>
		public int CategoryId
		{
			get { return categoryId; }
			set { categoryId = value; }
		}

		/// <summary>
		/// Gets or sets the ProductId value.
		/// </summary>
		public long ProductId
		{
			get { return productId; }
			set { productId = value; }
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
		/// Gets or sets the Manufacture value.
		/// </summary>
		public DateTime Manufacture
		{
			get { return manufacture; }
			set { manufacture = value; }
		}

		/// <summary>
		/// Gets or sets the POQuantity value.
		/// </summary>
		public decimal POQuantity
		{
			get { return pOQuantity; }
			set { pOQuantity = value; }
		}

		/// <summary>
		/// Gets or sets the ComplimentQTY value.
		/// </summary>
		public decimal ComplimentQTY
		{
			get { return complimentQTY; }
			set { complimentQTY = value; }
		}

		/// <summary>
		/// Gets or sets the Tax value.
		/// </summary>
		public decimal Tax
		{
			get { return tax; }
			set { tax = value; }
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
		/// Gets or sets the POUnit value.
		/// </summary>
		public string POUnit
		{
			get { return pOUnit; }
			set { pOUnit = value; }
		}

		/// <summary>
		/// Gets or sets the TotalCost value.
		/// </summary>
		public decimal TotalCost
		{
			get { return totalCost; }
			set { totalCost = value; }
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
		/// Gets or sets the SellingPrice value.
		/// </summary>
		public decimal SellingPrice
		{
			get { return sellingPrice; }
			set { sellingPrice = value; }
		}

		/// <summary>
		/// Gets or sets the RECQuantity value.
		/// </summary>
		public decimal RECQuantity
		{
			get { return rECQuantity; }
			set { rECQuantity = value; }
		}

		/// <summary>
		/// Gets or sets the RECUnit value.
		/// </summary>
		public string RECUnit
		{
			get { return rECUnit; }
			set { rECUnit = value; }
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
		/// Gets or sets the SellingUnit value.
		/// </summary>
		public string SellingUnit
		{
			get { return sellingUnit; }
			set { sellingUnit = value; }
		}

		/// <summary>
		/// Gets or sets the InvoiceQty value.
		/// </summary>
		public decimal InvoiceQty
		{
			get { return invoiceQty; }
			set { invoiceQty = value; }
		}

		/// <summary>
		/// Gets or sets the RcvdLSUQty value.
		/// </summary>
		public decimal RcvdLSUQty
		{
			get { return rcvdLSUQty; }
			set { rcvdLSUQty = value; }
		}

		/// <summary>
		/// Gets or sets the StockReceivedDate value.
		/// </summary>
		public DateTime StockReceivedDate
		{
			get { return stockReceivedDate; }
			set { stockReceivedDate = value; }
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
		/// Gets or sets the AttributeDetail value.
		/// </summary>
		public string AttributeDetail
		{
			get { return attributeDetail; }
			set { attributeDetail = value; }
		}

		/// <summary>
		/// Gets or sets the UnitSellingPrice value.
		/// </summary>
		public decimal UnitSellingPrice
		{
			get { return unitSellingPrice; }
			set { unitSellingPrice = value; }
		}

		/// <summary>
		/// Gets or sets the UnitCostPrice value.
		/// </summary>
		public decimal UnitCostPrice
		{
			get { return unitCostPrice; }
			set { unitCostPrice = value; }
		}

		/// <summary>
		/// Gets or sets the RakNo value.
		/// </summary>
		public string RakNo
		{
			get { return rakNo; }
			set { rakNo = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the ExciseTax value.
		/// </summary>
		public decimal ExciseTax
		{
			get { return exciseTax; }
			set { exciseTax = value; }
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
