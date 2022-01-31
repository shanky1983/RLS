using System;
using System.Collections.Generic;

namespace Attune.KernelV2.Entities
{
    public class UI_BillingPatientMetaData
    {
        public List<UI_Salutation> Titles { get; set; }
        public List<UI_MetaData> Gender { get; set; }
        public List<UI_MetaData> AgeType { get; set; }
        public List<UI_MetaData> MaritalStatus { get; set; }
        public List<UI_MetaData> PatientStatus { get; set; }
        public UI_Country Country { get; set; }
        public UI_State State { get; set; }
        public List<UI_MetaData> ReportDeliveryMode { get; set; }
        public List<UI_MetaData> DispatchType { get; set; }
        public List<UI_MetaValues> DispatchMode { get; set; }

    }

    public class UI_BillingMetaData
    {
        public List<UI_Discount> Discount { get; set; }
        public List<UI_DiscountReason> DiscountReason { get; set; }
        public List<UI_MetaData> DiscountType { get; set; }
        public List<UI_Tax> Tax { get; set; }

        //public List<UI_MetaData> SampleTimeType { get; set; }
        //public List<UI_MetaData> SearchType { get; set; }
        //public List<UI_MetaValues> Notification { get; set; }
        //public List<UI_MetaData> KnowledgeOfService { get; set; }  
        //public List<UI_VisitPurpose> VisitPurpose { get; set; }
        //public List<UI_MetaData> VisitType { get; set; }
        //public List<UI_MetaData> PatientType { get; set; }
        //public List<UI_MetaData> CopaymentLogic { get; set; }
        //public List<UI_MetaData> CoPaymentType { get; set; }
        //public List<UI_MetaData> DateAttributes { get; set; }        
        //public List<UI_MetaData> LanguageHdr { get; set; }
        //public List<UI_MetaData> IndicationsData { get; set; }
        //public List<UI_MetaData> AssineeValue { get; set; }
        //public List<UI_MetaData> Genetestresult { get; set; }
        //public List<UI_MetaData> PanelOrReferralValue { get; set; }
        //public List<UI_MetaData> AffectedCancer { get; set; }
        //public List<UI_MetaData> EthncityValue { get; set; }
        //public List<UI_MetaData> TGender { get; set; }
        //public List<UI_MetaData> TMasterCtrlOperRange { get; set; }
        //public List<UI_MetaData> TMasterCtrlOperRange1 { get; set; }
        //public List<UI_MetaData> TMasterCtrlInterpretation { get; set; }
        //public List<UI_MetaData> TMasterCtrlSubCategory { get; set; }
        //public List<UI_MetaData> TMasterCtrlRtype { get; set; }
    }

    public class UI_BillingPatientContext
    {
        private DateTime dateTime = DateTime.MaxValue;
        public int TITLECode { get; set; }
        public long PatientID { get; set; }
        public long VisitID { get; set; }
        public string PatientNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PatientName { get; set; }
        public string Sex { get; set; }
        public string Age { get; set; }
        public DateTime DOB { get { return dateTime; } set { dateTime = value; } }
        public string MartialStatus { get; set; }
        public string EMail { get; set; }
        public string PatientStatus { get; set; }
        public string ExternalPatientNumber { get; set; }
        public long SpeciesID { get; set; }
        public string URNO { get; set; }
        public long URNofId { get; set; }
        public long URNTypeId { get; set; }
        public string MobileNumber { get; set; }
        public string LandLineNumber { get; set; }
        public string Add1 { get; set; }
        public string PostalCode { get; set; }
        public long CountryID { get; set; }
        public long StateID { get; set; }
        public long CityID { get; set; }
        public string City { get; set; }
    }

    public class UI_BillingPatientVisitContext
    {
        private DateTime dateTime = DateTime.MaxValue;

        public long ClientID { get; set; }
        public int ReferingPhysicianID { get; set; }
        public string ReferingPhysicianName { get; set; }
        public int HospitalID { get; set; }
        public string HospitalName { get; set; }
        public int BookingID { get; set; }
        public string ReportMode { get; set; }
        public string PatientHistory { get; set; }
        public string WardNo { get; set; }
        public string RoundNo { get; set; }
        public long PhlebetomyID { get; set; }
        public long LogisticsID { get; set; }
        public string Exautoauthorization { get; set; }
        public string ApprovalNo { get; set; }
        public int KnowledgeOfServiceID { get; set; }
        public DateTime VisitDate { get { return dateTime; } set { dateTime = value; } }
        public string VisitNumber { get; set; }
        public int VisitPurposeID { get; set; }
        public int VisitType { get; set; }
        public List<UI_DisPatch> DisPatch { get; set; }
    }

