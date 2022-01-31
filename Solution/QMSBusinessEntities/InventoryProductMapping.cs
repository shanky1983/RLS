using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
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
		string _investigationname;
		public string InvestigationName
		{
			get { return _investigationname; }
			set { _investigationname = value; }
		}

		/// <summary>
		/// Gets or sets the ProductName value.
		/// </summary>
		string _productname;
		public string ProductName
		{
			get { return _productname; }
			set { _productname = value; }
		}

		/// <summary>
		/// Gets or sets the ActualQty value.
		/// </summary>
		Decimal _actualqty;
		public Decimal ActualQty
		{
			get { return _actualqty; }
			set { _actualqty = value; }
		}

		/// <summary>
		/// Gets or sets the UsedQty value.
		/// </summary>
		Decimal _usedqty;
		public Decimal UsedQty
		{
			get { return _usedqty; }
			set { _usedqty = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationQty value.
		/// </summary>
		Decimal _investigationqty;
		public Decimal InvestigationQty
		{
			get { return _investigationqty; }
			set { _investigationqty = value; }
		}

		/// <summary>
		/// Gets or sets the LocationName value.
		/// </summary>
		string _locationname;
		public string LocationName
		{
			get { return _locationname; }
			set { _locationname = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		int _locationid;
		public int LocationID
		{
			get { return _locationid; }
			set { _locationid = value; }
		}

		/// <summary>
		/// Gets or sets the ActualUsageQty value.
		/// </summary>
		Decimal _actualusageqty;
		public Decimal ActualUsageQty
		{
			get { return _actualusageqty; }
			set { _actualusageqty = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		int _orgaddressid;
		public int OrgAddressID
		{
			get { return _orgaddressid; }
			set { _orgaddressid = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceName value.
		/// </summary>
		string _devicename;
		public string DeviceName
		{
			get { return _devicename; }
			set { _devicename = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceID value.
		/// </summary>
		long _deviceid;
		public long DeviceID
		{
			get { return _deviceid; }
			set { _deviceid = value; }
		}

		/// <summary>
		/// Gets or sets the TotalUsageQty value.
		/// </summary>
		Decimal _totalusageqty;
		public Decimal TotalUsageQty
		{
			get { return _totalusageqty; }
			set { _totalusageqty = value; }
		}

		/// <summary>
		/// Gets or sets the ConsumptionQty value.
		/// </summary>
		Decimal _consumptionqty;
		public Decimal ConsumptionQty
		{
			get { return _consumptionqty; }
			set { _consumptionqty = value; }
		}

		/// <summary>
		/// Gets or sets the ParentProductID value.
		/// </summary>
		long _parentproductid;
		public long ParentProductID
		{
			get { return _parentproductid; }
			set { _parentproductid = value; }
		}

		/// <summary>
		/// Gets or sets the CategoryID value.
		/// </summary>
		long _categoryid;
		public long CategoryID
		{
			get { return _categoryid; }
			set { _categoryid = value; }
		}

		/// <summary>
		/// Gets or sets the ProductKey value.
		/// </summary>
		string _productkey;
		public string ProductKey
		{
			get { return _productkey; }
			set { _productkey = value; }
		}

		/// <summary>
		/// Gets or sets the TypeID value.
		/// </summary>
		int _typeid;
		public int TypeID
		{
			get { return _typeid; }
			set { _typeid = value; }
		}

		/// <summary>
		/// Gets or sets the ExpiryDate value.
		/// </summary>
		DateTime _expirydate;
		public DateTime ExpiryDate
		{
			get { return _expirydate; }
			set { _expirydate = value; }
		}

		/// <summary>
		/// Gets or sets the BatchNo value.
		/// </summary>
		string _batchno;
		public string BatchNo
		{
			get { return _batchno; }
			set { _batchno = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceMappingID  value.
		/// </summary>
		long _devicemappingid ;
		public long DeviceMappingID 
		{
			get { return _devicemappingid ; }
			set { _devicemappingid  = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceType  value.
		/// </summary>
		string _referencetype ;
		public string ReferenceType 
		{
			get { return _referencetype ; }
			set { _referencetype  = value; }
		}

		/// <summary>
		/// Gets or sets the ProductTypeID value.
		/// </summary>
		long _producttypeid;
		public long ProductTypeID
		{
			get { return _producttypeid; }
			set { _producttypeid = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		long _id;
		public long ID
		{
			get { return _id; }
			set { _id = value; }
		}

		/// <summary>
		/// Gets or sets the Status  value.
		/// </summary>
		string _status ;
		public string Status 
		{
			get { return _status ; }
			set { _status  = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		long _investigationid;
		public long InvestigationID
		{
			get { return _investigationid; }
			set { _investigationid = value; }
		}


		#endregion
}
}
