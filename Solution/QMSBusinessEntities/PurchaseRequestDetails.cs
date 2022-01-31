using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class PurchaseRequestDetails
	{
		#region Fields

		private long requestDetailID=0;
		private long purchaseRequestID=0;
		private DateTime requestDate=DateTime.MaxValue;
		private string pRStatus=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private int orgID=0;
		private int orgAddressID=0;
		private int locationID=0;
		private int toLocationID=0;
		private long supplierID=0;
		private long productID=0;
		private string unit=String.Empty;
		private long quantity=0;
		private int raiseOrgID=0;
		private int raiseOrgAddID=0;
		private long parentProductID=0;
		private string description=String.Empty;
		private long pOID=0;
		private long poDetailsID=0;
		private long intendDetailID=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the RequestDetailID value.
		/// </summary>
		public long RequestDetailID
		{
			get { return requestDetailID; }
			set { requestDetailID = value; }
		}

		/// <summary>
		/// Gets or sets the PurchaseRequestID value.
		/// </summary>
		public long PurchaseRequestID
		{
			get { return purchaseRequestID; }
			set { purchaseRequestID = value; }
		}

		/// <summary>
		/// Gets or sets the RequestDate value.
		/// </summary>
		public DateTime RequestDate
		{
			get { return requestDate; }
			set { requestDate = value; }
		}

		/// <summary>
		/// Gets or sets the PRStatus value.
		/// </summary>
		public string PRStatus
		{
			get { return pRStatus; }
			set { pRStatus = value; }
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
		/// Gets or sets the OrgID value.
		/// </summary>
		public int OrgID
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
		/// Gets or sets the LocationID value.
		/// </summary>
		public int LocationID
		{
			get { return locationID; }
			set { locationID = value; }
		}

		/// <summary>
		/// Gets or sets the ToLocationID value.
		/// </summary>
		public int ToLocationID
		{
			get { return toLocationID; }
			set { toLocationID = value; }
		}

		/// <summary>
		/// Gets or sets the SupplierID value.
		/// </summary>
		public long SupplierID
		{
			get { return supplierID; }
			set { supplierID = value; }
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
		/// Gets or sets the Unit value.
		/// </summary>
		public string Unit
		{
			get { return unit; }
			set { unit = value; }
		}

		/// <summary>
		/// Gets or sets the Quantity value.
		/// </summary>
		public long Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}

		/// <summary>
		/// Gets or sets the RaiseOrgID value.
		/// </summary>
		public int RaiseOrgID
		{
			get { return raiseOrgID; }
			set { raiseOrgID = value; }
		}

		/// <summary>
		/// Gets or sets the RaiseOrgAddID value.
		/// </summary>
		public int RaiseOrgAddID
		{
			get { return raiseOrgAddID; }
			set { raiseOrgAddID = value; }
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
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Gets or sets the POID value.
		/// </summary>
		public long POID
		{
			get { return pOID; }
			set { pOID = value; }
		}

		/// <summary>
		/// Gets or sets the PoDetailsID value.
		/// </summary>
		public long PoDetailsID
		{
			get { return poDetailsID; }
			set { poDetailsID = value; }
		}

		/// <summary>
		/// Gets or sets the IntendDetailID value.
		/// </summary>
		public long IntendDetailID
		{
			get { return intendDetailID; }
			set { intendDetailID = value; }
		}

		/// <summary>
		/// Gets or sets the LocationName value.
		/// </summary>
		string _locationname;
		public string LocationName
		{
			get { return _locationname; }
			set { _locationname = value; }
		}

		/// <summary>
		/// Gets or sets the ToLocationName value.
		/// </summary>
		string _tolocationname;
		public string ToLocationName
		{
			get { return _tolocationname; }
			set { _tolocationname = value; }
		}


		#endregion
}
}
