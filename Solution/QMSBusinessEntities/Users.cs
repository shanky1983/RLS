using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Users
	{
		#region Fields

		private long userID=0;
		private string name=String.Empty;
		private string sURNAME=String.Empty;
		private DateTime dOB=DateTime.MaxValue;
		private string sEX=String.Empty;
		private int addressID=0;
		private string email=String.Empty;
		private string titleCode=String.Empty;
		private string status=String.Empty;
		private string placeOfBirth=String.Empty;
		private string relegion=String.Empty;
		private string maritalStatus=String.Empty;
		private string qualification=String.Empty;
		private int orgID=0;
		private string remarks=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long loginID=0;
		private DateTime weddingDt=DateTime.MaxValue;
		private string fORENAME=String.Empty;
		private long empID=0;
		private string trans_USER_CODE=String.Empty;
		private string trans_Emp_CODE=String.Empty;
		private string actionType=String.Empty;
		private decimal dailySalary=Decimal.Zero;
		private decimal monthlySalary=Decimal.Zero;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the UserID value.
		/// </summary>
		public long UserID
		{
			get { return userID; }
			set { userID = value; }
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
		/// Gets or sets the SURNAME value.
		/// </summary>
		public string SURNAME
		{
			get { return sURNAME; }
			set { sURNAME = value; }
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
		/// Gets or sets the SEX value.
		/// </summary>
		public string SEX
		{
			get { return sEX; }
			set { sEX = value; }
		}

		/// <summary>
		/// Gets or sets the AddressID value.
		/// </summary>
		public int AddressID
		{
			get { return addressID; }
			set { addressID = value; }
		}

		/// <summary>
		/// Gets or sets the Email value.
		/// </summary>
		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		/// <summary>
		/// Gets or sets the TitleCode value.
		/// </summary>
		public string TitleCode
		{
			get { return titleCode; }
			set { titleCode = value; }
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
		/// Gets or sets the PlaceOfBirth value.
		/// </summary>
		public string PlaceOfBirth
		{
			get { return placeOfBirth; }
			set { placeOfBirth = value; }
		}

		/// <summary>
		/// Gets or sets the Relegion value.
		/// </summary>
		public string Relegion
		{
			get { return relegion; }
			set { relegion = value; }
		}

		/// <summary>
		/// Gets or sets the MaritalStatus value.
		/// </summary>
		public string MaritalStatus
		{
			get { return maritalStatus; }
			set { maritalStatus = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the Remarks value.
		/// </summary>
		public string Remarks
		{
			get { return remarks; }
			set { remarks = value; }
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
		/// Gets or sets the LoginID value.
		/// </summary>
		public long LoginID
		{
			get { return loginID; }
			set { loginID = value; }
		}

		/// <summary>
		/// Gets or sets the WeddingDt value.
		/// </summary>
		public DateTime WeddingDt
		{
			get { return weddingDt; }
			set { weddingDt = value; }
		}

		/// <summary>
		/// Gets or sets the FORENAME value.
		/// </summary>
		public string FORENAME
		{
			get { return fORENAME; }
			set { fORENAME = value; }
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
		/// Gets or sets the Trans_USER_CODE value.
		/// </summary>
		public string Trans_USER_CODE
		{
			get { return trans_USER_CODE; }
			set { trans_USER_CODE = value; }
		}

		/// <summary>
		/// Gets or sets the Trans_Emp_CODE value.
		/// </summary>
		public string Trans_Emp_CODE
		{
			get { return trans_Emp_CODE; }
			set { trans_Emp_CODE = value; }
		}

		/// <summary>
		/// Gets or sets the ActionType value.
		/// </summary>
		public string ActionType
		{
			get { return actionType; }
			set { actionType = value; }
		}

		/// <summary>
		/// Gets or sets the DailySalary value.
		/// </summary>
		public decimal DailySalary
		{
			get { return dailySalary; }
			set { dailySalary = value; }
		}

		/// <summary>
		/// Gets or sets the MonthlySalary value.
		/// </summary>
		public decimal MonthlySalary
		{
			get { return monthlySalary; }
			set { monthlySalary = value; }
		}

		/// <summary>
		/// Gets or sets the Address value.
		/// </summary>
		List<UserAddress> _address;
		public List<UserAddress> Address
		{
			get { return _address; }
			set { _address = value; }
		}

		/// <summary>
		/// Gets or sets the RoleName value.
		/// </summary>
		string _rolename;
		public string RoleName
		{
			get { return _rolename; }
			set { _rolename = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		long _roleid;
		public long RoleID
		{
			get { return _roleid; }
			set { _roleid = value; }
		}

		/// <summary>
		/// Gets or sets the OrgUserID value.
		/// </summary>
		long _orguserid;
		public long OrgUserID
		{
			get { return _orguserid; }
			set { _orguserid = value; }
		}

		/// <summary>
		/// Gets or sets the LoginName value.
		/// </summary>
		string _loginname;
		public string LoginName
		{
			get { return _loginname; }
			set { _loginname = value; }
		}

		/// <summary>
		/// Gets or sets the IsLocked value.
		/// </summary>
		string _islocked;
		public string IsLocked
		{
			get { return _islocked; }
			set { _islocked = value; }
		}

		/// <summary>
		/// Gets or sets the EndDTTM value.
		/// </summary>
		DateTime _enddttm;
		public DateTime EndDTTM
		{
			get { return _enddttm; }
			set { _enddttm = value; }
		}

		/// <summary>
		/// Gets or sets the BlockReason value.
		/// </summary>
		string _blockreason;
		public string BlockReason
		{
			get { return _blockreason; }
			set { _blockreason = value; }
		}

		/// <summary>
		/// Gets or sets the BlockedFrom value.
		/// </summary>
		DateTime _blockedfrom;
		public DateTime BlockedFrom
		{
			get { return _blockedfrom; }
			set { _blockedfrom = value; }
		}

		/// <summary>
		/// Gets or sets the BlockedTo value.
		/// </summary>
		DateTime _blockedto;
		public DateTime BlockedTo
		{
			get { return _blockedto; }
			set { _blockedto = value; }
		}


		#endregion
}
}
