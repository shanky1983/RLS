using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class BulckRateUpdates
	{
		#region Fields

		private long bulckRateUpdateID=0;
		private long bulckID=0;
		private long finalbillID=0;
		private long clientID=0;
		private long oldRateID=0;
		private decimal oldAmount=Decimal.Zero;
		private long newRateID=0;
		private decimal newAmount=Decimal.Zero;
		private decimal preTotBillAmt=Decimal.Zero;
		private long invoiceID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BulckRateUpdateID value.
		/// </summary>
		public long BulckRateUpdateID
		{
			get { return bulckRateUpdateID; }
			set { bulckRateUpdateID = value; }
		}

		/// <summary>
		/// Gets or sets the BulckID value.
		/// </summary>
		public long BulckID
		{
			get { return bulckID; }
			set { bulckID = value; }
		}

		/// <summary>
		/// Gets or sets the FinalbillID value.
		/// </summary>
		public long FinalbillID
		{
			get { return finalbillID; }
			set { finalbillID = value; }
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
		/// Gets or sets the OldRateID value.
		/// </summary>
		public long OldRateID
		{
			get { return oldRateID; }
			set { oldRateID = value; }
		}

		/// <summary>
		/// Gets or sets the OldAmount value.
		/// </summary>
		public decimal OldAmount
		{
			get { return oldAmount; }
			set { oldAmount = value; }
		}

		/// <summary>
		/// Gets or sets the NewRateID value.
		/// </summary>
		public long NewRateID
		{
			get { return newRateID; }
			set { newRateID = value; }
		}

		/// <summary>
		/// Gets or sets the NewAmount value.
		/// </summary>
		public decimal NewAmount
		{
			get { return newAmount; }
			set { newAmount = value; }
		}

		/// <summary>
		/// Gets or sets the PreTotBillAmt value.
		/// </summary>
		public decimal PreTotBillAmt
		{
			get { return preTotBillAmt; }
			set { preTotBillAmt = value; }
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
		/// Gets or sets the BillNo value.
		/// </summary>
		private string _billNo=String.Empty;
		public string BillNo
		{
			get { return  _billNo; }
			set { _billNo = value; }
		}

		/// <summary>
		/// Gets or sets the VisitNo value.
		/// </summary>
		private string _visitNo=String.Empty;
		public string VisitNo
		{
			get { return  _visitNo; }
			set { _visitNo = value; }
		}

		/// <summary>
		/// Gets or sets the BillFromDate value.
		/// </summary>
		private DateTime _billFromDate=DateTime.MaxValue;
		public DateTime BillFromDate
		{
			get { return  _billFromDate; }
			set { _billFromDate = value; }
		}

		/// <summary>
		/// Gets or sets the BillToDate value.
		/// </summary>
		private DateTime _billToDate=DateTime.MaxValue;
		public DateTime BillToDate
		{
			get { return  _billToDate; }
			set { _billToDate = value; }
		}

		/// <summary>
		/// Gets or sets the TotBillAmt value.
		/// </summary>
		private Decimal _totBillAmt=Decimal.Zero;
		public Decimal TotBillAmt
		{
			get { return  _totBillAmt; }
			set { _totBillAmt = value; }
		}

		/// <summary>
		/// Gets or sets the OldRateName value.
		/// </summary>
		private string _oldRateName=String.Empty;
		public string OldRateName
		{
			get { return  _oldRateName; }
			set { _oldRateName = value; }
		}

		/// <summary>
		/// Gets or sets the NewRateName value.
		/// </summary>
		private string _newRateName=String.Empty;
		public string NewRateName
		{
			get { return  _newRateName; }
			set { _newRateName = value; }
		}

		/// <summary>
		/// Gets or sets the Diffamount value.
		/// </summary>
		private string _diffamount=String.Empty;
		public string Diffamount
		{
			get { return  _diffamount; }
			set { _diffamount = value; }
		}


		#endregion
}
}
