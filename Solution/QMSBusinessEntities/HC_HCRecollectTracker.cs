using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class HC_HCRecollectTracker
	{
		#region Fields

		private int rescheduleID=0;
		private long visitID=0;
		private long investigtionID=0;
		private DateTime recollectTime=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RescheduleID value.
		/// </summary>
		public int RescheduleID
		{
			get { return rescheduleID; }
			set { rescheduleID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigtionID value.
		/// </summary>
		public long InvestigtionID
		{
			get { return investigtionID; }
			set { investigtionID = value; }
		}

		/// <summary>
		/// Gets or sets the RecollectTime value.
		/// </summary>
		public DateTime RecollectTime
		{
			get { return recollectTime; }
			set { recollectTime = value; }
		}


		#endregion
}
}
