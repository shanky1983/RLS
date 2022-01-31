using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Backupreportmaster
	{
		#region Fields

		private int templateID=0;
		private string reportTemplateName=String.Empty;
		private string isDefault=String.Empty;
		private int orgID=0;
		private string isActive=String.Empty;
		private string type=String.Empty;
		private string templateName=String.Empty;
		private long stationaryID=0;
		private string isSeperatePrint=String.Empty;
		private int iD=0;
		private int templateSeq=0;
		private long imageGroupID=0;
		private int location=0;
		private int templateTypeID=0;

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
		/// Gets or sets the ReportTemplateName value.
		/// </summary>
		public string ReportTemplateName
		{
			get { return reportTemplateName; }
			set { reportTemplateName = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
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
		/// Gets or sets the TemplateName value.
		/// </summary>
		public string TemplateName
		{
			get { return templateName; }
			set { templateName = value; }
		}

		/// <summary>
		/// Gets or sets the StationaryID value.
		/// </summary>
		public long StationaryID
		{
			get { return stationaryID; }
			set { stationaryID = value; }
		}

		/// <summary>
		/// Gets or sets the IsSeperatePrint value.
		/// </summary>
		public string IsSeperatePrint
		{
			get { return isSeperatePrint; }
			set { isSeperatePrint = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the TemplateSeq value.
		/// </summary>
		public int TemplateSeq
		{
			get { return templateSeq; }
			set { templateSeq = value; }
		}

		/// <summary>
		/// Gets or sets the ImageGroupID value.
		/// </summary>
		public long ImageGroupID
		{
			get { return imageGroupID; }
			set { imageGroupID = value; }
		}

		/// <summary>
		/// Gets or sets the Location value.
		/// </summary>
		public int Location
		{
			get { return location; }
			set { location = value; }
		}

		/// <summary>
		/// Gets or sets the TemplateTypeID value.
		/// </summary>
		public int TemplateTypeID
		{
			get { return templateTypeID; }
			set { templateTypeID = value; }
		}


		#endregion
}
}
