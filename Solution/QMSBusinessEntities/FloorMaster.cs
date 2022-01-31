using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class FloorMaster
	{
		#region Fields

		private string floorName=String.Empty;
		private int buildingID=0;
		private short floorID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FloorName value.
		/// </summary>
		public string FloorName
		{
			get { return floorName; }
			set { floorName = value; }
		}

		/// <summary>
		/// Gets or sets the BuildingID value.
		/// </summary>
		public int BuildingID
		{
			get { return buildingID; }
			set { buildingID = value; }
		}

		/// <summary>
		/// Gets or sets the FloorID value.
		/// </summary>
		public short FloorID
		{
			get { return floorID; }
			set { floorID = value; }
		}


		#endregion
}
}
