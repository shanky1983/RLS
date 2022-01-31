using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ScheduleTemplate
	{
		#region Fields

		private int scheduleTemplateID=0;
		private TimeSpan startTime=TimeSpan.MinValue;
		private TimeSpan endTime=TimeSpan.MinValue;
		private int slotDuration=0;
		private int recurrenceID=0;
		private string level=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ScheduleTemplateID value.
		/// </summary>
		public int ScheduleTemplateID
		{
			get { return scheduleTemplateID; }
			set { scheduleTemplateID = value; }
		}

		/// <summary>
		/// Gets or sets the StartTime value.
		/// </summary>
		public TimeSpan StartTime
		{
			get { return startTime; }
			set { startTime = value; }
		}

		/// <summary>
		/// Gets or sets the EndTime value.
		/// </summary>
		public TimeSpan EndTime
		{
			get { return endTime; }
			set { endTime = value; }
		}

		/// <summary>
		/// Gets or sets the SlotDuration value.
		/// </summary>
		public int SlotDuration
		{
			get { return slotDuration; }
			set { slotDuration = value; }
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
		/// Gets or sets the Level value.
		/// </summary>
		public string Level
		{
			get { return level; }
			set { level = value; }
		}

		/// <summary>
		/// Gets or sets the StartDate value.
		/// </summary>
		DateTime _startdate;
		public DateTime StartDate
		{
			get { return _startdate; }
			set { _startdate = value; }
		}

		/// <summary>
		/// Gets or sets the EndDate value.
		/// </summary>
		DateTime _enddate;
		public DateTime EndDate
		{
			get { return _enddate; }
			set { _enddate = value; }
		}


		#endregion
}
}
