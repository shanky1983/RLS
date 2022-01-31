using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class SearchColumns
	{
		#region Fields

		private int searchColumnID=0;
		private string searchColumnName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SearchColumnID value.
		/// </summary>
		public int SearchColumnID
		{
			get { return searchColumnID; }
			set { searchColumnID = value; }
		}

		/// <summary>
		/// Gets or sets the SearchColumnName value.
		/// </summary>
		public string SearchColumnName
		{
			get { return searchColumnName; }
			set { searchColumnName = value; }
		}


		#endregion
}
}
