using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class NewInstanceWaitingCustomers
	{
		#region Fields

		private int newInstanceWaitID=0;
		private string name=String.Empty;
		private int organizationTypeID=0;
		private string logoPath=String.Empty;
		private string add1=String.Empty;
		private string add2=String.Empty;
		private string add3=String.Empty;
		private string postalCode=String.Empty;
		private short countryID=0;
		private string city=String.Empty;
		private short stateID=0;
		private string landLineNumber=String.Empty;
		private string location=String.Empty;
		private DateTime startDTTM=DateTime.MaxValue;
		private DateTime endDTTM=DateTime.MaxValue;
		private string otherCountryName=String.Empty;
		private string otherStateName=String.Empty;
		private string mobileNo=String.Empty;
		private long aliceID=0;
		private string aliceType=String.Empty;
		private string isApproved=String.Empty;
		private string isdefaultorg=String.Empty;
		private long defaultOrgID=0;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private int countryCode=0;
		private int stateCode=0;
		private int cityCode=0;
		private int addLevel1=0;
		private int addLevel2=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the NewInstanceWaitID value.
		/// </summary>
		public int NewInstanceWaitID
		{
			get { return newInstanceWaitID; }
			set { newInstanceWaitID = value; }
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
		/// Gets or sets the LogoPath value.
		/// </summary>
		public string LogoPath
		{
			get { return logoPath; }
			set { logoPath = value; }
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
		public short CountryID
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
		public short StateID
		{
			get { return stateID; }
			set { stateID = value; }
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
		/// Gets or sets the Location value.
		/// </summary>
		public string Location
		{
			get { return location; }
			set { location = value; }
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
		/// Gets or sets the MobileNo value.
		/// </summary>
		public string MobileNo
		{
			get { return mobileNo; }
			set { mobileNo = value; }
		}

		/// <summary>
		/// Gets or sets the AliceID value.
		/// </summary>
		public long AliceID
		{
			get { return aliceID; }
			set { aliceID = value; }
		}

		/// <summary>
		/// Gets or sets the AliceType value.
		/// </summary>
		public string AliceType
		{
			get { return aliceType; }
			set { aliceType = value; }
		}

		/// <summary>
		/// Gets or sets the IsApproved value.
		/// </summary>
		public string IsApproved
		{
			get { return isApproved; }
			set { isApproved = value; }
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
		/// Gets or sets the DefaultOrgID value.
		/// </summary>
		public long DefaultOrgID
		{
			get { return defaultOrgID; }
			set { defaultOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
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
		/// Gets or sets the CountryCode value.
		/// </summary>
		public int CountryCode
		{
			get { return countryCode; }
			set { countryCode = value; }
		}

		/// <summary>
		/// Gets or sets the StateCode value.
		/// </summary>
		public int StateCode
		{
			get { return stateCode; }
			set { stateCode = value; }
		}

		/// <summary>
		/// Gets or sets the CityCode value.
		/// </summary>
		public int CityCode
		{
			get { return cityCode; }
			set { cityCode = value; }
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


		#endregion
}
}
