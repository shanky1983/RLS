using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PlanAndSchedule_QMS
	{
		#region Fields

		private long planScheduleID=0;
		private long orgID=0;
		private int eventType=0;
		private string eventName=String.Empty;
		private DateTime fromDate=DateTime.MaxValue;
		private DateTime todate=DateTime.MaxValue;
		private string eventScope=String.Empty;
		private string eventCriteria=String.Empty;
		private int programType=0;
		private long deptID=0;
		private string status=String.Empty;
		private string participant=String.Empty;
		private string venue=String.Empty;
		private int location=0;
		private long scheduledParticipantID=0;
		private long empRegID=0;
		private string actionType=String.Empty;
        private long empDeptID = 0;
        private string guestMailID = String.Empty;
		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PlanScheduleID value.
		/// </summary>
		public long PlanScheduleID
		{
			get { return planScheduleID; }
			set { planScheduleID = value; }
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
		/// Gets or sets the EventType value.
		/// </summary>
		public int EventType
		{
			get { return eventType; }
			set { eventType = value; }
		}

		/// <summary>
		/// Gets or sets the EventName value.
		/// </summary>
		public string EventName
		{
			get { return eventName; }
			set { eventName = value; }
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

		/// <summary>
		/// Gets or sets the EventScope value.
		/// </summary>
		public string EventScope
		{
			get { return eventScope; }
			set { eventScope = value; }
		}

		/// <summary>
		/// Gets or sets the EventCriteria value.
		/// </summary>
		public string EventCriteria
		{
			get { return eventCriteria; }
			set { eventCriteria = value; }
		}

		/// <summary>
		/// Gets or sets the ProgramType value.
		/// </summary>
		public int ProgramType
		{
			get { return programType; }
			set { programType = value; }
		}

		/// <summary>
		/// Gets or sets the DeptID value.
		/// </summary>
		public long DeptID
		{
			get { return deptID; }
			set { deptID = value; }
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
		/// Gets or sets the Participant value.
		/// </summary>
		public string Participant
		{
			get { return participant; }
			set { participant = value; }
		}

		/// <summary>
		/// Gets or sets the Venue value.
		/// </summary>
		public string Venue
		{
			get { return venue; }
			set { venue = value; }
		}

		/// <summary>
		/// Gets or sets the Location value.
		/// </summary>
		public int Location
		{
			get { return location; }
			set { location = value; }
		}

		/// <summary>
		/// Gets or sets the ScheduledParticipantID value.
		/// </summary>
		public long ScheduledParticipantID
		{
			get { return scheduledParticipantID; }
			set { scheduledParticipantID = value; }
		}

		/// <summary>
		/// Gets or sets the EmpRegID value.
		/// </summary>
		public long EmpRegID
		{
			get { return empRegID; }
			set { empRegID = value; }
		}

		/// <summary>
		/// Gets or sets the ActionType value.
		/// </summary>
		public string ActionType
		{
			get { return actionType; }
			set { actionType = value; }
		}

        public string GuestMailID
		{
            get { return guestMailID; }
            set { guestMailID = value; }
		}
        public long EmpDeptID
		{
			get { return empDeptID; }
			set { empDeptID = value; }
		}
        
		#endregion
}
}
