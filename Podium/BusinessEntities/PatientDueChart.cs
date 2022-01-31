using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
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
		private long productReceivedDetailsID=0;
		private long receivedUniqueNumber=0;
		private decimal taxAmount=Decimal.Zero;
		private DateTime tatreferencedatetime=DateTime.MaxValue;
		//private byte tatreferencedatebase=0x00; -- MARIYA TAT Integration
        private int tatreferencedatebase = 0;
		private short logistictimeinmins=0;
		private DateTime tatsamplereceiptdatetime=DateTime.MaxValue;
		private int processingtimeinmins=0;
		private DateTime tatprocessstartdatetime=DateTime.MaxValue;
		//private TimeSpan labendtime=TimeSpan.MinValue; -- TAT Integration 
        //private TimeSpan earlyreporttime=TimeSpan.MinValue; -- TAT Integration 
        private string labendtime= string.Empty;
        private string earlyreporttime = string.Empty;
		private DateTime customerCommittedTAT=DateTime.MaxValue;
		private long itemCurrencyID=0;

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
        //public byte Tatreferencedatebase
        //{
        //    get { return tatreferencedatebase; }
        //    set { tatreferencedatebase = value; }
        //}
        public int  Tatreferencedatebase
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
        //public TimeSpan Labendtime
        //{
        //    get { return labendtime; }
        //    set { labendtime = value; }
        //}

        public string Labendtime
        {
            get { return labendtime; }
            set { labendtime = value; }
        }

		/// <summary>
		/// Gets or sets the Earlyreporttime value.
		/// </summary>
        //public TimeSpan Earlyreporttime
        //{
        //    get { return earlyreporttime; }
        //    set { earlyreporttime = value; }
        //}
        public string Earlyreporttime
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
		/// Gets or sets the ItemCurrencyID value.
		/// </summary>
		public long ItemCurrencyID
		{
			get { return itemCurrencyID; }
			set { itemCurrencyID = value; }
		}

		/// <summary>
		/// Gets or sets the RoomTypeName value.
		/// </summary>
		private string _roomTypeName=String.Empty;
		public string RoomTypeName
		{
			get { return  _roomTypeName; }
			set { _roomTypeName = value; }
		}

		/// <summary>
		/// Gets or sets the AdvanceAmount value.
		/// </summary>
		private decimal _advanceAmount=Decimal.Zero;
		public decimal AdvanceAmount
		{
			get { return  _advanceAmount; }
			set { _advanceAmount = value; }
		}

		/// <summary>
		/// Gets or sets the RightOff value.
		/// </summary>
		private decimal _rightOff=Decimal.Zero;
		public decimal RightOff
		{
			get { return  _rightOff; }
			set { _rightOff = value; }
		}

		/// <summary>
		/// Gets or sets the TDS value.
		/// </summary>
		private decimal _tDS=Decimal.Zero;
		public decimal TDS
		{
			get { return  _tDS; }
			set { _tDS = value; }
		}

		/// <summary>
		/// Gets or sets the BankNameorCardType value.
		/// </summary>
		private string _bankNameorCardType=String.Empty;
		public string BankNameorCardType
		{
			get { return  _bankNameorCardType; }
			set { _bankNameorCardType = value; }
		}

		/// <summary>
		/// Gets or sets the ChequeorCardNumber value.
		/// </summary>
		private string _chequeorCardNumber=String.Empty;
		public string ChequeorCardNumber
		{
			get { return  _chequeorCardNumber; }
			set { _chequeorCardNumber = value; }
		}

		/// <summary>
		/// Gets or sets the TypeID value.
		/// </summary>
		private int _typeID=0;
		public int TypeID
		{
			get { return  _typeID; }
			set { _typeID = value; }
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
		/// Gets or sets the UserID value.
		/// </summary>
		private long _userID=0;
		public long UserID
		{
			get { return  _userID; }
			set { _userID = value; }
		}

		/// <summary>
		/// Gets or sets the SpecialityID value.
		/// </summary>
		private int _specialityID=0;
		public int SpecialityID
		{
			get { return  _specialityID; }
			set { _specialityID = value; }
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
		/// Gets or sets the PatientName value.
		/// </summary>
		private string _patientName=String.Empty;
		public string PatientName
		{
			get { return  _patientName; }
			set { _patientName = value; }
		}

		/// <summary>
		/// Gets or sets the FinalBillID value.
		/// </summary>
		private long _finalBillID=0;
		public long FinalBillID
		{
			get { return  _finalBillID; }
			set { _finalBillID = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiptNO value.
		/// </summary>
		private long _receiptNO=0;
		public long ReceiptNO
		{
			get { return  _receiptNO; }
			set { _receiptNO = value; }
		}

		/// <summary>
		/// Gets or sets the StockOutFlowDetailsID value.
		/// </summary>
		private long _stockOutFlowDetailsID=0;
		public long StockOutFlowDetailsID
		{
			get { return  _stockOutFlowDetailsID; }
			set { _stockOutFlowDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		private string _type=String.Empty;
		public string Type
		{
			get { return  _type; }
			set { _type = value; }
		}

		/// <summary>
		/// Gets or sets the DetailID value.
		/// </summary>
		private long _detailID=0;
		public long DetailID
		{
			get { return  _detailID; }
			set { _detailID = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiptNumber value.
		/// </summary>
		private string _receiptNumber=String.Empty;
		public string ReceiptNumber
		{
			get { return  _receiptNumber; }
			set { _receiptNumber = value; }
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
		/// Gets or sets the CoPaymentAmount value.
		/// </summary>
		private Decimal _coPaymentAmount=Decimal.Zero;
		public Decimal CoPaymentAmount
		{
			get { return  _coPaymentAmount; }
			set { _coPaymentAmount = value; }
		}

		/// <summary>
		/// Gets or sets the TPADiscountAmt value.
		/// </summary>
		private Decimal _tPADiscountAmt=Decimal.Zero;
		public Decimal TPADiscountAmt
		{
			get { return  _tPADiscountAmt; }
			set { _tPADiscountAmt = value; }
		}

		/// <summary>
		/// Gets or sets the TPASettledAmt value.
		/// </summary>
		private Decimal _tPASettledAmt=Decimal.Zero;
		public Decimal TPASettledAmt
		{
			get { return  _tPASettledAmt; }
			set { _tPASettledAmt = value; }
		}

		/// <summary>
		/// Gets or sets the TPADisallowedAmt value.
		/// </summary>
		private Decimal _tPADisallowedAmt=Decimal.Zero;
		public Decimal TPADisallowedAmt
		{
			get { return  _tPADisallowedAmt; }
			set { _tPADisallowedAmt = value; }
		}

		/// <summary>
		/// Gets or sets the TPARemarks value.
		/// </summary>
		private string _tPARemarks=String.Empty;
		public string TPARemarks
		{
			get { return  _tPARemarks; }
			set { _tPARemarks = value; }
		}

		/// <summary>
		/// Gets or sets the TPAApproverID value.
		/// </summary>
		private long _tPAApproverID=0;
		public long TPAApproverID
		{
			get { return  _tPAApproverID; }
			set { _tPAApproverID = value; }
		}

		/// <summary>
		/// Gets or sets the TPAApproverName value.
		/// </summary>
		private string _tPAApproverName=String.Empty;
		public string TPAApproverName
		{
			get { return  _tPAApproverName; }
			set { _tPAApproverName = value; }
		}

		/// <summary>
		/// Gets or sets the TPAApprovedDate value.
		/// </summary>
		private DateTime _tPAApprovedDate=DateTime.MaxValue;
		public DateTime TPAApprovedDate
		{
			get { return  _tPAApprovedDate; }
			set { _tPAApprovedDate = value; }
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
		/// Gets or sets the TPAWriteOffApprover value.
		/// </summary>
		private long _tPAWriteOffApprover=0;
		public long TPAWriteOffApprover
		{
			get { return  _tPAWriteOffApprover; }
			set { _tPAWriteOffApprover = value; }
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
		/// Gets or sets the BaseRateID value.
		/// </summary>
		private long _baseRateID=0;
		public long BaseRateID
		{
			get { return  _baseRateID; }
			set { _baseRateID = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountPolicyID value.
		/// </summary>
		private long _discountPolicyID=0;
		public long DiscountPolicyID
		{
			get { return  _discountPolicyID; }
			set { _discountPolicyID = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountCategoryCode value.
		/// </summary>
		private string _discountCategoryCode=String.Empty;
		public string DiscountCategoryCode
		{
			get { return  _discountCategoryCode; }
			set { _discountCategoryCode = value; }
		}

		/// <summary>
		/// Gets or sets the TatDate value.
		/// </summary>
		private DateTime _tatDate=DateTime.MaxValue;
		public DateTime TatDate
		{
			get { return  _tatDate; }
			set { _tatDate = value; }
		}

		/// <summary>
		/// Gets or sets the BaseTestcalculationAmount value.
		/// </summary>
		private decimal _baseTestcalculationAmount=Decimal.Zero;
		public decimal BaseTestcalculationAmount
		{
			get { return  _baseTestcalculationAmount; }
			set { _baseTestcalculationAmount = value; }
		}

		/// <summary>
		/// Gets or sets the MaxTestDisPercentage value.
		/// </summary>
		private decimal _maxTestDisPercentage=Decimal.Zero;
		public decimal MaxTestDisPercentage
		{
			get { return  _maxTestDisPercentage; }
			set { _maxTestDisPercentage = value; }
		}

		/// <summary>
		/// Gets or sets the MaxTestDisAmount value.
		/// </summary>
		private decimal _maxTestDisAmount=Decimal.Zero;
		public decimal MaxTestDisAmount
		{
			get { return  _maxTestDisAmount; }
			set { _maxTestDisAmount = value; }
		}

		/// <summary>
		/// Gets or sets the IsRedeem value.
		/// </summary>
		private string _isRedeem=String.Empty;
		public string IsRedeem
		{
			get { return  _isRedeem; }
			set { _isRedeem = value; }
		}

		/// <summary>
		/// Gets or sets the RedeemAmount value.
		/// </summary>
		private decimal _redeemAmount=Decimal.Zero;
		public decimal RedeemAmount
		{
			get { return  _redeemAmount; }
			set { _redeemAmount = value; }
		}

		/// <summary>
		/// Gets or sets the RedeemPoints value.
		/// </summary>
		private decimal _redeemPoints=Decimal.Zero;
		public decimal RedeemPoints
		{
			get { return  _redeemPoints; }
			set { _redeemPoints = value; }
		}

		/// <summary>
		/// Gets or sets the ReportDeliveryDate value.
		/// </summary>
		private DateTime _reportDeliveryDate=DateTime.MaxValue;
		public DateTime ReportDeliveryDate
		{
			get { return  _reportDeliveryDate; }
			set { _reportDeliveryDate = value; }
		}

		/// <summary>
		/// Gets or sets the PatientAmount value.
		/// </summary>
		private Decimal _patientAmount=Decimal.Zero;
		public Decimal PatientAmount
		{
			get { return  _patientAmount; }
			set { _patientAmount = value; }
		}

		/// <summary>
		/// Gets or sets the InsuranceAmount value.
		/// </summary>
		private Decimal _insuranceAmount=Decimal.Zero;
		public Decimal InsuranceAmount
		{
			get { return  _insuranceAmount; }
			set { _insuranceAmount = value; }
		}

		/// <summary>
		/// Gets or sets the ReferralID value.
		/// </summary>
		private int _referralID=0;
		public int ReferralID
		{
			get { return  _referralID; }
			set { _referralID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferralName value.
		/// </summary>
		private string _referralName=String.Empty;
		public string ReferralName
		{
			get { return  _referralName; }
			set { _referralName = value; }
		}

		/// <summary>
		/// Gets or sets the IsLineItem value.
		/// </summary>
		private int _isLineItem=0;
		public int IsLineItem
		{
			get { return  _isLineItem; }
			set { _isLineItem = value; }
		}

		/// <summary>
		/// Gets or sets the ItemCopay value.
		/// </summary>
		private Decimal _itemCopay=Decimal.Zero;
		public Decimal ItemCopay
		{
			get { return  _itemCopay; }
			set { _itemCopay = value; }
		}

		/// <summary>
		/// Gets or sets the ItemCoPayType value.
		/// </summary>
		private string _itemCoPayType=String.Empty;
		public string ItemCoPayType
		{
			get { return  _itemCoPayType; }
			set { _itemCoPayType = value; }
		}

		/// <summary>
		/// Gets or sets the NoofSittings value.
		/// </summary>
		private int _noofSittings=0;
		public int NoofSittings
		{
			get { return  _noofSittings; }
			set { _noofSittings = value; }
		}

		/// <summary>
		/// Gets or sets the ReferralType value.
		/// </summary>
		private string _referralType=String.Empty;
		public string ReferralType
		{
			get { return  _referralType; }
			set { _referralType = value; }
		}

		/// <summary>
		/// Gets or sets the ItemCurrencyId value.
		/// </summary>
		private long _itemCurrencyId=0;
		public long ItemCurrencyId
		{
			get { return  _itemCurrencyId; }
			set { _itemCurrencyId = value; }
		}


		#endregion
}
}
