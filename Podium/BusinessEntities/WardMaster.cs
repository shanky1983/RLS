using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class WardMaster
	{
		#region Fields

		private int wardID=0;
		private string wardName=String.Empty;
		private int buildingID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the WardID value.
		/// </summary>
		public int WardID
		{
			get { return wardID; }
			set { wardID = value; }
		}

		/// <summary>
		/// Gets or sets the WardName value.
		/// </summary>
		public string WardName
		{
			get { return wardName; }
			set { wardName = value; }
		}

		/// <summary>
		/// Gets or sets the BuildingID value.
		/// </summary>
		public int BuildingID
		{
			get { return buildingID; }
			set { buildingID = value; }
		}


		#endregion
}
}
