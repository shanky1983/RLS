using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Widgetmaster
	{
		#region Fields

		private long wID=0;
		private string wName=String.Empty;
		private string wCode=String.Empty;
		private DateTime createdat=DateTime.MaxValue;
		private long createdby=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedby=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the WID value.
		/// </summary>
		public long WID
		{
			get { return wID; }
			set { wID = value; }
		}

		/// <summary>
		/// Gets or sets the WName value.
		/// </summary>
		public string WName
		{
			get { return wName; }
			set { wName = value; }
		}

		/// <summary>
		/// Gets or sets the WCode value.
		/// </summary>
		public string WCode
		{
			get { return wCode; }
			set { wCode = value; }
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
		/// Gets or sets the Createdby value.
		/// </summary>
		public long Createdby
		{
			get { return createdby; }
			set { createdby = value; }
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
		/// Gets or sets the Modifiedby value.
		/// </summary>
		public long Modifiedby
		{
			get { return modifiedby; }
			set { modifiedby = value; }
		}


		#endregion
}
}
