using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvoiceAdvance
	{
		#region Fields

		private long advanceID=0;
		private long clientID=0;
		private decimal totalAdvance=Decimal.Zero;
		private decimal usedAdvance=Decimal.Zero;
		private string remarks=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private long orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AdvanceID value.
		/// </summary>
		public long AdvanceID
		{
			get { return advanceID; }
			set { advanceID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public long ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		/// <summary>
		/// Gets or sets the TotalAdvance value.
		/// </summary>
		public decimal TotalAdvance
		{
			get { return totalAdvance; }
			set { totalAdvance = value; }
		}

		/// <summary>
		/// Gets or sets the UsedAdvance value.
		/// </summary>
		public decimal UsedAdvance
		{
			get { return usedAdvance; }
			set { usedAdvance = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
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

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}


		#endregion
}
}
