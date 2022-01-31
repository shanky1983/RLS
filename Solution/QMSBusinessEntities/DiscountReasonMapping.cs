using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class DiscountReasonMapping
	{
		#region Fields

		private long id=0;
		private long discountId=0;
		private long reasonId=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private string isMapped=String.Empty;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long orgId=0;

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
		/// Gets or sets the DiscountId value.
		/// </summary>
		public long DiscountId
		{
			get { return discountId; }
			set { discountId = value; }
		}

		/// <summary>
		/// Gets or sets the ReasonId value.
		/// </summary>
		public long ReasonId
		{
			get { return reasonId; }
			set { reasonId = value; }
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
		/// Gets or sets the IsMapped value.
		/// </summary>
		public string IsMapped
		{
			get { return isMapped; }
			set { isMapped = value; }
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
		/// Gets or sets the OrgId value.
		/// </summary>
		public long OrgId
		{
			get { return orgId; }
			set { orgId = value; }
		}


		#endregion
}
}
