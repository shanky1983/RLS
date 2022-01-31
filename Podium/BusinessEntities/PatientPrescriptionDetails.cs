using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientPrescriptionDetails
	{
		#region Fields

		private long patientVisitID=0;
		private long drugID=0;
		private string brandName=String.Empty;
		private string dose=String.Empty;
		private string formulation=String.Empty;
		private string rOA=String.Empty;
		private string drugFrequency=String.Empty;
		private string duration=String.Empty;
		private int complaintId=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private DateTime administeredAtFrom=DateTime.MaxValue;
		private string instruction=String.Empty;
		private long prescriptionID=0;
		private string drugStatus=String.Empty;
		private DateTime administeredAtTo=DateTime.MaxValue;
		private string drugSource=String.Empty;
		private string prescriptionType=String.Empty;
		private decimal issuedQty=Decimal.Zero;
		private string status=String.Empty;
		private decimal totalQty=Decimal.Zero;
		private long taskID=0;
		private string prescriptionNumber=String.Empty;
		private long physicianID=0;
		private DateTime prescriptionValidityDate=DateTime.MaxValue;
		private string direction=String.Empty;
		private decimal returnQuantity=Decimal.Zero;
		private string migrated_Patient_Number=String.Empty;
		private string migrated_Visit_Number=String.Empty;
		private string migrated_Drug_Code=String.Empty;
		private string migrated_Batch_Code=String.Empty;
		private decimal migrated_Price_Code=Decimal.Zero;
		private string isGeneric=String.Empty;
		private long issueDrugID=0;
		private string type=String.Empty;
		private long orderTaskID=0;
		private long patientPrescriptionID=0;
		private string comment=String.Empty;
		private int drugFrequencyID=0;
		private int drugInstructionID=0;
		private long prescriptionDrugMappingID=0;
		private long patientID=0;
		private int orgID=0;
		private DateTime startDate=DateTime.MaxValue;
		private DateTime endDate=DateTime.MaxValue;
		private bool sticky=false;
		private long prescriptionDetailID=0;
		private long pPrescriptionID=0;
		private string drugName=String.Empty;
		private long productID=0;

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
		/// Gets or sets the DrugID value.
		/// </summary>
		public long DrugID
		{
			get { return drugID; }
			set { drugID = value; }
		}

		/// <summary>
		/// Gets or sets the BrandName value.
		/// </summary>
		public string BrandName
		{
			get { return brandName; }
			set { brandName = value; }
		}

		/// <summary>
		/// Gets or sets the Dose value.
		/// </summary>
		public string Dose
		{
			get { return dose; }
			set { dose = value; }
		}

		/// <summary>
		/// Gets or sets the Formulation value.
		/// </summary>
		public string Formulation
		{
			get { return formulation; }
			set { formulation = value; }
		}

		/// <summary>
		/// Gets or sets the ROA value.
		/// </summary>
		public string ROA
		{
			get { return rOA; }
			set { rOA = value; }
		}

		/// <summary>
		/// Gets or sets the DrugFrequency value.
		/// </summary>
		public string DrugFrequency
		{
			get { return drugFrequency; }
			set { drugFrequency = value; }
		}

		/// <summary>
		/// Gets or sets the Duration value.
		/// </summary>
		public string Duration
		{
			get { return duration; }
			set { duration = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintId value.
		/// </summary>
		public int ComplaintId
		{
			get { return complaintId; }
			set { complaintId = value; }
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
		/// Gets or sets the AdministeredAtFrom value.
		/// </summary>
		public DateTime AdministeredAtFrom
		{
			get { return administeredAtFrom; }
			set { administeredAtFrom = value; }
		}

		/// <summary>
		/// Gets or sets the Instruction value.
		/// </summary>
		public string Instruction
		{
			get { return instruction; }
			set { instruction = value; }
		}

		/// <summary>
		/// Gets or sets the PrescriptionID value.
		/// </summary>
		public long PrescriptionID
		{
			get { return prescriptionID; }
			set { prescriptionID = value; }
		}

		/// <summary>
		/// Gets or sets the DrugStatus value.
		/// </summary>
		public string DrugStatus
		{
			get { return drugStatus; }
			set { drugStatus = value; }
		}

		/// <summary>
		/// Gets or sets the AdministeredAtTo value.
		/// </summary>
		public DateTime AdministeredAtTo
		{
			get { return administeredAtTo; }
			set { administeredAtTo = value; }
		}

		/// <summary>
		/// Gets or sets the DrugSource value.
		/// </summary>
		public string DrugSource
		{
			get { return drugSource; }
			set { drugSource = value; }
		}

		/// <summary>
		/// Gets or sets the PrescriptionType value.
		/// </summary>
		public string PrescriptionType
		{
			get { return prescriptionType; }
			set { prescriptionType = value; }
		}

		/// <summary>
		/// Gets or sets the IssuedQty value.
		/// </summary>
		public decimal IssuedQty
		{
			get { return issuedQty; }
			set { issuedQty = value; }
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
		/// Gets or sets the TotalQty value.
		/// </summary>
		public decimal TotalQty
		{
			get { return totalQty; }
			set { totalQty = value; }
		}

		/// <summary>
		/// Gets or sets the TaskID value.
		/// </summary>
		public long TaskID
		{
			get { return taskID; }
			set { taskID = value; }
		}

		/// <summary>
		/// Gets or sets the PrescriptionNumber value.
		/// </summary>
		public string PrescriptionNumber
		{
			get { return prescriptionNumber; }
			set { prescriptionNumber = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianID value.
		/// </summary>
		public long PhysicianID
		{
			get { return physicianID; }
			set { physicianID = value; }
		}

		/// <summary>
		/// Gets or sets the PrescriptionValidityDate value.
		/// </summary>
		public DateTime PrescriptionValidityDate
		{
			get { return prescriptionValidityDate; }
			set { prescriptionValidityDate = value; }
		}

		/// <summary>
		/// Gets or sets the Direction value.
		/// </summary>
		public string Direction
		{
			get { return direction; }
			set { direction = value; }
		}

		/// <summary>
		/// Gets or sets the ReturnQuantity value.
		/// </summary>
		public decimal ReturnQuantity
		{
			get { return returnQuantity; }
			set { returnQuantity = value; }
		}

		/// <summary>
		/// Gets or sets the Migrated_Patient_Number value.
		/// </summary>
		public string Migrated_Patient_Number
		{
			get { return migrated_Patient_Number; }
			set { migrated_Patient_Number = value; }
		}

		/// <summary>
		/// Gets or sets the Migrated_Visit_Number value.
		/// </summary>
		public string Migrated_Visit_Number
		{
			get { return migrated_Visit_Number; }
			set { migrated_Visit_Number = value; }
		}

		/// <summary>
		/// Gets or sets the Migrated_Drug_Code value.
		/// </summary>
		public string Migrated_Drug_Code
		{
			get { return migrated_Drug_Code; }
			set { migrated_Drug_Code = value; }
		}

		/// <summary>
		/// Gets or sets the Migrated_Batch_Code value.
		/// </summary>
		public string Migrated_Batch_Code
		{
			get { return migrated_Batch_Code; }
			set { migrated_Batch_Code = value; }
		}

		/// <summary>
		/// Gets or sets the Migrated_Price_Code value.
		/// </summary>
		public decimal Migrated_Price_Code
		{
			get { return migrated_Price_Code; }
			set { migrated_Price_Code = value; }
		}

		/// <summary>
		/// Gets or sets the IsGeneric value.
		/// </summary>
		public string IsGeneric
		{
			get { return isGeneric; }
			set { isGeneric = value; }
		}

		/// <summary>
		/// Gets or sets the IssueDrugID value.
		/// </summary>
		public long IssueDrugID
		{
			get { return issueDrugID; }
			set { issueDrugID = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the OrderTaskID value.
		/// </summary>
		public long OrderTaskID
		{
			get { return orderTaskID; }
			set { orderTaskID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientPrescriptionID value.
		/// </summary>
		public long PatientPrescriptionID
		{
			get { return patientPrescriptionID; }
			set { patientPrescriptionID = value; }
		}

		/// <summary>
		/// Gets or sets the Comment value.
		/// </summary>
		public string Comment
		{
			get { return comment; }
			set { comment = value; }
		}

		/// <summary>
		/// Gets or sets the DrugFrequencyID value.
		/// </summary>
		public int DrugFrequencyID
		{
			get { return drugFrequencyID; }
			set { drugFrequencyID = value; }
		}

		/// <summary>
		/// Gets or sets the DrugInstructionID value.
		/// </summary>
		public int DrugInstructionID
		{
			get { return drugInstructionID; }
			set { drugInstructionID = value; }
		}

		/// <summary>
		/// Gets or sets the PrescriptionDrugMappingID value.
		/// </summary>
		public long PrescriptionDrugMappingID
		{
			get { return prescriptionDrugMappingID; }
			set { prescriptionDrugMappingID = value; }
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
		/// Gets or sets the StartDate value.
		/// </summary>
		public DateTime StartDate
		{
			get { return startDate; }
			set { startDate = value; }
		}

		/// <summary>
		/// Gets or sets the EndDate value.
		/// </summary>
		public DateTime EndDate
		{
			get { return endDate; }
			set { endDate = value; }
		}

		/// <summary>
		/// Gets or sets the Sticky value.
		/// </summary>
		public bool Sticky
		{
			get { return sticky; }
			set { sticky = value; }
		}

		/// <summary>
		/// Gets or sets the PrescriptionDetailID value.
		/// </summary>
		public long PrescriptionDetailID
		{
			get { return prescriptionDetailID; }
			set { prescriptionDetailID = value; }
		}

		/// <summary>
		/// Gets or sets the PPrescriptionID value.
		/// </summary>
		public long PPrescriptionID
		{
			get { return pPrescriptionID; }
			set { pPrescriptionID = value; }
		}

		/// <summary>
		/// Gets or sets the DrugName value.
		/// </summary>
		public string DrugName
		{
			get { return drugName; }
			set { drugName = value; }
		}

		/// <summary>
		/// Gets or sets the ProductID value.
		/// </summary>
		public long ProductID
		{
			get { return productID; }
			set { productID = value; }
		}


		#endregion
}
}
