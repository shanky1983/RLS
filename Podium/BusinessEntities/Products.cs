using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Products
	{
		#region Fields

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
		private long parentProductID=0;
		private decimal taxPercent=Decimal.Zero;
		private string isNorcotic=String.Empty;
		private string transactionBlock=String.Empty;
		private string productCode=String.Empty;
		private string make=String.Empty;
		private string model=String.Empty;
		private string pSerialNo=String.Empty;
		private string pLocation=String.Empty;
		private long reminderTemplateID=0;
		private DateTime preMaintenanceDate=DateTime.MaxValue;
		private DateTime nextMaintenanceDate=DateTime.MaxValue;
		private string servicerDetails=String.Empty;
		private string hasSerialNo=String.Empty;
		private string isLabAnalyzer=String.Empty;
		private short lTofProduct=0;
		private int referenceID=0;
		private string referenceType=String.Empty;
		private string isDiscountable=String.Empty;
		private string productColour=String.Empty;
		private string cName=String.Empty;
		private string catName=String.Empty;
		private long oldCategoryID=0;
		private string orderedUnit=String.Empty;
		private long orderedConvertUnit=0;
		private string isConsign=String.Empty;
		private long shelfPeriod=0;
		private string pDeptGroup=String.Empty;
		private string shelfPeriodCode=String.Empty;
		private string hSNCode=String.Empty;
		private int taxID=0;

		#endregion

		#region Properties
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
		/// Gets or sets the ParentProductID value.
		/// </summary>
		public long ParentProductID
		{
			get { return parentProductID; }
			set { parentProductID = value; }
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
		/// Gets or sets the Model value.
		/// </summary>
		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		/// <summary>
		/// Gets or sets the PSerialNo value.
		/// </summary>
		public string PSerialNo
		{
			get { return pSerialNo; }
			set { pSerialNo = value; }
		}

		/// <summary>
		/// Gets or sets the PLocation value.
		/// </summary>
		public string PLocation
		{
			get { return pLocation; }
			set { pLocation = value; }
		}

		/// <summary>
		/// Gets or sets the ReminderTemplateID value.
		/// </summary>
		public long ReminderTemplateID
		{
			get { return reminderTemplateID; }
			set { reminderTemplateID = value; }
		}

		/// <summary>
		/// Gets or sets the PreMaintenanceDate value.
		/// </summary>
		public DateTime PreMaintenanceDate
		{
			get { return preMaintenanceDate; }
			set { preMaintenanceDate = value; }
		}

		/// <summary>
		/// Gets or sets the NextMaintenanceDate value.
		/// </summary>
		public DateTime NextMaintenanceDate
		{
			get { return nextMaintenanceDate; }
			set { nextMaintenanceDate = value; }
		}

		/// <summary>
		/// Gets or sets the ServicerDetails value.
		/// </summary>
		public string ServicerDetails
		{
			get { return servicerDetails; }
			set { servicerDetails = value; }
		}

		/// <summary>
		/// Gets or sets the HasSerialNo value.
		/// </summary>
		public string HasSerialNo
		{
			get { return hasSerialNo; }
			set { hasSerialNo = value; }
		}

		/// <summary>
		/// Gets or sets the IsLabAnalyzer value.
		/// </summary>
		public string IsLabAnalyzer
		{
			get { return isLabAnalyzer; }
			set { isLabAnalyzer = value; }
		}

		/// <summary>
		/// Gets or sets the LTofProduct value.
		/// </summary>
		public short LTofProduct
		{
			get { return lTofProduct; }
			set { lTofProduct = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceID value.
		/// </summary>
		public int ReferenceID
		{
			get { return referenceID; }
			set { referenceID = value; }
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
		/// Gets or sets the IsDiscountable value.
		/// </summary>
		public string IsDiscountable
		{
			get { return isDiscountable; }
			set { isDiscountable = value; }
		}

		/// <summary>
		/// Gets or sets the ProductColour value.
		/// </summary>
		public string ProductColour
		{
			get { return productColour; }
			set { productColour = value; }
		}

		/// <summary>
		/// Gets or sets the CName value.
		/// </summary>
		public string CName
		{
			get { return cName; }
			set { cName = value; }
		}

		/// <summary>
		/// Gets or sets the CatName value.
		/// </summary>
		public string CatName
		{
			get { return catName; }
			set { catName = value; }
		}

		/// <summary>
		/// Gets or sets the OldCategoryID value.
		/// </summary>
		public long OldCategoryID
		{
			get { return oldCategoryID; }
			set { oldCategoryID = value; }
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

		/// <summary>
		/// Gets or sets the IsConsign value.
		/// </summary>
		public string IsConsign
		{
			get { return isConsign; }
			set { isConsign = value; }
		}

		/// <summary>
		/// Gets or sets the ShelfPeriod value.
		/// </summary>
		public long ShelfPeriod
		{
			get { return shelfPeriod; }
			set { shelfPeriod = value; }
		}

		/// <summary>
		/// Gets or sets the PDeptGroup value.
		/// </summary>
		public string PDeptGroup
		{
			get { return pDeptGroup; }
			set { pDeptGroup = value; }
		}

		/// <summary>
		/// Gets or sets the ShelfPeriodCode value.
		/// </summary>
		public string ShelfPeriodCode
		{
			get { return shelfPeriodCode; }
			set { shelfPeriodCode = value; }
		}

		/// <summary>
		/// Gets or sets the HSNCode value.
		/// </summary>
		public string HSNCode
		{
			get { return hSNCode; }
			set { hSNCode = value; }
		}

		/// <summary>
		/// Gets or sets the TaxID value.
		/// </summary>
		public int TaxID
		{
			get { return taxID; }
			set { taxID = value; }
		}

		/// <summary>
		/// Gets or sets the DateOfMaintenance value.
		/// </summary>
		private DateTime _dateOfMaintenance=DateTime.MaxValue;
		public DateTime DateOfMaintenance
		{
			get { return  _dateOfMaintenance; }
			set { _dateOfMaintenance = value; }
		}

		/// <summary>
		/// Gets or sets the ActualDateOfMaintenance value.
		/// </summary>
		private DateTime _actualDateOfMaintenance=DateTime.MaxValue;
		public DateTime ActualDateOfMaintenance
		{
			get { return  _actualDateOfMaintenance; }
			set { _actualDateOfMaintenance = value; }
		}

		/// <summary>
		/// Gets or sets the CorrectiveAction value.
		/// </summary>
		private string _correctiveAction=String.Empty;
		public string CorrectiveAction
		{
			get { return  _correctiveAction; }
			set { _correctiveAction = value; }
		}

		/// <summary>
		/// Gets or sets the MaintenanceCost value.
		/// </summary>
		private decimal _maintenanceCost=Decimal.Zero;
		public decimal MaintenanceCost
		{
			get { return  _maintenanceCost; }
			set { _maintenanceCost = value; }
		}

		/// <summary>
		/// Gets or sets the MaintenanceType value.
		/// </summary>
		private string _maintenanceType=String.Empty;
		public string MaintenanceType
		{
			get { return  _maintenanceType; }
			set { _maintenanceType = value; }
		}

		/// <summary>
		/// Gets or sets the ProbDetails value.
		/// </summary>
		private string _probDetails=String.Empty;
		public string ProbDetails
		{
			get { return  _probDetails; }
			set { _probDetails = value; }
		}

		/// <summary>
		/// Gets or sets the StockReceivedDetailsId value.
		/// </summary>
		private long _stockReceivedDetailsId=0;
		public long StockReceivedDetailsId
		{
			get { return  _stockReceivedDetailsId; }
			set { _stockReceivedDetailsId = value; }
		}

		/// <summary>
		/// Gets or sets the StartDate value.
		/// </summary>
		private DateTime _startDate=DateTime.MaxValue;
		public DateTime StartDate
		{
			get { return  _startDate; }
			set { _startDate = value; }
		}

		/// <summary>
		/// Gets or sets the EndDate value.
		/// </summary>
		private DateTime _endDate=DateTime.MaxValue;
		public DateTime EndDate
		{
			get { return  _endDate; }
			set { _endDate = value; }
		}

		/// <summary>
		/// Gets or sets the Frequency value.
		/// </summary>
		private string _frequency=String.Empty;
		public string Frequency
		{
			get { return  _frequency; }
			set { _frequency = value; }
		}

		/// <summary>
		/// Gets or sets the Notes value.
		/// </summary>
		private string _notes=String.Empty;
		public string Notes
		{
			get { return  _notes; }
			set { _notes = value; }
		}

		/// <summary>
		/// Gets or sets the AmcProvider value.
		/// </summary>
		private string _amcProvider=String.Empty;
		public string AmcProvider
		{
			get { return  _amcProvider; }
			set { _amcProvider = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedRoleName value.
		/// </summary>
		private string _createdRoleName=String.Empty;
		public string CreatedRoleName
		{
			get { return  _createdRoleName; }
			set { _createdRoleName = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedLoginName value.
		/// </summary>
		private string _createdLoginName=String.Empty;
		public string CreatedLoginName
		{
			get { return  _createdLoginName; }
			set { _createdLoginName = value; }
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
		/// Gets or sets the ClientID value.
		/// </summary>
		private long _clientID=0;
		public long ClientID
		{
			get { return  _clientID; }
			set { _clientID = value; }
		}


		#endregion
}
}
