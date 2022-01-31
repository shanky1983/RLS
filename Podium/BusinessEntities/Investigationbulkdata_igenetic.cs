using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Investigationbulkdata_igenetic
	{
		#region Fields

		private long resultID=0;
		private long investigationID=0;
		private string name=String.Empty;
		private string valu=String.Empty;
		private long investigationMethodID=0;
		private string abnormalFlag=String.Empty;
		private string type=String.Empty;
		private int iD=0;
		private int seqno=0;
		private int isStatus=0;
		private int orgID=0;
		private string langCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ResultID value.
		/// </summary>
		public long ResultID
		{
			get { return resultID; }
			set { resultID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
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
		/// Gets or sets the Valu value.
		/// </summary>
		public string Value
		{
			get { return valu; }
			set { valu = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationMethodID value.
		/// </summary>
		public long InvestigationMethodID
		{
			get { return investigationMethodID; }
			set { investigationMethodID = value; }
		}

		/// <summary>
		/// Gets or sets the AbnormalFlag value.
		/// </summary>
		public string AbnormalFlag
		{
			get { return abnormalFlag; }
			set { abnormalFlag = value; }
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
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the Seqno value.
		/// </summary>
		public int Seqno
		{
			get { return seqno; }
			set { seqno = value; }
		}

		/// <summary>
		/// Gets or sets the IsStatus value.
		/// </summary>
		public int IsStatus
		{
			get { return isStatus; }
			set { isStatus = value; }
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
