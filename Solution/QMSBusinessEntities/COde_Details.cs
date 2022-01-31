using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class COde_Details
	{
		#region Fields

		private int orgID=0;
		private string name=String.Empty;
		private int codeTypeID=0;
		private string codeType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
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
		/// Gets or sets the CodeType value.
		/// </summary>
		public string CodeType
		{
			get { return codeType; }
			set { codeType = value; }
		}


		#endregion
}
}
