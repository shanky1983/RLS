using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class TaskActions
	{
		#region Fields

		private int taskActionID=0;
		private string actionName=String.Empty;
		private string redirectURL=String.Empty;
		private string displayTextTemplate=String.Empty;
		private int orgID=0;
		private string category=String.Empty;
		private long roleID=0;
		private int moduleID=0;
		private string isShareable=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string categoryText=String.Empty;
		private string languageCode=String.Empty;
		private string displayText=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TaskActionID value.
		/// </summary>
		public int TaskActionID
		{
			get { return taskActionID; }
			set { taskActionID = value; }
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
		/// Gets or sets the RedirectURL value.
		/// </summary>
		public string RedirectURL
		{
			get { return redirectURL; }
			set { redirectURL = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayTextTemplate value.
		/// </summary>
		public string DisplayTextTemplate
		{
			get { return displayTextTemplate; }
			set { displayTextTemplate = value; }
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
		/// Gets or sets the Category value.
		/// </summary>
		public string Category
		{
			get { return category; }
			set { category = value; }
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
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
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
		/// Gets or sets the CategoryText value.
		/// </summary>
		public string CategoryText
		{
			get { return categoryText; }
			set { categoryText = value; }
		}

		/// <summary>
		/// Gets or sets the LanguageCode value.
		/// </summary>
		public string LanguageCode
		{
			get { return languageCode; }
			set { languageCode = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayText value.
		/// </summary>
		public string DisplayText
		{
			get { return displayText; }
			set { displayText = value; }
		}


		#endregion
}
}
