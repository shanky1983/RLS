using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientExtendedType
	{
		#region Fields

		private long parentPatientID=0;
		private long relatedPatientID=0;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string relationShipType=String.Empty;
		private string relationShipSubType=String.Empty;
		private long relationShipTypeID=0;
		private string patientEmpTypeNumber=String.Empty;
		private string employementTypeNumber=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ParentPatientID value.
		/// </summary>
		public long ParentPatientID
		{
			get { return parentPatientID; }
			set { parentPatientID = value; }
		}

		/// <summary>
		/// Gets or sets the RelatedPatientID value.
		/// </summary>
		public long RelatedPatientID
		{
			get { return relatedPatientID; }
			set { relatedPatientID = value; }
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
		/// Gets or sets the RelationShipType value.
		/// </summary>
		public string RelationShipType
		{
			get { return relationShipType; }
			set { relationShipType = value; }
		}

		/// <summary>
		/// Gets or sets the RelationShipSubType value.
		/// </summary>
		public string RelationShipSubType
		{
			get { return relationShipSubType; }
			set { relationShipSubType = value; }
		}

		/// <summary>
		/// Gets or sets the RelationShipTypeID value.
		/// </summary>
		public long RelationShipTypeID
		{
			get { return relationShipTypeID; }
			set { relationShipTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientEmpTypeNumber value.
		/// </summary>
		public string PatientEmpTypeNumber
		{
			get { return patientEmpTypeNumber; }
			set { patientEmpTypeNumber = value; }
		}

		/// <summary>
		/// Gets or sets the EmployementTypeNumber value.
		/// </summary>
		public string EmployementTypeNumber
		{
			get { return employementTypeNumber; }
			set { employementTypeNumber = value; }
		}


		#endregion
}
}
