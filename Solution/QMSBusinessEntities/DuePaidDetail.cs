using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class DuePaidDetail
	{
		#region Fields

		private long dueBillNo=0;
		private decimal billAmount=Decimal.Zero;
		private decimal paidAmount=Decimal.Zero;
		private long paidBillNo=0;
		private DateTime paidDate=DateTime.MaxValue;
		private long dueCollectedBy=0;
		private int baseCurrencyID=0;
		private int paidCurrencyID=0;
		private decimal otherCurrencyAmount=Decimal.Zero;
		private string versionNo=String.Empty;
		private decimal discountAmt=Decimal.Zero;
		private decimal outStandingAmt=Decimal.Zero;
		private string discountReason=String.Empty;
		private long discountApprovedBy=0;
		private long duePaidDetailID=0;
		private string receiptNO=String.Empty;
		private string description=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private long orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DueBillNo value.
		/// </summary>
		public long DueBillNo
		{
			get { return dueBillNo; }
			set { dueBillNo = value; }
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
		/// Gets or sets the PaidAmount value.
		/// </summary>
		public decimal PaidAmount
		{
			get { return paidAmount; }
			set { paidAmount = value; }
		}

		/// <summary>
		/// Gets or sets the PaidBillNo value.
		/// </summary>
		public long PaidBillNo
		{
			get { return paidBillNo; }
			set { paidBillNo = value; }
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
		/// Gets or sets the DueCollectedBy value.
		/// </summary>
		public long DueCollectedBy
		{
			get { return dueCollectedBy; }
			set { dueCollectedBy = value; }
		}

		/// <summary>
		/// Gets or sets the BaseCurrencyID value.
		/// </summary>
		public int BaseCurrencyID
		{
			get { return baseCurrencyID; }
			set { baseCurrencyID = value; }
		}

		/// <summary>
		/// Gets or sets the PaidCurrencyID value.
		/// </summary>
		public int PaidCurrencyID
		{
			get { return paidCurrencyID; }
			set { paidCurrencyID = value; }
		}

		/// <summary>
		/// Gets or sets the OtherCurrencyAmount value.
		/// </summary>
		public decimal OtherCurrencyAmount
		{
			get { return otherCurrencyAmount; }
			set { otherCurrencyAmount = value; }
		}

		/// <summary>
		/// Gets or sets the VersionNo value.
		/// </summary>
		public string VersionNo
		{
			get { return versionNo; }
			set { versionNo = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountAmt value.
		/// </summary>
		public decimal DiscountAmt
		{
			get { return discountAmt; }
			set { discountAmt = value; }
		}

		/// <summary>
		/// Gets or sets the OutStandingAmt value.
		/// </summary>
		public decimal OutStandingAmt
		{
			get { return outStandingAmt; }
			set { outStandingAmt = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountReason value.
		/// </summary>
		public string DiscountReason
		{
			get { return discountReason; }
			set { discountReason = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountApprovedBy value.
		/// </summary>
		public long DiscountApprovedBy
		{
			get { return discountApprovedBy; }
			set { discountApprovedBy = value; }
		}

		/// <summary>
		/// Gets or sets the DuePaidDetailID value.
		/// </summary>
		public long DuePaidDetailID
		{
			get { return duePaidDetailID; }
			set { duePaidDetailID = value; }
		}

		/// <summary>
		/// Gets or sets the ReceiptNO value.
		/// </summary>
		public string ReceiptNO
		{
			get { return receiptNO; }
			set { receiptNO = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientName value.
		/// </summary>
		string _patientname;
		public string PatientName
		{
			get { return _patientname; }
			set { _patientname = value; }
		}

		/// <summary>
		/// Gets or sets the DueBillDate value.
		/// </summary>
		DateTime _duebilldate;
		public DateTime DueBillDate
		{
			get { return _duebilldate; }
			set { _duebilldate = value; }
		}

		/// <summary>
		/// Gets or sets the ReceivedBy value.
		/// </summary>
		string _receivedby;
		public string ReceivedBy
		{
			get { return _receivedby; }
			set { _receivedby = value; }
		}

		/// <summary>
		/// Gets or sets the Address value.
		/// </summary>
		string _address;
		public string Address
		{
			get { return _address; }
			set { _address = value; }
		}

		/// <summary>
		/// Gets or sets the ContactNo value.
		/// </summary>
		string _contactno;
		public string ContactNo
		{
			get { return _contactno; }
			set { _contactno = value; }
		}

		/// <summary>
		/// Gets or sets the Age value.
		/// </summary>
		string _age;
		public string Age
		{
			get { return _age; }
			set { _age = value; }
		}

		/// <summary>
		/// Gets or sets the PatientNumber value.
		/// </summary>
		string _patientnumber;
		public string PatientNumber
		{
			get { return _patientnumber; }
			set { _patientnumber = value; }
		}

		/// <summary>
		/// Gets or sets the PaidCurrency value.
		/// </summary>
		string _paidcurrency;
		public string PaidCurrency
		{
			get { return _paidcurrency; }
			set { _paidcurrency = value; }
		}

		/// <summary>
		/// Gets or sets the PaidCurrencyAmount value.
		/// </summary>
		decimal _paidcurrencyamount;
		public decimal PaidCurrencyAmount
		{
			get { return _paidcurrencyamount; }
			set { _paidcurrencyamount = value; }
		}

		/// <summary>
		/// Gets or sets the BilledBy value.
		/// </summary>
		string _billedby;
		public string BilledBy
		{
			get { return _billedby; }
			set { _billedby = value; }
		}

		/// <summary>
		/// Gets or sets the DueBillNum value.
		/// </summary>
		string _duebillnum;
		public string DueBillNum
		{
			get { return _duebillnum; }
			set { _duebillnum = value; }
		}

		/// <summary>
		/// Gets or sets the PaidBillNum value.
		/// </summary>
		string _paidbillnum;
		public string PaidBillNum
		{
			get { return _paidbillnum; }
			set { _paidbillnum = value; }
		}


		#endregion
}
}
