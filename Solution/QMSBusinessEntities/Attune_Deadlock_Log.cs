using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Attune_Deadlock_Log
	{
		#region Fields

		private int seqNo=0;
		private int spid=0;
		private string spid_Stmt=String.Empty;
		private int blockingId=0;
		private string blockingId_Stmt=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SeqNo value.
		/// </summary>
		public int SeqNo
		{
			get { return seqNo; }
			set { seqNo = value; }
		}

		/// <summary>
		/// Gets or sets the Spid value.
		/// </summary>
		public int Spid
		{
			get { return spid; }
			set { spid = value; }
		}

		/// <summary>
		/// Gets or sets the Spid_Stmt value.
		/// </summary>
		public string Spid_Stmt
		{
			get { return spid_Stmt; }
			set { spid_Stmt = value; }
		}

		/// <summary>
		/// Gets or sets the BlockingId value.
		/// </summary>
		public int BlockingId
		{
			get { return blockingId; }
			set { blockingId = value; }
		}

		/// <summary>
		/// Gets or sets the BlockingId_Stmt value.
		/// </summary>
		public string BlockingId_Stmt
		{
			get { return blockingId_Stmt; }
			set { blockingId_Stmt = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}


		#endregion
}
}
