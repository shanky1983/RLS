using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Tmp_sampleinfo
	{
		#region Fields

		private string externalVisitID=String.Empty;
		private string barcodeNumber=String.Empty;
		private string sampleCode=String.Empty;
		private string sampleDesc=String.Empty;
		private string groupname=String.Empty;
		private string investigationName=String.Empty;
		private string valu=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ExternalVisitID value.
		/// </summary>
		public string ExternalVisitID
		{
			get { return externalVisitID; }
			set { externalVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the BarcodeNumber value.
		/// </summary>
		public string BarcodeNumber
		{
			get { return barcodeNumber; }
			set { barcodeNumber = value; }
		}

		/// <summary>
		/// Gets or sets the SampleCode value.
		/// </summary>
		public string SampleCode
		{
			get { return sampleCode; }
			set { sampleCode = value; }
		}

		/// <summary>
		/// Gets or sets the SampleDesc value.
		/// </summary>
		public string SampleDesc
		{
			get { return sampleDesc; }
			set { sampleDesc = value; }
		}

		/// <summary>
		/// Gets or sets the Groupname value.
		/// </summary>
		public string Groupname
		{
			get { return groupname; }
			set { groupname = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationName value.
		/// </summary>
		public string InvestigationName
		{
			get { return investigationName; }
			set { investigationName = value; }
		}

		/// <summary>
		/// Gets or sets the Valu value.
		/// </summary>
		public string Value
		{
			get { return valu; }
			set { valu = value; }
		}


		#endregion
}
}
