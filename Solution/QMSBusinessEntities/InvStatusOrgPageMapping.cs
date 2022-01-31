using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvStatusOrgPageMapping
	{
		#region Fields

		private long statusID=0;
		private int orgID=0;
		private string pageType=String.Empty;
		private long locationID=0;
		private string isDefault=String.Empty;
		private string langCode=String.Empty;
		private string displaytext=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the StatusID value.
		/// </summary>
		public long StatusID
		{
			get { return statusID; }
			set { statusID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the PageType value.
		/// </summary>
		public string PageType
		{
			get { return pageType; }
			set { pageType = value; }
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
		/// Gets or sets the IsDefault value.
		/// </summary>
		public string IsDefault
		{
			get { return isDefault; }
			set { isDefault = value; }
		}

		/// <summary>
		/// Gets or sets the LangCode value.
		/// </summary>
		public string LangCode
		{
			get { return langCode; }
			set { langCode = value; }
		}

		/// <summary>
		/// Gets or sets the Displaytext value.
		/// </summary>
		public string Displaytext
		{
			get { return displaytext; }
			set { displaytext = value; }
		}


		#endregion
}
}
