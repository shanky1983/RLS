using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class NationalityLangMapping
	{
		#region Fields

		private long nationalityLangMappingID=0;
		private long nationalityID=0;
		private string nationalityDesc=String.Empty;
		private string langCode=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the NationalityLangMappingID value.
		/// </summary>
		public long NationalityLangMappingID
		{
			get { return nationalityLangMappingID; }
			set { nationalityLangMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the NationalityID value.
		/// </summary>
		public long NationalityID
		{
			get { return nationalityID; }
			set { nationalityID = value; }
		}

		/// <summary>
		/// Gets or sets the NationalityDesc value.
		/// </summary>
		public string NationalityDesc
		{
			get { return nationalityDesc; }
			set { nationalityDesc = value; }
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
