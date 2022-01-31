using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class LabPrintHistory
	{
		#region Fields

		private long patientVisitID=0;
		private long iD=0;
		private string name=String.Empty;
		private string type=String.Empty;
		private string status=String.Empty;
		private long accessionNumber=0;
		private int orgID=0;
		private string printType=String.Empty;
		private string pageMode=String.Empty;
		private long printedBy=0;
		private DateTime printedAt=DateTime.MaxValue;
		private int locationID=0;
		private string uID=String.Empty;

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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the PrintType value.
		/// </summary>
		public string PrintType
		{
			get { return printType; }
			set { printType = value; }
		}

		/// <summary>
		/// Gets or sets the PageMode value.
		/// </summary>
		public string PageMode
		{
			get { return pageMode; }
			set { pageMode = value; }
		}

		/// <summary>
		/// Gets or sets the PrintedBy value.
		/// </summary>
		public long PrintedBy
		{
			get { return printedBy; }
			set { printedBy = value; }
		}

		/// <summary>
		/// Gets or sets the PrintedAt value.
		/// </summary>
		public DateTime PrintedAt
		{
			get { return printedAt; }
			set { printedAt = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		public int LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the UID value.
		/// </summary>
		public string UID
		{
			get { return uID; }
			set { uID = value; }
		}


		#endregion
}
}
