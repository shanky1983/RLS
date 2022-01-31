using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ComplaintVaccination
	{
		#region Fields

		private int complaintID=0;
		private int vaccinationID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ComplaintID value.
		/// </summary>
		public int ComplaintID
		{
			get { return complaintID; }
			set { complaintID = value; }
		}

		/// <summary>
		/// Gets or sets the VaccinationID value.
		/// </summary>
		public int VaccinationID
		{
			get { return vaccinationID; }
			set { vaccinationID = value; }
		}


		#endregion
}
}
