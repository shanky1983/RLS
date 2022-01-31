using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Racemaster
	{
		#region Fields

		private int raceid=0;
		private string racename=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Raceid value.
		/// </summary>
		public int Raceid
		{
			get { return raceid; }
			set { raceid = value; }
		}

		/// <summary>
		/// Gets or sets the Racename value.
		/// </summary>
		public string Racename
		{
			get { return racename; }
			set { racename = value; }
		}


		#endregion
}
}
