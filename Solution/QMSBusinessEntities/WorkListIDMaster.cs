using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class WorkListIDMaster
	{
		#region Fields

		private long orgID=0;
		private long workListID=0;
		private int rowID=0;

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
		/// Gets or sets the WorkListID value.
		/// </summary>
		public long WorkListID
		{
			get { return workListID; }
			set { workListID = value; }
		}

		/// <summary>
		/// Gets or sets the RowID value.
		/// </summary>
		public int RowID
		{
			get { return rowID; }
			set { rowID = value; }
		}


		#endregion
}
}
