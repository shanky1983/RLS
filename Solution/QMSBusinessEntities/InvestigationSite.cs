using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvestigationSite
	{
		#region Fields

		private int samplingSiteID=0;
		private string siteName=String.Empty;
		private string siteDescription=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SamplingSiteID value.
		/// </summary>
		public int SamplingSiteID
		{
			get { return samplingSiteID; }
			set { samplingSiteID = value; }
		}

		/// <summary>
		/// Gets or sets the SiteName value.
		/// </summary>
		public string SiteName
		{
			get { return siteName; }
			set { siteName = value; }
		}

		/// <summary>
		/// Gets or sets the SiteDescription value.
		/// </summary>
		public string SiteDescription
		{
			get { return siteDescription; }
			set { siteDescription = value; }
		}


		#endregion
}
}
