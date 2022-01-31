using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvoiceItemDetails
	{
		#region Fields

		private long iD=0;
		private long invoiceID=0;
		private long fInalBillID=0;
		private long billingDetailsID=0;
		private long clientID=0;
		private string clientCode=String.Empty;
		private long orgID=0;
		private long feeId=0;
		private string feeType=String.Empty;
		private string testDescription=String.Empty;
		private decimal netAmount=Decimal.Zero;
		private long rateID=0;
		private decimal grossAmount=Decimal.Zero;
		private long baseRateID=0;
		private decimal discountAmount=Decimal.Zero;
		private string patientName=String.Empty;
		private DateTime date=DateTime.MaxValue;
		private long visitNumber=0;
		private decimal qty=Decimal.Zero;
		private decimal billNumber=Decimal.Zero;
		private string invoiceNumber=String.Empty;
		private decimal tTOD=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
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
		/// Gets or sets the FInalBillID value.
		/// </summary>
		public long FInalBillID
		{
			get { return fInalBillID; }
			set { fInalBillID = value; }
		}

		/// <summary>
		/// Gets or sets the BillingDetailsID value.
		/// </summary>
		public long BillingDetailsID
		{
			get { return billingDetailsID; }
			set { billingDetailsID = value; }
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
		/// Gets or sets the ClientCode value.
		/// </summary>
		public string ClientCode
		{
			get { return clientCode; }
			set { clientCode = value; }
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
		/// Gets or sets the FeeId value.
		/// </summary>
		public long FeeId
		{
			get { return feeId; }
			set { feeId = value; }
		}

		/// <summary>
		/// Gets or sets the FeeType value.
		/// </summary>
		public string FeeType
		{
			get { return feeType; }
			set { feeType = value; }
		}

		/// <summary>
		/// Gets or sets the TestDescription value.
		/// </summary>
		public string TestDescription
		{
			get { return testDescription; }
			set { testDescription = value; }
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
		/// Gets or sets the RateID value.
		/// </summary>
		public long RateID
		{
			get { return rateID; }
			set { rateID = value; }
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
		/// Gets or sets the BaseRateID value.
		/// </summary>
		public long BaseRateID
		{
			get { return baseRateID; }
			set { baseRateID = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountAmount value.
		/// </summary>
		public decimal DiscountAmount
		{
			get { return discountAmount; }
			set { discountAmount = value; }
		}

		/// <summary>
		/// Gets or sets the PatientName value.
		/// </summary>
		public string PatientName
		{
			get { return patientName; }
			set { patientName = value; }
		}

		/// <summary>
		/// Gets or sets the Date value.
		/// </summary>
		public DateTime Date
		{
			get { return date; }
			set { date = value; }
		}

		/// <summary>
		/// Gets or sets the VisitNumber value.
		/// </summary>
		public long VisitNumber
		{
			get { return visitNumber; }
			set { visitNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Qty value.
		/// </summary>
		public decimal Qty
		{
			get { return qty; }
			set { qty = value; }
		}

		/// <summary>
		/// Gets or sets the BillNumber value.
		/// </summary>
		public decimal BillNumber
		{
			get { return billNumber; }
			set { billNumber = value; }
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
		/// Gets or sets the TTOD value.
		/// </summary>
		public decimal TTOD
		{
			get { return tTOD; }
			set { tTOD = value; }
		}


		#endregion
}
}
