using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ConsentLetters
	{
		#region Fields

		private int consentLetterID=0;
		private long patientVisitID=0;
		private int consentTypeID=0;
		private string consentLetterBeforeSign=String.Empty;
		private string consentLetterAfterSign=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ConsentLetterID value.
		/// </summary>
		public int ConsentLetterID
		{
			get { return consentLetterID; }
			set { consentLetterID = value; }
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
		/// Gets or sets the ConsentTypeID value.
		/// </summary>
		public int ConsentTypeID
		{
			get { return consentTypeID; }
			set { consentTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the ConsentLetterBeforeSign value.
		/// </summary>
		public string ConsentLetterBeforeSign
		{
			get { return consentLetterBeforeSign; }
			set { consentLetterBeforeSign = value; }
		}

		/// <summary>
		/// Gets or sets the ConsentLetterAfterSign value.
		/// </summary>
		public string ConsentLetterAfterSign
		{
			get { return consentLetterAfterSign; }
			set { consentLetterAfterSign = value; }
		}


		#endregion
}
}
