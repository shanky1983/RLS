using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InternalAuditObersation_QMS
	{
		#region Fields

		private long internalAuditID=0;
		private long orgID=0;
		private long planScheduleID=0;
		private string auditType=String.Empty;
		private string category=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string observation=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InternalAuditID value.
		/// </summary>
		public long InternalAuditID
		{
			get { return internalAuditID; }
			set { internalAuditID = value; }
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
		/// Gets or sets the PlanScheduleID value.
		/// </summary>
		public long PlanScheduleID
		{
			get { return planScheduleID; }
			set { planScheduleID = value; }
		}

		/// <summary>
		/// Gets or sets the AuditType value.
		/// </summary>
		public string AuditType
		{
			get { return auditType; }
			set { auditType = value; }
		}

		/// <summary>
		/// Gets or sets the Category value.
		/// </summary>
		public string Category
		{
			get { return category; }
			set { category = value; }
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
		/// Gets or sets the Observation value.
		/// </summary>
		public string Observation
		{
			get { return observation; }
			set { observation = value; }
		}


		#endregion
}
}
