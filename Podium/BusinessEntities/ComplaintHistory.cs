using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ComplaintHistory
	{
		#region Fields

		private int complaintID=0;
		private int historyID=0;

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
		/// Gets or sets the HistoryID value.
		/// </summary>
		public int HistoryID
		{
			get { return historyID; }
			set { historyID = value; }
		}


		#endregion
}
}
