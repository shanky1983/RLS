using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class FeeTypeGroupOrgMapping
	{
		#region Fields

		private long feeTypeGroupOrgID=0;
		private long feeTypeGroupID=0;
		private long feeTypeSubGroupID=0;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string languageCode=String.Empty;
		private string feeType=String.Empty;
		private long feeID=0;
		private string isActive=String.Empty;
		private DateTime validFrom=DateTime.MaxValue;
		private DateTime validTo=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FeeTypeGroupOrgID value.
		/// </summary>
		public long FeeTypeGroupOrgID
		{
			get { return feeTypeGroupOrgID; }
			set { feeTypeGroupOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the FeeTypeGroupID value.
		/// </summary>
		public long FeeTypeGroupID
		{
			get { return feeTypeGroupID; }
			set { feeTypeGroupID = value; }
		}

		/// <summary>
		/// Gets or sets the FeeTypeSubGroupID value.
		/// </summary>
		public long FeeTypeSubGroupID
		{
			get { return feeTypeSubGroupID; }
			set { feeTypeSubGroupID = value; }
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
		/// Gets or sets the LanguageCode value.
		/// </summary>
		public string LanguageCode
		{
			get { return languageCode; }
			set { languageCode = value; }
		}

		/// <summary>
		/// Gets or sets the FeeType value.
		/// </summary>
		public string FeeType
		{
			get { return feeType; }
			set { feeType = value; }
		}

		/// <summary>
		/// Gets or sets the FeeID value.
		/// </summary>
		public long FeeID
		{
			get { return feeID; }
			set { feeID = value; }
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
		/// Gets or sets the ValidFrom value.
		/// </summary>
		public DateTime ValidFrom
		{
			get { return validFrom; }
			set { validFrom = value; }
		}

		/// <summary>
		/// Gets or sets the ValidTo value.
		/// </summary>
		public DateTime ValidTo
		{
			get { return validTo; }
			set { validTo = value; }
		}


		#endregion
}
}
