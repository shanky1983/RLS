using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
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
		string _paydetails;
		public string PayDetails
		{
			get { return _paydetails; }
			set { _paydetails = value; }
		}

		/// <summary>
		/// Gets or sets the CurrencyName value.
		/// </summary>
		string _currencyname;
		public string CurrencyName
		{
			get { return _currencyname; }
			set { _currencyname = value; }
		}

		/// <summary>
		/// Gets or sets the OtherCurrencyAmount value.
		/// </summary>
		decimal _othercurrencyamount;
		public decimal OtherCurrencyAmount
		{
			get { return _othercurrencyamount; }
			set { _othercurrencyamount = value; }
		}

		/// <summary>
		/// Gets or sets the AmountUsed value.
		/// </summary>
		decimal _amountused;
		public decimal AmountUsed
		{
			get { return _amountused; }
			set { _amountused = value; }
		}

		/// <summary>
		/// Gets or sets the IsDefault value.
		/// </summary>
		string _isdefault;
		public string IsDefault
		{
			get { return _isdefault; }
			set { _isdefault = value; }
		}

		/// <summary>
		/// Gets or sets the PTypeIDIsRequired value.
		/// </summary>
		string _ptypeidisrequired;
		public string PTypeIDIsRequired
		{
			get { return _ptypeidisrequired; }
			set { _ptypeidisrequired = value; }
		}


		#endregion
}
}
