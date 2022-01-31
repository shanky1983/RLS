using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientComplication
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
		private string complicationType=String.Empty;
		private string iCDCode=String.Empty;
		private string iCDDescription=String.Empty;
		private int complaintID=0;
		private string iCDCodeStatus=String.Empty;

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
		/// Gets or sets the ComplicationType value.
		/// </summary>
		public string ComplicationType
		{
			get { return complicationType; }
			set { complicationType = value; }
		}

		/// <summary>
		/// Gets or sets the ICDCode value.
		/// </summary>
		public string ICDCode
		{
			get { return iCDCode; }
			set { iCDCode = value; }
		}

		/// <summary>
		/// Gets or sets the ICDDescription value.
		/// </summary>
		public string ICDDescription
		{
			get { return iCDDescription; }
			set { iCDDescription = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintID value.
		/// </summary>
		public int ComplaintID
		{
			get { return complaintID; }
			set { complaintID = value; }
		}

		/// <summary>
		/// Gets or sets the ICDCodeStatus value.
		/// </summary>
		public string ICDCodeStatus
		{
			get { return iCDCodeStatus; }
			set { iCDCodeStatus = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintId value.
		/// </summary>
		private int _complaintId=0;
		public int ComplaintId
		{
			get { return  _complaintId; }
			set { _complaintId = value; }
		}


		#endregion
}
}
