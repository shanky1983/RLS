using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class XSLBillFormat
	{
		#region Fields

		private int xSLBFID=0;
		private string header=String.Empty;
		private string body=String.Empty;
		private string footer=String.Empty;
		private string billType=String.Empty;
		private int orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the XSLBFID value.
		/// </summary>
		public int XSLBFID
		{
			get { return xSLBFID; }
			set { xSLBFID = value; }
		}

		/// <summary>
		/// Gets or sets the Header value.
		/// </summary>
		public string Header
		{
			get { return header; }
			set { header = value; }
		}

		/// <summary>
		/// Gets or sets the Body value.
		/// </summary>
		public string Body
		{
			get { return body; }
			set { body = value; }
		}

		/// <summary>
		/// Gets or sets the Footer value.
		/// </summary>
		public string Footer
		{
			get { return footer; }
			set { footer = value; }
		}

		/// <summary>
		/// Gets or sets the BillType value.
		/// </summary>
		public string BillType
		{
			get { return billType; }
			set { billType = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}


		#endregion
}
}
