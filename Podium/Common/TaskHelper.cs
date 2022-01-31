using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attune.Podium.Common
{
    public class TaskHelper
    {
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
            CollectSurgeryPayment=36,
            Pharmacy = 37,
            HealthCheckUpHistory = 38,
            Approval = 39,
            Refund = 40,
            PerformPhysiotherapy=41,
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
            IPCreditPharmaDueClearance=59,
            IPCashierCreditDueClearance = 60, 
            BloodBank = 45,
            BloodDonation = 46,
            BloodRequest = 69,
            Validate=62,
            EpisodeApprovel=64,
            GenerateInvoice =61,
            CancelBill=65,
            PerformCancel=66,
            Coauthorize=67,
            InvestigationCollectPayment=68,
            BillingforBlood=70,
            IPBillingforBlood=71,
            AmountApproval=72,
            GenerateBarCode = 73,
            BulckRateChanges=76,
            PerformDueWriteOff=80,
            DueWriteOffApproval=81,
            SecondOpinion=82,
            WithholdValidation=84,
            WithholdApprovel=85,
            WithholdEnterResult=86,
            EnterResult=63,
            AutoApproval = 86,
                ///////////////Karthick
            Revalidate = 94,

            GeneralPattern = 87,
            Tablepatternautopopulate = 88,
			RichTextPattern = 89,
            PDFUploadPattern = 90,
			HistoImageDescriptionPattern = 100,
			ImageDescriptionpattern=63,
			 /// Added for IsSensitive Result test//
            Release=98, 
		///
            //For Test Cancellation
            TestCancellation=99,
            //
            /* BEGIN | NA | Sabari | 20181202 | Created | InvestigationResultDeflagging */
            ResultDeflag=98,
            ResultDeflagSrLabTech=99
            /* END | NA | Sabari | 20181202 | Created | InvestigationResultDeflagging */
			
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
            APPROVED = 8,
        }


        public enum RelativeType
        {
            D = 1,
            W = 2,
            M = 3,
            Y = 4,
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

        public enum InvStatus
        {
            Ordered = 1,
            Reffered = 2,
            Paid = 3,
            SampleCollected = 4,
            InProgress = 5
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
            aPTT=37,
            PTT=38,
            BodyFluidAnalysis=39,
            SMEAR=40,
            SemenAnalysisNewPattern=41,
            CultureAndSensitivityV1 = 42,
            GTTContentPattern = 43,
            CultureAndSensitivityV2 = 44,
            ImagePattern=45,
            FishPattern1 = 46,
            ResultFishPattern = 47,
            ResultFishPattern1 = 48,
            FishPattern2 = 49,
            MultiAddControl=50,
            MolBioPattern=51,
            BRCAPattern = 52,
            BRCAPattern1 = 53,
            OrganismDrugPattern=54,
            MicroStainPattern = 55,
			MicroBio1 = 56,
            HEMATOLOGY=57,
            GeneralPattern = 58,
            ///////////////kapil 
            
            Tablepatternautopopulate=59,
            RichTextPattern=60,
            PDFUploadpattern=61,
			 HistoImageDescriptionPattern = 62,
			  ImageDescriptionpattern=63,
              hpPatternQuantum = 64,  
            /* BEGIN | sabari | 20181129 | Dev | Culture Report */
            OrganismDrugPatternWithLevel=65,
            /* END | sabari | 20181129 | Dev | Culture Report */
            HistoPathologyPatternLilavathi=66,
			TablepatternautopopulateV2=69
        }

        /// <summary>
        /// Enum for Investigation Sample Status Master Table.
        /// </summary>

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

        public enum OrgID
        {
            Grace = 1
        }

        public string[] Alphabets()
        {
            string[] alpha = new string[26];
            alpha[0] = "A";
            alpha[1] = "B";
            alpha[2] = "C";
            alpha[3] = "D";
            alpha[4] = "E";
            alpha[5] = "F";
            alpha[6] = "G";
            alpha[7] = "H";
            alpha[8] = "I";
            alpha[9] = "J";
            alpha[10] = "K";
            alpha[11] = "L";
            alpha[12] = "M";
            alpha[13] = "N";
            alpha[14] = "O";
            alpha[15] = "P";
            alpha[16] = "Q";
            alpha[17] = "R";
            alpha[18] = "S";
            alpha[19] = "T";
            alpha[20] = "U";
            alpha[21] = "V";
            alpha[22] = "W";
            alpha[23] = "X";
            alpha[24] = "Y";
            alpha[25] = "Z";
            return alpha;
        }
        public enum OrgStatus
        {
            orgSpecific = 0,
            NotSpecific = 1
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
            IntendSearch=21,
            TPASearch = 22,
            ReceiptSearch=23,
            RefundSearch = 24,
            Help = 25,
            MRD=26,
            IPPharmacy=29,
            InterimBill=30,
            ReturnFromPatient=31,
            DayCare=32,
            KitBatchProductSearch=33,
            Corporate = 34,
            Purchaserequest=35,
            Quotation = 36,
            InventoryAdmin=37,
            SalesOrder=38,
            SalesOrderIssue = 39,
            DCSearch = 40,
            Invoice=41,
            SampleSearch=42,
            InvestigationSearch=43,
            BloodRequestSearch = 44,
            PublishReport = 45,
            SampleTransfer = 46,
			 NotificationSearch=47
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

        //public enum modeofDelivery
        //{
        //    Caesarean = 1,
        //    ForcepsDelivery = 2,
        //    VaccumExtraction = 3,
        //    NormalVaginalDelivery = 4
        //}

        //public enum birthMaturity
        //{
        //    FullTerm = 1,
        //    PreTerm = 2,
        //    PostTerm = 3
        //}

        public enum speciality
        {
            GeneralMedicine = 1,
            Pulmonology = 2,
            Dermatology = 3,
            Paediatrics = 4,
            OBG = 5,
            Orthopaedics = 6,
            Dentistry = 7,
            ENT = 8,
            Psychiatry = 9,
            Gynaecology = 10,
            Urology = 11,
            Generalsurgery = 12,
            Diabetology = 13,
            Cardiology = 14,
            Nephrology = 15,
            ANC = 16,
            PlasticSurgery = 17,
            NeuroSurgery = 18,
            MaxillofacialSurgery = 19,
            Rheumatology = 20,
            Gastroenterology = 21,
            Oncology = 22,
            Opthalmology = 23,
            Aneathesiology = 24,
            Neurology = 25,
            Vascularsurgery = 26,
            Sonology = 27,
            Endocrinology=48,
            BloodBank = 51
          

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
        public enum ActionMaster
        {
            Show_Report_InvestigationReport=42
        }

        public enum BloodBankPattern
        {
            OneTextPattern = 0,
            OneDropdownPattern = 1,
            ThreeDropdowns = 2
        }
    }
}