using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ConsentTypeMaster
	{
		#region Fields

		private int consentFormTypeID=0;
		private string consentFormTypeName=String.Empty;
		private long orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ConsentFormTypeID value.
		/// </summary>
		public int ConsentFormTypeID
		{
			get { return consentFormTypeID; }
			set { consentFormTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the ConsentFormTypeName value.
		/// </summary>
		public string ConsentFormTypeName
		{
			get { return consentFormTypeName; }
			set { consentFormTypeName = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}


		#endregion
}
}
