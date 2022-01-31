using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class DynamicColumnMapping
	{
		#region Fields

		private int dynamicColumnMappingID=0;
		private int searchTypeID=0;
		private int searchColumnID=0;
		private int orgID=0;
		private int orgAddID=0;
		private string deleted=String.Empty;
		private string visible=String.Empty;
		private string displayText=String.Empty;
		private string langCode=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DynamicColumnMappingID value.
		/// </summary>
		public int DynamicColumnMappingID
		{
			get { return dynamicColumnMappingID; }
			set { dynamicColumnMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the SearchTypeID value.
		/// </summary>
		public int SearchTypeID
		{
			get { return searchTypeID; }
			set { searchTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the SearchColumnID value.
		/// </summary>
		public int SearchColumnID
		{
			get { return searchColumnID; }
			set { searchColumnID = value; }
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
		/// Gets or sets the OrgAddID value.
		/// </summary>
		public int OrgAddID
		{
			get { return orgAddID; }
			set { orgAddID = value; }
		}

		/// <summary>
		/// Gets or sets the Deleted value.
		/// </summary>
		public string Deleted
		{
			get { return deleted; }
			set { deleted = value; }
		}

		/// <summary>
		/// Gets or sets the Visible value.
		/// </summary>
		public string Visible
		{
			get { return visible; }
			set { visible = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
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
		/// Gets or sets the SearchColumnName value.
		/// </summary>
		string _searchcolumnname;
		public string SearchColumnName
		{
			get { return _searchcolumnname; }
			set { _searchcolumnname = value; }
		}

		/// <summary>
		/// Gets or sets the SearchTypeName value.
		/// </summary>
		string _searchtypename;
		public string SearchTypeName
		{
			get { return _searchtypename; }
			set { _searchtypename = value; }
		}


		#endregion
}
}
