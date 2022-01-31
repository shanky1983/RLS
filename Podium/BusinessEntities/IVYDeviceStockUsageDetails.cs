using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class IVYDeviceStockUsageDetails
	{
		#region Fields

		private long deviceStockUsageDetailsID=0;
		private long deviceStockUsageID=0;
		private long productID=0;
		private string deviceID=String.Empty;
		private string itemBarcodeNo=String.Empty;
		private int orgID=0;
		private DateTime startTime=DateTime.MaxValue;
		private DateTime endTime=DateTime.MaxValue;
		private string status=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private int createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DeviceStockUsageDetailsID value.
		/// </summary>
		public long DeviceStockUsageDetailsID
		{
			get { return deviceStockUsageDetailsID; }
			set { deviceStockUsageDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceStockUsageID value.
		/// </summary>
		public long DeviceStockUsageID
		{
			get { return deviceStockUsageID; }
			set { deviceStockUsageID = value; }
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
		/// Gets or sets the DeviceID value.
		/// </summary>
		public string DeviceID
		{
			get { return deviceID; }
			set { deviceID = value; }
		}

		/// <summary>
		/// Gets or sets the ItemBarcodeNo value.
		/// </summary>
		public string ItemBarcodeNo
		{
			get { return itemBarcodeNo; }
			set { itemBarcodeNo = value; }
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
		/// Gets or sets the StartTime value.
		/// </summary>
		public DateTime StartTime
		{
			get { return startTime; }
			set { startTime = value; }
		}

		/// <summary>
		/// Gets or sets the EndTime value.
		/// </summary>
		public DateTime EndTime
		{
			get { return endTime; }
			set { endTime = value; }
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
		public int CreatedBy
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
		public int ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}


		#endregion
}
}
