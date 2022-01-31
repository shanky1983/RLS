using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class SearchActions
	{
		#region Fields

		private long actionID=0;
		private string actionName=String.Empty;
		private long roleID=0;
		private long pageID=0;
		private string type=String.Empty;
		private int parentid=0;
		private string loggedonOrgOnly=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ActionID value.
		/// </summary>
		public long ActionID
		{
			get { return actionID; }
			set { actionID = value; }
		}

		/// <summary>
		/// Gets or sets the ActionName value.
		/// </summary>
		public string ActionName
		{
			get { return actionName; }
			set { actionName = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		public long RoleID
		{
			get { return roleID; }
			set { roleID = value; }
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
		/// Gets or sets the Parentid value.
		/// </summary>
		public int Parentid
		{
			get { return parentid; }
			set { parentid = value; }
		}

		/// <summary>
		/// Gets or sets the LoggedonOrgOnly value.
		/// </summary>
		public string LoggedonOrgOnly
		{
			get { return loggedonOrgOnly; }
			set { loggedonOrgOnly = value; }
		}

		/// <summary>
		/// Gets or sets the PageURL value.
		/// </summary>
		string _pageurl;
		public string PageURL
		{
			get { return _pageurl; }
			set { _pageurl = value; }
		}


		#endregion
}
}
