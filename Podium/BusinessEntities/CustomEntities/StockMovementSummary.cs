using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class StockMovementSummary
	{
		#region Fields

		private long productID=0;
		private string productName=String.Empty;
		private decimal openingBalance=Decimal.Zero;
		private decimal stockReceived=Decimal.Zero;
		private decimal stockIssued=Decimal.Zero;
		private decimal stockDamage=Decimal.Zero;
		private decimal stockReturn=Decimal.Zero;
		private decimal closingBalance=Decimal.Zero;
		private decimal currentSellingPrice=Decimal.Zero;
        private decimal costprice = Decimal.Zero;
        private decimal sellingprice = Decimal.Zero;
		private string units=String.Empty;
		private decimal openingStockValue=Decimal.Zero;
		private decimal closingStockValue=Decimal.Zero;
        private decimal openingStockValueCP = Decimal.Zero;
        private decimal closingStockValueCP = Decimal.Zero;
        private DateTime tDate = DateTime.MaxValue;
        private string srdNo = String.Empty;
        private string batchNo = String.Empty;
        private string supplierName = String.Empty;
        private int locationID = 0;
        private int categoryID = 0;
        private DateTime expireddate = DateTime.MaxValue;
        public decimal StockPercent { get; set; }
        private decimal stockExpiryDate = Decimal.Zero;
        private decimal adhoc = Decimal.Zero;
        private decimal stockTransfer = Decimal.Zero;
        private decimal receivedStockValue;
        private decimal receivedStockValueCP;
        private decimal issuedStockValue;
        private decimal issuedStockValueCP;
        private string locationName = String.Empty;
        private string mfgName = String.Empty;
		#endregion

		#region Properties


        public string LocationName
        {
            get { return locationName; }
            set { locationName = value; }
        }

        public int LocationID
        {
            get { return locationID; }
            set { locationID = value; }
        }
        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        /// <summary>
        /// Gets or sets the CreatedAt value.
        /// </summary>
        public DateTime TDate
        {
            get { return tDate; }
            set { tDate = value; }
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
		/// Gets or sets the ProductName value.
		/// </summary>
		public string ProductName
		{
			get { return productName; }
			set { productName = value; }
		}

		/// <summary>
		/// Gets or sets the OpeningBalance value.
		/// </summary>
		public decimal OpeningBalance
		{
			get { return openingBalance; }
			set { openingBalance = value; }
		}

		/// <summary>
		/// Gets or sets the StockReceived value.
		/// </summary>
		public decimal StockReceived
		{
			get { return stockReceived; }
			set { stockReceived = value; }
		}

		/// <summary>
		/// Gets or sets the StockIssued value.
		/// </summary>
		public decimal StockIssued
		{
			get { return stockIssued; }
			set { stockIssued = value; }
		}

		/// <summary>
		/// Gets or sets the StockDamage value.
		/// </summary>
		public decimal StockDamage
		{
			get { return stockDamage; }
			set { stockDamage = value; }
		}

		/// <summary>
		/// Gets or sets the StockReturn value.
		/// </summary>
		public decimal StockReturn
		{
			get { return stockReturn; }
			set { stockReturn = value; }
		}

		/// <summary>
		/// Gets or sets the ClosingBalance value.
		/// </summary>
		public decimal ClosingBalance
		{
			get { return closingBalance; }
			set { closingBalance = value; }
		}

		/// <summary>
		/// Gets or sets the CurrentSellingPrice value.
		/// </summary>
		public decimal CurrentSellingPrice
		{
			get { return currentSellingPrice; }
			set { currentSellingPrice = value; }
		}

        public decimal CostPrice
        {
            get { return costprice ; }
            set { costprice  = value; }
        }

        public decimal SellingPrice
        {
            get { return sellingprice ; }
            set { sellingprice = value; }
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
		/// Gets or sets the OpeningStockValue value.
		/// </summary>
		public decimal OpeningStockValue
		{
			get { return openingStockValue; }
			set { openingStockValue = value; }
		}

		/// <summary>
		/// Gets or sets the ClosingStockValue value.
		/// </summary>
		public decimal ClosingStockValue
		{
			get { return closingStockValue; }
			set { closingStockValue = value; }
		}

        /// <summary>
        /// Gets or sets the OpeningStockValue value.
        /// </summary>
        public decimal OpeningStockValueCP
        {
            get { return openingStockValueCP; }
            set { openingStockValueCP = value; }
        }

        /// <summary>
        /// Gets or sets the ClosingStockValue value.
        /// </summary>
        public decimal ClosingStockValueCP
        {
            get { return closingStockValueCP; }
            set { closingStockValueCP = value; }
        }

        /// <summary>
        /// Gets or sets the SRDNo value.
        /// </summary>
        public string SRDNo
        {
            get { return srdNo; }
            set { srdNo = value; }
        }

        public string BatchNo
        {
            get { return batchNo ; }
            set { batchNo  = value; }
        }
        /// <summary>
        /// Gets or sets the SupplierName value.
        /// </summary>
        public string SupplierName
        {
            get { return supplierName; }
            set { supplierName = value; }
        }
        public DateTime ExpiredDate
        {
            get { return expireddate; }
            set { expireddate = value; }
        }
        public decimal StockExpiryDate
        {
            get { return stockExpiryDate; }
            set { stockExpiryDate = value; }
        }
        public decimal Adhoc
        {
            get { return adhoc; }
            set { adhoc = value; }
        }
        public decimal StockTransfer
        {
            get { return stockTransfer; }
            set { stockTransfer = value; }
        }

        public decimal ReceivedStockValue
        {
            get
            {
                return receivedStockValue;
            }
            set
            {
                receivedStockValue = value;
            }
        }
        public decimal ReceivedStockValueCP
        {
            get
            {
                return receivedStockValueCP;
            }
            set
            {
                receivedStockValueCP = value;
            }
        }
        public decimal IssuedStockValue
        {
            get
            {
                return issuedStockValue;
            }
            set
            {
                issuedStockValue = value;
            }
        }
        public decimal IssuedStockValueCP
        {
            get
            {
                return issuedStockValueCP;
            }
            set
            {
                issuedStockValueCP = value;
            }
        }
        public string MfgName
        {
            get
            {
                return mfgName;
            }
            set
            {
                mfgName = value;
            }
        }
        public string ProductCode { get; set; }
        public string CategoryName { get; set; }
        public decimal StockUsage { get; set; }


		#endregion
}
}
