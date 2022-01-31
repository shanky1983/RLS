using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class DocumentUploadManager_HIST
	{
		#region Fields

		private long docFileID=0;
		private string docFileUrl=String.Empty;
		private string docFileName=String.Empty;
		private long patientID=0;
		private int orgID=0;
		private long identifyingID=0;
		private string identifyingType=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private string status=String.Empty;
		private string reason=String.Empty;
		private long histID=0;
		private string action=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DocFileID value.
		/// </summary>
		public long DocFileID
		{
			get { return docFileID; }
			set { docFileID = value; }
		}

		/// <summary>
		/// Gets or sets the DocFileUrl value.
		/// </summary>
		public string DocFileUrl
		{
			get { return docFileUrl; }
			set { docFileUrl = value; }
		}

		/// <summary>
		/// Gets or sets the DocFileName value.
		/// </summary>
		public string DocFileName
		{
			get { return docFileName; }
			set { docFileName = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the IdentifyingID value.
		/// </summary>
		public long IdentifyingID
		{
			get { return identifyingID; }
			set { identifyingID = value; }
		}

		/// <summary>
		/// Gets or sets the IdentifyingType value.
		/// </summary>
		public string IdentifyingType
		{
			get { return identifyingType; }
			set { identifyingType = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
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
		/// Gets or sets the HistID value.
		/// </summary>
		public long HistID
		{
			get { return histID; }
			set { histID = value; }
		}

		/// <summary>
		/// Gets or sets the Action value.
		/// </summary>
		public string Action
		{
			get { return action; }
			set { action = value; }
		}


		#endregion
}
}
