using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ReportOrgMapping
	{
		#region Fields

		private long reportID=0;
		private int roleID=0;
		private long orgID=0;
		private string isMapped=String.Empty;
		private int iD=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ReportID value.
		/// </summary>
		public long ReportID
		{
			get { return reportID; }
			set { reportID = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		public int RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the IsMapped value.
		/// </summary>
		public string IsMapped
		{
			get { return isMapped; }
			set { isMapped = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}


		#endregion
}
}
