using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class IVYInvestigationConsumptionDetails
	{
		#region Fields

		private long investigationConsumptionDetailsID=0;
		private long investigationValuesID=0;
		private long additionalConsumptionID=0;
		private int orgID=0;
		private long investigationID=0;
		private long productID=0;
		private string deviceID=String.Empty;
		private string itemBarcodeNo=String.Empty;
		private decimal consumptionQty=Decimal.Zero;
		private int uOMID=0;
		private string consumptionType=String.Empty;
		private DateTime sampleLoadTime=DateTime.MaxValue;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private int consumptionCount=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvestigationConsumptionDetailsID value.
		/// </summary>
		public long InvestigationConsumptionDetailsID
		{
			get { return investigationConsumptionDetailsID; }
			set { investigationConsumptionDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationValuesID value.
		/// </summary>
		public long InvestigationValuesID
		{
			get { return investigationValuesID; }
			set { investigationValuesID = value; }
		}

		/// <summary>
		/// Gets or sets the AdditionalConsumptionID value.
		/// </summary>
		public long AdditionalConsumptionID
		{
			get { return additionalConsumptionID; }
			set { additionalConsumptionID = value; }
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
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
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
		/// Gets or sets the ConsumptionQty value.
		/// </summary>
		public decimal ConsumptionQty
		{
			get { return consumptionQty; }
			set { consumptionQty = value; }
		}

		/// <summary>
		/// Gets or sets the UOMID value.
		/// </summary>
		public int UOMID
		{
			get { return uOMID; }
			set { uOMID = value; }
		}

		/// <summary>
		/// Gets or sets the ConsumptionType value.
		/// </summary>
		public string ConsumptionType
		{
			get { return consumptionType; }
			set { consumptionType = value; }
		}

		/// <summary>
		/// Gets or sets the SampleLoadTime value.
		/// </summary>
		public DateTime SampleLoadTime
		{
			get { return sampleLoadTime; }
			set { sampleLoadTime = value; }
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

		/// <summary>
		/// Gets or sets the ConsumptionCount value.
		/// </summary>
		public int ConsumptionCount
		{
			get { return consumptionCount; }
			set { consumptionCount = value; }
		}


		#endregion
}
}
