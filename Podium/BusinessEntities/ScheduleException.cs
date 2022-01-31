using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ScheduleException
	{
		#region Fields

		private int exceptionID=0;
		private int scheduleTemplateID=0;
		private int scheduleID=0;
		private DateTime dateOfChange=DateTime.MaxValue;
		private TimeSpan startTime=TimeSpan.MinValue;
		private TimeSpan endTime=TimeSpan.MinValue;
		private int slotDuration=0;
		private int recurrenceID=0;
		private string level=String.Empty;
		private int createdBy=0;
		private DateTime createdAT=DateTime.MaxValue;
		private int modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ExceptionID value.
		/// </summary>
		public int ExceptionID
		{
			get { return exceptionID; }
			set { exceptionID = value; }
		}

		/// <summary>
		/// Gets or sets the ScheduleTemplateID value.
		/// </summary>
		public int ScheduleTemplateID
		{
			get { return scheduleTemplateID; }
			set { scheduleTemplateID = value; }
		}

		/// <summary>
		/// Gets or sets the ScheduleID value.
		/// </summary>
		public int ScheduleID
		{
			get { return scheduleID; }
			set { scheduleID = value; }
		}

		/// <summary>
		/// Gets or sets the DateOfChange value.
		/// </summary>
		public DateTime DateOfChange
		{
			get { return dateOfChange; }
			set { dateOfChange = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public int CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAT value.
		/// </summary>
		public DateTime CreatedAT
		{
			get { return createdAT; }
			set { createdAT = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public int ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}


		#endregion
}
}
