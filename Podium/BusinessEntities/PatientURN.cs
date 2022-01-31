using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientURN
	{
		#region Fields

		private long patientURNID=0;
		private long uRNTypeID=0;
		private string uRNValue=String.Empty;
		private bool isDefault=false;
		private DateTime uRNEXPDate=DateTime.MaxValue;
		private long uRNNoofId=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private bool status=false;
		private long patientId=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientURNID value.
		/// </summary>
		public long PatientURNID
		{
			get { return patientURNID; }
			set { patientURNID = value; }
		}

		/// <summary>
		/// Gets or sets the URNTypeID value.
		/// </summary>
		public long URNTypeID
		{
			get { return uRNTypeID; }
			set { uRNTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the URNValue value.
		/// </summary>
		public string URNValue
		{
			get { return uRNValue; }
			set { uRNValue = value; }
		}

		/// <summary>
		/// Gets or sets the IsDefault value.
		/// </summary>
		public bool IsDefault
		{
			get { return isDefault; }
			set { isDefault = value; }
		}

		/// <summary>
		/// Gets or sets the URNEXPDate value.
		/// </summary>
		public DateTime URNEXPDate
		{
			get { return uRNEXPDate; }
			set { uRNEXPDate = value; }
		}

		/// <summary>
		/// Gets or sets the URNNoofId value.
		/// </summary>
		public long URNNoofId
		{
			get { return uRNNoofId; }
			set { uRNNoofId = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedAt value.
		/// </summary>
		public DateTime ModifiedAt
		{
			get { return modifiedAt; }
			set { modifiedAt = value; }
		}

		/// <summary>
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public bool Status
		{
			get { return status; }
			set { status = value; }
		}

		/// <summary>
		/// Gets or sets the PatientId value.
		/// </summary>
		public long PatientId
		{
			get { return patientId; }
			set { patientId = value; }
		}


		#endregion
}
}
