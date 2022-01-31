using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientUltraSoundData
	{
		#region Fields

		private long patientID=0;
		private long patientVisitID=0;
		private int gestationalWeek=0;
		private int gestationalDays=0;
		private long placentalPositionID=0;
		private string placentalPositionName=String.Empty;
		private DateTime dateOfUltraSound=DateTime.MaxValue;
		private int multipleGestation=0;
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
		/// Gets or sets the GestationalWeek value.
		/// </summary>
		public int GestationalWeek
		{
			get { return gestationalWeek; }
			set { gestationalWeek = value; }
		}

		/// <summary>
		/// Gets or sets the GestationalDays value.
		/// </summary>
		public int GestationalDays
		{
			get { return gestationalDays; }
			set { gestationalDays = value; }
		}

		/// <summary>
		/// Gets or sets the PlacentalPositionID value.
		/// </summary>
		public long PlacentalPositionID
		{
			get { return placentalPositionID; }
			set { placentalPositionID = value; }
		}

		/// <summary>
		/// Gets or sets the PlacentalPositionName value.
		/// </summary>
		public string PlacentalPositionName
		{
			get { return placentalPositionName; }
			set { placentalPositionName = value; }
		}

		/// <summary>
		/// Gets or sets the DateOfUltraSound value.
		/// </summary>
		public DateTime DateOfUltraSound
		{
			get { return dateOfUltraSound; }
			set { dateOfUltraSound = value; }
		}

		/// <summary>
		/// Gets or sets the MultipleGestation value.
		/// </summary>
		public int MultipleGestation
		{
			get { return multipleGestation; }
			set { multipleGestation = value; }
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
		/// Gets or sets the PlacentalPosition value.
		/// </summary>
		private string _placentalPosition=String.Empty;
		public string PlacentalPosition
		{
			get { return  _placentalPosition; }
			set { _placentalPosition = value; }
		}

		/// <summary>
		/// Gets or sets the GAge value.
		/// </summary>
		private string _gAge=String.Empty;
		public string GAge
		{
			get { return  _gAge; }
			set { _gAge = value; }
		}

		/// <summary>
		/// Gets or sets the USDate value.
		/// </summary>
		private string _uSDate=String.Empty;
		public string USDate
		{
			get { return  _uSDate; }
			set { _uSDate = value; }
		}


		#endregion
}
}
