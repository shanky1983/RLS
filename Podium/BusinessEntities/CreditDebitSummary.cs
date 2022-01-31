using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CreditDebitSummary
	{
		#region Fields

		private long summaryID=0;
		private long receiptNo=0;
		private DateTime crDrDate=DateTime.MaxValue;
		private string clientType=String.Empty;
		private long clientId=0;
		private string itemType=String.Empty;
		private long authorizedby=0;
		private int orgID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string referenceType=String.Empty;
		private long referenceID=0;
		private long invoiceID=0;
		private long bkp_ClientID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SummaryID value.
		/// </summary>
		public long SummaryID
		{
			get { return summaryID; }
			set { summaryID = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiptNo value.
		/// </summary>
		public long ReceiptNo
		{
			get { return receiptNo; }
			set { receiptNo = value; }
		}

		/// <summary>
		/// Gets or sets the CrDrDate value.
		/// </summary>
		public DateTime CrDrDate
		{
			get { return crDrDate; }
			set { crDrDate = value; }
		}

		/// <summary>
		/// Gets or sets the ClientType value.
		/// </summary>
		public string ClientType
		{
			get { return clientType; }
			set { clientType = value; }
		}

		/// <summary>
		/// Gets or sets the ClientId value.
		/// </summary>
		public long ClientId
		{
			get { return clientId; }
			set { clientId = value; }
		}

		/// <summary>
		/// Gets or sets the ItemType value.
		/// </summary>
		public string ItemType
		{
			get { return itemType; }
			set { itemType = value; }
		}

		/// <summary>
		/// Gets or sets the Authorizedby value.
		/// </summary>
		public long Authorizedby
		{
			get { return authorizedby; }
			set { authorizedby = value; }
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
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceType value.
		/// </summary>
		public string ReferenceType
		{
			get { return referenceType; }
			set { referenceType = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceID value.
		/// </summary>
		public long ReferenceID
		{
			get { return referenceID; }
			set { referenceID = value; }
		}

		/// <summary>
		/// Gets or sets the InvoiceID value.
		/// </summary>
		public long InvoiceID
		{
			get { return invoiceID; }
			set { invoiceID = value; }
		}

		/// <summary>
		/// Gets or sets the Bkp_ClientID value.
		/// </summary>
		public long Bkp_ClientID
		{
			get { return bkp_ClientID; }
			set { bkp_ClientID = value; }
		}

		/// <summary>
		/// Gets or sets the Reason value.
		/// </summary>
		private string _reason=String.Empty;
		public string Reason
		{
			get { return  _reason; }
			set { _reason = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		private string _remarks=String.Empty;
		public string Remarks
		{
			get { return  _remarks; }
			set { _remarks = value; }
		}

		/// <summary>
		/// Gets or sets the Reasonid value.
		/// </summary>
		private long _reasonid=0;
		public long Reasonid
		{
			get { return  _reasonid; }
			set { _reasonid = value; }
		}

		/// <summary>
		/// Gets or sets the TotalRows value.
		/// </summary>
		private int _totalRows=0;
		public int TotalRows
		{
			get { return  _totalRows; }
			set { _totalRows = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		private int _iD=0;
		public int ID
		{
			get { return  _iD; }
			set { _iD = value; }
		}

		/// <summary>
		/// Gets or sets the Date value.
		/// </summary>
		private DateTime _date=DateTime.MaxValue;
		public DateTime Date
		{
			get { return  _date; }
			set { _date = value; }
		}

		/// <summary>
		/// Gets or sets the Crdrtype value.
		/// </summary>
		private string _crdrtype=String.Empty;
		public string Crdrtype
		{
			get { return  _crdrtype; }
			set { _crdrtype = value; }
		}

		/// <summary>
		/// Gets or sets the Patientid value.
		/// </summary>
		private int _patientid=0;
		public int Patientid
		{
			get { return  _patientid; }
			set { _patientid = value; }
		}

		/// <summary>
		/// Gets or sets the ClientName value.
		/// </summary>
		private string _clientName=String.Empty;
		public string ClientName
		{
			get { return  _clientName; }
			set { _clientName = value; }
		}

		/// <summary>
		/// Gets or sets the AuthorizerName value.
		/// </summary>
		private string _authorizerName=String.Empty;
		public string AuthorizerName
		{
			get { return  _authorizerName; }
			set { _authorizerName = value; }
		}

		/// <summary>
		/// Gets or sets the Amount value.
		/// </summary>
		private Decimal _amount=Decimal.Zero;
		public Decimal Amount
		{
			get { return  _amount; }
			set { _amount = value; }
		}

		/// <summary>
		/// Gets or sets the BillNumber value.
		/// </summary>
		private string _billNumber=String.Empty;
		public string BillNumber
		{
			get { return  _billNumber; }
			set { _billNumber = value; }
		}


		#endregion
}
}
