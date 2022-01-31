using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PreQuotationInvestigations
	{
		#region Fields

		private long quotationId=0;
		private long iD=0;
		private string name=String.Empty;
		private string investigationsType=String.Empty;
		private string sampleTypeID=String.Empty;
		private int sampleCount=0;
		private string discountTypeID=String.Empty;
		private int discountValue=0;
		private decimal amount=Decimal.Zero;
		private string status=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long pkgID=0;
		private string pkgName=String.Empty;
		private long accessionNumber=0;
		private decimal pkgAmt=Decimal.Zero;
		private long visitID=0;
		private int uniqueID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the QuotationId value.
		/// </summary>
		public long QuotationId
		{
			get { return quotationId; }
			set { quotationId = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationsType value.
		/// </summary>
		public string InvestigationsType
		{
			get { return investigationsType; }
			set { investigationsType = value; }
		}

		/// <summary>
		/// Gets or sets the SampleTypeID value.
		/// </summary>
		public string SampleTypeID
		{
			get { return sampleTypeID; }
			set { sampleTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the SampleCount value.
		/// </summary>
		public int SampleCount
		{
			get { return sampleCount; }
			set { sampleCount = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountTypeID value.
		/// </summary>
		public string DiscountTypeID
		{
			get { return discountTypeID; }
			set { discountTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountValue value.
		/// </summary>
		public int DiscountValue
		{
			get { return discountValue; }
			set { discountValue = value; }
		}

		/// <summary>
		/// Gets or sets the Amount value.
		/// </summary>
		public decimal Amount
		{
			get { return amount; }
			set { amount = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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
		/// Gets or sets the PkgID value.
		/// </summary>
		public long PkgID
		{
			get { return pkgID; }
			set { pkgID = value; }
		}

		/// <summary>
		/// Gets or sets the PkgName value.
		/// </summary>
		public string PkgName
		{
			get { return pkgName; }
			set { pkgName = value; }
		}

		/// <summary>
		/// Gets or sets the AccessionNumber value.
		/// </summary>
		public long AccessionNumber
		{
			get { return accessionNumber; }
			set { accessionNumber = value; }
		}

		/// <summary>
		/// Gets or sets the PkgAmt value.
		/// </summary>
		public decimal PkgAmt
		{
			get { return pkgAmt; }
			set { pkgAmt = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the UniqueID value.
		/// </summary>
		public int UniqueID
		{
			get { return uniqueID; }
			set { uniqueID = value; }
		}


		#endregion
}
}
