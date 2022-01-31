using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvestigationFee
	{
		#region Fields

		private long investigationFeeID=0;
		private long investigationID=0;
		private long orgID=0;
		private decimal amount=Decimal.Zero;
		private string isVariable=String.Empty;
		private int methodID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private long modifiedAt=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvestigationFeeID value.
		/// </summary>
		public long InvestigationFeeID
		{
			get { return investigationFeeID; }
			set { investigationFeeID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
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
		/// Gets or sets the MethodID value.
		/// </summary>
		public int MethodID
		{
			get { return methodID; }
			set { methodID = value; }
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
		public long ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the SNo value.
		/// </summary>
		private string _sNo=String.Empty;
		public string SNo
		{
			get { return  _sNo; }
			set { _sNo = value; }
		}

		/// <summary>
		/// Gets or sets the Descrip value.
		/// </summary>
		private string _descrip=String.Empty;
		public string Descrip
		{
			get { return  _descrip; }
			set { _descrip = value; }
		}


		#endregion
}
}
