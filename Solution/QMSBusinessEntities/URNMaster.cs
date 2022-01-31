using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class URNMaster
	{
		#region Fields

		private long orgID=0;
		private long uRNumber=0;
		private int rowid=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the URNumber value.
		/// </summary>
		public long URNumber
		{
			get { return uRNumber; }
			set { uRNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Rowid value.
		/// </summary>
		public int Rowid
		{
			get { return rowid; }
			set { rowid = value; }
		}


		#endregion
}
}
