using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Locations
	{
		#region Fields

		private int locationID=0;
		private string locationName=String.Empty;
		private int locationTypeID=0;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgAddressID=0;
		private string isActive=String.Empty;
		private int parentLocationID=0;
		private int parentLocationTypeID=0;
		private string tINNO=String.Empty;
		private string dLNO=String.Empty;
		private string locationCode=String.Empty;
		private int rootLocationID=0;
		private bool isDefaults=false;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		public int LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the LocationName value.
		/// </summary>
		public string LocationName
		{
			get { return locationName; }
			set { locationName = value; }
		}

		/// <summary>
		/// Gets or sets the LocationTypeID value.
		/// </summary>
		public int LocationTypeID
		{
			get { return locationTypeID; }
			set { locationTypeID = value; }
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
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public int OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the ParentLocationID value.
		/// </summary>
		public int ParentLocationID
		{
			get { return parentLocationID; }
			set { parentLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the ParentLocationTypeID value.
		/// </summary>
		public int ParentLocationTypeID
		{
			get { return parentLocationTypeID; }
			set { parentLocationTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the TINNO value.
		/// </summary>
		public string TINNO
		{
			get { return tINNO; }
			set { tINNO = value; }
		}

		/// <summary>
		/// Gets or sets the DLNO value.
		/// </summary>
		public string DLNO
		{
			get { return dLNO; }
			set { dLNO = value; }
		}

		/// <summary>
		/// Gets or sets the LocationCode value.
		/// </summary>
		public string LocationCode
		{
			get { return locationCode; }
			set { locationCode = value; }
		}

		/// <summary>
		/// Gets or sets the RootLocationID value.
		/// </summary>
		public int RootLocationID
		{
			get { return rootLocationID; }
			set { rootLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the IsDefaults value.
		/// </summary>
		public bool IsDefaults
		{
			get { return isDefaults; }
			set { isDefaults = value; }
		}

		/// <summary>
		/// Gets or sets the LocationTypeCode value.
		/// </summary>
		private string _locationTypeCode=String.Empty;
		public string LocationTypeCode
		{
			get { return  _locationTypeCode; }
			set { _locationTypeCode = value; }
		}

		/// <summary>
		/// Gets or sets the LocationInfo value.
		/// </summary>
		private string _locationInfo=String.Empty;
		public string LocationInfo
		{
			get { return  _locationInfo; }
			set { _locationInfo = value; }
		}

		/// <summary>
		/// Gets or sets the ProductTypeID value.
		/// </summary>
		private string _productTypeID=String.Empty;
		public string ProductTypeID
		{
			get { return  _productTypeID; }
			set { _productTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the TypeName value.
		/// </summary>
		private string _typeName=String.Empty;
		public string TypeName
		{
			get { return  _typeName; }
			set { _typeName = value; }
		}

		/// <summary>
		/// Gets or sets the ToLocationID value.
		/// </summary>
		private int _toLocationID=0;
		public int ToLocationID
		{
			get { return  _toLocationID; }
			set { _toLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddressName value.
		/// </summary>
		private string _orgAddressName=String.Empty;
		public string OrgAddressName
		{
			get { return  _orgAddressName; }
			set { _orgAddressName = value; }
		}

		/// <summary>
		/// Gets or sets the ReorderQuantity value.
		/// </summary>
		private long _reorderQuantity=0;
		public long ReorderQuantity
		{
			get { return  _reorderQuantity; }
			set { _reorderQuantity = value; }
		}

		/// <summary>
		/// Gets or sets the ProductLocationMappingID value.
		/// </summary>
		private long _productLocationMappingID=0;
		public long ProductLocationMappingID
		{
			get { return  _productLocationMappingID; }
			set { _productLocationMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		private long _clientID=0;
		public long ClientID
		{
			get { return  _clientID; }
			set { _clientID = value; }
		}

		/// <summary>
		/// Gets or sets the ParentLocationname value.
		/// </summary>
		private string _parentLocationname=String.Empty;
		public string ParentLocationname
		{
			get { return  _parentLocationname; }
			set { _parentLocationname = value; }
		}

		/// <summary>
		/// Gets or sets the ClientName value.
		/// </summary>
		private string _clientName=String.Empty;
		public string ClientName
		{
			get { return  _clientName; }
			set { _clientName = value; }
		}

		/// <summary>
		/// Gets or sets the MaximumQuantity value.
		/// </summary>
		private long _maximumQuantity=0;
		public long MaximumQuantity
		{
			get { return  _maximumQuantity; }
			set { _maximumQuantity = value; }
		}


		#endregion
}
}
