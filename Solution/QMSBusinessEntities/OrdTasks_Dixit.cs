using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class OrdTasks_Dixit
	{
		#region Fields

		private string taskStatus=String.Empty;
		private int taskSEQ=0;
		private int nextTaskID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TaskStatus value.
		/// </summary>
		public string TaskStatus
		{
			get { return taskStatus; }
			set { taskStatus = value; }
		}

		/// <summary>
		/// Gets or sets the TaskSEQ value.
		/// </summary>
		public int TaskSEQ
		{
			get { return taskSEQ; }
			set { taskSEQ = value; }
		}

		/// <summary>
		/// Gets or sets the NextTaskID value.
		/// </summary>
		public int NextTaskID
		{
			get { return nextTaskID; }
			set { nextTaskID = value; }
		}


		#endregion
}
}
