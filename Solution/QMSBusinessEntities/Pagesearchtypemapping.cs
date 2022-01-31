using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Pagesearchtypemapping
	{
		#region Fields

		private long pagesearchtypemapID=0;
		private long pageID=0;
		private string type=String.Empty;
		private long typeID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PagesearchtypemapID value.
		/// </summary>
		public long PagesearchtypemapID
		{
			get { return pagesearchtypemapID; }
			set { pagesearchtypemapID = value; }
		}

		/// <summary>
		/// Gets or sets the PageID value.
		/// </summary>
		public long PageID
		{
			get { return pageID; }
			set { pageID = value; }
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
		/// Gets or sets the TypeID value.
		/// </summary>
		public long TypeID
		{
			get { return typeID; }
			set { typeID = value; }
		}


		#endregion
}
}
