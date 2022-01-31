using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
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
		private string photoPath=String.Empty;
		private string photoName=String.Empty;
		private long designationID=0;
		private string pAN=String.Empty;

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
		/// Gets or sets the PhotoPath value.
		/// </summary>
		public string PhotoPath
		{
			get { return photoPath; }
			set { photoPath = value; }
		}

		/// <summary>
		/// Gets or sets the PhotoName value.
		/// </summary>
		public string PhotoName
		{
			get { return photoName; }
			set { photoName = value; }
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
		/// Gets or sets the PAN value.
		/// </summary>
		public string PAN
		{
			get { return pAN; }
			set { pAN = value; }
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
		private string _roleName=String.Empty;
		public string RoleName
		{
			get { return  _roleName; }
			set { _roleName = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		private long _roleID=0;
		public long RoleID
		{
			get { return  _roleID; }
			set { _roleID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgUserID value.
		/// </summary>
		private long _orgUserID=0;
		public long OrgUserID
		{
			get { return  _orgUserID; }
			set { _orgUserID = value; }
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
		/// Gets or sets the IsLocked value.
		/// </summary>
		private string _isLocked=String.Empty;
		public string IsLocked
		{
			get { return  _isLocked; }
			set { _isLocked = value; }
		}

		/// <summary>
		/// Gets or sets the EndDTTM value.
		/// </summary>
		private DateTime _endDTTM=DateTime.MaxValue;
		public DateTime EndDTTM
		{
			get { return  _endDTTM; }
			set { _endDTTM = value; }
		}

		/// <summary>
		/// Gets or sets the BlockReason value.
		/// </summary>
		private string _blockReason=String.Empty;
		public string BlockReason
		{
			get { return  _blockReason; }
			set { _blockReason = value; }
		}

		/// <summary>
		/// Gets or sets the BlockedFrom value.
		/// </summary>
		private DateTime _blockedFrom=DateTime.MaxValue;
		public DateTime BlockedFrom
		{
			get { return  _blockedFrom; }
			set { _blockedFrom = value; }
		}

		/// <summary>
		/// Gets or sets the BlockedTo value.
		/// </summary>
		private DateTime _blockedTo=DateTime.MaxValue;
		public DateTime BlockedTo
		{
			get { return  _blockedTo; }
			set { _blockedTo = value; }
		}


		#endregion
}
}
