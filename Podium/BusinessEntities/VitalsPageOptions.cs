using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class VitalsPageOptions
	{
		#region Fields

		private long actionID=0;
		private string actionName=String.Empty;
		private long roleID=0;
		private long pageID=0;
		private long orgId=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ActionID value.
		/// </summary>
		public long ActionID
		{
			get { return actionID; }
			set { actionID = value; }
		}

		/// <summary>
		/// Gets or sets the ActionName value.
		/// </summary>
		public string ActionName
		{
			get { return actionName; }
			set { actionName = value; }
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
		/// Gets or sets the PageID value.
		/// </summary>
		public long PageID
		{
			get { return pageID; }
			set { pageID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgId value.
		/// </summary>
		public long OrgId
		{
			get { return orgId; }
			set { orgId = value; }
		}


		#endregion
}
}
