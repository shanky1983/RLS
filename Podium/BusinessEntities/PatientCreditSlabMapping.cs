using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientCreditSlabMapping
	{
		#region Fields

		private long slabID=0;
		private decimal rangeFrom=Decimal.Zero;
		private decimal rangeTo=Decimal.Zero;
		private decimal pointsPercent=Decimal.Zero;
		private decimal pointsValue=Decimal.Zero;
		private int orgId=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string isActive=String.Empty;
		private decimal amountValue=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SlabID value.
		/// </summary>
		public long SlabID
		{
			get { return slabID; }
			set { slabID = value; }
		}

		/// <summary>
		/// Gets or sets the RangeFrom value.
		/// </summary>
		public decimal RangeFrom
		{
			get { return rangeFrom; }
			set { rangeFrom = value; }
		}

		/// <summary>
		/// Gets or sets the RangeTo value.
		/// </summary>
		public decimal RangeTo
		{
			get { return rangeTo; }
			set { rangeTo = value; }
		}

		/// <summary>
		/// Gets or sets the PointsPercent value.
		/// </summary>
		public decimal PointsPercent
		{
			get { return pointsPercent; }
			set { pointsPercent = value; }
		}

		/// <summary>
		/// Gets or sets the PointsValue value.
		/// </summary>
		public decimal PointsValue
		{
			get { return pointsValue; }
			set { pointsValue = value; }
		}

		/// <summary>
		/// Gets or sets the OrgId value.
		/// </summary>
		public int OrgId
		{
			get { return orgId; }
			set { orgId = value; }
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
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the AmountValue value.
		/// </summary>
		public decimal AmountValue
		{
			get { return amountValue; }
			set { amountValue = value; }
		}


		#endregion
}
}
