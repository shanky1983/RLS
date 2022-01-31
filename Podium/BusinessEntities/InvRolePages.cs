using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvRolePages
	{
		#region Fields

		private string displayText=String.Empty;
		private int parentid=0;
		private string pageName=String.Empty;
		private string pageURL=String.Empty;
		private int locationTypeID=0;
		private long pageID=0;
		private long menuID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DisplayText value.
		/// </summary>
		public string DisplayText
		{
			get { return displayText; }
			set { displayText = value; }
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
		/// Gets or sets the LocationTypeID value.
		/// </summary>
		public int LocationTypeID
		{
			get { return locationTypeID; }
			set { locationTypeID = value; }
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
		/// Gets or sets the MenuID value.
		/// </summary>
		public long MenuID
		{
			get { return menuID; }
			set { menuID = value; }
		}


		#endregion
}
}
