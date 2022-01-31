using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Physician_HIST
	{
		#region Fields

		private long physician_HISTID=0;
		private long physicianID=0;
		private string physicianName=String.Empty;
		private string email=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string physicianType=String.Empty;
		private string sex=String.Empty;
		private long loginID=0;
		private DateTime weddingDt=DateTime.MaxValue;
		private string titleCode=String.Empty;
		private DateTime dOB=DateTime.MaxValue;
		private string relegion=String.Empty;
		private string maritalStatus=String.Empty;
		private string qualification=String.Empty;
		private int orgID=0;
		private string status=String.Empty;
		private string regNumber=String.Empty;
		private string physicianCode=String.Empty;
		private long createdRole=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Physician_HISTID value.
		/// </summary>
		public long Physician_HISTID
		{
			get { return physician_HISTID; }
			set { physician_HISTID = value; }
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
		/// Gets or sets the PhysicianName value.
		/// </summary>
		public string PhysicianName
		{
			get { return physicianName; }
			set { physicianName = value; }
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
		/// Gets or sets the PhysicianType value.
		/// </summary>
		public string PhysicianType
		{
			get { return physicianType; }
			set { physicianType = value; }
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
		/// Gets or sets the TitleCode value.
		/// </summary>
		public string TitleCode
		{
			get { return titleCode; }
			set { titleCode = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the RegNumber value.
		/// </summary>
		public string RegNumber
		{
			get { return regNumber; }
			set { regNumber = value; }
		}

		/// <summary>
		/// Gets or sets the PhysicianCode value.
		/// </summary>
		public string PhysicianCode
		{
			get { return physicianCode; }
			set { physicianCode = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedRole value.
		/// </summary>
		public long CreatedRole
		{
			get { return createdRole; }
			set { createdRole = value; }
		}


		#endregion
}
}
