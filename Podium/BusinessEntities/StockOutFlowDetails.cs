using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class StockOutFlowDetails
	{
		#region Fields

		private long stockOutFlowDetailsID=0;
		private long stockOutFlowID=0;
		private int orgID=0;
		private long orgAddressID=0;
		private long productID=0;
		private decimal quantity=Decimal.Zero;
		private string unit=String.Empty;
		private string description=String.Empty;
		private DateTime stockOutFlowDate=DateTime.MaxValue;
		private int locationID=0;
		private long detailID=0;
		private string type=String.Empty;
		private long parentProductID=0;
		private decimal discountvalue=Decimal.Zero;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private long productReceivedDetailsID=0;
		private long receivedUniqueNumber=0;
		private string attributeDetail=String.Empty;
		private string batchNo=String.Empty;
		private decimal unitPrice=Decimal.Zero;
		private decimal taxPercent=Decimal.Zero;
		private decimal sellingPrice=Decimal.Zero;
		private DateTime expiryDate=DateTime.MaxValue;
		private string productKey=String.Empty;
		private int raiseOrgID=0;
		private int raiseOrgAddID=0;
		private long kitID=0;
		private decimal mRP=Decimal.Zero;
		private decimal totalCost=Decimal.Zero;
		private decimal totalMRP=Decimal.Zero;
		private decimal taxvalues=Decimal.Zero;
		private decimal exciesDuty=Decimal.Zero;
		private decimal cSTax=Decimal.Zero;
		private decimal cSTAmount=Decimal.Zero;
		private DateTime manufacture=DateTime.MaxValue;
		private int cLocationID=0;
		private decimal discount=Decimal.Zero;
		private decimal returnqty=Decimal.Zero;
		private long barcodeDetailsId=0;
		private long barcodeId=0;
		private string barcodeNo=String.Empty;
		private string remarks=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the StockOutFlowDetailsID value.
		/// </summary>
		public long StockOutFlowDetailsID
		{
			get { return stockOutFlowDetailsID; }
			set { stockOutFlowDetailsID = value; }
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
		/// Gets or sets the StockOutFlowDate value.
		/// </summary>
		public DateTime StockOutFlowDate
		{
			get { return stockOutFlowDate; }
			set { stockOutFlowDate = value; }
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
		/// Gets or sets the DetailID value.
		/// </summary>
		public long DetailID
		{
			get { return detailID; }
			set { detailID = value; }
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
		/// Gets or sets the ParentProductID value.
		/// </summary>
		public long ParentProductID
		{
			get { return parentProductID; }
			set { parentProductID = value; }
		}

		/// <summary>
		/// Gets or sets the Discountvalue value.
		/// </summary>
		public decimal Discountvalue
		{
			get { return discountvalue; }
			set { discountvalue = value; }
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

		/// <summary>
		/// Gets or sets the ProductReceivedDetailsID value.
		/// </summary>
		public long ProductReceivedDetailsID
		{
			get { return productReceivedDetailsID; }
			set { productReceivedDetailsID = value; }
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
		/// Gets or sets the AttributeDetail value.
		/// </summary>
		public string AttributeDetail
		{
			get { return attributeDetail; }
			set { attributeDetail = value; }
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
		/// Gets or sets the SellingPrice value.
		/// </summary>
		public decimal SellingPrice
		{
			get { return sellingPrice; }
			set { sellingPrice = value; }
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
		/// Gets or sets the ProductKey value.
		/// </summary>
		public string ProductKey
		{
			get { return productKey; }
			set { productKey = value; }
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
		/// Gets or sets the KitID value.
		/// </summary>
		public long KitID
		{
			get { return kitID; }
			set { kitID = value; }
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
		/// Gets or sets the TotalCost value.
		/// </summary>
		public decimal TotalCost
		{
			get { return totalCost; }
			set { totalCost = value; }
		}

		/// <summary>
		/// Gets or sets the TotalMRP value.
		/// </summary>
		public decimal TotalMRP
		{
			get { return totalMRP; }
			set { totalMRP = value; }
		}

		/// <summary>
		/// Gets or sets the Taxvalues value.
		/// </summary>
		public decimal Taxvalues
		{
			get { return taxvalues; }
			set { taxvalues = value; }
		}

		/// <summary>
		/// Gets or sets the ExciesDuty value.
		/// </summary>
		public decimal ExciesDuty
		{
			get { return exciesDuty; }
			set { exciesDuty = value; }
		}

		/// <summary>
		/// Gets or sets the CSTax value.
		/// </summary>
		public decimal CSTax
		{
			get { return cSTax; }
			set { cSTax = value; }
		}

		/// <summary>
		/// Gets or sets the CSTAmount value.
		/// </summary>
		public decimal CSTAmount
		{
			get { return cSTAmount; }
			set { cSTAmount = value; }
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
		/// Gets or sets the CLocationID value.
		/// </summary>
		public int CLocationID
		{
			get { return cLocationID; }
			set { cLocationID = value; }
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
		/// Gets or sets the Returnqty value.
		/// </summary>
		public decimal Returnqty
		{
			get { return returnqty; }
			set { returnqty = value; }
		}

		/// <summary>
		/// Gets or sets the BarcodeDetailsId value.
		/// </summary>
		public long BarcodeDetailsId
		{
			get { return barcodeDetailsId; }
			set { barcodeDetailsId = value; }
		}

		/// <summary>
		/// Gets or sets the BarcodeId value.
		/// </summary>
		public long BarcodeId
		{
			get { return barcodeId; }
			set { barcodeId = value; }
		}

		/// <summary>
		/// Gets or sets the BarcodeNo value.
		/// </summary>
		public string BarcodeNo
		{
			get { return barcodeNo; }
			set { barcodeNo = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
		}


		#endregion
}
}
