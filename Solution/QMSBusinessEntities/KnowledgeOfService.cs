using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class KnowledgeOfService
	{
		#region Fields

		private short knowledgeOfServiceID=0;
		private string knowledgeOfServiceName=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the KnowledgeOfServiceID value.
		/// </summary>
		public short KnowledgeOfServiceID
		{
			get { return knowledgeOfServiceID; }
			set { knowledgeOfServiceID = value; }
		}

		/// <summary>
		/// Gets or sets the KnowledgeOfServiceName value.
		/// </summary>
		public string KnowledgeOfServiceName
		{
			get { return knowledgeOfServiceName; }
			set { knowledgeOfServiceName = value; }
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


		#endregion
}
}
