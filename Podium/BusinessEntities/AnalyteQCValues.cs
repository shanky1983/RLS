using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class AnalyteQCValues
	{
		#region Fields

		private long qCValueID=0;
		private int instrumentID=0;
		private long investigationID=0;
		private long orgAddressID=0;
		private long orgID=0;
		private string value1=String.Empty;
		private string value2=String.Empty;
		private string value3=String.Empty;
		private string value4=String.Empty;
		private DateTime processedAt=DateTime.MaxValue;
		private DateTime createdAt=DateTime.MaxValue;
		private DateTime createdBy=DateTime.MaxValue;
		private DateTime modifiedAt=DateTime.MaxValue;
		private DateTime modifiedBy=DateTime.MaxValue;
		private int qcStatus=0;
		private string failedRule=String.Empty;
		private string reason=String.Empty;
		private string correctionAction=String.Empty;
		private string preventiveAction=String.Empty;
		private long lotID=0;
		private string lotName=String.Empty;
		private long qCLevel=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the QCValueID value.
		/// </summary>
		public long QCValueID
		{
			get { return qCValueID; }
			set { qCValueID = value; }
		}

		/// <summary>
		/// Gets or sets the InstrumentID value.
		/// </summary>
		public int InstrumentID
		{
			get { return instrumentID; }
			set { instrumentID = value; }
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
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public long OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
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
		/// Gets or sets the Value1 value.
		/// </summary>
		public string Value1
		{
			get { return value1; }
			set { value1 = value; }
		}

		/// <summary>
		/// Gets or sets the Value2 value.
		/// </summary>
		public string Value2
		{
			get { return value2; }
			set { value2 = value; }
		}

		/// <summary>
		/// Gets or sets the Value3 value.
		/// </summary>
		public string Value3
		{
			get { return value3; }
			set { value3 = value; }
		}

		/// <summary>
		/// Gets or sets the Value4 value.
		/// </summary>
		public string Value4
		{
			get { return value4; }
			set { value4 = value; }
		}

		/// <summary>
		/// Gets or sets the ProcessedAt value.
		/// </summary>
		public DateTime ProcessedAt
		{
			get { return processedAt; }
			set { processedAt = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public DateTime CreatedBy
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
		public DateTime ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the QcStatus value.
		/// </summary>
		public int QcStatus
		{
			get { return qcStatus; }
			set { qcStatus = value; }
		}

		/// <summary>
		/// Gets or sets the FailedRule value.
		/// </summary>
		public string FailedRule
		{
			get { return failedRule; }
			set { failedRule = value; }
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
		/// Gets or sets the CorrectionAction value.
		/// </summary>
		public string CorrectionAction
		{
			get { return correctionAction; }
			set { correctionAction = value; }
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
		/// Gets or sets the LotID value.
		/// </summary>
		public long LotID
		{
			get { return lotID; }
			set { lotID = value; }
		}

		/// <summary>
		/// Gets or sets the LotName value.
		/// </summary>
		public string LotName
		{
			get { return lotName; }
			set { lotName = value; }
		}

		/// <summary>
		/// Gets or sets the QCLevel value.
		/// </summary>
		public long QCLevel
		{
			get { return qCLevel; }
			set { qCLevel = value; }
		}


		#endregion
}
}
