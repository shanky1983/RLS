using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class OrdTasks
	{
		#region Fields

		private string status=String.Empty;
		private int sEQ=0;
		private int taskSeq=0;
		private int nextTaskid=0;
		private string taskstatus=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the SEQ value.
		/// </summary>
		public int SEQ
		{
			get { return sEQ; }
			set { sEQ = value; }
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

		/// <summary>
		/// Gets or sets the Taskstatus value.
		/// </summary>
		public string Taskstatus
		{
			get { return taskstatus; }
			set { taskstatus = value; }
		}


		#endregion
}
}
