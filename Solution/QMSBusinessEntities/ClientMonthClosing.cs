using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ClientMonthClosing
	{
		#region Fields

		private long iD=0;
		private DateTime month=DateTime.MaxValue;
		private int orgID=0;
		private string sourceCode=String.Empty;
		private string subSourceCode=String.Empty;
		private long workLoad=0;
		private decimal openingBalance=Decimal.Zero;
		private decimal bills=Decimal.Zero;
		private decimal debits=Decimal.Zero;
		private decimal credits=Decimal.Zero;
		private decimal receipts=Decimal.Zero;
		private decimal closingBalance=Decimal.Zero;
		private DateTime periodFrom=DateTime.MaxValue;
		private DateTime periodTo=DateTime.MaxValue;
		private DateTime lastUpdated=DateTime.MaxValue;
		private string status=String.Empty;

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
		/// Gets or sets the Month value.
		/// </summary>
		public DateTime Month
		{
			get { return month; }
			set { month = value; }
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
		/// Gets or sets the SourceCode value.
		/// </summary>
		public string SourceCode
		{
			get { return sourceCode; }
			set { sourceCode = value; }
		}

		/// <summary>
		/// Gets or sets the SubSourceCode value.
		/// </summary>
		public string SubSourceCode
		{
			get { return subSourceCode; }
			set { subSourceCode = value; }
		}

		/// <summary>
		/// Gets or sets the WorkLoad value.
		/// </summary>
		public long WorkLoad
		{
			get { return workLoad; }
			set { workLoad = value; }
		}

		/// <summary>
		/// Gets or sets the OpeningBalance value.
		/// </summary>
		public decimal OpeningBalance
		{
			get { return openingBalance; }
			set { openingBalance = value; }
		}

		/// <summary>
		/// Gets or sets the Bills value.
		/// </summary>
		public decimal Bills
		{
			get { return bills; }
			set { bills = value; }
		}

		/// <summary>
		/// Gets or sets the Debits value.
		/// </summary>
		public decimal Debits
		{
			get { return debits; }
			set { debits = value; }
		}

		/// <summary>
		/// Gets or sets the Credits value.
		/// </summary>
		public decimal Credits
		{
			get { return credits; }
			set { credits = value; }
		}

		/// <summary>
		/// Gets or sets the Receipts value.
		/// </summary>
		public decimal Receipts
		{
			get { return receipts; }
			set { receipts = value; }
		}

		/// <summary>
		/// Gets or sets the ClosingBalance value.
		/// </summary>
		public decimal ClosingBalance
		{
			get { return closingBalance; }
			set { closingBalance = value; }
		}

		/// <summary>
		/// Gets or sets the PeriodFrom value.
		/// </summary>
		public DateTime PeriodFrom
		{
			get { return periodFrom; }
			set { periodFrom = value; }
		}

		/// <summary>
		/// Gets or sets the PeriodTo value.
		/// </summary>
		public DateTime PeriodTo
		{
			get { return periodTo; }
			set { periodTo = value; }
		}

		/// <summary>
		/// Gets or sets the LastUpdated value.
		/// </summary>
		public DateTime LastUpdated
		{
			get { return lastUpdated; }
			set { lastUpdated = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}


		#endregion
}
}
