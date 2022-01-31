using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Tasks
	{
		#region Fields

		private long taskID=0;
		private int taskActionID=0;
		private string taskDescription=String.Empty;
		private string redirectURL=String.Empty;
		private DateTime taskDate=DateTime.MaxValue;
		private long patientID=0;
		private long assignedTo=0;
		private long roleID=0;
		private int orgID=0;
		private long parentID=0;
		private long patientVisitID=0;
		private int taskStatusID=0;
		private string highlightColor=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int specialityID=0;
		private string refernceID=String.Empty;
		private string type=String.Empty;
		private int locationID=0;
		private string remarks=String.Empty;
		private DateTime showedTime=DateTime.MaxValue;
		private int deptID=0;
		private long fTReferenceID=0;
		private string fromTable=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TaskID value.
		/// </summary>
		public long TaskID
		{
			get { return taskID; }
			set { taskID = value; }
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
		/// Gets or sets the AssignedTo value.
		/// </summary>
		public long AssignedTo
		{
			get { return assignedTo; }
			set { assignedTo = value; }
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
		/// Gets or sets the SpecialityID value.
		/// </summary>
		public int SpecialityID
		{
			get { return specialityID; }
			set { specialityID = value; }
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
		/// Gets or sets the LocationID value.
		/// </summary>
		public int LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
		}

		/// <summary>
		/// Gets or sets the ShowedTime value.
		/// </summary>
		public DateTime ShowedTime
		{
			get { return showedTime; }
			set { showedTime = value; }
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
		/// Gets or sets the FTReferenceID value.
		/// </summary>
		public long FTReferenceID
		{
			get { return fTReferenceID; }
			set { fTReferenceID = value; }
		}

		/// <summary>
		/// Gets or sets the FromTable value.
		/// </summary>
		public string FromTable
		{
			get { return fromTable; }
			set { fromTable = value; }
		}

		/// <summary>
		/// Gets or sets the Category value.
		/// </summary>
		private string _category=String.Empty;
		public string Category
		{
			get { return  _category; }
			set { _category = value; }
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
		/// Gets or sets the DispTextFiller value.
		/// </summary>
		private Hashtable _dispTextFiller=new Hashtable();
		public Hashtable DispTextFiller
		{
			get { return  _dispTextFiller; }
			set { _dispTextFiller = value; }
		}

		/// <summary>
		/// Gets or sets the URLFiller value.
		/// </summary>
		private Hashtable _uRLFiller=new Hashtable();
		public Hashtable URLFiller
		{
			get { return  _uRLFiller; }
			set { _uRLFiller = value; }
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
		/// Gets or sets the BillID value.
		/// </summary>
		private long _billID=0;
		public long BillID
		{
			get { return  _billID; }
			set { _billID = value; }
		}

		/// <summary>
		/// Gets or sets the StatusName value.
		/// </summary>
		private string _statusName=String.Empty;
		public string StatusName
		{
			get { return  _statusName; }
			set { _statusName = value; }
		}

		/// <summary>
		/// Gets or sets the AllowDuplicate value.
		/// </summary>
		private string _allowDuplicate=String.Empty;
		public string AllowDuplicate
		{
			get { return  _allowDuplicate; }
			set { _allowDuplicate = value; }
		}

		/// <summary>
		/// Gets or sets the IsStat value.
		/// </summary>
		private string _isStat=String.Empty;
		public string IsStat
		{
			get { return  _isStat; }
			set { _isStat = value; }
		}

		/// <summary>
		/// Gets or sets the RaiseOrgID value.
		/// </summary>
		private int _raiseOrgID=0;
		public int RaiseOrgID
		{
			get { return  _raiseOrgID; }
			set { _raiseOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the ToLocationID value.
		/// </summary>
		private int _toLocationID=0;
		public int ToLocationID
		{
			get { return  _toLocationID; }
			set { _toLocationID = value; }
		}


		#endregion
}
}
