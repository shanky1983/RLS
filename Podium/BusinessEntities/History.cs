using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class History
	{
		#region Fields

		private int historyID=0;
		private string historyName=String.Empty;
		private int parentID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string hashAttribute=String.Empty;
		private string type=String.Empty;
		private string controlType=String.Empty;
		private string isActive=String.Empty;
		private int orgID=0;
		private string historyCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the HistoryID value.
		/// </summary>
		public int HistoryID
		{
			get { return historyID; }
			set { historyID = value; }
		}

		/// <summary>
		/// Gets or sets the HistoryName value.
		/// </summary>
		public string HistoryName
		{
			get { return historyName; }
			set { historyName = value; }
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
		/// Gets or sets the HashAttribute value.
		/// </summary>
		public string HashAttribute
		{
			get { return hashAttribute; }
			set { hashAttribute = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the ControlType value.
		/// </summary>
		public string ControlType
		{
			get { return controlType; }
			set { controlType = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
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
		/// Gets or sets the HistoryCode value.
		/// </summary>
		public string HistoryCode
		{
			get { return historyCode; }
			set { historyCode = value; }
		}

		/// <summary>
		/// Gets or sets the HasChild value.
		/// </summary>
		private int _hasChild=0;
		public int HasChild
		{
			get { return  _hasChild; }
			set { _hasChild = value; }
		}

		/// <summary>
		/// Gets or sets the OperationType value.
		/// </summary>
		private string _operationType=String.Empty;
		public string OperationType
		{
			get { return  _operationType; }
			set { _operationType = value; }
		}


		#endregion
}
}
