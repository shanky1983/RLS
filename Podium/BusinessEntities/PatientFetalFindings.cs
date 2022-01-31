using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientFetalFindings
	{
		#region Fields

		private long patientID=0;
		private long patientVisitID=0;
		private int fetalNumber=0;
		private string fetalPresentationDesc=String.Empty;
		private string fetalPositionDesc=String.Empty;
		private string fetalMovementsDesc=String.Empty;
		private string fetalFHSDesc=String.Empty;
		private string fetalOthers=String.Empty;
		private string isNormalFinding=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
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
		/// Gets or sets the FetalNumber value.
		/// </summary>
		public int FetalNumber
		{
			get { return fetalNumber; }
			set { fetalNumber = value; }
		}

		/// <summary>
		/// Gets or sets the FetalPresentationDesc value.
		/// </summary>
		public string FetalPresentationDesc
		{
			get { return fetalPresentationDesc; }
			set { fetalPresentationDesc = value; }
		}

		/// <summary>
		/// Gets or sets the FetalPositionDesc value.
		/// </summary>
		public string FetalPositionDesc
		{
			get { return fetalPositionDesc; }
			set { fetalPositionDesc = value; }
		}

		/// <summary>
		/// Gets or sets the FetalMovementsDesc value.
		/// </summary>
		public string FetalMovementsDesc
		{
			get { return fetalMovementsDesc; }
			set { fetalMovementsDesc = value; }
		}

		/// <summary>
		/// Gets or sets the FetalFHSDesc value.
		/// </summary>
		public string FetalFHSDesc
		{
			get { return fetalFHSDesc; }
			set { fetalFHSDesc = value; }
		}

		/// <summary>
		/// Gets or sets the FetalOthers value.
		/// </summary>
		public string FetalOthers
		{
			get { return fetalOthers; }
			set { fetalOthers = value; }
		}

		/// <summary>
		/// Gets or sets the IsNormalFinding value.
		/// </summary>
		public string IsNormalFinding
		{
			get { return isNormalFinding; }
			set { isNormalFinding = value; }
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
		/// Gets or sets the FetalPresentationID value.
		/// </summary>
		private int _fetalPresentationID=0;
		public int FetalPresentationID
		{
			get { return  _fetalPresentationID; }
			set { _fetalPresentationID = value; }
		}

		/// <summary>
		/// Gets or sets the FetalPositionID value.
		/// </summary>
		private int _fetalPositionID=0;
		public int FetalPositionID
		{
			get { return  _fetalPositionID; }
			set { _fetalPositionID = value; }
		}

		/// <summary>
		/// Gets or sets the FetalMovementsID value.
		/// </summary>
		private int _fetalMovementsID=0;
		public int FetalMovementsID
		{
			get { return  _fetalMovementsID; }
			set { _fetalMovementsID = value; }
		}

		/// <summary>
		/// Gets or sets the FetalFHSID value.
		/// </summary>
		private int _fetalFHSID=0;
		public int FetalFHSID
		{
			get { return  _fetalFHSID; }
			set { _fetalFHSID = value; }
		}


		#endregion
}
}
