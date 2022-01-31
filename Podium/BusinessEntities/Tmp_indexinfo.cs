using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Tmp_indexinfo
	{
		#region Fields

		private string queryDatabase=String.Empty;
		private byte[] sql_handle=new byte[0];
		private string objectSchemaName=String.Empty;
		private string objectName=String.Empty;
		private string sqlText=String.Empty;
		private long total_elapsed_time=0;
		private DateTime last_execution_time=DateTime.MaxValue;
		private long execution_count=0;
		private long total_logical_writes=0;
		private long total_logical_reads=0;
		private long min_elapsed_time=0;
		private long max_elapsed_time=0;
		private string query_plan=String.Empty;
		private string tableDatabase=String.Empty;
		private string tableName=String.Empty;
		private string tableSchema=String.Empty;
		private decimal projectedImpact=Decimal.Zero;
		private string indexColumns=String.Empty;
		private string includedColumns=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the QueryDatabase value.
		/// </summary>
		public string QueryDatabase
		{
			get { return queryDatabase; }
			set { queryDatabase = value; }
		}

		/// <summary>
		/// Gets or sets the Sql_handle value.
		/// </summary>
		public byte[] Sql_handle
		{
			get { return sql_handle; }
			set { sql_handle = value; }
		}

		/// <summary>
		/// Gets or sets the ObjectSchemaName value.
		/// </summary>
		public string ObjectSchemaName
		{
			get { return objectSchemaName; }
			set { objectSchemaName = value; }
		}

		/// <summary>
		/// Gets or sets the ObjectName value.
		/// </summary>
		public string ObjectName
		{
			get { return objectName; }
			set { objectName = value; }
		}

		/// <summary>
		/// Gets or sets the SqlText value.
		/// </summary>
		public string SqlText
		{
			get { return sqlText; }
			set { sqlText = value; }
		}

		/// <summary>
		/// Gets or sets the Total_elapsed_time value.
		/// </summary>
		public long Total_elapsed_time
		{
			get { return total_elapsed_time; }
			set { total_elapsed_time = value; }
		}

		/// <summary>
		/// Gets or sets the Last_execution_time value.
		/// </summary>
		public DateTime Last_execution_time
		{
			get { return last_execution_time; }
			set { last_execution_time = value; }
		}

		/// <summary>
		/// Gets or sets the Execution_count value.
		/// </summary>
		public long Execution_count
		{
			get { return execution_count; }
			set { execution_count = value; }
		}

		/// <summary>
		/// Gets or sets the Total_logical_writes value.
		/// </summary>
		public long Total_logical_writes
		{
			get { return total_logical_writes; }
			set { total_logical_writes = value; }
		}

		/// <summary>
		/// Gets or sets the Total_logical_reads value.
		/// </summary>
		public long Total_logical_reads
		{
			get { return total_logical_reads; }
			set { total_logical_reads = value; }
		}

		/// <summary>
		/// Gets or sets the Min_elapsed_time value.
		/// </summary>
		public long Min_elapsed_time
		{
			get { return min_elapsed_time; }
			set { min_elapsed_time = value; }
		}

		/// <summary>
		/// Gets or sets the Max_elapsed_time value.
		/// </summary>
		public long Max_elapsed_time
		{
			get { return max_elapsed_time; }
			set { max_elapsed_time = value; }
		}

		/// <summary>
		/// Gets or sets the Query_plan value.
		/// </summary>
		public string Query_plan
		{
			get { return query_plan; }
			set { query_plan = value; }
		}

		/// <summary>
		/// Gets or sets the TableDatabase value.
		/// </summary>
		public string TableDatabase
		{
			get { return tableDatabase; }
			set { tableDatabase = value; }
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
		/// Gets or sets the TableSchema value.
		/// </summary>
		public string TableSchema
		{
			get { return tableSchema; }
			set { tableSchema = value; }
		}

		/// <summary>
		/// Gets or sets the ProjectedImpact value.
		/// </summary>
		public decimal ProjectedImpact
		{
			get { return projectedImpact; }
			set { projectedImpact = value; }
		}

		/// <summary>
		/// Gets or sets the IndexColumns value.
		/// </summary>
		public string IndexColumns
		{
			get { return indexColumns; }
			set { indexColumns = value; }
		}

		/// <summary>
		/// Gets or sets the IncludedColumns value.
		/// </summary>
		public string IncludedColumns
		{
			get { return includedColumns; }
			set { includedColumns = value; }
		}


		#endregion
}
}
