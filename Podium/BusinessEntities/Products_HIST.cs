using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Products_HIST
	{
		#region Fields

		private long products_HISTID=0;
		private long productID=0;
		private string productName=String.Empty;
		private int categoryID=0;
		private int orgID=0;
		private string specification1=String.Empty;
		private string description=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long reOrderLevel=0;
		private string isScheduleHDrug=String.Empty;
		private int orgAddressID=0;
		private string lSU=String.Empty;
		private string hasExpiryDate=String.Empty;
		private int typeID=0;
		private string hasBatchNo=String.Empty;
		private string hasUsage=String.Empty;
		private string hasAttributes=String.Empty;
		private int usageCount=0;
		private string attributes=String.Empty;
		private string mfgName=String.Empty;
		private string mfgCode=String.Empty;
		private string isDeleted=String.Empty;
		private decimal taxPercent=Decimal.Zero;
		private long parentProductID=0;
		private string isNorcotic=String.Empty;
		private string transactionBlock=String.Empty;
		private string productCode=String.Empty;
		private string make=String.Empty;
		private long createdRole=0;
		private string orderedUnit=String.Empty;
		private long orderedConvertUnit=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Products_HISTID value.
		/// </summary>
		public long Products_HISTID
		{
			get { return products_HISTID; }
			set { products_HISTID = value; }
		}

		/// <summary>
		/// Gets or sets the ProductID value.
		/// </summary>
		public long ProductID
		{
			get { return productID; }
			set { productID = value; }
		}

		/// <summary>
		/// Gets or sets the ProductName value.
		/// </summary>
		public string ProductName
		{
			get { return productName; }
			set { productName = value; }
		}

		/// <summary>
		/// Gets or sets the CategoryID value.
		/// </summary>
		public int CategoryID
		{
			get { return categoryID; }
			set { categoryID = value; }
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
		/// Gets or sets the Specification1 value.
		/// </summary>
		public string Specification1
		{
			get { return specification1; }
			set { specification1 = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
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
		/// Gets or sets the ReOrderLevel value.
		/// </summary>
		public long ReOrderLevel
		{
			get { return reOrderLevel; }
			set { reOrderLevel = value; }
		}

		/// <summary>
		/// Gets or sets the IsScheduleHDrug value.
		/// </summary>
		public string IsScheduleHDrug
		{
			get { return isScheduleHDrug; }
			set { isScheduleHDrug = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public int OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the LSU value.
		/// </summary>
		public string LSU
		{
			get { return lSU; }
			set { lSU = value; }
		}

		/// <summary>
		/// Gets or sets the HasExpiryDate value.
		/// </summary>
		public string HasExpiryDate
		{
			get { return hasExpiryDate; }
			set { hasExpiryDate = value; }
		}

		/// <summary>
		/// Gets or sets the TypeID value.
		/// </summary>
		public int TypeID
		{
			get { return typeID; }
			set { typeID = value; }
		}

		/// <summary>
		/// Gets or sets the HasBatchNo value.
		/// </summary>
		public string HasBatchNo
		{
			get { return hasBatchNo; }
			set { hasBatchNo = value; }
		}

		/// <summary>
		/// Gets or sets the HasUsage value.
		/// </summary>
		public string HasUsage
		{
			get { return hasUsage; }
			set { hasUsage = value; }
		}

		/// <summary>
		/// Gets or sets the HasAttributes value.
		/// </summary>
		public string HasAttributes
		{
			get { return hasAttributes; }
			set { hasAttributes = value; }
		}

		/// <summary>
		/// Gets or sets the UsageCount value.
		/// </summary>
		public int UsageCount
		{
			get { return usageCount; }
			set { usageCount = value; }
		}

		/// <summary>
		/// Gets or sets the Attributes value.
		/// </summary>
		public string Attributes
		{
			get { return attributes; }
			set { attributes = value; }
		}

		/// <summary>
		/// Gets or sets the MfgName value.
		/// </summary>
		public string MfgName
		{
			get { return mfgName; }
			set { mfgName = value; }
		}

		/// <summary>
		/// Gets or sets the MfgCode value.
		/// </summary>
		public string MfgCode
		{
			get { return mfgCode; }
			set { mfgCode = value; }
		}

		/// <summary>
		/// Gets or sets the IsDeleted value.
		/// </summary>
		public string IsDeleted
		{
			get { return isDeleted; }
			set { isDeleted = value; }
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
		/// Gets or sets the ParentProductID value.
		/// </summary>
		public long ParentProductID
		{
			get { return parentProductID; }
			set { parentProductID = value; }
		}

		/// <summary>
		/// Gets or sets the IsNorcotic value.
		/// </summary>
		public string IsNorcotic
		{
			get { return isNorcotic; }
			set { isNorcotic = value; }
		}

		/// <summary>
		/// Gets or sets the TransactionBlock value.
		/// </summary>
		public string TransactionBlock
		{
			get { return transactionBlock; }
			set { transactionBlock = value; }
		}

		/// <summary>
		/// Gets or sets the ProductCode value.
		/// </summary>
		public string ProductCode
		{
			get { return productCode; }
			set { productCode = value; }
		}

		/// <summary>
		/// Gets or sets the Make value.
		/// </summary>
		public string Make
		{
			get { return make; }
			set { make = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedRole value.
		/// </summary>
		public long CreatedRole
		{
			get { return createdRole; }
			set { createdRole = value; }
		}

		/// <summary>
		/// Gets or sets the OrderedUnit value.
		/// </summary>
		public string OrderedUnit
		{
			get { return orderedUnit; }
			set { orderedUnit = value; }
		}

		/// <summary>
		/// Gets or sets the OrderedConvertUnit value.
		/// </summary>
		public long OrderedConvertUnit
		{
			get { return orderedConvertUnit; }
			set { orderedConvertUnit = value; }
		}


		#endregion
}
}
