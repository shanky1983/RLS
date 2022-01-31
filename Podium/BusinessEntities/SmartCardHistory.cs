using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class SmartCardHistory
	{
		#region Fields

		private long patientId=0;
		private string smartCardNumber=String.Empty;
		private string status=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdby=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientId value.
		/// </summary>
		public long PatientId
		{
			get { return patientId; }
			set { patientId = value; }
		}

		/// <summary>
		/// Gets or sets the SmartCardNumber value.
		/// </summary>
		public string SmartCardNumber
		{
			get { return smartCardNumber; }
			set { smartCardNumber = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedAt value.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}

		/// <summary>
		/// Gets or sets the Createdby value.
		/// </summary>
		public long Createdby
		{
			get { return createdby; }
			set { createdby = value; }
		}


		#endregion
}
}
