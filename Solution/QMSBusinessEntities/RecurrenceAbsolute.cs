using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class RecurrenceAbsolute
	{
		#region Fields

		private int recurrenceCycleID=0;
		private int recurrenceID=0;
		private int parentRecurrenceCycleID=0;
		private string unit=String.Empty;
		private string valu=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RecurrenceCycleID value.
		/// </summary>
		public int RecurrenceCycleID
		{
			get { return recurrenceCycleID; }
			set { recurrenceCycleID = value; }
		}

		/// <summary>
		/// Gets or sets the RecurrenceID value.
		/// </summary>
		public int RecurrenceID
		{
			get { return recurrenceID; }
			set { recurrenceID = value; }
		}

		/// <summary>
		/// Gets or sets the ParentRecurrenceCycleID value.
		/// </summary>
		public int ParentRecurrenceCycleID
		{
			get { return parentRecurrenceCycleID; }
			set { parentRecurrenceCycleID = value; }
		}

		/// <summary>
		/// Gets or sets the Unit value.
		/// </summary>
		public string Unit
		{
			get { return unit; }
			set { unit = value; }
		}

		/// <summary>
		/// Gets or sets the Valu value.
		/// </summary>
		public string Value
		{
			get { return valu; }
			set { valu = value; }
		}


		#endregion
}
}
