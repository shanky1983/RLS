using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Taxmaster
	{
		#region Fields

		private int taxID=0;
		private string taxName=String.Empty;
		private decimal taxPercent=Decimal.Zero;
		private int orgID=0;
		private string activeYN=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string code=String.Empty;
		private string referenceType=String.Empty;
		private string sourceType=String.Empty;
		private long sourceID=0;
		private string taxType=String.Empty;
		private string langCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TaxID value.
		/// </summary>
		public int TaxID
		{
			get { return taxID; }
			set { taxID = value; }
		}

		/// <summary>
		/// Gets or sets the TaxName value.
		/// </summary>
		public string TaxName
		{
			get { return taxName; }
			set { taxName = value; }
		}

		/// <summary>
		/// Gets or sets the TaxPercent value.
		/// </summary>
		public decimal TaxPercent
		{
			get { return taxPercent; }
			set { taxPercent = value; }
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
		/// Gets or sets the ActiveYN value.
		/// </summary>
		public string ActiveYN
		{
			get { return activeYN; }
			set { activeYN = value; }
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
		/// Gets or sets the Code value.
		/// </summary>
		public string Code
		{
			get { return code; }
			set { code = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceType value.
		/// </summary>
		public string ReferenceType
		{
			get { return referenceType; }
			set { referenceType = value; }
		}

		/// <summary>
		/// Gets or sets the SourceType value.
		/// </summary>
		public string SourceType
		{
			get { return sourceType; }
			set { sourceType = value; }
		}

		/// <summary>
		/// Gets or sets the SourceID value.
		/// </summary>
		public long SourceID
		{
			get { return sourceID; }
			set { sourceID = value; }
		}

		/// <summary>
		/// Gets or sets the TaxType value.
		/// </summary>
		public string TaxType
		{
			get { return taxType; }
			set { taxType = value; }
		}

		/// <summary>
		/// Gets or sets the LangCode value.
		/// </summary>
		public string LangCode
		{
			get { return langCode; }
			set { langCode = value; }
		}

		/// <summary>
		/// Gets or sets the TaxAmount value.
		/// </summary>
		decimal _taxamount;
		public decimal TaxAmount
		{
			get { return _taxamount; }
			set { _taxamount = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceName value.
		/// </summary>
		string _referencename;
		public string ReferenceName
		{
			get { return _referencename; }
			set { _referencename = value; }
		}


		#endregion
}
}
