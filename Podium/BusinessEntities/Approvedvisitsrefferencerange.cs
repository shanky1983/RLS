using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Approvedvisitsrefferencerange
	{
		#region Fields

		private long patientvisitid=0;
		private long investigationid=0;
		private long accessionnumber=0;
		private long approvedby=0;
		private DateTime approvedAt=DateTime.MaxValue;
		private string referenceRange=String.Empty;
		private string status=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Patientvisitid value.
		/// </summary>
		public long Patientvisitid
		{
			get { return patientvisitid; }
			set { patientvisitid = value; }
		}

		/// <summary>
		/// Gets or sets the Investigationid value.
		/// </summary>
		public long Investigationid
		{
			get { return investigationid; }
			set { investigationid = value; }
		}

		/// <summary>
		/// Gets or sets the Accessionnumber value.
		/// </summary>
		public long Accessionnumber
		{
			get { return accessionnumber; }
			set { accessionnumber = value; }
		}

		/// <summary>
		/// Gets or sets the Approvedby value.
		/// </summary>
		public long Approvedby
		{
			get { return approvedby; }
			set { approvedby = value; }
		}

		/// <summary>
		/// Gets or sets the ApprovedAt value.
		/// </summary>
		public DateTime ApprovedAt
		{
			get { return approvedAt; }
			set { approvedAt = value; }
		}

		/// <summary>
		/// Gets or sets the ReferenceRange value.
		/// </summary>
		public string ReferenceRange
		{
			get { return referenceRange; }
			set { referenceRange = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
		}


		#endregion
}
}
