using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class FeeTypeAttributesMapping
	{
		#region Fields

		private int feeTypeAttributesID=0;
		private int orgID=0;
		private string languageCode=String.Empty;
		private string displayText=String.Empty;
		private long itemID=0;
		private string feeType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the FeeTypeAttributesID value.
		/// </summary>
		public int FeeTypeAttributesID
		{
			get { return feeTypeAttributesID; }
			set { feeTypeAttributesID = value; }
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
		/// Gets or sets the LanguageCode value.
		/// </summary>
		public string LanguageCode
		{
			get { return languageCode; }
			set { languageCode = value; }
		}

		/// <summary>
		/// Gets or sets the DisplayText value.
		/// </summary>
		public string DisplayText
		{
			get { return displayText; }
			set { displayText = value; }
		}

		/// <summary>
		/// Gets or sets the ItemID value.
		/// </summary>
		public long ItemID
		{
			get { return itemID; }
			set { itemID = value; }
		}

		/// <summary>
		/// Gets or sets the FeeType value.
		/// </summary>
		public string FeeType
		{
			get { return feeType; }
			set { feeType = value; }
		}


		#endregion
}
}
