using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class DialysisDetails
	{
		#region Fields

		private long dialysisDetailsID=0;
		private long patientVisitID=0;
		private bool isFirstDialysis=false;
		private DateTime dialysisSince=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DialysisDetailsID value.
		/// </summary>
		public long DialysisDetailsID
		{
			get { return dialysisDetailsID; }
			set { dialysisDetailsID = value; }
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
		/// Gets or sets the IsFirstDialysis value.
		/// </summary>
		public bool IsFirstDialysis
		{
			get { return isFirstDialysis; }
			set { isFirstDialysis = value; }
		}

		/// <summary>
		/// Gets or sets the DialysisSince value.
		/// </summary>
		public DateTime DialysisSince
		{
			get { return dialysisSince; }
			set { dialysisSince = value; }
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
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}


		#endregion
}
}
