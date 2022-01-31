using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class SurgeryPackageMaster
	{
		#region Fields

		private long packageID=0;
		private string packageCode=String.Empty;
		private string packageName=String.Empty;
		private decimal amount=Decimal.Zero;
		private int orgID=0;
		private int orgAddID=0;
		private int packageDays=0;
		private int noFreeConsBefore=0;
		private int noFreeConsAfter=0;
		private int freeConsValidity=0;
		private string activeYN=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long rateID=0;
		private long surgeryPackageID=0;
		private string serviceCode=String.Empty;
		private long rateRefID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PackageID value.
		/// </summary>
		public long PackageID
		{
			get { return packageID; }
			set { packageID = value; }
		}

		/// <summary>
		/// Gets or sets the PackageCode value.
		/// </summary>
		public string PackageCode
		{
			get { return packageCode; }
			set { packageCode = value; }
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
		/// Gets or sets the Amount value.
		/// </summary>
		public decimal Amount
		{
			get { return amount; }
			set { amount = value; }
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
		/// Gets or sets the OrgAddID value.
		/// </summary>
		public int OrgAddID
		{
			get { return orgAddID; }
			set { orgAddID = value; }
		}

		/// <summary>
		/// Gets or sets the PackageDays value.
		/// </summary>
		public int PackageDays
		{
			get { return packageDays; }
			set { packageDays = value; }
		}

		/// <summary>
		/// Gets or sets the NoFreeConsBefore value.
		/// </summary>
		public int NoFreeConsBefore
		{
			get { return noFreeConsBefore; }
			set { noFreeConsBefore = value; }
		}

		/// <summary>
		/// Gets or sets the NoFreeConsAfter value.
		/// </summary>
		public int NoFreeConsAfter
		{
			get { return noFreeConsAfter; }
			set { noFreeConsAfter = value; }
		}

		/// <summary>
		/// Gets or sets the FreeConsValidity value.
		/// </summary>
		public int FreeConsValidity
		{
			get { return freeConsValidity; }
			set { freeConsValidity = value; }
		}

		/// <summary>
		/// Gets or sets the ActiveYN value.
		/// </summary>
		public string ActiveYN
		{
			get { return activeYN; }
			set { activeYN = value; }
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
		/// Gets or sets the RateID value.
		/// </summary>
		public long RateID
		{
			get { return rateID; }
			set { rateID = value; }
		}

		/// <summary>
		/// Gets or sets the SurgeryPackageID value.
		/// </summary>
		public long SurgeryPackageID
		{
			get { return surgeryPackageID; }
			set { surgeryPackageID = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceCode value.
		/// </summary>
		public string ServiceCode
		{
			get { return serviceCode; }
			set { serviceCode = value; }
		}

		/// <summary>
		/// Gets or sets the RateRefID value.
		/// </summary>
		public long RateRefID
		{
			get { return rateRefID; }
			set { rateRefID = value; }
		}


		#endregion
}
}
