using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CategorySlab
	{
		#region Fields

		private byte categoryid=0x00;
		private int fromrange=0;
		private int torange=0;
		private decimal payout=Decimal.Zero;
		private byte payon=0x00;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Categoryid value.
		/// </summary>
		public byte Categoryid
		{
			get { return categoryid; }
			set { categoryid = value; }
		}

		/// <summary>
		/// Gets or sets the Fromrange value.
		/// </summary>
		public int Fromrange
		{
			get { return fromrange; }
			set { fromrange = value; }
		}

		/// <summary>
		/// Gets or sets the Torange value.
		/// </summary>
		public int Torange
		{
			get { return torange; }
			set { torange = value; }
		}

		/// <summary>
		/// Gets or sets the Payout value.
		/// </summary>
		public decimal Payout
		{
			get { return payout; }
			set { payout = value; }
		}

		/// <summary>
		/// Gets or sets the Payon value.
		/// </summary>
		public byte Payon
		{
			get { return payon; }
			set { payon = value; }
		}


		#endregion
}
}
