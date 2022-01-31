using System;
using System.Collections.Generic;

namespace Attune.KernelV2.Entities
{
    public class UI_PatientInvestigation
    {
        private DateTime dateTime = DateTime.MaxValue;

        public long AccessionNumber { get; set; }
        public string Age { get; set; }
        public string AnyFlagRecieved { get; set; }
        public string ApprovalType { get; set; }
        public DateTime ApprovedAt { get { return dateTime; } set { dateTime = value; } }
        public long ApprovedBy { get; set; }
        public long AuthorizedBy { get; set; }
        public long AutoApproveLoginID { get; set; }
        public string BarcodeNumber { get; set; }
        public string BatchRoutine { get; set; }
        public long ClientID { get; set; }
        public string ClientName { get; set; }
        public DateTime CollectedDateTime { get { return dateTime; } set { dateTime = value; } }
        public int ComplaintId { get; set; }
        public decimal CONV_Factor { get; set; }
        public string CONV_UOMCode { get; set; }
        public int CONV_UOMID { get; set; }
        public int CONVFactorDecimalPt { get; set; }
        public string ConvReferenceRange { get; set; }
        public DateTime CreatedAt { get { return dateTime; } set { dateTime = value; } }
        public long CreatedBy { get; set; }
        public string DecimalPlaces { get; set; }
        public string DepartmentID { get; set; }
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public string DeviceActualValue { get; set; }
        public string DeviceErrorCode { get; set; }
        public string DeviceID { get; set; }
        public string Display { get; set; }
        public string DisplayStatus { get; set; }
        public string ErrorCategory { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public string ExcludeVIDlock { get; set; }
        public string ExternalVisitID { get; set; }
        public string GroupComment { get; set; }
        public int GroupID { get; set; }
        public string GroupMedicalRemarks { get; set; }
        public string GroupName { get; set; }
        public string GroupNameRate { get; set; }
        public long HeaderID { get; set; }
        public string HeaderName { get; set; }
        public long InstrumentID { get; set; }
        public string InstrumentName { get; set; }
        public string Interpretation { get; set; }
        public long InvestigationID { get; set; }
        public long InvestigationMethodID { get; set; }
        public string InvestigationName { get; set; }
        public string InvestigationNameRate { get; set; }
        public int InvestigationSampleContainerID { get; set; }
        public int InvestigationSiteID { get; set; }
        public string InvestigationValue { get; set; }
        public int InvSampleStatusID { get; set; }
        public int InvStatusReasonID { get; set; }
        public string InvValidationText { get; set; }
        public string IOMReferenceRange { get; set; }
        public long IPInvSampleCollectionMasterID { get; set; }
        public string IsAbnormal { get; set; }
        public string IsAllowNull { get; set; }
        public long Isarchive { get; set; }
        public string IsAutoAbnormalResult { get; set; }
        public string IsAutoApproveQueue { get; set; }
        public string IsAutoAuthorize { get; set; }
        public string IsAutoValidate { get; set; }
        public string IsAutoValidation { get; set; }
        public string IsCoAuthorized { get; set; }
        public string IsCompleted { get; set; }
        public string IsConfidentialTest { get; set; }
        public bool IsFormulaCalculateOnDevice { get; set; }
        public string IsFormulaField { get; set; }
        public bool IsNonEditable { get; set; }
        public string IsSensitive { get; set; }
        public string IsSentBarcode { get; set; }
        public string IsSTAT { get; set; }
        public long KitID { get; set; }
        public string KitName { get; set; }
        public string LabNo { get; set; }
        public string LastModified { get; set; }
        public string Location { get; set; }
        public long LoginID { get; set; }
        public string Loginname { get; set; }
        public string ManualAbnormal { get; set; }
        public string MedicalRemarks { get; set; }
        public string MethodName { get; set; }
        public string Migrated_Patient_Number { get; set; }
        public string Migrated_Request_Number { get; set; }
        public string Migrated_TestCode { get; set; }
        public string Migrated_TestType { get; set; }
        public string Migrated_Visit_Number { get; set; }
        public DateTime ModifiedAt { get { return dateTime; } set { dateTime = value; } }
        public long ModifiedBy { get; set; }
        public string Name { get; set; }
        public DateTime OrderedAt { get { return dateTime; } set { dateTime = value; } }
        public string OrganizationName { get; set; }
        public int OrgID { get; set; }
        public int PackageID { get; set; }
        public string PackageName { get; set; }
        public string DeviceValue { get; set; }
        public long ParentGroupID { get; set; }
        public long PatientID { get; set; }
        public long PatientInvID { get; set; }
        public string PatientNumber { get; set; }
        public long PatientVisitID { get; set; }
        public long PatternID { get; set; }
        public string PatternName { get; set; }
        public string PdfStatus { get; set; }
        public string PerformingPhysicainName { get; set; }
        public long PickedBy { get; set; }
        public long PrincipleID { get; set; }
        public string PrincipleName { get; set; }
        public string PrintableRange { get; set; }
        public string QCData { get; set; }
        public decimal Rate { get; set; }
        public string Reason { get; set; }
        public string ReceivedDateTime { get; set; }
        public string RecollectNotify { get; set; }
        public long RefAccessionNo { get; set; }
        public string ReferenceRange { get; set; }
        public long ReferralID { get; set; }
        public string ReferredType { get; set; }
        public string RefSuffixText { get; set; }
        public string RegisteredDate { get; set; }
        public string RegisteredLocation { get; set; }
        public long RemarksID { get; set; }
        public string ReportStatus { get; set; }
        public int ResCaptureLoc { get; set; }
        public string ResultValueType { get; set; }
        public long RootGroupID { get; set; }
        public int SampleID { get; set; }
        public string SampleStatus { get; set; }
        public int SeqNo { get; set; }
        public int SequenceNo { get; set; }
        public string Sex { get; set; }
        public long Sno { get; set; }
        public string Status { get; set; }
        public string Statustype { get; set; }
        public string TATDateTime { get; set; }
        public string TechnicalRemarks { get; set; }
        public string Test { get; set; }
        public string TestStatus { get; set; }
        public string Type { get; set; }
        public string UID { get; set; }
        public string UOMCode { get; set; }
        public int UOMID { get; set; }
        public string UserID { get; set; }
        public DateTime ValidatedAt { get { return dateTime; } set { dateTime = value; } }
        public long ValidatedBy { get; set; }
        public string ValidationRule { get; set; }
        public string ValidationText { get; set; }
        public string Value { get; set; }
        public string VisitNumber { get; set; }
        public DateTime WorklistCreatedat { get { return dateTime; } set { dateTime = value; } }
        public string WorklistCreatedby { get; set; }
        public string WorklistDeletedStatus { get; set; }
        public long WorkListID { get; set; }
        public string WorklistType { get; set; }
        public long WorklistTypeID { get; set; }
        public long RowNumber { get; set; }
        public List<UI_InvestigationStatus> InvStatus { get; set; }
        public List<UI_InvestigationValues> InvestigationValues { get; set; }
        public UI_InvReasonMasters InvReasons { get; set; }
    }
}
