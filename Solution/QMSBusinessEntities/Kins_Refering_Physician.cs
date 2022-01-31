using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Kins_Refering_Physician
	{
		#region Fields

		private string physicianCode=String.Empty;
		private string physicianName=String.Empty;
		private string qualification=String.Empty;
		private string organizationName=String.Empty;
		private string salutation=String.Empty;
		private string isclient=String.Empty;
		private string gender=String.Empty;
		private string dOB=String.Empty;
		private string age=String.Empty;
		private string address=String.Empty;
		private string city=String.Empty;
		private string state=String.Empty;
		private string country=String.Empty;
		private string emailid=String.Empty;
		private string phone=String.Empty;
		private float mobile=0.0F;
		private string fax=String.Empty;
		private string referenceType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PhysicianCode value.
		/// </summary>
		public string PhysicianCode
		{
			get { return physicianCode; }
			set { physicianCode = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianName value.
		/// </summary>
		public string PhysicianName
		{
			get { return physicianName; }
			set { physicianName = value; }
		}

		/// <summary>
		/// Gets or sets the Qualification value.
		/// </summary>
		public string Qualification
		{
			get { return qualification; }
			set { qualification = value; }
		}

		/// <summary>
		/// Gets or sets the OrganizationName value.
		/// </summary>
		public string OrganizationName
		{
			get { return organizationName; }
			set { organizationName = value; }
		}

		/// <summary>
		/// Gets or sets the Salutation value.
		/// </summary>
		public string Salutation
		{
			get { return salutation; }
			set { salutation = value; }
		}

		/// <summary>
		/// Gets or sets the Isclient value.
		/// </summary>
		public string Isclient
		{
			get { return isclient; }
			set { isclient = value; }
		}

		/// <summary>
		/// Gets or sets the Gender value.
		/// </summary>
		public string Gender
		{
			get { return gender; }
			set { gender = value; }
		}

		/// <summary>
		/// Gets or sets the DOB value.
		/// </summary>
		public string DOB
		{
			get { return dOB; }
			set { dOB = value; }
		}

		/// <summary>
		/// Gets or sets the Age value.
		/// </summary>
		public string Age
		{
			get { return age; }
			set { age = value; }
		}

		/// <summary>
		/// Gets or sets the Address value.
		/// </summary>
		public string Address
		{
			get { return address; }
			set { address = value; }
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
		/// Gets or sets the State value.
		/// </summary>
		public string State
		{
			get { return state; }
			set { state = value; }
		}

		/// <summary>
		/// Gets or sets the Country value.
		/// </summary>
		public string Country
		{
			get { return country; }
			set { country = value; }
		}

		/// <summary>
		/// Gets or sets the Emailid value.
		/// </summary>
		public string Emailid
		{
			get { return emailid; }
			set { emailid = value; }
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
		public float Mobile
		{
			get { return mobile; }
			set { mobile = value; }
		}

		/// <summary>
		/// Gets or sets the Fax value.
		/// </summary>
		public string Fax
		{
			get { return fax; }
			set { fax = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceType value.
		/// </summary>
		public string ReferenceType
		{
			get { return referenceType; }
			set { referenceType = value; }
		}


		#endregion
}
}
