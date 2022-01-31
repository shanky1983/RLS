using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvestigationStatusHistory
	{
		#region Fields

		private long patientVisitID=0;
		private long investigationID=0;
		private string investigationName=String.Empty;
		private string type=String.Empty;
		private long modifiedBy=0;
		private DateTime modifiedat=DateTime.MaxValue;
		private string uID=String.Empty;
		private int orgID=0;
		private string orginalStatus=String.Empty;
		private string alteredStatus=String.Empty;
		private long approvedBy=0;
		private string reason=String.Empty;
		private int histid=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		public long PatientVisitID
		{
			get { return patientVisitID; }
			set { patientVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationName value.
		/// </summary>
		public string InvestigationName
		{
			get { return investigationName; }
			set { investigationName = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
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
		/// Gets or sets the Modifiedat value.
		/// </summary>
		public DateTime Modifiedat
		{
			get { return modifiedat; }
			set { modifiedat = value; }
		}

		/// <summary>
		/// Gets or sets the UID value.
		/// </summary>
		public string UID
		{
			get { return uID; }
			set { uID = value; }
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
		/// Gets or sets the OrginalStatus value.
		/// </summary>
		public string OrginalStatus
		{
			get { return orginalStatus; }
			set { orginalStatus = value; }
		}

		/// <summary>
		/// Gets or sets the AlteredStatus value.
		/// </summary>
		public string AlteredStatus
		{
			get { return alteredStatus; }
			set { alteredStatus = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovedBy value.
		/// </summary>
		public long ApprovedBy
		{
			get { return approvedBy; }
			set { approvedBy = value; }
		}

		/// <summary>
		/// Gets or sets the Reason value.
		/// </summary>
		public string Reason
		{
			get { return reason; }
			set { reason = value; }
		}

		/// <summary>
		/// Gets or sets the Histid value.
		/// </summary>
		public int Histid
		{
			get { return histid; }
			set { histid = value; }
		}


		#endregion
}
}
