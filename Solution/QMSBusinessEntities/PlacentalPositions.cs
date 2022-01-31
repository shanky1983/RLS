using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PlacentalPositions
	{
		#region Fields

		private int placentalPositionID=0;
		private string placentalPositionName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PlacentalPositionID value.
		/// </summary>
		public int PlacentalPositionID
		{
			get { return placentalPositionID; }
			set { placentalPositionID = value; }
		}

		/// <summary>
		/// Gets or sets the PlacentalPositionName value.
		/// </summary>
		public string PlacentalPositionName
		{
			get { return placentalPositionName; }
			set { placentalPositionName = value; }
		}


		#endregion
}
}
