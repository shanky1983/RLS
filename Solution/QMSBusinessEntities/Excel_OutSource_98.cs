using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Excel_OutSource_98
	{
		#region Fields

		private string tCODE=String.Empty;
		private string testName=String.Empty;
		private string dISPLAY_NAME=String.Empty;
		private string subCategory=String.Empty;
		private string pROCESSING_LOCATION=String.Empty;
		private string tESTTYPE=String.Empty;
		private string processing_AddressID=String.Empty;
		private int id=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the TCODE value.
		/// </summary>
		public string TCODE
		{
			get { return tCODE; }
			set { tCODE = value; }
		}

		/// <summary>
		/// Gets or sets the TestName value.
		/// </summary>
		public string TestName
		{
			get { return testName; }
			set { testName = value; }
		}

		/// <summary>
		/// Gets or sets the DISPLAY_NAME value.
		/// </summary>
		public string DISPLAY_NAME
		{
			get { return dISPLAY_NAME; }
			set { dISPLAY_NAME = value; }
		}

		/// <summary>
		/// Gets or sets the SubCategory value.
		/// </summary>
		public string SubCategory
		{
			get { return subCategory; }
			set { subCategory = value; }
		}

		/// <summary>
		/// Gets or sets the PROCESSING_LOCATION value.
		/// </summary>
		public string PROCESSING_LOCATION
		{
			get { return pROCESSING_LOCATION; }
			set { pROCESSING_LOCATION = value; }
		}

		/// <summary>
		/// Gets or sets the TESTTYPE value.
		/// </summary>
		public string TESTTYPE
		{
			get { return tESTTYPE; }
			set { tESTTYPE = value; }
		}

		/// <summary>
		/// Gets or sets the Processing_AddressID value.
		/// </summary>
		public string Processing_AddressID
		{
			get { return processing_AddressID; }
			set { processing_AddressID = value; }
		}

		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public int Id
		{
			get { return id; }
			set { id = value; }
		}


		#endregion
}
}
