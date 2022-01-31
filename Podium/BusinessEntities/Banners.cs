using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Banners
	{
		#region Fields

		private string bannerText=String.Empty;
		private int orgID=0;
		private string bannerType=String.Empty;
		private string categoryCode=String.Empty;
		private string title=String.Empty;
		private long empDeptID=0;
		private string docFileUrl=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long modifiedby=0;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private bool status=false;
		private int bannerID=0;

		#endregion

		#region Properties
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

		/// <summary>
		/// Gets or sets the BannerType value.
		/// </summary>
		public string BannerType
		{
			get { return bannerType; }
			set { bannerType = value; }
		}

		/// <summary>
		/// Gets or sets the CategoryCode value.
		/// </summary>
		public string CategoryCode
		{
			get { return categoryCode; }
			set { categoryCode = value; }
		}

		/// <summary>
		/// Gets or sets the Title value.
		/// </summary>
		public string Title
		{
			get { return title; }
			set { title = value; }
		}

		/// <summary>
		/// Gets or sets the EmpDeptID value.
		/// </summary>
		public long EmpDeptID
		{
			get { return empDeptID; }
			set { empDeptID = value; }
		}

		/// <summary>
		/// Gets or sets the DocFileUrl value.
		/// </summary>
		public string DocFileUrl
		{
			get { return docFileUrl; }
			set { docFileUrl = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public bool Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the BannerID value.
		/// </summary>
		public int BannerID
		{
			get { return bannerID; }
			set { bannerID = value; }
		}

		/// <summary>
		/// Gets or sets the BannerBookMarksID value.
		/// </summary>
		private int _bannerBookMarksID=0;
		public int BannerBookMarksID
		{
			get { return  _bannerBookMarksID; }
			set { _bannerBookMarksID = value; }
		}

		/// <summary>
		/// Gets or sets the BannerEndDate value.
		/// </summary>
		private DateTime _bannerEndDate=DateTime.MaxValue;
		public DateTime BannerEndDate
		{
			get { return  _bannerEndDate; }
			set { _bannerEndDate = value; }
		}

		/// <summary>
		/// Gets or sets the BannerStartDate value.
		/// </summary>
		private DateTime _bannerStartDate=DateTime.MaxValue;
		public DateTime BannerStartDate
		{
			get { return  _bannerStartDate; }
			set { _bannerStartDate = value; }
		}

		/// <summary>
		/// Gets or sets the BannerTextToolTip value.
		/// </summary>
		private string _bannerTextToolTip=String.Empty;
		public string BannerTextToolTip
		{
			get { return  _bannerTextToolTip; }
			set { _bannerTextToolTip = value; }
		}

		/// <summary>
		/// Gets or sets the Category value.
		/// </summary>
		private string _category=String.Empty;
		public string Category
		{
			get { return  _category; }
			set { _category = value; }
		}

		/// <summary>
		/// Gets or sets the EmpDeptName value.
		/// </summary>
		private string _empDeptName=String.Empty;
		public string EmpDeptName
		{
			get { return  _empDeptName; }
			set { _empDeptName = value; }
		}

		/// <summary>
		/// Gets or sets the LoginID value.
		/// </summary>
		private long _loginID=0;
		public long LoginID
		{
			get { return  _loginID; }
			set { _loginID = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		private long _roleID=0;
		public long RoleID
		{
			get { return  _roleID; }
			set { _roleID = value; }
		}

		/// <summary>
		/// Gets or sets the RowNumber value.
		/// </summary>
		private int _rowNumber=0;
		public int RowNumber
		{
			get { return  _rowNumber; }
			set { _rowNumber = value; }
		}


		#endregion
}
}
