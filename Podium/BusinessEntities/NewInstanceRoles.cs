using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class NewInstanceRoles
	{
		#region Fields

		private int newInstanceWaitID=0;
		private string roleName=String.Empty;
		private string description=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the NewInstanceWaitID value.
		/// </summary>
		public int NewInstanceWaitID
		{
			get { return newInstanceWaitID; }
			set { newInstanceWaitID = value; }
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
