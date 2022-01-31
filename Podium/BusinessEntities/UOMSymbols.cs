using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class UOMSymbols
	{
		#region Fields

		private long uOMID=0;
		private string uOMCode=String.Empty;
		private string uOMDescription=String.Empty;
		private long orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the UOMID value.
		/// </summary>
		public long UOMID
		{
			get { return uOMID; }
			set { uOMID = value; }
		}

		/// <summary>
		/// Gets or sets the UOMCode value.
		/// </summary>
		public string UOMCode
		{
			get { return uOMCode; }
			set { uOMCode = value; }
		}

		/// <summary>
		/// Gets or sets the UOMDescription value.
		/// </summary>
		public string UOMDescription
		{
			get { return uOMDescription; }
			set { uOMDescription = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}


		#endregion
}
}
