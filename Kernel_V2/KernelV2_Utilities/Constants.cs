namespace Attune.KernelV2.Utilities
{
    public class Constants
    {
        public const string DATABASE_CONNECTION_CONFIG_KEY = "AttuneDbConnection";
        public const string DATABASE_DB_PROVIDE = "AttuneDbProvider";
    }
    public enum DataProviderType
    {
        MsSql, MySql
    }

    public class InvStatus
    {
        public const string Paid = "Paid";
        public const string Ordered = "Ordered";
        public const string Completed = "Completed";
        public const string PartiallyCompleted = "PartiallyCompleted";
        public const string Rejected = "Reject";
        public const string Pending = "Pending";
        public const string Approved = "Approve";
        public const string SampleReceived = "SampleReceived";
        public const string SampleCollected = "SampleCollected";
        public const string OutSource = "OutSource";
        public const string Cancel = "Cancel";
        public const string Retest = "Retest";
        public const string Recheck = "Recheck";
        public const string Validate = "Validate";
        public const string Coauthorize = "Co-authorize";
        public const string Coauthorized = "Co-authorized";
        public const string Notgiven = "Not given";
        public const string PartialyCollected = "PartialyCollected";
        public const string PartialyApproved = "PartiallyApproved";
        public const string WithHeld = "With Held";
        public const string SecondOpinion = "Second Opinion";
        public const string OpinionGiven = "Opinion Given";
        public const string PartiallyValidated = "PartiallyValidated";
        public const string ReflexWithNewSample = "Reflexwithnewsample";
        public const string ReflexWithSameSample = "Reflexwithsamesample";
        public const string WithholdCompletion = "With-hold Completion";
        public const string WithholdValidation = "With-hold Validation";
        public const string WithholdApproval = "With-hold Approval";
    }

    public enum TaskAction
    {
        CollectGeneralVitals = 1,
        CancelAppointment = 2,
        CloseTask = 3,
        CollectANCVitals = 4,
        FirstDialysis = 5,
        PreDialysis = 6,
        OnFlowMonitoring = 7,
        PostDialysis = 8,
        CollectPayment = 9,
        PerformInvestigation = 10,
        PerformDiagnosis = 11,
        HandoverCaseSheet = 13,
        HandoverDialysisCaseSheet = 14,
        InvestigationPayment = 15,
        DeptSampleCollect = 16,
        ReferedInvestigation = 17,
        PrescriptionPrinting = 18,
        ShowInvestigation = 19,
        CheckPayment = 20,
        IPAdmission = 21,
        CollectSample = 22,
        HematologyAction = 23,
        BioChemistryAction = 24,
        MicroBiologyAction = 25,
        ClinicalPathologyAction = 26,
        GraceLabAction = 27,
        PerformANCDiagnosis = 33,
        HandoverANCCaseSheet = 34,
        Immunization = 35,
        CollectSurgeryPayment = 36,
        Pharmacy = 37,
        HealthCheckUpHistory = 38,
        Approval = 39,
        Refund = 40,
        PerformPhysiotherapy = 41,
        ViewInvestigationResult = 42,
        PerformRefund = 43,
        CorporatePharmacy = 47,
        HandoverCaseRecord = 49,
        PharmacyOrderService = 51,
        PendingPayment = 52,
        RefundPharmacyStock = 53,
        EditRefundPharmacyStock = 54,
        IPPharmacyOrderService = 55,
        IPPendingPayment = 56,
        IPPharmaDueClearance = 57,
        IPCashierDueClearance = 58,
        IPCreditPharmaDueClearance = 59,
        IPCashierCreditDueClearance = 60,
        BloodBank = 45,
        BloodDonation = 46,
        BloodRequest = 69,
        Validate = 62,
        EpisodeApprovel = 64,
        GenerateInvoice = 61,
        CancelBill = 65,
        PerformCancel = 66,
        Coauthorize = 67,
        InvestigationCollectPayment = 68,
        BillingforBlood = 70,
        IPBillingforBlood = 71,
        AmountApproval = 72,
        GenerateBarCode = 73,
        BulckRateChanges = 76,
        PerformDueWriteOff = 80,
        DueWriteOffApproval = 81,
        SecondOpinion = 82,
        WithholdValidation = 84,
        WithholdApprovel = 85,
        WithholdEnterResult = 86,
        EnterResult = 63,
        AutoApproval = 86,
        Revalidate = 94,
        GeneralPattern = 87,
        Tablepatternautopopulate = 88,
        RichTextPattern = 89,
        PDFUploadPattern = 90,
        HistoImageDescriptionPattern = 100,
        ImageDescriptionpattern = 63

    }

    public enum TaskStatus
    {
        Pending = 1,
        Completed = 2,
        Deleted = 3,
        Grouped = 4,
        InProgress = 5,
        YetToCollectPayment = 6,
        REASSIGNED = 7,
        APPROVED = 8
    }

    public enum RelativeType
    {
        D = 1,
        W = 2,
        M = 3,
        Y = 4
    }

    public enum unit
    {
        WD = 0,
        WN = 1,
        MD = 2,
        Y = 3,
        MN = 4
    }


    public enum weekNumber
    {
        First = 1,
        Second = 2,
        Third = 3,
        Fourth = 4,
        Fifth = 5
    }

 
    public enum Pattern
    {
        Commanpattern = 0,
        BioPattern1 = 1,
        BioPattern2 = 2,
        BioPattern3 = 3,
        BioPattern4 = 4,
        BioPattern5 = 5,
        MicroPattern = 6,
        HematPattern6 = 7,
        HematPattern7 = 8,
        HematPattern8 = 9,
        HematPattern9 = 10,
        HematPattern10 = 11,
        HematPattern11 = 12,
        ClinicalPattern12 = 13,
        ClinicalPattern13 = 14,
        DifferentialPattern = 15,
        CastPattern = 16,
        ANAPattern = 17,
        WidelPattern = 18,
        FluidPattern = 19,
        hpPattern = 20,
        CultureAndSensitivity = 21,
        microbiopattern = 22,
        faCellsPattern = 23,
        faChemistryPattern = 24,
        faCytologyPattern = 25,
        faImmunologyPattern = 26,
        StoneAnalysis = 27,
        FungalSmearPattern = 28,
        AntiBodyWithMethod = 29,
        AntiBodyQualitative = 30,
        Semenanalysis = 31,
        Imaging = 32,
        PheripheralSmear = 33,
        BleedingTime = 34,
        TextualPattern = 35,
        GTT = 36,
        aPTT = 37,
        PTT = 38,
        BodyFluidAnalysis = 39,
        SMEAR = 40,
        SemenAnalysisNewPattern = 41,
        CultureAndSensitivityV1 = 42,
        GTTContentPattern = 43,
        CultureAndSensitivityV2 = 44,
        ImagePattern = 45,
        FishPattern1 = 46,
        ResultFishPattern = 47,
        ResultFishPattern1 = 48,
        FishPattern2 = 49,
        MultiAddControl = 50,
        MolBioPattern = 51,
        BRCAPattern = 52,
        BRCAPattern1 = 53,
        OrganismDrugPattern = 54,
        MicroStainPattern = 55,
        MicroBio1 = 56,
        HEMATOLOGY = 57,
        GeneralPattern = 58,
        Tablepatternautopopulate = 59,
        RichTextPattern = 60,
        PDFUploadpattern = 61,
        HistoImageDescriptionPattern = 62,
        ImageDescriptionpattern = 63,
        hpPatternQuantum = 64,
        IsPanic = 65
    }

    public enum InvSampleStatusmaster
    {
        SampleCollected = 1,
        SampleInTransit = 2,
        SampleReceived = 3,
        SampleRejected = 4,
        YetToReceived = 5
    }

    public enum Department
    {
        Biochemistry = 4,
        Hematology = 1,
        Microbiology = 3,
        ClinicalPathology = 2,
        BloodBank = 5,
        Cytogenetics = 6,
        Department = 7,
        General = 8,
        Histopathology = 9,
        Imaging = 10,
        Immunology = 11,
        MolecularBiology = 12,
        Lab = 13,
        CYTOLOGY = 14,
        ENDOCRINOLOGY = 15,
        HEPATITISMARKERS = 16,
        IMMUNOHEMATOLOGY = 17,
        MICROSEROLOGY = 18,
        SEROLOGY = 19,
        SPECIAL = 20,
        URINECHEMISTRY = 21,
        FLUIDANALYSIS = 22,
        comman = 0
    }

    public enum SearchType
    {
        OP = 0,
        IP = 1,
        MDM = 2,
        INVENTORY = 3,
        Lab = 4,
        IPPayments = 5,
        IPSettlement = 6,
        ManageSchedules = 7,
        Referral = 8,
        BillSearch = 9,
        OutPatientSearch = 10,
        VisitSearch = 11,
        InPatientSearch = 12,
        IPVisitSearch = 13,
        PurchaseOrder = 14,
        StockReceive = 15,
        StockDamage = 16,
        StockIssued = 17,
        StockReturn = 18,
        TodaysVisit = 19,
        LabSummaryReport = 20,
        IntendSearch = 21,
        TPASearch = 22,
        ReceiptSearch = 23,
        RefundSearch = 24,
        Help = 25,
        MRD = 26,
        IPPharmacy = 29,
        InterimBill = 30,
        ReturnFromPatient = 31,
        DayCare = 32,
        KitBatchProductSearch = 33,
        Corporate = 34,
        Purchaserequest = 35,
        Quotation = 36,
        InventoryAdmin = 37,
        SalesOrder = 38,
        SalesOrderIssue = 39,
        DCSearch = 40,
        Invoice = 41,
        SampleSearch = 42,
        InvestigationSearch = 43,
        BloodRequestSearch = 44,
        PublishReport = 45,
        SampleTransfer = 46
    }

    public enum monthNumber
    {
        January = 1,
        Febrauary = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }

    public enum VisitPurpose
    {
        Consultation = 1,
        FollowUp = 2,
        LabInvestigation = 3,
        HealthCheckup = 4,
        Emergency = 5,
        Casualty = 6,
        TreatmentProcedure = 7,
        LetterCertificate = 8,
        Admission = 9,
        DuePayment = 10,
        Immunization = 11,
        Pharmacy = 12,
        BloodDonation = 15

    }

    public enum PatientType
    {
        OP = 0,
        IP = 1,
        MDM = 2,
        INVENTORY = 3,
        Lab = 4,
        IPPayments = 5,
        IPSettlement = 6,
        ManageSchedules = 7
    }
    public class ActionContextType
    {
        public const string Patient = "P";
        public const string User = "U";
        public const string Client = "C";
        public const string ClientPatient = "CP";
        public const string ReferringPhysician = "RP";
        public const string ProjectManager = "PM";
        public const string Despatch = "DISP";
        public const string HomeCollectionPatient = "HCP";
        public const string HomeCollectionUser = "HCU";
        public const string HomeCollectionUserCancel = "HCC";
        public const string Invoice = "INV";
        public const string Reject = "REJECT";
        public const string Recollect = "RECOLLECT";
    }

    public class CommunicationType
    {
        public const string SMS = "SMS";
        public const string EMail = "EMail";
        public const string Invoice = "INV";
    }
}
