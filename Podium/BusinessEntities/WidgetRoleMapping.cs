using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class WidgetRoleMapping
	{
		#region Fields

		private long wRID=0;
		private long wID=0;
		private long roleID=0;
		private long orgID=0;
		private DateTime createdat=DateTime.MaxValue;
		private long createdby=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedby=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the WRID value.
		/// </summary>
		public long WRID
		{
			get { return wRID; }
			set { wRID = value; }
		}

		/// <summary>
		/// Gets or sets the WID value.
		/// </summary>
		public long WID
		{
			get { return wID; }
			set { wID = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		public long RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
		}

		/// <summary>
		/// Gets or sets the Createdby value.
		/// </summary>
		public long Createdby
		{
			get { return createdby; }
			set { createdby = value; }
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
		/// Gets or sets the Modifiedby value.
		/// </summary>
		public long Modifiedby
		{
			get { return modifiedby; }
			set { modifiedby = value; }
		}

		/// <summary>
		/// Gets or sets the DetailedID value.
		/// </summary>
		private long _detailedID=0;
		public long DetailedID
		{
			get { return  _detailedID; }
			set { _detailedID = value; }
		}

		/// <summary>
		/// Gets or sets the WCode value.
		/// </summary>
		private string _wCode=String.Empty;
		public string WCode
		{
			get { return  _wCode; }
			set { _wCode = value; }
		}

		/// <summary>
		/// Gets or sets the Active value.
		/// </summary>
		private string _active=String.Empty;
		public string Active
		{
			get { return  _active; }
			set { _active = value; }
		}

		/// <summary>
		/// Gets or sets the WGCode value.
		/// </summary>
		private string _wGCode=String.Empty;
		public string WGCode
		{
			get { return  _wGCode; }
			set { _wGCode = value; }
		}

		/// <summary>
		/// Gets or sets the LoginID value.
		/// </summary>
		private long _loginID=0;
		public long LoginID
		{
			get { return  _loginID; }
			set { _loginID = value; }
		}


		#endregion
}
}
