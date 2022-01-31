using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PageMapping
	{
		#region Fields

		private long id=0;
		private long roleId=0;
		private long pageID=0;
		private string description=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private string modifiedBy=String.Empty;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long seqNo=0;
		private long createdBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public long Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the RoleId value.
		/// </summary>
		public long RoleId
		{
			get { return roleId; }
			set { roleId = value; }
		}

		/// <summary>
		/// Gets or sets the PageID value.
		/// </summary>
		public long PageID
		{
			get { return pageID; }
			set { pageID = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
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
		public string ModifiedBy
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
		/// Gets or sets the SeqNo value.
		/// </summary>
		public long SeqNo
		{
			get { return seqNo; }
			set { seqNo = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}


		#endregion
}
}
