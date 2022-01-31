using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ModeOfDelivery
	{
		#region Fields

		private int modeOfDeliveryId=0;
		private string modeOfDeliveryDesc=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ModeOfDeliveryId value.
		/// </summary>
		public int ModeOfDeliveryId
		{
			get { return modeOfDeliveryId; }
			set { modeOfDeliveryId = value; }
		}

		/// <summary>
		/// Gets or sets the ModeOfDeliveryDesc value.
		/// </summary>
		public string ModeOfDeliveryDesc
		{
			get { return modeOfDeliveryDesc; }
			set { modeOfDeliveryDesc = value; }
		}


		#endregion
}
}
