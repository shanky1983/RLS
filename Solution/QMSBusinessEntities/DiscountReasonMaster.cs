using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class DiscountReasonMaster
	{
		#region Fields

		private int reasonId=0;
		private string reasonCode=String.Empty;
		private string reasonDesc=String.Empty;
		private long orgID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ReasonId value.
		/// </summary>
		public int ReasonId
		{
			get { return reasonId; }
			set { reasonId = value; }
		}

		/// <summary>
		/// Gets or sets the ReasonCode value.
		/// </summary>
		public string ReasonCode
		{
			get { return reasonCode; }
			set { reasonCode = value; }
		}

		/// <summary>
		/// Gets or sets the ReasonDesc value.
		/// </summary>
		public string ReasonDesc
		{
			get { return reasonDesc; }
			set { reasonDesc = value; }
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
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}


		#endregion
}
}
