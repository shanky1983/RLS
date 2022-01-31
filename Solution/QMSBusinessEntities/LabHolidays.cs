using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class LabHolidays
	{
		#region Fields

		private int detailID=0;
		private long orgID=0;
		private string holidayName=String.Empty;
		private DateTime holidayDate=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DetailID value.
		/// </summary>
		public int DetailID
		{
			get { return detailID; }
			set { detailID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the HolidayName value.
		/// </summary>
		public string HolidayName
		{
			get { return holidayName; }
			set { holidayName = value; }
		}

		/// <summary>
		/// Gets or sets the HolidayDate value.
		/// </summary>
		public DateTime HolidayDate
		{
			get { return holidayDate; }
			set { holidayDate = value; }
		}


		#endregion
}
}
