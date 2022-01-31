using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class BuildingMaster
	{
		#region Fields

		private int buildingID=0;
		private string buildingName=String.Empty;
		private int orgID=0;
		private int orgAddID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BuildingID value.
		/// </summary>
		public int BuildingID
		{
			get { return buildingID; }
			set { buildingID = value; }
		}

		/// <summary>
		/// Gets or sets the BuildingName value.
		/// </summary>
		public string BuildingName
		{
			get { return buildingName; }
			set { buildingName = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddID value.
		/// </summary>
		public int OrgAddID
		{
			get { return orgAddID; }
			set { orgAddID = value; }
		}


		#endregion
}
}
