using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientEmployer_HIST
	{
		#region Fields

		private long patientEmployerID_HISTID=0;
		private long patientEmployerID=0;
		private long patientID=0;
		private string employerName=String.Empty;
		private string add1=String.Empty;
		private string add2=String.Empty;
		private string add3=String.Empty;
		private string postalCode=String.Empty;
		private short countryID=0;
		private string city=String.Empty;
		private short stateID=0;
		private string mobileNumber=String.Empty;
		private string landLineNumber=String.Empty;
		private DateTime startDTTM=DateTime.MaxValue;
		private DateTime endDTTM=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string employeeName=String.Empty;
		private string employeeNo=String.Empty;
		private long visitID=0;
		private string otherCountryName=String.Empty;
		private string otherStateName=String.Empty;
		private long createdRole=0;
		private int cityCode=0;
		private int addLevel1=0;
		private int addLevel2=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientEmployerID_HISTID value.
		/// </summary>
		public long PatientEmployerID_HISTID
		{
			get { return patientEmployerID_HISTID; }
			set { patientEmployerID_HISTID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientEmployerID value.
		/// </summary>
		public long PatientEmployerID
		{
			get { return patientEmployerID; }
			set { patientEmployerID = value; }
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
		/// Gets or sets the EmployerName value.
		/// </summary>
		public string EmployerName
		{
			get { return employerName; }
			set { employerName = value; }
		}

		/// <summary>
		/// Gets or sets the Add1 value.
		/// </summary>
		public string Add1
		{
			get { return add1; }
			set { add1 = value; }
		}

		/// <summary>
		/// Gets or sets the Add2 value.
		/// </summary>
		public string Add2
		{
			get { return add2; }
			set { add2 = value; }
		}

		/// <summary>
		/// Gets or sets the Add3 value.
		/// </summary>
		public string Add3
		{
			get { return add3; }
			set { add3 = value; }
		}

		/// <summary>
		/// Gets or sets the PostalCode value.
		/// </summary>
		public string PostalCode
		{
			get { return postalCode; }
			set { postalCode = value; }
		}

		/// <summary>
		/// Gets or sets the CountryID value.
		/// </summary>
		public short CountryID
		{
			get { return countryID; }
			set { countryID = value; }
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
		/// Gets or sets the StateID value.
		/// </summary>
		public short StateID
		{
			get { return stateID; }
			set { stateID = value; }
		}

		/// <summary>
		/// Gets or sets the MobileNumber value.
		/// </summary>
		public string MobileNumber
		{
			get { return mobileNumber; }
			set { mobileNumber = value; }
		}

		/// <summary>
		/// Gets or sets the LandLineNumber value.
		/// </summary>
		public string LandLineNumber
		{
			get { return landLineNumber; }
			set { landLineNumber = value; }
		}

		/// <summary>
		/// Gets or sets the StartDTTM value.
		/// </summary>
		public DateTime StartDTTM
		{
			get { return startDTTM; }
			set { startDTTM = value; }
		}

		/// <summary>
		/// Gets or sets the EndDTTM value.
		/// </summary>
		public DateTime EndDTTM
		{
			get { return endDTTM; }
			set { endDTTM = value; }
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
		/// Gets or sets the EmployeeName value.
		/// </summary>
		public string EmployeeName
		{
			get { return employeeName; }
			set { employeeName = value; }
		}

		/// <summary>
		/// Gets or sets the EmployeeNo value.
		/// </summary>
		public string EmployeeNo
		{
			get { return employeeNo; }
			set { employeeNo = value; }
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
		/// Gets or sets the OtherCountryName value.
		/// </summary>
		public string OtherCountryName
		{
			get { return otherCountryName; }
			set { otherCountryName = value; }
		}

		/// <summary>
		/// Gets or sets the OtherStateName value.
		/// </summary>
		public string OtherStateName
		{
			get { return otherStateName; }
			set { otherStateName = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedRole value.
		/// </summary>
		public long CreatedRole
		{
			get { return createdRole; }
			set { createdRole = value; }
		}

		/// <summary>
		/// Gets or sets the CityCode value.
		/// </summary>
		public int CityCode
		{
			get { return cityCode; }
			set { cityCode = value; }
		}

		/// <summary>
		/// Gets or sets the AddLevel1 value.
		/// </summary>
		public int AddLevel1
		{
			get { return addLevel1; }
			set { addLevel1 = value; }
		}

		/// <summary>
		/// Gets or sets the AddLevel2 value.
		/// </summary>
		public int AddLevel2
		{
			get { return addLevel2; }
			set { addLevel2 = value; }
		}


		#endregion
}
}
