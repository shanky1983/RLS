using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ClientHospital
	{
		#region Fields

		private int orgID=0;
		private long clientID=0;
		private long hospitalID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public long ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		/// <summary>
		/// Gets or sets the HospitalID value.
		/// </summary>
		public long HospitalID
		{
			get { return hospitalID; }
			set { hospitalID = value; }
		}


		#endregion
}
}
