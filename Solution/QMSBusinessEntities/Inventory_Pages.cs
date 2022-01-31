using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Inventory_Pages
	{
		#region Fields

		private int rowID=0;
		private string pageName=String.Empty;
		private string pageURL=String.Empty;
		private int parentid=0;
		private string displayText=String.Empty;
		private int pageID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RowID value.
		/// </summary>
		public int RowID
		{
			get { return rowID; }
			set { rowID = value; }
		}

		/// <summary>
		/// Gets or sets the PageName value.
		/// </summary>
		public string PageName
		{
			get { return pageName; }
			set { pageName = value; }
		}

		/// <summary>
		/// Gets or sets the PageURL value.
		/// </summary>
		public string PageURL
		{
			get { return pageURL; }
			set { pageURL = value; }
		}

		/// <summary>
		/// Gets or sets the Parentid value.
		/// </summary>
		public int Parentid
		{
			get { return parentid; }
			set { parentid = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayText value.
		/// </summary>
		public string DisplayText
		{
			get { return displayText; }
			set { displayText = value; }
		}

		/// <summary>
		/// Gets or sets the PageID value.
		/// </summary>
		public int PageID
		{
			get { return pageID; }
			set { pageID = value; }
		}


		#endregion
}
}
