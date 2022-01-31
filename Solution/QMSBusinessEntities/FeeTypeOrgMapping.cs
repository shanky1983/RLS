using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class FeeTypeOrgMapping
	{
		#region Fields

		private int feeTypeID=0;
		private int orgID=0;
		private string visitType=String.Empty;
		private string feeTypeDesc=String.Empty;
		private string languageCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FeeTypeID value.
		/// </summary>
		public int FeeTypeID
		{
			get { return feeTypeID; }
			set { feeTypeID = value; }
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
		/// Gets or sets the FeeTypeDesc value.
		/// </summary>
		public string FeeTypeDesc
		{
			get { return feeTypeDesc; }
			set { feeTypeDesc = value; }
		}

		/// <summary>
		/// Gets or sets the LanguageCode value.
		/// </summary>
		public string LanguageCode
		{
			get { return languageCode; }
			set { languageCode = value; }
		}


		#endregion
}
}
