using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PaymentBanks
	{
		#region Fields

		private long bankID=0;
		private string bankName=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BankID value.
		/// </summary>
		public long BankID
		{
			get { return bankID; }
			set { bankID = value; }
		}

		/// <summary>
		/// Gets or sets the BankName value.
		/// </summary>
		public string BankName
		{
			get { return bankName; }
			set { bankName = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		string _description;
		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		string _remarks;
		public string Remarks
		{
			get { return _remarks; }
			set { _remarks = value; }
		}


		#endregion
}
}
