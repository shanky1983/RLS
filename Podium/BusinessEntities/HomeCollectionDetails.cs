using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class HomeCollectionDetails
	{
		#region Fields

		private long homeCollectionDetailsID=0;
		private long patientID=0;
		private int orgID=0;
		private long orgAddressID=0;
		private int createdOrgID=0;
		private long patientVisitId=0;
		private long roleID=0;
		private long userID=0;
		private string collectionAddress=String.Empty;
		private DateTime collectionTime=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private string status=String.Empty;
		private string patientNumber=String.Empty;
		private string name=String.Empty;
		private string age=String.Empty;
		private string sex=String.Empty;
		private string add2=String.Empty;
		private string city=String.Empty;
		private string mobileNumber=String.Empty;
		private string bookingNumber=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the HomeCollectionDetailsID value.
		/// </summary>
		public long HomeCollectionDetailsID
		{
			get { return homeCollectionDetailsID; }
			set { homeCollectionDetailsID = value; }
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
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public long OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedOrgID value.
		/// </summary>
		public int CreatedOrgID
		{
			get { return createdOrgID; }
			set { createdOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVisitId value.
		/// </summary>
		public long PatientVisitId
		{
			get { return patientVisitId; }
			set { patientVisitId = value; }
		}

		/// <summary>
		/// Gets or sets the RoleID value.
		/// </summary>
		public long RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}

		/// <summary>
		/// Gets or sets the UserID value.
		/// </summary>
		public long UserID
		{
			get { return userID; }
			set { userID = value; }
		}

		/// <summary>
		/// Gets or sets the CollectionAddress value.
		/// </summary>
		public string CollectionAddress
		{
			get { return collectionAddress; }
			set { collectionAddress = value; }
		}

		/// <summary>
		/// Gets or sets the CollectionTime value.
		/// </summary>
		public DateTime CollectionTime
		{
			get { return collectionTime; }
			set { collectionTime = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the PatientNumber value.
		/// </summary>
		public string PatientNumber
		{
			get { return patientNumber; }
			set { patientNumber = value; }
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
		/// Gets or sets the Age value.
		/// </summary>
		public string Age
		{
			get { return age; }
			set { age = value; }
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
		/// Gets or sets the Add2 value.
		/// </summary>
		public string Add2
		{
			get { return add2; }
			set { add2 = value; }
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
		/// Gets or sets the MobileNumber value.
		/// </summary>
		public string MobileNumber
		{
			get { return mobileNumber; }
			set { mobileNumber = value; }
		}

		/// <summary>
		/// Gets or sets the BookingNumber value.
		/// </summary>
		public string BookingNumber
		{
			get { return bookingNumber; }
			set { bookingNumber = value; }
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
		/// Gets or sets the UserName value.
		/// </summary>
		private string _userName=String.Empty;
		public string UserName
		{
			get { return  _userName; }
			set { _userName = value; }
		}


		#endregion
}
}
