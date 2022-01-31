using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class VisitClientMapping
	{
		#region Fields

		private long visitClientMappingID=0;
		private long visitID=0;
		private long clientID=0;
		private long finalBillID=0;
		private long rateID=0;
		private int orgID=0;
		private decimal preAuthAmount=Decimal.Zero;
		private string preAuthApprovalNumber=String.Empty;
		private decimal claimAmount=Decimal.Zero;
		private int claimLogic=0;
		private decimal coPayment=Decimal.Zero;
		private decimal copaymentPercent=Decimal.Zero;
		private int coPaymentLogic=0;
		private decimal nonMedicalAmount=Decimal.Zero;
		private string clientAttributes=String.Empty;
		private string isAllMedical=String.Empty;
		private string paymentStatus=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string asCreditBill=String.Empty;
		private string policyNo=String.Empty;
		private DateTime policyStartDate=DateTime.MaxValue;
		private DateTime policyEndDate=DateTime.MaxValue;
		private long onBehalfOfClientID=0;
		private long refFinalBillID=0;
		private string isActive=String.Empty;
		private string coPaymentType=String.Empty;
		private string isCopay=String.Empty;
		private long eligibleRateTypeID=0;
		private long eligibleClientID=0;
		private string isBilled=String.Empty;
		private string isRateCardChanged=String.Empty;
		private DateTime firstTestProcessedAt=DateTime.MaxValue;
		private string isCreditBill=String.Empty;
		private decimal tPAAmount=Decimal.Zero;
		private long reportClientID=0;
		private string clientInvoiceNumber=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the VisitClientMappingID value.
		/// </summary>
		public long VisitClientMappingID
		{
			get { return visitClientMappingID; }
			set { visitClientMappingID = value; }
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
		/// Gets or sets the ClientID value.
		/// </summary>
		public long ClientID
		{
			get { return clientID; }
			set { clientID = value; }
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
		/// Gets or sets the RateID value.
		/// </summary>
		public long RateID
		{
			get { return rateID; }
			set { rateID = value; }
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
		/// Gets or sets the PreAuthAmount value.
		/// </summary>
		public decimal PreAuthAmount
		{
			get { return preAuthAmount; }
			set { preAuthAmount = value; }
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
		/// Gets or sets the ClaimAmount value.
		/// </summary>
		public decimal ClaimAmount
		{
			get { return claimAmount; }
			set { claimAmount = value; }
		}

		/// <summary>
		/// Gets or sets the ClaimLogic value.
		/// </summary>
		public int ClaimLogic
		{
			get { return claimLogic; }
			set { claimLogic = value; }
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
		/// Gets or sets the NonMedicalAmount value.
		/// </summary>
		public decimal NonMedicalAmount
		{
			get { return nonMedicalAmount; }
			set { nonMedicalAmount = value; }
		}

		/// <summary>
		/// Gets or sets the ClientAttributes value.
		/// </summary>
		public string ClientAttributes
		{
			get { return clientAttributes; }
			set { clientAttributes = value; }
		}

		/// <summary>
		/// Gets or sets the IsAllMedical value.
		/// </summary>
		public string IsAllMedical
		{
			get { return isAllMedical; }
			set { isAllMedical = value; }
		}

		/// <summary>
		/// Gets or sets the PaymentStatus value.
		/// </summary>
		public string PaymentStatus
		{
			get { return paymentStatus; }
			set { paymentStatus = value; }
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
		/// Gets or sets the AsCreditBill value.
		/// </summary>
		public string AsCreditBill
		{
			get { return asCreditBill; }
			set { asCreditBill = value; }
		}

		/// <summary>
		/// Gets or sets the PolicyNo value.
		/// </summary>
		public string PolicyNo
		{
			get { return policyNo; }
			set { policyNo = value; }
		}

		/// <summary>
		/// Gets or sets the PolicyStartDate value.
		/// </summary>
		public DateTime PolicyStartDate
		{
			get { return policyStartDate; }
			set { policyStartDate = value; }
		}

		/// <summary>
		/// Gets or sets the PolicyEndDate value.
		/// </summary>
		public DateTime PolicyEndDate
		{
			get { return policyEndDate; }
			set { policyEndDate = value; }
		}

		/// <summary>
		/// Gets or sets the OnBehalfOfClientID value.
		/// </summary>
		public long OnBehalfOfClientID
		{
			get { return onBehalfOfClientID; }
			set { onBehalfOfClientID = value; }
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
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the CoPaymentType value.
		/// </summary>
		public string CoPaymentType
		{
			get { return coPaymentType; }
			set { coPaymentType = value; }
		}

		/// <summary>
		/// Gets or sets the IsCopay value.
		/// </summary>
		public string IsCopay
		{
			get { return isCopay; }
			set { isCopay = value; }
		}

		/// <summary>
		/// Gets or sets the EligibleRateTypeID value.
		/// </summary>
		public long EligibleRateTypeID
		{
			get { return eligibleRateTypeID; }
			set { eligibleRateTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the EligibleClientID value.
		/// </summary>
		public long EligibleClientID
		{
			get { return eligibleClientID; }
			set { eligibleClientID = value; }
		}

		/// <summary>
		/// Gets or sets the IsBilled value.
		/// </summary>
		public string IsBilled
		{
			get { return isBilled; }
			set { isBilled = value; }
		}

		/// <summary>
		/// Gets or sets the IsRateCardChanged value.
		/// </summary>
		public string IsRateCardChanged
		{
			get { return isRateCardChanged; }
			set { isRateCardChanged = value; }
		}

		/// <summary>
		/// Gets or sets the FirstTestProcessedAt value.
		/// </summary>
		public DateTime FirstTestProcessedAt
		{
			get { return firstTestProcessedAt; }
			set { firstTestProcessedAt = value; }
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
		/// Gets or sets the TPAAmount value.
		/// </summary>
		public decimal TPAAmount
		{
			get { return tPAAmount; }
			set { tPAAmount = value; }
		}

		/// <summary>
		/// Gets or sets the ReportClientID value.
		/// </summary>
		public long ReportClientID
		{
			get { return reportClientID; }
			set { reportClientID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientInvoiceNumber value.
		/// </summary>
		public string ClientInvoiceNumber
		{
			get { return clientInvoiceNumber; }
			set { clientInvoiceNumber = value; }
		}

		/// <summary>
		/// Gets or sets the RateName value.
		/// </summary>
		private string _rateName=String.Empty;
		public string RateName
		{
			get { return  _rateName; }
			set { _rateName = value; }
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
		/// Gets or sets the Description value.
		/// </summary>
		private string _description=String.Empty;
		public string Description
		{
			get { return  _description; }
			set { _description = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		private string _remarks=String.Empty;
		public string Remarks
		{
			get { return  _remarks; }
			set { _remarks = value; }
		}

		/// <summary>
		/// Gets or sets the TotalPreAuthAmount value.
		/// </summary>
		private decimal _totalPreAuthAmount=Decimal.Zero;
		public decimal TotalPreAuthAmount
		{
			get { return  _totalPreAuthAmount; }
			set { _totalPreAuthAmount = value; }
		}

		/// <summary>
		/// Gets or sets the ClientCode value.
		/// </summary>
		private string _clientCode=String.Empty;
		public string ClientCode
		{
			get { return  _clientCode; }
			set { _clientCode = value; }
		}

		/// <summary>
		/// Gets or sets the IsBPJSINT value.
		/// </summary>
		private string _isBPJSINT=String.Empty;
		public string IsBPJSINT
		{
			get { return  _isBPJSINT; }
			set { _isBPJSINT = value; }
		}

		/// <summary>
		/// Gets or sets the IsCPMClientAttributesCode value.
		/// </summary>
		private string _isCPMClientAttributesCode=String.Empty;
		public string IsCPMClientAttributesCode
		{
			get { return  _isCPMClientAttributesCode; }
			set { _isCPMClientAttributesCode = value; }
		}

		/// <summary>
		/// Gets or sets the CoPaymentLogicDesc value.
		/// </summary>
		private string _coPaymentLogicDesc=String.Empty;
		public string CoPaymentLogicDesc
		{
			get { return  _coPaymentLogicDesc; }
			set { _coPaymentLogicDesc = value; }
		}

		/// <summary>
		/// Gets or sets the ClaimLogicDesc value.
		/// </summary>
		private string _claimLogicDesc=String.Empty;
		public string ClaimLogicDesc
		{
			get { return  _claimLogicDesc; }
			set { _claimLogicDesc = value; }
		}

		/// <summary>
		/// Gets or sets the EligibleRateName value.
		/// </summary>
		private string _eligibleRateName=String.Empty;
		public string EligibleRateName
		{
			get { return  _eligibleRateName; }
			set { _eligibleRateName = value; }
		}

		/// <summary>
		/// Gets or sets the EligibleClientName value.
		/// </summary>
		private string _eligibleClientName=String.Empty;
		public string EligibleClientName
		{
			get { return  _eligibleClientName; }
			set { _eligibleClientName = value; }
		}

		/// <summary>
		/// Gets or sets the IsSepGenerated value.
		/// </summary>
		private string _isSepGenerated=String.Empty;
		public string IsSepGenerated
		{
			get { return  _isSepGenerated; }
			set { _isSepGenerated = value; }
		}


		#endregion
}
}
