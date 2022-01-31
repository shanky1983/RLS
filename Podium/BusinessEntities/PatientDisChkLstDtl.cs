using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientDisChkLstDtl
	{
		#region Fields

		private long pDCLstDID=0;
		private long patientID=0;
		private long patientVisitId=0;
		private int chkLstID=0;
		private string comments=String.Empty;
		private DateTime pDCLstDate=DateTime.MaxValue;
		private long collectedBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PDCLstDID value.
		/// </summary>
		public long PDCLstDID
		{
			get { return pDCLstDID; }
			set { pDCLstDID = value; }
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
		/// Gets or sets the PatientVisitId value.
		/// </summary>
		public long PatientVisitId
		{
			get { return patientVisitId; }
			set { patientVisitId = value; }
		}

		/// <summary>
		/// Gets or sets the ChkLstID value.
		/// </summary>
		public int ChkLstID
		{
			get { return chkLstID; }
			set { chkLstID = value; }
		}

		/// <summary>
		/// Gets or sets the Comments value.
		/// </summary>
		public string Comments
		{
			get { return comments; }
			set { comments = value; }
		}

		/// <summary>
		/// Gets or sets the PDCLstDate value.
		/// </summary>
		public DateTime PDCLstDate
		{
			get { return pDCLstDate; }
			set { pDCLstDate = value; }
		}

		/// <summary>
		/// Gets or sets the CollectedBy value.
		/// </summary>
		public long CollectedBy
		{
			get { return collectedBy; }
			set { collectedBy = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}


		#endregion
}
}
