using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ProductLegendSummary
	{
		#region Fields

		private long productId=0;
		private string productName=String.Empty;
        private DateTime transactionDate = DateTime.MaxValue;
		private decimal openingBalance=Decimal.Zero;
		private decimal closingBalance=Decimal.Zero;
		private decimal openingStockValue=Decimal.Zero;
		private decimal closingStockValue=Decimal.Zero;
		private decimal stockReceived=Decimal.Zero;
		private decimal stockIssued=Decimal.Zero;
		private decimal stockDamage=Decimal.Zero;
		private decimal stockReturn=Decimal.Zero;
		private string sRDNo=String.Empty;
		private string receivedFrom=String.Empty;
		private string issuedTo=String.Empty;
		private long billId=0;
		private string billNo=String.Empty;
		private string units=String.Empty;
        private string patientName = String.Empty;
        private string issueLocation = String.Empty;
        private string receiveLocation = String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ProductId value.
		/// </summary>
		public long ProductId
		{
			get { return productId; }
			set { productId = value; }
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
		/// Gets or sets the TransactionDate value.
		/// </summary>
		public DateTime TransactionDate
		{
			get { return transactionDate; }
			set { transactionDate = value; }
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
		/// Gets or sets the ClosingBalance value.
		/// </summary>
		public decimal ClosingBalance
		{
			get { return closingBalance; }
			set { closingBalance = value; }
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
		/// Gets or sets the SRDNo value.
		/// </summary>
		public string SRDNo
		{
			get { return sRDNo; }
			set { sRDNo = value; }
		}

		/// <summary>
		/// Gets or sets the ReceivedFrom value.
		/// </summary>
		public string ReceivedFrom
		{
			get { return receivedFrom; }
			set { receivedFrom = value; }
		}

		/// <summary>
		/// Gets or sets the IssuedTo value.
		/// </summary>
		public string IssuedTo
		{
			get { return issuedTo; }
			set { issuedTo = value; }
		}

		/// <summary>
		/// Gets or sets the BillId value.
		/// </summary>
		public long BillId
		{
			get { return billId; }
			set { billId = value; }
		}

		/// <summary>
		/// Gets or sets the BillNo value.
		/// </summary>
		public string BillNo
		{
			get { return billNo; }
			set { billNo = value; }
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
        /// Gets or sets the PatientName value.
        /// </summary>
        public string PatientName
        {
            get { return patientName; }
            set { patientName = value; }
        }

        /// <summary>
        /// Gets or sets the IssueLocation value.
        /// </summary>
        public string IssueLocation
        {
            get { return issueLocation; }
            set { issueLocation = value; }
        }


        /// <summary>
        /// Gets or sets the ReceiveLocation value.
        /// </summary>
        public string ReceiveLocation
        {
            get { return receiveLocation; }
            set { receiveLocation = value; }
        }


		#endregion
}
}
