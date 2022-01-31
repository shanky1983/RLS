using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class QuestionaryTemplateMaster
	{
		#region Fields

		private long templateID=0;
		private string templateText=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string templateName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TemplateID value.
		/// </summary>
		public long TemplateID
		{
			get { return templateID; }
			set { templateID = value; }
		}

		/// <summary>
		/// Gets or sets the TemplateText value.
		/// </summary>
		public string TemplateText
		{
			get { return templateText; }
			set { templateText = value; }
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
		/// Gets or sets the TemplateName value.
		/// </summary>
		public string TemplateName
		{
			get { return templateName; }
			set { templateName = value; }
		}


		#endregion
}
}
