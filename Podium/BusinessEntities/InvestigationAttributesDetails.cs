using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvestigationAttributesDetails
	{
		#region Fields

		private long id=0;
		private long patientInvId=0;
		private long investigationId=0;
		private string isReportable=String.Empty;
		private int orgId=0;
		private int parentInvId=0;
		private string statusType=String.Empty;
		private string isBillable=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long accessionNumber=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public long Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the PatientInvId value.
		/// </summary>
		public long PatientInvId
		{
			get { return patientInvId; }
			set { patientInvId = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationId value.
		/// </summary>
		public long InvestigationId
		{
			get { return investigationId; }
			set { investigationId = value; }
		}

		/// <summary>
		/// Gets or sets the IsReportable value.
		/// </summary>
		public string IsReportable
		{
			get { return isReportable; }
			set { isReportable = value; }
		}

		/// <summary>
		/// Gets or sets the OrgId value.
		/// </summary>
		public int OrgId
		{
			get { return orgId; }
			set { orgId = value; }
		}

		/// <summary>
		/// Gets or sets the ParentInvId value.
		/// </summary>
		public int ParentInvId
		{
			get { return parentInvId; }
			set { parentInvId = value; }
		}

		/// <summary>
		/// Gets or sets the StatusType value.
		/// </summary>
		public string StatusType
		{
			get { return statusType; }
			set { statusType = value; }
		}

		/// <summary>
		/// Gets or sets the IsBillable value.
		/// </summary>
		public string IsBillable
		{
			get { return isBillable; }
			set { isBillable = value; }
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
		/// Gets or sets the AccessionNumber value.
		/// </summary>
		public long AccessionNumber
		{
			get { return accessionNumber; }
			set { accessionNumber = value; }
		}


		#endregion
}
}
