using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientMuscleDetail
	{
		#region Fields

		private long patientMuscleID=0;
		private long muscleID=0;
		private string musclePower=String.Empty;
		private string muscleTone=String.Empty;
		private long visitID=0;
		private long patientID=0;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientMuscleID value.
		/// </summary>
		public long PatientMuscleID
		{
			get { return patientMuscleID; }
			set { patientMuscleID = value; }
		}

		/// <summary>
		/// Gets or sets the MuscleID value.
		/// </summary>
		public long MuscleID
		{
			get { return muscleID; }
			set { muscleID = value; }
		}

		/// <summary>
		/// Gets or sets the MusclePower value.
		/// </summary>
		public string MusclePower
		{
			get { return musclePower; }
			set { musclePower = value; }
		}

		/// <summary>
		/// Gets or sets the MuscleTone value.
		/// </summary>
		public string MuscleTone
		{
			get { return muscleTone; }
			set { muscleTone = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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
		/// Gets or sets the Name value.
		/// </summary>
		private string _name=String.Empty;
		public string Name
		{
			get { return  _name; }
			set { _name = value; }
		}


		#endregion
}
}
