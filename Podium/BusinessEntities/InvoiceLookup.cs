using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvoiceLookup
	{
		#region Fields

		private long billNo=0;
		private string type=String.Empty;
		private long raisedToClient=0;
		private string invoiceStatus=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgID=0;
		private int invoiceLookupID=0;
		private string validation=String.Empty;
		private string invoiceNumber=String.Empty;
		private string validateStatus=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BillNo value.
		/// </summary>
		public long BillNo
		{
			get { return billNo; }
			set { billNo = value; }
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
		/// Gets or sets the RaisedToClient value.
		/// </summary>
		public long RaisedToClient
		{
			get { return raisedToClient; }
			set { raisedToClient = value; }
		}

		/// <summary>
		/// Gets or sets the InvoiceStatus value.
		/// </summary>
		public string InvoiceStatus
		{
			get { return invoiceStatus; }
			set { invoiceStatus = value; }
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
		/// Gets or sets the InvoiceLookupID value.
		/// </summary>
		public int InvoiceLookupID
		{
			get { return invoiceLookupID; }
			set { invoiceLookupID = value; }
		}

		/// <summary>
		/// Gets or sets the Validation value.
		/// </summary>
		public string Validation
		{
			get { return validation; }
			set { validation = value; }
		}

		/// <summary>
		/// Gets or sets the InvoiceNumber value.
		/// </summary>
		public string InvoiceNumber
		{
			get { return invoiceNumber; }
			set { invoiceNumber = value; }
		}

		/// <summary>
		/// Gets or sets the ValidateStatus value.
		/// </summary>
		public string ValidateStatus
		{
			get { return validateStatus; }
			set { validateStatus = value; }
		}


		#endregion
}
}
