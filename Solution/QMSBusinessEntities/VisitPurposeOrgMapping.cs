using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class VisitPurposeOrgMapping
	{
		#region Fields

		private int visitPurposeID=0;
		private int orgID=0;
		private string visitType=String.Empty;
		private string languageCode=String.Empty;
		private string visitPurposeName=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the VisitPurposeID value.
		/// </summary>
		public int VisitPurposeID
		{
			get { return visitPurposeID; }
			set { visitPurposeID = value; }
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
		/// Gets or sets the VisitType value.
		/// </summary>
		public string VisitType
		{
			get { return visitType; }
			set { visitType = value; }
		}

		/// <summary>
		/// Gets or sets the LanguageCode value.
		/// </summary>
		public string LanguageCode
		{
			get { return languageCode; }
			set { languageCode = value; }
		}

		/// <summary>
		/// Gets or sets the VisitPurposeName value.
		/// </summary>
		public string VisitPurposeName
		{
			get { return visitPurposeName; }
			set { visitPurposeName = value; }
		}


		#endregion
}
}
