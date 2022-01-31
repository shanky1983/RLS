using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PageLangMapping
	{
		#region Fields

		private long pageMappingID=0;
		private long pageID=0;
		private string displayText=String.Empty;
		private string langCode=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PageMappingID value.
		/// </summary>
		public long PageMappingID
		{
			get { return pageMappingID; }
			set { pageMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the PageID value.
		/// </summary>
		public long PageID
		{
			get { return pageID; }
			set { pageID = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}


		#endregion
}
}
