using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InventoryTaxDetails
	{
		#region Fields

		private long iD=0;
		private string referenceType=String.Empty;
		private long referenceID=0;
		private decimal packingSale=Decimal.Zero;
		private decimal exciseDuty=Decimal.Zero;
		private decimal eduCess=Decimal.Zero;
		private decimal secCess=Decimal.Zero;
		private decimal cST=Decimal.Zero;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private decimal total=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceType value.
		/// </summary>
		public string ReferenceType
		{
			get { return referenceType; }
			set { referenceType = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceID value.
		/// </summary>
		public long ReferenceID
		{
			get { return referenceID; }
			set { referenceID = value; }
		}

		/// <summary>
		/// Gets or sets the PackingSale value.
		/// </summary>
		public decimal PackingSale
		{
			get { return packingSale; }
			set { packingSale = value; }
		}

		/// <summary>
		/// Gets or sets the ExciseDuty value.
		/// </summary>
		public decimal ExciseDuty
		{
			get { return exciseDuty; }
			set { exciseDuty = value; }
		}

		/// <summary>
		/// Gets or sets the EduCess value.
		/// </summary>
		public decimal EduCess
		{
			get { return eduCess; }
			set { eduCess = value; }
		}

		/// <summary>
		/// Gets or sets the SecCess value.
		/// </summary>
		public decimal SecCess
		{
			get { return secCess; }
			set { secCess = value; }
		}

		/// <summary>
		/// Gets or sets the CST value.
		/// </summary>
		public decimal CST
		{
			get { return cST; }
			set { cST = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
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
		/// Gets or sets the Total value.
		/// </summary>
		public decimal Total
		{
			get { return total; }
			set { total = value; }
		}


		#endregion
}
}
