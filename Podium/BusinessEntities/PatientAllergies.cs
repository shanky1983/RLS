using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientAllergies
	{
		#region Fields

		private long patientId=0;
		private int allergyId=0;
		private string allergyName=String.Empty;
		private string allergyType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientId value.
		/// </summary>
		public long PatientId
		{
			get { return patientId; }
			set { patientId = value; }
		}

		/// <summary>
		/// Gets or sets the AllergyId value.
		/// </summary>
		public int AllergyId
		{
			get { return allergyId; }
			set { allergyId = value; }
		}

		/// <summary>
		/// Gets or sets the AllergyName value.
		/// </summary>
		public string AllergyName
		{
			get { return allergyName; }
			set { allergyName = value; }
		}

		/// <summary>
		/// Gets or sets the AllergyType value.
		/// </summary>
		public string AllergyType
		{
			get { return allergyType; }
			set { allergyType = value; }
		}

		/// <summary>
		/// Gets or sets the TotRows value.
		/// </summary>
		private int _totRows=0;
		public int TotRows
		{
			get { return  _totRows; }
			set { _totRows = value; }
		}


		#endregion
}
}
