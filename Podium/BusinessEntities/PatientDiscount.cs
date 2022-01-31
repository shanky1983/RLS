using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientDiscount
	{
		#region Fields

		private long patientDiscountID=0;
		private long finalBillID=0;
		private long discountID=0;
		private string discountCode=String.Empty;
		private string discountName=String.Empty;
		private string discountType=String.Empty;
		private decimal discountCeilingValue=Decimal.Zero;
		private decimal userDiscountValue=Decimal.Zero;
		private decimal slabCeilingValue=Decimal.Zero;
		private decimal slabPercentage=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientDiscountID value.
		/// </summary>
		public long PatientDiscountID
		{
			get { return patientDiscountID; }
			set { patientDiscountID = value; }
		}

		/// <summary>
		/// Gets or sets the FinalBillID value.
		/// </summary>
		public long FinalBillID
		{
			get { return finalBillID; }
			set { finalBillID = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountID value.
		/// </summary>
		public long DiscountID
		{
			get { return discountID; }
			set { discountID = value; }
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
		/// Gets or sets the DiscountName value.
		/// </summary>
		public string DiscountName
		{
			get { return discountName; }
			set { discountName = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountType value.
		/// </summary>
		public string DiscountType
		{
			get { return discountType; }
			set { discountType = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountCeilingValue value.
		/// </summary>
		public decimal DiscountCeilingValue
		{
			get { return discountCeilingValue; }
			set { discountCeilingValue = value; }
		}

		/// <summary>
		/// Gets or sets the UserDiscountValue value.
		/// </summary>
		public decimal UserDiscountValue
		{
			get { return userDiscountValue; }
			set { userDiscountValue = value; }
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
		/// Gets or sets the SlabPercentage value.
		/// </summary>
		public decimal SlabPercentage
		{
			get { return slabPercentage; }
			set { slabPercentage = value; }
		}


		#endregion
}
}
