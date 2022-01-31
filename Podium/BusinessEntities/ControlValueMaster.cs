using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class ControlValueMaster
	{
		#region Fields

		private long controlValueID=0;
		private long controlMappingID=0;
		private string controlValue=String.Empty;
		private string isTableReference=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ControlValueID value.
		/// </summary>
		public long ControlValueID
		{
			get { return controlValueID; }
			set { controlValueID = value; }
		}

		/// <summary>
		/// Gets or sets the ControlMappingID value.
		/// </summary>
		public long ControlMappingID
		{
			get { return controlMappingID; }
			set { controlMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the ControlValue value.
		/// </summary>
		public string ControlValue
		{
			get { return controlValue; }
			set { controlValue = value; }
		}

		/// <summary>
		/// Gets or sets the IsTableReference value.
		/// </summary>
		public string IsTableReference
		{
			get { return isTableReference; }
			set { isTableReference = value; }
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
