using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ProcedureFeeDetails
	{
		#region Fields

		private long iD=0;
		private long procedureFeeID=0;
		private int orgID=0;
		private string type=String.Empty;
		private int feeTypeAttributesID=0;
		private decimal amount=Decimal.Zero;
		private string procedureType=String.Empty;
		private long procedureID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private decimal percent=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the ProcedureFeeID value.
		/// </summary>
		public long ProcedureFeeID
		{
			get { return procedureFeeID; }
			set { procedureFeeID = value; }
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
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the FeeTypeAttributesID value.
		/// </summary>
		public int FeeTypeAttributesID
		{
			get { return feeTypeAttributesID; }
			set { feeTypeAttributesID = value; }
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
		/// Gets or sets the ProcedureType value.
		/// </summary>
		public string ProcedureType
		{
			get { return procedureType; }
			set { procedureType = value; }
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
		/// Gets or sets the Percent value.
		/// </summary>
		public decimal Percent
		{
			get { return percent; }
			set { percent = value; }
		}


		#endregion
}
}
