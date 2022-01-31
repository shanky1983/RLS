using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ShippingAddress
	{
		#region Fields

		private long shippingAddressID=0;
		private string add1=String.Empty;
		private string add2=String.Empty;
		private string add3=String.Empty;
		private string postalCode=String.Empty;
		private short countryID=0;
		private string city=String.Empty;
		private short stateID=0;
		private string mobileNumber=String.Empty;
		private string landLineNumber=String.Empty;
		private DateTime startDTTM=DateTime.MaxValue;
		private DateTime endDTTM=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ShippingAddressID value.
		/// </summary>
		public long ShippingAddressID
		{
			get { return shippingAddressID; }
			set { shippingAddressID = value; }
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
		/// Gets or sets the StateName value.
		/// </summary>
		private string _stateName=String.Empty;
		public string StateName
		{
			get { return  _stateName; }
			set { _stateName = value; }
		}

		/// <summary>
		/// Gets or sets the CountryName value.
		/// </summary>
		private string _countryName=String.Empty;
		public string CountryName
		{
			get { return  _countryName; }
			set { _countryName = value; }
		}


		#endregion
}
}
