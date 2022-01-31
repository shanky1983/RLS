using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class OrdTasks
	{
		#region Fields

		private string taskstatus=String.Empty;
		private int taskSeq=0;
		private int nextTaskid=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Taskstatus value.
		/// </summary>
		public string Taskstatus
		{
			get { return taskstatus; }
			set { taskstatus = value; }
		}

		/// <summary>
		/// Gets or sets the TaskSeq value.
		/// </summary>
		public int TaskSeq
		{
			get { return taskSeq; }
			set { taskSeq = value; }
		}

		/// <summary>
		/// Gets or sets the NextTaskid value.
		/// </summary>
		public int NextTaskid
		{
			get { return nextTaskid; }
			set { nextTaskid = value; }
		}


		#endregion
}
}
