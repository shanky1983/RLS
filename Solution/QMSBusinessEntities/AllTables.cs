using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class AllTables
	{
		#region Fields

		private string table =String.Empty;
		private string f2=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Table value.
		/// </summary>
		public string Table
		{
			get { return table; }
			set { table = value; }
		}

		/// <summary>
		/// Gets or sets the F2 value.
		/// </summary>
		public string F2
		{
			get { return f2; }
			set { f2 = value; }
		}


		#endregion
}
}
