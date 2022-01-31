using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class AddressType
	{
		#region Fields

		private int typeID=0;
		private string typeName=String.Empty;
		private string category=String.Empty;
		private int orgID=0;
		private long createdby=0;
		private DateTime createdAt=DateTime.MaxValue;
		private string langCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TypeID value.
		/// </summary>
		public int TypeID
		{
			get { return typeID; }
			set { typeID = value; }
		}

		/// <summary>
		/// Gets or sets the TypeName value.
		/// </summary>
		public string TypeName
		{
			get { return typeName; }
			set { typeName = value; }
		}

		/// <summary>
		/// Gets or sets the Category value.
		/// </summary>
		public string Category
		{
			get { return category; }
			set { category = value; }
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
		/// Gets or sets the Createdby value.
		/// </summary>
		public long Createdby
		{
			get { return createdby; }
			set { createdby = value; }
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
		/// Gets or sets the LangCode value.
		/// </summary>
		public string LangCode
		{
			get { return langCode; }
			set { langCode = value; }
		}


		#endregion
}
}
