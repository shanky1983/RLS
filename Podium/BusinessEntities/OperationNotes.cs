using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class OperationNotes
	{
		#region Fields

		private long operationID=0;
		private long patientID=0;
		private int orgID=0;
		private long patientVistID=0;
		private DateTime fromTime=DateTime.MaxValue;
		private DateTime toTime=DateTime.MaxValue;
		private int surgeryTypeID=0;
		private int anesthesiaTypeID=0;
		private int operationTypeID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OperationID value.
		/// </summary>
		public long OperationID
		{
			get { return operationID; }
			set { operationID = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVistID value.
		/// </summary>
		public long PatientVistID
		{
			get { return patientVistID; }
			set { patientVistID = value; }
		}

		/// <summary>
		/// Gets or sets the FromTime value.
		/// </summary>
		public DateTime FromTime
		{
			get { return fromTime; }
			set { fromTime = value; }
		}

		/// <summary>
		/// Gets or sets the ToTime value.
		/// </summary>
		public DateTime ToTime
		{
			get { return toTime; }
			set { toTime = value; }
		}

		/// <summary>
		/// Gets or sets the SurgeryTypeID value.
		/// </summary>
		public int SurgeryTypeID
		{
			get { return surgeryTypeID; }
			set { surgeryTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the AnesthesiaTypeID value.
		/// </summary>
		public int AnesthesiaTypeID
		{
			get { return anesthesiaTypeID; }
			set { anesthesiaTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the OperationTypeID value.
		/// </summary>
		public int OperationTypeID
		{
			get { return operationTypeID; }
			set { operationTypeID = value; }
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
		/// Gets or sets the OperativeTechnique value.
		/// </summary>
		private string _operativeTechnique=String.Empty;
		public string OperativeTechnique
		{
			get { return  _operativeTechnique; }
			set { _operativeTechnique = value; }
		}

		/// <summary>
		/// Gets or sets the OperativeFindings value.
		/// </summary>
		private string _operativeFindings=String.Empty;
		public string OperativeFindings
		{
			get { return  _operativeFindings; }
			set { _operativeFindings = value; }
		}

		/// <summary>
		/// Gets or sets the AnesthesiaType value.
		/// </summary>
		private string _anesthesiaType=String.Empty;
		public string AnesthesiaType
		{
			get { return  _anesthesiaType; }
			set { _anesthesiaType = value; }
		}

		/// <summary>
		/// Gets or sets the SurgeryType value.
		/// </summary>
		private string _surgeryType=String.Empty;
		public string SurgeryType
		{
			get { return  _surgeryType; }
			set { _surgeryType = value; }
		}

		/// <summary>
		/// Gets or sets the OperationType value.
		/// </summary>
		private string _operationType=String.Empty;
		public string OperationType
		{
			get { return  _operationType; }
			set { _operationType = value; }
		}

		/// <summary>
		/// Gets or sets the TreatmentName value.
		/// </summary>
		private string _treatmentName=String.Empty;
		public string TreatmentName
		{
			get { return  _treatmentName; }
			set { _treatmentName = value; }
		}

		/// <summary>
		/// Gets or sets the ProcedureName value.
		/// </summary>
		private string _procedureName=String.Empty;
		public string ProcedureName
		{
			get { return  _procedureName; }
			set { _procedureName = value; }
		}

		/// <summary>
		/// Gets or sets the ICDCode value.
		/// </summary>
		private string _iCDCode=String.Empty;
		public string ICDCode
		{
			get { return  _iCDCode; }
			set { _iCDCode = value; }
		}


		#endregion
}
}
