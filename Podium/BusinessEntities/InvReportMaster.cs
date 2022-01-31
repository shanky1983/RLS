using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvReportMaster
	{
		#region Fields

		private int templateID=0;
		private string reportTemplateName=String.Empty;
		private string isDefault=String.Empty;
		private int orgID=0;
		private string isActive=String.Empty;
		private string type=String.Empty;
		private string templateName=String.Empty;
		private long stationaryID=0;
		private string isSeperatePrint=String.Empty;
		private int iD=0;
		private int templateSeq=0;
		private long imageGroupID=0;
		private int location=0;
		private int templateTypeID=0;
		private int transOrgID=0;
		private bool isParentOrg=false;
		private long transVisitID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TemplateID value.
		/// </summary>
		public int TemplateID
		{
			get { return templateID; }
			set { templateID = value; }
		}

		/// <summary>
		/// Gets or sets the ReportTemplateName value.
		/// </summary>
		public string ReportTemplateName
		{
			get { return reportTemplateName; }
			set { reportTemplateName = value; }
		}

		/// <summary>
		/// Gets or sets the IsDefault value.
		/// </summary>
		public string IsDefault
		{
			get { return isDefault; }
			set { isDefault = value; }
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
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
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
		/// Gets or sets the TemplateName value.
		/// </summary>
		public string TemplateName
		{
			get { return templateName; }
			set { templateName = value; }
		}

		/// <summary>
		/// Gets or sets the StationaryID value.
		/// </summary>
		public long StationaryID
		{
			get { return stationaryID; }
			set { stationaryID = value; }
		}

		/// <summary>
		/// Gets or sets the IsSeperatePrint value.
		/// </summary>
		public string IsSeperatePrint
		{
			get { return isSeperatePrint; }
			set { isSeperatePrint = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the TemplateSeq value.
		/// </summary>
		public int TemplateSeq
		{
			get { return templateSeq; }
			set { templateSeq = value; }
		}

		/// <summary>
		/// Gets or sets the ImageGroupID value.
		/// </summary>
		public long ImageGroupID
		{
			get { return imageGroupID; }
			set { imageGroupID = value; }
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
		/// Gets or sets the TemplateTypeID value.
		/// </summary>
		public int TemplateTypeID
		{
			get { return templateTypeID; }
			set { templateTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the TransOrgID value.
		/// </summary>
		public int TransOrgID
		{
			get { return transOrgID; }
			set { transOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the IsParentOrg value.
		/// </summary>
		public bool IsParentOrg
		{
			get { return isParentOrg; }
			set { isParentOrg = value; }
		}

		/// <summary>
		/// Gets or sets the TransVisitID value.
		/// </summary>
		public long TransVisitID
		{
			get { return transVisitID; }
			set { transVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationName value.
		/// </summary>
		private string _investigationName=String.Empty;
		public string InvestigationName
		{
			get { return  _investigationName; }
			set { _investigationName = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		private long _investigationID=0;
		public long InvestigationID
		{
			get { return  _investigationID; }
			set { _investigationID = value; }
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
		/// Gets or sets the CreatedAt value.
		/// </summary>
		private DateTime _createdAt=DateTime.MaxValue;
		public DateTime CreatedAt
		{
			get { return  _createdAt; }
			set { _createdAt = value; }
		}

		/// <summary>
		/// Gets or sets the AccessionNumber value.
		/// </summary>
		private long _accessionNumber=0;
		public long AccessionNumber
		{
			get { return  _accessionNumber; }
			set { _accessionNumber = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		private long _patientID=0;
		public long PatientID
		{
			get { return  _patientID; }
			set { _patientID = value; }
		}

		/// <summary>
		/// Gets or sets the DeptID value.
		/// </summary>
		private int _deptID=0;
		public int DeptID
		{
			get { return  _deptID; }
			set { _deptID = value; }
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
		/// Gets or sets the PrintCount value.
		/// </summary>
		private int _printCount=0;
		public int PrintCount
		{
			get { return  _printCount; }
			set { _printCount = value; }
		}

		/// <summary>
		/// Gets or sets the PkgName value.
		/// </summary>
		private string _pkgName=String.Empty;
		public string PkgName
		{
			get { return  _pkgName; }
			set { _pkgName = value; }
		}

		/// <summary>
		/// Gets or sets the PkgId value.
		/// </summary>
		private long _pkgId=0;
		public long PkgId
		{
			get { return  _pkgId; }
			set { _pkgId = value; }
		}

		/// <summary>
		/// Gets or sets the IsBlindingClient value.
		/// </summary>
		private string _isBlindingClient=String.Empty;
		public string IsBlindingClient
		{
			get { return  _isBlindingClient; }
			set { _isBlindingClient = value; }
		}

		/// <summary>
		/// Gets or sets the IsConfidentialTest value.
		/// </summary>
		private string _isConfidentialTest=String.Empty;
		public string IsConfidentialTest
		{
			get { return  _isConfidentialTest; }
			set { _isConfidentialTest = value; }
		}

		/// <summary>
		/// Gets or sets the IsCopublish value.
		/// </summary>
		private string _isCopublish=String.Empty;
		public string IsCopublish
		{
			get { return  _isCopublish; }
			set { _isCopublish = value; }
		}

		/// <summary>
		/// Gets or sets the PriorityTest value.
		/// </summary>
		private string _priorityTest=String.Empty;
		public string PriorityTest
		{
			get { return  _priorityTest; }
			set { _priorityTest = value; }
		}

		/// <summary>
		/// Gets or sets the ReportAccessionNumber value.
		/// </summary>
		private string _reportAccessionNumber=String.Empty;
		public string ReportAccessionNumber
		{
			get { return  _reportAccessionNumber; }
			set { _reportAccessionNumber = value; }
		}


		#endregion
}
}
