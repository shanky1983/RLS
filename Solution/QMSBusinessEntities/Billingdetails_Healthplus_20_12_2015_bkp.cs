using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Billingdetails_Healthplus_20_12_2015_bkp
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


		#endregion
}
}
