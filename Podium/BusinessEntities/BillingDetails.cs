using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class BillingDetails
	{
		#region Fields

		private long billingDetailsID=0;
		private long finalBillID=0;
		private long feeId=0;
		private string feeType=String.Empty;
		private string feeDescription=String.Empty;
		private decimal amount=Decimal.Zero;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string itemType=String.Empty;
		private decimal quantity=Decimal.Zero;
		private decimal rate=Decimal.Zero;
		private string status=String.Empty;
		private string isCreditBill=String.Empty;
		private string batchNo=String.Empty;
		private DateTime expiryDate=DateTime.MaxValue;
		private DateTime fromDate=DateTime.MaxValue;
		private DateTime toDate=DateTime.MaxValue;
		private string attributeDetail=String.Empty;
		private string receiptNO=String.Empty;
		private decimal discountAmount=Decimal.Zero;
		private string isReimbursable=String.Empty;
		private string isTaxable=String.Empty;
		private string serviceCode=String.Empty;
		private long refPhysicianID=0;
		private string refPhyName=String.Empty;
		private string referenceType=String.Empty;
		private string perphyname=String.Empty;
		private long perphyID=0;
		private decimal returnQuantity=Decimal.Zero;
		private string sourceType=String.Empty;
		private long sourceTypeID=0;
		private DateTime billedDate=DateTime.MaxValue;
		private string labNo=String.Empty;
		private decimal taxPercent=Decimal.Zero;
		private decimal discountPercent=Decimal.Zero;
		private string discOrEnhanceType=String.Empty;
		private string remarks=String.Empty;
		private int roomTypeID=0;
		private long kitid=0;
		private string productKey=String.Empty;
		private string versionNo=String.Empty;
		private decimal reimbursableAmount=Decimal.Zero;
		private decimal nonReimbursableAmount=Decimal.Zero;
		private int roleID=0;
		private int deptID=0;
		private long orgID=0;
		private int locationID=0;
		private long taskID=0;
		private decimal actualAmount=Decimal.Zero;
		private long rateID=0;
		private string pharmacyBillNo=String.Empty;
		private string isDiscountable=String.Empty;
		private string isSTAT=String.Empty;
		private string isOutSource=String.Empty;
		private string isNABL=String.Empty;
		private long clientID=0;
		private long transferRateID=0;
		private decimal transferAmount=Decimal.Zero;
		private DateTime tatDateTime=DateTime.MaxValue;
		private string performertype=String.Empty;
		private long baseRateID=0;
		private long discountPolicyID=0;
		private string discountCategoryCode=String.Empty;
		private DateTime reportDateTime=DateTime.MaxValue;
		private decimal maxTestDisAmount=Decimal.Zero;
		private decimal baseTestcalculationAmount=Decimal.Zero;
		private decimal maxTestDisPercentage=Decimal.Zero;
		private string isRedeem=String.Empty;
		private decimal redeemAmount=Decimal.Zero;
		private decimal redeemPoints=Decimal.Zero;
		private int couponId=0;
		private long currencyID=0;
		private string discountReason=String.Empty;
		private decimal eligibleAmount=Decimal.Zero;
		private decimal coSharing=Decimal.Zero;
		private int rateRefID=0;
		private string comments=String.Empty;
		private string rejectReason=String.Empty;
		private string resubmissionType=String.Empty;
		private string claimStatus=String.Empty;
		private string isAdminChargeApplicable=String.Empty;
		private string discOrEnhanceRemarks=String.Empty;
		private string sellingUnit=String.Empty;
		private long clientFeeTypeRateCustID=0;
		private decimal agreedAmount=Decimal.Zero;
		private decimal discOrEnhancePercent=Decimal.Zero;
		private int referralID=0;
		private string referralType=String.Empty;
		private decimal coPayValue=Decimal.Zero;
		private string coPayType=String.Empty;
		private long perPhySpecialtyID=0;
		private long packageId=0;
		private long productReceivedDetailsID=0;
		private long receivedUniqueNumber=0;
		private decimal taxAmount=Decimal.Zero;
		private DateTime tatreferencedatetime=DateTime.MaxValue;
		private byte tatreferencedatebase=0x00;
		private short logistictimeinmins=0;
		private DateTime tatsamplereceiptdatetime=DateTime.MaxValue;
		private int processingtimeinmins=0;
		private DateTime tatprocessstartdatetime=DateTime.MaxValue;
		private TimeSpan labendtime=TimeSpan.MinValue;
		private TimeSpan earlyreporttime=TimeSpan.MinValue;
		private DateTime customerCommittedTAT=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BillingDetailsID value.
		/// </summary>
		public long BillingDetailsID
		{
			get { return billingDetailsID; }
			set { billingDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the FinalBillID value.
		/// </summary>
		public long FinalBillID
		{
			get { return finalBillID; }
			set { finalBillID = value; }
		}

		/// <summary>
		/// Gets or sets the FeeId value.
		/// </summary>
		public long FeeId
		{
			get { return feeId; }
			set { feeId = value; }
		}

		/// <summary>
		/// Gets or sets the FeeType value.
		/// </summary>
		public string FeeType
		{
			get { return feeType; }
			set { feeType = value; }
		}

		/// <summary>
		/// Gets or sets the FeeDescription value.
		/// </summary>
		public string FeeDescription
		{
			get { return feeDescription; }
			set { feeDescription = value; }
		}

		/// <summary>
		/// Gets or sets the Amount value.
		/// </summary>
		public decimal Amount
		{
			get { return amount; }
			set { amount = value; }
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
		/// Gets or sets the ItemType value.
		/// </summary>
		public string ItemType
		{
			get { return itemType; }
			set { itemType = value; }
		}

		/// <summary>
		/// Gets or sets the Quantity value.
		/// </summary>
		public decimal Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}

		/// <summary>
		/// Gets or sets the Rate value.
		/// </summary>
		public decimal Rate
		{
			get { return rate; }
			set { rate = value; }
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
		/// Gets or sets the IsCreditBill value.
		/// </summary>
		public string IsCreditBill
		{
			get { return isCreditBill; }
			set { isCreditBill = value; }
		}

		/// <summary>
		/// Gets or sets the BatchNo value.
		/// </summary>
		public string BatchNo
		{
			get { return batchNo; }
			set { batchNo = value; }
		}

		/// <summary>
		/// Gets or sets the ExpiryDate value.
		/// </summary>
		public DateTime ExpiryDate
		{
			get { return expiryDate; }
			set { expiryDate = value; }
		}

		/// <summary>
		/// Gets or sets the FromDate value.
		/// </summary>
		public DateTime FromDate
		{
			get { return fromDate; }
			set { fromDate = value; }
		}

		/// <summary>
		/// Gets or sets the ToDate value.
		/// </summary>
		public DateTime ToDate
		{
			get { return toDate; }
			set { toDate = value; }
		}

		/// <summary>
		/// Gets or sets the AttributeDetail value.
		/// </summary>
		public string AttributeDetail
		{
			get { return attributeDetail; }
			set { attributeDetail = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiptNO value.
		/// </summary>
		public string ReceiptNO
		{
			get { return receiptNO; }
			set { receiptNO = value; }
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
		/// Gets or sets the IsReimbursable value.
		/// </summary>
		public string IsReimbursable
		{
			get { return isReimbursable; }
			set { isReimbursable = value; }
		}

		/// <summary>
		/// Gets or sets the IsTaxable value.
		/// </summary>
		public string IsTaxable
		{
			get { return isTaxable; }
			set { isTaxable = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceCode value.
		/// </summary>
		public string ServiceCode
		{
			get { return serviceCode; }
			set { serviceCode = value; }
		}

		/// <summary>
		/// Gets or sets the RefPhysicianID value.
		/// </summary>
		public long RefPhysicianID
		{
			get { return refPhysicianID; }
			set { refPhysicianID = value; }
		}

		/// <summary>
		/// Gets or sets the RefPhyName value.
		/// </summary>
		public string RefPhyName
		{
			get { return refPhyName; }
			set { refPhyName = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceType value.
		/// </summary>
		public string ReferenceType
		{
			get { return referenceType; }
			set { referenceType = value; }
		}

		/// <summary>
		/// Gets or sets the Perphyname value.
		/// </summary>
		public string Perphyname
		{
			get { return perphyname; }
			set { perphyname = value; }
		}

		/// <summary>
		/// Gets or sets the PerphyID value.
		/// </summary>
		public long PerphyID
		{
			get { return perphyID; }
			set { perphyID = value; }
		}

		/// <summary>
		/// Gets or sets the ReturnQuantity value.
		/// </summary>
		public decimal ReturnQuantity
		{
			get { return returnQuantity; }
			set { returnQuantity = value; }
		}

		/// <summary>
		/// Gets or sets the SourceType value.
		/// </summary>
		public string SourceType
		{
			get { return sourceType; }
			set { sourceType = value; }
		}

		/// <summary>
		/// Gets or sets the SourceTypeID value.
		/// </summary>
		public long SourceTypeID
		{
			get { return sourceTypeID; }
			set { sourceTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the BilledDate value.
		/// </summary>
		public DateTime BilledDate
		{
			get { return billedDate; }
			set { billedDate = value; }
		}

		/// <summary>
		/// Gets or sets the LabNo value.
		/// </summary>
		public string LabNo
		{
			get { return labNo; }
			set { labNo = value; }
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
		/// Gets or sets the DiscountPercent value.
		/// </summary>
		public decimal DiscountPercent
		{
			get { return discountPercent; }
			set { discountPercent = value; }
		}

		/// <summary>
		/// Gets or sets the DiscOrEnhanceType value.
		/// </summary>
		public string DiscOrEnhanceType
		{
			get { return discOrEnhanceType; }
			set { discOrEnhanceType = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
		}

		/// <summary>
		/// Gets or sets the RoomTypeID value.
		/// </summary>
		public int RoomTypeID
		{
			get { return roomTypeID; }
			set { roomTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the Kitid value.
		/// </summary>
		public long Kitid
		{
			get { return kitid; }
			set { kitid = value; }
		}

		/// <summary>
		/// Gets or sets the ProductKey value.
		/// </summary>
		public string ProductKey
		{
			get { return productKey; }
			set { productKey = value; }
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
		/// Gets or sets the ReimbursableAmount value.
		/// </summary>
		public decimal ReimbursableAmount
		{
			get { return reimbursableAmount; }
			set { reimbursableAmount = value; }
		}

		/// <summary>
		/// Gets or sets the NonReimbursableAmount value.
		/// </summary>
		public decimal NonReimbursableAmount
		{
			get { return nonReimbursableAmount; }
			set { nonReimbursableAmount = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		public int RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}

		/// <summary>
		/// Gets or sets the DeptID value.
		/// </summary>
		public int DeptID
		{
			get { return deptID; }
			set { deptID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		public int LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the TaskID value.
		/// </summary>
		public long TaskID
		{
			get { return taskID; }
			set { taskID = value; }
		}

		/// <summary>
		/// Gets or sets the ActualAmount value.
		/// </summary>
		public decimal ActualAmount
		{
			get { return actualAmount; }
			set { actualAmount = value; }
		}

		/// <summary>
		/// Gets or sets the RateID value.
		/// </summary>
		public long RateID
		{
			get { return rateID; }
			set { rateID = value; }
		}

		/// <summary>
		/// Gets or sets the PharmacyBillNo value.
		/// </summary>
		public string PharmacyBillNo
		{
			get { return pharmacyBillNo; }
			set { pharmacyBillNo = value; }
		}

		/// <summary>
		/// Gets or sets the IsDiscountable value.
		/// </summary>
		public string IsDiscountable
		{
			get { return isDiscountable; }
			set { isDiscountable = value; }
		}

		/// <summary>
		/// Gets or sets the IsSTAT value.
		/// </summary>
		public string IsSTAT
		{
			get { return isSTAT; }
			set { isSTAT = value; }
		}

		/// <summary>
		/// Gets or sets the IsOutSource value.
		/// </summary>
		public string IsOutSource
		{
			get { return isOutSource; }
			set { isOutSource = value; }
		}

		/// <summary>
		/// Gets or sets the IsNABL value.
		/// </summary>
		public string IsNABL
		{
			get { return isNABL; }
			set { isNABL = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public long ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		/// <summary>
		/// Gets or sets the TransferRateID value.
		/// </summary>
		public long TransferRateID
		{
			get { return transferRateID; }
			set { transferRateID = value; }
		}

		/// <summary>
		/// Gets or sets the TransferAmount value.
		/// </summary>
		public decimal TransferAmount
		{
			get { return transferAmount; }
			set { transferAmount = value; }
		}

		/// <summary>
		/// Gets or sets the TatDateTime value.
		/// </summary>
		public DateTime TatDateTime
		{
			get { return tatDateTime; }
			set { tatDateTime = value; }
		}

		/// <summary>
		/// Gets or sets the Performertype value.
		/// </summary>
		public string Performertype
		{
			get { return performertype; }
			set { performertype = value; }
		}

		/// <summary>
		/// Gets or sets the BaseRateID value.
		/// </summary>
		public long BaseRateID
		{
			get { return baseRateID; }
			set { baseRateID = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountPolicyID value.
		/// </summary>
		public long DiscountPolicyID
		{
			get { return discountPolicyID; }
			set { discountPolicyID = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountCategoryCode value.
		/// </summary>
		public string DiscountCategoryCode
		{
			get { return discountCategoryCode; }
			set { discountCategoryCode = value; }
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
		/// Gets or sets the MaxTestDisAmount value.
		/// </summary>
		public decimal MaxTestDisAmount
		{
			get { return maxTestDisAmount; }
			set { maxTestDisAmount = value; }
		}

		/// <summary>
		/// Gets or sets the BaseTestcalculationAmount value.
		/// </summary>
		public decimal BaseTestcalculationAmount
		{
			get { return baseTestcalculationAmount; }
			set { baseTestcalculationAmount = value; }
		}

		/// <summary>
		/// Gets or sets the MaxTestDisPercentage value.
		/// </summary>
		public decimal MaxTestDisPercentage
		{
			get { return maxTestDisPercentage; }
			set { maxTestDisPercentage = value; }
		}

		/// <summary>
		/// Gets or sets the IsRedeem value.
		/// </summary>
		public string IsRedeem
		{
			get { return isRedeem; }
			set { isRedeem = value; }
		}

		/// <summary>
		/// Gets or sets the RedeemAmount value.
		/// </summary>
		public decimal RedeemAmount
		{
			get { return redeemAmount; }
			set { redeemAmount = value; }
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
		/// Gets or sets the CouponId value.
		/// </summary>
		public int CouponId
		{
			get { return couponId; }
			set { couponId = value; }
		}

		/// <summary>
		/// Gets or sets the CurrencyID value.
		/// </summary>
		public long CurrencyID
		{
			get { return currencyID; }
			set { currencyID = value; }
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
		/// Gets or sets the EligibleAmount value.
		/// </summary>
		public decimal EligibleAmount
		{
			get { return eligibleAmount; }
			set { eligibleAmount = value; }
		}

		/// <summary>
		/// Gets or sets the CoSharing value.
		/// </summary>
		public decimal CoSharing
		{
			get { return coSharing; }
			set { coSharing = value; }
		}

		/// <summary>
		/// Gets or sets the RateRefID value.
		/// </summary>
		public int RateRefID
		{
			get { return rateRefID; }
			set { rateRefID = value; }
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
		/// Gets or sets the RejectReason value.
		/// </summary>
		public string RejectReason
		{
			get { return rejectReason; }
			set { rejectReason = value; }
		}

		/// <summary>
		/// Gets or sets the ResubmissionType value.
		/// </summary>
		public string ResubmissionType
		{
			get { return resubmissionType; }
			set { resubmissionType = value; }
		}

		/// <summary>
		/// Gets or sets the ClaimStatus value.
		/// </summary>
		public string ClaimStatus
		{
			get { return claimStatus; }
			set { claimStatus = value; }
		}

		/// <summary>
		/// Gets or sets the IsAdminChargeApplicable value.
		/// </summary>
		public string IsAdminChargeApplicable
		{
			get { return isAdminChargeApplicable; }
			set { isAdminChargeApplicable = value; }
		}

		/// <summary>
		/// Gets or sets the DiscOrEnhanceRemarks value.
		/// </summary>
		public string DiscOrEnhanceRemarks
		{
			get { return discOrEnhanceRemarks; }
			set { discOrEnhanceRemarks = value; }
		}

		/// <summary>
		/// Gets or sets the SellingUnit value.
		/// </summary>
		public string SellingUnit
		{
			get { return sellingUnit; }
			set { sellingUnit = value; }
		}

		/// <summary>
		/// Gets or sets the ClientFeeTypeRateCustID value.
		/// </summary>
		public long ClientFeeTypeRateCustID
		{
			get { return clientFeeTypeRateCustID; }
			set { clientFeeTypeRateCustID = value; }
		}

		/// <summary>
		/// Gets or sets the AgreedAmount value.
		/// </summary>
		public decimal AgreedAmount
		{
			get { return agreedAmount; }
			set { agreedAmount = value; }
		}

		/// <summary>
		/// Gets or sets the DiscOrEnhancePercent value.
		/// </summary>
		public decimal DiscOrEnhancePercent
		{
			get { return discOrEnhancePercent; }
			set { discOrEnhancePercent = value; }
		}

		/// <summary>
		/// Gets or sets the ReferralID value.
		/// </summary>
		public int ReferralID
		{
			get { return referralID; }
			set { referralID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferralType value.
		/// </summary>
		public string ReferralType
		{
			get { return referralType; }
			set { referralType = value; }
		}

		/// <summary>
		/// Gets or sets the CoPayValue value.
		/// </summary>
		public decimal CoPayValue
		{
			get { return coPayValue; }
			set { coPayValue = value; }
		}

		/// <summary>
		/// Gets or sets the CoPayType value.
		/// </summary>
		public string CoPayType
		{
			get { return coPayType; }
			set { coPayType = value; }
		}

		/// <summary>
		/// Gets or sets the PerPhySpecialtyID value.
		/// </summary>
		public long PerPhySpecialtyID
		{
			get { return perPhySpecialtyID; }
			set { perPhySpecialtyID = value; }
		}

		/// <summary>
		/// Gets or sets the PackageId value.
		/// </summary>
		public long PackageId
		{
			get { return packageId; }
			set { packageId = value; }
		}

		/// <summary>
		/// Gets or sets the ProductReceivedDetailsID value.
		/// </summary>
		public long ProductReceivedDetailsID
		{
			get { return productReceivedDetailsID; }
			set { productReceivedDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the ReceivedUniqueNumber value.
		/// </summary>
		public long ReceivedUniqueNumber
		{
			get { return receivedUniqueNumber; }
			set { receivedUniqueNumber = value; }
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
		/// Gets or sets the Tatreferencedatetime value.
		/// </summary>
		public DateTime Tatreferencedatetime
		{
			get { return tatreferencedatetime; }
			set { tatreferencedatetime = value; }
		}

		/// <summary>
		/// Gets or sets the Tatreferencedatebase value.
		/// </summary>
		public byte Tatreferencedatebase
		{
			get { return tatreferencedatebase; }
			set { tatreferencedatebase = value; }
		}

		/// <summary>
		/// Gets or sets the Logistictimeinmins value.
		/// </summary>
		public short Logistictimeinmins
		{
			get { return logistictimeinmins; }
			set { logistictimeinmins = value; }
		}

		/// <summary>
		/// Gets or sets the Tatsamplereceiptdatetime value.
		/// </summary>
		public DateTime Tatsamplereceiptdatetime
		{
			get { return tatsamplereceiptdatetime; }
			set { tatsamplereceiptdatetime = value; }
		}

		/// <summary>
		/// Gets or sets the Processingtimeinmins value.
		/// </summary>
		public int Processingtimeinmins
		{
			get { return processingtimeinmins; }
			set { processingtimeinmins = value; }
		}

		/// <summary>
		/// Gets or sets the Tatprocessstartdatetime value.
		/// </summary>
		public DateTime Tatprocessstartdatetime
		{
			get { return tatprocessstartdatetime; }
			set { tatprocessstartdatetime = value; }
		}

		/// <summary>
		/// Gets or sets the Labendtime value.
		/// </summary>
		public TimeSpan Labendtime
		{
			get { return labendtime; }
			set { labendtime = value; }
		}

		/// <summary>
		/// Gets or sets the Earlyreporttime value.
		/// </summary>
		public TimeSpan Earlyreporttime
		{
			get { return earlyreporttime; }
			set { earlyreporttime = value; }
		}

		/// <summary>
		/// Gets or sets the CustomerCommittedTAT value.
		/// </summary>
		public DateTime CustomerCommittedTAT
		{
			get { return customerCommittedTAT; }
			set { customerCommittedTAT = value; }
		}

		/// <summary>
		/// Gets or sets the SNo value.
		/// </summary>
		private long _sNo=0;
		public long SNo
		{
			get { return  _sNo; }
			set { _sNo = value; }
		}

		/// <summary>
		/// Gets or sets the IsVariable value.
		/// </summary>
		private String _isVariable=String.Empty;
		public String IsVariable
		{
			get { return  _isVariable; }
			set { _isVariable = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianFeeID value.
		/// </summary>
		private long _physicianFeeID=0;
		public long PhysicianFeeID
		{
			get { return  _physicianFeeID; }
			set { _physicianFeeID = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		private long _iD=0;
		public long ID
		{
			get { return  _iD; }
			set { _iD = value; }
		}

		/// <summary>
		/// Gets or sets the ProcedureName value.
		/// </summary>
		private String _procedureName=String.Empty;
		public String ProcedureName
		{
			get { return  _procedureName; }
			set { _procedureName = value; }
		}

		/// <summary>
		/// Gets or sets the ProcedureType value.
		/// </summary>
		private String _procedureType=String.Empty;
		public String ProcedureType
		{
			get { return  _procedureType; }
			set { _procedureType = value; }
		}

		/// <summary>
		/// Gets or sets the IsAVisitPurpose value.
		/// </summary>
		private String _isAVisitPurpose=String.Empty;
		public String IsAVisitPurpose
		{
			get { return  _isAVisitPurpose; }
			set { _isAVisitPurpose = value; }
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
		/// Gets or sets the VisitID value.
		/// </summary>
		private long _visitID=0;
		public long VisitID
		{
			get { return  _visitID; }
			set { _visitID = value; }
		}

		/// <summary>
		/// Gets or sets the GrossBillValue value.
		/// </summary>
		private decimal _grossBillValue=Decimal.Zero;
		public decimal GrossBillValue
		{
			get { return  _grossBillValue; }
			set { _grossBillValue = value; }
		}

		/// <summary>
		/// Gets or sets the StdDedID value.
		/// </summary>
		private long _stdDedID=0;
		public long StdDedID
		{
			get { return  _stdDedID; }
			set { _stdDedID = value; }
		}

		/// <summary>
		/// Gets or sets the NetValue value.
		/// </summary>
		private decimal _netValue=Decimal.Zero;
		public decimal NetValue
		{
			get { return  _netValue; }
			set { _netValue = value; }
		}

		/// <summary>
		/// Gets or sets the AmountReceived value.
		/// </summary>
		private decimal _amountReceived=Decimal.Zero;
		public decimal AmountReceived
		{
			get { return  _amountReceived; }
			set { _amountReceived = value; }
		}

		/// <summary>
		/// Gets or sets the Due value.
		/// </summary>
		private decimal _due=Decimal.Zero;
		public decimal Due
		{
			get { return  _due; }
			set { _due = value; }
		}

		/// <summary>
		/// Gets or sets the AdvanceRecieved value.
		/// </summary>
		private decimal _advanceRecieved=Decimal.Zero;
		public decimal AdvanceRecieved
		{
			get { return  _advanceRecieved; }
			set { _advanceRecieved = value; }
		}

		/// <summary>
		/// Gets or sets the AmountRefund value.
		/// </summary>
		private decimal _amountRefund=Decimal.Zero;
		public decimal AmountRefund
		{
			get { return  _amountRefund; }
			set { _amountRefund = value; }
		}

		/// <summary>
		/// Gets or sets the FORENAME value.
		/// </summary>
		private string _fORENAME=String.Empty;
		public string FORENAME
		{
			get { return  _fORENAME; }
			set { _fORENAME = value; }
		}

		/// <summary>
		/// Gets or sets the RefundedAmt value.
		/// </summary>
		private decimal _refundedAmt=Decimal.Zero;
		public decimal RefundedAmt
		{
			get { return  _refundedAmt; }
			set { _refundedAmt = value; }
		}

		/// <summary>
		/// Gets or sets the UseEdit value.
		/// </summary>
		private String _useEdit=String.Empty;
		public String UseEdit
		{
			get { return  _useEdit; }
			set { _useEdit = value; }
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
		/// Gets or sets the Address value.
		/// </summary>
		private string _address=String.Empty;
		public string Address
		{
			get { return  _address; }
			set { _address = value; }
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
		/// Gets or sets the IPIterPayDetailsID value.
		/// </summary>
		private long _iPIterPayDetailsID=0;
		public long IPIterPayDetailsID
		{
			get { return  _iPIterPayDetailsID; }
			set { _iPIterPayDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the IsTaskAssign value.
		/// </summary>
		private string _isTaskAssign=String.Empty;
		public string IsTaskAssign
		{
			get { return  _isTaskAssign; }
			set { _isTaskAssign = value; }
		}

		/// <summary>
		/// Gets or sets the ReasonforRefund value.
		/// </summary>
		private string _reasonforRefund=String.Empty;
		public string ReasonforRefund
		{
			get { return  _reasonforRefund; }
			set { _reasonforRefund = value; }
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
		/// Gets or sets the FromTable value.
		/// </summary>
		private string _fromTable=String.Empty;
		public string FromTable
		{
			get { return  _fromTable; }
			set { _fromTable = value; }
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
		/// Gets or sets the BillNumber value.
		/// </summary>
		private string _billNumber=String.Empty;
		public string BillNumber
		{
			get { return  _billNumber; }
			set { _billNumber = value; }
		}

		/// <summary>
		/// Gets or sets the UnitPrice value.
		/// </summary>
		private decimal _unitPrice=Decimal.Zero;
		public decimal UnitPrice
		{
			get { return  _unitPrice; }
			set { _unitPrice = value; }
		}

		/// <summary>
		/// Gets or sets the OpAmtToHos value.
		/// </summary>
		private decimal _opAmtToHos=Decimal.Zero;
		public decimal OpAmtToHos
		{
			get { return  _opAmtToHos; }
			set { _opAmtToHos = value; }
		}

		/// <summary>
		/// Gets or sets the AmtToDoct value.
		/// </summary>
		private decimal _amtToDoct=Decimal.Zero;
		public decimal AmtToDoct
		{
			get { return  _amtToDoct; }
			set { _amtToDoct = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiptInterimNo value.
		/// </summary>
		private string _receiptInterimNo=String.Empty;
		public string ReceiptInterimNo
		{
			get { return  _receiptInterimNo; }
			set { _receiptInterimNo = value; }
		}

		/// <summary>
		/// Gets or sets the AmountDeposited value.
		/// </summary>
		private decimal _amountDeposited=Decimal.Zero;
		public decimal AmountDeposited
		{
			get { return  _amountDeposited; }
			set { _amountDeposited = value; }
		}

		/// <summary>
		/// Gets or sets the PaymentName value.
		/// </summary>
		private string _paymentName=String.Empty;
		public string PaymentName
		{
			get { return  _paymentName; }
			set { _paymentName = value; }
		}

		/// <summary>
		/// Gets or sets the AmountUsed value.
		/// </summary>
		private decimal _amountUsed=Decimal.Zero;
		public decimal AmountUsed
		{
			get { return  _amountUsed; }
			set { _amountUsed = value; }
		}

		/// <summary>
		/// Gets or sets the PatientHistory value.
		/// </summary>
		private string _patientHistory=String.Empty;
		public string PatientHistory
		{
			get { return  _patientHistory; }
			set { _patientHistory = value; }
		}

		/// <summary>
		/// Gets or sets the PayType value.
		/// </summary>
		private string _payType=String.Empty;
		public string PayType
		{
			get { return  _payType; }
			set { _payType = value; }
		}

		/// <summary>
		/// Gets or sets the Discount value.
		/// </summary>
		private string _discount=String.Empty;
		public string Discount
		{
			get { return  _discount; }
			set { _discount = value; }
		}

		/// <summary>
		/// Gets or sets the VolumeDiscount value.
		/// </summary>
		private decimal _volumeDiscount=Decimal.Zero;
		public decimal VolumeDiscount
		{
			get { return  _volumeDiscount; }
			set { _volumeDiscount = value; }
		}

		/// <summary>
		/// Gets or sets the VisitType value.
		/// </summary>
		private int _visitType=0;
		public int VisitType
		{
			get { return  _visitType; }
			set { _visitType = value; }
		}

		/// <summary>
		/// Gets or sets the BilledAmount value.
		/// </summary>
		private decimal _billedAmount=Decimal.Zero;
		public decimal BilledAmount
		{
			get { return  _billedAmount; }
			set { _billedAmount = value; }
		}

		/// <summary>
		/// Gets or sets the WriteOffAmt value.
		/// </summary>
		private decimal _writeOffAmt=Decimal.Zero;
		public decimal WriteOffAmt
		{
			get { return  _writeOffAmt; }
			set { _writeOffAmt = value; }
		}

		/// <summary>
		/// Gets or sets the Department value.
		/// </summary>
		private string _department=String.Empty;
		public string Department
		{
			get { return  _department; }
			set { _department = value; }
		}

		/// <summary>
		/// Gets or sets the PrescriptionNumber value.
		/// </summary>
		private string _prescriptionNumber=String.Empty;
		public string PrescriptionNumber
		{
			get { return  _prescriptionNumber; }
			set { _prescriptionNumber = value; }
		}

		/// <summary>
		/// Gets or sets the HealthPackage value.
		/// </summary>
		private string _healthPackage=String.Empty;
		public string HealthPackage
		{
			get { return  _healthPackage; }
			set { _healthPackage = value; }
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
		/// Gets or sets the DenialCode value.
		/// </summary>
		private string _denialCode=String.Empty;
		public string DenialCode
		{
			get { return  _denialCode; }
			set { _denialCode = value; }
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
		/// Gets or sets the PreAuthApprovalDate value.
		/// </summary>
		private string _preAuthApprovalDate=String.Empty;
		public string PreAuthApprovalDate
		{
			get { return  _preAuthApprovalDate; }
			set { _preAuthApprovalDate = value; }
		}

		/// <summary>
		/// Gets or sets the HospitalCharge value.
		/// </summary>
		private decimal _hospitalCharge=Decimal.Zero;
		public decimal HospitalCharge
		{
			get { return  _hospitalCharge; }
			set { _hospitalCharge = value; }
		}

		/// <summary>
		/// Gets or sets the DoctorCharge value.
		/// </summary>
		private decimal _doctorCharge=Decimal.Zero;
		public decimal DoctorCharge
		{
			get { return  _doctorCharge; }
			set { _doctorCharge = value; }
		}


		#endregion
}
}
