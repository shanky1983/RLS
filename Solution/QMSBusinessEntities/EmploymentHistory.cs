using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class EmploymentHistory
	{
		#region Fields

		private long empHistoryID=0;
		private long empID=0;
		private long patientID=0;
		private DateTime startDate=DateTime.MaxValue;
		private DateTime endDate=DateTime.MaxValue;
		private long employerID=0;
		private long mgrID=0;
		private long deptID=0;
		private long designationID=0;
		private long employementTypeID=0;
		private string employementTypeNumber=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string fileNo=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the EmpHistoryID value.
		/// </summary>
		public long EmpHistoryID
		{
			get { return empHistoryID; }
			set { empHistoryID = value; }
		}

		/// <summary>
		/// Gets or sets the EmpID value.
		/// </summary>
		public long EmpID
		{
			get { return empID; }
			set { empID = value; }
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
		/// Gets or sets the EmployerID value.
		/// </summary>
		public long EmployerID
		{
			get { return employerID; }
			set { employerID = value; }
		}

		/// <summary>
		/// Gets or sets the MgrID value.
		/// </summary>
		public long MgrID
		{
			get { return mgrID; }
			set { mgrID = value; }
		}

		/// <summary>
		/// Gets or sets the DeptID value.
		/// </summary>
		public long DeptID
		{
			get { return deptID; }
			set { deptID = value; }
		}

		/// <summary>
		/// Gets or sets the DesignationID value.
		/// </summary>
		public long DesignationID
		{
			get { return designationID; }
			set { designationID = value; }
		}

		/// <summary>
		/// Gets or sets the EmployementTypeID value.
		/// </summary>
		public long EmployementTypeID
		{
			get { return employementTypeID; }
			set { employementTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the EmployementTypeNumber value.
		/// </summary>
		public string EmployementTypeNumber
		{
			get { return employementTypeNumber; }
			set { employementTypeNumber = value; }
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
		/// Gets or sets the FileNo value.
		/// </summary>
		public string FileNo
		{
			get { return fileNo; }
			set { fileNo = value; }
		}


		#endregion
}
}
