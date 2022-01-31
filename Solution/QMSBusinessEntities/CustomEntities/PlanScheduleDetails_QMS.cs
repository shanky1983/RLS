using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PlanScheduleDetails_QMS
	{
		#region Fields

		private long planScheduleID=0;
		private long orgID=0;
		private int eventType=0;
		private string eventName=String.Empty;
		private DateTime fromDate=DateTime.MaxValue;
		private DateTime todate=DateTime.MaxValue;
		private string auditScope=String.Empty;
		private string auditCriteria=String.Empty;
		private string venue=String.Empty;
		private string topic=String.Empty;
		private string agenda=String.Empty;
		private string programType=String.Empty;
		private long deptID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int location=0;
		private string status=String.Empty;
		private long paricipantID=0;
        private long roleID = 0;
		private long userID=0;
        private string files = String.Empty;
        private string eventTypeCode = String.Empty;
		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PlanScheduleID value.
		/// </summary>
        /// 
        public string EventTypeCode
        {
            get { return eventTypeCode; }
            set { eventTypeCode = value; }
        }
		public long PlanScheduleID
		{
			get { return planScheduleID; }
			set { planScheduleID = value; }
		}
        public long RoleID
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
		/// Gets or sets the AuditScope value.
		/// </summary>
		public string AuditScope
		{
			get { return auditScope; }
			set { auditScope = value; }
		}

		/// <summary>
		/// Gets or sets the AuditCriteria value.
		/// </summary>
		public string AuditCriteria
		{
			get { return auditCriteria; }
			set { auditCriteria = value; }
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
		/// Gets or sets the Topic value.
		/// </summary>
		public string Topic
		{
			get { return topic; }
			set { topic = value; }
		}

		/// <summary>
		/// Gets or sets the Agenda value.
		/// </summary>
		public string Agenda
		{
			get { return agenda; }
			set { agenda = value; }
		}

		/// <summary>
		/// Gets or sets the ProgramType value.
		/// </summary>
		public string ProgramType
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the ParicipantID value.
		/// </summary>
		public long ParicipantID
		{
			get { return paricipantID; }
			set { paricipantID = value; }
		}

		/// <summary>
		/// Gets or sets the UserID value.
		/// </summary>
		public long UserID
		{
			get { return userID; }
			set { userID = value; }
		}

        public string Files
        {
            get { return files; }
            set { files = value; }
        }


		#endregion
}
}
