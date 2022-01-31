using System;
using System.Collections.Generic;

namespace Attune.KernelV2.Entities
{
    public class UI_InvResultsCapture
    {
        public List<UI_PatientInvestigation> lstUI_PatientInvestigation = new List<UI_PatientInvestigation>();
        public List<UI_InvestigationValues> InvestigationValues = new List<UI_InvestigationValues>();
        public List<UI_InvestigationStatus> lstUI_InvestigationStatus = new List<UI_InvestigationStatus>();
        public List<UI_RoleDeptMap> lstUI_RoleDeptMap = new List<UI_RoleDeptMap>();
    }

    public class UI_ResultCapturePost
    {
        public List<UI_InvDept> lstDept { get; set; }
        public List<UI_InvestigationBulkData> InvQualitativeResult { get; set; }
        public UI_PageContext PageContext { get; set; }
    }

    public class UI_InvDept
    {
        public long DeptID { get; set; }
        public string DeptName { get; set; }
        public List<UI_Group> lstUI_Group = new List<UI_Group>();
        public List<UI_PatientInvestigation> lstUI_PatientInvestigation = new List<UI_PatientInvestigation>();
        public List<UI_InvestigationStatus> InvStatus = new List<UI_InvestigationStatus>();
    }
    public class UI_ResultCapture
    {
        public List<UI_InvDept> InvDept = new List<UI_InvDept>();
        public List<UI_InvReasonMasters> InvReasons = new List<UI_InvReasonMasters>();
        public List<UI_InvQualitativeResultMaster> InvQualitativeResult = new List<UI_InvQualitativeResultMaster>();
    }

    public class UI_InvGroupValidation
    {
        public long DeptID { get; set; }
        public long GroupID { get; set; }
        public long InvestigationID { get; set; }
        public string ValidationText { get; set; }
        public long RowNumber { get; set; }
    }
    public class UI_Group
    {
        public string GroupindexID { get; set; }
        public long GroupID { get; set; }
        public string GroupName { get; set; }
        public string Remarks { get; set; }
        public string Comment { get; set; }
        public List<UI_PatientInvestigation> lstUI_PatientInvestigation = new List<UI_PatientInvestigation>();
        public List<UI_InvestigationStatus> InvStatus = new List<UI_InvestigationStatus>();
    }

    public class UI_InvPackageMapping
    {
        public int PackageID { get; set; }
        public long ID { get; set; }
        public string Type { get; set; }
        public int SequenceNo { get; set; }
        public string Active { get; set; }
        public string PrintSeparately { get; set; }
        public long Mapid { get; set; }
        public string IsReflex { get; set; }
        public string IsReportable { get; set; }
    }


    public class UI_InvestigationValues
    {
        private DateTime dateTime = DateTime.MaxValue;

