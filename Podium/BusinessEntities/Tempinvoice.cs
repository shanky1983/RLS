using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Tempinvoice
	{
		#region Fields

		private long invoiceid=0;
		private long orgid=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Invoiceid value.
		/// </summary>
		public long Invoiceid
		{
			get { return invoiceid; }
			set { invoiceid = value; }
		}

		/// <summary>
		/// Gets or sets the Orgid value.
		/// </summary>
		public long Orgid
		{
			get { return orgid; }
			set { orgid = value; }
		}


		#endregion
}
}
