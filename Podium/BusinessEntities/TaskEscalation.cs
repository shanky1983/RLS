using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
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
		private string _actionName=String.Empty;
		public string ActionName
		{
			get { return  _actionName; }
			set { _actionName = value; }
		}

		/// <summary>
		/// Gets or sets the TaskDate value.
		/// </summary>
		private DateTime _taskDate=DateTime.MaxValue;
		public DateTime TaskDate
		{
			get { return  _taskDate; }
			set { _taskDate = value; }
		}

		/// <summary>
		/// Gets or sets the ElapsedTime value.
		/// </summary>
		private int _elapsedTime=0;
		public int ElapsedTime
		{
			get { return  _elapsedTime; }
			set { _elapsedTime = value; }
		}

		/// <summary>
		/// Gets or sets the RoleName value.
		/// </summary>
		private string _roleName=String.Empty;
		public string RoleName
		{
			get { return  _roleName; }
			set { _roleName = value; }
		}

		/// <summary>
		/// Gets or sets the PatientName value.
		/// </summary>
		private string _patientName=String.Empty;
		public string PatientName
		{
			get { return  _patientName; }
			set { _patientName = value; }
		}

		/// <summary>
		/// Gets or sets the TaskID value.
		/// </summary>
		private long _taskID=0;
		public long TaskID
		{
			get { return  _taskID; }
			set { _taskID = value; }
		}

		/// <summary>
		/// Gets or sets the TaskDescription value.
		/// </summary>
		private string _taskDescription=String.Empty;
		public string TaskDescription
		{
			get { return  _taskDescription; }
			set { _taskDescription = value; }
		}

		/// <summary>
		/// Gets or sets the AssignedTo value.
		/// </summary>
		private long _assignedTo=0;
		public long AssignedTo
		{
			get { return  _assignedTo; }
			set { _assignedTo = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		private long _patientVisitID=0;
		public long PatientVisitID
		{
			get { return  _patientVisitID; }
			set { _patientVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the ElapsedDays value.
		/// </summary>
		private string _elapsedDays=String.Empty;
		public string ElapsedDays
		{
			get { return  _elapsedDays; }
			set { _elapsedDays = value; }
		}


		#endregion
}
}
