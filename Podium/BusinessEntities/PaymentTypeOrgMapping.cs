using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PaymentTypeOrgMapping
	{
		#region Fields

		private int paymentTypeID=0;
		private long orgID=0;
		private decimal serviceCharge=Decimal.Zero;
		private int createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private int modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string isDefault=String.Empty;
		private string isApprovalRequired=String.Empty;
		private int maxLength=0;
		private int chequeValidMonth=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PaymentTypeID value.
		/// </summary>
		public int PaymentTypeID
		{
			get { return paymentTypeID; }
			set { paymentTypeID = value; }
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
		/// Gets or sets the ServiceCharge value.
		/// </summary>
		public decimal ServiceCharge
		{
			get { return serviceCharge; }
			set { serviceCharge = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public int CreatedBy
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
		public int ModifiedBy
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
		/// Gets or sets the IsDefault value.
		/// </summary>
		public string IsDefault
		{
			get { return isDefault; }
			set { isDefault = value; }
		}

		/// <summary>
		/// Gets or sets the IsApprovalRequired value.
		/// </summary>
		public string IsApprovalRequired
		{
			get { return isApprovalRequired; }
			set { isApprovalRequired = value; }
		}

		/// <summary>
		/// Gets or sets the MaxLength value.
		/// </summary>
		public int MaxLength
		{
			get { return maxLength; }
			set { maxLength = value; }
		}

		/// <summary>
		/// Gets or sets the ChequeValidMonth value.
		/// </summary>
		public int ChequeValidMonth
		{
			get { return chequeValidMonth; }
			set { chequeValidMonth = value; }
		}

		/// <summary>
		/// Gets or sets the IsRequired value.
		/// </summary>
		private string _isRequired=String.Empty;
		public string IsRequired
		{
			get { return  _isRequired; }
			set { _isRequired = value; }
		}


		#endregion
}
}
