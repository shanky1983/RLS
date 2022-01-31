using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class StockReceivedBarcodeDetails
	{
		#region Fields

		private long stockReceivedBarcodeDetailsID=0;
		private long stockReceivedBarcodeID=0;
		private long receivedUniqueNumber=0;
		private string barcodeNo=String.Empty;
		private int orgID=0;
		private int locationID=0;
		private string issuedStatus=String.Empty;
		private long stockOutFlowDetailsID=0;
		private string isUniqueBarcode=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the StockReceivedBarcodeDetailsID value.
		/// </summary>
		public long StockReceivedBarcodeDetailsID
		{
			get { return stockReceivedBarcodeDetailsID; }
			set { stockReceivedBarcodeDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the StockReceivedBarcodeID value.
		/// </summary>
		public long StockReceivedBarcodeID
		{
			get { return stockReceivedBarcodeID; }
			set { stockReceivedBarcodeID = value; }
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
		/// Gets or sets the BarcodeNo value.
		/// </summary>
		public string BarcodeNo
		{
			get { return barcodeNo; }
			set { barcodeNo = value; }
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
		/// Gets or sets the LocationID value.
		/// </summary>
		public int LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the IssuedStatus value.
		/// </summary>
		public string IssuedStatus
		{
			get { return issuedStatus; }
			set { issuedStatus = value; }
		}

		/// <summary>
		/// Gets or sets the StockOutFlowDetailsID value.
		/// </summary>
		public long StockOutFlowDetailsID
		{
			get { return stockOutFlowDetailsID; }
			set { stockOutFlowDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the IsUniqueBarcode value.
		/// </summary>
		public string IsUniqueBarcode
		{
			get { return isUniqueBarcode; }
			set { isUniqueBarcode = value; }
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
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}


		#endregion
}
}
