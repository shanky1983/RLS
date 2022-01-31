using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class BillofMaterialDetails
	{
		#region Fields

		private int billofMaterialDetailsID=0;
		private int billofMaterialID=0;
		private long productID=0;
		private decimal estimatedQty=Decimal.Zero;
		private string estimatedUnit=String.Empty;
		private decimal bufferQty=Decimal.Zero;
		private string bufferUnit=String.Empty;
		private string estimatedDuration=String.Empty;
		private string ceilingLimit=String.Empty;
		private DateTime createdAt=DateTime.MaxValue;
		private long createdBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private long orgID=0;
		private int orgAddressID=0;
		private long parentProductID=0;
		private long investigationID=0;
		private int locationID=0;
		private string description=String.Empty;
		private string recurrentUsage=String.Empty;
		private string feeType=String.Empty;
		private int feeTypeID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BillofMaterialDetailsID value.
		/// </summary>
		public int BillofMaterialDetailsID
		{
			get { return billofMaterialDetailsID; }
			set { billofMaterialDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the BillofMaterialID value.
		/// </summary>
		public int BillofMaterialID
		{
			get { return billofMaterialID; }
			set { billofMaterialID = value; }
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
		/// Gets or sets the EstimatedQty value.
		/// </summary>
		public decimal EstimatedQty
		{
			get { return estimatedQty; }
			set { estimatedQty = value; }
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
		/// Gets or sets the BufferQty value.
		/// </summary>
		public decimal BufferQty
		{
			get { return bufferQty; }
			set { bufferQty = value; }
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
		/// Gets or sets the EstimatedDuration value.
		/// </summary>
		public string EstimatedDuration
		{
			get { return estimatedDuration; }
			set { estimatedDuration = value; }
		}

		/// <summary>
		/// Gets or sets the CeilingLimit value.
		/// </summary>
		public string CeilingLimit
		{
			get { return ceilingLimit; }
			set { ceilingLimit = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public long OrgID
		{
			get { return orgID; }
			set { orgID = value; }
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

		/// <summary>
		/// Gets or sets the LocationID value.
		/// </summary>
		public int LocationID
		{
			get { return locationID; }
			set { locationID = value; }
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
		/// Gets or sets the RecurrentUsage value.
		/// </summary>
		public string RecurrentUsage
		{
			get { return recurrentUsage; }
			set { recurrentUsage = value; }
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
		/// Gets or sets the ResourceServiceTypeName value.
		/// </summary>
		private string _resourceServiceTypeName=String.Empty;
		public string ResourceServiceTypeName
		{
			get { return  _resourceServiceTypeName; }
			set { _resourceServiceTypeName = value; }
		}

		/// <summary>
		/// Gets or sets the ServiceName value.
		/// </summary>
		private string _serviceName=String.Empty;
		public string ServiceName
		{
			get { return  _serviceName; }
			set { _serviceName = value; }
		}

		/// <summary>
		/// Gets or sets the ResourceType value.
		/// </summary>
		private string _resourceType=String.Empty;
		public string ResourceType
		{
			get { return  _resourceType; }
			set { _resourceType = value; }
		}

		/// <summary>
		/// Gets or sets the ResourceName value.
		/// </summary>
		private string _resourceName=String.Empty;
		public string ResourceName
		{
			get { return  _resourceName; }
			set { _resourceName = value; }
		}


		#endregion
}
}
