using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ComplaintGroupOrgMapping
	{
		#region Fields

		private int compiantInvID=0;
		private int iNVGroupID=0;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CompiantInvID value.
		/// </summary>
		public int CompiantInvID
		{
			get { return compiantInvID; }
			set { compiantInvID = value; }
		}

		/// <summary>
		/// Gets or sets the INVGroupID value.
		/// </summary>
		public int INVGroupID
		{
			get { return iNVGroupID; }
			set { iNVGroupID = value; }
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
