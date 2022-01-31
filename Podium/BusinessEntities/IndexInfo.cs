using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class IndexInfo
	{
		#region Fields

		private string tablename=String.Empty;
		private string indexName=String.Empty;
		private string indexType=String.Empty;
		private string indexColumn=String.Empty;
		private string includeColumn=String.Empty;
		private string script=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Tablename value.
		/// </summary>
		public string Tablename
		{
			get { return tablename; }
			set { tablename = value; }
		}

		/// <summary>
		/// Gets or sets the IndexName value.
		/// </summary>
		public string IndexName
		{
			get { return indexName; }
			set { indexName = value; }
		}

		/// <summary>
		/// Gets or sets the IndexType value.
		/// </summary>
		public string IndexType
		{
			get { return indexType; }
			set { indexType = value; }
		}

		/// <summary>
		/// Gets or sets the IndexColumn value.
		/// </summary>
		public string IndexColumn
		{
			get { return indexColumn; }
			set { indexColumn = value; }
		}

		/// <summary>
		/// Gets or sets the IncludeColumn value.
		/// </summary>
		public string IncludeColumn
		{
			get { return includeColumn; }
			set { includeColumn = value; }
		}

		/// <summary>
		/// Gets or sets the Script value.
		/// </summary>
		public string Script
		{
			get { return script; }
			set { script = value; }
		}


		#endregion
}
}
