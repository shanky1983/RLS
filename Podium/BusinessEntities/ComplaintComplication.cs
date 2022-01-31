using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ComplaintComplication
	{
		#region Fields

		private int complaintID=0;
		private int complicationID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ComplaintID value.
		/// </summary>
		public int ComplaintID
		{
			get { return complaintID; }
			set { complaintID = value; }
		}

		/// <summary>
		/// Gets or sets the ComplicationID value.
		/// </summary>
		public int ComplicationID
		{
			get { return complicationID; }
			set { complicationID = value; }
		}


		#endregion
}
}
