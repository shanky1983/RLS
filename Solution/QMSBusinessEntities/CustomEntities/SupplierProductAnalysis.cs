using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class SupplierProductAnalysis
	{
		#region Fields

		private int supplierID=0;
		private string supplierName=String.Empty;
		private int pOCount=0;
		private int sRDCount=0;
		private int cancelledPOCount=0;
        private DateTime lastPODate = DateTime.MaxValue;
        private DateTime lastSRDDate = DateTime.MaxValue;
		private string pONumber=String.Empty;
		private string sRDNumber=String.Empty;
		private long productID=0;
		private string productName=String.Empty;
		private decimal orderedQuantity=Decimal.Zero;
		private decimal receivedQuantity=Decimal.Zero;
		private decimal complimentQuantity=Decimal.Zero;
		private decimal unitPrice=Decimal.Zero;
		private decimal totalCost=Decimal.Zero;
		private int frequency=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SupplierID value.
		/// </summary>
		public int SupplierID
		{
			get { return supplierID; }
			set { supplierID = value; }
		}

		/// <summary>
		/// Gets or sets the SupplierName value.
		/// </summary>
		public string SupplierName
		{
			get { return supplierName; }
			set { supplierName = value; }
		}

		/// <summary>
		/// Gets or sets the POCount value.
		/// </summary>
		public int POCount
		{
			get { return pOCount; }
			set { pOCount = value; }
		}

		/// <summary>
		/// Gets or sets the SRDCount value.
		/// </summary>
		public int SRDCount
		{
			get { return sRDCount; }
			set { sRDCount = value; }
		}

		/// <summary>
		/// Gets or sets the CancelledPOCount value.
		/// </summary>
		public int CancelledPOCount
		{
			get { return cancelledPOCount; }
			set { cancelledPOCount = value; }
		}

		/// <summary>
		/// Gets or sets the LastPODate value.
		/// </summary>
		public DateTime LastPODate
		{
			get { return lastPODate; }
			set { lastPODate = value; }
		}

		/// <summary>
		/// Gets or sets the LastSRDDate value.
		/// </summary>
		public DateTime LastSRDDate
		{
			get { return lastSRDDate; }
			set { lastSRDDate = value; }
		}

		/// <summary>
		/// Gets or sets the PONumber value.
		/// </summary>
		public string PONumber
		{
			get { return pONumber; }
			set { pONumber = value; }
		}

		/// <summary>
		/// Gets or sets the SRDNumber value.
		/// </summary>
		public string SRDNumber
		{
			get { return sRDNumber; }
			set { sRDNumber = value; }
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
		/// Gets or sets the OrderedQuantity value.
		/// </summary>
		public decimal OrderedQuantity
		{
			get { return orderedQuantity; }
			set { orderedQuantity = value; }
		}

		/// <summary>
		/// Gets or sets the ReceivedQuantity value.
		/// </summary>
		public decimal ReceivedQuantity
		{
			get { return receivedQuantity; }
			set { receivedQuantity = value; }
		}

		/// <summary>
		/// Gets or sets the ComplimentQuantity value.
		/// </summary>
		public decimal ComplimentQuantity
		{
			get { return complimentQuantity; }
			set { complimentQuantity = value; }
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
		/// Gets or sets the TotalCost value.
		/// </summary>
		public decimal TotalCost
		{
			get { return totalCost; }
			set { totalCost = value; }
		}

		/// <summary>
		/// Gets or sets the Frequency value.
		/// </summary>
		public int Frequency
		{
			get { return frequency; }
			set { frequency = value; }
		}


		#endregion
}
}
