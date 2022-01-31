using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Organization
	{
		#region Fields

		private int orgID=0;
		private string name=String.Empty;
		private int organizationTypeID=0;
		private int addressID=0;
		private string email=String.Empty;
		private string remarks=String.Empty;
		private string logoPath=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string integrationName=String.Empty;
		private string orgDisplayName=String.Empty;
		private int parentOrgID=0;
		private int rootOrgID=0;
		private string referType=String.Empty;
		private long referTypeID=0;
		private long centreCode=0;
		private int timeDifference=0;
		private string timeZone=String.Empty;
		private string isbaseorg=String.Empty;
		private long defaultOrgID=0;
		private string isdefaultorg=String.Empty;
		private int orgCategoryID=0;

        private string reportLanguage = String.Empty;
		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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
		/// Gets or sets the OrganizationTypeID value.
		/// </summary>
		public int OrganizationTypeID
		{
			get { return organizationTypeID; }
			set { organizationTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the AddressID value.
		/// </summary>
		public int AddressID
		{
			get { return addressID; }
			set { addressID = value; }
		}

		/// <summary>
		/// Gets or sets the Email value.
		/// </summary>
		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
		}

		/// <summary>
		/// Gets or sets the LogoPath value.
		/// </summary>
		public string LogoPath
		{
			get { return logoPath; }
			set { logoPath = value; }
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
		/// Gets or sets the IntegrationName value.
		/// </summary>
		public string IntegrationName
		{
			get { return integrationName; }
			set { integrationName = value; }
		}

		/// <summary>
		/// Gets or sets the OrgDisplayName value.
		/// </summary>
		public string OrgDisplayName
		{
			get { return orgDisplayName; }
			set { orgDisplayName = value; }
		}

		/// <summary>
		/// Gets or sets the ParentOrgID value.
		/// </summary>
		public int ParentOrgID
		{
			get { return parentOrgID; }
			set { parentOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the RootOrgID value.
		/// </summary>
		public int RootOrgID
		{
			get { return rootOrgID; }
			set { rootOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferType value.
		/// </summary>
		public string ReferType
		{
			get { return referType; }
			set { referType = value; }
		}

		/// <summary>
		/// Gets or sets the ReferTypeID value.
		/// </summary>
		public long ReferTypeID
		{
			get { return referTypeID; }
			set { referTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the CentreCode value.
		/// </summary>
		public long CentreCode
		{
			get { return centreCode; }
			set { centreCode = value; }
		}

		/// <summary>
		/// Gets or sets the TimeDifference value.
		/// </summary>
		public int TimeDifference
		{
			get { return timeDifference; }
			set { timeDifference = value; }
		}

		/// <summary>
		/// Gets or sets the TimeZone value.
		/// </summary>
		public string TimeZone
		{
			get { return timeZone; }
			set { timeZone = value; }
		}

		/// <summary>
		/// Gets or sets the Isbaseorg value.
		/// </summary>
		public string Isbaseorg
		{
			get { return isbaseorg; }
			set { isbaseorg = value; }
		}

		/// <summary>
		/// Gets or sets the DefaultOrgID value.
		/// </summary>
		public long DefaultOrgID
		{
			get { return defaultOrgID; }
			set { defaultOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the Isdefaultorg value.
		/// </summary>
		public string Isdefaultorg
		{
			get { return isdefaultorg; }
			set { isdefaultorg = value; }
		}

		/// <summary>
		/// Gets or sets the OrgCategoryID value.
		/// </summary>
		public int OrgCategoryID
		{
			get { return orgCategoryID; }
			set { orgCategoryID = value; }
		}

		/// <summary>
		/// Gets or sets the FinalBillID value.
		/// </summary>
		private long _finalBillID=0;
		public long FinalBillID
		{
			get { return  _finalBillID; }
			set { _finalBillID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		private long _patientID=0;
		public long PatientID
		{
			get { return  _patientID; }
			set { _patientID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		private long _visitID=0;
		public long VisitID
		{
			get { return  _visitID; }
			set { _visitID = value; }
		}

		/// <summary>
		/// Gets or sets the GrossBillValue value.
		/// </summary>
		private decimal _grossBillValue=Decimal.Zero;
		public decimal GrossBillValue
		{
			get { return  _grossBillValue; }
			set { _grossBillValue = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountAmount value.
		/// </summary>
		private decimal _discountAmount=Decimal.Zero;
		public decimal DiscountAmount
		{
			get { return  _discountAmount; }
			set { _discountAmount = value; }
		}

		/// <summary>
		/// Gets or sets the StdDedID value.
		/// </summary>
		private long _stdDedID=0;
		public long StdDedID
		{
			get { return  _stdDedID; }
			set { _stdDedID = value; }
		}

		/// <summary>
		/// Gets or sets the NetValue value.
		/// </summary>
		private decimal _netValue=Decimal.Zero;
		public decimal NetValue
		{
			get { return  _netValue; }
			set { _netValue = value; }
		}

		/// <summary>
		/// Gets or sets the AmountReceived value.
		/// </summary>
		private decimal _amountReceived=Decimal.Zero;
		public decimal AmountReceived
		{
			get { return  _amountReceived; }
			set { _amountReceived = value; }
		}

		/// <summary>
		/// Gets or sets the Due value.
		/// </summary>
		private decimal _due=Decimal.Zero;
		public decimal Due
		{
			get { return  _due; }
			set { _due = value; }
		}

		/// <summary>
		/// Gets or sets the AdvanceRecieved value.
		/// </summary>
		private decimal _advanceRecieved=Decimal.Zero;
		public decimal AdvanceRecieved
		{
			get { return  _advanceRecieved; }
			set { _advanceRecieved = value; }
		}

		/// <summary>
		/// Gets or sets the AmountRefund value.
		/// </summary>
		private decimal _amountRefund=Decimal.Zero;
		public decimal AmountRefund
		{
			get { return  _amountRefund; }
			set { _amountRefund = value; }
		}

		/// <summary>
		/// Gets or sets the IsCreditBill value.
		/// </summary>
		private string _isCreditBill=String.Empty;
		public string IsCreditBill
		{
			get { return  _isCreditBill; }
			set { _isCreditBill = value; }
		}

		/// <summary>
		/// Gets or sets the Address value.
		/// </summary>
		private string _address=String.Empty;
		public string Address
		{
			get { return  _address; }
			set { _address = value; }
		}

		/// <summary>
		/// Gets or sets the City value.
		/// </summary>
		private string _city=String.Empty;
		public string City
		{
			get { return  _city; }
			set { _city = value; }
		}

		/// <summary>
		/// Gets or sets the PhoneNumber value.
		/// </summary>
		private string _phoneNumber=String.Empty;
		public string PhoneNumber
		{
			get { return  _phoneNumber; }
			set { _phoneNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Add1 value.
		/// </summary>
		private string _add1=String.Empty;
		public string Add1
		{
			get { return  _add1; }
			set { _add1 = value; }
		}

		/// <summary>
		/// Gets or sets the Add2 value.
		/// </summary>
		private string _add2=String.Empty;
		public string Add2
		{
			get { return  _add2; }
			set { _add2 = value; }
		}

		/// <summary>
		/// Gets or sets the Add3 value.
		/// </summary>
		private string _add3=String.Empty;
		public string Add3
		{
			get { return  _add3; }
			set { _add3 = value; }
		}

		/// <summary>
		/// Gets or sets the PostalCode value.
		/// </summary>
		private string _postalCode=String.Empty;
		public string PostalCode
		{
			get { return  _postalCode; }
			set { _postalCode = value; }
		}

		/// <summary>
		/// Gets or sets the CountryID value.
		/// </summary>
		private long _countryID=0;
		public long CountryID
		{
			get { return  _countryID; }
			set { _countryID = value; }
		}

		/// <summary>
		/// Gets or sets the StateID value.
		/// </summary>
		private long _stateID=0;
		public long StateID
		{
			get { return  _stateID; }
			set { _stateID = value; }
		}

		/// <summary>
		/// Gets or sets the LandLineNumber value.
		/// </summary>
		private string _landLineNumber=String.Empty;
		public string LandLineNumber
		{
			get { return  _landLineNumber; }
			set { _landLineNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Location value.
		/// </summary>
		private string _location=String.Empty;
		public string Location
		{
			get { return  _location; }
			set { _location = value; }
		}

		/// <summary>
		/// Gets or sets the StartDTTM value.
		/// </summary>
		private DateTime _startDTTM=DateTime.MaxValue;
		public DateTime StartDTTM
		{
			get { return  _startDTTM; }
			set { _startDTTM = value; }
		}

		/// <summary>
		/// Gets or sets the EndDTTM value.
		/// </summary>
		private DateTime _endDTTM=DateTime.MaxValue;
		public DateTime EndDTTM
		{
			get { return  _endDTTM; }
			set { _endDTTM = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddID value.
		/// </summary>
		private long _orgAddID=0;
		public long OrgAddID
		{
			get { return  _orgAddID; }
			set { _orgAddID = value; }
		}

		/// <summary>
		/// Gets or sets the OtherCountryName value.
		/// </summary>
		private string _otherCountryName=String.Empty;
		public string OtherCountryName
		{
			get { return  _otherCountryName; }
			set { _otherCountryName = value; }
		}

		/// <summary>
		/// Gets or sets the OtherStateName value.
		/// </summary>
		private string _otherStateName=String.Empty;
		public string OtherStateName
		{
			get { return  _otherStateName; }
			set { _otherStateName = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		private int _locationID=0;
		public int LocationID
		{
			get { return  _locationID; }
			set { _locationID = value; }
		}

		/// <summary>
		/// Gets or sets the CountryCode value.
		/// </summary>
		private int _countryCode=0;
		public int CountryCode
		{
			get { return  _countryCode; }
			set { _countryCode = value; }
		}

		/// <summary>
		/// Gets or sets the StateCode value.
		/// </summary>
		private int _stateCode=0;
		public int StateCode
		{
			get { return  _stateCode; }
			set { _stateCode = value; }
		}

		/// <summary>
		/// Gets or sets the CityCode value.
		/// </summary>
		private int _cityCode=0;
		public int CityCode
		{
			get { return  _cityCode; }
			set { _cityCode = value; }
		}

		/// <summary>
		/// Gets or sets the AddLevel1 value.
		/// </summary>
		private int _addLevel1=0;
		public int AddLevel1
		{
			get { return  _addLevel1; }
			set { _addLevel1 = value; }
		}

		/// <summary>
		/// Gets or sets the AddLevel2 value.
		/// </summary>
		private int _addLevel2=0;
		public int AddLevel2
		{
			get { return  _addLevel2; }
			set { _addLevel2 = value; }
		}

		/// <summary>
		/// Gets or sets the OrgCategory value.
		/// </summary>
		private string _orgCategory=String.Empty;
		public string OrgCategory
		{
			get { return  _orgCategory; }
			set { _orgCategory = value; }
		}
        public string ReportLanguage
        {
            get { return reportLanguage; }
            set { reportLanguage = value; }
        }

		#endregion
}
}
