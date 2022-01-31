using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class BloodComponent
	{
		#region Fields

		private long bloodComponentID=0;
		private string bloodComponentName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BloodComponentID value.
		/// </summary>
		public long BloodComponentID
		{
			get { return bloodComponentID; }
			set { bloodComponentID = value; }
		}

		/// <summary>
		/// Gets or sets the BloodComponentName value.
		/// </summary>
		public string BloodComponentName
		{
			get { return bloodComponentName; }
			set { bloodComponentName = value; }
		}


		#endregion
}
}
