using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Error_Deadlock
	{
		#region Fields

		private string databasename=String.Empty;
		private int reqsessionid=0;
		private int blocksessionid=0;
		private string blockobj=String.Empty;
		private string resourcetype=String.Empty;
		private string reqText=String.Empty;
		private string blockText=String.Empty;
		private string reqmode=String.Empty;
		private string reqQuery=String.Empty;
		private string blockQuery=String.Empty;
		private DateTime locktime=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Databasename value.
		/// </summary>
		public string Databasename
		{
			get { return databasename; }
			set { databasename = value; }
		}

		/// <summary>
		/// Gets or sets the Reqsessionid value.
		/// </summary>
		public int Reqsessionid
		{
			get { return reqsessionid; }
			set { reqsessionid = value; }
		}

		/// <summary>
		/// Gets or sets the Blocksessionid value.
		/// </summary>
		public int Blocksessionid
		{
			get { return blocksessionid; }
			set { blocksessionid = value; }
		}

		/// <summary>
		/// Gets or sets the Blockobj value.
		/// </summary>
		public string Blockobj
		{
			get { return blockobj; }
			set { blockobj = value; }
		}

		/// <summary>
		/// Gets or sets the Resourcetype value.
		/// </summary>
		public string Resourcetype
		{
			get { return resourcetype; }
			set { resourcetype = value; }
		}

		/// <summary>
		/// Gets or sets the ReqText value.
		/// </summary>
		public string ReqText
		{
			get { return reqText; }
			set { reqText = value; }
		}

		/// <summary>
		/// Gets or sets the BlockText value.
		/// </summary>
		public string BlockText
		{
			get { return blockText; }
			set { blockText = value; }
		}

		/// <summary>
		/// Gets or sets the Reqmode value.
		/// </summary>
		public string Reqmode
		{
			get { return reqmode; }
			set { reqmode = value; }
		}

		/// <summary>
		/// Gets or sets the ReqQuery value.
		/// </summary>
		public string ReqQuery
		{
			get { return reqQuery; }
			set { reqQuery = value; }
		}

		/// <summary>
		/// Gets or sets the BlockQuery value.
		/// </summary>
		public string BlockQuery
		{
			get { return blockQuery; }
			set { blockQuery = value; }
		}

		/// <summary>
		/// Gets or sets the Locktime value.
		/// </summary>
		public DateTime Locktime
		{
			get { return locktime; }
			set { locktime = value; }
		}


		#endregion
}
}
