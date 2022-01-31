using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ConsentTemplateDetails
	{
		#region Fields

		private int consentTemplateID=0;
		private int consentFormTypeID=0;
		private string consentFormDetails=String.Empty;
		private long orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ConsentTemplateID value.
		/// </summary>
		public int ConsentTemplateID
		{
			get { return consentTemplateID; }
			set { consentTemplateID = value; }
		}

		/// <summary>
		/// Gets or sets the ConsentFormTypeID value.
		/// </summary>
		public int ConsentFormTypeID
		{
			get { return consentFormTypeID; }
			set { consentFormTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the ConsentFormDetails value.
		/// </summary>
		public string ConsentFormDetails
		{
			get { return consentFormDetails; }
			set { consentFormDetails = value; }
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
