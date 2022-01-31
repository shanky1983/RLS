using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientVitals
	{
		#region Fields

		private long patientVitalsID=0;
		private long patientID=0;
		private long patientVisitID=0;
		private int vitalsID=0;
		private decimal vitalsValue=Decimal.Zero;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int uOMID=0;
		private int vitalsSetID=0;
		private string vitalsType=String.Empty;
		private long vitalsTypeID=0;
		private DateTime enterDate=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientVitalsID value.
		/// </summary>
		public long PatientVitalsID
		{
			get { return patientVitalsID; }
			set { patientVitalsID = value; }
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
		/// Gets or sets the VitalsID value.
		/// </summary>
		public int VitalsID
		{
			get { return vitalsID; }
			set { vitalsID = value; }
		}

		/// <summary>
		/// Gets or sets the VitalsValue value.
		/// </summary>
		public decimal VitalsValue
		{
			get { return vitalsValue; }
			set { vitalsValue = value; }
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
		/// Gets or sets the UOMID value.
		/// </summary>
		public int UOMID
		{
			get { return uOMID; }
			set { uOMID = value; }
		}

		/// <summary>
		/// Gets or sets the VitalsSetID value.
		/// </summary>
		public int VitalsSetID
		{
			get { return vitalsSetID; }
			set { vitalsSetID = value; }
		}

		/// <summary>
		/// Gets or sets the VitalsType value.
		/// </summary>
		public string VitalsType
		{
			get { return vitalsType; }
			set { vitalsType = value; }
		}

		/// <summary>
		/// Gets or sets the VitalsTypeID value.
		/// </summary>
		public long VitalsTypeID
		{
			get { return vitalsTypeID; }
			set { vitalsTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the EnterDate value.
		/// </summary>
		public DateTime EnterDate
		{
			get { return enterDate; }
			set { enterDate = value; }
		}

		/// <summary>
		/// Gets or sets the ConditionID value.
		/// </summary>
		private int _conditionID=0;
		public int ConditionID
		{
			get { return  _conditionID; }
			set { _conditionID = value; }
		}

		/// <summary>
		/// Gets or sets the NurseNotes value.
		/// </summary>
		private string _nurseNotes=String.Empty;
		public string NurseNotes
		{
			get { return  _nurseNotes; }
			set { _nurseNotes = value; }
		}

		/// <summary>
		/// Gets or sets the VitalsName value.
		/// </summary>
		private string _vitalsName=String.Empty;
		public string VitalsName
		{
			get { return  _vitalsName; }
			set { _vitalsName = value; }
		}

		/// <summary>
		/// Gets or sets the VitalsDescription value.
		/// </summary>
		private string _vitalsDescription=String.Empty;
		public string VitalsDescription
		{
			get { return  _vitalsDescription; }
			set { _vitalsDescription = value; }
		}

		/// <summary>
		/// Gets or sets the UOMCode value.
		/// </summary>
		private string _uOMCode=String.Empty;
		public string UOMCode
		{
			get { return  _uOMCode; }
			set { _uOMCode = value; }
		}

		/// <summary>
		/// Gets or sets the UOMDescription value.
		/// </summary>
		private string _uOMDescription=String.Empty;
		public string UOMDescription
		{
			get { return  _uOMDescription; }
			set { _uOMDescription = value; }
		}


		#endregion
}
}
