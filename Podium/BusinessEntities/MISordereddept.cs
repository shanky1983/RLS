using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class MISordereddept
	{
		#region Fields

		private long accessionNumber=0;
		private int deptid=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AccessionNumber value.
		/// </summary>
		public long AccessionNumber
		{
			get { return accessionNumber; }
			set { accessionNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Deptid value.
		/// </summary>
		public int Deptid
		{
			get { return deptid; }
			set { deptid = value; }
		}


		#endregion
}
}
