using System;
using System.Collections.Generic;

namespace Attune.KernelV2.Entities
{
    public class UI_FinalBillDetails
    {
        public decimal DiscountAmount { get; set; }
        public decimal GrossBillValue { get; set; }
        public string DiscountReason { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal ServiceCharge { get; set; }
        public decimal RoundOff { get; set; }
        public decimal NetValue { get; set; }
        public decimal Due { get; set; }
        public UI_PatientDiscount BillDiscount { get; set; }
        public long AuthorizedBy { get; set; }
    }

    public class UI_PreviousVisitBilling
    {
        private DateTime dateTime = DateTime.MaxValue;

        public DateTime VisitDate { get { return dateTime; } set { dateTime = value; } }
        public string FeeDescription { get; set; }
        public string TestCode { get; set; }
        public long FeeId { get; set; }
        public string FeeType { get; set; }
        public long VisitID { get; set; }
        public string Status { get; set; }
        public bool IsOutSource { get; set; }
    }

    public class UI_BillingItems
    {
        public long ID { get; set; }
        public string Descrip { get; set; }
        public string FeeType { get; set; }
        public string Gender { get; set; }
        public string TestCode { get; set; }
        public string LocationMapping { get; set; }
        public bool IsOutSource { get; set; }
    }

    public class UI_BillingItemsDetails
    {
        public long ID { get; set; }
        public string FeeType { get; set; }
        public decimal Amount { get; set; }
        public string TatDate { get; set; }
        public decimal ActualAmount { get; set; }
        public string IsDiscountable { get; set; }
        public string IsTaxable { get; set; }
        public string IsRepeatable { get; set; }
        public string IsSTAT { get; set; }
        public string IsSMS { get; set; }
        public string IsNABL { get; set; }
        public int HasHistory { get; set; }
        public string ProcessingLoc { get; set; }
        public string TcodeName { get; set; }
        public long BaseRateID { get; set; }
        public int DiscountPolicyID { get; set; }
        public string CategoryCode { get; set; }
        public string ReportDeliveryDate { get; set; }
        public decimal MaxDiscount { get; set; }
        public string IsRedeem { get; set; }
        public decimal RedeemAmount { get; set; }
        public string IsHistoryMandatory { get; set; }
    }

    public class UI_PatientDueChart
    {
        private DateTime dateTime = DateTime.MaxValue;
        public long ItemCurrencyID { get; set; }
        public DateTime Tatreferencedatetime { get { return dateTime; } set { dateTime = value; } }
        public int Tatreferencedatebase { get; set; }
        public DateTime Tatsamplereceiptdatetime { get { return dateTime; } set { dateTime = value; } }
        public DateTime Tatprocessstartdatetime { get { return dateTime; } set { dateTime = value; } }
        public int Logistictimeinmins { get; set; }
        public int Processingtimeinmins { get; set; }
        public string Labendtime { get; set; }
        public string Earlyreporttime { get; set; }

        public string FeeType { get; set; }
        public long FeeID { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public DateTime FromDate { get { return dateTime; } set { dateTime = value; } }
        public DateTime ToDate { get { return dateTime; } set { dateTime = value; } }
        public string Status { get; set; }
        public decimal unit { get; set; }
        public decimal Amount { get; set; }
        public long DetailsID { get; set; }
        public long PackageID { get; set; }
        public int SpecialityID { get; set; }
        public long UserID { get; set; }
        public decimal DiscountAmount { get; set; }
        public string IsReimbursable { get; set; }
        public string IsTaxable { get; set; }
        public string ServiceCode { get; set; }
        public decimal DiscountPercent { get; set; }
        public string DiscOrEnhanceType { get; set; }
        public string Remarks { get; set; }
        public decimal ReimbursableAmount { get; set; }
        public decimal NonReimbursableAmount { get; set; }
        public decimal ActualAmount { get; set; }
        public long RateID { get; set; }
        public string IsDiscountable { get; set; }
        public string IsSTAT { get; set; }
        public string IsOutSource { get; set; }
        public string IsNABL { get; set; }
        //public DateTime TatDate { get { return dateTime; } set { dateTime = value; } }
        public string TatDate { get; set; }
        public long BaseRateID { get; set; }
        public long DiscountPolicyID { get; set; }
        public string DiscountCategoryCode { get; set; }
        //public DateTime ReportDeliveryDate { get { return dateTime; } set { dateTime = value; } }
        public string ReportDeliveryDate { get; set; }
        public decimal MaxTestDisPercentage { get; set; }
        public decimal MaxTestDisAmount { get; set; }
        public decimal BaseTestcalculationAmount { get; set; }
        public string IsRedeem { get; set; }
        public decimal RedeemAmount { get; set; }
        public decimal RedeemPoints { get; set; }
        public long ClientFeeTypeRateCustID { get; set; }
        public string DiscOrEnhanceRemarks { get; set; }
        public decimal DiscOrEnhancePercent { get; set; }
        public int ReferralID { get; set; }
        public string ReferralType { get; set; }
        public UI_PatientDiscount ItemDiscount { get; set; }
        public UI_BillingHistory Historys { get;  set; }
    }

