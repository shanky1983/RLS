using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class HLMessageMandatoryDetailsMapping
	{
		#region Fields

		private long hLMessageMandatoryDetailsMappingID=0;
		private long hLMessageMandatoryDetailsID=0;
		private string isMandatory=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private long orgID=0;
		private long locationID=0;
		private string tableCode=String.Empty;
		private string errorMessage=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the HLMessageMandatoryDetailsMappingID value.
		/// </summary>
		public long HLMessageMandatoryDetailsMappingID
		{
			get { return hLMessageMandatoryDetailsMappingID; }
			set { hLMessageMandatoryDetailsMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the HLMessageMandatoryDetailsID value.
		/// </summary>
		public long HLMessageMandatoryDetailsID
		{
			get { return hLMessageMandatoryDetailsID; }
			set { hLMessageMandatoryDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the IsMandatory value.
		/// </summary>
		public string IsMandatory
		{
			get { return isMandatory; }
			set { isMandatory = value; }
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
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		public long LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the TableCode value.
		/// </summary>
		public string TableCode
		{
			get { return tableCode; }
			set { tableCode = value; }
		}

		/// <summary>
		/// Gets or sets the ErrorMessage value.
		/// </summary>
		public string ErrorMessage
		{
			get { return errorMessage; }
			set { errorMessage = value; }
		}


		#endregion
}
}
