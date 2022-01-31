using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
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
		string _patientname;
		public string PatientName
		{
			get { return _patientname; }
			set { _patientname = value; }
		}

		/// <summary>
		/// Gets or sets the Age value.
		/// </summary>
		string _age;
		public string Age
		{
			get { return _age; }
			set { _age = value; }
		}

		/// <summary>
		/// Gets or sets the SEX value.
		/// </summary>
		string _sex;
		public string SEX
		{
			get { return _sex; }
			set { _sex = value; }
		}

		/// <summary>
		/// Gets or sets the Address value.
		/// </summary>
		string _address;
		public string Address
		{
			get { return _address; }
			set { _address = value; }
		}

		/// <summary>
		/// Gets or sets the AdmissionDate value.
		/// </summary>
		DateTime _admissiondate;
		public DateTime AdmissionDate
		{
			get { return _admissiondate; }
			set { _admissiondate = value; }
		}

		/// <summary>
		/// Gets or sets the DischargedDT value.
		/// </summary>
		DateTime _dischargeddt;
		public DateTime DischargedDT
		{
			get { return _dischargeddt; }
			set { _dischargeddt = value; }
		}

		/// <summary>
		/// Gets or sets the IPNumber value.
		/// </summary>
		string _ipnumber;
		public string IPNumber
		{
			get { return _ipnumber; }
			set { _ipnumber = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountPercent value.
		/// </summary>
		decimal _discountpercent;
		public decimal DiscountPercent
		{
			get { return _discountpercent; }
			set { _discountpercent = value; }
		}

		/// <summary>
		/// Gets or sets the DiscOrEnhanceType value.
		/// </summary>
		string _discorenhancetype;
		public string DiscOrEnhanceType
		{
			get { return _discorenhancetype; }
			set { _discorenhancetype = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		string _remarks;
		public string Remarks
		{
			get { return _remarks; }
			set { _remarks = value; }
		}


		#endregion
}
}
