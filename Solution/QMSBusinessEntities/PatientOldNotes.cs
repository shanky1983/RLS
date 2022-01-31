using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientOldNotes
	{
		#region Fields

		private long patientoldNotesID=0;
		private long visitID=0;
		private string documentTitle=String.Empty;
		private DateTime documentDate=DateTime.MaxValue;
		private string physicainName=String.Empty;
		private string performingOrgName=String.Empty;
		private string performingOrgLocation=String.Empty;
		private long uploadOrgID=0;
		private long uploadOrgLoactionID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientoldNotesID value.
		/// </summary>
		public long PatientoldNotesID
		{
			get { return patientoldNotesID; }
			set { patientoldNotesID = value; }
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
		/// Gets or sets the DocumentTitle value.
		/// </summary>
		public string DocumentTitle
		{
			get { return documentTitle; }
			set { documentTitle = value; }
		}

		/// <summary>
		/// Gets or sets the DocumentDate value.
		/// </summary>
		public DateTime DocumentDate
		{
			get { return documentDate; }
			set { documentDate = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicainName value.
		/// </summary>
		public string PhysicainName
		{
			get { return physicainName; }
			set { physicainName = value; }
		}

		/// <summary>
		/// Gets or sets the PerformingOrgName value.
		/// </summary>
		public string PerformingOrgName
		{
			get { return performingOrgName; }
			set { performingOrgName = value; }
		}

		/// <summary>
		/// Gets or sets the PerformingOrgLocation value.
		/// </summary>
		public string PerformingOrgLocation
		{
			get { return performingOrgLocation; }
			set { performingOrgLocation = value; }
		}

		/// <summary>
		/// Gets or sets the UploadOrgID value.
		/// </summary>
		public long UploadOrgID
		{
			get { return uploadOrgID; }
			set { uploadOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the UploadOrgLoactionID value.
		/// </summary>
		public long UploadOrgLoactionID
		{
			get { return uploadOrgLoactionID; }
			set { uploadOrgLoactionID = value; }
		}


		#endregion
}
}
