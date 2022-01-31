using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class SurgeryPackageFeeTypeRateMaster
	{
		#region Fields

		private long feeTypeRateMasterID=0;
		private long packageID=0;
		private string feetype=String.Empty;
		private long rateID=0;
		private int specialtyID=0;
		private decimal maxAmountAllowed=Decimal.Zero;
		private DateTime createdby=DateTime.MaxValue;
		private DateTime createdAt=DateTime.MaxValue;
		private DateTime modifiedBy=DateTime.MaxValue;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FeeTypeRateMasterID value.
		/// </summary>
		public long FeeTypeRateMasterID
		{
			get { return feeTypeRateMasterID; }
			set { feeTypeRateMasterID = value; }
		}

		/// <summary>
		/// Gets or sets the PackageID value.
		/// </summary>
		public long PackageID
		{
			get { return packageID; }
			set { packageID = value; }
		}

		/// <summary>
		/// Gets or sets the Feetype value.
		/// </summary>
		public string Feetype
		{
			get { return feetype; }
			set { feetype = value; }
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
		/// Gets or sets the SpecialtyID value.
		/// </summary>
		public int SpecialtyID
		{
			get { return specialtyID; }
			set { specialtyID = value; }
		}

		/// <summary>
		/// Gets or sets the MaxAmountAllowed value.
		/// </summary>
		public decimal MaxAmountAllowed
		{
			get { return maxAmountAllowed; }
			set { maxAmountAllowed = value; }
		}

		/// <summary>
		/// Gets or sets the Createdby value.
		/// </summary>
		public DateTime Createdby
		{
			get { return createdby; }
			set { createdby = value; }
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
		public DateTime ModifiedBy
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


		#endregion
}
}
