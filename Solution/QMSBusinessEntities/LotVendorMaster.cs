using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class LotVendorMaster
	{
		#region Fields

		private long vendorID=0;
		private string vendorName=String.Empty;
		private string vendorcode=String.Empty;
		private string panNo=String.Empty;
		private string sPOCName=String.Empty;
		private string emailID=String.Empty;
		private string mobileno=String.Empty;
		private string landlineno=String.Empty;
		private string faxNo=String.Empty;
		private int countryID=0;
		private int stateID=0;
		private int cityID=0;
		private string postalCode=String.Empty;
		private string tempAddress=String.Empty;
		private string permenentAddress=String.Empty;
		private string termsandconditions=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdby=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedby=0;
		private string isActive=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the VendorID value.
		/// </summary>
		public long VendorID
		{
			get { return vendorID; }
			set { vendorID = value; }
		}

		/// <summary>
		/// Gets or sets the VendorName value.
		/// </summary>
		public string VendorName
		{
			get { return vendorName; }
			set { vendorName = value; }
		}

		/// <summary>
		/// Gets or sets the Vendorcode value.
		/// </summary>
		public string Vendorcode
		{
			get { return vendorcode; }
			set { vendorcode = value; }
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
		/// Gets or sets the SPOCName value.
		/// </summary>
		public string SPOCName
		{
			get { return sPOCName; }
			set { sPOCName = value; }
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
		/// Gets or sets the Mobileno value.
		/// </summary>
		public string Mobileno
		{
			get { return mobileno; }
			set { mobileno = value; }
		}

		/// <summary>
		/// Gets or sets the Landlineno value.
		/// </summary>
		public string Landlineno
		{
			get { return landlineno; }
			set { landlineno = value; }
		}

		/// <summary>
		/// Gets or sets the FaxNo value.
		/// </summary>
		public string FaxNo
		{
			get { return faxNo; }
			set { faxNo = value; }
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
		/// Gets or sets the CityID value.
		/// </summary>
		public int CityID
		{
			get { return cityID; }
			set { cityID = value; }
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
		/// Gets or sets the TempAddress value.
		/// </summary>
		public string TempAddress
		{
			get { return tempAddress; }
			set { tempAddress = value; }
		}

		/// <summary>
		/// Gets or sets the PermenentAddress value.
		/// </summary>
		public string PermenentAddress
		{
			get { return permenentAddress; }
			set { permenentAddress = value; }
		}

		/// <summary>
		/// Gets or sets the Termsandconditions value.
		/// </summary>
		public string Termsandconditions
		{
			get { return termsandconditions; }
			set { termsandconditions = value; }
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
		/// Gets or sets the Createdby value.
		/// </summary>
		public long Createdby
		{
			get { return createdby; }
			set { createdby = value; }
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
		/// Gets or sets the Modifiedby value.
		/// </summary>
		public long Modifiedby
		{
			get { return modifiedby; }
			set { modifiedby = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}


		#endregion
}
}
