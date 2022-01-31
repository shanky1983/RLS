using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class InvestigationProductMapping
	{
		#region Fields

		private long invProductMappingID=0;
		private long deviceMappingID=0;
		private long productID=0;
		private decimal estimatedQuantiy=Decimal.Zero;
		private string estimatedUnit=String.Empty;
		private decimal bufferQuantiy=Decimal.Zero;
		private string bufferUnit=String.Empty;
		private string description=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgAddressID=0;
		private int locationID=0;
		private long orgID=0;
		private long parentProductID=0;
		private long investigationID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the InvProductMappingID value.
		/// </summary>
		public long InvProductMappingID
		{
			get { return invProductMappingID; }
			set { invProductMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the DeviceMappingID value.
		/// </summary>
		public long DeviceMappingID
		{
			get { return deviceMappingID; }
			set { deviceMappingID = value; }
		}

		/// <summary>
		/// Gets or sets the ProductID value.
		/// </summary>
		public long ProductID
		{
			get { return productID; }
			set { productID = value; }
		}

		/// <summary>
		/// Gets or sets the EstimatedQuantiy value.
		/// </summary>
		public decimal EstimatedQuantiy
		{
			get { return estimatedQuantiy; }
			set { estimatedQuantiy = value; }
		}

		/// <summary>
		/// Gets or sets the EstimatedUnit value.
		/// </summary>
		public string EstimatedUnit
		{
			get { return estimatedUnit; }
			set { estimatedUnit = value; }
		}

		/// <summary>
		/// Gets or sets the BufferQuantiy value.
		/// </summary>
		public decimal BufferQuantiy
		{
			get { return bufferQuantiy; }
			set { bufferQuantiy = value; }
		}

		/// <summary>
		/// Gets or sets the BufferUnit value.
		/// </summary>
		public string BufferUnit
		{
			get { return bufferUnit; }
			set { bufferUnit = value; }
		}

		/// <summary>
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
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
		/// Gets or sets the LocationID value.
		/// </summary>
		public int LocationID
		{
			get { return locationID; }
			set { locationID = value; }
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
		/// Gets or sets the ParentProductID value.
		/// </summary>
		public long ParentProductID
		{
			get { return parentProductID; }
			set { parentProductID = value; }
		}

		/// <summary>
		/// Gets or sets the InvestigationID value.
		/// </summary>
		public long InvestigationID
		{
			get { return investigationID; }
			set { investigationID = value; }
		}


		#endregion
}
}
