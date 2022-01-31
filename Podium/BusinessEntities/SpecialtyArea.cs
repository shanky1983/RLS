using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class SpecialtyArea
	{
		#region Fields

		private long specialtyAreaID=0;
		private string name=String.Empty;
		private int orgID=0;
		private int orgAddressID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SpecialtyAreaID value.
		/// </summary>
		public long SpecialtyAreaID
		{
			get { return specialtyAreaID; }
			set { specialtyAreaID = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
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
