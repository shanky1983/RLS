using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class FeeTypeMaster
	{
		#region Fields

		private int feeTypeID=0;
		private string feeType=String.Empty;
		private string feeTypeDesc=String.Empty;
		private string isBillable=String.Empty;
		private string isServiceable=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FeeTypeID value.
		/// </summary>
		public int FeeTypeID
		{
			get { return feeTypeID; }
			set { feeTypeID = value; }
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
		/// Gets or sets the FeeTypeDesc value.
		/// </summary>
		public string FeeTypeDesc
		{
			get { return feeTypeDesc; }
			set { feeTypeDesc = value; }
		}

		/// <summary>
		/// Gets or sets the IsBillable value.
		/// </summary>
		public string IsBillable
		{
			get { return isBillable; }
			set { isBillable = value; }
		}

		/// <summary>
		/// Gets or sets the IsServiceable value.
		/// </summary>
		public string IsServiceable
		{
			get { return isServiceable; }
			set { isServiceable = value; }
		}


		#endregion
}
}
