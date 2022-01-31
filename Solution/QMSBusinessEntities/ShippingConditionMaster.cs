using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ShippingConditionMaster
	{
		#region Fields

		private int shippingConditionID=0;
		private string conditionDesc=String.Empty;
		private string langCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ShippingConditionID value.
		/// </summary>
		public int ShippingConditionID
		{
			get { return shippingConditionID; }
			set { shippingConditionID = value; }
		}

		/// <summary>
		/// Gets or sets the ConditionDesc value.
		/// </summary>
		public string ConditionDesc
		{
			get { return conditionDesc; }
			set { conditionDesc = value; }
		}

		/// <summary>
		/// Gets or sets the LangCode value.
		/// </summary>
		public string LangCode
		{
			get { return langCode; }
			set { langCode = value; }
		}


		#endregion
}
}
