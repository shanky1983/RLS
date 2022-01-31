using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Reminder
	{
		#region Fields

		private long reminderID=0;
		private DateTime remindDate=DateTime.MaxValue;
		private long reminderTemplateID=0;
		private long userID=0;
		private long roleID=0;
		private DateTime deferDate=DateTime.MaxValue;
		private string status=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ReminderID value.
		/// </summary>
		public long ReminderID
		{
			get { return reminderID; }
			set { reminderID = value; }
		}

		/// <summary>
		/// Gets or sets the RemindDate value.
		/// </summary>
		public DateTime RemindDate
		{
			get { return remindDate; }
			set { remindDate = value; }
		}

		/// <summary>
		/// Gets or sets the ReminderTemplateID value.
		/// </summary>
		public long ReminderTemplateID
		{
			get { return reminderTemplateID; }
			set { reminderTemplateID = value; }
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
		public long RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}

		/// <summary>
		/// Gets or sets the DeferDate value.
		/// </summary>
		public DateTime DeferDate
		{
			get { return deferDate; }
			set { deferDate = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the Notes value.
		/// </summary>
		private string _notes=String.Empty;
		public string Notes
		{
			get { return  _notes; }
			set { _notes = value; }
		}


		#endregion
}
}
