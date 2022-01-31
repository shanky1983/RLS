using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PageLoginAccess
	{
		#region Fields

		private long loginID=0;
		private long pageID=0;
		private long locationID=0;
		private long orgID=0;
		private string lockedPageID=String.Empty;
		private string isLockedPage=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the LoginID value.
		/// </summary>
		public long LoginID
		{
			get { return loginID; }
			set { loginID = value; }
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
		/// Gets or sets the LocationID value.
		/// </summary>
		public long LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the LockedPageID value.
		/// </summary>
		public string LockedPageID
		{
			get { return lockedPageID; }
			set { lockedPageID = value; }
		}

		/// <summary>
		/// Gets or sets the IsLockedPage value.
		/// </summary>
		public string IsLockedPage
		{
			get { return isLockedPage; }
			set { isLockedPage = value; }
		}


		#endregion
}
}
