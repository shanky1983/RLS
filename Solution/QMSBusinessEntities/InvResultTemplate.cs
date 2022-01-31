using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvResultTemplate
	{
		#region Fields

		private int resultID=0;
		private string resultName=String.Empty;
		private string resultValues=String.Empty;
		private string resultTemplateType=String.Empty;
		private int orgID=0;
		private long deptID=0;
		private long rowID=0;
		private string langCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ResultID value.
		/// </summary>
		public int ResultID
		{
			get { return resultID; }
			set { resultID = value; }
		}

		/// <summary>
		/// Gets or sets the ResultName value.
		/// </summary>
		public string ResultName
		{
			get { return resultName; }
			set { resultName = value; }
		}

		/// <summary>
		/// Gets or sets the ResultValues value.
		/// </summary>
		public string ResultValues
		{
			get { return resultValues; }
			set { resultValues = value; }
		}

		/// <summary>
		/// Gets or sets the ResultTemplateType value.
		/// </summary>
		public string ResultTemplateType
		{
			get { return resultTemplateType; }
			set { resultTemplateType = value; }
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
		/// Gets or sets the DeptID value.
		/// </summary>
		public long DeptID
		{
			get { return deptID; }
			set { deptID = value; }
		}

		/// <summary>
		/// Gets or sets the RowID value.
		/// </summary>
		public long RowID
		{
			get { return rowID; }
			set { rowID = value; }
		}

		/// <summary>
		/// Gets or sets the LangCode value.
		/// </summary>
		public string LangCode
		{
			get { return langCode; }
			set { langCode = value; }
		}


		#endregion
}
}
