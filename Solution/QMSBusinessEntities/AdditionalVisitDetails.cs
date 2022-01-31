using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class AdditionalVisitDetails
	{
		#region Fields

		private long patientVisitID=0;
		private long phlebetomyID=0;
		private long logisticsID=0;
		private string roundNo=String.Empty;
		private string exautoauthorization=String.Empty;
		private long zoneID=0;
		private string approvalNo=String.Empty;
		private int iD=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string emailCC=String.Empty;
		private string visitNumber=String.Empty;
		private string clinicCode=String.Empty;

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
		/// Gets or sets the PhlebetomyID value.
		/// </summary>
		public long PhlebetomyID
		{
			get { return phlebetomyID; }
			set { phlebetomyID = value; }
		}

		/// <summary>
		/// Gets or sets the LogisticsID value.
		/// </summary>
		public long LogisticsID
		{
			get { return logisticsID; }
			set { logisticsID = value; }
		}

		/// <summary>
		/// Gets or sets the RoundNo value.
		/// </summary>
		public string RoundNo
		{
			get { return roundNo; }
			set { roundNo = value; }
		}

		/// <summary>
		/// Gets or sets the Exautoauthorization value.
		/// </summary>
		public string Exautoauthorization
		{
			get { return exautoauthorization; }
			set { exautoauthorization = value; }
		}

		/// <summary>
		/// Gets or sets the ZoneID value.
		/// </summary>
		public long ZoneID
		{
			get { return zoneID; }
			set { zoneID = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovalNo value.
		/// </summary>
		public string ApprovalNo
		{
			get { return approvalNo; }
			set { approvalNo = value; }
		}

		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
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
		/// Gets or sets the EmailCC value.
		/// </summary>
		public string EmailCC
		{
			get { return emailCC; }
			set { emailCC = value; }
		}

		/// <summary>
		/// Gets or sets the VisitNumber value.
		/// </summary>
		public string VisitNumber
		{
			get { return visitNumber; }
			set { visitNumber = value; }
		}

		/// <summary>
		/// Gets or sets the ClinicCode value.
		/// </summary>
		public string ClinicCode
		{
			get { return clinicCode; }
			set { clinicCode = value; }
		}


		#endregion
}
}
