using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class IndexInfo
	{
		#region Fields

		private string tableName=String.Empty;
		private string indexcolumn=String.Empty;
		private string indexType=String.Empty;
		private string includecolumn=String.Empty;
		private string script=String.Empty;
		private string indexName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TableName value.
		/// </summary>
		public string TableName
		{
			get { return tableName; }
			set { tableName = value; }
		}

		/// <summary>
		/// Gets or sets the Indexcolumn value.
		/// </summary>
		public string Indexcolumn
		{
			get { return indexcolumn; }
			set { indexcolumn = value; }
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
		/// Gets or sets the Includecolumn value.
		/// </summary>
		public string Includecolumn
		{
			get { return includecolumn; }
			set { includecolumn = value; }
		}

		/// <summary>
		/// Gets or sets the Script value.
		/// </summary>
		public string Script
		{
			get { return script; }
			set { script = value; }
		}

		/// <summary>
		/// Gets or sets the IndexName value.
		/// </summary>
		public string IndexName
		{
			get { return indexName; }
			set { indexName = value; }
		}


		#endregion
}
}
