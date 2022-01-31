using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class TemplateDetailMaster
	{
		#region Fields

		private int parentTemplateID=0;
		private int childReportID=0;
		private string reportType=String.Empty;
		private string reportTemplateName=String.Empty;
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
		/// Gets or sets the ReportType value.
		/// </summary>
		public string ReportType
		{
			get { return reportType; }
			set { reportType = value; }
		}

		/// <summary>
		/// Gets or sets the ReportTemplateName value.
		/// </summary>
		public string ReportTemplateName
		{
			get { return reportTemplateName; }
			set { reportTemplateName = value; }
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
