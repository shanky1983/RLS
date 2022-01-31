using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Triestanamechange
	{
		#region Fields

		private int orgID=0;
		private string name=String.Empty;
		private int organizationTypeID=0;
		private int addressID=0;
		private string email=String.Empty;
		private string remarks=String.Empty;
		private string logoPath=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string integrationName=String.Empty;
		private string orgDisplayName=String.Empty;
		private int parentOrgID=0;
		private int rootOrgID=0;
		private string referType=String.Empty;
		private long referTypeID=0;
		private long centreCode=0;
		private int timeDifference=0;
		private string timeZone=String.Empty;
		private string isbaseorg=String.Empty;
		private long defaultOrgID=0;
		private string isdefaultorg=String.Empty;
		private int orgCategoryID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Gets or sets the OrganizationTypeID value.
		/// </summary>
		public int OrganizationTypeID
		{
			get { return organizationTypeID; }
			set { organizationTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the AddressID value.
		/// </summary>
		public int AddressID
		{
			get { return addressID; }
			set { addressID = value; }
		}

		/// <summary>
		/// Gets or sets the Email value.
		/// </summary>
		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
		}

		/// <summary>
		/// Gets or sets the LogoPath value.
		/// </summary>
		public string LogoPath
		{
			get { return logoPath; }
			set { logoPath = value; }
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
		/// Gets or sets the IntegrationName value.
		/// </summary>
		public string IntegrationName
		{
			get { return integrationName; }
			set { integrationName = value; }
		}

		/// <summary>
		/// Gets or sets the OrgDisplayName value.
		/// </summary>
		public string OrgDisplayName
		{
			get { return orgDisplayName; }
			set { orgDisplayName = value; }
		}

		/// <summary>
		/// Gets or sets the ParentOrgID value.
		/// </summary>
		public int ParentOrgID
		{
			get { return parentOrgID; }
			set { parentOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the RootOrgID value.
		/// </summary>
		public int RootOrgID
		{
			get { return rootOrgID; }
			set { rootOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferType value.
		/// </summary>
		public string ReferType
		{
			get { return referType; }
			set { referType = value; }
		}

		/// <summary>
		/// Gets or sets the ReferTypeID value.
		/// </summary>
		public long ReferTypeID
		{
			get { return referTypeID; }
			set { referTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the CentreCode value.
		/// </summary>
		public long CentreCode
		{
			get { return centreCode; }
			set { centreCode = value; }
		}

		/// <summary>
		/// Gets or sets the TimeDifference value.
		/// </summary>
		public int TimeDifference
		{
			get { return timeDifference; }
			set { timeDifference = value; }
		}

		/// <summary>
		/// Gets or sets the TimeZone value.
		/// </summary>
		public string TimeZone
		{
			get { return timeZone; }
			set { timeZone = value; }
		}

		/// <summary>
		/// Gets or sets the Isbaseorg value.
		/// </summary>
		public string Isbaseorg
		{
			get { return isbaseorg; }
			set { isbaseorg = value; }
		}

		/// <summary>
		/// Gets or sets the DefaultOrgID value.
		/// </summary>
		public long DefaultOrgID
		{
			get { return defaultOrgID; }
			set { defaultOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the Isdefaultorg value.
		/// </summary>
		public string Isdefaultorg
		{
			get { return isdefaultorg; }
			set { isdefaultorg = value; }
		}

		/// <summary>
		/// Gets or sets the OrgCategoryID value.
		/// </summary>
		public int OrgCategoryID
		{
			get { return orgCategoryID; }
			set { orgCategoryID = value; }
		}


		#endregion
}
}
