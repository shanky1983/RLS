using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CurrencyConversionMaster
	{
		#region Fields

		private int currencyValueId=0;
		private string fromCurrency=String.Empty;
		private int fromCurrencyID=0;
		private string toCurrency=String.Empty;
		private int toCurrencyID=0;
		private decimal conversionValue=Decimal.Zero;
		private DateTime validFrom=DateTime.MaxValue;
		private DateTime validTo=DateTime.MaxValue;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CurrencyValueId value.
		/// </summary>
		public int CurrencyValueId
		{
			get { return currencyValueId; }
			set { currencyValueId = value; }
		}

		/// <summary>
		/// Gets or sets the FromCurrency value.
		/// </summary>
		public string FromCurrency
		{
			get { return fromCurrency; }
			set { fromCurrency = value; }
		}

		/// <summary>
		/// Gets or sets the FromCurrencyID value.
		/// </summary>
		public int FromCurrencyID
		{
			get { return fromCurrencyID; }
			set { fromCurrencyID = value; }
		}

		/// <summary>
		/// Gets or sets the ToCurrency value.
		/// </summary>
		public string ToCurrency
		{
			get { return toCurrency; }
			set { toCurrency = value; }
		}

		/// <summary>
		/// Gets or sets the ToCurrencyID value.
		/// </summary>
		public int ToCurrencyID
		{
			get { return toCurrencyID; }
			set { toCurrencyID = value; }
		}

		/// <summary>
		/// Gets or sets the ConversionValue value.
		/// </summary>
		public decimal ConversionValue
		{
			get { return conversionValue; }
			set { conversionValue = value; }
		}

		/// <summary>
		/// Gets or sets the ValidFrom value.
		/// </summary>
		public DateTime ValidFrom
		{
			get { return validFrom; }
			set { validFrom = value; }
		}

		/// <summary>
		/// Gets or sets the ValidTo value.
		/// </summary>
		public DateTime ValidTo
		{
			get { return validTo; }
			set { validTo = value; }
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


		#endregion
}
}
