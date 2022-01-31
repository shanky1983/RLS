using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
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


		#endregion
}
}
