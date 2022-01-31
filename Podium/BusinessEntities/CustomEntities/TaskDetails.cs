using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class TaskDetails
    {
        #region Fields

       
        

        private long patientID = 0;
        private long taskID = 0;
        private string labNo = string.Empty;
        private string redirectURL = String.Empty;
        private long patientVisitID = 0;
        private string taskDescription = String.Empty;
        private DateTime taskDate = DateTime.MaxValue;
        private string _category=String.Empty;
        private string _location=String.Empty;
        private string _specialityName=String.Empty;       
        private int taskActionID = 0;       
        private long assignedTo = 0;
        private long roleID = 0;
        private int orgID = 0;
       // private int OrgID = 0;
        private string orgName = String.Empty;
        private long parentID = 0;       
        private int taskStatusID = 0;
        private string highlightColor = String.Empty;
        private long createdBy = 0;
        private DateTime createdAt = DateTime.MaxValue;
        private long modifiedBy = 0;
        private DateTime modifiedAt = DateTime.MaxValue;
        private int specialityID = 0;
        private string roleName = string.Empty;
        private string investigationName = string.Empty;
        private string refernceID = String.Empty;
        private string createdName = String.Empty;
        private string clientName = String.Empty;
        private int skipTaskValue = 0;
        private int locationId=0;
        private string _urlStatus = String.Empty;
		private string tasktype = string.Empty;
		private string bGColour = String.Empty;
		private int taskpendingcount = 0;
        private int taskprogresscount = 0;
        #endregion

        #region Properties

        public string InvestigationName
        {
            get { return investigationName; }
            set { investigationName = value; }
        }
        /// <summary>
        /// Gets or sets the TaskID value.
        /// </summary>
        public long TaskID
        {
            get { return taskID; }
            set { taskID = value; }
        }
        public string LabNo
        {
            get { return labNo; }
            set { labNo = value; }
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

        private int organizationId;
        public int OrganizationId
        {
            get { return organizationId; }
            set { organizationId = value; }
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
        /// Gets or sets the Category value.
        /// </summary>
        
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        /// <summary>
        /// Gets or sets the Category value.
        /// </summary>
      
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        /// <summary>
        /// Gets or sets the Category value.
        /// </summary>
       
        public string SpecialityName 
        {
            get { return _specialityName; }
            set { _specialityName = value; }
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
        /// Gets or sets the DispTextFiller value.
        /// </summary>
        Hashtable _disptextfiller;
        public Hashtable DispTextFiller
        {
            get { return _disptextfiller; }
            set { _disptextfiller = value; }
        }

        /// <summary>
        /// Gets or sets the URLFiller value.
        /// </summary>
        Hashtable _urlfiller;
        public Hashtable URLFiller
        {
            get { return _urlfiller; }
            set { _urlfiller = value; }
        }

        /// <summary>
        /// Gets or sets the SpecialityID value.
        /// </summary>
        public int SpecialityID
        {
            get { return specialityID; }
            set { specialityID = value; }
        }

        #endregion

        /// <summary>
        /// Gets or sets the RoleName value.
        /// </summary>
        public string RoleName
        {
            get { return roleName; }
            set { roleName = value; }
        }
        public string RefernceID
        {
            get { return refernceID; }
            set { refernceID = value; }
        }
        public string CreatedName
        {
            get { return createdName; }
            set { createdName = value; }
        }

        public string OrgName
        {
            get { return orgName; }
            set { orgName = value; }
        }
        string _showedTime;
        public string ShowedTime
        {
            get { return _showedTime; }
            set { _showedTime = value; }
        }
        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        string _age;
        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }
        string _visitNumber;
        public string VisitNumber
        {
            get { return _visitNumber; }
            set { _visitNumber = value; }
        }

        string _isTimedtask;
        public string IsTimedTask
        {
            get { return _isTimedtask; }
            set { _isTimedtask = value; }
        }
        string _isURLStatus;
        public string URLStatus
        {
            get { return _isURLStatus;}
            set{_isURLStatus=value;}
        }
		public string ClientName
		  {
		   get { return clientName; }
		    set { clientName = value; }
			        
		  }
        public int LocationId
        {
            get { return locationId; }
            set { locationId = value; }
        }

        public int SkipTaskValue
        {
            get { return skipTaskValue; }
            set { skipTaskValue = value; }
        }
        public int Taskpendingcount
        {
            get { return taskpendingcount; }
            set { taskpendingcount = value; }
        }
		  public int Taskprogresscount
        {
            get { return taskprogresscount; }
            set { taskprogresscount = value; }
        }
        
        private string _CategoryText = string.Empty;
        public string CategoryText
        {
            get { return _CategoryText; }
            set { _CategoryText = value; }
        }
        private DateTime reporttatdate = DateTime.MaxValue;
        public DateTime ReportTatDate
        {
            get { return reporttatdate; }
            set { reporttatdate = value; }
			}
			
		private string _DisplayText = string.Empty;
        public string DisplayText
        {
            get { return _DisplayText; }
            set { _DisplayText = value; }
        }	
		public string TaskType
		{
			get { return tasktype; }
			set { tasktype = value;}
		}			
		public string BGColour
        {
            get { return bGColour; }
            set { bGColour = value; }
        }
		string _patientNumber;
        public string PatientNumber
        {
            get { return _patientNumber; }
            set { _patientNumber = value; }
        }

        string _mobileNumber;
        public string MobileNumber
        {
            get { return _mobileNumber; }
            set { _mobileNumber = value; }
        }
    }
}
