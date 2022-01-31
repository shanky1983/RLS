using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class DeviceErrorFlag
	{
		#region Fields

		private long instrumentID=0;
		private string deviceCode=String.Empty;
		private string errorCategory=String.Empty;
		private string errorCode=String.Empty;
		private string errorDescription=String.Empty;
		private int orgID=0;
		private int orgAddressID=0;
		private string symbol=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InstrumentID value.
		/// </summary>
		public long InstrumentID
		{
			get { return instrumentID; }
			set { instrumentID = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceCode value.
		/// </summary>
		public string DeviceCode
		{
			get { return deviceCode; }
			set { deviceCode = value; }
		}

		/// <summary>
		/// Gets or sets the ErrorCategory value.
		/// </summary>
		public string ErrorCategory
		{
			get { return errorCategory; }
			set { errorCategory = value; }
		}

		/// <summary>
		/// Gets or sets the ErrorCode value.
		/// </summary>
		public string ErrorCode
		{
			get { return errorCode; }
			set { errorCode = value; }
		}

		/// <summary>
		/// Gets or sets the ErrorDescription value.
		/// </summary>
		public string ErrorDescription
		{
			get { return errorDescription; }
			set { errorDescription = value; }
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
		/// Gets or sets the Symbol value.
		/// </summary>
		public string Symbol
		{
			get { return symbol; }
			set { symbol = value; }
		}


		#endregion
}
}
