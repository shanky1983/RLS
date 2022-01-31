using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PageContextActionMapping
	{
		#region Fields

		private long mappingID=0;
		private long pageContextID=0;
		private long roleID=0;
		private int actionTypeID=0;
		private int templateID=0;
		private string contextType=String.Empty;
		private string additionalContext=String.Empty;
		private string description=String.Empty;
		private string isAttachment=String.Empty;
		private string category=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MappingID value.
		/// </summary>
		public long MappingID
		{
			get { return mappingID; }
			set { mappingID = value; }
		}

		/// <summary>
		/// Gets or sets the PageContextID value.
		/// </summary>
		public long PageContextID
		{
			get { return pageContextID; }
			set { pageContextID = value; }
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
		/// Gets or sets the ActionTypeID value.
		/// </summary>
		public int ActionTypeID
		{
			get { return actionTypeID; }
			set { actionTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the TemplateID value.
		/// </summary>
		public int TemplateID
		{
			get { return templateID; }
			set { templateID = value; }
		}

		/// <summary>
		/// Gets or sets the ContextType value.
		/// </summary>
		public string ContextType
		{
			get { return contextType; }
			set { contextType = value; }
		}

		/// <summary>
		/// Gets or sets the AdditionalContext value.
		/// </summary>
		public string AdditionalContext
		{
			get { return additionalContext; }
			set { additionalContext = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Gets or sets the IsAttachment value.
		/// </summary>
		public string IsAttachment
		{
			get { return isAttachment; }
			set { isAttachment = value; }
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
		/// Gets or sets the RoleName value.
		/// </summary>
		private string _roleName=String.Empty;
		public string RoleName
		{
			get { return  _roleName; }
			set { _roleName = value; }
		}

		/// <summary>
		/// Gets or sets the PageName value.
		/// </summary>
		private string _pageName=String.Empty;
		public string PageName
		{
			get { return  _pageName; }
			set { _pageName = value; }
		}

		/// <summary>
		/// Gets or sets the ActionType value.
		/// </summary>
		private string _actionType=String.Empty;
		public string ActionType
		{
			get { return  _actionType; }
			set { _actionType = value; }
		}

		/// <summary>
		/// Gets or sets the TemplateName value.
		/// </summary>
		private string _templateName=String.Empty;
		public string TemplateName
		{
			get { return  _templateName; }
			set { _templateName = value; }
		}


		#endregion
}
}
