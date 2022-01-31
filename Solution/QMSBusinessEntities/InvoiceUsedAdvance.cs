using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvoiceUsedAdvance
	{
		#region Fields

		private long usedAdvanceId=0;
		private long clientId=0;
		private long receiptId=0;
		private string trnStatus=String.Empty;
		private decimal usedAdvanceAmt=Decimal.Zero;
		private long orgId=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the UsedAdvanceId value.
		/// </summary>
		public long UsedAdvanceId
		{
			get { return usedAdvanceId; }
			set { usedAdvanceId = value; }
		}

		/// <summary>
		/// Gets or sets the ClientId value.
		/// </summary>
		public long ClientId
		{
			get { return clientId; }
			set { clientId = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiptId value.
		/// </summary>
		public long ReceiptId
		{
			get { return receiptId; }
			set { receiptId = value; }
		}

		/// <summary>
		/// Gets or sets the TrnStatus value.
		/// </summary>
		public string TrnStatus
		{
			get { return trnStatus; }
			set { trnStatus = value; }
		}

		/// <summary>
		/// Gets or sets the UsedAdvanceAmt value.
		/// </summary>
		public decimal UsedAdvanceAmt
		{
			get { return usedAdvanceAmt; }
			set { usedAdvanceAmt = value; }
		}

		/// <summary>
		/// Gets or sets the OrgId value.
		/// </summary>
		public long OrgId
		{
			get { return orgId; }
			set { orgId = value; }
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
