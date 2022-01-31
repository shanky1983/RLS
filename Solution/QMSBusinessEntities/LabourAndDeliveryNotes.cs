using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class LabourAndDeliveryNotes
	{
		#region Fields

		private long birthRegID=0;
		private long patientID=0;
		private long visitID=0;
		private string husbandName=String.Empty;
		private int typeOfLabour=0;
		private int modeOfDelivery=0;
		private int deliveryAssistance=0;
		private int procedureTypeID=0;
		private int generationType=0;
		private string labourTmax=String.Empty;
		private string rOMLength=String.Empty;
		private string deliveryTerm=String.Empty;
		private long deliveringObstreticianID=0;
		private long neonatologistID=0;
		private string deliveryNotes=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int anesthesiaTypeID=0;
		private int typeid=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BirthRegID value.
		/// </summary>
		public long BirthRegID
		{
			get { return birthRegID; }
			set { birthRegID = value; }
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
		/// Gets or sets the VisitID value.
		/// </summary>
		public long VisitID
		{
			get { return visitID; }
			set { visitID = value; }
		}

		/// <summary>
		/// Gets or sets the HusbandName value.
		/// </summary>
		public string HusbandName
		{
			get { return husbandName; }
			set { husbandName = value; }
		}

		/// <summary>
		/// Gets or sets the TypeOfLabour value.
		/// </summary>
		public int TypeOfLabour
		{
			get { return typeOfLabour; }
			set { typeOfLabour = value; }
		}

		/// <summary>
		/// Gets or sets the ModeOfDelivery value.
		/// </summary>
		public int ModeOfDelivery
		{
			get { return modeOfDelivery; }
			set { modeOfDelivery = value; }
		}

		/// <summary>
		/// Gets or sets the DeliveryAssistance value.
		/// </summary>
		public int DeliveryAssistance
		{
			get { return deliveryAssistance; }
			set { deliveryAssistance = value; }
		}

		/// <summary>
		/// Gets or sets the ProcedureTypeID value.
		/// </summary>
		public int ProcedureTypeID
		{
			get { return procedureTypeID; }
			set { procedureTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the GenerationType value.
		/// </summary>
		public int GenerationType
		{
			get { return generationType; }
			set { generationType = value; }
		}

		/// <summary>
		/// Gets or sets the LabourTmax value.
		/// </summary>
		public string LabourTmax
		{
			get { return labourTmax; }
			set { labourTmax = value; }
		}

		/// <summary>
		/// Gets or sets the ROMLength value.
		/// </summary>
		public string ROMLength
		{
			get { return rOMLength; }
			set { rOMLength = value; }
		}

		/// <summary>
		/// Gets or sets the DeliveryTerm value.
		/// </summary>
		public string DeliveryTerm
		{
			get { return deliveryTerm; }
			set { deliveryTerm = value; }
		}

		/// <summary>
		/// Gets or sets the DeliveringObstreticianID value.
		/// </summary>
		public long DeliveringObstreticianID
		{
			get { return deliveringObstreticianID; }
			set { deliveringObstreticianID = value; }
		}

		/// <summary>
		/// Gets or sets the NeonatologistID value.
		/// </summary>
		public long NeonatologistID
		{
			get { return neonatologistID; }
			set { neonatologistID = value; }
		}

		/// <summary>
		/// Gets or sets the DeliveryNotes value.
		/// </summary>
		public string DeliveryNotes
		{
			get { return deliveryNotes; }
			set { deliveryNotes = value; }
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
		/// Gets or sets the AnesthesiaTypeID value.
		/// </summary>
		public int AnesthesiaTypeID
		{
			get { return anesthesiaTypeID; }
			set { anesthesiaTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the Typeid value.
		/// </summary>
		public int Typeid
		{
			get { return typeid; }
			set { typeid = value; }
		}

		/// <summary>
		/// Gets or sets the TypeOfLabourName value.
		/// </summary>
		string _typeoflabourname;
		public string TypeOfLabourName
		{
			get { return _typeoflabourname; }
			set { _typeoflabourname = value; }
		}

		/// <summary>
		/// Gets or sets the ModeOfDeliveryName value.
		/// </summary>
		string _modeofdeliveryname;
		public string ModeOfDeliveryName
		{
			get { return _modeofdeliveryname; }
			set { _modeofdeliveryname = value; }
		}

		/// <summary>
		/// Gets or sets the DeliveryAssistanceName value.
		/// </summary>
		string _deliveryassistancename;
		public string DeliveryAssistanceName
		{
			get { return _deliveryassistancename; }
			set { _deliveryassistancename = value; }
		}

		/// <summary>
		/// Gets or sets the ProcedureType value.
		/// </summary>
		string _proceduretype;
		public string ProcedureType
		{
			get { return _proceduretype; }
			set { _proceduretype = value; }
		}


		#endregion
}
}
