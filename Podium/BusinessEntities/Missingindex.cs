using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Missingindex
	{
		#region Fields

		private int sno=0;
		private decimal avgpercent=Decimal.Zero;
		private int seek=0;
		private string tableName=String.Empty;
		private string indexcol=String.Empty;
		private string include=String.Empty;
		private string indexname=String.Empty;
		private string script=String.Empty;

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
		/// Gets or sets the Avgpercent value.
		/// </summary>
		public decimal Avgpercent
		{
			get { return avgpercent; }
			set { avgpercent = value; }
		}

		/// <summary>
		/// Gets or sets the Seek value.
		/// </summary>
		public int Seek
		{
			get { return seek; }
			set { seek = value; }
		}

		/// <summary>
		/// Gets or sets the TableName value.
		/// </summary>
		public string TableName
		{
			get { return tableName; }
			set { tableName = value; }
		}

		/// <summary>
		/// Gets or sets the Indexcol value.
		/// </summary>
		public string Indexcol
		{
			get { return indexcol; }
			set { indexcol = value; }
		}

		/// <summary>
		/// Gets or sets the Include value.
		/// </summary>
		public string Include
		{
			get { return include; }
			set { include = value; }
		}

		/// <summary>
		/// Gets or sets the Indexname value.
		/// </summary>
		public string Indexname
		{
			get { return indexname; }
			set { indexname = value; }
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
