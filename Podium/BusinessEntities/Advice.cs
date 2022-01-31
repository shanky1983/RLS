using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Advice
	{
		#region Fields

		private int adviceID=0;
		private string adviceName=String.Empty;
		private string adviceDesc=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the AdviceID value.
		/// </summary>
		public int AdviceID
		{
			get { return adviceID; }
			set { adviceID = value; }
		}

		/// <summary>
		/// Gets or sets the AdviceName value.
		/// </summary>
		public string AdviceName
		{
			get { return adviceName; }
			set { adviceName = value; }
		}

		/// <summary>
		/// Gets or sets the AdviceDesc value.
		/// </summary>
		public string AdviceDesc
		{
			get { return adviceDesc; }
			set { adviceDesc = value; }
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
		/// Gets or sets the AllergyName value.
		/// </summary>
		private string _allergyName=String.Empty;
		public string AllergyName
		{
			get { return  _allergyName; }
			set { _allergyName = value; }
		}

		/// <summary>
		/// Gets or sets the PatientVisitID value.
		/// </summary>
		private long _patientVisitID=0;
		public long PatientVisitID
		{
			get { return  _patientVisitID; }
			set { _patientVisitID = value; }
		}


		#endregion
}
}
