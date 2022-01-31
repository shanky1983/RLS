using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class SurgeryPackageItems
	{
		#region Fields

		private long packageID=0;
		private string packageCode=String.Empty;
		private string packageName=String.Empty;
		private decimal amount=Decimal.Zero;
		private int packageDays=0;
		private int noFreeConsBefore=0;
		private int noFreeConsAfter=0;
		private int freeConsValidity=0;
		private long detailsID=0;
		private string feetype=String.Empty;
		private long feeID=0;
		private long drugGenericID=0;
		private int specialtyID=0;
		private decimal pkgQuantity=Decimal.Zero;
		private string itemName=String.Empty;
		private long trackerID=0;
		private long packageDetailsID=0;
		private long drugID=0;
		private decimal quantity=Decimal.Zero;
		private decimal usedQuantity=Decimal.Zero;
		private string batchNumber=String.Empty;
        private DateTime expiryDate = DateTime.MaxValue;
        private DateTime orderedDate = DateTime.MaxValue;
        private DateTime fromDate = DateTime.MaxValue;
        private DateTime toDate = DateTime.MaxValue;

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
		/// Gets or sets the DetailsID value.
		/// </summary>
		public long DetailsID
		{
			get { return detailsID; }
			set { detailsID = value; }
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
		/// Gets or sets the TrackerID value.
		/// </summary>
		public long TrackerID
		{
			get { return trackerID; }
			set { trackerID = value; }
		}

		/// <summary>
		/// Gets or sets the PackageDetailsID value.
		/// </summary>
		public long PackageDetailsID
		{
			get { return packageDetailsID; }
			set { packageDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the DrugID value.
		/// </summary>
		public long DrugID
		{
			get { return drugID; }
			set { drugID = value; }
		}

		/// <summary>
		/// Gets or sets the Quantity value.
		/// </summary>
		public decimal Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}

		/// <summary>
		/// Gets or sets the UsedQuantity value.
		/// </summary>
		public decimal UsedQuantity
		{
			get { return usedQuantity; }
			set { usedQuantity = value; }
		}

		/// <summary>
		/// Gets or sets the BatchNumber value.
		/// </summary>
		public string BatchNumber
		{
			get { return batchNumber; }
			set { batchNumber = value; }
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
		/// Gets or sets the OrderedDate value.
		/// </summary>
		public DateTime OrderedDate
		{
			get { return orderedDate; }
			set { orderedDate = value; }
		}

		/// <summary>
		/// Gets or sets the FromDate value.
		/// </summary>
		public DateTime FromDate
		{
			get { return fromDate; }
			set { fromDate = value; }
		}

		/// <summary>
		/// Gets or sets the ToDate value.
		/// </summary>
		public DateTime ToDate
		{
			get { return toDate; }
			set { toDate = value; }
		}


		#endregion
}
}
