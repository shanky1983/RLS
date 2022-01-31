using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ExternalQualityValueMaster_History
	{
		#region Fields

		private long histId=0;
		private long iD=0;
		private long eQMID=0;
		private long investigationID=0;
		private string resultValue=String.Empty;
		private string internalResultValue=String.Empty;
		private string externalResultValue=String.Empty;
		private decimal deviation=Decimal.Zero;
		private decimal correction=Decimal.Zero;
		private string zscore=String.Empty;
		private string status=String.Empty;
		private string rootCause=String.Empty;
		private string correctiveAction=String.Empty;
		private string preventiveAction=String.Empty;
		private long orgId=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long deletedBy=0;
		private DateTime delitedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the HistId value.
		/// </summary>
		public long HistId
		{
			get { return histId; }
			set { histId = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the EQMID value.
		/// </summary>
		public long EQMID
		{
			get { return eQMID; }
			set { eQMID = value; }
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
		/// Gets or sets the ResultValue value.
		/// </summary>
		public string ResultValue
		{
			get { return resultValue; }
			set { resultValue = value; }
		}

		/// <summary>
		/// Gets or sets the InternalResultValue value.
		/// </summary>
		public string InternalResultValue
		{
			get { return internalResultValue; }
			set { internalResultValue = value; }
		}

		/// <summary>
		/// Gets or sets the ExternalResultValue value.
		/// </summary>
		public string ExternalResultValue
		{
			get { return externalResultValue; }
			set { externalResultValue = value; }
		}

		/// <summary>
		/// Gets or sets the Deviation value.
		/// </summary>
		public decimal Deviation
		{
			get { return deviation; }
			set { deviation = value; }
		}

		/// <summary>
		/// Gets or sets the Correction value.
		/// </summary>
		public decimal Correction
		{
			get { return correction; }
			set { correction = value; }
		}

		/// <summary>
		/// Gets or sets the Zscore value.
		/// </summary>
		public string Zscore
		{
			get { return zscore; }
			set { zscore = value; }
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
		/// Gets or sets the RootCause value.
		/// </summary>
		public string RootCause
		{
			get { return rootCause; }
			set { rootCause = value; }
		}

		/// <summary>
		/// Gets or sets the CorrectiveAction value.
		/// </summary>
		public string CorrectiveAction
		{
			get { return correctiveAction; }
			set { correctiveAction = value; }
		}

		/// <summary>
		/// Gets or sets the PreventiveAction value.
		/// </summary>
		public string PreventiveAction
		{
			get { return preventiveAction; }
			set { preventiveAction = value; }
		}

		/// <summary>
		/// Gets or sets the OrgId value.
		/// </summary>
		public long OrgId
		{
			get { return orgId; }
			set { orgId = value; }
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
		/// Gets or sets the DeletedBy value.
		/// </summary>
		public long DeletedBy
		{
			get { return deletedBy; }
			set { deletedBy = value; }
		}

		/// <summary>
		/// Gets or sets the DelitedAt value.
		/// </summary>
		public DateTime DelitedAt
		{
			get { return delitedAt; }
			set { delitedAt = value; }
		}


		#endregion
}
}
