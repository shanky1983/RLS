using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InPatientConsultantTransferDetails
	{
		#region Fields

		private int transferDetailsID=0;
		private int patientID=0;
		private int visitID=0;
		private int fromDoctorID=0;
		private int toDoctorID=0;
		private string reasonForTransfer=String.Empty;
		private int createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private int modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TransferDetailsID value.
		/// </summary>
		public int TransferDetailsID
		{
			get { return transferDetailsID; }
			set { transferDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientID value.
		/// </summary>
		public int PatientID
		{
			get { return patientID; }
			set { patientID = value; }
		}

		/// <summary>
		/// Gets or sets the VisitID value.
		/// </summary>
		public int VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the FromDoctorID value.
		/// </summary>
		public int FromDoctorID
		{
			get { return fromDoctorID; }
			set { fromDoctorID = value; }
		}

		/// <summary>
		/// Gets or sets the ToDoctorID value.
		/// </summary>
		public int ToDoctorID
		{
			get { return toDoctorID; }
			set { toDoctorID = value; }
		}

		/// <summary>
		/// Gets or sets the ReasonForTransfer value.
		/// </summary>
		public string ReasonForTransfer
		{
			get { return reasonForTransfer; }
			set { reasonForTransfer = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public int CreatedBy
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
		public int ModifiedBy
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


		#endregion
}
}
