using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientInvestigationDevice
	{
		#region Fields

		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string status=String.Empty;
		private string referenceRange=String.Empty;
		private long patientInvID=0;
		private string isAbnormal=String.Empty;
		private string convReferenceRange=String.Empty;
		private string isAutoAuthorize=String.Empty;
		private string printableRange=String.Empty;
		private string isAutoValidate=String.Empty;
		private bool isUpdated=false;
		private long rowID=0;

		#endregion

		#region Properties
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
		/// Gets or sets the ReferenceRange value.
		/// </summary>
		public string ReferenceRange
		{
			get { return referenceRange; }
			set { referenceRange = value; }
		}

		/// <summary>
		/// Gets or sets the PatientInvID value.
		/// </summary>
		public long PatientInvID
		{
			get { return patientInvID; }
			set { patientInvID = value; }
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
		/// Gets or sets the ConvReferenceRange value.
		/// </summary>
		public string ConvReferenceRange
		{
			get { return convReferenceRange; }
			set { convReferenceRange = value; }
		}

		/// <summary>
		/// Gets or sets the IsAutoAuthorize value.
		/// </summary>
		public string IsAutoAuthorize
		{
			get { return isAutoAuthorize; }
			set { isAutoAuthorize = value; }
		}

		/// <summary>
		/// Gets or sets the PrintableRange value.
		/// </summary>
		public string PrintableRange
		{
			get { return printableRange; }
			set { printableRange = value; }
		}

		/// <summary>
		/// Gets or sets the IsAutoValidate value.
		/// </summary>
		public string IsAutoValidate
		{
			get { return isAutoValidate; }
			set { isAutoValidate = value; }
		}

		/// <summary>
		/// Gets or sets the IsUpdated value.
		/// </summary>
		public bool IsUpdated
		{
			get { return isUpdated; }
			set { isUpdated = value; }
		}

		/// <summary>
		/// Gets or sets the RowID value.
		/// </summary>
		public long RowID
		{
			get { return rowID; }
			set { rowID = value; }
		}


		#endregion
}
}
