using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientDisChkLstMaster
	{
		#region Fields

		private long pDCLstMID=0;
		private long patientID=0;
		private string iPNumber=String.Empty;
		private long patientVisitId=0;
		private string destPostDis=String.Empty;
		private long collectedBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PDCLstMID value.
		/// </summary>
		public long PDCLstMID
		{
			get { return pDCLstMID; }
			set { pDCLstMID = value; }
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
		/// Gets or sets the IPNumber value.
		/// </summary>
		public string IPNumber
		{
			get { return iPNumber; }
			set { iPNumber = value; }
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
		/// Gets or sets the DestPostDis value.
		/// </summary>
		public string DestPostDis
		{
			get { return destPostDis; }
			set { destPostDis = value; }
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
