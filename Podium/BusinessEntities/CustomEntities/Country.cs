using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Country
	{
		#region Fields

		private string countryName=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string nationality=String.Empty;
		private long nationalityID=0;
		private int sNo=0;
        private long countryID = 0;
		private string isDefault=String.Empty;
		private int iSDCode=0;
		private long countryCode=0;
		private int phoneNo_Length=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CountryName value.
		/// </summary>
		public string CountryName
		{
			get { return countryName; }
			set { countryName = value; }
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
		/// Gets or sets the Nationality value.
		/// </summary>
		public string Nationality
		{
			get { return nationality; }
			set { nationality = value; }
		}

		/// <summary>
		/// Gets or sets the NationalityID value.
		/// </summary>
		public long NationalityID
		{
			get { return nationalityID; }
			set { nationalityID = value; }
		}

		/// <summary>
		/// Gets or sets the SNo value.
		/// </summary>
		public int SNo
		{
			get { return sNo; }
			set { sNo = value; }
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
		/// Gets or sets the IsDefault value.
		/// </summary>
		public string IsDefault
		{
			get { return isDefault; }
			set { isDefault = value; }
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
		/// Gets or sets the CountryCode value.
		/// </summary>
		public long CountryCode
		{
			get { return countryCode; }
			set { countryCode = value; }
		}

		/// <summary>
		/// Gets or sets the PhoneNo_Length value.
		/// </summary>
		public int PhoneNo_Length
		{
			get { return phoneNo_Length; }
			set { phoneNo_Length = value; }
		}


		#endregion
}
}
