using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Role
	{
		#region Fields

		private long roleID=0;
		private string roleName=String.Empty;
		private string description=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long parentID=0;
		private int orgID=0;
		private string sortedrole=String.Empty;
		private string langCode=String.Empty;
		private string displayText=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		public long RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}

		/// <summary>
		/// Gets or sets the RoleName value.
		/// </summary>
		public string RoleName
		{
			get { return roleName; }
			set { roleName = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
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
		/// Gets or sets the ParentID value.
		/// </summary>
		public long ParentID
		{
			get { return parentID; }
			set { parentID = value; }
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
		/// Gets or sets the Sortedrole value.
		/// </summary>
		public string Sortedrole
		{
			get { return sortedrole; }
			set { sortedrole = value; }
		}

		/// <summary>
		/// Gets or sets the LangCode value.
		/// </summary>
		public string LangCode
		{
			get { return langCode; }
			set { langCode = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayText value.
		/// </summary>
		public string DisplayText
		{
			get { return displayText; }
			set { displayText = value; }
		}

		/// <summary>
		/// Gets or sets the OrgName value.
		/// </summary>
		private string _orgName=String.Empty;
		public string OrgName
		{
			get { return  _orgName; }
			set { _orgName = value; }
		}

		/// <summary>
		/// Gets or sets the LogoPath value.
		/// </summary>
		private string _logoPath=String.Empty;
		public string LogoPath
		{
			get { return  _logoPath; }
			set { _logoPath = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		private long _orgAddressID=0;
		public long OrgAddressID
		{
			get { return  _orgAddressID; }
			set { _orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the IntegrationName value.
		/// </summary>
		private string _integrationName=String.Empty;
		public string IntegrationName
		{
			get { return  _integrationName; }
			set { _integrationName = value; }
		}

		/// <summary>
		/// Gets or sets the IsDefault value.
		/// </summary>
		private bool _isDefault=false;
		public bool IsDefault
		{
			get { return  _isDefault; }
			set { _isDefault = value; }
		}

		/// <summary>
		/// Gets or sets the OrgDisplayName value.
		/// </summary>
		private string _orgDisplayName=String.Empty;
		public string OrgDisplayName
		{
			get { return  _orgDisplayName; }
			set { _orgDisplayName = value; }
		}

		/// <summary>
		/// Gets or sets the ParentOrgID value.
		/// </summary>
		private int _parentOrgID=0;
		public int ParentOrgID
		{
			get { return  _parentOrgID; }
			set { _parentOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the LoginName value.
		/// </summary>
		private string _loginName=String.Empty;
		public string LoginName
		{
			get { return  _loginName; }
			set { _loginName = value; }
		}

		/// <summary>
		/// Gets or sets the OrgTimeZone value.
		/// </summary>
		private string _orgTimeZone=String.Empty;
		public string OrgTimeZone
		{
			get { return  _orgTimeZone; }
			set { _orgTimeZone = value; }
		}

		/// <summary>
		/// Gets or sets the OrgDateTimeZone value.
		/// </summary>
		private string _orgDateTimeZone=String.Empty;
		public string OrgDateTimeZone
		{
			get { return  _orgDateTimeZone; }
			set { _orgDateTimeZone = value; }
		}

		/// <summary>
		/// Gets or sets the RoleDescription value.
		/// </summary>
		private string _roleDescription=String.Empty;
		public string RoleDescription
		{
			get { return  _roleDescription; }
			set { _roleDescription = value; }
		}


		#endregion
}
}
