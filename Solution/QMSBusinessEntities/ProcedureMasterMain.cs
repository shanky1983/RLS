using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ProcedureMasterMain
	{
		#region Fields

		private long procID=0;
		private string procName=String.Empty;
		private string procType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ProcID value.
		/// </summary>
		public long ProcID
		{
			get { return procID; }
			set { procID = value; }
		}

		/// <summary>
		/// Gets or sets the ProcName value.
		/// </summary>
		public string ProcName
		{
			get { return procName; }
			set { procName = value; }
		}

		/// <summary>
		/// Gets or sets the ProcType value.
		/// </summary>
		public string ProcType
		{
			get { return procType; }
			set { procType = value; }
		}


		#endregion
}
}
