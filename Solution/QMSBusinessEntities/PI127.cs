using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PI127
	{
		#region Fields

		private long patientVisitID=0;
		private long investigationID=0;
		private string investigationName=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long investigationMethodID=0;
		private int investigationSampleContainerID=0;
		private int sampleID=0;
		private int investigationSiteID=0;
		private string isCompleted=String.Empty;
		private DateTime collectedDateTime=DateTime.MaxValue;
		private string status=String.Empty;
		private int complaintId=0;
		private int groupID=0;
		private string groupName=String.Empty;
		private string reason=String.Empty;
		private string reportStatus=String.Empty;
		private string referenceRange=String.Empty;
		private string methodName=String.Empty;
		private long iPInvSampleCollectionMasterID=0;
		private int orgID=0;
		private string worklistDeletedStatus=String.Empty;
		private string performingPhysicainName=String.Empty;
		private long kitID=0;
		private string kitName=String.Empty;
		private long instrumentID=0;
		private string instrumentName=String.Empty;
		private string interpretation=String.Empty;
		private long principleID=0;
		private string principleName=String.Empty;
		private string qCData=String.Empty;
		private int packageID=0;
		private string packageName=String.Empty;
		private long approvedBy=0;
		private long patientInvID=0;
		private DateTime orderedAt=DateTime.MaxValue;
		private string uID=String.Empty;
		private string groupComment=String.Empty;
		private DateTime approvedAt=DateTime.MaxValue;
		private long accessionNumber=0;
		private string isAbnormal=String.Empty;
		private int invStatusReasonID=0;
		private string test=String.Empty;
		private long validatedBy=0;
		private DateTime validatedAt=DateTime.MaxValue;
		private long remarksID=0;
		private string medicalRemarks=String.Empty;
		private string groupMedicalRemarks=String.Empty;
		private string refSuffixText=String.Empty;
		private string migrated_Patient_Number=String.Empty;
		private string migrated_Request_Number=String.Empty;
		private string migrated_Visit_Number=String.Empty;
		private string migrated_TestCode=String.Empty;
		private string migrated_TestType=String.Empty;
		private long workListID=0;
		private long authorizedBy=0;
		private string deviceID=String.Empty;
		private string worklistType=String.Empty;
		private long worklistTypeID=0;
		private long pickedBy=0;
		private string statustype=String.Empty;
		private string convReferenceRange=String.Empty;
		private long refAccessionNo=0;
		private string manualAbnormal=String.Empty;
		private string isAutoAuthorize=String.Empty;
		private string isSentBarcode=String.Empty;
		private string printableRange=String.Empty;
		private string worklistCreatedby=String.Empty;
		private DateTime worklistCreatedat=DateTime.MaxValue;
		private string approvalType=String.Empty;
		private string isAutoValidate=String.Empty;
		private string isAllowNull=String.Empty;
		private string isConfidentialTest=String.Empty;
		private long isarchive=0;
		private int seqNo=0;
		private string isSensitive=String.Empty;
		private string recollectNotify=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		public long PatientVisitID
		{
			get { return patientVisitID; }
			set { patientVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationName value.
		/// </summary>
		public string InvestigationName
		{
			get { return investigationName; }
			set { investigationName = value; }
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
		/// Gets or sets the InvestigationMethodID value.
		/// </summary>
		public long InvestigationMethodID
		{
			get { return investigationMethodID; }
			set { investigationMethodID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationSampleContainerID value.
		/// </summary>
		public int InvestigationSampleContainerID
		{
			get { return investigationSampleContainerID; }
			set { investigationSampleContainerID = value; }
		}

		/// <summary>
		/// Gets or sets the SampleID value.
		/// </summary>
		public int SampleID
		{
			get { return sampleID; }
			set { sampleID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationSiteID value.
		/// </summary>
		public int InvestigationSiteID
		{
			get { return investigationSiteID; }
			set { investigationSiteID = value; }
		}

		/// <summary>
		/// Gets or sets the IsCompleted value.
		/// </summary>
		public string IsCompleted
		{
			get { return isCompleted; }
			set { isCompleted = value; }
		}

		/// <summary>
		/// Gets or sets the CollectedDateTime value.
		/// </summary>
		public DateTime CollectedDateTime
		{
			get { return collectedDateTime; }
			set { collectedDateTime = value; }
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
		/// Gets or sets the ComplaintId value.
		/// </summary>
		public int ComplaintId
		{
			get { return complaintId; }
			set { complaintId = value; }
		}

		/// <summary>
		/// Gets or sets the GroupID value.
		/// </summary>
		public int GroupID
		{
			get { return groupID; }
			set { groupID = value; }
		}

		/// <summary>
		/// Gets or sets the GroupName value.
		/// </summary>
		public string GroupName
		{
			get { return groupName; }
			set { groupName = value; }
		}

		/// <summary>
		/// Gets or sets the Reason value.
		/// </summary>
		public string Reason
		{
			get { return reason; }
			set { reason = value; }
		}

		/// <summary>
		/// Gets or sets the ReportStatus value.
		/// </summary>
		public string ReportStatus
		{
			get { return reportStatus; }
			set { reportStatus = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceRange value.
		/// </summary>
		public string ReferenceRange
		{
			get { return referenceRange; }
			set { referenceRange = value; }
		}

		/// <summary>
		/// Gets or sets the MethodName value.
		/// </summary>
		public string MethodName
		{
			get { return methodName; }
			set { methodName = value; }
		}

		/// <summary>
		/// Gets or sets the IPInvSampleCollectionMasterID value.
		/// </summary>
		public long IPInvSampleCollectionMasterID
		{
			get { return iPInvSampleCollectionMasterID; }
			set { iPInvSampleCollectionMasterID = value; }
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
		/// Gets or sets the WorklistDeletedStatus value.
		/// </summary>
		public string WorklistDeletedStatus
		{
			get { return worklistDeletedStatus; }
			set { worklistDeletedStatus = value; }
		}

		/// <summary>
		/// Gets or sets the PerformingPhysicainName value.
		/// </summary>
		public string PerformingPhysicainName
		{
			get { return performingPhysicainName; }
			set { performingPhysicainName = value; }
		}

		/// <summary>
		/// Gets or sets the KitID value.
		/// </summary>
		public long KitID
		{
			get { return kitID; }
			set { kitID = value; }
		}

		/// <summary>
		/// Gets or sets the KitName value.
		/// </summary>
		public string KitName
		{
			get { return kitName; }
			set { kitName = value; }
		}

		/// <summary>
		/// Gets or sets the InstrumentID value.
		/// </summary>
		public long InstrumentID
		{
			get { return instrumentID; }
			set { instrumentID = value; }
		}

		/// <summary>
		/// Gets or sets the InstrumentName value.
		/// </summary>
		public string InstrumentName
		{
			get { return instrumentName; }
			set { instrumentName = value; }
		}

		/// <summary>
		/// Gets or sets the Interpretation value.
		/// </summary>
		public string Interpretation
		{
			get { return interpretation; }
			set { interpretation = value; }
		}

		/// <summary>
		/// Gets or sets the PrincipleID value.
		/// </summary>
		public long PrincipleID
		{
			get { return principleID; }
			set { principleID = value; }
		}

		/// <summary>
		/// Gets or sets the PrincipleName value.
		/// </summary>
		public string PrincipleName
		{
			get { return principleName; }
			set { principleName = value; }
		}

		/// <summary>
		/// Gets or sets the QCData value.
		/// </summary>
		public string QCData
		{
			get { return qCData; }
			set { qCData = value; }
		}

		/// <summary>
		/// Gets or sets the PackageID value.
		/// </summary>
		public int PackageID
		{
			get { return packageID; }
			set { packageID = value; }
		}

		/// <summary>
		/// Gets or sets the PackageName value.
		/// </summary>
		public string PackageName
		{
			get { return packageName; }
			set { packageName = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovedBy value.
		/// </summary>
		public long ApprovedBy
		{
			get { return approvedBy; }
			set { approvedBy = value; }
		}

		/// <summary>
		/// Gets or sets the PatientInvID value.
		/// </summary>
		public long PatientInvID
		{
			get { return patientInvID; }
			set { patientInvID = value; }
		}

		/// <summary>
		/// Gets or sets the OrderedAt value.
		/// </summary>
		public DateTime OrderedAt
		{
			get { return orderedAt; }
			set { orderedAt = value; }
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
		/// Gets or sets the GroupComment value.
		/// </summary>
		public string GroupComment
		{
			get { return groupComment; }
			set { groupComment = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovedAt value.
		/// </summary>
		public DateTime ApprovedAt
		{
			get { return approvedAt; }
			set { approvedAt = value; }
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
		/// Gets or sets the IsAbnormal value.
		/// </summary>
		public string IsAbnormal
		{
			get { return isAbnormal; }
			set { isAbnormal = value; }
		}

		/// <summary>
		/// Gets or sets the InvStatusReasonID value.
		/// </summary>
		public int InvStatusReasonID
		{
			get { return invStatusReasonID; }
			set { invStatusReasonID = value; }
		}

		/// <summary>
		/// Gets or sets the Test value.
		/// </summary>
		public string Test
		{
			get { return test; }
			set { test = value; }
		}

		/// <summary>
		/// Gets or sets the ValidatedBy value.
		/// </summary>
		public long ValidatedBy
		{
			get { return validatedBy; }
			set { validatedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ValidatedAt value.
		/// </summary>
		public DateTime ValidatedAt
		{
			get { return validatedAt; }
			set { validatedAt = value; }
		}

		/// <summary>
		/// Gets or sets the RemarksID value.
		/// </summary>
		public long RemarksID
		{
			get { return remarksID; }
			set { remarksID = value; }
		}

		/// <summary>
		/// Gets or sets the MedicalRemarks value.
		/// </summary>
		public string MedicalRemarks
		{
			get { return medicalRemarks; }
			set { medicalRemarks = value; }
		}

		/// <summary>
		/// Gets or sets the GroupMedicalRemarks value.
		/// </summary>
		public string GroupMedicalRemarks
		{
			get { return groupMedicalRemarks; }
			set { groupMedicalRemarks = value; }
		}

		/// <summary>
		/// Gets or sets the RefSuffixText value.
		/// </summary>
		public string RefSuffixText
		{
			get { return refSuffixText; }
			set { refSuffixText = value; }
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
		/// Gets or sets the Migrated_TestType value.
		/// </summary>
		public string Migrated_TestType
		{
			get { return migrated_TestType; }
			set { migrated_TestType = value; }
		}

		/// <summary>
		/// Gets or sets the WorkListID value.
		/// </summary>
		public long WorkListID
		{
			get { return workListID; }
			set { workListID = value; }
		}

		/// <summary>
		/// Gets or sets the AuthorizedBy value.
		/// </summary>
		public long AuthorizedBy
		{
			get { return authorizedBy; }
			set { authorizedBy = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceID value.
		/// </summary>
		public string DeviceID
		{
			get { return deviceID; }
			set { deviceID = value; }
		}

		/// <summary>
		/// Gets or sets the WorklistType value.
		/// </summary>
		public string WorklistType
		{
			get { return worklistType; }
			set { worklistType = value; }
		}

		/// <summary>
		/// Gets or sets the WorklistTypeID value.
		/// </summary>
		public long WorklistTypeID
		{
			get { return worklistTypeID; }
			set { worklistTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the PickedBy value.
		/// </summary>
		public long PickedBy
		{
			get { return pickedBy; }
			set { pickedBy = value; }
		}

		/// <summary>
		/// Gets or sets the Statustype value.
		/// </summary>
		public string Statustype
		{
			get { return statustype; }
			set { statustype = value; }
		}

		/// <summary>
		/// Gets or sets the ConvReferenceRange value.
		/// </summary>
		public string ConvReferenceRange
		{
			get { return convReferenceRange; }
			set { convReferenceRange = value; }
		}

		/// <summary>
		/// Gets or sets the RefAccessionNo value.
		/// </summary>
		public long RefAccessionNo
		{
			get { return refAccessionNo; }
			set { refAccessionNo = value; }
		}

		/// <summary>
		/// Gets or sets the ManualAbnormal value.
		/// </summary>
		public string ManualAbnormal
		{
			get { return manualAbnormal; }
			set { manualAbnormal = value; }
		}

		/// <summary>
		/// Gets or sets the IsAutoAuthorize value.
		/// </summary>
		public string IsAutoAuthorize
		{
			get { return isAutoAuthorize; }
			set { isAutoAuthorize = value; }
		}

		/// <summary>
		/// Gets or sets the IsSentBarcode value.
		/// </summary>
		public string IsSentBarcode
		{
			get { return isSentBarcode; }
			set { isSentBarcode = value; }
		}

		/// <summary>
		/// Gets or sets the PrintableRange value.
		/// </summary>
		public string PrintableRange
		{
			get { return printableRange; }
			set { printableRange = value; }
		}

		/// <summary>
		/// Gets or sets the WorklistCreatedby value.
		/// </summary>
		public string WorklistCreatedby
		{
			get { return worklistCreatedby; }
			set { worklistCreatedby = value; }
		}

		/// <summary>
		/// Gets or sets the WorklistCreatedat value.
		/// </summary>
		public DateTime WorklistCreatedat
		{
			get { return worklistCreatedat; }
			set { worklistCreatedat = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovalType value.
		/// </summary>
		public string ApprovalType
		{
			get { return approvalType; }
			set { approvalType = value; }
		}

		/// <summary>
		/// Gets or sets the IsAutoValidate value.
		/// </summary>
		public string IsAutoValidate
		{
			get { return isAutoValidate; }
			set { isAutoValidate = value; }
		}

		/// <summary>
		/// Gets or sets the IsAllowNull value.
		/// </summary>
		public string IsAllowNull
		{
			get { return isAllowNull; }
			set { isAllowNull = value; }
		}

		/// <summary>
		/// Gets or sets the IsConfidentialTest value.
		/// </summary>
		public string IsConfidentialTest
		{
			get { return isConfidentialTest; }
			set { isConfidentialTest = value; }
		}

		/// <summary>
		/// Gets or sets the Isarchive value.
		/// </summary>
		public long Isarchive
		{
			get { return isarchive; }
			set { isarchive = value; }
		}

		/// <summary>
		/// Gets or sets the SeqNo value.
		/// </summary>
		public int SeqNo
		{
			get { return seqNo; }
			set { seqNo = value; }
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
		/// Gets or sets the RecollectNotify value.
		/// </summary>
		public string RecollectNotify
		{
			get { return recollectNotify; }
			set { recollectNotify = value; }
		}


		#endregion
}
}
