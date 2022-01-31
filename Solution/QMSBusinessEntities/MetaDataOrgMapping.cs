using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class MetaDataOrgMapping
	{
		#region Fields

		private long metadataOrgMappingID=0;
		private long metadataID=0;
		private long orgID=0;
		private string langCode=String.Empty;
		private string displayText=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MetadataOrgMappingID value.
		/// </summary>
		public long MetadataOrgMappingID
		{
			get { return metadataOrgMappingID; }
			set { metadataOrgMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the MetadataID value.
		/// </summary>
		public long MetadataID
		{
			get { return metadataID; }
			set { metadataID = value; }
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
		/// Gets or sets the LangCode value.
		/// </summary>
		public string LangCode
		{
			get { return langCode; }
			set { langCode = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayText value.
		/// </summary>
		public string DisplayText
		{
			get { return displayText; }
			set { displayText = value; }
		}


		#endregion
}
}
