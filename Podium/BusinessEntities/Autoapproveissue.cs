using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Autoapproveissue
	{
		#region Fields

		private long patientvisitID=0;
		private int orgID=0;
		private int investigationID=0;
		private long accessionNumber=0;
		private string testName=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private DateTime modifiedat=DateTime.MaxValue;
		private string createdby=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientvisitID value.
		/// </summary>
		public long PatientvisitID
		{
			get { return patientvisitID; }
			set { patientvisitID = value; }
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
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public int InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
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
		/// Gets or sets the TestName value.
		/// </summary>
		public string TestName
		{
			get { return testName; }
			set { testName = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
		}

		/// <summary>
		/// Gets or sets the Modifiedat value.
		/// </summary>
		public DateTime Modifiedat
		{
			get { return modifiedat; }
			set { modifiedat = value; }
		}

		/// <summary>
		/// Gets or sets the Createdby value.
		/// </summary>
		public string Createdby
		{
			get { return createdby; }
			set { createdby = value; }
		}


		#endregion
}
}
