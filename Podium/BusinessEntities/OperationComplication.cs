using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class OperationComplication
	{
		#region Fields

		private long operationComplicationID=0;
		private long operationID=0;
		private long patientVisitID=0;
		private int orgID=0;
		private string complicationName=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string iCDCode=String.Empty;
		private string iCDDescription=String.Empty;
		private int complaintID=0;
		private string iCDCodeStatus=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OperationComplicationID value.
		/// </summary>
		public long OperationComplicationID
		{
			get { return operationComplicationID; }
			set { operationComplicationID = value; }
		}

		/// <summary>
		/// Gets or sets the OperationID value.
		/// </summary>
		public long OperationID
		{
			get { return operationID; }
			set { operationID = value; }
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
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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


		#endregion
}
}
