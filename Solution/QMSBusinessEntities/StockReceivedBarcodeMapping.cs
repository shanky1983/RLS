using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class StockReceivedBarcodeMapping
	{
		#region Fields

		private int barcodeMappingId=0;
		private long productID=0;
		private string productKey=String.Empty;
		private string barcode=String.Empty;
		private int unitSize=0;
		private string unit=String.Empty;
		private long stockReceivedDetailsId=0;
		private long stockOutFlowId=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BarcodeMappingId value.
		/// </summary>
		public int BarcodeMappingId
		{
			get { return barcodeMappingId; }
			set { barcodeMappingId = value; }
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
		/// Gets or sets the ProductKey value.
		/// </summary>
		public string ProductKey
		{
			get { return productKey; }
			set { productKey = value; }
		}

		/// <summary>
		/// Gets or sets the Barcode value.
		/// </summary>
		public string Barcode
		{
			get { return barcode; }
			set { barcode = value; }
		}

		/// <summary>
		/// Gets or sets the UnitSize value.
		/// </summary>
		public int UnitSize
		{
			get { return unitSize; }
			set { unitSize = value; }
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
		/// Gets or sets the StockReceivedDetailsId value.
		/// </summary>
		public long StockReceivedDetailsId
		{
			get { return stockReceivedDetailsId; }
			set { stockReceivedDetailsId = value; }
		}

		/// <summary>
		/// Gets or sets the StockOutFlowId value.
		/// </summary>
		public long StockOutFlowId
		{
			get { return stockOutFlowId; }
			set { stockOutFlowId = value; }
		}


		#endregion
}
}
