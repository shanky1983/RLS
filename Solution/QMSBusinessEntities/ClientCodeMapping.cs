using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ClientCodeMapping
	{
		#region Fields

		private int iD=0;
		private string code=String.Empty;
		private long clientID=0;
		private int referingPhysicianID=0;
		private long labRefOrgID=0;
		private int orgID=0;

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
		/// Gets or sets the Code value.
		/// </summary>
		public string Code
		{
			get { return code; }
			set { code = value; }
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
		/// Gets or sets the ReferingPhysicianID value.
		/// </summary>
		public int ReferingPhysicianID
		{
			get { return referingPhysicianID; }
			set { referingPhysicianID = value; }
		}

		/// <summary>
		/// Gets or sets the LabRefOrgID value.
		/// </summary>
		public long LabRefOrgID
		{
			get { return labRefOrgID; }
			set { labRefOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}


		#endregion
}
}
