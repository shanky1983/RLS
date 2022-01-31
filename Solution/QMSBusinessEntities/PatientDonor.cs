using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientDonor
	{
		#region Fields

		private long patientDonorID=0;
		private long patientID=0;
		private long patientVisitID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientDonorID value.
		/// </summary>
		public long PatientDonorID
		{
			get { return patientDonorID; }
			set { patientDonorID = value; }
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


		#endregion
}
}
