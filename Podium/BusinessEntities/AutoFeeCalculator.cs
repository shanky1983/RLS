using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class AutoFeeCalculator
	{
		#region Fields

		private long iD=0;
		private long clientID=0;
		private long feeId=0;
		private string feeType=String.Empty;
		private int autoFeeId=0;
		private string autoFeeType=String.Empty;
		private string calcType=String.Empty;
		private TimeSpan validFromTime=TimeSpan.MinValue;
		private TimeSpan validToTime=TimeSpan.MinValue;

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
		/// Gets or sets the ClientID value.
		/// </summary>
		public long ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}

		/// <summary>
		/// Gets or sets the FeeId value.
		/// </summary>
		public long FeeId
		{
			get { return feeId; }
			set { feeId = value; }
		}

		/// <summary>
		/// Gets or sets the FeeType value.
		/// </summary>
		public string FeeType
		{
			get { return feeType; }
			set { feeType = value; }
		}

		/// <summary>
		/// Gets or sets the AutoFeeId value.
		/// </summary>
		public int AutoFeeId
		{
			get { return autoFeeId; }
			set { autoFeeId = value; }
		}

		/// <summary>
		/// Gets or sets the AutoFeeType value.
		/// </summary>
		public string AutoFeeType
		{
			get { return autoFeeType; }
			set { autoFeeType = value; }
		}

		/// <summary>
		/// Gets or sets the CalcType value.
		/// </summary>
		public string CalcType
		{
			get { return calcType; }
			set { calcType = value; }
		}

		/// <summary>
		/// Gets or sets the ValidFromTime value.
		/// </summary>
		public TimeSpan ValidFromTime
		{
			get { return validFromTime; }
			set { validFromTime = value; }
		}

		/// <summary>
		/// Gets or sets the ValidToTime value.
		/// </summary>
		public TimeSpan ValidToTime
		{
			get { return validToTime; }
			set { validToTime = value; }
		}


		#endregion
}
}
