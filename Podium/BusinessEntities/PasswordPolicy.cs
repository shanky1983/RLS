using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PasswordPolicy
	{
		#region Fields

		private long id=0;
		private string type=String.Empty;
		private int passwordLength=0;
		private int splcharlen=0;
		private int numcharlen=0;
		private string validityPeriodType=String.Empty;
		private int validityPeriod=0;
		private int previousPwdcount=0;
		private long orgID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int minPassLength=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id value.
		/// </summary>
		public long Id
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Gets or sets the PasswordLength value.
		/// </summary>
		public int PasswordLength
		{
			get { return passwordLength; }
			set { passwordLength = value; }
		}

		/// <summary>
		/// Gets or sets the Splcharlen value.
		/// </summary>
		public int Splcharlen
		{
			get { return splcharlen; }
			set { splcharlen = value; }
		}

		/// <summary>
		/// Gets or sets the Numcharlen value.
		/// </summary>
		public int Numcharlen
		{
			get { return numcharlen; }
			set { numcharlen = value; }
		}

		/// <summary>
		/// Gets or sets the ValidityPeriodType value.
		/// </summary>
		public string ValidityPeriodType
		{
			get { return validityPeriodType; }
			set { validityPeriodType = value; }
		}

		/// <summary>
		/// Gets or sets the ValidityPeriod value.
		/// </summary>
		public int ValidityPeriod
		{
			get { return validityPeriod; }
			set { validityPeriod = value; }
		}

		/// <summary>
		/// Gets or sets the PreviousPwdcount value.
		/// </summary>
		public int PreviousPwdcount
		{
			get { return previousPwdcount; }
			set { previousPwdcount = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
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
		/// Gets or sets the MinPassLength value.
		/// </summary>
		public int MinPassLength
		{
			get { return minPassLength; }
			set { minPassLength = value; }
		}


		#endregion
}
}
