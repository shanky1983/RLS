using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Refer
	{
		#region Fields

		private int referingPhysicianID=0;
		private string physicianName=String.Empty;
		private string qualification=String.Empty;
		private string organizationName=String.Empty;
		private int orgID=0;
		private string status=String.Empty;
		private int salutation=0;
		private long loginID=0;
		private string physicianCode=String.Empty;
		private string isClient=String.Empty;
		private string isActive=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string gender=String.Empty;
		private string dOB=String.Empty;
		private string age=String.Empty;
		private string registrationType=String.Empty;
		private int parentReferingPhysicianID=0;
		private string isMerged=String.Empty;
		private decimal discountLimit=Decimal.Zero;
		private string discountPeriod=String.Empty;
		private DateTime discountValidFrom=DateTime.MaxValue;
		private DateTime discountValidTo=DateTime.MaxValue;
		private long refFeeCategoryid=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ReferingPhysicianID value.
		/// </summary>
		public int ReferingPhysicianID
		{
			get { return referingPhysicianID; }
			set { referingPhysicianID = value; }
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
		/// Gets or sets the Qualification value.
		/// </summary>
		public string Qualification
		{
			get { return qualification; }
			set { qualification = value; }
		}

		/// <summary>
		/// Gets or sets the OrganizationName value.
		/// </summary>
		public string OrganizationName
		{
			get { return organizationName; }
			set { organizationName = value; }
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
		/// Gets or sets the Salutation value.
		/// </summary>
		public int Salutation
		{
			get { return salutation; }
			set { salutation = value; }
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
		/// Gets or sets the PhysicianCode value.
		/// </summary>
		public string PhysicianCode
		{
			get { return physicianCode; }
			set { physicianCode = value; }
		}

		/// <summary>
		/// Gets or sets the IsClient value.
		/// </summary>
		public string IsClient
		{
			get { return isClient; }
			set { isClient = value; }
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
		/// Gets or sets the Gender value.
		/// </summary>
		public string Gender
		{
			get { return gender; }
			set { gender = value; }
		}

		/// <summary>
		/// Gets or sets the DOB value.
		/// </summary>
		public string DOB
		{
			get { return dOB; }
			set { dOB = value; }
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
		/// Gets or sets the RegistrationType value.
		/// </summary>
		public string RegistrationType
		{
			get { return registrationType; }
			set { registrationType = value; }
		}

		/// <summary>
		/// Gets or sets the ParentReferingPhysicianID value.
		/// </summary>
		public int ParentReferingPhysicianID
		{
			get { return parentReferingPhysicianID; }
			set { parentReferingPhysicianID = value; }
		}

		/// <summary>
		/// Gets or sets the IsMerged value.
		/// </summary>
		public string IsMerged
		{
			get { return isMerged; }
			set { isMerged = value; }
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
		/// Gets or sets the RefFeeCategoryid value.
		/// </summary>
		public long RefFeeCategoryid
		{
			get { return refFeeCategoryid; }
			set { refFeeCategoryid = value; }
		}


		#endregion
}
}
