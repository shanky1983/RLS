using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Reflection;
namespace Attune.Podium.Common
{
    public class Helper
    {
        public static bool IsNullorEmpty(string strValue)
        {
            if (strValue != null && strValue.Trim() != "")
                return false;
            else
                return true;
        }
    }
    public class UserDefinedDate
    {
        public DateTime MinimumDate = Convert.ToDateTime("01/01/1753 00:00:00");
    }
    public enum StockOutFlowType
    {
        StockIssued = 1,
        StockDamage = 2,
        StockReturn = 3,
        ExpiryDate = 4,
        StockUsage = 5,
        Adhoc = 6,
        Disposal = 7,
        SalesIssued = 8,
        BloodSeperation = 9

    }

    public class StockOutFlowStatus
    {
        public const string Created = "Created";
        public const string Approved = "Approved";
        public const string Modified = "Modified";
        public const string Cancelled = "Cancelled";
        public const string Received = "Received";
        public const string Inprogress = "Inprogress";
        public const string Pending = "Pending";
        public const string Partial = "Partial";
        public const string Issued = "Issued";

    }

    public enum StockReceivedTypes
    {
        FromSupplier = 1,
        FreeProduct = 2,
        AdhocDetails = 3,
        FromStore = 4,
        BulkLoad = 5,
        QuickStockRecd = 6,
        StockReturn = 7,
        BloodBank = 8
    }



    public class VisitType
    {
        public const string OutPatient = "OutPatient";
        public const string InPatient = "InPatient";

    }

    public enum ReportType
    {
        Receipt = 1,
        Voucher = 2,
        OPBill = 3,
        IPBill = 4,
        CaseSheet = 5,
        InvoiceReceipt = 6





    }


    public class FeeType
    {
        public const string Casuality = "CAS";
        public const string MedicalIndents = "IND";
        public enum type
        {
            [DescriptionAttribute("CAS")]
            Casuality,
            [DescriptionAttribute("IND")]
            MedicalIndent

        }
    }


    public enum StockReturnReason
    {
        StockExpiry = 1,
        Damage = 2,
        NonMovement = 3,
        Adjustment = 4,
        Disposal = 5,
        StockReturn = 6

    }

    public class CommunicationType
    {
        public const string SMS = "SMS";
        public const string EMail = "EMail";
        public const string Invoice = "INV";
    }

    public class BarcodeCategory
    {
        public const string Bill = "Bill";
        public const string Report = "Report";
        public const string ContainerRegular = "ContainerRg";
        public const string ContainerCT = "ContainerCT";
        public const string KitBatchNo = "KitBatchNo";
        public const string IndentNo = "IndentNo";
        public const string VisitLevelIndent = "VisitLevelKit";
        public const string VisitNumber = "Visit_Number";
        public const string MRDNumber = "MRD_Number";
        public const string TRF = "TRF";
        public const string SlideBarcode = "SlideBarcode";
    }

    public class ReportProcessStatus
    {
        public const string Ready = "Ready";
        public const string Dispatched = "Dispatched";
    }

    public class InvStatus
    {
        public const string Paid = "Paid";
        public const string Ordered = "Ordered";
        public const string Completed = "Completed";
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

    public class PerformActionType
    {
        public const string Sms = "Sms";
        public const string Email = "Email";
        public const string RedirectURL = "RedirectURL";
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

    public class InvSampleStatus
    {
        public const long Collected = 1;
        public const long SampleInTransit = 2;
        public const long Received = 3;
        public const long Rejected = 4;
        public const long YetToReceived = 5;
        public const long Not_Given = 6;
        public const long OutSource = 12;
    }

    public class PageType
    {
        public const string CollectSample = "CollectSample";
    }

    public class InvSummaryTemplateType
    {
        public const string ResultSummary = "ResultSummary";
        public const string ClinicalInterpretation = "ClinicalInterpretation";
        public const string Suggestions = "Suggestions";
    }
    public class PrintPolicyType
    {
        public const string Report = "REPORT";
    }
    public class CodeSchemeType
    {
        public const string Investigations = "Investigations";
        public const string Groups = "GRP";
    }

    public enum SqlConnectionKey
    {
        Shared = 1,
        Primary = 2,
        Secondary =3,
        SharedSecondary = 4
    }
}


