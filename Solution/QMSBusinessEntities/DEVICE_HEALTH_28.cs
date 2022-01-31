using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class DEVICE_HEALTH_28
	{
		#region Fields

		private string productCode=String.Empty;
		private string testCode=String.Empty;
		private string investigationid=String.Empty;
		private string instrumentName=String.Empty;
		private string testAttributes=String.Empty;
		private string referenceType=String.Empty;
		private string instrumentID=String.Empty;
		private string formula=String.Empty;
		private string abnormal=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ProductCode value.
		/// </summary>
		public string ProductCode
		{
			get { return productCode; }
			set { productCode = value; }
		}

		/// <summary>
		/// Gets or sets the TestCode value.
		/// </summary>
		public string TestCode
		{
			get { return testCode; }
			set { testCode = value; }
		}

		/// <summary>
		/// Gets or sets the Investigationid value.
		/// </summary>
		public string Investigationid
		{
			get { return investigationid; }
			set { investigationid = value; }
		}

		/// <summary>
		/// Gets or sets the InstrumentName value.
		/// </summary>
		public string InstrumentName
		{
			get { return instrumentName; }
			set { instrumentName = value; }
		}

		/// <summary>
		/// Gets or sets the TestAttributes value.
		/// </summary>
		public string TestAttributes
		{
			get { return testAttributes; }
			set { testAttributes = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceType value.
		/// </summary>
		public string ReferenceType
		{
			get { return referenceType; }
			set { referenceType = value; }
		}

		/// <summary>
		/// Gets or sets the InstrumentID value.
		/// </summary>
		public string InstrumentID
		{
			get { return instrumentID; }
			set { instrumentID = value; }
		}

		/// <summary>
		/// Gets or sets the Formula value.
		/// </summary>
		public string Formula
		{
			get { return formula; }
			set { formula = value; }
		}

		/// <summary>
		/// Gets or sets the Abnormal value.
		/// </summary>
		public string Abnormal
		{
			get { return abnormal; }
			set { abnormal = value; }
		}


		#endregion
}
}
