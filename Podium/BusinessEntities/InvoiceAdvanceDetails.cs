using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvoiceAdvanceDetails
	{
		#region Fields

		private long advanceDetailID=0;
		private long clientID=0;
		private DateTime paidDate=DateTime.MaxValue;
		private decimal amount=Decimal.Zero;
		private string remarks=String.Empty;
		private string status=String.Empty;
		private string uploadedImages=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private string paymentType=String.Empty;
		private long orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AdvanceDetailID value.
		/// </summary>
		public long AdvanceDetailID
		{
			get { return advanceDetailID; }
			set { advanceDetailID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public long ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		/// <summary>
		/// Gets or sets the PaidDate value.
		/// </summary>
		public DateTime PaidDate
		{
			get { return paidDate; }
			set { paidDate = value; }
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
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
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
		/// Gets or sets the UploadedImages value.
		/// </summary>
		public string UploadedImages
		{
			get { return uploadedImages; }
			set { uploadedImages = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
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
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the PaymentType value.
		/// </summary>
		public string PaymentType
		{
			get { return paymentType; }
			set { paymentType = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}


		#endregion
}
}
