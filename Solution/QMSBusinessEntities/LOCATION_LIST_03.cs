using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class LOCATION_LIST_03
	{
		#region Fields

		private string location=String.Empty;
		private string city=String.Empty;
		private string state=String.Empty;
		private float pincode=0.0F;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Location value.
		/// </summary>
		public string Location
		{
			get { return location; }
			set { location = value; }
		}

		/// <summary>
		/// Gets or sets the City value.
		/// </summary>
		public string City
		{
			get { return city; }
			set { city = value; }
		}

		/// <summary>
		/// Gets or sets the State value.
		/// </summary>
		public string State
		{
			get { return state; }
			set { state = value; }
		}

		/// <summary>
		/// Gets or sets the Pincode value.
		/// </summary>
		public float Pincode
		{
			get { return pincode; }
			set { pincode = value; }
		}


		#endregion
}
}
