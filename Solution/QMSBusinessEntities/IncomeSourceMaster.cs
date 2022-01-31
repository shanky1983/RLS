using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class IncomeSourceMaster
	{
		#region Fields

		private int sourceID=0;
		private string sourceName=String.Empty;
		private string sourceDescription=String.Empty;
		private string code=String.Empty;
		private string langCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SourceID value.
		/// </summary>
		public int SourceID
		{
			get { return sourceID; }
			set { sourceID = value; }
		}

		/// <summary>
		/// Gets or sets the SourceName value.
		/// </summary>
		public string SourceName
		{
			get { return sourceName; }
			set { sourceName = value; }
		}

		/// <summary>
		/// Gets or sets the SourceDescription value.
		/// </summary>
		public string SourceDescription
		{
			get { return sourceDescription; }
			set { sourceDescription = value; }
		}

		/// <summary>
		/// Gets or sets the Code value.
		/// </summary>
		public string Code
		{
			get { return code; }
			set { code = value; }
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
