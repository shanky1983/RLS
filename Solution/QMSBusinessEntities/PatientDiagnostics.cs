using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientDiagnostics
	{
		#region Fields

		private long patientVisitID=0;
		private int diagnosticsID=0;
		private string diagnosticsName=String.Empty;
		private string description=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string hashAttribute=String.Empty;
		private long seqID=0;

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
		/// Gets or sets the DiagnosticsID value.
		/// </summary>
		public int DiagnosticsID
		{
			get { return diagnosticsID; }
			set { diagnosticsID = value; }
		}

		/// <summary>
		/// Gets or sets the DiagnosticsName value.
		/// </summary>
		public string DiagnosticsName
		{
			get { return diagnosticsName; }
			set { diagnosticsName = value; }
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
		/// Gets or sets the HashAttribute value.
		/// </summary>
		public string HashAttribute
		{
			get { return hashAttribute; }
			set { hashAttribute = value; }
		}

		/// <summary>
		/// Gets or sets the SeqID value.
		/// </summary>
		public long SeqID
		{
			get { return seqID; }
			set { seqID = value; }
		}


		#endregion
}
}
