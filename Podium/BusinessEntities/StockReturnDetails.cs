using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class StockReturnDetails
	{
		#region Fields

		private long stockReturnDetailsID=0;
		private long stockReturnID=0;
		private long stockReceivedID=0;
		private long productID=0;
		private string batchNo=String.Empty;
		private decimal quantity=Decimal.Zero;
		private decimal costPrice=Decimal.Zero;
		private decimal amount=Decimal.Zero;
		private long stockOuFlowID=0;
		private string unit=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private decimal pOReturnQty=Decimal.Zero;
		private decimal pOReturnCompQTY=Decimal.Zero;
		private long productReceivedDetailsID=0;
		private long receivedUniqueNumber=0;
		private string productKey=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the StockReturnDetailsID value.
		/// </summary>
		public long StockReturnDetailsID
		{
			get { return stockReturnDetailsID; }
			set { stockReturnDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the StockReturnID value.
		/// </summary>
		public long StockReturnID
		{
			get { return stockReturnID; }
			set { stockReturnID = value; }
		}

		/// <summary>
		/// Gets or sets the StockReceivedID value.
		/// </summary>
		public long StockReceivedID
		{
			get { return stockReceivedID; }
			set { stockReceivedID = value; }
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
		/// Gets or sets the BatchNo value.
		/// </summary>
		public string BatchNo
		{
			get { return batchNo; }
			set { batchNo = value; }
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
		/// Gets or sets the CostPrice value.
		/// </summary>
		public decimal CostPrice
		{
			get { return costPrice; }
			set { costPrice = value; }
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
		/// Gets or sets the StockOuFlowID value.
		/// </summary>
		public long StockOuFlowID
		{
			get { return stockOuFlowID; }
			set { stockOuFlowID = value; }
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
		/// Gets or sets the POReturnQty value.
		/// </summary>
		public decimal POReturnQty
		{
			get { return pOReturnQty; }
			set { pOReturnQty = value; }
		}

		/// <summary>
		/// Gets or sets the POReturnCompQTY value.
		/// </summary>
		public decimal POReturnCompQTY
		{
			get { return pOReturnCompQTY; }
			set { pOReturnCompQTY = value; }
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
