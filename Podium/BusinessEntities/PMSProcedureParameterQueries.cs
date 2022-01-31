using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PMSProcedureParameterQueries
	{
		#region Fields

		private long iD=0;
		private string queryName=String.Empty;
		private string query=String.Empty;
		private string displayType=String.Empty;
		private string queryType=String.Empty;
		private bool isActive=false;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string inputType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the QueryName value.
		/// </summary>
		public string QueryName
		{
			get { return queryName; }
			set { queryName = value; }
		}

		/// <summary>
		/// Gets or sets the Query value.
		/// </summary>
		public string Query
		{
			get { return query; }
			set { query = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayType value.
		/// </summary>
		public string DisplayType
		{
			get { return displayType; }
			set { displayType = value; }
		}

		/// <summary>
		/// Gets or sets the QueryType value.
		/// </summary>
		public string QueryType
		{
			get { return queryType; }
			set { queryType = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public bool IsActive
		{
			get { return isActive; }
			set { isActive = value; }
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

		/// <summary>
		/// Gets or sets the InputType value.
		/// </summary>
		public string InputType
		{
			get { return inputType; }
			set { inputType = value; }
		}


		#endregion
}
}
