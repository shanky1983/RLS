using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class InPatientDischargeType
	{
		#region Fields

		private int dischargeTypeID=0;
		private string dischargeTypeName=String.Empty;
		private int createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private int modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private DateTime expiredDateUntil=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DischargeTypeID value.
		/// </summary>
		public int DischargeTypeID
		{
			get { return dischargeTypeID; }
			set { dischargeTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the DischargeTypeName value.
		/// </summary>
		public string DischargeTypeName
		{
			get { return dischargeTypeName; }
			set { dischargeTypeName = value; }
		}

		/// <summary>
		/// Gets or sets the CreatedBy value.
		/// </summary>
		public int CreatedBy
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
		public int ModifiedBy
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
		/// Gets or sets the ExpiredDateUntil value.
		/// </summary>
		public DateTime ExpiredDateUntil
		{
			get { return expiredDateUntil; }
			set { expiredDateUntil = value; }
		}


		#endregion
}
}
