using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CurrencyOrgMapping
	{
		#region Fields

		private int currencyID=0;
		private int orgID=0;
		private decimal conversionRate=Decimal.Zero;
		private string isBaseCurrency=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string languageCode=String.Empty;
		private string currencyDisplayText=String.Empty;
		private string minorCurrencyDisplayText=String.Empty;
		private string isRoundOff=String.Empty;
		private decimal roundOffValue=Decimal.Zero;

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
		/// Gets or sets the IsBaseCurrency value.
		/// </summary>
		public string IsBaseCurrency
		{
			get { return isBaseCurrency; }
			set { isBaseCurrency = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
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
		/// Gets or sets the LanguageCode value.
		/// </summary>
		public string LanguageCode
		{
			get { return languageCode; }
			set { languageCode = value; }
		}

		/// <summary>
		/// Gets or sets the CurrencyDisplayText value.
		/// </summary>
		public string CurrencyDisplayText
		{
			get { return currencyDisplayText; }
			set { currencyDisplayText = value; }
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
		/// Gets or sets the IsRoundOff value.
		/// </summary>
		public string IsRoundOff
		{
			get { return isRoundOff; }
			set { isRoundOff = value; }
		}

		/// <summary>
		/// Gets or sets the RoundOffValue value.
		/// </summary>
		public decimal RoundOffValue
		{
			get { return roundOffValue; }
			set { roundOffValue = value; }
		}

		/// <summary>
		/// Gets or sets the CurrencyCode value.
		/// </summary>
		private string _currencyCode=String.Empty;
		public string CurrencyCode
		{
			get { return  _currencyCode; }
			set { _currencyCode = value; }
		}

		/// <summary>
		/// Gets or sets the CurrencyName value.
		/// </summary>
		private string _currencyName=String.Empty;
		public string CurrencyName
		{
			get { return  _currencyName; }
			set { _currencyName = value; }
		}

		/// <summary>
		/// Gets or sets the RemoveCurrency value.
		/// </summary>
		private char _removeCurrency=new char();
		public char RemoveCurrency
		{
			get { return  _removeCurrency; }
			set { _removeCurrency = value; }
		}


		#endregion
}
}
