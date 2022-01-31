using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ICPaymentBlockFinalbill
	{
		#region Fields

		private long finalbillid=0;
		private string remarks=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Finalbillid value.
		/// </summary>
		public long Finalbillid
		{
			get { return finalbillid; }
			set { finalbillid = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
		}


		#endregion
}
}
