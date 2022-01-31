using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ActionTemplate
	{
		#region Fields

		private int templateID=0;
		private int templateTypeID=0;
		private string template=String.Empty;
		private string subject=String.Empty;
		private string templateName=String.Empty;
		private string attachmentName=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TemplateID value.
		/// </summary>
		public int TemplateID
		{
			get { return templateID; }
			set { templateID = value; }
		}

		/// <summary>
		/// Gets or sets the TemplateTypeID value.
		/// </summary>
		public int TemplateTypeID
		{
			get { return templateTypeID; }
			set { templateTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the Template value.
		/// </summary>
		public string Template
		{
			get { return template; }
			set { template = value; }
		}

		/// <summary>
		/// Gets or sets the Subject value.
		/// </summary>
		public string Subject
		{
			get { return subject; }
			set { subject = value; }
		}

		/// <summary>
		/// Gets or sets the TemplateName value.
		/// </summary>
		public string TemplateName
		{
			get { return templateName; }
			set { templateName = value; }
		}

		/// <summary>
		/// Gets or sets the AttachmentName value.
		/// </summary>
		public string AttachmentName
		{
			get { return attachmentName; }
			set { attachmentName = value; }
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
		/// Gets or sets the TemplateType value.
		/// </summary>
		private string _templateType=String.Empty;
		public string TemplateType
		{
			get { return  _templateType; }
			set { _templateType = value; }
		}


		#endregion
}
}
