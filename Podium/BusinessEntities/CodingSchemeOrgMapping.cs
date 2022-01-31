using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class CodingSchemeOrgMapping
	{
		#region Fields

		private int codingSchemeOrgID=0;
		private int codeTypeID=0;
		private long rootOrgID=0;
		private long parentOrgID=0;
		private long orgID=0;
		private string isPrimary=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CodingSchemeOrgID value.
		/// </summary>
		public int CodingSchemeOrgID
		{
			get { return codingSchemeOrgID; }
			set { codingSchemeOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the CodeTypeID value.
		/// </summary>
		public int CodeTypeID
		{
			get { return codeTypeID; }
			set { codeTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the RootOrgID value.
		/// </summary>
		public long RootOrgID
		{
			get { return rootOrgID; }
			set { rootOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the ParentOrgID value.
		/// </summary>
		public long ParentOrgID
		{
			get { return parentOrgID; }
			set { parentOrgID = value; }
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
		/// Gets or sets the IsPrimary value.
		/// </summary>
		public string IsPrimary
		{
			get { return isPrimary; }
			set { isPrimary = value; }
		}


		#endregion
}
}
