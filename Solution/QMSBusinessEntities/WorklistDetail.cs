using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class WorklistDetail
	{
		#region Fields

		private long worklistDetailId=0;
		private int wMID=0;
		private long patientInvId=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the WorklistDetailId value.
		/// </summary>
		public long WorklistDetailId
		{
			get { return worklistDetailId; }
			set { worklistDetailId = value; }
		}

		/// <summary>
		/// Gets or sets the WMID value.
		/// </summary>
		public int WMID
		{
			get { return wMID; }
			set { wMID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientInvId value.
		/// </summary>
		public long PatientInvId
		{
			get { return patientInvId; }
			set { patientInvId = value; }
		}


		#endregion
}
}
