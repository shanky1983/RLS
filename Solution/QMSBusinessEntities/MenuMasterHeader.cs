using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class MenuMasterHeader
	{
		#region Fields

		private int parentID=0;
		private string headerCode=String.Empty;
		private string headerText=String.Empty;
		private string languageCode=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string cssClass=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ParentID value.
		/// </summary>
		public int ParentID
		{
			get { return parentID; }
			set { parentID = value; }
		}

		/// <summary>
		/// Gets or sets the HeaderCode value.
		/// </summary>
		public string HeaderCode
		{
			get { return headerCode; }
			set { headerCode = value; }
		}

		/// <summary>
		/// Gets or sets the HeaderText value.
		/// </summary>
		public string HeaderText
		{
			get { return headerText; }
			set { headerText = value; }
		}

		/// <summary>
		/// Gets or sets the LanguageCode value.
		/// </summary>
		public string LanguageCode
		{
			get { return languageCode; }
			set { languageCode = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
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

		/// <summary>
		/// Gets or sets the CssClass value.
		/// </summary>
		public string CssClass
		{
			get { return cssClass; }
			set { cssClass = value; }
		}


		#endregion
}
}
