using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvestigationPrecaution
	{
		#region Fields

		private int investigationCautionID=0;
		private int precautionID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvestigationCautionID value.
		/// </summary>
		public int InvestigationCautionID
		{
			get { return investigationCautionID; }
			set { investigationCautionID = value; }
		}

		/// <summary>
		/// Gets or sets the PrecautionID value.
		/// </summary>
		public int PrecautionID
		{
			get { return precautionID; }
			set { precautionID = value; }
		}


		#endregion
}
}
