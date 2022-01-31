using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class GRP_Sequence
	{
		#region Fields

		private string tCODE=String.Empty;
		private float sequenceNo=0.0F;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TCODE value.
		/// </summary>
		public string TCODE
		{
			get { return tCODE; }
			set { tCODE = value; }
		}

		/// <summary>
		/// Gets or sets the SequenceNo value.
		/// </summary>
		public float SequenceNo
		{
			get { return sequenceNo; }
			set { sequenceNo = value; }
		}


		#endregion
}
}
