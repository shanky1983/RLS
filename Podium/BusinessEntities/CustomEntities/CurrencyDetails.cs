using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CurrencyDetails
	{
		#region Fields

		private int currencyID=0;
		private string currencyCode=String.Empty;
		private string currencyName=String.Empty;
		private string minorCurrencyDisplayText=String.Empty;
		private decimal conversionRate=Decimal.Zero;
		private string isBaseCurrency=String.Empty;
		private int orgID=0;

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
		/// Gets or sets the CurrencyCode value.
		/// </summary>
		public string CurrencyCode
		{
			get { return currencyCode; }
			set { currencyCode = value; }
		}

		/// <summary>
		/// Gets or sets the CurrencyName value.
		/// </summary>
		public string CurrencyName
		{
			get { return currencyName; }
			set { currencyName = value; }
		}

		/// <summary>
		/// Gets or sets the MinorCurrencyDisplayText value.
		/// </summary>
		public string MinorCurrencyDisplayText
		{
			get { return minorCurrencyDisplayText; }
			set { minorCurrencyDisplayText = value; }
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
		/// Gets or sets the IsBaseCurrency value.
		/// </summary>
		public string IsBaseCurrency
		{
			get { return isBaseCurrency; }
			set { isBaseCurrency = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}


		#endregion
}
}
