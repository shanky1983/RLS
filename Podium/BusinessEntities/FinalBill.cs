using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class FinalBill
	{
		#region Fields

		private long finalBillID=0;
		private int orgID=0;
		private long patientID=0;
		private long visitID=0;
		private decimal grossBillValue=Decimal.Zero;
		private decimal discountAmount=Decimal.Zero;
		private long stdDedID=0;
		private decimal netValue=Decimal.Zero;
		private decimal amountReceived=Decimal.Zero;
		private decimal due=Decimal.Zero;
		private decimal advanceRecieved=Decimal.Zero;
		private decimal amountRefund=Decimal.Zero;
		private string isCreditBill=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private decimal taxPercent=Decimal.Zero;
		private decimal currentDue=Decimal.Zero;
		private string name=String.Empty;
		private string physician=String.Empty;
		private string comments=String.Empty;
		private int orgAddressID=0;
		private decimal taxAmount=Decimal.Zero;
		private int collectionCentreID=0;
		private string type=String.Empty;
		private long referenceBillID=0;
		private string status=String.Empty;
		private string billNumber=String.Empty;
		private string discountReason=String.Empty;
		private decimal serviceCharge=Decimal.Zero;
		private string tPAPaymentStatus=String.Empty;
		private decimal rightOff=Decimal.Zero;
		private decimal tDS=Decimal.Zero;
		private DateTime tPASettlementDate=DateTime.MaxValue;
		private decimal tPAAmount=Decimal.Zero;
		private decimal roundOff=Decimal.Zero;
		private decimal previousBill=Decimal.Zero;
		private decimal excessAmtRecd=Decimal.Zero;
		private decimal tpaDue=Decimal.Zero;
		private decimal patientDue=Decimal.Zero;
		private DateTime cliamForwardDate=DateTime.MaxValue;
		private string isDiscountPercentage=String.Empty;
		private DateTime billDate=DateTime.MaxValue;
		private decimal tPADiscountAmt=Decimal.Zero;
		private decimal tPASettledAmt=Decimal.Zero;
		private decimal tPADisallowedAmt=Decimal.Zero;
		private string tPARemarks=String.Empty;
		private long tPAApproverID=0;
		private string tPAApproverName=String.Empty;
		private DateTime tPAApprovedDate=DateTime.MaxValue;
		private long tPAWriteOffApprover=0;
		private string versionNo=String.Empty;
		private string isFreeOfCost=String.Empty;
		private long discountApprovedBy=0;
		private DateTime tATDate=DateTime.MaxValue;
		private decimal eDCess=Decimal.Zero;
		private decimal sHEDCess=Decimal.Zero;
		private string editBill=String.Empty;
		private long edt_BillMasterID=0;
		private long refFinalBillID=0;
		private DateTime reportDateTime=DateTime.MaxValue;
		private string isFoc=String.Empty;
		private decimal redeemPoints=Decimal.Zero;
		private decimal redeemValue=Decimal.Zero;
		private decimal creditValue=Decimal.Zero;
		private string isCashClient=String.Empty;
		private string isCoPayBill=String.Empty;
		private string hasHealthcoupon=String.Empty;
		private decimal itemLevelDiscountTotal=Decimal.Zero;
		private decimal billLevelDiscountTotal=Decimal.Zero;
		private long collectionID=0;
        private bool isfranchisee = false;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FinalBillID value.
		/// </summary>
		public long FinalBillID
		{
			get { return finalBillID; }
			set { finalBillID = value; }
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
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the GrossBillValue value.
		/// </summary>
		public decimal GrossBillValue
		{
			get { return grossBillValue; }
			set { grossBillValue = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountAmount value.
		/// </summary>
		public decimal DiscountAmount
		{
			get { return discountAmount; }
			set { discountAmount = value; }
		}

		/// <summary>
		/// Gets or sets the StdDedID value.
		/// </summary>
		public long StdDedID
		{
			get { return stdDedID; }
			set { stdDedID = value; }
		}

		/// <summary>
		/// Gets or sets the NetValue value.
		/// </summary>
		public decimal NetValue
		{
			get { return netValue; }
			set { netValue = value; }
		}

		/// <summary>
		/// Gets or sets the AmountReceived value.
		/// </summary>
		public decimal AmountReceived
		{
			get { return amountReceived; }
			set { amountReceived = value; }
		}

		/// <summary>
		/// Gets or sets the Due value.
		/// </summary>
		public decimal Due
		{
			get { return due; }
			set { due = value; }
		}

		/// <summary>
		/// Gets or sets the AdvanceRecieved value.
		/// </summary>
		public decimal AdvanceRecieved
		{
			get { return advanceRecieved; }
			set { advanceRecieved = value; }
		}

		/// <summary>
		/// Gets or sets the AmountRefund value.
		/// </summary>
		public decimal AmountRefund
		{
			get { return amountRefund; }
			set { amountRefund = value; }
		}

		/// <summary>
		/// Gets or sets the IsCreditBill value.
		/// </summary>
		public string IsCreditBill
		{
			get { return isCreditBill; }
			set { isCreditBill = value; }
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
		/// Gets or sets the TaxPercent value.
		/// </summary>
		public decimal TaxPercent
		{
			get { return taxPercent; }
			set { taxPercent = value; }
		}

		/// <summary>
		/// Gets or sets the CurrentDue value.
		/// </summary>
		public decimal CurrentDue
		{
			get { return currentDue; }
			set { currentDue = value; }
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
		/// Gets or sets the Physician value.
		/// </summary>
		public string Physician
		{
			get { return physician; }
			set { physician = value; }
		}

		/// <summary>
		/// Gets or sets the Comments value.
		/// </summary>
		public string Comments
		{
			get { return comments; }
			set { comments = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public int OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the TaxAmount value.
		/// </summary>
		public decimal TaxAmount
		{
			get { return taxAmount; }
			set { taxAmount = value; }
		}

		/// <summary>
		/// Gets or sets the CollectionCentreID value.
		/// </summary>
		public int CollectionCentreID
		{
			get { return collectionCentreID; }
			set { collectionCentreID = value; }
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
		/// Gets or sets the ReferenceBillID value.
		/// </summary>
		public long ReferenceBillID
		{
			get { return referenceBillID; }
			set { referenceBillID = value; }
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
		/// Gets or sets the BillNumber value.
		/// </summary>
		public string BillNumber
		{
			get { return billNumber; }
			set { billNumber = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountReason value.
		/// </summary>
		public string DiscountReason
		{
			get { return discountReason; }
			set { discountReason = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceCharge value.
		/// </summary>
		public decimal ServiceCharge
		{
			get { return serviceCharge; }
			set { serviceCharge = value; }
		}

		/// <summary>
		/// Gets or sets the TPAPaymentStatus value.
		/// </summary>
		public string TPAPaymentStatus
		{
			get { return tPAPaymentStatus; }
			set { tPAPaymentStatus = value; }
		}

		/// <summary>
		/// Gets or sets the RightOff value.
		/// </summary>
		public decimal RightOff
		{
			get { return rightOff; }
			set { rightOff = value; }
		}

		/// <summary>
		/// Gets or sets the TDS value.
		/// </summary>
		public decimal TDS
		{
			get { return tDS; }
			set { tDS = value; }
		}

		/// <summary>
		/// Gets or sets the TPASettlementDate value.
		/// </summary>
		public DateTime TPASettlementDate
		{
			get { return tPASettlementDate; }
			set { tPASettlementDate = value; }
		}

		/// <summary>
		/// Gets or sets the TPAAmount value.
		/// </summary>
		public decimal TPAAmount
		{
			get { return tPAAmount; }
			set { tPAAmount = value; }
		}

		/// <summary>
		/// Gets or sets the RoundOff value.
		/// </summary>
		public decimal RoundOff
		{
			get { return roundOff; }
			set { roundOff = value; }
		}

		/// <summary>
		/// Gets or sets the PreviousBill value.
		/// </summary>
		public decimal PreviousBill
		{
			get { return previousBill; }
			set { previousBill = value; }
		}

		/// <summary>
		/// Gets or sets the ExcessAmtRecd value.
		/// </summary>
		public decimal ExcessAmtRecd
		{
			get { return excessAmtRecd; }
			set { excessAmtRecd = value; }
		}

		/// <summary>
		/// Gets or sets the TpaDue value.
		/// </summary>
		public decimal TpaDue
		{
			get { return tpaDue; }
			set { tpaDue = value; }
		}

		/// <summary>
		/// Gets or sets the PatientDue value.
		/// </summary>
		public decimal PatientDue
		{
			get { return patientDue; }
			set { patientDue = value; }
		}

		/// <summary>
		/// Gets or sets the CliamForwardDate value.
		/// </summary>
		public DateTime CliamForwardDate
		{
			get { return cliamForwardDate; }
			set { cliamForwardDate = value; }
		}

		/// <summary>
		/// Gets or sets the IsDiscountPercentage value.
		/// </summary>
		public string IsDiscountPercentage
		{
			get { return isDiscountPercentage; }
			set { isDiscountPercentage = value; }
		}

		/// <summary>
		/// Gets or sets the BillDate value.
		/// </summary>
		public DateTime BillDate
		{
			get { return billDate; }
			set { billDate = value; }
		}

		/// <summary>
		/// Gets or sets the TPADiscountAmt value.
		/// </summary>
		public decimal TPADiscountAmt
		{
			get { return tPADiscountAmt; }
			set { tPADiscountAmt = value; }
		}

		/// <summary>
		/// Gets or sets the TPASettledAmt value.
		/// </summary>
		public decimal TPASettledAmt
		{
			get { return tPASettledAmt; }
			set { tPASettledAmt = value; }
		}

		/// <summary>
		/// Gets or sets the TPADisallowedAmt value.
		/// </summary>
		public decimal TPADisallowedAmt
		{
			get { return tPADisallowedAmt; }
			set { tPADisallowedAmt = value; }
		}

		/// <summary>
		/// Gets or sets the TPARemarks value.
		/// </summary>
		public string TPARemarks
		{
			get { return tPARemarks; }
			set { tPARemarks = value; }
		}

		/// <summary>
		/// Gets or sets the TPAApproverID value.
		/// </summary>
		public long TPAApproverID
		{
			get { return tPAApproverID; }
			set { tPAApproverID = value; }
		}

		/// <summary>
		/// Gets or sets the TPAApproverName value.
		/// </summary>
		public string TPAApproverName
		{
			get { return tPAApproverName; }
			set { tPAApproverName = value; }
		}

		/// <summary>
		/// Gets or sets the TPAApprovedDate value.
		/// </summary>
		public DateTime TPAApprovedDate
		{
			get { return tPAApprovedDate; }
			set { tPAApprovedDate = value; }
		}

		/// <summary>
		/// Gets or sets the TPAWriteOffApprover value.
		/// </summary>
		public long TPAWriteOffApprover
		{
			get { return tPAWriteOffApprover; }
			set { tPAWriteOffApprover = value; }
		}

		/// <summary>
		/// Gets or sets the VersionNo value.
		/// </summary>
		public string VersionNo
		{
			get { return versionNo; }
			set { versionNo = value; }
		}

		/// <summary>
		/// Gets or sets the IsFreeOfCost value.
		/// </summary>
		public string IsFreeOfCost
		{
			get { return isFreeOfCost; }
			set { isFreeOfCost = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountApprovedBy value.
		/// </summary>
		public long DiscountApprovedBy
		{
			get { return discountApprovedBy; }
			set { discountApprovedBy = value; }
		}

		/// <summary>
		/// Gets or sets the TATDate value.
		/// </summary>
		public DateTime TATDate
		{
			get { return tATDate; }
			set { tATDate = value; }
		}

		/// <summary>
		/// Gets or sets the EDCess value.
		/// </summary>
		public decimal EDCess
		{
			get { return eDCess; }
			set { eDCess = value; }
		}

		/// <summary>
		/// Gets or sets the SHEDCess value.
		/// </summary>
		public decimal SHEDCess
		{
			get { return sHEDCess; }
			set { sHEDCess = value; }
		}

		/// <summary>
		/// Gets or sets the EditBill value.
		/// </summary>
		public string EditBill
		{
			get { return editBill; }
			set { editBill = value; }
		}

		/// <summary>
		/// Gets or sets the Edt_BillMasterID value.
		/// </summary>
		public long Edt_BillMasterID
		{
			get { return edt_BillMasterID; }
			set { edt_BillMasterID = value; }
		}

		/// <summary>
		/// Gets or sets the RefFinalBillID value.
		/// </summary>
		public long RefFinalBillID
		{
			get { return refFinalBillID; }
			set { refFinalBillID = value; }
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
		/// Gets or sets the IsFoc value.
		/// </summary>
		public string IsFoc
		{
			get { return isFoc; }
			set { isFoc = value; }
		}

		/// <summary>
		/// Gets or sets the RedeemPoints value.
		/// </summary>
		public decimal RedeemPoints
		{
			get { return redeemPoints; }
			set { redeemPoints = value; }
		}

		/// <summary>
		/// Gets or sets the RedeemValue value.
		/// </summary>
		public decimal RedeemValue
		{
			get { return redeemValue; }
			set { redeemValue = value; }
		}

		/// <summary>
		/// Gets or sets the CreditValue value.
		/// </summary>
		public decimal CreditValue
		{
			get { return creditValue; }
			set { creditValue = value; }
		}

		/// <summary>
		/// Gets or sets the IsCashClient value.
		/// </summary>
		public string IsCashClient
		{
			get { return isCashClient; }
			set { isCashClient = value; }
		}

		/// <summary>
		/// Gets or sets the IsCoPayBill value.
		/// </summary>
		public string IsCoPayBill
		{
			get { return isCoPayBill; }
			set { isCoPayBill = value; }
		}

		/// <summary>
		/// Gets or sets the HasHealthcoupon value.
		/// </summary>
		public string HasHealthcoupon
		{
			get { return hasHealthcoupon; }
			set { hasHealthcoupon = value; }
		}

		/// <summary>
		/// Gets or sets the ItemLevelDiscountTotal value.
		/// </summary>
		public decimal ItemLevelDiscountTotal
		{
			get { return itemLevelDiscountTotal; }
			set { itemLevelDiscountTotal = value; }
		}

		/// <summary>
		/// Gets or sets the BillLevelDiscountTotal value.
		/// </summary>
		public decimal BillLevelDiscountTotal
		{
			get { return billLevelDiscountTotal; }
			set { billLevelDiscountTotal = value; }
		}

		/// <summary>
		/// Gets or sets the CollectionID value.
		/// </summary>
		public long CollectionID
		{
			get { return collectionID; }
			set { collectionID = value; }
		}

		/// <summary>
		/// Gets or sets the StdDedName value.
		/// </summary>
		private string _stdDedName=String.Empty;
		public string StdDedName
		{
			get { return  _stdDedName; }
			set { _stdDedName = value; }
		}

		/// <summary>
		/// Gets or sets the StdDedValue value.
		/// </summary>
		private string _stdDedValue=String.Empty;
		public string StdDedValue
		{
			get { return  _stdDedValue; }
			set { _stdDedValue = value; }
		}

		/// <summary>
		/// Gets or sets the StdDedType value.
		/// </summary>
		private string _stdDedType=String.Empty;
		public string StdDedType
		{
			get { return  _stdDedType; }
			set { _stdDedType = value; }
		}

		/// <summary>
		/// Gets or sets the DueStamp value.
		/// </summary>
		private decimal _dueStamp=Decimal.Zero;
		public decimal DueStamp
		{
			get { return  _dueStamp; }
			set { _dueStamp = value; }
		}

		/// <summary>
		/// Gets or sets the BilledBy value.
		/// </summary>
		private string _billedBy=String.Empty;
		public string BilledBy
		{
			get { return  _billedBy; }
			set { _billedBy = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		private string _description=String.Empty;
		public string Description
		{
			get { return  _description; }
			set { _description = value; }
		}

		/// <summary>
		/// Gets or sets the RefundStatus value.
		/// </summary>
		private string _refundStatus=String.Empty;
		public string RefundStatus
		{
			get { return  _refundStatus; }
			set { _refundStatus = value; }
		}

		/// <summary>
		/// Gets or sets the PatientAge value.
		/// </summary>
		private string _patientAge=String.Empty;
		public string PatientAge
		{
			get { return  _patientAge; }
			set { _patientAge = value; }
		}

		/// <summary>
		/// Gets or sets the PatientNo value.
		/// </summary>
		private string _patientNo=String.Empty;
		public string PatientNo
		{
			get { return  _patientNo; }
			set { _patientNo = value; }
		}

		/// <summary>
		/// Gets or sets the RemainDeposit value.
		/// </summary>
		private decimal _remainDeposit=Decimal.Zero;
		public decimal RemainDeposit
		{
			get { return  _remainDeposit; }
			set { _remainDeposit = value; }
		}

		/// <summary>
		/// Gets or sets the TotalDepositAmount value.
		/// </summary>
		private decimal _totalDepositAmount=Decimal.Zero;
		public decimal TotalDepositAmount
		{
			get { return  _totalDepositAmount; }
			set { _totalDepositAmount = value; }
		}

		/// <summary>
		/// Gets or sets the TotalDepositUsed value.
		/// </summary>
		private decimal _totalDepositUsed=Decimal.Zero;
		public decimal TotalDepositUsed
		{
			get { return  _totalDepositUsed; }
			set { _totalDepositUsed = value; }
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
		/// Gets or sets the ToPay value.
		/// </summary>
		private decimal _toPay=Decimal.Zero;
		public decimal ToPay
		{
			get { return  _toPay; }
			set { _toPay = value; }
		}

		/// <summary>
		/// Gets or sets the CreditLimt value.
		/// </summary>
		private decimal _creditLimt=Decimal.Zero;
		public decimal CreditLimt
		{
			get { return  _creditLimt; }
			set { _creditLimt = value; }
		}

		/// <summary>
		/// Gets or sets the BalanceCreditLimit value.
		/// </summary>
		private decimal _balanceCreditLimit=Decimal.Zero;
		public decimal BalanceCreditLimit
		{
			get { return  _balanceCreditLimit; }
			set { _balanceCreditLimit = value; }
		}

		/// <summary>
		/// Gets or sets the PatientIdentifyID value.
		/// </summary>
		private string _patientIdentifyID=String.Empty;
		public string PatientIdentifyID
		{
			get { return  _patientIdentifyID; }
			set { _patientIdentifyID = value; }
		}

		/// <summary>
		/// Gets or sets the PreAuthAmount value.
		/// </summary>
		private decimal _preAuthAmount=Decimal.Zero;
		public decimal PreAuthAmount
		{
			get { return  _preAuthAmount; }
			set { _preAuthAmount = value; }
		}

		/// <summary>
		/// Gets or sets the NonMedicalAmount value.
		/// </summary>
		private decimal _nonMedicalAmount=Decimal.Zero;
		public decimal NonMedicalAmount
		{
			get { return  _nonMedicalAmount; }
			set { _nonMedicalAmount = value; }
		}

		/// <summary>
		/// Gets or sets the CoPayment value.
		/// </summary>
		private decimal _coPayment=Decimal.Zero;
		public decimal CoPayment
		{
			get { return  _coPayment; }
			set { _coPayment = value; }
		}

		/// <summary>
		/// Gets or sets the RateID value.
		/// </summary>
		private int _rateID=0;
		public int RateID
		{
			get { return  _rateID; }
			set { _rateID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		private int _clientID=0;
		public int ClientID
		{
			get { return  _clientID; }
			set { _clientID = value; }
		}

		/// <summary>
		/// Gets or sets the TotalCount value.
		/// </summary>
		private int _totalCount=0;
		public int TotalCount
		{
			get { return  _totalCount; }
			set { _totalCount = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		private int _locationID=0;
		public int LocationID
		{
			get { return  _locationID; }
			set { _locationID = value; }
		}

		/// <summary>
		/// Gets or sets the PrepareCharges value.
		/// </summary>
		private decimal _prepareCharges=Decimal.Zero;
		public decimal PrepareCharges
		{
			get { return  _prepareCharges; }
			set { _prepareCharges = value; }
		}

		/// <summary>
		/// Gets or sets the DueReason value.
		/// </summary>
		private string _dueReason=String.Empty;
		public string DueReason
		{
			get { return  _dueReason; }
			set { _dueReason = value; }
		}

		/// <summary>
		/// Gets or sets the PreAuthApprovalNumber value.
		/// </summary>
		private string _preAuthApprovalNumber=String.Empty;
		public string PreAuthApprovalNumber
		{
			get { return  _preAuthApprovalNumber; }
			set { _preAuthApprovalNumber = value; }
		}

		/// <summary>
		/// Gets or sets the PaymentCollectedFrom value.
		/// </summary>
		private string _paymentCollectedFrom=String.Empty;
		public string PaymentCollectedFrom
		{
			get { return  _paymentCollectedFrom; }
			set { _paymentCollectedFrom = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountID value.
		/// </summary>
		private long _discountID=0;
		public long DiscountID
		{
			get { return  _discountID; }
			set { _discountID = value; }
		}

		/// <summary>
		/// Gets or sets the IsCopay value.
		/// </summary>
		private string _isCopay=String.Empty;
		public string IsCopay
		{
			get { return  _isCopay; }
			set { _isCopay = value; }
		}

        private bool IsFranchisee
        {
            get { return isfranchisee; }
            set { isfranchisee = value; }
        }
		#endregion
}
}
