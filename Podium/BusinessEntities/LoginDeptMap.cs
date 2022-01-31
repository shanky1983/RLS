using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class LoginDeptMap
	{
		#region Fields

		private long loginDeptMapID=0;
		private long roleDetpID=0;
		private long loginID=0;
		private string isActive=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the LoginDeptMapID value.
		/// </summary>
		public long LoginDeptMapID
		{
			get { return loginDeptMapID; }
			set { loginDeptMapID = value; }
		}

		/// <summary>
		/// Gets or sets the RoleDetpID value.
		/// </summary>
		public long RoleDetpID
		{
			get { return roleDetpID; }
			set { roleDetpID = value; }
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
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}


		#endregion
}
}
