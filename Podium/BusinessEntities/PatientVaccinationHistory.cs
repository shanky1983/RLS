using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientVaccinationHistory
	{
		#region Fields

		private long patientID=0;
		private long patientVisitID=0;
		private int vaccinationID=0;
		private string vaccinationName=String.Empty;
		private int monthOfVaccination=0;
		private int yearOfVaccination=0;
		private string vaccinationDose=String.Empty;
		private string isBooster=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
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
		/// Gets or sets the MonthOfVaccination value.
		/// </summary>
		public int MonthOfVaccination
		{
			get { return monthOfVaccination; }
			set { monthOfVaccination = value; }
		}

		/// <summary>
		/// Gets or sets the YearOfVaccination value.
		/// </summary>
		public int YearOfVaccination
		{
			get { return yearOfVaccination; }
			set { yearOfVaccination = value; }
		}

		/// <summary>
		/// Gets or sets the VaccinationDose value.
		/// </summary>
		public string VaccinationDose
		{
			get { return vaccinationDose; }
			set { vaccinationDose = value; }
		}

		/// <summary>
		/// Gets or sets the IsBooster value.
		/// </summary>
		public string IsBooster
		{
			get { return isBooster; }
			set { isBooster = value; }
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
		/// Gets or sets the MonthName value.
		/// </summary>
		private string _monthName=String.Empty;
		public string MonthName
		{
			get { return  _monthName; }
			set { _monthName = value; }
		}

		/// <summary>
		/// Gets or sets the Booster value.
		/// </summary>
		private string _booster=String.Empty;
		public string Booster
		{
			get { return  _booster; }
			set { _booster = value; }
		}


		#endregion
}
}
