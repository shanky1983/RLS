using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class AmountDebtClosureDetails
	{
		#region Fields

		private long amountDebtClosureDetailsID=0;
		private decimal totalAmount=Decimal.Zero;
		private decimal debitedAmount=Decimal.Zero;
		private DateTime debitedDate=DateTime.MaxValue;
		private string description=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedAt=0;
		private DateTime modifiedBy=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AmountDebtClosureDetailsID value.
		/// </summary>
		public long AmountDebtClosureDetailsID
		{
			get { return amountDebtClosureDetailsID; }
			set { amountDebtClosureDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the TotalAmount value.
		/// </summary>
		public decimal TotalAmount
		{
			get { return totalAmount; }
			set { totalAmount = value; }
		}

		/// <summary>
		/// Gets or sets the DebitedAmount value.
		/// </summary>
		public decimal DebitedAmount
		{
			get { return debitedAmount; }
			set { debitedAmount = value; }
		}

		/// <summary>
		/// Gets or sets the DebitedDate value.
		/// </summary>
		public DateTime DebitedDate
		{
			get { return debitedDate; }
			set { debitedDate = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
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
		/// Gets or sets the RemainingAmount value.
		/// </summary>
		decimal _remainingamount;
		public decimal RemainingAmount
		{
			get { return _remainingamount; }
			set { _remainingamount = value; }
		}

		/// <summary>
		/// Gets or sets the FileURL value.
		/// </summary>
		string _fileurl;
		public string FileURL
		{
			get { return _fileurl; }
			set { _fileurl = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		string _name;
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}


		#endregion
}
}
