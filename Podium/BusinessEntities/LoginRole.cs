using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class LoginRole
	{
		#region Fields

		private long roleID=0;
		private long loginID=0;
		private DateTime startDTTM=DateTime.MaxValue;
		private DateTime endDTTM=DateTime.MaxValue;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private bool isDefault=false;
		private long loginRoleID=0;

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
		/// Gets or sets the LoginID value.
		/// </summary>
		public long LoginID
		{
			get { return loginID; }
			set { loginID = value; }
		}

		/// <summary>
		/// Gets or sets the StartDTTM value.
		/// </summary>
		public DateTime StartDTTM
		{
			get { return startDTTM; }
			set { startDTTM = value; }
		}

		/// <summary>
		/// Gets or sets the EndDTTM value.
		/// </summary>
		public DateTime EndDTTM
		{
			get { return endDTTM; }
			set { endDTTM = value; }
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
		/// Gets or sets the IsDefault value.
		/// </summary>
		public bool IsDefault
		{
			get { return isDefault; }
			set { isDefault = value; }
		}

		/// <summary>
		/// Gets or sets the LoginRoleID value.
		/// </summary>
		public long LoginRoleID
		{
			get { return loginRoleID; }
			set { loginRoleID = value; }
		}

		/// <summary>
		/// Gets or sets the RoleName value.
		/// </summary>
		private string _roleName=String.Empty;
		public string RoleName
		{
			get { return  _roleName; }
			set { _roleName = value; }
		}

		/// <summary>
		/// Gets or sets the OrgId value.
		/// </summary>
		private int _orgId=0;
		public int OrgId
		{
			get { return  _orgId; }
			set { _orgId = value; }
		}

		/// <summary>
		/// Gets or sets the OrganisationName value.
		/// </summary>
		private string _organisationName=String.Empty;
		public string OrganisationName
		{
			get { return  _organisationName; }
			set { _organisationName = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		private string _description=String.Empty;
		public string Description
		{
			get { return  _description; }
			set { _description = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		private string _type=String.Empty;
		public string Type
		{
			get { return  _type; }
			set { _type = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianStatus value.
		/// </summary>
		private string _physicianStatus=String.Empty;
		public string PhysicianStatus
		{
			get { return  _physicianStatus; }
			set { _physicianStatus = value; }
		}


		#endregion
}
}
