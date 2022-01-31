using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class TabRole
	{
		#region Fields

		private int tabMasterId=0;
		private int orgId=0;
		private int roleId=0;
		private bool hasAccess=false;
		private bool isdefault=false;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TabMasterId value.
		/// </summary>
		public int TabMasterId
		{
			get { return tabMasterId; }
			set { tabMasterId = value; }
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
		/// Gets or sets the RoleId value.
		/// </summary>
		public int RoleId
		{
			get { return roleId; }
			set { roleId = value; }
		}

		/// <summary>
		/// Gets or sets the HasAccess value.
		/// </summary>
		public bool HasAccess
		{
			get { return hasAccess; }
			set { hasAccess = value; }
		}

		/// <summary>
		/// Gets or sets the Isdefault value.
		/// </summary>
		public bool Isdefault
		{
			get { return isdefault; }
			set { isdefault = value; }
		}


		#endregion
}
}
