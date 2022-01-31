using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
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
		string _orgname;
		public string OrgName
		{
			get { return _orgname; }
			set { _orgname = value; }
		}

		/// <summary>
		/// Gets or sets the LogoPath value.
		/// </summary>
		string _logopath;
		public string LogoPath
		{
			get { return _logopath; }
			set { _logopath = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		long _orgaddressid;
		public long OrgAddressID
		{
			get { return _orgaddressid; }
			set { _orgaddressid = value; }
		}

		/// <summary>
		/// Gets or sets the IntegrationName value.
		/// </summary>
		string _integrationname;
		public string IntegrationName
		{
			get { return _integrationname; }
			set { _integrationname = value; }
		}

		/// <summary>
		/// Gets or sets the IsDefault value.
		/// </summary>
		bool _isdefault;
		public bool IsDefault
		{
			get { return _isdefault; }
			set { _isdefault = value; }
		}

		/// <summary>
		/// Gets or sets the OrgDisplayName value.
		/// </summary>
		string _orgdisplayname;
		public string OrgDisplayName
		{
			get { return _orgdisplayname; }
			set { _orgdisplayname = value; }
		}

		/// <summary>
		/// Gets or sets the ParentOrgID value.
		/// </summary>
		int _parentorgid;
		public int ParentOrgID
		{
			get { return _parentorgid; }
			set { _parentorgid = value; }
		}

		/// <summary>
		/// Gets or sets the LoginName value.
		/// </summary>
		string _loginname;
		public string LoginName
		{
			get { return _loginname; }
			set { _loginname = value; }
		}

		/// <summary>
		/// Gets or sets the OrgTimeZone value.
		/// </summary>
		string _orgtimezone;
		public string OrgTimeZone
		{
			get { return _orgtimezone; }
			set { _orgtimezone = value; }
		}


		#endregion
}
}
