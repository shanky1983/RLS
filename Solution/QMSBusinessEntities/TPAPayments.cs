using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class TPAPayments
	{
		#region Fields

		private long tPAPaymentID=0;
		private long finalBillID=0;
		private long visitID=0;
		private int orgID=0;
		private decimal amount=Decimal.Zero;
		private int typeID=0;
		private decimal tDS=Decimal.Zero;
		private string chequeorCardNumber=String.Empty;
		private string bankNameorCardType=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TPAPaymentID value.
		/// </summary>
		public long TPAPaymentID
		{
			get { return tPAPaymentID; }
			set { tPAPaymentID = value; }
		}

		/// <summary>
		/// Gets or sets the FinalBillID value.
		/// </summary>
		public long FinalBillID
		{
			get { return finalBillID; }
			set { finalBillID = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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
		/// Gets or sets the TypeID value.
		/// </summary>
		public int TypeID
		{
			get { return typeID; }
			set { typeID = value; }
		}

		/// <summary>
		/// Gets or sets the TDS value.
		/// </summary>
		public decimal TDS
		{
			get { return tDS; }
			set { tDS = value; }
		}

		/// <summary>
		/// Gets or sets the ChequeorCardNumber value.
		/// </summary>
		public string ChequeorCardNumber
		{
			get { return chequeorCardNumber; }
			set { chequeorCardNumber = value; }
		}

		/// <summary>
		/// Gets or sets the BankNameorCardType value.
		/// </summary>
		public string BankNameorCardType
		{
			get { return bankNameorCardType; }
			set { bankNameorCardType = value; }
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
		/// Gets or sets the DueDetails value.
		/// </summary>
		Decimal _duedetails;
		public Decimal DueDetails
		{
			get { return _duedetails; }
			set { _duedetails = value; }
		}

		/// <summary>
		/// Gets or sets the TPAPaymentStatus value.
		/// </summary>
		String _tpapaymentstatus;
		public String TPAPaymentStatus
		{
			get { return _tpapaymentstatus; }
			set { _tpapaymentstatus = value; }
		}

		/// <summary>
		/// Gets or sets the TPASettlementDate value.
		/// </summary>
		DateTime _tpasettlementdate;
		public DateTime TPASettlementDate
		{
			get { return _tpasettlementdate; }
			set { _tpasettlementdate = value; }
		}

		/// <summary>
		/// Gets or sets the CliamForwardDate value.
		/// </summary>
		DateTime _cliamforwarddate;
		public DateTime CliamForwardDate
		{
			get { return _cliamforwarddate; }
			set { _cliamforwarddate = value; }
		}


		#endregion
}
}
