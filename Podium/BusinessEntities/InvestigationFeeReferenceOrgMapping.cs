using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvestigationFeeReferenceOrgMapping
	{
		#region Fields

		private long investigationFeeID=0;
		private long referenceOrgID=0;
		private decimal precentageToHostingOrg=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvestigationFeeID value.
		/// </summary>
		public long InvestigationFeeID
		{
			get { return investigationFeeID; }
			set { investigationFeeID = value; }
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
		/// Gets or sets the PrecentageToHostingOrg value.
		/// </summary>
		public decimal PrecentageToHostingOrg
		{
			get { return precentageToHostingOrg; }
			set { precentageToHostingOrg = value; }
		}


		#endregion
}
}
