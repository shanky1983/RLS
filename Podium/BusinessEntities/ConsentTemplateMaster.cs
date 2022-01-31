using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ConsentTemplateMaster
	{
		#region Fields

		private int consentTemplateID=0;
		private string consentTemplateType=String.Empty;
		private string consentTemplateDetails=String.Empty;
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
		/// Gets or sets the ConsentTemplateType value.
		/// </summary>
		public string ConsentTemplateType
		{
			get { return consentTemplateType; }
			set { consentTemplateType = value; }
		}

		/// <summary>
		/// Gets or sets the ConsentTemplateDetails value.
		/// </summary>
		public string ConsentTemplateDetails
		{
			get { return consentTemplateDetails; }
			set { consentTemplateDetails = value; }
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
