using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ProcedureFee_HIST
	{
		#region Fields

		private long procedureFeeID=0;
		private long procedureID=0;
		private decimal amount=Decimal.Zero;
		private string isVariable=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string procedureDesc=String.Empty;
		private long rateID=0;
		private long orgID=0;
		private decimal iPAmount=Decimal.Zero;
		private string isActive=String.Empty;
		private long rateRefID=0;
		private string procedureType=String.Empty;
		private decimal advanceAmount=Decimal.Zero;
		private long histID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ProcedureFeeID value.
		/// </summary>
		public long ProcedureFeeID
		{
			get { return procedureFeeID; }
			set { procedureFeeID = value; }
		}

		/// <summary>
		/// Gets or sets the ProcedureID value.
		/// </summary>
		public long ProcedureID
		{
			get { return procedureID; }
			set { procedureID = value; }
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
		/// Gets or sets the IsVariable value.
		/// </summary>
		public string IsVariable
		{
			get { return isVariable; }
			set { isVariable = value; }
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
		/// Gets or sets the ProcedureDesc value.
		/// </summary>
		public string ProcedureDesc
		{
			get { return procedureDesc; }
			set { procedureDesc = value; }
		}

		/// <summary>
		/// Gets or sets the RateID value.
		/// </summary>
		public long RateID
		{
			get { return rateID; }
			set { rateID = value; }
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
		/// Gets or sets the IPAmount value.
		/// </summary>
		public decimal IPAmount
		{
			get { return iPAmount; }
			set { iPAmount = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the RateRefID value.
		/// </summary>
		public long RateRefID
		{
			get { return rateRefID; }
			set { rateRefID = value; }
		}

		/// <summary>
		/// Gets or sets the ProcedureType value.
		/// </summary>
		public string ProcedureType
		{
			get { return procedureType; }
			set { procedureType = value; }
		}

		/// <summary>
		/// Gets or sets the AdvanceAmount value.
		/// </summary>
		public decimal AdvanceAmount
		{
			get { return advanceAmount; }
			set { advanceAmount = value; }
		}

		/// <summary>
		/// Gets or sets the HistID value.
		/// </summary>
		public long HistID
		{
			get { return histID; }
			set { histID = value; }
		}


		#endregion
}
}
