using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Tblindexinfo
	{
		#region Fields

		private int sno=0;
		private string tablename=String.Empty;
		private string constraintName=String.Empty;
		private string indexType=String.Empty;
		private string indexColumn=String.Empty;
		private string includeColumn=String.Empty;
		private string script=String.Empty;
		private string server=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Sno value.
		/// </summary>
		public int Sno
		{
			get { return sno; }
			set { sno = value; }
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
		/// Gets or sets the ConstraintName value.
		/// </summary>
		public string ConstraintName
		{
			get { return constraintName; }
			set { constraintName = value; }
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

		/// <summary>
		/// Gets or sets the Server value.
		/// </summary>
		public string Server
		{
			get { return server; }
			set { server = value; }
		}


		#endregion
}
}
