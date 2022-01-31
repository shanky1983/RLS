using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ComplaintExamination
	{
		#region Fields

		private int complaintID=0;
		private int examinationID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ComplaintID value.
		/// </summary>
		public int ComplaintID
		{
			get { return complaintID; }
			set { complaintID = value; }
		}

		/// <summary>
		/// Gets or sets the ExaminationID value.
		/// </summary>
		public int ExaminationID
		{
			get { return examinationID; }
			set { examinationID = value; }
		}


		#endregion
}
}
