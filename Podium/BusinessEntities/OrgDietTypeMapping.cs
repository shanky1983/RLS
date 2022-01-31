using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class OrgDietTypeMapping
	{
		#region Fields

		private long orgDietTypeMappingID=0;
		private int dietTypeID=0;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrgDietTypeMappingID value.
		/// </summary>
		public long OrgDietTypeMappingID
		{
			get { return orgDietTypeMappingID; }
			set { orgDietTypeMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the DietTypeID value.
		/// </summary>
		public int DietTypeID
		{
			get { return dietTypeID; }
			set { dietTypeID = value; }
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
		/// Gets or sets the DietTypeName value.
		/// </summary>
		private string _dietTypeName=String.Empty;
		public string DietTypeName
		{
			get { return  _dietTypeName; }
			set { _dietTypeName = value; }
		}


		#endregion
}
}
