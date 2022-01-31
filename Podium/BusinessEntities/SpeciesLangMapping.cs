using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class SpeciesLangMapping
	{
		#region Fields

		private int speciesLangMappingID=0;
		private int speciesID=0;
		private string speciesDisplayText=String.Empty;
		private string langCode=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SpeciesLangMappingID value.
		/// </summary>
		public int SpeciesLangMappingID
		{
			get { return speciesLangMappingID; }
			set { speciesLangMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the SpeciesID value.
		/// </summary>
		public int SpeciesID
		{
			get { return speciesID; }
			set { speciesID = value; }
		}

		/// <summary>
		/// Gets or sets the SpeciesDisplayText value.
		/// </summary>
		public string SpeciesDisplayText
		{
			get { return speciesDisplayText; }
			set { speciesDisplayText = value; }
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


		#endregion
}
}
