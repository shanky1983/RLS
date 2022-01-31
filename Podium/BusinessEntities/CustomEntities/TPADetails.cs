using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class TPADetails
	{
		#region Fields

		private string name=String.Empty;
		private string birthDays=String.Empty;
        private string patientNumber = String.Empty;
		private string tPAName=String.Empty;
        private DateTime admissionDate = DateTime.MaxValue;
        private DateTime dischargedDT = DateTime.MaxValue;
		private string mobileNumber=String.Empty;
		private long patientID=0;
		private long patientVisitID=0;
		private decimal tPABillAmount=Decimal.Zero;
		private decimal recievedAmount=Decimal.Zero;
		private decimal grossAmount=Decimal.Zero;
		private decimal netAmount=Decimal.Zero;
		private decimal paidByTPA=Decimal.Zero;
		private decimal tDSAmount=Decimal.Zero;
		private decimal writeOff=Decimal.Zero;
		private decimal amountRefund=Decimal.Zero;
		private decimal discountAmount=Decimal.Zero;
		private decimal preAuthAmount=Decimal.Zero;
        private string refPhysicianName = String.Empty;
        private DateTime cliamForwardDate = DateTime.MaxValue;
		private string primaryConsultant=String.Empty;
        private DateTime settlementDate = DateTime.MaxValue;
        private long finalbillid = 0;
        private string billnumber = String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Gets or sets the BirthDays value.
		/// </summary>
		public string BirthDays
		{
			get { return birthDays; }
			set { birthDays = value; }
		}

		/// <summary>
		/// Gets or sets the PatientNumber value.
		/// </summary>
		public string PatientNumber
		{
			get { return patientNumber; }
			set { patientNumber = value; }
		}

		/// <summary>
		/// Gets or sets the TPAName value.
		/// </summary>
		public string TPAName
		{
			get { return tPAName; }
			set { tPAName = value; }
		}

		/// <summary>
		/// Gets or sets the AdmissionDate value.
		/// </summary>
		public DateTime AdmissionDate
		{
			get { return admissionDate; }
			set { admissionDate = value; }
		}

		/// <summary>
		/// Gets or sets the DischargedDT value.
		/// </summary>
		public DateTime DischargedDT
		{
			get { return dischargedDT; }
			set { dischargedDT = value; }
		}

		/// <summary>
		/// Gets or sets the MobileNumber value.
		/// </summary>
		public string MobileNumber
		{
			get { return mobileNumber; }
			set { mobileNumber = value; }
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
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		public long PatientVisitID
		{
			get { return patientVisitID; }
			set { patientVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the TPABillAmount value.
		/// </summary>
		public decimal TPABillAmount
		{
			get { return tPABillAmount; }
			set { tPABillAmount = value; }
		}

		/// <summary>
		/// Gets or sets the RecievedAmount value.
		/// </summary>
		public decimal RecievedAmount
		{
			get { return recievedAmount; }
			set { recievedAmount = value; }
		}

		/// <summary>
		/// Gets or sets the GrossAmount value.
		/// </summary>
		public decimal GrossAmount
		{
			get { return grossAmount; }
			set { grossAmount = value; }
		}

		/// <summary>
		/// Gets or sets the NetAmount value.
		/// </summary>
		public decimal NetAmount
		{
			get { return netAmount; }
			set { netAmount = value; }
		}

		/// <summary>
		/// Gets or sets the PaidByTPA value.
		/// </summary>
		public decimal PaidByTPA
		{
			get { return paidByTPA; }
			set { paidByTPA = value; }
		}

		/// <summary>
		/// Gets or sets the TDSAmount value.
		/// </summary>
		public decimal TDSAmount
		{
			get { return tDSAmount; }
			set { tDSAmount = value; }
		}

		/// <summary>
		/// Gets or sets the WriteOff value.
		/// </summary>
		public decimal WriteOff
		{
			get { return writeOff; }
			set { writeOff = value; }
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
		/// Gets or sets the DiscountAmount value.
		/// </summary>
		public decimal DiscountAmount
		{
			get { return discountAmount; }
			set { discountAmount = value; }
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
		/// Gets or sets the RefPhysicianName value.
		/// </summary>
		public string RefPhysicianName
		{
			get { return refPhysicianName; }
			set { refPhysicianName = value; }
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
		/// Gets or sets the PrimaryConsultant value.
		/// </summary>
		public string PrimaryConsultant
		{
			get { return primaryConsultant; }
			set { primaryConsultant = value; }
		}

		/// <summary>
		/// Gets or sets the SettlementDate value.
		/// </summary>
		public DateTime SettlementDate
		{
			get { return settlementDate; }
			set { settlementDate = value; }
		}

        public long FinalBillID
        {
            get
            {
                return finalbillid;
            }
            set
            {
                finalbillid = value;
            }
        }

        public string BillNumber
        {
            get
            {
                return billnumber;
            }
            set
            {
                billnumber = value;
            }
        }

        private DateTime billedDate = DateTime.MaxValue;
        public DateTime BilledDate
        {
            get { return billedDate; }
            set { billedDate = value; }
        }

        /// <summary>
        /// Gets or sets the PrimaryConsultant value.
        /// </summary>
        private string diagnosis = string.Empty;
        public string Diagnosis
        {
            get { return diagnosis; }
            set { diagnosis = value; }
        }

        private string treatment = string.Empty;
        public string Treatment
        {
            get { return treatment; }
            set { treatment = value; }
        }
        private string doctorName = string.Empty;
        public string DoctorName
        {
            get { return doctorName; }
            set { doctorName = value; }
        }
        private string tPAProcessStatus = string.Empty;
        public string TPAProcessStatus
        {
            get { return tPAProcessStatus; }
            set { tPAProcessStatus = value; }
        }
        private string claimStatus = string.Empty;
        public string ClaimStatus
        {
            get { return claimStatus; }
            set { claimStatus = value; }
        }

        private string _visitType = string.Empty;

        public string VisitType
        {
            get { return _visitType; }
            set { _visitType = value; }
        }
        private string _denialCode = string.Empty;
        public string DenialCode
        {
            get { return _denialCode; }
            set { _denialCode = value; }

        }

        private string raFileName = string.Empty;
        public string RaFileName
        {
            get { return raFileName; }
            set { raFileName = value; }

        }
        #endregion
    }
}
