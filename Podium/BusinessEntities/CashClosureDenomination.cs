using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CashClosureDenomination
	{
		#region Fields

		private string closureID=String.Empty;
		private long denominationID=0;
		private decimal unit=Decimal.Zero;
		private decimal amount=Decimal.Zero;
		private long loginID=0;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private string status=String.Empty;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ClosureID value.
		/// </summary>
		public string ClosureID
		{
			get { return closureID; }
			set { closureID = value; }
		}

		/// <summary>
		/// Gets or sets the DenominationID value.
		/// </summary>
		public long DenominationID
		{
			get { return denominationID; }
			set { denominationID = value; }
		}

		/// <summary>
		/// Gets or sets the Unit value.
		/// </summary>
		public decimal Unit
		{
			get { return unit; }
			set { unit = value; }
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
		/// Gets or sets the LoginID value.
		/// </summary>
		public long LoginID
		{
			get { return loginID; }
			set { loginID = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
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
		/// Gets or sets the Rupees value.
		/// </summary>
		private Decimal _rupees=Decimal.Zero;
		public Decimal Rupees
		{
			get { return  _rupees; }
			set { _rupees = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		private string _name=String.Empty;
		public string Name
		{
			get { return  _name; }
			set { _name = value; }
		}


		#endregion
}
}
