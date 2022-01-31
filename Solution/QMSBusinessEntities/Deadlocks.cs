using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Deadlocks
	{
		#region Fields

		private int iD=0;
		private string deadlock=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the Deadlock value.
		/// </summary>
		public string Deadlock
		{
			get { return deadlock; }
			set { deadlock = value; }
		}


		#endregion
}
}
