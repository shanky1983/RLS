using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientPastComplication
	{
		#region Fields

		private int complicationID=0;
		private string complicationName=String.Empty;
		private long patientVisitID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long patientID=0;
		private string aNCStatus=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ComplicationID value.
		/// </summary>
		public int ComplicationID
		{
			get { return complicationID; }
			set { complicationID = value; }
		}

		/// <summary>
		/// Gets or sets the ComplicationName value.
		/// </summary>
		public string ComplicationName
		{
			get { return complicationName; }
			set { complicationName = value; }
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

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
		}

		/// <summary>
		/// Gets or sets the ANCStatus value.
		/// </summary>
		public string ANCStatus
		{
			get { return aNCStatus; }
			set { aNCStatus = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintId value.
		/// </summary>
		int _complaintid;
		public int ComplaintId
		{
			get { return _complaintid; }
			set { _complaintid = value; }
		}


		#endregion
}
}
