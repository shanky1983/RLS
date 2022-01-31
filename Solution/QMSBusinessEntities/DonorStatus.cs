using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class DonorStatus
	{
		#region Fields

		private long patientVisitID=0;
		private string permanentStatus1=String.Empty;
		private string permanentStatus2=String.Empty;
		private string temporaryStatus1=String.Empty;
		private string temporaryStatus2=String.Empty;
		private string examinationStatus1=String.Empty;
		private string examinationStatus2=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		public long PatientVisitID
		{
			get { return patientVisitID; }
			set { patientVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the PermanentStatus1 value.
		/// </summary>
		public string PermanentStatus1
		{
			get { return permanentStatus1; }
			set { permanentStatus1 = value; }
		}

		/// <summary>
		/// Gets or sets the PermanentStatus2 value.
		/// </summary>
		public string PermanentStatus2
		{
			get { return permanentStatus2; }
			set { permanentStatus2 = value; }
		}

		/// <summary>
		/// Gets or sets the TemporaryStatus1 value.
		/// </summary>
		public string TemporaryStatus1
		{
			get { return temporaryStatus1; }
			set { temporaryStatus1 = value; }
		}

		/// <summary>
		/// Gets or sets the TemporaryStatus2 value.
		/// </summary>
		public string TemporaryStatus2
		{
			get { return temporaryStatus2; }
			set { temporaryStatus2 = value; }
		}

		/// <summary>
		/// Gets or sets the ExaminationStatus1 value.
		/// </summary>
		public string ExaminationStatus1
		{
			get { return examinationStatus1; }
			set { examinationStatus1 = value; }
		}

		/// <summary>
		/// Gets or sets the ExaminationStatus2 value.
		/// </summary>
		public string ExaminationStatus2
		{
			get { return examinationStatus2; }
			set { examinationStatus2 = value; }
		}


		#endregion
}
}