        public long AccessionNumber { get; set; }
        public long ApprovedBy { get; set; }
        public decimal CONV_Factor { get; set; }
        public int CONVFactorDecimalPt { get; set; }
        public string ConvUOMCode { get; set; }
        public string ConvValue { get; set; }
        public DateTime CreatedAt { get { return dateTime; } set { dateTime = value; } }
        public long CreatedBy { get; set; }
        public string DeviceActualValue { get; set; }
        public string DeviceErrorCode { get; set; }
        public string DeviceID { get; set; }
        public string DeviceValue { get; set; }
        public string Dilution { get; set; }
        public string DisplayStatus { get; set; }
        public string ErrorCategory { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public int GroupID { get; set; }
        public string GroupMedicalRemarks { get; set; }
        public string GroupName { get; set; }
        public string InstrumentName { get; set; }
        public long InvestigationID { get; set; }
        public string InvestigationName { get; set; }
        public long InvestigationValueID { get; set; }
        public long IPInvSampleCollectionMasterID { get; set; }
        public string IsAbnormal { get; set; }
        public string KitName { get; set; }
        public string MedicalRemarks { get; set; }
        public string Migrated_Request_Number { get; set; }
        public string Migrated_TestCode { get; set; }
        public DateTime ModifiedAt { get { return dateTime; } set { dateTime = value; } }
        public long ModifiedBy { get; set; }
        public string Name { get; set; }
        public int Orgid { get; set; }
        public int PackageID { get; set; }
        public string PackageName { get; set; }
        public string PatientIdentifyID { get; set; }
        public long PatientInvID { get; set; }
        public long PatientVisitID { get; set; }
        public string PerformingPhysicainName { get; set; }
        public string Precision { get; set; }
        public string Reason { get; set; }
        public string ReferenceRange { get; set; }
        public long ReferralID { get; set; }
        public int SampleCode { get; set; }
        public int SampleContainerID { get; set; }
        public int SequenceNo { get; set; }
        public string Status { get; set; }
        public string Statustype { get; set; }
        public string TechnicalRemarks { get; set; }
        public string UID { get; set; }
        public string UOMCode { get; set; }
        public int UOMID { get; set; }
        public DateTime ValidatedAt { get { return dateTime; } set { dateTime = value; } }
        public string Value { get; set; }
        public string VisitID { get; set; }
    }
    public class UI_InvestigationOrgMapping
    {
        public long InvestigationID { get; set; }
        public int OrgID { get; set; }
        public int DeptID { get; set; }
        public long HeaderID { get; set; }
        public string Display { get; set; }
        public string ReferenceRange { get; set; }
        public string DisplayText { get; set; }
        public int UOMID { get; set; }
        public string UOMCode { get; set; }
        public int SequenceNo { get; set; }
        public int SampleCode { get; set; }
        public long MethodID { get; set; }
        public long PrincipleID { get; set; }
        public long KitID { get; set; }
        public long InstrumentID { get; set; }
        public string QCData { get; set; }
        public string Interpretation { get; set; }
        public int SampleContainerID { get; set; }
        public int ProcessingAddressID { get; set; }
        public string InvestigationCode { get; set; }
        public long RowID { get; set; }
        public string PanicRange { get; set; }
        public long AutoApproveLoginID { get; set; }
        public string ReferenceRangeString { get; set; }
        public int VmValue { get; set; }
        public int VmUnitID { get; set; }
        public int SampleConditionID { get; set; }
        public string InvValidationText { get; set; }
        public string SubCategory { get; set; }
        public bool IsDiscountable { get; set; }
        public bool IsOrderable { get; set; }
        public bool IsRepeatable { get; set; }
        public bool IsSTAT { get; set; }
        public string IsActive { get; set; }
        public string Gender { get; set; }
        public string IsNonReportable { get; set; }
        public string PrintSeparately { get; set; }
        public int CONV_UOMID { get; set; }
        public string CONV_UOMCode { get; set; }
        public decimal CONV_Factor { get; set; }
        public int ConvFac_DecimalPoint { get; set; }
        public long RCreatedBy { get; set; }
        public long RModifiedBy { get; set; }
        public DateTime RCreatedAt { get; set; }
        public DateTime RModifiedAt { get; set; }
        public string IsParameter { get; set; }
        public int ProtocalGroupID { get; set; }
        public string OutputInvestigationCode { get; set; }
        public string IsColorPrint { get; set; }
        public string IsHeader { get; set; }
        public string BillingName { get; set; }
        public string IsAutoApproveQueue { get; set; }
        public string IsAutoValidate { get; set; }
        public string IsAllowNull { get; set; }
        public string Iscountable { get; set; }
        public string IsConfidentialTest { get; set; }
        public decimal MaxDiscount { get; set; }
        public decimal RedeemAmount { get; set; }
        public string ImageToShow { get; set; }
        public int PreAnalyticalConditionId { get; set; }
        public int PostAnalyticalConditionId { get; set; }
        public string IsRedeem { get; set; }
        public string AbbCode { get; set; }
        public long SectionID { get; set; }
        public string TestCode { get; set; }
        public string OtherLanguage { get; set; }
        public string Active { get; set; }
        public string IsSynoptic { get; set; }
        public string IsFieldTest { get; set; }
        public bool Trend { get; set; }
        public string IsAutoValidation { get; set; }
        public string IsAutoAbnormalResult { get; set; }
        public int Scheduleid { get; set; }
        public string InvestigationName { get; set; }
        public long LoginID { get; set; }
        public long OutsourceProcessingAddressID { get; set; }
        public long Type { get; set; }
        public string AutoApproveLoginName { get; set; }
        public decimal Amount { get; set; }
    }

