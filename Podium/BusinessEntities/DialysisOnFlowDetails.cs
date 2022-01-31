using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class DialysisOnFlowDetails
	{
		#region Fields

		private long dialysisOnFlowID=0;
		private long patientVisitID=0;
		private long vitalsID=0;
		private decimal vitalsValue=Decimal.Zero;
		private int uOMID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DialysisOnFlowID value.
		/// </summary>
		public long DialysisOnFlowID
		{
			get { return dialysisOnFlowID; }
			set { dialysisOnFlowID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		public long PatientVisitID
		{
			get { return patientVisitID; }
			set { patientVisitID = value; }
		}

		/// <summary>
		/// Gets or sets the VitalsID value.
		/// </summary>
		public long VitalsID
		{
			get { return vitalsID; }
			set { vitalsID = value; }
		}

		/// <summary>
		/// Gets or sets the VitalsValue value.
		/// </summary>
		public decimal VitalsValue
		{
			get { return vitalsValue; }
			set { vitalsValue = value; }
		}

		/// <summary>
		/// Gets or sets the UOMID value.
		/// </summary>
		public int UOMID
		{
			get { return uOMID; }
			set { uOMID = value; }
		}


		#endregion
}
}
