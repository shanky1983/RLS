using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Hl7OutBoundMessageDetails
	{
		#region Fields

		private long hL7ID=0;
		private long iD=0;
		private string name=String.Empty;
		private string type=String.Empty;
		private string status=String.Empty;
		private long accessionNumber=0;
		private string generatedXML=String.Empty;
		private string testStatus=String.Empty;
		private long patientVisitID=0;
		private long orderedID=0;
		private long orgID=0;
		private DateTime collectedDateTime=DateTime.MaxValue;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private string pDFForOutBound=String.Empty;
		private string reason=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the HL7ID value.
		/// </summary>
		public long HL7ID
		{
			get { return hL7ID; }
			set { hL7ID = value; }
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
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
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
		/// Gets or sets the AccessionNumber value.
		/// </summary>
		public long AccessionNumber
		{
			get { return accessionNumber; }
			set { accessionNumber = value; }
		}

		/// <summary>
		/// Gets or sets the GeneratedXML value.
		/// </summary>
		public string GeneratedXML
		{
			get { return generatedXML; }
			set { generatedXML = value; }
		}

		/// <summary>
		/// Gets or sets the TestStatus value.
		/// </summary>
		public string TestStatus
		{
			get { return testStatus; }
			set { testStatus = value; }
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
		/// Gets or sets the OrderedID value.
		/// </summary>
		public long OrderedID
		{
			get { return orderedID; }
			set { orderedID = value; }
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
		/// Gets or sets the CollectedDateTime value.
		/// </summary>
		public DateTime CollectedDateTime
		{
			get { return collectedDateTime; }
			set { collectedDateTime = value; }
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

		/// <summary>
		/// Gets or sets the PDFForOutBound value.
		/// </summary>
		public string PDFForOutBound
		{
			get { return pDFForOutBound; }
			set { pDFForOutBound = value; }
		}

		/// <summary>
		/// Gets or sets the Reason value.
		/// </summary>
		public string Reason
		{
			get { return reason; }
			set { reason = value; }
		}


		#endregion
}
}
