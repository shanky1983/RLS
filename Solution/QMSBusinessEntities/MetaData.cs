using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class MetaData
	{
		#region Fields

		private int metaDataID=0;
		private string domain=String.Empty;
		private string code=String.Empty;
		private string displayText=String.Empty;
		private string langCode=String.Empty;
		private long parentID=0;
		private int seqNo=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MetaDataID value.
		/// </summary>
		public int MetaDataID
		{
			get { return metaDataID; }
			set { metaDataID = value; }
		}

		/// <summary>
		/// Gets or sets the Domain value.
		/// </summary>
		public string Domain
		{
			get { return domain; }
			set { domain = value; }
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
		/// Gets or sets the DisplayText value.
		/// </summary>
		public string DisplayText
		{
			get { return displayText; }
			set { displayText = value; }
		}

		/// <summary>
		/// Gets or sets the LangCode value.
		/// </summary>
		public string LangCode
		{
			get { return langCode; }
			set { langCode = value; }
		}

		/// <summary>
		/// Gets or sets the ParentID value.
		/// </summary>
		public long ParentID
		{
			get { return parentID; }
			set { parentID = value; }
		}

		/// <summary>
		/// Gets or sets the SeqNo value.
		/// </summary>
		public int SeqNo
		{
			get { return seqNo; }
			set { seqNo = value; }
		}


		#endregion
}
}
