using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PsychiatricReview
	{
		#region Fields

		private int reviewId=0;
		private string reviewName=String.Empty;
		private int sequenceNo=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ReviewId value.
		/// </summary>
		public int ReviewId
		{
			get { return reviewId; }
			set { reviewId = value; }
		}

		/// <summary>
		/// Gets or sets the ReviewName value.
		/// </summary>
		public string ReviewName
		{
			get { return reviewName; }
			set { reviewName = value; }
		}

		/// <summary>
		/// Gets or sets the SequenceNo value.
		/// </summary>
		public int SequenceNo
		{
			get { return sequenceNo; }
			set { sequenceNo = value; }
		}


		#endregion
}
}
