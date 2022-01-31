using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ExternalAudit_QMS
	{
		#region Fields

		private long enternalAuditID=0;
		private long orgID=0;
		private long addressID=0;
		private long auditNo=0;
		private string auditAgency=String.Empty;
		private int majorNC=0;
		private int minorNC=0;
		private string auditorsList=String.Empty;
		private int deptID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private DateTime fromTime=DateTime.MaxValue;
		private DateTime toTime=DateTime.MaxValue;
		private string status=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the EnternalAuditID value.
		/// </summary>
		public long EnternalAuditID
		{
			get { return enternalAuditID; }
			set { enternalAuditID = value; }
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
		/// Gets or sets the AddressID value.
		/// </summary>
		public long AddressID
		{
			get { return addressID; }
			set { addressID = value; }
		}

		/// <summary>
		/// Gets or sets the AuditNo value.
		/// </summary>
		public long AuditNo
		{
			get { return auditNo; }
			set { auditNo = value; }
		}

		/// <summary>
		/// Gets or sets the AuditAgency value.
		/// </summary>
		public string AuditAgency
		{
			get { return auditAgency; }
			set { auditAgency = value; }
		}

		/// <summary>
		/// Gets or sets the MajorNC value.
		/// </summary>
		public int MajorNC
		{
			get { return majorNC; }
			set { majorNC = value; }
		}

		/// <summary>
		/// Gets or sets the MinorNC value.
		/// </summary>
		public int MinorNC
		{
			get { return minorNC; }
			set { minorNC = value; }
		}

		/// <summary>
		/// Gets or sets the AuditorsList value.
		/// </summary>
		public string AuditorsList
		{
			get { return auditorsList; }
			set { auditorsList = value; }
		}

		/// <summary>
		/// Gets or sets the DeptID value.
		/// </summary>
		public int DeptID
		{
			get { return deptID; }
			set { deptID = value; }
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
		/// Gets or sets the FromTime value.
		/// </summary>
		public DateTime FromTime
		{
			get { return fromTime; }
			set { fromTime = value; }
		}

		/// <summary>
		/// Gets or sets the ToTime value.
		/// </summary>
		public DateTime ToTime
		{
			get { return toTime; }
			set { toTime = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}


		#endregion
}
}