    public class UI_BillingHistory
    {
        public List<UI_Complaint> History{ get; set; }
        public List<UI_Preferences> PatientPreference { get; set; }
    }

    public  class UI_Preferences
    {
        public string  Preference { get; private set; }
    }

    public class UI_AmountReceivedDetails
    {
        private DateTime dateTime = DateTime.MaxValue;

        public decimal AmtReceived { get; set; }
        public int TypeID { get; set; }
        public string ChequeorCardNumber { get; set; }
        public string BankNameorCardType { get; set; }
        public string Remarks { get; set; }
        public DateTime ChequeValidDate { get { return dateTime; } set { dateTime = value; } }
        public decimal ServiceCharge { get; set; }
        public int BaseCurrencyID { get; set; }
        public int PaidCurrencyID { get; set; }
        public decimal OtherCurrencyAmount { get; set; }
        public string EMIOpted { get; set; }
        public decimal EMIROI { get; set; }
        public int EMITenor { get; set; }
        public decimal EMIValue { get; set; }
        public long ReferenceID { get; set; }
        public string ReferenceType { get; set; }
        public int Units { get; set; }
        public string CardHolderName { get; set; }
        public decimal CashGiven { get; set; }
        public decimal BalanceGiven { get; set; }
        public string TransactionID { get; set; }
        public string BranchName { get; set; }
        public string PaymentCollectedFrom { get; set; }
        public string IsOutStation { get; set; }
        public long AmtReceivedID { get; set; }
        public string AuthorisationCode { get; set; }
        public long ModifiedBy { get; set; }
    }

    public class UI_UDTOrderedInvestigations
    {
        private DateTime dateTime = DateTime.MaxValue;

        public string Name { get; set; }
        public long ID { get; set; }
        public long VisitID { get; set; }
        public long CreatedBy { get; set; }
        public long ModifiedBy { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public int OrgID { get; set; }
        public string StudyInstanceUId { get; set; }
        public int ComplaintId { get; set; }
        public int ReferedToOrgID { get; set; }
        public int ReferedToLocation { get; set; }
        public string InvestigationsType { get; set; }
        public long ReferralID { get; set; }
        public string UID { get; set; }
        public string ReferenceType { get; set; }
        public string RefPhyName { get; set; }
        public int RefPhysicianID { get; set; }
        public int SequenceNo { get; set; }
        public DateTime ReportDateTime { get { return dateTime; } set { dateTime = value; } }
        public DateTime TatDateTime { get { return dateTime; } set { dateTime = value; } }
        public string IsStat { get; set; }
        public string SampleID { get; set; }
    }

    public class UI_ControlMappingDetails
    {
        public int ControlTypeID { get; set; }
        public string ControlName { get; set; }
        public string ControlCode { get; set; }
        public long ControlMappingID { get; set; }
        public string DisplayText { get; set; }
        public int OrgID { get; set; }
        public long ReferenceID { get; set; }
        public string ReferenceType { get; set; }
        public int SequenceNo { get; set; }
        public long ControlValueID { get; set; }
        public string ControlValue { get; set; }
        public string Description { get; set; }
        public long ID { get; set; }
    }

    public class UI_VisitClientMapping
    {
        private DateTime dateTime = DateTime.MaxValue;

        public long VisitClientMappingID { get; set; }
        public long VisitID { get; set; }
        public long ClientID { get; set; }
        public long FinalBillID { get; set; }
        public long RateID { get; set; }
        public int OrgID { get; set; }
        public decimal PreAuthAmount { get; set; }
        public string PreAuthApprovalNumber { get; set; }
        public decimal ClaimAmount { get; set; }
        public int ClaimLogic { get; set; }
        public decimal CoPayment { get; set; }
        public decimal CopaymentPercent { get; set; }
        public int CoPaymentLogic { get; set; }
        public decimal NonMedicalAmount { get; set; }
        public string ClientAttributes { get; set; }
        public string IsAllMedical { get; set; }
        public string PaymentStatus { get; set; }
        public string ClientName { get; set; }
        public string RateName { get; set; }
        public string AsCreditBill { get; set; }
        public string PolicyNo { get; set; }
        public DateTime PolicyStartDate { get { return dateTime; } set { dateTime = value; } }
        public DateTime PolicyEndDate { get { return dateTime; } set { dateTime = value; } }
    }

    public class UI_DespatchMode
    {
        public long ActionTypeID { get; set; }
        public string Despatch { get; set; }
        public string Description { get; set; }
        public string ClientID { get; set; }
    }

    public class UI_PatientRedemDetails
    {
        public long MembershipCardMappingID { get; set; }
        public long PatientID { get; set; }
        public long VisitID { get; set; }
        public decimal RedemPoints { get; set; }
        public decimal RedemValue { get; set; }
        public decimal Finalbillid { get; set; }
    }

    
}
