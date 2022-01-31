using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InternalAuditNC_QMS
	{
		#region Fields

		private long internalAuditNCID=0;
		private long orgID=0;
		private long planScheduleID=0;
		private string nABLClause=String.Empty;
		private string iSOClause=String.Empty;
		private long nCNO=0;
		private string description=String.Empty;
		private string classification=String.Empty;
		private string activityAssesed=String.Empty;
		private string proposedAction=String.Empty;
		private string actionTaken=String.Empty;
		private DateTime completionDate=DateTime.MaxValue;
		private string actionVerified=String.Empty;
		private string comments=String.Empty;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InternalAuditNCID value.
		/// </summary>
		public long InternalAuditNCID
		{
			get { return internalAuditNCID; }
			set { internalAuditNCID = value; }
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
		/// Gets or sets the PlanScheduleID value.
		/// </summary>
		public long PlanScheduleID
		{
			get { return planScheduleID; }
			set { planScheduleID = value; }
		}

		/// <summary>
		/// Gets or sets the NABLClause value.
		/// </summary>
		public string NABLClause
		{
			get { return nABLClause; }
			set { nABLClause = value; }
		}

		/// <summary>
		/// Gets or sets the ISOClause value.
		/// </summary>
		public string ISOClause
		{
			get { return iSOClause; }
			set { iSOClause = value; }
		}

		/// <summary>
		/// Gets or sets the NCNO value.
		/// </summary>
		public long NCNO
		{
			get { return nCNO; }
			set { nCNO = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Gets or sets the Classification value.
		/// </summary>
		public string Classification
		{
			get { return classification; }
			set { classification = value; }
		}

		/// <summary>
		/// Gets or sets the ActivityAssesed value.
		/// </summary>
		public string ActivityAssesed
		{
			get { return activityAssesed; }
			set { activityAssesed = value; }
		}

		/// <summary>
		/// Gets or sets the ProposedAction value.
		/// </summary>
		public string ProposedAction
		{
			get { return proposedAction; }
			set { proposedAction = value; }
		}

		/// <summary>
		/// Gets or sets the ActionTaken value.
		/// </summary>
		public string ActionTaken
		{
			get { return actionTaken; }
			set { actionTaken = value; }
		}

		/// <summary>
		/// Gets or sets the CompletionDate value.
		/// </summary>
		public DateTime CompletionDate
		{
			get { return completionDate; }
			set { completionDate = value; }
		}

		/// <summary>
		/// Gets or sets the ActionVerified value.
		/// </summary>
		public string ActionVerified
		{
			get { return actionVerified; }
			set { actionVerified = value; }
		}

		/// <summary>
		/// Gets or sets the Comments value.
		/// </summary>
		public string Comments
		{
			get { return comments; }
			set { comments = value; }
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
