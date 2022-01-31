using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Mytable_backup
	{
		#region Fields

		private long patientInvID=0;
		private string deviceID=String.Empty;
		private long id=0;
		private string isSentBarcode=String.Empty;
		private int orgID=0;
		private bool iscompleted=false;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientInvID value.
		/// </summary>
		public long PatientInvID
		{
			get { return patientInvID; }
			set { patientInvID = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceID value.
		/// </summary>
		public string DeviceID
		{
			get { return deviceID; }
			set { deviceID = value; }
		}

		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public long Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the IsSentBarcode value.
		/// </summary>
		public string IsSentBarcode
		{
			get { return isSentBarcode; }
			set { isSentBarcode = value; }
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
		/// Gets or sets the Iscompleted value.
		/// </summary>
		public bool Iscompleted
		{
			get { return iscompleted; }
			set { iscompleted = value; }
		}


		#endregion
}
}