    public class UI_BillingPatientDetails
    {
        public UI_Patient Patient { get; set; }
        public UI_Country Country { get; set; }
        public UI_State State { get; set; }
        public UI_MetaData ReportDeliveryMode { get; set; }
        public List<UI_MetaData> DispatchType { get; set; }
        public List<UI_MetaValues> DispatchMode { get; set; }
        public UI_ClientMaster ClientReference { get; set; }
        public UI_URNTypes URN { get; set; }
        public List<UI_PreviousVisitBilling> PreviousVisitBilling { get; set; }
    }

    public class UI_BillingPatientAdditionalDetails
    {
        public long ZoneId { get; set; }
        public string VisitNumber { get; set; }
        public string PatientHistory { get; set; }
        public string PatientType { get; set; }
        public long DiscountApprovedBy { get; set; }
        public string RegistrationRemarks { get; set; }
        public string IsEditMode { get; set; }
        public int VisitTypeID { get; set; }
        public int PatientStausID { get; set; }
        public int PhleboID { get; set; }
        public int LogisticsID { get; set; }
        public string RoundNo { get; set; }
        public string ExAutoAuthorization { get; set; }
        public string Confidential { get; set; }
        public long ParentPatientID { get; set; }
        public string ExternalVisitID { get; set; }
        public string ApprovalNo { get; set; }
        public string NewPassword { get; set; }
        public byte UnknownFlag { get; set; }
        public long DiscountID { get; set; }
        public string IsCopay { get; set; }
        public string IsFoc { get; set; }
        public string MyCardActiveDays { get; set; }
        public string MemebershipcardType { get; set; }
        public string HealthCardType { get; set; }
        public string OTP { get; set; }
        public long MembershipCardMappingID { get; set; }
        public string CreditRedeemType { get; set; }
        public string HasHealthCard { get; set; }
        public decimal RedemPoints { get; set; }
        public decimal RedemValue { get; set; }
        public int ExternalVisitType { get; set; }
        public string OrderedID { get; set; }
        public string MigratedvisitNumber { get; set; }
        public string MigratedRequestNumber { get; set; }
        public string ClientFlag { get; set; }
        public long CollectionID { get; set; }
        public string EmailCCAddress { get; set; }
        public string Value { get; set; }
        public string ClinicCode { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SpeciesID { get; set; }
        public int SuburbID { get; set; }
        public string RefdoctorId { get; set; }
        public string RefPhysicianPNo { get; set; }
        public string ReportMode { get; set; }
        public string SpeciesName { get; set; }
        public int IsNotifyType { get; set; }
        public string SecuredCode { get; set; }
        public long EpisodeID { get; set; }
        public long EpisodeVisitID { get; set; }
        public int ReferedSpecialityID { get; set; }
        public long EpisodeTrackID { get; set; }
        public int PriorityID { get; set; }
        public long SpecialtyID { get; set; }
        public string ReferralType { get; set; }
        public long SiteID { get; set; }
        public string ConsignmentNo { get; set; }
        public long VisitID { get; set; }
    }

    public class UI_BillingPatient
    {
        public UI_Patient Patient { get; set; }
        public UI_Country Country { get; set; }
        public UI_State State { get; set; }
        public UI_City City { get; set; }
        public UI_MetaData ReportDeliveryMode { get; set; }
        public List<UI_MetaData> DispatchType { get; set; }
        public List<UI_MetaValues> DispatchMode { get; set; }
        public UI_ClientMaster ClientReference { get; set; }
        public UI_URNTypes URN { get; set; }
        public UI_BillingPatientAdditionalDetails AdditionalDetails { get; set; }
        public List<UI_PatientDueChart> PatientDueChart { get; set; }
        public UI_FinalBillDetails FinalBillDetails { get; set; }
        public List<UI_AmountReceivedDetails> AmountReceivedDetails { get; set; }
        public List<UI_FileProperties> TRFFile { get; set; }
    }

