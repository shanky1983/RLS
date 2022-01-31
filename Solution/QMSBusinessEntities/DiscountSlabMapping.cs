using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class DiscountSlabMapping
	{
		#region Fields

		private long iD=0;
		private string discountCode=String.Empty;
		private decimal slabPercentage=Decimal.Zero;
		private decimal slabCeilingValue=Decimal.Zero;
		private int discountID=0;

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
		/// Gets or sets the DiscountCode value.
		/// </summary>
		public string DiscountCode
		{
			get { return discountCode; }
			set { discountCode = value; }
		}

		/// <summary>
		/// Gets or sets the SlabPercentage value.
		/// </summary>
		public decimal SlabPercentage
		{
			get { return slabPercentage; }
			set { slabPercentage = value; }
		}

		/// <summary>
		/// Gets or sets the SlabCeilingValue value.
		/// </summary>
		public decimal SlabCeilingValue
		{
			get { return slabCeilingValue; }
			set { slabCeilingValue = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountID value.
		/// </summary>
		public int DiscountID
		{
			get { return discountID; }
			set { discountID = value; }
		}


		#endregion
}
}
