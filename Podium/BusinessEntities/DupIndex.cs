using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class DupIndex
	{
		#region Fields

		private string table=String.Empty;
		private string index=String.Empty;
		private string partialduplicate=String.Empty;

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
		/// Gets or sets the Index value.
		/// </summary>
		public string Index
		{
			get { return index; }
			set { index = value; }
		}

		/// <summary>
		/// Gets or sets the Partialduplicate value.
		/// </summary>
		public string Partialduplicate
		{
			get { return partialduplicate; }
			set { partialduplicate = value; }
		}


		#endregion
}
}
