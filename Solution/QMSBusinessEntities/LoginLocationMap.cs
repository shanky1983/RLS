using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class LoginLocationMap
	{
		#region Fields

		private long loginLocationMapID=0;
		private long loginRoleID=0;
		private int orgID=0;
		private long addressID=0;

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


		#endregion
}
}
