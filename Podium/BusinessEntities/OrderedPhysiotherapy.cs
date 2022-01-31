using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class OrderedPhysiotherapy
	{
		#region Fields

		private long procedureID=0;
		private string procedureName=String.Empty;
		private decimal odreredQty=Decimal.Zero;
		private string status=String.Empty;
		private string paymentStatus=String.Empty;
		private long patientID=0;
		private long visitID=0;
		private int orgAddID=0;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long perphyID=0;
		private string perphyname=String.Empty;
		private string performerType=String.Empty;
		private long taskID=0;
		private long physicianID=0;
		private string type=String.Empty;
		private long iD=0;
		private int orderedPhysioID=0;
		private long orderTaskID=0;
		private long patientVisitAttribID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ProcedureID value.
		/// </summary>
		public long ProcedureID
		{
			get { return procedureID; }
			set { procedureID = value; }
		}

		/// <summary>
		/// Gets or sets the ProcedureName value.
		/// </summary>
		public string ProcedureName
		{
			get { return procedureName; }
			set { procedureName = value; }
		}

		/// <summary>
		/// Gets or sets the OdreredQty value.
		/// </summary>
		public decimal OdreredQty
		{
			get { return odreredQty; }
			set { odreredQty = value; }
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
		/// Gets or sets the PaymentStatus value.
		/// </summary>
		public string PaymentStatus
		{
			get { return paymentStatus; }
			set { paymentStatus = value; }
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
		/// Gets or sets the OrgAddID value.
		/// </summary>
		public int OrgAddID
		{
			get { return orgAddID; }
			set { orgAddID = value; }
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
		/// Gets or sets the PerphyID value.
		/// </summary>
		public long PerphyID
		{
			get { return perphyID; }
			set { perphyID = value; }
		}

		/// <summary>
		/// Gets or sets the Perphyname value.
		/// </summary>
		public string Perphyname
		{
			get { return perphyname; }
			set { perphyname = value; }
		}

		/// <summary>
		/// Gets or sets the PerformerType value.
		/// </summary>
		public string PerformerType
		{
			get { return performerType; }
			set { performerType = value; }
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
		/// Gets or sets the PhysicianID value.
		/// </summary>
		public long PhysicianID
		{
			get { return physicianID; }
			set { physicianID = value; }
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
		/// Gets or sets the ID value.
		/// </summary>
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the OrderedPhysioID value.
		/// </summary>
		public int OrderedPhysioID
		{
			get { return orderedPhysioID; }
			set { orderedPhysioID = value; }
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
		/// Gets or sets the PatientVisitAttribID value.
		/// </summary>
		public long PatientVisitAttribID
		{
			get { return patientVisitAttribID; }
			set { patientVisitAttribID = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianComments value.
		/// </summary>
		private string _physicianComments=String.Empty;
		public string PhysicianComments
		{
			get { return  _physicianComments; }
			set { _physicianComments = value; }
		}

		/// <summary>
		/// Gets or sets the ProcedureType value.
		/// </summary>
		private string _procedureType=String.Empty;
		public string ProcedureType
		{
			get { return  _procedureType; }
			set { _procedureType = value; }
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

		/// <summary>
		/// Gets or sets the NoofSittings value.
		/// </summary>
		private int _noofSittings=0;
		public int NoofSittings
		{
			get { return  _noofSittings; }
			set { _noofSittings = value; }
		}


		#endregion
}
}
