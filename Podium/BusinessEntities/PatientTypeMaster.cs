using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PatientTypeMaster
	{
		#region Fields

		private long patientTypeID=0;
		private string patientTypeName=String.Empty;
		private int orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string colourCode=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the PatientTypeID value.
		/// </summary>
		public long PatientTypeID
		{
			get { return patientTypeID; }
			set { patientTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the PatientTypeName value.
		/// </summary>
		public string PatientTypeName
		{
			get { return patientTypeName; }
			set { patientTypeName = value; }
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
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public long CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
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
		/// Gets or sets the ModifiedBy value.
		/// </summary>
		public long ModifiedBy
		{
			get { return modifiedBy; }
			set { modifiedBy = value; }
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
		/// Gets or sets the ColourCode value.
		/// </summary>
		public string ColourCode
		{
			get { return colourCode; }
			set { colourCode = value; }
		}


		#endregion
}
}
