using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ScheduledMOM
	{
		#region Fields

		private long scheduledMOMID=0;
		private long planScheduleID=0;
		private int deptID=0;
		private string pointsDiscussed=String.Empty;
		private string actionProposed=String.Empty;
		private DateTime proposedCompDate=DateTime.MaxValue;
		private long responsiblePerson=0;
		private string status=String.Empty;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ScheduledMOMID value.
		/// </summary>
		public long ScheduledMOMID
		{
			get { return scheduledMOMID; }
			set { scheduledMOMID = value; }
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
		/// Gets or sets the DeptID value.
		/// </summary>
		public int DeptID
		{
			get { return deptID; }
			set { deptID = value; }
		}

		/// <summary>
		/// Gets or sets the PointsDiscussed value.
		/// </summary>
		public string PointsDiscussed
		{
			get { return pointsDiscussed; }
			set { pointsDiscussed = value; }
		}

		/// <summary>
		/// Gets or sets the ActionProposed value.
		/// </summary>
		public string ActionProposed
		{
			get { return actionProposed; }
			set { actionProposed = value; }
		}

		/// <summary>
		/// Gets or sets the ProposedCompDate value.
		/// </summary>
		public DateTime ProposedCompDate
		{
			get { return proposedCompDate; }
			set { proposedCompDate = value; }
		}

		/// <summary>
		/// Gets or sets the ResponsiblePerson value.
		/// </summary>
		public long ResponsiblePerson
		{
			get { return responsiblePerson; }
			set { responsiblePerson = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
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
