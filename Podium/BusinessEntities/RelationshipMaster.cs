using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class RelationshipMaster
	{
		#region Fields

		private long relationshipID=0;
		private string relationshipName=String.Empty;
		private long orgID=0;
		private string isDeleted=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string relationType=String.Empty;
		private string relation=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RelationshipID value.
		/// </summary>
		public long RelationshipID
		{
			get { return relationshipID; }
			set { relationshipID = value; }
		}

		/// <summary>
		/// Gets or sets the RelationshipName value.
		/// </summary>
		public string RelationshipName
		{
			get { return relationshipName; }
			set { relationshipName = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the IsDeleted value.
		/// </summary>
		public string IsDeleted
		{
			get { return isDeleted; }
			set { isDeleted = value; }
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
		/// Gets or sets the RelationType value.
		/// </summary>
		public string RelationType
		{
			get { return relationType; }
			set { relationType = value; }
		}

		/// <summary>
		/// Gets or sets the Relation value.
		/// </summary>
		public string Relation
		{
			get { return relation; }
			set { relation = value; }
		}


		#endregion
}
}
