using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class CaseSheet
	{
		#region Fields

		private long patientID=0;
		private long patientVisitID=0;
		private string caseSheetText=String.Empty;

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
		/// Gets or sets the CaseSheetText value.
		/// </summary>
		public string CaseSheetText
		{
			get { return caseSheetText; }
			set { caseSheetText = value; }
		}


		#endregion
}
}
