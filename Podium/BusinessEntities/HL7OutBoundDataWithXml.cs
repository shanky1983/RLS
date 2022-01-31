using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class HL7OutBoundDataWithXml
	{
		#region Fields

		private long hl7ID=0;
		private long patientVisitID=0;
		private long accessionNumber=0;
		private string outBoundXML=String.Empty;
		private string status=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Hl7ID value.
		/// </summary>
		public long Hl7ID
		{
			get { return hl7ID; }
			set { hl7ID = value; }
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
		/// Gets or sets the AccessionNumber value.
		/// </summary>
		public long AccessionNumber
		{
			get { return accessionNumber; }
			set { accessionNumber = value; }
		}

		/// <summary>
		/// Gets or sets the OutBoundXML value.
		/// </summary>
		public string OutBoundXML
		{
			get { return outBoundXML; }
			set { outBoundXML = value; }
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
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}


		#endregion
}
}
