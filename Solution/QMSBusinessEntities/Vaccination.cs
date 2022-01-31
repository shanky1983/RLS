using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Vaccination
	{
		#region Fields

		private int vaccinationID=0;
		private string vaccinationName=String.Empty;
		private string vaccDescription=String.Empty;

		#endregion

		#region Properties
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
		/// Gets or sets the VaccDescription value.
		/// </summary>
		public string VaccDescription
		{
			get { return vaccDescription; }
			set { vaccDescription = value; }
		}


		#endregion
}
}
