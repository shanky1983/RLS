using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class RuleApprovelMaster
	{
		#region Fields

		private int ruleApprovelID=0;
		private int ruleID=0;
		private int seqNo=0;
		private int statusID=0;
		private bool isActive=false;
		private int nextActionID=0;
		private int orgID=0;
		private int nextStatusID=0;
		private long roleID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RuleApprovelID value.
		/// </summary>
		public int RuleApprovelID
		{
			get { return ruleApprovelID; }
			set { ruleApprovelID = value; }
		}

		/// <summary>
		/// Gets or sets the RuleID value.
		/// </summary>
		public int RuleID
		{
			get { return ruleID; }
			set { ruleID = value; }
		}

		/// <summary>
		/// Gets or sets the SeqNo value.
		/// </summary>
		public int SeqNo
		{
			get { return seqNo; }
			set { seqNo = value; }
		}

		/// <summary>
		/// Gets or sets the StatusID value.
		/// </summary>
		public int StatusID
		{
			get { return statusID; }
			set { statusID = value; }
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
		/// Gets or sets the NextActionID value.
		/// </summary>
		public int NextActionID
		{
			get { return nextActionID; }
			set { nextActionID = value; }
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
		/// Gets or sets the NextStatusID value.
		/// </summary>
		public int NextStatusID
		{
			get { return nextStatusID; }
			set { nextStatusID = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		public long RoleID
		{
			get { return roleID; }
			set { roleID = value; }
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
