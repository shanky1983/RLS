using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class TaskEscalation
	{
		#region Fields

		private long escalationID=0;
		private int taskActionID=0;
		private long escalateToUserID=0;
		private long escalateToRoleID=0;
		private int orgID=0;
		private int allowedElaspsedTime=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the EscalationID value.
		/// </summary>
		public long EscalationID
		{
			get { return escalationID; }
			set { escalationID = value; }
		}

		/// <summary>
		/// Gets or sets the TaskActionID value.
		/// </summary>
		public int TaskActionID
		{
			get { return taskActionID; }
			set { taskActionID = value; }
		}

		/// <summary>
		/// Gets or sets the EscalateToUserID value.
		/// </summary>
		public long EscalateToUserID
		{
			get { return escalateToUserID; }
			set { escalateToUserID = value; }
		}

		/// <summary>
		/// Gets or sets the EscalateToRoleID value.
		/// </summary>
		public long EscalateToRoleID
		{
			get { return escalateToRoleID; }
			set { escalateToRoleID = value; }
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
		/// Gets or sets the AllowedElaspsedTime value.
		/// </summary>
		public int AllowedElaspsedTime
		{
			get { return allowedElaspsedTime; }
			set { allowedElaspsedTime = value; }
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
		/// Gets or sets the ActionName value.
		/// </summary>
		string _actionname;
		public string ActionName
		{
			get { return _actionname; }
			set { _actionname = value; }
		}

		/// <summary>
		/// Gets or sets the TaskDate value.
		/// </summary>
		DateTime _taskdate;
		public DateTime TaskDate
		{
			get { return _taskdate; }
			set { _taskdate = value; }
		}

		/// <summary>
		/// Gets or sets the ElapsedTime value.
		/// </summary>
		int _elapsedtime;
		public int ElapsedTime
		{
			get { return _elapsedtime; }
			set { _elapsedtime = value; }
		}

		/// <summary>
		/// Gets or sets the RoleName value.
		/// </summary>
		string _rolename;
		public string RoleName
		{
			get { return _rolename; }
			set { _rolename = value; }
		}

		/// <summary>
		/// Gets or sets the PatientName value.
		/// </summary>
		string _patientname;
		public string PatientName
		{
			get { return _patientname; }
			set { _patientname = value; }
		}

		/// <summary>
		/// Gets or sets the TaskID value.
		/// </summary>
		long _taskid;
		public long TaskID
		{
			get { return _taskid; }
			set { _taskid = value; }
		}

		/// <summary>
		/// Gets or sets the TaskDescription value.
		/// </summary>
		string _taskdescription;
		public string TaskDescription
		{
			get { return _taskdescription; }
			set { _taskdescription = value; }
		}

		/// <summary>
		/// Gets or sets the AssignedTo value.
		/// </summary>
		long _assignedto;
		public long AssignedTo
		{
			get { return _assignedto; }
			set { _assignedto = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVisitID  value.
		/// </summary>
		long _patientvisitid ;
		public long PatientVisitID 
		{
			get { return _patientvisitid ; }
			set { _patientvisitid  = value; }
		}

		/// <summary>
		/// Gets or sets the ElapsedDays value.
		/// </summary>
		string _elapseddays;
		public string ElapsedDays
		{
			get { return _elapseddays; }
			set { _elapseddays = value; }
		}


		#endregion
}
}
