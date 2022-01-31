using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class StatusMaster
	{
		#region Fields

		private int statusID=0;
		private string statusDesc=String.Empty;
		private string type=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the StatusID value.
		/// </summary>
		public int StatusID
		{
			get { return statusID; }
			set { statusID = value; }
		}

		/// <summary>
		/// Gets or sets the StatusDesc value.
		/// </summary>
		public string StatusDesc
		{
			get { return statusDesc; }
			set { statusDesc = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the SeqNo value.
		/// </summary>
		private int _seqNo=0;
		public int SeqNo
		{
			get { return  _seqNo; }
			set { _seqNo = value; }
		}


		#endregion
}
}
