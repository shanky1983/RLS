using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class BannerRoleMapping
	{
		#region Fields

		private long bannerID=0;
		private long roleID=0;
		private long loginID=0;
		private DateTime bannerStartDate=DateTime.MaxValue;
		private DateTime bannerEndDate=DateTime.MaxValue;
		private DateTime createdat=DateTime.MaxValue;
		private long modifiedby=0;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int bannerRoleMappingID=0;

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

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
		}

		/// <summary>
		/// Gets or sets the Modifiedby value.
		/// </summary>
		public long Modifiedby
		{
			get { return modifiedby; }
			set { modifiedby = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the BannerRoleMappingID value.
		/// </summary>
		public int BannerRoleMappingID
		{
			get { return bannerRoleMappingID; }
			set { bannerRoleMappingID = value; }
		}


		#endregion
}
}
