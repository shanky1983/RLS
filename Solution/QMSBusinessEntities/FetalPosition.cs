using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class FetalPosition
	{
		#region Fields

		private int fetalPositionID=0;
		private string fetalPositionDesc=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FetalPositionID value.
		/// </summary>
		public int FetalPositionID
		{
			get { return fetalPositionID; }
			set { fetalPositionID = value; }
		}

		/// <summary>
		/// Gets or sets the FetalPositionDesc value.
		/// </summary>
		public string FetalPositionDesc
		{
			get { return fetalPositionDesc; }
			set { fetalPositionDesc = value; }
		}


		#endregion
}
}
