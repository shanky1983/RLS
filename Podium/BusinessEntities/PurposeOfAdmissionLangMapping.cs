using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PurposeOfAdmissionLangMapping
	{
		#region Fields

		private long purposeOfAdmissionLangMappingID=0;
		private long purposeOfAdmissionID=0;
		private string purposeOfAdmissionDesc=String.Empty;
		private string langCode=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PurposeOfAdmissionLangMappingID value.
		/// </summary>
		public long PurposeOfAdmissionLangMappingID
		{
			get { return purposeOfAdmissionLangMappingID; }
			set { purposeOfAdmissionLangMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the PurposeOfAdmissionID value.
		/// </summary>
		public long PurposeOfAdmissionID
		{
			get { return purposeOfAdmissionID; }
			set { purposeOfAdmissionID = value; }
		}

		/// <summary>
		/// Gets or sets the PurposeOfAdmissionDesc value.
		/// </summary>
		public string PurposeOfAdmissionDesc
		{
			get { return purposeOfAdmissionDesc; }
			set { purposeOfAdmissionDesc = value; }
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
