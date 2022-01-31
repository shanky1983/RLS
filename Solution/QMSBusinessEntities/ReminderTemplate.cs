using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ReminderTemplate
	{
		#region Fields

		private long reminderTemplateID=0;
		private DateTime startDate=DateTime.MaxValue;
		private DateTime endDate=DateTime.MaxValue;
		private string notes=String.Empty;
		private long userID=0;
		private int roleID=0;
		private string frequency=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ReminderTemplateID value.
		/// </summary>
		public long ReminderTemplateID
		{
			get { return reminderTemplateID; }
			set { reminderTemplateID = value; }
		}

		/// <summary>
		/// Gets or sets the StartDate value.
		/// </summary>
		public DateTime StartDate
		{
			get { return startDate; }
			set { startDate = value; }
		}

		/// <summary>
		/// Gets or sets the EndDate value.
		/// </summary>
		public DateTime EndDate
		{
			get { return endDate; }
			set { endDate = value; }
		}

		/// <summary>
		/// Gets or sets the Notes value.
		/// </summary>
		public string Notes
		{
			get { return notes; }
			set { notes = value; }
		}

		/// <summary>
		/// Gets or sets the UserID value.
		/// </summary>
		public long UserID
		{
			get { return userID; }
			set { userID = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		public int RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}

		/// <summary>
		/// Gets or sets the Frequency value.
		/// </summary>
		public string Frequency
		{
			get { return frequency; }
			set { frequency = value; }
		}


		#endregion
}
}
