using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PatientCondition
	{
		#region Fields

		private int conditionID=0;
		private string condition=String.Empty;
		private string bGColor=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ConditionID value.
		/// </summary>
		public int ConditionID
		{
			get { return conditionID; }
			set { conditionID = value; }
		}

		/// <summary>
		/// Gets or sets the Condition value.
		/// </summary>
		public string Condition
		{
			get { return condition; }
			set { condition = value; }
		}

		/// <summary>
		/// Gets or sets the BGColor value.
		/// </summary>
		public string BGColor
		{
			get { return bGColor; }
			set { bGColor = value; }
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


		#endregion
}
}
