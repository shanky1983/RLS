using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvOrgAuthorization
	{
		#region Fields

		private long iD=0;
		private long investigationID=0;
		private int orgID=0;
		private string type=String.Empty;
		private int roleID=0;
		private int deptID=0;
		private long userID=0;
		private string isPrimary=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		public int RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}

		/// <summary>
		/// Gets or sets the DeptID value.
		/// </summary>
		public int DeptID
		{
			get { return deptID; }
			set { deptID = value; }
		}

		/// <summary>
		/// Gets or sets the UserID value.
		/// </summary>
		public long UserID
		{
			get { return userID; }
			set { userID = value; }
		}

		/// <summary>
		/// Gets or sets the IsPrimary value.
		/// </summary>
		public string IsPrimary
		{
			get { return isPrimary; }
			set { isPrimary = value; }
		}

		/// <summary>
		/// Gets or sets the UserName value.
		/// </summary>
		string _username;
		public string UserName
		{
			get { return _username; }
			set { _username = value; }
		}

		/// <summary>
		/// Gets or sets the RoleName value.
		/// </summary>
		string _rolename;
		public string RoleName
		{
			get { return _rolename; }
			set { _rolename = value; }
		}

		/// <summary>
		/// Gets or sets the DeptName value.
		/// </summary>
		string _deptname;
		public string DeptName
		{
			get { return _deptname; }
			set { _deptname = value; }
		}


		#endregion
}
}
