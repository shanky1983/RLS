using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class FinalBill_HIST
	{
		#region Fields

		private long finalBillID_HISTID=0;
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
		private long clientID=0;
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
		private decimal preAuthAmount=Decimal.Zero;
		private decimal tPAAmount=Decimal.Zero;
		private decimal roundOff=Decimal.Zero;
		private decimal previousBill=Decimal.Zero;
		private decimal coPayment=Decimal.Zero;
		private decimal nonMedicalAmount=Decimal.Zero;
		private decimal excessAmtRecd=Decimal.Zero;
		private DateTime cliamForwardDate=DateTime.MaxValue;
		private int rateID=0;
		private long tPAID=0;
		private decimal tpaDue=Decimal.Zero;
		private decimal patientDue=Decimal.Zero;
		private string isDiscountPercentage=String.Empty;
		private decimal copaymentPercent=Decimal.Zero;
		private int coPaymentLogic=0;
		private long claimLogic=0;
		private decimal tPADiscountAmt=Decimal.Zero;
		private decimal tPASettledAmt=Decimal.Zero;
		private decimal tPADisallowedAmt=Decimal.Zero;
		private string tPARemarks=String.Empty;
		private long tPAApproverID=0;
		private string tPAApproverName=String.Empty;
		private DateTime tPAApprovedDate=DateTime.MaxValue;
		private long tPAWriteOffApprover=0;
		private string preAuthApprovalNumber=String.Empty;
		private DateTime billDate=DateTime.MaxValue;
		private string versionNo=String.Empty;
		private string isFreeOfCost=String.Empty;
		private long discountApprovedBy=0;
		private long clientMappingDetailsID=0;
		private long createdRole=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FinalBillID_HISTID value.
		/// </summary>
		public long FinalBillID_HISTID
		{
			get { return finalBillID_HISTID; }
			set { finalBillID_HISTID = value; }
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
		/// Gets or sets the ClientID value.
		/// </summary>
		public long ClientID
		{
			get { return clientID; }
			set { clientID = value; }
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
		/// Gets or sets the PreAuthAmount value.
		/// </summary>
		public decimal PreAuthAmount
		{
			get { return preAuthAmount; }
			set { preAuthAmount = value; }
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
		/// Gets or sets the CoPayment value.
		/// </summary>
		public decimal CoPayment
		{
			get { return coPayment; }
			set { coPayment = value; }
		}

		/// <summary>
		/// Gets or sets the NonMedicalAmount value.
		/// </summary>
		public decimal NonMedicalAmount
		{
			get { return nonMedicalAmount; }
			set { nonMedicalAmount = value; }
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
		/// Gets or sets the CliamForwardDate value.
		/// </summary>
		public DateTime CliamForwardDate
		{
			get { return cliamForwardDate; }
			set { cliamForwardDate = value; }
		}

		/// <summary>
		/// Gets or sets the RateID value.
		/// </summary>
		public int RateID
		{
			get { return rateID; }
			set { rateID = value; }
		}

		/// <summary>
		/// Gets or sets the TPAID value.
		/// </summary>
		public long TPAID
		{
			get { return tPAID; }
			set { tPAID = value; }
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
		/// Gets or sets the IsDiscountPercentage value.
		/// </summary>
		public string IsDiscountPercentage
		{
			get { return isDiscountPercentage; }
			set { isDiscountPercentage = value; }
		}

		/// <summary>
		/// Gets or sets the CopaymentPercent value.
		/// </summary>
		public decimal CopaymentPercent
		{
			get { return copaymentPercent; }
			set { copaymentPercent = value; }
		}

		/// <summary>
		/// Gets or sets the CoPaymentLogic value.
		/// </summary>
		public int CoPaymentLogic
		{
			get { return coPaymentLogic; }
			set { coPaymentLogic = value; }
		}

		/// <summary>
		/// Gets or sets the ClaimLogic value.
		/// </summary>
		public long ClaimLogic
		{
			get { return claimLogic; }
			set { claimLogic = value; }
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
		/// Gets or sets the PreAuthApprovalNumber value.
		/// </summary>
		public string PreAuthApprovalNumber
		{
			get { return preAuthApprovalNumber; }
			set { preAuthApprovalNumber = value; }
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
		/// Gets or sets the ClientMappingDetailsID value.
		/// </summary>
		public long ClientMappingDetailsID
		{
			get { return clientMappingDetailsID; }
			set { clientMappingDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedRole value.
		/// </summary>
		public long CreatedRole
		{
			get { return createdRole; }
			set { createdRole = value; }
		}


		#endregion
}
}
