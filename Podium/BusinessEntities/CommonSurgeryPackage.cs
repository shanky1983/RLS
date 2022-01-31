using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CommonSurgeryPackage
	{
		#region Fields

		private long surgeryPackageID=0;
		private string packageName=String.Empty;
		private int orgID=0;
		private int orgAddressId=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string displayText=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SurgeryPackageID value.
		/// </summary>
		public long SurgeryPackageID
		{
			get { return surgeryPackageID; }
			set { surgeryPackageID = value; }
		}

		/// <summary>
		/// Gets or sets the PackageName value.
		/// </summary>
		public string PackageName
		{
			get { return packageName; }
			set { packageName = value; }
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
		/// Gets or sets the OrgAddressId value.
		/// </summary>
		public int OrgAddressId
		{
			get { return orgAddressId; }
			set { orgAddressId = value; }
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
		/// Gets or sets the DisplayText value.
		/// </summary>
		public string DisplayText
		{
			get { return displayText; }
			set { displayText = value; }
		}


		#endregion
}
}
