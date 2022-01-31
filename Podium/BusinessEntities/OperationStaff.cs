using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class OperationStaff
	{
		#region Fields

		private long operationStaffID=0;
		private long operationID=0;
		private string staffType=String.Empty;
		private long staffID=0;
		private int orgID=0;
		private long patientVistID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OperationStaffID value.
		/// </summary>
		public long OperationStaffID
		{
			get { return operationStaffID; }
			set { operationStaffID = value; }
		}

		/// <summary>
		/// Gets or sets the OperationID value.
		/// </summary>
		public long OperationID
		{
			get { return operationID; }
			set { operationID = value; }
		}

		/// <summary>
		/// Gets or sets the StaffType value.
		/// </summary>
		public string StaffType
		{
			get { return staffType; }
			set { staffType = value; }
		}

		/// <summary>
		/// Gets or sets the StaffID value.
		/// </summary>
		public long StaffID
		{
			get { return staffID; }
			set { staffID = value; }
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
		/// Gets or sets the PhysicianName value.
		/// </summary>
		private string _physicianName=String.Empty;
		public string PhysicianName
		{
			get { return  _physicianName; }
			set { _physicianName = value; }
		}


		#endregion
}
}
