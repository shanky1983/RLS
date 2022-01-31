using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class MRDFileDetails
	{
		#region Fields

		private long mRDFileDetailsID=0;
		private long patientID=0;
		private long patientVisitId=0;
		private string categoryType=String.Empty;
		private int categoryID=0;
		private long fromPersonID=0;
		private long toPersonID=0;
		private string status=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private long mRDFileID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MRDFileDetailsID value.
		/// </summary>
		public long MRDFileDetailsID
		{
			get { return mRDFileDetailsID; }
			set { mRDFileDetailsID = value; }
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
		/// Gets or sets the CategoryType value.
		/// </summary>
		public string CategoryType
		{
			get { return categoryType; }
			set { categoryType = value; }
		}

		/// <summary>
		/// Gets or sets the CategoryID value.
		/// </summary>
		public int CategoryID
		{
			get { return categoryID; }
			set { categoryID = value; }
		}

		/// <summary>
		/// Gets or sets the FromPersonID value.
		/// </summary>
		public long FromPersonID
		{
			get { return fromPersonID; }
			set { fromPersonID = value; }
		}

		/// <summary>
		/// Gets or sets the ToPersonID value.
		/// </summary>
		public long ToPersonID
		{
			get { return toPersonID; }
			set { toPersonID = value; }
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
		/// Gets or sets the MRDFileID value.
		/// </summary>
		public long MRDFileID
		{
			get { return mRDFileID; }
			set { mRDFileID = value; }
		}


		#endregion
}
}
