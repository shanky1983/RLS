using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class IPPaymentsRoleMapping
	{
		#region Fields

		private long ipPaymentsID=0;
		private long roleid=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IpPaymentsID value.
		/// </summary>
		public long IpPaymentsID
		{
			get { return ipPaymentsID; }
			set { ipPaymentsID = value; }
		}

		/// <summary>
		/// Gets or sets the Roleid value.
		/// </summary>
		public long Roleid
		{
			get { return roleid; }
			set { roleid = value; }
		}


		#endregion
}
}
