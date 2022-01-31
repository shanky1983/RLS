using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ORDTMP
	{
		#region Fields

		private long visitID=0;
		private long iD=0;
		private string name=String.Empty;
		private string type=String.Empty;
		private string status=String.Empty;
		private long accessionNumber=0;
		private string studyInstanceUId=String.Empty;
		private string performingPhysicain=String.Empty;
		private int complaintId=0;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string investigationsType=String.Empty;
		private long referralID=0;
		private string paymentStatus=String.Empty;
		private string uID=String.Empty;
		private int resCaptureLoc=0;
		private int mPPSStatus=0;
		private long referredAccessionNo=0;
		private long taskID=0;
		private string labNo=String.Empty;
		private long refPhysicianID=0;
		private string refPhyName=String.Empty;
		private string referenceType=String.Empty;
		private string referredType=String.Empty;
		private string investigationComment=String.Empty;
		private int printCount=0;
		private string visitSampleStatus=String.Empty;
		private DateTime samplePickupDate=DateTime.MaxValue;
		private string migrated_Patient_Number=String.Empty;
		private string migrated_Request_Number=String.Empty;
		private string migrated_Visit_Number=String.Empty;
		private string migrated_TestCode=String.Empty;
		private long patient_HISTID=0;
		private long pkgID=0;
		private string pkgName=String.Empty;
		private string isStat=String.Empty;
		private DateTime reportDateTime=DateTime.MaxValue;
		private DateTime tatDateTime=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the AccessionNumber value.
		/// </summary>
		public long AccessionNumber
		{
			get { return accessionNumber; }
			set { accessionNumber = value; }
		}

		/// <summary>
		/// Gets or sets the StudyInstanceUId value.
		/// </summary>
		public string StudyInstanceUId
		{
			get { return studyInstanceUId; }
			set { studyInstanceUId = value; }
		}

		/// <summary>
		/// Gets or sets the PerformingPhysicain value.
		/// </summary>
		public string PerformingPhysicain
		{
			get { return performingPhysicain; }
			set { performingPhysicain = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintId value.
		/// </summary>
		public int ComplaintId
		{
			get { return complaintId; }
			set { complaintId = value; }
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
		/// Gets or sets the InvestigationsType value.
		/// </summary>
		public string InvestigationsType
		{
			get { return investigationsType; }
			set { investigationsType = value; }
		}

		/// <summary>
		/// Gets or sets the ReferralID value.
		/// </summary>
		public long ReferralID
		{
			get { return referralID; }
			set { referralID = value; }
		}

		/// <summary>
		/// Gets or sets the PaymentStatus value.
		/// </summary>
		public string PaymentStatus
		{
			get { return paymentStatus; }
			set { paymentStatus = value; }
		}

		/// <summary>
		/// Gets or sets the UID value.
		/// </summary>
		public string UID
		{
			get { return uID; }
			set { uID = value; }
		}

		/// <summary>
		/// Gets or sets the ResCaptureLoc value.
		/// </summary>
		public int ResCaptureLoc
		{
			get { return resCaptureLoc; }
			set { resCaptureLoc = value; }
		}

		/// <summary>
		/// Gets or sets the MPPSStatus value.
		/// </summary>
		public int MPPSStatus
		{
			get { return mPPSStatus; }
			set { mPPSStatus = value; }
		}

		/// <summary>
		/// Gets or sets the ReferredAccessionNo value.
		/// </summary>
		public long ReferredAccessionNo
		{
			get { return referredAccessionNo; }
			set { referredAccessionNo = value; }
		}

		/// <summary>
		/// Gets or sets the TaskID value.
		/// </summary>
		public long TaskID
		{
			get { return taskID; }
			set { taskID = value; }
		}

		/// <summary>
		/// Gets or sets the LabNo value.
		/// </summary>
		public string LabNo
		{
			get { return labNo; }
			set { labNo = value; }
		}

		/// <summary>
		/// Gets or sets the RefPhysicianID value.
		/// </summary>
		public long RefPhysicianID
		{
			get { return refPhysicianID; }
			set { refPhysicianID = value; }
		}

		/// <summary>
		/// Gets or sets the RefPhyName value.
		/// </summary>
		public string RefPhyName
		{
			get { return refPhyName; }
			set { refPhyName = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceType value.
		/// </summary>
		public string ReferenceType
		{
			get { return referenceType; }
			set { referenceType = value; }
		}

		/// <summary>
		/// Gets or sets the ReferredType value.
		/// </summary>
		public string ReferredType
		{
			get { return referredType; }
			set { referredType = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationComment value.
		/// </summary>
		public string InvestigationComment
		{
			get { return investigationComment; }
			set { investigationComment = value; }
		}

		/// <summary>
		/// Gets or sets the PrintCount value.
		/// </summary>
		public int PrintCount
		{
			get { return printCount; }
			set { printCount = value; }
		}

		/// <summary>
		/// Gets or sets the VisitSampleStatus value.
		/// </summary>
		public string VisitSampleStatus
		{
			get { return visitSampleStatus; }
			set { visitSampleStatus = value; }
		}

		/// <summary>
		/// Gets or sets the SamplePickupDate value.
		/// </summary>
		public DateTime SamplePickupDate
		{
			get { return samplePickupDate; }
			set { samplePickupDate = value; }
		}

		/// <summary>
		/// Gets or sets the Migrated_Patient_Number value.
		/// </summary>
		public string Migrated_Patient_Number
		{
			get { return migrated_Patient_Number; }
			set { migrated_Patient_Number = value; }
		}

		/// <summary>
		/// Gets or sets the Migrated_Request_Number value.
		/// </summary>
		public string Migrated_Request_Number
		{
			get { return migrated_Request_Number; }
			set { migrated_Request_Number = value; }
		}

		/// <summary>
		/// Gets or sets the Migrated_Visit_Number value.
		/// </summary>
		public string Migrated_Visit_Number
		{
			get { return migrated_Visit_Number; }
			set { migrated_Visit_Number = value; }
		}

		/// <summary>
		/// Gets or sets the Migrated_TestCode value.
		/// </summary>
		public string Migrated_TestCode
		{
			get { return migrated_TestCode; }
			set { migrated_TestCode = value; }
		}

		/// <summary>
		/// Gets or sets the Patient_HISTID value.
		/// </summary>
		public long Patient_HISTID
		{
			get { return patient_HISTID; }
			set { patient_HISTID = value; }
		}

		/// <summary>
		/// Gets or sets the PkgID value.
		/// </summary>
		public long PkgID
		{
			get { return pkgID; }
			set { pkgID = value; }
		}

		/// <summary>
		/// Gets or sets the PkgName value.
		/// </summary>
		public string PkgName
		{
			get { return pkgName; }
			set { pkgName = value; }
		}

		/// <summary>
		/// Gets or sets the IsStat value.
		/// </summary>
		public string IsStat
		{
			get { return isStat; }
			set { isStat = value; }
		}

		/// <summary>
		/// Gets or sets the ReportDateTime value.
		/// </summary>
		public DateTime ReportDateTime
		{
			get { return reportDateTime; }
			set { reportDateTime = value; }
		}

		/// <summary>
		/// Gets or sets the TatDateTime value.
		/// </summary>
		public DateTime TatDateTime
		{
			get { return tatDateTime; }
			set { tatDateTime = value; }
		}


		#endregion
}
}
