using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InvSampleMasterDeviceMapping
	{
		#region Fields

		private string deviceID=String.Empty;
		private long sampleCode=0;
		private string deviceSampleDesc=String.Empty;
		private long orgID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DeviceID value.
		/// </summary>
		public string DeviceID
		{
			get { return deviceID; }
			set { deviceID = value; }
		}

		/// <summary>
		/// Gets or sets the SampleCode value.
		/// </summary>
		public long SampleCode
		{
			get { return sampleCode; }
			set { sampleCode = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceSampleDesc value.
		/// </summary>
		public string DeviceSampleDesc
		{
			get { return deviceSampleDesc; }
			set { deviceSampleDesc = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}


		#endregion
}
}
