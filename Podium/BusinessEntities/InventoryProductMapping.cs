using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InventoryProductMapping
	{
		#region Fields

		private long investigationId=0;
		private long productId=0;
		private decimal estimateQty=Decimal.Zero;
		private string eunits=String.Empty;
		private decimal bufferQty=Decimal.Zero;
		private string bunits=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgId=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvestigationId value.
		/// </summary>
		public long InvestigationId
		{
			get { return investigationId; }
			set { investigationId = value; }
		}

		/// <summary>
		/// Gets or sets the ProductId value.
		/// </summary>
		public long ProductId
		{
			get { return productId; }
			set { productId = value; }
		}

		/// <summary>
		/// Gets or sets the EstimateQty value.
		/// </summary>
		public decimal EstimateQty
		{
			get { return estimateQty; }
			set { estimateQty = value; }
		}

		/// <summary>
		/// Gets or sets the Eunits value.
		/// </summary>
		public string Eunits
		{
			get { return eunits; }
			set { eunits = value; }
		}

		/// <summary>
		/// Gets or sets the BufferQty value.
		/// </summary>
		public decimal BufferQty
		{
			get { return bufferQty; }
			set { bufferQty = value; }
		}

		/// <summary>
		/// Gets or sets the Bunits value.
		/// </summary>
		public string Bunits
		{
			get { return bunits; }
			set { bunits = value; }
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
		/// Gets or sets the OrgId value.
		/// </summary>
		public int OrgId
		{
			get { return orgId; }
			set { orgId = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationName value.
		/// </summary>
		private string _investigationName=String.Empty;
		public string InvestigationName
		{
			get { return  _investigationName; }
			set { _investigationName = value; }
		}

		/// <summary>
		/// Gets or sets the ProductName value.
		/// </summary>
		private string _productName=String.Empty;
		public string ProductName
		{
			get { return  _productName; }
			set { _productName = value; }
		}

		/// <summary>
		/// Gets or sets the ActualQty value.
		/// </summary>
		private Decimal _actualQty=Decimal.Zero;
		public Decimal ActualQty
		{
			get { return  _actualQty; }
			set { _actualQty = value; }
		}

		/// <summary>
		/// Gets or sets the UsedQty value.
		/// </summary>
		private Decimal _usedQty=Decimal.Zero;
		public Decimal UsedQty
		{
			get { return  _usedQty; }
			set { _usedQty = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationQty value.
		/// </summary>
		private Decimal _investigationQty=Decimal.Zero;
		public Decimal InvestigationQty
		{
			get { return  _investigationQty; }
			set { _investigationQty = value; }
		}

		/// <summary>
		/// Gets or sets the LocationName value.
		/// </summary>
		private string _locationName=String.Empty;
		public string LocationName
		{
			get { return  _locationName; }
			set { _locationName = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		private int _locationID=0;
		public int LocationID
		{
			get { return  _locationID; }
			set { _locationID = value; }
		}

		/// <summary>
		/// Gets or sets the ActualUsageQty value.
		/// </summary>
		private Decimal _actualUsageQty=Decimal.Zero;
		public Decimal ActualUsageQty
		{
			get { return  _actualUsageQty; }
			set { _actualUsageQty = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		private int _orgAddressID=0;
		public int OrgAddressID
		{
			get { return  _orgAddressID; }
			set { _orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceName value.
		/// </summary>
		private string _deviceName=String.Empty;
		public string DeviceName
		{
			get { return  _deviceName; }
			set { _deviceName = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceID value.
		/// </summary>
		private long _deviceID=0;
		public long DeviceID
		{
			get { return  _deviceID; }
			set { _deviceID = value; }
		}

		/// <summary>
		/// Gets or sets the TotalUsageQty value.
		/// </summary>
		private Decimal _totalUsageQty=Decimal.Zero;
		public Decimal TotalUsageQty
		{
			get { return  _totalUsageQty; }
			set { _totalUsageQty = value; }
		}

		/// <summary>
		/// Gets or sets the ConsumptionQty value.
		/// </summary>
		private Decimal _consumptionQty=Decimal.Zero;
		public Decimal ConsumptionQty
		{
			get { return  _consumptionQty; }
			set { _consumptionQty = value; }
		}

		/// <summary>
		/// Gets or sets the ParentProductID value.
		/// </summary>
		private long _parentProductID=0;
		public long ParentProductID
		{
			get { return  _parentProductID; }
			set { _parentProductID = value; }
		}

		/// <summary>
		/// Gets or sets the CategoryID value.
		/// </summary>
		private long _categoryID=0;
		public long CategoryID
		{
			get { return  _categoryID; }
			set { _categoryID = value; }
		}

		/// <summary>
		/// Gets or sets the ProductKey value.
		/// </summary>
		private string _productKey=String.Empty;
		public string ProductKey
		{
			get { return  _productKey; }
			set { _productKey = value; }
		}

		/// <summary>
		/// Gets or sets the TypeID value.
		/// </summary>
		private int _typeID=0;
		public int TypeID
		{
			get { return  _typeID; }
			set { _typeID = value; }
		}

		/// <summary>
		/// Gets or sets the ExpiryDate value.
		/// </summary>
		private DateTime _expiryDate=DateTime.MaxValue;
		public DateTime ExpiryDate
		{
			get { return  _expiryDate; }
			set { _expiryDate = value; }
		}

		/// <summary>
		/// Gets or sets the BatchNo value.
		/// </summary>
		private string _batchNo=String.Empty;
		public string BatchNo
		{
			get { return  _batchNo; }
			set { _batchNo = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceMappingID value.
		/// </summary>
		private long _deviceMappingID=0;
		public long DeviceMappingID
		{
			get { return  _deviceMappingID; }
			set { _deviceMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceType value.
		/// </summary>
		private string _referenceType=String.Empty;
		public string ReferenceType
		{
			get { return  _referenceType; }
			set { _referenceType = value; }
		}

		/// <summary>
		/// Gets or sets the ProductTypeID value.
		/// </summary>
		private long _productTypeID=0;
		public long ProductTypeID
		{
			get { return  _productTypeID; }
			set { _productTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		private long _iD=0;
		public long ID
		{
			get { return  _iD; }
			set { _iD = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		private string _status=String.Empty;
		public string Status
		{
			get { return  _status; }
			set { _status = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		private long _investigationID=0;
		public long InvestigationID
		{
			get { return  _investigationID; }
			set { _investigationID = value; }
		}


		#endregion
}
}
