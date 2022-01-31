using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class OrganizationSpecialityMapping_HIST
	{
		#region Fields

		private long itemID=0;
		private string itemName=String.Empty;
		private long orgSpecialityID=0;
		private int orgID=0;
		private long rateID=0;
		private decimal oPAmount=Decimal.Zero;
		private decimal iPAmount=Decimal.Zero;
		private long rateRefID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedDate=DateTime.MaxValue;
		private long specialityID=0;
		private long histID=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ItemID value.
		/// </summary>
		public long ItemID
		{
			get { return itemID; }
			set { itemID = value; }
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
		/// Gets or sets the OrgSpecialityID value.
		/// </summary>
		public long OrgSpecialityID
		{
			get { return orgSpecialityID; }
			set { orgSpecialityID = value; }
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
		/// Gets or sets the RateID value.
		/// </summary>
		public long RateID
		{
			get { return rateID; }
			set { rateID = value; }
		}

		/// <summary>
		/// Gets or sets the OPAmount value.
		/// </summary>
		public decimal OPAmount
		{
			get { return oPAmount; }
			set { oPAmount = value; }
		}

		/// <summary>
		/// Gets or sets the IPAmount value.
		/// </summary>
		public decimal IPAmount
		{
			get { return iPAmount; }
			set { iPAmount = value; }
		}

		/// <summary>
		/// Gets or sets the RateRefID value.
		/// </summary>
		public long RateRefID
		{
			get { return rateRefID; }
			set { rateRefID = value; }
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
		/// Gets or sets the ModifiedDate value.
		/// </summary>
		public DateTime ModifiedDate
		{
			get { return modifiedDate; }
			set { modifiedDate = value; }
		}

		/// <summary>
		/// Gets or sets the SpecialityID value.
		/// </summary>
		public long SpecialityID
		{
			get { return specialityID; }
			set { specialityID = value; }
		}

		/// <summary>
		/// Gets or sets the HistID value.
		/// </summary>
		public long HistID
		{
			get { return histID; }
			set { histID = value; }
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
