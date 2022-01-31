using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ReportExcelSp
	{
		#region Fields

		private int iD=0;
		private string name=String.Empty;
		private string description=String.Empty;
		private int orgID=0;
		private int reportGroupID=0;
		private string dataSetname=String.Empty;
		private string reportPath=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
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
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
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
		/// Gets or sets the ReportGroupID value.
		/// </summary>
		public int ReportGroupID
		{
			get { return reportGroupID; }
			set { reportGroupID = value; }
		}

		/// <summary>
		/// Gets or sets the DataSetname value.
		/// </summary>
		public string DataSetname
		{
			get { return dataSetname; }
			set { dataSetname = value; }
		}

		/// <summary>
		/// Gets or sets the ReportPath value.
		/// </summary>
		public string ReportPath
		{
			get { return reportPath; }
			set { reportPath = value; }
		}


		#endregion
}
}
