using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class StockInHand
	{
		#region Fields

		private long productID=0;
		private int orgID=0;
		private decimal totalStockReceived=Decimal.Zero;
		private decimal totalStockIssued=Decimal.Zero;
		private decimal totalStockReturn=Decimal.Zero;
		private decimal totalStockDamage=Decimal.Zero;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgAddressID=0;
		private string batchNo=String.Empty;
		private DateTime expiryDate=DateTime.MaxValue;
		private decimal tax=Decimal.Zero;
		private decimal sellingPrice=Decimal.Zero;
		private string sellingUnit=String.Empty;
		private int locationID=0;
		private decimal totalLocationIssued=Decimal.Zero;
		private string rakNo=String.Empty;
		private decimal mRP=Decimal.Zero;
		private decimal costPrice=Decimal.Zero;
		private long stockInHandid=0;
		private decimal substoreReturnqty=Decimal.Zero;
		private long productReceivedDetailsID=0;
		private long receivedUniqueNumber=0;
		private string attributeDetail=String.Empty;
		private int totalUsageLimit=0;
		private int totalUsedSoFor=0;
		private string productKey=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ProductID value.
		/// </summary>
		public long ProductID
		{
			get { return productID; }
			set { productID = value; }
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
		/// Gets or sets the TotalStockReceived value.
		/// </summary>
		public decimal TotalStockReceived
		{
			get { return totalStockReceived; }
			set { totalStockReceived = value; }
		}

		/// <summary>
		/// Gets or sets the TotalStockIssued value.
		/// </summary>
		public decimal TotalStockIssued
		{
			get { return totalStockIssued; }
			set { totalStockIssued = value; }
		}

		/// <summary>
		/// Gets or sets the TotalStockReturn value.
		/// </summary>
		public decimal TotalStockReturn
		{
			get { return totalStockReturn; }
			set { totalStockReturn = value; }
		}

		/// <summary>
		/// Gets or sets the TotalStockDamage value.
		/// </summary>
		public decimal TotalStockDamage
		{
			get { return totalStockDamage; }
			set { totalStockDamage = value; }
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
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public int OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
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
		/// Gets or sets the Tax value.
		/// </summary>
		public decimal Tax
		{
			get { return tax; }
			set { tax = value; }
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
		/// Gets or sets the LocationID value.
		/// </summary>
		public int LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the TotalLocationIssued value.
		/// </summary>
		public decimal TotalLocationIssued
		{
			get { return totalLocationIssued; }
			set { totalLocationIssued = value; }
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
		/// Gets or sets the CostPrice value.
		/// </summary>
		public decimal CostPrice
		{
			get { return costPrice; }
			set { costPrice = value; }
		}

		/// <summary>
		/// Gets or sets the StockInHandid value.
		/// </summary>
		public long StockInHandid
		{
			get { return stockInHandid; }
			set { stockInHandid = value; }
		}

		/// <summary>
		/// Gets or sets the SubstoreReturnqty value.
		/// </summary>
		public decimal SubstoreReturnqty
		{
			get { return substoreReturnqty; }
			set { substoreReturnqty = value; }
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
		/// Gets or sets the TotalUsageLimit value.
		/// </summary>
		public int TotalUsageLimit
		{
			get { return totalUsageLimit; }
			set { totalUsageLimit = value; }
		}

		/// <summary>
		/// Gets or sets the TotalUsedSoFor value.
		/// </summary>
		public int TotalUsedSoFor
		{
			get { return totalUsedSoFor; }
			set { totalUsedSoFor = value; }
		}

		/// <summary>
		/// Gets or sets the ProductKey value.
		/// </summary>
		public string ProductKey
		{
			get { return productKey; }
			set { productKey = value; }
		}


		#endregion
}
}
