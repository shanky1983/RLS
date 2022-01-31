using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class IpPayments
	{
		#region Fields

		private long iPPaymentsID=0;
		private string paymentTypeCde=String.Empty;
		private string paymentTypeName=String.Empty;
		private int parentID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IPPaymentsID value.
		/// </summary>
		public long IPPaymentsID
		{
			get { return iPPaymentsID; }
			set { iPPaymentsID = value; }
		}

		/// <summary>
		/// Gets or sets the PaymentTypeCde value.
		/// </summary>
		public string PaymentTypeCde
		{
			get { return paymentTypeCde; }
			set { paymentTypeCde = value; }
		}

		/// <summary>
		/// Gets or sets the PaymentTypeName value.
		/// </summary>
		public string PaymentTypeName
		{
			get { return paymentTypeName; }
			set { paymentTypeName = value; }
		}

		/// <summary>
		/// Gets or sets the ParentID value.
		/// </summary>
		public int ParentID
		{
			get { return parentID; }
			set { parentID = value; }
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


		#endregion
}
}
