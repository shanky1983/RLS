using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
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
		long _finalbillid;
		public long FinalBillID
		{
			get { return _finalbillid; }
			set { _finalbillid = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		long _patientid;
		public long PatientID
		{
			get { return _patientid; }
			set { _patientid = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		long _visitid;
		public long VisitID
		{
			get { return _visitid; }
			set { _visitid = value; }
		}

		/// <summary>
		/// Gets or sets the GrossBillValue value.
		/// </summary>
		decimal _grossbillvalue;
		public decimal GrossBillValue
		{
			get { return _grossbillvalue; }
			set { _grossbillvalue = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountAmount value.
		/// </summary>
		decimal _discountamount;
		public decimal DiscountAmount
		{
			get { return _discountamount; }
			set { _discountamount = value; }
		}

		/// <summary>
		/// Gets or sets the StdDedID value.
		/// </summary>
		long _stddedid;
		public long StdDedID
		{
			get { return _stddedid; }
			set { _stddedid = value; }
		}

		/// <summary>
		/// Gets or sets the NetValue value.
		/// </summary>
		decimal _netvalue;
		public decimal NetValue
		{
			get { return _netvalue; }
			set { _netvalue = value; }
		}

		/// <summary>
		/// Gets or sets the AmountReceived value.
		/// </summary>
		decimal _amountreceived;
		public decimal AmountReceived
		{
			get { return _amountreceived; }
			set { _amountreceived = value; }
		}

		/// <summary>
		/// Gets or sets the Due value.
		/// </summary>
		decimal _due;
		public decimal Due
		{
			get { return _due; }
			set { _due = value; }
		}

		/// <summary>
		/// Gets or sets the AdvanceRecieved value.
		/// </summary>
		decimal _advancerecieved;
		public decimal AdvanceRecieved
		{
			get { return _advancerecieved; }
			set { _advancerecieved = value; }
		}

		/// <summary>
		/// Gets or sets the AmountRefund value.
		/// </summary>
		decimal _amountrefund;
		public decimal AmountRefund
		{
			get { return _amountrefund; }
			set { _amountrefund = value; }
		}

		/// <summary>
		/// Gets or sets the IsCreditBill value.
		/// </summary>
		string _iscreditbill;
		public string IsCreditBill
		{
			get { return _iscreditbill; }
			set { _iscreditbill = value; }
		}

		/// <summary>
		/// Gets or sets the Address value.
		/// </summary>
		string _address;
		public string Address
		{
			get { return _address; }
			set { _address = value; }
		}

		/// <summary>
		/// Gets or sets the City value.
		/// </summary>
		string _city;
		public string City
		{
			get { return _city; }
			set { _city = value; }
		}

		/// <summary>
		/// Gets or sets the PhoneNumber value.
		/// </summary>
		string _phonenumber;
		public string PhoneNumber
		{
			get { return _phonenumber; }
			set { _phonenumber = value; }
		}

		/// <summary>
		/// Gets or sets the Add1 value.
		/// </summary>
		string _add1;
		public string Add1
		{
			get { return _add1; }
			set { _add1 = value; }
		}

		/// <summary>
		/// Gets or sets the Add2 value.
		/// </summary>
		string _add2;
		public string Add2
		{
			get { return _add2; }
			set { _add2 = value; }
		}

		/// <summary>
		/// Gets or sets the Add3 value.
		/// </summary>
		string _add3;
		public string Add3
		{
			get { return _add3; }
			set { _add3 = value; }
		}

		/// <summary>
		/// Gets or sets the PostalCode value.
		/// </summary>
		string _postalcode;
		public string PostalCode
		{
			get { return _postalcode; }
			set { _postalcode = value; }
		}

		/// <summary>
		/// Gets or sets the CountryID value.
		/// </summary>
		int _countryid;
		public int CountryID
		{
			get { return _countryid; }
			set { _countryid = value; }
		}

		/// <summary>
		/// Gets or sets the StateID value.
		/// </summary>
		int _stateid;
		public int StateID
		{
			get { return _stateid; }
			set { _stateid = value; }
		}

		/// <summary>
		/// Gets or sets the LandLineNumber value.
		/// </summary>
		string _landlinenumber;
		public string LandLineNumber
		{
			get { return _landlinenumber; }
			set { _landlinenumber = value; }
		}

		/// <summary>
		/// Gets or sets the Location value.
		/// </summary>
		string _location;
		public string Location
		{
			get { return _location; }
			set { _location = value; }
		}

		/// <summary>
		/// Gets or sets the StartDTTM value.
		/// </summary>
		DateTime _startdttm;
		public DateTime StartDTTM
		{
			get { return _startdttm; }
			set { _startdttm = value; }
		}

		/// <summary>
		/// Gets or sets the EndDTTM value.
		/// </summary>
		DateTime _enddttm;
		public DateTime EndDTTM
		{
			get { return _enddttm; }
			set { _enddttm = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddID value.
		/// </summary>
		long _orgaddid;
		public long OrgAddID
		{
			get { return _orgaddid; }
			set { _orgaddid = value; }
		}

		/// <summary>
		/// Gets or sets the OtherCountryName value.
		/// </summary>
		string _othercountryname;
		public string OtherCountryName
		{
			get { return _othercountryname; }
			set { _othercountryname = value; }
		}

		/// <summary>
		/// Gets or sets the OtherStateName value.
		/// </summary>
		string _otherstatename;
		public string OtherStateName
		{
			get { return _otherstatename; }
			set { _otherstatename = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		int _locationid;
		public int LocationID
		{
			get { return _locationid; }
			set { _locationid = value; }
		}


		#endregion
}
}
