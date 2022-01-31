using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CTE
	{
		#region Fields

		private string billNumber=String.Empty;
		private string receiptNo=String.Empty;
		private string billedBy=String.Empty;
		private string patientName=String.Empty;
		private string age=String.Empty;
		private string visitDate=String.Empty;
		private decimal billAmount=Decimal.Zero;
		private decimal amountReceived=Decimal.Zero;
		private decimal due=Decimal.Zero;
		private decimal amountRefund=Decimal.Zero;
		private decimal discount=Decimal.Zero;
		private decimal depositUsed=Decimal.Zero;
		private string visitNumber=String.Empty;
		private string clientName=String.Empty;
		private string refphysicianName=String.Empty;
		private string location=String.Empty;
		private string description=String.Empty;
		private decimal quanity=Decimal.Zero;
		private decimal billedAmount=Decimal.Zero;
		private decimal mRPAmt=Decimal.Zero;
		private decimal itemDiscount=Decimal.Zero;
		private decimal itemSpecialDiscount=Decimal.Zero;
		private decimal totalMRP=Decimal.Zero;
		private decimal totalDiscount=Decimal.Zero;
		private decimal totalSPecialDiscount=Decimal.Zero;
		private string feeType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BillNumber value.
		/// </summary>
		public string BillNumber
		{
			get { return billNumber; }
			set { billNumber = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiptNo value.
		/// </summary>
		public string ReceiptNo
		{
			get { return receiptNo; }
			set { receiptNo = value; }
		}

		/// <summary>
		/// Gets or sets the BilledBy value.
		/// </summary>
		public string BilledBy
		{
			get { return billedBy; }
			set { billedBy = value; }
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
		/// Gets or sets the Age value.
		/// </summary>
		public string Age
		{
			get { return age; }
			set { age = value; }
		}

		/// <summary>
		/// Gets or sets the VisitDate value.
		/// </summary>
		public string VisitDate
		{
			get { return visitDate; }
			set { visitDate = value; }
		}

		/// <summary>
		/// Gets or sets the BillAmount value.
		/// </summary>
		public decimal BillAmount
		{
			get { return billAmount; }
			set { billAmount = value; }
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
		/// Gets or sets the Due value.
		/// </summary>
		public decimal Due
		{
			get { return due; }
			set { due = value; }
		}

		/// <summary>
		/// Gets or sets the AmountRefund value.
		/// </summary>
		public decimal AmountRefund
		{
			get { return amountRefund; }
			set { amountRefund = value; }
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
		/// Gets or sets the DepositUsed value.
		/// </summary>
		public decimal DepositUsed
		{
			get { return depositUsed; }
			set { depositUsed = value; }
		}

		/// <summary>
		/// Gets or sets the VisitNumber value.
		/// </summary>
		public string VisitNumber
		{
			get { return visitNumber; }
			set { visitNumber = value; }
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
		/// Gets or sets the RefphysicianName value.
		/// </summary>
		public string RefphysicianName
		{
			get { return refphysicianName; }
			set { refphysicianName = value; }
		}

		/// <summary>
		/// Gets or sets the Location value.
		/// </summary>
		public string Location
		{
			get { return location; }
			set { location = value; }
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
		/// Gets or sets the Quanity value.
		/// </summary>
		public decimal Quanity
		{
			get { return quanity; }
			set { quanity = value; }
		}

		/// <summary>
		/// Gets or sets the BilledAmount value.
		/// </summary>
		public decimal BilledAmount
		{
			get { return billedAmount; }
			set { billedAmount = value; }
		}

		/// <summary>
		/// Gets or sets the MRPAmt value.
		/// </summary>
		public decimal MRPAmt
		{
			get { return mRPAmt; }
			set { mRPAmt = value; }
		}

		/// <summary>
		/// Gets or sets the ItemDiscount value.
		/// </summary>
		public decimal ItemDiscount
		{
			get { return itemDiscount; }
			set { itemDiscount = value; }
		}

		/// <summary>
		/// Gets or sets the ItemSpecialDiscount value.
		/// </summary>
		public decimal ItemSpecialDiscount
		{
			get { return itemSpecialDiscount; }
			set { itemSpecialDiscount = value; }
		}

		/// <summary>
		/// Gets or sets the TotalMRP value.
		/// </summary>
		public decimal TotalMRP
		{
			get { return totalMRP; }
			set { totalMRP = value; }
		}

		/// <summary>
		/// Gets or sets the TotalDiscount value.
		/// </summary>
		public decimal TotalDiscount
		{
			get { return totalDiscount; }
			set { totalDiscount = value; }
		}

		/// <summary>
		/// Gets or sets the TotalSPecialDiscount value.
		/// </summary>
		public decimal TotalSPecialDiscount
		{
			get { return totalSPecialDiscount; }
			set { totalSPecialDiscount = value; }
		}

		/// <summary>
		/// Gets or sets the FeeType value.
		/// </summary>
		public string FeeType
		{
			get { return feeType; }
			set { feeType = value; }
		}


		#endregion
}
}
