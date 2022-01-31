using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Suppliers
	{
		#region Fields

		private int supplierID=0;
		private string supplierName=String.Empty;
		private string contactPerson=String.Empty;
		private string address1=String.Empty;
		private string address2=String.Empty;
		private string city=String.Empty;
		private string emailID=String.Empty;
		private string phone=String.Empty;
		private string mobile=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgAddressID=0;
		private string tinNo=String.Empty;
		private string faxNumber=String.Empty;
		private long parentSupplierID=0;
		private string isDeleted=String.Empty;
		private string termsconditions=String.Empty;
		private string cstNo=String.Empty;
		private string drugLicenceNo=String.Empty;
		private string serviceTaxNo=String.Empty;
		private string panNo=String.Empty;
		private string drugLicenceNo1=String.Empty;
		private string drugLicenceNo2=String.Empty;
		private string supplierCode=String.Empty;
		private string pIN=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SupplierID value.
		/// </summary>
		public int SupplierID
		{
			get { return supplierID; }
			set { supplierID = value; }
		}

		/// <summary>
		/// Gets or sets the SupplierName value.
		/// </summary>
		public string SupplierName
		{
			get { return supplierName; }
			set { supplierName = value; }
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
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public int OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the TinNo value.
		/// </summary>
		public string TinNo
		{
			get { return tinNo; }
			set { tinNo = value; }
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
		/// Gets or sets the ParentSupplierID value.
		/// </summary>
		public long ParentSupplierID
		{
			get { return parentSupplierID; }
			set { parentSupplierID = value; }
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
		/// Gets or sets the Termsconditions value.
		/// </summary>
		public string Termsconditions
		{
			get { return termsconditions; }
			set { termsconditions = value; }
		}

		/// <summary>
		/// Gets or sets the CstNo value.
		/// </summary>
		public string CstNo
		{
			get { return cstNo; }
			set { cstNo = value; }
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
		/// Gets or sets the PanNo value.
		/// </summary>
		public string PanNo
		{
			get { return panNo; }
			set { panNo = value; }
		}

		/// <summary>
		/// Gets or sets the DrugLicenceNo1 value.
		/// </summary>
		public string DrugLicenceNo1
		{
			get { return drugLicenceNo1; }
			set { drugLicenceNo1 = value; }
		}

		/// <summary>
		/// Gets or sets the DrugLicenceNo2 value.
		/// </summary>
		public string DrugLicenceNo2
		{
			get { return drugLicenceNo2; }
			set { drugLicenceNo2 = value; }
		}

		/// <summary>
		/// Gets or sets the SupplierCode value.
		/// </summary>
		public string SupplierCode
		{
			get { return supplierCode; }
			set { supplierCode = value; }
		}

		/// <summary>
		/// Gets or sets the PIN value.
		/// </summary>
		public string PIN
		{
			get { return pIN; }
			set { pIN = value; }
		}


		#endregion
}
}
