using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class HomeCollectionIDMaster
	{
		#region Fields

		private int orgID=0;
		private long bookingNumber=0;
		private int rowID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the BookingNumber value.
		/// </summary>
		public long BookingNumber
		{
			get { return bookingNumber; }
			set { bookingNumber = value; }
		}

		/// <summary>
		/// Gets or sets the RowID value.
		/// </summary>
		public int RowID
		{
			get { return rowID; }
			set { rowID = value; }
		}


		#endregion
}
}
