using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvestigationHeader
	{
		#region Fields

		private long headerID=0;
		private string headerName=String.Empty;
		private string code=String.Empty;
		private long sequenceNo=0;
		private string otherLanguageHeader=String.Empty;
		private bool isActive=false;
		private string langCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the HeaderID value.
		/// </summary>
		public long HeaderID
		{
			get { return headerID; }
			set { headerID = value; }
		}

		/// <summary>
		/// Gets or sets the HeaderName value.
		/// </summary>
		public string HeaderName
		{
			get { return headerName; }
			set { headerName = value; }
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
		/// Gets or sets the SequenceNo value.
		/// </summary>
		public long SequenceNo
		{
			get { return sequenceNo; }
			set { sequenceNo = value; }
		}

		/// <summary>
		/// Gets or sets the OtherLanguageHeader value.
		/// </summary>
		public string OtherLanguageHeader
		{
			get { return otherLanguageHeader; }
			set { otherLanguageHeader = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public bool IsActive
		{
			get { return isActive; }
			set { isActive = value; }
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
