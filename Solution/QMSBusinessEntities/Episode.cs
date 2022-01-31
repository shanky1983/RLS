using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Episode
	{
		#region Fields

		private long episodeID=0;
		private string episodeName=String.Empty;
		private int orgID=0;
		private int noofSitting=0;
		private long clientID=0;
		private int studyTypeID=0;
		private string episodeNumber=String.Empty;
		private DateTime startDate=DateTime.MaxValue;
		private DateTime endDate=DateTime.MaxValue;
		private string attributes=String.Empty;
		private int noOfPatient=0;
		private string iSAdhoc=String.Empty;
		private int orgLocationID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string episodeStatus=String.Empty;
		private string lifeStatus=String.Empty;
		private string clientSiteAttribute=String.Empty;
		private int siteWiseSubjectAllocation=0;
		private int visitWiseSubjectAllocation=0;
		private int studyPhaseID=0;
		private string studySource=String.Empty;
		private string studyDesign=String.Empty;
		private string referenceLab=String.Empty;
		private int screeningSubjects=0;
		private int noOfSites=0;
		private string isUndefinedScreening=String.Empty;
		private string therapeuticVlaue=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the EpisodeID value.
		/// </summary>
		public long EpisodeID
		{
			get { return episodeID; }
			set { episodeID = value; }
		}

		/// <summary>
		/// Gets or sets the EpisodeName value.
		/// </summary>
		public string EpisodeName
		{
			get { return episodeName; }
			set { episodeName = value; }
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
		/// Gets or sets the NoofSitting value.
		/// </summary>
		public int NoofSitting
		{
			get { return noofSitting; }
			set { noofSitting = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public long ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		/// <summary>
		/// Gets or sets the StudyTypeID value.
		/// </summary>
		public int StudyTypeID
		{
			get { return studyTypeID; }
			set { studyTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the EpisodeNumber value.
		/// </summary>
		public string EpisodeNumber
		{
			get { return episodeNumber; }
			set { episodeNumber = value; }
		}

		/// <summary>
		/// Gets or sets the StartDate value.
		/// </summary>
		public DateTime StartDate
		{
			get { return startDate; }
			set { startDate = value; }
		}

		/// <summary>
		/// Gets or sets the EndDate value.
		/// </summary>
		public DateTime EndDate
		{
			get { return endDate; }
			set { endDate = value; }
		}

		/// <summary>
		/// Gets or sets the Attributes value.
		/// </summary>
		public string Attributes
		{
			get { return attributes; }
			set { attributes = value; }
		}

		/// <summary>
		/// Gets or sets the NoOfPatient value.
		/// </summary>
		public int NoOfPatient
		{
			get { return noOfPatient; }
			set { noOfPatient = value; }
		}

		/// <summary>
		/// Gets or sets the ISAdhoc value.
		/// </summary>
		public string ISAdhoc
		{
			get { return iSAdhoc; }
			set { iSAdhoc = value; }
		}

		/// <summary>
		/// Gets or sets the OrgLocationID value.
		/// </summary>
		public int OrgLocationID
		{
			get { return orgLocationID; }
			set { orgLocationID = value; }
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
		/// Gets or sets the EpisodeStatus value.
		/// </summary>
		public string EpisodeStatus
		{
			get { return episodeStatus; }
			set { episodeStatus = value; }
		}

		/// <summary>
		/// Gets or sets the LifeStatus value.
		/// </summary>
		public string LifeStatus
		{
			get { return lifeStatus; }
			set { lifeStatus = value; }
		}

		/// <summary>
		/// Gets or sets the ClientSiteAttribute value.
		/// </summary>
		public string ClientSiteAttribute
		{
			get { return clientSiteAttribute; }
			set { clientSiteAttribute = value; }
		}

		/// <summary>
		/// Gets or sets the SiteWiseSubjectAllocation value.
		/// </summary>
		public int SiteWiseSubjectAllocation
		{
			get { return siteWiseSubjectAllocation; }
			set { siteWiseSubjectAllocation = value; }
		}

		/// <summary>
		/// Gets or sets the VisitWiseSubjectAllocation value.
		/// </summary>
		public int VisitWiseSubjectAllocation
		{
			get { return visitWiseSubjectAllocation; }
			set { visitWiseSubjectAllocation = value; }
		}

		/// <summary>
		/// Gets or sets the StudyPhaseID value.
		/// </summary>
		public int StudyPhaseID
		{
			get { return studyPhaseID; }
			set { studyPhaseID = value; }
		}

		/// <summary>
		/// Gets or sets the StudySource value.
		/// </summary>
		public string StudySource
		{
			get { return studySource; }
			set { studySource = value; }
		}

		/// <summary>
		/// Gets or sets the StudyDesign value.
		/// </summary>
		public string StudyDesign
		{
			get { return studyDesign; }
			set { studyDesign = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceLab value.
		/// </summary>
		public string ReferenceLab
		{
			get { return referenceLab; }
			set { referenceLab = value; }
		}

		/// <summary>
		/// Gets or sets the ScreeningSubjects value.
		/// </summary>
		public int ScreeningSubjects
		{
			get { return screeningSubjects; }
			set { screeningSubjects = value; }
		}

		/// <summary>
		/// Gets or sets the NoOfSites value.
		/// </summary>
		public int NoOfSites
		{
			get { return noOfSites; }
			set { noOfSites = value; }
		}

		/// <summary>
		/// Gets or sets the IsUndefinedScreening value.
		/// </summary>
		public string IsUndefinedScreening
		{
			get { return isUndefinedScreening; }
			set { isUndefinedScreening = value; }
		}

		/// <summary>
		/// Gets or sets the TherapeuticVlaue value.
		/// </summary>
		public string TherapeuticVlaue
		{
			get { return therapeuticVlaue; }
			set { therapeuticVlaue = value; }
		}

		/// <summary>
		/// Gets or sets the ClientName value.
		/// </summary>
		string _clientname;
		public string ClientName
		{
			get { return _clientname; }
			set { _clientname = value; }
		}

		/// <summary>
		/// Gets or sets the StudyType value.
		/// </summary>
		string _studytype;
		public string StudyType
		{
			get { return _studytype; }
			set { _studytype = value; }
		}

		/// <summary>
		/// Gets or sets the VisitDetails value.
		/// </summary>
		string _visitdetails;
		public string VisitDetails
		{
			get { return _visitdetails; }
			set { _visitdetails = value; }
		}

		/// <summary>
		/// Gets or sets the Fdate value.
		/// </summary>
		string _fdate;
		public string Fdate
		{
			get { return _fdate; }
			set { _fdate = value; }
		}

		/// <summary>
		/// Gets or sets the Tdate value.
		/// </summary>
		string _tdate;
		public string Tdate
		{
			get { return _tdate; }
			set { _tdate = value; }
		}

		/// <summary>
		/// Gets or sets the TaskStatusID value.
		/// </summary>
		long _taskstatusid;
		public long TaskStatusID
		{
			get { return _taskstatusid; }
			set { _taskstatusid = value; }
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
		/// Gets or sets the ChildAttribute value.
		/// </summary>
		string _childattribute;
		public string ChildAttribute
		{
			get { return _childattribute; }
			set { _childattribute = value; }
		}

		/// <summary>
		/// Gets or sets the VisitCount value.
		/// </summary>
		long _visitcount;
		public long VisitCount
		{
			get { return _visitcount; }
			set { _visitcount = value; }
		}


		#endregion
}
}
