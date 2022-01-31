using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class VendorOrgAddressMapping
	{
		#region Fields

		private long mappingID=0;
		private long vendorID=0;
		private long attuneOrgAddressID=0;
		private long vendorOrgAddressID=0;
		private bool status=false;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long loginID=0;
		private int roleID=0;
		private long locationID=0;
		private int invLocationID=0;
		private Guid attGuId=Guid.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MappingID value.
		/// </summary>
		public long MappingID
		{
			get { return mappingID; }
			set { mappingID = value; }
		}

		/// <summary>
		/// Gets or sets the VendorID value.
		/// </summary>
		public long VendorID
		{
			get { return vendorID; }
			set { vendorID = value; }
		}

		/// <summary>
		/// Gets or sets the AttuneOrgAddressID value.
		/// </summary>
		public long AttuneOrgAddressID
		{
			get { return attuneOrgAddressID; }
			set { attuneOrgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the VendorOrgAddressID value.
		/// </summary>
		public long VendorOrgAddressID
		{
			get { return vendorOrgAddressID; }
			set { vendorOrgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public bool Status
		{
			get { return status; }
			set { status = value; }
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
		/// Gets or sets the LoginID value.
		/// </summary>
		public long LoginID
		{
			get { return loginID; }
			set { loginID = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		public int RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		public long LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the InvLocationID value.
		/// </summary>
		public int InvLocationID
		{
			get { return invLocationID; }
			set { invLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the AttGuId value.
		/// </summary>
		public Guid AttGuId
		{
			get { return attGuId; }
			set { attGuId = value; }
		}


		#endregion
}
}
