using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ProcedureComplication
	{
		#region Fields

		private int procedureID=0;
		private int complicationID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ProcedureID value.
		/// </summary>
		public int ProcedureID
		{
			get { return procedureID; }
			set { procedureID = value; }
		}

		/// <summary>
		/// Gets or sets the ComplicationID value.
		/// </summary>
		public int ComplicationID
		{
			get { return complicationID; }
			set { complicationID = value; }
		}


		#endregion
}
}
