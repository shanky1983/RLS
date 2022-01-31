using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class TaskStatus
	{
		#region Fields

		private byte taskStatusID=0x00;
		private string statusName=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private long modifiedAt=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TaskStatusID value.
		/// </summary>
		public byte TaskStatusID
		{
			get { return taskStatusID; }
			set { taskStatusID = value; }
		}

		/// <summary>
		/// Gets or sets the StatusName value.
		/// </summary>
		public string StatusName
		{
			get { return statusName; }
			set { statusName = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public long ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}


		#endregion
}
}
