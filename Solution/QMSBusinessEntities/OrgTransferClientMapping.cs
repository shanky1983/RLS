using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class OrgTransferClientMapping
	{
		#region Fields

		private int iD=0;
		private int registeredOrgID=0;
		private int processingOrgID=0;
		private long clientID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the RegisteredOrgID value.
		/// </summary>
		public int RegisteredOrgID
		{
			get { return registeredOrgID; }
			set { registeredOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessingOrgID value.
		/// </summary>
		public int ProcessingOrgID
		{
			get { return processingOrgID; }
			set { processingOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public long ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}


		#endregion
}
}
