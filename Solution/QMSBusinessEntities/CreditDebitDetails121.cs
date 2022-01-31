using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class CreditDebitDetails121
	{
		#region Fields

		private int summaryID=0;
		private string referenceType=String.Empty;
		private long referenceID=0;
		private decimal amount=Decimal.Zero;
		private int orgID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long reason=0;
		private string remarks=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SummaryID value.
		/// </summary>
		public int SummaryID
		{
			get { return summaryID; }
			set { summaryID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceType value.
		/// </summary>
		public string ReferenceType
		{
			get { return referenceType; }
			set { referenceType = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceID value.
		/// </summary>
		public long ReferenceID
		{
			get { return referenceID; }
			set { referenceID = value; }
		}

		/// <summary>
		/// Gets or sets the Amount value.
		/// </summary>
		public decimal Amount
		{
			get { return amount; }
			set { amount = value; }
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
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the Reason value.
		/// </summary>
		public long Reason
		{
			get { return reason; }
			set { reason = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
		}


		#endregion
}
}
