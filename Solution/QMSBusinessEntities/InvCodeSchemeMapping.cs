using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvCodeSchemeMapping
	{
		#region Fields

		private int invCodeSchemeID=0;
		private long invID=0;
		private long orgID=0;
		private int codeTypeID=0;
		private string code=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvCodeSchemeID value.
		/// </summary>
		public int InvCodeSchemeID
		{
			get { return invCodeSchemeID; }
			set { invCodeSchemeID = value; }
		}

		/// <summary>
		/// Gets or sets the InvID value.
		/// </summary>
		public long InvID
		{
			get { return invID; }
			set { invID = value; }
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
		/// Gets or sets the CodeTypeID value.
		/// </summary>
		public int CodeTypeID
		{
			get { return codeTypeID; }
			set { codeTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the Code value.
		/// </summary>
		public string Code
		{
			get { return code; }
			set { code = value; }
		}


		#endregion
}
}
