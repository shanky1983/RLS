using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
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
		string _locationtypecode;
		public string LocationTypeCode
		{
			get { return _locationtypecode; }
			set { _locationtypecode = value; }
		}

		/// <summary>
		/// Gets or sets the LocationInfo value.
		/// </summary>
		string _locationinfo;
		public string LocationInfo
		{
			get { return _locationinfo; }
			set { _locationinfo = value; }
		}

		/// <summary>
		/// Gets or sets the ProductTypeID value.
		/// </summary>
		string _producttypeid;
		public string ProductTypeID
		{
			get { return _producttypeid; }
			set { _producttypeid = value; }
		}

		/// <summary>
		/// Gets or sets the TypeName value.
		/// </summary>
		string _typename;
		public string TypeName
		{
			get { return _typename; }
			set { _typename = value; }
		}

		/// <summary>
		/// Gets or sets the ToLocationID value.
		/// </summary>
		int _tolocationid;
		public int ToLocationID
		{
			get { return _tolocationid; }
			set { _tolocationid = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddressName value.
		/// </summary>
		string _orgaddressname;
		public string OrgAddressName
		{
			get { return _orgaddressname; }
			set { _orgaddressname = value; }
		}


		#endregion
}
}
