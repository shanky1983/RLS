using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class BannerRoleMapping
	{
		#region Fields

		private long bannerID=0;
		private long roleID=0;
		private long loginID=0;
		private DateTime bannerStartDate=DateTime.MaxValue;
		private DateTime bannerEndDate=DateTime.MaxValue;

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
		/// Gets or sets the RoleID value.
		/// </summary>
		public long RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}

		/// <summary>
		/// Gets or sets the LoginID value.
		/// </summary>
		public long LoginID
		{
			get { return loginID; }
			set { loginID = value; }
		}

		/// <summary>
		/// Gets or sets the BannerStartDate value.
		/// </summary>
		public DateTime BannerStartDate
		{
			get { return bannerStartDate; }
			set { bannerStartDate = value; }
		}

		/// <summary>
		/// Gets or sets the BannerEndDate value.
		/// </summary>
		public DateTime BannerEndDate
		{
			get { return bannerEndDate; }
			set { bannerEndDate = value; }
		}


		#endregion
}
}
