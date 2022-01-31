using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Vitals
	{
		#region Fields

		private int vitalsID=0;
		private string vitalsName=String.Empty;
		private string vitalsDescription=String.Empty;
		private string vitalsGroup=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string category=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the VitalsID value.
		/// </summary>
		public int VitalsID
		{
			get { return vitalsID; }
			set { vitalsID = value; }
		}

		/// <summary>
		/// Gets or sets the VitalsName value.
		/// </summary>
		public string VitalsName
		{
			get { return vitalsName; }
			set { vitalsName = value; }
		}

		/// <summary>
		/// Gets or sets the VitalsDescription value.
		/// </summary>
		public string VitalsDescription
		{
			get { return vitalsDescription; }
			set { vitalsDescription = value; }
		}

		/// <summary>
		/// Gets or sets the VitalsGroup value.
		/// </summary>
		public string VitalsGroup
		{
			get { return vitalsGroup; }
			set { vitalsGroup = value; }
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
		/// Gets or sets the Category value.
		/// </summary>
		public string Category
		{
			get { return category; }
			set { category = value; }
		}


		#endregion
}
}
