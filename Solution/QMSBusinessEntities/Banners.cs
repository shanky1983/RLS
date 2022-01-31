using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Banners
	{
		#region Fields

		private long bannerID=0;
		private string bannerText=String.Empty;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BannerID value.
		/// </summary>
		public long BannerID
		{
			get { return bannerID; }
			set { bannerID = value; }
		}

		/// <summary>
		/// Gets or sets the BannerText value.
		/// </summary>
		public string BannerText
		{
			get { return bannerText; }
			set { bannerText = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}


		#endregion
}
}
