using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class HL7Facility
	{
		#region Fields

		private int id=0;
		private string facilityName=String.Empty;
		private string facilityCode=String.Empty;
		private int orgId=0;
		private string receiving_Application=String.Empty;
		private string isDefault=String.Empty;
		private string receiving_Facility=String.Empty;

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

		/// <summary>
		/// Gets or sets the Receiving_Application value.
		/// </summary>
		public string Receiving_Application
		{
			get { return receiving_Application; }
			set { receiving_Application = value; }
		}

		/// <summary>
		/// Gets or sets the IsDefault value.
		/// </summary>
		public string IsDefault
		{
			get { return isDefault; }
			set { isDefault = value; }
		}

		/// <summary>
		/// Gets or sets the Receiving_Facility value.
		/// </summary>
		public string Receiving_Facility
		{
			get { return receiving_Facility; }
			set { receiving_Facility = value; }
		}


		#endregion
}
}
