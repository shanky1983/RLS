using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class BillMaster
	{
		#region Fields

		private long billID=0;
		private DateTime billDate=DateTime.MaxValue;
		private long visitID=0;
		private long patientID=0;
		private int clientID=0;
		private decimal grossAmount=Decimal.Zero;
		private decimal discount=Decimal.Zero;
		private decimal taxPercent=Decimal.Zero;
		private decimal netAmount=Decimal.Zero;
		private decimal amountReceived=Decimal.Zero;
		private decimal amountDue=Decimal.Zero;
		private string isCredit=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string comments=String.Empty;
		private string type=String.Empty;
		private int orgID=0;
		private string status=String.Empty;
		private int collectionCentreID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BillID value.
		/// </summary>
		public long BillID
		{
			get { return billID; }
			set { billID = value; }
		}

		/// <summary>
		/// Gets or sets the BillDate value.
		/// </summary>
		public DateTime BillDate
		{
			get { return billDate; }
			set { billDate = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		public int ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		/// <summary>
		/// Gets or sets the GrossAmount value.
		/// </summary>
		public decimal GrossAmount
		{
			get { return grossAmount; }
			set { grossAmount = value; }
		}

		/// <summary>
		/// Gets or sets the Discount value.
		/// </summary>
		public decimal Discount
		{
			get { return discount; }
			set { discount = value; }
		}

		/// <summary>
		/// Gets or sets the TaxPercent value.
		/// </summary>
		public decimal TaxPercent
		{
			get { return taxPercent; }
			set { taxPercent = value; }
		}

		/// <summary>
		/// Gets or sets the NetAmount value.
		/// </summary>
		public decimal NetAmount
		{
			get { return netAmount; }
			set { netAmount = value; }
		}

		/// <summary>
		/// Gets or sets the AmountReceived value.
		/// </summary>
		public decimal AmountReceived
		{
			get { return amountReceived; }
			set { amountReceived = value; }
		}

		/// <summary>
		/// Gets or sets the AmountDue value.
		/// </summary>
		public decimal AmountDue
		{
			get { return amountDue; }
			set { amountDue = value; }
		}

		/// <summary>
		/// Gets or sets the IsCredit value.
		/// </summary>
		public string IsCredit
		{
			get { return isCredit; }
			set { isCredit = value; }
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
		/// Gets or sets the Comments value.
		/// </summary>
		public string Comments
		{
			get { return comments; }
			set { comments = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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
		/// Gets or sets the CollectionCentreID value.
		/// </summary>
		public int CollectionCentreID
		{
			get { return collectionCentreID; }
			set { collectionCentreID = value; }
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
		/// Gets or sets the DueBillID value.
		/// </summary>
		private long _dueBillID=0;
		public long DueBillID
		{
			get { return  _dueBillID; }
			set { _dueBillID = value; }
		}

		/// <summary>
		/// Gets or sets the ParentBillID value.
		/// </summary>
		private long _parentBillID=0;
		public long ParentBillID
		{
			get { return  _parentBillID; }
			set { _parentBillID = value; }
		}

		/// <summary>
		/// Gets or sets the TPAID value.
		/// </summary>
		private long _tPAID=0;
		public long TPAID
		{
			get { return  _tPAID; }
			set { _tPAID = value; }
		}


		#endregion
}
}
