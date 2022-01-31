using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
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
		private DateTime _startDate=DateTime.MaxValue;
		public DateTime StartDate
		{
			get { return  _startDate; }
			set { _startDate = value; }
		}

		/// <summary>
		/// Gets or sets the EndDate value.
		/// </summary>
		private DateTime _endDate=DateTime.MaxValue;
		public DateTime EndDate
		{
			get { return  _endDate; }
			set { _endDate = value; }
		}


		#endregion
}
}
