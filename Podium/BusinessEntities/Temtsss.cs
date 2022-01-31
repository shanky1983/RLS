using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Temtsss
	{
		#region Fields

		private int taskactionid=0;
		private string taskDescription=String.Empty;
		private string redirectURL=String.Empty;
		private DateTime taskDate=DateTime.MaxValue;
		private long patientID=0;
		private long assignedto=0;
		private long roleID=0;
		private long orgID=0;
		private long parentID=0;
		private long patientVisitID=0;
		private int taskStatusID=0;
		private string highlightColor=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private int specialityID=0;
		private int locationID=0;
		private string refernceID=String.Empty;
		private string type=String.Empty;
		private long taskid=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Taskactionid value.
		/// </summary>
		public int Taskactionid
		{
			get { return taskactionid; }
			set { taskactionid = value; }
		}

		/// <summary>
		/// Gets or sets the TaskDescription value.
		/// </summary>
		public string TaskDescription
		{
			get { return taskDescription; }
			set { taskDescription = value; }
		}

		/// <summary>
		/// Gets or sets the RedirectURL value.
		/// </summary>
		public string RedirectURL
		{
			get { return redirectURL; }
			set { redirectURL = value; }
		}

		/// <summary>
		/// Gets or sets the TaskDate value.
		/// </summary>
		public DateTime TaskDate
		{
			get { return taskDate; }
			set { taskDate = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
		}

		/// <summary>
		/// Gets or sets the Assignedto value.
		/// </summary>
		public long Assignedto
		{
			get { return assignedto; }
			set { assignedto = value; }
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
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the ParentID value.
		/// </summary>
		public long ParentID
		{
			get { return parentID; }
			set { parentID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		public long PatientVisitID
		{
			get { return patientVisitID; }
			set { patientVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the TaskStatusID value.
		/// </summary>
		public int TaskStatusID
		{
			get { return taskStatusID; }
			set { taskStatusID = value; }
		}

		/// <summary>
		/// Gets or sets the HighlightColor value.
		/// </summary>
		public string HighlightColor
		{
			get { return highlightColor; }
			set { highlightColor = value; }
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
		/// Gets or sets the SpecialityID value.
		/// </summary>
		public int SpecialityID
		{
			get { return specialityID; }
			set { specialityID = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		public int LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the RefernceID value.
		/// </summary>
		public string RefernceID
		{
			get { return refernceID; }
			set { refernceID = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the Taskid value.
		/// </summary>
		public long Taskid
		{
			get { return taskid; }
			set { taskid = value; }
		}


		#endregion
}
}
