using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class BloodComponentMapping
	{
		#region Fields

		private long bloodGroupID=0;
		private long bloodComponentID=0;
		private int mappingID=0;

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
		/// Gets or sets the BloodComponentID value.
		/// </summary>
		public long BloodComponentID
		{
			get { return bloodComponentID; }
			set { bloodComponentID = value; }
		}

		/// <summary>
		/// Gets or sets the MappingID value.
		/// </summary>
		public int MappingID
		{
			get { return mappingID; }
			set { mappingID = value; }
		}


		#endregion
}
}
