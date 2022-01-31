using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class MetaValue_Common
	{
		#region Fields

		private long metaValueID=0;
		private long metaTypeId=0;
		private string valu=String.Empty;
		private string code=String.Empty;
		private int orgID=0;
		private string description=String.Empty;
		private string isActive=String.Empty;
		private string langCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the MetaValueID value.
		/// </summary>
		public long MetaValueID
		{
			get { return metaValueID; }
			set { metaValueID = value; }
		}

		/// <summary>
		/// Gets or sets the MetaTypeId value.
		/// </summary>
		public long MetaTypeId
		{
			get { return metaTypeId; }
			set { metaTypeId = value; }
		}

		/// <summary>
		/// Gets or sets the Valu value.
		/// </summary>
		public string Value
		{
			get { return valu; }
			set { valu = value; }
		}

		/// <summary>
		/// Gets or sets the Code value.
		/// </summary>
		public string Code
		{
			get { return code; }
			set { code = value; }
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
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
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
		/// Gets or sets the LangCode value.
		/// </summary>
		public string LangCode
		{
			get { return langCode; }
			set { langCode = value; }
		}

		/// <summary>
		/// Gets or sets the TypeName value.
		/// </summary>
		private string _typeName=String.Empty;
		public string TypeName
		{
			get { return  _typeName; }
			set { _typeName = value; }
		}


		#endregion
}
}
