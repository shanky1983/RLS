using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Indexinfo_2
	{
		#region Fields

		private int objectid=0;
		private string tablename=String.Empty;
		private string indexName=String.Empty;
		private short indexid=0;
		private string dropindex=String.Empty;
		private string indexType=String.Empty;
		private string indexColumn=String.Empty;
		private string includeColumn=String.Empty;
		private string filteredindex=String.Empty;
		private string script=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Objectid value.
		/// </summary>
		public int Objectid
		{
			get { return objectid; }
			set { objectid = value; }
		}

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
		/// Gets or sets the Indexid value.
		/// </summary>
		public short Indexid
		{
			get { return indexid; }
			set { indexid = value; }
		}

		/// <summary>
		/// Gets or sets the Dropindex value.
		/// </summary>
		public string Dropindex
		{
			get { return dropindex; }
			set { dropindex = value; }
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
		/// Gets or sets the Filteredindex value.
		/// </summary>
		public string Filteredindex
		{
			get { return filteredindex; }
			set { filteredindex = value; }
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
