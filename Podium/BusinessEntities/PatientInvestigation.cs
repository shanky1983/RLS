using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientInvestigation
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
		private string previousStatus=String.Empty;
		private bool isReportable=false;
		private bool isShowReferenceRange=false;
		private string technicalRemarks=String.Empty;

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

		/// <summary>
		/// Gets or sets the PreviousStatus value.
		/// </summary>
		public string PreviousStatus
		{
			get { return previousStatus; }
			set { previousStatus = value; }
		}

		/// <summary>
		/// Gets or sets the IsReportable value.
		/// </summary>
		public bool IsReportable
		{
			get { return isReportable; }
			set { isReportable = value; }
		}

		/// <summary>
		/// Gets or sets the IsShowReferenceRange value.
		/// </summary>
		public bool IsShowReferenceRange
		{
			get { return isShowReferenceRange; }
			set { isShowReferenceRange = value; }
		}

		/// <summary>
		/// Gets or sets the TechnicalRemarks value.
		/// </summary>
		public string TechnicalRemarks
		{
			get { return technicalRemarks; }
			set { technicalRemarks = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationValue value.
		/// </summary>
		private string _investigationValue=String.Empty;
		public string InvestigationValue
		{
			get { return  _investigationValue; }
			set { _investigationValue = value; }
		}

		/// <summary>
		/// Gets or sets the PatternName value.
		/// </summary>
		private string _patternName=String.Empty;
		public string PatternName
		{
			get { return  _patternName; }
			set { _patternName = value; }
		}

		/// <summary>
		/// Gets or sets the UOMCode value.
		/// </summary>
		private string _uOMCode=String.Empty;
		public string UOMCode
		{
			get { return  _uOMCode; }
			set { _uOMCode = value; }
		}

		/// <summary>
		/// Gets or sets the DeptName value.
		/// </summary>
		private string _deptName=String.Empty;
		public string DeptName
		{
			get { return  _deptName; }
			set { _deptName = value; }
		}

		/// <summary>
		/// Gets or sets the PatternID value.
		/// </summary>
		private long _patternID=0;
		public long PatternID
		{
			get { return  _patternID; }
			set { _patternID = value; }
		}

		/// <summary>
		/// Gets or sets the UOMID value.
		/// </summary>
		private int _uOMID=0;
		public int UOMID
		{
			get { return  _uOMID; }
			set { _uOMID = value; }
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
		/// Gets or sets the HeaderName value.
		/// </summary>
		private string _headerName=String.Empty;
		public string HeaderName
		{
			get { return  _headerName; }
			set { _headerName = value; }
		}

		/// <summary>
		/// Gets or sets the HeaderID value.
		/// </summary>
		private long _headerID=0;
		public long HeaderID
		{
			get { return  _headerID; }
			set { _headerID = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		private string _type=String.Empty;
		public string Type
		{
			get { return  _type; }
			set { _type = value; }
		}

		/// <summary>
		/// Gets or sets the Value value.
		/// </summary>
		private string _value=String.Empty;
		public string Value
		{
			get { return  _value; }
			set { _value = value; }
		}

		/// <summary>
		/// Gets or sets the GroupNameRate value.
		/// </summary>
		private string _groupNameRate=String.Empty;
		public string GroupNameRate
		{
			get { return  _groupNameRate; }
			set { _groupNameRate = value; }
		}

		/// <summary>
		/// Gets or sets the Rate value.
		/// </summary>
		private decimal _rate=Decimal.Zero;
		public decimal Rate
		{
			get { return  _rate; }
			set { _rate = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationNameRate value.
		/// </summary>
		private string _investigationNameRate=String.Empty;
		public string InvestigationNameRate
		{
			get { return  _investigationNameRate; }
			set { _investigationNameRate = value; }
		}

		/// <summary>
		/// Gets or sets the SequenceNo value.
		/// </summary>
		private int _sequenceNo=0;
		public int SequenceNo
		{
			get { return  _sequenceNo; }
			set { _sequenceNo = value; }
		}

		/// <summary>
		/// Gets or sets the Display value.
		/// </summary>
		private string _display=String.Empty;
		public string Display
		{
			get { return  _display; }
			set { _display = value; }
		}

		/// <summary>
		/// Gets or sets the ValidationText value.
		/// </summary>
		private string _validationText=String.Empty;
		public string ValidationText
		{
			get { return  _validationText; }
			set { _validationText = value; }
		}

		/// <summary>
		/// Gets or sets the OrganizationName value.
		/// </summary>
		private string _organizationName=String.Empty;
		public string OrganizationName
		{
			get { return  _organizationName; }
			set { _organizationName = value; }
		}

		/// <summary>
		/// Gets or sets the PatientNumber value.
		/// </summary>
		private string _patientNumber=String.Empty;
		public string PatientNumber
		{
			get { return  _patientNumber; }
			set { _patientNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		private string _name=String.Empty;
		public string Name
		{
			get { return  _name; }
			set { _name = value; }
		}

		/// <summary>
		/// Gets or sets the Age value.
		/// </summary>
		private string _age=String.Empty;
		public string Age
		{
			get { return  _age; }
			set { _age = value; }
		}

		/// <summary>
		/// Gets or sets the Location value.
		/// </summary>
		private string _location=String.Empty;
		public string Location
		{
			get { return  _location; }
			set { _location = value; }
		}

		/// <summary>
		/// Gets or sets the AutoApproveLoginID value.
		/// </summary>
		private long _autoApproveLoginID=0;
		public long AutoApproveLoginID
		{
			get { return  _autoApproveLoginID; }
			set { _autoApproveLoginID = value; }
		}

		/// <summary>
		/// Gets or sets the InvValidationText value.
		/// </summary>
		private string _invValidationText=String.Empty;
		public string InvValidationText
		{
			get { return  _invValidationText; }
			set { _invValidationText = value; }
		}

		/// <summary>
		/// Gets or sets the ResultValueType value.
		/// </summary>
		private string _resultValueType=String.Empty;
		public string ResultValueType
		{
			get { return  _resultValueType; }
			set { _resultValueType = value; }
		}

		/// <summary>
		/// Gets or sets the DecimalPlaces value.
		/// </summary>
		private string _decimalPlaces=String.Empty;
		public string DecimalPlaces
		{
			get { return  _decimalPlaces; }
			set { _decimalPlaces = value; }
		}

		/// <summary>
		/// Gets or sets the LoginID value.
		/// </summary>
		private long _loginID=0;
		public long LoginID
		{
			get { return  _loginID; }
			set { _loginID = value; }
		}

		/// <summary>
		/// Gets or sets the Sex value.
		/// </summary>
		private string _sex=String.Empty;
		public string Sex
		{
			get { return  _sex; }
			set { _sex = value; }
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
		/// Gets or sets the Sno value.
		/// </summary>
		private long _sno=0;
		public long Sno
		{
			get { return  _sno; }
			set { _sno = value; }
		}

		/// <summary>
		/// Gets or sets the LabNo value.
		/// </summary>
		private string _labNo=String.Empty;
		public string LabNo
		{
			get { return  _labNo; }
			set { _labNo = value; }
		}

		/// <summary>
		/// Gets or sets the IsSTAT value.
		/// </summary>
		private string _isSTAT=String.Empty;
		public string IsSTAT
		{
			get { return  _isSTAT; }
			set { _isSTAT = value; }
		}

		/// <summary>
		/// Gets or sets the RootGroupID value.
		/// </summary>
		private long _rootGroupID=0;
		public long RootGroupID
		{
			get { return  _rootGroupID; }
			set { _rootGroupID = value; }
		}

		/// <summary>
		/// Gets or sets the InvSampleStatusID value.
		/// </summary>
		private int _invSampleStatusID=0;
		public int InvSampleStatusID
		{
			get { return  _invSampleStatusID; }
			set { _invSampleStatusID = value; }
		}

		/// <summary>
		/// Gets or sets the IsCoAuthorized value.
		/// </summary>
		private string _isCoAuthorized=String.Empty;
		public string IsCoAuthorized
		{
			get { return  _isCoAuthorized; }
			set { _isCoAuthorized = value; }
		}

		/// <summary>
		/// Gets or sets the UserID value.
		/// </summary>
		private string _userID=String.Empty;
		public string UserID
		{
			get { return  _userID; }
			set { _userID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferredType value.
		/// </summary>
		private string _referredType=String.Empty;
		public string ReferredType
		{
			get { return  _referredType; }
			set { _referredType = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayStatus value.
		/// </summary>
		private string _displayStatus=String.Empty;
		public string DisplayStatus
		{
			get { return  _displayStatus; }
			set { _displayStatus = value; }
		}

		/// <summary>
		/// Gets or sets the VisitNumber value.
		/// </summary>
		private string _visitNumber=String.Empty;
		public string VisitNumber
		{
			get { return  _visitNumber; }
			set { _visitNumber = value; }
		}

		/// <summary>
		/// Gets or sets the ParentGroupID value.
		/// </summary>
		private long _parentGroupID=0;
		public long ParentGroupID
		{
			get { return  _parentGroupID; }
			set { _parentGroupID = value; }
		}

		/// <summary>
		/// Gets or sets the IsNonEditable value.
		/// </summary>
		private bool _isNonEditable=false;
		public bool IsNonEditable
		{
			get { return  _isNonEditable; }
			set { _isNonEditable = value; }
		}

		/// <summary>
		/// Gets or sets the TestStatus value.
		/// </summary>
		private string _testStatus=String.Empty;
		public string TestStatus
		{
			get { return  _testStatus; }
			set { _testStatus = value; }
		}

		/// <summary>
		/// Gets or sets the IsAutoApproveQueue value.
		/// </summary>
		private string _isAutoApproveQueue=String.Empty;
		public string IsAutoApproveQueue
		{
			get { return  _isAutoApproveQueue; }
			set { _isAutoApproveQueue = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		private long _clientID=0;
		public long ClientID
		{
			get { return  _clientID; }
			set { _clientID = value; }
		}

		/// <summary>
		/// Gets or sets the CONV_UOMID value.
		/// </summary>
		private int _cONV_UOMID=0;
		public int CONV_UOMID
		{
			get { return  _cONV_UOMID; }
			set { _cONV_UOMID = value; }
		}

		/// <summary>
		/// Gets or sets the CONV_UOMCode value.
		/// </summary>
		private string _cONV_UOMCode=String.Empty;
		public string CONV_UOMCode
		{
			get { return  _cONV_UOMCode; }
			set { _cONV_UOMCode = value; }
		}

		/// <summary>
		/// Gets or sets the CONV_Factor value.
		/// </summary>
		private decimal _cONV_Factor=Decimal.Zero;
		public decimal CONV_Factor
		{
			get { return  _cONV_Factor; }
			set { _cONV_Factor = value; }
		}

		/// <summary>
		/// Gets or sets the CONVFactorDecimalPt value.
		/// </summary>
		private int _cONVFactorDecimalPt=0;
		public int CONVFactorDecimalPt
		{
			get { return  _cONVFactorDecimalPt; }
			set { _cONVFactorDecimalPt = value; }
		}

		/// <summary>
		/// Gets or sets the BarcodeNumber value.
		/// </summary>
		private string _barcodeNumber=String.Empty;
		public string BarcodeNumber
		{
			get { return  _barcodeNumber; }
			set { _barcodeNumber = value; }
		}

		/// <summary>
		/// Gets or sets the RegisteredDate value.
		/// </summary>
		private string _registeredDate=String.Empty;
		public string RegisteredDate
		{
			get { return  _registeredDate; }
			set { _registeredDate = value; }
		}

		/// <summary>
		/// Gets or sets the TATDateTime value.
		/// </summary>
		private string _tATDateTime=String.Empty;
		public string TATDateTime
		{
			get { return  _tATDateTime; }
			set { _tATDateTime = value; }
		}

		/// <summary>
		/// Gets or sets the Loginname value.
		/// </summary>
		private string _loginname=String.Empty;
		public string Loginname
		{
			get { return  _loginname; }
			set { _loginname = value; }
		}

		/// <summary>
		/// Gets or sets the ClientName value.
		/// </summary>
		private string _clientName=String.Empty;
		public string ClientName
		{
			get { return  _clientName; }
			set { _clientName = value; }
		}

		/// <summary>
		/// Gets or sets the RegisteredLocation value.
		/// </summary>
		private string _registeredLocation=String.Empty;
		public string RegisteredLocation
		{
			get { return  _registeredLocation; }
			set { _registeredLocation = value; }
		}

		/// <summary>
		/// Gets or sets the ReceivedDateTime value.
		/// </summary>
		private string _receivedDateTime=String.Empty;
		public string ReceivedDateTime
		{
			get { return  _receivedDateTime; }
			set { _receivedDateTime = value; }
		}

		/// <summary>
		/// Gets or sets the ReferralID value.
		/// </summary>
		private long _referralID=0;
		public long ReferralID
		{
			get { return  _referralID; }
			set { _referralID = value; }
		}

		/// <summary>
		/// Gets or sets the ExcludeVIDlock value.
		/// </summary>
		private string _excludeVIDlock=String.Empty;
		public string ExcludeVIDlock
		{
			get { return  _excludeVIDlock; }
			set { _excludeVIDlock = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceErrorCode value.
		/// </summary>
		private string _deviceErrorCode=String.Empty;
		public string DeviceErrorCode
		{
			get { return  _deviceErrorCode; }
			set { _deviceErrorCode = value; }
		}

		/// <summary>
		/// Gets or sets the IsFormulaField value.
		/// </summary>
		private string _isFormulaField=String.Empty;
		public string IsFormulaField
		{
			get { return  _isFormulaField; }
			set { _isFormulaField = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceActualValue value.
		/// </summary>
		private string _deviceActualValue=String.Empty;
		public string DeviceActualValue
		{
			get { return  _deviceActualValue; }
			set { _deviceActualValue = value; }
		}

		/// <summary>
		/// Gets or sets the BatchRoutine value.
		/// </summary>
		private string _batchRoutine=String.Empty;
		public string BatchRoutine
		{
			get { return  _batchRoutine; }
			set { _batchRoutine = value; }
		}

		/// <summary>
		/// Gets or sets the ExternalVisitID value.
		/// </summary>
		private string _externalVisitID=String.Empty;
		public string ExternalVisitID
		{
			get { return  _externalVisitID; }
			set { _externalVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the DepartmentID value.
		/// </summary>
		private string _departmentID=String.Empty;
		public string DepartmentID
		{
			get { return  _departmentID; }
			set { _departmentID = value; }
		}

		/// <summary>
		/// Gets or sets the SampleStatus value.
		/// </summary>
		private string _sampleStatus=String.Empty;
		public string SampleStatus
		{
			get { return  _sampleStatus; }
			set { _sampleStatus = value; }
		}

		/// <summary>
		/// Gets or sets the LastModified value.
		/// </summary>
		private string _lastModified=String.Empty;
		public string LastModified
		{
			get { return  _lastModified; }
			set { _lastModified = value; }
		}

		/// <summary>
		/// Gets or sets the AnyFlagRecieved value.
		/// </summary>
		private string _anyFlagRecieved=String.Empty;
		public string AnyFlagRecieved
		{
			get { return  _anyFlagRecieved; }
			set { _anyFlagRecieved = value; }
		}

		/// <summary>
		/// Gets or sets the PdfStatus value.
		/// </summary>
		private string _pdfStatus=String.Empty;
		public string PdfStatus
		{
			get { return  _pdfStatus; }
			set { _pdfStatus = value; }
		}

		/// <summary>
		/// Gets or sets the IsFormulaCalculateOnDevice value.
		/// </summary>
		private bool _isFormulaCalculateOnDevice=false;
		public bool IsFormulaCalculateOnDevice
		{
			get { return  _isFormulaCalculateOnDevice; }
			set { _isFormulaCalculateOnDevice = value; }
		}

		/// <summary>
		/// Gets or sets the IOMReferenceRange value.
		/// </summary>
		private string _iOMReferenceRange=String.Empty;
		public string IOMReferenceRange
		{
			get { return  _iOMReferenceRange; }
			set { _iOMReferenceRange = value; }
		}

		/// <summary>
		/// Gets or sets the ValidationRule value.
		/// </summary>
		private string _validationRule=String.Empty;
		public string ValidationRule
		{
			get { return  _validationRule; }
			set { _validationRule = value; }
		}

		/// <summary>
		/// Gets or sets the ResCaptureLoc value.
		/// </summary>
		private int _resCaptureLoc=0;
		public int ResCaptureLoc
		{
			get { return  _resCaptureLoc; }
			set { _resCaptureLoc = value; }
		}

		/// <summary>
		/// Gets or sets the ErrorCode value.
		/// </summary>
		private string _errorCode=String.Empty;
		public string ErrorCode
		{
			get { return  _errorCode; }
			set { _errorCode = value; }
		}

		/// <summary>
		/// Gets or sets the ErrorCategory value.
		/// </summary>
		private string _errorCategory=String.Empty;
		public string ErrorCategory
		{
			get { return  _errorCategory; }
			set { _errorCategory = value; }
		}

		/// <summary>
		/// Gets or sets the ErrorDescription value.
		/// </summary>
		private string _errorDescription=String.Empty;
		public string ErrorDescription
		{
			get { return  _errorDescription; }
			set { _errorDescription = value; }
		}

		/// <summary>
		/// Gets or sets the IsAvailableCumulative value.
		/// </summary>
		private bool _isAvailableCumulative=false;
		public bool IsAvailableCumulative
		{
			get { return  _isAvailableCumulative; }
			set { _isAvailableCumulative = value; }
		}

		/// <summary>
		/// Gets or sets the IsAutoValidation value.
		/// </summary>
		private string _isAutoValidation=String.Empty;
		public string IsAutoValidation
		{
			get { return  _isAutoValidation; }
			set { _isAutoValidation = value; }
		}

		/// <summary>
		/// Gets or sets the IsAutoAbnormalResult value.
		/// </summary>
		private string _isAutoAbnormalResult=String.Empty;
		public string IsAutoAbnormalResult
		{
			get { return  _isAutoAbnormalResult; }
			set { _isAutoAbnormalResult = value; }
		}

		/// <summary>
		/// Gets or sets the IsShowReportable value.
		/// </summary>
		private string _isShowReportable=String.Empty;
		public string IsShowReportable
		{
			get { return  _isShowReportable; }
			set { _isShowReportable = value; }
		}
        /// <summary>
        /// Gets or sets the DeltaCheck value.
        /// </summary>
        private bool _isDeltaCheck = false;
        public bool IsDeltaCheck
        {
            get { return _isDeltaCheck; }
            set { _isDeltaCheck = value; }
        }
        /// <summary>
        /// Gets or sets the DeltaLowerLimit value.
        /// </summary>

        private decimal _deltaLowerLimit = Decimal.Zero;
        public decimal DeltaLowerLimit
        {
            get { return _deltaLowerLimit; }
            set { _deltaLowerLimit = value; }
        }

        /// <summary>
        /// Gets or sets the DeltaHigherLimit value.
        /// </summary>


        private decimal _deltaHigherLimit = Decimal.Zero;
        public decimal DeltaHigherLimit
        {
            get { return _deltaHigherLimit; }
            set { _deltaHigherLimit = value; }
        }
        /// <summary>
        /// Gets or sets the DeltaStatus value.
        /// </summary>
        private bool _isDeltaStatus = false;
        public bool IsDeltaStatus
        {
            get { return _isDeltaStatus; }
            set { _isDeltaStatus = value; }
        }
        /// <summary>
        /// Gets or sets the AutoCertification value.
        /// </summary>
        private string _isAutoCertification = String.Empty;
        public string IsAutoCertification
        {
            get { return _isAutoCertification; }
            set { _isAutoCertification = value; }
        }

        private long _medicalRemarksID = 0;
        public long MedicalRemarksID
        {
            get { return _medicalRemarksID; }
            set { _medicalRemarksID = value; }
        }
		#endregion
}
}
