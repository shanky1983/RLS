using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvestigationSection
	{
		#region Fields

		private long sectionID=0;
		private string sectionName=String.Empty;
		private string sectionCode=String.Empty;
		private long orgID=0;
		private string isMLNumber=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SectionID value.
		/// </summary>
		public long SectionID
		{
			get { return sectionID; }
			set { sectionID = value; }
		}

		/// <summary>
		/// Gets or sets the SectionName value.
		/// </summary>
		public string SectionName
		{
			get { return sectionName; }
			set { sectionName = value; }
		}

		/// <summary>
		/// Gets or sets the SectionCode value.
		/// </summary>
		public string SectionCode
		{
			get { return sectionCode; }
			set { sectionCode = value; }
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
		/// Gets or sets the IsMLNumber value.
		/// </summary>
		public string IsMLNumber
		{
			get { return isMLNumber; }
			set { isMLNumber = value; }
		}


		#endregion
}
}
