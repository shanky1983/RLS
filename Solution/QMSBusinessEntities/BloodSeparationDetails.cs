using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class BloodSeparationDetails
	{
		#region Fields

		private int bloodSeparationDetailsID=0;
		private string parentbagNumber=String.Empty;
		private string bagNumber=String.Empty;
		private long productID=0;
		private string productName=String.Empty;
		private string volume=String.Empty;
		private DateTime expiryDate=DateTime.MaxValue;
		private long orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string bloodGroupName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BloodSeparationDetailsID value.
		/// </summary>
		public int BloodSeparationDetailsID
		{
			get { return bloodSeparationDetailsID; }
			set { bloodSeparationDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the ParentbagNumber value.
		/// </summary>
		public string ParentbagNumber
		{
			get { return parentbagNumber; }
			set { parentbagNumber = value; }
		}

		/// <summary>
		/// Gets or sets the BagNumber value.
		/// </summary>
		public string BagNumber
		{
			get { return bagNumber; }
			set { bagNumber = value; }
		}

		/// <summary>
		/// Gets or sets the ProductID value.
		/// </summary>
		public long ProductID
		{
			get { return productID; }
			set { productID = value; }
		}

		/// <summary>
		/// Gets or sets the ProductName value.
		/// </summary>
		public string ProductName
		{
			get { return productName; }
			set { productName = value; }
		}

		/// <summary>
		/// Gets or sets the Volume value.
		/// </summary>
		public string Volume
		{
			get { return volume; }
			set { volume = value; }
		}

		/// <summary>
		/// Gets or sets the ExpiryDate value.
		/// </summary>
		public DateTime ExpiryDate
		{
			get { return expiryDate; }
			set { expiryDate = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
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
		/// Gets or sets the BloodGroupName value.
		/// </summary>
		public string BloodGroupName
		{
			get { return bloodGroupName; }
			set { bloodGroupName = value; }
		}


		#endregion
}
}
