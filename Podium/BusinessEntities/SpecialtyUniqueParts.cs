using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class SpecialtyUniqueParts
	{
		#region Fields

		private long specialtyUniquePartID=0;
		private string name=String.Empty;
		private int orgID=0;
		private int orgAddressID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SpecialtyUniquePartID value.
		/// </summary>
		public long SpecialtyUniquePartID
		{
			get { return specialtyUniquePartID; }
			set { specialtyUniquePartID = value; }
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

		/// <summary>
		/// Gets or sets the SpecialtyAreaName value.
		/// </summary>
		private string _specialtyAreaName=String.Empty;
		public string SpecialtyAreaName
		{
			get { return  _specialtyAreaName; }
			set { _specialtyAreaName = value; }
		}


		#endregion
}
}
