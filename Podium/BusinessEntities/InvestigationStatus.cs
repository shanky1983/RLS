using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvestigationStatus
	{
		#region Fields

		private int investigationStatusID=0;
		private string status=String.Empty;
		private string reason=String.Empty;
		private int orgid=0;
		private string displayText=String.Empty;
		private string aBBR=String.Empty;
		private int sequence=0;
        private long patientVisitID = 0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvestigationStatusID value.
		/// </summary>
		public int InvestigationStatusID
		{
			get { return investigationStatusID; }
			set { investigationStatusID = value; }
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
		/// Gets or sets the Orgid value.
		/// </summary>
		public int Orgid
		{
			get { return orgid; }
			set { orgid = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayText value.
		/// </summary>
		public string DisplayText
		{
			get { return displayText; }
			set { displayText = value; }
		}

		/// <summary>
		/// Gets or sets the ABBR value.
		/// </summary>
		public string ABBR
		{
			get { return aBBR; }
			set { aBBR = value; }
		}

		/// <summary>
		/// Gets or sets the Sequence value.
		/// </summary>
		public int Sequence
		{
			get { return sequence; }
			set { sequence = value; }
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
		private long _investigationID=0;
		public long InvestigationID
		{
			get { return  _investigationID; }
			set { _investigationID = value; }
		}

		/// <summary>
		/// Gets or sets the StatuswithID value.
		/// </summary>
		private String _statuswithID=String.Empty;
		public String StatuswithID
		{
			get { return  _statuswithID; }
			set { _statuswithID = value; }
		}

		/// <summary>
		/// Gets or sets the IsAutoAuthorize value.
		/// </summary>
		private String _isAutoAuthorize=String.Empty;
		public String IsAutoAuthorize
		{
			get { return  _isAutoAuthorize; }
			set { _isAutoAuthorize = value; }
		}

		/// <summary>
		/// Gets or sets the ExcludeVIDlock value.
		/// </summary>
		private String _excludeVIDlock=String.Empty;
		public String ExcludeVIDlock
		{
			get { return  _excludeVIDlock; }
			set { _excludeVIDlock = value; }
		}


		#endregion
}
}
