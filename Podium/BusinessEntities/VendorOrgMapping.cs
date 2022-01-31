using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class VendorOrgMapping
	{
		#region Fields

		private int vendorMappingID=0;
		private int vendorID=0;
		private string orgName=String.Empty;
		private long attuneOrgID=0;
		private long vendorOrgID=0;
		private string integrationTypeCode=String.Empty;
		private DateTime modifiedAt=DateTime.MaxValue;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private string authenticationKey=String.Empty;
		private string appName=String.Empty;
		private int refreshTokenLifeTime=0;
		private string allowedOrigin=String.Empty;
		private int applicationType=0;
		private Guid uniqueKey=Guid.Empty;
		private bool status=false;
		private int sessionTokenLifeTime=0;
		private long modifiedBy=0;
		private string vendorApiKey=String.Empty;
		private string vendorSecretKey=String.Empty;
		private bool requiredRefreshToken=false;
		private Guid attGuId=Guid.Empty;
		private string roleName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the VendorMappingID value.
		/// </summary>
		public int VendorMappingID
		{
			get { return vendorMappingID; }
			set { vendorMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the VendorID value.
		/// </summary>
		public int VendorID
		{
			get { return vendorID; }
			set { vendorID = value; }
		}

		/// <summary>
		/// Gets or sets the OrgName value.
		/// </summary>
		public string OrgName
		{
			get { return orgName; }
			set { orgName = value; }
		}

		/// <summary>
		/// Gets or sets the AttuneOrgID value.
		/// </summary>
		public long AttuneOrgID
		{
			get { return attuneOrgID; }
			set { attuneOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the VendorOrgID value.
		/// </summary>
		public long VendorOrgID
		{
			get { return vendorOrgID; }
			set { vendorOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the IntegrationTypeCode value.
		/// </summary>
		public string IntegrationTypeCode
		{
			get { return integrationTypeCode; }
			set { integrationTypeCode = value; }
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
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
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
		/// Gets or sets the AuthenticationKey value.
		/// </summary>
		public string AuthenticationKey
		{
			get { return authenticationKey; }
			set { authenticationKey = value; }
		}

		/// <summary>
		/// Gets or sets the AppName value.
		/// </summary>
		public string AppName
		{
			get { return appName; }
			set { appName = value; }
		}

		/// <summary>
		/// Gets or sets the RefreshTokenLifeTime value.
		/// </summary>
		public int RefreshTokenLifeTime
		{
			get { return refreshTokenLifeTime; }
			set { refreshTokenLifeTime = value; }
		}

		/// <summary>
		/// Gets or sets the AllowedOrigin value.
		/// </summary>
		public string AllowedOrigin
		{
			get { return allowedOrigin; }
			set { allowedOrigin = value; }
		}

		/// <summary>
		/// Gets or sets the ApplicationType value.
		/// </summary>
		public int ApplicationType
		{
			get { return applicationType; }
			set { applicationType = value; }
		}

		/// <summary>
		/// Gets or sets the UniqueKey value.
		/// </summary>
		public Guid UniqueKey
		{
			get { return uniqueKey; }
			set { uniqueKey = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public bool Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the SessionTokenLifeTime value.
		/// </summary>
		public int SessionTokenLifeTime
		{
			get { return sessionTokenLifeTime; }
			set { sessionTokenLifeTime = value; }
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
		/// Gets or sets the VendorApiKey value.
		/// </summary>
		public string VendorApiKey
		{
			get { return vendorApiKey; }
			set { vendorApiKey = value; }
		}

		/// <summary>
		/// Gets or sets the VendorSecretKey value.
		/// </summary>
		public string VendorSecretKey
		{
			get { return vendorSecretKey; }
			set { vendorSecretKey = value; }
		}

		/// <summary>
		/// Gets or sets the RequiredRefreshToken value.
		/// </summary>
		public bool RequiredRefreshToken
		{
			get { return requiredRefreshToken; }
			set { requiredRefreshToken = value; }
		}

		/// <summary>
		/// Gets or sets the AttGuId value.
		/// </summary>
		public Guid AttGuId
		{
			get { return attGuId; }
			set { attGuId = value; }
		}

		/// <summary>
		/// Gets or sets the RoleName value.
		/// </summary>
		public string RoleName
		{
			get { return roleName; }
			set { roleName = value; }
		}


		#endregion
}
}
