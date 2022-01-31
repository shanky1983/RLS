using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Customers
	{
		#region Fields

		private int customerID=0;
		private string customerName=String.Empty;
		private string contactPerson=String.Empty;
		private string address1=String.Empty;
		private string address2=String.Empty;
		private string city=String.Empty;
		private string emailID=String.Empty;
		private string phone=String.Empty;
		private string mobile=String.Empty;
		private string faxNumber=String.Empty;
		private string pANNumber=String.Empty;
		private string tINNo=String.Empty;
		private string cSTNo=String.Empty;
		private string drugLicenceNo=String.Empty;
		private string serviceTaxNo=String.Empty;
		private int customerTypeID=0;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string isDeleted=String.Empty;
		private string termsConditions=String.Empty;
		private int orgAddressID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CustomerID value.
		/// </summary>
		public int CustomerID
		{
			get { return customerID; }
			set { customerID = value; }
		}

		/// <summary>
		/// Gets or sets the CustomerName value.
		/// </summary>
		public string CustomerName
		{
			get { return customerName; }
			set { customerName = value; }
		}

		/// <summary>
		/// Gets or sets the ContactPerson value.
		/// </summary>
		public string ContactPerson
		{
			get { return contactPerson; }
			set { contactPerson = value; }
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
		/// Gets or sets the Address2 value.
		/// </summary>
		public string Address2
		{
			get { return address2; }
			set { address2 = value; }
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
		/// Gets or sets the PANNumber value.
		/// </summary>
		public string PANNumber
		{
			get { return pANNumber; }
			set { pANNumber = value; }
		}

		/// <summary>
		/// Gets or sets the TINNo value.
		/// </summary>
		public string TINNo
		{
			get { return tINNo; }
			set { tINNo = value; }
		}

		/// <summary>
		/// Gets or sets the CSTNo value.
		/// </summary>
		public string CSTNo
		{
			get { return cSTNo; }
			set { cSTNo = value; }
		}

		/// <summary>
		/// Gets or sets the DrugLicenceNo value.
		/// </summary>
		public string DrugLicenceNo
		{
			get { return drugLicenceNo; }
			set { drugLicenceNo = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceTaxNo value.
		/// </summary>
		public string ServiceTaxNo
		{
			get { return serviceTaxNo; }
			set { serviceTaxNo = value; }
		}

		/// <summary>
		/// Gets or sets the CustomerTypeID value.
		/// </summary>
		public int CustomerTypeID
		{
			get { return customerTypeID; }
			set { customerTypeID = value; }
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
		/// Gets or sets the IsDeleted value.
		/// </summary>
		public string IsDeleted
		{
			get { return isDeleted; }
			set { isDeleted = value; }
		}

		/// <summary>
		/// Gets or sets the TermsConditions value.
		/// </summary>
		public string TermsConditions
		{
			get { return termsConditions; }
			set { termsConditions = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public int OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}


		#endregion
}
}
