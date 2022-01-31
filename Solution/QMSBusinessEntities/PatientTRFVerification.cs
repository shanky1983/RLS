using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientTRFVerification
	{
		#region Fields

		private int iD=0;
		private long patientVisitID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private bool isDetailsEdited=false;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}

		/// <summary>
		/// Gets or sets the IsDetailsEdited value.
		/// </summary>
		public bool IsDetailsEdited
		{
			get { return isDetailsEdited; }
			set { isDetailsEdited = value; }
		}


		#endregion
}
}
