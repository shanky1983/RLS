using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class EmployeeRegMaster
	{
		#region Fields

		private long empID=0;
		private string employeeNumber=String.Empty;
		private string name=String.Empty;
		private string sex=String.Empty;
		private string marital=String.Empty;
		private string address=String.Empty;
		private string city=String.Empty;
		private string mobileNo=String.Empty;
		private string landlineNo=String.Empty;
		private string country=String.Empty;
		private string state=String.Empty;
		private string bloodGroup=String.Empty;
		private DateTime dOB=DateTime.MaxValue;
		private DateTime dOJ=DateTime.MaxValue;
		private DateTime dOR=DateTime.MaxValue;
		private long employerID=0;
		private long patientID=0;
		private long mgrID=0;
		private long deptID=0;
		private long designationID=0;
		private long employementTypeID=0;
		private long gradeID=0;
		private string employementTypeNumber=String.Empty;
		private string qualification=String.Empty;
		private long employerLocationID=0;
		private long orgID=0;
		private string isActive=String.Empty;
		private string isAlive=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string status=String.Empty;
		private string fileNo=String.Empty;
		private long zoneID=0;
		private string eMail=String.Empty;
		private decimal discountLimit=Decimal.Zero;
		private string discountPeriod=String.Empty;
		private DateTime discountValidFrom=DateTime.MaxValue;
		private DateTime discountValidTo=DateTime.MaxValue;
		private long refID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the EmpID value.
		/// </summary>
		public long EmpID
		{
			get { return empID; }
			set { empID = value; }
		}

		/// <summary>
		/// Gets or sets the EmployeeNumber value.
		/// </summary>
		public string EmployeeNumber
		{
			get { return employeeNumber; }
			set { employeeNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Gets or sets the Sex value.
		/// </summary>
		public string Sex
		{
			get { return sex; }
			set { sex = value; }
		}

		/// <summary>
		/// Gets or sets the Marital value.
		/// </summary>
		public string Marital
		{
			get { return marital; }
			set { marital = value; }
		}

		/// <summary>
		/// Gets or sets the Address value.
		/// </summary>
		public string Address
		{
			get { return address; }
			set { address = value; }
		}

		/// <summary>
		/// Gets or sets the City value.
		/// </summary>
		public string City
		{
			get { return city; }
			set { city = value; }
		}

		/// <summary>
		/// Gets or sets the MobileNo value.
		/// </summary>
		public string MobileNo
		{
			get { return mobileNo; }
			set { mobileNo = value; }
		}

		/// <summary>
		/// Gets or sets the LandlineNo value.
		/// </summary>
		public string LandlineNo
		{
			get { return landlineNo; }
			set { landlineNo = value; }
		}

		/// <summary>
		/// Gets or sets the Country value.
		/// </summary>
		public string Country
		{
			get { return country; }
			set { country = value; }
		}

		/// <summary>
		/// Gets or sets the State value.
		/// </summary>
		public string State
		{
			get { return state; }
			set { state = value; }
		}

		/// <summary>
		/// Gets or sets the BloodGroup value.
		/// </summary>
		public string BloodGroup
		{
			get { return bloodGroup; }
			set { bloodGroup = value; }
		}

		/// <summary>
		/// Gets or sets the DOB value.
		/// </summary>
		public DateTime DOB
		{
			get { return dOB; }
			set { dOB = value; }
		}

		/// <summary>
		/// Gets or sets the DOJ value.
		/// </summary>
		public DateTime DOJ
		{
			get { return dOJ; }
			set { dOJ = value; }
		}

		/// <summary>
		/// Gets or sets the DOR value.
		/// </summary>
		public DateTime DOR
		{
			get { return dOR; }
			set { dOR = value; }
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
		/// Gets or sets the PatientID value.
		/// </summary>
		public long PatientID
		{
			get { return patientID; }
			set { patientID = value; }
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
		/// Gets or sets the GradeID value.
		/// </summary>
		public long GradeID
		{
			get { return gradeID; }
			set { gradeID = value; }
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
		/// Gets or sets the Qualification value.
		/// </summary>
		public string Qualification
		{
			get { return qualification; }
			set { qualification = value; }
		}

		/// <summary>
		/// Gets or sets the EmployerLocationID value.
		/// </summary>
		public long EmployerLocationID
		{
			get { return employerLocationID; }
			set { employerLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public string IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		/// <summary>
		/// Gets or sets the IsAlive value.
		/// </summary>
		public string IsAlive
		{
			get { return isAlive; }
			set { isAlive = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the FileNo value.
		/// </summary>
		public string FileNo
		{
			get { return fileNo; }
			set { fileNo = value; }
		}

		/// <summary>
		/// Gets or sets the ZoneID value.
		/// </summary>
		public long ZoneID
		{
			get { return zoneID; }
			set { zoneID = value; }
		}

		/// <summary>
		/// Gets or sets the EMail value.
		/// </summary>
		public string EMail
		{
			get { return eMail; }
			set { eMail = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountLimit value.
		/// </summary>
		public decimal DiscountLimit
		{
			get { return discountLimit; }
			set { discountLimit = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountPeriod value.
		/// </summary>
		public string DiscountPeriod
		{
			get { return discountPeriod; }
			set { discountPeriod = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountValidFrom value.
		/// </summary>
		public DateTime DiscountValidFrom
		{
			get { return discountValidFrom; }
			set { discountValidFrom = value; }
		}

		/// <summary>
		/// Gets or sets the DiscountValidTo value.
		/// </summary>
		public DateTime DiscountValidTo
		{
			get { return discountValidTo; }
			set { discountValidTo = value; }
		}

		/// <summary>
		/// Gets or sets the RefID value.
		/// </summary>
		public long RefID
		{
			get { return refID; }
			set { refID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientNumber value.
		/// </summary>
		private long _patientNumber=0;
		public long PatientNumber
		{
			get { return  _patientNumber; }
			set { _patientNumber = value; }
		}

		/// <summary>
		/// Gets or sets the EmpDeptName value.
		/// </summary>
		private string _empDeptName=String.Empty;
		public string EmpDeptName
		{
			get { return  _empDeptName; }
			set { _empDeptName = value; }
		}

		/// <summary>
		/// Gets or sets the GradeName value.
		/// </summary>
		private string _gradeName=String.Empty;
		public string GradeName
		{
			get { return  _gradeName; }
			set { _gradeName = value; }
		}

		/// <summary>
		/// Gets or sets the DesignationName value.
		/// </summary>
		private string _designationName=String.Empty;
		public string DesignationName
		{
			get { return  _designationName; }
			set { _designationName = value; }
		}

		/// <summary>
		/// Gets or sets the EmployerName value.
		/// </summary>
		private string _employerName=String.Empty;
		public string EmployerName
		{
			get { return  _employerName; }
			set { _employerName = value; }
		}

		/// <summary>
		/// Gets or sets the EmployerLocationName value.
		/// </summary>
		private string _employerLocationName=String.Empty;
		public string EmployerLocationName
		{
			get { return  _employerLocationName; }
			set { _employerLocationName = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		private string _type=String.Empty;
		public string Type
		{
			get { return  _type; }
			set { _type = value; }
		}

		/// <summary>
		/// Gets or sets the ZoneName value.
		/// </summary>
		private string _zoneName=String.Empty;
		public string ZoneName
		{
			get { return  _zoneName; }
			set { _zoneName = value; }
		}

		/// <summary>
		/// Gets or sets the LoginName value.
		/// </summary>
		private string _loginName=String.Empty;
		public string LoginName
		{
			get { return  _loginName; }
			set { _loginName = value; }
		}

		/// <summary>
		/// Gets or sets the LoginID value.
		/// </summary>
		private long _loginID=0;
		public long LoginID
		{
			get { return  _loginID; }
			set { _loginID = value; }
		}


		#endregion
}
}
