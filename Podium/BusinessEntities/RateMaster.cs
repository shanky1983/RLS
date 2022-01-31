using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class RateMaster
	{
		#region Fields

		private int rateId=0;
		private string rateName=String.Empty;
		private string status=String.Empty;
		private int createdBY=0;
		private DateTime createdAt=DateTime.MaxValue;
		private int modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgid=0;
		private string type=String.Empty;
		private long discountPolicyID=0;
		private string rateCode=String.Empty;
		private int currencyID=0;
		private string comments=String.Empty;
		private string subType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RateId value.
		/// </summary>
		public int RateId
		{
			get { return rateId; }
			set { rateId = value; }
		}

		/// <summary>
		/// Gets or sets the RateName value.
		/// </summary>
		public string RateName
		{
			get { return rateName; }
			set { rateName = value; }
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
		/// Gets or sets the CreatedBY value.
		/// </summary>
		public int CreatedBY
		{
			get { return createdBY; }
			set { createdBY = value; }
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
		/// Gets or sets the Orgid value.
		/// </summary>
		public int Orgid
		{
			get { return orgid; }
			set { orgid = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountPolicyID value.
		/// </summary>
		public long DiscountPolicyID
		{
			get { return discountPolicyID; }
			set { discountPolicyID = value; }
		}

		/// <summary>
		/// Gets or sets the RateCode value.
		/// </summary>
		public string RateCode
		{
			get { return rateCode; }
			set { rateCode = value; }
		}

		/// <summary>
		/// Gets or sets the CurrencyID value.
		/// </summary>
		public int CurrencyID
		{
			get { return currencyID; }
			set { currencyID = value; }
		}

		/// <summary>
		/// Gets or sets the Comments value.
		/// </summary>
		public string Comments
		{
			get { return comments; }
			set { comments = value; }
		}

		/// <summary>
		/// Gets or sets the SubType value.
		/// </summary>
		public string SubType
		{
			get { return subType; }
			set { subType = value; }
		}

		/// <summary>
		/// Gets or sets the ClientName value.
		/// </summary>
		private string _clientName=String.Empty;
		public string ClientName
		{
			get { return  _clientName; }
			set { _clientName = value; }
		}

		/// <summary>
		/// Gets or sets the RateTypeName value.
		/// </summary>
		private string _rateTypeName=String.Empty;
		public string RateTypeName
		{
			get { return  _rateTypeName; }
			set { _rateTypeName = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		private long _investigationID=0;
		public long InvestigationID
		{
			get { return  _investigationID; }
			set { _investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationType value.
		/// </summary>
		private string _investigationType=String.Empty;
		public string InvestigationType
		{
			get { return  _investigationType; }
			set { _investigationType = value; }
		}

		/// <summary>
		/// Gets or sets the OpAmount value.
		/// </summary>
		private decimal _opAmount=Decimal.Zero;
		public decimal OpAmount
		{
			get { return  _opAmount; }
			set { _opAmount = value; }
		}

		/// <summary>
		/// Gets or sets the IpAmount value.
		/// </summary>
		private decimal _ipAmount=Decimal.Zero;
		public decimal IpAmount
		{
			get { return  _ipAmount; }
			set { _ipAmount = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		private long _clientID=0;
		public long ClientID
		{
			get { return  _clientID; }
			set { _clientID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceType value.
		/// </summary>
		private string _referenceType=String.Empty;
		public string ReferenceType
		{
			get { return  _referenceType; }
			set { _referenceType = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceID value.
		/// </summary>
		private long _serviceID=0;
		public long ServiceID
		{
			get { return  _serviceID; }
			set { _serviceID = value; }
		}

		/// <summary>
		/// Gets or sets the SCode value.
		/// </summary>
		private string _sCode=String.Empty;
		public string SCode
		{
			get { return  _sCode; }
			set { _sCode = value; }
		}

		/// <summary>
		/// Gets or sets the LSubType value.
		/// </summary>
		private string _lSubType=String.Empty;
		public string LSubType
		{
			get { return  _lSubType; }
			set { _lSubType = value; }
		}

		/// <summary>
		/// Gets or sets the LType value.
		/// </summary>
		private string _lType=String.Empty;
		public string LType
		{
			get { return  _lType; }
			set { _lType = value; }
		}


		#endregion
}
}
