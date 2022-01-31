using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class CurrencyHistory
	{
		#region Fields

		private int currencyID=0;
		private int orgID=0;
		private decimal conversionRate=Decimal.Zero;
		private DateTime startDate=DateTime.MaxValue;
		private DateTime endDate=DateTime.MaxValue;
		private int baseCurrencyID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CurrencyID value.
		/// </summary>
		public int CurrencyID
		{
			get { return currencyID; }
			set { currencyID = value; }
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
		/// Gets or sets the ConversionRate value.
		/// </summary>
		public decimal ConversionRate
		{
			get { return conversionRate; }
			set { conversionRate = value; }
		}

		/// <summary>
		/// Gets or sets the StartDate value.
		/// </summary>
		public DateTime StartDate
		{
			get { return startDate; }
			set { startDate = value; }
		}

		/// <summary>
		/// Gets or sets the EndDate value.
		/// </summary>
		public DateTime EndDate
		{
			get { return endDate; }
			set { endDate = value; }
		}

		/// <summary>
		/// Gets or sets the BaseCurrencyID value.
		/// </summary>
		public int BaseCurrencyID
		{
			get { return baseCurrencyID; }
			set { baseCurrencyID = value; }
		}


		#endregion
}
}
