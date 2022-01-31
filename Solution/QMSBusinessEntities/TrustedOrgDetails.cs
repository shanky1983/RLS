using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class TrustedOrgDetails
	{
		#region Fields

		private int loggedOrgID=0;
		private int sharingOrgID=0;
		private int shareTypeID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int loggedOrgAddressID=0;
		private int sharingOrgAddressID=0;
		private long trustedOrgDetailsID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the LoggedOrgID value.
		/// </summary>
		public int LoggedOrgID
		{
			get { return loggedOrgID; }
			set { loggedOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the SharingOrgID value.
		/// </summary>
		public int SharingOrgID
		{
			get { return sharingOrgID; }
			set { sharingOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the ShareTypeID value.
		/// </summary>
		public int ShareTypeID
		{
			get { return shareTypeID; }
			set { shareTypeID = value; }
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
		/// Gets or sets the LoggedOrgAddressID value.
		/// </summary>
		public int LoggedOrgAddressID
		{
			get { return loggedOrgAddressID; }
			set { loggedOrgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the SharingOrgAddressID value.
		/// </summary>
		public int SharingOrgAddressID
		{
			get { return sharingOrgAddressID; }
			set { sharingOrgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the TrustedOrgDetailsID value.
		/// </summary>
		public long TrustedOrgDetailsID
		{
			get { return trustedOrgDetailsID; }
			set { trustedOrgDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the ShareTypeName value.
		/// </summary>
		string _sharetypename;
		public string ShareTypeName
		{
			get { return _sharetypename; }
			set { _sharetypename = value; }
		}

		/// <summary>
		/// Gets or sets the OrgName value.
		/// </summary>
		string _orgname;
		public string OrgName
		{
			get { return _orgname; }
			set { _orgname = value; }
		}

		/// <summary>
		/// Gets or sets the CityofOrg value.
		/// </summary>
		string _cityoforg;
		public string CityofOrg
		{
			get { return _cityoforg; }
			set { _cityoforg = value; }
		}

		/// <summary>
		/// Gets or sets the OrganizationID value.
		/// </summary>
		string _organizationid;
		public string OrganizationID
		{
			get { return _organizationid; }
			set { _organizationid = value; }
		}

		/// <summary>
		/// Gets or sets the AddressID value.
		/// </summary>
		string _addressid;
		public string AddressID
		{
			get { return _addressid; }
			set { _addressid = value; }
		}


		#endregion
}
}
