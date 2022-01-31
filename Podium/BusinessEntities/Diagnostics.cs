using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Diagnostics
	{
		#region Fields

		private int diagnosticsID=0;
		private string diagnosticsName=String.Empty;
		private string diagnosticsDesc=String.Empty;
		private string diagnosticsType=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int parentID=0;
		private string hashAttribute=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DiagnosticsID value.
		/// </summary>
		public int DiagnosticsID
		{
			get { return diagnosticsID; }
			set { diagnosticsID = value; }
		}

		/// <summary>
		/// Gets or sets the DiagnosticsName value.
		/// </summary>
		public string DiagnosticsName
		{
			get { return diagnosticsName; }
			set { diagnosticsName = value; }
		}

		/// <summary>
		/// Gets or sets the DiagnosticsDesc value.
		/// </summary>
		public string DiagnosticsDesc
		{
			get { return diagnosticsDesc; }
			set { diagnosticsDesc = value; }
		}

		/// <summary>
		/// Gets or sets the DiagnosticsType value.
		/// </summary>
		public string DiagnosticsType
		{
			get { return diagnosticsType; }
			set { diagnosticsType = value; }
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
		/// Gets or sets the ParentID value.
		/// </summary>
		public int ParentID
		{
			get { return parentID; }
			set { parentID = value; }
		}

		/// <summary>
		/// Gets or sets the HashAttribute value.
		/// </summary>
		public string HashAttribute
		{
			get { return hashAttribute; }
			set { hashAttribute = value; }
		}


		#endregion
}
}
