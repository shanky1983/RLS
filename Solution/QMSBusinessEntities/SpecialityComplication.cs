using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class SpecialityComplication
	{
		#region Fields

		private int specialityID=0;
		private int complicationID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SpecialityID value.
		/// </summary>
		public int SpecialityID
		{
			get { return specialityID; }
			set { specialityID = value; }
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
