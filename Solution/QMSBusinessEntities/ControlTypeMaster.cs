using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class ControlTypeMaster
	{
		#region Fields

		private int controlTypeID=0;
		private string controlName=String.Empty;
		private string controlCode=String.Empty;
		private string isEnable=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ControlTypeID value.
		/// </summary>
		public int ControlTypeID
		{
			get { return controlTypeID; }
			set { controlTypeID = value; }
		}

		/// <summary>
		/// Gets or sets the ControlName value.
		/// </summary>
		public string ControlName
		{
			get { return controlName; }
			set { controlName = value; }
		}

		/// <summary>
		/// Gets or sets the ControlCode value.
		/// </summary>
		public string ControlCode
		{
			get { return controlCode; }
			set { controlCode = value; }
		}

		/// <summary>
		/// Gets or sets the IsEnable value.
		/// </summary>
		public string IsEnable
		{
			get { return isEnable; }
			set { isEnable = value; }
		}

		/// <summary>
		/// Gets or sets the Createdat value.
		/// </summary>
		public DateTime Createdat
		{
			get { return createdat; }
			set { createdat = value; }
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


		#endregion
}
}
