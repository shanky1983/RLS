using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class SpecialtyPartMapping
	{
		#region Fields

		private long specialtyPartMappingID=0;
		private long specialtyAreaID=0;
		private string specialtyUniquePartID=String.Empty;
		private string specialty=String.Empty;
		private int orgID=0;
		private int orgAddressID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SpecialtyPartMappingID value.
		/// </summary>
		public long SpecialtyPartMappingID
		{
			get { return specialtyPartMappingID; }
			set { specialtyPartMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the SpecialtyAreaID value.
		/// </summary>
		public long SpecialtyAreaID
		{
			get { return specialtyAreaID; }
			set { specialtyAreaID = value; }
		}

		/// <summary>
		/// Gets or sets the SpecialtyUniquePartID value.
		/// </summary>
		public string SpecialtyUniquePartID
		{
			get { return specialtyUniquePartID; }
			set { specialtyUniquePartID = value; }
		}

		/// <summary>
		/// Gets or sets the Specialty value.
		/// </summary>
		public string Specialty
		{
			get { return specialty; }
			set { specialty = value; }
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
