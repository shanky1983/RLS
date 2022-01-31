using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Aspnet_UsersInRoles
	{
		#region Fields

		private Guid userId=Guid.Empty;
		private Guid roleId=Guid.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the UserId value.
		/// </summary>
		public Guid UserId
		{
			get { return userId; }
			set { userId = value; }
		}

		/// <summary>
		/// Gets or sets the RoleId value.
		/// </summary>
		public Guid RoleId
		{
			get { return roleId; }
			set { roleId = value; }
		}


		#endregion
}
}
