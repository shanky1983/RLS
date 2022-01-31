using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InstrumentationMaster
	{
		#region Fields

		private long instrumentationID=0;
		private string name=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InstrumentationID value.
		/// </summary>
		public long InstrumentationID
		{
			get { return instrumentationID; }
			set { instrumentationID = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}


		#endregion
}
}
