using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class VisitKnowledgeMapping
	{
		#region Fields

		private long visitKnowledgeMappingID=0;
		private short knowledgeOfServiceID=0;
		private long attributeID=0;
		private string description=String.Empty;
		private long visitID=0;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the VisitKnowledgeMappingID value.
		/// </summary>
		public long VisitKnowledgeMappingID
		{
			get { return visitKnowledgeMappingID; }
			set { visitKnowledgeMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the KnowledgeOfServiceID value.
		/// </summary>
		public short KnowledgeOfServiceID
		{
			get { return knowledgeOfServiceID; }
			set { knowledgeOfServiceID = value; }
		}

		/// <summary>
		/// Gets or sets the AttributeID value.
		/// </summary>
		public long AttributeID
		{
			get { return attributeID; }
			set { attributeID = value; }
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
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
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
