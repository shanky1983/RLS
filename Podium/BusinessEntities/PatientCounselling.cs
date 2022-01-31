using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientCounselling
	{
		#region Fields

		private long patientID=0;
		private long visitID=0;
		private string symptoms=String.Empty;
		private int counselID=0;
		private string isConfidential=String.Empty;
		private string reviewOfSystem=String.Empty;
		private string examination=String.Empty;

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
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the Symptoms value.
		/// </summary>
		public string Symptoms
		{
			get { return symptoms; }
			set { symptoms = value; }
		}

		/// <summary>
		/// Gets or sets the CounselID value.
		/// </summary>
		public int CounselID
		{
			get { return counselID; }
			set { counselID = value; }
		}

		/// <summary>
		/// Gets or sets the IsConfidential value.
		/// </summary>
		public string IsConfidential
		{
			get { return isConfidential; }
			set { isConfidential = value; }
		}

		/// <summary>
		/// Gets or sets the ReviewOfSystem value.
		/// </summary>
		public string ReviewOfSystem
		{
			get { return reviewOfSystem; }
			set { reviewOfSystem = value; }
		}

		/// <summary>
		/// Gets or sets the Examination value.
		/// </summary>
		public string Examination
		{
			get { return examination; }
			set { examination = value; }
		}


		#endregion
}
}