    public class UI_PerformingPhysician
    {
        public long PerformingPhysicianID { get; set; }
        public string PhysicianName { get; set; }
        public string Qualification { get; set; }
        public int OrgID { get; set; }
        public string Status { get; set; }
    }

    public class UI_InvPatternBulkData
    {
        public List<UI_InvestigationValues> lstBulkData { get; set; }
        public List<UI_InvestigationValues> lstPendingValue { get; set; }
    }

    public class UI_InvValueRangeMaster
    {
        public long InvestigationID { get; set; }
        public long InvValueRangeMasterID { get; set; }
        public string IsActive { get; set; }
        public string IsChargeable { get; set; }
        public string IsReflex { get; set; }
        public string IsReportable { get; set; }
        public string Range { get; set; }
        public long ReflexInvestigationID { get; set; }
        public string ReflexInvestigationName { get; set; }
        public string ReflexSampleType { get; set; }
        public string Type { get; set; }
        public string ValueRange { get; set; }
    }

    public class UI_InvestigationBulkData
    {
        public string AbnormalFlag { get; set; }
        public string DisplayText { get; set; }
        public long GroupID { get; set; }
        public int ID { get; set; }
        public long InvestigationID { get; set; }
        public long InvestigationMethodID { get; set; }
        public int IsStatus { get; set; }
        public string LangCode { get; set; }
        public string Name { get; set; }
        public int OrgID { get; set; }
        public long ResultID { get; set; }
        public int Seqno { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
    }

    public class UI_PatientInvSampleResults
    {
        public int AttributesID { get; set; }
        public string AttributesName { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public string InvestigationName { get; set; }
        public DateTime ModifiedAt { get; set; }
        public long ModifiedBy { get; set; }
        public int OrgID { get; set; }
        public int SampleCode { get; set; }
        public string SampleDesc { get; set; }
        public string SampleName { get; set; }
        public string SampleValues { get; set; }
        public long VisitID { get; set; }
    }

    public class UI_PatientInvSampleMapping
    {
        public string Barcode { get; set; }
        public string CaseNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CurrentLocationID { get; set; }
        public int DeptID { get; set; }
        public long ID { get; set; }
        public bool IsActive { get; set; }
        public int OrgID { get; set; }
        public string PatientIdentifyID { get; set; }
        public int SampleID { get; set; }
        public long SampleInstanceID { get; set; }
        public int SampleMappingID { get; set; }
        public long Seqeuenceid { get; set; }
        public long Sequeceid { get; set; }
        public long SID { get; set; }
        public string Type { get; set; }
        public string UID { get; set; }
        public long VisitID { get; set; }
    }
    public class UI_InvReasonMasters
    {
        public long ReasonID { get; set; }
        public string ReasonCode { get; set; }
        public string Reason { get; set; }
        public int ReasonTypeID { get; set; }
        public string ReasonTypeCode { get; set; }
        public string ReasonDesc { get; set; }
        public int StatusID { get; set; }
    }
    public class UI_InvestigationIDs
    {
        public long InvestigationID { get; set; }
    }

    public class UI_InvQualitativeResultMaster
    {
        public int QualitativeResultId { get; set; }
        public string QualitativeResultName { get; set; }
    }

    public class UI_InvestigationQueue
    {
        public long AccessionNumber { get; set; }
        public string AccessionNumbers { get; set; }
        public long AddressID { get; set; }
        public string BillableStatus { get; set; }
        public string BillNumber { get; set; }
        public int ClientID { get; set; }
        public long CreatedBy { get; set; }
        public string DisplayStatus { get; set; }
        public string FromDate { get; set; }
        public long InvestigationID { get; set; }
        public string InvestigationIDs { get; set; }
        public string InvestigationName { get; set; }
        public string IsBillable { get; set; }
        public string IsReportable { get; set; }
        public string LabNo { get; set; }
        public string Location { get; set; }
        public string OrderedUID { get; set; }
        public int OrgID { get; set; }
        public int ParentInvId { get; set; }
        public string ParentName { get; set; }
        public long PatientID { get; set; }
        public string PatientName { get; set; }
        public string PatientNumber { get; set; }
        public string PatientStatus { get; set; }
        public string PhoneNo { get; set; }
        public string Reason { get; set; }
        public string ReferingPhysicianName { get; set; }
        public string SampleDesc { get; set; }
        public string Status { get; set; }
        public long TestID { get; set; }
        public string Type { get; set; }
        public string UID { get; set; }
        public DateTime VisitDate { get; set; }
        public long VisitID { get; set; }
    }

