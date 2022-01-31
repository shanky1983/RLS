using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class DischargeSummarySeq
	{
		#region Fields

		private long dischargeSummarySeqID=0;
		private string placeHolderID=String.Empty;
		private string controlName=String.Empty;
		private string headerName=String.Empty;
		private int orgID=0;
		private string isActive=String.Empty;
		private int sequenceNo=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DischargeSummarySeqID value.
		/// </summary>
		public long DischargeSummarySeqID
		{
			get { return dischargeSummarySeqID; }
			set { dischargeSummarySeqID = value; }
		}

		/// <summary>
		/// Gets or sets the PlaceHolderID value.
		/// </summary>
		public string PlaceHolderID
		{
			get { return placeHolderID; }
			set { placeHolderID = value; }
		}

		/// <summary>
		/// Gets or sets the ControlName value.
		/// </summary>
		public string ControlName
		{
			get { return controlName; }
			set { controlName = value; }
		}

		/// <summary>
		/// Gets or sets the HeaderName value.
		/// </summary>
		public string HeaderName
		{
			get { return headerName; }
			set { headerName = value; }
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
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the SequenceNo value.
		/// </summary>
		public int SequenceNo
		{
			get { return sequenceNo; }
			set { sequenceNo = value; }
		}


		#endregion
}
}
