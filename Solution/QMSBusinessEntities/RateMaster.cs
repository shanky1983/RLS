using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
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
		string _clientname;
		public string ClientName
		{
			get { return _clientname; }
			set { _clientname = value; }
		}

		/// <summary>
		/// Gets or sets the RateTypeName value.
		/// </summary>
		string _ratetypename;
		public string RateTypeName
		{
			get { return _ratetypename; }
			set { _ratetypename = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		long _investigationid;
		public long InvestigationID
		{
			get { return _investigationid; }
			set { _investigationid = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationType value.
		/// </summary>
		string _investigationtype;
		public string InvestigationType
		{
			get { return _investigationtype; }
			set { _investigationtype = value; }
		}

		/// <summary>
		/// Gets or sets the OpAmount value.
		/// </summary>
		decimal _opamount;
		public decimal OpAmount
		{
			get { return _opamount; }
			set { _opamount = value; }
		}

		/// <summary>
		/// Gets or sets the IpAmount value.
		/// </summary>
		decimal _ipamount;
		public decimal IpAmount
		{
			get { return _ipamount; }
			set { _ipamount = value; }
		}

		/// <summary>
		/// Gets or sets the ClientID value.
		/// </summary>
		long _clientid;
		public long ClientID
		{
			get { return _clientid; }
			set { _clientid = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceType value.
		/// </summary>
		string _referencetype;
		public string ReferenceType
		{
			get { return _referencetype; }
			set { _referencetype = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceID value.
		/// </summary>
		long _serviceid;
		public long ServiceID
		{
			get { return _serviceid; }
			set { _serviceid = value; }
		}

		/// <summary>
		/// Gets or sets the SCode value.
		/// </summary>
		string _scode;
		public string SCode
		{
			get { return _scode; }
			set { _scode = value; }
		}


		#endregion
}
}