    public class UI_BillingPart
    {
        public long FinalBillID { get; set; }
        public string BillNumber { get; set; }
        public long PatientID { get; set; }
        public long VisitID { get; set; }
        public string LabNo { get; set; }
        public string VisitNumber { get; set; }
    }
    public class UI_PrintBillingDetails
    {
        public string BilledBy { get; set; }
        public long BillingDetailsID { get; set; }
        public string BillNumber { get; set; }
        public long FeeId { get; set; }
        public string FeeType { get; set; }
        public string FeeDescription { get; set; }
        public decimal Amount { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string ServiceCode { get; set; }
        public string LabNo { get; set; }
        public string Address { get; set; }
        public string CreatedBy { get; set; }
        public string IsOutSource { get; set; }
        public string ModifiedAt { get; set; }
        public string AttributeDetail { get; set; }
        public decimal WriteOffAmt { get; set; }
        public decimal BaseTestcalculationAmount { get; set; }
    }
    public class UI_PrintFinalBill
    {
        public string FinalBillID { get; set; }
        public int OrgID { get; set; }
        public long PatientID { get; set; }
        public decimal GrossBillValue { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal NetValue { get; set; }
        public decimal AmountReceived { get; set; }
        public decimal Due { get; set; }
        public string IsCreditBill { get; set; }
        public string StdDedName { get; set; }
        public long StdDedID { get; set; }
        public string StdDedValue { get; set; }
        public string StdDedType { get; set; }
        public decimal CurrentDue { get; set; }
        public decimal ServiceCharge { get; set; }
        public string BillNumber { get; set; }
        public decimal RoundOff { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal IsDiscountPercentage { get; set; }
        public decimal RemainDeposit { get; set; }
        public decimal EDCess { get; set; }
        public decimal SHEDCess { get; set; }
        public string Versionno { get; set; }
        public DateTime TatDateTime { get; set; }
        public DateTime TATDate { get; set; }
        public decimal TDS { get; set; }
        public string DiscountReason { get; set; }
        public string TPARemarks { get; set; }
    }
    public class UI_PrintPatient
    {
        public string TitleName { get; set; }
        public string Name { get; set; }
        public string AliasName { get; set; }
        public string RelationName { get; set; }
        public string EMail { get; set; }
        public DateTime DOB { get; set; }
        public string MartialStatus { get; set; }
        public string URNO { get; set; }
        public string MobileNumber { get; set; }
        public string LandLineNumber { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string Add3 { get; set; }
        public string City { get; set; }
        public string StateName { get; set; }
        public string CountryName { get; set; }
        public string Age { get; set; }
        public string SEX { get; set; }
        public string PatientNumber { get; set; }
        public string ReferingPhysicianName { get; set; }
        public string ReferingSpecialityName { get; set; }
        public string TPAAttributes { get; set; }
        public string TPAName { get; set; }
        public string ConfigTaxPercent { get; set; }
        public int PayerID { get; set; }
        public string ReferedHospitalName { get; set; }
        public string VersionNo { get; set; }
        public long ParentPatientID { get; set; }
        public string PriorityID { get; set; }
        public string DetailHistory { get; set; }
        public string RegistrationRemarks { get; set; }
        public string DispatchType { get; set; }
        public DateTime SamplePickupDate { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string ExternalVisitID { get; set; }
        public string AgeValues { get; set; }
        public string NewPassword { get; set; }
        public string ReportStatus { get; set; }
        public long URNTypeId { get; set; }
        public string BillType { get; set; }
        public long PatientID { get; set; }
        public long FinalBillID { get; set; }
        public long OrgID { get; set; }
    }
    public class UI_BillPrint
    {
        public List<UI_PrintBillingDetails> lstBillingDetails { get; set; }
        public List<UI_PrintFinalBill> lstFinalBillDetails { get; set; }
        public UI_PrintPatient objPatient { get; set; }
    }

    public class UI_FileProperties
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string FilePath { get; set; }
        public Object File { get; set; }
    }

    public class UI_TRFFileUpload
    {
        private DateTime dateTime = DateTime.MaxValue;
        public long FileID { get; set; }
        public string FileUrl { get; set; }
        public long PatientID { get; set; }
        public long VisitID { get; set; }
        public int OrgID { get; set; }
        public long IdentifyingID { get; set; }
        public string IdentifyingType { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public long Createdby { get; set; }
        public DateTime Createdat { get { return dateTime; } set { dateTime = value; } }
        public string Isactive { get; set; }
    }

    public class UI_DocumentUpload
    {
        public UI_MetaData FileType { get; set; }
        public UI_FileProperties File { get; set; }
        public long FileID { get; set; }
    }
    public class UI_DisPatch
    {
        public string DispatchType{ get; set; }
        public string DispatchValue { get; set; }
    }
}
