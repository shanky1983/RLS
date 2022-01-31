using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class AttuneRptPINV
	{
		#region Fields

		private long patientinvid=0;
		private long accessionnumber=0;
		private int orgid=0;
		private long patientVisitID=0;
		private long investigationID=0;
		private string investigationName=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string status=String.Empty;
		private int groupID=0;
		private string groupName=String.Empty;
		private string isAbnormal=String.Empty;
		private long approvedBy=0;
		private DateTime approvedAt=DateTime.MaxValue;
		private long validatedBy=0;
		private DateTime validatedAt=DateTime.MaxValue;
		private int deptid=0;
		private int sampleid=0;
		private string isSensitive=String.Empty;
		private int containerID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Patientinvid value.
		/// </summary>
		public long Patientinvid
		{
			get { return patientinvid; }
			set { patientinvid = value; }
		}

		/// <summary>
		/// Gets or sets the Accessionnumber value.
		/// </summary>
		public long Accessionnumber
		{
			get { return accessionnumber; }
			set { accessionnumber = value; }
		}

		/// <summary>
		/// Gets or sets the Orgid value.
		/// </summary>
		public int Orgid
		{
			get { return orgid; }
			set { orgid = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the GroupID value.
		/// </summary>
		public int GroupID
		{
			get { return groupID; }
			set { groupID = value; }
		}

		/// <summary>
		/// Gets or sets the GroupName value.
		/// </summary>
		public string GroupName
		{
			get { return groupName; }
			set { groupName = value; }
		}

		/// <summary>
		/// Gets or sets the IsAbnormal value.
		/// </summary>
		public string IsAbnormal
		{
			get { return isAbnormal; }
			set { isAbnormal = value; }
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
		/// Gets or sets the ApprovedAt value.
		/// </summary>
		public DateTime ApprovedAt
		{
			get { return approvedAt; }
			set { approvedAt = value; }
		}

		/// <summary>
		/// Gets or sets the ValidatedBy value.
		/// </summary>
		public long ValidatedBy
		{
			get { return validatedBy; }
			set { validatedBy = value; }
		}

		/// <summary>
		/// Gets or sets the ValidatedAt value.
		/// </summary>
		public DateTime ValidatedAt
		{
			get { return validatedAt; }
			set { validatedAt = value; }
		}

		/// <summary>
		/// Gets or sets the Deptid value.
		/// </summary>
		public int Deptid
		{
			get { return deptid; }
			set { deptid = value; }
		}

		/// <summary>
		/// Gets or sets the Sampleid value.
		/// </summary>
		public int Sampleid
		{
			get { return sampleid; }
			set { sampleid = value; }
		}

		/// <summary>
		/// Gets or sets the IsSensitive value.
		/// </summary>
		public string IsSensitive
		{
			get { return isSensitive; }
			set { isSensitive = value; }
		}

		/// <summary>
		/// Gets or sets the ContainerID value.
		/// </summary>
		public int ContainerID
		{
			get { return containerID; }
			set { containerID = value; }
		}


		#endregion
}
}
