using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PMSProcedureParameters
	{
		#region Fields

		private long iD=0;
		private string procedureName=String.Empty;
		private string paramName=String.Empty;
		private string displayName=String.Empty;
		private long defaultValue=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long procedureID=0;
		private long paramQueryID=0;
		private bool optional=false;

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
		/// Gets or sets the ProcedureName value.
		/// </summary>
		public string ProcedureName
		{
			get { return procedureName; }
			set { procedureName = value; }
		}

		/// <summary>
		/// Gets or sets the ParamName value.
		/// </summary>
		public string ParamName
		{
			get { return paramName; }
			set { paramName = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayName value.
		/// </summary>
		public string DisplayName
		{
			get { return displayName; }
			set { displayName = value; }
		}

		/// <summary>
		/// Gets or sets the DefaultValue value.
		/// </summary>
		public long DefaultValue
		{
			get { return defaultValue; }
			set { defaultValue = value; }
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
		/// Gets or sets the ProcedureID value.
		/// </summary>
		public long ProcedureID
		{
			get { return procedureID; }
			set { procedureID = value; }
		}

		/// <summary>
		/// Gets or sets the ParamQueryID value.
		/// </summary>
		public long ParamQueryID
		{
			get { return paramQueryID; }
			set { paramQueryID = value; }
		}

		/// <summary>
		/// Gets or sets the Optional value.
		/// </summary>
		public bool Optional
		{
			get { return optional; }
			set { optional = value; }
		}


		#endregion
}
}
