using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class SurgeryResourceList
	{
		#region Fields

		private long surgeryResourceListID=0;
		private long surgeryResourcePlanID=0;
		private string resourceType=String.Empty;
		private long resourceID=0;
		private string resourceName=String.Empty;
		private string status=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private string resourceRole=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the SurgeryResourceListID value.
		/// </summary>
		public long SurgeryResourceListID
		{
			get { return surgeryResourceListID; }
			set { surgeryResourceListID = value; }
		}

		/// <summary>
		/// Gets or sets the SurgeryResourcePlanID value.
		/// </summary>
		public long SurgeryResourcePlanID
		{
			get { return surgeryResourcePlanID; }
			set { surgeryResourcePlanID = value; }
		}

		/// <summary>
		/// Gets or sets the ResourceType value.
		/// </summary>
		public string ResourceType
		{
			get { return resourceType; }
			set { resourceType = value; }
		}

		/// <summary>
		/// Gets or sets the ResourceID value.
		/// </summary>
		public long ResourceID
		{
			get { return resourceID; }
			set { resourceID = value; }
		}

		/// <summary>
		/// Gets or sets the ResourceName value.
		/// </summary>
		public string ResourceName
		{
			get { return resourceName; }
			set { resourceName = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
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

		/// <summary>
		/// Gets or sets the ResourceRole value.
		/// </summary>
		public string ResourceRole
		{
			get { return resourceRole; }
			set { resourceRole = value; }
		}


		#endregion
}
}
