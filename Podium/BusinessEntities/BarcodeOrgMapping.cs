using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class BarcodeOrgMapping
	{
		#region Fields

		private long id=0;
		private long barcodeCategoryId=0;
		private long barcodeMainAttributeId=0;
		private int orgID=0;
		private string valu=String.Empty;
		private string displayText=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public long Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the BarcodeCategoryId value.
		/// </summary>
		public long BarcodeCategoryId
		{
			get { return barcodeCategoryId; }
			set { barcodeCategoryId = value; }
		}

		/// <summary>
		/// Gets or sets the BarcodeMainAttributeId value.
		/// </summary>
		public long BarcodeMainAttributeId
		{
			get { return barcodeMainAttributeId; }
			set { barcodeMainAttributeId = value; }
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
		/// Gets or sets the Valu value.
		/// </summary>
		public string Value
		{
			get { return valu; }
			set { valu = value; }
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
		/// Gets or sets the CategoryName value.
		/// </summary>
		private string _categoryName=String.Empty;
		public string CategoryName
		{
			get { return  _categoryName; }
			set { _categoryName = value; }
		}

		/// <summary>
		/// Gets or sets the MainAttributeName value.
		/// </summary>
		private string _mainAttributeName=String.Empty;
		public string MainAttributeName
		{
			get { return  _mainAttributeName; }
			set { _mainAttributeName = value; }
		}


		#endregion
}
}
