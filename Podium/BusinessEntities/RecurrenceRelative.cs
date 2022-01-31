using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class RecurrenceRelative
	{
		#region Fields

		private int recurrenceID=0;
		private string type=String.Empty;
		private int interval=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RecurrenceID value.
		/// </summary>
		public int RecurrenceID
		{
			get { return recurrenceID; }
			set { recurrenceID = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the Interval value.
		/// </summary>
		public int Interval
		{
			get { return interval; }
			set { interval = value; }
		}


		#endregion
}
}
