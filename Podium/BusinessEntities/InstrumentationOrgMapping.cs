using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InstrumentationOrgMapping
	{
		#region Fields

		private long instOrgMappingID=0;
		private long instrumentationID=0;
		private int orgID=0;
		private int orgAddressID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InstOrgMappingID value.
		/// </summary>
		public long InstOrgMappingID
		{
			get { return instOrgMappingID; }
			set { instOrgMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the InstrumentationID value.
		/// </summary>
		public long InstrumentationID
		{
			get { return instrumentationID; }
			set { instrumentationID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public int OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}


		#endregion
}
}
