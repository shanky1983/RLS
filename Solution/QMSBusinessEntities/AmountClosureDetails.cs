using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class AmountClosureDetails
	{
		#region Fields

		private long closureID=0;
		private decimal amountToBeClosed=Decimal.Zero;
		private decimal amountClosed=Decimal.Zero;
		private string status=String.Empty;
		private int closedBy=0;
		private int closedFor=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedAt=0;
		private DateTime modifiedBy=DateTime.MaxValue;
		private decimal amountRefunded=Decimal.Zero;
		private long closureID_Copy=0;
		private decimal pendingSettlementAmt=Decimal.Zero;
		private string amountClosureStatus=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ClosureID value.
		/// </summary>
		public long ClosureID
		{
			get { return closureID; }
			set { closureID = value; }
		}

		/// <summary>
		/// Gets or sets the AmountToBeClosed value.
		/// </summary>
		public decimal AmountToBeClosed
		{
			get { return amountToBeClosed; }
			set { amountToBeClosed = value; }
		}

		/// <summary>
		/// Gets or sets the AmountClosed value.
		/// </summary>
		public decimal AmountClosed
		{
			get { return amountClosed; }
			set { amountClosed = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the ClosedBy value.
		/// </summary>
		public int ClosedBy
		{
			get { return closedBy; }
			set { closedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ClosedFor value.
		/// </summary>
		public int ClosedFor
		{
			get { return closedFor; }
			set { closedFor = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public long ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public DateTime ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the AmountRefunded value.
		/// </summary>
		public decimal AmountRefunded
		{
			get { return amountRefunded; }
			set { amountRefunded = value; }
		}

		/// <summary>
		/// Gets or sets the ClosureID_Copy value.
		/// </summary>
		public long ClosureID_Copy
		{
			get { return closureID_Copy; }
			set { closureID_Copy = value; }
		}

		/// <summary>
		/// Gets or sets the PendingSettlementAmt value.
		/// </summary>
		public decimal PendingSettlementAmt
		{
			get { return pendingSettlementAmt; }
			set { pendingSettlementAmt = value; }
		}

		/// <summary>
		/// Gets or sets the AmountClosureStatus value.
		/// </summary>
		public string AmountClosureStatus
		{
			get { return amountClosureStatus; }
			set { amountClosureStatus = value; }
		}

		/// <summary>
		/// Gets or sets the UserName value.
		/// </summary>
		string _username;
		public string UserName
		{
			get { return _username; }
			set { _username = value; }
		}


		#endregion
}
}
