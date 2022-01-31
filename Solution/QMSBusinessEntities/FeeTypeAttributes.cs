using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class FeeTypeAttributes
	{
		#region Fields

		private int feeTypeAttributesID=0;
		private string code=String.Empty;
		private string desc=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FeeTypeAttributesID value.
		/// </summary>
		public int FeeTypeAttributesID
		{
			get { return feeTypeAttributesID; }
			set { feeTypeAttributesID = value; }
		}

		/// <summary>
		/// Gets or sets the Code value.
		/// </summary>
		public string Code
		{
			get { return code; }
			set { code = value; }
		}

		/// <summary>
		/// Gets or sets the Desc value.
		/// </summary>
		public string Desc
		{
			get { return desc; }
			set { desc = value; }
		}


		#endregion
}
}
