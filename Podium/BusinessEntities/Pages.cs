using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Pages
	{
		#region Fields

		private long pageID=0;
		private string pageName=String.Empty;
		private string pageURL=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int moduleID=0;
		private string isShareable=String.Empty;
		private string sequenceId=String.Empty;
		private string templateUrl=String.Empty;
		private string controller=String.Empty;
		private string isLockedPage=String.Empty;
		private string lockedPageID=String.Empty;
		private string isLocationBased=String.Empty;
		private string pageType=String.Empty;
		private bool hasPageConfig=false;
		private string dependencies=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PageID value.
		/// </summary>
		public long PageID
		{
			get { return pageID; }
			set { pageID = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
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
		/// Gets or sets the ModuleID value.
		/// </summary>
		public int ModuleID
		{
			get { return moduleID; }
			set { moduleID = value; }
		}

		/// <summary>
		/// Gets or sets the IsShareable value.
		/// </summary>
		public string IsShareable
		{
			get { return isShareable; }
			set { isShareable = value; }
		}

		/// <summary>
		/// Gets or sets the SequenceId value.
		/// </summary>
		public string SequenceId
		{
			get { return sequenceId; }
			set { sequenceId = value; }
		}

		/// <summary>
		/// Gets or sets the TemplateUrl value.
		/// </summary>
		public string TemplateUrl
		{
			get { return templateUrl; }
			set { templateUrl = value; }
		}

		/// <summary>
		/// Gets or sets the Controller value.
		/// </summary>
		public string Controller
		{
			get { return controller; }
			set { controller = value; }
		}

		/// <summary>
		/// Gets or sets the IsLockedPage value.
		/// </summary>
		public string IsLockedPage
		{
			get { return isLockedPage; }
			set { isLockedPage = value; }
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
		/// Gets or sets the IsLocationBased value.
		/// </summary>
		public string IsLocationBased
		{
			get { return isLocationBased; }
			set { isLocationBased = value; }
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
		/// Gets or sets the HasPageConfig value.
		/// </summary>
		public bool HasPageConfig
		{
			get { return hasPageConfig; }
			set { hasPageConfig = value; }
		}

		/// <summary>
		/// Gets or sets the Dependencies value.
		/// </summary>
		public string Dependencies
		{
			get { return dependencies; }
			set { dependencies = value; }
		}


		#endregion
}
}
