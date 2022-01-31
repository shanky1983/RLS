using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class AddressDetails
	{
		#region Fields

		private long addressID=0;
		private int addressTypeID=0;
		private long referenceID=0;
		private string referenceType=String.Empty;
		private string address1=String.Empty;
		private string city=String.Empty;
		private int countryID=0;
		private int stateID=0;
		private string emailID=String.Empty;
		private string phone=String.Empty;
		private string mobile=String.Empty;
		private string faxNumber=String.Empty;
		private int orgID=0;
		private string isCommunication=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int iSDCode=0;
		private string name=String.Empty;
		private string contactType=String.Empty;
		private long empID=0;
		private string subUrban=String.Empty;
		private string postalCode=String.Empty;
		private string address2=String.Empty;
		private string invoiceEmail=String.Empty;

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
		/// Gets or sets the AddressTypeID value.
		/// </summary>
		public int AddressTypeID
		{
			get { return addressTypeID; }
			set { addressTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceID value.
		/// </summary>
		public long ReferenceID
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
		/// Gets or sets the Address1 value.
		/// </summary>
		public string Address1
		{
			get { return address1; }
			set { address1 = value; }
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
		/// Gets or sets the CountryID value.
		/// </summary>
		public int CountryID
		{
			get { return countryID; }
			set { countryID = value; }
		}

		/// <summary>
		/// Gets or sets the StateID value.
		/// </summary>
		public int StateID
		{
			get { return stateID; }
			set { stateID = value; }
		}

		/// <summary>
		/// Gets or sets the EmailID value.
		/// </summary>
		public string EmailID
		{
			get { return emailID; }
			set { emailID = value; }
		}

		/// <summary>
		/// Gets or sets the Phone value.
		/// </summary>
		public string Phone
		{
			get { return phone; }
			set { phone = value; }
		}

		/// <summary>
		/// Gets or sets the Mobile value.
		/// </summary>
		public string Mobile
		{
			get { return mobile; }
			set { mobile = value; }
		}

		/// <summary>
		/// Gets or sets the FaxNumber value.
		/// </summary>
		public string FaxNumber
		{
			get { return faxNumber; }
			set { faxNumber = value; }
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
		/// Gets or sets the IsCommunication value.
		/// </summary>
		public string IsCommunication
		{
			get { return isCommunication; }
			set { isCommunication = value; }
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
		/// Gets or sets the ISDCode value.
		/// </summary>
		public int ISDCode
		{
			get { return iSDCode; }
			set { iSDCode = value; }
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
		/// Gets or sets the ContactType value.
		/// </summary>
		public string ContactType
		{
			get { return contactType; }
			set { contactType = value; }
		}

		/// <summary>
		/// Gets or sets the EmpID value.
		/// </summary>
		public long EmpID
		{
			get { return empID; }
			set { empID = value; }
		}

		/// <summary>
		/// Gets or sets the SubUrban value.
		/// </summary>
		public string SubUrban
		{
			get { return subUrban; }
			set { subUrban = value; }
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
		/// Gets or sets the Address2 value.
		/// </summary>
		public string Address2
		{
			get { return address2; }
			set { address2 = value; }
		}

		/// <summary>
		/// Gets or sets the InvoiceEmail value.
		/// </summary>
		public string InvoiceEmail
		{
			get { return invoiceEmail; }
			set { invoiceEmail = value; }
		}

        ///// <summary>
        ///// Gets or sets the InvoiceEmail value.
        ///// </summary>
        //private string _invoiceEmail=String.Empty;
        //public string InvoiceEmail
        //{
        //    get { return  _invoiceEmail; }
        //    set { _invoiceEmail = value; }
        //}

		/// <summary>
		/// Gets or sets the CommunicationConfigID value.
		/// </summary>
		private long _communicationConfigID=0;
		public long CommunicationConfigID
		{
			get { return  _communicationConfigID; }
			set { _communicationConfigID = value; }
		}

		/// <summary>
		/// Gets or sets the NotificationCategory value.
		/// </summary>
		private string _notificationCategory=String.Empty;
		public string NotificationCategory
		{
			get { return  _notificationCategory; }
			set { _notificationCategory = value; }
		}

		/// <summary>
		/// Gets or sets the NotificationType value.
		/// </summary>
		private string _notificationType=String.Empty;
		public string NotificationType
		{
			get { return  _notificationType; }
			set { _notificationType = value; }
		}

		/// <summary>
		/// Gets or sets the CommunicationConfigValues value.
		/// </summary>
		private string _communicationConfigValues=String.Empty;
		public string CommunicationConfigValues
		{
			get { return  _communicationConfigValues; }
			set { _communicationConfigValues = value; }
		}

		/// <summary>
		/// Gets or sets the EmailType value.
		/// </summary>
		private string _emailType=String.Empty;
		public string EmailType
		{
			get { return  _emailType; }
			set { _emailType = value; }
		}

		/// <summary>
		/// Gets or sets the Sno value.
		/// </summary>
		private long _sno=0;
		public long Sno
		{
			get { return  _sno; }
			set { _sno = value; }
		}


		#endregion
}
}
