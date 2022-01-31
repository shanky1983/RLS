using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class EpisodeVisitDetails
	{
		#region Fields

		private long episodeVisitId=0;
		private long episodeID=0;
		private string episodeVisitName=String.Empty;
		private long feeID=0;
		private string feeType=String.Empty;
		private string timedType=String.Empty;
		private int timedNo=0;
		private int episodeVisitNumber=0;
		private string isMandatory=String.Empty;
		private string packageDetails=String.Empty;
		private int orgID=0;
		private int visitType=0;
		private string isDelete=String.Empty;
		private string guid=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the EpisodeVisitId value.
		/// </summary>
		public long EpisodeVisitId
		{
			get { return episodeVisitId; }
			set { episodeVisitId = value; }
		}

		/// <summary>
		/// Gets or sets the EpisodeID value.
		/// </summary>
		public long EpisodeID
		{
			get { return episodeID; }
			set { episodeID = value; }
		}

		/// <summary>
		/// Gets or sets the EpisodeVisitName value.
		/// </summary>
		public string EpisodeVisitName
		{
			get { return episodeVisitName; }
			set { episodeVisitName = value; }
		}

		/// <summary>
		/// Gets or sets the FeeID value.
		/// </summary>
		public long FeeID
		{
			get { return feeID; }
			set { feeID = value; }
		}

		/// <summary>
		/// Gets or sets the FeeType value.
		/// </summary>
		public string FeeType
		{
			get { return feeType; }
			set { feeType = value; }
		}

		/// <summary>
		/// Gets or sets the TimedType value.
		/// </summary>
		public string TimedType
		{
			get { return timedType; }
			set { timedType = value; }
		}

		/// <summary>
		/// Gets or sets the TimedNo value.
		/// </summary>
		public int TimedNo
		{
			get { return timedNo; }
			set { timedNo = value; }
		}

		/// <summary>
		/// Gets or sets the EpisodeVisitNumber value.
		/// </summary>
		public int EpisodeVisitNumber
		{
			get { return episodeVisitNumber; }
			set { episodeVisitNumber = value; }
		}

		/// <summary>
		/// Gets or sets the IsMandatory value.
		/// </summary>
		public string IsMandatory
		{
			get { return isMandatory; }
			set { isMandatory = value; }
		}

		/// <summary>
		/// Gets or sets the PackageDetails value.
		/// </summary>
		public string PackageDetails
		{
			get { return packageDetails; }
			set { packageDetails = value; }
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
		/// Gets or sets the VisitType value.
		/// </summary>
		public int VisitType
		{
			get { return visitType; }
			set { visitType = value; }
		}

		/// <summary>
		/// Gets or sets the IsDelete value.
		/// </summary>
		public string IsDelete
		{
			get { return isDelete; }
			set { isDelete = value; }
		}

		/// <summary>
		/// Gets or sets the Guid value.
		/// </summary>
		public string Guid
		{
			get { return guid; }
			set { guid = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
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
		/// Gets or sets the PackageName value.
		/// </summary>
		string _packagename;
		public string PackageName
		{
			get { return _packagename; }
			set { _packagename = value; }
		}

		/// <summary>
		/// Gets or sets the EpisodeName value.
		/// </summary>
		string _episodename;
		public string EpisodeName
		{
			get { return _episodename; }
			set { _episodename = value; }
		}

		/// <summary>
		/// Gets or sets the EpisodeNumber value.
		/// </summary>
		string _episodenumber;
		public string EpisodeNumber
		{
			get { return _episodenumber; }
			set { _episodenumber = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		string _status;
		public string Status
		{
			get { return _status; }
			set { _status = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		string _description;
		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		/// <summary>
		/// Gets or sets the StudyTypeID value.
		/// </summary>
		int _studytypeid;
		public int StudyTypeID
		{
			get { return _studytypeid; }
			set { _studytypeid = value; }
		}

		/// <summary>
		/// Gets or sets the NoOfPatient value.
		/// </summary>
		int _noofpatient;
		public int NoOfPatient
		{
			get { return _noofpatient; }
			set { _noofpatient = value; }
		}

		/// <summary>
		/// Gets or sets the ISAdhoc value.
		/// </summary>
		string _isadhoc;
		public string ISAdhoc
		{
			get { return _isadhoc; }
			set { _isadhoc = value; }
		}

		/// <summary>
		/// Gets or sets the SiteDetails value.
		/// </summary>
		string _sitedetails;
		public string SiteDetails
		{
			get { return _sitedetails; }
			set { _sitedetails = value; }
		}

		/// <summary>
		/// Gets or sets the SiteName value.
		/// </summary>
		string _sitename;
		public string SiteName
		{
			get { return _sitename; }
			set { _sitename = value; }
		}

		/// <summary>
		/// Gets or sets the SiteID value.
		/// </summary>
		long _siteid;
		public long SiteID
		{
			get { return _siteid; }
			set { _siteid = value; }
		}

		/// <summary>
		/// Gets or sets the TimedDisplayText value.
		/// </summary>
		string _timeddisplaytext;
		public string TimedDisplayText
		{
			get { return _timeddisplaytext; }
			set { _timeddisplaytext = value; }
		}

		/// <summary>
		/// Gets or sets the VisitTypeDisplayText value.
		/// </summary>
		string _visittypedisplaytext;
		public string VisitTypeDisplayText
		{
			get { return _visittypedisplaytext; }
			set { _visittypedisplaytext = value; }
		}

		/// <summary>
		/// Gets or sets the Amount value.
		/// </summary>
		int _amount;
		public int Amount
		{
			get { return _amount; }
			set { _amount = value; }
		}

		/// <summary>
		/// Gets or sets the RaisedQty value.
		/// </summary>
		int _raisedqty;
		public int RaisedQty
		{
			get { return _raisedqty; }
			set { _raisedqty = value; }
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
		/// Gets or sets the PatientType value.
		/// </summary>
		string _patienttype;
		public string PatientType
		{
			get { return _patienttype; }
			set { _patienttype = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayText value.
		/// </summary>
		string _displaytext;
		public string DisplayText
		{
			get { return _displaytext; }
			set { _displaytext = value; }
		}

		/// <summary>
		/// Gets or sets the URNO value.
		/// </summary>
		string _urno;
		public string URNO
		{
			get { return _urno; }
			set { _urno = value; }
		}

		/// <summary>
		/// Gets or sets the PrintedDate value.
		/// </summary>
		DateTime _printeddate;
		public DateTime PrintedDate
		{
			get { return _printeddate; }
			set { _printeddate = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
		DateTime _createdat;
		public DateTime CreatedAt
		{
			get { return _createdat; }
			set { _createdat = value; }
		}


		#endregion
}
}
