using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientDueChart
	{
		#region Fields

		private long detailsID=0;
		private long visitID=0;
		private long patientID=0;
		private string feeType=String.Empty;
		private long feeID=0;
		private string description=String.Empty;
		private string comments=String.Empty;
		private DateTime fromDate=DateTime.MaxValue;
		private DateTime toDate=DateTime.MaxValue;
		private string status=String.Empty;
		private decimal unit=Decimal.Zero;
		private int createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private int modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private decimal amount=Decimal.Zero;
		private long packageID=0;
		private string batchNo=String.Empty;
		private DateTime expiryDate=DateTime.MaxValue;
		private string attributeDetail=String.Empty;
		private string isReimbursable=String.Empty;
		private string interimBillNo=String.Empty;
		private string isTaxable=String.Empty;
		private string serviceCode=String.Empty;
		private long refPhysicianID=0;
		private string refPhyName=String.Empty;
		private string referenceType=String.Empty;
		private string perphyName=String.Empty;
		private long perPhysicianID=0;
		private decimal returnQuantity=Decimal.Zero;
		private decimal discountAmount=Decimal.Zero;
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
		private int orgID=0;
		private int locationID=0;
		private decimal actualAmount=Decimal.Zero;
		private long rateID=0;
		private string pharmacyBillNo=String.Empty;
		private string isDiscountable=String.Empty;
		private string isSTAT=String.Empty;
		private string isOutSource=String.Empty;
		private string isNABL=String.Empty;
		private long clientID=0;
		private string discountReason=String.Empty;
		private string discOrEnhanceRemarks=String.Empty;
		private decimal eligibleAmount=Decimal.Zero;
		private decimal coSharing=Decimal.Zero;
		private string performertype=String.Empty;
		private int rateRefID=0;
		private string sellingUnit=String.Empty;
		private decimal prepareCharges=Decimal.Zero;
		private long clientFeeTypeRateCustID=0;
		private decimal discOrEnhancePercent=Decimal.Zero;
		private decimal agreedAmount=Decimal.Zero;
		private decimal coPayValue=Decimal.Zero;
		private string coPayType=String.Empty;
		private string des=String.Empty;
		private long perPhySpecialityID=0;
		private string isAdminChargeApplicable=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DetailsID value.
		/// </summary>
		public long DetailsID
		{
			get { return detailsID; }
			set { detailsID = value; }
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
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
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
		/// Gets or sets the FeeID value.
		/// </summary>
		public long FeeID
		{
			get { return feeID; }
			set { feeID = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the Unit value.
		/// </summary>
		public decimal Unit
		{
			get { return unit; }
			set { unit = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public int CreatedBy
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
		public int ModifiedBy
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
		/// Gets or sets the Amount value.
		/// </summary>
		public decimal Amount
		{
			get { return amount; }
			set { amount = value; }
		}

		/// <summary>
		/// Gets or sets the PackageID value.
		/// </summary>
		public long PackageID
		{
			get { return packageID; }
			set { packageID = value; }
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
		/// Gets or sets the AttributeDetail value.
		/// </summary>
		public string AttributeDetail
		{
			get { return attributeDetail; }
			set { attributeDetail = value; }
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
		/// Gets or sets the InterimBillNo value.
		/// </summary>
		public string InterimBillNo
		{
			get { return interimBillNo; }
			set { interimBillNo = value; }
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
		/// Gets or sets the PerphyName value.
		/// </summary>
		public string PerphyName
		{
			get { return perphyName; }
			set { perphyName = value; }
		}

		/// <summary>
		/// Gets or sets the PerPhysicianID value.
		/// </summary>
		public long PerPhysicianID
		{
			get { return perPhysicianID; }
			set { perPhysicianID = value; }
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
		/// Gets or sets the DiscountAmount value.
		/// </summary>
		public decimal DiscountAmount
		{
			get { return discountAmount; }
			set { discountAmount = value; }
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
		public int OrgID
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
		/// Gets or sets the DiscountReason value.
		/// </summary>
		public string DiscountReason
		{
			get { return discountReason; }
			set { discountReason = value; }
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
		/// Gets or sets the Performertype value.
		/// </summary>
		public string Performertype
		{
			get { return performertype; }
			set { performertype = value; }
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
		/// Gets or sets the SellingUnit value.
		/// </summary>
		public string SellingUnit
		{
			get { return sellingUnit; }
			set { sellingUnit = value; }
		}

		/// <summary>
		/// Gets or sets the PrepareCharges value.
		/// </summary>
		public decimal PrepareCharges
		{
			get { return prepareCharges; }
			set { prepareCharges = value; }
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
		/// Gets or sets the DiscOrEnhancePercent value.
		/// </summary>
		public decimal DiscOrEnhancePercent
		{
			get { return discOrEnhancePercent; }
			set { discOrEnhancePercent = value; }
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
		/// Gets or sets the Des value.
		/// </summary>
		public string Des
		{
			get { return des; }
			set { des = value; }
		}

		/// <summary>
		/// Gets or sets the PerPhySpecialityID value.
		/// </summary>
		public long PerPhySpecialityID
		{
			get { return perPhySpecialityID; }
			set { perPhySpecialityID = value; }
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
		/// Gets or sets the RoomTypeName value.
		/// </summary>
		string _roomtypename;
		public string RoomTypeName
		{
			get { return _roomtypename; }
			set { _roomtypename = value; }
		}

		/// <summary>
		/// Gets or sets the AdvanceAmount value.
		/// </summary>
		decimal _advanceamount;
		public decimal AdvanceAmount
		{
			get { return _advanceamount; }
			set { _advanceamount = value; }
		}

		/// <summary>
		/// Gets or sets the RightOff value.
		/// </summary>
		decimal _rightoff;
		public decimal RightOff
		{
			get { return _rightoff; }
			set { _rightoff = value; }
		}

		/// <summary>
		/// Gets or sets the TDS value.
		/// </summary>
		decimal _tds;
		public decimal TDS
		{
			get { return _tds; }
			set { _tds = value; }
		}

		/// <summary>
		/// Gets or sets the BankNameorCardType value.
		/// </summary>
		string _banknameorcardtype;
		public string BankNameorCardType
		{
			get { return _banknameorcardtype; }
			set { _banknameorcardtype = value; }
		}

		/// <summary>
		/// Gets or sets the ChequeorCardNumber value.
		/// </summary>
		string _chequeorcardnumber;
		public string ChequeorCardNumber
		{
			get { return _chequeorcardnumber; }
			set { _chequeorcardnumber = value; }
		}

		/// <summary>
		/// Gets or sets the TypeID value.
		/// </summary>
		int _typeid;
		public int TypeID
		{
			get { return _typeid; }
			set { _typeid = value; }
		}

		/// <summary>
		/// Gets or sets the FromTable value.
		/// </summary>
		string _fromtable;
		public string FromTable
		{
			get { return _fromtable; }
			set { _fromtable = value; }
		}

		/// <summary>
		/// Gets or sets the UserID value.
		/// </summary>
		long _userid;
		public long UserID
		{
			get { return _userid; }
			set { _userid = value; }
		}

		/// <summary>
		/// Gets or sets the SpecialityID value.
		/// </summary>
		int _specialityid;
		public int SpecialityID
		{
			get { return _specialityid; }
			set { _specialityid = value; }
		}

		/// <summary>
		/// Gets or sets the PatientNumber value.
		/// </summary>
		string _patientnumber;
		public string PatientNumber
		{
			get { return _patientnumber; }
			set { _patientnumber = value; }
		}

		/// <summary>
		/// Gets or sets the PatientName value.
		/// </summary>
		string _patientname;
		public string PatientName
		{
			get { return _patientname; }
			set { _patientname = value; }
		}

		/// <summary>
		/// Gets or sets the FinalBillID value.
		/// </summary>
		long _finalbillid;
		public long FinalBillID
		{
			get { return _finalbillid; }
			set { _finalbillid = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiptNO value.
		/// </summary>
		long _receiptno;
		public long ReceiptNO
		{
			get { return _receiptno; }
			set { _receiptno = value; }
		}

		/// <summary>
		/// Gets or sets the StockOutFlowDetailsID value.
		/// </summary>
		long _stockoutflowdetailsid;
		public long StockOutFlowDetailsID
		{
			get { return _stockoutflowdetailsid; }
			set { _stockoutflowdetailsid = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		string _type;
		public string Type
		{
			get { return _type; }
			set { _type = value; }
		}

		/// <summary>
		/// Gets or sets the DetailID value.
		/// </summary>
		long _detailid;
		public long DetailID
		{
			get { return _detailid; }
			set { _detailid = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiptNumber value.
		/// </summary>
		string _receiptnumber;
		public string ReceiptNumber
		{
			get { return _receiptnumber; }
			set { _receiptnumber = value; }
		}

		/// <summary>
		/// Gets or sets the BilledBy value.
		/// </summary>
		string _billedby;
		public string BilledBy
		{
			get { return _billedby; }
			set { _billedby = value; }
		}

		/// <summary>
		/// Gets or sets the CoPaymentAmount value.
		/// </summary>
		Decimal _copaymentamount;
		public Decimal CoPaymentAmount
		{
			get { return _copaymentamount; }
			set { _copaymentamount = value; }
		}

		/// <summary>
		/// Gets or sets the TPADiscountAmt value.
		/// </summary>
		Decimal _tpadiscountamt;
		public Decimal TPADiscountAmt
		{
			get { return _tpadiscountamt; }
			set { _tpadiscountamt = value; }
		}

		/// <summary>
		/// Gets or sets the TPASettledAmt value.
		/// </summary>
		Decimal _tpasettledamt;
		public Decimal TPASettledAmt
		{
			get { return _tpasettledamt; }
			set { _tpasettledamt = value; }
		}

		/// <summary>
		/// Gets or sets the TPADisallowedAmt value.
		/// </summary>
		Decimal _tpadisallowedamt;
		public Decimal TPADisallowedAmt
		{
			get { return _tpadisallowedamt; }
			set { _tpadisallowedamt = value; }
		}

		/// <summary>
		/// Gets or sets the TPARemarks value.
		/// </summary>
		string _tparemarks;
		public string TPARemarks
		{
			get { return _tparemarks; }
			set { _tparemarks = value; }
		}

		/// <summary>
		/// Gets or sets the TPAApproverID value.
		/// </summary>
		long _tpaapproverid;
		public long TPAApproverID
		{
			get { return _tpaapproverid; }
			set { _tpaapproverid = value; }
		}

		/// <summary>
		/// Gets or sets the TPAApproverName value.
		/// </summary>
		string _tpaapprovername;
		public string TPAApproverName
		{
			get { return _tpaapprovername; }
			set { _tpaapprovername = value; }
		}

		/// <summary>
		/// Gets or sets the TPAApprovedDate value.
		/// </summary>
		DateTime _tpaapproveddate;
		public DateTime TPAApprovedDate
		{
			get { return _tpaapproveddate; }
			set { _tpaapproveddate = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiptInterimNo value.
		/// </summary>
		string _receiptinterimno;
		public string ReceiptInterimNo
		{
			get { return _receiptinterimno; }
			set { _receiptinterimno = value; }
		}

		/// <summary>
		/// Gets or sets the TPAWriteOffApprover value.
		/// </summary>
		long _tpawriteoffapprover;
		public long TPAWriteOffApprover
		{
			get { return _tpawriteoffapprover; }
			set { _tpawriteoffapprover = value; }
		}

		/// <summary>
		/// Gets or sets the PatientIdentifyID value.
		/// </summary>
		string _patientidentifyid;
		public string PatientIdentifyID
		{
			get { return _patientidentifyid; }
			set { _patientidentifyid = value; }
		}

		/// <summary>
		/// Gets or sets the BaseRateID value.
		/// </summary>
		long _baserateid;
		public long BaseRateID
		{
			get { return _baserateid; }
			set { _baserateid = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountPolicyID value.
		/// </summary>
		long _discountpolicyid;
		public long DiscountPolicyID
		{
			get { return _discountpolicyid; }
			set { _discountpolicyid = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountCategoryCode value.
		/// </summary>
		string _discountcategorycode;
		public string DiscountCategoryCode
		{
			get { return _discountcategorycode; }
			set { _discountcategorycode = value; }
		}

		/// <summary>
		/// Gets or sets the TatDate value.
		/// </summary>
		DateTime _tatdate;
		public DateTime TatDate
		{
			get { return _tatdate; }
			set { _tatdate = value; }
		}

		/// <summary>
		/// Gets or sets the ReportDeliveryDate value.
		/// </summary>
		DateTime _reportdeliverydate;
		public DateTime ReportDeliveryDate
		{
			get { return _reportdeliverydate; }
			set { _reportdeliverydate = value; }
		}


		#endregion
}
}
