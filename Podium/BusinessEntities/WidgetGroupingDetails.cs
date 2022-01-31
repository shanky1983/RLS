using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class WidgetGroupingDetails
	{
		#region Fields

		private long detailedID=0;
		private string detailedName=String.Empty;
		private long wID=0;
		private string active=String.Empty;
		private string icon=String.Empty;
		private string wGCode=String.Empty;
		private bool showReport=false;
		private DateTime createdat=DateTime.MaxValue;
		private long createdby=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedby=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the DetailedID value.
		/// </summary>
		public long DetailedID
		{
			get { return detailedID; }
			set { detailedID = value; }
		}

		/// <summary>
		/// Gets or sets the DetailedName value.
		/// </summary>
		public string DetailedName
		{
			get { return detailedName; }
			set { detailedName = value; }
		}

		/// <summary>
		/// Gets or sets the WID value.
		/// </summary>
		public long WID
		{
			get { return wID; }
			set { wID = value; }
		}

		/// <summary>
		/// Gets or sets the Active value.
		/// </summary>
		public string Active
		{
			get { return active; }
			set { active = value; }
		}

		/// <summary>
		/// Gets or sets the Icon value.
		/// </summary>
		public string Icon
		{
			get { return icon; }
			set { icon = value; }
		}

		/// <summary>
		/// Gets or sets the WGCode value.
		/// </summary>
		public string WGCode
		{
			get { return wGCode; }
			set { wGCode = value; }
		}

		/// <summary>
		/// Gets or sets the ShowReport value.
		/// </summary>
		public bool ShowReport
		{
			get { return showReport; }
			set { showReport = value; }
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
