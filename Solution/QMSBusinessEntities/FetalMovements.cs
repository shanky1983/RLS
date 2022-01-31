using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class FetalMovements
	{
		#region Fields

		private int fetalMovementsID=0;
		private string fetalMovementsDesc=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FetalMovementsID value.
		/// </summary>
		public int FetalMovementsID
		{
			get { return fetalMovementsID; }
			set { fetalMovementsID = value; }
		}

		/// <summary>
		/// Gets or sets the FetalMovementsDesc value.
		/// </summary>
		public string FetalMovementsDesc
		{
			get { return fetalMovementsDesc; }
			set { fetalMovementsDesc = value; }
		}


		#endregion
}
}
