using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientBabyVaccination
	{
		#region Fields

		private long patientVisitID=0;
		private long patientID=0;
		private int vaccinationID=0;
		private string vaccinationName=String.Empty;
		private string immunizedPeriod=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string paymentstatus=String.Empty;

		#endregion

		#region Properties
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
		/// Gets or sets the VaccinationID value.
		/// </summary>
		public int VaccinationID
		{
			get { return vaccinationID; }
			set { vaccinationID = value; }
		}

		/// <summary>
		/// Gets or sets the VaccinationName value.
		/// </summary>
		public string VaccinationName
		{
			get { return vaccinationName; }
			set { vaccinationName = value; }
		}

		/// <summary>
		/// Gets or sets the ImmunizedPeriod value.
		/// </summary>
		public string ImmunizedPeriod
		{
			get { return immunizedPeriod; }
			set { immunizedPeriod = value; }
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
		/// Gets or sets the Paymentstatus value.
		/// </summary>
		public string Paymentstatus
		{
			get { return paymentstatus; }
			set { paymentstatus = value; }
		}


		#endregion
}
}
