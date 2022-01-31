using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class LoginLocationMapping
	{
		#region Fields

		private long loginLocationMapID=0;
		private long loginRoleID=0;
		private int orgID=0;
		private long addressID=0;
		private string isDefault=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the LoginLocationMapID value.
		/// </summary>
		public long LoginLocationMapID
		{
			get { return loginLocationMapID; }
			set { loginLocationMapID = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the AddressID value.
		/// </summary>
		public long AddressID
		{
			get { return addressID; }
			set { addressID = value; }
		}

		/// <summary>
		/// Gets or sets the IsDefault value.
		/// </summary>
		public string IsDefault
		{
			get { return isDefault; }
			set { isDefault = value; }
		}


		#endregion
}
}
