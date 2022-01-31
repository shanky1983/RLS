using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class LocalitiesLangMapping
	{
		#region Fields

		private long localitiesMappingID=0;
		private long localitiesID=0;
		private string localitiesDesc=String.Empty;
		private string langCode=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the LocalitiesMappingID value.
		/// </summary>
		public long LocalitiesMappingID
		{
			get { return localitiesMappingID; }
			set { localitiesMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the LocalitiesID value.
		/// </summary>
		public long LocalitiesID
		{
			get { return localitiesID; }
			set { localitiesID = value; }
		}

		/// <summary>
		/// Gets or sets the LocalitiesDesc value.
		/// </summary>
		public string LocalitiesDesc
		{
			get { return localitiesDesc; }
			set { localitiesDesc = value; }
		}

		/// <summary>
		/// Gets or sets the LangCode value.
		/// </summary>
		public string LangCode
		{
			get { return langCode; }
			set { langCode = value; }
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


		#endregion
}
}
