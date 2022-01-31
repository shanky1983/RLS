using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Test_RefRanges
	{
		#region Fields

		private long invID=0;
		private string range=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvID value.
		/// </summary>
		public long InvID
		{
			get { return invID; }
			set { invID = value; }
		}

		/// <summary>
		/// Gets or sets the Range value.
		/// </summary>
		public string Range
		{
			get { return range; }
			set { range = value; }
		}


		#endregion
}
}
