using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class BillOfMaterials
	{
		#region Fields

		private int billofMaterialID=0;
		private string serviceName=String.Empty;
		private string feeType=String.Empty;
		private int feeTypeID=0;
		private string resourceType=String.Empty;
		private string resourceName=String.Empty;
		private long orgID=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private long seviceID=0;
		private string serviceType=String.Empty;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BillofMaterialID value.
		/// </summary>
		public int BillofMaterialID
		{
			get { return billofMaterialID; }
			set { billofMaterialID = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceName value.
		/// </summary>
		public string ServiceName
		{
			get { return serviceName; }
			set { serviceName = value; }
		}

		/// <summary>
		/// Gets or sets the FeeType value.
		/// </summary>
		public string FeeType
		{
			get { return feeType; }
			set { feeType = value; }
		}

		/// <summary>
		/// Gets or sets the FeeTypeID value.
		/// </summary>
		public int FeeTypeID
		{
			get { return feeTypeID; }
			set { feeTypeID = value; }
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
		/// Gets or sets the ResourceName value.
		/// </summary>
		public string ResourceName
		{
			get { return resourceName; }
			set { resourceName = value; }
		}

		/// <summary>
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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
		/// Gets or sets the SeviceID value.
		/// </summary>
		public long SeviceID
		{
			get { return seviceID; }
			set { seviceID = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceType value.
		/// </summary>
		public string ServiceType
		{
			get { return serviceType; }
			set { serviceType = value; }
		}


		#endregion
}
}
