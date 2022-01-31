using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class SchedulableResource
	{
		#region Fields

		private long resourceTemplateID=0;
		private long resourceID=0;
		private string resourceType=String.Empty;
		private int orgID=0;
		private int scheduleTemplateID=0;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgAddressID=0;
		private string additionalContextKey=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ResourceTemplateID value.
		/// </summary>
		public long ResourceTemplateID
		{
			get { return resourceTemplateID; }
			set { resourceTemplateID = value; }
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
		/// Gets or sets the ResourceType value.
		/// </summary>
		public string ResourceType
		{
			get { return resourceType; }
			set { resourceType = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
		{
			get { return orgID; }
			set { orgID = value; }
		}

		/// <summary>
		/// Gets or sets the ScheduleTemplateID value.
		/// </summary>
		public int ScheduleTemplateID
		{
			get { return scheduleTemplateID; }
			set { scheduleTemplateID = value; }
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
		/// Gets or sets the OrgAddressID value.
		/// </summary>
		public int OrgAddressID
		{
			get { return orgAddressID; }
			set { orgAddressID = value; }
		}

		/// <summary>
		/// Gets or sets the AdditionalContextKey value.
		/// </summary>
		public string AdditionalContextKey
		{
			get { return additionalContextKey; }
			set { additionalContextKey = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintName value.
		/// </summary>
		private string _complaintName=String.Empty;
		public string ComplaintName
		{
			get { return  _complaintName; }
			set { _complaintName = value; }
		}

		/// <summary>
		/// Gets or sets the ComplaintDesc value.
		/// </summary>
		private string _complaintDesc=String.Empty;
		public string ComplaintDesc
		{
			get { return  _complaintDesc; }
			set { _complaintDesc = value; }
		}


		#endregion
}
}
