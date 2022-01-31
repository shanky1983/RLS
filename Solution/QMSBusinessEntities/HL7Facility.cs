using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class HL7Facility
	{
		#region Fields

		private int id=0;
		private string facilityName=String.Empty;
		private string facilityCode=String.Empty;
		private int orgId=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the FacilityName value.
		/// </summary>
		public string FacilityName
		{
			get { return facilityName; }
			set { facilityName = value; }
		}

		/// <summary>
		/// Gets or sets the FacilityCode value.
		/// </summary>
		public string FacilityCode
		{
			get { return facilityCode; }
			set { facilityCode = value; }
		}

		/// <summary>
		/// Gets or sets the OrgId value.
		/// </summary>
		public int OrgId
		{
			get { return orgId; }
			set { orgId = value; }
		}


		#endregion
}
}
