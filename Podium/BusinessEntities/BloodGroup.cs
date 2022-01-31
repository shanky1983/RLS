using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class BloodGroup
	{
		#region Fields

		private long bloodGroupID=0;
		private string bloodGroupName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BloodGroupID value.
		/// </summary>
		public long BloodGroupID
		{
			get { return bloodGroupID; }
			set { bloodGroupID = value; }
		}

		/// <summary>
		/// Gets or sets the BloodGroupName value.
		/// </summary>
		public string BloodGroupName
		{
			get { return bloodGroupName; }
			set { bloodGroupName = value; }
		}


		#endregion
}
}
