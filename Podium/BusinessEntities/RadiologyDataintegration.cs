using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class RadiologyDataintegration
	{
		#region Fields

		private long iD=0;
		private long patientVisitID=0;
		private long orgID=0;
		private string accessionNumber=String.Empty;
		private string isProcessed=String.Empty;
		private string errorMessage=String.Empty;
		private DateTime createdAT=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		public long PatientVisitID
		{
			get { return patientVisitID; }
			set { patientVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the AccessionNumber value.
		/// </summary>
		public string AccessionNumber
		{
			get { return accessionNumber; }
			set { accessionNumber = value; }
		}

		/// <summary>
		/// Gets or sets the IsProcessed value.
		/// </summary>
		public string IsProcessed
		{
			get { return isProcessed; }
			set { isProcessed = value; }
		}

		/// <summary>
		/// Gets or sets the ErrorMessage value.
		/// </summary>
		public string ErrorMessage
		{
			get { return errorMessage; }
			set { errorMessage = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAT value.
		/// </summary>
		public DateTime CreatedAT
		{
			get { return createdAT; }
			set { createdAT = value; }
		}


		#endregion
}
}
