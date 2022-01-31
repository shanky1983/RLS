using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ReportExcelMaster
	{
		#region Fields

		private int iD=0;
		private string excelName=String.Empty;
		private int sp=0;
		private string reportName=String.Empty;
		private string parametertype=String.Empty;
		private short parametervalue=0;
		private bool isActive=true;

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
		/// Gets or sets the ExcelName value.
		/// </summary>
		public string ExcelName
		{
			get { return excelName; }
			set { excelName = value; }
		}

		/// <summary>
		/// Gets or sets the Sp value.
		/// </summary>
		public int Sp
		{
			get { return sp; }
			set { sp = value; }
		}

		/// <summary>
		/// Gets or sets the ReportName value.
		/// </summary>
		public string ReportName
		{
			get { return reportName; }
			set { reportName = value; }
		}

		/// <summary>
		/// Gets or sets the Parametertype value.
		/// </summary>
		public string Parametertype
		{
			get { return parametertype; }
			set { parametertype = value; }
		}

		/// <summary>
		/// Gets or sets the Parametervalue value.
		/// </summary>
		public short Parametervalue
		{
			get { return parametervalue; }
			set { parametervalue = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public bool IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}


		#endregion
}
}
