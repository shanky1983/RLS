using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class LocationPrintMap
	{
		#region Fields

		private long autoID=0;
		private long code=0;
		private string printerName=String.Empty;
		private int orgID=0;
		private int orgAddressID=0;
		private bool isColorPrinter=false;
		private bool isActive=false;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AutoID value.
		/// </summary>
		public long AutoID
		{
			get { return autoID; }
			set { autoID = value; }
		}

		/// <summary>
		/// Gets or sets the Code value.
		/// </summary>
		public long Code
		{
			get { return code; }
			set { code = value; }
		}

		/// <summary>
		/// Gets or sets the PrinterName value.
		/// </summary>
		public string PrinterName
		{
			get { return printerName; }
			set { printerName = value; }
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
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public int OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the IsColorPrinter value.
		/// </summary>
		public bool IsColorPrinter
		{
			get { return isColorPrinter; }
			set { isColorPrinter = value; }
		}

		/// <summary>
		/// Gets or sets the IsActive value.
		/// </summary>
		public bool IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}


		#endregion
}
}
