using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Aspnet_Roles
	{
		#region Fields

		private Guid applicationId=Guid.Empty;
		private Guid roleId=Guid.Empty;
		private string roleName=String.Empty;
		private string loweredRoleName=String.Empty;
		private string description=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ApplicationId value.
		/// </summary>
		public Guid ApplicationId
		{
			get { return applicationId; }
			set { applicationId = value; }
		}

		/// <summary>
		/// Gets or sets the RoleId value.
		/// </summary>
		public Guid RoleId
		{
			get { return roleId; }
			set { roleId = value; }
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
		/// Gets or sets the LoweredRoleName value.
		/// </summary>
		public string LoweredRoleName
		{
			get { return loweredRoleName; }
			set { loweredRoleName = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}


		#endregion
}
}
