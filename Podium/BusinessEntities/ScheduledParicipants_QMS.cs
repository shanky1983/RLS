using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ScheduledParicipants_QMS
	{
		#region Fields

		private long paricipantID=0;
		private long planScheduleID=0;
		private long userID=0;
		private long roleID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ParicipantID value.
		/// </summary>
		public long ParicipantID
		{
			get { return paricipantID; }
			set { paricipantID = value; }
		}

		/// <summary>
		/// Gets or sets the PlanScheduleID value.
		/// </summary>
		public long PlanScheduleID
		{
			get { return planScheduleID; }
			set { planScheduleID = value; }
		}

		/// <summary>
		/// Gets or sets the UserID value.
		/// </summary>
		public long UserID
		{
			get { return userID; }
			set { userID = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		public long RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}


		#endregion
}
}
