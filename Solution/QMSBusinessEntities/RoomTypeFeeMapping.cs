using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class RoomTypeFeeMapping
	{
		#region Fields

		private long roomTypeFeeMappingID=0;
		private int roomTypeID=0;
		private long feeID=0;
		private decimal amount=Decimal.Zero;
		private string iSVariable=String.Empty;
		private string iSOptional=String.Empty;
		private int rateID=0;
		private string feeLogic=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RoomTypeFeeMappingID value.
		/// </summary>
		public long RoomTypeFeeMappingID
		{
			get { return roomTypeFeeMappingID; }
			set { roomTypeFeeMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the RoomTypeID value.
		/// </summary>
		public int RoomTypeID
		{
			get { return roomTypeID; }
			set { roomTypeID = value; }
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
		/// Gets or sets the Amount value.
		/// </summary>
		public decimal Amount
		{
			get { return amount; }
			set { amount = value; }
		}

		/// <summary>
		/// Gets or sets the ISVariable value.
		/// </summary>
		public string ISVariable
		{
			get { return iSVariable; }
			set { iSVariable = value; }
		}

		/// <summary>
		/// Gets or sets the ISOptional value.
		/// </summary>
		public string ISOptional
		{
			get { return iSOptional; }
			set { iSOptional = value; }
		}

		/// <summary>
		/// Gets or sets the RateID value.
		/// </summary>
		public int RateID
		{
			get { return rateID; }
			set { rateID = value; }
		}

		/// <summary>
		/// Gets or sets the FeeLogic value.
		/// </summary>
		public string FeeLogic
		{
			get { return feeLogic; }
			set { feeLogic = value; }
		}


		#endregion
}
}