    public class UI_PatientInvSample
    {
        public string Action { get; set; }
        public string AddExtraTube { get; set; }
        public int AddressID { get; set; }
        public string Age { get; set; }
        public string BarcodeNumber { get; set; }
        public int BatchID { get; set; }
        public string CaseNumber { get; set; }
        public DateTime CollectedDateTime { get; set; }
        public int CollectedLocID { get; set; }
        public string ConditionDesc { get; set; }
        public string ConsignmentNo { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public long FeeID { get; set; }
        public long ID1 { get; set; }
        public long ID2 { get; set; }
        public string InvestigationCode { get; set; }
        public string InvestigationID { get; set; }
        public string InvestigationName { get; set; }
        public string InvestigtionName { get; set; }
        public long INVID { get; set; }
        public string InvSampleStatusDesc { get; set; }
        public long InvSampleStatusID { get; set; }
        public long IPInvSampleCollectionMasterID { get; set; }
        public string IsActive { get; set; }
        public string IsAlicotedSample { get; set; }
        public string IsMLNumber { get; set; }
        public string IsOutsourcingSample { get; set; }
        public string IsSecondaryBarCode { get; set; }
        public string IsTimed { get; set; }
        public string LocationName { get; set; }
        public string LocationType { get; set; }
        public long MeanTime { get; set; }
        public long MedicalDetailID { get; set; }
        public DateTime ModifiedAt { get; set; }
        public long ModifiedBy { get; set; }
        public string Name { get; set; }
        public int OrgID { get; set; }
        public string Outsource { get; set; }
        public string Param1 { get; set; }
        public string Param2 { get; set; }
        public string Param3 { get; set; }
        public string Param4 { get; set; }
        public string Param5 { get; set; }
        public string Param6 { get; set; }
        public long PatientID { get; set; }
        public string PatientIdentifyID { get; set; }
        public string PatientName { get; set; }
        public long PatientVisitID { get; set; }
        public long Pickedby { get; set; }
        public string Reason { get; set; }
        public DateTime ReceivedDateTime { get; set; }
        public int Recorgid { get; set; }
        public int RecSampleLocID { get; set; }
        public string Remarks { get; set; }
        public int SampleCode { get; set; }
        public int SampleConditionID { get; set; }
        public int SampleContainerID { get; set; }
        public string SampleContainerName { get; set; }
        public string SampleDesc { get; set; }
        public int SampleID { get; set; }
        public int SampleMappingID { get; set; }
        public int SampleRelationshipID { get; set; }
        public string SampleUnit { get; set; }
        public int SampleVolume { get; set; }
        public string SEX { get; set; }
        public string Status { get; set; }
        public string Suffix { get; set; }
        public long TestID { get; set; }
        public string Testname { get; set; }
        public DateTime TransferedDateTime { get; set; }
        public string Type { get; set; }
        public string UID { get; set; }
        public string VisitNumber { get; set; }
        public int VmUnitID { get; set; }
        public int VmValue { get; set; }
    }
    public class UI_InvGroupMaster
    {
        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public string Type { get; set; }
        public long ParentID { get; set; }
        public int OrgID { get; set; }
        public int SequenceNo { get; set; }
        public string TestCode { get; set; }
        public DateTime Createdat { get; set; }
        public long CreatedBy { get; set; }
        public long ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int AttGroupID { get; set; }
        public int OrgGroupID { get; set; }
        public string DisplayText { get; set; }
        public Decimal Rate { get; set; }
        public string GroupNameCommands { get; set; }
        public string CodeName { get; set; }
    }
}


