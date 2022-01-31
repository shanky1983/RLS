using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class VendorMaster
	{
		#region Fields

		private int vendorID=0;
		private string vendorName=String.Empty;
		private string status=String.Empty;
		private DateTime createdDate=DateTime.MaxValue;
		private long createdBy=0;
		private string partnerType=String.Empty;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private string vendorApiURL=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the VendorID value.
		/// </summary>
		public int VendorID
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedDate value.
		/// </summary>
		public DateTime CreatedDate
		{
			get { return createdDate; }
			set { createdDate = value; }
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
		/// Gets or sets the PartnerType value.
		/// </summary>
		public string PartnerType
		{
			get { return partnerType; }
			set { partnerType = value; }
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
		/// Gets or sets the VendorApiURL value.
		/// </summary>
		public string VendorApiURL
		{
			get { return vendorApiURL; }
			set { vendorApiURL = value; }
		}


		#endregion
}
}
