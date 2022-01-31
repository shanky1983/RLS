using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class RTAMLCDetails_HIST
	{
		#region Fields

		private long rTAMLCDetails_HISTID=0;
		private long patientID=0;
		private long patientVisitID=0;
		private string alcoholDrugInfluence=String.Empty;
		private DateTime rTAMLCDate=DateTime.MaxValue;
		private string fIRNo=String.Empty;
		private string location=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgID=0;
		private string policeStation=String.Empty;
		private string mLCNo=String.Empty;
		private DateTime fIRDate=DateTime.MaxValue;
		private long createdRole=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RTAMLCDetails_HISTID value.
		/// </summary>
		public long RTAMLCDetails_HISTID
		{
			get { return rTAMLCDetails_HISTID; }
			set { rTAMLCDetails_HISTID = value; }
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
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		public long PatientVisitID
		{
			get { return patientVisitID; }
			set { patientVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the AlcoholDrugInfluence value.
		/// </summary>
		public string AlcoholDrugInfluence
		{
			get { return alcoholDrugInfluence; }
			set { alcoholDrugInfluence = value; }
		}

		/// <summary>
		/// Gets or sets the RTAMLCDate value.
		/// </summary>
		public DateTime RTAMLCDate
		{
			get { return rTAMLCDate; }
			set { rTAMLCDate = value; }
		}

		/// <summary>
		/// Gets or sets the FIRNo value.
		/// </summary>
		public string FIRNo
		{
			get { return fIRNo; }
			set { fIRNo = value; }
		}

		/// <summary>
		/// Gets or sets the Location value.
		/// </summary>
		public string Location
		{
			get { return location; }
			set { location = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the PoliceStation value.
		/// </summary>
		public string PoliceStation
		{
			get { return policeStation; }
			set { policeStation = value; }
		}

		/// <summary>
		/// Gets or sets the MLCNo value.
		/// </summary>
		public string MLCNo
		{
			get { return mLCNo; }
			set { mLCNo = value; }
		}

		/// <summary>
		/// Gets or sets the FIRDate value.
		/// </summary>
		public DateTime FIRDate
		{
			get { return fIRDate; }
			set { fIRDate = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedRole value.
		/// </summary>
		public long CreatedRole
		{
			get { return createdRole; }
			set { createdRole = value; }
		}


		#endregion
}
}
