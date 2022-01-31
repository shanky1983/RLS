using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class SurgeryPackageDetails
	{
		#region Fields

		private long detailsID=0;
		private long packageID=0;
		private string feetype=String.Empty;
		private long feeID=0;
		private long drugGenericID=0;
		private int specialtyID=0;
		private decimal pkgQuantity=Decimal.Zero;
		private string itemName=String.Empty;
		private string activeYN=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private decimal amount=Decimal.Zero;
		private long rateID=0;
		private string isReimbursable=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DetailsID value.
		/// </summary>
		public long DetailsID
		{
			get { return detailsID; }
			set { detailsID = value; }
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
		/// Gets or sets the FeeID value.
		/// </summary>
		public long FeeID
		{
			get { return feeID; }
			set { feeID = value; }
		}

		/// <summary>
		/// Gets or sets the DrugGenericID value.
		/// </summary>
		public long DrugGenericID
		{
			get { return drugGenericID; }
			set { drugGenericID = value; }
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
		/// Gets or sets the PkgQuantity value.
		/// </summary>
		public decimal PkgQuantity
		{
			get { return pkgQuantity; }
			set { pkgQuantity = value; }
		}

		/// <summary>
		/// Gets or sets the ItemName value.
		/// </summary>
		public string ItemName
		{
			get { return itemName; }
			set { itemName = value; }
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
		/// Gets or sets the Amount value.
		/// </summary>
		public decimal Amount
		{
			get { return amount; }
			set { amount = value; }
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
		/// Gets or sets the IsReimbursable value.
		/// </summary>
		public string IsReimbursable
		{
			get { return isReimbursable; }
			set { isReimbursable = value; }
		}


		#endregion
}
}
