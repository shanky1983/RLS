using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class Complication
	{
		#region Fields

		private int complicationID=0;
		private string complicationName=String.Empty;
		private string complicationDesc=String.Empty;
		private string complicationType=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int parentID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ComplicationID value.
		/// </summary>
		public int ComplicationID
		{
			get { return complicationID; }
			set { complicationID = value; }
		}

		/// <summary>
		/// Gets or sets the ComplicationName value.
		/// </summary>
		public string ComplicationName
		{
			get { return complicationName; }
			set { complicationName = value; }
		}

		/// <summary>
		/// Gets or sets the ComplicationDesc value.
		/// </summary>
		public string ComplicationDesc
		{
			get { return complicationDesc; }
			set { complicationDesc = value; }
		}

		/// <summary>
		/// Gets or sets the ComplicationType value.
		/// </summary>
		public string ComplicationType
		{
			get { return complicationType; }
			set { complicationType = value; }
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
		/// Gets or sets the ParentID value.
		/// </summary>
		public int ParentID
		{
			get { return parentID; }
			set { parentID = value; }
		}


		#endregion
}
}
