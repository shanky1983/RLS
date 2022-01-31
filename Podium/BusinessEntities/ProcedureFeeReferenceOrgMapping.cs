using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ProcedureFeeReferenceOrgMapping
	{
		#region Fields

		private long procedureFfeeID=0;
		private long referenceOrgID=0;
		private decimal percentageToHostingOrg=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ProcedureFfeeID value.
		/// </summary>
		public long ProcedureFfeeID
		{
			get { return procedureFfeeID; }
			set { procedureFfeeID = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceOrgID value.
		/// </summary>
		public long ReferenceOrgID
		{
			get { return referenceOrgID; }
			set { referenceOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the PercentageToHostingOrg value.
		/// </summary>
		public decimal PercentageToHostingOrg
		{
			get { return percentageToHostingOrg; }
			set { percentageToHostingOrg = value; }
		}


		#endregion
}
}
