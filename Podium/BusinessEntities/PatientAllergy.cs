using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientAllergy
	{
		#region Fields

		private int patientAllergyID=0;
		private int patientID=0;
		private string createdBy=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private string modifiedBy=String.Empty;
		private DateTime modifiedAt=DateTime.MaxValue;
		private short allergyID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientAllergyID value.
		/// </summary>
		public int PatientAllergyID
		{
			get { return patientAllergyID; }
			set { patientAllergyID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		public int PatientID
		{
			get { return patientID; }
			set { patientID = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public string CreatedBy
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
		public string ModifiedBy
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
		/// Gets or sets the AllergyID value.
		/// </summary>
		public short AllergyID
		{
			get { return allergyID; }
			set { allergyID = value; }
		}


		#endregion
}
}
