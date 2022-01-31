using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PaymentType
	{
		#region Fields

		private int paymentTypeID=0;
		private string paymentName=String.Empty;
		private long orgID=0;
		private int createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private int modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string allowEMI=String.Empty;
		private string languageCode=String.Empty;
		private string paymentCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PaymentTypeID value.
		/// </summary>
		public int PaymentTypeID
		{
			get { return paymentTypeID; }
			set { paymentTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the PaymentName value.
		/// </summary>
		public string PaymentName
		{
			get { return paymentName; }
			set { paymentName = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public int CreatedBy
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
		public int ModifiedBy
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
		/// Gets or sets the AllowEMI value.
		/// </summary>
		public string AllowEMI
		{
			get { return allowEMI; }
			set { allowEMI = value; }
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
		/// Gets or sets the PaymentCode value.
		/// </summary>
		public string PaymentCode
		{
			get { return paymentCode; }
			set { paymentCode = value; }
		}

		/// <summary>
		/// Gets or sets the PayDetails value.
		/// </summary>
		private string _payDetails=String.Empty;
		public string PayDetails
		{
			get { return  _payDetails; }
			set { _payDetails = value; }
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
		/// Gets or sets the OtherCurrencyAmount value.
		/// </summary>
		private decimal _otherCurrencyAmount=Decimal.Zero;
		public decimal OtherCurrencyAmount
		{
			get { return  _otherCurrencyAmount; }
			set { _otherCurrencyAmount = value; }
		}

		/// <summary>
		/// Gets or sets the AmountUsed value.
		/// </summary>
		private decimal _amountUsed=Decimal.Zero;
		public decimal AmountUsed
		{
			get { return  _amountUsed; }
			set { _amountUsed = value; }
		}

		/// <summary>
		/// Gets or sets the IsDefault value.
		/// </summary>
		private string _isDefault=String.Empty;
		public string IsDefault
		{
			get { return  _isDefault; }
			set { _isDefault = value; }
		}

		/// <summary>
		/// Gets or sets the PTypeIDIsRequired value.
		/// </summary>
		private string _pTypeIDIsRequired=String.Empty;
		public string PTypeIDIsRequired
		{
			get { return  _pTypeIDIsRequired; }
			set { _pTypeIDIsRequired = value; }
		}

		/// <summary>
		/// Gets or sets the BaseCurrency value.
		/// </summary>
		private string _baseCurrency=String.Empty;
		public string BaseCurrency
		{
			get { return  _baseCurrency; }
			set { _baseCurrency = value; }
		}


		#endregion
}
}
