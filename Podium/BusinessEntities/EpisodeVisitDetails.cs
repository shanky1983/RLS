using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
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
		private string _packageName=String.Empty;
		public string PackageName
		{
			get { return  _packageName; }
			set { _packageName = value; }
		}

		/// <summary>
		/// Gets or sets the EpisodeName value.
		/// </summary>
		private string _episodeName=String.Empty;
		public string EpisodeName
		{
			get { return  _episodeName; }
			set { _episodeName = value; }
		}

		/// <summary>
		/// Gets or sets the EpisodeNumber value.
		/// </summary>
		private string _episodeNumber=String.Empty;
		public string EpisodeNumber
		{
			get { return  _episodeNumber; }
			set { _episodeNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		private string _status=String.Empty;
		public string Status
		{
			get { return  _status; }
			set { _status = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		private string _description=String.Empty;
		public string Description
		{
			get { return  _description; }
			set { _description = value; }
		}

		/// <summary>
		/// Gets or sets the StudyTypeID value.
		/// </summary>
		private int _studyTypeID=0;
		public int StudyTypeID
		{
			get { return  _studyTypeID; }
			set { _studyTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the NoOfPatient value.
		/// </summary>
		private int _noOfPatient=0;
		public int NoOfPatient
		{
			get { return  _noOfPatient; }
			set { _noOfPatient = value; }
		}

		/// <summary>
		/// Gets or sets the ISAdhoc value.
		/// </summary>
		private string _iSAdhoc=String.Empty;
		public string ISAdhoc
		{
			get { return  _iSAdhoc; }
			set { _iSAdhoc = value; }
		}

		/// <summary>
		/// Gets or sets the SiteDetails value.
		/// </summary>
		private string _siteDetails=String.Empty;
		public string SiteDetails
		{
			get { return  _siteDetails; }
			set { _siteDetails = value; }
		}

		/// <summary>
		/// Gets or sets the SiteName value.
		/// </summary>
		private string _siteName=String.Empty;
		public string SiteName
		{
			get { return  _siteName; }
			set { _siteName = value; }
		}

		/// <summary>
		/// Gets or sets the SiteID value.
		/// </summary>
		private long _siteID=0;
		public long SiteID
		{
			get { return  _siteID; }
			set { _siteID = value; }
		}

		/// <summary>
		/// Gets or sets the TimedDisplayText value.
		/// </summary>
		private string _timedDisplayText=String.Empty;
		public string TimedDisplayText
		{
			get { return  _timedDisplayText; }
			set { _timedDisplayText = value; }
		}

		/// <summary>
		/// Gets or sets the VisitTypeDisplayText value.
		/// </summary>
		private string _visitTypeDisplayText=String.Empty;
		public string VisitTypeDisplayText
		{
			get { return  _visitTypeDisplayText; }
			set { _visitTypeDisplayText = value; }
		}

		/// <summary>
		/// Gets or sets the Amount value.
		/// </summary>
		private int _amount=0;
		public int Amount
		{
			get { return  _amount; }
			set { _amount = value; }
		}

		/// <summary>
		/// Gets or sets the RaisedQty value.
		/// </summary>
		private int _raisedQty=0;
		public int RaisedQty
		{
			get { return  _raisedQty; }
			set { _raisedQty = value; }
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
		/// Gets or sets the PatientType value.
		/// </summary>
		private string _patientType=String.Empty;
		public string PatientType
		{
			get { return  _patientType; }
			set { _patientType = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayText value.
		/// </summary>
		private string _displayText=String.Empty;
		public string DisplayText
		{
			get { return  _displayText; }
			set { _displayText = value; }
		}

		/// <summary>
		/// Gets or sets the URNO value.
		/// </summary>
		private string _uRNO=String.Empty;
		public string URNO
		{
			get { return  _uRNO; }
			set { _uRNO = value; }
		}

		/// <summary>
		/// Gets or sets the PrintedDate value.
		/// </summary>
		private DateTime _printedDate=DateTime.MaxValue;
		public DateTime PrintedDate
		{
			get { return  _printedDate; }
			set { _printedDate = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
		private DateTime _createdAt=DateTime.MaxValue;
		public DateTime CreatedAt
		{
			get { return  _createdAt; }
			set { _createdAt = value; }
		}


		#endregion
}
}
