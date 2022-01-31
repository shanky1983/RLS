using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvReportTemplateFooter
	{
		#region Fields

		private string source=String.Empty;
		private string title=String.Empty;
		private string name=String.Empty;
		private string designation=String.Empty;
		private int orgID=0;
		private long investigationID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Source value.
		/// </summary>
		public string Source
		{
			get { return source; }
			set { source = value; }
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
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Gets or sets the Designation value.
		/// </summary>
		public string Designation
		{
			get { return designation; }
			set { designation = value; }
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
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}


		#endregion
}
}
