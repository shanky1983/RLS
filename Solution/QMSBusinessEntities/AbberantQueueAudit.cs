using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class AbberantQueueAudit
	{
		#region Fields

		private long rowID=0;
		private long createdBy=0;
		private DateTime createdAT=DateTime.MaxValue;
		private long roleID=0;
		private int orgID=0;
		private long locationID=0;
		private DateTime fromDate=DateTime.MaxValue;
		private DateTime todate=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RowID value.
		/// </summary>
		public long RowID
		{
			get { return rowID; }
			set { rowID = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAT value.
		/// </summary>
		public DateTime CreatedAT
		{
			get { return createdAT; }
			set { createdAT = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		public long RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		public long LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the FromDate value.
		/// </summary>
		public DateTime FromDate
		{
			get { return fromDate; }
			set { fromDate = value; }
		}

		/// <summary>
		/// Gets or sets the Todate value.
		/// </summary>
		public DateTime Todate
		{
			get { return todate; }
			set { todate = value; }
		}


		#endregion
}
}
