using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class WatersQuotationMaster
	{
		#region Fields

		private long quotationID=0;
		private string quotationNo=String.Empty;
		private DateTime validFrom=DateTime.MaxValue;
		private DateTime validTo=DateTime.MaxValue;
		private string others=String.Empty;
		private long clientID=0;
		private string clientName=String.Empty;
		private string clientSource=String.Empty;
		private string isSameAsBillingAddr=String.Empty;
		private string salesPerson=String.Empty;
		private string branch=String.Empty;
		private string remarks=String.Empty;
		private string sendEmail=String.Empty;
		private string sendSMS=String.Empty;
		private string isFileUpload=String.Empty;
		private string status=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the QuotationID value.
		/// </summary>
		public long QuotationID
		{
			get { return quotationID; }
			set { quotationID = value; }
		}

		/// <summary>
		/// Gets or sets the QuotationNo value.
		/// </summary>
		public string QuotationNo
		{
			get { return quotationNo; }
			set { quotationNo = value; }
		}

		/// <summary>
		/// Gets or sets the ValidFrom value.
		/// </summary>
		public DateTime ValidFrom
		{
			get { return validFrom; }
			set { validFrom = value; }
		}

		/// <summary>
		/// Gets or sets the ValidTo value.
		/// </summary>
		public DateTime ValidTo
		{
			get { return validTo; }
			set { validTo = value; }
		}

		/// <summary>
		/// Gets or sets the Others value.
		/// </summary>
		public string Others
		{
			get { return others; }
			set { others = value; }
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
		/// Gets or sets the ClientName value.
		/// </summary>
		public string ClientName
		{
			get { return clientName; }
			set { clientName = value; }
		}

		/// <summary>
		/// Gets or sets the ClientSource value.
		/// </summary>
		public string ClientSource
		{
			get { return clientSource; }
			set { clientSource = value; }
		}

		/// <summary>
		/// Gets or sets the IsSameAsBillingAddr value.
		/// </summary>
		public string IsSameAsBillingAddr
		{
			get { return isSameAsBillingAddr; }
			set { isSameAsBillingAddr = value; }
		}

		/// <summary>
		/// Gets or sets the SalesPerson value.
		/// </summary>
		public string SalesPerson
		{
			get { return salesPerson; }
			set { salesPerson = value; }
		}

		/// <summary>
		/// Gets or sets the Branch value.
		/// </summary>
		public string Branch
		{
			get { return branch; }
			set { branch = value; }
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
		/// Gets or sets the SendEmail value.
		/// </summary>
		public string SendEmail
		{
			get { return sendEmail; }
			set { sendEmail = value; }
		}

		/// <summary>
		/// Gets or sets the SendSMS value.
		/// </summary>
		public string SendSMS
		{
			get { return sendSMS; }
			set { sendSMS = value; }
		}

		/// <summary>
		/// Gets or sets the IsFileUpload value.
		/// </summary>
		public string IsFileUpload
		{
			get { return isFileUpload; }
			set { isFileUpload = value; }
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
