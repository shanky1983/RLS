using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PsychiatryExamination
	{
		#region Fields

		private int iD=0;
		private string examinationName=String.Empty;
		private int sequence=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the ExaminationName value.
		/// </summary>
		public string ExaminationName
		{
			get { return examinationName; }
			set { examinationName = value; }
		}

		/// <summary>
		/// Gets or sets the Sequence value.
		/// </summary>
		public int Sequence
		{
			get { return sequence; }
			set { sequence = value; }
		}


		#endregion
}
}
