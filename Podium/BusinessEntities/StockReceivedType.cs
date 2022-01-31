using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class StockReceivedType
	{
		#region Fields

		private int strockReceivedTypeID=0;
		private string srockReceivedTypeName=String.Empty;
		private string isDisplay=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private string languageCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the StrockReceivedTypeID value.
		/// </summary>
		public int StrockReceivedTypeID
		{
			get { return strockReceivedTypeID; }
			set { strockReceivedTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the SrockReceivedTypeName value.
		/// </summary>
		public string SrockReceivedTypeName
		{
			get { return srockReceivedTypeName; }
			set { srockReceivedTypeName = value; }
		}

		/// <summary>
		/// Gets or sets the IsDisplay value.
		/// </summary>
		public string IsDisplay
		{
			get { return isDisplay; }
			set { isDisplay = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
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
