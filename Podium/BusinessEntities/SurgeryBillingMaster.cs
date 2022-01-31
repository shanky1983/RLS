using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class SurgeryBillingMaster
	{
		#region Fields

		private long surgeryBillingID=0;
		private long patientVisitID=0;
		private long patientID=0;
		private int orgID=0;
		private long surgeryID=0;
		private string treatmentName=String.Empty;
		private decimal surgicalFee=Decimal.Zero;
		private long chiefSurgeonID=0;
		private string chiefSurgeonName=String.Empty;
		private decimal chiefSurgeonFee=Decimal.Zero;
		private decimal oTCharges=Decimal.Zero;
		private decimal roomCharges=Decimal.Zero;
		private decimal consumables=Decimal.Zero;
		private decimal prosthesisFee=Decimal.Zero;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string isCreditBill=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SurgeryBillingID value.
		/// </summary>
		public long SurgeryBillingID
		{
			get { return surgeryBillingID; }
			set { surgeryBillingID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		public long PatientVisitID
		{
			get { return patientVisitID; }
			set { patientVisitID = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the SurgeryID value.
		/// </summary>
		public long SurgeryID
		{
			get { return surgeryID; }
			set { surgeryID = value; }
		}

		/// <summary>
		/// Gets or sets the TreatmentName value.
		/// </summary>
		public string TreatmentName
		{
			get { return treatmentName; }
			set { treatmentName = value; }
		}

		/// <summary>
		/// Gets or sets the SurgicalFee value.
		/// </summary>
		public decimal SurgicalFee
		{
			get { return surgicalFee; }
			set { surgicalFee = value; }
		}

		/// <summary>
		/// Gets or sets the ChiefSurgeonID value.
		/// </summary>
		public long ChiefSurgeonID
		{
			get { return chiefSurgeonID; }
			set { chiefSurgeonID = value; }
		}

		/// <summary>
		/// Gets or sets the ChiefSurgeonName value.
		/// </summary>
		public string ChiefSurgeonName
		{
			get { return chiefSurgeonName; }
			set { chiefSurgeonName = value; }
		}

		/// <summary>
		/// Gets or sets the ChiefSurgeonFee value.
		/// </summary>
		public decimal ChiefSurgeonFee
		{
			get { return chiefSurgeonFee; }
			set { chiefSurgeonFee = value; }
		}

		/// <summary>
		/// Gets or sets the OTCharges value.
		/// </summary>
		public decimal OTCharges
		{
			get { return oTCharges; }
			set { oTCharges = value; }
		}

		/// <summary>
		/// Gets or sets the RoomCharges value.
		/// </summary>
		public decimal RoomCharges
		{
			get { return roomCharges; }
			set { roomCharges = value; }
		}

		/// <summary>
		/// Gets or sets the Consumables value.
		/// </summary>
		public decimal Consumables
		{
			get { return consumables; }
			set { consumables = value; }
		}

		/// <summary>
		/// Gets or sets the ProsthesisFee value.
		/// </summary>
		public decimal ProsthesisFee
		{
			get { return prosthesisFee; }
			set { prosthesisFee = value; }
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
		/// Gets or sets the IsCreditBill value.
		/// </summary>
		public string IsCreditBill
		{
			get { return isCreditBill; }
			set { isCreditBill = value; }
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
		/// Gets or sets the Age value.
		/// </summary>
		private string _age=String.Empty;
		public string Age
		{
			get { return  _age; }
			set { _age = value; }
		}

		/// <summary>
		/// Gets or sets the SEX value.
		/// </summary>
		private string _sEX=String.Empty;
		public string SEX
		{
			get { return  _sEX; }
			set { _sEX = value; }
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
		/// Gets or sets the AdmissionDate value.
		/// </summary>
		private DateTime _admissionDate=DateTime.MaxValue;
		public DateTime AdmissionDate
		{
			get { return  _admissionDate; }
			set { _admissionDate = value; }
		}

		/// <summary>
		/// Gets or sets the DischargedDT value.
		/// </summary>
		private DateTime _dischargedDT=DateTime.MaxValue;
		public DateTime DischargedDT
		{
			get { return  _dischargedDT; }
			set { _dischargedDT = value; }
		}

		/// <summary>
		/// Gets or sets the IPNumber value.
		/// </summary>
		private string _iPNumber=String.Empty;
		public string IPNumber
		{
			get { return  _iPNumber; }
			set { _iPNumber = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountPercent value.
		/// </summary>
		private decimal _discountPercent=Decimal.Zero;
		public decimal DiscountPercent
		{
			get { return  _discountPercent; }
			set { _discountPercent = value; }
		}

		/// <summary>
		/// Gets or sets the DiscOrEnhanceType value.
		/// </summary>
		private string _discOrEnhanceType=String.Empty;
		public string DiscOrEnhanceType
		{
			get { return  _discOrEnhanceType; }
			set { _discOrEnhanceType = value; }
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
		/// Gets or sets the PatientNumber value.
		/// </summary>
		private string _patientNumber=String.Empty;
		public string PatientNumber
		{
			get { return  _patientNumber; }
			set { _patientNumber = value; }
		}

		/// <summary>
		/// Gets or sets the EligibleAmount value.
		/// </summary>
		private decimal _eligibleAmount=Decimal.Zero;
		public decimal EligibleAmount
		{
			get { return  _eligibleAmount; }
			set { _eligibleAmount = value; }
		}

		/// <summary>
		/// Gets or sets the ClientFeeTypeRateCustID value.
		/// </summary>
		private long _clientFeeTypeRateCustID=0;
		public long ClientFeeTypeRateCustID
		{
			get { return  _clientFeeTypeRateCustID; }
			set { _clientFeeTypeRateCustID = value; }
		}

		/// <summary>
		/// Gets or sets the DiscOrEnhanceRemarks value.
		/// </summary>
		private string _discOrEnhanceRemarks=String.Empty;
		public string DiscOrEnhanceRemarks
		{
			get { return  _discOrEnhanceRemarks; }
			set { _discOrEnhanceRemarks = value; }
		}

		/// <summary>
		/// Gets or sets the DiscOrEnhancePercent value.
		/// </summary>
		private decimal _discOrEnhancePercent=Decimal.Zero;
		public decimal DiscOrEnhancePercent
		{
			get { return  _discOrEnhancePercent; }
			set { _discOrEnhancePercent = value; }
		}

		/// <summary>
		/// Gets or sets the AssistantPhyshician value.
		/// </summary>
		private string _assistantPhyshician=String.Empty;
		public string AssistantPhyshician
		{
			get { return  _assistantPhyshician; }
			set { _assistantPhyshician = value; }
		}

		/// <summary>
		/// Gets or sets the Anesthetist value.
		/// </summary>
		private string _anesthetist=String.Empty;
		public string Anesthetist
		{
			get { return  _anesthetist; }
			set { _anesthetist = value; }
		}

		/// <summary>
		/// Gets or sets the Instrumenration value.
		/// </summary>
		private string _instrumenration=String.Empty;
		public string Instrumenration
		{
			get { return  _instrumenration; }
			set { _instrumenration = value; }
		}

		/// <summary>
		/// Gets or sets the Nures value.
		/// </summary>
		private string _nures=String.Empty;
		public string Nures
		{
			get { return  _nures; }
			set { _nures = value; }
		}

		/// <summary>
		/// Gets or sets the ProthsLst value.
		/// </summary>
		private string _prothsLst=String.Empty;
		public string ProthsLst
		{
			get { return  _prothsLst; }
			set { _prothsLst = value; }
		}

		/// <summary>
		/// Gets or sets the SurgeryBillingDetails value.
		/// </summary>
		private string _surgeryBillingDetails=String.Empty;
		public string SurgeryBillingDetails
		{
			get { return  _surgeryBillingDetails; }
			set { _surgeryBillingDetails = value; }
		}

		/// <summary>
		/// Gets or sets the TotalBilled value.
		/// </summary>
		private decimal _totalBilled=Decimal.Zero;
		public decimal TotalBilled
		{
			get { return  _totalBilled; }
			set { _totalBilled = value; }
		}

		/// <summary>
		/// Gets or sets the TreatmentMasterID value.
		/// </summary>
		private int _treatmentMasterID=0;
		public int TreatmentMasterID
		{
			get { return  _treatmentMasterID; }
			set { _treatmentMasterID = value; }
		}

		/// <summary>
		/// Gets or sets the InterimBillNo value.
		/// </summary>
		private string _interimBillNo=String.Empty;
		public string InterimBillNo
		{
			get { return  _interimBillNo; }
			set { _interimBillNo = value; }
		}

		/// <summary>
		/// Gets or sets the ProsthesisName value.
		/// </summary>
		private string _prosthesisName=String.Empty;
		public string ProsthesisName
		{
			get { return  _prosthesisName; }
			set { _prosthesisName = value; }
		}

		/// <summary>
		/// Gets or sets the ProsthesisID value.
		/// </summary>
		private long _prosthesisID=0;
		public long ProsthesisID
		{
			get { return  _prosthesisID; }
			set { _prosthesisID = value; }
		}


		#endregion
}
}
