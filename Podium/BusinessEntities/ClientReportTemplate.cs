using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ClientReportTemplate
	{
		#region Fields

		private int parentTemplateID=0;
		private int childReportID=0;
		private long iD=0;
		private string isDefault=String.Empty;
		private string type=String.Empty;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ParentTemplateID value.
		/// </summary>
		public int ParentTemplateID
		{
			get { return parentTemplateID; }
			set { parentTemplateID = value; }
		}

		/// <summary>
		/// Gets or sets the ChildReportID value.
		/// </summary>
		public int ChildReportID
		{
			get { return childReportID; }
			set { childReportID = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the IsDefault value.
		/// </summary>
		public string IsDefault
		{
			get { return isDefault; }
			set { isDefault = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
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
		/// Gets or sets the TemplateTypeID value.
		/// </summary>
		private int _templateTypeID=0;
		public int TemplateTypeID
		{
			get { return  _templateTypeID; }
			set { _templateTypeID = value; }
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

		/// <summary>
		/// Gets or sets the TemplateName value.
		/// </summary>
		private string _templateName=String.Empty;
		public string TemplateName
		{
			get { return  _templateName; }
			set { _templateName = value; }
		}

		/// <summary>
		/// Gets or sets the ReportTemplateName value.
		/// </summary>
		private string _reportTemplateName=String.Empty;
		public string ReportTemplateName
		{
			get { return  _reportTemplateName; }
			set { _reportTemplateName = value; }
		}


		#endregion
}
}
