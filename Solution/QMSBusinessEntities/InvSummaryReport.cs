using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvSummaryReport
	{
		#region Fields

		private long iD=0;
		private int orgID=0;
		private long visitID=0;
		private string resultSummary=String.Empty;
		private string clinicalInterpretation=String.Empty;
		private string suggestions=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string comments=String.Empty;
		private bool showTRF=false;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
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
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the ResultSummary value.
		/// </summary>
		public string ResultSummary
		{
			get { return resultSummary; }
			set { resultSummary = value; }
		}

		/// <summary>
		/// Gets or sets the ClinicalInterpretation value.
		/// </summary>
		public string ClinicalInterpretation
		{
			get { return clinicalInterpretation; }
			set { clinicalInterpretation = value; }
		}

		/// <summary>
		/// Gets or sets the Suggestions value.
		/// </summary>
		public string Suggestions
		{
			get { return suggestions; }
			set { suggestions = value; }
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
		/// Gets or sets the Comments value.
		/// </summary>
		public string Comments
		{
			get { return comments; }
			set { comments = value; }
		}

		/// <summary>
		/// Gets or sets the ShowTRF value.
		/// </summary>
		public bool ShowTRF
		{
			get { return showTRF; }
			set { showTRF = value; }
		}


		#endregion
}
}
