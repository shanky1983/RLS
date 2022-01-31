using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class OrganizationAddress
	{
		#region Fields

		private long addressID=0;
		private int orgID=0;
		private string addressType=String.Empty;
		private string add1=String.Empty;
		private string add2=String.Empty;
		private string add3=String.Empty;
		private string postalCode=String.Empty;
		private long countryID=0;
		private string city=String.Empty;
		private long stateID=0;
		private string mobileNumber=String.Empty;
		private string landLineNumber=String.Empty;
		private DateTime startDTTM=DateTime.MaxValue;
		private DateTime endDTTM=DateTime.MaxValue;
		private string comments=String.Empty;
		private string location=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string otherCountryName=String.Empty;
		private string otherStateName=String.Empty;
		private string status=String.Empty;
		private string locationCode=String.Empty;
		private string referType=String.Empty;
		private long referTypeID=0;
		private string isDefault=String.Empty;
		private string centerTypeCode=String.Empty;
		private string cityCode=String.Empty;
		private int cutOffTimeValue=0;
		private string cutOffTimeType=String.Empty;
		private string isMappedClients=String.Empty;
		private string isPrint=String.Empty;
		private string isRemote=String.Empty;
		private long parentAddressID=0;
		private long processingAddressID=0;
		private string hasHealthcoupon=String.Empty;
		private int addLevel1=0;
		private int addLevel2=0;
		private TimeSpan timeDifference=TimeSpan.MinValue;
		private string timeZone=String.Empty;
		private string timeFormat=String.Empty;
		private string dateFormat=String.Empty;
		private string ambulanceNumber=String.Empty;
		private int locRateID=0;
		private byte[] logo=new byte[0];
		private bool isScanInScanOutRequired=false;
		private byte isIntegrationTest=0x00;
        private string isfranchisee = string.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AddressID value.
		/// </summary>
		public long AddressID
		{
			get { return addressID; }
			set { addressID = value; }
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
		/// Gets or sets the AddressType value.
		/// </summary>
		public string AddressType
		{
			get { return addressType; }
			set { addressType = value; }
		}

		/// <summary>
		/// Gets or sets the Add1 value.
		/// </summary>
		public string Add1
		{
			get { return add1; }
			set { add1 = value; }
		}

		/// <summary>
		/// Gets or sets the Add2 value.
		/// </summary>
		public string Add2
		{
			get { return add2; }
			set { add2 = value; }
		}

		/// <summary>
		/// Gets or sets the Add3 value.
		/// </summary>
		public string Add3
		{
			get { return add3; }
			set { add3 = value; }
		}

		/// <summary>
		/// Gets or sets the PostalCode value.
		/// </summary>
		public string PostalCode
		{
			get { return postalCode; }
			set { postalCode = value; }
		}

		/// <summary>
		/// Gets or sets the CountryID value.
		/// </summary>
		public long CountryID
		{
			get { return countryID; }
			set { countryID = value; }
		}

		/// <summary>
		/// Gets or sets the City value.
		/// </summary>
		public string City
		{
			get { return city; }
			set { city = value; }
		}

		/// <summary>
		/// Gets or sets the StateID value.
		/// </summary>
		public long StateID
		{
			get { return stateID; }
			set { stateID = value; }
		}

		/// <summary>
		/// Gets or sets the MobileNumber value.
		/// </summary>
		public string MobileNumber
		{
			get { return mobileNumber; }
			set { mobileNumber = value; }
		}

		/// <summary>
		/// Gets or sets the LandLineNumber value.
		/// </summary>
		public string LandLineNumber
		{
			get { return landLineNumber; }
			set { landLineNumber = value; }
		}

		/// <summary>
		/// Gets or sets the StartDTTM value.
		/// </summary>
		public DateTime StartDTTM
		{
			get { return startDTTM; }
			set { startDTTM = value; }
		}

		/// <summary>
		/// Gets or sets the EndDTTM value.
		/// </summary>
		public DateTime EndDTTM
		{
			get { return endDTTM; }
			set { endDTTM = value; }
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
		/// Gets or sets the Location value.
		/// </summary>
		public string Location
		{
			get { return location; }
			set { location = value; }
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
		/// Gets or sets the OtherCountryName value.
		/// </summary>
		public string OtherCountryName
		{
			get { return otherCountryName; }
			set { otherCountryName = value; }
		}

		/// <summary>
		/// Gets or sets the OtherStateName value.
		/// </summary>
		public string OtherStateName
		{
			get { return otherStateName; }
			set { otherStateName = value; }
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
		/// Gets or sets the LocationCode value.
		/// </summary>
		public string LocationCode
		{
			get { return locationCode; }
			set { locationCode = value; }
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
		/// Gets or sets the IsDefault value.
		/// </summary>
		public string IsDefault
		{
			get { return isDefault; }
			set { isDefault = value; }
		}

		/// <summary>
		/// Gets or sets the CenterTypeCode value.
		/// </summary>
		public string CenterTypeCode
		{
			get { return centerTypeCode; }
			set { centerTypeCode = value; }
		}

		/// <summary>
		/// Gets or sets the CityCode value.
		/// </summary>
		public string CityCode
		{
			get { return cityCode; }
			set { cityCode = value; }
		}

		/// <summary>
		/// Gets or sets the CutOffTimeValue value.
		/// </summary>
		public int CutOffTimeValue
		{
			get { return cutOffTimeValue; }
			set { cutOffTimeValue = value; }
		}

		/// <summary>
		/// Gets or sets the CutOffTimeType value.
		/// </summary>
		public string CutOffTimeType
		{
			get { return cutOffTimeType; }
			set { cutOffTimeType = value; }
		}

		/// <summary>
		/// Gets or sets the IsMappedClients value.
		/// </summary>
		public string IsMappedClients
		{
			get { return isMappedClients; }
			set { isMappedClients = value; }
		}

		/// <summary>
		/// Gets or sets the IsPrint value.
		/// </summary>
		public string IsPrint
		{
			get { return isPrint; }
			set { isPrint = value; }
		}

		/// <summary>
		/// Gets or sets the IsRemote value.
		/// </summary>
		public string IsRemote
		{
			get { return isRemote; }
			set { isRemote = value; }
		}

		/// <summary>
		/// Gets or sets the ParentAddressID value.
		/// </summary>
		public long ParentAddressID
		{
			get { return parentAddressID; }
			set { parentAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessingAddressID value.
		/// </summary>
		public long ProcessingAddressID
		{
			get { return processingAddressID; }
			set { processingAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the HasHealthcoupon value.
		/// </summary>
		public string HasHealthcoupon
		{
			get { return hasHealthcoupon; }
			set { hasHealthcoupon = value; }
		}

		/// <summary>
		/// Gets or sets the AddLevel1 value.
		/// </summary>
		public int AddLevel1
		{
			get { return addLevel1; }
			set { addLevel1 = value; }
		}

		/// <summary>
		/// Gets or sets the AddLevel2 value.
		/// </summary>
		public int AddLevel2
		{
			get { return addLevel2; }
			set { addLevel2 = value; }
		}

		/// <summary>
		/// Gets or sets the TimeDifference value.
		/// </summary>
		public TimeSpan TimeDifference
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
		/// Gets or sets the TimeFormat value.
		/// </summary>
		public string TimeFormat
		{
			get { return timeFormat; }
			set { timeFormat = value; }
		}

		/// <summary>
		/// Gets or sets the DateFormat value.
		/// </summary>
		public string DateFormat
		{
			get { return dateFormat; }
			set { dateFormat = value; }
		}

		/// <summary>
		/// Gets or sets the AmbulanceNumber value.
		/// </summary>
		public string AmbulanceNumber
		{
			get { return ambulanceNumber; }
			set { ambulanceNumber = value; }
		}

		/// <summary>
		/// Gets or sets the LocRateID value.
		/// </summary>
		public int LocRateID
		{
			get { return locRateID; }
			set { locRateID = value; }
		}

		/// <summary>
		/// Gets or sets the Logo value.
		/// </summary>
		public byte[] Logo
		{
			get { return logo; }
			set { logo = value; }
		}

		/// <summary>
		/// Gets or sets the IsScanInScanOutRequired value.
		/// </summary>
		public bool IsScanInScanOutRequired
		{
			get { return isScanInScanOutRequired; }
			set { isScanInScanOutRequired = value; }
		}

		/// <summary>
		/// Gets or sets the IsIntegrationTest value.
		/// </summary>
		public byte IsIntegrationTest
		{
			get { return isIntegrationTest; }
			set { isIntegrationTest = value; }
		}
        public string IsFranchisee
        {
            get { return isfranchisee; }
            set { isfranchisee = value; }
        }

		#endregion
}
}
