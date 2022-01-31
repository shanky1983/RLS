using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class FeeShareGroupValueDetails
	{
		#region Fields

		private long valueID=0;
		private long groupDefinationID=0;
		private long feeTypeAttributesID=0;
		private decimal valu=Decimal.Zero;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ValueID value.
		/// </summary>
		public long ValueID
		{
			get { return valueID; }
			set { valueID = value; }
		}

		/// <summary>
		/// Gets or sets the GroupDefinationID value.
		/// </summary>
		public long GroupDefinationID
		{
			get { return groupDefinationID; }
			set { groupDefinationID = value; }
		}

		/// <summary>
		/// Gets or sets the FeeTypeAttributesID value.
		/// </summary>
		public long FeeTypeAttributesID
		{
			get { return feeTypeAttributesID; }
			set { feeTypeAttributesID = value; }
		}

		/// <summary>
		/// Gets or sets the Valu value.
		/// </summary>
		public decimal Value
		{
			get { return valu; }
			set { valu = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
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


		#endregion
}
}
