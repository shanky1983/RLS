using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class OrderedInvestigations_Hist
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
		private string sortedTask=String.Empty;
		private string print_Task=String.Empty;
		private int print_taskid=0;
		private string isCoPublish=String.Empty;
		private string isBlindingClient=String.Empty;
		private string isSensitive=String.Empty;
		private bool isarchive=false;
		private long orderedID=0;
		private long billingID=0;
		private DateTime reportCommitTime=DateTime.MaxValue;
		private string recollectNotify=String.Empty;
		private long physicianID=0;
		private string orderType=String.Empty;
		private string barcodeNumber=String.Empty;
		private string updatestauts=String.Empty;
		private long orderID=0;
		private string deviceid=String.Empty;
		private string testCode=String.Empty;
		private long orderTaskID=0;
		private decimal orderedQty=Decimal.Zero;
		private long patientVisitAttribID=0;
		private long perphyID=0;
		private string perphyname=String.Empty;
		private string performertype=String.Empty;
		private string sampleID=String.Empty;
		private byte isIntegrationTest=0x00;
		private DateTime tatreferencedatetime=DateTime.MaxValue;
		private byte tatreferencedatebase=0x00;
		private short logistictimeinmins=0;
		private DateTime tatsamplereceiptdatetime=DateTime.MaxValue;
		private int processingtimeinmins=0;
		private DateTime tatprocessstartdatetime=DateTime.MaxValue;
		private TimeSpan labendtime=TimeSpan.MinValue;
		private TimeSpan earlyreporttime=TimeSpan.MinValue;
		private DateTime customerCommittedTAT=DateTime.MaxValue;
		private long billingDetailsID=0;
		private bool isNonPath=false;
		private long currentLocationID=0;
		private string messageControlID=String.Empty;
		private string tCODE=String.Empty;
		private long hLMessageOBRDetailsID=0;
		private string previousStatus=String.Empty;

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

		/// <summary>
		/// Gets or sets the SortedTask value.
		/// </summary>
		public string SortedTask
		{
			get { return sortedTask; }
			set { sortedTask = value; }
		}

		/// <summary>
		/// Gets or sets the Print_Task value.
		/// </summary>
		public string Print_Task
		{
			get { return print_Task; }
			set { print_Task = value; }
		}

		/// <summary>
		/// Gets or sets the Print_taskid value.
		/// </summary>
		public int Print_taskid
		{
			get { return print_taskid; }
			set { print_taskid = value; }
		}

		/// <summary>
		/// Gets or sets the IsCoPublish value.
		/// </summary>
		public string IsCoPublish
		{
			get { return isCoPublish; }
			set { isCoPublish = value; }
		}

		/// <summary>
		/// Gets or sets the IsBlindingClient value.
		/// </summary>
		public string IsBlindingClient
		{
			get { return isBlindingClient; }
			set { isBlindingClient = value; }
		}

		/// <summary>
		/// Gets or sets the IsSensitive value.
		/// </summary>
		public string IsSensitive
		{
			get { return isSensitive; }
			set { isSensitive = value; }
		}

		/// <summary>
		/// Gets or sets the Isarchive value.
		/// </summary>
		public bool Isarchive
		{
			get { return isarchive; }
			set { isarchive = value; }
		}

		/// <summary>
		/// Gets or sets the OrderedID value.
		/// </summary>
		public long OrderedID
		{
			get { return orderedID; }
			set { orderedID = value; }
		}

		/// <summary>
		/// Gets or sets the BillingID value.
		/// </summary>
		public long BillingID
		{
			get { return billingID; }
			set { billingID = value; }
		}

		/// <summary>
		/// Gets or sets the ReportCommitTime value.
		/// </summary>
		public DateTime ReportCommitTime
		{
			get { return reportCommitTime; }
			set { reportCommitTime = value; }
		}

		/// <summary>
		/// Gets or sets the RecollectNotify value.
		/// </summary>
		public string RecollectNotify
		{
			get { return recollectNotify; }
			set { recollectNotify = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianID value.
		/// </summary>
		public long PhysicianID
		{
			get { return physicianID; }
			set { physicianID = value; }
		}

		/// <summary>
		/// Gets or sets the OrderType value.
		/// </summary>
		public string OrderType
		{
			get { return orderType; }
			set { orderType = value; }
		}

		/// <summary>
		/// Gets or sets the BarcodeNumber value.
		/// </summary>
		public string BarcodeNumber
		{
			get { return barcodeNumber; }
			set { barcodeNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Updatestauts value.
		/// </summary>
		public string Updatestauts
		{
			get { return updatestauts; }
			set { updatestauts = value; }
		}

		/// <summary>
		/// Gets or sets the OrderID value.
		/// </summary>
		public long OrderID
		{
			get { return orderID; }
			set { orderID = value; }
		}

		/// <summary>
		/// Gets or sets the Deviceid value.
		/// </summary>
		public string Deviceid
		{
			get { return deviceid; }
			set { deviceid = value; }
		}

		/// <summary>
		/// Gets or sets the TestCode value.
		/// </summary>
		public string TestCode
		{
			get { return testCode; }
			set { testCode = value; }
		}

		/// <summary>
		/// Gets or sets the OrderTaskID value.
		/// </summary>
		public long OrderTaskID
		{
			get { return orderTaskID; }
			set { orderTaskID = value; }
		}

		/// <summary>
		/// Gets or sets the OrderedQty value.
		/// </summary>
		public decimal OrderedQty
		{
			get { return orderedQty; }
			set { orderedQty = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVisitAttribID value.
		/// </summary>
		public long PatientVisitAttribID
		{
			get { return patientVisitAttribID; }
			set { patientVisitAttribID = value; }
		}

		/// <summary>
		/// Gets or sets the PerphyID value.
		/// </summary>
		public long PerphyID
		{
			get { return perphyID; }
			set { perphyID = value; }
		}

		/// <summary>
		/// Gets or sets the Perphyname value.
		/// </summary>
		public string Perphyname
		{
			get { return perphyname; }
			set { perphyname = value; }
		}

		/// <summary>
		/// Gets or sets the Performertype value.
		/// </summary>
		public string Performertype
		{
			get { return performertype; }
			set { performertype = value; }
		}

		/// <summary>
		/// Gets or sets the SampleID value.
		/// </summary>
		public string SampleID
		{
			get { return sampleID; }
			set { sampleID = value; }
		}

		/// <summary>
		/// Gets or sets the IsIntegrationTest value.
		/// </summary>
		public byte IsIntegrationTest
		{
			get { return isIntegrationTest; }
			set { isIntegrationTest = value; }
		}

		/// <summary>
		/// Gets or sets the Tatreferencedatetime value.
		/// </summary>
		public DateTime Tatreferencedatetime
		{
			get { return tatreferencedatetime; }
			set { tatreferencedatetime = value; }
		}

		/// <summary>
		/// Gets or sets the Tatreferencedatebase value.
		/// </summary>
		public byte Tatreferencedatebase
		{
			get { return tatreferencedatebase; }
			set { tatreferencedatebase = value; }
		}

		/// <summary>
		/// Gets or sets the Logistictimeinmins value.
		/// </summary>
		public short Logistictimeinmins
		{
			get { return logistictimeinmins; }
			set { logistictimeinmins = value; }
		}

		/// <summary>
		/// Gets or sets the Tatsamplereceiptdatetime value.
		/// </summary>
		public DateTime Tatsamplereceiptdatetime
		{
			get { return tatsamplereceiptdatetime; }
			set { tatsamplereceiptdatetime = value; }
		}

		/// <summary>
		/// Gets or sets the Processingtimeinmins value.
		/// </summary>
		public int Processingtimeinmins
		{
			get { return processingtimeinmins; }
			set { processingtimeinmins = value; }
		}

		/// <summary>
		/// Gets or sets the Tatprocessstartdatetime value.
		/// </summary>
		public DateTime Tatprocessstartdatetime
		{
			get { return tatprocessstartdatetime; }
			set { tatprocessstartdatetime = value; }
		}

		/// <summary>
		/// Gets or sets the Labendtime value.
		/// </summary>
		public TimeSpan Labendtime
		{
			get { return labendtime; }
			set { labendtime = value; }
		}

		/// <summary>
		/// Gets or sets the Earlyreporttime value.
		/// </summary>
		public TimeSpan Earlyreporttime
		{
			get { return earlyreporttime; }
			set { earlyreporttime = value; }
		}

		/// <summary>
		/// Gets or sets the CustomerCommittedTAT value.
		/// </summary>
		public DateTime CustomerCommittedTAT
		{
			get { return customerCommittedTAT; }
			set { customerCommittedTAT = value; }
		}

		/// <summary>
		/// Gets or sets the BillingDetailsID value.
		/// </summary>
		public long BillingDetailsID
		{
			get { return billingDetailsID; }
			set { billingDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the IsNonPath value.
		/// </summary>
		public bool IsNonPath
		{
			get { return isNonPath; }
			set { isNonPath = value; }
		}

		/// <summary>
		/// Gets or sets the CurrentLocationID value.
		/// </summary>
		public long CurrentLocationID
		{
			get { return currentLocationID; }
			set { currentLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the MessageControlID value.
		/// </summary>
		public string MessageControlID
		{
			get { return messageControlID; }
			set { messageControlID = value; }
		}

		/// <summary>
		/// Gets or sets the TCODE value.
		/// </summary>
		public string TCODE
		{
			get { return tCODE; }
			set { tCODE = value; }
		}

		/// <summary>
		/// Gets or sets the HLMessageOBRDetailsID value.
		/// </summary>
		public long HLMessageOBRDetailsID
		{
			get { return hLMessageOBRDetailsID; }
			set { hLMessageOBRDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the PreviousStatus value.
		/// </summary>
		public string PreviousStatus
		{
			get { return previousStatus; }
			set { previousStatus = value; }
		}


		#endregion
}
}
