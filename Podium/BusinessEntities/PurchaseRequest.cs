using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class PurchaseRequest
	{
		#region Fields

		private long purchaseRequestID=0;
		private DateTime requestDate=DateTime.MaxValue;
		private string purchaseRequestNo=String.Empty;
		private long supplierID=0;
		private string status=String.Empty;
		private long createdBy=0;
		private DateTime createdAt=DateTime.MaxValue;
		private long modifiedBy=0;
		private DateTime modifiedAt=DateTime.MaxValue;
		private string comments=String.Empty;
		private int orgID=0;
		private int orgAddressID=0;
		private int locationID=0;
		private int toLocationID=0;
		private int raiseOrgID=0;
		private int raiseOrgAddID=0;
		private long intendID=0;

		#endregion

		#region Properties
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
		/// Gets or sets the PurchaseRequestNo value.
		/// </summary>
		public string PurchaseRequestNo
		{
			get { return purchaseRequestNo; }
			set { purchaseRequestNo = value; }
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
		/// Gets or sets the Status value.
		/// </summary>
		public string Status
		{
			get { return status; }
			set { status = value; }
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
		/// Gets or sets the Comments value.
		/// </summary>
		public string Comments
		{
			get { return comments; }
			set { comments = value; }
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
		/// Gets or sets the IntendID value.
		/// </summary>
		public long IntendID
		{
			get { return intendID; }
			set { intendID = value; }
		}

		/// <summary>
		/// Gets or sets the LocationName value.
		/// </summary>
		private string _locationName=String.Empty;
		public string LocationName
		{
			get { return  _locationName; }
			set { _locationName = value; }
		}

		/// <summary>
		/// Gets or sets the ToLocationName value.
		/// </summary>
		private string _toLocationName=String.Empty;
		public string ToLocationName
		{
			get { return  _toLocationName; }
			set { _toLocationName = value; }
		}


		#endregion
}
}
