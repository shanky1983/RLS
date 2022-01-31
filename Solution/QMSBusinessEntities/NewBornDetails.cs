using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class NewBornDetails
	{
		#region Fields

		private long newBornDetailID=0;
		private long birthRegID=0;
		private long patientID=0;
		private long visitID=0;
		private long parentVisitID=0;
		private int orgID=0;
		private string name=String.Empty;
		private string sex=String.Empty;
		private string identiFicationMarks1=String.Empty;
		private string identiFicationMarks2=String.Empty;
		private DateTime dOB=DateTime.MaxValue;
		private string birthWeight=String.Empty;
		private int presentationID=0;
		private string headCIRC=String.Empty;
		private string cHL=String.Empty;
		private string status=String.Empty;
		private string aPGARScore=String.Empty;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the NewBornDetailID value.
		/// </summary>
		public long NewBornDetailID
		{
			get { return newBornDetailID; }
			set { newBornDetailID = value; }
		}

		/// <summary>
		/// Gets or sets the BirthRegID value.
		/// </summary>
		public long BirthRegID
		{
			get { return birthRegID; }
			set { birthRegID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
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
		/// Gets or sets the ParentVisitID value.
		/// </summary>
		public long ParentVisitID
		{
			get { return parentVisitID; }
			set { parentVisitID = value; }
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
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Gets or sets the Sex value.
		/// </summary>
		public string Sex
		{
			get { return sex; }
			set { sex = value; }
		}

		/// <summary>
		/// Gets or sets the IdentiFicationMarks1 value.
		/// </summary>
		public string IdentiFicationMarks1
		{
			get { return identiFicationMarks1; }
			set { identiFicationMarks1 = value; }
		}

		/// <summary>
		/// Gets or sets the IdentiFicationMarks2 value.
		/// </summary>
		public string IdentiFicationMarks2
		{
			get { return identiFicationMarks2; }
			set { identiFicationMarks2 = value; }
		}

		/// <summary>
		/// Gets or sets the DOB value.
		/// </summary>
		public DateTime DOB
		{
			get { return dOB; }
			set { dOB = value; }
		}

		/// <summary>
		/// Gets or sets the BirthWeight value.
		/// </summary>
		public string BirthWeight
		{
			get { return birthWeight; }
			set { birthWeight = value; }
		}

		/// <summary>
		/// Gets or sets the PresentationID value.
		/// </summary>
		public int PresentationID
		{
			get { return presentationID; }
			set { presentationID = value; }
		}

		/// <summary>
		/// Gets or sets the HeadCIRC value.
		/// </summary>
		public string HeadCIRC
		{
			get { return headCIRC; }
			set { headCIRC = value; }
		}

		/// <summary>
		/// Gets or sets the CHL value.
		/// </summary>
		public string CHL
		{
			get { return cHL; }
			set { cHL = value; }
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
		/// Gets or sets the APGARScore value.
		/// </summary>
		public string APGARScore
		{
			get { return aPGARScore; }
			set { aPGARScore = value; }
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
		/// Gets or sets the CreatedByName value.
		/// </summary>
		string _createdbyname;
		public string CreatedByName
		{
			get { return _createdbyname; }
			set { _createdbyname = value; }
		}


		#endregion
}
}
